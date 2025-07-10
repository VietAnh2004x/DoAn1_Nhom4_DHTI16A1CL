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
    internal class DongXe
    {
        [Key]
        [Column("MaDongXe")]
        [DisplayName("Mã Dòng Xe")]
        [StringLength(20)]
        public string maDongXe { get; set; }

        [Required]
        [Column("LoaiXe")]
        [DisplayName("Loại Xe")]
        [StringLength(50)]
        public string loaiXe { get; set; }

        public virtual ICollection<ThongTinXe> Xes { get; set; }

        public DongXe()
        {
            maDongXe = string.Empty;
            loaiXe = string.Empty;
            Xes = new HashSet<ThongTinXe>();
        }

    }
}
