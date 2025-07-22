using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects
{
    public class TonXe
    {
        [Key]
        [Column("MaNhap")]
        [DisplayName("Mã Nhập")]
        [StringLength(10)]
        public string maNhap { get; set; }

        [Required]
        [Column("MaXe")]
        [DisplayName("Mã Xe")]
        [StringLength(10)]
        public string maXe { get; set; }

        [Required]
        [Column("NgayNhap")]
        [DisplayName("Ngày Nhập")]
        [DataType(DataType.Date)]
        public DateTime ngayNhap { get; set; }

        [Required]
        [Column("SoLuong")]
        [DisplayName("Số Lượng")]
        public int soLuong { get; set; }

        [Required]
        [Column("DonGiaNhap")]
        [DisplayName("Đơn Giá Nhập")]
        [DataType(DataType.Currency)]
        public decimal donGiaNhap { get; set; }

        [ForeignKey("maXe")]
        public virtual ThongTinXe? Xe { get; set; }

        public TonXe()
        {
            maNhap = string.Empty;
            maXe = string.Empty;
            ngayNhap = DateTime.Now;
            soLuong = 0;
            donGiaNhap = 0;
        }
    }
}
