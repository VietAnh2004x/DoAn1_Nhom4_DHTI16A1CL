using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public string tenTaiKhoan { get; set; }

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

        [ForeignKey("tenTaiKhoan")]
        public virtual TaiKhoan? TaiKhoan { get; set; }

        public NhanVien()
        {
            maNV = string.Empty;
            tenTaiKhoan = string.Empty;
            hoTen = string.Empty;
            gioiTinh = string.Empty;
            ngaySinh = DateTime.MinValue;
            soDienThoai = string.Empty;
            email = string.Empty;
        }
    }
}
