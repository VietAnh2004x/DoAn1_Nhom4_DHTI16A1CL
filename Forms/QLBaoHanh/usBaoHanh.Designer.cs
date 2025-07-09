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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThi = new System.Windows.Forms.TableLayoutPanel();
            this.tbTrai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTTBaoHanh = new System.Windows.Forms.GroupBox();
            this.txtMaBaoHanh = new System.Windows.Forms.TextBox();
            this.lblMaBaoHanh = new System.Windows.Forms.Label();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.txtNgayBatDau = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTimKiemPhieuBaoHanh = new System.Windows.Forms.GroupBox();
            this.txtTimKiemPhieuBaoHanh = new System.Windows.Forms.TextBox();
            this.lblTimKiemPhieuBaoHanh = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDSBaoHanh = new System.Windows.Forms.GroupBox();
            this.dgvDSBaoHanh = new System.Windows.Forms.DataGridView();
            this.colMaBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grpTTBaoHanh.SuspendLayout();
            this.grpTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grpTimKiemPhieuBaoHanh.SuspendLayout();
            this.grpDSBaoHanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBaoHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 750);
            this.panel1.TabIndex = 0;
            // 
            // tbTong
            // 
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTong.Controls.Add(this.tbHienThi, 0, 1);
            this.tbTong.Controls.Add(this.lblTieuDe, 0, 0);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbTong.Size = new System.Drawing.Size(1000, 750);
            this.tbTong.TabIndex = 0;
            // 
            // tbHienThi
            // 
            this.tbHienThi.ColumnCount = 2;
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbHienThi.Controls.Add(this.tbTrai, 0, 0);
            this.tbHienThi.Controls.Add(this.tbPhai, 1, 0);
            this.tbHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThi.Location = new System.Drawing.Point(3, 115);
            this.tbHienThi.Name = "tbHienThi";
            this.tbHienThi.RowCount = 1;
            this.tbHienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 632F));
            this.tbHienThi.Size = new System.Drawing.Size(994, 632);
            this.tbHienThi.TabIndex = 0;
            // 
            // tbTrai
            // 
            this.tbTrai.ColumnCount = 1;
            this.tbTrai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tbTrai.Controls.Add(this.grpTTBaoHanh, 0, 0);
            this.tbTrai.Controls.Add(this.grpTacVu, 0, 1);
            this.tbTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrai.Location = new System.Drawing.Point(3, 3);
            this.tbTrai.Name = "tbTrai";
            this.tbTrai.RowCount = 2;
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTrai.Size = new System.Drawing.Size(391, 626);
            this.tbTrai.TabIndex = 0;
            // 
            // grpTTBaoHanh
            // 
            this.grpTTBaoHanh.Controls.Add(this.txtMaBaoHanh);
            this.grpTTBaoHanh.Controls.Add(this.lblMaBaoHanh);
            this.grpTTBaoHanh.Controls.Add(this.txtThoiHan);
            this.grpTTBaoHanh.Controls.Add(this.txtNgayBatDau);
            this.grpTTBaoHanh.Controls.Add(this.txtMaHoaDon);
            this.grpTTBaoHanh.Controls.Add(this.txtMaXe);
            this.grpTTBaoHanh.Controls.Add(this.lblThoiHan);
            this.grpTTBaoHanh.Controls.Add(this.lblNgayBatDau);
            this.grpTTBaoHanh.Controls.Add(this.lblMaXe);
            this.grpTTBaoHanh.Controls.Add(this.lblMaHoaDon);
            this.grpTTBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTBaoHanh.Location = new System.Drawing.Point(3, 3);
            this.grpTTBaoHanh.Name = "grpTTBaoHanh";
            this.grpTTBaoHanh.Size = new System.Drawing.Size(385, 463);
            this.grpTTBaoHanh.TabIndex = 0;
            this.grpTTBaoHanh.TabStop = false;
            this.grpTTBaoHanh.Text = "Thông Tin Bảo Hành";
            // 
            // txtMaBaoHanh
            // 
            this.txtMaBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaBaoHanh.Location = new System.Drawing.Point(165, 67);
            this.txtMaBaoHanh.Name = "txtMaBaoHanh";
            this.txtMaBaoHanh.Size = new System.Drawing.Size(140, 30);
            this.txtMaBaoHanh.TabIndex = 11;
            // 
            // lblMaBaoHanh
            // 
            this.lblMaBaoHanh.Location = new System.Drawing.Point(6, 69);
            this.lblMaBaoHanh.Name = "lblMaBaoHanh";
            this.lblMaBaoHanh.Size = new System.Drawing.Size(153, 32);
            this.lblMaBaoHanh.TabIndex = 10;
            this.lblMaBaoHanh.Text = "Mã Bảo Hành";
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThoiHan.Location = new System.Drawing.Point(165, 376);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(140, 30);
            this.txtThoiHan.TabIndex = 9;
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayBatDau.Location = new System.Drawing.Point(165, 298);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(140, 30);
            this.txtNgayBatDau.TabIndex = 8;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoaDon.Location = new System.Drawing.Point(165, 145);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(140, 30);
            this.txtMaHoaDon.TabIndex = 7;
            // 
            // txtMaXe
            // 
            this.txtMaXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaXe.Location = new System.Drawing.Point(165, 223);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(140, 30);
            this.txtMaXe.TabIndex = 6;
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.Location = new System.Drawing.Point(6, 378);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(103, 34);
            this.lblThoiHan.TabIndex = 4;
            this.lblThoiHan.Text = "Thời Hạn:";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Location = new System.Drawing.Point(6, 300);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(147, 32);
            this.lblNgayBatDau.TabIndex = 3;
            this.lblNgayBatDau.Text = "Ngày Bắt Đầu:";
            // 
            // lblMaXe
            // 
            this.lblMaXe.Location = new System.Drawing.Point(6, 225);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(127, 29);
            this.lblMaXe.TabIndex = 2;
            this.lblMaXe.Text = "Mã Xe:";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Location = new System.Drawing.Point(6, 147);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(127, 32);
            this.lblMaHoaDon.TabIndex = 1;
            this.lblMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // grpTacVu
            // 
            this.grpTacVu.Controls.Add(this.btnLamMoi);
            this.grpTacVu.Controls.Add(this.btnXoa);
            this.grpTacVu.Controls.Add(this.btnSua);
            this.grpTacVu.Controls.Add(this.btnThem);
            this.grpTacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTacVu.Location = new System.Drawing.Point(3, 472);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Size = new System.Drawing.Size(385, 151);
            this.grpTacVu.TabIndex = 1;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác Vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(224, 97);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(59, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(224, 36);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(59, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbPhai
            // 
            this.tbPhai.ColumnCount = 1;
            this.tbPhai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.tbPhai.Controls.Add(this.grpTimKiemPhieuBaoHanh, 0, 0);
            this.tbPhai.Controls.Add(this.grpDSBaoHanh, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(400, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbPhai.Size = new System.Drawing.Size(591, 626);
            this.tbPhai.TabIndex = 1;
            // 
            // grpTimKiemPhieuBaoHanh
            // 
            this.grpTimKiemPhieuBaoHanh.Controls.Add(this.txtTimKiemPhieuBaoHanh);
            this.grpTimKiemPhieuBaoHanh.Controls.Add(this.lblTimKiemPhieuBaoHanh);
            this.grpTimKiemPhieuBaoHanh.Controls.Add(this.btnTimKiem);
            this.grpTimKiemPhieuBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimKiemPhieuBaoHanh.Location = new System.Drawing.Point(3, 3);
            this.grpTimKiemPhieuBaoHanh.Name = "grpTimKiemPhieuBaoHanh";
            this.grpTimKiemPhieuBaoHanh.Size = new System.Drawing.Size(585, 119);
            this.grpTimKiemPhieuBaoHanh.TabIndex = 0;
            this.grpTimKiemPhieuBaoHanh.TabStop = false;
            this.grpTimKiemPhieuBaoHanh.Text = "Tìm Kiếm Phiếu Bảo Hành";
            // 
            // txtTimKiemPhieuBaoHanh
            // 
            this.txtTimKiemPhieuBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemPhieuBaoHanh.Location = new System.Drawing.Point(180, 49);
            this.txtTimKiemPhieuBaoHanh.Name = "txtTimKiemPhieuBaoHanh";
            this.txtTimKiemPhieuBaoHanh.Size = new System.Drawing.Size(196, 30);
            this.txtTimKiemPhieuBaoHanh.TabIndex = 6;
            // 
            // lblTimKiemPhieuBaoHanh
            // 
            this.lblTimKiemPhieuBaoHanh.Location = new System.Drawing.Point(14, 52);
            this.lblTimKiemPhieuBaoHanh.Name = "lblTimKiemPhieuBaoHanh";
            this.lblTimKiemPhieuBaoHanh.Size = new System.Drawing.Size(160, 23);
            this.lblTimKiemPhieuBaoHanh.TabIndex = 5;
            this.lblTimKiemPhieuBaoHanh.Text = "Mã Phiếu Bảo Hành:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(433, 43);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 35);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grpDSBaoHanh
            // 
            this.grpDSBaoHanh.Controls.Add(this.dgvDSBaoHanh);
            this.grpDSBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSBaoHanh.Location = new System.Drawing.Point(3, 128);
            this.grpDSBaoHanh.Name = "grpDSBaoHanh";
            this.grpDSBaoHanh.Size = new System.Drawing.Size(585, 495);
            this.grpDSBaoHanh.TabIndex = 1;
            this.grpDSBaoHanh.TabStop = false;
            this.grpDSBaoHanh.Text = "Danh Sách Bảo Hành";
            // 
            // dgvDSBaoHanh
            // 
            this.dgvDSBaoHanh.AllowUserToAddRows = false;
            this.dgvDSBaoHanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBaoHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBaoHanh,
            this.colMaHoaDon,
            this.colMaXe,
            this.colNgayBatDau,
            this.colThoiHan});
            this.dgvDSBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBaoHanh.Location = new System.Drawing.Point(3, 26);
            this.dgvDSBaoHanh.Name = "dgvDSBaoHanh";
            this.dgvDSBaoHanh.RowHeadersWidth = 51;
            this.dgvDSBaoHanh.Size = new System.Drawing.Size(579, 466);
            this.dgvDSBaoHanh.TabIndex = 0;
            // 
            // colMaBaoHanh
            // 
            this.colMaBaoHanh.HeaderText = "Mã Bảo Hành";
            this.colMaBaoHanh.MinimumWidth = 6;
            this.colMaBaoHanh.Name = "colMaBaoHanh";
            this.colMaBaoHanh.Width = 150;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.colMaHoaDon.MinimumWidth = 6;
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.ReadOnly = true;
            this.colMaHoaDon.Width = 150;
            // 
            // colMaXe
            // 
            this.colMaXe.HeaderText = "Mã Xe";
            this.colMaXe.MinimumWidth = 6;
            this.colMaXe.Name = "colMaXe";
            this.colMaXe.ReadOnly = true;
            this.colMaXe.Width = 150;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.colNgayBatDau.MinimumWidth = 6;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.ReadOnly = true;
            this.colNgayBatDau.Width = 150;
            // 
            // colThoiHan
            // 
            this.colThoiHan.HeaderText = "Thời Hạn";
            this.colThoiHan.MinimumWidth = 6;
            this.colThoiHan.Name = "colThoiHan";
            this.colThoiHan.ReadOnly = true;
            this.colThoiHan.Width = 150;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(994, 112);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "QUẢN LÝ BẢO HÀNH";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "usBaoHanh";
            this.Size = new System.Drawing.Size(1000, 750);
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThi.ResumeLayout(false);
            this.tbTrai.ResumeLayout(false);
            this.grpTTBaoHanh.ResumeLayout(false);
            this.grpTTBaoHanh.PerformLayout();
            this.grpTacVu.ResumeLayout(false);
            this.tbPhai.ResumeLayout(false);
            this.grpTimKiemPhieuBaoHanh.ResumeLayout(false);
            this.grpTimKiemPhieuBaoHanh.PerformLayout();
            this.grpDSBaoHanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBaoHanh)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiemPhieuBaoHanh;
        private System.Windows.Forms.Label lblTimKiemPhieuBaoHanh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSBaoHanh;
        private DataGridViewTextBoxColumn colMaBaoHanh;
        private DataGridViewTextBoxColumn colMaHoaDon;
        private DataGridViewTextBoxColumn colMaXe;
        private DataGridViewTextBoxColumn colNgayBatDau;
        private DataGridViewTextBoxColumn colThoiHan;
        private TextBox txtMaHoaDon;
        private TextBox txtMaXe;
        private Label lblMaXe;
        private Label lblMaHoaDon;
        private TextBox txtMaBaoHanh;
        private Label lblMaBaoHanh;
    }
}
