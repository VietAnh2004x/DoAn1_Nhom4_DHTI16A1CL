namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoCao
{
    partial class usBaoCao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpDoanhThu = new System.Windows.Forms.GroupBox();
            this.dgvDoanhThuTheoThongKe = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.grpChonThongKe = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.grpSLThongKe = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDaiLy = new System.Windows.Forms.TextBox();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtTongSoXeBanRa = new System.Windows.Forms.TextBox();
            this.lblTongSoXeBanRa = new System.Windows.Forms.Label();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.txtSoKhachHang = new System.Windows.Forms.TextBox();
            this.lblDaiLy = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuTheoThongKe)).BeginInit();
            this.grpChonThongKe.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpSLThongKe.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTieuDe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpDoanhThu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnXuatExcel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.grpChonThongKe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpSLThongKe, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1209, 766);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTieuDe.Location = new System.Drawing.Point(5, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1199, 114);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÁO CÁO - THỐNG KÊ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDoanhThu
            // 
            this.grpDoanhThu.Controls.Add(this.dgvDoanhThuTheoThongKe);
            this.grpDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpDoanhThu.Location = new System.Drawing.Point(5, 348);
            this.grpDoanhThu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpDoanhThu.Name = "grpDoanhThu";
            this.grpDoanhThu.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpDoanhThu.Size = new System.Drawing.Size(1199, 334);
            this.grpDoanhThu.TabIndex = 3;
            this.grpDoanhThu.TabStop = false;
            this.grpDoanhThu.Text = "Chi tiết theo thống kê";
            // 
            // dgvDoanhThuTheoThongKe
            // 
            this.dgvDoanhThuTheoThongKe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhThuTheoThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoanhThuTheoThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuTheoThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThuTheoThongKe.EnableHeadersVisualStyles = false;
            this.dgvDoanhThuTheoThongKe.Location = new System.Drawing.Point(5, 20);
            this.dgvDoanhThuTheoThongKe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvDoanhThuTheoThongKe.Name = "dgvDoanhThuTheoThongKe";
            this.dgvDoanhThuTheoThongKe.RowHeadersWidth = 51;
            this.dgvDoanhThuTheoThongKe.Size = new System.Drawing.Size(1189, 309);
            this.dgvDoanhThuTheoThongKe.TabIndex = 0;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(514, 699);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(180, 54);
            this.btnXuatExcel.TabIndex = 4;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // grpChonThongKe
            // 
            this.grpChonThongKe.Controls.Add(this.tableLayoutPanel2);
            this.grpChonThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChonThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpChonThongKe.Location = new System.Drawing.Point(5, 119);
            this.grpChonThongKe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpChonThongKe.Name = "grpChonThongKe";
            this.grpChonThongKe.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpChonThongKe.Size = new System.Drawing.Size(1199, 66);
            this.grpChonThongKe.TabIndex = 5;
            this.grpChonThongKe.TabStop = false;
            this.grpChonThongKe.Text = "Chọn Thống Kê";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.dtpDenNgay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpTuNgay, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbLoaiThongKe, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThongKe, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1189, 41);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(305, 7);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(281, 27);
            this.dtpDenNgay.TabIndex = 5;
            this.dtpDenNgay.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(10, 7);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(277, 27);
            this.dtpTuNgay.TabIndex = 4;
            this.dtpTuNgay.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // cbLoaiThongKe
            // 
            this.cbLoaiThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLoaiThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiThongKe.FormattingEnabled = true;
            this.cbLoaiThongKe.Items.AddRange(new object[] {
            "Doanh Thu",
            "Số Lượng"});
            this.cbLoaiThongKe.Location = new System.Drawing.Point(636, 7);
            this.cbLoaiThongKe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbLoaiThongKe.Name = "cbLoaiThongKe";
            this.cbLoaiThongKe.Size = new System.Drawing.Size(212, 26);
            this.cbLoaiThongKe.TabIndex = 6;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(944, 5);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(192, 31);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // grpSLThongKe
            // 
            this.grpSLThongKe.Controls.Add(this.tableLayoutPanel3);
            this.grpSLThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSLThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grpSLThongKe.Location = new System.Drawing.Point(5, 195);
            this.grpSLThongKe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpSLThongKe.Name = "grpSLThongKe";
            this.grpSLThongKe.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpSLThongKe.Size = new System.Drawing.Size(1199, 143);
            this.grpSLThongKe.TabIndex = 6;
            this.grpSLThongKe.TabStop = false;
            this.grpSLThongKe.Text = "Thống Kê";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.txtDaiLy, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtTongDoanhThu, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTongDoanhThu, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTongSoXeBanRa, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTongSoXeBanRa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSoKhachHang, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtSoKhachHang, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDaiLy, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1189, 118);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // txtDaiLy
            // 
            this.txtDaiLy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDaiLy.Location = new System.Drawing.Point(896, 77);
            this.txtDaiLy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDaiLy.Name = "txtDaiLy";
            this.txtDaiLy.Size = new System.Drawing.Size(202, 22);
            this.txtDaiLy.TabIndex = 7;
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTongDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongDoanhThu.Location = new System.Drawing.Point(302, 18);
            this.txtTongDoanhThu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(202, 22);
            this.txtTongDoanhThu.TabIndex = 3;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(47, 12);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(245, 34);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // txtTongSoXeBanRa
            // 
            this.txtTongSoXeBanRa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTongSoXeBanRa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongSoXeBanRa.Location = new System.Drawing.Point(896, 18);
            this.txtTongSoXeBanRa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTongSoXeBanRa.Name = "txtTongSoXeBanRa";
            this.txtTongSoXeBanRa.Size = new System.Drawing.Size(202, 22);
            this.txtTongSoXeBanRa.TabIndex = 4;
            // 
            // lblTongSoXeBanRa
            // 
            this.lblTongSoXeBanRa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTongSoXeBanRa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongSoXeBanRa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTongSoXeBanRa.Location = new System.Drawing.Point(634, 12);
            this.lblTongSoXeBanRa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTongSoXeBanRa.Name = "lblTongSoXeBanRa";
            this.lblTongSoXeBanRa.Size = new System.Drawing.Size(252, 34);
            this.lblTongSoXeBanRa.TabIndex = 1;
            this.lblTongSoXeBanRa.Text = "Tổng Số Xe Bán Ra";
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblSoKhachHang.Location = new System.Drawing.Point(47, 71);
            this.lblSoKhachHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(245, 34);
            this.lblSoKhachHang.TabIndex = 2;
            this.lblSoKhachHang.Text = "Số Khách Hàng";
            // 
            // txtSoKhachHang
            // 
            this.txtSoKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoKhachHang.Location = new System.Drawing.Point(302, 77);
            this.txtSoKhachHang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoKhachHang.Name = "txtSoKhachHang";
            this.txtSoKhachHang.Size = new System.Drawing.Size(202, 22);
            this.txtSoKhachHang.TabIndex = 5;
            // 
            // lblDaiLy
            // 
            this.lblDaiLy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDaiLy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDaiLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDaiLy.Location = new System.Drawing.Point(641, 71);
            this.lblDaiLy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDaiLy.Name = "lblDaiLy";
            this.lblDaiLy.Size = new System.Drawing.Size(245, 34);
            this.lblDaiLy.TabIndex = 6;
            this.lblDaiLy.Text = "Đại Lý";
            // 
            // usBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "usBaoCao";
            this.Padding = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.Size = new System.Drawing.Size(1243, 796);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuTheoThongKe)).EndInit();
            this.grpChonThongKe.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpSLThongKe.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThuTheoThongKe;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.GroupBox grpChonThongKe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.ComboBox cbLoaiThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox grpSLThongKe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.TextBox txtTongSoXeBanRa;
        private System.Windows.Forms.TextBox txtSoKhachHang;
        private System.Windows.Forms.Label lblDaiLy;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongSoXeBanRa;
        private System.Windows.Forms.TextBox txtDaiLy;
    }
}
