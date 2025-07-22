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
    public partial class usQuenMatKhau : Form
    {     
        public usQuenMatKhau()
        {
            InitializeComponent();
            GiaoDienDong();
        }
        
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLXe;Integrated Security=True";

        private void GiaoDienDong()
        {
            btnUpdate.MouseEnter += (s, e) => btnUpdate.BackColor = Color.FromArgb(0, 100, 220);
            btnUpdate.MouseLeave += (s, e) => btnUpdate.BackColor = Color.FromArgb(0, 123, 255);

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPass = txtNewPass.Text;
            string confirmPass = txtConfirmPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra tài khoản có tồn tại không
                    string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @username";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật mật khẩu
                    string updateQuery = "UPDATE TaiKhoan SET MatKhau = @newPass WHERE TenTaiKhoan = @username";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newPass", newPass);
                    updateCmd.Parameters.AddWithValue("@username", username);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Đóng form
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
