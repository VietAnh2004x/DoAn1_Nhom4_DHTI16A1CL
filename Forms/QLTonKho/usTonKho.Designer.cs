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
            panel1 = new Panel();
            tbTong = new TableLayoutPanel();
            grpTTHoaDon = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            grTTXe = new GroupBox();
            txtSoLuong = new TextBox();
            txtNgayNhap = new TextBox();
            txtTenXe = new TextBox();
            lblSoLuong = new Label();
            lblNgayNhap = new Label();
            lblTenXe = new Label();
            tbPhai = new TableLayoutPanel();
            grpTimKiemXe = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTimKiemMaXe = new Label();
            txtTimKiemMaXe = new TextBox();
            btnTimKiem = new Button();
            grDSXe = new GroupBox();
            dgvDSTonKho = new DataGridView();
            lblTieuDe = new Label();
            panel1.SuspendLayout();
            tbTong.SuspendLayout();
            grpTTHoaDon.SuspendLayout();
            tbTrai.SuspendLayout();
            grTTXe.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemXe.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grDSXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSTonKho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            tbTrai.Controls.Add(grTTXe, 0, 0);
            tbTrai.Dock = DockStyle.Fill;
            tbTrai.Location = new Point(3, 3);
            tbTrai.Name = "tbTrai";
            tbTrai.RowCount = 1;
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTrai.Size = new Size(391, 626);
            tbTrai.TabIndex = 0;
            // 
            // grTTXe
            // 
            grTTXe.Controls.Add(txtSoLuong);
            grTTXe.Controls.Add(txtNgayNhap);
            grTTXe.Controls.Add(txtTenXe);
            grTTXe.Controls.Add(lblSoLuong);
            grTTXe.Controls.Add(lblNgayNhap);
            grTTXe.Controls.Add(lblTenXe);
            grTTXe.Dock = DockStyle.Fill;
            grTTXe.Location = new Point(3, 3);
            grTTXe.Name = "grTTXe";
            grTTXe.Size = new Size(385, 620);
            grTTXe.TabIndex = 0;
            grTTXe.TabStop = false;
            grTTXe.Text = "Thông Tin Xe";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(176, 295);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(139, 25);
            txtSoLuong.TabIndex = 9;
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.BorderStyle = BorderStyle.FixedSingle;
            txtNgayNhap.Location = new Point(176, 195);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.Size = new Size(139, 25);
            txtNgayNhap.TabIndex = 8;
            // 
            // txtTenXe
            // 
            txtTenXe.BorderStyle = BorderStyle.FixedSingle;
            txtTenXe.Location = new Point(176, 95);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(139, 25);
            txtTenXe.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(18, 297);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(127, 22);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.Location = new Point(18, 197);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(127, 22);
            lblNgayNhap.TabIndex = 3;
            lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblTenXe
            // 
            lblTenXe.Location = new Point(18, 97);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(127, 22);
            lblTenXe.TabIndex = 2;
            lblTenXe.Text = "Tên Xe:";
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tbPhai.Controls.Add(grpTimKiemXe, 0, 0);
            tbPhai.Controls.Add(grDSXe, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(400, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(591, 626);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemXe
            // 
            grpTimKiemXe.Controls.Add(tableLayoutPanel1);
            grpTimKiemXe.Dock = DockStyle.Fill;
            grpTimKiemXe.Location = new Point(3, 3);
            grpTimKiemXe.Name = "grpTimKiemXe";
            grpTimKiemXe.Size = new Size(585, 119);
            grpTimKiemXe.TabIndex = 0;
            grpTimKiemXe.TabStop = false;
            grpTimKiemXe.Text = "Tìm Kiếm Xe";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(lblTimKiemMaXe, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTimKiemMaXe, 1, 0);
            tableLayoutPanel1.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(579, 95);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTimKiemMaXe
            // 
            lblTimKiemMaXe.Anchor = AnchorStyles.None;
            lblTimKiemMaXe.Location = new Point(6, 36);
            lblTimKiemMaXe.Name = "lblTimKiemMaXe";
            lblTimKiemMaXe.Size = new Size(160, 23);
            lblTimKiemMaXe.TabIndex = 11;
            lblTimKiemMaXe.Text = "Mã Xe:";
            // 
            // txtTimKiemMaXe
            // 
            txtTimKiemMaXe.Anchor = AnchorStyles.None;
            txtTimKiemMaXe.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemMaXe.Location = new Point(190, 35);
            txtTimKiemMaXe.Name = "txtTimKiemMaXe";
            txtTimKiemMaXe.Size = new Size(196, 25);
            txtTimKiemMaXe.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(441, 30);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 35);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grDSXe
            // 
            grDSXe.Controls.Add(dgvDSTonKho);
            grDSXe.Dock = DockStyle.Fill;
            grDSXe.Location = new Point(3, 128);
            grDSXe.Name = "grDSXe";
            grDSXe.Size = new Size(585, 495);
            grDSXe.TabIndex = 1;
            grDSXe.TabStop = false;
            grDSXe.Text = "Danh Sách Xe";
            // 
            // dgvDSTonKho
            // 
            dgvDSTonKho.AllowUserToAddRows = false;
            dgvDSTonKho.BackgroundColor = Color.White;
            dgvDSTonKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTonKho.Dock = DockStyle.Fill;
            dgvDSTonKho.Location = new Point(3, 21);
            dgvDSTonKho.Name = "dgvDSTonKho";
            dgvDSTonKho.RowHeadersWidth = 51;
            dgvDSTonKho.Size = new Size(579, 471);
            dgvDSTonKho.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.Location = new Point(3, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(994, 112);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "QUẢN LÝ TỒN KHO";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usTonKho
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            BackColor = Color.FromArgb(255, 255, 230);
            Name = "usTonKho";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbTong.ResumeLayout(false);
            grpTTHoaDon.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grTTXe.ResumeLayout(false);
            grTTXe.PerformLayout();
            tbPhai.ResumeLayout(false);
            grpTimKiemXe.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            grDSXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSTonKho).EndInit();
            ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgvDSTonKho;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTimKiemMaXe;
        private TextBox txtTimKiemMaXe;
        private Button btnTimKiem;
    }
}
