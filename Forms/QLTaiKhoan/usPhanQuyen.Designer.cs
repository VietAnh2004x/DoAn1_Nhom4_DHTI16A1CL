namespace DoAn.Forms.Main
{
    partial class usPhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
     
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblChon;
        private Label label1;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTaiKhoan = new DataGridView();
            lblChon = new Label();
            cboQuyen = new ComboBox();
            btnCapNhat = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTenTaiKhoan = new TextBox();
            rdoNam = new RadioButton();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            rdoNu = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtpNgaySinh = new DateTimePicker();
            dtpNgayVaoLam = new DateTimePicker();
            txtHoTen = new TextBox();
            txtMaNV = new TextBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Location = new Point(168, 94);
            dgvTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(677, 165);
            dgvTaiKhoan.TabIndex = 0;
            dgvTaiKhoan.SelectionChanged += dgvTaiKhoan_SelectionChanged;
            // 
            // lblChon
            // 
            lblChon.AutoSize = true;
            lblChon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChon.Location = new Point(96, 303);
            lblChon.Name = "lblChon";
            lblChon.Size = new Size(122, 19);
            lblChon.TabIndex = 1;
            lblChon.Text = "Chọn quyền mới:";
            // 
            // cboQuyen
            // 
            cboQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyen.Font = new Font("Segoe UI", 10F);
            cboQuyen.FormattingEnabled = true;
            cboQuyen.Location = new Point(265, 301);
            cboQuyen.Margin = new Padding(3, 2, 3, 2);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(200, 25);
            cboQuyen.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCapNhat.Location = new Point(612, 296);
            btnCapNhat.Margin = new Padding(3, 2, 3, 2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(170, 32);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật quyền";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(355, 32);
            label1.Name = "label1";
            label1.Size = new Size(294, 37);
            label1.TabIndex = 4;
            label1.Text = "Phân quyền tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 350);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 5;
            label2.Text = "Tên tài khoản";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(215, 350);
            txtTenTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(219, 23);
            txtTenTaiKhoan.TabIndex = 6;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoNam.Location = new Point(216, 536);
            rdoNam.Margin = new Padding(3, 2, 3, 2);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(59, 23);
            rdoNam.TabIndex = 8;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(574, 433);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 33);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(752, 361);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 31);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(574, 361);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 31);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoNu.Location = new Point(334, 536);
            rdoNu.Margin = new Padding(3, 2, 3, 2);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(47, 23);
            rdoNu.TabIndex = 12;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 397);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 13;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(97, 491);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 14;
            label4.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(97, 444);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 15;
            label5.Text = "Mã NV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(97, 538);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 16;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(97, 585);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 17;
            label7.Text = "Ngày sinh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(97, 632);
            label8.Name = "label8";
            label8.Size = new Size(35, 19);
            label8.TabIndex = 18;
            label8.Text = "SĐT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(510, 511);
            label9.Name = "label9";
            label9.Size = new Size(45, 19);
            label9.TabIndex = 19;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(510, 585);
            label10.Name = "label10";
            label10.Size = new Size(103, 19);
            label10.TabIndex = 20;
            label10.Text = "Ngày vào làm";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(215, 582);
            dtpNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(219, 23);
            dtpNgaySinh.TabIndex = 21;
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Format = DateTimePickerFormat.Custom;
            dtpNgayVaoLam.Location = new Point(648, 582);
            dtpNgayVaoLam.Margin = new Padding(3, 2, 3, 2);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(219, 23);
            dtpNgayVaoLam.TabIndex = 22;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(215, 491);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(219, 23);
            txtHoTen.TabIndex = 23;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(215, 444);
            txtMaNV.Margin = new Padding(3, 2, 3, 2);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(219, 23);
            txtMaNV.TabIndex = 24;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(215, 397);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(219, 23);
            txtMatKhau.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(648, 511);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 26;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(215, 632);
            txtSDT.Margin = new Padding(3, 2, 3, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(219, 23);
            txtSDT.TabIndex = 27;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(752, 432);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(82, 34);
            btnLamMoi.TabIndex = 28;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // usPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLamMoi);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtMatKhau);
            Controls.Add(txtMaNV);
            Controls.Add(txtHoTen);
            Controls.Add(dtpNgayVaoLam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rdoNu);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(rdoNam);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCapNhat);
            Controls.Add(cboQuyen);
            Controls.Add(lblChon);
            Controls.Add(dgvTaiKhoan);
            Margin = new Padding(3, 2, 3, 2);
            Name = "usPhanQuyen";
            Size = new Size(1048, 709);
            Load += usPhanQuyen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label2;
        private TextBox txtTenTaiKhoan;
        private RadioButton rdoNam;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private RadioButton rdoNu;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpNgaySinh;
        private DateTimePicker dtpNgayVaoLam;
        private TextBox txtHoTen;
        private TextBox txtMaNV;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private Button btnLamMoi;
    }
}