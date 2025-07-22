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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tbTong = new TableLayoutPanel();
            grpKQThongKe = new GroupBox();
            dgvThongKe = new DataGridView();
            grpChonThongKe = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            btnThongKe = new Button();
            grpThongKe = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtTongSoXeTheoLoai = new TextBox();
            txtTongDoanhThu = new TextBox();
            lblTongDoanhThu = new Label();
            txtTongSoXeBanRa = new TextBox();
            lblTongSoXeBanRa = new Label();
            lblSoKhachHang = new Label();
            txtSoKhachHang = new TextBox();
            lblDTongSoXeTheoLoai = new Label();
            grpDoanhThu = new GroupBox();
            dgvThongKe = new DataGridView();
            btnXuatExcel = new Button();
            lblTieuDe = new Label();
            tableLayoutPanel1.SuspendLayout();
            grpChonThongKe.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpThongKe.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            grpDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            grpChonThongKe.SuspendLayout();
            tbChonThongKe.SuspendLayout();
            grpSLThongKe.SuspendLayout();
            tbSLThongKe.SuspendLayout();
            SuspendLayout();
            // 
            // tbTong
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(grpChonThongKe, 0, 1);
            tableLayoutPanel1.Controls.Add(grpThongKe, 0, 2);
            tableLayoutPanel1.Controls.Add(grpDoanhThu, 0, 3);
            tableLayoutPanel1.Controls.Add(btnXuatExcel, 0, 4);
            tableLayoutPanel1.Controls.Add(lblTieuDe, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(17, 15);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1209, 766);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // grpKQThongKe
            // 
            grpKQThongKe.Controls.Add(dgvThongKe);
            grpKQThongKe.Dock = DockStyle.Fill;
            grpKQThongKe.ForeColor = Color.FromArgb(50, 50, 50);
            grpKQThongKe.Location = new Point(5, 309);
            grpKQThongKe.Margin = new Padding(5);
            grpKQThongKe.Name = "grpKQThongKe";
            grpKQThongKe.Padding = new Padding(5);
            grpKQThongKe.Size = new Size(1199, 452); // Adjusted height
            grpKQThongKe.TabIndex = 7;
            grpKQThongKe.TabStop = false;
            grpKQThongKe.Text = "Kết Quả Thống Kê";
            // 
            // dgvThongKe
            // 
            dgvThongKe.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Dock = DockStyle.Fill;
            dgvThongKe.EnableHeadersVisualStyles = false;
            dgvThongKe.Location = new Point(5, 29);
            dgvThongKe.Margin = new Padding(5);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(1189, 418); // Adjusted size
            dgvThongKe.TabIndex = 1;
            // 
            // grpChonThongKe
            // 
            grpChonThongKe.Controls.Add(tbChonThongKe);
            grpChonThongKe.Dock = DockStyle.Fill;
            grpChonThongKe.Location = new Point(3, 3);
            grpChonThongKe.Name = "grpChonThongKe";
            grpChonThongKe.Size = new Size(1203, 131);
            grpChonThongKe.TabIndex = 8;
            grpChonThongKe.TabStop = false;
            grpChonThongKe.Text = "Chọn Thống Kê";
            // 
            // tbChonThongKe
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(dtpNgayKetThuc, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpNgayBatDau, 0, 0);
            tableLayoutPanel2.Controls.Add(cboLuaChon, 2, 0);
            tableLayoutPanel2.Controls.Add(btnThongKe, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1189, 74);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // cboDanhSachLuaChon
            // 
            cboDanhSachLuaChon.Anchor = AnchorStyles.None;
            cboDanhSachLuaChon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDanhSachLuaChon.FormattingEnabled = true;
            cboDanhSachLuaChon.Items.AddRange(new object[] { "Xe Điện", "Xe Đạp Điện", "Xe Máy Điện" });
            cboDanhSachLuaChon.Location = new Point(754, 21);
            cboDanhSachLuaChon.Name = "cboDanhSachLuaChon";
            cboDanhSachLuaChon.Size = new Size(151, 31);
            cboDanhSachLuaChon.TabIndex = 5;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Anchor = AnchorStyles.None;
            dtpNgayKetThuc.Location = new Point(339, 23);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(213, 27);
            dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Anchor = AnchorStyles.None;
            dtpNgayBatDau.Location = new Point(42, 23);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(213, 27);
            dtpNgayBatDau.TabIndex = 0;
            dtpNgayBatDau.Value = new DateTime(2025, 7, 10, 0, 0, 0, 0);
            // 
            // cboLuaChon
            // 
            cboLuaChon.Anchor = AnchorStyles.None;
            cboLuaChon.FormattingEnabled = true;
            cboLuaChon.Items.AddRange(new object[] { "Xe Điện", "Xe Đạp Điện", "Xe Máy Điện" });
            cboLuaChon.Location = new Point(667, 23);
            cboLuaChon.Name = "cboLuaChon";
            cboLuaChon.Size = new Size(151, 28);
            cboLuaChon.TabIndex = 2;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.None;
            btnThongKe.BackColor = Color.FromArgb(85, 85, 85);
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(981, 17);
            btnThongKe.Margin = new Padding(4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(118, 40);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // cboChiTietThongKe
            // 
            cboChiTietThongKe.Anchor = AnchorStyles.None;
            cboChiTietThongKe.FormattingEnabled = true;
            cboChiTietThongKe.Location = new Point(672, 60);
            cboChiTietThongKe.Name = "cboChiTietThongKe";
            cboChiTietThongKe.Size = new Size(151, 33);
            cboChiTietThongKe.TabIndex = 5;
            // 
            // cboChonThongKe
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(txtTongSoXeTheoLoai, 3, 1);
            tableLayoutPanel3.Controls.Add(txtTongDoanhThu, 1, 0);
            tableLayoutPanel3.Controls.Add(lblTongDoanhThu, 0, 0);
            tableLayoutPanel3.Controls.Add(txtTongSoXeBanRa, 3, 0);
            tableLayoutPanel3.Controls.Add(lblTongSoXeBanRa, 2, 0);
            tableLayoutPanel3.Controls.Add(lblSoKhachHang, 0, 1);
            tableLayoutPanel3.Controls.Add(txtSoKhachHang, 1, 1);
            tableLayoutPanel3.Controls.Add(lblDTongSoXeTheoLoai, 2, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 25);
            tableLayoutPanel3.Margin = new Padding(5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(1189, 113);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // txtTongSoXeTheoLoai
            // 
            txtTongSoXeTheoLoai.Anchor = AnchorStyles.None;
            txtTongSoXeTheoLoai.BorderStyle = BorderStyle.FixedSingle;
            txtTongSoXeTheoLoai.Location = new Point(960, 71);
            txtTongSoXeTheoLoai.Margin = new Padding(5);
            txtTongSoXeTheoLoai.Name = "txtTongSoXeTheoLoai";
            txtTongSoXeTheoLoai.ReadOnly = true;
            txtTongSoXeTheoLoai.Size = new Size(160, 27);
            txtTongSoXeTheoLoai.TabIndex = 7;
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.Anchor = AnchorStyles.None;
            txtTongDoanhThu.BorderStyle = BorderStyle.FixedSingle;
            txtTongDoanhThu.Location = new Point(361, 14);
            txtTongDoanhThu.Margin = new Padding(5);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.ReadOnly = true;
            txtTongDoanhThu.Size = new Size(169, 27);
            txtTongDoanhThu.TabIndex = 3;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.Anchor = AnchorStyles.Right;
            lblTongDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongDoanhThu.ForeColor = Color.FromArgb(50, 50, 50);
            lblTongDoanhThu.Location = new Point(88, 12);
            lblTongDoanhThu.Margin = new Padding(5, 0, 5, 0);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(204, 31);
            lblTongDoanhThu.TabIndex = 0;
            lblTongDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // txtTongSoXeBanRa
            // 
            txtTongSoXeBanRa.Anchor = AnchorStyles.None;
            txtTongSoXeBanRa.BorderStyle = BorderStyle.FixedSingle;
            txtTongSoXeBanRa.Location = new Point(961, 14);
            txtTongSoXeBanRa.Margin = new Padding(5);
            txtTongSoXeBanRa.Name = "txtTongSoXeBanRa";
            txtTongSoXeBanRa.ReadOnly = true;
            txtTongSoXeBanRa.Size = new Size(157, 27);
            txtTongSoXeBanRa.TabIndex = 4;
            // 
            // lblTongSoXeBanRa
            // 
            lblTongSoXeBanRa.Anchor = AnchorStyles.Right;
            lblTongSoXeBanRa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongSoXeBanRa.ForeColor = Color.FromArgb(50, 50, 50);
            lblTongSoXeBanRa.Location = new Point(649, 10);
            lblTongSoXeBanRa.Margin = new Padding(5, 0, 5, 0);
            lblTongSoXeBanRa.Name = "lblTongSoXeBanRa";
            lblTongSoXeBanRa.Size = new Size(237, 35);
            lblTongSoXeBanRa.TabIndex = 1;
            lblTongSoXeBanRa.Text = "Tổng Số Xe Bán Ra";
            // 
            // lblSoKhachHang
            // 
            lblSoKhachHang.Anchor = AnchorStyles.Right;
            lblSoKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSoKhachHang.ForeColor = Color.FromArgb(50, 50, 50);
            lblSoKhachHang.Location = new Point(88, 67);
            lblSoKhachHang.Margin = new Padding(5, 0, 5, 0);
            lblSoKhachHang.Name = "lblSoKhachHang";
            lblSoKhachHang.Size = new Size(204, 35);
            lblSoKhachHang.TabIndex = 2;
            lblSoKhachHang.Text = "Số Khách Hàng";
            // 
            // txtSoKhachHang
            // 
            txtSoKhachHang.Anchor = AnchorStyles.None;
            txtSoKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtSoKhachHang.Location = new Point(361, 71);
            txtSoKhachHang.Margin = new Padding(5);
            txtSoKhachHang.Name = "txtSoKhachHang";
            txtSoKhachHang.ReadOnly = true;
            txtSoKhachHang.Size = new Size(169, 27);
            txtSoKhachHang.TabIndex = 5;
            // 
            // lblDTongSoXeTheoLoai
            // 
            lblDTongSoXeTheoLoai.Anchor = AnchorStyles.Right;
            lblDTongSoXeTheoLoai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDTongSoXeTheoLoai.ForeColor = Color.FromArgb(50, 50, 50);
            lblDTongSoXeTheoLoai.Location = new Point(649, 69);
            lblDTongSoXeTheoLoai.Margin = new Padding(5, 0, 5, 0);
            lblDTongSoXeTheoLoai.Name = "lblDTongSoXeTheoLoai";
            lblDTongSoXeTheoLoai.Size = new Size(237, 31);
            lblDTongSoXeTheoLoai.TabIndex = 6;
            lblDTongSoXeTheoLoai.Text = "Tổng Số Xe Theo Loại";
            // 
            // grpDoanhThu
            // 
            grpDoanhThu.Controls.Add(dgvThongKe);
            grpDoanhThu.Dock = DockStyle.Fill;
            grpDoanhThu.ForeColor = Color.FromArgb(50, 50, 50);
            grpDoanhThu.Location = new Point(5, 386);
            grpDoanhThu.Margin = new Padding(5);
            grpDoanhThu.Name = "grpDoanhThu";
            grpDoanhThu.Padding = new Padding(5);
            grpDoanhThu.Size = new Size(1199, 296);
            grpDoanhThu.TabIndex = 3;
            grpDoanhThu.TabStop = false;
            grpDoanhThu.Text = "Chi tiết theo thống kê";
            // 
            // txtSL2
            // 
            txtSL2.Anchor = AnchorStyles.None;
            txtSL2.BorderStyle = BorderStyle.FixedSingle;
            txtSL2.Location = new Point(968, 17);
            txtSL2.Margin = new Padding(5);
            txtSL2.Name = "txtSL2";
            txtSL2.ReadOnly = true;
            txtSL2.Size = new Size(157, 31);
            txtSL2.TabIndex = 4;
            // 
            // lblSL2
            // 
            lblSL2.Anchor = AnchorStyles.Right;
            lblSL2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSL2.ForeColor = Color.FromArgb(50, 50, 50);
            lblSL2.Location = new Point(655, 16);
            lblSL2.Margin = new Padding(5, 0, 5, 0);
            lblSL2.Name = "lblSL2";
            lblSL2.Size = new Size(237, 35);
            lblSL2.TabIndex = 1;
            lblSL2.Text = "Tổng Số Xe Bán Ra";
            // 
            // lblSL3
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTieuDe.Location = new System.Drawing.Point(4, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1299, 134);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÁO CÁO - THỐNG KÊ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usBaoCao
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tbTong);
            Margin = new Padding(5);
            Name = "usBaoCao";
            Padding = new Padding(17, 15, 17, 15);
            Size = new Size(1243, 796);
            Load += usBaoCao_Load;
            tbTong.ResumeLayout(false);
            grpKQThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            grpChonThongKe.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            grpThongKe.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            grpDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpDoanhThu;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnXuatExcel;
        private GroupBox grpThongKe;
        private GroupBox grpChonThongKe;
        private TableLayoutPanel tbChonThongKe;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private Button btnThongKe;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtTongSoXeTheoLoai;
        private TextBox txtTongDoanhThu;
        private Label lblTongDoanhThu;
        private TextBox txtTongSoXeBanRa;
        private Label lblTongSoXeBanRa;
        private Label lblSoKhachHang;
        private TextBox txtSoKhachHang;
        private Label lblDTongSoXeTheoLoai;
        private Label lblTieuDe;
    }
}
