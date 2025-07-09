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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTenCuaHang = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTinXe = new System.Windows.Forms.GroupBox();
            this.txtDungLuongAcQuy = new System.Windows.Forms.TextBox();
            this.lblDungLuongAcQuy = new System.Windows.Forms.Label();
            this.txtSoBinhAcQuy = new System.Windows.Forms.TextBox();
            this.lblSoBinhAcQuy = new System.Windows.Forms.Label();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.picAnhXe = new System.Windows.Forms.PictureBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpThongTinXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(37, 16);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(109, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTenCuaHang
            // 
            this.lblTenCuaHang.AutoSize = true;
            this.lblTenCuaHang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTenCuaHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenCuaHang.Location = new System.Drawing.Point(160, 16);
            this.lblTenCuaHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenCuaHang.Name = "lblTenCuaHang";
            this.lblTenCuaHang.Size = new System.Drawing.Size(389, 30);
            this.lblTenCuaHang.TabIndex = 1;
            this.lblTenCuaHang.Text = "CỬA HÀNG XE ĐIỆN HCTV ELECTRIC";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiaChi.Location = new System.Drawing.Point(162, 54);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(281, 15);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ: 218 Lĩnh Nam, Hà Nội | www.hctvelectric.vn";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 115);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(983, 55);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "PHIẾU NHẬP XE ĐIỆN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinXe
            // 
            this.grpThongTinXe.Controls.Add(this.txtDungLuongAcQuy);
            this.grpThongTinXe.Controls.Add(this.lblDungLuongAcQuy);
            this.grpThongTinXe.Controls.Add(this.txtSoBinhAcQuy);
            this.grpThongTinXe.Controls.Add(this.lblSoBinhAcQuy);
            this.grpThongTinXe.Controls.Add(this.txtMauSac);
            this.grpThongTinXe.Controls.Add(this.lblMauSac);
            this.grpThongTinXe.Controls.Add(this.btnThemAnh);
            this.grpThongTinXe.Controls.Add(this.picAnhXe);
            this.grpThongTinXe.Controls.Add(this.txtDonGia);
            this.grpThongTinXe.Controls.Add(this.txtNhaCungCap);
            this.grpThongTinXe.Controls.Add(this.lblDonGia);
            this.grpThongTinXe.Controls.Add(this.lblNhaCungCap);
            this.grpThongTinXe.Controls.Add(this.lblSoLuong);
            this.grpThongTinXe.Controls.Add(this.txtSoLuong);
            this.grpThongTinXe.Controls.Add(this.cboLoaiXe);
            this.grpThongTinXe.Controls.Add(this.txtTenXe);
            this.grpThongTinXe.Controls.Add(this.lblLoaiXe);
            this.grpThongTinXe.Controls.Add(this.lblTenXe);
            this.grpThongTinXe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinXe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpThongTinXe.Location = new System.Drawing.Point(67, 177);
            this.grpThongTinXe.Margin = new System.Windows.Forms.Padding(2);
            this.grpThongTinXe.Name = "grpThongTinXe";
            this.grpThongTinXe.Padding = new System.Windows.Forms.Padding(2);
            this.grpThongTinXe.Size = new System.Drawing.Size(852, 267);
            this.grpThongTinXe.TabIndex = 4;
            this.grpThongTinXe.TabStop = false;
            this.grpThongTinXe.Text = "Thông tin xe điện";
            // 
            // txtDungLuongAcQuy
            // 
            this.txtDungLuongAcQuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDungLuongAcQuy.Location = new System.Drawing.Point(507, 163);
            this.txtDungLuongAcQuy.Margin = new System.Windows.Forms.Padding(2);
            this.txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            this.txtDungLuongAcQuy.Size = new System.Drawing.Size(134, 23);
            this.txtDungLuongAcQuy.TabIndex = 22;
            // 
            // lblDungLuongAcQuy
            // 
            this.lblDungLuongAcQuy.AutoSize = true;
            this.lblDungLuongAcQuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDungLuongAcQuy.Location = new System.Drawing.Point(377, 166);
            this.lblDungLuongAcQuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDungLuongAcQuy.Name = "lblDungLuongAcQuy";
            this.lblDungLuongAcQuy.Size = new System.Drawing.Size(111, 15);
            this.lblDungLuongAcQuy.TabIndex = 21;
            this.lblDungLuongAcQuy.Text = "Dung lượng ắc quy:";
            // 
            // txtSoBinhAcQuy
            // 
            this.txtSoBinhAcQuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBinhAcQuy.Location = new System.Drawing.Point(507, 220);
            this.txtSoBinhAcQuy.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            this.txtSoBinhAcQuy.Size = new System.Drawing.Size(134, 23);
            this.txtSoBinhAcQuy.TabIndex = 20;
            // 
            // lblSoBinhAcQuy
            // 
            this.lblSoBinhAcQuy.AutoSize = true;
            this.lblSoBinhAcQuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBinhAcQuy.Location = new System.Drawing.Point(377, 223);
            this.lblSoBinhAcQuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoBinhAcQuy.Name = "lblSoBinhAcQuy";
            this.lblSoBinhAcQuy.Size = new System.Drawing.Size(88, 15);
            this.lblSoBinhAcQuy.TabIndex = 19;
            this.lblSoBinhAcQuy.Text = "Số bình ắc quy:";
            // 
            // txtMauSac
            // 
            this.txtMauSac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauSac.Location = new System.Drawing.Point(507, 49);
            this.txtMauSac.Margin = new System.Windows.Forms.Padding(2);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(134, 23);
            this.txtMauSac.TabIndex = 18;
            // 
            // lblMauSac
            // 
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMauSac.Location = new System.Drawing.Point(377, 52);
            this.lblMauSac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(54, 15);
            this.lblMauSac.TabIndex = 17;
            this.lblMauSac.Text = "Màu sắc:";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.Location = new System.Drawing.Point(719, 204);
            this.btnThemAnh.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(98, 34);
            this.btnThemAnh.TabIndex = 16;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            // 
            // picAnhXe
            // 
            this.picAnhXe.Location = new System.Drawing.Point(719, 83);
            this.picAnhXe.Margin = new System.Windows.Forms.Padding(2);
            this.picAnhXe.Name = "picAnhXe";
            this.picAnhXe.Size = new System.Drawing.Size(98, 98);
            this.picAnhXe.TabIndex = 15;
            this.picAnhXe.TabStop = false;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(507, 106);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(134, 23);
            this.txtDonGia.TabIndex = 14;
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCungCap.Location = new System.Drawing.Point(137, 220);
            this.txtNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(134, 23);
            this.txtNhaCungCap.TabIndex = 13;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(377, 109);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(51, 15);
            this.lblDonGia.TabIndex = 12;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(38, 223);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(84, 15);
            this.lblNhaCungCap.TabIndex = 11;
            this.lblNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(38, 166);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(57, 15);
            this.lblSoLuong.TabIndex = 10;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(137, 163);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(132, 23);
            this.txtSoLuong.TabIndex = 9;
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Items.AddRange(new object[] {
            "Xe đạp điện",
            "Xe máy điện"});
            this.cboLoaiXe.Location = new System.Drawing.Point(137, 106);
            this.cboLoaiXe.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(132, 23);
            this.cboLoaiXe.TabIndex = 8;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.Location = new System.Drawing.Point(137, 49);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(134, 23);
            this.txtTenXe.TabIndex = 7;
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiXe.Location = new System.Drawing.Point(38, 109);
            this.lblLoaiXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(46, 15);
            this.lblLoaiXe.TabIndex = 5;
            this.lblLoaiXe.Text = "Loại xe:";
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenXe.Location = new System.Drawing.Point(41, 52);
            this.lblTenXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(43, 15);
            this.lblTenXe.TabIndex = 4;
            this.lblTenXe.Text = "Tên xe:";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.Location = new System.Drawing.Point(214, 518);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 33);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLamMoi.Location = new System.Drawing.Point(429, 518);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(83, 33);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(659, 518);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 33);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNgayNhap.Location = new System.Drawing.Point(699, 470);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(68, 15);
            this.lblNgayNhap.TabIndex = 9;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(786, 464);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(98, 23);
            this.dtpNgayNhap.TabIndex = 10;
            this.dtpNgayNhap.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // PhieuThemXeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grpThongTinXe);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenCuaHang);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhieuThemXeForm";
            this.Text = "Phiếu nhập xe điện";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpThongTinXe.ResumeLayout(false);
            this.grpThongTinXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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