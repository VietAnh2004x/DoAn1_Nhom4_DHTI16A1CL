using DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn.Data_Transfer_Objects
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
        [ForeignKey("maKhachHang")]
        public virtual KhachHang KhachHang { get; set; } = null!;

        [ForeignKey("tenTaiKhoan")]
        public virtual TaiKhoan? TaiKhoan { get; set; }
        public virtual ICollection<BaoHanh> BaoHanhs { get; set; } = new HashSet<BaoHanh>();
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new HashSet<ChiTietHoaDon>();

        public HoaDon()
        {
            maHoaDon = string.Empty;
            maKhachHang = string.Empty;
            tenTaiKhoan = string.Empty;
            ngayLap = DateTime.Now;
            tongTien = 0;
        }
    }
}
