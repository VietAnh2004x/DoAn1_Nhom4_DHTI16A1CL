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
                                       join xe in context.ThongTinXe
                                         on bh.maXe equals xe.maXe
                                       join hd in context.HoaDon
                                         on bh.maHoaDon equals hd.maHoaDon
                                       select new
                                       {
                                           bh.maBaoHanh,
                                           bh.maHoaDon,
                                           bh.maXe,
                                           tenXe = xe.tenXe,
                                           bh.ngayBatDau,
                                           bh.thoiHanThang
                                       }).ToList();

                dgvDSBaoHanh.DataSource = danhSachBaoHanh;

                // Đặt tên cột hiển thị
                dgvDSBaoHanh.Columns["maBaoHanh"]!.HeaderText = "Mã Bảo Hành";
                dgvDSBaoHanh.Columns["maHoaDon"]!.HeaderText = "Mã Hóa Đơn";
                dgvDSBaoHanh.Columns["maXe"]!.HeaderText = "Mã Xe";
                dgvDSBaoHanh.Columns["tenXe"]!.HeaderText = "Tên Xe";
                dgvDSBaoHanh.Columns["ngayBatDau"]!.HeaderText = "Ngày Bắt Đầu";
                dgvDSBaoHanh.Columns["thoiHanThang"]!.HeaderText = "Thời Hạn (Tháng)";

                // Chống xuống dòng ở header
                dgvDSBaoHanh.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // Căn giữa tiêu đề
                dgvDSBaoHanh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Tự động giãn cột theo nội dung lớn nhất (bao gồm cả header)
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
                DataGridViewRow row = dgvDSBaoHanh.Rows[e.RowIndex];

                txtMaBaoHanh.Text = row.Cells["maBaoHanh"].Value?.ToString();
                txtMaHoaDon.Text = row.Cells["maHoaDon"].Value?.ToString();
                txtMaXe.Text = row.Cells["maXe"].Value?.ToString();

                if (row.Cells["ngayBatDau"].Value != null &&
                    DateTime.TryParse(row.Cells["ngayBatDau"]!.Value!.ToString(), out DateTime ngayBD))
                {
                    if (ngayBD == DateTime.MinValue)
                    {
                        dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
                        dtpNgayBatDau.CustomFormat = " ";
                    }
                    else
                    {
                        dtpNgayBatDau.Value = ngayBD;
                        dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
                        dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
                    }
                }
                else
                {
                    dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
                    dtpNgayBatDau.CustomFormat = " ";
                }

                txtThoiHan.Text = row.Cells["thoiHanThang"].Value?.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBaoHanh.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn mã bảo hành để sửa.", "Thông báo");
                return;
            }

            if (!int.TryParse(txtThoiHan.Text, out int thoiHan))
            {
                MessageBox.Show("Thời hạn phải là số nguyên.", "Lỗi nhập liệu");
                return;
            }

            string maBH = txtMaBaoHanh.Text.Trim();

            using (var context = new DataDbContext())
            {
                var baoHanh = context.BaoHanh.FirstOrDefault(bh => bh.maBaoHanh == maBH);
                if (baoHanh != null)
                {
                    baoHanh.maHoaDon = txtMaHoaDon.Text.Trim();
                    baoHanh.maXe = txtMaXe.Text.Trim();

                    // Gán DateTime.MinValue nếu dtp hiển thị rỗng
                    if (dtpNgayBatDau.Format == DateTimePickerFormat.Custom && dtpNgayBatDau.CustomFormat == " ")
                    {
                        baoHanh.ngayBatDau = DateTime.MinValue;
                    }
                    else
                    {
                        baoHanh.ngayBatDau = dtpNgayBatDau.Value;
                    }

                    baoHanh.thoiHanThang = thoiHan;

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật bảo hành thành công!", "Thông báo");
                        LoadBaoHanh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi hệ thống");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bảo hành với mã: " + maBH, "Lỗi");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBaoHanh.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa hoặc nhập mã bảo hành.", "Thông báo");
                return;
            }

            string maBH = txtMaBaoHanh.Text.Trim();

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa bảo hành này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var context = new DataDbContext())
                {
                    var baoHanh = context.BaoHanh.FirstOrDefault(bh => bh.maBaoHanh == maBH);
                    if (baoHanh != null)
                    {
                        try
                        {
                            context.BaoHanh.Remove(baoHanh);
                            context.SaveChanges();
                            MessageBox.Show("Xóa bảo hành thành công!", "Thông báo");

                            LoadBaoHanh(); // Tải lại danh sách sau khi xóa
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi hệ thống");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bảo hành cần xóa.", "Lỗi");
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBaoHanh.Clear();
            txtMaHoaDon.Clear();
            txtMaXe.Clear();
            txtThoiHan.Clear();

            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = " ";

            txtMaBaoHanh.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemPhieuBaoHanh.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo");
                return;
            }

            using (var context = new DataDbContext())
            {
                var ketQua = context.BaoHanh
                    .Where(bh => bh.maBaoHanh.Contains(tuKhoa) || bh.maHoaDon.Contains(tuKhoa))
                    .Select(bh => new
                    {
                        bh.maBaoHanh,
                        bh.maHoaDon,
                        bh.maXe,
                        bh.ngayBatDau,
                        bh.thoiHanThang
                    })
                    .ToList();

                if (ketQua.Any())
                {
                    dgvDSBaoHanh.DataSource = ketQua;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo");
                }
            }
        }
    }
}
