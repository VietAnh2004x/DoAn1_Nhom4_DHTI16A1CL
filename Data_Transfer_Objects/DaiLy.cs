using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects
{
    public class DaiLy
    {
        [Key]
        [Column("MaDaiLy")]
        [DisplayName("Mã Đại Lý")]
        [StringLength(20)]
        public string maDaiLy { get; set; }

        [Required]
        [Column("TenDaiLy")]
        [DisplayName("Tên Đại Lý")]
        [StringLength(100)]
        public string tenDaiLy { get; set; }

        [Required]
        [Column("DiaChi")]
        [DisplayName("Địa Chỉ")]
        [StringLength(200)]
        public string diaChi { get; set; }

        [Required]
        [EmailAddress]
        [Column("Email")]
        [DisplayName("Email")]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [Phone]
        [Column("SoDienThoai")]
        [DisplayName("Số Điện Thoại")]
        [StringLength(15)]
        public string soDienThoai { get; set; }

        public virtual ICollection<ThongTinXe> Xes { get; set; }
        public DaiLy()
        {
            maDaiLy = string.Empty;
            tenDaiLy = string.Empty;
            diaChi = string.Empty;
            email = string.Empty;
            soDienThoai = string.Empty;
            Xes = new HashSet<ThongTinXe>();
        }

    }
}
