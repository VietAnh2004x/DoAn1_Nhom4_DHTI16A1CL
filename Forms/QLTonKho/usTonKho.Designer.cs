using System.Windows.Forms;

namespace DoAn1.Forms.QLTonKho
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
            grpTTHoaDon = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            grTTXe = new GroupBox();
            txtTongTienNhap = new TextBox();
            txtDongianhap = new TextBox();
            lblTongTien = new Label();
            lblDonGiaNhap = new Label();
            txtSoLuong = new TextBox();
            txtNgayNhap = new TextBox();
            txtTenXe = new TextBox();
            lblSoLuong = new Label();
            lblNgayNhap = new Label();
            lblTenXe = new Label();
            tbPhai = new TableLayoutPanel();
            grpTimKiemXe = new GroupBox();
            tbTimKiem = new TableLayoutPanel();
            lblTimKiemMaXe = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            grDSXe = new GroupBox();
            dgvDSTonKho = new DataGridView();
            panel1.SuspendLayout();
            grpTTHoaDon.SuspendLayout();
            tbTrai.SuspendLayout();
            grTTXe.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemXe.SuspendLayout();
            tbTimKiem.SuspendLayout();
            grDSXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSTonKho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            tbTrai.Controls.Add(grTTXe, 0, 0);
            tbTrai.Dock = DockStyle.Fill;
            tbTrai.Location = new Point(3, 3);
            tbTrai.Name = "tbTrai";
            tbTrai.RowCount = 1;
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTrai.Size = new Size(394, 744);
            tbTrai.TabIndex = 0;
            // 
            // grTTXe
            // 
            grTTXe.Controls.Add(txtTongTienNhap);
            grTTXe.Controls.Add(txtDongianhap);
            grTTXe.Controls.Add(lblTongTien);
            grTTXe.Controls.Add(lblDonGiaNhap);
            grTTXe.Controls.Add(txtSoLuong);
            grTTXe.Controls.Add(txtNgayNhap);
            grTTXe.Controls.Add(txtTenXe);
            grTTXe.Controls.Add(lblSoLuong);
            grTTXe.Controls.Add(lblNgayNhap);
            grTTXe.Controls.Add(lblTenXe);
            grTTXe.Dock = DockStyle.Fill;
            grTTXe.Location = new Point(3, 3);
            grTTXe.Name = "grTTXe";
            grTTXe.Size = new Size(388, 738);
            grTTXe.TabIndex = 0;
            grTTXe.TabStop = false;
            grTTXe.Text = "Thông Tin Xe";
            // 
            // txtTongTienNhap
            // 
            txtTongTienNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTongTienNhap.Location = new Point(176, 490);
            txtTongTienNhap.Name = "txtTongTienNhap";
            txtTongTienNhap.Size = new Size(168, 30);
            txtTongTienNhap.TabIndex = 13;
            // 
            // txtDongianhap
            // 
            txtDongianhap.BorderStyle = BorderStyle.FixedSingle;
            txtDongianhap.Location = new Point(176, 398);
            txtDongianhap.Name = "txtDongianhap";
            txtDongianhap.Size = new Size(168, 30);
            txtDongianhap.TabIndex = 12;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(18, 492);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(86, 23);
            lblTongTien.TabIndex = 11;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // lblDonGiaNhap
            // 
            lblDonGiaNhap.AutoSize = true;
            lblDonGiaNhap.Location = new Point(18, 400);
            lblDonGiaNhap.Name = "lblDonGiaNhap";
            lblDonGiaNhap.Size = new Size(114, 23);
            lblDonGiaNhap.TabIndex = 10;
            lblDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(176, 297);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(168, 30);
            txtSoLuong.TabIndex = 9;
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.BorderStyle = BorderStyle.FixedSingle;
            txtNgayNhap.Location = new Point(176, 196);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.Size = new Size(168, 30);
            txtNgayNhap.TabIndex = 8;
            // 
            // txtTenXe
            // 
            txtTenXe.BorderStyle = BorderStyle.FixedSingle;
            txtTenXe.Location = new Point(176, 95);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(168, 30);
            txtTenXe.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(18, 299);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(127, 32);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.Location = new Point(18, 198);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(127, 32);
            lblNgayNhap.TabIndex = 3;
            lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblTenXe
            // 
            lblTenXe.Location = new Point(18, 97);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(127, 32);
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
            tbPhai.Location = new Point(403, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(594, 744);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemXe
            // 
            grpTimKiemXe.Controls.Add(tbTimKiem);
            grpTimKiemXe.Dock = DockStyle.Fill;
            grpTimKiemXe.Location = new Point(3, 3);
            grpTimKiemXe.Name = "grpTimKiemXe";
            grpTimKiemXe.Size = new Size(588, 142);
            grpTimKiemXe.TabIndex = 0;
            grpTimKiemXe.TabStop = false;
            grpTimKiemXe.Text = "Tìm Kiếm Xe";
            // 
            // tbTimKiem
            // 
            tbTimKiem.ColumnCount = 3;
            tbTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tbTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tbTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tbTimKiem.Controls.Add(lblTimKiemMaXe, 0, 0);
            tbTimKiem.Controls.Add(txtTimKiem, 1, 0);
            tbTimKiem.Controls.Add(btnTimKiem, 2, 0);
            tbTimKiem.Dock = DockStyle.Fill;
            tbTimKiem.Location = new Point(3, 26);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.RowCount = 1;
            tbTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTimKiem.Size = new Size(582, 113);
            tbTimKiem.TabIndex = 0;
            // 
            // lblTimKiemMaXe
            // 
            lblTimKiemMaXe.Anchor = AnchorStyles.None;
            lblTimKiemMaXe.Location = new Point(7, 45);
            lblTimKiemMaXe.Name = "lblTimKiemMaXe";
            lblTimKiemMaXe.Size = new Size(160, 23);
            lblTimKiemMaXe.TabIndex = 11;
            lblTimKiemMaXe.Text = "Mã Xe:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(192, 41);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(196, 30);
            txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(443, 39);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 35);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // grDSXe
            // 
            grDSXe.Controls.Add(dgvDSTonKho);
            grDSXe.Dock = DockStyle.Fill;
            grDSXe.Location = new Point(3, 151);
            grDSXe.Name = "grDSXe";
            grDSXe.Size = new Size(588, 590);
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
            dgvDSTonKho.Location = new Point(3, 26);
            dgvDSTonKho.Name = "dgvDSTonKho";
            dgvDSTonKho.RowHeadersWidth = 51;
            dgvDSTonKho.Size = new Size(582, 561);
            dgvDSTonKho.TabIndex = 0;
            dgvDSTonKho.CellContentClick += dgvDSTonKho_CellContentClick_1;
            // 
            // usTonKho
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 255, 230);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usTonKho";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            grpTTHoaDon.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grTTXe.ResumeLayout(false);
            grTTXe.PerformLayout();
            tbPhai.ResumeLayout(false);
            grpTimKiemXe.ResumeLayout(false);
            tbTimKiem.ResumeLayout(false);
            tbTimKiem.PerformLayout();
            grDSXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSTonKho).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private TableLayoutPanel grpTTHoaDon;
        private TableLayoutPanel tbTrai;
        private GroupBox grTTXe;
        private TextBox txtSoLuong;
        private TextBox txtNgayNhap;
        private TextBox txtTenXe;
        private Label lblSoLuong;
        private Label lblNgayNhap;
        private Label lblTenXe;
        private TableLayoutPanel tbPhai;
        private GroupBox grpTimKiemXe;
        private TableLayoutPanel tbTimKiem;
        private Label lblTimKiemMaXe;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private GroupBox grDSXe;
        private DataGridView dgvDSTonKho;
        private Label lblDonGiaNhap;
        private TextBox txtTongTienNhap;
        private TextBox txtDongianhap;
        private Label lblTongTien;
    }
}
