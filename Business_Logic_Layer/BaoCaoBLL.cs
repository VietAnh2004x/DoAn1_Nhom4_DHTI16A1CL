using DoAn1.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.Business_Logic_Layer
{
    public class BaoCaoBLL
    {
        private DataDbContext context = new DataDbContext();
        public string ThongKeTongDoanhThu(DateTime ngayBatDau, DateTime ngayKetThuc, string loaiThongKe)
        {
                var query = from hd in context.HoaDon
                            join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                            join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                            join dong in context.DongXe on xe.maDongXe equals dong.maDongXe
                            where hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc
                            select new { hd.tongTien, dong.maDongXe };

                if (loaiThongKe == "Xe Điện")
                    query = query.Where(x => x.maDongXe == "1" || x.maDongXe == "2");
                else if (loaiThongKe == "Xe Máy Điện")
                    query = query.Where(x => x.maDongXe == "1");
                else
                    query = query.Where(x => x.maDongXe == "2");

                decimal tong = query.Sum(x => x.tongTien);
                return tong.ToString("#,##0 'VNĐ'");
        }
        public int ThongKeKhachHang(DateTime NgayBatDau, DateTime NgayKetThuc, string loaiThongKe)
        {
            loaiThongKe = loaiThongKe.Trim().ToLower();

            var query = from hd in context.HoaDon
                        join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                        join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                        join dx in context.DongXe on xe.maDongXe equals dx.maDongXe
                        where hd.ngayLap >= NgayBatDau && hd.ngayLap <= NgayKetThuc
                        select new { hd.maKhachHang, dx.maDongXe };

            if (loaiThongKe == "xe điện")
                query = query.Where(x => x.maDongXe == "1" || x.maDongXe == "2");
            else if (loaiThongKe == "xe máy điện")
                query = query.Where(x => x.maDongXe == "1");
            else if (loaiThongKe == "xe đạp điện")
                query = query.Where(x => x.maDongXe == "2");

            return query.Select(x => x.maKhachHang).Distinct().Count();
        }

        public int ThongKeSoXeBanRa(DateTime ngayBatDau, DateTime ngayKetThuc, string loaiThongKe)
        {
                var query = from hd in context.HoaDon
                            join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                            join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                            join dong in context.DongXe on xe.maDongXe equals dong.maDongXe
                            where hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc
                            select new { ct.maXe, dong.maDongXe };

                if (loaiThongKe == "Xe Điện")
                    query = query.Where(x => x.maDongXe == "1" || x.maDongXe == "2");
                else if (loaiThongKe == "Xe Máy Điện")
                    query = query.Where(x => x.maDongXe == "1");
                else
                    query = query.Where(x => x.maDongXe == "2");

                return query.Count(); // Số lượng xe bán
        }
        public int ThongKeTongSoXeTheoLoai(DateTime NgayBatDau, DateTime NgayKetThuc, string LoaiThongKe)
        {
            var query = from hd in context.HoaDon
                        join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                        join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                        join dx in context.DongXe on xe.maDongXe equals dx.maDongXe
                        where hd.ngayLap >= NgayBatDau && hd.ngayLap <= NgayKetThuc
                        select new { dx.maDongXe, ct.maXe };

            if (LoaiThongKe == "Xe Điện")
                query = query.Where(x => x.maDongXe == "1" || x.maDongXe == "2");
            else if (LoaiThongKe == "Xe Máy Điện")
                query = query.Where(x => x.maDongXe == "1");
            else
                query = query.Where(x => x.maDongXe == "2");

            return query.Count();
        }
    }
}
