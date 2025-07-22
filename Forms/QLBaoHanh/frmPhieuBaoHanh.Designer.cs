namespace DoAn.Forms.QLBaoHanh
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
            grpThongTinKhachHang.Location = new Point(38, 197);
            grpThongTinKhachHang.Margin = new Padding(3, 1, 3, 1);
            grpThongTinKhachHang.Name = "grpThongTinKhachHang";
            grpThongTinKhachHang.Padding = new Padding(3, 1, 3, 1);
            grpThongTinKhachHang.Size = new Size(834, 213);
            grpThongTinKhachHang.TabIndex = 9;
            grpThongTinKhachHang.TabStop = false;
            grpThongTinKhachHang.Text = "Thông tin bảo hành";
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKH.Location = new Point(538, 76);
            txtTenKH.Margin = new Padding(3, 1, 3, 1);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(263, 23);
            txtTenKH.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(428, 79);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 31;
            label3.Text = "Tên Khách Hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKH.Location = new Point(538, 32);
            txtMaKH.Margin = new Padding(3, 1, 3, 1);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(263, 23);
            txtMaKH.TabIndex = 30;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(428, 35);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 29;
            label2.Text = "Mã Khách Hàng";
            // 
            // txtTenXe
            // 
            txtTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXe.Location = new Point(134, 76);
            txtTenXe.Margin = new Padding(3, 1, 3, 1);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(263, 23);
            txtTenXe.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 79);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 27;
            label1.Text = "Tên xe:";
            // 
            // nudThoiHan
            // 
            nudThoiHan.Location = new Point(538, 120);
            nudThoiHan.Margin = new Padding(3, 2, 3, 2);
            nudThoiHan.Name = "nudThoiHan";
            nudThoiHan.Size = new Size(109, 23);
            nudThoiHan.TabIndex = 26;
            // 
            // lblNgayHetHan
            // 
            lblNgayHetHan.AutoSize = true;
            lblNgayHetHan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayHetHan.Location = new Point(428, 123);
            lblNgayHetHan.Name = "lblNgayHetHan";
            lblNgayHetHan.Size = new Size(57, 15);
            lblNgayHetHan.TabIndex = 25;
            lblNgayHetHan.Text = "Thời hạn:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(410, 166);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(110, 23);
            dtpNgayLap.TabIndex = 24;
            dtpNgayLap.Value = new DateTime(2025, 7, 17, 8, 26, 22, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.Location = new Point(308, 172);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(81, 15);
            lblNgayNhap.TabIndex = 23;
            lblNgayNhap.Text = "Ngày bắt đầu:";
            // 
            // txtMaXe
            // 
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXe.Location = new Point(134, 32);
            txtMaXe.Margin = new Padding(3, 1, 3, 1);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(263, 23);
            txtMaXe.TabIndex = 20;
            txtMaXe.TextChanged += txtMaXe_TextChanged;
            // 
            // lblMaXe
            // 
            lblMaXe.AutoSize = true;
            lblMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaXe.Location = new Point(32, 35);
            lblMaXe.Name = "lblMaXe";
            lblMaXe.Size = new Size(41, 15);
            lblMaXe.TabIndex = 19;
            lblMaXe.Text = "Mã xe:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaHoaDon.Location = new Point(134, 120);
            txtMaHoaDon.Margin = new Padding(3, 1, 3, 1);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(263, 23);
            txtMaHoaDon.TabIndex = 18;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaHoaDon.Location = new Point(32, 123);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(74, 15);
            lblMaHoaDon.TabIndex = 17;
            lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(1, 145);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(917, 41);
            lblTieuDe.TabIndex = 8;
            lblTieuDe.Text = "PHIẾU BẢO HÀNH";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(193, 73);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(281, 15);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(190, 29);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(389, 30);
            lblTenCuaHang.TabIndex = 6;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(46, 29);
            picLogo.Margin = new Padding(3, 1, 3, 1);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(127, 115);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(626, 430);
            btnThoat.Margin = new Padding(3, 1, 3, 1);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 35);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(407, 429);
            btnLamMoi.Margin = new Padding(3, 1, 3, 1);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(116, 37);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(188, 429);
            btnThem.Margin = new Padding(3, 1, 3, 1);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 35);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmPhieuBaoHanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 490);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(grpThongTinKhachHang);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(3, 1, 3, 1);
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