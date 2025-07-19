using DoAn.Data_Access_Layer;
using DoAn1.Data_Transfer_Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Forms.QLTonKho
{
    public partial class usTonKho : UserControl
    {
        public usTonKho()
        {
            InitializeComponent();
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            LoadTonXe();
        }
        public void LoadTonXe()
        {
            using (var context = new DataDbContext())
            {
                var danhSachTonXe = (from ton in context.TonXe
                                     join xe in context.ThongTinXe
                                     on ton.maXe equals xe.maXe
                                     select new
                                     {
                                         ton.maNhap,
                                         ton.maXe,
                                         xe.tenXe,
                                         ton.ngayNhap,
                                         ton.soLuong,
                                         ton.donGiaNhap
                                     }).ToList();

                dgvDSTonKho.DataSource = null;  // Xóa datasource cũ
                dgvDSTonKho.DataSource = danhSachTonXe;
            }

            // Đặt tiêu đề cột
            dgvDSTonKho.Columns["maNhap"]!.HeaderText = "Mã Nhập";
            dgvDSTonKho.Columns["maXe"]!.HeaderText = "Mã Xe";
            dgvDSTonKho.Columns["tenXe"]!.HeaderText = "Tên Xe";
            dgvDSTonKho.Columns["ngayNhap"]!.HeaderText = "Ngày Nhập";
            dgvDSTonKho.Columns["soLuong"]!.HeaderText = "Số Lượng";
            dgvDSTonKho.Columns["donGiaNhap"]!.HeaderText = "Đơn Giá Nhập";


            // Format tiền tệ
            dgvDSTonKho.Columns["donGiaNhap"]!.DefaultCellStyle.Format = "N0";


            // Căn chỉnh chung
            dgvDSTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Căn giữa tiêu đề & tắt xuống dòng
            dgvDSTonKho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTonKho.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

        }

        private void dgvDSTonKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDSTonKho.Rows[e.RowIndex].Cells["tenXe"].Value != null)
            {
                DataGridViewRow row = dgvDSTonKho.Rows[e.RowIndex];
                txtMaXe.Text = row.Cells["maXe"].Value?.ToString();
                txtTenXe.Text = row.Cells["tenXe"].Value?.ToString();

                // Chuyển sang dùng DateTimePicker thay vì TextBox
                dtpNgayNhap.Value = Convert.ToDateTime(row.Cells["ngayNhap"].Value);

                txtSoLuong.Text = row.Cells["soLuong"].Value?.ToString();
                txtDongianhap.Text = Convert.ToDecimal(row.Cells["donGiaNhap"].Value).ToString("N0") + " VNĐ";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSTonKho.CurrentRow == null || dgvDSTonKho.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng được chọn
            DataGridViewRow selectedRow = dgvDSTonKho.CurrentRow;

            if (selectedRow.Cells["maNhap"].Value == null)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maNhap = selectedRow.Cells["maNhap"].Value.ToString();

            using (var context = new DataDbContext())
            {
                var tonXe = context.TonXe.FirstOrDefault(x => x.maNhap == maNhap);

                if (tonXe == null)
                {
                    MessageBox.Show("Không tìm thấy bản ghi để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Kiểm tra dữ liệu nhập
                    if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtDongianhap.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cập nhật dữ liệu
                    tonXe.soLuong = int.Parse(txtSoLuong.Text);
                    tonXe.ngayNhap = dtpNgayNhap.Value; // Sử dụng DateTimePicker
                    tonXe.donGiaNhap = decimal.Parse(txtDongianhap.Text.Replace("VNĐ", "").Replace(",", "").Trim());

                    context.SaveChanges();
                    LoadTonXe();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Dữ liệu không đúng định dạng. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvDSTonKho.CurrentRow == null || dgvDSTonKho.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            // Lấy dòng đang được chọn
            DataGridViewRow selectedRow = dgvDSTonKho.CurrentRow;

            // Kiểm tra xem giá trị maNhap có tồn tại không
            if (selectedRow.Cells["maNhap"].Value == null)
            {
                MessageBox.Show("Không thể lấy thông tin Mã Nhập để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maNhap = selectedRow.Cells["maNhap"].Value.ToString();

            using (var context = new DataDbContext())
            {
                var tonXe = context.TonXe.FirstOrDefault(x => x.maNhap == maNhap);

                if (tonXe != null)
                {
                    context.TonXe.Remove(tonXe);
                    context.SaveChanges();
                    LoadTonXe();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaXe.Clear();
            txtTenXe.Clear();
            dtpNgayNhap.Value = DateTime.Now;
            txtSoLuong.Clear();
            txtDongianhap.Clear();
            txtTimKiem.Clear();
            LoadTonXe();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Bỏ kiểm tra txtTenXe vì giờ tự lấy
            if (string.IsNullOrWhiteSpace(txtMaXe.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtDongianhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataDbContext())
            {
                var maXe = txtMaXe.Text.Trim();
                var xe = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);

                if (xe == null)
                {
                    MessageBox.Show("Không tìm thấy xe có mã tương ứng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật tên xe lên textbox để hiển thị luôn
                txtTenXe.Text = xe.tenXe;

                // Sinh mã nhập tự động: N001, N002,...
                string maMoi;

                var danhSachMaNhap = context.TonXe
                    .Where(x => x.maNhap.StartsWith("N"))
                    .Select(x => x.maNhap)
                    .ToList();

                int maxSo = 0;

                foreach (var ma in danhSachMaNhap)
                {
                    if (int.TryParse(ma.Substring(1), out int so))
                    {
                        if (so > maxSo)
                            maxSo = so;
                    }
                }

                maMoi = "N" + (maxSo + 1).ToString("D3"); // Tăng số và format 3 chữ số

                try
                {
                    var tonXe = new TonXe
                    {
                        maNhap = maMoi,
                        maXe = xe.maXe,
                        ngayNhap = dtpNgayNhap.Value, // Dùng DateTimePicker
                        soLuong = int.Parse(txtSoLuong.Text),
                        donGiaNhap = decimal.Parse(txtDongianhap.Text.Replace("VNĐ", "").Replace(",", "").Trim())
                    };

                    context.TonXe.Add(tonXe);
                    context.SaveChanges();
                    LoadTonXe();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Dữ liệu số không hợp lệ! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            using (var context = new DataDbContext())
            {
                var danhSach = (from ton in context.TonXe
                                join xe in context.ThongTinXe on ton.maXe equals xe.maXe
                                select new
                                {
                                    ton.maNhap,
                                    ton.maXe,
                                    xe.tenXe,
                                    ton.ngayNhap,
                                    ton.soLuong,
                                    ton.donGiaNhap

                                }).ToList();


                var ketQua = danhSach.Where(x =>
                    x.maNhap.ToLower().Contains(tuKhoa) ||
                    x.maXe.ToLower().Contains(tuKhoa) ||
                    x.tenXe.ToLower().Contains(tuKhoa) ||
                    x.ngayNhap.ToString("dd/MM/yyyy").Contains(tuKhoa) ||
                    x.soLuong.ToString().Contains(tuKhoa) ||
                    x.donGiaNhap.ToString().Contains(tuKhoa)
                ).ToList();

                dgvDSTonKho.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadTonXe();
            }
        }

        private void txtMaXe_Leave(object sender, EventArgs e)
        {
            string maXe = txtMaXe.Text.Trim();
            if (string.IsNullOrEmpty(maXe))
            {
                txtTenXe.Text = "";
                return;
            }

            using (var context = new DataDbContext())
            {
                var xe = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                if (xe != null)
                {
                    txtTenXe.Text = xe.tenXe;
                }
                else
                {
                    txtTenXe.Text = "";
                    // Bạn có thể hiện message hoặc không
                    // MessageBox.Show("Mã xe không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
