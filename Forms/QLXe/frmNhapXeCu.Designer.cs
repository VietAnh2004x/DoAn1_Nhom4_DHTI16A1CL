namespace DoAn.Forms.QLXe
{
    partial class frmNhapXeCu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapXeCu));
            dtpNgayGiaoDich = new DateTimePicker();
            lblNgayNhap = new Label();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnLuu = new Button();
            grpThongTinXeCu = new GroupBox();
            txtTenXeDoi = new TextBox();
            label5 = new Label();
            txtMaNV = new TextBox();
            label4 = new Label();
            txtMaXeDoi = new TextBox();
            label2 = new Label();
            txtNamSanXuat = new TextBox();
            labelNamSanXuat = new Label();
            txtGiaDinhGia = new TextBox();
            txtSoKmDaDi = new TextBox();
            lblSoKmDaDi = new Label();
            txtTinhTrang = new TextBox();
            lblGiaNhap = new Label();
            lblTinhTrang = new Label();
            txtMaKhachHang = new TextBox();
            txtTenXeCu = new TextBox();
            lblTenXe = new Label();
            lblTenNhanVien = new Label();
            lblTieuDe = new Label();
            lblDiaChi = new Label();
            lblTenCuaHang = new Label();
            picLogo = new PictureBox();
            grpThongTinXeCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // dtpNgayGiaoDich
            // 
            dtpNgayGiaoDich.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayGiaoDich.Format = DateTimePickerFormat.Short;
            dtpNgayGiaoDich.Location = new Point(982, 375);
            dtpNgayGiaoDich.Margin = new Padding(4);
            dtpNgayGiaoDich.Name = "dtpNgayGiaoDich";
            dtpNgayGiaoDich.Size = new Size(253, 31);
            dtpNgayGiaoDich.TabIndex = 30;
            dtpNgayGiaoDich.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayNhap.Location = new Point(816, 379);
            lblNgayNhap.Margin = new Padding(4, 0, 4, 0);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(136, 25);
            lblNgayNhap.TabIndex = 29;
            lblNgayNhap.Text = "Ngày giao dịch:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(1125, 908);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 64);
            btnThoat.TabIndex = 28;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(741, 908);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(139, 64);
            btnLamMoi.TabIndex = 27;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(382, 908);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(139, 64);
            btnLuu.TabIndex = 26;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // grpThongTinXeCu
            // 
            grpThongTinXeCu.Controls.Add(txtTenXeDoi);
            grpThongTinXeCu.Controls.Add(label5);
            grpThongTinXeCu.Controls.Add(txtMaNV);
            grpThongTinXeCu.Controls.Add(label4);
            grpThongTinXeCu.Controls.Add(txtMaXeDoi);
            grpThongTinXeCu.Controls.Add(label2);
            grpThongTinXeCu.Controls.Add(dtpNgayGiaoDich);
            grpThongTinXeCu.Controls.Add(txtNamSanXuat);
            grpThongTinXeCu.Controls.Add(lblNgayNhap);
            grpThongTinXeCu.Controls.Add(labelNamSanXuat);
            grpThongTinXeCu.Controls.Add(txtGiaDinhGia);
            grpThongTinXeCu.Controls.Add(txtSoKmDaDi);
            grpThongTinXeCu.Controls.Add(lblSoKmDaDi);
            grpThongTinXeCu.Controls.Add(txtTinhTrang);
            grpThongTinXeCu.Controls.Add(lblGiaNhap);
            grpThongTinXeCu.Controls.Add(lblTinhTrang);
            grpThongTinXeCu.Controls.Add(txtMaKhachHang);
            grpThongTinXeCu.Controls.Add(txtTenXeCu);
            grpThongTinXeCu.Controls.Add(lblTenXe);
            grpThongTinXeCu.Controls.Add(lblTenNhanVien);
            grpThongTinXeCu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpThongTinXeCu.ForeColor = SystemColors.ActiveCaptionText;
            grpThongTinXeCu.Location = new Point(100, 374);
            grpThongTinXeCu.Margin = new Padding(4);
            grpThongTinXeCu.Name = "grpThongTinXeCu";
            grpThongTinXeCu.Padding = new Padding(4);
            grpThongTinXeCu.Size = new Size(1420, 459);
            grpThongTinXeCu.TabIndex = 25;
            grpThongTinXeCu.TabStop = false;
            grpThongTinXeCu.Text = "Thông tin xe cũ";
            // 
            // txtTenXeDoi
            // 
            txtTenXeDoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXeDoi.Location = new Point(982, 301);
            txtTenXeDoi.Margin = new Padding(4);
            txtTenXeDoi.Name = "txtTenXeDoi";
            txtTenXeDoi.Size = new Size(253, 31);
            txtTenXeDoi.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(816, 305);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 39;
            label5.Text = "Tên xe đổi:";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.Location = new Point(982, 127);
            txtMaNV.Margin = new Padding(4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(253, 31);
            txtMaNV.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(816, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 37;
            label4.Text = "Mã nhân viên:";
            // 
            // txtMaXeDoi
            // 
            txtMaXeDoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXeDoi.Location = new Point(982, 216);
            txtMaXeDoi.Margin = new Padding(4);
            txtMaXeDoi.Name = "txtMaXeDoi";
            txtMaXeDoi.Size = new Size(253, 31);
            txtMaXeDoi.TabIndex = 34;
            txtMaXeDoi.Leave += txtMaXeDoi_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(816, 220);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 33;
            label2.Text = "Mã xe đổi:";
            // 
            // txtNamSanXuat
            // 
            txtNamSanXuat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamSanXuat.Location = new Point(221, 100);
            txtNamSanXuat.Margin = new Padding(4);
            txtNamSanXuat.Name = "txtNamSanXuat";
            txtNamSanXuat.Size = new Size(239, 31);
            txtNamSanXuat.TabIndex = 27;
            // 
            // labelNamSanXuat
            // 
            labelNamSanXuat.AutoSize = true;
            labelNamSanXuat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNamSanXuat.Location = new Point(55, 104);
            labelNamSanXuat.Margin = new Padding(4, 0, 4, 0);
            labelNamSanXuat.Name = "labelNamSanXuat";
            labelNamSanXuat.Size = new Size(124, 25);
            labelNamSanXuat.TabIndex = 26;
            labelNamSanXuat.Text = "Năm sản xuất:";
            // 
            // txtGiaDinhGia
            // 
            txtGiaDinhGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaDinhGia.Location = new Point(221, 350);
            txtGiaDinhGia.Margin = new Padding(4);
            txtGiaDinhGia.Name = "txtGiaDinhGia";
            txtGiaDinhGia.Size = new Size(239, 31);
            txtGiaDinhGia.TabIndex = 25;
            // 
            // txtSoKmDaDi
            // 
            txtSoKmDaDi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoKmDaDi.Location = new Point(221, 253);
            txtSoKmDaDi.Margin = new Padding(4);
            txtSoKmDaDi.Name = "txtSoKmDaDi";
            txtSoKmDaDi.Size = new Size(239, 31);
            txtSoKmDaDi.TabIndex = 24;
            // 
            // lblSoKmDaDi
            // 
            lblSoKmDaDi.AutoSize = true;
            lblSoKmDaDi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoKmDaDi.Location = new Point(61, 253);
            lblSoKmDaDi.Margin = new Padding(4, 0, 4, 0);
            lblSoKmDaDi.Name = "lblSoKmDaDi";
            lblSoKmDaDi.Size = new Size(112, 25);
            lblSoKmDaDi.TabIndex = 23;
            lblSoKmDaDi.Text = "Số km đã đi:";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTinhTrang.Location = new Point(221, 168);
            txtTinhTrang.Margin = new Padding(4);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(499, 31);
            txtTinhTrang.TabIndex = 22;
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.AutoSize = true;
            lblGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiaNhap.Location = new Point(61, 357);
            lblGiaNhap.Margin = new Padding(4, 0, 4, 0);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(115, 25);
            lblGiaNhap.TabIndex = 21;
            lblGiaNhap.Text = "Giá định giá :";
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTinhTrang.Location = new Point(61, 175);
            lblTinhTrang.Margin = new Padding(4, 0, 4, 0);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(92, 25);
            lblTinhTrang.TabIndex = 20;
            lblTinhTrang.Text = "Tình trạng";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKhachHang.Location = new Point(982, 48);
            txtMaKhachHang.Margin = new Padding(4);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(253, 31);
            txtMaKhachHang.TabIndex = 19;
            // 
            // txtTenXeCu
            // 
            txtTenXeCu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXeCu.Location = new Point(221, 44);
            txtTenXeCu.Margin = new Padding(4);
            txtTenXeCu.Name = "txtTenXeCu";
            txtTenXeCu.Size = new Size(239, 31);
            txtTenXeCu.TabIndex = 13;
            // 
            // lblTenXe
            // 
            lblTenXe.AutoSize = true;
            lblTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenXe.Location = new Point(55, 48);
            lblTenXe.Margin = new Padding(4, 0, 4, 0);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(87, 25);
            lblTenXe.TabIndex = 11;
            lblTenXe.Text = "Tên xe cũ:";
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenNhanVien.Location = new Point(815, 54);
            lblTenNhanVien.Margin = new Padding(4, 0, 4, 0);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(137, 25);
            lblTenNhanVien.TabIndex = 5;
            lblTenNhanVien.Text = "Mã khách hàng:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(1, 264);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1639, 106);
            lblTieuDe.TabIndex = 24;
            lblTieuDe.Text = "PHIẾU GIAO DỊCH XE CŨ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(272, 158);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(415, 25);
            lblDiaChi.TabIndex = 23;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(269, 85);
            lblTenCuaHang.Margin = new Padding(4, 0, 4, 0);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(569, 45);
            lblTenCuaHang.TabIndex = 22;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(68, 69);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(181, 192);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 21;
            picLogo.TabStop = false;
            // 
            // frmNhapXeCu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 1050);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(grpThongTinXeCu);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(4);
            Name = "frmNhapXeCu";
            Text = "frmNhapXeCu";
            grpThongTinXeCu.ResumeLayout(false);
            grpThongTinXeCu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayGiaoDich;
        private Label lblNgayNhap;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnLuu;
        private GroupBox grpThongTinXeCu;
        private TextBox txtGiaDinhGia;
        private TextBox txtSoKmDaDi;
        private Label lblSoKmDaDi;
        private TextBox txtTinhTrang;
        private Label lblGiaNhap;
        private Label lblTinhTrang;
        private TextBox txtMaKhachHang;
        private TextBox txtTenXeCu;
        private Label lblTenXe;
        private Label lblTenNhanVien;
        private Label lblTieuDe;
        private Label lblDiaChi;
        private Label lblTenCuaHang;
        private PictureBox picLogo;
        private TextBox txtNamSanXuat;
        private Label labelNamSanXuat;
        private TextBox txtMaXeDoi;
        private Label label2;
        private TextBox txtMaNV;
        private Label label4;
        private TextBox txtTenXeDoi;
        private Label label5;
    }
}