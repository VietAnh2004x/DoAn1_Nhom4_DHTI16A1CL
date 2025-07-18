namespace DoAn1.Forms.QLXe
{
    partial class usXeCu
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
            grpDSXeCu = new GroupBox();
            dgvDSXeCu = new DataGridView();
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpTTXeCu = new GroupBox();
            panel1.SuspendLayout();
            tbHienThiXe.SuspendLayout();
            tbHienThiBang.SuspendLayout();
            grpDSXeCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSXeCu).BeginInit();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
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
            tbHienThiXe.Controls.Add(grpTTXeCu, 0, 0);
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
            tbHienThiBang.Controls.Add(grpDSXeCu, 0, 0);
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
            // grpDSXeCu
            // 
            grpDSXeCu.Controls.Add(dgvDSXeCu);
            grpDSXeCu.Dock = DockStyle.Fill;
            grpDSXeCu.Location = new Point(3, 3);
            grpDSXeCu.Name = "grpDSXeCu";
            grpDSXeCu.Size = new Size(588, 589);
            grpDSXeCu.TabIndex = 0;
            grpDSXeCu.TabStop = false;
            grpDSXeCu.Text = "Danh sách xe cũ";
            // 
            // dgvDSXeCu
            // 
            dgvDSXeCu.AllowUserToAddRows = false;
            dgvDSXeCu.BackgroundColor = Color.White;
            dgvDSXeCu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSXeCu.Dock = DockStyle.Fill;
            dgvDSXeCu.Location = new Point(3, 21);
            dgvDSXeCu.Name = "dgvDSXeCu";
            dgvDSXeCu.RowHeadersWidth = 51;
            dgvDSXeCu.Size = new Size(582, 565);
            dgvDSXeCu.TabIndex = 0;
            dgvDSXeCu.CellClick += dgvDSXeMayDien_CellClick;
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
            tbTacVu.Location = new Point(3, 21);
            tbTacVu.Name = "tbTacVu";
            tbTacVu.RowCount = 1;
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTacVu.Size = new Size(582, 119);
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
            btnThem.Location = new Point(22, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(167, 39);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(312, 39);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 193, 7);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(457, 39);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(103, 40);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grpTTXeCu
            // 
            grpTTXeCu.Dock = DockStyle.Fill;
            grpTTXeCu.Location = new Point(3, 3);
            grpTTXeCu.Name = "grpTTXeCu";
            grpTTXeCu.Size = new Size(394, 744);
            grpTTXeCu.TabIndex = 1;
            grpTTXeCu.TabStop = false;
            grpTTXeCu.Text = "Thông tin xe cũ";
            // 
            // usXeCu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(240, 240, 240);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usXeCu";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbHienThiXe.ResumeLayout(false);
            tbHienThiBang.ResumeLayout(false);
            grpDSXeCu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSXeCu).EndInit();
            grpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private TableLayoutPanel tbHienThiXe;
        private TableLayoutPanel tbHienThiBang;
        private GroupBox grpDSXeCu;
        private DataGridView dgvDSXeCu;
        private GroupBox grpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox grpTTXeCu;
    }
}
