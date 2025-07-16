using DoAn.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    public partial class usXeDapDien : UserControl
    {
        public usXeDapDien()
        {
            InitializeComponent();
            using (var context = new DataDbContext())
            {
                loadDanhSachXe();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuThemXe phieuThemXeForm = new frmPhieuThemXe();
            if (phieuThemXeForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm xe đạp điện thành công!");
            else
                MessageBox.Show("Thêm xe đạp điện thất bại!");
        }
        public void loadDanhSachXe()
        {
            using (var context = new DataDbContext())
            {
                BindingSource xeDapDienBindingSource = new BindingSource();
                xeDapDienBindingSource.DataSource = context.ThongTinXe.Where(d => d.maDongXe == "2").ToList();
                dgvDSXeDapDien.DataSource = xeDapDienBindingSource;
                dgvDSXeDapDien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvDSXeDapDien.Columns["gia"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";
                dgvDSXeDapDien.Columns["MaDongXe"]!.Visible = false;
                dgvDSXeDapDien.Columns["DaiLy"]!.Visible = false;
                dgvDSXeDapDien.Columns["DongXe"]!.Visible = false;
                dgvDSXeDapDien.Columns["ChiTietHoaDons"]!.Visible = false;
                dgvDSXeDapDien.Columns["BaoHanhs"]!.Visible = false;
                dgvDSXeDapDien.Columns["HinhAnh"]!.Visible = false;
                dgvDSXeDapDien.Columns["TonXes"]!.Visible = false;
            }

        }
        private void dgvDSXeDapDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSXeDapDien.Rows.Count)
            {
                DataGridViewRow row = dgvDSXeDapDien.Rows[e.RowIndex];

                // Gán thông tin lên textbox
                txtTenXe.Text = row.Cells["tenXe"]?.Value?.ToString() ?? "";
                txtGia.Text = Convert.ToDecimal(row.Cells["gia"]?.Value ?? 0).ToString("#,##0 'VNĐ'");
                txtMauSac.Text = row.Cells["mauSac"]?.Value?.ToString() ?? "";
                txtDungLuongAcQuy.Text = row.Cells["dungLuongAcQuy"]?.Value?.ToString() ?? "";
                txtSoBinhAcQuy.Text = row.Cells["soBinhAcQuy"]?.Value?.ToString() ?? "";

                // Tên file ảnh (ví dụ A105A.jpg)
                string imageName = row.Cells["HinhAnh"]?.Value?.ToString();

                // Đường dẫn đầy đủ đến thư mục chứa ảnh
                string imageFolder = @"C:\Users\admin\OneDrive\Máy tính\DoAn\HinhAnh";
                string imagePath = Path.Combine(imageFolder, imageName);

                // Xử lý hiển thị ảnh
                if (!string.IsNullOrEmpty(imageName) && File.Exists(imagePath))
                {
                    try
                    {
                        // Giải phóng ảnh cũ
                        picAnhXe.Image?.Dispose();

                        // Load ảnh mới từ stream để tránh lỗi "file bị khóa" hoặc định dạng sai
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            picAnhXe.Image = Image.FromStream(fs);
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        picAnhXe.Image = null;
                        MessageBox.Show("Ảnh bị lỗi hoặc không đúng định dạng: " + imagePath, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        picAnhXe.Image = null;
                        MessageBox.Show("Lỗi khi mở ảnh: " + ex.Message, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    picAnhXe.Image = null;
                    MessageBox.Show("Không tìm thấy ảnh: " + imagePath, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn xe trong DataGridView hay chưa
            if (dgvDSXeDapDien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một xe cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã xe từ dòng được chọn
            string maXe = dgvDSXeDapDien.CurrentRow.Cells["maXe"]?.Value?.ToString();
            if (string.IsNullOrEmpty(maXe))
            {
                MessageBox.Show("Không tìm thấy mã xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DataDbContext())
            {
                // Tìm xe trong database theo mã xe
                var xeCanSua = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                if (xeCanSua == null)
                {
                    MessageBox.Show("Không tìm thấy xe trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Cập nhật thông tin từ TextBox vào xe
                    xeCanSua.tenXe = txtTenXe.Text.Trim();
                    xeCanSua.mauSac = txtMauSac.Text.Trim();
                    xeCanSua.dungLuongAcQuy = txtDungLuongAcQuy.Text.Trim();
                    xeCanSua.soBinhAcQuy = txtSoBinhAcQuy.Text.Trim();

                    // Xử lý giá (loại bỏ chữ VNĐ và dấu phẩy)
                    string giaText = txtGia.Text.Replace("VNĐ", "").Replace(",", "").Trim();
                    if (decimal.TryParse(giaText, out decimal giaMoi))
                    {
                        xeCanSua.gia = giaMoi;
                    }
                    else
                    {
                        xeCanSua.gia = 0;  // Hoặc bạn có thể báo lỗi nếu cần
                    }

                    // Nếu bạn có TextBox cho link hình ảnh (nếu không có thì bỏ đoạn này)
                    // Giả sử bạn thêm txtHinhAnh
                    // xeCanSua.HinhAnh = txtHinhAnh.Text.Trim();

                    // Lưu thay đổi vào database
                    context.SaveChanges();

                    MessageBox.Show("Sửa thông tin xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load lại danh sách xe
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
            if (dgvDSXeDapDien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một xe để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maXe = dgvDSXeDapDien.CurrentRow.Cells["maXe"]?.Value?.ToString();
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
                    if (chiTietHoaDons.Any())
                        context.ChiTietHoaDon.RemoveRange(chiTietHoaDons);
                    var baoHanhs = context.BaoHanh.Where(b => b.maXe == maXe).ToList();
                    if (baoHanhs.Any())
                        context.BaoHanh.RemoveRange(baoHanhs);
                    var tonXes = context.TonXe.Where(t => t.maXe == maXe).ToList();
                    if (tonXes.Any())
                        context.TonXe.RemoveRange(tonXes);
                    context.ThongTinXe.Remove(xeCanXoa);
                    context.SaveChanges();
                    MessageBox.Show("Xóa xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachXe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa xe: " + ex.InnerException?.Message ?? ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            picAnhXe.Image = null;
            loadDanhSachXe();
            dgvDSXeDapDien.ClearSelection();
        }

    }
}

