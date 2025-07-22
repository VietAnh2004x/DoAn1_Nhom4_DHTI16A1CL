using System.Windows.Forms;
using System.Drawing;

namespace DoAn.Forms.QLTonKho
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
            grpTacVu = new GroupBox();
            tbTacVu = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
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
            grpTacVu.SuspendLayout();
            tbTacVu.SuspendLayout();
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
            tbTrai.Controls.Add(grpTacVu, 0, 1);
            tbTrai.Controls.Add(grTTXe, 0, 0);
            tbTrai.Dock = DockStyle.Fill;
            tbTrai.Location = new Point(3, 3);
            tbTrai.Name = "tbTrai";
            tbTrai.RowCount = 2;
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbTrai.Size = new Size(394, 744);
            tbTrai.TabIndex = 0;
            // 
            // grpTacVu
            // 
            grpTacVu.Controls.Add(tbTacVu);
            grpTacVu.Dock = DockStyle.Fill;
            grpTacVu.Location = new Point(3, 561);
            grpTacVu.Name = "grpTacVu";
            grpTacVu.Size = new Size(388, 180);
            grpTacVu.TabIndex = 2;
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
            tbTacVu.Location = new Point(3, 21);
            tbTacVu.Name = "tbTacVu";
            tbTacVu.RowCount = 2;
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTacVu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbTacVu.Size = new Size(382, 156);
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
            btnLamMoi.Location = new Point(233, 98);
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
            btnThem.Location = new Point(42, 20);
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
            btnXoa.Location = new Point(42, 98);
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
            btnSua.Location = new Point(233, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            txtMaXe.Location = new Point(179, 60);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(168, 25);
            txtMaXe.TabIndex = 15;
            txtMaXe.Leave += txtMaXe_Leave;
            // 
            // label1
            // 
            label1.Location = new Point(6, 62);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 14;
            label1.Text = "Mã Xe:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(179, 249);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(168, 25);
            dtpNgayNhap.TabIndex = 13;
            // 
            // txtDongianhap
            // 
            txtDongianhap.BorderStyle = BorderStyle.FixedSingle;
            txtDongianhap.Location = new Point(179, 440);
            txtDongianhap.Name = "txtDongianhap";
            txtDongianhap.Size = new Size(168, 25);
            txtDongianhap.TabIndex = 12;
            // 
            // lblDonGiaNhap
            // 
            lblDonGiaNhap.AutoSize = true;
            lblDonGiaNhap.Location = new Point(6, 442);
            lblDonGiaNhap.Name = "lblDonGiaNhap";
            lblDonGiaNhap.Size = new Size(92, 19);
            lblDonGiaNhap.TabIndex = 10;
            lblDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(179, 347);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(168, 25);
            txtSoLuong.TabIndex = 9;
            // 
            // txtTenXe
            // 
            txtTenXe.BorderStyle = BorderStyle.FixedSingle;
            txtTenXe.Location = new Point(179, 158);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(168, 25);
            txtTenXe.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(6, 349);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(127, 25);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.Location = new Point(6, 255);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(127, 26);
            lblNgayNhap.TabIndex = 3;
            lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblTenXe
            // 
            lblTenXe.Location = new Point(6, 160);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(127, 27);
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
            tbTimKiem.Controls.Add(txtTimKiem, 1, 0);
            tbTimKiem.Controls.Add(btnTimKiem, 2, 0);
            tbTimKiem.Controls.Add(lblTimKiemMaXe, 0, 0);
            tbTimKiem.Dock = DockStyle.Fill;
            tbTimKiem.Location = new Point(3, 21);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.RowCount = 1;
            tbTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbTimKiem.Size = new Size(582, 118);
            tbTimKiem.TabIndex = 0;
            // 
            // lblTimKiemMaXe
            // 
            lblTimKiemMaXe.Anchor = AnchorStyles.None;
            lblTimKiemMaXe.Location = new Point(7, 47);
            lblTimKiemMaXe.Name = "lblTimKiemMaXe";
            lblTimKiemMaXe.Size = new Size(160, 23);
            lblTimKiemMaXe.TabIndex = 11;
            lblTimKiemMaXe.Text = "Mã Xe:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(192, 46);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(196, 25);
            txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(437, 41);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 36);
            btnTimKiem.TabIndex = 14;
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
            grDSXe.Text = "Danh Sách Tồn Kho";
            // 
            // dgvDSTonKho
            // 
            dgvDSTonKho.AllowUserToAddRows = false;
            dgvDSTonKho.AllowUserToDeleteRows = false;
            dgvDSTonKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTonKho.Dock = DockStyle.Fill;
            dgvDSTonKho.Location = new Point(3, 21);
            dgvDSTonKho.Name = "dgvDSTonKho";
            dgvDSTonKho.ReadOnly = true;
            dgvDSTonKho.RowHeadersWidth = 62;
            dgvDSTonKho.RowTemplate.Height = 28;
            dgvDSTonKho.Size = new Size(582, 566);
            dgvDSTonKho.TabIndex = 0;
            dgvDSTonKho.CellContentClick += dgvDSTonKho_CellClick;
            // 
            // usTonKho
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            Name = "usTonKho";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            grpTTHoaDon.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grpTacVu.ResumeLayout(false);
            tbTacVu.ResumeLayout(false);
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
        private DateTimePicker dtpNgayNhap;
        private TextBox txtMaXe;
        private Label label1;
        private GroupBox grpTacVu;
        private TableLayoutPanel tbTacVu;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
