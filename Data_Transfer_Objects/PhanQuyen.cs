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
    public class PhanQuyen
    {
        [Key]
        [Column("MaQuyen")]
        [DisplayName("Mã Quyền")]
        public int maQuyen { get; set; }

        [Required]
        [Column("TenQuyen")]
        [DisplayName("Tên Quyền")]
        [StringLength(50)]
        public string tenQuyen { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }

        public PhanQuyen()
        {
            maQuyen = 0;
            tenQuyen = string.Empty;
            TaiKhoans = new HashSet<TaiKhoan>();
        }

    }
}
