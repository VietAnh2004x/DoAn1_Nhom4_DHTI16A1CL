using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    partial class usXeDapDien
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tbTong = new TableLayoutPanel();
            lblTieuDe = new Label();
            tbHienThiXe = new TableLayoutPanel();
            tbHienThiBang = new TableLayoutPanel();
            grpDSXeDapDien = new GroupBox();
            dgvDSXeDapDien = new DataGridView();
            grpTacVu = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpTTXe = new GroupBox();
            txtSoBinhAcQuy = new TextBox();
            txtDungLuongAcQuy = new TextBox();
            txtMauSac = new TextBox();
            txtGia = new TextBox();
            txtTenXe = new TextBox();
            picAnhXe = new PictureBox();
            lblSoBinhAcQuy = new Label();
            lblDungLuongAcQuy = new Label();
            lblMauSac = new Label();
            lblGia = new Label();
            lblTenXe = new Label();
            panel1.SuspendLayout();
            tbTong.SuspendLayout();
            tbHienThiXe.SuspendLayout();
            tbHienThiBang.SuspendLayout();
            grpDSXeDapDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSXeDapDien).BeginInit();
            grpTacVu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grpTTXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhXe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 248, 233);
            panel1.Controls.Add(tbTong);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 750);
            panel1.TabIndex = 0;
            // 
            // tbTong
            // 
            tbTong.ColumnCount = 1;
            tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbTong.Controls.Add(lblTieuDe, 0, 0);
            tbTong.Controls.Add(tbHienThiXe, 0, 1);
            tbTong.Dock = DockStyle.Fill;
            tbTong.Location = new Point(0, 0);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 2;
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tbTong.Size = new Size(1000, 750);
            tbTong.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.Location = new Point(3, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(994, 112);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "THÔNG TIN XE ĐẠP ĐIỆN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbHienThiXe
            // 
            tbHienThiXe.AutoScroll = true;
            tbHienThiXe.ColumnCount = 2;
            tbHienThiXe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tbHienThiXe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tbHienThiXe.Controls.Add(tbHienThiBang, 1, 0);
            tbHienThiXe.Controls.Add(grpTTXe, 0, 0);
            tbHienThiXe.Dock = DockStyle.Fill;
            tbHienThiXe.Location = new Point(3, 115);
            tbHienThiXe.Name = "tbHienThiXe";
            tbHienThiXe.RowCount = 1;
            tbHienThiXe.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbHienThiXe.Size = new Size(994, 632);
            tbHienThiXe.TabIndex = 1;
            // 
            // tbHienThiBang
            // 
            tbHienThiBang.ColumnCount = 1;
            tbHienThiBang.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tbHienThiBang.Controls.Add(grpDSXeDapDien, 0, 0);
            tbHienThiBang.Controls.Add(grpTacVu, 0, 1);
            tbHienThiBang.Dock = DockStyle.Fill;
            tbHienThiBang.Location = new Point(400, 3);
            tbHienThiBang.Name = "tbHienThiBang";
            tbHienThiBang.RowCount = 2;
            tbHienThiBang.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbHienThiBang.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbHienThiBang.Size = new Size(591, 626);
            tbHienThiBang.TabIndex = 0;
            // 
            // grpDSXeDapDien
            // 
            grpDSXeDapDien.Controls.Add(dgvDSXeDapDien);
            grpDSXeDapDien.Dock = DockStyle.Fill;
            grpDSXeDapDien.Location = new Point(3, 3);
            grpDSXeDapDien.Name = "grpDSXeDapDien";
            grpDSXeDapDien.Size = new Size(585, 494);
            grpDSXeDapDien.TabIndex = 0;
            grpDSXeDapDien.TabStop = false;
            grpDSXeDapDien.Text = "Danh sách xe đạp điện";
            // 
            // dgvDSXeDapDien
            // 
            dgvDSXeDapDien.AllowUserToAddRows = false;
            dgvDSXeDapDien.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 102, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSXeDapDien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSXeDapDien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDSXeDapDien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDSXeDapDien.Dock = DockStyle.Fill;
            dgvDSXeDapDien.Location = new Point(3, 21);
            dgvDSXeDapDien.Name = "dgvDSXeDapDien";
            dgvDSXeDapDien.RowHeadersWidth = 51;
            dgvDSXeDapDien.RowTemplate.Height = 24;
            dgvDSXeDapDien.Size = new Size(579, 470);
            dgvDSXeDapDien.TabIndex = 0;
            // 
            // grpTacVu
            // 
            grpTacVu.Controls.Add(tableLayoutPanel1);
            grpTacVu.Dock = DockStyle.Fill;
            grpTacVu.Location = new Point(3, 503);
            grpTacVu.Name = "grpTacVu";
            grpTacVu.Size = new Size(585, 120);
            grpTacVu.TabIndex = 1;
            grpTacVu.TabStop = false;
            grpTacVu.Text = "Tác vụ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel1.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLamMoi, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(579, 96);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.FromArgb(67, 160, 71);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(25, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 35);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.FromArgb(41, 182, 246);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(169, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 35);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.FromArgb(239, 83, 80);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(313, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 35);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 213, 79);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(458, 30);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 35);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // grpTTXe
            // 
            grpTTXe.Controls.Add(txtSoBinhAcQuy);
            grpTTXe.Controls.Add(txtDungLuongAcQuy);
            grpTTXe.Controls.Add(txtMauSac);
            grpTTXe.Controls.Add(txtGia);
            grpTTXe.Controls.Add(txtTenXe);
            grpTTXe.Controls.Add(picAnhXe);
            grpTTXe.Controls.Add(lblSoBinhAcQuy);
            grpTTXe.Controls.Add(lblDungLuongAcQuy);
            grpTTXe.Controls.Add(lblMauSac);
            grpTTXe.Controls.Add(lblGia);
            grpTTXe.Controls.Add(lblTenXe);
            grpTTXe.Dock = DockStyle.Fill;
            grpTTXe.Location = new Point(3, 3);
            grpTTXe.Name = "grpTTXe";
            grpTTXe.Size = new Size(391, 626);
            grpTTXe.TabIndex = 1;
            grpTTXe.TabStop = false;
            grpTTXe.Text = "Thông tin xe";
            // 
            // txtSoBinhAcQuy
            // 
            txtSoBinhAcQuy.BorderStyle = BorderStyle.FixedSingle;
            txtSoBinhAcQuy.Location = new Point(187, 547);
            txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            txtSoBinhAcQuy.Size = new Size(117, 25);
            txtSoBinhAcQuy.TabIndex = 15;
            // 
            // txtDungLuongAcQuy
            // 
            txtDungLuongAcQuy.BorderStyle = BorderStyle.FixedSingle;
            txtDungLuongAcQuy.Location = new Point(187, 457);
            txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            txtDungLuongAcQuy.Size = new Size(117, 25);
            txtDungLuongAcQuy.TabIndex = 14;
            // 
            // txtMauSac
            // 
            txtMauSac.BorderStyle = BorderStyle.FixedSingle;
            txtMauSac.Location = new Point(111, 370);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(117, 25);
            txtMauSac.TabIndex = 13;
            // 
            // txtGia
            // 
            txtGia.BorderStyle = BorderStyle.FixedSingle;
            txtGia.Location = new Point(111, 283);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(117, 25);
            txtGia.TabIndex = 12;
            // 
            // txtTenXe
            // 
            txtTenXe.BorderStyle = BorderStyle.FixedSingle;
            txtTenXe.Location = new Point(111, 196);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(117, 25);
            txtTenXe.TabIndex = 10;
            // 
            // picAnhXe
            // 
            picAnhXe.BackColor = Color.White;
            picAnhXe.BorderStyle = BorderStyle.FixedSingle;
            picAnhXe.Location = new Point(111, 45);
            picAnhXe.Name = "picAnhXe";
            picAnhXe.Size = new Size(176, 95);
            picAnhXe.SizeMode = PictureBoxSizeMode.Zoom;
            picAnhXe.TabIndex = 8;
            picAnhXe.TabStop = false;
            // 
            // lblSoBinhAcQuy
            // 
            lblSoBinhAcQuy.Location = new Point(6, 549);
            lblSoBinhAcQuy.Name = "lblSoBinhAcQuy";
            lblSoBinhAcQuy.Size = new Size(152, 28);
            lblSoBinhAcQuy.TabIndex = 7;
            lblSoBinhAcQuy.Text = "Số Bình Ắc Quy:";
            // 
            // lblDungLuongAcQuy
            // 
            lblDungLuongAcQuy.Location = new Point(6, 459);
            lblDungLuongAcQuy.Name = "lblDungLuongAcQuy";
            lblDungLuongAcQuy.Size = new Size(175, 32);
            lblDungLuongAcQuy.TabIndex = 6;
            lblDungLuongAcQuy.Text = "Dung Lượng Ắc Quy:";
            // 
            // lblMauSac
            // 
            lblMauSac.Location = new Point(8, 372);
            lblMauSac.Name = "lblMauSac";
            lblMauSac.Size = new Size(79, 32);
            lblMauSac.TabIndex = 5;
            lblMauSac.Text = "Màu Sắc:";
            // 
            // lblGia
            // 
            lblGia.Location = new Point(8, 285);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(44, 32);
            lblGia.TabIndex = 3;
            lblGia.Text = "Giá:";
            // 
            // lblTenXe
            // 
            lblTenXe.Location = new Point(6, 198);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(81, 32);
            lblTenXe.TabIndex = 2;
            lblTenXe.Text = "Tên Xe:";
            // 
            // usXeDapDien
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usXeDapDien";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbTong.ResumeLayout(false);
            tbHienThiXe.ResumeLayout(false);
            tbHienThiBang.ResumeLayout(false);
            grpDSXeDapDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSXeDapDien).EndInit();
            grpTacVu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            grpTTXe.ResumeLayout(false);
            grpTTXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhXe).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiXe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiBang;
        private System.Windows.Forms.GroupBox grpDSXeDapDien;
        private System.Windows.Forms.GroupBox grpTTXe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.Label lblSoBinhAcQuy;
        private System.Windows.Forms.Label lblDungLuongAcQuy;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.DataGridView dgvDSXeDapDien;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.PictureBox picAnhXe;
        private TextBox txtSoBinhAcQuy;
        private TextBox txtDungLuongAcQuy;
        private TextBox txtMauSac;
        private Label lblMauSac;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
    }
}
