namespace DoAn.Forms.QLBaoCao
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
            cboLuaChon = new ComboBox();
            cboLoaiThongKe = new ComboBox();
            btnThongKe = new Button();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            grpSLThongKe = new GroupBox();
            tbSLThongKe = new TableLayoutPanel();
            lbl1 = new Label();
            txt2 = new TextBox();
            lbl2 = new Label();
            lblSoKhachHang = new Label();
            lbl3 = new Label();
            txt3 = new TextBox();
            txt1 = new TextBox();
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
            tbChonThongKe.ColumnCount = 5;
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.833334F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.833334F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.833334F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.833334F));
            tbChonThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tbChonThongKe.Controls.Add(cboLuaChon, 3, 0);
            tbChonThongKe.Controls.Add(cboLoaiThongKe, 2, 0);
            tbChonThongKe.Controls.Add(btnThongKe, 4, 0);
            tbChonThongKe.Controls.Add(dtpNgayKetThuc, 1, 0);
            tbChonThongKe.Controls.Add(dtpNgayBatDau, 0, 0);
            tbChonThongKe.Dock = DockStyle.Fill;
            tbChonThongKe.Location = new Point(3, 23);
            tbChonThongKe.Name = "tbChonThongKe";
            tbChonThongKe.RowCount = 1;
            tbChonThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbChonThongKe.Size = new Size(1197, 82);
            tbChonThongKe.TabIndex = 2;
            // 
            // cboLuaChon
            // 
            cboLuaChon.Anchor = AnchorStyles.None;
            cboLuaChon.FormattingEnabled = true;
            cboLuaChon.Location = new Point(803, 27);
            cboLuaChon.Name = "cboLuaChon";
            cboLuaChon.Size = new Size(137, 28);
            cboLuaChon.TabIndex = 5;
            // 
            // cboLoaiThongKe
            // 
            cboLoaiThongKe.Anchor = AnchorStyles.None;
            cboLoaiThongKe.FormattingEnabled = true;
            cboLoaiThongKe.Items.AddRange(new object[] { "Loại Xe", "Nhân Viên" });
            cboLoaiThongKe.Location = new Point(553, 27);
            cboLoaiThongKe.Name = "cboLoaiThongKe";
            cboLoaiThongKe.Size = new Size(138, 28);
            cboLoaiThongKe.TabIndex = 2;
            cboLoaiThongKe.SelectedIndexChanged += cboLoaiThongKe_SelectedIndexChanged;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.None;
            btnThongKe.BackColor = Color.FromArgb(85, 85, 85);
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(1037, 21);
            btnThongKe.Margin = new Padding(4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(118, 40);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Anchor = AnchorStyles.None;
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(306, 27);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(135, 27);
            dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Anchor = AnchorStyles.None;
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(53, 27);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(142, 27);
            dtpNgayBatDau.TabIndex = 0;
            dtpNgayBatDau.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
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
            tbSLThongKe.Controls.Add(lbl1, 0, 0);
            tbSLThongKe.Controls.Add(txt2, 3, 0);
            tbSLThongKe.Controls.Add(lbl2, 2, 0);
            tbSLThongKe.Controls.Add(lblSoKhachHang, 0, 1);
            tbSLThongKe.Controls.Add(lbl3, 1, 1);
            tbSLThongKe.Controls.Add(txt3, 2, 1);
            tbSLThongKe.Controls.Add(txt1, 1, 0);
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
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Right;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl1.ForeColor = Color.FromArgb(50, 50, 50);
            lbl1.Location = new Point(90, 22);
            lbl1.Margin = new Padding(5, 0, 5, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(204, 34);
            lbl1.TabIndex = 0;
            lbl1.Text = "Label1";
            lbl1.Visible = false;
            // 
            // txt2
            // 
            txt2.Anchor = AnchorStyles.None;
            txt2.BorderStyle = BorderStyle.FixedSingle;
            txt2.Location = new Point(968, 26);
            txt2.Margin = new Padding(5);
            txt2.Name = "txt2";
            txt2.ReadOnly = true;
            txt2.Size = new Size(157, 27);
            txt2.TabIndex = 4;
            txt2.Visible = false;
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.Right;
            lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl2.ForeColor = Color.FromArgb(50, 50, 50);
            lbl2.Location = new Point(688, 24);
            lbl2.Margin = new Padding(5, 0, 5, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(204, 30);
            lbl2.TabIndex = 1;
            lbl2.Text = "Label2";
            lbl2.Visible = false;
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
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.Right;
            lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl3.ForeColor = Color.FromArgb(50, 50, 50);
            lbl3.Location = new Point(306, 104);
            lbl3.Margin = new Padding(5, 0, 5, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(287, 30);
            lbl3.TabIndex = 6;
            lbl3.Text = "Label3";
            lbl3.Visible = false;
            // 
            // txt3
            // 
            txt3.Anchor = AnchorStyles.None;
            txt3.BorderStyle = BorderStyle.FixedSingle;
            txt3.Location = new Point(668, 105);
            txt3.Margin = new Padding(5);
            txt3.Name = "txt3";
            txt3.ReadOnly = true;
            txt3.Size = new Size(158, 27);
            txt3.TabIndex = 7;
            txt3.Visible = false;
            // 
            // txt1
            // 
            txt1.Anchor = AnchorStyles.None;
            txt1.BorderStyle = BorderStyle.FixedSingle;
            txt1.Location = new Point(369, 26);
            txt1.Margin = new Padding(5);
            txt1.Name = "txt1";
            txt1.ReadOnly = true;
            txt1.Size = new Size(159, 27);
            txt1.TabIndex = 3;
            txt1.Visible = false;
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
            btnXuatExcel.Click += btnXuatExcel_Click;
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
        private ComboBox cboLoaiThongKe;
        private Button btnThongKe;
        private GroupBox grpSLThongKe;
        private DataGridView dgvThongKe;
        private TableLayoutPanel tbSLThongKe;
        private TextBox txt3;
        private TextBox txt1;
        private Label lbl1;
        private TextBox txt2;
        private Label lbl2;
        private Label lblSoKhachHang;
        private Label lbl3;
        private Panel panelXuatExcel;
        private Button btnXuatExcel;
        private ComboBox cboLuaChon;
    }
}
