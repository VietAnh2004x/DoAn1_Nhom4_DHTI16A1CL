namespace DoAn.Forms.QLTonKho
{
    partial class frmNhapXeVaoKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapXeVaoKho));
            dtpNgayNhap = new DateTimePicker();
            lblNgayNhap = new Label();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnLuu = new Button();
            grpThongTinXeNhap = new GroupBox();
            txtMaXe = new TextBox();
            txtDonGiaNhap = new TextBox();
            lblDonGiaNhap = new Label();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblLoaiXe = new Label();
            lblTieuDe = new Label();
            lblDiaChi = new Label();
            lblTenCuaHang = new Label();
            picLogo = new PictureBox();
            grpThongTinXeNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(235, 213);
            dtpNgayNhap.Margin = new Padding(4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(160, 31);
            dtpNgayNhap.TabIndex = 20;
            dtpNgayNhap.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayNhap.Location = new Point(68, 226);
            lblNgayNhap.Margin = new Padding(4, 0, 4, 0);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(103, 25);
            lblNgayNhap.TabIndex = 19;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(1114, 905);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 64);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(730, 905);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(139, 64);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(371, 905);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(139, 64);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // grpThongTinXeNhap
            // 
            grpThongTinXeNhap.Controls.Add(dtpNgayNhap);
            grpThongTinXeNhap.Controls.Add(lblNgayNhap);
            grpThongTinXeNhap.Controls.Add(txtMaXe);
            grpThongTinXeNhap.Controls.Add(txtDonGiaNhap);
            grpThongTinXeNhap.Controls.Add(lblDonGiaNhap);
            grpThongTinXeNhap.Controls.Add(lblSoLuong);
            grpThongTinXeNhap.Controls.Add(txtSoLuong);
            grpThongTinXeNhap.Controls.Add(lblLoaiXe);
            grpThongTinXeNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpThongTinXeNhap.ForeColor = SystemColors.ActiveCaptionText;
            grpThongTinXeNhap.Location = new Point(95, 346);
            grpThongTinXeNhap.Margin = new Padding(4);
            grpThongTinXeNhap.Name = "grpThongTinXeNhap";
            grpThongTinXeNhap.Padding = new Padding(4);
            grpThongTinXeNhap.Size = new Size(1420, 451);
            grpThongTinXeNhap.TabIndex = 15;
            grpThongTinXeNhap.TabStop = false;
            grpThongTinXeNhap.Text = "Thông tin xe nhập";
            // 
            // txtMaXe
            // 
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXe.Location = new Point(235, 96);
            txtMaXe.Margin = new Padding(4);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(220, 31);
            txtMaXe.TabIndex = 19;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonGiaNhap.Location = new Point(842, 215);
            txtDonGiaNhap.Margin = new Padding(4);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(220, 31);
            txtDonGiaNhap.TabIndex = 14;
            // 
            // lblDonGiaNhap
            // 
            lblDonGiaNhap.AutoSize = true;
            lblDonGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDonGiaNhap.Location = new Point(626, 219);
            lblDonGiaNhap.Margin = new Padding(4, 0, 4, 0);
            lblDonGiaNhap.Name = "lblDonGiaNhap";
            lblDonGiaNhap.Size = new Size(124, 25);
            lblDonGiaNhap.TabIndex = 12;
            lblDonGiaNhap.Text = "Đơn giá nhập:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(626, 100);
            lblSoLuong.Margin = new Padding(4, 0, 4, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(89, 25);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(842, 96);
            txtSoLuong.Margin = new Padding(4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(220, 31);
            txtSoLuong.TabIndex = 9;
            // 
            // lblLoaiXe
            // 
            lblLoaiXe.AutoSize = true;
            lblLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoaiXe.Location = new Point(68, 100);
            lblLoaiXe.Margin = new Padding(4, 0, 4, 0);
            lblLoaiXe.Name = "lblLoaiXe";
            lblLoaiXe.Size = new Size(63, 25);
            lblLoaiXe.TabIndex = 5;
            lblLoaiXe.Text = "Mã xe:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(-4, 236);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1639, 106);
            lblTieuDe.TabIndex = 14;
            lblTieuDe.Text = "PHIẾU NHẬP XE VÀO KHO";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(268, 130);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(415, 25);
            lblDiaChi.TabIndex = 13;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(264, 58);
            lblTenCuaHang.Margin = new Padding(4, 0, 4, 0);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(569, 45);
            lblTenCuaHang.TabIndex = 12;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(62, 41);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(181, 192);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 11;
            picLogo.TabStop = false;
            // 
            // frmNhapXeVaoKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 1019);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(grpThongTinXeNhap);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(4);
            Name = "frmNhapXeVaoKho";
            Text = "frmNhapXeVaoKho";
            grpThongTinXeNhap.ResumeLayout(false);
            grpThongTinXeNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayNhap;
        private Label lblNgayNhap;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnLuu;
        private GroupBox grpThongTinXeNhap;
        private TextBox txtDonGiaNhap;
        private Label lblDonGiaNhap;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblLoaiXe;
        private Label lblTieuDe;
        private Label lblDiaChi;
        private Label lblTenCuaHang;
        private PictureBox picLogo;
        private TextBox txtMaXe;
    }
}