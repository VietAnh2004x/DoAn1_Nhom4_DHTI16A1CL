using DoAn.Data_Access_Layer;
using System.Globalization;
using System.Data;

namespace DoAn.Forms.QLXe
{
    public partial class usXeCu : UserControl
    {
        public usXeCu()
        {
            InitializeComponent();
            LoadDanhSachXe();
        }

        public void LoadDanhSachXe()
        {
            using (var context = new DataDbContext())
            {
                var data = (from gd in context.GiaoDichXeCu
                            join kh in context.KhachHang on gd.maKhachHang equals kh.maKhachHang
                            join nv in context.NhanVien on gd.maNV equals nv.maNV
                            join xe in context.ThongTinXe on gd.maXe equals xe.maXe
                            select new
                            {
                                MaGiaoDich = gd.MaDoi,
                                TenKhachHang = kh.hoTen,
                                TenNhanVien = nv.hoTen,
                                TenXeMoi = xe.tenXe,
                                TenXeCu = gd.TenXeCu,
                                NamSanXuat = gd.NamSanXuat,
                                SoKm = gd.SoKm,
                                TinhTrang = gd.TinhTrang,
                                GiaDinhGia = gd.GiaDinhGia,
                                GiaXeMoi = xe.giaBan,
                                SoTienPhaiTra = xe.giaBan - gd.GiaDinhGia,
                                NgayDoi = gd.NgayDoi
                            }).ToList();

                dgvDSXeCu.DataSource = data;
            }

            // Cập nhật tên cột cho dễ nhìn
            dgvDSXeCu.Columns["MaGiaoDich"].HeaderText = "Mã Giao Dịch";
            dgvDSXeCu.Columns["TenKhachHang"].HeaderText = "Khách Hàng";
            dgvDSXeCu.Columns["TenNhanVien"].HeaderText = "Nhân Viên";
            dgvDSXeCu.Columns["TenXeMoi"].HeaderText = "Xe Mới";
            dgvDSXeCu.Columns["TenXeCu"].HeaderText = "Xe Cũ";
            dgvDSXeCu.Columns["NamSanXuat"].HeaderText = "Năm Sản Xuất";
            dgvDSXeCu.Columns["SoKm"].HeaderText = "Số Km";
            dgvDSXeCu.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            dgvDSXeCu.Columns["GiaDinhGia"].HeaderText = "Định Giá";
            dgvDSXeCu.Columns["GiaXeMoi"].HeaderText = "Giá Xe Mới";
            dgvDSXeCu.Columns["SoTienPhaiTra"].HeaderText = "Số Tiền Phải Trả";
            dgvDSXeCu.Columns["NgayDoi"].HeaderText = "Ngày Đổi";

            // Định dạng cột tiền
            dgvDSXeCu.Columns["GiaDinhGia"].DefaultCellStyle.Format = "#,##0 VNĐ";
            dgvDSXeCu.Columns["GiaXeMoi"].DefaultCellStyle.Format = "#,##0 VNĐ";
            dgvDSXeCu.Columns["SoTienPhaiTra"].DefaultCellStyle.Format = "#,##0 VNĐ";

            // Canh phải cột tiền cho dễ nhìn
            dgvDSXeCu.Columns["GiaDinhGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDSXeCu.Columns["GiaXeMoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDSXeCu.Columns["SoTienPhaiTra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Tự động co cột cho vừa khung
            dgvDSXeCu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDSXeCu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvDSXeCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDSXeCu.Rows[e.RowIndex];

            // Cập nhật mã giao dịch vào txtMaGD
            txtMaGD.Text = row.Cells["MaGiaoDich"].Value?.ToString() ?? "";

            txtTenKH.Text = row.Cells["TenKhachHang"].Value?.ToString() ?? "";
            txtTenXeCu.Text = row.Cells["TenXeCu"].Value?.ToString() ?? "";
            txtXeMuonDoi.Text = row.Cells["TenXeMoi"].Value?.ToString() ?? "";
            txtNSX.Text = row.Cells["NamSanXuat"].Value?.ToString() ?? "";
            txtSoKm.Text = row.Cells["SoKm"].Value?.ToString() ?? "";

            var culture = new CultureInfo("vi-VN");

            // Xử lý định giá
            string dinhGiaStr = row.Cells["GiaDinhGia"].Value?.ToString() ?? "";
            dinhGiaStr = dinhGiaStr.Replace(" VND", "").Trim();
            if (decimal.TryParse(dinhGiaStr, NumberStyles.Number, culture, out decimal dinhGia))
            {
                txtDinhGia.Text = dinhGia.ToString("N0", culture) + " VND";
            }
            else
            {
                txtDinhGia.Text = row.Cells["GiaDinhGia"].Value?.ToString() ?? "";
            }

            // Xử lý số tiền phải trả
            string soTienStr = row.Cells["SoTienPhaiTra"].Value?.ToString() ?? "";
            soTienStr = soTienStr.Replace(" VND", "").Trim();
            if (decimal.TryParse(soTienStr, NumberStyles.Number, culture, out decimal soTien))
            {
                txtSoTienPhaiTra.Text = soTien.ToString("N0", culture) + " VND";
            }
            else
            {
                txtSoTienPhaiTra.Text = row.Cells["SoTienPhaiTra"].Value?.ToString() ?? "";
            }

            txtTinhTrang.Text = row.Cells["TinhTrang"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["NgayDoi"].Value?.ToString(), out DateTime dt))
            {
                dtpNgayDoi.Format = DateTimePickerFormat.Short;
                dtpNgayDoi.Value = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhapXeCu NhapXeCuForm = new frmNhapXeCu();
            NhapXeCuForm.ShowDialog();
            LoadDanhSachXe();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGD.Clear();
            txtTenKH.Clear();
            txtTenXeCu.Clear();
            txtXeMuonDoi.Clear();
            txtNSX.Clear();
            txtSoKm.Clear();
            txtTinhTrang.Clear();
            txtDinhGia.Clear();
            txtSoTienPhaiTra.Clear();
            dtpNgayDoi.Value = DateTime.Today;

            LoadDanhSachXe();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                var giaoDich = context.GiaoDichXeCu.FirstOrDefault(g => g.MaDoi == txtMaGD.Text);
                if (giaoDich == null)
                {
                    MessageBox.Show("Không tìm thấy giao dịch để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var maXe = context.ThongTinXe.FirstOrDefault(x => x.tenXe == txtTenXeCu.Text)?.maXe;
                var maKH = context.KhachHang.FirstOrDefault(x => x.hoTen == txtTenKH.Text)?.maKhachHang;


                if (maXe == null || maKH == null)
                {
                    MessageBox.Show("Không tìm thấy mã xe, mã khách hàng hoặc mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                giaoDich.maKhachHang = maKH;

                giaoDich.maXe = maXe;
                giaoDich.TenXeCu = txtXeMuonDoi.Text;
                giaoDich.NamSanXuat = int.Parse(txtNSX.Text);
                giaoDich.SoKm = int.Parse(txtSoKm.Text);
                giaoDich.TinhTrang = txtTinhTrang.Text;
                giaoDich.GiaDinhGia = decimal.Parse(txtDinhGia.Text);
                giaoDich.NgayDoi = dtpNgayDoi.Value;

                context.SaveChanges();
                MessageBox.Show("Cập nhật giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachXe();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa giao dịch này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var context = new DataDbContext())
                {
                    var giaoDich = context.GiaoDichXeCu.FirstOrDefault(g => g.MaDoi == txtMaGD.Text);
                    if (giaoDich == null)
                    {
                        MessageBox.Show("Không tìm thấy giao dịch cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.GiaoDichXeCu.Remove(giaoDich);
                    context.SaveChanges();
                    MessageBox.Show("Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachXe();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            using (var context = new DataDbContext())
            {
                var ketQua = (from gd in context.GiaoDichXeCu
                              join kh in context.KhachHang on gd.maKhachHang equals kh.maKhachHang
                              join nv in context.NhanVien on gd.maNV equals nv.maNV
                              join xe in context.ThongTinXe on gd.maXe equals xe.maXe
                              where gd.MaDoi.Contains(tuKhoa) || kh.hoTen.Contains(tuKhoa)
                              select new
                              {
                                  MaGiaoDich = gd.MaDoi,
                                  TenKhachHang = kh.hoTen,
                                  TenNhanVien = nv.hoTen,
                                  TenXeMoi = xe.tenXe,
                                  TenXeCu = gd.TenXeCu,
                                  NamSanXuat = gd.NamSanXuat,
                                  SoKm = gd.SoKm,
                                  TinhTrang = gd.TinhTrang,
                                  GiaDinhGia = gd.GiaDinhGia,
                                  GiaXeMoi = xe.giaBan,
                                  SoTienPhaiTra = xe.giaBan - gd.GiaDinhGia,
                                  NgayDoi = gd.NgayDoi
                              }).ToList();

                dgvDSXeCu.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
