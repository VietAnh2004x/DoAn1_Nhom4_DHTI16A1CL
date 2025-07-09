using DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoCao;
using DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoHanh;
using DoAn1_Nhom4_DHTI16A1CL.Forms.QLDaiLy;
using DoAn1_Nhom4_DHTI16A1CL.Forms.QLHoaDon;
using DoAn1_Nhom4_DHTI16A1CL.Forms.QLKhachHang;
using DoAn1_Nhom4_DHTI16A1CL.Forms.QLTaiKhoan;
using DoAn1_Nhom4_DHTI16A1CL.Forms.QLTonKho;
using DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe;
using DoAn1_Nhom4_DHTI16A1CL.Forms.TongQuan;
using System;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.TongQuan
{
    public partial class usSideBar : UserControl
    {
        private Action<UserControl> onMenuClick;

        public usSideBar(Action<UserControl> onMenuClick)
        {
            InitializeComponent();
            this.onMenuClick = onMenuClick;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usBaoCao());
            ActivateButton((Button)sender);
        }

        private void btnQLBaoHanh_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usBaoHanh());
            ActivateButton((Button)sender);
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usTongQuan());
            ActivateButton((Button)sender);
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usKhachHang());
            ActivateButton((Button)sender);
        }

        private void btnQLTonKho_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usTonKho());
            ActivateButton((Button)sender);
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usHoaDon());
            ActivateButton((Button)sender);
        }

        private void btnQLDaiLy_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usDaiLy());
            ActivateButton((Button)sender);
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usTaiKhoan());
            ActivateButton((Button)sender);
        }

        private void btnQLXeDapDien_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usXeDapDien());
            ActivateButton((Button)sender);
        }

        private void btnQLXeMayDien_Click(object sender, EventArgs e)
        {
            onMenuClick?.Invoke(new usXeMayDien());
            ActivateButton((Button)sender);
        }
    }
}
