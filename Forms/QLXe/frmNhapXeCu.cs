using DoAn.Data_Transfer_Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Data_Access_Layer;

namespace DoAn.Forms.QLXe
{
    public partial class frmNhapXeCu : Form
    {
        private readonly DataDbContext _context;
        public frmNhapXeCu()
        {
            InitializeComponent();
            _context = new DataDbContext();

            // Gắn sự kiện cho mã xe
            txtMaXeDoi.Leave += txtMaXeDoi_Leave!;
        }

        private string TaoMaGiaoDichMoi()
        {
            // Lấy mã lớn nhất hiện tại
            var maCuoi = _context.GiaoDichXeCu
                .OrderByDescending(g => g.MaDoi)
                .Select(g => g.MaDoi)
                .FirstOrDefault();

            if (string.IsNullOrEmpty(maCuoi))
            {
                return "DX001"; // Nếu chưa có gì trong DB
            }

            // Tách số sau tiền tố "DX"
            var so = maCuoi.Substring(2); // VD: "DX005" => "005"
            if (int.TryParse(so, out int soMoi))
            {
                soMoi++; // Tăng lên
                return $"DX{soMoi:D3}"; // Format lại thành DX + số có 3 chữ số
            }

            return "DX001"; // Trường hợp lỗi parse
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var giaoDich = new GiaoDichXeCu
                {
                    MaDoi = TaoMaGiaoDichMoi(), // ✅ Gọi hàm tạo mã tự động
                    maKhachHang = txtMaKhachHang.Text.Trim(),
                    maNV = txtMaNV.Text.Trim(),
                    maXe = txtMaXeDoi.Text.Trim(),
                    TenXeCu = txtTenXeCu.Text.Trim(),
                    NamSanXuat = int.Parse(txtNamSanXuat.Text.Trim()),
                    SoKm = int.Parse(txtSoKmDaDi.Text.Trim()),
                    TinhTrang = txtTinhTrang.Text.Trim(),
                    GiaDinhGia = decimal.Parse(txtGiaDinhGia.Text.Trim()),
                    NgayDoi = dtpNgayGiaoDich.Value
                };

                _context.GiaoDichXeCu.Add(giaoDich);
                _context.SaveChanges();

                MessageBox.Show("Lưu giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Lấy tất cả TextBox trong form (cả trong container)
            var textBoxes = GetAllControls(this).OfType<TextBox>();
            foreach (var tb in textBoxes)
            {
                tb.Clear(); // hoặc tb.Text = "";
            }

            dtpNgayGiaoDich.Value = DateTime.Today;
        }

        // Hàm lấy tất cả control con đệ quy
        private IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    


private void txtMaXeDoi_Leave(object sender, EventArgs e)
        {
            string maXe = txtMaXeDoi.Text.Trim();

            if (!string.IsNullOrEmpty(maXe))
            {
                var xe = _context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                txtTenXeDoi.Text = xe?.tenXe ?? string.Empty;
            }
            else
            {
                txtTenXeDoi.Text = string.Empty;
            }
        }
    }
}
