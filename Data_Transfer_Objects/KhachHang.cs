using DoAn1.Data_Transfer_Objects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1.Data_Transfer_Objects
{
    public class KhachHang
    {
        [Key]
        [Column("MaKH")]
        [DisplayName("Mã Khách Hàng")]
        [StringLength(20)]
        public string maKhachHang { get; set; }

        [Required]
        [Column("HoTen")]
        [DisplayName("Họ Tên")]
        [StringLength(100)]
        public string hoTen { get; set; }

        [Required]
        [Column("DiaChi")]
        [DisplayName("Địa Chỉ")]
        [StringLength(200)]
        public string diaChi { get; set; }

        [Required]
        [Phone]
        [Column("SoDienThoai")]
        [DisplayName("Số Điện Thoại")]
        [StringLength(15)]
        public string soDienThoai { get; set; }

        [Required]
        [EmailAddress]
        [Column("Email")]
        [DisplayName("Email")]
        [StringLength(100)]
        public string email { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; } = new HashSet<HoaDon>();
        public virtual ICollection<GiaoDichXeCu> GiaoDichXeCus { get; set; } = new List<GiaoDichXeCu>();
        public KhachHang()
        {
            maKhachHang = string.Empty;
            hoTen = string.Empty;
            diaChi = string.Empty;
            soDienThoai = string.Empty;
            email = string.Empty;
            HoaDons = new HashSet<HoaDon>();
        }

    }
}
