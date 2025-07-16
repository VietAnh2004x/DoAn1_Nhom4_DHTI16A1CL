using DoAn.Data_Transfer_Objects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1.Data_Transfer_Objects
{
    public class ChiTietHoaDon
    {
        [Column("MaHD", Order = 0)]
        [DisplayName("Mã Hóa Đơn")]
        [StringLength(20)]
        public string maHoaDon { get; set; } = string.Empty;

        [Column("MaXe", Order = 1)]
        [DisplayName("Mã Xe")]
        [StringLength(20)]
        public string maXe { get; set; } = string.Empty;

        [Required]
        [Column("SoLuong")]
        [DisplayName("Số Lượng")]
        public int soLuong { get; set; }

        [Required]
        [Column("DonGia")]
        [DisplayName("Đơn Giá")]
        [DataType(DataType.Currency)]
        public decimal donGia { get; set; }

        [ForeignKey("maHoaDon")]
        public virtual HoaDon HoaDon { get; set; } = null!;

        [ForeignKey("maXe")]
        public virtual ThongTinXe Xe { get; set; } = null!;

        public ChiTietHoaDon()
        {
            maHoaDon = string.Empty;
            maXe = string.Empty;
            soLuong = 0;
            donGia = 0m;
        }
    }
}
