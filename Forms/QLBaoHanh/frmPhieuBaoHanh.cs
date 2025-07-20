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

namespace DoAn1.Forms.QLBaoHanh
{
    public partial class frmPhieuBaoHanh : Form
    {
        public frmPhieuBaoHanh()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                // Lấy mã bảo hành lớn nhất hiện có bắt đầu bằng "BH"
                var maxMaBH = context.BaoHanh
                    .Where(bh => bh.maBaoHanh.StartsWith("BH"))
                    .Select(bh => bh.maBaoHanh.Substring(2)) // bỏ "BH" để lấy số
                    .ToList() // chuyển sang xử lý client-side
                    .Select(s => int.TryParse(s, out var num) ? num : 0)
                    .DefaultIfEmpty(0)
                    .Max();

                // Tạo mã bảo hành mới: BH001, BH002, ...
                string maBaoHanh = "BH" + (maxMaBH + 1).ToString("D3");

                // Lấy dữ liệu từ các điều khiển
                string maXe = txtMaXe.Text.Trim();
                string maHoaDon = txtMaHoaDon.Text.Trim();
                int thoiHanThang = (int)nudThoiHan.Value;

                // Kiểm tra mã xe
                bool xeTonTai = context.ThongTinXe.Any(x => x.maXe == maXe);
                if (!xeTonTai)
                {
                    MessageBox.Show("Mã xe không tồn tại! Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mã hóa đơn
                bool hoaDonTonTai = context.HoaDon.Any(hd => hd.maHoaDon == maHoaDon);
                if (!hoaDonTonTai)
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại! Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra thời gian bảo hành
                if (thoiHanThang <= 0)
                {
                    MessageBox.Show("Thời hạn bảo hành phải lớn hơn 0 tháng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm mới phiếu bảo hành
                var phieuBaoHanh = new BaoHanh
                {
                    maBaoHanh = maBaoHanh,
                    maHoaDon = maHoaDon,
                    maXe = maXe,
                    ngayBatDau = dtpNgayLap.Value,
                    thoiHanThang = thoiHanThang
                };

                context.BaoHanh.Add(phieuBaoHanh);

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Đã lưu phiếu bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaXe.Clear();
            txtMaHoaDon.Clear();
            nudThoiHan.Value = 0; 
            dtpNgayLap.Value = DateTime.Now;
        }
    }
}
