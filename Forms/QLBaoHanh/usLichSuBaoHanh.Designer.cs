using System.Windows.Forms;

namespace DoAn1.Forms.QLBaoHanh
{
    partial class usLichSuBaoHanh
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
            grpLSBaoHanh = new GroupBox();
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            tbPhai = new TableLayoutPanel();
            grpTimKiemLSBaoHanh = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTimKiemLSBaoHanh = new Label();
            txtTimKiemLSBaoHanh = new TextBox();
            btnTimKiem = new Button();
            grpDSLSBaoHanh = new GroupBox();
            dgvDSLSBaoHanh = new DataGridView();
            panel1.SuspendLayout();
            tbHienThi.SuspendLayout();
            tbTrai.SuspendLayout();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemLSBaoHanh.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpDSLSBaoHanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSLSBaoHanh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = ColorTranslator.FromHtml("#E0F2F1");
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
            tbTrai.Controls.Add(grpLSBaoHanh, 0, 0);
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
            // grpLSBaoHanh
            // 
            grpLSBaoHanh.Dock = DockStyle.Fill;
            grpLSBaoHanh.Location = new Point(3, 3);
            grpLSBaoHanh.Name = "grpLSBaoHanh";
            grpLSBaoHanh.Size = new Size(388, 552);
            grpLSBaoHanh.TabIndex = 0;
            grpLSBaoHanh.TabStop = false;
            grpLSBaoHanh.Text = "Thông Tin Lịch Sử Bảo Hành";
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
            tbTacVu.Location = new Point(3, 21);
            tbTacVu.Name = "tbTacVu";
            tbTacVu.RowCount = 2;
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTacVu.Size = new Size(382, 156);
            tbTacVu.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 193, 7);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(231, 98);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 37);
            btnLamMoi.TabIndex = 15;
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
            btnThem.Location = new Point(40, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 37);
            btnThem.TabIndex = 12;
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
            btnXoa.Location = new Point(40, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 37);
            btnXoa.TabIndex = 14;
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
            btnSua.Location = new Point(231, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 37);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tbPhai.Controls.Add(grpTimKiemLSBaoHanh, 0, 0);
            tbPhai.Controls.Add(grpDSLSBaoHanh, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(403, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(594, 744);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemLSBaoHanh
            // 
            grpTimKiemLSBaoHanh.Controls.Add(tableLayoutPanel2);
            grpTimKiemLSBaoHanh.Dock = DockStyle.Fill;
            grpTimKiemLSBaoHanh.Location = new Point(3, 3);
            grpTimKiemLSBaoHanh.Name = "grpTimKiemLSBaoHanh";
            grpTimKiemLSBaoHanh.Size = new Size(588, 142);
            grpTimKiemLSBaoHanh.TabIndex = 0;
            grpTimKiemLSBaoHanh.TabStop = false;
            grpTimKiemLSBaoHanh.Text = "Tìm Kiếm Lịch Sử Bảo Hành";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(lblTimKiemLSBaoHanh, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTimKiemLSBaoHanh, 1, 0);
            tableLayoutPanel2.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 21);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(582, 118);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimKiemLSBaoHanh
            // 
            lblTimKiemLSBaoHanh.Anchor = AnchorStyles.None;
            lblTimKiemLSBaoHanh.Location = new Point(3, 47);
            lblTimKiemLSBaoHanh.Name = "lblTimKiemLSBaoHanh";
            lblTimKiemLSBaoHanh.Size = new Size(167, 23);
            lblTimKiemLSBaoHanh.TabIndex = 13;
            lblTimKiemLSBaoHanh.Text = "Mã Lịch Sử Bảo Hành:";
            // 
            // txtTimKiemLSBaoHanh
            // 
            txtTimKiemLSBaoHanh.Anchor = AnchorStyles.None;
            txtTimKiemLSBaoHanh.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemLSBaoHanh.Location = new Point(192, 46);
            txtTimKiemLSBaoHanh.Name = "txtTimKiemLSBaoHanh";
            txtTimKiemLSBaoHanh.Size = new Size(196, 25);
            txtTimKiemLSBaoHanh.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(439, 41);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(109, 36);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // grpDSLSBaoHanh
            // 
            grpDSLSBaoHanh.Controls.Add(dgvDSLSBaoHanh);
            grpDSLSBaoHanh.Dock = DockStyle.Fill;
            grpDSLSBaoHanh.Location = new Point(3, 151);
            grpDSLSBaoHanh.Name = "grpDSLSBaoHanh";
            grpDSLSBaoHanh.Size = new Size(588, 590);
            grpDSLSBaoHanh.TabIndex = 1;
            grpDSLSBaoHanh.TabStop = false;
            grpDSLSBaoHanh.Text = "Danh Sách Lịch Sử Bảo Hành";
            // 
            // dgvDSLSBaoHanh
            // 
            dgvDSLSBaoHanh.AllowUserToAddRows = false;
            dgvDSLSBaoHanh.BackgroundColor = Color.White;
            dgvDSLSBaoHanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLSBaoHanh.Dock = DockStyle.Fill;
            dgvDSLSBaoHanh.Location = new Point(3, 21);
            dgvDSLSBaoHanh.Name = "dgvDSLSBaoHanh";
            dgvDSLSBaoHanh.RowHeadersWidth = 51;
            dgvDSLSBaoHanh.Size = new Size(582, 566);
            dgvDSLSBaoHanh.TabIndex = 0;
            dgvDSLSBaoHanh.CellClick += dgvDSBaoHanh_CellClick;
            // 
            // usLichSuBaoHanh
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usLichSuBaoHanh";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbHienThi.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemLSBaoHanh.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grpDSLSBaoHanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSLSBaoHanh).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private TableLayoutPanel tbHienThi;
        private TableLayoutPanel tbTrai;
        private GroupBox grpLSBaoHanh;
        private GroupBox grpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TableLayoutPanel tbPhai;
        private GroupBox grpTimKiemLSBaoHanh;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTimKiemLSBaoHanh;
        private TextBox txtTimKiemLSBaoHanh;
        private Button btnTimKiem;
        private GroupBox grpDSLSBaoHanh;
        private DataGridView dgvDSLSBaoHanh;
    }
}
