using System.Windows.Forms;

namespace DoAn1.Forms.QLKhachHang
{
    partial class usKhachHang
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
            tbHienThiChung = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            grpTTKhachHang = new GroupBox();
            txtMaKH = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            lblHoTen = new Label();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            tbPhai = new TableLayoutPanel();
            grpTimKiemKhachHang = new GroupBox();
            tbTimKiem = new TableLayoutPanel();
            lblTimKiemKhachHang = new Label();
            txtTimKiemKhachHang = new TextBox();
            btnTimKiem = new Button();
            grpDSKhachHang = new GroupBox();
            dgvDSKhachHang = new DataGridView();
            panel1.SuspendLayout();
            tbHienThiChung.SuspendLayout();
            tbTrai.SuspendLayout();
            grpTTKhachHang.SuspendLayout();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemKhachHang.SuspendLayout();
            tbTimKiem.SuspendLayout();
            grpDSKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbHienThiChung);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 750);
            panel1.TabIndex = 0;
            // 
            // tbHienThiChung
            // 
            tbHienThiChung.ColumnCount = 2;
            tbHienThiChung.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tbHienThiChung.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tbHienThiChung.Controls.Add(tbTrai, 0, 0);
            tbHienThiChung.Controls.Add(tbPhai, 1, 0);
            tbHienThiChung.Dock = DockStyle.Fill;
            tbHienThiChung.Location = new Point(0, 0);
            tbHienThiChung.Name = "tbHienThiChung";
            tbHienThiChung.RowCount = 1;
            tbHienThiChung.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbHienThiChung.Size = new Size(1000, 750);
            tbHienThiChung.TabIndex = 2;
            // 
            // tbTrai
            // 
            tbTrai.ColumnCount = 1;
            tbTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 391F));
            tbTrai.Controls.Add(grpTTKhachHang, 0, 0);
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
            // grpTTKhachHang
            // 
            grpTTKhachHang.Controls.Add(txtMaKH);
            grpTTKhachHang.Controls.Add(label1);
            grpTTKhachHang.Controls.Add(txtEmail);
            grpTTKhachHang.Controls.Add(txtSoDienThoai);
            grpTTKhachHang.Controls.Add(txtHoTen);
            grpTTKhachHang.Controls.Add(txtDiaChi);
            grpTTKhachHang.Controls.Add(lblDiaChi);
            grpTTKhachHang.Controls.Add(lblHoTen);
            grpTTKhachHang.Controls.Add(lblSoDienThoai);
            grpTTKhachHang.Controls.Add(lblEmail);
            grpTTKhachHang.Dock = DockStyle.Fill;
            grpTTKhachHang.Location = new Point(3, 3);
            grpTTKhachHang.Name = "grpTTKhachHang";
            grpTTKhachHang.Size = new Size(388, 552);
            grpTTKhachHang.TabIndex = 0;
            grpTTKhachHang.TabStop = false;
            grpTTKhachHang.Text = "Thông tin khách hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            txtMaKH.Location = new Point(181, 81);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(157, 30);
            txtMaKH.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 83);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 11;
            label1.Text = "Mã Khách Hàng:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(177, 417);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 30);
            txtEmail.TabIndex = 10;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Location = new Point(177, 333);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(154, 30);
            txtSoDienThoai.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(181, 165);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(154, 30);
            txtHoTen.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(177, 249);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(154, 30);
            txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(13, 251);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 23);
            lblDiaChi.TabIndex = 5;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(13, 167);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Location = new Point(13, 335);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(121, 23);
            lblSoDienThoai.TabIndex = 3;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(13, 419);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
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
            grpTacVu.Text = "Tác vụ";
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
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(233, 94);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(107, 38);
            btnLamMoi.TabIndex = 14;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(42, 18);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 38);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(42, 94);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 38);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(233, 18);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbPhai.Controls.Add(grpTimKiemKhachHang, 0, 0);
            tbPhai.Controls.Add(grpDSKhachHang, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(403, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(594, 744);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemKhachHang
            // 
            grpTimKiemKhachHang.Controls.Add(tbTimKiem);
            grpTimKiemKhachHang.Dock = DockStyle.Fill;
            grpTimKiemKhachHang.Location = new Point(3, 3);
            grpTimKiemKhachHang.Name = "grpTimKiemKhachHang";
            grpTimKiemKhachHang.Size = new Size(588, 142);
            grpTimKiemKhachHang.TabIndex = 0;
            grpTimKiemKhachHang.TabStop = false;
            grpTimKiemKhachHang.Text = "Tìm kiếm khách hàng";
            // 
            // tbTimKiem
            // 
            tbTimKiem.ColumnCount = 3;
            tbTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tbTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tbTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tbTimKiem.Controls.Add(lblTimKiemKhachHang, 0, 0);
            tbTimKiem.Controls.Add(txtTimKiemKhachHang, 1, 0);
            tbTimKiem.Controls.Add(btnTimKiem, 2, 0);
            tbTimKiem.Dock = DockStyle.Fill;
            tbTimKiem.Location = new Point(3, 26);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.RowCount = 1;
            tbTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTimKiem.Size = new Size(582, 113);
            tbTimKiem.TabIndex = 0;
            // 
            // lblTimKiemKhachHang
            // 
            lblTimKiemKhachHang.Anchor = AnchorStyles.None;
            lblTimKiemKhachHang.Location = new Point(7, 45);
            lblTimKiemKhachHang.Name = "lblTimKiemKhachHang";
            lblTimKiemKhachHang.Size = new Size(160, 23);
            lblTimKiemKhachHang.TabIndex = 11;
            lblTimKiemKhachHang.Text = "Tên khách hàng:";
            // 
            // txtTimKiemKhachHang
            // 
            txtTimKiemKhachHang.Anchor = AnchorStyles.None;
            txtTimKiemKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemKhachHang.Location = new Point(192, 41);
            txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            txtTimKiemKhachHang.Size = new Size(196, 30);
            txtTimKiemKhachHang.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(443, 39);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(102, 35);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // grpDSKhachHang
            // 
            grpDSKhachHang.Controls.Add(dgvDSKhachHang);
            grpDSKhachHang.Dock = DockStyle.Fill;
            grpDSKhachHang.Location = new Point(3, 151);
            grpDSKhachHang.Name = "grpDSKhachHang";
            grpDSKhachHang.Size = new Size(588, 590);
            grpDSKhachHang.TabIndex = 1;
            grpDSKhachHang.TabStop = false;
            grpDSKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgvDSKhachHang
            // 
            dgvDSKhachHang.AllowUserToAddRows = false;
            dgvDSKhachHang.BackgroundColor = Color.White;
            dgvDSKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSKhachHang.Dock = DockStyle.Fill;
            dgvDSKhachHang.Location = new Point(3, 26);
            dgvDSKhachHang.Name = "dgvDSKhachHang";
            dgvDSKhachHang.RowHeadersWidth = 51;
            dgvDSKhachHang.Size = new Size(582, 561);
            dgvDSKhachHang.TabIndex = 0;
            dgvDSKhachHang.CellContentClick += dgvDSKhachHang_CellContentClick_1;
            // 
            // usKhachHang
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(240, 248, 255);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usKhachHang";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbHienThiChung.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grpTTKhachHang.ResumeLayout(false);
            grpTTKhachHang.PerformLayout();
            grpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemKhachHang.ResumeLayout(false);
            tbTimKiem.ResumeLayout(false);
            tbTimKiem.PerformLayout();
            grpDSKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSKhachHang).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private TableLayoutPanel tbHienThiChung;
        private TableLayoutPanel tbTrai;
        private GroupBox grpTTKhachHang;
        private TextBox txtMaKH;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private Label lblHoTen;
        private Label lblSoDienThoai;
        private Label lblEmail;
        private GroupBox grpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TableLayoutPanel tbPhai;
        private GroupBox grpTimKiemKhachHang;
        private TableLayoutPanel tbTimKiem;
        private Label lblTimKiemKhachHang;
        private TextBox txtTimKiemKhachHang;
        private Button btnTimKiem;
        private GroupBox grpDSKhachHang;
        private DataGridView dgvDSKhachHang;
    }
}
