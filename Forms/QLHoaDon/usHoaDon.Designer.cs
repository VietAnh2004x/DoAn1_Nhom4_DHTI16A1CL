using System.Windows.Forms;

namespace DoAn1.Forms.QLHoaDon
{
    partial class usHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;

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
            grpTTHoaDon = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            grTTDaiLy = new GroupBox();
            txtTenKhachHang = new TextBox();
            lblMaKhachHang = new Label();
            txtMaHoaDon = new TextBox();
            lblMaHoaDon = new Label();
            txtTenNhanVien = new TextBox();
            lblTenNhanVien = new Label();
            txtTongTien = new TextBox();
            txtNgayLap = new TextBox();
            lblTongTien = new Label();
            lblNgayLap = new Label();
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            tbPhai = new TableLayoutPanel();
            grpTimKiemHoaDon = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTimKiemHoaDon = new Label();
            txtTimKiemHoaDon = new TextBox();
            btnTimKiem = new Button();
            grDSHoaDon = new GroupBox();
            dgvDSHoaDon = new DataGridView();
            panel1.SuspendLayout();
            grpTTHoaDon.SuspendLayout();
            tbTrai.SuspendLayout();
            grTTDaiLy.SuspendLayout();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemHoaDon.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grDSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(grpTTHoaDon);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 750);
            panel1.TabIndex = 0;
            // 
            // grpTTHoaDon
            // 
            grpTTHoaDon.ColumnCount = 2;
            grpTTHoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            grpTTHoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            grpTTHoaDon.Controls.Add(tbTrai, 0, 0);
            grpTTHoaDon.Controls.Add(tbPhai, 1, 0);
            grpTTHoaDon.Dock = DockStyle.Fill;
            grpTTHoaDon.Location = new Point(0, 0);
            grpTTHoaDon.Name = "grpTTHoaDon";
            grpTTHoaDon.RowCount = 1;
            grpTTHoaDon.RowStyles.Add(new RowStyle(SizeType.Absolute, 632F));
            grpTTHoaDon.Size = new Size(1000, 750);
            grpTTHoaDon.TabIndex = 1;
            // 
            // tbTrai
            // 
            tbTrai.ColumnCount = 1;
            tbTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 391F));
            tbTrai.Controls.Add(grTTDaiLy, 0, 0);
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
            // grTTDaiLy
            // 
            grTTDaiLy.Controls.Add(txtTenKhachHang);
            grTTDaiLy.Controls.Add(lblMaKhachHang);
            grTTDaiLy.Controls.Add(txtMaHoaDon);
            grTTDaiLy.Controls.Add(lblMaHoaDon);
            grTTDaiLy.Controls.Add(txtTenNhanVien);
            grTTDaiLy.Controls.Add(lblTenNhanVien);
            grTTDaiLy.Controls.Add(txtTongTien);
            grTTDaiLy.Controls.Add(txtNgayLap);
            grTTDaiLy.Controls.Add(lblTongTien);
            grTTDaiLy.Controls.Add(lblNgayLap);
            grTTDaiLy.Dock = DockStyle.Fill;
            grTTDaiLy.Location = new Point(3, 3);
            grTTDaiLy.Name = "grTTDaiLy";
            grTTDaiLy.Size = new Size(388, 552);
            grTTDaiLy.TabIndex = 0;
            grTTDaiLy.TabStop = false;
            grTTDaiLy.Text = "Thông Tin Hóa Đơn";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTenKhachHang.Location = new Point(188, 142);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(162, 30);
            txtTenKhachHang.TabIndex = 15;
            // 
            // lblMaKhachHang
            // 
            lblMaKhachHang.Location = new Point(10, 144);
            lblMaKhachHang.Name = "lblMaKhachHang";
            lblMaKhachHang.Size = new Size(152, 32);
            lblMaKhachHang.TabIndex = 14;
            lblMaKhachHang.Text = "Tên Khách Hàng";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtMaHoaDon.Location = new Point(188, 69);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(162, 30);
            txtMaHoaDon.TabIndex = 13;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.Location = new Point(10, 71);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(152, 30);
            lblMaHoaDon.TabIndex = 12;
            lblMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtTenNhanVien.Location = new Point(188, 217);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(162, 30);
            txtTenNhanVien.TabIndex = 11;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.Location = new Point(10, 219);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(152, 37);
            lblTenNhanVien.TabIndex = 10;
            lblTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // txtTongTien
            // 
            txtTongTien.BorderStyle = BorderStyle.FixedSingle;
            txtTongTien.Location = new Point(188, 372);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(162, 30);
            txtTongTien.TabIndex = 9;
            // 
            // txtNgayLap
            // 
            txtNgayLap.BorderStyle = BorderStyle.FixedSingle;
            txtNgayLap.Location = new Point(188, 297);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(162, 30);
            txtNgayLap.TabIndex = 8;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(10, 374);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(152, 32);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "Tổng Tiền(VND)";
            // 
            // lblNgayLap
            // 
            lblNgayLap.Location = new Point(10, 299);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(152, 32);
            lblNgayLap.TabIndex = 3;
            lblNgayLap.Text = "Ngày Lập:";
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
            btnLamMoi.Location = new Point(238, 96);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(97, 33);
            btnLamMoi.TabIndex = 19;
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
            btnThem.Location = new Point(47, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(97, 33);
            btnThem.TabIndex = 16;
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
            btnXoa.Location = new Point(47, 96);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(97, 33);
            btnXoa.TabIndex = 18;
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
            btnSua.Location = new Point(238, 21);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(97, 33);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tbPhai.Controls.Add(grpTimKiemHoaDon, 0, 0);
            tbPhai.Controls.Add(grDSHoaDon, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(403, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(594, 744);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemHoaDon
            // 
            grpTimKiemHoaDon.Controls.Add(tableLayoutPanel2);
            grpTimKiemHoaDon.Dock = DockStyle.Fill;
            grpTimKiemHoaDon.Location = new Point(3, 3);
            grpTimKiemHoaDon.Name = "grpTimKiemHoaDon";
            grpTimKiemHoaDon.Size = new Size(588, 142);
            grpTimKiemHoaDon.TabIndex = 0;
            grpTimKiemHoaDon.TabStop = false;
            grpTimKiemHoaDon.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(lblTimKiemHoaDon, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTimKiemHoaDon, 1, 0);
            tableLayoutPanel2.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(582, 113);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimKiemHoaDon
            // 
            lblTimKiemHoaDon.Anchor = AnchorStyles.None;
            lblTimKiemHoaDon.Location = new Point(7, 45);
            lblTimKiemHoaDon.Name = "lblTimKiemHoaDon";
            lblTimKiemHoaDon.Size = new Size(160, 23);
            lblTimKiemHoaDon.TabIndex = 17;
            lblTimKiemHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // txtTimKiemHoaDon
            // 
            txtTimKiemHoaDon.Anchor = AnchorStyles.None;
            txtTimKiemHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemHoaDon.Location = new Point(192, 41);
            txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            txtTimKiemHoaDon.Size = new Size(196, 30);
            txtTimKiemHoaDon.TabIndex = 18;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(442, 39);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 35);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // grDSHoaDon
            // 
            grDSHoaDon.Controls.Add(dgvDSHoaDon);
            grDSHoaDon.Dock = DockStyle.Fill;
            grDSHoaDon.Location = new Point(3, 151);
            grDSHoaDon.Name = "grDSHoaDon";
            grDSHoaDon.Size = new Size(588, 590);
            grDSHoaDon.TabIndex = 1;
            grDSHoaDon.TabStop = false;
            grDSHoaDon.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvDSHoaDon
            // 
            dgvDSHoaDon.AllowUserToAddRows = false;
            dgvDSHoaDon.BackgroundColor = Color.White;
            dgvDSHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSHoaDon.Dock = DockStyle.Fill;
            dgvDSHoaDon.Location = new Point(3, 26);
            dgvDSHoaDon.Name = "dgvDSHoaDon";
            dgvDSHoaDon.RowHeadersWidth = 51;
            dgvDSHoaDon.Size = new Size(582, 561);
            dgvDSHoaDon.TabIndex = 16;
            // 
            // usHoaDon
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usHoaDon";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            grpTTHoaDon.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grTTDaiLy.ResumeLayout(false);
            grTTDaiLy.PerformLayout();
            grpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemHoaDon.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grDSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSHoaDon).EndInit();
            ResumeLayout(false);

        }
        private TableLayoutPanel grpTTHoaDon;
        private TableLayoutPanel tbTrai;
        private GroupBox grTTDaiLy;
        private TextBox txtTenKhachHang;
        private Label lblMaKhachHang;
        private TextBox txtMaHoaDon;
        private Label lblMaHoaDon;
        private TextBox txtTenNhanVien;
        private Label lblTenNhanVien;
        private TextBox txtTongTien;
        private TextBox txtNgayLap;
        private Label lblTongTien;
        private Label lblNgayLap;
        private GroupBox grpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TableLayoutPanel tbPhai;
        private GroupBox grpTimKiemHoaDon;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTimKiemHoaDon;
        private TextBox txtTimKiemHoaDon;
        private Button btnTimKiem;
        private GroupBox grDSHoaDon;
        private DataGridView dgvDSHoaDon;
    }
}
