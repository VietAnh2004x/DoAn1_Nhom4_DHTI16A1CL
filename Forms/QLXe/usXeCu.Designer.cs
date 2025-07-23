namespace DoAn.Forms.QLXe
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
            txtMaGD = new TextBox();
            label1 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtXeMuonDoi = new TextBox();
            label9 = new Label();
            txtSoTienPhaiTra = new TextBox();
            label8 = new Label();
            txtDinhGia = new TextBox();
            label7 = new Label();
            txtSoKm = new TextBox();
            label6 = new Label();
            txtTinhTrang = new TextBox();
            label5 = new Label();
            txtNSX = new TextBox();
            label4 = new Label();
            txtTenXeCu = new TextBox();
            label3 = new Label();
            txtTenKH = new TextBox();
            label2 = new Label();
            dtpNgayDoi = new DateTimePicker();
            panel1.SuspendLayout();
            tbHienThiXe.SuspendLayout();
            tbHienThiBang.SuspendLayout();
            grpDSXeCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSXeCu).BeginInit();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
            grpTTXeCu.SuspendLayout();
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
            dgvDSXeCu.Location = new Point(3, 26);
            dgvDSXeCu.Name = "dgvDSXeCu";
            dgvDSXeCu.RowHeadersWidth = 51;
            dgvDSXeCu.Size = new Size(582, 560);
            dgvDSXeCu.TabIndex = 0;
            dgvDSXeCu.CellClick += dgvDSXeCu_CellClick;
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
            btnThem.Location = new Point(22, 37);
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
            btnSua.Location = new Point(167, 37);
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
            btnXoa.Location = new Point(312, 37);
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
            btnLamMoi.Location = new Point(457, 37);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(103, 40);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grpTTXeCu
            // 
            grpTTXeCu.Controls.Add(txtMaGD);
            grpTTXeCu.Controls.Add(label1);
            grpTTXeCu.Controls.Add(btnTimKiem);
            grpTTXeCu.Controls.Add(txtTimKiem);
            grpTTXeCu.Controls.Add(label11);
            grpTTXeCu.Controls.Add(label10);
            grpTTXeCu.Controls.Add(txtXeMuonDoi);
            grpTTXeCu.Controls.Add(label9);
            grpTTXeCu.Controls.Add(txtSoTienPhaiTra);
            grpTTXeCu.Controls.Add(label8);
            grpTTXeCu.Controls.Add(txtDinhGia);
            grpTTXeCu.Controls.Add(label7);
            grpTTXeCu.Controls.Add(txtSoKm);
            grpTTXeCu.Controls.Add(label6);
            grpTTXeCu.Controls.Add(txtTinhTrang);
            grpTTXeCu.Controls.Add(label5);
            grpTTXeCu.Controls.Add(txtNSX);
            grpTTXeCu.Controls.Add(label4);
            grpTTXeCu.Controls.Add(txtTenXeCu);
            grpTTXeCu.Controls.Add(label3);
            grpTTXeCu.Controls.Add(txtTenKH);
            grpTTXeCu.Controls.Add(label2);
            grpTTXeCu.Controls.Add(dtpNgayDoi);
            grpTTXeCu.Dock = DockStyle.Fill;
            grpTTXeCu.Location = new Point(3, 3);
            grpTTXeCu.Name = "grpTTXeCu";
            grpTTXeCu.Size = new Size(394, 744);
            grpTTXeCu.TabIndex = 1;
            grpTTXeCu.TabStop = false;
            grpTTXeCu.Text = "Thông tin xe cũ";
            // 
            // txtMaGD
            // 
            txtMaGD.Location = new Point(163, 30);
            txtMaGD.Name = "txtMaGD";
            txtMaGD.Size = new Size(213, 30);
            txtMaGD.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 23;
            label1.Text = "Mã Giao Dịch";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(268, 667);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(108, 34);
            btnTimKiem.TabIndex = 22;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(107, 673);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(139, 30);
            txtTimKiem.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 673);
            label11.Name = "label11";
            label11.Size = new Size(81, 23);
            label11.TabIndex = 20;
            label11.Text = "Tìm Kiếm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 222);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 19;
            label10.Text = "Năm Sản Xuất";
            // 
            // txtXeMuonDoi
            // 
            txtXeMuonDoi.Location = new Point(163, 471);
            txtXeMuonDoi.Name = "txtXeMuonDoi";
            txtXeMuonDoi.Size = new Size(213, 30);
            txtXeMuonDoi.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 474);
            label9.Name = "label9";
            label9.Size = new Size(110, 23);
            label9.TabIndex = 17;
            label9.Text = "Xe Muốn Đổi";
            // 
            // txtSoTienPhaiTra
            // 
            txtSoTienPhaiTra.Location = new Point(163, 534);
            txtSoTienPhaiTra.Name = "txtSoTienPhaiTra";
            txtSoTienPhaiTra.Size = new Size(213, 30);
            txtSoTienPhaiTra.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 537);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 15;
            label8.Text = "Số tiền phải trả";
            // 
            // txtDinhGia
            // 
            txtDinhGia.Location = new Point(163, 408);
            txtDinhGia.Name = "txtDinhGia";
            txtDinhGia.Size = new Size(213, 30);
            txtDinhGia.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 411);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 13;
            label7.Text = "Định giá";
            // 
            // txtSoKm
            // 
            txtSoKm.Location = new Point(163, 348);
            txtSoKm.Name = "txtSoKm";
            txtSoKm.Size = new Size(213, 30);
            txtSoKm.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 348);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 11;
            label6.Text = "Số Km";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Location = new Point(163, 282);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(213, 30);
            txtTinhTrang.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 285);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 9;
            label5.Text = "Tình Trạng";
            // 
            // txtNSX
            // 
            txtNSX.Location = new Point(163, 219);
            txtNSX.Name = "txtNSX";
            txtNSX.Size = new Size(213, 30);
            txtNSX.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 600);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 7;
            label4.Text = "Ngày Đổi";
            // 
            // txtTenXeCu
            // 
            txtTenXeCu.Location = new Point(163, 156);
            txtTenXeCu.Name = "txtTenXeCu";
            txtTenXeCu.Size = new Size(213, 30);
            txtTenXeCu.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 159);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 5;
            label3.Text = "Tên Xe";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(163, 93);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(213, 30);
            txtTenKH.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 96);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 3;
            label2.Text = "Tên Khách Hàng";
            // 
            // dtpNgayDoi
            // 
            dtpNgayDoi.Format = DateTimePickerFormat.Custom;
            dtpNgayDoi.Location = new Point(163, 594);
            dtpNgayDoi.Name = "dtpNgayDoi";
            dtpNgayDoi.Size = new Size(213, 30);
            dtpNgayDoi.TabIndex = 2;
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
            grpTTXeCu.ResumeLayout(false);
            grpTTXeCu.PerformLayout();
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
        private Label label10;
        private TextBox txtXeMuonDoi;
        private Label label9;
        private TextBox txtSoTienPhaiTra;
        private Label label8;
        private TextBox txtDinhGia;
        private Label label7;
        private TextBox txtSoKm;
        private Label label6;
        private TextBox txtTinhTrang;
        private Label label5;
        private TextBox txtNSX;
        private Label label4;
        private TextBox txtTenXeCu;
        private Label label3;
        private TextBox txtTenKH;
        private Label label2;
        private DateTimePicker dtpNgayDoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label11;
        private TextBox txtMaGD;
        private Label label1;
    }
}
