﻿using System.Windows.Forms;

namespace DoAn.Forms.QLBaoHanh
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
            tbHienThi = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            grpTTBaoHanh = new GroupBox();
            txtTenXe = new TextBox();
            lbTenXe = new Label();
            dtpNgayBatDau = new DateTimePicker();
            txtMaBaoHanh = new TextBox();
            lblMaBaoHanh = new Label();
            txtThoiHan = new TextBox();
            txtTenKhach = new TextBox();
            lblThoiHan = new Label();
            lblNgayBatDau = new Label();
            lblMaHoaDon = new Label();
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
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
            panel1.SuspendLayout();
            tbHienThi.SuspendLayout();
            tbTrai.SuspendLayout();
            grpTTBaoHanh.SuspendLayout();
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
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
            panel1.Controls.Add(tbHienThi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 799);
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
            tbHienThi.Size = new Size(989, 799);
            tbHienThi.TabIndex = 1;
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
            tbTrai.Size = new Size(389, 793);
            tbTrai.TabIndex = 0;
            // 
            // grpTTBaoHanh
            // 
            grpTTBaoHanh.Controls.Add(txtTenXe);
            grpTTBaoHanh.Controls.Add(lbTenXe);
            grpTTBaoHanh.Controls.Add(dtpNgayBatDau);
            grpTTBaoHanh.Controls.Add(txtMaBaoHanh);
            grpTTBaoHanh.Controls.Add(lblMaBaoHanh);
            grpTTBaoHanh.Controls.Add(txtThoiHan);
            grpTTBaoHanh.Controls.Add(txtTenKhach);
            grpTTBaoHanh.Controls.Add(lblThoiHan);
            grpTTBaoHanh.Controls.Add(lblNgayBatDau);
            grpTTBaoHanh.Controls.Add(lblMaHoaDon);
            grpTTBaoHanh.Dock = DockStyle.Fill;
            grpTTBaoHanh.Location = new Point(3, 3);
            grpTTBaoHanh.Name = "grpTTBaoHanh";
            grpTTBaoHanh.Size = new Size(385, 588);
            grpTTBaoHanh.TabIndex = 0;
            grpTTBaoHanh.TabStop = false;
            grpTTBaoHanh.Text = "Thông Tin Bảo Hành";
            // 
            // txtTenXe
            // 
            txtTenXe.BorderStyle = BorderStyle.FixedSingle;
            txtTenXe.Location = new Point(165, 263);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(203, 30);
            txtTenXe.TabIndex = 13;
            // 
            // lbTenXe
            // 
            lbTenXe.Location = new Point(14, 265);
            lbTenXe.Name = "lbTenXe";
            lbTenXe.Size = new Size(127, 23);
            lbTenXe.TabIndex = 12;
            lbTenXe.Text = "Tên Xe";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(163, 342);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(204, 30);
            dtpNgayBatDau.TabIndex = 8;
            // 
            // txtMaBaoHanh
            // 
            txtMaBaoHanh.BorderStyle = BorderStyle.FixedSingle;
            txtMaBaoHanh.Location = new Point(163, 95);
            txtMaBaoHanh.Name = "txtMaBaoHanh";
            txtMaBaoHanh.Size = new Size(203, 30);
            txtMaBaoHanh.TabIndex = 11;
            // 
            // lblMaBaoHanh
            // 
            lblMaBaoHanh.Location = new Point(14, 97);
            lblMaBaoHanh.Name = "lblMaBaoHanh";
            lblMaBaoHanh.Size = new Size(136, 25);
            lblMaBaoHanh.TabIndex = 10;
            lblMaBaoHanh.Text = "Mã Bảo Hành";
            // 
            // txtThoiHan
            // 
            txtThoiHan.BorderStyle = BorderStyle.FixedSingle;
            txtThoiHan.Location = new Point(165, 426);
            txtThoiHan.Name = "txtThoiHan";
            txtThoiHan.Size = new Size(204, 30);
            txtThoiHan.TabIndex = 9;
            // 
            // txtTenKhach
            // 
            txtTenKhach.BorderStyle = BorderStyle.FixedSingle;
            txtTenKhach.Location = new Point(165, 180);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(203, 30);
            txtTenKhach.TabIndex = 7;
            // 
            // lblThoiHan
            // 
            lblThoiHan.Location = new Point(14, 428);
            lblThoiHan.Name = "lblThoiHan";
            lblThoiHan.Size = new Size(103, 23);
            lblThoiHan.TabIndex = 4;
            lblThoiHan.Text = "Thời Hạn (Tháng):";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.Location = new Point(14, 348);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(136, 20);
            lblNgayBatDau.TabIndex = 3;
            lblNgayBatDau.Text = "Ngày Bắt Đầu:";
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.Location = new Point(14, 182);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(146, 23);
            lblMaHoaDon.TabIndex = 1;
            lblMaHoaDon.Text = "Tên Khách Hàng";
            // 
            // grpTacVu
            // 
            grpTacVu.Controls.Add(tbTacVu);
            grpTacVu.Dock = DockStyle.Fill;
            grpTacVu.Location = new Point(3, 597);
            grpTacVu.Name = "grpTacVu";
            grpTacVu.Size = new Size(385, 193);
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
            tbTacVu.Size = new Size(379, 164);
            tbTacVu.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(255, 193, 7);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(229, 104);
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
            btnThem.Location = new Point(39, 22);
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
            btnXoa.Location = new Point(39, 104);
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
            btnSua.Location = new Point(229, 22);
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
            tbPhai.Controls.Add(grpTimKiemPhieuBaoHanh, 0, 0);
            tbPhai.Controls.Add(grpDSBaoHanh, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(398, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(588, 793);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemPhieuBaoHanh
            // 
            grpTimKiemPhieuBaoHanh.Controls.Add(tableLayoutPanel2);
            grpTimKiemPhieuBaoHanh.Dock = DockStyle.Fill;
            grpTimKiemPhieuBaoHanh.Location = new Point(3, 3);
            grpTimKiemPhieuBaoHanh.Name = "grpTimKiemPhieuBaoHanh";
            grpTimKiemPhieuBaoHanh.Size = new Size(585, 152);
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
            tableLayoutPanel2.Size = new Size(579, 123);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimKiemPhieuBaoHanh
            // 
            lblTimKiemPhieuBaoHanh.Anchor = AnchorStyles.None;
            lblTimKiemPhieuBaoHanh.Location = new Point(3, 50);
            lblTimKiemPhieuBaoHanh.Name = "lblTimKiemPhieuBaoHanh";
            lblTimKiemPhieuBaoHanh.Size = new Size(167, 23);
            lblTimKiemPhieuBaoHanh.TabIndex = 13;
            lblTimKiemPhieuBaoHanh.Text = "Mã Phiếu Bảo Hành:";
            // 
            // txtTimKiemPhieuBaoHanh
            // 
            txtTimKiemPhieuBaoHanh.Anchor = AnchorStyles.None;
            txtTimKiemPhieuBaoHanh.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemPhieuBaoHanh.Location = new Point(190, 46);
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
            btnTimKiem.Location = new Point(437, 43);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(109, 36);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // grpDSBaoHanh
            // 
            grpDSBaoHanh.Controls.Add(dgvDSBaoHanh);
            grpDSBaoHanh.Dock = DockStyle.Fill;
            grpDSBaoHanh.Location = new Point(3, 161);
            grpDSBaoHanh.Name = "grpDSBaoHanh";
            grpDSBaoHanh.Size = new Size(585, 629);
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
            dgvDSBaoHanh.Size = new Size(579, 600);
            dgvDSBaoHanh.TabIndex = 0;
            dgvDSBaoHanh.CellClick += dgvDSBaoHanh_CellClick;
            // 
            // usBaoHanh
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usBaoHanh";
            Size = new Size(989, 799);
            panel1.ResumeLayout(false);
            tbHienThi.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grpTTBaoHanh.ResumeLayout(false);
            grpTTBaoHanh.PerformLayout();
            grpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemPhieuBaoHanh.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grpDSBaoHanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSBaoHanh).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private TableLayoutPanel tbHienThi;
        private TableLayoutPanel tbTrai;
        private GroupBox grpTTBaoHanh;
        private DateTimePicker dtpNgayBatDau;
        private TextBox txtMaBaoHanh;
        private Label lblMaBaoHanh;
        private TextBox txtThoiHan;
        private TextBox txtTenKhach;
        private Label lblThoiHan;
        private Label lblNgayBatDau;
        private Label lblMaHoaDon;
        private GroupBox grpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TableLayoutPanel tbPhai;
        private GroupBox grpTimKiemPhieuBaoHanh;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTimKiemPhieuBaoHanh;
        private TextBox txtTimKiemPhieuBaoHanh;
        private Button btnTimKiem;
        private GroupBox grpDSBaoHanh;
        private DataGridView dgvDSBaoHanh;
        private TextBox txtTenXe;
        private Label lbTenXe;
    }
}
