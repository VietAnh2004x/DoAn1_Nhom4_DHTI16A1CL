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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            grpChonThongKe = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            cboDanhSachLuaChon = new ComboBox();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            cboLuaChon = new ComboBox();
            btnThongKe = new Button();
            grpThongKe = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txt1 = new TextBox();
            lbl1 = new Label();
            txt2 = new TextBox();
            lbl2 = new Label();
            lbl3 = new Label();
            txt3 = new TextBox();
            grpDoAn1_Nhom4_DHTI16A1CLhThu = new GroupBox();
            dgvThongKe = new DataGridView();
            btnXuatExcel = new Button();
            lblTieuDe = new Label();
            tableLayoutPanel1.SuspendLayout();
            grpChonThongKe.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpThongKe.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            grpDoAn1_Nhom4_DHTI16A1CLhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(grpChonThongKe, 0, 1);
            tableLayoutPanel1.Controls.Add(grpThongKe, 0, 2);
            tableLayoutPanel1.Controls.Add(grpDoAn1_Nhom4_DHTI16A1CLhThu, 0, 3);
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
            // grpChonThongKe
            // 
            grpChonThongKe.AutoSize = true;
            grpChonThongKe.Controls.Add(tableLayoutPanel2);
            grpChonThongKe.Dock = DockStyle.Fill;
            grpChonThongKe.ForeColor = Color.FromArgb(50, 50, 50);
            grpChonThongKe.Location = new Point(5, 119);
            grpChonThongKe.Margin = new Padding(5);
            grpChonThongKe.Name = "grpChonThongKe";
            grpChonThongKe.Padding = new Padding(5);
            grpChonThongKe.Size = new Size(1199, 104);
            grpChonThongKe.TabIndex = 8;
            grpChonThongKe.TabStop = false;
            grpChonThongKe.Text = "Chọn Thống Kê";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(cboDanhSachLuaChon, 3, 0);
            tableLayoutPanel2.Controls.Add(dtpNgayKetThuc, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpNgayBatDau, 0, 0);
            tableLayoutPanel2.Controls.Add(cboLuaChon, 2, 0);
            tableLayoutPanel2.Controls.Add(btnThongKe, 4, 0);
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
            dtpNgayKetThuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(278, 22);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(155, 30);
            dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Anchor = AnchorStyles.None;
            dtpNgayBatDau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(44, 22);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(149, 30);
            dtpNgayBatDau.TabIndex = 0;
            dtpNgayBatDau.Value = new DateTime(2025, 7, 10, 0, 0, 0, 0);
            // 
            // cboLuaChon
            // 
            cboLuaChon.Anchor = AnchorStyles.None;
            cboLuaChon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLuaChon.FormattingEnabled = true;
            cboLuaChon.Items.AddRange(new object[] { "Loại Xe", "Nhân Viên" });
            cboLuaChon.Location = new Point(517, 21);
            cboLuaChon.Name = "cboLuaChon";
            cboLuaChon.Size = new Size(151, 31);
            cboLuaChon.TabIndex = 2;
            cboLuaChon.SelectedIndexChanged += cboLuaChon_SelectedIndexChanged;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.None;
            btnThongKe.BackColor = Color.FromArgb(85, 85, 85);
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(1009, 17);
            btnThongKe.Margin = new Padding(4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(118, 40);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // grpThongKe
            // 
            grpThongKe.Controls.Add(tableLayoutPanel3);
            grpThongKe.Dock = DockStyle.Fill;
            grpThongKe.ForeColor = Color.FromArgb(50, 50, 50);
            grpThongKe.Location = new Point(5, 233);
            grpThongKe.Margin = new Padding(5);
            grpThongKe.Name = "grpThongKe";
            grpThongKe.Padding = new Padding(5);
            grpThongKe.Size = new Size(1199, 143);
            grpThongKe.TabIndex = 7;
            grpThongKe.TabStop = false;
            grpThongKe.Text = "Thống Kê";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(txt1, 1, 0);
            tableLayoutPanel3.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel3.Controls.Add(txt2, 3, 0);
            tableLayoutPanel3.Controls.Add(lbl2, 2, 0);
            tableLayoutPanel3.Controls.Add(lbl3, 1, 1);
            tableLayoutPanel3.Controls.Add(txt3, 2, 1);
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
            // txt1
            // 
            txt1.Anchor = AnchorStyles.None;
            txt1.BorderStyle = BorderStyle.FixedSingle;
            txt1.Location = new Point(361, 14);
            txt1.Margin = new Padding(5);
            txt1.Name = "txt1";
            txt1.ReadOnly = true;
            txt1.Size = new Size(169, 27);
            txt1.TabIndex = 3;
            txt1.Visible = false;
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Right;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl1.ForeColor = Color.FromArgb(50, 50, 50);
            lbl1.Location = new Point(88, 12);
            lbl1.Margin = new Padding(5, 0, 5, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(204, 31);
            lbl1.TabIndex = 0;
            lbl1.Text = "Label1";
            lbl1.Visible = false;
            // 
            // txt2
            // 
            txt2.Anchor = AnchorStyles.None;
            txt2.BorderStyle = BorderStyle.FixedSingle;
            txt2.Location = new Point(961, 14);
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
            lbl2.Location = new Point(649, 10);
            lbl2.Margin = new Padding(5, 0, 5, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(237, 35);
            lbl2.TabIndex = 1;
            lbl2.Text = "Label2";
            lbl2.Visible = false;
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.Right;
            lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl3.ForeColor = Color.FromArgb(50, 50, 50);
            lbl3.Location = new Point(352, 69);
            lbl3.Margin = new Padding(5, 0, 5, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(237, 31);
            lbl3.TabIndex = 6;
            lbl3.Text = "Label3";
            lbl3.Visible = false;
            // 
            // txt3
            // 
            txt3.Anchor = AnchorStyles.None;
            txt3.BorderStyle = BorderStyle.FixedSingle;
            txt3.Location = new Point(662, 71);
            txt3.Margin = new Padding(5);
            txt3.Name = "txt3";
            txt3.ReadOnly = true;
            txt3.Size = new Size(160, 27);
            txt3.TabIndex = 7;
            txt3.Visible = false;
            // 
            // grpDoAn1_Nhom4_DHTI16A1CLhThu
            // 
            grpDoAn1_Nhom4_DHTI16A1CLhThu.Controls.Add(dgvThongKe);
            grpDoAn1_Nhom4_DHTI16A1CLhThu.Dock = DockStyle.Fill;
            grpDoAn1_Nhom4_DHTI16A1CLhThu.ForeColor = Color.FromArgb(50, 50, 50);
            grpDoAn1_Nhom4_DHTI16A1CLhThu.Location = new Point(5, 386);
            grpDoAn1_Nhom4_DHTI16A1CLhThu.Margin = new Padding(5);
            grpDoAn1_Nhom4_DHTI16A1CLhThu.Name = "grpDoAn1_Nhom4_DHTI16A1CLhThu";
            grpDoAn1_Nhom4_DHTI16A1CLhThu.Padding = new Padding(5);
            grpDoAn1_Nhom4_DHTI16A1CLhThu.Size = new Size(1199, 296);
            grpDoAn1_Nhom4_DHTI16A1CLhThu.TabIndex = 3;
            grpDoAn1_Nhom4_DHTI16A1CLhThu.TabStop = false;
            grpDoAn1_Nhom4_DHTI16A1CLhThu.Text = "Chi tiết theo thống kê";
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
            dgvThongKe.Size = new Size(1189, 266);
            dgvThongKe.TabIndex = 0;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.None;
            btnXuatExcel.BackColor = Color.FromArgb(72, 201, 176);
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(547, 706);
            btnXuatExcel.Margin = new Padding(5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(115, 41);
            btnXuatExcel.TabIndex = 4;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(50, 50, 50);
            lblTieuDe.Location = new Point(4, 0);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1201, 114);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÁO CÁO - THỐNG KÊ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usBaoCao
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5);
            Name = "usBaoCao";
            Padding = new Padding(17, 15, 17, 15);
            Size = new Size(1243, 796);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            grpChonThongKe.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            grpThongKe.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            grpDoAn1_Nhom4_DHTI16A1CLhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpDoAn1_Nhom4_DHTI16A1CLhThu;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnXuatExcel;
        private GroupBox grpThongKe;
        private GroupBox grpChonThongKe;
        private TableLayoutPanel tableLayoutPanel2;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private ComboBox cboLuaChon;
        private Button btnThongKe;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txt3;
        private TextBox txt1;
        private Label lbl1;
        private TextBox txt2;
        private Label lbl2;
        private Label lbl3;
        private Label lblTieuDe;
        private ComboBox cboDanhSachLuaChon;
    }
}
