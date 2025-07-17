using DoAn1.Data_Transfer_Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
namespace DoAn1.Forms.QLTaiKhoan
{
   public partial class usTaiKhoan : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
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

        private string GetTenQuyen(string tenQuyen)
        {
            using (var db = new Data_Access_Layer.DataDbContext())
            {
                var tk = db.TaiKhoan
                           .Include(t => t.PhanQuyen)
                           .FirstOrDefault(t => t.tenTaiKhoan == tenQuyen);

                return tk?.PhanQuyen?.tenQuyen ?? "Chưa phân quyền";
            }
        }

        private void InitializeComponent()
        {
            grpTTTaiKhoan = new GroupBox();
            tbTTaiKhoan = new TableLayoutPanel();
            txtPhanQuyen = new TextBox();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            txtNgaySinh = new TextBox();
            txtGioiTinh = new TextBox();
            txtHoVaTen = new TextBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            lblHoVaTen = new Label();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            lblPhanQuyen = new Label();
            txtTenDangNhap = new TextBox();
            grpTTTaiKhoan.SuspendLayout();
            tbTTaiKhoan.SuspendLayout();
            SuspendLayout();
            // 
            // grpTTTaiKhoan
            // 
            grpTTTaiKhoan.Controls.Add(tbTTaiKhoan);
            grpTTTaiKhoan.Dock = DockStyle.Fill;
            grpTTTaiKhoan.Location = new Point(10, 10);
            grpTTTaiKhoan.Name = "grpTTTaiKhoan";
            grpTTTaiKhoan.Size = new Size(980, 730);
            grpTTTaiKhoan.TabIndex = 4;
            grpTTTaiKhoan.TabStop = false;
            grpTTTaiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // tbTTaiKhoan
            // 
            tbTTaiKhoan.ColumnCount = 2;
            tbTTaiKhoan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbTTaiKhoan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbTTaiKhoan.Controls.Add(txtPhanQuyen, 1, 7);
            tbTTaiKhoan.Controls.Add(txtEmail, 1, 6);
            tbTTaiKhoan.Controls.Add(txtSoDienThoai, 1, 5);
            tbTTaiKhoan.Controls.Add(txtNgaySinh, 1, 4);
            tbTTaiKhoan.Controls.Add(txtGioiTinh, 1, 3);
            tbTTaiKhoan.Controls.Add(txtHoVaTen, 1, 2);
            tbTTaiKhoan.Controls.Add(txtMatKhau, 1, 1);
            tbTTaiKhoan.Controls.Add(lblMatKhau, 0, 1);
            tbTTaiKhoan.Controls.Add(lblTenDangNhap, 0, 0);
            tbTTaiKhoan.Controls.Add(lblHoVaTen, 0, 2);
            tbTTaiKhoan.Controls.Add(lblGioiTinh, 0, 3);
            tbTTaiKhoan.Controls.Add(lblNgaySinh, 0, 4);
            tbTTaiKhoan.Controls.Add(lblSoDienThoai, 0, 5);
            tbTTaiKhoan.Controls.Add(lblEmail, 0, 6);
            tbTTaiKhoan.Controls.Add(lblPhanQuyen, 0, 7);
            tbTTaiKhoan.Controls.Add(txtTenDangNhap, 1, 0);
            tbTTaiKhoan.Dock = DockStyle.Fill;
            tbTTaiKhoan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tbTTaiKhoan.ForeColor = Color.DimGray;
            tbTTaiKhoan.Location = new Point(3, 23);
            tbTTaiKhoan.Name = "tbTTaiKhoan";
            tbTTaiKhoan.RowCount = 8;
            tbTTaiKhoan.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tbTTaiKhoan.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tbTTaiKhoan.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tbTTaiKhoan.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tbTTaiKhoan.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tbTTaiKhoan.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tbTTaiKhoan.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tbTTaiKhoan.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tbTTaiKhoan.Size = new Size(974, 704);
            tbTTaiKhoan.TabIndex = 0;
            tbTTaiKhoan.Paint += tbTTaiKhoan_Paint;
            // 
            // txtPhanQuyen
            // 
            txtPhanQuyen.Anchor = AnchorStyles.Left;
            txtPhanQuyen.Location = new Point(490, 644);
            txtPhanQuyen.Name = "txtPhanQuyen";
            txtPhanQuyen.Size = new Size(203, 32);
            txtPhanQuyen.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.Location = new Point(490, 556);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 32);
            txtEmail.TabIndex = 14;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left;
            txtSoDienThoai.Location = new Point(490, 468);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(203, 32);
            txtSoDienThoai.TabIndex = 13;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Anchor = AnchorStyles.Left;
            txtNgaySinh.Location = new Point(490, 380);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(203, 32);
            txtNgaySinh.TabIndex = 12;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Anchor = AnchorStyles.Left;
            txtGioiTinh.Location = new Point(490, 292);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(203, 32);
            txtGioiTinh.TabIndex = 11;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Anchor = AnchorStyles.Left;
            txtHoVaTen.Location = new Point(490, 204);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(203, 32);
            txtHoVaTen.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left;
            txtMatKhau.Location = new Point(490, 116);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(203, 32);
            txtMatKhau.TabIndex = 9;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Anchor = AnchorStyles.Right;
            lblMatKhau.Location = new Point(325, 117);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(159, 30);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Anchor = AnchorStyles.Right;
            lblTenDangNhap.Location = new Point(322, 27);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(162, 33);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.Anchor = AnchorStyles.Right;
            lblHoVaTen.Location = new Point(325, 204);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(159, 31);
            lblHoVaTen.TabIndex = 2;
            lblHoVaTen.Text = "Họ Và Tên";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Anchor = AnchorStyles.Right;
            lblGioiTinh.Location = new Point(325, 292);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(159, 31);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Anchor = AnchorStyles.Right;
            lblNgaySinh.Location = new Point(325, 381);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(159, 29);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Anchor = AnchorStyles.Right;
            lblSoDienThoai.Location = new Point(325, 470);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(159, 27);
            lblSoDienThoai.TabIndex = 5;
            lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.Location = new Point(325, 556);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(159, 32);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhanQuyen
            // 
            lblPhanQuyen.Anchor = AnchorStyles.Right;
            lblPhanQuyen.Location = new Point(328, 645);
            lblPhanQuyen.Name = "lblPhanQuyen";
            lblPhanQuyen.Size = new Size(156, 29);
            lblPhanQuyen.TabIndex = 7;
            lblPhanQuyen.Text = "Phân Quyền";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.Left;
            txtTenDangNhap.Location = new Point(490, 28);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(203, 32);
            txtTenDangNhap.TabIndex = 8;
            // 
            // usTaiKhoan
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            Controls.Add(grpTTTaiKhoan);
            Name = "usTaiKhoan";
            Padding = new Padding(10);
            Size = new Size(1000, 750);
            grpTTTaiKhoan.ResumeLayout(false);
            tbTTaiKhoan.ResumeLayout(false);
            tbTTaiKhoan.PerformLayout();
            ResumeLayout(false);

        }
        private GroupBox grpTTTaiKhoan;
        private TableLayoutPanel tbTTaiKhoan;
        private TextBox txtPhanQuyen;
        private TextBox txtEmail;
        private TextBox txtSoDienThoai;
        private TextBox txtNgaySinh;
        private TextBox txtGioiTinh;
        private TextBox txtHoVaTen;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private Label lblTenDangNhap;
        private Label lblHoVaTen;
        private Label lblGioiTinh;
        private Label lblNgaySinh;
        private Label lblSoDienThoai;
        private Label lblEmail;
        private Label lblPhanQuyen;
        private TextBox txtTenDangNhap;
    }
}
