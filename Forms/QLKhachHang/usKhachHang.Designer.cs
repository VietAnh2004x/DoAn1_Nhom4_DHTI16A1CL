using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLKhachHang
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
            tbTong = new TableLayoutPanel();
            lblTieuDe = new Label();
            tbHienThiChung = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            grpTTKhachHang = new GroupBox();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            lblHoTen = new Label();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            grpTacVu = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            tbPhai = new TableLayoutPanel();
            grpTimKiemKhachHang = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTimKiemKhachHang = new Label();
            txtTimKiemKhachHang = new TextBox();
            btnTimKiem = new Button();
            grpDSKhachHang = new GroupBox();
            dgvDSKhachHang = new DataGridView();
            panel1.SuspendLayout();
            tbTong.SuspendLayout();
            tbHienThiChung.SuspendLayout();
            tbTrai.SuspendLayout();
            grpTTKhachHang.SuspendLayout();
            grpTacVu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tbPhai.SuspendLayout();
            grpTimKiemKhachHang.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpDSKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSKhachHang).BeginInit();
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
            tbTong.Controls.Add(lblTieuDe, 0, 0);
            tbTong.Controls.Add(tbHienThiChung, 0, 1);
            tbTong.Dock = DockStyle.Fill;
            tbTong.Location = new Point(0, 0);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 2;
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tbTong.Size = new Size(1000, 750);
            tbTong.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.Location = new Point(3, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(994, 112);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÍ KHÁCH HÀNG";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbHienThiChung
            // 
            tbHienThiChung.ColumnCount = 2;
            tbHienThiChung.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tbHienThiChung.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tbHienThiChung.Controls.Add(tbTrai, 0, 0);
            tbHienThiChung.Controls.Add(tbPhai, 1, 0);
            tbHienThiChung.Dock = DockStyle.Fill;
            tbHienThiChung.Location = new Point(3, 115);
            tbHienThiChung.Name = "tbHienThiChung";
            tbHienThiChung.RowCount = 1;
            tbHienThiChung.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbHienThiChung.Size = new Size(994, 632);
            tbHienThiChung.TabIndex = 1;
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
            tbTrai.Size = new Size(391, 626);
            tbTrai.TabIndex = 0;
            // 
            // grpTTKhachHang
            // 
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
            grpTTKhachHang.Size = new Size(385, 463);
            grpTTKhachHang.TabIndex = 0;
            grpTTKhachHang.TabStop = false;
            grpTTKhachHang.Text = "Thông tin khách hàng";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(170, 333);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 25);
            txtEmail.TabIndex = 10;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Location = new Point(170, 250);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(154, 25);
            txtSoDienThoai.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(170, 84);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(154, 25);
            txtHoTen.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(170, 167);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(154, 25);
            txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(6, 169);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 23);
            lblDiaChi.TabIndex = 5;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(6, 86);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Location = new Point(6, 252);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(121, 23);
            lblSoDienThoai.TabIndex = 3;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(6, 335);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
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
            grpTacVu.Text = "Tác vụ";
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
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(379, 127);
            tableLayoutPanel1.TabIndex = 0;
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
            btnLamMoi.Location = new Point(240, 79);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(88, 32);
            btnLamMoi.TabIndex = 14;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
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
            btnThem.Location = new Point(50, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(88, 32);
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
            btnXoa.Location = new Point(50, 79);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(88, 32);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
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
            btnSua.Location = new Point(240, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(88, 32);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbPhai.Controls.Add(grpTimKiemKhachHang, 0, 0);
            tbPhai.Controls.Add(grpDSKhachHang, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(400, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbPhai.Size = new Size(591, 626);
            tbPhai.TabIndex = 1;
            // 
            // grpTimKiemKhachHang
            // 
            grpTimKiemKhachHang.Controls.Add(tableLayoutPanel2);
            grpTimKiemKhachHang.Dock = DockStyle.Fill;
            grpTimKiemKhachHang.Location = new Point(3, 3);
            grpTimKiemKhachHang.Name = "grpTimKiemKhachHang";
            grpTimKiemKhachHang.Size = new Size(585, 119);
            grpTimKiemKhachHang.TabIndex = 0;
            grpTimKiemKhachHang.TabStop = false;
            grpTimKiemKhachHang.Text = "Tìm kiếm khách hàng";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(lblTimKiemKhachHang, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTimKiemKhachHang, 1, 0);
            tableLayoutPanel2.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 21);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(579, 95);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTimKiemKhachHang
            // 
            lblTimKiemKhachHang.Anchor = AnchorStyles.None;
            lblTimKiemKhachHang.Location = new Point(6, 36);
            lblTimKiemKhachHang.Name = "lblTimKiemKhachHang";
            lblTimKiemKhachHang.Size = new Size(160, 23);
            lblTimKiemKhachHang.TabIndex = 11;
            lblTimKiemKhachHang.Text = "Mã khách hàng:";
            // 
            // txtTimKiemKhachHang
            // 
            txtTimKiemKhachHang.Anchor = AnchorStyles.None;
            txtTimKiemKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemKhachHang.Location = new Point(190, 35);
            txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            txtTimKiemKhachHang.Size = new Size(196, 25);
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
            btnTimKiem.Location = new Point(440, 30);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(102, 35);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // grpDSKhachHang
            // 
            grpDSKhachHang.Controls.Add(dgvDSKhachHang);
            grpDSKhachHang.Dock = DockStyle.Fill;
            grpDSKhachHang.Location = new Point(3, 128);
            grpDSKhachHang.Name = "grpDSKhachHang";
            grpDSKhachHang.Size = new Size(585, 495);
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
            dgvDSKhachHang.Location = new Point(3, 21);
            dgvDSKhachHang.Name = "dgvDSKhachHang";
            dgvDSKhachHang.RowHeadersWidth = 51;
            dgvDSKhachHang.Size = new Size(579, 471);
            dgvDSKhachHang.TabIndex = 0;
            // 
            // usKhachHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "usKhachHang";
            Size = new Size(1000, 750);
            panel1.ResumeLayout(false);
            tbTong.ResumeLayout(false);
            tbHienThiChung.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            grpTTKhachHang.ResumeLayout(false);
            grpTTKhachHang.PerformLayout();
            grpTacVu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            grpTimKiemKhachHang.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grpDSKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSKhachHang).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiChung;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.GroupBox grpTTKhachHang;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.GroupBox grpTimKiemKhachHang;
        private System.Windows.Forms.GroupBox grpDSKhachHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvDSKhachHang;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTimKiemKhachHang;
        private TextBox txtTimKiemKhachHang;
        private Button btnTimKiem;
    }
}
