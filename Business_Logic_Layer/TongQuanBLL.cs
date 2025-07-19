using DoAn.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;

public class TongQuanBLL
{
    private readonly DataDbContext context = new DataDbContext();

    public int LaySoLuongXeTheoLoai(string loaiXe)
    {
        var soLuong = context.TonXe
            .Join(context.ThongTinXe, tx => tx.maXe, tt => tt.maXe, (tx, tt) => new { tx, tt })
            .Join(context.DongXe, temp => temp.tt.maDongXe, dx => dx.maDongXe, (temp, dx) => new { temp.tx, dx })
            .Where(x => x.dx.loaiXe == loaiXe)
            .Sum(x => (int?)x.tx.soLuong) ?? 0;

        return soLuong;
    }

    public decimal LayTongDoanhThu()
    {
        return context.HoaDon.Sum(h => (decimal?)h.tongTien) ?? 0;
    }

    public int LaySoLuongDonHang()
    {
        return context.HoaDon.Count();
    }

    public List<(string TenXe, int SoLuong)> LayTopSanPhamBanChay(int topN = 5)
    {
        var topSP = context.ChiTietHoaDon
            .GroupBy(c => c.maXe)
            .Select(g => new
            {
                MaXe = g.Key,
                SoLuong = g.Sum(x => x.soLuong)
            })
            .OrderByDescending(x => x.SoLuong)
            .Take(topN)
            .Join(context.ThongTinXe, g => g.MaXe, tt => tt.maXe, (g, tt) => new
            {
                tt.tenXe,
                g.SoLuong
            })
            .ToList()
            .Select(x => (x.tenXe, x.SoLuong))
            .ToList();

        return topSP;
    }

    public List<(int Thang, decimal TongTien)> LayDoanhThuTheoThang()
    {
        var ds = context.HoaDon
            .Where(h => h.ngayLap != DateTime.MinValue)
            .GroupBy(h => h.ngayLap.Month)
            .Select(g => new
            {
                Thang = g.Key,
                TongTien = g.Sum(h => h.tongTien)
            })
            .OrderBy(x => x.Thang)
            .ToList()
            .Select(x => (x.Thang, x.TongTien))
            .ToList();

        return ds;
    }
}