using DoAn.Business_Logic_Layer;
using DoAn.Data_Access_Layer;
using OfficeOpenXml;
using System;
using System.Globalization;
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
        private void SetThongKeControlsVisibility(bool visible)
        {
            lbl1.Visible = visible;
            lbl2.Visible = visible;
            lbl3.Visible = visible;
            txt1.Visible = visible;
            txt2.Visible = visible;
            txt3.Visible = visible;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string selectedMainOption = cboLoaiThongKe.SelectedItem?.ToString()!;
            string selectedSubOption = cboLuaChon.SelectedItem?.ToString()!;
            DateTime startDate = dtpNgayBatDau.Value;
            DateTime endDate = dtpNgayKetThuc.Value;
            SetThongKeControlsVisibility(true);

            if (selectedMainOption == "Loại Xe")
            {
                lbl1.Text = "Tổng doanh thu:";
                lbl2.Text = "Tổng số xe bán ra:";
                lbl3.Text = "Tổng khách hàng:";

                var dongXe = context.DongXe.FirstOrDefault(dx => dx.loaiXe == selectedSubOption);
                if (dongXe == null) return;

                // Tính toán các giá trị tổng
                var tongDoanhThu = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Join(context.ThongTinXe,
                        temp => temp.cthd.maXe,
                        xe => xe.maXe,
                        (temp, xe) => new { temp.cthd, temp.hd, xe })
                    .Where(x => x.xe.maDongXe == dongXe.maDongXe &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Sum(x => x.hd.tongTien);

                txt1.Text = tongDoanhThu.ToString("N0") + " VNĐ";

                var tongXeBanRa = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Join(context.ThongTinXe,
                        temp => temp.cthd.maXe,
                        xe => xe.maXe,
                        (temp, xe) => new { temp.cthd, xe, temp.hd })
                    .Where(x => x.xe.maDongXe == dongXe.maDongXe &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Count();

                txt2.Text = tongXeBanRa.ToString();

                var tongKhachHang = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Join(context.ThongTinXe,
                        temp => temp.cthd.maXe,
                        xe => xe.maXe,
                        (temp, xe) => new { temp.hd, xe })
                    .Where(x => x.xe.maDongXe == dongXe.maDongXe &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Select(x => x.hd.maKhachHang)
                    .Distinct()
                    .Count();

                txt3.Text = tongKhachHang.ToString();

                // Hiển thị chi tiết trong DataGridView
                var chiTietThongKe = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Join(context.ThongTinXe,
                        temp => temp.cthd.maXe,
                        xe => xe.maXe,
                        (temp, xe) => new { temp.cthd, temp.hd, xe })
                    .Where(x => x.xe.maDongXe == dongXe.maDongXe &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Select(x => new
                    {
                        x.hd.maHoaDon,
                        x.xe.maXe,
                        x.xe.tenXe,
                        x.xe.mauSac,
                        TongTien = x.hd.tongTien.ToString("N0", CultureInfo.InvariantCulture).Replace(",", "."), // Lấy từ HoaDon thay vì ChiTietHoaDon
                        GhiChuKhuyenMai = x.cthd.ghiChuKhuyenMai ?? "0%",
                        NgayBan = x.hd.ngayLap
                    })
                    .ToList();

                dgvThongKe.DataSource = chiTietThongKe;
                dgvThongKe.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                dgvThongKe.Columns["maXe"].HeaderText = "Mã Xe";
                dgvThongKe.Columns["tenXe"].HeaderText = "Tên Xe";
                dgvThongKe.Columns["mauSac"].HeaderText = "Màu Sắc";
                dgvThongKe.Columns["TongTien"].HeaderText = "Tổng Tiền";
                dgvThongKe.Columns["GhiChuKhuyenMai"].HeaderText = "Ghi Chú Khuyến Mãi";
                dgvThongKe.Columns["NgayBan"].HeaderText = "Ngày Bán";

                dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvThongKe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvThongKe.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }
            else if (selectedMainOption == "Nhân Viên")
            {
                lbl1.Text = "Tổng xe bán được:";
                lbl2.Text = "Tổng doanh thu:";
                lbl3.Text = "Tổng khách hàng đã xử lí:";

                var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.hoTen == selectedSubOption);
                if (nhanVien == null) return;

                // Tính toán các giá trị tổng
                var tongXeBanDuoc = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Where(x => x.hd.TaiKhoan!.tenTaiKhoan == nhanVien.tenTaiKhoan &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Count();

                txt1.Text = tongXeBanDuoc.ToString();

                var tongDoanhThu = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Where(x => x.hd.TaiKhoan!.tenTaiKhoan == nhanVien.tenTaiKhoan &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Sum(x => x.cthd.donGia);

                txt2.Text = tongDoanhThu.ToString("N0") + " VNĐ";

                var tongKhachHang = context.HoaDon
                    .Where(hd => hd.TaiKhoan!.tenTaiKhoan == nhanVien.tenTaiKhoan &&
                                 hd.ngayLap >= startDate &&
                                 hd.ngayLap <= endDate)
                    .Select(hd => hd.maKhachHang)
                    .Distinct()
                    .Count();

                txt3.Text = tongKhachHang.ToString();

                // Hiển thị chi tiết trong DataGridView
                var chiTietThongKe = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Join(context.ThongTinXe,
                        temp => temp.cthd.maXe,
                        xe => xe.maXe,
                        (temp, xe) => new { temp.cthd, temp.hd, xe })
                    .Join(context.DongXe,
                        temp => temp.xe.maDongXe,
                        dx => dx.maDongXe,
                        (temp, dx) => new { temp.cthd, temp.hd, temp.xe, dx })
                    .Join(context.KhachHang,
                        temp => temp.hd.maKhachHang,
                        kh => kh.maKhachHang,
                        (temp, kh) => new { temp.cthd, temp.hd, temp.xe, temp.dx, kh })
                    .Where(x => x.hd.TaiKhoan!.tenTaiKhoan == nhanVien.tenTaiKhoan &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Select(x => new
                    {
                        x.xe.maXe,
                        x.hd.maKhachHang,
                        TenKhach = x.kh.hoTen,
                        x.xe.tenXe,
                        TongTien = x.hd.tongTien.ToString("N0", CultureInfo.InvariantCulture).Replace(",", "."),
                        LoaiXe = x.dx.loaiXe,
                        ThoiGianXuLi = x.hd.ngayLap
                    })
                    .ToList();

                dgvThongKe.DataSource = chiTietThongKe;
                dgvThongKe.Columns["maXe"].HeaderText = "Mã Xe";
                dgvThongKe.Columns["maKhachHang"].HeaderText = "Mã KH";
                dgvThongKe.Columns["TenKhach"].HeaderText = "Tên Khách Hàng";
                dgvThongKe.Columns["tenXe"].HeaderText = "Tên Xe";
                dgvThongKe.Columns["TongTien"].HeaderText = "Tổng Tiền";
                dgvThongKe.Columns["LoaiXe"].HeaderText = "Loại Xe";
                dgvThongKe.Columns["ThoiGianXuLi"].HeaderText = "Thời Gian Xử Lý";

                dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvThongKe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvThongKe.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }
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

        private void cboLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa các mục cũ trong cboLuaChon
            cboLuaChon.Items.Clear();

            string selectedOption = cboLoaiThongKe.SelectedItem?.ToString()!;

            if (selectedOption == "Loại Xe")
            {
                cboLuaChon.Items.AddRange(new object[] { "Xe Đạp Điện", "Xe Máy Điện" });
                cboLuaChon.SelectedIndex = 0; // Chọn mặc định "Xe Đạp Điện"
            }
            else if (selectedOption == "Nhân Viên")
            {
                // Lấy danh sách nhân viên từ database
                // Giả sử bạn có DbSet<NhanVien> trong DataDbContext và NhanVien có thuộc tính TenNhanVien
                var danhSachNhanVien = context.NhanVien.Select(nv => nv.hoTen).ToList();
                cboLuaChon.Items.AddRange(danhSachNhanVien.ToArray());
                if (cboLuaChon.Items.Count > 0)
                {
                    cboLuaChon.SelectedIndex = 0; // Chọn nhân viên đầu tiên
                }
            }
        }
    }
}
