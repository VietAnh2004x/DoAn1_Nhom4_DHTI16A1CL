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
        [StringLength(20)]
        public string maNhap { get; set; }

        [Required]
        [Column("MaXe")]
        [DisplayName("Mã Xe")]
        [StringLength(20)]
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

        [ForeignKey("maXe")]
        public virtual ThongTinXe? ThongTinXe { get; set; }
        public TonXe()
        {
            maNhap = string.Empty;
            maXe = string.Empty;
            ngayNhap = DateTime.MinValue;
            soLuong = 0;
        }

    }
}
