using System.Windows.Forms;
using System.Drawing;

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
            txtMaXe = new TextBox();
            label1 = new Label();
            dtpNgayNhap = new DateTimePicker();
            txtDongianhap = new TextBox();
            lblDonGiaNhap = new Label();
            txtSoLuong = new TextBox();
            txtTenXe = new TextBox();
            lblSoLuong = new Label();
            lblNgayNhap = new Label();
            lblTenXe = new Label();
            gtpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
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
            gtpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
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
            tbTrai.Controls.Add(gtpTacVu, 0, 1);
            tbTrai.Dock = DockStyle.Fill;
            tbTrai.Location = new Point(3, 3);
            tbTrai.Name = "tbTrai";
            tbTrai.RowCount = 2;
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbTrai.Size = new Size(394, 744);
            tbTrai.TabIndex = 0;
            // 
            // grTTXe
            // 
            grTTXe.Controls.Add(txtMaXe);
            grTTXe.Controls.Add(label1);
            grTTXe.Controls.Add(dtpNgayNhap);
            grTTXe.Controls.Add(txtDongianhap);
            grTTXe.Controls.Add(lblDonGiaNhap);
            grTTXe.Controls.Add(txtSoLuong);
            grTTXe.Controls.Add(txtTenXe);
            grTTXe.Controls.Add(lblSoLuong);
            grTTXe.Controls.Add(lblNgayNhap);
            grTTXe.Controls.Add(lblTenXe);
            grTTXe.Dock = DockStyle.Fill;
            grTTXe.Location = new Point(3, 3);
            grTTXe.Name = "grTTXe";
            grTTXe.Size = new Size(388, 552);
            grTTXe.TabIndex = 0;
            grTTXe.TabStop = false;
            grTTXe.Text = "Thông Tin Xe";
            // 
            // txtMaXe
            // 
            txtMaXe.BorderStyle = BorderStyle.FixedSingle;
            txtMaXe.Location = new Point(179, 53);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(168, 39);
            txtMaXe.TabIndex = 15;
            txtMaXe.Leave += txtMaXe_Leave;
            // 
            // label1
            // 
            label1.Location = new Point(6, 60);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 14;
            label1.Text = "Mã Xe:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(91, 238);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(306, 39);
            dtpNgayNhap.TabIndex = 13;
            // 
            // txtDongianhap
            // 
            txtDongianhap.BorderStyle = BorderStyle.FixedSingle;
            txtDongianhap.Location = new Point(179, 443);
            txtDongianhap.Name = "txtDongianhap";
            txtDongianhap.Size = new Size(168, 39);
            txtDongianhap.TabIndex = 12;
            // 
            // lblDonGiaNhap
            // 
            lblDonGiaNhap.AutoSize = true;
            lblDonGiaNhap.Location = new Point(6, 450);
            lblDonGiaNhap.Name = "lblDonGiaNhap";
            lblDonGiaNhap.Size = new Size(159, 32);
            lblDonGiaNhap.TabIndex = 10;
            lblDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(179, 342);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(168, 39);
            txtSoLuong.TabIndex = 9;
            // 
            // txtTenXe
            // 
            txtTenXe.BorderStyle = BorderStyle.FixedSingle;
            txtTenXe.Location = new Point(179, 140);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(168, 39);
            txtTenXe.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(6, 342);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(127, 32);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.Location = new Point(0, 243);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(127, 32);
            lblNgayNhap.TabIndex = 3;
            lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblTenXe
            // 
            lblTenXe.Location = new Point(6, 147);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(127, 32);
            lblTenXe.TabIndex = 2;
            lblTenXe.Text = "Tên Xe:";
            // 
            // gtpTacVu
            // 
            gtpTacVu.Controls.Add(tbTacVu);
            gtpTacVu.Dock = DockStyle.Fill;
            gtpTacVu.Location = new Point(3, 561);
            gtpTacVu.Name = "gtpTacVu";
            gtpTacVu.Size = new Size(388, 180);
            gtpTacVu.TabIndex = 1;
            gtpTacVu.TabStop = false;
            gtpTacVu.Text = "Tác Vụ";
            // 
            // tbTacVu
            // 
            tbTacVu.ColumnCount = 4;
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbTacVu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbTacVu.Controls.Add(btnLamMoi, 0, 0);
            tbTacVu.Controls.Add(btnThem, 1, 0);
            tbTacVu.Controls.Add(btnXoa, 2, 0);
            tbTacVu.Controls.Add(btnSua, 3, 0);
            tbTacVu.Dock = DockStyle.Fill;
            tbTacVu.Location = new Point(3, 35);
            tbTacVu.Name = "tbTacVu";
            tbTacVu.RowCount = 1;
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTacVu.Size = new Size(382, 142);
            tbTacVu.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.LightCoral;
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(3, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(89, 136);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click_1;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DodgerBlue;
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(98, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(89, 136);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(193, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(89, 136);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Goldenrod;
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(288, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 136);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            tbTimKiem.Location = new Point(3, 35);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.RowCount = 1;
            tbTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTimKiem.Size = new Size(582, 104);
            tbTimKiem.TabIndex = 0;
            // 
            // lblTimKiemMaXe
            // 
            lblTimKiemMaXe.Anchor = AnchorStyles.None;
            lblTimKiemMaXe.Location = new Point(7, 34);
            lblTimKiemMaXe.Name = "lblTimKiemMaXe";
            lblTimKiemMaXe.Size = new Size(160, 36);
            lblTimKiemMaXe.TabIndex = 11;
            lblTimKiemMaXe.Text = "Mã Xe:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(192, 32);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(196, 39);
            txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(437, 34);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 36);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
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
            grDSXe.Text = "Danh Sách Tồn Kho";
            // 
            // dgvDSTonKho
            // 
            dgvDSTonKho.AllowUserToAddRows = false;
            dgvDSTonKho.AllowUserToDeleteRows = false;
            dgvDSTonKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTonKho.Dock = DockStyle.Fill;
            dgvDSTonKho.Location = new Point(3, 35);
            dgvDSTonKho.Name = "dgvDSTonKho";
            dgvDSTonKho.ReadOnly = true;
            dgvDSTonKho.RowHeadersWidth = 62;
            dgvDSTonKho.RowTemplate.Height = 28;
            dgvDSTonKho.Size = new Size(582, 552);
            dgvDSTonKho.TabIndex = 0;
            dgvDSTonKho.CellContentClick += dgvDSTonKho_CellClick;
            // 
            // usTonKho
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "usTonKho";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            grpTTHoaDon.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grTTXe.ResumeLayout(false);
            grTTXe.PerformLayout();
            gtpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemXe.ResumeLayout(false);
            tbTimKiem.ResumeLayout(false);
            tbTimKiem.PerformLayout();
            grDSXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSTonKho).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private TableLayoutPanel grpTTHoaDon;
        private TableLayoutPanel tbTrai;
        private GroupBox grTTXe;
        private TextBox txtSoLuong;
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
        private TextBox txtDongianhap;
        private GroupBox gtpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtMaXe;
        private Label label1;
    }
}
