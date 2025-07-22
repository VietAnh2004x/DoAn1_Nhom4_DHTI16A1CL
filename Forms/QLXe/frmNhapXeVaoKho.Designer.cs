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
            dtpNgayNhap.Location = new Point(164, 136);
            dtpNgayNhap.Margin = new Padding(3, 2, 3, 2);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(210, 23);
            dtpNgayNhap.TabIndex = 20;
            dtpNgayNhap.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayNhap.Location = new Point(48, 139);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(68, 15);
            lblNgayNhap.TabIndex = 19;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(787, 439);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 38);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(518, 439);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(97, 38);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(267, 439);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(97, 38);
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
            grpThongTinXeNhap.Location = new Point(66, 208);
            grpThongTinXeNhap.Margin = new Padding(3, 2, 3, 2);
            grpThongTinXeNhap.Name = "grpThongTinXeNhap";
            grpThongTinXeNhap.Padding = new Padding(3, 2, 3, 2);
            grpThongTinXeNhap.Size = new Size(994, 200);
            grpThongTinXeNhap.TabIndex = 15;
            grpThongTinXeNhap.TabStop = false;
            grpThongTinXeNhap.Text = "Thông tin xe nhập";
            // 
            // txtMaXe
            // 
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXe.Location = new Point(164, 58);
            txtMaXe.Margin = new Padding(3, 2, 3, 2);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(210, 23);
            txtMaXe.TabIndex = 19;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonGiaNhap.Location = new Point(730, 136);
            txtDonGiaNhap.Margin = new Padding(3, 2, 3, 2);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(210, 23);
            txtDonGiaNhap.TabIndex = 14;
            // 
            // lblDonGiaNhap
            // 
            lblDonGiaNhap.AutoSize = true;
            lblDonGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDonGiaNhap.Location = new Point(579, 139);
            lblDonGiaNhap.Name = "lblDonGiaNhap";
            lblDonGiaNhap.Size = new Size(81, 15);
            lblDonGiaNhap.TabIndex = 12;
            lblDonGiaNhap.Text = "Đơn giá nhập:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(579, 60);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(57, 15);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(730, 57);
            txtSoLuong.Margin = new Padding(3, 2, 3, 2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(210, 23);
            txtSoLuong.TabIndex = 9;
            // 
            // lblLoaiXe
            // 
            lblLoaiXe.AutoSize = true;
            lblLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoaiXe.Location = new Point(48, 60);
            lblLoaiXe.Name = "lblLoaiXe";
            lblLoaiXe.Size = new Size(41, 15);
            lblLoaiXe.TabIndex = 5;
            lblLoaiXe.Text = "Mã xe:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(-3, 142);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1147, 64);
            lblTieuDe.TabIndex = 14;
            lblTieuDe.Text = "PHIẾU NHẬP XE VÀO KHO";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(188, 78);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(281, 15);
            lblDiaChi.TabIndex = 13;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(185, 35);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(389, 30);
            lblTenCuaHang.TabIndex = 12;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(43, 25);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(127, 115);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 11;
            picLogo.TabStop = false;
            // 
            // frmNhapXeVaoKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 511);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(grpThongTinXeNhap);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(3, 2, 3, 2);
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