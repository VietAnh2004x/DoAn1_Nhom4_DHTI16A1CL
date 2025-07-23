using DoAn;
using DoAn.Data_Transfer_Objects;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace DoAn.Forms.QLDangNhap
{
     public partial class frmDangNhap : Form
    {
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;     
        private Button btnLogin;
        private LinkLabel linkForgot;
        private CheckBox chkShowPass;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            picLogo = new PictureBox();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPass = new CheckBox();
            btnLogin = new Button();
            linkForgot = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.BackColor = Color.FromArgb(240, 248, 255);
            picLogo.Location = new Point(165, 23);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(150, 150);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(2, 187);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(482, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ĐĂNG NHẬP";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(48, 240);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(114, 21);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(48, 270);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(380, 29);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(48, 320);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(48, 350);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(380, 29);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Segoe UI", 10F);
            chkShowPass.Location = new Point(48, 385);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(118, 23);
            chkShowPass.TabIndex = 6;
            chkShowPass.Text = "Hiện mật khẩu";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(48, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(380, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkForgot
            // 
            linkForgot.ActiveLinkColor = Color.Red;
            linkForgot.AutoSize = true;
            linkForgot.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            linkForgot.LinkColor = Color.FromArgb(0, 102, 204);
            linkForgot.Location = new Point(48, 480);
            linkForgot.Name = "linkForgot";
            linkForgot.Size = new Size(113, 19);
            linkForgot.TabIndex = 8;
            linkForgot.TabStop = true;
            linkForgot.Text = "Quên mật khẩu?";
            // 
            // frmDangNhap
            // 
            AcceptButton = btnLogin;
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(484, 561);
            Controls.Add(picLogo);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPass);
            Controls.Add(btnLogin);
            Controls.Add(linkForgot);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}