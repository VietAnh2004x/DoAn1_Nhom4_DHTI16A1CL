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

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLHoaDon
{
    public partial class usHoaDon : UserControl
    {
        public usHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            using (var context = new DataDbContext())
            {
                var data = from hd in context.HoaDon
                           join kh in context.KhachHang on hd.maKhachHang equals kh.maKhachHang
                           join tk in context.TaiKhoan on hd.tenTaiKhoan equals tk.tenTaiKhoan
                           join nv in context.NhanVien on tk.tenTaiKhoan equals nv.tenTaiKhoan
                           select new
                           {
                               MaHD = hd.maHoaDon,
                               TenKhachHang = kh.hoTen,
                               TenNhanVien = nv.hoTen,
                               NgayLap = hd.ngayLap,
                               TongTien = hd.tongTien
                           };

                dgvDSHoaDon.DataSource = data.ToList();

                dgvDSHoaDon.Columns["TongTien"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuHoaDon frmPhieuHoaDon = new frmPhieuHoaDon();
            if (frmPhieuHoaDon.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm hóa đơn thành công!");
            else
                MessageBox.Show("Thêm hóa đơn thất bại!");
        }

        private void dgvDSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số dòng hợp lệ
            {
                DataGridViewRow row = dgvDSHoaDon.Rows[e.RowIndex];

                // Giả sử bạn có các TextBox với tên:
                // txtMaHD, txtTenKH, txtTenNV, txtNgayLap, txtTongTien

                txtMaHoaDon.Text = row.Cells["MaHD"].Value?.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value?.ToString();

                // Format ngày lập (nếu cần)
                if (DateTime.TryParse(row.Cells["NgayLap"].Value?.ToString(), out DateTime ngayLap))
                    txtNgayLap.Text = ngayLap.ToString("dd/MM/yyyy");
                else
                    txtNgayLap.Text = "";

                // Tổng tiền định dạng số
                if (decimal.TryParse(row.Cells["TongTien"].Value?.ToString(), out decimal tongTien))
                    txtTongTien.Text = tongTien.ToString("#,##0 'VNĐ'");
                else
                    txtTongTien.Text = "";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemHoaDon.Text.Trim().ToLower(); // textbox tìm kiếm

            using (var context = new DataDbContext())
            {
                var ketQua = from hd in context.HoaDon
                             join kh in context.KhachHang on hd.maKhachHang equals kh.maKhachHang
                             join tk in context.TaiKhoan on hd.tenTaiKhoan equals tk.tenTaiKhoan
                             join nv in context.NhanVien on tk.tenTaiKhoan equals nv.tenTaiKhoan
                             where hd.maHoaDon.ToLower().Contains(tuKhoa)
                                || kh.hoTen.ToLower().Contains(tuKhoa)
                             select new
                             {
                                 MaHD = hd.maHoaDon,
                                 TenKhachHang = kh.hoTen,
                                 TenNhanVien = nv.hoTen,
                                 NgayLap = hd.ngayLap,
                                 TongTien = hd.tongTien
                             };

                dgvDSHoaDon.DataSource = ketQua.ToList();
                dgvDSHoaDon.Columns["TongTien"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHoaDon.Text.Trim();

            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataDbContext())
            {
                var hoaDon = context.HoaDon.FirstOrDefault(hd => hd.maHoaDon == maHD);

                if (hoaDon == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tìm mã khách hàng dựa vào tên khách hàng (nếu cần)
                var khach = context.KhachHang.FirstOrDefault(k => k.hoTen == txtTenKhachHang.Text.Trim());
                if (khach == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tìm tài khoản dựa vào tên nhân viên (nếu đang nhập họ tên)
                var nhanVien = (from tk in context.TaiKhoan
                                join nv in context.NhanVien on tk.tenTaiKhoan equals nv.tenTaiKhoan
                                where nv.hoTen == txtTenNhanVien.Text.Trim()
                                select tk).FirstOrDefault();

                if (nhanVien == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gán lại các giá trị
                hoaDon.maKhachHang = khach.maKhachHang;
                hoaDon.tenTaiKhoan = nhanVien.tenTaiKhoan;

                if (DateTime.TryParse(txtNgayLap.Text, out DateTime ngayLap))
                    hoaDon.ngayLap = ngayLap;
                else
                    hoaDon.ngayLap = DateTime.Now;

                if (decimal.TryParse(txtTongTien.Text.Replace("VNĐ", "").Replace(",", "").Trim(), out decimal tongTien))
                    hoaDon.tongTien = tongTien;

                context.SaveChanges();

                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Gợi ý: Gọi lại hàm load danh sách nếu có
            LoadHoaDon();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Clear();
            txtTenKhachHang.Clear();
            txtTenNhanVien.Clear();
            txtNgayLap.Clear();
            txtTongTien.Clear();
            txtTimKiemHoaDon.Clear();

            // Load lại danh sách hóa đơn
            LoadHoaDon();

            // Đặt lại focus nếu cần
            txtTimKiemHoaDon.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHoaDon.Text.Trim();

            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn {maHD} không?",
                                         "Xác nhận xóa",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var context = new DataDbContext())
                {
                    var hoaDon = context.HoaDon.FirstOrDefault(hd => hd.maHoaDon == maHD);

                    if (hoaDon == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Nếu có ràng buộc, xóa ChiTietHoaDon trước
                    var chiTiet = context.ChiTietHoaDon.Where(ct => ct.maHoaDon == maHD).ToList();
                    if (chiTiet.Any())
                        context.ChiTietHoaDon.RemoveRange(chiTiet);

                    // Nếu có bảo hành thì xóa tiếp
                    var baoHanhs = context.BaoHanh.Where(bh => bh.maHoaDon == maHD).ToList();
                    if (baoHanhs.Any())
                        context.BaoHanh.RemoveRange(baoHanhs);

                    context.HoaDon.Remove(hoaDon);
                    context.SaveChanges();
                }

                MessageBox.Show("Đã xóa hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon(); // Tải lại danh sách sau khi xóa
                btnLamMoi_Click(sender, e); // Reset form nếu muốn
            }
        }
    }
}
