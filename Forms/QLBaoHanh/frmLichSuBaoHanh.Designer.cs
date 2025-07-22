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
            btnThoat.Location = new Point(1132, 891);
            btnThoat.Margin = new Padding(4, 4, 4, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 64);
            btnThoat.TabIndex = 36;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(749, 891);
            btnLamMoi.Margin = new Padding(4, 4, 4, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(139, 64);
            btnLamMoi.TabIndex = 35;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(390, 891);
            btnLuu.Margin = new Padding(4, 4, 4, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(139, 64);
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
            grpThongTinLichSuBaoHanh.Location = new Point(100, 386);
            grpThongTinLichSuBaoHanh.Margin = new Padding(4, 4, 4, 4);
            grpThongTinLichSuBaoHanh.Name = "grpThongTinLichSuBaoHanh";
            grpThongTinLichSuBaoHanh.Padding = new Padding(4, 4, 4, 4);
            grpThongTinLichSuBaoHanh.Size = new Size(1420, 436);
            grpThongTinLichSuBaoHanh.TabIndex = 33;
            grpThongTinLichSuBaoHanh.TabStop = false;
            grpThongTinLichSuBaoHanh.Text = "Thông tin lịch sử bảo hành";
            // 
            // dtpNgayBaoHanh
            // 
            dtpNgayBaoHanh.Format = DateTimePickerFormat.Custom;
            dtpNgayBaoHanh.Location = new Point(970, 65);
            dtpNgayBaoHanh.Margin = new Padding(4, 4, 4, 4);
            dtpNgayBaoHanh.Name = "dtpNgayBaoHanh";
            dtpNgayBaoHanh.Size = new Size(381, 31);
            dtpNgayBaoHanh.TabIndex = 32;
            dtpNgayBaoHanh.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGhiChu.Location = new Point(970, 166);
            txtGhiChu.Margin = new Padding(4, 4, 4, 4);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(381, 31);
            txtGhiChu.TabIndex = 31;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGhiChu.Location = new Point(756, 169);
            lblGhiChu.Margin = new Padding(4, 0, 4, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(75, 25);
            lblGhiChu.TabIndex = 30;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNhanVien.Location = new Point(276, 166);
            txtMaNhanVien.Margin = new Padding(4, 4, 4, 4);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(378, 31);
            txtMaNhanVien.TabIndex = 29;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNhanVien.Location = new Point(62, 175);
            lblMaNhanVien.Margin = new Padding(4, 0, 4, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(122, 25);
            lblMaNhanVien.TabIndex = 28;
            lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtNoiDungBaoHanh
            // 
            txtNoiDungBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoiDungBaoHanh.Location = new Point(276, 325);
            txtNoiDungBaoHanh.Margin = new Padding(4, 4, 4, 4);
            txtNoiDungBaoHanh.Name = "txtNoiDungBaoHanh";
            txtNoiDungBaoHanh.Size = new Size(821, 31);
            txtNoiDungBaoHanh.TabIndex = 27;
            // 
            // labelNoiDungBaoHanh
            // 
            labelNoiDungBaoHanh.AutoSize = true;
            labelNoiDungBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNoiDungBaoHanh.Location = new Point(56, 329);
            labelNoiDungBaoHanh.Margin = new Padding(4, 0, 4, 0);
            labelNoiDungBaoHanh.Name = "labelNoiDungBaoHanh";
            labelNoiDungBaoHanh.Size = new Size(171, 25);
            labelNoiDungBaoHanh.TabIndex = 26;
            labelNoiDungBaoHanh.Text = "Nội dung bảo hành:";
            // 
            // txtMaBaoHanh
            // 
            txtMaBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaBaoHanh.Location = new Point(276, 65);
            txtMaBaoHanh.Margin = new Padding(4, 4, 4, 4);
            txtMaBaoHanh.Name = "txtMaBaoHanh";
            txtMaBaoHanh.Size = new Size(378, 31);
            txtMaBaoHanh.TabIndex = 13;
            // 
            // lblMaBaoHanh
            // 
            lblMaBaoHanh.AutoSize = true;
            lblMaBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaBaoHanh.Location = new Point(61, 69);
            lblMaBaoHanh.Margin = new Padding(4, 0, 4, 0);
            lblMaBaoHanh.Name = "lblMaBaoHanh";
            lblMaBaoHanh.Size = new Size(121, 25);
            lblMaBaoHanh.TabIndex = 11;
            lblMaBaoHanh.Text = "Mã bảo hành:";
            // 
            // lblNgayBaoHanh
            // 
            lblNgayBaoHanh.AutoSize = true;
            lblNgayBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayBaoHanh.Location = new Point(758, 71);
            lblNgayBaoHanh.Margin = new Padding(4, 0, 4, 0);
            lblNgayBaoHanh.Name = "lblNgayBaoHanh";
            lblNgayBaoHanh.Size = new Size(138, 25);
            lblNgayBaoHanh.TabIndex = 5;
            lblNgayBaoHanh.Text = "Ngày bảo hành:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(1, 276);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1639, 106);
            lblTieuDe.TabIndex = 32;
            lblTieuDe.Text = "PHIẾU NHẬP LỊCH SỬ BẢO HÀNH";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(272, 170);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(415, 25);
            lblDiaChi.TabIndex = 31;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(269, 98);
            lblTenCuaHang.Margin = new Padding(4, 0, 4, 0);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(569, 45);
            lblTenCuaHang.TabIndex = 30;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(68, 81);
            picLogo.Margin = new Padding(4, 4, 4, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(181, 192);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 29;
            picLogo.TabStop = false;
            // 
            // frmLichSuBaoHanh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 996);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(grpThongTinLichSuBaoHanh);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(4, 4, 4, 4);
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