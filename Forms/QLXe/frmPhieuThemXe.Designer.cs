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
            cboTenDaiLy = new ComboBox();
            txtMaXe = new TextBox();
            label1 = new Label();
            txtDungLuongAcQuy = new TextBox();
            lblDungLuongAcQuy = new Label();
            txtSoBinhAcQuy = new TextBox();
            lblSoBinhAcQuy = new Label();
            txtMauSac = new TextBox();
            lblMauSac = new Label();
            btnThemAnh = new Button();
            picAnhXe = new PictureBox();
            txtGiaBan = new TextBox();
            lblDonGia = new Label();
            lblNhaCungCap = new Label();
            cboLoaiXe = new ComboBox();
            txtTenXe = new TextBox();
            lblLoaiXe = new Label();
            lblTenXe = new Label();
            btnLuu = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpThongTinXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhXe).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(65, 15);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(181, 192);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenCuaHang.ForeColor = SystemColors.ActiveCaptionText;
            lblTenCuaHang.Location = new Point(266, 31);
            lblTenCuaHang.Margin = new Padding(4, 0, 4, 0);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(569, 45);
            lblTenCuaHang.TabIndex = 1;
            lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(270, 104);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(415, 25);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(54, 220);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1639, 106);
            lblTieuDe.TabIndex = 3;
            lblTieuDe.Text = "PHIẾU THÔNG TIN XE ĐIỆN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTinXe
            // 
            grpThongTinXe.Controls.Add(cboTenDaiLy);
            grpThongTinXe.Controls.Add(txtMaXe);
            grpThongTinXe.Controls.Add(label1);
            grpThongTinXe.Controls.Add(txtDungLuongAcQuy);
            grpThongTinXe.Controls.Add(lblDungLuongAcQuy);
            grpThongTinXe.Controls.Add(txtSoBinhAcQuy);
            grpThongTinXe.Controls.Add(lblSoBinhAcQuy);
            grpThongTinXe.Controls.Add(txtMauSac);
            grpThongTinXe.Controls.Add(lblMauSac);
            grpThongTinXe.Controls.Add(btnThemAnh);
            grpThongTinXe.Controls.Add(picAnhXe);
            grpThongTinXe.Controls.Add(txtGiaBan);
            grpThongTinXe.Controls.Add(lblDonGia);
            grpThongTinXe.Controls.Add(lblNhaCungCap);
            grpThongTinXe.Controls.Add(cboLoaiXe);
            grpThongTinXe.Controls.Add(txtTenXe);
            grpThongTinXe.Controls.Add(lblLoaiXe);
            grpThongTinXe.Controls.Add(lblTenXe);
            grpThongTinXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpThongTinXe.ForeColor = SystemColors.ActiveCaptionText;
            grpThongTinXe.Location = new Point(98, 320);
            grpThongTinXe.Margin = new Padding(4);
            grpThongTinXe.Name = "grpThongTinXe";
            grpThongTinXe.Padding = new Padding(4);
            grpThongTinXe.Size = new Size(1420, 514);
            grpThongTinXe.TabIndex = 4;
            grpThongTinXe.TabStop = false;
            grpThongTinXe.Text = "Thông tin xe điện";
            // 
            // cboTenDaiLy
            // 
            cboTenDaiLy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTenDaiLy.FormattingEnabled = true;
            cboTenDaiLy.Items.AddRange(new object[] { "Xe đạp điện", "Xe máy điện" });
            cboTenDaiLy.Location = new Point(231, 319);
            cboTenDaiLy.Margin = new Padding(4);
            cboTenDaiLy.Name = "cboTenDaiLy";
            cboTenDaiLy.Size = new Size(218, 33);
            cboTenDaiLy.TabIndex = 25;
            // 
            // txtMaXe
            // 
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaXe.Location = new Point(229, 50);
            txtMaXe.Margin = new Padding(4);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(220, 31);
            txtMaXe.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 23;
            label1.Text = "Mã xe:";
            // 
            // txtDungLuongAcQuy
            // 
            txtDungLuongAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDungLuongAcQuy.Location = new Point(802, 270);
            txtDungLuongAcQuy.Margin = new Padding(4);
            txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            txtDungLuongAcQuy.Size = new Size(220, 31);
            txtDungLuongAcQuy.TabIndex = 22;
            // 
            // lblDungLuongAcQuy
            // 
            lblDungLuongAcQuy.AutoSize = true;
            lblDungLuongAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDungLuongAcQuy.Location = new Point(586, 275);
            lblDungLuongAcQuy.Margin = new Padding(4, 0, 4, 0);
            lblDungLuongAcQuy.Name = "lblDungLuongAcQuy";
            lblDungLuongAcQuy.Size = new Size(169, 25);
            lblDungLuongAcQuy.TabIndex = 21;
            lblDungLuongAcQuy.Text = "Dung lượng ắc quy:";
            // 
            // txtSoBinhAcQuy
            // 
            txtSoBinhAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoBinhAcQuy.Location = new Point(802, 378);
            txtSoBinhAcQuy.Margin = new Padding(4);
            txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            txtSoBinhAcQuy.Size = new Size(220, 31);
            txtSoBinhAcQuy.TabIndex = 20;
            // 
            // lblSoBinhAcQuy
            // 
            lblSoBinhAcQuy.AutoSize = true;
            lblSoBinhAcQuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoBinhAcQuy.Location = new Point(586, 385);
            lblSoBinhAcQuy.Margin = new Padding(4, 0, 4, 0);
            lblSoBinhAcQuy.Name = "lblSoBinhAcQuy";
            lblSoBinhAcQuy.Size = new Size(134, 25);
            lblSoBinhAcQuy.TabIndex = 19;
            lblSoBinhAcQuy.Text = "Số bình ắc quy:";
            // 
            // txtMauSac
            // 
            txtMauSac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMauSac.Location = new Point(802, 50);
            txtMauSac.Margin = new Padding(4);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(220, 31);
            txtMauSac.TabIndex = 18;
            // 
            // lblMauSac
            // 
            lblMauSac.AutoSize = true;
            lblMauSac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMauSac.Location = new Point(586, 56);
            lblMauSac.Margin = new Padding(4, 0, 4, 0);
            lblMauSac.Name = "lblMauSac";
            lblMauSac.Size = new Size(81, 25);
            lblMauSac.TabIndex = 17;
            lblMauSac.Text = "Màu sắc:";
            // 
            // btnThemAnh
            // 
            btnThemAnh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemAnh.Location = new Point(1199, 392);
            btnThemAnh.Margin = new Padding(4);
            btnThemAnh.Name = "btnThemAnh";
            btnThemAnh.Size = new Size(164, 65);
            btnThemAnh.TabIndex = 16;
            btnThemAnh.Text = "Thêm ảnh";
            btnThemAnh.UseVisualStyleBackColor = true;
            btnThemAnh.Click += btnThemAnh_Click;
            // 
            // picAnhXe
            // 
            picAnhXe.Location = new Point(1199, 160);
            picAnhXe.Margin = new Padding(4);
            picAnhXe.Name = "picAnhXe";
            picAnhXe.Size = new Size(164, 189);
            picAnhXe.TabIndex = 15;
            picAnhXe.TabStop = false;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaBan.Location = new Point(802, 160);
            txtGiaBan.Margin = new Padding(4);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(220, 31);
            txtGiaBan.TabIndex = 14;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDonGia.Location = new Point(586, 166);
            lblDonGia.Margin = new Padding(4, 0, 4, 0);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(75, 25);
            lblDonGia.TabIndex = 12;
            lblDonGia.Text = "Giá Bán:";
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNhaCungCap.Location = new Point(63, 322);
            lblNhaCungCap.Margin = new Padding(4, 0, 4, 0);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new Size(90, 25);
            lblNhaCungCap.TabIndex = 11;
            lblNhaCungCap.Text = "Tên Đại Lý";
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Items.AddRange(new object[] { "Xe đạp điện", "Xe máy điện" });
            cboLoaiXe.Location = new Point(231, 215);
            cboLoaiXe.Margin = new Padding(4);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(218, 33);
            cboLoaiXe.TabIndex = 8;
            // 
            // txtTenXe
            // 
            txtTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenXe.Location = new Point(229, 128);
            txtTenXe.Margin = new Padding(4);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(220, 31);
            txtTenXe.TabIndex = 7;
            // 
            // lblLoaiXe
            // 
            lblLoaiXe.AutoSize = true;
            lblLoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoaiXe.Location = new Point(63, 223);
            lblLoaiXe.Margin = new Padding(4, 0, 4, 0);
            lblLoaiXe.Name = "lblLoaiXe";
            lblLoaiXe.Size = new Size(70, 25);
            lblLoaiXe.TabIndex = 5;
            lblLoaiXe.Text = "Loại xe:";
            // 
            // lblTenXe
            // 
            lblTenXe.AutoSize = true;
            lblTenXe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenXe.Location = new Point(69, 134);
            lblTenXe.Margin = new Padding(4, 0, 4, 0);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(64, 25);
            lblTenXe.TabIndex = 4;
            lblTenXe.Text = "Tên xe:";
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(358, 935);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(139, 64);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(716, 935);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(139, 64);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(1100, 935);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 64);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuThemXe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 1050);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuu);
            Controls.Add(grpThongTinXe);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenCuaHang);
            Controls.Add(picLogo);
            Margin = new Padding(4);
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
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDungLuongAcQuy;
        private System.Windows.Forms.Label lblDungLuongAcQuy;
        private System.Windows.Forms.TextBox txtSoBinhAcQuy;
        private System.Windows.Forms.Label lblSoBinhAcQuy;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label lblMauSac;
        private TextBox txtMaXe;
        private Label label1;
        private ComboBox cboTenDaiLy;
    }
}