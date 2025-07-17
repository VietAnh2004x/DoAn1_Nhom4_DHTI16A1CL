using DoAn.Data_Access_Layer;
using DoAn1.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Forms.QLKhachHang
{
    public partial class frmPhieuKhachHang : Form
    {
        public frmPhieuKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                // Lấy dữ liệu từ các textbox
                string tenKH = txtTenKhachHang.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();
                string soDienThoai = txtSoDienThoai.Text.Trim();

                // Kiểm tra ràng buộc
                if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(diaChi) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(soDienThoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra email trùng
                if (context.KhachHang.Any(kh => kh.email == email))
                {
                    MessageBox.Show("Email đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Sinh mã khách hàng tự động
                string newMaKH = "KH001";
                var lastKH = context.KhachHang
                                    .OrderByDescending(kh => kh.maKhachHang)
                                    .FirstOrDefault();

                if (lastKH != null)
                {
                    string lastMa = lastKH.maKhachHang; // KH009
                    string numberPart = lastMa.Substring(2); // "009"
                    if (int.TryParse(numberPart, out int number))
                    {
                        number++;
                        newMaKH = "KH" + number.ToString("D3");
                    }
                }

                // Tạo đối tượng KhachHang mới
                var khachHang = new KhachHang
                {
                    maKhachHang = newMaKH,
                    hoTen = tenKH,
                    diaChi = diaChi,
                    email = email,
                    soDienThoai = soDienThoai
                };

                // Thêm vào CSDL
                context.KhachHang.Add(khachHang);
                context.SaveChanges();

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
        }
    }
}
