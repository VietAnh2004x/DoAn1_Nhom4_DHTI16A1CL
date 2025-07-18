using DoAn.Data_Transfer_Objects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1.Data_Transfer_Objects
{
    public class ChiTietHoaDon
    {
        [Key, Column("MaHD", Order = 0)]
        [DisplayName("Mã Hóa Đơn")]
        [StringLength(10)]
        public string maHoaDon { get; set; } = string.Empty;

        [Key, Column("MaXe", Order = 1)]
        [DisplayName("Mã Xe")]
        [StringLength(10)]
        public string maXe { get; set; } = string.Empty;
        
        [Required]
        [Column("DonGia")]
        [DisplayName("Đơn Giá")]
        [DataType(DataType.Currency)]
        public decimal donGia { get; set; }

        [Column("GhiChuKhuyenMai")]
        [DisplayName("Ghi Chú Khuyến Mãi")]
        [StringLength(255)]
        public string? ghiChuKhuyenMai { get; set; }

        // Navigation properties
        [ForeignKey("maHoaDon")]
        public virtual HoaDon HoaDon { get; set; } = null!;

        [ForeignKey("maXe")]
        public virtual ThongTinXe Xe { get; set; } = null!;

        public ChiTietHoaDon()
        {
            maHoaDon = string.Empty;
            maXe = string.Empty;
            donGia = 0m;
            ghiChuKhuyenMai = string.Empty;
        }
    }
}
