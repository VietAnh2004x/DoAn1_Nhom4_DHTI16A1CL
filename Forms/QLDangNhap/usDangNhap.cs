using DoAn1.Data_Transfer_Objects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Forms.QLDangNhap
{
    public partial class usDangNhap : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLXe;Integrated Security=True";
        private System.Windows.Forms.Timer colorTimer;
        private Color[] titleColors;
        private int currentColorIndex = 0;
        public usDangNhap()
        {
            InitializeComponent();
            KhoiTaoGiaoDienDong(); // Gọi hàm tạo hiệu ứng động
        }

        private void KhoiTaoGiaoDienDong()
        {
            // Load ảnh logo
            try
            {
                picLogo.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "image", "logo.png"));
            }
            catch
            {
                // Tránh lỗi nếu ảnh không tồn tại
                picLogo.BackColor = Color.Gray;
            }

            // Thiết lập Timer cho tiêu đề
            titleColors = new Color[]
            {
              Color.FromArgb(0, 102, 204), Color.Red, Color.Green,
              Color.Orange, Color.Purple, Color.DeepPink, Color.Teal
            };

            colorTimer = new System.Windows.Forms.Timer();
            colorTimer.Interval = 300;
            colorTimer.Tick += (s, e) =>
            {
                lblTitle.ForeColor = titleColors[currentColorIndex];
                currentColorIndex = (currentColorIndex + 1) % titleColors.Length;
            };
            colorTimer.Start();

            // Bắt sự kiện checkbox hiện mật khẩu
            chkShowPass.CheckedChanged += (s, e) =>
            {
                txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
            };

            // Sự kiện hover nút đăng nhập
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.FromArgb(0, 100, 220);
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(0, 123, 255);

            // Click
            btnLogin.Click += BtnLogin_Click;
            linkForgot.Click += LinkForgot_Click;
        }

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
