using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLHoaDon
{
    partial class usHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel grpTTHoaDon;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.GroupBox grpTimKiemHoaDon;
        private System.Windows.Forms.GroupBox grDSHoaDon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiemHoaDon;
        private System.Windows.Forms.Label lblTimKiemHoaDon;
        private System.Windows.Forms.Button btnTimKiem;

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
            tbTong = new TableLayoutPanel();
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
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            tbPhai = new TableLayoutPanel();
            grpTimKiemHoaDon = new GroupBox();
            txtTimKiemHoaDon = new TextBox();
            lblTimKiemHoaDon = new Label();
            btnTimKiem = new Button();
            grDSHoaDon = new GroupBox();
            lblTieuDe = new Label();
            dataGridView1 = new DataGridView();
            colMaHoaDon = new DataGridViewTextBoxColumn();
            colTenKhachHang = new DataGridViewTextBoxColumn();
            colTenNhanVien = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tbTong.SuspendLayout();
            grpTTHoaDon.SuspendLayout();
            tbTrai.SuspendLayout();
            grTTDaiLy.SuspendLayout();
            grpTacVu.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemHoaDon.SuspendLayout();
            grDSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
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
            tbTong.Controls.Add(grpTTHoaDon, 0, 1);
            tbTong.Controls.Add(lblTieuDe, 0, 0);
            tbTong.Dock = DockStyle.Fill;
            tbTong.Location = new Point(0, 0);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 2;
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tbTong.Size = new Size(1000, 750);
            tbTong.TabIndex = 0;
            // 
            // grpTTHoaDon
            // 
            grpTTHoaDon.ColumnCount = 2;
            grpTTHoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            grpTTHoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            grpTTHoaDon.Controls.Add(tbTrai, 0, 0);
            grpTTHoaDon.Controls.Add(tbPhai, 1, 0);
            grpTTHoaDon.Dock = DockStyle.Fill;
            grpTTHoaDon.Location = new Point(3, 115);
            grpTTHoaDon.Name = "grpTTHoaDon";
            grpTTHoaDon.RowCount = 1;
            grpTTHoaDon.RowStyles.Add(new RowStyle(SizeType.Absolute, 632F));
            grpTTHoaDon.Size = new Size(994, 632);
            grpTTHoaDon.TabIndex = 0;
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
            tbTrai.Size = new Size(391, 626);
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
            grTTDaiLy.Size = new Size(385, 463);
            grTTDaiLy.TabIndex = 0;
            grTTDaiLy.TabStop = false;
            grTTDaiLy.Text = "Thông Tin Hóa Đơn";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTenKhachHang.Location = new Point(188, 142);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(162, 25);
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
            txtMaHoaDon.Size = new Size(162, 25);
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
            txtTenNhanVien.Size = new Size(162, 25);
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
            txtTongTien.Size = new Size(162, 25);
            txtTongTien.TabIndex = 9;
            // 
            // txtNgayLap
            // 
            txtNgayLap.BorderStyle = BorderStyle.FixedSingle;
            txtNgayLap.Location = new Point(188, 297);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(162, 25);
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
            grpTacVu.Controls.Add(btnLamMoi);
            grpTacVu.Controls.Add(btnXoa);
            grpTacVu.Controls.Add(btnSua);
            grpTacVu.Controls.Add(btnThem);
            grpTacVu.Dock = DockStyle.Fill;
            grpTacVu.Location = new Point(3, 472);
            grpTacVu.Name = "grpTacVu";
            grpTacVu.Size = new Size(385, 151);
            grpTacVu.TabIndex = 1;
            grpTacVu.TabStop = false;
            grpTacVu.Text = "Tác Vụ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(255, 193, 7);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(224, 97);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(59, 97);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(224, 36);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(59, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tbPhai.Controls.Add(grpTimKiemHoaDon, 0, 0);
            tbPhai.Controls.Add(grDSHoaDon, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(400, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(591, 626);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemHoaDon
            // 
            grpTimKiemHoaDon.Controls.Add(txtTimKiemHoaDon);
            grpTimKiemHoaDon.Controls.Add(lblTimKiemHoaDon);
            grpTimKiemHoaDon.Controls.Add(btnTimKiem);
            grpTimKiemHoaDon.Dock = DockStyle.Fill;
            grpTimKiemHoaDon.Location = new Point(3, 3);
            grpTimKiemHoaDon.Name = "grpTimKiemHoaDon";
            grpTimKiemHoaDon.Size = new Size(585, 119);
            grpTimKiemHoaDon.TabIndex = 0;
            grpTimKiemHoaDon.TabStop = false;
            grpTimKiemHoaDon.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // txtTimKiemHoaDon
            // 
            txtTimKiemHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemHoaDon.Location = new Point(180, 49);
            txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            txtTimKiemHoaDon.Size = new Size(196, 25);
            txtTimKiemHoaDon.TabIndex = 6;
            // 
            // lblTimKiemHoaDon
            // 
            lblTimKiemHoaDon.Location = new Point(14, 52);
            lblTimKiemHoaDon.Name = "lblTimKiemHoaDon";
            lblTimKiemHoaDon.Size = new Size(160, 23);
            lblTimKiemHoaDon.TabIndex = 5;
            lblTimKiemHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(433, 43);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(125, 35);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grDSHoaDon
            // 
            grDSHoaDon.Controls.Add(dataGridView1);
            grDSHoaDon.Dock = DockStyle.Fill;
            grDSHoaDon.Location = new Point(3, 128);
            grDSHoaDon.Name = "grDSHoaDon";
            grDSHoaDon.Size = new Size(585, 495);
            grDSHoaDon.TabIndex = 1;
            grDSHoaDon.TabStop = false;
            grDSHoaDon.Text = "Danh Sách Hóa Đơn";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkSlateGray;
            lblTieuDe.Location = new Point(3, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(994, 112);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "QUẢN LÝ HÓA ĐƠN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaHoaDon, colTenKhachHang, colTenNhanVien, colNgayLap, colTongTien });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 471);
            dataGridView1.TabIndex = 16;
            // 
            // colMaHoaDon
            // 
            colMaHoaDon.HeaderText = "Mã Hóa Đơn";
            colMaHoaDon.Name = "colMaHoaDon";
            colMaHoaDon.ReadOnly = true;
            colMaHoaDon.Width = 125;
            // 
            // colTenKhachHang
            // 
            colTenKhachHang.HeaderText = "Tên Khách Hàng";
            colTenKhachHang.Name = "colTenKhachHang";
            colTenKhachHang.ReadOnly = true;
            colTenKhachHang.Width = 150;
            // 
            // colTenNhanVien
            // 
            colTenNhanVien.HeaderText = "Tên Nhân Viên";
            colTenNhanVien.Name = "colTenNhanVien";
            colTenNhanVien.ReadOnly = true;
            colTenNhanVien.Width = 125;
            // 
            // colNgayLap
            // 
            colNgayLap.HeaderText = "Ngày Lập";
            colNgayLap.Name = "colNgayLap";
            colNgayLap.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // usHoaDon
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usHoaDon";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbTong.ResumeLayout(false);
            grpTTHoaDon.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grTTDaiLy.ResumeLayout(false);
            grTTDaiLy.PerformLayout();
            grpTacVu.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemHoaDon.ResumeLayout(false);
            grpTimKiemHoaDon.PerformLayout();
            grDSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }
        private GroupBox grTTDaiLy;
        private TextBox txtTenNhanVien;
        private Label lblTenNhanVien;
        private TextBox txtTongTien;
        private TextBox txtNgayLap;
        private Label lblTongTien;
        private Label lblNgayLap;
        private TextBox txtTenKhachHang;
        private Label lblMaKhachHang;
        private TextBox txtMaHoaDon;
        private Label lblMaHoaDon;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMaHoaDon;
        private DataGridViewTextBoxColumn colTenKhachHang;
        private DataGridViewTextBoxColumn colTenNhanVien;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colTongTien;
    }
}
