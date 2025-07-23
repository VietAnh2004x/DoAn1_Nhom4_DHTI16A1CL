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
            dtpNgayGiaoDich.Location = new Point(794, 330);
            dtpNgayGiaoDich.Name = "dtpNgayGiaoDich";
            dtpNgayGiaoDich.Size = new Size(241, 27);
            dtpNgayGiaoDich.TabIndex = 30;
            dtpNgayGiaoDich.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayNhap.Location = new Point(661, 335);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(113, 20);
            lblNgayNhap.TabIndex = 29;
            lblNgayNhap.Text = "Ngày giao dịch:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(894, 755);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 51);
            btnThoat.TabIndex = 28;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(587, 755);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(128, 51);
            btnLamMoi.TabIndex = 27;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(300, 755);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(128, 51);
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
            grpThongTinXeCu.Location = new Point(80, 299);
            grpThongTinXeCu.Name = "grpThongTinXeCu";
            grpThongTinXeCu.Size = new Size(1136, 418);
            grpThongTinXeCu.TabIndex = 25;
            grpThongTinXeCu.TabStop = false;
            grpThongTinXeCu.Text = "Thông tin xe cũ";
            // 
            // txtTenXeDoi
            // 
            txtTenXeDoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXeDoi.Location = new Point(794, 260);
            txtTenXeDoi.Name = "txtTenXeDoi";
            txtTenXeDoi.Size = new Size(241, 27);
            txtTenXeDoi.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(661, 267);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 39;
            label5.Text = "Tên xe đổi:";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.Location = new Point(794, 128);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(241, 27);
            txtMaNV.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(663, 131);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 37;
            label4.Text = "Mã nhân viên:";
            // 
            // txtMaXeDoi
            // 
            txtMaXeDoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXeDoi.Location = new Point(794, 196);
            txtMaXeDoi.Name = "txtMaXeDoi";
            txtMaXeDoi.Size = new Size(241, 27);
            txtMaXeDoi.TabIndex = 34;
            txtMaXeDoi.Leave += txtMaXeDoi_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(663, 199);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 33;
            label2.Text = "Mã xe đổi:";
            // 
            // txtNamSanXuat
            // 
            txtNamSanXuat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamSanXuat.Location = new Point(184, 128);
            txtNamSanXuat.Name = "txtNamSanXuat";
            txtNamSanXuat.Size = new Size(225, 27);
            txtNamSanXuat.TabIndex = 27;
            // 
            // labelNamSanXuat
            // 
            labelNamSanXuat.AutoSize = true;
            labelNamSanXuat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNamSanXuat.Location = new Point(57, 131);
            labelNamSanXuat.Name = "labelNamSanXuat";
            labelNamSanXuat.Size = new Size(102, 20);
            labelNamSanXuat.TabIndex = 26;
            labelNamSanXuat.Text = "Năm sản xuất:";
            // 
            // txtGiaDinhGia
            // 
            txtGiaDinhGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaDinhGia.Location = new Point(184, 332);
            txtGiaDinhGia.Name = "txtGiaDinhGia";
            txtGiaDinhGia.Size = new Size(225, 27);
            txtGiaDinhGia.TabIndex = 25;
            // 
            // txtSoKmDaDi
            // 
            txtSoKmDaDi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoKmDaDi.Location = new Point(184, 264);
            txtSoKmDaDi.Name = "txtSoKmDaDi";
            txtSoKmDaDi.Size = new Size(225, 27);
            txtSoKmDaDi.TabIndex = 24;
            // 
            // lblSoKmDaDi
            // 
            lblSoKmDaDi.AutoSize = true;
            lblSoKmDaDi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoKmDaDi.Location = new Point(57, 267);
            lblSoKmDaDi.Name = "lblSoKmDaDi";
            lblSoKmDaDi.Size = new Size(91, 20);
            lblSoKmDaDi.TabIndex = 23;
            lblSoKmDaDi.Text = "Số km đã đi:";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTinhTrang.Location = new Point(184, 196);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(400, 27);
            txtTinhTrang.TabIndex = 22;
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.AutoSize = true;
            lblGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiaNhap.Location = new Point(57, 335);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(96, 20);
            lblGiaNhap.TabIndex = 21;
            lblGiaNhap.Text = "Giá định giá :";
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTinhTrang.Location = new Point(57, 199);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(76, 20);
            lblTinhTrang.TabIndex = 20;
            lblTinhTrang.Text = "Tình trạng";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKhachHang.Location = new Point(794, 60);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(241, 27);
            txtMaKhachHang.TabIndex = 19;
            // 
            // txtTenXeCu
            // 
            txtTenXeCu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXeCu.Location = new Point(184, 60);
            txtTenXeCu.Name = "txtTenXeCu";
            txtTenXeCu.Size = new Size(225, 27);
            txtTenXeCu.TabIndex = 13;
            // 
            // lblTenXe
            // 
            lblTenXe.AutoSize = true;
            lblTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenXe.Location = new Point(57, 63);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(73, 20);
            lblTenXe.TabIndex = 11;
            lblTenXe.Text = "Tên xe cũ:";
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenNhanVien.Location = new Point(661, 63);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(112, 20);
            lblTenNhanVien.TabIndex = 5;
            lblTenNhanVien.Text = "Mã khách hàng:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(1, 211);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1311, 85);
            lblTieuDe.TabIndex = 24;
            lblTieuDe.Text = "PHIẾU GIAO DỊCH XE CŨ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(218, 126);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(348, 20);
            lblDiaChi.TabIndex = 23;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(215, 68);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(477, 37);
            lblTenCuaHang.TabIndex = 22;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(54, 55);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(145, 154);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 21;
            picLogo.TabStop = false;
            // 
            // frmNhapXeCu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 840);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(grpThongTinXeCu);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
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