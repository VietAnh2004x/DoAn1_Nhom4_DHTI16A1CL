using DoAn1.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1.Data_Transfer_Objects
{
    public class BaoHanh
    {
        [Key]
        [Column("MaBH")]
        [DisplayName("Mã Bảo Hành")]
        [StringLength(20)]
        public string maBaoHanh { get; set; } = string.Empty;

        [Required]
        [Column("MaHD")]
        [DisplayName("Mã Hóa Đơn")]
        [StringLength(20)]
        public string maHoaDon { get; set; } = string.Empty;

        [Required]
        [Column("MaXe")]
        [DisplayName("Mã Xe")]
        [StringLength(20)]
        public string maXe { get; set; } = string.Empty;

        [Required]
        [Column("NgayBatDau")]
        [DisplayName("Ngày Bắt Đầu")]
        public DateTime ngayBatDau { get; set; }

        [Required]
        [Column("ThoiHanThang")]
        [DisplayName("Thời Hạn (Tháng)")]
        public int thoiHanThang { get; set; }

        [ForeignKey("maHoaDon")]
        public virtual HoaDon HoaDon { get; set; } = null!;

        [ForeignKey("maXe")]
        public virtual ThongTinXe? Xe { get; set; }
        public virtual ICollection<LichSuBaoHanh> LichSuBaoHanhs { get; set; } 
        public BaoHanh()
        {
            maBaoHanh = string.Empty;
            maHoaDon = string.Empty;
            maXe = string.Empty;
            ngayBatDau = DateTime.MinValue;
            thoiHanThang = 0;
        }
    }
}
