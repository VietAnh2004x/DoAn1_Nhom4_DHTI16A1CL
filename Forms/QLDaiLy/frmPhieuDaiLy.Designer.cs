namespace DoAn1.Forms.QLDaiLy
{
    partial class frmPhieuDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuDaiLy));
            lblTieuDe = new Label();
            lblDiaChi = new Label();
            lblTenCuaHang = new Label();
            picLogo = new PictureBox();
            grbThongTinDaiLy = new GroupBox();
            txtSoDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtTenDaiLy = new TextBox();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            lblDiaChiDaiLy = new Label();
            lblTenDaiLy = new Label();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grbThongTinDaiLy.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(-1, 202);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1312, 74);
            lblTieuDe.TabIndex = 12;
            lblTieuDe.Text = "PHIẾU THÔNG TIN ĐẠI LÝ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(229, 103);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(348, 20);
            lblDiaChi.TabIndex = 11;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(227, 45);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(477, 37);
            lblTenCuaHang.TabIndex = 10;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(63, 45);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(145, 154);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 9;
            picLogo.TabStop = false;
            // 
            // grbThongTinDaiLy
            // 
            grbThongTinDaiLy.Controls.Add(txtSoDienThoai);
            grbThongTinDaiLy.Controls.Add(txtEmail);
            grbThongTinDaiLy.Controls.Add(txtDiaChi);
            grbThongTinDaiLy.Controls.Add(txtTenDaiLy);
            grbThongTinDaiLy.Controls.Add(lblSoDienThoai);
            grbThongTinDaiLy.Controls.Add(lblEmail);
            grbThongTinDaiLy.Controls.Add(lblDiaChiDaiLy);
            grbThongTinDaiLy.Controls.Add(lblTenDaiLy);
            grbThongTinDaiLy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongTinDaiLy.Location = new Point(97, 312);
            grbThongTinDaiLy.Name = "grbThongTinDaiLy";
            grbThongTinDaiLy.Size = new Size(1116, 258);
            grbThongTinDaiLy.TabIndex = 13;
            grbThongTinDaiLy.TabStop = false;
            grbThongTinDaiLy.Text = "Thông tin đại lý";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(771, 162);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(265, 27);
            txtSoDienThoai.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(771, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(188, 162);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(265, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtTenDaiLy
            // 
            txtTenDaiLy.Location = new Point(188, 63);
            txtTenDaiLy.Name = "txtTenDaiLy";
            txtTenDaiLy.Size = new Size(265, 27);
            txtTenDaiLy.TabIndex = 6;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(648, 162);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 20);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(652, 68);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblDiaChiDaiLy
            // 
            lblDiaChiDaiLy.AutoSize = true;
            lblDiaChiDaiLy.Location = new Point(77, 162);
            lblDiaChiDaiLy.Name = "lblDiaChiDaiLy";
            lblDiaChiDaiLy.Size = new Size(58, 20);
            lblDiaChiDaiLy.TabIndex = 2;
            lblDiaChiDaiLy.Text = "Địa chỉ:";
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.AutoSize = true;
            lblTenDaiLy.Location = new Point(77, 68);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(75, 20);
            lblTenDaiLy.TabIndex = 1;
            lblTenDaiLy.Text = "Tên đại lý:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(868, 617);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(115, 55);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(601, 617);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(115, 55);
            btnLamMoi.TabIndex = 20;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(335, 617);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 55);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmPhieuDaiLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 709);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(grbThongTinDaiLy);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Name = "frmPhieuDaiLy";
            Text = "FormDaiLy";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grbThongTinDaiLy.ResumeLayout(false);
            grbThongTinDaiLy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenCuaHang;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grbThongTinDaiLy;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChiDaiLy;
        private System.Windows.Forms.Label lblTenDaiLy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;

    }
}