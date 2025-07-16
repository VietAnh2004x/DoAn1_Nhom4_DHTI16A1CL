namespace DoAn1.Forms.QLBaoCao
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tbTong = new TableLayoutPanel();
            grpKQThongKe = new GroupBox();
            dgvThongKe = new DataGridView();
            grpChonThongKe = new GroupBox();
            tbChonThongKe = new TableLayoutPanel();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            cboLuaChon = new ComboBox();
            btnThongKe = new Button();
            grpSLThongKe = new GroupBox();
            tbSLThongKe = new TableLayoutPanel();
            txtTongSoXeTheoLoai = new TextBox();
            txtTongDoanhThu = new TextBox();
            lblTongDoanhThu = new Label();
            txtTongSoXeBanRa = new TextBox();
            lblTongSoXeBanRa = new Label();
            lblSoKhachHang = new Label();
            txtSoKhachHang = new TextBox();
            lblDTongSoXeTheoLoai = new Label();
            panelXuatExcel = new Panel();
            btnXuatExcel = new Button();
            tbTong.SuspendLayout();
            grpKQThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            grpChonThongKe.SuspendLayout();
            tbChonThongKe.SuspendLayout();
            grpSLThongKe.SuspendLayout();
            tbSLThongKe.SuspendLayout();
            panelXuatExcel.SuspendLayout();
            SuspendLayout();
            // 
            // tbTong
            // 
            tbTong.AutoSize = true;
            tbTong.ColumnCount = 1;
            tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbTong.Controls.Add(grpKQThongKe, 0, 2);
            tbTong.Controls.Add(grpChonThongKe, 0, 0);
            tbTong.Controls.Add(grpSLThongKe, 0, 1);
            tbTong.Controls.Add(panelXuatExcel, 0, 3);
            tbTong.Dock = DockStyle.Fill;
            tbTong.Location = new Point(17, 15);
            tbTong.Margin = new Padding(5);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 4;
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbTong.Size = new Size(1209, 766);
            tbTong.TabIndex = 0;
            // 
            // grpKQThongKe
            // 
            grpKQThongKe.Controls.Add(dgvThongKe);
            grpKQThongKe.Dock = DockStyle.Fill;
            grpKQThongKe.ForeColor = Color.FromArgb(50, 50, 50);
            grpKQThongKe.Location = new Point(5, 310);
            grpKQThongKe.Margin = new Padding(5);
            grpKQThongKe.Name = "grpKQThongKe";
            grpKQThongKe.Padding = new Padding(5);
            grpKQThongKe.Size = new Size(1199, 373);
            grpKQThongKe.TabIndex = 7;
            grpKQThongKe.TabStop = false;
            grpKQThongKe.Text = "Kết Quả Thống Kê";
            // 
            // dgvThongKe
            // 
            dgvThongKe.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Dock = DockStyle.Fill;
            dgvThongKe.EnableHeadersVisualStyles = false;
            dgvThongKe.Location = new Point(5, 25);
            dgvThongKe.Margin = new Padding(5);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(1189, 343);
            dgvThongKe.TabIndex = 1;
            // 
            // grpChonThongKe
            // 
            grpChonThongKe.Controls.Add(tbChonThongKe);
            grpChonThongKe.Dock = DockStyle.Fill;
            grpChonThongKe.Location = new Point(3, 3);
            grpChonThongKe.Name = "grpChonThongKe";
            grpChonThongKe.Size = new Size(1203, 108);
            grpChonThongKe.TabIndex = 8;
            grpChonThongKe.TabStop = false;
            grpChonThongKe.Text = "Chọn Thống Kê";
            // 
            // tbChonThongKe
            // 
            tbChonThongKe.ColumnCount = 4;
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbChonThongKe.Controls.Add(dtpNgayKetThuc, 1, 0);
            tbChonThongKe.Controls.Add(dtpNgayBatDau, 0, 0);
            tbChonThongKe.Controls.Add(cboLuaChon, 2, 0);
            tbChonThongKe.Controls.Add(btnThongKe, 3, 0);
            tbChonThongKe.Dock = DockStyle.Fill;
            tbChonThongKe.Location = new Point(3, 23);
            tbChonThongKe.Name = "tbChonThongKe";
            tbChonThongKe.RowCount = 1;
            tbChonThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbChonThongKe.Size = new Size(1197, 82);
            tbChonThongKe.TabIndex = 2;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Anchor = AnchorStyles.None;
            dtpNgayKetThuc.Location = new Point(342, 27);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(213, 27);
            dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Anchor = AnchorStyles.None;
            dtpNgayBatDau.Location = new Point(43, 27);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(213, 27);
            dtpNgayBatDau.TabIndex = 0;
            dtpNgayBatDau.Value = new DateTime(2025, 7, 10, 7, 54, 38, 0);
            // 
            // cboLuaChon
            // 
            cboLuaChon.Anchor = AnchorStyles.None;
            cboLuaChon.FormattingEnabled = true;
            cboLuaChon.Items.AddRange(new object[] { "Xe Điện", "Xe Đạp Điện", "Xe Máy Điện" });
            cboLuaChon.Location = new Point(672, 27);
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
            btnThongKe.Location = new Point(988, 21);
            btnThongKe.Margin = new Padding(4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(118, 40);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // grpSLThongKe
            // 
            grpSLThongKe.Controls.Add(tbSLThongKe);
            grpSLThongKe.Dock = DockStyle.Fill;
            grpSLThongKe.Location = new Point(3, 117);
            grpSLThongKe.Name = "grpSLThongKe";
            grpSLThongKe.Size = new Size(1203, 185);
            grpSLThongKe.TabIndex = 9;
            grpSLThongKe.TabStop = false;
            grpSLThongKe.Text = "Số Liệu Thống Kê";
            // 
            // tbSLThongKe
            // 
            tbSLThongKe.ColumnCount = 4;
            tbSLThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbSLThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbSLThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbSLThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbSLThongKe.Controls.Add(txtTongSoXeTheoLoai, 3, 1);
            tbSLThongKe.Controls.Add(txtTongDoanhThu, 1, 0);
            tbSLThongKe.Controls.Add(lblTongDoanhThu, 0, 0);
            tbSLThongKe.Controls.Add(txtTongSoXeBanRa, 3, 0);
            tbSLThongKe.Controls.Add(lblTongSoXeBanRa, 2, 0);
            tbSLThongKe.Controls.Add(lblSoKhachHang, 0, 1);
            tbSLThongKe.Controls.Add(txtSoKhachHang, 1, 1);
            tbSLThongKe.Controls.Add(lblDTongSoXeTheoLoai, 2, 1);
            tbSLThongKe.Dock = DockStyle.Fill;
            tbSLThongKe.Location = new Point(3, 23);
            tbSLThongKe.Margin = new Padding(5);
            tbSLThongKe.Name = "tbSLThongKe";
            tbSLThongKe.RowCount = 2;
            tbSLThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbSLThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbSLThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbSLThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbSLThongKe.Size = new Size(1197, 159);
            tbSLThongKe.TabIndex = 8;
            // 
            // txtTongSoXeTheoLoai
            // 
            txtTongSoXeTheoLoai.Anchor = AnchorStyles.None;
            txtTongSoXeTheoLoai.BorderStyle = BorderStyle.FixedSingle;
            txtTongSoXeTheoLoai.Location = new Point(967, 105);
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
            txtTongDoanhThu.Location = new Point(364, 26);
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
            lblTongDoanhThu.Location = new Point(90, 24);
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
            txtTongSoXeBanRa.Location = new Point(968, 26);
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
            lblTongSoXeBanRa.Location = new Point(655, 22);
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
            lblSoKhachHang.Location = new Point(90, 101);
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
            txtSoKhachHang.Location = new Point(364, 105);
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
            lblDTongSoXeTheoLoai.Location = new Point(655, 103);
            lblDTongSoXeTheoLoai.Margin = new Padding(5, 0, 5, 0);
            lblDTongSoXeTheoLoai.Name = "lblDTongSoXeTheoLoai";
            lblDTongSoXeTheoLoai.Size = new Size(237, 31);
            lblDTongSoXeTheoLoai.TabIndex = 6;
            lblDTongSoXeTheoLoai.Text = "Tổng Số Xe Theo Loại";
            // 
            // panelXuatExcel
            // 
            panelXuatExcel.Controls.Add(btnXuatExcel);
            panelXuatExcel.Dock = DockStyle.Fill;
            panelXuatExcel.Location = new Point(3, 691);
            panelXuatExcel.Name = "panelXuatExcel";
            panelXuatExcel.Size = new Size(1203, 72);
            panelXuatExcel.TabIndex = 10;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.None;
            btnXuatExcel.BackColor = Color.FromArgb(72, 201, 176);
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(526, 12);
            btnXuatExcel.Margin = new Padding(5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(162, 49);
            btnXuatExcel.TabIndex = 6;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
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
            tbChonThongKe.ResumeLayout(false);
            grpSLThongKe.ResumeLayout(false);
            tbSLThongKe.ResumeLayout(false);
            tbSLThongKe.PerformLayout();
            panelXuatExcel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private GroupBox grpKQThongKe;
        private GroupBox grpChonThongKe;
        private TableLayoutPanel tbChonThongKe;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private ComboBox cboLuaChon;
        private Button btnThongKe;
        private GroupBox grpSLThongKe;
        private DataGridView dgvThongKe;
        private TableLayoutPanel tbSLThongKe;
        private TextBox txtTongSoXeTheoLoai;
        private TextBox txtTongDoanhThu;
        private Label lblTongDoanhThu;
        private TextBox txtTongSoXeBanRa;
        private Label lblTongSoXeBanRa;
        private Label lblSoKhachHang;
        private TextBox txtSoKhachHang;
        private Label lblDTongSoXeTheoLoai;
        private Panel panelXuatExcel;
        private Button btnXuatExcel;
    }
}
