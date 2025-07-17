using DoAn1.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public static class Session
    {
        public static NhanVien? NhanVienDangNhap { get; set; }
        public static string TenDangNhap { get; set; } = string.Empty;
        public static string MatKhau { get; set; } = string.Empty;
    }
}
