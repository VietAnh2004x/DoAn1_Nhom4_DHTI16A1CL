using DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects; // Đảm bảo namespace đúng
using Microsoft.EntityFrameworkCore;

namespace DoAn1_Nhom4_DHTI16A1CL.Data_Access_Layer
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() { }

        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        // DbSet của các entities của bạn
        public DbSet<NhanVien> NhanVien { get; set; } = null!;
        public DbSet<TaiKhoan> TaiKhoan { get; set; } = null!;
        public DbSet<PhanQuyen> PhanQuyen { get; set; } = null!;
        public DbSet<KhachHang> KhachHang { get; set; } = null!;
        public DbSet<HoaDon> HoaDon { get; set; } = null!;
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; } = null!;
        public DbSet<DaiLy> DaiLy { get; set; } = null!;
        public DbSet<ThongTinXe> ThongTinXe { get; set; } = null!;
        public DbSet<DongXe> DongXe { get; set; } = null!;
        public DbSet<TonXe> TonXe { get; set; } = null!;
        public DbSet<BaoHanh> BaoHanh { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLXe;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Quan hệ 1-1: NhanVien có một TaiKhoan và TaiKhoan có một NhanVien duy nhất
            // Đảm bảo sử dụng tenTK trong NhanVien
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.TaiKhoan)
                .WithOne(tk => tk.NhanVien)
                .HasForeignKey<NhanVien>(nv => nv.tenTK); // Sử dụng tenTK

            // Quan hệ 1-n: TaiKhoan có nhiều HoaDon
            // Đảm bảo sử dụng tenTK trong HoaDon
            modelBuilder.Entity<TaiKhoan>()
                .HasMany(tk => tk.HoaDons)
                .WithOne(hd => hd.TaiKhoan)
                .HasForeignKey(hd => hd.tenTK); // Sử dụng tenTK

            // Quan hệ 1-n: KhachHang có nhiều HoaDon
            modelBuilder.Entity<KhachHang>()
                .HasMany(kh => kh.HoaDons)
                .WithOne(hd => hd.KhachHang)
                .HasForeignKey(hd => hd.maKhachHang);

            // Quan hệ 1-n: HoaDon có nhiều ChiTietHoaDon
            modelBuilder.Entity<HoaDon>()
                .HasMany(hd => hd.ChiTietHoaDons)
                .WithOne(ct => ct.HoaDon)
                .HasForeignKey(ct => ct.maHoaDon);

            // Quan hệ 1-n: ThongTinXe có nhiều ChiTietHoaDon
            modelBuilder.Entity<ThongTinXe>()
                .HasMany(xe => xe.ChiTietHoaDons)
                .WithOne(ct => ct.ThongTinXe)
                .HasForeignKey(ct => ct.maXe);

            // Quan hệ 1-n: DongXe có nhiều ThongTinXe
            modelBuilder.Entity<DongXe>()
                .HasMany(dong => dong.Xes) // Giả định bạn có ICollection<ThongTinXe> trong DongXe.cs
                .WithOne(xe => xe.DongXe)
                .HasForeignKey(xe => xe.maDongXe);

            // Quan hệ 1-n: ThongTinXe có nhiều TonXe
            modelBuilder.Entity<ThongTinXe>()
                .HasMany(xe => xe.TonXes) // Giả định bạn có ICollection<TonXe> trong ThongTinXe.cs
                .WithOne(tx => tx.ThongTinXe)
                .HasForeignKey(tx => tx.maXe);

            // Quan hệ 1-n: HoaDon có nhiều BaoHanh
            modelBuilder.Entity<HoaDon>()
                .HasMany(hd => hd.BaoHanhs)
                .WithOne(bh => bh.HoaDon)
                .HasForeignKey(bh => bh.maHopDong);


            base.OnModelCreating(modelBuilder);
        }
    }
}