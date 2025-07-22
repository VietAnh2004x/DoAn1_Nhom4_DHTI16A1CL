using DoAn1.Data_Access_Layer;
using DoAn1.Data_Transfer_Objects;
using System.Data;

namespace DoAn1.Forms.QLBaoHanh
{
    public partial class frmPhieuBaoHanh : Form
    {
        public frmPhieuBaoHanh()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                // B1: Lấy danh sách mã bảo hành hợp lệ từ DB trước
                var danhSachMaBH = context.BaoHanh
                    .Select(bh => bh.maBaoHanh)
                    .Where(m => m.StartsWith("BH") && m.Length == 5)
                    .ToList();

                // B2: Chuyển sang số, tìm số lớn nhất
                var dsSo = danhSachMaBH
                    .Select(m =>
                    {
                        string soStr = m.Substring(2);
                        return int.TryParse(soStr, out int so) ? so : 0;
                    })
                    .ToList();

                int soLonNhat = dsSo.Any() ? dsSo.Max() : 0;
                string maBaoHanh = "BH" + (soLonNhat + 1).ToString("D3");

                // B3: Lấy dữ liệu từ giao diện
                string maXe = txtMaXe.Text.Trim();
                string maKhachHang = txtMaKH.Text.Trim();
                string maHoaDon = txtMaHoaDon.Text.Trim();
                int thoiHanThang = (int)nudThoiHan.Value;
                DateTime ngayBatDau = dtpNgayLap.Value;

                // B4: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(maXe) || string.IsNullOrWhiteSpace(maKhachHang) || string.IsNullOrWhiteSpace(maHoaDon))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường bắt buộc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (thoiHanThang <= 0)
                {
                    MessageBox.Show("Thời hạn bảo hành phải lớn hơn 0 tháng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // B5: Kiểm tra tính hợp lệ của mã hóa đơn, mã xe, mã KH bằng JOIN với ChiTietHoaDon
                var thongTin = (from ct in context.ChiTietHoaDon
                                join hd in context.HoaDon on ct.maHoaDon equals hd.maHoaDon
                                join kh in context.KhachHang on hd.maKhachHang equals kh.maKhachHang
                                join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                                where ct.maHoaDon == maHoaDon &&
                                      ct.maXe == maXe &&
                                      kh.maKhachHang == maKhachHang
                                select new
                                {
                                    TenKhachHang = kh.hoTen,  // Đảm bảo tên thuộc tính đúng với entity của bạn
                                    TenXe = xe.tenXe
                                }).FirstOrDefault();

                if (thongTin == null)
                {
                    MessageBox.Show("Thông tin không hợp lệ! Mã hóa đơn, mã khách hàng và mã xe không khớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // B6: Hiển thị lại tên khách và tên xe lên form
                txtTenKH.Text = thongTin.TenKhachHang;
                txtTenXe.Text = thongTin.TenXe;

                // B7: Tạo và thêm phiếu bảo hành mới
                var phieuBaoHanh = new BaoHanh
                {
                    maBaoHanh = maBaoHanh,
                    maHoaDon = maHoaDon,
                    maXe = maXe,
                    ngayBatDau = ngayBatDau,
                    thoiHanThang = thoiHanThang
                };

                context.BaoHanh.Add(phieuBaoHanh);

                // B8: Lưu vào DB
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Đã lưu phiếu bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaXe.Clear();
            txtMaHoaDon.Clear();
            nudThoiHan.Value = 0;
            dtpNgayLap.Value = DateTime.Now;
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {

        }

        private void txtTenXe_Leave(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            if (string.IsNullOrWhiteSpace(maKH)) return;

            using (var context = new DataDbContext())
            {
                var kh = context.KhachHang.FirstOrDefault(k => k.maKhachHang == maKH);
                txtTenKH.Text = kh != null ? kh.hoTen : "";
            }
        }

        private void txtMaXe_TextChanged(object sender, EventArgs e)
        {
            string maXe = txtMaXe.Text.Trim();
            if (string.IsNullOrWhiteSpace(maXe)) return;

            using (var context = new DataDbContext())
            {
                var xe = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                txtTenXe.Text = xe != null ? xe.tenXe : "";
            }
        }
    }
}
