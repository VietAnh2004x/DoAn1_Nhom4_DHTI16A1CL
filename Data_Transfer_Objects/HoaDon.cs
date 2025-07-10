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
    public class HoaDon
    {
        [Key]
        [Column("MaHD")]
        [DisplayName("Mã Hóa Đơn")]
        [StringLength(20)]
        public string maHoaDon { get; set; }

        [Required]
        [Column("MaKH")]
        [DisplayName("Mã Khách Hàng")]
        [StringLength(20)]
        public string maKhachHang { get; set; }

        [Required]
        [Column("TenNhanVien")]
        [DisplayName("Tên Nhân Viên")]
        [StringLength(100)]
        public string tenNhanVien { get; set; }

        [Required]
        [Column("NgayLap")]
        [DisplayName("Ngày Lập")]
        [DataType(DataType.Date)]
        public DateTime ngayLap { get; set; }

        [Required]
        [Column("TongTien")]
        [DisplayName("Tổng Tiền")]
        [DataType(DataType.Currency)]
        public decimal tongTien { get; set; }

        [ForeignKey("maKhachHang")]
        public virtual KhachHang? KhachHang { get; set; }
        [ForeignKey("tenNhanVien")]
        public virtual TaiKhoan? TaiKhoan { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<BaoHanh> BaoHanhs { get; set; }

        public HoaDon()
        {
            maHoaDon = string.Empty;
            maKhachHang = string.Empty;
            tenNhanVien = string.Empty;
            ngayLap = DateTime.Now;
            tongTien = 0;
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            BaoHanhs = new HashSet<BaoHanh>();
        }
    }
}
