using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLDaiLy
{
    partial class usDaiLy
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
            this.grpTTDaiLy = new System.Windows.Forms.GroupBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenDaiLy = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenDaiLy = new System.Windows.Forms.Label();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTimKiemDaiLy = new System.Windows.Forms.GroupBox();
            this.txtTimKiemDaiLy = new System.Windows.Forms.TextBox();
            this.lblTimKiemDaiLy = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDSDaiLy = new System.Windows.Forms.GroupBox();
            this.dgvDSDaiLy = new System.Windows.Forms.DataGridView();
            this.colMaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grpTTDaiLy.SuspendLayout();
            this.grpTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grpTimKiemDaiLy.SuspendLayout();
            this.grpDSDaiLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
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
            this.tbTrai.Controls.Add(this.grpTTDaiLy, 0, 0);
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
            // grpTTDaiLy
            // 
            this.grpTTDaiLy.Controls.Add(this.txtSoDienThoai);
            this.grpTTDaiLy.Controls.Add(this.txtEmail);
            this.grpTTDaiLy.Controls.Add(this.txtTenDaiLy);
            this.grpTTDaiLy.Controls.Add(this.txtDiaChi);
            this.grpTTDaiLy.Controls.Add(this.lblSoDienThoai);
            this.grpTTDaiLy.Controls.Add(this.lblEmail);
            this.grpTTDaiLy.Controls.Add(this.lblDiaChi);
            this.grpTTDaiLy.Controls.Add(this.lblTenDaiLy);
            this.grpTTDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTDaiLy.Location = new System.Drawing.Point(3, 3);
            this.grpTTDaiLy.Name = "grpTTDaiLy";
            this.grpTTDaiLy.Size = new System.Drawing.Size(385, 463);
            this.grpTTDaiLy.TabIndex = 0;
            this.grpTTDaiLy.TabStop = false;
            this.grpTTDaiLy.Text = "Thông Tin Đại Lý";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Location = new System.Drawing.Point(164, 349);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(143, 34);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(164, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 34);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDaiLy.Location = new System.Drawing.Point(165, 82);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(143, 34);
            this.txtTenDaiLy.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(164, 171);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(143, 34);
            this.txtDiaChi.TabIndex = 6;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Location = new System.Drawing.Point(6, 351);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(139, 22);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(6, 262);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(139, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(6, 173);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(139, 22);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblTenDaiLy
            // 
            this.lblTenDaiLy.Location = new System.Drawing.Point(6, 84);
            this.lblTenDaiLy.Name = "lblTenDaiLy";
            this.lblTenDaiLy.Size = new System.Drawing.Size(139, 22);
            this.lblTenDaiLy.TabIndex = 1;
            this.lblTenDaiLy.Text = "Tên Đại Lý:";
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
            this.tbPhai.Controls.Add(this.grpTimKiemDaiLy, 0, 0);
            this.tbPhai.Controls.Add(this.grpDSDaiLy, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(400, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbPhai.Size = new System.Drawing.Size(591, 626);
            this.tbPhai.TabIndex = 1;
            // 
            // grpTimKiemDaiLy
            // 
            this.grpTimKiemDaiLy.Controls.Add(this.txtTimKiemDaiLy);
            this.grpTimKiemDaiLy.Controls.Add(this.lblTimKiemDaiLy);
            this.grpTimKiemDaiLy.Controls.Add(this.btnTimKiem);
            this.grpTimKiemDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimKiemDaiLy.Location = new System.Drawing.Point(3, 3);
            this.grpTimKiemDaiLy.Name = "grpTimKiemDaiLy";
            this.grpTimKiemDaiLy.Size = new System.Drawing.Size(585, 119);
            this.grpTimKiemDaiLy.TabIndex = 0;
            this.grpTimKiemDaiLy.TabStop = false;
            this.grpTimKiemDaiLy.Text = "Tìm Kiếm Đại Lý";
            // 
            // txtTimKiemDaiLy
            // 
            this.txtTimKiemDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemDaiLy.Location = new System.Drawing.Point(180, 49);
            this.txtTimKiemDaiLy.Name = "txtTimKiemDaiLy";
            this.txtTimKiemDaiLy.Size = new System.Drawing.Size(196, 34);
            this.txtTimKiemDaiLy.TabIndex = 6;
            // 
            // lblTimKiemDaiLy
            // 
            this.lblTimKiemDaiLy.Location = new System.Drawing.Point(14, 52);
            this.lblTimKiemDaiLy.Name = "lblTimKiemDaiLy";
            this.lblTimKiemDaiLy.Size = new System.Drawing.Size(160, 23);
            this.lblTimKiemDaiLy.TabIndex = 5;
            this.lblTimKiemDaiLy.Text = "Mã Đại Lý:";
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
            // grpDSDaiLy
            // 
            this.grpDSDaiLy.Controls.Add(this.dgvDSDaiLy);
            this.grpDSDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSDaiLy.Location = new System.Drawing.Point(3, 128);
            this.grpDSDaiLy.Name = "grpDSDaiLy";
            this.grpDSDaiLy.Size = new System.Drawing.Size(585, 495);
            this.grpDSDaiLy.TabIndex = 1;
            this.grpDSDaiLy.TabStop = false;
            this.grpDSDaiLy.Text = "Danh Sách Đại Lý";
            // 
            // dgvDSDaiLy
            // 
            this.dgvDSDaiLy.AllowUserToAddRows = false;
            this.dgvDSDaiLy.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDaiLy,
            this.colTenDaiLy,
            this.colDiaChi,
            this.colEmail,
            this.colSoDienThoai});
            this.dgvDSDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDaiLy.Location = new System.Drawing.Point(3, 30);
            this.dgvDSDaiLy.Name = "dgvDSDaiLy";
            this.dgvDSDaiLy.RowHeadersWidth = 51;
            this.dgvDSDaiLy.Size = new System.Drawing.Size(579, 462);
            this.dgvDSDaiLy.TabIndex = 0;
            // 
            // colMaDaiLy
            // 
            this.colMaDaiLy.HeaderText = "Mã Đại Lý";
            this.colMaDaiLy.MinimumWidth = 6;
            this.colMaDaiLy.Name = "colMaDaiLy";
            this.colMaDaiLy.Width = 125;
            // 
            // colTenDaiLy
            // 
            this.colTenDaiLy.HeaderText = "Tên Đại Lý";
            this.colTenDaiLy.MinimumWidth = 6;
            this.colTenDaiLy.Name = "colTenDaiLy";
            this.colTenDaiLy.ReadOnly = true;
            this.colTenDaiLy.Width = 125;
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 125;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.HeaderText = "Số Điện Thoại";
            this.colSoDienThoai.MinimumWidth = 6;
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            this.colSoDienThoai.Width = 150;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(994, 112);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "QUẢN LÝ ĐẠI LÝ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "usDaiLy";
            this.Size = new System.Drawing.Size(1000, 750);
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThi.ResumeLayout(false);
            this.tbTrai.ResumeLayout(false);
            this.grpTTDaiLy.ResumeLayout(false);
            this.grpTTDaiLy.PerformLayout();
            this.grpTacVu.ResumeLayout(false);
            this.tbPhai.ResumeLayout(false);
            this.grpTimKiemDaiLy.ResumeLayout(false);
            this.grpTimKiemDaiLy.PerformLayout();
            this.grpDSDaiLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDaiLy)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbHienThi;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.GroupBox grpTTDaiLy;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.GroupBox grpTimKiemDaiLy;
        private System.Windows.Forms.GroupBox grpDSDaiLy;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenDaiLy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiemDaiLy;
        private System.Windows.Forms.Label lblTimKiemDaiLy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSDaiLy;
        private DataGridViewTextBoxColumn colMaDaiLy;
        private DataGridViewTextBoxColumn colTenDaiLy;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colSoDienThoai;
    }
}
