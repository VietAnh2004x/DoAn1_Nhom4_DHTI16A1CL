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
            txtTenKH = new TextBox();
            label3 = new Label();
            txtMaKH = new TextBox();
            label2 = new Label();
            txtTenXe = new TextBox();
            label1 = new Label();
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
            grpThongTinKhachHang.Controls.Add(txtTenKH);
            grpThongTinKhachHang.Controls.Add(label3);
            grpThongTinKhachHang.Controls.Add(txtMaKH);
            grpThongTinKhachHang.Controls.Add(label2);
            grpThongTinKhachHang.Controls.Add(txtTenXe);
            grpThongTinKhachHang.Controls.Add(label1);
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
            grpThongTinKhachHang.Location = new Point(55, 328);
            grpThongTinKhachHang.Margin = new Padding(4, 2, 4, 2);
            grpThongTinKhachHang.Name = "grpThongTinKhachHang";
            grpThongTinKhachHang.Padding = new Padding(4, 2, 4, 2);
            grpThongTinKhachHang.Size = new Size(1191, 342);
            grpThongTinKhachHang.TabIndex = 9;
            grpThongTinKhachHang.TabStop = false;
            grpThongTinKhachHang.Text = "Thông tin bảo hành";
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKH.Location = new Point(759, 115);
            txtTenKH.Margin = new Padding(4, 2, 4, 2);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(374, 31);
            txtTenKH.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(612, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 31;
            label3.Text = "Tên Khách Hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKH.Location = new Point(759, 56);
            txtMaKH.Margin = new Padding(4, 2, 4, 2);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(374, 31);
            txtMaKH.TabIndex = 30;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(612, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 29;
            label2.Text = "Mã Khách Hàng";
            // 
            // txtTenXe
            // 
            txtTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXe.Location = new Point(192, 111);
            txtTenXe.Margin = new Padding(4, 2, 4, 2);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(374, 31);
            txtTenXe.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 27;
            label1.Text = "Tên xe:";
            // 
            // nudThoiHan
            // 
            nudThoiHan.Location = new Point(769, 184);
            nudThoiHan.Margin = new Padding(4);
            nudThoiHan.Name = "nudThoiHan";
            nudThoiHan.Size = new Size(156, 31);
            nudThoiHan.TabIndex = 26;
            // 
            // lblNgayHetHan
            // 
            lblNgayHetHan.AutoSize = true;
            lblNgayHetHan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayHetHan.Location = new Point(615, 186);
            lblNgayHetHan.Margin = new Padding(4, 0, 4, 0);
            lblNgayHetHan.Name = "lblNgayHetHan";
            lblNgayHetHan.Size = new Size(84, 25);
            lblNgayHetHan.TabIndex = 25;
            lblNgayHetHan.Text = "Thời hạn:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(192, 246);
            dtpNgayLap.Margin = new Padding(4, 5, 4, 5);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(155, 31);
            dtpNgayLap.TabIndex = 24;
            dtpNgayLap.Value = new DateTime(2025, 7, 17, 8, 26, 22, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.Location = new Point(38, 255);
            lblNgayNhap.Margin = new Padding(4, 0, 4, 0);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(124, 25);
            lblNgayNhap.TabIndex = 23;
            lblNgayNhap.Text = "Ngày bắt đầu:";
            // 
            // txtMaXe
            // 
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXe.Location = new Point(192, 55);
            txtMaXe.Margin = new Padding(4, 2, 4, 2);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(374, 31);
            txtMaXe.TabIndex = 20;
            txtMaXe.TextChanged += txtMaXe_TextChanged;
            // 
            // lblMaXe
            // 
            lblMaXe.AutoSize = true;
            lblMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaXe.Location = new Point(45, 59);
            lblMaXe.Margin = new Padding(4, 0, 4, 0);
            lblMaXe.Name = "lblMaXe";
            lblMaXe.Size = new Size(63, 25);
            lblMaXe.TabIndex = 19;
            lblMaXe.Text = "Mã xe:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaHoaDon.Location = new Point(192, 180);
            txtMaHoaDon.Margin = new Padding(4, 2, 4, 2);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(374, 31);
            txtMaHoaDon.TabIndex = 18;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaHoaDon.Location = new Point(45, 184);
            lblMaHoaDon.Margin = new Padding(4, 0, 4, 0);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(113, 25);
            lblMaHoaDon.TabIndex = 17;
            lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(2, 242);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1310, 69);
            lblTieuDe.TabIndex = 8;
            lblTieuDe.Text = "PHIẾU BẢO HÀNH";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(276, 122);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(415, 25);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(271, 48);
            lblTenCuaHang.Margin = new Padding(4, 0, 4, 0);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(569, 45);
            lblTenCuaHang.TabIndex = 6;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(66, 48);
            picLogo.Margin = new Padding(4, 2, 4, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(181, 192);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(896, 716);
            btnThoat.Margin = new Padding(4, 2, 4, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(165, 58);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(582, 715);
            btnLamMoi.Margin = new Padding(4, 2, 4, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(165, 61);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(269, 715);
            btnThem.Margin = new Padding(4, 2, 4, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(165, 58);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmPhieuBaoHanh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 816);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(grpThongTinKhachHang);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(4, 2, 4, 2);
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
        private TextBox txtTenXe;
        private Label label1;
        private TextBox txtTenKH;
        private Label label3;
        private TextBox txtMaKH;
        private Label label2;
    }
}