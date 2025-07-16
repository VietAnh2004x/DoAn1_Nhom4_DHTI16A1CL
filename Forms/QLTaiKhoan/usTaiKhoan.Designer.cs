using System.Windows.Forms;

namespace DoAn1.Forms.QLTaiKhoan
{
    partial class usTaiKhoan
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

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDoiMatKhau = new Button();
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
            tableLayoutPanel1.SuspendLayout();
            grpTTTaiKhoan.SuspendLayout();
            tbTTaiKhoan.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnDoiMatKhau, 0, 1);
            tableLayoutPanel1.Controls.Add(grpTTTaiKhoan, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(980, 730);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Anchor = AnchorStyles.None;
            btnDoiMatKhau.BackColor = Color.SteelBlue;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(413, 651);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(153, 47);
            btnDoiMatKhau.TabIndex = 4;
            btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            // 
            // grpTTTaiKhoan
            // 
            grpTTTaiKhoan.Controls.Add(tbTTaiKhoan);
            grpTTTaiKhoan.Dock = DockStyle.Fill;
            grpTTTaiKhoan.Location = new Point(3, 3);
            grpTTTaiKhoan.Name = "grpTTTaiKhoan";
            grpTTTaiKhoan.Size = new Size(974, 614);
            grpTTTaiKhoan.TabIndex = 3;
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
            tbTTaiKhoan.Size = new Size(968, 588);
            tbTTaiKhoan.TabIndex = 0;
            // 
            // txtPhanQuyen
            // 
            txtPhanQuyen.Anchor = AnchorStyles.Left;
            txtPhanQuyen.Location = new Point(487, 533);
            txtPhanQuyen.Name = "txtPhanQuyen";
            txtPhanQuyen.Size = new Size(156, 32);
            txtPhanQuyen.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.Location = new Point(487, 458);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(156, 32);
            txtEmail.TabIndex = 14;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left;
            txtSoDienThoai.Location = new Point(487, 385);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(156, 32);
            txtSoDienThoai.TabIndex = 13;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Anchor = AnchorStyles.Left;
            txtNgaySinh.Location = new Point(487, 312);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(156, 32);
            txtNgaySinh.TabIndex = 12;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Anchor = AnchorStyles.Left;
            txtGioiTinh.Location = new Point(487, 239);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(156, 32);
            txtGioiTinh.TabIndex = 11;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Anchor = AnchorStyles.Left;
            txtHoVaTen.Location = new Point(487, 166);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(156, 32);
            txtHoVaTen.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left;
            txtMatKhau.Location = new Point(487, 93);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(156, 32);
            txtMatKhau.TabIndex = 9;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Anchor = AnchorStyles.Right;
            lblMatKhau.Location = new Point(322, 94);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(159, 30);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Anchor = AnchorStyles.Right;
            lblTenDangNhap.Location = new Point(319, 20);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(162, 33);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.Anchor = AnchorStyles.Right;
            lblHoVaTen.Location = new Point(322, 167);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(159, 31);
            lblHoVaTen.TabIndex = 2;
            lblHoVaTen.Text = "Họ Và Tên";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Anchor = AnchorStyles.Right;
            lblGioiTinh.Location = new Point(322, 240);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(159, 31);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Anchor = AnchorStyles.Right;
            lblNgaySinh.Location = new Point(322, 314);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(159, 29);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Anchor = AnchorStyles.Right;
            lblSoDienThoai.Location = new Point(322, 388);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(159, 27);
            lblSoDienThoai.TabIndex = 5;
            lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.Location = new Point(322, 458);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(159, 32);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhanQuyen
            // 
            lblPhanQuyen.Anchor = AnchorStyles.Right;
            lblPhanQuyen.Location = new Point(325, 535);
            lblPhanQuyen.Name = "lblPhanQuyen";
            lblPhanQuyen.Size = new Size(156, 29);
            lblPhanQuyen.TabIndex = 7;
            lblPhanQuyen.Text = "Phân Quyền";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.Left;
            txtTenDangNhap.Location = new Point(487, 20);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(156, 32);
            txtTenDangNhap.TabIndex = 8;
            // 
            // usTaiKhoan
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tableLayoutPanel1);
            Name = "usTaiKhoan";
            Padding = new Padding(10);
            Size = new Size(1000, 750);
            tableLayoutPanel1.ResumeLayout(false);
            grpTTTaiKhoan.ResumeLayout(false);
            tbTTaiKhoan.ResumeLayout(false);
            tbTTaiKhoan.PerformLayout();
            ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Button btnDoiMatKhau;
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
