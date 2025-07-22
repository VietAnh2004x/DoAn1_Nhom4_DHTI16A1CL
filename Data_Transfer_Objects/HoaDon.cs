using DoAn1.Data_Transfer_Objects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1.Data_Transfer_Objects
{
    public class HoaDon
    {
        [Key]
        [Column("MaHD")]
        [DisplayName("Mã Hóa Đơn")]
        [StringLength(10)]
        public string maHoaDon { get; set; }

        [Required]
        [Column("MaKH")]
        [DisplayName("Mã Khách Hàng")]
        [StringLength(10)]
        public string maKhachHang { get; set; }

        [Required]
        [Column("TenTaiKhoan")]
        [DisplayName("Tên Tài Khoản")]
        [StringLength(50)]
        public string tenTaiKhoan { get; set; }

        [Required]
        [Column("NgayLap")]
        [DisplayName("Ngày Lập")]
        [DataType(DataType.Date)]
        public DateTime ngayLap { get; set; }

        [Required]
        [Column("TongTien")]
        [DisplayName("Tổng Tiền")]
        public decimal tongTien { get; set; }

        

        [Required]
        [Column("PTThanhToan")]
        [DisplayName("Phương Thức Thanh Toán")]
        [StringLength(50)]
        public string phuongThucThanhToan { get; set; }

        // Liên kết khóa ngoại
        [ForeignKey("maKhachHang")]
        public virtual KhachHang? KhachHang { get; set; }

        [ForeignKey("tenTaiKhoan")]
        public virtual TaiKhoan? TaiKhoan { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new HashSet<ChiTietHoaDon>();
        public virtual ICollection<BaoHanh> BaoHanhs { get; set; } = new HashSet<BaoHanh>();
        public HoaDon()
        {
            maHoaDon = string.Empty;
            maKhachHang = string.Empty;
            tenTaiKhoan = string.Empty;
            phuongThucThanhToan = string.Empty;
            ngayLap = DateTime.Now;
            tongTien = 0;
        }
    }
}
