using DoAn.Forms.Main;
using DoAn1.Forms.QLBaoCao;
using DoAn1.Forms.QLBaoHanh;
using DoAn1.Forms.QLDaiLy;
using DoAn1.Forms.QLHoaDon;
using DoAn1.Forms.QLKhachHang;
using DoAn1.Forms.QLTaiKhoan;
using DoAn1.Forms.QLTonKho;
using DoAn1.Forms.QLXe;
using DoAn1.Forms.TongQuan;
using FontAwesome.Sharp;

namespace DoAn1.Forms.Main
{
    public partial class usSideBar : UserControl
    {
        public event Action<string, IconChar, UserControl>? OnMenuButtonClickedWithControl;

        public usSideBar(Action<string, IconChar, UserControl> onMenuClick)
        {
            InitializeComponent();
            OnMenuButtonClickedWithControl += onMenuClick;

            ApplyPhanQuyen(); // ẩn/hiện theo quyền
        }

        private void RaiseMenuEvent(string title, IconChar icon, UserControl control)
        {
            OnMenuButtonClickedWithControl?.Invoke(title, icon, control);
        }

        private void ApplyPhanQuyen()
        {
            string maQuyen = Session.MaQuyen;

            switch (maQuyen)
            {
                case "1":
                    btnPhanQuyen.Visible = true;
                    break;

                case "2":
                    btnPhanQuyen.Visible = false;
                    btnBaoCao.Visible = true;
                    break;               
                default:
                    // Không có quyền xem báo cáo => gán lại sự kiện click để chặn
                    btnBaoCao.Click -= btnBaoCao_Click; // Xóa sự kiện gốc nếu có
                    btnBaoCao.Click += (s, e) =>
                    {
                        MessageBox.Show("Nhân viên không có quyền xem báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    };
                    break;
            }
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Tổng Quan", IconChar.ChartPie, new usTongQuan());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Báo Cáo", IconChar.FileInvoice, new usBaoCao());
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Quản Lý Tài Khoản", IconChar.UserCog, new usTaiKhoan());
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Phân Quyền", IconChar.UserShield, new usPhanQuyen());
        }

        private void btnQLXeDapDien_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Quản Lý Xe Đạp Điện", IconChar.Bicycle, new usXeDapDien());
        }

        private void btnQLXeMayDien_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Quản Lý Xe Máy Điện", IconChar.Motorcycle, new usXeMayDien());
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Quản Lý Khách Hàng", IconChar.Users, new usKhachHang());
        }

        private void btnQLTonKho_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Quản Lý Tồn Kho", IconChar.Warehouse, new usTonKho());
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Quản Lý Hóa Đơn", IconChar.FileInvoiceDollar, new usHoaDon());
        }

        private void btnQLPhieuBaoHanh_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Quản Lý Phiếu Bảo Hành", IconChar.FileInvoice, new usBaoHanh());
        }

        private void btnQLDaiLy_Click(object sender, EventArgs e)
        {
            RaiseMenuEvent("Quản Lý Đại Lý", IconChar.Store, new usDaiLy());
        }

        private void btnQLDanhMuc_Click(object sender, EventArgs e)
        {
            subMenuVisible = !subMenuVisible;
            subMenuPanel.Visible = subMenuVisible;
            subMenuPanel.Height = subMenuVisible ? 350 : 0;
            RaiseMenuEvent("Quản Lý Danh Mục", IconChar.FolderOpen, new usRong());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Xác nhận đăng xuất
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Reset session
                Session.TenDangNhap = "";
                Session.MatKhau = "";
                Session.MaQuyen = "";
                Session.NhanVienDangNhap = null;

                // Mở lại form đăng nhập
                Forms.QLDangNhap.usDangNhap loginForm = new Forms.QLDangNhap.usDangNhap();
                loginForm.Show();

                // Đóng form chính hiện tại
                Form mainForm = this.FindForm(); // lấy ra Form chứa UserControl này
                if (mainForm != null)
                {
                    mainForm.Hide(); // hoặc mainForm.Close(); nếu bạn không cần giữ lại
                }
            }
        }
    }
}
