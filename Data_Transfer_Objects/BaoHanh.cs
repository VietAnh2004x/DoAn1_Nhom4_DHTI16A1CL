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
    public class BaoHanh
    {
        [Key]
        [Column("MaBH")]
        [DisplayName("Mã Bảo Hành")]
        [StringLength(20)]
        public string maBaoHanh { get; set; }

        [Required]
        [Column("MaHD")]
        [DisplayName("Mã Hợp Đồng")]
        [StringLength(20)]
        public string maHopDong { get; set; }

        [Required]
        [Column("MaXe")]
        [DisplayName("Mã Xe")]
        [StringLength(20)]
        public string maXe { get; set; }

        [Required]
        [Column("NgayBatDau")]
        [DisplayName("Ngày Bắt Đầu")]
        public DateTime ngayBatDau { get; set; }

        [Required]
        [Column("ThoiHanThang")]
        [DisplayName("Thời Hạn (Tháng)")]
        public int thoiHanThang { get; set; }

        [ForeignKey("maHopDong")]
        public virtual HoaDon? HoaDon { get; set; }
        [ForeignKey("maXe")]
        public virtual ThongTinXe? Xe { get; set; }

        public BaoHanh() {
            maBaoHanh = string.Empty;
            maHopDong = string.Empty;
            maXe = string.Empty;
            ngayBatDau = DateTime.MinValue;
            thoiHanThang = 0;
        }

    }
}
