using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLTonKho
{
    partial class usTonKho
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
            this.grpTTHoaDon = new System.Windows.Forms.TableLayoutPanel();
            this.tbTrai = new System.Windows.Forms.TableLayoutPanel();
            this.grTTXe = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTimKiemXe = new System.Windows.Forms.GroupBox();
            this.txtTimKiemMaXe = new System.Windows.Forms.TextBox();
            this.lblTimKiemMaXe = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grDSXe = new System.Windows.Forms.GroupBox();
            this.dgvDSTonKho = new System.Windows.Forms.DataGridView();
            this.colMaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.grpTTHoaDon.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grTTXe.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grpTimKiemXe.SuspendLayout();
            this.grDSXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
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
            this.tbTong.Controls.Add(this.grpTTHoaDon, 0, 1);
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
            // grpTTHoaDon
            // 
            this.grpTTHoaDon.ColumnCount = 2;
            this.grpTTHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.grpTTHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.grpTTHoaDon.Controls.Add(this.tbTrai, 0, 0);
            this.grpTTHoaDon.Controls.Add(this.tbPhai, 1, 0);
            this.grpTTHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTHoaDon.Location = new System.Drawing.Point(3, 115);
            this.grpTTHoaDon.Name = "grpTTHoaDon";
            this.grpTTHoaDon.RowCount = 1;
            this.grpTTHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 632F));
            this.grpTTHoaDon.Size = new System.Drawing.Size(994, 632);
            this.grpTTHoaDon.TabIndex = 0;
            // 
            // tbTrai
            // 
            this.tbTrai.ColumnCount = 1;
            this.tbTrai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tbTrai.Controls.Add(this.grTTXe, 0, 0);
            this.tbTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrai.Location = new System.Drawing.Point(3, 3);
            this.tbTrai.Name = "tbTrai";
            this.tbTrai.RowCount = 1;
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbTrai.Size = new System.Drawing.Size(391, 626);
            this.tbTrai.TabIndex = 0;
            // 
            // grTTXe
            // 
            this.grTTXe.Controls.Add(this.txtSoLuong);
            this.grTTXe.Controls.Add(this.txtNgayNhap);
            this.grTTXe.Controls.Add(this.txtTenXe);
            this.grTTXe.Controls.Add(this.lblSoLuong);
            this.grTTXe.Controls.Add(this.lblNgayNhap);
            this.grTTXe.Controls.Add(this.lblTenXe);
            this.grTTXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTXe.Location = new System.Drawing.Point(3, 3);
            this.grTTXe.Name = "grTTXe";
            this.grTTXe.Size = new System.Drawing.Size(385, 620);
            this.grTTXe.TabIndex = 0;
            this.grTTXe.TabStop = false;
            this.grTTXe.Text = "Thông Tin Xe";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(176, 295);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(139, 34);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayNhap.Location = new System.Drawing.Point(176, 195);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(139, 34);
            this.txtNgayNhap.TabIndex = 8;
            // 
            // txtTenXe
            // 
            this.txtTenXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenXe.Location = new System.Drawing.Point(176, 95);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(139, 34);
            this.txtTenXe.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(18, 297);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(127, 22);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Location = new System.Drawing.Point(18, 197);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(127, 22);
            this.lblNgayNhap.TabIndex = 3;
            this.lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblTenXe
            // 
            this.lblTenXe.Location = new System.Drawing.Point(18, 97);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(127, 22);
            this.lblTenXe.TabIndex = 2;
            this.lblTenXe.Text = "Tên Xe:";
            // 
            // tbPhai
            // 
            this.tbPhai.ColumnCount = 1;
            this.tbPhai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.tbPhai.Controls.Add(this.grpTimKiemXe, 0, 0);
            this.tbPhai.Controls.Add(this.grDSXe, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(400, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbPhai.Size = new System.Drawing.Size(591, 626);
            this.tbPhai.TabIndex = 1;
            // 
            // grpTimKiemXe
            // 
            this.grpTimKiemXe.Controls.Add(this.txtTimKiemMaXe);
            this.grpTimKiemXe.Controls.Add(this.lblTimKiemMaXe);
            this.grpTimKiemXe.Controls.Add(this.btnTimKiem);
            this.grpTimKiemXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimKiemXe.Location = new System.Drawing.Point(3, 3);
            this.grpTimKiemXe.Name = "grpTimKiemXe";
            this.grpTimKiemXe.Size = new System.Drawing.Size(585, 119);
            this.grpTimKiemXe.TabIndex = 0;
            this.grpTimKiemXe.TabStop = false;
            this.grpTimKiemXe.Text = "Tìm Kiếm Xe";
            // 
            // txtTimKiemMaXe
            // 
            this.txtTimKiemMaXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemMaXe.Location = new System.Drawing.Point(180, 49);
            this.txtTimKiemMaXe.Name = "txtTimKiemMaXe";
            this.txtTimKiemMaXe.Size = new System.Drawing.Size(196, 34);
            this.txtTimKiemMaXe.TabIndex = 6;
            // 
            // lblTimKiemMaXe
            // 
            this.lblTimKiemMaXe.Location = new System.Drawing.Point(14, 52);
            this.lblTimKiemMaXe.Name = "lblTimKiemMaXe";
            this.lblTimKiemMaXe.Size = new System.Drawing.Size(160, 23);
            this.lblTimKiemMaXe.TabIndex = 5;
            this.lblTimKiemMaXe.Text = "Mã Xe:";
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
            // grDSXe
            // 
            this.grDSXe.Controls.Add(this.dgvDSTonKho);
            this.grDSXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSXe.Location = new System.Drawing.Point(3, 128);
            this.grDSXe.Name = "grDSXe";
            this.grDSXe.Size = new System.Drawing.Size(585, 495);
            this.grDSXe.TabIndex = 1;
            this.grDSXe.TabStop = false;
            this.grDSXe.Text = "Danh Sách Xe";
            // 
            // dgvDSTonKho
            // 
            this.dgvDSTonKho.AllowUserToAddRows = false;
            this.dgvDSTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhap,
            this.colMaXe,
            this.colTenXe,
            this.colNgayNhap,
            this.colSoLuong});
            this.dgvDSTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTonKho.Location = new System.Drawing.Point(3, 30);
            this.dgvDSTonKho.Name = "dgvDSTonKho";
            this.dgvDSTonKho.RowHeadersWidth = 51;
            this.dgvDSTonKho.Size = new System.Drawing.Size(579, 462);
            this.dgvDSTonKho.TabIndex = 0;
            // 
            // colMaNhap
            // 
            this.colMaNhap.HeaderText = "Mã Nhập";
            this.colMaNhap.MinimumWidth = 6;
            this.colMaNhap.Name = "colMaNhap";
            this.colMaNhap.Width = 150;
            // 
            // colMaXe
            // 
            this.colMaXe.HeaderText = "Mã Xe";
            this.colMaXe.MinimumWidth = 6;
            this.colMaXe.Name = "colMaXe";
            this.colMaXe.ReadOnly = true;
            this.colMaXe.Width = 175;
            // 
            // colTenXe
            // 
            this.colTenXe.HeaderText = "Tên Xe";
            this.colTenXe.MinimumWidth = 6;
            this.colTenXe.Name = "colTenXe";
            this.colTenXe.ReadOnly = true;
            this.colTenXe.Width = 175;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.HeaderText = "Ngày Nhập";
            this.colNgayNhap.MinimumWidth = 6;
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            this.colNgayNhap.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 150;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(994, 112);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "QUẢN LÝ TỒN KHO";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "usTonKho";
            this.Size = new System.Drawing.Size(1000, 750);
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.grpTTHoaDon.ResumeLayout(false);
            this.tbTrai.ResumeLayout(false);
            this.grTTXe.ResumeLayout(false);
            this.grTTXe.PerformLayout();
            this.tbPhai.ResumeLayout(false);
            this.grpTimKiemXe.ResumeLayout(false);
            this.grpTimKiemXe.PerformLayout();
            this.grDSXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel grpTTHoaDon;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.GroupBox grTTXe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTimKiemXe;
        private System.Windows.Forms.GroupBox grDSXe;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.TextBox txtTimKiemMaXe;
        private System.Windows.Forms.Label lblTimKiemMaXe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSTonKho;
        private DataGridViewTextBoxColumn colMaNhap;
        private DataGridViewTextBoxColumn colMaXe;
        private DataGridViewTextBoxColumn colTenXe;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colSoLuong;
    }
}
