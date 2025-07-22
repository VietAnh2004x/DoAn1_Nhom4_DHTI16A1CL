namespace DoAn.Forms.QLBaoHanh
{
    partial class frmLichSuBaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuBaoHanh));
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnLuu = new Button();
            grpThongTinLichSuBaoHanh = new GroupBox();
            dtpNgayBaoHanh = new DateTimePicker();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            txtMaNhanVien = new TextBox();
            lblMaNhanVien = new Label();
            txtNoiDungBaoHanh = new TextBox();
            labelNoiDungBaoHanh = new Label();
            txtMaBaoHanh = new TextBox();
            lblMaBaoHanh = new Label();
            lblNgayBaoHanh = new Label();
            lblTieuDe = new Label();
            lblDiaChi = new Label();
            lblTenCuaHang = new Label();
            picLogo = new PictureBox();
            grpThongTinLichSuBaoHanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(792, 535);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 38);
            btnThoat.TabIndex = 36;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(524, 535);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(97, 38);
            btnLamMoi.TabIndex = 35;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(273, 535);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(97, 38);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // grpThongTinLichSuBaoHanh
            // 
            grpThongTinLichSuBaoHanh.Controls.Add(dtpNgayBaoHanh);
            grpThongTinLichSuBaoHanh.Controls.Add(txtGhiChu);
            grpThongTinLichSuBaoHanh.Controls.Add(lblGhiChu);
            grpThongTinLichSuBaoHanh.Controls.Add(txtMaNhanVien);
            grpThongTinLichSuBaoHanh.Controls.Add(lblMaNhanVien);
            grpThongTinLichSuBaoHanh.Controls.Add(txtNoiDungBaoHanh);
            grpThongTinLichSuBaoHanh.Controls.Add(labelNoiDungBaoHanh);
            grpThongTinLichSuBaoHanh.Controls.Add(txtMaBaoHanh);
            grpThongTinLichSuBaoHanh.Controls.Add(lblMaBaoHanh);
            grpThongTinLichSuBaoHanh.Controls.Add(lblNgayBaoHanh);
            grpThongTinLichSuBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpThongTinLichSuBaoHanh.ForeColor = SystemColors.ActiveCaptionText;
            grpThongTinLichSuBaoHanh.Location = new Point(70, 232);
            grpThongTinLichSuBaoHanh.Margin = new Padding(3, 2, 3, 2);
            grpThongTinLichSuBaoHanh.Name = "grpThongTinLichSuBaoHanh";
            grpThongTinLichSuBaoHanh.Padding = new Padding(3, 2, 3, 2);
            grpThongTinLichSuBaoHanh.Size = new Size(994, 262);
            grpThongTinLichSuBaoHanh.TabIndex = 33;
            grpThongTinLichSuBaoHanh.TabStop = false;
            grpThongTinLichSuBaoHanh.Text = "Thông tin lịch sử bảo hành";
            // 
            // dtpNgayBaoHanh
            // 
            dtpNgayBaoHanh.Format = DateTimePickerFormat.Custom;
            dtpNgayBaoHanh.Location = new Point(679, 39);
            dtpNgayBaoHanh.Margin = new Padding(3, 2, 3, 2);
            dtpNgayBaoHanh.Name = "dtpNgayBaoHanh";
            dtpNgayBaoHanh.Size = new Size(268, 23);
            dtpNgayBaoHanh.TabIndex = 32;
            dtpNgayBaoHanh.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGhiChu.Location = new Point(679, 116);
            txtGhiChu.Margin = new Padding(3, 2, 3, 2);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(268, 23);
            txtGhiChu.TabIndex = 31;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGhiChu.Location = new Point(531, 119);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(51, 15);
            lblGhiChu.TabIndex = 30;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNhanVien.Location = new Point(193, 116);
            txtMaNhanVien.Margin = new Padding(3, 2, 3, 2);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(266, 23);
            txtMaNhanVien.TabIndex = 29;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNhanVien.Location = new Point(43, 119);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(82, 15);
            lblMaNhanVien.TabIndex = 28;
            lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtNoiDungBaoHanh
            // 
            txtNoiDungBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoiDungBaoHanh.Location = new Point(193, 195);
            txtNoiDungBaoHanh.Margin = new Padding(3, 2, 3, 2);
            txtNoiDungBaoHanh.Name = "txtNoiDungBaoHanh";
            txtNoiDungBaoHanh.Size = new Size(576, 23);
            txtNoiDungBaoHanh.TabIndex = 27;
            // 
            // labelNoiDungBaoHanh
            // 
            labelNoiDungBaoHanh.AutoSize = true;
            labelNoiDungBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNoiDungBaoHanh.Location = new Point(39, 197);
            labelNoiDungBaoHanh.Name = "labelNoiDungBaoHanh";
            labelNoiDungBaoHanh.Size = new Size(113, 15);
            labelNoiDungBaoHanh.TabIndex = 26;
            labelNoiDungBaoHanh.Text = "Nội dung bảo hành:";
            // 
            // txtMaBaoHanh
            // 
            txtMaBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaBaoHanh.Location = new Point(193, 39);
            txtMaBaoHanh.Margin = new Padding(3, 2, 3, 2);
            txtMaBaoHanh.Name = "txtMaBaoHanh";
            txtMaBaoHanh.Size = new Size(266, 23);
            txtMaBaoHanh.TabIndex = 13;
            // 
            // lblMaBaoHanh
            // 
            lblMaBaoHanh.AutoSize = true;
            lblMaBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaBaoHanh.Location = new Point(43, 41);
            lblMaBaoHanh.Name = "lblMaBaoHanh";
            lblMaBaoHanh.Size = new Size(80, 15);
            lblMaBaoHanh.TabIndex = 11;
            lblMaBaoHanh.Text = "Mã bảo hành:";
            // 
            // lblNgayBaoHanh
            // 
            lblNgayBaoHanh.AutoSize = true;
            lblNgayBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayBaoHanh.Location = new Point(531, 43);
            lblNgayBaoHanh.Name = "lblNgayBaoHanh";
            lblNgayBaoHanh.Size = new Size(91, 15);
            lblNgayBaoHanh.TabIndex = 5;
            lblNgayBaoHanh.Text = "Ngày bảo hành:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(1, 166);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1147, 64);
            lblTieuDe.TabIndex = 32;
            lblTieuDe.Text = "PHIẾU NHẬP LỊCH SỬ BẢO HÀNH";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(190, 102);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(281, 15);
            lblDiaChi.TabIndex = 31;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(188, 59);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(389, 30);
            lblTenCuaHang.TabIndex = 30;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(48, 49);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(127, 115);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 29;
            picLogo.TabStop = false;
            // 
            // frmLichSuBaoHanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 598);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(grpThongTinLichSuBaoHanh);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLichSuBaoHanh";
            Text = "frmLichSuBaoHanh";
            grpThongTinLichSuBaoHanh.ResumeLayout(false);
            grpThongTinLichSuBaoHanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnLuu;
        private GroupBox grpThongTinLichSuBaoHanh;
        private TextBox txtNoiDungBaoHanh;
        private Label labelNoiDungBaoHanh;
        private TextBox txtMaBaoHanh;
        private Label lblMaBaoHanh;
        private Label lblNgayBaoHanh;
        private Label lblTieuDe;
        private Label lblDiaChi;
        private Label lblTenCuaHang;
        private PictureBox picLogo;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
        private TextBox txtMaNhanVien;
        private Label lblMaNhanVien;
        private DateTimePicker dtpNgayBaoHanh;
    }
}