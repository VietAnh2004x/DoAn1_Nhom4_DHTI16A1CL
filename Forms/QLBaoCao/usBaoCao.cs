using DoAn.Business_Logic_Layer;
using DoAn.Data_Access_Layer;
using OfficeOpenXml;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms.QLBaoCao
{
    public partial class usBaoCao : UserControl
    {
        private readonly DataDbContext context = new DataDbContext();
        private readonly BaoCaoBLL baoCaoBLL = new BaoCaoBLL();

        public usBaoCao()
        {
            InitializeComponent();

            // EPPlus 5.x - 7.x: cần cấu hình context license
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void usBaoCao_Load(object sender, EventArgs e)
        {
            cboLoaiThongKe.Items.Clear();
            cboLoaiThongKe.Items.AddRange(new[] { "Xe Điện", "Xe Máy Điện", "Xe Đạp Điện" });
            cboLoaiThongKe.SelectedIndex = 0;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime bd = dtpNgayBatDau.Value.Date;
            DateTime kt = dtpNgayKetThuc.Value.Date;
            string loai = cboLoaiThongKe.SelectedItem?.ToString() ?? "Xe Điện";

            var data = (from hd in context.HoaDon
                        join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                        join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                        join dong in context.DongXe on xe.maDongXe equals dong.maDongXe
                        where hd.ngayLap >= bd && hd.ngayLap <= kt
                              && (loai == "Xe Điện" || dong.loaiXe == loai)
                        select new
                        {
                            MaHoaDon = hd.maHoaDon,
                            TenXe = xe.tenXe,
                            MauSac = xe.mauSac,
                            SoBinhAcQuy = xe.soBinhAcQuy,
                            DungLuongAcQuy = xe.dungLuongAcQuy,
                            TongTien = hd.tongTien,
                            NgayBan = hd.ngayLap,
                            LoaiXe = dong.loaiXe
                        }).ToList();

            dgvThongKe.DataSource = data;
            dgvThongKe.Columns["TongTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";

            txtSoKhachHang.Text = baoCaoBLL.ThongKeKhachHang(bd, kt, loai).ToString();
            txt2.Text = baoCaoBLL.ThongKeSoXeBanRa(bd, kt, loai).ToString();
            txt1.Text = baoCaoBLL.ThongKeTongDoanhThu(bd, kt, loai);
            txt3.Text = baoCaoBLL.ThongKeTongSoXeTheoLoai(bd, kt, loai).ToString();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo");
                return;
            }

            using SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                FileName = "BaoCaoThongKe.xlsx"
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Báo Cáo");

            // Ghi header
            for (int col = 0; col < dgvThongKe.Columns.Count; col++)
            {
                worksheet.Cells[1, col + 1].Value = dgvThongKe.Columns[col].HeaderText;
                worksheet.Cells[1, col + 1].Style.Font.Bold = true;
            }

            // Ghi dữ liệu
            for (int i = 0; i < dgvThongKe.Rows.Count; i++)
            {
                for (int j = 0; j < dgvThongKe.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = dgvThongKe.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Cells.AutoFitColumns();

            // Lưu file
            File.WriteAllBytes(dlg.FileName, package.GetAsByteArray());
            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
