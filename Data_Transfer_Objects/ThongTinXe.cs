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
    public class ThongTinXe
    {
        [Key]
        [Column("MaXe")]
        [DisplayName("Mã Xe")]
        [StringLength(20)]
        public string maXe { get; set; }

        [Required]
        [Column("TenXe")]
        [DisplayName("Tên Xe")]
        [StringLength(100)]
        public string tenXe { get; set; }

        [Required]
        [Column("MaDaiLy")]
        [DisplayName("Mã Đại Lý")]
        [StringLength(20)]
        public string maDaiLy { get; set; }

        [Required]
        [Column("MaDongXe")]
        [DisplayName("Mã Dòng Xe")]
        [StringLength(20)]
        public string maDongXe { get; set; }

        [Required]
        [Column("MauSac")]
        [DisplayName("Màu Sắc")]
        [StringLength(50)]
        public string mauSac { get; set; }

        [Required]
        [Column("SoBinhAcQuy")]
        [DisplayName("Số Bình Ắc Quy")]
        [StringLength(50)]
        public string soBinhAcQuy { get; set; }

        [Required]
        [Column("DungLuongAcQuy")]
        [DisplayName("Dung Lượng Ắc Quy (Ah)")]
        [StringLength(50)]
        public string dungLuongAcQuy { get; set; }

        [Required]
        [Column("GiaNhap")]
        [DisplayName("Giá Bán (VNĐ)")]
        [DataType(DataType.Currency)]
        public decimal gia { get; set; }

        [Column("HinhAnh")]
        [DisplayName("Hình Ảnh")]
        [StringLength(200)]
        public string hinhAnh { get; set; }

        [ForeignKey("maDaiLy")]
        public virtual DaiLy? DaiLy { get; set; }
        [ForeignKey("maDongXe")]
        public virtual DongXe? DongXe { get; set; }

        public virtual ICollection<BaoHanh> BaoHanhs { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<TonXe> TonXes { get; set; }

        public ThongTinXe()
        {
            maXe = string.Empty;
            tenXe = string.Empty;
            maDaiLy = string.Empty;
            maDongXe = string.Empty;
            mauSac = string.Empty;
            soBinhAcQuy = string.Empty;
            dungLuongAcQuy = string.Empty;
            gia = 0;
            hinhAnh = string.Empty;
            BaoHanhs = new HashSet<BaoHanh>();
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            TonXes = new HashSet<TonXe>();
        }

    }
}
