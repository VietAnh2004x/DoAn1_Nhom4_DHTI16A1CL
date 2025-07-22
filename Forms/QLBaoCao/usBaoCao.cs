using DoAn1_Nhom4_DHTI16A1CL.Business_Logic_Layer;
using DoAn1_Nhom4_DHTI16A1CL.Data_Access_Layer;
using System.Data;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoCao
{
    public partial class usBaoCao : UserControl
    {
        private DataDbContext context = new DataDbContext();
        private BaoCaoBLL baoCaoBLL = new BaoCaoBLL();
        public usBaoCao()
        {
            InitializeComponent();
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
            string selectedMainOption = cboLuaChon.SelectedItem?.ToString();
            string selectedSubOption = cboDanhSachLuaChon.SelectedItem?.ToString();
            DateTime startDate = dtpNgayBatDau.Value;
            DateTime endDate = dtpNgayKetThuc.Value;
            SetThongKeControlsVisibility(true);

            if (selectedMainOption == "Loại Xe")
            {
                lbl1.Text = "Tổng doanh thu:";
                lbl2.Text = "Tổng số xe bán ra:";
                lbl3.Text = "Tổng xe còn trong kho:";

                var dongXe = context.DongXe.FirstOrDefault(dx => dx.loaiXe == selectedSubOption);
                if (dongXe == null) return;

                // Tính tổng doanh thu (mỗi chi tiết tính là 1 xe)
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
                    .Sum(x => x.cthd.donGia); // Bỏ * soLuong

                txt1.Text = tongDoanhThu.ToString("N0") + " VNĐ";

                // Tính tổng số xe bán ra (đếm số chi tiết)
                var tongXeBanRa = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Join(context.ThongTinXe,
                        temp => temp.cthd.maXe,
                        xe => xe.maXe,
                        (temp, xe) => new { temp.cthd, xe })
                    .Where(x => x.xe.maDongXe == dongXe.maDongXe &&
                                x.cthd.HoaDon.ngayLap >= startDate &&
                                x.cthd.HoaDon.ngayLap <= endDate)
                    .Count(); // Đếm số bản ghi thay vì sum soLuong

                txt2.Text = tongXeBanRa.ToString();

                // Tính tổng xe còn trong kho (giữ nguyên)
                var tongXeTrongKho = context.TonXe
                    .Join(context.ThongTinXe,
                        ton => ton.maXe,
                        xe => xe.maXe,
                        (ton, xe) => new { ton, xe })
                    .Where(x => x.xe.maDongXe == dongXe.maDongXe)
                    .Sum(x => x.ton.soLuong);

                txt3.Text = tongXeTrongKho.ToString();
            }
            else if (selectedMainOption == "Nhân Viên")
            {
                lbl1.Text = "Tổng xe bán được:";
                lbl2.Text = "Tổng doanh thu:";
                lbl3.Text = "Tổng KH đã xử lí:";

                var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.hoTen == selectedSubOption);
                if (nhanVien == null) return;

                // Tính tổng xe bán được (đếm số chi tiết)
                var tongXeBanDuoc = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Where(x => x.hd.TaiKhoan!.tenTaiKhoan == nhanVien.tenTaiKhoan &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Count(); // Đếm số bản ghi thay vì sum soLuong

                txt1.Text = tongXeBanDuoc.ToString();

                // Tính tổng doanh thu (mỗi chi tiết tính là 1 xe)
                var tongDoanhThu = context.ChiTietHoaDon
                    .Join(context.HoaDon,
                        cthd => cthd.maHoaDon,
                        hd => hd.maHoaDon,
                        (cthd, hd) => new { cthd, hd })
                    .Where(x => x.hd.TaiKhoan!.tenTaiKhoan == nhanVien.tenTaiKhoan &&
                                x.hd.ngayLap >= startDate &&
                                x.hd.ngayLap <= endDate)
                    .Sum(x => x.cthd.donGia); // Bỏ * soLuong

                txt2.Text = tongDoanhThu.ToString("N0") + " VNĐ";

                // Tính tổng khách hàng đã xử lý (giữ nguyên)
                var tongKhachHang = context.HoaDon
                    .Where(hd => hd.TaiKhoan!.tenTaiKhoan == nhanVien.tenTaiKhoan &&
                                 hd.ngayLap >= startDate &&
                                 hd.ngayLap <= endDate)
                    .Select(hd => hd.maKhachHang)
                    .Distinct()
                    .Count();

                txt3.Text = tongKhachHang.ToString();
            }
        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa các mục cũ trong cboDanhSachLuaChon
            cboDanhSachLuaChon.Items.Clear();

            string selectedOption = cboLuaChon.SelectedItem?.ToString();

            if (selectedOption == "Loại Xe")
            {
                cboDanhSachLuaChon.Items.AddRange(new object[] { "Xe Đạp Điện", "Xe Máy Điện" });
                cboDanhSachLuaChon.SelectedIndex = 0; // Chọn mặc định "Xe Điện"
            }
            else if (selectedOption == "Nhân Viên")
            {
                // Lấy danh sách nhân viên từ database
                // Giả sử bạn có DbSet<NhanVien> trong DataDbContext và NhanVien có thuộc tính TenNhanVien
                var danhSachNhanVien = context.NhanVien.Select(nv => nv.hoTen).ToList();
                cboDanhSachLuaChon.Items.AddRange(danhSachNhanVien.ToArray());
                if (cboDanhSachLuaChon.Items.Count > 0)
                {
                    cboDanhSachLuaChon.SelectedIndex = 0; // Chọn nhân viên đầu tiên
                }
            }
        }
    }
}
