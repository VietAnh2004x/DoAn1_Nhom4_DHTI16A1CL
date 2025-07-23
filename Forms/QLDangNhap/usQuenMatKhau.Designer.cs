using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace DoAn.Forms.QLDangNhap
{
    public partial class usQuenMatKhau : Form
    {
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblNewPass;
        private TextBox txtNewPass;
        private Label lblConfirmPass;
        private TextBox txtConfirmPass;
        private Button btnUpdate;

        private void InitializeComponent()
        {
            // Cài đặt form
            this.Text = "Quên mật khẩu";
            this.Size = new Size(450, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(240, 248, 255); // Nền xanh nhạt

            // === Tiêu đề ===
            lblTitle = new Label();
            lblTitle.Text = "KHÔI PHỤC MẬT KHẨU";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point((this.ClientSize.Width - lblTitle.PreferredWidth) / 2, 40);
            this.Controls.Add(lblTitle);

            // === Label Tên đăng nhập ===
            lblUsername = new Label();
            lblUsername.Text = "Tên đăng nhập:";
            lblUsername.Font = new Font("Segoe UI", 12);
            lblUsername.Location = new Point(50, 100);
            lblUsername.AutoSize = true;
            this.Controls.Add(lblUsername);

            txtUsername = new TextBox();
            txtUsername.Font = new Font("Segoe UI", 12);
            txtUsername.Location = new Point(50, 130);
            txtUsername.Width = 340;
            this.Controls.Add(txtUsername);

            // === Label mật khẩu mới ===
            lblNewPass = new Label();
            lblNewPass.Text = "Mật khẩu mới:";
            lblNewPass.Font = new Font("Segoe UI", 12);
            lblNewPass.Location = new Point(50, 175);
            lblNewPass.AutoSize = true;
            this.Controls.Add(lblNewPass);

            txtNewPass = new TextBox();
            txtNewPass.Font = new Font("Segoe UI", 12);
            txtNewPass.Location = new Point(50, 205);
            txtNewPass.Width = 340;
            txtNewPass.UseSystemPasswordChar = true;
            this.Controls.Add(txtNewPass);

            // === Label nhập lại mật khẩu ===
            lblConfirmPass = new Label();
            lblConfirmPass.Text = "Nhập lại mật khẩu:";
            lblConfirmPass.Font = new Font("Segoe UI", 12);
            lblConfirmPass.Location = new Point(50, 250);
            lblConfirmPass.AutoSize = true;
            this.Controls.Add(lblConfirmPass);

            txtConfirmPass = new TextBox();
            txtConfirmPass.Font = new Font("Segoe UI", 12);
            txtConfirmPass.Location = new Point(50, 280);
            txtConfirmPass.Width = 340;
            txtConfirmPass.UseSystemPasswordChar = true;
            this.Controls.Add(txtConfirmPass);

            // === Nút cập nhật mật khẩu ===
            btnUpdate = new Button();
            btnUpdate.Text = "Cập nhật mật khẩu";
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnUpdate.Location = new Point(50, 340);
            btnUpdate.Size = new Size(340, 45);
            btnUpdate.BackColor = Color.FromArgb(0, 123, 255);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Cursor = Cursors.Hand;           
            btnUpdate.Click += BtnUpdate_Click;
            this.Controls.Add(btnUpdate);
            this.AcceptButton = btnUpdate;
        }   
    }
}
