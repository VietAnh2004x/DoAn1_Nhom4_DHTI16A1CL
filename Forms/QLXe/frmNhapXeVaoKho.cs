using DoAn.Data_Access_Layer;
using DoAn.Data_Transfer_Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace DoAn.Forms.QLTonKho
{
    public partial class frmNhapXeVaoKho : Form
    {
        public frmNhapXeVaoKho()
        {
            InitializeComponent();
            this.Load += frmNhapXeVaoKho_Load!;
        }

        // Gọi khi form load
        private void frmNhapXeVaoKho_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        // Hàm làm mới tất cả dữ liệu nhập
        private void LoadForm()
        {
            
            txtMaXe.Text = string.Empty;
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            dtpNgayNhap.Value = DateTime.Now;
            txtMaXe.Focus();
        }

        private string SinhMaNhapTuDong()
        {
            using (var context = new DataDbContext())
            {
                var lastMa = context.TonXe
                    .OrderByDescending(t => t.maNhap)
                    .Select(t => t.maNhap)
                    .FirstOrDefault();

                if (string.IsNullOrEmpty(lastMa))
                {
                    return "N001";
                }

                string so = lastMa.Substring(1); // bỏ chữ 'N'

                if (int.TryParse(so, out int stt))
                {
                    stt++;
                    return "N" + stt.ToString("D3");
                }
                return "N001";
            }
        }

        // Lưu dữ liệu vào cơ sở dữ liệu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maXe = txtMaXe.Text.Trim();
            DateTime ngayNhap = dtpNgayNhap.Value;

            if (string.IsNullOrWhiteSpace(maXe))
            {
                MessageBox.Show("Mã xe không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGiaNhap.Text.Trim(), out decimal donGiaNhap) || donGiaNhap < 0)
            {
                MessageBox.Show("Đơn giá nhập phải lớn hơn hoặc bằng 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string maNhapMoi = SinhMaNhapTuDong(); // Sinh mã mới tự động

                TonXe tonXe = new TonXe
                {
                    maNhap = maNhapMoi,
                    maXe = maXe,
                    ngayNhap = ngayNhap,
                    soLuong = soLuong,
                    donGiaNhap = donGiaNhap
                };

                using (var context = new DataDbContext())
                {
                    context.TonXe.Add(tonXe);
                    context.SaveChanges();
                }

                MessageBox.Show($"Lưu thành công! Mã nhập: {maNhapMoi}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Làm mới form
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        // Thoát khỏi form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
