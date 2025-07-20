using DoAn1.Data_Access_Layer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn1.Forms.QLKhachHang
{
    public partial class usKhachHang : UserControl
    {
        public usKhachHang()
        {
            InitializeComponent();
            loadDanhSachKhachHang();
        }

        private void loadDanhSachKhachHang()
        {
            using (var context = new DataDbContext())
            {
                var danhSach = context.KhachHang.ToList();

                dgvDSKhachHang.DataSource = danhSach;

                // Tự động co giãn cột theo nội dung
                dgvDSKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Ẩn cột navigation không cần hiển thị
                if (dgvDSKhachHang.Columns.Contains("HoaDons"))
                {
                    dgvDSKhachHang.Columns["HoaDons"]!.Visible = false;
                }

                // Căn giữa header và không cho header xuống dòng
                dgvDSKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDSKhachHang.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuKhachHang phieuKhachHangForm = new frmPhieuKhachHang();
            phieuKhachHangForm.ShowDialog();
            loadDanhSachKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataDbContext())
            {
                var khachHang = context.KhachHang.FirstOrDefault(kh => kh.maKhachHang == maKH);
                if (khachHang == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                khachHang.hoTen = txtHoTen.Text.Trim();
                khachHang.diaChi = txtDiaChi.Text.Trim();
                khachHang.soDienThoai = txtSoDienThoai.Text.Trim();
                khachHang.email = txtEmail.Text.Trim();

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = dgvDSKhachHang.CurrentRow.Cells["maKhachHang"]!.Value!.ToString();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Không tìm thấy mã khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            using (var context = new DataDbContext())
            {
                try
                {
                    var khachHang = context.KhachHang.FirstOrDefault(kh => kh.maKhachHang == maKH);
                    if (khachHang == null)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var hoaDons = context.HoaDon.Where(hd => hd.maKhachHang == maKH).ToList();
                    if (hoaDons.Any())
                        context.HoaDon.RemoveRange(hoaDons);

                    context.KhachHang.Remove(khachHang);
                    context.SaveChanges();

                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khách hàng: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenKH = txtTimKiemKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataDbContext())
            {
                var ketQua = context.KhachHang
                                    .Where(kh => kh.hoTen.Contains(tenKH))
                                    .ToList();

                if (ketQua.Any())
                {
                    dgvDSKhachHang.DataSource = ketQua;

                    if (dgvDSKhachHang.Columns.Contains("HoaDons"))
                    {
                        dgvDSKhachHang.Columns["HoaDons"]!.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng có tên chứa: " + tenKH, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDSKhachHang.DataSource = null;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtTimKiemKhachHang.Clear();

            loadDanhSachKhachHang();
            dgvDSKhachHang.ClearSelection();
        }

        private void dgvDSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSKhachHang.Rows.Count)
            {
                DataGridViewRow row = dgvDSKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["maKhachHang"]?.Value?.ToString() ?? "";
                txtHoTen.Text = row.Cells["hoTen"]?.Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["diaChi"]?.Value?.ToString() ?? "";
                txtSoDienThoai.Text = row.Cells["soDienThoai"]?.Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["email"]?.Value?.ToString() ?? "";
            }
        }
    }
}
