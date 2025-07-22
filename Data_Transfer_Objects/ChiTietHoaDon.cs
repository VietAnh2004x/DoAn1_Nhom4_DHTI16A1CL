using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects
{
    public class ChiTietHoaDon
    {
        [Key]
        [Column("MaHD", Order = 0)]
        [DisplayName("Mã Hóa Đơn")]
        [StringLength(20)]
        public string maHoaDon { get; set; }

        [Required]
        [Column("MaXe", Order = 1)]
        [DisplayName("Mã Xe")]
        [StringLength(20)]
        public string maXe { get; set; }

        [Required]
        [Column("SoLuong")]
        [DisplayName("Số Lượng")]
        public int soLuong { get; set; }

        [Required]
        [Column("DonGia")]
        [DisplayName("Đơn Giá")]
        [DataType(DataType.Currency)]
        public double donGia { get; set; }

        [ForeignKey("maHoaDon")]
        public virtual HoaDon? HoaDon { get; set; }
        [ForeignKey("maXe")]
        public virtual ThongTinXe? ThongTinXe { get; set; }

        public ChiTietHoaDon()
        {
            maHoaDon = string.Empty;
            maXe = string.Empty;
            soLuong = 0;
            donGia = 0.0;
        }
    }
}
