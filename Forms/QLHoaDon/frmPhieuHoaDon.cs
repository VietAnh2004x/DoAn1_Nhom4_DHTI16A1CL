
﻿using DoAn.Data_Access_Layer;
using DoAn.Data_Transfer_Objects;
using DoAn1.Data_Transfer_Objects;
using System;
using System.Linq;
using System.Windows.Forms;
﻿using DoAn1.Data_Access_Layer;
using DoAn1.Data_Transfer_Objects;

namespace DoAn1.Forms.QLHoaDon
{
    public partial class frmPhieuHoaDon : Form
    {
        public frmPhieuHoaDon()
        {
            InitializeComponent();

            txtGiaBan.TextChanged += TxtGiaBanOrKhuyenMai_TextChanged;
            txtKhuyenMai.TextChanged += TxtGiaBanOrKhuyenMai_TextChanged;

            cbbPTTT.Items.AddRange(new string[] { "Tiền mặt", "Chuyển khoản", "Ví điện tử" });
            cbbPTTT.SelectedIndex = 0;
        }

        private void frmPhieuHoaDon_Load(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void TxtGiaBanOrKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            if (decimal.TryParse(txtGiaBan.Text.Trim().Replace(",", ""), out decimal giaBan))
            {
                string kmText = txtKhuyenMai.Text.Trim().Replace("%", "");
                if (decimal.TryParse(kmText, out decimal khuyenMai))
                {
                    if (khuyenMai >= 0 && khuyenMai <= 100)
                    {
                        decimal tongTien = giaBan * (1 - khuyenMai / 100);
                        txtTongTien.Text = tongTien.ToString("N0");
                        return;
                    }
                }
            }

            txtTongTien.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                string tenKH = txtTenKhachHang.Text.Trim();
                string tenNV = txtTenNhanVien.Text.Trim();
                string maXe = txtMaXe.Text.Trim();
                string phuongThuc = cbbPTTT.Text.Trim();

                // Kiểm tra dữ liệu bắt buộc
                if (string.IsNullOrEmpty(tenKH))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tenNV))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(maXe))
                {
                    MessageBox.Show("Vui lòng nhập mã xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtGiaBan.Text.Replace(",", "").Trim(), out decimal giaBan) || giaBan <= 0)
                {
                    MessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string kmText = txtKhuyenMai.Text.Trim().Replace("%", "");
                if (!decimal.TryParse(kmText, out decimal khuyenMai) || khuyenMai < 0 || khuyenMai > 100)
                {
                    MessageBox.Show("Khuyến mãi không hợp lệ! (0-100%)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra khách hàng
                var khachHang = context.KhachHang.FirstOrDefault(kh => kh.hoTen == tenKH);
                if (khachHang == null)
                {
                    MessageBox.Show("Tên khách hàng không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra nhân viên
                var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.hoTen == tenNV);
                if (nhanVien == null)
                {
                    MessageBox.Show("Tên nhân viên không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra mã xe trong DB
                var xe = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                if (xe == null)
                {
                    MessageBox.Show("Mã xe không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime ngayLap = dtpNgayLap.Value;

                if (!decimal.TryParse(txtTongTien.Text.Replace(",", "").Trim(), out decimal tongTien))
                {
                    MessageBox.Show("Tổng tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo mã hóa đơn mới
                string newMaHD = "HD001";
                var lastHoaDon = context.HoaDon.OrderByDescending(hd => hd.maHoaDon).FirstOrDefault();
                if (lastHoaDon != null)
                {
                    string lastMaHD = lastHoaDon.maHoaDon.Substring(2);
                    if (int.TryParse(lastMaHD, out int num))
                    {
                        newMaHD = "HD" + (num + 1).ToString("D3");
                    }
                }

                // Tạo hóa đơn mới (không có maXe)
                var hoaDon = new HoaDon
                {
                    maHoaDon = newMaHD,
                    maKhachHang = khachHang.maKhachHang,
                    tenTaiKhoan = nhanVien.tenTaiKhoan,
                    ngayLap = ngayLap,
                    tongTien = tongTien,
                    phuongThucThanhToan = phuongThuc
                };

                context.HoaDon.Add(hoaDon);
                context.SaveChanges();

                // Tạo chi tiết hóa đơn chứa maXe
                var chiTiet = new ChiTietHoaDon
                {
                    maHoaDon = newMaHD,
                    maXe = maXe,

                    donGia = giaBan,
                    ghiChuKhuyenMai = khuyenMai.ToString() + "%"
                };

                context.ChiTietHoaDon.Add(chiTiet);
                context.SaveChanges();

                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtMaNV.Clear();
            txtTenKhachHang.Clear();
            txtTenNhanVien.Clear();
            txtMaXe.Clear();
            txtGiaBan.Clear();
            txtKhuyenMai.Clear();
            txtTongTien.Clear();
            cbbPTTT.SelectedIndex = 0;
            dtpNgayLap.Value = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                string maKH = txtMaKH.Text.Trim();

                var kh = context.KhachHang.FirstOrDefault(k => k.maKhachHang == maKH);
                if (kh != null)
                {
                    txtTenKhachHang.Text = kh.hoTen;
                }
                else
                {
                    txtTenKhachHang.Text = "";
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                string maNV = txtMaNV.Text.Trim();

                var nv = context.NhanVien.FirstOrDefault(n => n.maNV == maNV);
                if (nv != null)
                {
                    txtTenNhanVien.Text = nv.hoTen;
                }
                else
                {
                    txtTenNhanVien.Text = "";
                    MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtMaXe_Leave(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                string maXe = txtMaXe.Text.Trim();

                var xe = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                if (xe != null)
                {
                    txtTenXe.Text = xe.tenXe;
                    txtGiaBan.Text = xe.giaBan.ToString("N0"); // Hiển thị có dấu phân cách hàng nghìn
                }
                else
                {
                    txtTenXe.Text = "";
                    txtGiaBan.Text = "";
                    MessageBox.Show("Không tìm thấy xe với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
