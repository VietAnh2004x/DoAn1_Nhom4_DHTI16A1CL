using System.Windows.Forms;

namespace DoAn.Forms.QLXe
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
            panel1 = new Panel();
            tbHienThiXe = new TableLayoutPanel();
            tbHienThiBang = new TableLayoutPanel();
            grpDSXeDapDien = new GroupBox();
            dgvDSXeDapDien = new DataGridView();
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpTTXe = new GroupBox();
            txtSoLuong = new TextBox();
            lba = new Label();
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
            grpDSXeDapDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSXeDapDien).BeginInit();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
            grpTTXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhXe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 248, 233);
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
            tbHienThiBang.Controls.Add(grpDSXeDapDien, 0, 0);
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
            // grpDSXeDapDien
            // 
            grpDSXeDapDien.Controls.Add(dgvDSXeDapDien);
            grpDSXeDapDien.Dock = DockStyle.Fill;
            grpDSXeDapDien.Location = new Point(3, 3);
            grpDSXeDapDien.Name = "grpDSXeDapDien";
            grpDSXeDapDien.Size = new Size(588, 589);
            grpDSXeDapDien.TabIndex = 0;
            grpDSXeDapDien.TabStop = false;
            grpDSXeDapDien.Text = "Danh sách xe đạp điện";
            // 
            // dgvDSXeDapDien
            // 
            dgvDSXeDapDien.AllowUserToAddRows = false;
            dgvDSXeDapDien.BackgroundColor = Color.White;
            dgvDSXeDapDien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSXeDapDien.Dock = DockStyle.Fill;
            dgvDSXeDapDien.Location = new Point(3, 30);
            dgvDSXeDapDien.Name = "dgvDSXeDapDien";
            dgvDSXeDapDien.RowHeadersWidth = 51;
            dgvDSXeDapDien.Size = new Size(582, 556);
            dgvDSXeDapDien.TabIndex = 0;
            dgvDSXeDapDien.CellClick += dgvDSXeDapDien_CellClick;
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
            tbTacVu.Location = new Point(3, 30);
            tbTacVu.Name = "tbTacVu";
            tbTacVu.RowCount = 1;
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTacVu.Size = new Size(582, 110);
            tbTacVu.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.FromArgb(67, 160, 71);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(21, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 39);
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
            btnSua.Location = new Point(166, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 39);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.FromArgb(239, 83, 80);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(311, 35);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 39);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 213, 79);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(457, 35);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(103, 39);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grpTTXe
            // 
            grpTTXe.Controls.Add(txtSoLuong);
            grpTTXe.Controls.Add(lba);
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
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(187, 628);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(167, 34);
            txtSoLuong.TabIndex = 17;
            // 
            // lba
            // 
            lba.Location = new Point(6, 630);
            lba.Name = "lba";
            lba.Size = new Size(152, 28);
            lba.TabIndex = 16;
            lba.Text = "Số Lượng";
            // 
            // txtSoBinhAcQuy
            // 
            txtSoBinhAcQuy.BorderStyle = BorderStyle.FixedSingle;
            txtSoBinhAcQuy.Location = new Point(187, 547);
            txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            txtSoBinhAcQuy.Size = new Size(167, 34);
            txtSoBinhAcQuy.TabIndex = 15;
            // 
            // txtDungLuongAcQuy
            // 
            txtDungLuongAcQuy.BorderStyle = BorderStyle.FixedSingle;
            txtDungLuongAcQuy.Location = new Point(187, 457);
            txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            txtDungLuongAcQuy.Size = new Size(167, 34);
            txtDungLuongAcQuy.TabIndex = 14;
            // 
            // txtMauSac
            // 
            txtMauSac.BorderStyle = BorderStyle.FixedSingle;
            txtMauSac.Location = new Point(111, 370);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(193, 34);
            txtMauSac.TabIndex = 13;
            // 
            // txtGia
            // 
            txtGia.BorderStyle = BorderStyle.FixedSingle;
            txtGia.Location = new Point(111, 283);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(193, 34);
            txtGia.TabIndex = 12;
            // 
            // txtTenXe
            // 
            txtTenXe.BorderStyle = BorderStyle.FixedSingle;
            txtTenXe.Location = new Point(111, 196);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(193, 34);
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
            tbHienThiXe.ResumeLayout(false);
            tbHienThiBang.ResumeLayout(false);
            grpDSXeDapDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSXeDapDien).EndInit();
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
        private GroupBox grpDSXeDapDien;
        private DataGridView dgvDSXeDapDien;
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
        private TextBox txtSoLuong;
        private Label lba;
    }
}
