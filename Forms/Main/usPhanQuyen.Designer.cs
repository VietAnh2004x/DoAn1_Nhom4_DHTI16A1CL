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
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Location = new Point(214, 125);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(585, 220);
            dgvTaiKhoan.TabIndex = 0;
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
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(367, 56);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 4;
            label1.Text = "Phân quyền tài khoản";
            // 
            // usPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnCapNhat);
            Controls.Add(cboQuyen);
            Controls.Add(lblChon);
            Controls.Add(dgvTaiKhoan);
            Name = "usPhanQuyen";
            Size = new Size(1041, 535);
            Load += usPhanQuyen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}