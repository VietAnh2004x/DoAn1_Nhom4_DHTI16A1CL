using DoAn.Data_Transfer_Objects;
using DoAn1.Data_Transfer_Objects;
using Microsoft.EntityFrameworkCore;
using DoAn.Data_Transfer_Objects;

namespace DoAn.Data_Access_Layer
{
    internal class DataDbContext : DbContext
    {
        public DbSet<BaoHanh> BaoHanh { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<DaiLy> DaiLy { get; set; }
        public DbSet<DongXe> DongXe { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<PhanQuyen> PhanQuyen { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<TonXe> TonXe { get; set; }
        public DbSet<ThongTinXe> ThongTinXe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QLXe;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Khóa chính tổng hợp ChiTietHoaDon
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasKey(ct => new { ct.maHoaDon, ct.maXe });

            // Quan hệ 1-n: HoaDon - ChiTietHoaDon
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.ChiTietHoaDons)
                .HasForeignKey(ct => ct.maHoaDon);

            // Quan hệ 1-n: Xe - ChiTietHoaDon
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.Xe)
                .WithMany(x => x.ChiTietHoaDons)
                .HasForeignKey(ct => ct.maXe);

            // Quan hệ 1-n: DaiLy - Xe
            modelBuilder.Entity<ThongTinXe>()
                .HasOne(x => x.DaiLy)
                .WithMany(dl => dl.Xes)
                .HasForeignKey(x => x.maDaiLy);

            // Quan hệ 1-n: DongXe - Xe
            modelBuilder.Entity<ThongTinXe>()
                .HasOne(x => x.DongXe)
                .WithMany(dx => dx.Xes)
                .HasForeignKey(x => x.maDongXe);

            // Quan hệ 1-n: Xe - TonXe
            modelBuilder.Entity<TonXe>()
                .HasOne(tx => tx.Xe)
                .WithMany(x => x.TonXes)
                .HasForeignKey(tx => tx.maXe);

            // Quan hệ 1-n: Xe - BaoHanh
            modelBuilder.Entity<BaoHanh>()
                .HasOne(bh => bh.Xe)
                .WithMany(x => x.BaoHanhs)
                .HasForeignKey(bh => bh.maXe);

            // Quan hệ 1-n: HoaDon - BaoHanh
            modelBuilder.Entity<BaoHanh>()
                 .HasOne(bh => bh.HoaDon)
                 .WithMany(hd => hd.BaoHanhs)
                 .HasForeignKey(bh => bh.maHoaDon); 


            // Quan hệ 1-n: PhanQuyen - TaiKhoan
            modelBuilder.Entity<TaiKhoan>()
                .HasOne(tk => tk.PhanQuyen)
                .WithMany(pq => pq.TaiKhoans)
                .HasForeignKey(tk => tk.maQuyen);

            // Quan hệ 1-n: KhachHang - HoaDon
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.KhachHang)            
                .WithMany(kh => kh.HoaDons)            
                .HasForeignKey(hd => hd.maKhachHang);

            // Quan hệ 1-n: TaiKhoan - HoaDon
            modelBuilder.Entity<TaiKhoan>()
                .HasMany(tk => tk.HoaDons)
                .WithOne(hd => hd.TaiKhoan)
                .HasForeignKey(hd => hd.tenTK);

            // Quan hệ 1-1: NhanVien - TaiKhoan
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.TaiKhoan)
                .WithOne(tk => tk.NhanVien)
                .HasForeignKey<NhanVien>(nv => nv.tenTK);
        }
    }
}
