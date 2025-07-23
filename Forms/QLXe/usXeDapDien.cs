using DoAn.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Forms.QLXe
{
    public partial class usXeDapDien : UserControl
    {
        public usXeDapDien()
        {
            InitializeComponent();
            loadDanhSachXe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuThemXe phieuThemXeForm = new frmPhieuThemXe();
            phieuThemXeForm.ShowDialog();
            loadDanhSachXe();
        }

        public void loadDanhSachXe()
        {
            using (var context = new DataDbContext())
            {
                BindingSource xeDapDienBindingSource = new BindingSource();

                var danhSach = context.ThongTinXe
                    .Where(d => d.maDongXe == "2")
                    .Select(x => new
                    {
                        x.maXe,
                        x.tenXe,
                        x.mauSac,
                        x.dungLuongAcQuy,
                        x.soBinhAcQuy,
                        gia = x.giaBan,
                        x.hinhAnh,

                        // Tính tồn kho: tổng nhập - số hóa đơn bán ra
                        soLuong =
                            (context.TonXe
                                .Where(t => t.maXe == x.maXe)
                                .Sum(t => (int?)t.soLuong) ?? 0)
                            -
                            (context.ChiTietHoaDon
                                .Where(h => h.maXe == x.maXe)
                                .Count())
                    })
                    .ToList();

                xeDapDienBindingSource.DataSource = danhSach;
                dgvDSXeDapDien.DataSource = xeDapDienBindingSource;

                // Tự động co giãn cột
                dgvDSXeDapDien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Định dạng giá
                if (dgvDSXeDapDien.Columns.Contains("gia"))
                    dgvDSXeDapDien.Columns["gia"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";

                if (dgvDSXeDapDien.Columns.Contains("soLuong"))
                {
                    dgvDSXeDapDien.Columns["soLuong"]!.HeaderText = "Số Lượng";
                    dgvDSXeDapDien.Columns["soLuong"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dgvDSXeDapDien.Columns["maXe"]!.HeaderText = "Mã Xe";
                dgvDSXeDapDien.Columns["tenXe"]!.HeaderText = "Tên Xe";
                dgvDSXeDapDien.Columns["mauSac"]!.HeaderText = "Màu Sắc";
                dgvDSXeDapDien.Columns["dungLuongAcQuy"]!.HeaderText = "Dung Lượng Ắc Quy";
                dgvDSXeDapDien.Columns["soBinhAcQuy"]!.HeaderText = "Số Bình Ắc Quy";
                dgvDSXeDapDien.Columns["gia"]!.HeaderText = "Giá Bán";
                dgvDSXeDapDien.Columns["hinhAnh"]!.HeaderText = "Hình Ảnh";

                dgvDSXeDapDien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSXeDapDien.CurrentRow == null || !dgvDSXeDapDien.Columns.Contains("maXe"))
            {
                MessageBox.Show("Vui lòng chọn một xe cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maXe = dgvDSXeDapDien.CurrentRow.Cells["maXe"]!.Value!.ToString()!;
            if (string.IsNullOrEmpty(maXe))
            {
                MessageBox.Show("Không tìm thấy mã xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DataDbContext())
            {
                var xeCanSua = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                if (xeCanSua == null)
                {
                    MessageBox.Show("Không tìm thấy xe trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    xeCanSua.tenXe = txtTenXe.Text.Trim();
                    xeCanSua.mauSac = txtMauSac.Text.Trim();
                    xeCanSua.dungLuongAcQuy = txtDungLuongAcQuy.Text.Trim();
                    xeCanSua.soBinhAcQuy = txtSoBinhAcQuy.Text.Trim();

                    string giaText = txtGia.Text.Replace("VNĐ", "").Replace(",", "").Trim();
                    xeCanSua.giaBan = decimal.TryParse(giaText, out decimal giaMoi) ? giaMoi : 0;

                    context.SaveChanges();
                    MessageBox.Show("Sửa thông tin xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachXe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSXeDapDien.CurrentRow == null || !dgvDSXeDapDien.Columns.Contains("maXe"))
            {
                MessageBox.Show("Vui lòng chọn một xe để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maXe = dgvDSXeDapDien.CurrentRow.Cells["maXe"]!.Value!.ToString()!;
            if (string.IsNullOrEmpty(maXe))
            {
                MessageBox.Show("Không tìm thấy mã xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            using (var context = new DataDbContext())
            {
                try
                {
                    var xeCanXoa = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                    if (xeCanXoa == null)
                    {
                        MessageBox.Show("Không tìm thấy xe trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var chiTietHoaDons = context.ChiTietHoaDon.Where(c => c.maXe == maXe).ToList();
                    if (chiTietHoaDons.Any()) context.ChiTietHoaDon.RemoveRange(chiTietHoaDons);

                    var baoHanhs = context.BaoHanh.Where(b => b.maXe == maXe).ToList();
                    if (baoHanhs.Any()) context.BaoHanh.RemoveRange(baoHanhs);

                    var tonXes = context.TonXe.Where(t => t.maXe == maXe).ToList();
                    if (tonXes.Any()) context.TonXe.RemoveRange(tonXes);

                    context.ThongTinXe.Remove(xeCanXoa);
                    context.SaveChanges();
                    MessageBox.Show("Xóa xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachXe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa xe: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenXe.Clear();
            txtGia.Clear();
            txtMauSac.Clear();
            txtDungLuongAcQuy.Clear();
            txtSoBinhAcQuy.Clear();
            if (picAnhXe.Image != null)
            {
                picAnhXe.Image.Dispose();
                picAnhXe.Image = null;
            }
            loadDanhSachXe();
            dgvDSXeDapDien.ClearSelection();
            txtSoLuong.Clear();
        }

        private void dgvDSXeDapDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSXeDapDien.Rows.Count)
            {
                DataGridViewRow row = dgvDSXeDapDien.Rows[e.RowIndex];

                txtTenXe.Text = row.Cells["tenXe"]?.Value?.ToString() ?? "";
                txtGia.Text = Convert.ToDecimal(row.Cells["gia"]?.Value ?? 0).ToString("#,##0 'VNĐ'");
                txtMauSac.Text = row.Cells["mauSac"]?.Value?.ToString() ?? "";
                txtDungLuongAcQuy.Text = row.Cells["dungLuongAcQuy"]?.Value?.ToString() ?? "";
                txtSoBinhAcQuy.Text = row.Cells["soBinhAcQuy"]?.Value?.ToString() ?? "";
                txtSoLuong.Text = row.Cells["soLuong"]?.Value?.ToString() ?? "0";
                string imageName = row.Cells["HinhAnh"]!.Value!.ToString()!;
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if (!string.IsNullOrEmpty(imageName))
                {
                    string imagePath = Path.Combine(projectDirectory, "Resources", "hinhAnh", imageName);
                    if (File.Exists(imagePath))
                    {
                        try
                        {
                            picAnhXe.Image?.Dispose();
                            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                            {
                                picAnhXe.Image = Image.FromStream(fs);
                            }
                        }
                        catch (Exception ex)
                        {
                            picAnhXe.Image = null;
                            MessageBox.Show("Lỗi khi load ảnh: " + ex.Message, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        picAnhXe.Image = null;
                        MessageBox.Show("Không tìm thấy ảnh: " + imagePath, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    picAnhXe.Image = null;
                }
            }
        }

        
    }
}
