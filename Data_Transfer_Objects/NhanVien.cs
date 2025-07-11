﻿using DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Data_Transfer_Objects
{
    public class NhanVien
    {
        [Key]
        [Column("MaNV")]
        [DisplayName("Mã Nhân Viên")]
        [StringLength(20)]
        public string maNV { get; set; }

        [Required]
        [Column("TenNV")]
        [DisplayName("Tên Nhân Viên")]
        [StringLength(100)]
        public string tenNV { get; set; }

        [Required]
        [Column("ChucVu")]
        [DisplayName("Chức Vụ")]
        [StringLength(50)]
        public string chucVu { get; set; }

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
        [Phone]
        [StringLength(15)]
        public string soDienThoai { get; set; }

        [Required]
        [Column("Email")]
        [DisplayName("Email")]
        [EmailAddress]
        [StringLength(100)]
        public string email { get; set; }

        public virtual TaiKhoan? TaiKhoan { get; set; }        

        public NhanVien()
        {
            maNV = string.Empty;
            tenNV = string.Empty;
            chucVu = string.Empty;
            gioiTinh = string.Empty;
            ngaySinh = DateTime.MinValue;
            soDienThoai = string.Empty;
            email = string.Empty;
        }
    }
}
