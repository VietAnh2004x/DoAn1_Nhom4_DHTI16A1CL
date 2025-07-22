namespace DoAn.Forms.QLHoaDon
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
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpThongTinKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(0, 150);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(946, 49);
            lblTieuDe.TabIndex = 12;
            lblTieuDe.Text = "PHIẾU HÓA ĐƠN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(179, 79);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(281, 15);
            lblDiaChi.TabIndex = 11;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(176, 34);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(389, 30);
            lblTenCuaHang.TabIndex = 10;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(32, 24);
            picLogo.Margin = new Padding(3, 1, 3, 1);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(127, 125);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 9;
            picLogo.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(626, 499);
            btnThoat.Margin = new Padding(3, 1, 3, 1);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 35);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(407, 498);
            btnLamMoi.Margin = new Padding(3, 1, 3, 1);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(116, 37);
            btnLamMoi.TabIndex = 21;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(188, 498);
            btnThem.Margin = new Padding(3, 1, 3, 1);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 35);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grpThongTinKhachHang
            // 
            grpThongTinKhachHang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            grpThongTinKhachHang.Location = new Point(32, 209);
            grpThongTinKhachHang.Margin = new Padding(3, 1, 3, 1);
            grpThongTinKhachHang.Name = "grpThongTinKhachHang";
            grpThongTinKhachHang.Padding = new Padding(3, 1, 3, 1);
            grpThongTinKhachHang.Size = new Size(882, 260);
            grpThongTinKhachHang.TabIndex = 19;
            grpThongTinKhachHang.TabStop = false;
            grpThongTinKhachHang.Text = "Thông tin hóa đơn";
            // 
            // txtMaXe
            // 
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXe.Location = new Point(197, 153);
            txtMaXe.Margin = new Padding(3, 1, 3, 1);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(204, 23);
            txtMaXe.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 156);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 35;
            label2.Text = "Mã Xe";
            // 
            // cbbPTTT
            // 
            cbbPTTT.FormattingEnabled = true;
            cbbPTTT.Location = new Point(197, 214);
            cbbPTTT.Margin = new Padding(2, 2, 2, 2);
            cbbPTTT.Name = "cbbPTTT";
            cbbPTTT.Size = new Size(150, 23);
            cbbPTTT.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 217);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 33;
            label1.Text = "Phương Thức Thanh Toán:";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(575, 214);
            txtTongTien.Margin = new Padding(3, 1, 3, 1);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(204, 23);
            txtTongTien.TabIndex = 32;
            // 
            // txtKhuyenMai
            // 
            txtKhuyenMai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKhuyenMai.Location = new Point(575, 153);
            txtKhuyenMai.Margin = new Padding(3, 1, 3, 1);
            txtKhuyenMai.Name = "txtKhuyenMai";
            txtKhuyenMai.Size = new Size(204, 23);
            txtKhuyenMai.TabIndex = 31;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaBan.Location = new Point(575, 89);
            txtGiaBan.Margin = new Padding(3, 1, 3, 1);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(204, 23);
            txtGiaBan.TabIndex = 30;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(458, 217);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(61, 15);
            lblTongTien.TabIndex = 29;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // lblKhuyenMai
            // 
            lblKhuyenMai.AutoSize = true;
            lblKhuyenMai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKhuyenMai.Location = new Point(458, 156);
            lblKhuyenMai.Name = "lblKhuyenMai";
            lblKhuyenMai.Size = new Size(73, 15);
            lblKhuyenMai.TabIndex = 28;
            lblKhuyenMai.Text = "Khuyến mãi:";
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiaBan.Location = new Point(458, 95);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(50, 15);
            lblGiaBan.TabIndex = 27;
            lblGiaBan.Text = "Giá bán:";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNhanVien.Location = new Point(575, 31);
            txtTenNhanVien.Margin = new Padding(3, 1, 3, 1);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(204, 23);
            txtTenNhanVien.TabIndex = 26;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenNhanVien.Location = new Point(458, 34);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(84, 15);
            lblTenNhanVien.TabIndex = 25;
            lblTenNhanVien.Text = "Tên nhân viên:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(197, 89);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(141, 23);
            dtpNgayLap.TabIndex = 24;
            dtpNgayLap.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.Location = new Point(31, 95);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(54, 15);
            lblNgayNhap.TabIndex = 23;
            lblNgayNhap.Text = "Ngày lập";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKhachHang.Location = new Point(197, 31);
            txtTenKhachHang.Margin = new Padding(3, 1, 3, 1);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(196, 23);
            txtTenKhachHang.TabIndex = 22;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenKhachHang.Location = new Point(31, 34);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(94, 15);
            lblTenKhachHang.TabIndex = 21;
            lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // frmPhieuHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 565);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThem);
            Controls.Add(grpThongTinKhachHang);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
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
    }
}