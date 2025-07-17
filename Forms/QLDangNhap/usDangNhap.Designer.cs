using DoAn1;
using DoAn1.Data_Transfer_Objects;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace DoAn1.Forms.QLDangNhap
{
     public partial class usDangNhap : Form
    {
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;     
        private Button btnLogin;
        private LinkLabel linkRegister;
        private LinkLabel linkForgot;
        private CheckBox chkShowPass;       

        private void InitializeComponent()
        {
            // === Cài đặt Form ===
            this.Text = "Đăng nhập";
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(240, 248, 255); // Nền xanh nhạt dịu mắt

            // === Logo ===
            picLogo = new PictureBox();       
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.Size = new Size(150, 150);
            picLogo.Location = new Point((this.ClientSize.Width - picLogo.Width) / 2, 30);
            this.Controls.Add(picLogo);

            // === Tiêu đề ===
            lblTitle = new Label();
          
            lblTitle.Text = "ĐĂNG NHẬP";
            lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
         
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point((this.ClientSize.Width - lblTitle.PreferredWidth) / 2, 190);
            this.Controls.Add(lblTitle);

            int leftMargin = 60;
            int textboxWidth = 380;

            // === Label Tên đăng nhập ===
            lblUsername = new Label();
            lblUsername.Text = "Tên đăng nhập:";
            lblUsername.Font = new Font("Segoe UI", 12);
            lblUsername.Location = new Point(leftMargin, 240);
            lblUsername.AutoSize = true;
            this.Controls.Add(lblUsername);

            // === TextBox Tên đăng nhập ===
            txtUsername = new TextBox();
            txtUsername.Font = new Font("Segoe UI", 12);
            txtUsername.Size = new Size(textboxWidth, 30);
            txtUsername.Location = new Point(leftMargin, 270);
            this.Controls.Add(txtUsername);

            // === Label Mật khẩu ===
            lblPassword = new Label();
            lblPassword.Text = "Mật khẩu:";
            lblPassword.Font = new Font("Segoe UI", 12);
            lblPassword.Location = new Point(leftMargin, 320);
            lblPassword.AutoSize = true;
            this.Controls.Add(lblPassword);

            // === TextBox Mật khẩu ===
            txtPassword = new TextBox();
            txtPassword.Font = new Font("Segoe UI", 12);
            txtPassword.Size = new Size(textboxWidth, 30);
            txtPassword.Location = new Point(leftMargin, 350);
            txtPassword.UseSystemPasswordChar = true;
            this.Controls.Add(txtPassword);

            // === Checkbox hiện mật khẩu ===
            chkShowPass = new CheckBox();
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.Font = new Font("Segoe UI", 10);
            chkShowPass.AutoSize = true;
            chkShowPass.Location = new Point(leftMargin + 5, 385);
            //chkShowPass.CheckedChanged += (s, e) =>
            //{
            //    txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
            //};
            this.Controls.Add(chkShowPass);

            // === Nút Đăng nhập ===
            btnLogin = new Button();
            btnLogin.Text = "Đăng nhập";
            btnLogin.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnLogin.Size = new Size(textboxWidth, 45);
            btnLogin.Location = new Point(leftMargin, 420);
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;           
            this.Controls.Add(btnLogin);

            // === Link Quên mật khẩu ===
            linkForgot = new LinkLabel();
            linkForgot.Text = "Quên mật khẩu?";
            linkForgot.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            linkForgot.LinkColor = Color.FromArgb(0, 102, 204);
            linkForgot.ActiveLinkColor = Color.Red;
            linkForgot.AutoSize = true;
            linkForgot.Location = new Point(leftMargin + textboxWidth - linkForgot.PreferredWidth, 480);          
            this.Controls.Add(linkForgot);
        }
     
    }
}