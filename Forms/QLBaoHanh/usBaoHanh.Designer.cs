using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoHanh
{
    partial class usBaoHanh
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
            tbTong = new TableLayoutPanel();
            tbHienThi = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            grpTTBaoHanh = new GroupBox();
            txtMaBaoHanh = new TextBox();
            lblMaBaoHanh = new Label();
            txtThoiHan = new TextBox();
            txtNgayBatDau = new TextBox();
            txtMaHoaDon = new TextBox();
            txtMaXe = new TextBox();
            lblThoiHan = new Label();
            lblNgayBatDau = new Label();
            lblMaXe = new Label();
            lblMaHoaDon = new Label();
            grpTacVu = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            tbPhai = new TableLayoutPanel();
            grpTimKiemPhieuBaoHanh = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTimKiemPhieuBaoHanh = new Label();
            txtTimKiemPhieuBaoHanh = new TextBox();
            btnTimKiem = new Button();
            grpDSBaoHanh = new GroupBox();
            dgvDSBaoHanh = new DataGridView();
            lblTieuDe = new Label();
            panel1.SuspendLayout();
            tbTong.SuspendLayout();
            tbHienThi.SuspendLayout();
            tbTrai.SuspendLayout();
            grpTTBaoHanh.SuspendLayout();
            grpTacVu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemPhieuBaoHanh.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpDSBaoHanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSBaoHanh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
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
            tbTong.Controls.Add(tbHienThi, 0, 1);
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
            // tbHienThi
            // 
            tbHienThi.ColumnCount = 2;
            tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tbHienThi.Controls.Add(tbTrai, 0, 0);
            tbHienThi.Controls.Add(tbPhai, 1, 0);
            tbHienThi.Dock = DockStyle.Fill;
            tbHienThi.Location = new Point(3, 115);
            tbHienThi.Name = "tbHienThi";
            tbHienThi.RowCount = 1;
            tbHienThi.RowStyles.Add(new RowStyle(SizeType.Absolute, 632F));
            tbHienThi.Size = new Size(994, 632);
            tbHienThi.TabIndex = 0;
            // 
            // tbTrai
            // 
            tbTrai.ColumnCount = 1;
            tbTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 391F));
            tbTrai.Controls.Add(grpTTBaoHanh, 0, 0);
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
            // grpTTBaoHanh
            // 
            grpTTBaoHanh.Controls.Add(txtMaBaoHanh);
            grpTTBaoHanh.Controls.Add(lblMaBaoHanh);
            grpTTBaoHanh.Controls.Add(txtThoiHan);
            grpTTBaoHanh.Controls.Add(txtNgayBatDau);
            grpTTBaoHanh.Controls.Add(txtMaHoaDon);
            grpTTBaoHanh.Controls.Add(txtMaXe);
            grpTTBaoHanh.Controls.Add(lblThoiHan);
            grpTTBaoHanh.Controls.Add(lblNgayBatDau);
            grpTTBaoHanh.Controls.Add(lblMaXe);
            grpTTBaoHanh.Controls.Add(lblMaHoaDon);
            grpTTBaoHanh.Dock = DockStyle.Fill;
            grpTTBaoHanh.Location = new Point(3, 3);
            grpTTBaoHanh.Name = "grpTTBaoHanh";
            grpTTBaoHanh.Size = new Size(385, 463);
            grpTTBaoHanh.TabIndex = 0;
            grpTTBaoHanh.TabStop = false;
            grpTTBaoHanh.Text = "Thông Tin Bảo Hành";
            // 
            // txtMaBaoHanh
            // 
            txtMaBaoHanh.BorderStyle = BorderStyle.FixedSingle;
            txtMaBaoHanh.Location = new Point(165, 67);
            txtMaBaoHanh.Name = "txtMaBaoHanh";
            txtMaBaoHanh.Size = new Size(140, 30);
            txtMaBaoHanh.TabIndex = 11;
            // 
            // lblMaBaoHanh
            // 
            lblMaBaoHanh.Location = new Point(6, 69);
            lblMaBaoHanh.Name = "lblMaBaoHanh";
            lblMaBaoHanh.Size = new Size(153, 32);
            lblMaBaoHanh.TabIndex = 10;
            lblMaBaoHanh.Text = "Mã Bảo Hành";
            // 
            // txtThoiHan
            // 
            txtThoiHan.BorderStyle = BorderStyle.FixedSingle;
            txtThoiHan.Location = new Point(165, 376);
            txtThoiHan.Name = "txtThoiHan";
            txtThoiHan.Size = new Size(140, 30);
            txtThoiHan.TabIndex = 9;
            // 
            // txtNgayBatDau
            // 
            txtNgayBatDau.BorderStyle = BorderStyle.FixedSingle;
            txtNgayBatDau.Location = new Point(165, 298);
            txtNgayBatDau.Name = "txtNgayBatDau";
            txtNgayBatDau.Size = new Size(140, 30);
            txtNgayBatDau.TabIndex = 8;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtMaHoaDon.Location = new Point(165, 145);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(140, 30);
            txtMaHoaDon.TabIndex = 7;
            // 
            // txtMaXe
            // 
            txtMaXe.BorderStyle = BorderStyle.FixedSingle;
            txtMaXe.Location = new Point(165, 223);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(140, 30);
            txtMaXe.TabIndex = 6;
            // 
            // lblThoiHan
            // 
            lblThoiHan.Location = new Point(6, 378);
            lblThoiHan.Name = "lblThoiHan";
            lblThoiHan.Size = new Size(103, 34);
            lblThoiHan.TabIndex = 4;
            lblThoiHan.Text = "Thời Hạn:";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.Location = new Point(6, 300);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(147, 32);
            lblNgayBatDau.TabIndex = 3;
            lblNgayBatDau.Text = "Ngày Bắt Đầu:";
            // 
            // lblMaXe
            // 
            lblMaXe.Location = new Point(6, 225);
            lblMaXe.Name = "lblMaXe";
            lblMaXe.Size = new Size(127, 29);
            lblMaXe.TabIndex = 2;
            lblMaXe.Text = "Mã Xe:";
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.Location = new Point(6, 147);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(127, 32);
            lblMaHoaDon.TabIndex = 1;
            lblMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // grpTacVu
            // 
            grpTacVu.Controls.Add(tableLayoutPanel1);
            grpTacVu.Dock = DockStyle.Fill;
            grpTacVu.Location = new Point(3, 472);
            grpTacVu.Name = "grpTacVu";
            grpTacVu.Size = new Size(385, 151);
            grpTacVu.TabIndex = 1;
            grpTacVu.TabStop = false;
            grpTacVu.Text = "Tác Vụ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnLamMoi, 1, 1);
            tableLayoutPanel1.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel1.Controls.Add(btnXoa, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(379, 122);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 193, 7);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(233, 74);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(102, 34);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(43, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 34);
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
            btnXoa.Location = new Point(43, 74);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 34);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(233, 13);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 34);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tbPhai.Controls.Add(grpTimKiemPhieuBaoHanh, 0, 0);
            tbPhai.Controls.Add(grpDSBaoHanh, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(400, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(591, 626);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemPhieuBaoHanh
            // 
            grpTimKiemPhieuBaoHanh.Controls.Add(tableLayoutPanel2);
            grpTimKiemPhieuBaoHanh.Dock = DockStyle.Fill;
            grpTimKiemPhieuBaoHanh.Location = new Point(3, 3);
            grpTimKiemPhieuBaoHanh.Name = "grpTimKiemPhieuBaoHanh";
            grpTimKiemPhieuBaoHanh.Size = new Size(585, 119);
            grpTimKiemPhieuBaoHanh.TabIndex = 0;
            grpTimKiemPhieuBaoHanh.TabStop = false;
            grpTimKiemPhieuBaoHanh.Text = "Tìm Kiếm Phiếu Bảo Hành";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(lblTimKiemPhieuBaoHanh, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTimKiemPhieuBaoHanh, 1, 0);
            tableLayoutPanel2.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(579, 90);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimKiemPhieuBaoHanh
            // 
            lblTimKiemPhieuBaoHanh.Anchor = AnchorStyles.None;
            lblTimKiemPhieuBaoHanh.Location = new Point(3, 33);
            lblTimKiemPhieuBaoHanh.Name = "lblTimKiemPhieuBaoHanh";
            lblTimKiemPhieuBaoHanh.Size = new Size(167, 23);
            lblTimKiemPhieuBaoHanh.TabIndex = 13;
            lblTimKiemPhieuBaoHanh.Text = "Mã Phiếu Bảo Hành:";
            // 
            // txtTimKiemPhieuBaoHanh
            // 
            txtTimKiemPhieuBaoHanh.Anchor = AnchorStyles.None;
            txtTimKiemPhieuBaoHanh.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemPhieuBaoHanh.Location = new Point(190, 30);
            txtTimKiemPhieuBaoHanh.Name = "txtTimKiemPhieuBaoHanh";
            txtTimKiemPhieuBaoHanh.Size = new Size(196, 30);
            txtTimKiemPhieuBaoHanh.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(441, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grpDSBaoHanh
            // 
            grpDSBaoHanh.Controls.Add(dgvDSBaoHanh);
            grpDSBaoHanh.Dock = DockStyle.Fill;
            grpDSBaoHanh.Location = new Point(3, 128);
            grpDSBaoHanh.Name = "grpDSBaoHanh";
            grpDSBaoHanh.Size = new Size(585, 495);
            grpDSBaoHanh.TabIndex = 1;
            grpDSBaoHanh.TabStop = false;
            grpDSBaoHanh.Text = "Danh Sách Bảo Hành";
            // 
            // dgvDSBaoHanh
            // 
            dgvDSBaoHanh.AllowUserToAddRows = false;
            dgvDSBaoHanh.BackgroundColor = Color.White;
            dgvDSBaoHanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSBaoHanh.Dock = DockStyle.Fill;
            dgvDSBaoHanh.Location = new Point(3, 26);
            dgvDSBaoHanh.Name = "dgvDSBaoHanh";
            dgvDSBaoHanh.RowHeadersWidth = 51;
            dgvDSBaoHanh.Size = new Size(579, 466);
            dgvDSBaoHanh.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.Location = new Point(3, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(994, 112);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "QUẢN LÝ BẢO HÀNH";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usBaoHanh
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usBaoHanh";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbTong.ResumeLayout(false);
            tbHienThi.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grpTTBaoHanh.ResumeLayout(false);
            grpTTBaoHanh.PerformLayout();
            grpTacVu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemPhieuBaoHanh.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grpDSBaoHanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSBaoHanh).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbHienThi;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.GroupBox grpTTBaoHanh;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.GroupBox grpTimKiemPhieuBaoHanh;
        private System.Windows.Forms.GroupBox grpDSBaoHanh;
        private System.Windows.Forms.TextBox txtThoiHan;
        private System.Windows.Forms.TextBox txtNgayBatDau;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DataGridView dgvDSBaoHanh;
        private TextBox txtMaHoaDon;
        private TextBox txtMaXe;
        private Label lblMaXe;
        private Label lblMaHoaDon;
        private TextBox txtMaBaoHanh;
        private Label lblMaBaoHanh;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtTimKiemPhieuBaoHanh;
        private Label lblTimKiemPhieuBaoHanh;
        private Button btnTimKiem;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
