using DoAn.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1.Data_Transfer_Objects
{
    public class ThongTinXe
    {
        [Key]
        [Column("MaXe")]
        [DisplayName("Mã Xe")]
        [StringLength(10)]
        public string maXe { get; set; }

        [Required]
        [Column("TenXe")]
        [DisplayName("Tên Xe")]
        [StringLength(100)]
        public string tenXe { get; set; }

        [Required]
        [Column("MaDaiLy")]
        [DisplayName("Mã Đại Lý")]
        [StringLength(10)]
        public string maDaiLy { get; set; }

        [Required]
        [Column("MaDongXe")]
        [DisplayName("Mã Dòng Xe")]
        [StringLength(10)]
        public string maDongXe { get; set; }

        [Required]
        [Column("MauSac")]
        [DisplayName("Màu Sắc")]
        [StringLength(200)]
        public string mauSac { get; set; }

        [Required]
        [Column("SoBinhAcQuy")]
        [DisplayName("Số Bình Ắc Quy")]
        [StringLength(100)]
        public string soBinhAcQuy { get; set; }

        [Required]
        [Column("DungLuongAcQuy")]
        [DisplayName("Dung Lượng Ắc Quy (Ah)")]
        [StringLength(20)]
        public string dungLuongAcQuy { get; set; }

        [Required]
        [Column("GiaBan")]
        [DisplayName("Giá Bán (VNĐ)")]
        [DataType(DataType.Currency)]
        public decimal giaBan { get; set; }

        [Column("HinhAnh")]
        [DisplayName("Hình Ảnh")]
        [StringLength(255)]
        public string hinhAnh { get; set; }

        [ForeignKey("maDaiLy")]
        public virtual DaiLy? DaiLy { get; set; }

        [ForeignKey("maDongXe")]
        public virtual DongXe? DongXe { get; set; }

        public virtual ICollection<BaoHanh> BaoHanhs { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<TonXe> TonXes { get; set; }
        public virtual ICollection<GiaoDichXeCu> GiaoDichXeCus { get; set; } = new List<GiaoDichXeCu>();
        public ThongTinXe()
        {
            maXe = string.Empty;
            tenXe = string.Empty;
            maDaiLy = string.Empty;
            maDongXe = string.Empty;
            mauSac = string.Empty;
            soBinhAcQuy = string.Empty;
            dungLuongAcQuy = string.Empty;
            giaBan = 0;
            hinhAnh = string.Empty;

            BaoHanhs = new HashSet<BaoHanh>();
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            TonXes = new HashSet<TonXe>();
        }
    }
}
