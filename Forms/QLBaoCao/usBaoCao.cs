using DoAn.Business_Logic_Layer;
using DoAn.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoCao
{
    public partial class usBaoCao : UserControl
    {
        private DataDbContext context = new DataDbContext();
        private BaoCaoBLL baoCaoBLL = new BaoCaoBLL();
        public usBaoCao()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date;
            string loaiThongKe = cboLuaChon.SelectedItem?.ToString() ?? "Xe Điện";
            if (loaiThongKe == "Xe Điện")
            {
                var thongKe = (from hd in context.HoaDon
                               join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                               join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                               join dong in context.DongXe on xe.maDongXe equals dong.maDongXe
                               where hd.ngayLap >= ngayBatDau
                                     && hd.ngayLap <= ngayKetThuc
                                     && (dong.maDongXe == "1" || dong.maDongXe == "2")
                               select new
                               {
                                   MaHoaDon = hd.maHoaDon,
                                   TenXe = xe.tenXe,
                                   MauSac = xe.mauSac,
                                   SoBinhAcQuy = xe.soBinhAcQuy,
                                   DungLuongAcQuy = xe.dungLuongAcQuy,
                                   TongTien = hd.tongTien,
                                   LoaiXe = dong.loaiXe,
                                   NgayBan = hd.ngayLap
                               }).ToList();

                dgvThongKe.DataSource = thongKe;

                dgvThongKe.Columns["MaHoaDon"]!.HeaderText = "Mã Hóa Đơn";
                dgvThongKe.Columns["TenXe"]!.HeaderText = "Tên Xe";
                dgvThongKe.Columns["MauSac"]!.HeaderText = "Màu Sắc";
                dgvThongKe.Columns["SoBinhAcQuy"]!.HeaderText = "Số Bình Ắc Quy";
                dgvThongKe.Columns["DungLuongAcQuy"]!.HeaderText = "Dung Lượng Ắc Quy";
                dgvThongKe.Columns["TongTien"]!.HeaderText = "Tổng Tiền";
                dgvThongKe.Columns["LoaiXe"]!.HeaderText = "Loại Xe";
                dgvThongKe.Columns["NgayBan"]!.HeaderText = "Ngày Bán";

                // Format cột giá tiền
                dgvThongKe.Columns["TongTien"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";

            }
            else if (loaiThongKe == "Xe Máy Điện")
            {
                var thongKe = (from hd in context.HoaDon
                               join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                               join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                               join dong in context.DongXe on xe.maDongXe equals dong.maDongXe
                               where hd.ngayLap >= ngayBatDau
                                     && hd.ngayLap <= ngayKetThuc
                                     && dong.maDongXe == "1"
                               select new
                               {
                                   MaHoaDon = hd.maHoaDon,
                                   TenXe = xe.tenXe,
                                   MauSac = xe.mauSac,
                                   SoBinhAcQuy = xe.soBinhAcQuy,
                                   DungLuongAcQuy = xe.dungLuongAcQuy,
                                   TongTien = hd.tongTien,
                                   NgayBan = hd.ngayLap
                               }).ToList();

                dgvThongKe.DataSource = thongKe;

                // Đổi tên cột
                dgvThongKe.Columns["MaHoaDon"]!.HeaderText = "Mã Hóa Đơn";
                dgvThongKe.Columns["TenXe"]!.HeaderText = "Tên Xe";
                dgvThongKe.Columns["MauSac"]!.HeaderText = "Màu Sắc";
                dgvThongKe.Columns["SoBinhAcQuy"]!.HeaderText = "Số Bình Ắc Quy";
                dgvThongKe.Columns["DungLuongAcQuy"]!.HeaderText = "Dung Lượng Ắc Quy";
                dgvThongKe.Columns["TongTien"]!.HeaderText = "Tổng Tiền";
                dgvThongKe.Columns["NgayBan"]!.HeaderText = "Ngày Bán";

                // Format tiền
                dgvThongKe.Columns["TongTien"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";


            }
            else
            {
                var thongKe = (from hd in context.HoaDon
                               join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                               join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                               join dong in context.DongXe on xe.maDongXe equals dong.maDongXe
                               where hd.ngayLap >= ngayBatDau
                                     && hd.ngayLap <= ngayKetThuc
                                     && dong.maDongXe == "2"
                               select new
                               {
                                   MaHoaDon = hd.maHoaDon,
                                   TenXe = xe.tenXe,
                                   MauSac = xe.mauSac,
                                   SoBinhAcQuy = xe.soBinhAcQuy,
                                   DungLuongAcQuy = xe.dungLuongAcQuy,
                                   TongTien = hd.tongTien,
                                   NgayBan = hd.ngayLap
                               }).ToList();

                dgvThongKe.DataSource = thongKe;

                // Đổi tên cột
                dgvThongKe.Columns["MaHoaDon"]!.HeaderText = "Mã Hóa Đơn";
                dgvThongKe.Columns["TenXe"]!.HeaderText = "Tên Xe";
                dgvThongKe.Columns["MauSac"]!.HeaderText = "Màu Sắc";
                dgvThongKe.Columns["SoBinhAcQuy"]!.HeaderText = "Số Bình Ắc Quy";
                dgvThongKe.Columns["DungLuongAcQuy"]!.HeaderText = "Dung Lượng Ắc Quy";
                dgvThongKe.Columns["TongTien"]!.HeaderText = "Tổng Tiền";
                dgvThongKe.Columns["NgayBan"]!.HeaderText = "Ngày Bán";

                // Format tiền
                dgvThongKe.Columns["TongTien"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";
            }

            txtSoKhachHang.Text = baoCaoBLL.ThongKeKhachHang(ngayBatDau, ngayKetThuc, loaiThongKe).ToString();
            txtTongSoXeBanRa.Text = baoCaoBLL.ThongKeSoXeBanRa(ngayBatDau, ngayKetThuc, loaiThongKe).ToString();
            txtTongDoanhThu.Text = baoCaoBLL.ThongKeTongDoanhThu(ngayBatDau, ngayKetThuc, loaiThongKe);
            txtTongSoXeTheoLoai.Text = baoCaoBLL.ThongKeTongSoXeTheoLoai(ngayBatDau, ngayKetThuc, loaiThongKe).ToString();
        }
    }
}
