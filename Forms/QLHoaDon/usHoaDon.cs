﻿using DoAn.Data_Access_Layer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms.QLHoaDon
{
    public partial class usHoaDon : UserControl
    {
        public usHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();
            SetupDateTimePicker();
        }

        private void SetupDateTimePicker()
        {
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = " "; // Hiển thị trống ban đầu
        }

        private void LoadHoaDon()
        {
            using (var context = new DataDbContext())
            {
                // Lấy danh sách hóa đơn kèm chi tiết và thông tin xe
                var data = context.HoaDon
                    .Select(hd => new
                    {
                        hd.maHoaDon,
                        TenKhachHang = hd.KhachHang!.hoTen,
                        TenNhanVien = hd.TaiKhoan!.NhanVien!.hoTen,
                        hd.ngayLap,
                        ChiTiet = hd.ChiTietHoaDons.Select(ct => new
                        {
                            ct.donGia,
                            ct.ghiChuKhuyenMai,
                            ct.maXe,
                            TenXe = ct.Xe.tenXe,    // Lấy tên xe từ navigation property
                            GiaBan = ct.Xe.giaBan,
                           
                        }).ToList()
                    })
                    .AsEnumerable() // chuyển sang xử lý phía client
                    .Select(h => new
                    {
                        MaHD = h.maHoaDon,
                        TenKhachHang = h.TenKhachHang,
                        TenNhanVien = h.TenNhanVien,
                        NgayLap = h.ngayLap,
                        // Lấy tên xe đầu tiên để hiển thị ví dụ
                        TenXe = h.ChiTiet.FirstOrDefault()?.TenXe ?? "",
                        GiaBan = h.ChiTiet.FirstOrDefault()?.GiaBan ?? 0,
                        // CHỈNH SỬA Ở ĐÂY: Hiển thị trống nếu ghiChuKhuyenMai là "0%"
                        GhiChuKhuyenMai = (h.ChiTiet.FirstOrDefault()?.ghiChuKhuyenMai ?? "").Trim() == "0%" ? "" : (h.ChiTiet.FirstOrDefault()?.ghiChuKhuyenMai ?? ""),
                        TongTien = h.ChiTiet.Sum(ct => ct.donGia * (1 - ParseKhuyenMai(ct.ghiChuKhuyenMai!)))
                    })
                    .ToList();

                dgvDSHoaDon.DataSource = data;

                // Đặt lại header cho các cột
                dgvDSHoaDon.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                dgvDSHoaDon.Columns["TenKhachHang"].HeaderText = "Khách Hàng";
                dgvDSHoaDon.Columns["TenNhanVien"].HeaderText = "Nhân Viên";
                dgvDSHoaDon.Columns["NgayLap"].HeaderText = "Ngày Lập";
                dgvDSHoaDon.Columns["TenXe"].HeaderText = "Tên Xe";
                dgvDSHoaDon.Columns["GiaBan"].HeaderText = "Giá Bán";
                dgvDSHoaDon.Columns["GhiChuKhuyenMai"].HeaderText = "Ghi Chú Khuyến Mãi";
                dgvDSHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";

                // Định dạng tiền tệ
                dgvDSHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                dgvDSHoaDon.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvDSHoaDon.Columns["GiaBan"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                dgvDSHoaDon.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvDSHoaDon.Columns["GhiChuKhuyenMai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // Căn giữa tiêu đề cột
                dgvDSHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDSHoaDon.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                dgvDSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private decimal ParseKhuyenMai(string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(ghiChu))
                return 0m;

            // Giả sử chuỗi ghi chú khuyến mãi có dạng: "10%", "5%", "15%"...
            // Ta sẽ tìm số trong chuỗi rồi chia cho 100 để lấy tỉ lệ
            var digits = new string(ghiChu.Where(char.IsDigit).ToArray());
            if (decimal.TryParse(digits, out decimal percent))
            {
                return percent / 100m;
            }
            return 0m;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuHoaDon frmPhieuHoaDon = new frmPhieuHoaDon();
            frmPhieuHoaDon.ShowDialog();
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
                                || (nv.hoTen ?? "").ToLower().Contains(tuKhoa)
                                || (xe.tenXe ?? "").ToLower().Contains(tuKhoa)
                                || (cthd != null && (cthd.ghiChuKhuyenMai ?? "").ToLower().Contains(tuKhoa))
                             select new
                             {
                                 MaHD = hd.maHoaDon,
                                 TenKhachHang = kh.hoTen,
                                 TenNhanVien = nv.hoTen,
                                 NgayLap = hd.ngayLap,
                                 TenXe = xe == null ? "" : xe.tenXe,
                                 GiaBan = xe == null ? 0 : xe.giaBan,
                                 // CHỈNH SỬA Ở ĐÂY: Hiển thị trống nếu ghiChuKhuyenMai là "0%"
                                 GhiChuKhuyenMai = (cthd == null || (cthd.ghiChuKhuyenMai ?? "").Trim() == "0%") ? "" : cthd.ghiChuKhuyenMai,
                                 TongTien = hd.tongTien
                             };

                dgvDSHoaDon.DataSource = ketQua.ToList();

                // Đảm bảo các cột và định dạng vẫn được áp dụng sau khi tìm kiếm
                if (dgvDSHoaDon.Columns["MaHD"] != null) dgvDSHoaDon.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                if (dgvDSHoaDon.Columns["TenKhachHang"] != null) dgvDSHoaDon.Columns["TenKhachHang"].HeaderText = "Khách Hàng";
                if (dgvDSHoaDon.Columns["TenNhanVien"] != null) dgvDSHoaDon.Columns["TenNhanVien"].HeaderText = "Nhân Viên";
                if (dgvDSHoaDon.Columns["NgayLap"] != null) dgvDSHoaDon.Columns["NgayLap"].HeaderText = "Ngày Lập";
                if (dgvDSHoaDon.Columns["TenXe"] != null) dgvDSHoaDon.Columns["TenXe"].HeaderText = "Tên Xe";
                if (dgvDSHoaDon.Columns["GiaBan"] != null)
                {
                    dgvDSHoaDon.Columns["GiaBan"].HeaderText = "Giá Bán";
                    dgvDSHoaDon.Columns["GiaBan"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                    dgvDSHoaDon.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvDSHoaDon.Columns["GhiChuKhuyenMai"] != null)
                {
                    dgvDSHoaDon.Columns["GhiChuKhuyenMai"].HeaderText = "Ghi Chú Khuyến Mãi";
                    dgvDSHoaDon.Columns["GhiChuKhuyenMai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                if (dgvDSHoaDon.Columns["TongTien"] != null)
                {
                    dgvDSHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
                    dgvDSHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                    dgvDSHoaDon.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                dgvDSHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDSHoaDon.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                dgvDSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

                if (DateTime.TryParse(dtpNgayLap.Text, out DateTime ngayLap))
                    hoaDon.ngayLap = ngayLap;
                else
                    hoaDon.ngayLap = DateTime.Now;

                var chiTiet = context.ChiTietHoaDon.FirstOrDefault(ct => ct.maHoaDon == maHD);
                if (chiTiet != null)
                {
                    // Lưu giá trị từ textbox vào ghiChuKhuyenMai
                    // Nếu textbox trống, có thể lưu null hoặc chuỗi rỗng vào DB
                    // hoặc nếu bạn muốn lưu "0%" khi textbox trống, bạn cần một logic khác
                    string khuyenMaiInput = txtKhuyenMai.Text.Trim();
                    if (string.IsNullOrEmpty(khuyenMaiInput))
                    {
                        chiTiet.ghiChuKhuyenMai = "0%"; // Nếu muốn lưu "0%" khi người dùng để trống
                    }
                    else
                    {
                        chiTiet.ghiChuKhuyenMai = khuyenMaiInput;
                    }
                    context.SaveChanges();
                }

                // Tính toán lại tổng tiền sau khi có thể đã sửa khuyến mãi
                hoaDon.tongTien = context.ChiTietHoaDon
                                     .Where(ct => ct.maHoaDon == maHD)
                                     .ToList()
                                     .Sum(ct => ct.donGia  * (1 - ParseKhuyenMai(ct.ghiChuKhuyenMai!)));
                context.SaveChanges();

                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadHoaDon();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Clear();
            txtTenKhachHang.Clear();
            txtTenNhanVien.Clear();
            dtpNgayLap.CustomFormat = " ";
            txtTongTien.Clear();
            txtTimKiemHoaDon.Clear();
            txtKhuyenMai.Clear(); // Đảm bảo dòng này đã có
            txtGiaBan.Clear();
            txtTenXe.Clear();

            LoadHoaDon(); // Tải lại dữ liệu sau khi làm mới
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

                    // Xóa chi tiết hóa đơn liên quan trước (do có khóa ngoại)
                    var chiTiet = context.ChiTietHoaDon.Where(ct => ct.maHoaDon == maHD).ToList();
                    if (chiTiet.Any())
                        context.ChiTietHoaDon.RemoveRange(chiTiet);

                    // Xóa bảo hành liên quan (nếu có khóa ngoại tới HoaDon)
                    var baoHanhs = context.BaoHanh.Where(bh => bh.maHoaDon == maHD).ToList();
                    if (baoHanhs.Any())
                        context.BaoHanh.RemoveRange(baoHanhs);

                    // Xóa hóa đơn
                    context.HoaDon.Remove(hoaDon);
                    context.SaveChanges();
                }

                MessageBox.Show("Đã xóa hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon();
                btnLamMoi_Click(sender, e); // Làm mới các trường input
            }
        }

        private void dgvDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số dòng hợp lệ
            {
                DataGridViewRow row = dgvDSHoaDon.Rows[e.RowIndex];

                txtMaHoaDon.Text = row.Cells["MaHD"].Value?.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value?.ToString();
                txtTenXe.Text = row.Cells["TenXe"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["NgayLap"].Value?.ToString(), out DateTime ngayLap))
                {
                    dtpNgayLap.Format = DateTimePickerFormat.Custom;
                    dtpNgayLap.CustomFormat = "dd/MM/yyyy";
                    dtpNgayLap.Value = ngayLap;
                }
                else
                {
                    dtpNgayLap.Format = DateTimePickerFormat.Custom;
                    dtpNgayLap.CustomFormat = " ";
                }

                if (decimal.TryParse(row.Cells["TongTien"].Value?.ToString(), out decimal tongTien))
                    txtTongTien.Text = tongTien.ToString("#,##0 'VNĐ'");
                else
                    txtTongTien.Text = "";

                // CHỈNH SỬA Ở ĐÂY: Kiểm tra nếu giá trị là "0%" thì hiển thị trống
                string ghiChuKM = row.Cells["GhiChuKhuyenMai"].Value?.ToString() ?? "";
                if (ghiChuKM.Trim() == "0%") // Sử dụng Trim() để loại bỏ khoảng trắng thừa
                {
                    txtKhuyenMai.Text = ""; // Hiển thị trống nếu là "0%"
                }
                else
                {
                    txtKhuyenMai.Text = ghiChuKM; // Hiển thị giá trị khác
                }

                if (decimal.TryParse(row.Cells["GiaBan"].Value?.ToString(), out decimal giaBan))
                    txtGiaBan.Text = giaBan.ToString("#,##0 'VNĐ'");
                else
                    txtGiaBan.Text = "0 VNĐ";
            }
        }
    }
}