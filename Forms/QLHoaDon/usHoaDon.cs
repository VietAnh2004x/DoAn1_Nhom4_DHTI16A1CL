using DoAn1.Data_Access_Layer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn1.Forms.QLHoaDon
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
                           join cthd in context.ChiTietHoaDon on hd.maHoaDon equals cthd.maHoaDon into cthdGroup
                           from cthd in cthdGroup.DefaultIfEmpty()
                           join xe in context.ThongTinXe on cthd.maXe equals xe.maXe into xeGroup
                           from xe in xeGroup.DefaultIfEmpty()
                           select new
                           {
                               MaHD = hd.maHoaDon,
                               TenKhachHang = kh.hoTen,
                               TenNhanVien = nv.hoTen,
                               NgayLap = hd.ngayLap,
                               TongTien = hd.tongTien,
                               GhiChuKhuyenMai = cthd == null ? "" : cthd.ghiChuKhuyenMai,
                               GiaBan = xe == null ? 0 : xe.giaBan
                           };

                dgvDSHoaDon.DataSource = data.ToList();

                // Định dạng cột tiền
                if (dgvDSHoaDon.Columns["TongTien"] != null)
                {
                    dgvDSHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                    dgvDSHoaDon.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgvDSHoaDon.Columns["GiaBan"] != null)
                {
                    dgvDSHoaDon.Columns["GiaBan"].HeaderText = "Giá Bán";
                    dgvDSHoaDon.Columns["GiaBan"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                    dgvDSHoaDon.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgvDSHoaDon.Columns["GhiChuKhuyenMai"] != null)
                {
                    dgvDSHoaDon.Columns["GhiChuKhuyenMai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuHoaDon frmPhieuHoaDon = new frmPhieuHoaDon();
            if (frmPhieuHoaDon.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm hóa đơn thành công!");
            else
                MessageBox.Show("Thêm hóa đơn thất bại!");
            LoadHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemHoaDon.Text.Trim().ToLower();

            using (var context = new DataDbContext())
            {
                var ketQua = from hd in context.HoaDon
                             join kh in context.KhachHang on hd.maKhachHang equals kh.maKhachHang
                             join tk in context.TaiKhoan on hd.tenTaiKhoan equals tk.tenTaiKhoan
                             join nv in context.NhanVien on tk.tenTaiKhoan equals nv.tenTaiKhoan
                             join cthd in context.ChiTietHoaDon on hd.maHoaDon equals cthd.maHoaDon into cthdGroup
                             from cthd in cthdGroup.DefaultIfEmpty()
                             join xe in context.ThongTinXe on cthd.maXe equals xe.maXe into xeGroup
                             from xe in xeGroup.DefaultIfEmpty()
                             where hd.maHoaDon.ToLower().Contains(tuKhoa)
                                || kh.hoTen.ToLower().Contains(tuKhoa)
                                || (cthd != null && (cthd.ghiChuKhuyenMai ?? "").ToLower().Contains(tuKhoa))
                             select new
                             {
                                 MaHD = hd.maHoaDon,
                                 TenKhachHang = kh.hoTen,
                                 TenNhanVien = nv.hoTen,
                                 NgayLap = hd.ngayLap,
                                 TongTien = hd.tongTien,
                                 GhiChuKhuyenMai = cthd == null ? "" : cthd.ghiChuKhuyenMai,
                                 GiaBan = xe == null ? 0 : xe.giaBan
                             };

                dgvDSHoaDon.DataSource = ketQua.ToList();

                if (dgvDSHoaDon.Columns["TongTien"] != null)
                {
                    dgvDSHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                    dgvDSHoaDon.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgvDSHoaDon.Columns["GiaBan"] != null)
                {
                    dgvDSHoaDon.Columns["GiaBan"].HeaderText = "Giá Bán";
                    dgvDSHoaDon.Columns["GiaBan"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                    dgvDSHoaDon.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgvDSHoaDon.Columns["GhiChuKhuyenMai"] != null)
                {
                    dgvDSHoaDon.Columns["GhiChuKhuyenMai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
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

                var khach = context.KhachHang.FirstOrDefault(k => k.hoTen == txtTenKhachHang.Text.Trim());
                if (khach == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nhanVien = (from tk in context.TaiKhoan
                                join nv in context.NhanVien on tk.tenTaiKhoan equals nv.tenTaiKhoan
                                where nv.hoTen == txtTenNhanVien.Text.Trim()
                                select tk).FirstOrDefault();

                if (nhanVien == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hoaDon.maKhachHang = khach.maKhachHang;
                hoaDon.tenTaiKhoan = nhanVien.tenTaiKhoan;

                if (DateTime.TryParse(txtNgayLap.Text, out DateTime ngayLap))
                    hoaDon.ngayLap = ngayLap;
                else
                    hoaDon.ngayLap = DateTime.Now;

                if (decimal.TryParse(txtTongTien.Text.Replace("VNĐ", "").Replace(",", "").Trim(), out decimal tongTien))
                    hoaDon.tongTien = tongTien;

                context.SaveChanges();

                // Cập nhật ghi chú khuyến mãi trong ChiTietHoaDon (bản ghi đầu tiên)
                var chiTiet = context.ChiTietHoaDon.FirstOrDefault(ct => ct.maHoaDon == maHD);
                if (chiTiet != null)
                {
                    chiTiet.ghiChuKhuyenMai = txtKhuyenMai.Text.Trim();
                    context.SaveChanges();
                }

                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            txtKhuyenMai.Clear();
            txtGiaBan.Clear();

            LoadHoaDon();
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

                    // Xóa chi tiết hóa đơn liên quan
                    var chiTiet = context.ChiTietHoaDon.Where(ct => ct.maHoaDon == maHD).ToList();
                    if (chiTiet.Any())
                        context.ChiTietHoaDon.RemoveRange(chiTiet);

                    // Xóa bảo hành liên quan
                    var baoHanhs = context.BaoHanh.Where(bh => bh.maHoaDon == maHD).ToList();
                    if (baoHanhs.Any())
                        context.BaoHanh.RemoveRange(baoHanhs);

                    // Xóa hóa đơn
                    context.HoaDon.Remove(hoaDon);
                    context.SaveChanges();
                }

                MessageBox.Show("Đã xóa hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon();
                btnLamMoi_Click(sender, e);
            }
        }

        private void dgvDSHoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số dòng hợp lệ
            {
                DataGridViewRow row = dgvDSHoaDon.Rows[e.RowIndex];

                txtMaHoaDon.Text = row.Cells["MaHD"].Value?.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["NgayLap"].Value?.ToString(), out DateTime ngayLap))
                    txtNgayLap.Text = ngayLap.ToString("dd/MM/yyyy");
                else
                    txtNgayLap.Text = "";

                if (decimal.TryParse(row.Cells["TongTien"].Value?.ToString(), out decimal tongTien))
                    txtTongTien.Text = tongTien.ToString("#,##0 'VNĐ'");
                else
                    txtTongTien.Text = "";

                txtKhuyenMai.Text = row.Cells["GhiChuKhuyenMai"].Value?.ToString() ?? "";

                if (decimal.TryParse(row.Cells["GiaBan"].Value?.ToString(), out decimal giaBan))
                    txtGiaBan.Text = giaBan.ToString("#,##0 'VNĐ'");
                else
                    txtGiaBan.Text = "0 VNĐ";
            }
        }
    }
}
