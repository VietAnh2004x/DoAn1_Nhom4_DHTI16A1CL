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
        // Lọc hóa đơn theo ngày hôm nay
        return context.HoaDon
            .Where(h => h.ngayLap.Date == DateTime.Today.Date)
            .Sum(h => (decimal?)h.tongTien) ?? 0;
    }

    public int LaySoLuongDonHang()
    {
        // Lọc hóa đơn theo ngày hôm nay
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
        // Lấy ngày hiện tại
        DateTime now = DateTime.Now;

        // Xác định ngày bắt đầu của 3 tháng gần nhất
        // Ví dụ: Nếu hôm nay là 19/07/2025, thì ba tháng gần nhất sẽ là tháng 5, 6, 7.
        // threeMonthsAgo sẽ là 01/05/2025
        DateTime threeMonthsAgo = new DateTime(now.Year, now.Month, 1).AddMonths(-2);

        var ds = context.HoaDon
            // Lọc các hóa đơn trong khoảng thời gian 3 tháng gần nhất
            .Where(h => h.ngayLap >= threeMonthsAgo && h.ngayLap <= now)
            // Nhóm theo cả năm và tháng để phân biệt các tháng giống nhau ở các năm khác nhau
            .GroupBy(h => new { h.ngayLap.Year, h.ngayLap.Month })
            .Select(g => new
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                TongTien = g.Sum(h => h.tongTien)
            })
            // Sắp xếp theo năm và sau đó theo tháng để đảm bảo thứ tự thời gian
            .OrderBy(x => x.Year)
            .ThenBy(x => x.Month)
            .ToList() // Thực hiện truy vấn tại đây để có thể chiếu sang tuple sau đó
            .Select(x => (x.Month, x.TongTien)) // Chiếu sang tuple (Thang, TongTien)
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