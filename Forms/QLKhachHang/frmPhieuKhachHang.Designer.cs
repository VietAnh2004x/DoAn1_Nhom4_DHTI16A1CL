namespace DoAn1.Forms.QLKhachHang
{
    partial class frmPhieuKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuKhachHang));
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            grbThongTinKhachHang = new GroupBox();
            txtSoDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtTenKhachHang = new TextBox();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            lblDiaChiDaiLy = new Label();
            lblTenKhachHang = new Label();
            lblTieuDe = new Label();
            lblDiaChi = new Label();
            lblTenCuaHang = new Label();
            picLogo = new PictureBox();
            grbThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(714, 457);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 39);
            btnThoat.TabIndex = 31;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(518, 457);
            btnLamMoi.Margin = new Padding(2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(98, 39);
            btnLamMoi.TabIndex = 29;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(327, 457);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 39);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grbThongTinKhachHang
            // 
            grbThongTinKhachHang.Controls.Add(txtSoDienThoai);
            grbThongTinKhachHang.Controls.Add(txtEmail);
            grbThongTinKhachHang.Controls.Add(txtDiaChi);
            grbThongTinKhachHang.Controls.Add(txtTenKhachHang);
            grbThongTinKhachHang.Controls.Add(lblSoDienThoai);
            grbThongTinKhachHang.Controls.Add(lblEmail);
            grbThongTinKhachHang.Controls.Add(lblDiaChiDaiLy);
            grbThongTinKhachHang.Controls.Add(lblTenKhachHang);
            grbThongTinKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongTinKhachHang.Location = new Point(77, 237);
            grbThongTinKhachHang.Margin = new Padding(2);
            grbThongTinKhachHang.Name = "grbThongTinKhachHang";
            grbThongTinKhachHang.Padding = new Padding(2);
            grbThongTinKhachHang.Size = new Size(993, 196);
            grbThongTinKhachHang.TabIndex = 27;
            grbThongTinKhachHang.TabStop = false;
            grbThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(707, 129);
            txtSoDienThoai.Margin = new Padding(2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(214, 23);
            txtSoDienThoai.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(168, 129);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(707, 43);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(214, 23);
            txtDiaChi.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(168, 43);
            txtTenKhachHang.Margin = new Padding(2);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(214, 23);
            txtTenKhachHang.TabIndex = 6;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(590, 133);
            lblSoDienThoai.Margin = new Padding(2, 0, 2, 0);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(79, 15);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(54, 133);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblDiaChiDaiLy
            // 
            lblDiaChiDaiLy.AutoSize = true;
            lblDiaChiDaiLy.Location = new Point(590, 46);
            lblDiaChiDaiLy.Margin = new Padding(2, 0, 2, 0);
            lblDiaChiDaiLy.Name = "lblDiaChiDaiLy";
            lblDiaChiDaiLy.Size = new Size(46, 15);
            lblDiaChiDaiLy.TabIndex = 2;
            lblDiaChiDaiLy.Text = "Địa chỉ:";
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(54, 46);
            lblTenKhachHang.Margin = new Padding(2, 0, 2, 0);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(94, 15);
            lblTenKhachHang.TabIndex = 1;
            lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(-1, 173);
            lblTieuDe.Margin = new Padding(2, 0, 2, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1147, 54);
            lblTieuDe.TabIndex = 26;
            lblTieuDe.Text = "PHIẾU THÔNG TIN KHÁCH HÀNG";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(200, 99);
            lblDiaChi.Margin = new Padding(2, 0, 2, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(281, 15);
            lblDiaChi.TabIndex = 25;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(197, 55);
            lblTenCuaHang.Margin = new Padding(2, 0, 2, 0);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(389, 30);
            lblTenCuaHang.TabIndex = 24;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(54, 55);
            picLogo.Margin = new Padding(2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(127, 115);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 23;
            picLogo.TabStop = false;
            // 
            // frmPhieuKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 532);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(grbThongTinKhachHang);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(2);
            Name = "frmPhieuKhachHang";
            Text = "FormKhachHang";
            grbThongTinKhachHang.ResumeLayout(false);
            grbThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbThongTinKhachHang;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChiDaiLy;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenCuaHang;
        private System.Windows.Forms.PictureBox picLogo;


    }
}