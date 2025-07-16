using System.Windows.Forms;

namespace DoAn1.Forms.QLXe
{
    partial class usXeMayDien
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
            panel1 = new Panel();
            tbHienThiXe = new TableLayoutPanel();
            tbHienThiBang = new TableLayoutPanel();
            grpDSXeMayDien = new GroupBox();
            dgvDSXeMayDien = new DataGridView();
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
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
            tbHienThiXe.SuspendLayout();
            tbHienThiBang.SuspendLayout();
            grpDSXeMayDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSXeMayDien).BeginInit();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
            grpTTXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhXe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbHienThiXe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 750);
            panel1.TabIndex = 0;
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
            tbHienThiXe.Location = new Point(0, 0);
            tbHienThiXe.Name = "tbHienThiXe";
            tbHienThiXe.RowCount = 1;
            tbHienThiXe.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbHienThiXe.Size = new Size(1000, 750);
            tbHienThiXe.TabIndex = 2;
            // 
            // tbHienThiBang
            // 
            tbHienThiBang.ColumnCount = 1;
            tbHienThiBang.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tbHienThiBang.Controls.Add(grpDSXeMayDien, 0, 0);
            tbHienThiBang.Controls.Add(grpTacVu, 0, 1);
            tbHienThiBang.Dock = DockStyle.Fill;
            tbHienThiBang.Location = new Point(403, 3);
            tbHienThiBang.Name = "tbHienThiBang";
            tbHienThiBang.RowCount = 2;
            tbHienThiBang.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbHienThiBang.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbHienThiBang.Size = new Size(594, 744);
            tbHienThiBang.TabIndex = 0;
            // 
            // grpDSXeMayDien
            // 
            grpDSXeMayDien.Controls.Add(dgvDSXeMayDien);
            grpDSXeMayDien.Dock = DockStyle.Fill;
            grpDSXeMayDien.Location = new Point(3, 3);
            grpDSXeMayDien.Name = "grpDSXeMayDien";
            grpDSXeMayDien.Size = new Size(588, 589);
            grpDSXeMayDien.TabIndex = 0;
            grpDSXeMayDien.TabStop = false;
            grpDSXeMayDien.Text = "Danh sách xe máy điện";
            // 
            // dgvDSXeMayDien
            // 
            dgvDSXeMayDien.AllowUserToAddRows = false;
            dgvDSXeMayDien.BackgroundColor = Color.White;
            dgvDSXeMayDien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSXeMayDien.Dock = DockStyle.Fill;
            dgvDSXeMayDien.Location = new Point(3, 26);
            dgvDSXeMayDien.Name = "dgvDSXeMayDien";
            dgvDSXeMayDien.RowHeadersWidth = 51;
            dgvDSXeMayDien.Size = new Size(582, 560);
            dgvDSXeMayDien.TabIndex = 0;
            // 
            // grpTacVu
            // 
            grpTacVu.Controls.Add(tbTacVu);
            grpTacVu.Dock = DockStyle.Fill;
            grpTacVu.Location = new Point(3, 598);
            grpTacVu.Name = "grpTacVu";
            grpTacVu.Size = new Size(588, 143);
            grpTacVu.TabIndex = 1;
            grpTacVu.TabStop = false;
            grpTacVu.Text = "Tác vụ";
            // 
            // tbTacVu
            // 
            tbTacVu.ColumnCount = 4;
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbTacVu.Controls.Add(btnThem, 0, 0);
            tbTacVu.Controls.Add(btnSua, 1, 0);
            tbTacVu.Controls.Add(btnXoa, 2, 0);
            tbTacVu.Controls.Add(btnLamMoi, 3, 0);
            tbTacVu.Dock = DockStyle.Fill;
            tbTacVu.Location = new Point(3, 26);
            tbTacVu.Name = "tbTacVu";
            tbTacVu.RowCount = 1;
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTacVu.Size = new Size(582, 114);
            tbTacVu.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(26, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 34);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(171, 40);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 34);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(316, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 34);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 193, 7);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(460, 40);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(96, 34);
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
            grpTTXe.Size = new Size(394, 744);
            grpTTXe.TabIndex = 1;
            grpTTXe.TabStop = false;
            grpTTXe.Text = "Thông tin xe";
            // 
            // txtSoBinhAcQuy
            // 
            txtSoBinhAcQuy.BorderStyle = BorderStyle.FixedSingle;
            txtSoBinhAcQuy.Location = new Point(187, 547);
            txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            txtSoBinhAcQuy.Size = new Size(117, 30);
            txtSoBinhAcQuy.TabIndex = 15;
            // 
            // txtDungLuongAcQuy
            // 
            txtDungLuongAcQuy.BorderStyle = BorderStyle.FixedSingle;
            txtDungLuongAcQuy.Location = new Point(187, 457);
            txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            txtDungLuongAcQuy.Size = new Size(117, 30);
            txtDungLuongAcQuy.TabIndex = 14;
            // 
            // txtMauSac
            // 
            txtMauSac.BorderStyle = BorderStyle.FixedSingle;
            txtMauSac.Location = new Point(110, 370);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(118, 30);
            txtMauSac.TabIndex = 13;
            // 
            // txtGia
            // 
            txtGia.BorderStyle = BorderStyle.FixedSingle;
            txtGia.Location = new Point(110, 283);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(118, 30);
            txtGia.TabIndex = 12;
            // 
            // txtTenXe
            // 
            txtTenXe.BorderStyle = BorderStyle.FixedSingle;
            txtTenXe.Location = new Point(111, 196);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(117, 30);
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
            lblDungLuongAcQuy.Size = new Size(175, 24);
            lblDungLuongAcQuy.TabIndex = 6;
            lblDungLuongAcQuy.Text = "Dung Lượng Ắc Quy:";
            // 
            // lblMauSac
            // 
            lblMauSac.Location = new Point(8, 372);
            lblMauSac.Name = "lblMauSac";
            lblMauSac.Size = new Size(98, 21);
            lblMauSac.TabIndex = 5;
            lblMauSac.Text = "Màu Sắc:";
            // 
            // lblGia
            // 
            lblGia.Location = new Point(8, 285);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(44, 21);
            lblGia.TabIndex = 3;
            lblGia.Text = "Giá:";
            // 
            // lblTenXe
            // 
            lblTenXe.Location = new Point(6, 198);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(81, 21);
            lblTenXe.TabIndex = 2;
            lblTenXe.Text = "Tên Xe:";
            // 
            // usXeMayDien
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 240, 255);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usXeMayDien";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbHienThiXe.ResumeLayout(false);
            tbHienThiBang.ResumeLayout(false);
            grpDSXeMayDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSXeMayDien).EndInit();
            grpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
            grpTTXe.ResumeLayout(false);
            grpTTXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhXe).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private TableLayoutPanel tbHienThiXe;
        private TableLayoutPanel tbHienThiBang;
        private GroupBox grpDSXeMayDien;
        private DataGridView dgvDSXeMayDien;
        private GroupBox grpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox grpTTXe;
        private TextBox txtSoBinhAcQuy;
        private TextBox txtDungLuongAcQuy;
        private TextBox txtMauSac;
        private TextBox txtGia;
        private TextBox txtTenXe;
        private PictureBox picAnhXe;
        private Label lblSoBinhAcQuy;
        private Label lblDungLuongAcQuy;
        private Label lblMauSac;
        private Label lblGia;
        private Label lblTenXe;
    }
}
