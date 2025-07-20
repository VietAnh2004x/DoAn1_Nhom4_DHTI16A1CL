using DoAn.Data_Access_Layer;
using DoAn.Data_Transfer_Objects;

namespace DoAn1.Forms.QLHoaDon
{
    public partial class frmPhieuHoaDon : Form
    {
        public frmPhieuHoaDon()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                string tenKH = txtTenKhachHang.Text.Trim();
                string tenNV = txtTenNhanVien.Text.Trim();

                // Kiểm tra tên khách hàng
                var khachHang = context.KhachHang.FirstOrDefault(kh => kh.hoTen == tenKH);
                if (khachHang == null)
                {
                    MessageBox.Show("Tên khách hàng không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra tên nhân viên
                var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.hoTen == tenNV);
                if (nhanVien == null)
                {
                    MessageBox.Show("Tên nhân viên không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy mã khách hàng và tài khoản nhân viên
                string maKH = khachHang.maKhachHang;
                string tenTaiKhoan = nhanVien.tenTaiKhoan;

                // Ngày lập
                DateTime ngayLap = (dtpNgayLap.CustomFormat == " ") ? DateTime.Now : dtpNgayLap.Value;

                // Tổng tiền
                if (!decimal.TryParse(txtTongTien.Text.Trim(), out decimal tongTien))
                {
                    MessageBox.Show("Tổng tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy mã hóa đơn mới: dạng HD001, HD002,...
                string newMaHD = "HD001"; // mặc định nếu chưa có hóa đơn nào

                var lastHoaDon = context.HoaDon
                    .OrderByDescending(hd => hd.maHoaDon)
                    .FirstOrDefault();

                if (lastHoaDon != null)
                {
                    string lastMaHD = lastHoaDon.maHoaDon; // ví dụ: HD009
                    string so = lastMaHD.Substring(2);     // lấy "009"
                    if (int.TryParse(so, out int num))
                    {
                        num++;
                        newMaHD = "HD" + num.ToString("D3"); // D3 => 3 chữ số: "010"
                    }
                }

                // Tạo hóa đơn
                var hoaDon = new HoaDon
                {
                    maHoaDon = newMaHD,
                    maKhachHang = maKH,
                    tenTaiKhoan = tenTaiKhoan,
                    ngayLap = ngayLap,
                    tongTien = tongTien
                };

                // Thêm vào CSDL
                context.HoaDon.Add(hoaDon);
                context.SaveChanges();

                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
