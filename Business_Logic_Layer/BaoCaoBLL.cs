using DoAn.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_Nhom4_DHTI16A1CL.Business_Logic_Layer
{
    public class BaoCaoBLL
    {
        private DataDbContext context = new DataDbContext();

        // --- Thống kê theo Loại Xe ---

        public string ThongKeTongDoanhThuTheoLoaiXe(DateTime ngayBatDau, DateTime ngayKetThuc, string loaiXeCanThongKe)
        {
            var query = context.HoaDon
                        .Include(hd => hd.ChiTietHoaDons) // Bao gồm ChiTietHoaDons
                            .ThenInclude(ct => ct.ThongTinXe) // Bao gồm ThongTinXe từ ChiTietHoaDons
                                .ThenInclude(xe => xe.DongXe) // Bao gồm DongXe từ ThongTinXe
                        .Where(hd => hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc)
                        .SelectMany(hd => hd.ChiTietHoaDons) // Mở rộng ChiTietHoaDons để lọc dễ hơn
                        .Where(ct => ct.ThongTinXe != null && ct.ThongTinXe.DongXe != null &&
                            ((loaiXeCanThongKe == "Xe Điện" && (ct.ThongTinXe.DongXe.loaiXe == "Xe Máy Điện" || ct.ThongTinXe.DongXe.loaiXe == "Xe Đạp Điện")) ||
                            (loaiXeCanThongKe != "Xe Điện" && ct.ThongTinXe.DongXe.loaiXe == loaiXeCanThongKe))
                        );

            // Sum() trên tập hợp rỗng của decimal sẽ trả về 0, không phải null
            double tong = query.Sum(ct => ct.soLuong * ct.donGia); // Tính tổng từ ChiTietHoaDon
            return tong.ToString("#,##0 'VNĐ'");
        }

        public int ThongKeTongSoXeBanRaTheoLoaiXe(DateTime ngayBatDau, DateTime ngayKetThuc, string loaiXeCanThongKe)
        {
            var query = context.HoaDon
                        .Include(hd => hd.ChiTietHoaDons)
                            .ThenInclude(ct => ct.ThongTinXe)
                                .ThenInclude(xe => xe.DongXe)
                        .Where(hd => hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc)
                        .SelectMany(hd => hd.ChiTietHoaDons)
                        .Where(ct => ct.ThongTinXe != null && ct.ThongTinXe.DongXe != null &&
                            ((loaiXeCanThongKe == "Xe Điện" && (ct.ThongTinXe.DongXe.loaiXe == "Xe Máy Điện" || ct.ThongTinXe.DongXe.loaiXe == "Xe Đạp Điện")) ||
                            (loaiXeCanThongKe != "Xe Điện" && ct.ThongTinXe.DongXe.loaiXe == loaiXeCanThongKe))
                        );

            // Sum() trên tập hợp rỗng của int sẽ trả về 0, không phải null
            return query.Sum(ct => ct.soLuong);
        }

        public int ThongKeTongSoXeTonKhoTheoLoaiXe(string loaiXeCanThongKe)
        {
            // Tính tổng số lượng nhập vào dựa trên loại xe
            var importedQuantities = context.TonXe
                                    .Include(tx => tx.ThongTinXe)
                                        .ThenInclude(xe => xe.DongXe)
                                    .Where(tx => tx.ThongTinXe != null && tx.ThongTinXe.DongXe != null &&
                                        ((loaiXeCanThongKe == "Xe Điện" && (tx.ThongTinXe.DongXe.loaiXe == "Xe Máy Điện" || tx.ThongTinXe.DongXe.loaiXe == "Xe Đạp Điện")) ||
                                        (loaiXeCanThongKe != "Xe Điện" && tx.ThongTinXe.DongXe.loaiXe == loaiXeCanThongKe))
                                    )
                                    .GroupBy(tx => tx.maXe)
                                    .Select(g => new
                                    {
                                        MaXe = g.Key,
                                        TotalImported = g.Sum(tx => tx.soLuong)
                                    })
                                    .ToList();

            // Tính tổng số lượng bán ra dựa trên loại xe
            var soldQuantities = context.ChiTietHoaDon
                                .Include(cthd => cthd.ThongTinXe)
                                    .ThenInclude(xe => xe.DongXe)
                                .Where(cthd => cthd.ThongTinXe != null && cthd.ThongTinXe.DongXe != null &&
                                    ((loaiXeCanThongKe == "Xe Điện" && (cthd.ThongTinXe.DongXe.loaiXe == "Xe Máy Điện" || cthd.ThongTinXe.DongXe.loaiXe == "Xe Đạp Điện")) ||
                                    (loaiXeCanThongKe != "Xe Điện" && cthd.ThongTinXe.DongXe.loaiXe == loaiXeCanThongKe))
                                )
                                .GroupBy(cthd => cthd.maXe)
                                .Select(g => new
                                {
                                    MaXe = g.Key,
                                    TotalSold = g.Sum(cthd => cthd.soLuong)
                                })
                                .ToList();

            // Lấy tất cả các mã xe thuộc loại xe cần thống kê
            var relevantMaXes = context.ThongTinXe
                                    .Include(xe => xe.DongXe)
                                    .Where(xe => xe.DongXe != null &&
                                        ((loaiXeCanThongKe == "Xe Điện" && (xe.DongXe.loaiXe == "Xe Máy Điện" || xe.DongXe.loaiXe == "Xe Đạp Điện")) ||
                                        (loaiXeCanThongKe != "Xe Điện" && xe.DongXe.loaiXe == loaiXeCanThongKe))
                                    )
                                    .Select(xe => xe.maXe)
                                    .Distinct()
                                    .ToList();

            int totalStock = 0;
            foreach (var maXe in relevantMaXes)
            {
                int imported = importedQuantities.FirstOrDefault(iq => iq.MaXe == maXe)?.TotalImported ?? 0;
                int sold = soldQuantities.FirstOrDefault(sq => sq.MaXe == maXe)?.TotalSold ?? 0;
                totalStock += (imported - sold);
            }

            return totalStock;
        }

        // --- Thống kê theo Nhân Viên ---

        public string ThongKeTongDoanhThuTheoNhanVien(DateTime ngayBatDau, DateTime ngayKetThuc, string maNhanVien)
        {
            var query = from hd in context.HoaDon
                                .Include(h => h.TaiKhoan)
                                .ThenInclude(tk => tk.NhanVien) // Đảm bảo NhanVien được tải
                        where hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc
                              && hd.TaiKhoan != null && hd.TaiKhoan.NhanVien != null // Kiểm tra null
                              && hd.TaiKhoan.NhanVien.maNV == maNhanVien // Truy cập maNV của NhanVien
                        select hd.tongTien;

            decimal tong = query.Sum(x => x);
            return tong.ToString("#,##0 'VNĐ'");
        }

        public int ThongKeSoXeBanRaTheoNhanVien(DateTime ngayBatDau, DateTime ngayKetThuc, string maNhanVien)
        {
            var query = from hd in context.HoaDon
                                .Include(h => h.TaiKhoan)
                                .ThenInclude(tk => tk.NhanVien) // Đảm bảo NhanVien được tải
                        join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon // Đảm bảo sử dụng ICollection ChiTietHoaDons
                        where hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc
                              && hd.TaiKhoan != null && hd.TaiKhoan.NhanVien != null // Kiểm tra null
                              && hd.TaiKhoan.NhanVien.maNV == maNhanVien // Truy cập maNV của NhanVien
                        select ct.soLuong;

            return query.Sum(x => x);
        }

        public int ThongKeSoKhachHangTheoNhanVien(DateTime ngayBatDau, DateTime ngayKetThuc, string maNhanVien)
        {
            var query = from hd in context.HoaDon
                                .Include(h => h.TaiKhoan)
                                .ThenInclude(tk => tk.NhanVien) // Đảm bảo NhanVien được tải
                        where hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc
                              && hd.TaiKhoan != null && hd.TaiKhoan.NhanVien != null // Kiểm tra null
                              && hd.TaiKhoan.NhanVien.maNV == maNhanVien // Truy cập maNV của NhanVien
                        select hd.maKhachHang;

            return query.Distinct().Count();
        }
    }
}
