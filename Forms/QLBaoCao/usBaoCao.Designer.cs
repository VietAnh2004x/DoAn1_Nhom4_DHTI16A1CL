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
            tbChonThongKe = new TableLayoutPanel();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            btnThongKe = new Button();
            cboChiTietThongKe = new ComboBox();
            cboChonThongKe = new ComboBox();
            lblChonLoaiThongKe = new Label();
            lblChonChiTietThongKe = new Label();
            grpSLThongKe = new GroupBox();
            tbSLThongKe = new TableLayoutPanel();
            txtSL3 = new TextBox();
            txtSL1 = new TextBox();
            lblSL1 = new Label();
            txtSL2 = new TextBox();
            lblSL2 = new Label();
            lblSL3 = new Label();
            tbTong.SuspendLayout();
            grpKQThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            grpChonThongKe.SuspendLayout();
            tbChonThongKe.SuspendLayout();
            grpSLThongKe.SuspendLayout();
            tbSLThongKe.SuspendLayout();
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
            tbTong.Dock = DockStyle.Fill;
            tbTong.Location = new Point(17, 15);
            tbTong.Margin = new Padding(5);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 3; // Reduced row count, no Excel button
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 60F)); // Increased height for dgv
            tbTong.Size = new Size(1209, 766);
            tbTong.TabIndex = 0;
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
            tbChonThongKe.ColumnCount = 4;
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbChonThongKe.Controls.Add(dtpNgayKetThuc, 1, 0);
            tbChonThongKe.Controls.Add(dtpNgayBatDau, 0, 0);
            tbChonThongKe.Controls.Add(btnThongKe, 3, 1);
            tbChonThongKe.Controls.Add(cboChiTietThongKe, 2, 1);
            tbChonThongKe.Controls.Add(cboChonThongKe, 2, 0);
            tbChonThongKe.Controls.Add(lblChonLoaiThongKe, 3, 0);
            tbChonThongKe.Controls.Add(lblChonChiTietThongKe, 3, 1);
            tbChonThongKe.Dock = DockStyle.Fill;
            tbChonThongKe.Location = new Point(3, 27);
            tbChonThongKe.Name = "tbChonThongKe";
            tbChonThongKe.RowCount = 2;
            tbChonThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbChonThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbChonThongKe.Size = new Size(1197, 101);
            tbChonThongKe.TabIndex = 2;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Anchor = AnchorStyles.None;
            dtpNgayKetThuc.Location = new Point(342, 10);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(213, 31);
            dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Anchor = AnchorStyles.None;
            dtpNgayBatDau.Location = new Point(43, 10);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(213, 31);
            dtpNgayBatDau.TabIndex = 0;
            dtpNgayBatDau.Value = new DateTime(2025, 7, 10, 7, 54, 38, 0);
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.None;
            btnThongKe.BackColor = Color.FromArgb(85, 85, 85);
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(988, 55);
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
            cboChonThongKe.Anchor = AnchorStyles.None;
            cboChonThongKe.FormattingEnabled = true;
            cboChonThongKe.Location = new Point(672, 9);
            cboChonThongKe.Name = "cboChonThongKe";
            cboChonThongKe.Size = new Size(151, 33);
            cboChonThongKe.TabIndex = 6;
            cboChonThongKe.SelectedIndexChanged += cboChonThongKe_SelectedIndexChanged;
            // 
            // lblChonLoaiThongKe
            // 
            lblChonLoaiThongKe.Anchor = AnchorStyles.Right;
            lblChonLoaiThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChonLoaiThongKe.ForeColor = Color.FromArgb(50, 50, 50);
            lblChonLoaiThongKe.Location = new Point(888, 10);
            lblChonLoaiThongKe.Margin = new Padding(5, 0, 5, 0);
            lblChonLoaiThongKe.Name = "lblChonLoaiThongKe";
            lblChonLoaiThongKe.Size = new Size(100, 31);
            lblChonLoaiThongKe.TabIndex = 7;
            lblChonLoaiThongKe.Text = "Thống kê theo:";
            lblChonLoaiThongKe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblChonChiTietThongKe
            // 
            lblChonChiTietThongKe.Anchor = AnchorStyles.Right;
            lblChonChiTietThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChonChiTietThongKe.ForeColor = Color.FromArgb(50, 50, 50);
            lblChonChiTietThongKe.Location = new Point(888, 60);
            lblChonChiTietThongKe.Margin = new Padding(5, 0, 5, 0);
            lblChonChiTietThongKe.Name = "lblChonChiTietThongKe";
            lblChonChiTietThongKe.Size = new Size(100, 31);
            lblChonChiTietThongKe.TabIndex = 8;
            lblChonChiTietThongKe.Text = "Chọn:";
            lblChonChiTietThongKe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // grpSLThongKe
            // 
            grpSLThongKe.Controls.Add(tbSLThongKe);
            grpSLThongKe.Dock = DockStyle.Fill;
            grpSLThongKe.Location = new Point(3, 140);
            grpSLThongKe.Name = "grpSLThongKe";
            grpSLThongKe.Size = new Size(1203, 161);
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
            tbSLThongKe.Controls.Add(txtSL3, 3, 1);
            tbSLThongKe.Controls.Add(txtSL1, 1, 0);
            tbSLThongKe.Controls.Add(lblSL1, 0, 0);
            tbSLThongKe.Controls.Add(txtSL2, 3, 0);
            tbSLThongKe.Controls.Add(lblSL2, 2, 0);
            tbSLThongKe.Controls.Add(lblSL3, 2, 1);
            tbSLThongKe.Dock = DockStyle.Fill;
            tbSLThongKe.Location = new Point(3, 27);
            tbSLThongKe.Margin = new Padding(5);
            tbSLThongKe.Name = "tbSLThongKe";
            tbSLThongKe.RowCount = 2;
            tbSLThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbSLThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbSLThongKe.Size = new Size(1197, 131);
            tbSLThongKe.TabIndex = 8;
            // 
            // txtSL3
            // 
            txtSL3.Anchor = AnchorStyles.None;
            txtSL3.BorderStyle = BorderStyle.FixedSingle;
            txtSL3.Location = new Point(967, 85);
            txtSL3.Margin = new Padding(5);
            txtSL3.Name = "txtSL3";
            txtSL3.ReadOnly = true;
            txtSL3.Size = new Size(160, 31);
            txtSL3.TabIndex = 7;
            // 
            // txtSL1
            // 
            txtSL1.Anchor = AnchorStyles.None;
            txtSL1.BorderStyle = BorderStyle.FixedSingle;
            txtSL1.Location = new Point(364, 17);
            txtSL1.Margin = new Padding(5);
            txtSL1.Name = "txtSL1";
            txtSL1.ReadOnly = true;
            txtSL1.Size = new Size(169, 31);
            txtSL1.TabIndex = 3;
            // 
            // lblSL1
            // 
            lblSL1.Anchor = AnchorStyles.Right;
            lblSL1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSL1.ForeColor = Color.FromArgb(50, 50, 50);
            lblSL1.Location = new Point(90, 17);
            lblSL1.Margin = new Padding(5, 0, 5, 0);
            lblSL1.Name = "lblSL1";
            lblSL1.Size = new Size(204, 31);
            lblSL1.TabIndex = 0;
            lblSL1.Text = "Tổng Doanh Thu";
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
            lblSL3.Anchor = AnchorStyles.Right;
            lblSL3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSL3.ForeColor = Color.FromArgb(50, 50, 50);
            lblSL3.Location = new Point(655, 84);
            lblSL3.Margin = new Padding(5, 0, 5, 0);
            lblSL3.Name = "lblSL3";
            lblSL3.Size = new Size(237, 31);
            lblSL3.TabIndex = 6;
            lblSL3.Text = "Tổng Số Xe Còn Kho";
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
            ResumeLayout(false);
            PerformLayout();

        }
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private GroupBox grpKQThongKe;
        private GroupBox grpChonThongKe;
        private TableLayoutPanel tbChonThongKe;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private Button btnThongKe;
        private GroupBox grpSLThongKe;
        private DataGridView dgvThongKe;
        private TableLayoutPanel tbSLThongKe;
        private TextBox txtSL3;
        private TextBox txtSL1;
        private Label lblSL1;
        private TextBox txtSL2;
        private Label lblSL2;
        private Label lblSL3;
        private ComboBox cboChiTietThongKe;
        private ComboBox cboChonThongKe;
        private Label lblChonLoaiThongKe;
        private Label lblChonChiTietThongKe;
    }
}
