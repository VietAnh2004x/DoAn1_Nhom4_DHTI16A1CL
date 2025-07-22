using DoAn1_Nhom4_DHTI16A1CL.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;

public class TongQuanBLL
{
    private readonly DataDbContext context = new DataDbContext();

    public int LaySoLuongXeTheoLoai(string loaiXe)
    {
        return context.TonXe
            .Join(context.ThongTinXe, tx => tx.maXe, tt => tt.maXe, (tx, tt) => new { tx, tt })
            .Join(context.DongXe, temp => temp.tt.maDongXe, dx => dx.maDongXe, (temp, dx) => new { temp.tx, dx })
            .Where(x => x.dx.loaiXe == loaiXe)
            .Sum(x => x.tx.soLuong);
    }

    public decimal LayTongDoanhThu()
    {
        return context.HoaDon
            .Where(h => h.ngayLap.Date == DateTime.Today.Date)
            .Sum(h => h.tongTien);
    }

    public int LaySoLuongDonHang()
    {
        return context.HoaDon
            .Where(h => h.ngayLap.Date == DateTime.Today.Date)
            .Count();
    }

    // Thay thế các dùng tuple trong LINQ bằng anonymous type
    public List<(string TenXe, int SoLuong)> LayTopSanPhamBanChay(int topN = 3)
    {
        var result = context.ChiTietHoaDon
            .Join(context.HoaDon,
                cthd => cthd.maHoaDon,
                hd => hd.maHoaDon,
                (cthd, hd) => new { cthd, hd })
            .Where(x => x.hd.ngayLap.Date.Month == DateTime.Today.Month && x.hd.ngayLap.Date.Year == DateTime.Today.Year)
            .GroupBy(x => x.cthd.maXe)
            .Select(g => new
            {
                MaXe = g.Key,
                SoLuong = g.Count()
            })
            .OrderByDescending(x => x.SoLuong)
            .Take(topN)
            .Join(context.ThongTinXe,
                g => g.MaXe,
                tt => tt.maXe,
                (g, tt) => new { tt.tenXe, g.SoLuong })
            .ToList();

        return result.Select(x => (x.tenXe, x.SoLuong)).ToList();
    }
    public List<(int Thang, decimal TongTien)> LayDoanhThuTheoThang()
    {
        DateTime now = DateTime.Now;
        // Thay đổi từ AddMonths(-2) thành AddMonths(-3) để lấy từ đầu tháng 4
        DateTime startDate = new DateTime(now.Year, now.Month, 1).AddMonths(-3);
        DateTime endDate = startDate.AddMonths(3).AddDays(-1); // Đến hết ngày cuối cùng của tháng 6

        var result = context.HoaDon
            .Where(h => h.ngayLap >= startDate && h.ngayLap <= endDate)
            .GroupBy(h => new { h.ngayLap.Year, h.ngayLap.Month })
            .Select(g => new
            {
                g.Key.Month,
                TongTien = g.Sum(h => h.tongTien)
            })
            .OrderBy(x => x.Month)
            .ToList();

        return result.Select(x => (x.Month, x.TongTien)).ToList();
    }

    public int LaySoLuongKhachHangHomNay()
    {
        return context.HoaDon
            .Where(h => h.ngayLap.Date == DateTime.Today.Date)
            .Select(h => h.maKhachHang)
            .Distinct()
            .Count();
    }

    public int LaySoLuongNhanVienBanHangHomNay()
    {
        return context.HoaDon
            .Where(h => h.ngayLap.Date == DateTime.Today.Date)
            .Select(h => h.tenTaiKhoan)
            .Distinct()
            .Count();
    }
}