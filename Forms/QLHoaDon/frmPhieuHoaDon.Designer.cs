namespace DoAn1.Forms.QLHoaDon
{
    partial class frmPhieuHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuHoaDon));
            lblTieuDe = new Label();
            lblDiaChi = new Label();
            lblTenCuaHang = new Label();
            picLogo = new PictureBox();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            grpThongTinKhachHang = new GroupBox();
            txtMaNV = new TextBox();
            label4 = new Label();
            txtMaKH = new TextBox();
            label3 = new Label();
            txtMaXe = new TextBox();
            label2 = new Label();
            cbbPTTT = new ComboBox();
            label1 = new Label();
            txtTongTien = new TextBox();
            txtKhuyenMai = new TextBox();
            txtGiaBan = new TextBox();
            lblTongTien = new Label();
            lblKhuyenMai = new Label();
            lblGiaBan = new Label();
            txtTenNhanVien = new TextBox();
            lblTenNhanVien = new Label();
            dtpNgayLap = new DateTimePicker();
            lblNgayNhap = new Label();
            txtTenKhachHang = new TextBox();
            lblTenKhachHang = new Label();
            txtTenXe = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpThongTinKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(0, 250);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1351, 82);
            lblTieuDe.TabIndex = 12;
            lblTieuDe.Text = "PHIẾU HÓA ĐƠN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(256, 131);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(415, 25);
            lblDiaChi.TabIndex = 11;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(251, 56);
            lblTenCuaHang.Margin = new Padding(4, 0, 4, 0);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(569, 45);
            lblTenCuaHang.TabIndex = 10;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(46, 40);
            picLogo.Margin = new Padding(4, 2, 4, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(181, 208);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 9;
            picLogo.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(892, 815);
            btnThoat.Margin = new Padding(4, 2, 4, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(165, 58);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(579, 814);
            btnLamMoi.Margin = new Padding(4, 2, 4, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(165, 61);
            btnLamMoi.TabIndex = 21;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(265, 814);
            btnThem.Margin = new Padding(4, 2, 4, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(165, 58);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grpThongTinKhachHang
            // 
            grpThongTinKhachHang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinKhachHang.Controls.Add(txtTenXe);
            grpThongTinKhachHang.Controls.Add(label5);
            grpThongTinKhachHang.Controls.Add(txtMaNV);
            grpThongTinKhachHang.Controls.Add(label4);
            grpThongTinKhachHang.Controls.Add(txtMaKH);
            grpThongTinKhachHang.Controls.Add(label3);
            grpThongTinKhachHang.Controls.Add(txtMaXe);
            grpThongTinKhachHang.Controls.Add(label2);
            grpThongTinKhachHang.Controls.Add(cbbPTTT);
            grpThongTinKhachHang.Controls.Add(label1);
            grpThongTinKhachHang.Controls.Add(txtTongTien);
            grpThongTinKhachHang.Controls.Add(txtKhuyenMai);
            grpThongTinKhachHang.Controls.Add(txtGiaBan);
            grpThongTinKhachHang.Controls.Add(lblTongTien);
            grpThongTinKhachHang.Controls.Add(lblKhuyenMai);
            grpThongTinKhachHang.Controls.Add(lblGiaBan);
            grpThongTinKhachHang.Controls.Add(txtTenNhanVien);
            grpThongTinKhachHang.Controls.Add(lblTenNhanVien);
            grpThongTinKhachHang.Controls.Add(dtpNgayLap);
            grpThongTinKhachHang.Controls.Add(lblNgayNhap);
            grpThongTinKhachHang.Controls.Add(txtTenKhachHang);
            grpThongTinKhachHang.Controls.Add(lblTenKhachHang);
            grpThongTinKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpThongTinKhachHang.ForeColor = SystemColors.ActiveCaptionText;
            grpThongTinKhachHang.Location = new Point(46, 348);
            grpThongTinKhachHang.Margin = new Padding(4, 2, 4, 2);
            grpThongTinKhachHang.Name = "grpThongTinKhachHang";
            grpThongTinKhachHang.Padding = new Padding(4, 2, 4, 2);
            grpThongTinKhachHang.Size = new Size(1260, 410);
            grpThongTinKhachHang.TabIndex = 19;
            grpThongTinKhachHang.TabStop = false;
            grpThongTinKhachHang.Text = "Thông tin hóa đơn";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.Location = new Point(822, 37);
            txtMaNV.Margin = new Padding(4, 2, 4, 2);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(290, 31);
            txtMaNV.TabIndex = 40;
            txtMaNV.Leave += txtMaNV_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(647, 41);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 39;
            label4.Text = "Mã nhân viên:";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKH.Location = new Point(205, 40);
            txtMaKH.Margin = new Padding(4, 2, 4, 2);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(279, 31);
            txtMaKH.TabIndex = 38;
            txtMaKH.Leave += txtMaKH_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 37;
            label3.Text = "Mã khách hàng:";
            // 
            // txtMaXe
            // 
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXe.Location = new Point(219, 232);
            txtMaXe.Margin = new Padding(4, 2, 4, 2);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(290, 31);
            txtMaXe.TabIndex = 36;
            txtMaXe.Leave += txtMaXe_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 236);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 35;
            label2.Text = "Mã Xe";
            // 
            // cbbPTTT
            // 
            cbbPTTT.FormattingEnabled = true;
            cbbPTTT.Location = new Point(281, 348);
            cbbPTTT.Name = "cbbPTTT";
            cbbPTTT.Size = new Size(213, 33);
            cbbPTTT.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 356);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 33;
            label1.Text = "Phương Thức Thanh Toán:";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(831, 321);
            txtTongTien.Margin = new Padding(4, 2, 4, 2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(290, 31);
            txtTongTien.TabIndex = 32;
            // 
            // txtKhuyenMai
            // 
            txtKhuyenMai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKhuyenMai.Location = new Point(822, 248);
            txtKhuyenMai.Margin = new Padding(4, 2, 4, 2);
            txtKhuyenMai.Name = "txtKhuyenMai";
            txtKhuyenMai.Size = new Size(290, 31);
            txtKhuyenMai.TabIndex = 31;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaBan.Location = new Point(822, 176);
            txtGiaBan.Margin = new Padding(4, 2, 4, 2);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(290, 31);
            txtGiaBan.TabIndex = 30;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(656, 324);
            lblTongTien.Margin = new Padding(4, 0, 4, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(91, 25);
            lblTongTien.TabIndex = 29;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // lblKhuyenMai
            // 
            lblKhuyenMai.AutoSize = true;
            lblKhuyenMai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKhuyenMai.Location = new Point(655, 251);
            lblKhuyenMai.Margin = new Padding(4, 0, 4, 0);
            lblKhuyenMai.Name = "lblKhuyenMai";
            lblKhuyenMai.Size = new Size(108, 25);
            lblKhuyenMai.TabIndex = 28;
            lblKhuyenMai.Text = "Khuyến mãi:";
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiaBan.Location = new Point(647, 180);
            lblGiaBan.Margin = new Padding(4, 0, 4, 0);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(76, 25);
            lblGiaBan.TabIndex = 27;
            lblGiaBan.Text = "Giá bán:";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNhanVien.Location = new Point(822, 88);
            txtTenNhanVien.Margin = new Padding(4, 2, 4, 2);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(290, 31);
            txtTenNhanVien.TabIndex = 26;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenNhanVien.Location = new Point(647, 92);
            lblTenNhanVien.Margin = new Padding(4, 0, 4, 0);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(123, 25);
            lblTenNhanVien.TabIndex = 25;
            lblTenNhanVien.Text = "Tên nhân viên:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(215, 163);
            dtpNgayLap.Margin = new Padding(4, 5, 4, 5);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(200, 31);
            dtpNgayLap.TabIndex = 24;
            dtpNgayLap.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.Location = new Point(48, 169);
            lblNgayNhap.Margin = new Padding(4, 0, 4, 0);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(83, 25);
            lblNgayNhap.TabIndex = 23;
            lblNgayNhap.Text = "Ngày lập";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKhachHang.Location = new Point(205, 91);
            txtTenKhachHang.Margin = new Padding(4, 2, 4, 2);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(279, 31);
            txtTenKhachHang.TabIndex = 22;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenKhachHang.Location = new Point(38, 94);
            lblTenKhachHang.Margin = new Padding(4, 0, 4, 0);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(138, 25);
            lblTenKhachHang.TabIndex = 21;
            lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // txtTenXe
            // 
            txtTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXe.Location = new Point(219, 289);
            txtTenXe.Margin = new Padding(4, 2, 4, 2);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(290, 31);
            txtTenXe.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 293);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 41;
            label5.Text = "Tên Xe";
            // 
            // frmPhieuHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 941);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(grpThongTinKhachHang);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPhieuHoaDon";
            Text = "PhieuHoaDonForm";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpThongTinKhachHang.ResumeLayout(false);
            grpThongTinKhachHang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenCuaHang;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grpThongTinKhachHang;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private Label lblTongTien;
        private Label lblKhuyenMai;
        private Label lblGiaBan;
        private TextBox txtGiaBan;
        private TextBox txtTongTien;
        private TextBox txtKhuyenMai;
        private Label label1;
        private ComboBox cbbPTTT;
        private TextBox txtMaXe;
        private Label label2;
        private TextBox txtMaNV;
        private Label label4;
        private TextBox txtMaKH;
        private Label label3;
        private TextBox txtTenXe;
        private Label label5;
    }
}