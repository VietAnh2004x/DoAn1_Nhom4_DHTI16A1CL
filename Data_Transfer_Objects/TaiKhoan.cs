﻿using DoAn.Data_Transfer_Objects;
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
    public class TaiKhoan
    {
        [Key]
        [Column("TenNhanVien")]
        [DisplayName("Tên Nhân Viên")]
        [StringLength(50)]
        public string tenNhanVien { get; set; }

        [Required]
        [Column("MatKhau")]
        [DisplayName("Mật Khẩu")]
        [StringLength(100)]
        public string matKhau { get; set; }

        [Required]
        [Column("MaQuyen")]
        [DisplayName("Mã Quyền")]
        public int maQuyen { get; set; }

        [ForeignKey("maQuyen")]
        public virtual PhanQuyen? PhanQuyen { get; set; }

        [ForeignKey("tenNhanVien")]

        public virtual NhanVien? NhanVien { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public TaiKhoan()
        {
            tenNhanVien = string.Empty;
            matKhau = string.Empty;
            maQuyen = 0;
            HoaDons = new HashSet<HoaDon>();
        }
    }
}
