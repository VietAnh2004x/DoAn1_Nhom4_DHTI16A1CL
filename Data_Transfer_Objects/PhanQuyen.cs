using DoAn1.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.Data_Transfer_Objects
{
    public class PhanQuyen
    {
        [Key]
        [Column("MaQuyen")]
        [DisplayName("Mã Quyền")]
        [StringLength(10)]
        public string maQuyen { get; set; } = string.Empty;


        [Required]
        [Column("TenQuyen")]
        [DisplayName("Tên Quyền")]
        [StringLength(50)]
        public string tenQuyen { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new HashSet<TaiKhoan>();

        public PhanQuyen()
        {
            maQuyen = "";
            tenQuyen = string.Empty;
            TaiKhoans = new HashSet<TaiKhoan>();
        }

    }
}
