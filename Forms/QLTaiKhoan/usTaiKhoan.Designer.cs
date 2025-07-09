using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLTaiKhoan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpTTTaiKhoan = new System.Windows.Forms.GroupBox();
            this.tbTTaiKhoan = new System.Windows.Forms.TableLayoutPanel();
            this.txtPhanQuyen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhanQuyen = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpTTTaiKhoan.SuspendLayout();
            this.tbTTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTieuDe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpTTTaiKhoan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDoiMatKhau, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 730);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(974, 109);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÍ TÀI KHOẢN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTTTaiKhoan
            // 
            this.grpTTTaiKhoan.Controls.Add(this.tbTTaiKhoan);
            this.grpTTTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTTaiKhoan.Location = new System.Drawing.Point(3, 112);
            this.grpTTTaiKhoan.Name = "grpTTTaiKhoan";
            this.grpTTTaiKhoan.Size = new System.Drawing.Size(974, 505);
            this.grpTTTaiKhoan.TabIndex = 1;
            this.grpTTTaiKhoan.TabStop = false;
            this.grpTTTaiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // tbTTaiKhoan
            // 
            this.tbTTaiKhoan.ColumnCount = 2;
            this.tbTTaiKhoan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbTTaiKhoan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbTTaiKhoan.Controls.Add(this.txtPhanQuyen, 1, 7);
            this.tbTTaiKhoan.Controls.Add(this.txtEmail, 1, 6);
            this.tbTTaiKhoan.Controls.Add(this.txtSoDienThoai, 1, 5);
            this.tbTTaiKhoan.Controls.Add(this.txtNgaySinh, 1, 4);
            this.tbTTaiKhoan.Controls.Add(this.txtGioiTinh, 1, 3);
            this.tbTTaiKhoan.Controls.Add(this.txtHoVaTen, 1, 2);
            this.tbTTaiKhoan.Controls.Add(this.txtMatKhau, 1, 1);
            this.tbTTaiKhoan.Controls.Add(this.lblMatKhau, 0, 1);
            this.tbTTaiKhoan.Controls.Add(this.lblTenDangNhap, 0, 0);
            this.tbTTaiKhoan.Controls.Add(this.lblHoVaTen, 0, 2);
            this.tbTTaiKhoan.Controls.Add(this.lblGioiTinh, 0, 3);
            this.tbTTaiKhoan.Controls.Add(this.lblNgaySinh, 0, 4);
            this.tbTTaiKhoan.Controls.Add(this.lblSoDienThoai, 0, 5);
            this.tbTTaiKhoan.Controls.Add(this.lblEmail, 0, 6);
            this.tbTTaiKhoan.Controls.Add(this.lblPhanQuyen, 0, 7);
            this.tbTTaiKhoan.Controls.Add(this.txtTenDangNhap, 1, 0);
            this.tbTTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tbTTaiKhoan.ForeColor = System.Drawing.Color.DimGray;
            this.tbTTaiKhoan.Location = new System.Drawing.Point(3, 16);
            this.tbTTaiKhoan.Name = "tbTTaiKhoan";
            this.tbTTaiKhoan.RowCount = 8;
            this.tbTTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbTTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbTTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbTTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbTTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbTTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbTTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbTTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbTTaiKhoan.Size = new System.Drawing.Size(968, 486);
            this.tbTTaiKhoan.TabIndex = 0;
            // 
            // txtPhanQuyen
            // 
            this.txtPhanQuyen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhanQuyen.Location = new System.Drawing.Point(487, 439);
            this.txtPhanQuyen.Name = "txtPhanQuyen";
            this.txtPhanQuyen.Size = new System.Drawing.Size(156, 27);
            this.txtPhanQuyen.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(487, 376);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 27);
            this.txtEmail.TabIndex = 14;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoDienThoai.Location = new System.Drawing.Point(487, 316);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(156, 27);
            this.txtSoDienThoai.TabIndex = 13;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNgaySinh.Location = new System.Drawing.Point(487, 256);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(156, 27);
            this.txtNgaySinh.TabIndex = 12;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGioiTinh.Location = new System.Drawing.Point(487, 196);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(156, 27);
            this.txtGioiTinh.TabIndex = 11;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHoVaTen.Location = new System.Drawing.Point(487, 136);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(156, 27);
            this.txtHoVaTen.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMatKhau.Location = new System.Drawing.Point(487, 76);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(156, 27);
            this.txtMatKhau.TabIndex = 9;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMatKhau.Location = new System.Drawing.Point(355, 78);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(126, 23);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenDangNhap.Location = new System.Drawing.Point(352, 18);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(129, 23);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHoVaTen.Location = new System.Drawing.Point(355, 138);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(126, 23);
            this.lblHoVaTen.TabIndex = 2;
            this.lblHoVaTen.Text = "Họ Và Tên";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGioiTinh.Location = new System.Drawing.Point(355, 198);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(126, 23);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgaySinh.Location = new System.Drawing.Point(355, 258);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(126, 23);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoDienThoai.Location = new System.Drawing.Point(355, 318);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(126, 23);
            this.lblSoDienThoai.TabIndex = 5;
            this.lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.Location = new System.Drawing.Point(355, 378);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblPhanQuyen
            // 
            this.lblPhanQuyen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhanQuyen.Location = new System.Drawing.Point(358, 441);
            this.lblPhanQuyen.Name = "lblPhanQuyen";
            this.lblPhanQuyen.Size = new System.Drawing.Size(123, 23);
            this.lblPhanQuyen.TabIndex = 7;
            this.lblPhanQuyen.Text = "Phân Quyền";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenDangNhap.Location = new System.Drawing.Point(487, 16);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(156, 27);
            this.txtTenDangNhap.TabIndex = 8;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(424, 655);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(132, 39);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            // 
            // usTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "usTaiKhoan";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1000, 750);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpTTTaiKhoan.ResumeLayout(false);
            this.tbTTaiKhoan.ResumeLayout(false);
            this.tbTTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTTTaiKhoan;
        private System.Windows.Forms.TableLayoutPanel tbTTaiKhoan;
        private System.Windows.Forms.TextBox txtPhanQuyen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhanQuyen;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}
