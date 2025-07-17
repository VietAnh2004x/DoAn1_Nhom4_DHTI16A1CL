namespace DoAn1.Forms.QLBaoHanh
{
    partial class frmPhieuBaoHanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuBaoHanh));
            grpThongTinKhachHang = new GroupBox();
            nudThoiHan = new NumericUpDown();
            lblNgayHetHan = new Label();
            dtpNgayLap = new DateTimePicker();
            lblNgayNhap = new Label();
            txtMaXe = new TextBox();
            lblMaXe = new Label();
            txtMaHoaDon = new TextBox();
            lblMaHoaDon = new Label();
            lblTieuDe = new Label();
            lblDiaChi = new Label();
            lblTenCuaHang = new Label();
            picLogo = new PictureBox();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            grpThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudThoiHan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinKhachHang
            // 
            grpThongTinKhachHang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinKhachHang.Controls.Add(nudThoiHan);
            grpThongTinKhachHang.Controls.Add(lblNgayHetHan);
            grpThongTinKhachHang.Controls.Add(dtpNgayLap);
            grpThongTinKhachHang.Controls.Add(lblNgayNhap);
            grpThongTinKhachHang.Controls.Add(txtMaXe);
            grpThongTinKhachHang.Controls.Add(lblMaXe);
            grpThongTinKhachHang.Controls.Add(txtMaHoaDon);
            grpThongTinKhachHang.Controls.Add(lblMaHoaDon);
            grpThongTinKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpThongTinKhachHang.ForeColor = SystemColors.ActiveCaptionText;
            grpThongTinKhachHang.Location = new Point(44, 262);
            grpThongTinKhachHang.Margin = new Padding(3, 2, 3, 2);
            grpThongTinKhachHang.Name = "grpThongTinKhachHang";
            grpThongTinKhachHang.Padding = new Padding(3, 2, 3, 2);
            grpThongTinKhachHang.Size = new Size(953, 274);
            grpThongTinKhachHang.TabIndex = 9;
            grpThongTinKhachHang.TabStop = false;
            grpThongTinKhachHang.Text = "Thông tin bảo hành";
            // 
            // nudThoiHan
            // 
            nudThoiHan.Location = new Point(706, 182);
            nudThoiHan.Name = "nudThoiHan";
            nudThoiHan.Size = new Size(125, 27);
            nudThoiHan.TabIndex = 26;
            // 
            // lblNgayHetHan
            // 
            lblNgayHetHan.AutoSize = true;
            lblNgayHetHan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayHetHan.Location = new Point(582, 184);
            lblNgayHetHan.Name = "lblNgayHetHan";
            lblNgayHetHan.Size = new Size(69, 20);
            lblNgayHetHan.TabIndex = 25;
            lblNgayHetHan.Text = "Thời hạn:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(706, 101);
            dtpNgayLap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(125, 27);
            dtpNgayLap.TabIndex = 24;
            dtpNgayLap.Value = new DateTime(2025, 7, 17, 8, 26, 22, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.Location = new Point(582, 108);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(102, 20);
            lblNgayNhap.TabIndex = 23;
            lblNgayNhap.Text = "Ngày bắt đầu:";
            // 
            // txtMaXe
            // 
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXe.Location = new Point(181, 100);
            txtMaXe.Margin = new Padding(3, 2, 3, 2);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(300, 27);
            txtMaXe.TabIndex = 20;
            // 
            // lblMaXe
            // 
            lblMaXe.AutoSize = true;
            lblMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaXe.Location = new Point(63, 103);
            lblMaXe.Name = "lblMaXe";
            lblMaXe.Size = new Size(52, 20);
            lblMaXe.TabIndex = 19;
            lblMaXe.Text = "Mã xe:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaHoaDon.Location = new Point(181, 184);
            txtMaHoaDon.Margin = new Padding(3, 2, 3, 2);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(300, 27);
            txtMaHoaDon.TabIndex = 18;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaHoaDon.Location = new Point(63, 187);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(92, 20);
            lblMaHoaDon.TabIndex = 17;
            lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(2, 194);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1048, 55);
            lblTieuDe.TabIndex = 8;
            lblTieuDe.Text = "PHIẾU BẢO HÀNH";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(221, 98);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(348, 20);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(217, 38);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(477, 37);
            lblTenCuaHang.TabIndex = 6;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(53, 38);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(145, 154);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(717, 573);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(132, 46);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(466, 572);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(132, 49);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(215, 572);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(132, 46);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmPhieuBaoHanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 653);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(grpThongTinKhachHang);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPhieuBaoHanh";
            Text = "PhieuBaoHanh";
            grpThongTinKhachHang.ResumeLayout(false);
            grpThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudThoiHan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.GroupBox grpThongTinKhachHang;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenCuaHang;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNgayHetHan;
        private NumericUpDown nudThoiHan;
    }
}