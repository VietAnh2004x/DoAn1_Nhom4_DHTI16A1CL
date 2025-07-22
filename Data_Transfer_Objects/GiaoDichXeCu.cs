using DoAn.Data_Transfer_Objects;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn.Data_Transfer_Objects
{
    public class GiaoDichXeCu
    {
        [Key]
        [Column("MaDoi")]
        [DisplayName("Mã Giao Dịch Đổi Xe")]
        [StringLength(10)]
        public string MaDoi { get; set; }

        [Required]
        [Column("MaKH")]
        [DisplayName("Mã Khách Hàng")]
        [StringLength(10)]
        public string maKhachHang { get; set; }

        [Required]
        [Column("MaNV")]
        [DisplayName("Mã Nhân Viên")]
        [StringLength(10)]
        public string maNV { get; set; }

        [Required]
        [Column("MaXe")]
        [DisplayName("Mã Xe Mới")]
        [StringLength(10)]
        public string maXe { get; set; }

        [Required]
        [Column("TenXeCu")]
        [DisplayName("Tên Xe Cũ")]
        [StringLength(100)]
        public string TenXeCu { get; set; }

        [Required]
        [Column("NamSanXuat")]
        [DisplayName("Năm Sản Xuất")]
        public int NamSanXuat { get; set; }

        [Required]
        [Column("SoKm")]
        [DisplayName("Số Km Đã Chạy")]
        public int SoKm { get; set; }

        [Required]
        [Column("TinhTrang")]
        [DisplayName("Tình Trạng Xe Cũ")]
        [StringLength(255)]
        public string TinhTrang { get; set; }

        [Required]
        [Column("GiaDinhGia")]
        [DisplayName("Giá Định Giá")]
        [DataType(DataType.Currency)]
        public decimal GiaDinhGia { get; set; }

        [Column("NgayDoi")]
        [DisplayName("Ngày Đổi Xe")]
        [DataType(DataType.Date)]
        public DateTime NgayDoi { get; set; } 


        [ForeignKey("maKhachHang")]
        public virtual KhachHang? KhachHang { get; set; }

        [ForeignKey("maNV")]
        public virtual NhanVien? NhanVien { get; set; }

        [ForeignKey("maXe")]
        public virtual ThongTinXe? ThongTinXe { get; set; }

        public GiaoDichXeCu()
        {
            MaDoi = string.Empty;
            maKhachHang = string.Empty;
            maNV = string.Empty;
            maXe = string.Empty;
            TenXeCu = string.Empty;
            TinhTrang = string.Empty;
        }
    }
}
