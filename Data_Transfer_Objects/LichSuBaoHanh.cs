using DoAn.Data_Transfer_Objects;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn.Data_Transfer_Objects
{
    public class LichSuBaoHanh
    {
        [Key]
        [Column("MaLSBH")]
        [DisplayName("Mã Lịch Sử Bảo Hành")]
        [StringLength(10)]
        public string MaLSBH { get; set; }

        [Required]
        [Column("MaBH")]
        [DisplayName("Mã Bảo Hành Gốc")]
        [StringLength(10)]
        public string maBaoHanh { get; set; }

        [Required]
        [Column("NgayBaoHanh")]
        [DisplayName("Ngày Bảo Hành")]
        [DataType(DataType.Date)]
        public DateTime NgayBaoHanh { get; set; }

        [Required]
        [Column("NoiDungBaoHanh")]
        [DisplayName("Nội Dung Bảo Hành")]
        [StringLength(255)]
        public string NoiDungBaoHanh { get; set; }

        [Column("MaNV")]
        [DisplayName("Mã Nhân Viên")]
        [StringLength(10)]
        public string? maNV { get; set; } 

        [Column("GhiChu")]
        [DisplayName("Ghi Chú")]
        [StringLength(255)]
        public string? GhiChu { get; set; }

        [ForeignKey("maBaoHanh")]
        public virtual BaoHanh? BaoHanh { get; set; }

        [ForeignKey("maNV")]
        public virtual NhanVien? NhanVien { get; set; }

        public LichSuBaoHanh()
        {
            MaLSBH = string.Empty;
            maBaoHanh = string.Empty;
            NoiDungBaoHanh = string.Empty;
            NgayBaoHanh = DateTime.MinValue;
            maNV = null;
            GhiChu = string.Empty;
        }
    }
}
