using DoAn1.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Forms.QLTaiKhoan
{
    public partial class usTaiKhoan : UserControl
    {
        public usTaiKhoan()
        {
            InitializeComponent();
            this.Load += usTaiKhoan_Load;
        }

        private void usTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Session.NhanVienDangNhap != null)
            {
                var nv = Session.NhanVienDangNhap;
                txtTenDangNhap.Text = Session.TenDangNhap;
                txtMatKhau.Text = Session.MatKhau;
                txtHoVaTen.Text = nv.hoTen;
                txtGioiTinh.Text = nv.gioiTinh;
                txtNgaySinh.Text = nv.ngaySinh.ToShortDateString();
                txtSoDienThoai.Text = nv.soDienThoai;
                txtEmail.Text = nv.email;
                txtPhanQuyen.Text = GetTenQuyen(Session.TenDangNhap); // Xử lý bên dưới
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTTaiKhoan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

public static class Session
{
    public static NhanVien? NhanVienDangNhap { get; set; }
    public static string TenDangNhap { get; set; } = string.Empty;
    public static string MatKhau { get; set; } = string.Empty;
}
