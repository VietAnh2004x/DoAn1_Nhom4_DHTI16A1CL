using System.Windows.Forms;

namespace DoAn1.Forms.QLDaiLy
{
    partial class usDaiLy
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
            tbHienThi = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            grpTTDaiLy = new GroupBox();
            txtMaDaiLy = new TextBox();
            label1 = new Label();
            txtSoDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtTenDaiLy = new TextBox();
            txtDiaChi = new TextBox();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            lblDiaChi = new Label();
            lblTenDaiLy = new Label();
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            tbPhai = new TableLayoutPanel();
            grpTimKiemDaiLy = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTimKiemDaiLy = new Label();
            txtTimKiemDaiLy = new TextBox();
            btnTimKiem = new Button();
            grpDSDaiLy = new GroupBox();
            dgvDSDaiLy = new DataGridView();
            panel1.SuspendLayout();
            tbHienThi.SuspendLayout();
            tbTrai.SuspendLayout();
            grpTTDaiLy.SuspendLayout();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemDaiLy.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpDSDaiLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSDaiLy).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(tbHienThi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 750);
            panel1.TabIndex = 0;
            // 
            // tbHienThi
            // 
            tbHienThi.ColumnCount = 2;
            tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tbHienThi.Controls.Add(tbTrai, 0, 0);
            tbHienThi.Controls.Add(tbPhai, 1, 0);
            tbHienThi.Dock = DockStyle.Fill;
            tbHienThi.Location = new Point(0, 0);
            tbHienThi.Name = "tbHienThi";
            tbHienThi.RowCount = 1;
            tbHienThi.RowStyles.Add(new RowStyle(SizeType.Absolute, 632F));
            tbHienThi.Size = new Size(1000, 750);
            tbHienThi.TabIndex = 1;
            // 
            // tbTrai
            // 
            tbTrai.ColumnCount = 1;
            tbTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 391F));
            tbTrai.Controls.Add(grpTTDaiLy, 0, 0);
            tbTrai.Controls.Add(grpTacVu, 0, 1);
            tbTrai.Dock = DockStyle.Fill;
            tbTrai.Location = new Point(3, 3);
            tbTrai.Name = "tbTrai";
            tbTrai.RowCount = 2;
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbTrai.Size = new Size(394, 744);
            tbTrai.TabIndex = 0;
            // 
            // grpTTDaiLy
            // 
            grpTTDaiLy.Controls.Add(txtMaDaiLy);
            grpTTDaiLy.Controls.Add(label1);
            grpTTDaiLy.Controls.Add(txtSoDienThoai);
            grpTTDaiLy.Controls.Add(txtEmail);
            grpTTDaiLy.Controls.Add(txtTenDaiLy);
            grpTTDaiLy.Controls.Add(txtDiaChi);
            grpTTDaiLy.Controls.Add(lblSoDienThoai);
            grpTTDaiLy.Controls.Add(lblEmail);
            grpTTDaiLy.Controls.Add(lblDiaChi);
            grpTTDaiLy.Controls.Add(lblTenDaiLy);
            grpTTDaiLy.Dock = DockStyle.Fill;
            grpTTDaiLy.Location = new Point(3, 3);
            grpTTDaiLy.Name = "grpTTDaiLy";
            grpTTDaiLy.Size = new Size(388, 552);
            grpTTDaiLy.TabIndex = 0;
            grpTTDaiLy.TabStop = false;
            grpTTDaiLy.Text = "Thông Tin Đại Lý";
            // 
            // txtMaDaiLy
            // 
            txtMaDaiLy.BorderStyle = BorderStyle.FixedSingle;
            txtMaDaiLy.Location = new Point(159, 61);
            txtMaDaiLy.Name = "txtMaDaiLy";
            txtMaDaiLy.Size = new Size(211, 30);
            txtMaDaiLy.TabIndex = 11;
            // 
            // label1
            // 
            label1.Location = new Point(14, 63);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 10;
            label1.Text = "Mã Đại Lý";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Location = new Point(158, 412);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(211, 30);
            txtSoDienThoai.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(158, 323);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 30);
            txtEmail.TabIndex = 8;
            // 
            // txtTenDaiLy
            // 
            txtTenDaiLy.BorderStyle = BorderStyle.FixedSingle;
            txtTenDaiLy.Location = new Point(159, 145);
            txtTenDaiLy.Name = "txtTenDaiLy";
            txtTenDaiLy.Size = new Size(211, 30);
            txtTenDaiLy.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(158, 234);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(211, 30);
            txtDiaChi.TabIndex = 6;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Location = new Point(14, 414);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(139, 37);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(14, 325);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(139, 37);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(14, 236);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(139, 37);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.Location = new Point(14, 147);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(139, 37);
            lblTenDaiLy.TabIndex = 1;
            lblTenDaiLy.Text = "Tên Đại Lý:";
            // 
            // grpTacVu
            // 
            grpTacVu.Controls.Add(tbTacVu);
            grpTacVu.Dock = DockStyle.Fill;
            grpTacVu.Location = new Point(3, 561);
            grpTacVu.Name = "grpTacVu";
            grpTacVu.Size = new Size(388, 180);
            grpTacVu.TabIndex = 1;
            grpTacVu.TabStop = false;
            grpTacVu.Text = "Tác Vụ";
            // 
            // tbTacVu
            // 
            tbTacVu.ColumnCount = 2;
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbTacVu.Controls.Add(btnLamMoi, 1, 1);
            tbTacVu.Controls.Add(btnThem, 0, 0);
            tbTacVu.Controls.Add(btnXoa, 0, 1);
            tbTacVu.Controls.Add(btnSua, 1, 0);
            tbTacVu.Dock = DockStyle.Fill;
            tbTacVu.Location = new Point(3, 26);
            tbTacVu.Name = "tbTacVu";
            tbTacVu.RowCount = 2;
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTacVu.Size = new Size(382, 151);
            tbTacVu.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 193, 7);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(232, 93);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(108, 39);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(41, 18);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(108, 39);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(41, 93);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(108, 39);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(232, 18);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(108, 39);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tbPhai.Controls.Add(grpTimKiemDaiLy, 0, 0);
            tbPhai.Controls.Add(grpDSDaiLy, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(403, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(594, 744);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemDaiLy
            // 
            grpTimKiemDaiLy.Controls.Add(tableLayoutPanel2);
            grpTimKiemDaiLy.Dock = DockStyle.Fill;
            grpTimKiemDaiLy.Location = new Point(3, 3);
            grpTimKiemDaiLy.Name = "grpTimKiemDaiLy";
            grpTimKiemDaiLy.Size = new Size(588, 142);
            grpTimKiemDaiLy.TabIndex = 0;
            grpTimKiemDaiLy.TabStop = false;
            grpTimKiemDaiLy.Text = "Tìm Kiếm Đại Lý";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(lblTimKiemDaiLy, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTimKiemDaiLy, 1, 0);
            tableLayoutPanel2.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(582, 113);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimKiemDaiLy
            // 
            lblTimKiemDaiLy.Anchor = AnchorStyles.None;
            lblTimKiemDaiLy.Location = new Point(7, 45);
            lblTimKiemDaiLy.Name = "lblTimKiemDaiLy";
            lblTimKiemDaiLy.Size = new Size(160, 23);
            lblTimKiemDaiLy.TabIndex = 11;
            lblTimKiemDaiLy.Text = "Tên Đại Lý:";
            // 
            // txtTimKiemDaiLy
            // 
            txtTimKiemDaiLy.Anchor = AnchorStyles.None;
            txtTimKiemDaiLy.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemDaiLy.Location = new Point(192, 41);
            txtTimKiemDaiLy.Name = "txtTimKiemDaiLy";
            txtTimKiemDaiLy.Size = new Size(196, 30);
            txtTimKiemDaiLy.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(440, 36);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(107, 41);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // grpDSDaiLy
            // 
            grpDSDaiLy.Controls.Add(dgvDSDaiLy);
            grpDSDaiLy.Dock = DockStyle.Fill;
            grpDSDaiLy.Location = new Point(3, 151);
            grpDSDaiLy.Name = "grpDSDaiLy";
            grpDSDaiLy.Size = new Size(588, 590);
            grpDSDaiLy.TabIndex = 1;
            grpDSDaiLy.TabStop = false;
            grpDSDaiLy.Text = "Danh Sách Đại Lý";
            // 
            // dgvDSDaiLy
            // 
            dgvDSDaiLy.AllowUserToAddRows = false;
            dgvDSDaiLy.BackgroundColor = Color.White;
            dgvDSDaiLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSDaiLy.Dock = DockStyle.Fill;
            dgvDSDaiLy.Location = new Point(3, 26);
            dgvDSDaiLy.Name = "dgvDSDaiLy";
            dgvDSDaiLy.RowHeadersWidth = 51;
            dgvDSDaiLy.Size = new Size(582, 561);
            dgvDSDaiLy.TabIndex = 0;
            dgvDSDaiLy.CellClick += dgvDSDaiLy_CellClick;
            // 
            // usDaiLy
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usDaiLy";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbHienThi.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grpTTDaiLy.ResumeLayout(false);
            grpTTDaiLy.PerformLayout();
            grpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemDaiLy.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grpDSDaiLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSDaiLy).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private TableLayoutPanel tbHienThi;
        private TableLayoutPanel tbTrai;
        private GroupBox grpTTDaiLy;
        private TextBox txtMaDaiLy;
        private Label label1;
        private TextBox txtSoDienThoai;
        private TextBox txtEmail;
        private TextBox txtTenDaiLy;
        private TextBox txtDiaChi;
        private Label lblSoDienThoai;
        private Label lblEmail;
        private Label lblDiaChi;
        private Label lblTenDaiLy;
        private GroupBox grpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TableLayoutPanel tbPhai;
        private GroupBox grpTimKiemDaiLy;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTimKiemDaiLy;
        private TextBox txtTimKiemDaiLy;
        private Button btnTimKiem;
        private GroupBox grpDSDaiLy;
        private DataGridView dgvDSDaiLy;
    }
}
