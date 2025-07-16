using DoAn1.Data_Transfer_Objects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn.Data_Transfer_Objects
{
    public class NhanVien
    {
        [Key]
        [Column("MaNV")]
        [DisplayName("Mã Nhân Viên")]
        [StringLength(10)]
        public string maNV { get; set; }

        [Required]
        [Column("TenTaiKhoan")]
        [DisplayName("Tên Tài Khoản")]
        [StringLength(50)]
        public string tenTK { get; set; }

        [Required]
        [Column("HoTen")]
        [DisplayName("Họ Tên")]
        [StringLength(100)]
        public string hoTen { get; set; }

        [Required]
        [Column("GioiTinh")]
        [DisplayName("Giới Tính")]
        [StringLength(10)]
        public string gioiTinh { get; set; }

        [Required]
        [Column("NgaySinh")]
        [DisplayName("Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime ngaySinh { get; set; }

        [Required]
        [Column("SoDienThoai")]
        [DisplayName("Số Điện Thoại")]
        [StringLength(15)]
        public string soDienThoai { get; set; }

        [Required]
        [Column("Email")]
        [DisplayName("Email")]
        [StringLength(100)]
        public string email { get; set; }

        [ForeignKey("tenTK")]
        public virtual TaiKhoan? TaiKhoan { get; set; }        

        public NhanVien()
        {
            maNV = string.Empty;
            tenTK = string.Empty;
            hoTen = string.Empty;
            gioiTinh = string.Empty;
            ngaySinh = DateTime.MinValue;
            soDienThoai = string.Empty;
            email = string.Empty;
        }
    }
}
