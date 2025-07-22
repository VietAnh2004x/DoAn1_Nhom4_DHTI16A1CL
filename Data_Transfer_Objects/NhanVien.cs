using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects
{
    public class NhanVien
    {
        [Key]
        [Column("MaNV")]
        [DisplayName("Mã Nhân Viên")]
        [StringLength(10)]
        public string maNV { get; set; }

        [Required]
        [Column("TenTaiKhoan")]
        [DisplayName("Tên Tài Khoản")]
        [StringLength(50)]
        public string tenTaiKhoan { get; set; }

        [Required]
        [Column("HoTen")]
        [DisplayName("Họ Tên")]
        [StringLength(100)]
        public string hoTen { get; set; }

        [Required]
        [Column("GioiTinh")]
        [DisplayName("Giới Tính")]
        [StringLength(10)]
        public string gioiTinh { get; set; }

        [Required]
        [Column("NgaySinh")]
        [DisplayName("Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime ngaySinh { get; set; }

        [Required]
        [Column("SoDienThoai")]
        [DisplayName("Số Điện Thoại")]
        [StringLength(15)]
        public string soDienThoai { get; set; }

        [Required]
        [Column("Email")]
        [DisplayName("Email")]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [Column("NgayVaoLam")]
        [DisplayName("Ngày Vào Làm")]
        [DataType(DataType.Date)]
        public DateTime ngayVaoLam { get; set; }

        // Liên kết đến bảng TaiKhoan
        [ForeignKey("tenTaiKhoan")]
        public virtual TaiKhoan? TaiKhoan { get; set; }
        public virtual ICollection<GiaoDichXeCu> GiaoDichXeCus { get; set; } 
        public virtual ICollection<LichSuBaoHanh> LichSuBaoHanhs { get; set; }
        public NhanVien()
        {
            maNV = string.Empty;
            tenTaiKhoan = string.Empty;
            hoTen = string.Empty;
            gioiTinh = string.Empty;
            ngaySinh = DateTime.MinValue;
            ngayVaoLam = DateTime.MinValue;
            soDienThoai = string.Empty;
            email = string.Empty;
            GiaoDichXeCus = new HashSet<GiaoDichXeCu>();
            LichSuBaoHanhs = new HashSet<LichSuBaoHanh>();
        }
    }
}
