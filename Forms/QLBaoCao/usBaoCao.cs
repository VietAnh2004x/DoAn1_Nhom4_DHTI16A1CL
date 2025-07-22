using DoAn1_Nhom4_DHTI16A1CL.Business_Logic_Layer;
using DoAn1_Nhom4_DHTI16A1CL.Data_Access_Layer;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; // Thêm dòng này để sử dụng Include

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoCao
{
    public partial class usBaoCao : UserControl
    {
        private readonly DataDbContext context = new DataDbContext();
        private readonly BaoCaoBLL baoCaoBLL = new BaoCaoBLL();

        public usBaoCao()
        {
            InitializeComponent();
        }

        private void usBaoCao_Load(object sender, EventArgs e)
        {
            // Khởi tạo cboChonThongKe
            cboChonThongKe.Items.Clear();
            cboChonThongKe.Items.AddRange(new[] { "Loại xe", "Nhân viên" });
            cboChonThongKe.SelectedIndex = 0; // Mặc định chọn "Loại xe"
        }

        private void cboChonThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedType = cboChonThongKe.SelectedItem?.ToString(); // Thêm ? để xử lý nullable
            cboChiTietThongKe.Items.Clear();

            if (selectedType == "Loại xe")
            {
                lblChonChiTietThongKe.Text = "Chọn loại xe:";
                cboChiTietThongKe.Items.AddRange(new[] { "Xe Điện", "Xe Máy Điện", "Xe Đạp Điện" });
                cboChiTietThongKe.SelectedIndex = 0; // Mặc định chọn "Xe Điện"

                // Cập nhật các label thống kê cho loại xe
                lblSL1.Text = "Tổng Doanh Thu:";
                lblSL2.Text = "Tổng Số Xe Bán Ra:";
                lblSL3.Text = "Tổng Số Xe Còn Kho:";
            }
            else if (selectedType == "Nhân viên")
            {
                lblChonChiTietThongKe.Text = "Chọn nhân viên:";
                // Load danh sách nhân viên vào cboChiTietThongKe
                // Vì NhanVien không có HoTen, ta sẽ dùng MaNV hoặc TenTK để hiển thị
                var nhanVienList = context.NhanVien.Select(nv => new { MaNV = nv.maNV, TenTaiKhoan = nv.tenTK }).ToList();
                cboChiTietThongKe.DisplayMember = "TenTaiKhoan"; // Hiển thị tên tài khoản của nhân viên
                cboChiTietThongKe.ValueMember = "MaNV"; // Set ValueMember to access MaNV
                cboChiTietThongKe.DataSource = nhanVienList;
                if (cboChiTietThongKe.Items.Count > 0)
                {
                    cboChiTietThongKe.SelectedIndex = 0;
                }

                // Cập nhật các label thống kê cho nhân viên
                lblSL1.Text = "Tổng Doanh Thu NV:";
                lblSL2.Text = "Tổng Xe NV Bán:";
                lblSL3.Text = "Tổng KH NV Xử lý:";
            }

            // Xóa dữ liệu cũ khi thay đổi loại thống kê
            dgvThongKe.DataSource = null;
            txtSL1.Text = string.Empty;
            txtSL2.Text = string.Empty;
            txtSL3.Text = string.Empty;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date;
            string? loaiThongKeChinh = cboChonThongKe.SelectedItem?.ToString();

            if (cboChiTietThongKe.SelectedItem == null)
            {
                MessageBox.Show($"Vui lòng chọn {lblChonChiTietThongKe.Text.Replace(":", "").Trim()}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Clear previous data
            dgvThongKe.DataSource = null;

            if (loaiThongKeChinh == "Loại xe")
            {
                string loaiXe = cboChiTietThongKe.SelectedItem.ToString()!;

                // Query data for DataGridView
                var data = (from hd in context.HoaDon.Include(hd => hd.KhachHang) // Include KhachHang
                            join ct in context.ChiTietHoaDon on hd.maHoaDon equals ct.maHoaDon
                            join xe in context.ThongTinXe on ct.maXe equals xe.maXe
                            join dong in context.DongXe on xe.maDongXe equals dong.maDongXe
                            where hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc
                            select new
                            {
                                MaHoaDon = hd.maHoaDon,
                                TenXe = xe.tenXe,
                                LoaiXe = dong.loaiXe,
                                MauSac = xe.mauSac,
                                SoLuong = ct.soLuong,
                                DonGia = ct.donGia,
                                ThanhTien = ct.soLuong * ct.donGia,
                                NgayBan = hd.ngayLap,
                                TenKhachHang = hd.KhachHang != null ? hd.KhachHang.hoTen : "N/A" // Null check for KhachHang
                            });

                if (loaiXe == "Xe Điện")
                    data = data.Where(x => x.LoaiXe == "Xe Máy Điện" || x.LoaiXe == "Xe Đạp Điện");
                else
                    data = data.Where(x => x.LoaiXe == loaiXe);

                dgvThongKe.DataSource = data.ToList();
                dgvThongKe.Columns["ThanhTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
                dgvThongKe.Columns["DonGia"].DefaultCellStyle.Format = "#,##0 'VNĐ'";

                // Display summary statistics
                txtSL1.Text = baoCaoBLL.ThongKeTongDoanhThuTheoLoaiXe(ngayBatDau, ngayKetThuc, loaiXe);
                txtSL2.Text = baoCaoBLL.ThongKeTongSoXeBanRaTheoLoaiXe(ngayBatDau, ngayKetThuc, loaiXe).ToString();
                txtSL3.Text = baoCaoBLL.ThongKeTongSoXeTonKhoTheoLoaiXe(loaiXe).ToString();
            }
            else if (loaiThongKeChinh == "Nhân viên")
            {
                // Correctly access MaNV from the selected item
                string maNhanVien = ((dynamic)cboChiTietThongKe.SelectedItem!).MaNV; // Sử dụng ! vì đã kiểm tra null ở trên

                // Query data for DataGridView (HoaDon by NhanVien)
                var data = (from hd in context.HoaDon
                                .Include(hd => hd.TaiKhoan) // Include TaiKhoan
                                .ThenInclude(tk => tk.NhanVien) // ThenInclude NhanVien từ TaiKhoan
                                .Include(hd => hd.KhachHang) // Include KhachHang
                            where hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc
                                  && hd.TaiKhoan != null // Kiểm tra TaiKhoan không null
                                  && hd.TaiKhoan.NhanVien != null // Kiểm tra NhanVien từ TaiKhoan không null
                                  && hd.TaiKhoan.NhanVien.maNV == maNhanVien // Truy cập maNV của NhanVien
                            select new
                            {
                                MaHoaDon = hd.maHoaDon,
                                NgayLap = hd.ngayLap,
                                TongTien = hd.tongTien,
                                TenKhachHang = hd.KhachHang != null ? hd.KhachHang.hoTen : "N/A", // Null check for KhachHang
                                // TrangThaiThanhToan = hd.trangThaiThanhToan
                            }).ToList();

                dgvThongKe.DataSource = data;
                dgvThongKe.Columns["TongTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";

                // Display summary statistics
                txtSL1.Text = baoCaoBLL.ThongKeTongDoanhThuTheoNhanVien(ngayBatDau, ngayKetThuc, maNhanVien);
                txtSL2.Text = baoCaoBLL.ThongKeSoXeBanRaTheoNhanVien(ngayBatDau, ngayKetThuc, maNhanVien).ToString();
                txtSL3.Text = baoCaoBLL.ThongKeSoKhachHangTheoNhanVien(ngayBatDau, ngayKetThuc, maNhanVien).ToString();
            }
        }
    }
}
