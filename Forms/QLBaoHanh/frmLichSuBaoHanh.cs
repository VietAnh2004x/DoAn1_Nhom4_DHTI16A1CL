using DoAn.Data_Access_Layer;
using DoAn.Data_Transfer_Objects;
using DoAn1.Data_Transfer_Objects;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms.QLBaoHanh
{
    public partial class frmLichSuBaoHanh : Form
    {
        private DataDbContext _context;

        public frmLichSuBaoHanh()
        {
            InitializeComponent();
            _context = new DataDbContext();
            dtpNgayBaoHanh.Value = DateTime.Today;
        }

        private string TaoMaLSBHTuDong()
        {
            var maxMa = _context.LichSuBaoHanh
                .OrderByDescending(ls => ls.MaLSBH)
                .Select(ls => ls.MaLSBH)
                .FirstOrDefault();

            if (string.IsNullOrEmpty(maxMa))
            {
                return "LSBH001";
            }
            else
            {
                int soThuTu = int.Parse(maxMa.Substring(4));
                soThuTu++;
                return "LSBH" + soThuTu.ToString("D3");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaBaoHanh.Text))
                {
                    MessageBox.Show("Bạn chưa nhập Mã Bảo Hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaBaoHanh.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNoiDungBaoHanh.Text))
                {
                    MessageBox.Show("Bạn chưa nhập Nội dung bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoiDungBaoHanh.Focus();
                    return;
                }

                LichSuBaoHanh lichSu = new LichSuBaoHanh();

                lichSu.MaLSBH = TaoMaLSBHTuDong();
                lichSu.maBaoHanh = txtMaBaoHanh.Text.Trim();
                lichSu.NgayBaoHanh = dtpNgayBaoHanh.Value;
                lichSu.NoiDungBaoHanh = txtNoiDungBaoHanh.Text.Trim();

                lichSu.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();
                lichSu.maNV = string.IsNullOrWhiteSpace(txtMaNhanVien.Text) ? null : txtMaNhanVien.Text.Trim();

                _context.LichSuBaoHanh.Add(lichSu);
                _context.SaveChanges();

                MessageBox.Show($"Lưu lịch sử bảo hành thành công với mã: {lichSu.MaLSBH}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLamMoi.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBaoHanh.Text = "";
            txtNoiDungBaoHanh.Text = "";
            txtGhiChu.Text = "";
            txtMaNhanVien.Text = "";
            dtpNgayBaoHanh.Value = DateTime.Today;
            txtMaBaoHanh.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
