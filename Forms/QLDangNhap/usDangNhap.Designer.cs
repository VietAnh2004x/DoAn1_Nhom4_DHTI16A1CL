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
        private System.Windows.Forms.Timer colorTimer;
        private Color[] titleColors;
        private int currentColorIndex = 0;

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
            picLogo.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "image", "logo.png"));
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.Size = new Size(150, 150);
            picLogo.Location = new Point((this.ClientSize.Width - picLogo.Width) / 2, 30);
            this.Controls.Add(picLogo);

            // === Tiêu đề ===
            lblTitle = new Label();
            // === Mảng màu cho hiệu ứng nhấp nháy ===
            titleColors = new Color[]
            {
              Color.FromArgb(0, 102, 204),   // Xanh dương
              Color.Red,
              Color.Green,
              Color.Orange,
              Color.Purple,
              Color.DeepPink,
              Color.Teal
            };

            // === Timer thay đổi màu tiêu đề ===
            colorTimer = new System.Windows.Forms.Timer();
            colorTimer.Interval = 300; // Đổi màu mỗi 300ms
            colorTimer.Tick += (s, e) =>
            {
                lblTitle.ForeColor = titleColors[currentColorIndex];
                currentColorIndex = (currentColorIndex + 1) % titleColors.Length;
            };
            colorTimer.Start();
            lblTitle.Text = "ĐĂNG NHẬP";
            lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
          //  lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
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
            chkShowPass.CheckedChanged += (s, e) =>
            {
                txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
            };
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
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.FromArgb(0, 100, 220);
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);

            // === Link Quên mật khẩu ===
            linkForgot = new LinkLabel();
            linkForgot.Text = "Quên mật khẩu?";
            linkForgot.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            linkForgot.LinkColor = Color.FromArgb(0, 102, 204);
            linkForgot.ActiveLinkColor = Color.Red;
            linkForgot.AutoSize = true;
            linkForgot.Location = new Point(leftMargin + textboxWidth - linkForgot.PreferredWidth, 480);
            linkForgot.Click += LinkForgot_Click;
            this.Controls.Add(linkForgot);

        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLXe;Integrated Security=True";



        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Bước 1: Kiểm tra tài khoản
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @user AND MatKhau = @pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Bước 2: Truy vấn thông tin nhân viên tương ứng 
                        string queryNV = "SELECT * FROM NhanVien WHERE TenTaiKhoan = @user";
                        SqlCommand cmdNV = new SqlCommand(queryNV, conn);
                        cmdNV.Parameters.AddWithValue("@user", user);

                        SqlDataReader reader = cmdNV.ExecuteReader();

                        if (reader.Read())
                        {
                            Session.NhanVienDangNhap = new NhanVien
                            {
                                maNV = reader["MaNV"].ToString() ?? "",
                                tenTaiKhoan = reader["TenTaiKhoan"].ToString() ?? "",
                                hoTen = reader["HoTen"].ToString() ?? "",
                                gioiTinh = reader["GioiTinh"].ToString() ?? "",
                                ngaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                                soDienThoai = reader["SoDienThoai"].ToString() ?? "",
                                email = reader["Email"].ToString() ?? "",
                                ngayVaoLam = Convert.ToDateTime(reader["NgayVaoLam"])
                            };
                            Session.TenDangNhap = user;
                            Session.MatKhau = pass;
                        }
                        reader.Close();
                        // Bước 3: Chuyển sang form chính
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                        this.Hide();
                        DoAn1.Forms.Main.MainForm form = new DoAn1.Forms.Main.MainForm();
                        form.FormClosed += (s, args) => this.Close();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkForgot_Click(object sender, EventArgs e)
        {
            usQuenMatKhau forgotForm = new usQuenMatKhau();
            forgotForm.ShowDialog(); // Hiển thị form quên mật khẩu dưới dạng dialog
        }
    }
}