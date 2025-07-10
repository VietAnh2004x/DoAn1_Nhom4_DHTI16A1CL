namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    partial class frmPhieuThemXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThemXe));
            picLogo = new PictureBox();
            lblTenCuaHang = new Label();
            lblDiaChi = new Label();
            lblTieuDe = new Label();
            grpThongTinXe = new GroupBox();
            txtDungLuongAcQuy = new TextBox();
            lblDungLuongAcQuy = new Label();
            txtSoBinhAcQuy = new TextBox();
            lblSoBinhAcQuy = new Label();
            txtMauSac = new TextBox();
            lblMauSac = new Label();
            btnThemAnh = new Button();
            picAnhXe = new PictureBox();
            txtDonGia = new TextBox();
            txtNhaCungCap = new TextBox();
            lblDonGia = new Label();
            lblNhaCungCap = new Label();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            cboLoaiXe = new ComboBox();
            txtTenXe = new TextBox();
            lblLoaiXe = new Label();
            lblTenXe = new Label();
            btnLuu = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            lblNgayNhap = new Label();
            dtpNgayNhap = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpThongTinXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhXe).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(52, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(145, 154);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(213, 25);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(477, 37);
            lblTenCuaHang.TabIndex = 1;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(216, 83);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(348, 20);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(-1, 168);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1311, 85);
            lblTieuDe.TabIndex = 3;
            lblTieuDe.Text = "PHIẾU NHẬP XE ĐIỆN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTinXe
            // 
            grpThongTinXe.Controls.Add(txtDungLuongAcQuy);
            grpThongTinXe.Controls.Add(lblDungLuongAcQuy);
            grpThongTinXe.Controls.Add(txtSoBinhAcQuy);
            grpThongTinXe.Controls.Add(lblSoBinhAcQuy);
            grpThongTinXe.Controls.Add(txtMauSac);
            grpThongTinXe.Controls.Add(lblMauSac);
            grpThongTinXe.Controls.Add(btnThemAnh);
            grpThongTinXe.Controls.Add(picAnhXe);
            grpThongTinXe.Controls.Add(txtDonGia);
            grpThongTinXe.Controls.Add(txtNhaCungCap);
            grpThongTinXe.Controls.Add(lblDonGia);
            grpThongTinXe.Controls.Add(lblNhaCungCap);
            grpThongTinXe.Controls.Add(lblSoLuong);
            grpThongTinXe.Controls.Add(txtSoLuong);
            grpThongTinXe.Controls.Add(cboLoaiXe);
            grpThongTinXe.Controls.Add(txtTenXe);
            grpThongTinXe.Controls.Add(lblLoaiXe);
            grpThongTinXe.Controls.Add(lblTenXe);
            grpThongTinXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpThongTinXe.ForeColor = SystemColors.ActiveCaptionText;
            grpThongTinXe.Location = new Point(78, 256);
            grpThongTinXe.Name = "grpThongTinXe";
            grpThongTinXe.Size = new Size(1136, 411);
            grpThongTinXe.TabIndex = 4;
            grpThongTinXe.TabStop = false;
            grpThongTinXe.Text = "Thông tin xe điện";
            // 
            // txtDungLuongAcQuy
            // 
            txtDungLuongAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDungLuongAcQuy.Location = new Point(676, 251);
            txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            txtDungLuongAcQuy.Size = new Size(177, 27);
            txtDungLuongAcQuy.TabIndex = 22;
            // 
            // lblDungLuongAcQuy
            // 
            lblDungLuongAcQuy.AutoSize = true;
            lblDungLuongAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDungLuongAcQuy.Location = new Point(503, 255);
            lblDungLuongAcQuy.Name = "lblDungLuongAcQuy";
            lblDungLuongAcQuy.Size = new Size(138, 20);
            lblDungLuongAcQuy.TabIndex = 21;
            lblDungLuongAcQuy.Text = "Dung lượng ắc quy:";
            // 
            // txtSoBinhAcQuy
            // 
            txtSoBinhAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoBinhAcQuy.Location = new Point(676, 338);
            txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            txtSoBinhAcQuy.Size = new Size(177, 27);
            txtSoBinhAcQuy.TabIndex = 20;
            // 
            // lblSoBinhAcQuy
            // 
            lblSoBinhAcQuy.AutoSize = true;
            lblSoBinhAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoBinhAcQuy.Location = new Point(503, 343);
            lblSoBinhAcQuy.Name = "lblSoBinhAcQuy";
            lblSoBinhAcQuy.Size = new Size(109, 20);
            lblSoBinhAcQuy.TabIndex = 19;
            lblSoBinhAcQuy.Text = "Số bình ắc quy:";
            // 
            // txtMauSac
            // 
            txtMauSac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMauSac.Location = new Point(676, 75);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(177, 27);
            txtMauSac.TabIndex = 18;
            // 
            // lblMauSac
            // 
            lblMauSac.AutoSize = true;
            lblMauSac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMauSac.Location = new Point(503, 80);
            lblMauSac.Name = "lblMauSac";
            lblMauSac.Size = new Size(66, 20);
            lblMauSac.TabIndex = 17;
            lblMauSac.Text = "Màu sắc:";
            // 
            // btnThemAnh
            // 
            btnThemAnh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemAnh.Location = new Point(959, 314);
            btnThemAnh.Name = "btnThemAnh";
            btnThemAnh.Size = new Size(131, 52);
            btnThemAnh.TabIndex = 16;
            btnThemAnh.Text = "Thêm ảnh";
            btnThemAnh.UseVisualStyleBackColor = true;
            // 
            // picAnhXe
            // 
            picAnhXe.Location = new Point(959, 128);
            picAnhXe.Name = "picAnhXe";
            picAnhXe.Size = new Size(131, 151);
            picAnhXe.TabIndex = 15;
            picAnhXe.TabStop = false;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonGia.Location = new Point(676, 163);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(177, 27);
            txtDonGia.TabIndex = 14;
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNhaCungCap.Location = new Point(183, 338);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.Size = new Size(177, 27);
            txtNhaCungCap.TabIndex = 13;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDonGia.Location = new Point(503, 168);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(65, 20);
            lblDonGia.TabIndex = 12;
            lblDonGia.Text = "Đơn giá:";
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNhaCungCap.Location = new Point(51, 343);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new Size(103, 20);
            lblNhaCungCap.TabIndex = 11;
            lblNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(51, 255);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(183, 251);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(175, 27);
            txtSoLuong.TabIndex = 9;
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Items.AddRange(new object[] { "Xe đạp điện", "Xe máy điện" });
            cboLoaiXe.Location = new Point(183, 163);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(175, 28);
            cboLoaiXe.TabIndex = 8;
            // 
            // txtTenXe
            // 
            txtTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXe.Location = new Point(183, 75);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(177, 27);
            txtTenXe.TabIndex = 7;
            // 
            // lblLoaiXe
            // 
            lblLoaiXe.AutoSize = true;
            lblLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoaiXe.Location = new Point(51, 168);
            lblLoaiXe.Name = "lblLoaiXe";
            lblLoaiXe.Size = new Size(59, 20);
            lblLoaiXe.TabIndex = 5;
            lblLoaiXe.Text = "Loại xe:";
            // 
            // lblTenXe
            // 
            lblTenXe.AutoSize = true;
            lblTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenXe.Location = new Point(55, 80);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(54, 20);
            lblTenXe.TabIndex = 4;
            lblTenXe.Text = "Tên xe:";
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(286, 748);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(111, 51);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(573, 748);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(111, 51);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(880, 748);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(111, 51);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayNhap.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayNhap.Location = new Point(946, 695);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(84, 20);
            lblNgayNhap.TabIndex = 9;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(1062, 686);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(129, 27);
            dtpNgayNhap.TabIndex = 10;
            dtpNgayNhap.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // frmPhieuThemXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 853);
            Controls.Add(dtpNgayNhap);
            Controls.Add(lblNgayNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(grpThongTinXe);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Name = "frmPhieuThemXe";
            Text = "Phiếu nhập xe điện";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpThongTinXe.ResumeLayout(false);
            grpThongTinXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhXe).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTenCuaHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTinXe;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.PictureBox picAnhXe;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtDungLuongAcQuy;
        private System.Windows.Forms.Label lblDungLuongAcQuy;
        private System.Windows.Forms.TextBox txtSoBinhAcQuy;
        private System.Windows.Forms.Label lblSoBinhAcQuy;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label lblMauSac;
    }
}