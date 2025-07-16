using DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn.Data_Transfer_Objects
{
    public class TaiKhoan
    {
        [Key]
        [Column("TenTaiKhoan")]
        [DisplayName("Tên Tài Khoản")]
        [StringLength(50)]
        public string tenTK { get; set; }

        [Required]
        [Column("MatKhau")]
        [DisplayName("Mật Khẩu")]
        [StringLength(100)]
        public string matKhau { get; set; }

        [Required]
        [Column("MaQuyen")]
        [DisplayName("Mã Quyền")]
        [StringLength(10)]
        public string maQuyen { get; set; }

        [ForeignKey("maQuyen")]
        public virtual PhanQuyen PhanQuyen { get; set; } = null!;

        public virtual NhanVien? NhanVien { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public TaiKhoan()
        {
            tenTK = string.Empty;
            matKhau = string.Empty;
            maQuyen = string.Empty;
            HoaDons = new HashSet<HoaDon>();
        }
    }
}
