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
            label6 = new Label();
            txtGhiChu = new TextBox();
            label5 = new Label();
            txtNoiDung = new TextBox();
            label4 = new Label();
            txtTenNV = new TextBox();
            label3 = new Label();
            txtMaBH = new TextBox();
            label2 = new Label();
            dtpNgayBaoHanh = new DateTimePicker();
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
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            grpDSLSBaoHanh = new GroupBox();
            dgvDSLSBaoHanh = new DataGridView();
            panel1.SuspendLayout();
            tbHienThi.SuspendLayout();
            tbTrai.SuspendLayout();
            grpLSBaoHanh.SuspendLayout();
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
            panel1.BackColor = Color.FromArgb(224, 242, 241);
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
            grpLSBaoHanh.Controls.Add(label6);
            grpLSBaoHanh.Controls.Add(txtGhiChu);
            grpLSBaoHanh.Controls.Add(label5);
            grpLSBaoHanh.Controls.Add(txtNoiDung);
            grpLSBaoHanh.Controls.Add(label4);
            grpLSBaoHanh.Controls.Add(txtTenNV);
            grpLSBaoHanh.Controls.Add(label3);
            grpLSBaoHanh.Controls.Add(txtMaBH);
            grpLSBaoHanh.Controls.Add(label2);
            grpLSBaoHanh.Controls.Add(dtpNgayBaoHanh);
            grpLSBaoHanh.Dock = DockStyle.Fill;
            grpLSBaoHanh.Location = new Point(3, 3);
            grpLSBaoHanh.Name = "grpLSBaoHanh";
            grpLSBaoHanh.Size = new Size(388, 552);
            grpLSBaoHanh.TabIndex = 0;
            grpLSBaoHanh.TabStop = false;
            grpLSBaoHanh.Text = "Thông Tin Lịch Sử Bảo Hành";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 350);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 11;
            label6.Text = "Ngày Bảo Hành";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(127, 470);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(235, 34);
            txtGhiChu.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 476);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 9;
            label5.Text = "Ghi Chú";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(15, 286);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(329, 34);
            txtNoiDung.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 226);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 7;
            label4.Text = "Nội dung bảo hành";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(176, 142);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(186, 34);
            txtTenNV.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 148);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 5;
            label3.Text = "Tên Nhân Viên";
            // 
            // txtMaBH
            // 
            txtMaBH.Location = new Point(176, 70);
            txtMaBH.Name = "txtMaBH";
            txtMaBH.Size = new Size(186, 34);
            txtMaBH.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 73);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 3;
            label2.Text = "Mã Bảo Hành";
            // 
            // dtpNgayBaoHanh
            // 
            dtpNgayBaoHanh.Location = new Point(15, 403);
            dtpNgayBaoHanh.Name = "dtpNgayBaoHanh";
            dtpNgayBaoHanh.Size = new Size(329, 34);
            dtpNgayBaoHanh.TabIndex = 1;
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
            tbTacVu.Location = new Point(3, 30);
            tbTacVu.Name = "tbTacVu";
            tbTacVu.RowCount = 2;
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTacVu.Size = new Size(382, 147);
            tbTacVu.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 193, 7);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(231, 91);
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
            btnThem.Location = new Point(40, 18);
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
            btnXoa.Location = new Point(40, 91);
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
            btnSua.Location = new Point(231, 18);
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
            tableLayoutPanel2.Controls.Add(txtTimKiem, 1, 0);
            tableLayoutPanel2.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(582, 109);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimKiemLSBaoHanh
            // 
            lblTimKiemLSBaoHanh.Anchor = AnchorStyles.None;
            lblTimKiemLSBaoHanh.Location = new Point(3, 39);
            lblTimKiemLSBaoHanh.Name = "lblTimKiemLSBaoHanh";
            lblTimKiemLSBaoHanh.Size = new Size(168, 31);
            lblTimKiemLSBaoHanh.TabIndex = 13;
            lblTimKiemLSBaoHanh.Text = "Mã Lịch Sử Bảo Hành:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(192, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(196, 34);
            txtTimKiem.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(439, 36);
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
            dgvDSLSBaoHanh.Location = new Point(3, 30);
            dgvDSLSBaoHanh.Name = "dgvDSLSBaoHanh";
            dgvDSLSBaoHanh.RowHeadersWidth = 51;
            dgvDSLSBaoHanh.Size = new Size(582, 557);
            dgvDSLSBaoHanh.TabIndex = 0;
            dgvDSLSBaoHanh.CellClick += dgvDSLSBaoHanh_CellClick;
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
            grpLSBaoHanh.ResumeLayout(false);
            grpLSBaoHanh.PerformLayout();
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
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private GroupBox grpDSLSBaoHanh;
        private DataGridView dgvDSLSBaoHanh;
        private TextBox txtTenNV;
        private Label label3;
        private TextBox txtMaBH;
        private Label label2;
        private DateTimePicker dtpNgayBaoHanh;
        private Label label6;
        private TextBox txtGhiChu;
        private Label label5;
        private TextBox txtNoiDung;
        private Label label4;
    }
}
