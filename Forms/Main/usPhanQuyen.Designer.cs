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
            dgvTaiKhoan.Location = new Point(192, 125);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(774, 220);
            dgvTaiKhoan.TabIndex = 0;
            dgvTaiKhoan.SelectionChanged += dgvTaiKhoan_SelectionChanged;
            // 
            // lblChon
            // 
            lblChon.AutoSize = true;
            lblChon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChon.Location = new Point(110, 404);
            lblChon.Name = "lblChon";
            lblChon.Size = new Size(147, 23);
            lblChon.TabIndex = 1;
            lblChon.Text = "Chọn quyền mới:";
            // 
            // cboQuyen
            // 
            cboQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyen.Font = new Font("Segoe UI", 10F);
            cboQuyen.FormattingEnabled = true;
            cboQuyen.Location = new Point(322, 400);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(228, 31);
            cboQuyen.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCapNhat.Location = new Point(677, 400);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(194, 31);
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
            label1.Location = new Point(406, 42);
            label1.Name = "label1";
            label1.Size = new Size(366, 46);
            label1.TabIndex = 4;
            label1.Text = "Phân quyền tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 484);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 5;
            label2.Text = "Tên tài khoản";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(246, 480);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(250, 27);
            txtTenTaiKhoan.TabIndex = 6;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoNam.Location = new Point(246, 672);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(69, 27);
            rdoNam.TabIndex = 8;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(656, 577);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(860, 499);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(656, 499);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoNu.Location = new Point(381, 672);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(55, 27);
            rdoNu.TabIndex = 12;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 533);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 13;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(111, 630);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 14;
            label4.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(110, 583);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 15;
            label5.Text = "Mã NV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(106, 674);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 16;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(106, 727);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 17;
            label7.Text = "Ngày sinh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(106, 777);
            label8.Name = "label8";
            label8.Size = new Size(43, 23);
            label8.TabIndex = 18;
            label8.Text = "SĐT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(606, 676);
            label9.Name = "label9";
            label9.Size = new Size(54, 23);
            label9.TabIndex = 19;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(556, 740);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 20;
            label10.Text = "Ngày vào làm";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(246, 722);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 21;
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Format = DateTimePickerFormat.Custom;
            dtpNgayVaoLam.Location = new Point(728, 736);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(250, 27);
            dtpNgayVaoLam.TabIndex = 22;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(246, 626);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 23;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(246, 575);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(250, 27);
            txtMaNV.TabIndex = 24;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(246, 529);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(250, 27);
            txtMatKhau.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(728, 676);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 26;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(246, 770);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 27);
            txtSDT.TabIndex = 27;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(860, 576);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 31);
            btnLamMoi.TabIndex = 28;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // usPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Name = "usPhanQuyen";
            Size = new Size(1198, 945);
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