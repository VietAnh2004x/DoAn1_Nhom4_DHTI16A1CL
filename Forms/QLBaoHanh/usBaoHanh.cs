using DoAn1.Data_Access_Layer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn1.Forms.QLBaoHanh
{
    public partial class usBaoHanh : UserControl
    {
        public usBaoHanh()
        {
            InitializeComponent();
            SetupDateTimePicker();
            LoadBaoHanh();
        }

        private void SetupDateTimePicker()
        {
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = " "; // Hiển thị trống ban đầu
        }

        private void LoadBaoHanh()
        {
            using (var context = new DataDbContext())
            {
                var danhSachBaoHanh = (from bh in context.BaoHanh
                                       join xe in context.ThongTinXe on bh.maXe equals xe.maXe
                                       join hd in context.HoaDon on bh.maHoaDon equals hd.maHoaDon
                                       select new
                                       {
                                           bh.maBaoHanh,
                                           tenKhachHang = hd.KhachHang.hoTen,
                                           tenXe = xe.tenXe,
                                           bh.ngayBatDau,
                                           bh.thoiHanThang
                                       }).ToList();

                dgvDSBaoHanh.DataSource = danhSachBaoHanh;
                dgvDSBaoHanh.Columns["maBaoHanh"]!.HeaderText = "Mã Bảo Hành";
                dgvDSBaoHanh.Columns["tenKhachHang"]!.HeaderText = "Khách Hàng";
                dgvDSBaoHanh.Columns["tenXe"]!.HeaderText = "Tên Xe";
                dgvDSBaoHanh.Columns["ngayBatDau"]!.HeaderText = "Ngày Bắt Đầu";
                dgvDSBaoHanh.Columns["thoiHanThang"]!.HeaderText = "Thời Hạn (Tháng)";
                dgvDSBaoHanh.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                dgvDSBaoHanh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDSBaoHanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuBaoHanh phieuBaoHanhForm = new frmPhieuBaoHanh();
            phieuBaoHanhForm.ShowDialog();
            LoadBaoHanh(); // Tải lại danh sách sau khi thêm mới
        }

        private void dgvDSBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDSBaoHanh.Rows[e.RowIndex];

                txtMaBaoHanh.Text = row.Cells["maBaoHanh"].Value?.ToString();
                txtThoiHan.Text = row.Cells["thoiHanThang"].Value?.ToString();

                // Gán ngày
                if (row.Cells["ngayBatDau"].Value != null &&
                    DateTime.TryParse(row.Cells["ngayBatDau"].Value.ToString(), out DateTime ngayBD))
                {
                    dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
                    dtpNgayBatDau.CustomFormat = ngayBD == DateTime.MinValue ? " " : "dd/MM/yyyy";
                    if (ngayBD != DateTime.MinValue)
                        dtpNgayBatDau.Value = ngayBD;
                }
                else
                {
                    dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
                    dtpNgayBatDau.CustomFormat = " ";
                }

                // 👉 Gán thêm các thông tin mới:
                txtTenKhach.Text = row.Cells["tenKhachHang"].Value?.ToString();
                txtTenXe.Text = row.Cells["tenXe"].Value?.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBaoHanh.Text))
            {
                MessageBox.Show("Vui lòng chọn mã bảo hành để sửa.", "Thông báo");
                return;
            }

            if (!int.TryParse(txtThoiHan.Text, out int thoiHan))
            {
                MessageBox.Show("Thời hạn phải là số nguyên.", "Lỗi");
                return;
            }

            string maBH = txtMaBaoHanh.Text.Trim();

            using (var context = new DataDbContext())
            {
                var baoHanh = context.BaoHanh.FirstOrDefault(bh => bh.maBaoHanh == maBH);
                if (baoHanh != null)
                {
                    baoHanh.thoiHanThang = thoiHan;
                    baoHanh.ngayBatDau = (dtpNgayBatDau.CustomFormat == " ") ? DateTime.MinValue : dtpNgayBatDau.Value;

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        LoadBaoHanh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBaoHanh.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string maBH = txtMaBaoHanh.Text.Trim();
                using (var context = new DataDbContext())
                {
                    var bh = context.BaoHanh.FirstOrDefault(b => b.maBaoHanh == maBH);
                    if (bh != null)
                    {
                        context.BaoHanh.Remove(bh);
                        context.SaveChanges();
                        MessageBox.Show("Đã xóa.");
                        LoadBaoHanh();
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBaoHanh.Clear();
            txtThoiHan.Clear();
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = " ";
            txtMaBaoHanh.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemPhieuBaoHanh.Text.Trim();

            using (var context = new DataDbContext())
            {
                var ketQua = (from bh in context.BaoHanh
                              join xe in context.ThongTinXe on bh.maXe equals xe.maXe
                              join hd in context.HoaDon on bh.maHoaDon equals hd.maHoaDon
                              where bh.maBaoHanh.Contains(tuKhoa) ||
                                    hd.KhachHang.hoTen.Contains(tuKhoa)
                              select new
                              {
                                  bh.maBaoHanh,
                                  tenKhachHang = hd.KhachHang.hoTen,
                                  tenXe = xe.tenXe,
                                  bh.ngayBatDau,
                                  bh.thoiHanThang
                              }).ToList();

                dgvDSBaoHanh.DataSource = ketQua;

                if (!ketQua.Any())
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }
            }
        }

     
    }
}
