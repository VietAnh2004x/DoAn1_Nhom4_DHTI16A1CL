namespace DoAn1.Forms.QLXe
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
            picLogo.Location = new Point(46, 9);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(127, 116);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(186, 19);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(389, 30);
            lblTenCuaHang.TabIndex = 1;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(189, 62);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(281, 15);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(-1, 126);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1147, 64);
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
            grpThongTinXe.Location = new Point(68, 192);
            grpThongTinXe.Margin = new Padding(3, 2, 3, 2);
            grpThongTinXe.Name = "grpThongTinXe";
            grpThongTinXe.Padding = new Padding(3, 2, 3, 2);
            grpThongTinXe.Size = new Size(994, 308);
            grpThongTinXe.TabIndex = 4;
            grpThongTinXe.TabStop = false;
            grpThongTinXe.Text = "Thông tin xe điện";
            // 
            // txtDungLuongAcQuy
            // 
            txtDungLuongAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDungLuongAcQuy.Location = new Point(592, 188);
            txtDungLuongAcQuy.Margin = new Padding(3, 2, 3, 2);
            txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            txtDungLuongAcQuy.Size = new Size(155, 23);
            txtDungLuongAcQuy.TabIndex = 22;
            // 
            // lblDungLuongAcQuy
            // 
            lblDungLuongAcQuy.AutoSize = true;
            lblDungLuongAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDungLuongAcQuy.Location = new Point(440, 191);
            lblDungLuongAcQuy.Name = "lblDungLuongAcQuy";
            lblDungLuongAcQuy.Size = new Size(111, 15);
            lblDungLuongAcQuy.TabIndex = 21;
            lblDungLuongAcQuy.Text = "Dung lượng ắc quy:";
            // 
            // txtSoBinhAcQuy
            // 
            txtSoBinhAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoBinhAcQuy.Location = new Point(592, 254);
            txtSoBinhAcQuy.Margin = new Padding(3, 2, 3, 2);
            txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            txtSoBinhAcQuy.Size = new Size(155, 23);
            txtSoBinhAcQuy.TabIndex = 20;
            // 
            // lblSoBinhAcQuy
            // 
            lblSoBinhAcQuy.AutoSize = true;
            lblSoBinhAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoBinhAcQuy.Location = new Point(440, 257);
            lblSoBinhAcQuy.Name = "lblSoBinhAcQuy";
            lblSoBinhAcQuy.Size = new Size(88, 15);
            lblSoBinhAcQuy.TabIndex = 19;
            lblSoBinhAcQuy.Text = "Số bình ắc quy:";
            // 
            // txtMauSac
            // 
            txtMauSac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMauSac.Location = new Point(592, 56);
            txtMauSac.Margin = new Padding(3, 2, 3, 2);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(155, 23);
            txtMauSac.TabIndex = 18;
            // 
            // lblMauSac
            // 
            lblMauSac.AutoSize = true;
            lblMauSac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMauSac.Location = new Point(440, 60);
            lblMauSac.Name = "lblMauSac";
            lblMauSac.Size = new Size(54, 15);
            lblMauSac.TabIndex = 17;
            lblMauSac.Text = "Màu sắc:";
            // 
            // btnThemAnh
            // 
            btnThemAnh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemAnh.Location = new Point(839, 236);
            btnThemAnh.Margin = new Padding(3, 2, 3, 2);
            btnThemAnh.Name = "btnThemAnh";
            btnThemAnh.Size = new Size(115, 39);
            btnThemAnh.TabIndex = 16;
            btnThemAnh.Text = "Thêm ảnh";
            btnThemAnh.UseVisualStyleBackColor = true;
            // 
            // picAnhXe
            // 
            picAnhXe.Location = new Point(839, 96);
            picAnhXe.Margin = new Padding(3, 2, 3, 2);
            picAnhXe.Name = "picAnhXe";
            picAnhXe.Size = new Size(115, 113);
            picAnhXe.TabIndex = 15;
            picAnhXe.TabStop = false;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonGia.Location = new Point(592, 122);
            txtDonGia.Margin = new Padding(3, 2, 3, 2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(155, 23);
            txtDonGia.TabIndex = 14;
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNhaCungCap.Location = new Point(160, 254);
            txtNhaCungCap.Margin = new Padding(3, 2, 3, 2);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.Size = new Size(155, 23);
            txtNhaCungCap.TabIndex = 13;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDonGia.Location = new Point(440, 126);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(51, 15);
            lblDonGia.TabIndex = 12;
            lblDonGia.Text = "Đơn giá:";
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNhaCungCap.Location = new Point(45, 257);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new Size(84, 15);
            lblNhaCungCap.TabIndex = 11;
            lblNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(45, 191);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(57, 15);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(160, 188);
            txtSoLuong.Margin = new Padding(3, 2, 3, 2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(154, 23);
            txtSoLuong.TabIndex = 9;
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Items.AddRange(new object[] { "Xe đạp điện", "Xe máy điện" });
            cboLoaiXe.Location = new Point(160, 122);
            cboLoaiXe.Margin = new Padding(3, 2, 3, 2);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(154, 23);
            cboLoaiXe.TabIndex = 8;
            // 
            // txtTenXe
            // 
            txtTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXe.Location = new Point(160, 56);
            txtTenXe.Margin = new Padding(3, 2, 3, 2);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(155, 23);
            txtTenXe.TabIndex = 7;
            // 
            // lblLoaiXe
            // 
            lblLoaiXe.AutoSize = true;
            lblLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoaiXe.Location = new Point(45, 126);
            lblLoaiXe.Name = "lblLoaiXe";
            lblLoaiXe.Size = new Size(46, 15);
            lblLoaiXe.TabIndex = 5;
            lblLoaiXe.Text = "Loại xe:";
            // 
            // lblTenXe
            // 
            lblTenXe.AutoSize = true;
            lblTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenXe.Location = new Point(48, 60);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(43, 15);
            lblTenXe.TabIndex = 4;
            lblTenXe.Text = "Tên xe:";
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(250, 561);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(97, 38);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(501, 561);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(97, 38);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(770, 561);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 38);
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
            lblNgayNhap.Location = new Point(828, 521);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(68, 15);
            lblNgayNhap.TabIndex = 9;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(929, 514);
            dtpNgayNhap.Margin = new Padding(3, 2, 3, 2);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(113, 23);
            dtpNgayNhap.TabIndex = 10;
            dtpNgayNhap.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // frmPhieuThemXe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 640);
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
            Margin = new Padding(3, 2, 3, 2);
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