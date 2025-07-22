using DoAn.Data_Access_Layer;
using DoAn.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Forms.QLDaiLy
{
    public partial class usDaiLy : UserControl
    {
        public usDaiLy()
        {
            InitializeComponent();
            LoadDaiLy();
        }
        private void LoadDaiLy()
        {
            using (var context = new DataDbContext())
            {
                var danhSachDaiLy = context.DaiLy
                    .Select(dl => new
                    {
                        dl.maDaiLy,
                        dl.tenDaiLy,
                        dl.diaChi,
                        dl.soDienThoai,
                        dl.email
                    }).ToList();

                dgvDSDaiLy.DataSource = danhSachDaiLy;

                // Đặt tên cột hiển thị
                if (dgvDSDaiLy.Columns.Count > 0)
                {
                    dgvDSDaiLy.Columns["maDaiLy"]!.HeaderText = "Mã Đại Lý";
                    dgvDSDaiLy.Columns["tenDaiLy"]!.HeaderText = "Tên Đại Lý";
                    dgvDSDaiLy.Columns["diaChi"]!.HeaderText = "Địa Chỉ";
                    dgvDSDaiLy.Columns["soDienThoai"]!.HeaderText = "Số Điện Thoại";
                    dgvDSDaiLy.Columns["email"]!.HeaderText = "Email";
                }

                // ✅ Căn chỉnh tự động để tránh xuống dòng
                dgvDSDaiLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // ✅ Không cho phép header xuống dòng
                dgvDSDaiLy.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // ✅ Căn giữa nội dung trong header cho đẹp
                dgvDSDaiLy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuDaiLy phieuDaiLyForm = new frmPhieuDaiLy();
            phieuDaiLyForm.ShowDialog();
            LoadDaiLy();
        }

        private void dgvDSDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDSDaiLy.Rows[e.RowIndex].Cells["maDaiLy"].Value != null)
            {
                DataGridViewRow row = dgvDSDaiLy.Rows[e.RowIndex];

                txtMaDaiLy.Text = row.Cells["maDaiLy"].Value?.ToString();
                txtTenDaiLy.Text = row.Cells["tenDaiLy"].Value?.ToString();
                txtDiaChi.Text = row.Cells["diaChi"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["soDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMaDaiLy.Text))
            {
                MessageBox.Show("Vui lòng chọn đại lý cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataDbContext())
            {
                // Tìm đại lý theo mã
                var daiLy = context.DaiLy.FirstOrDefault(dl => dl.maDaiLy == txtMaDaiLy.Text);

                if (daiLy != null)
                {
                    // Cập nhật thông tin
                    daiLy.tenDaiLy = txtTenDaiLy.Text;
                    daiLy.diaChi = txtDiaChi.Text;
                    daiLy.soDienThoai = txtSoDienThoai.Text;
                    daiLy.email = txtEmail.Text;

                    context.SaveChanges();
                    MessageBox.Show("Sửa đại lý thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDaiLy(); // Load lại dữ liệu sau khi sửa
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đại lý để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDaiLy.Clear();
            txtTenDaiLy.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();

            txtMaDaiLy.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDaiLy.Text))
            {
                MessageBox.Show("Vui lòng chọn đại lý cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa đại lý này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (var context = new DataDbContext())
            {
                var maDL = txtMaDaiLy.Text;
                var daiLy = context.DaiLy.FirstOrDefault(dl => dl.maDaiLy == maDL);

                // ❗ Kiểm tra xem có xe nào đang tham chiếu đại lý này không
                bool coXeLienKet = context.ThongTinXe.Any(x => x.maDaiLy == maDL);

                if (coXeLienKet)
                {
                    MessageBox.Show("Không thể xóa vì có xe đang liên kết với đại lý này.", "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (daiLy != null)
                {
                    context.DaiLy.Remove(daiLy);
                    context.SaveChanges();

                    MessageBox.Show("Xóa đại lý thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDaiLy();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đại lý để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemDaiLy.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataDbContext())
            {
                var ketQua = context.DaiLy
                    .Where(dl =>
                        dl.maDaiLy.ToLower().Contains(tuKhoa) ||
                        dl.tenDaiLy.ToLower().Contains(tuKhoa) ||
                        dl.soDienThoai.ToLower().Contains(tuKhoa) ||
                        dl.email.ToLower().Contains(tuKhoa))
                    .Select(dl => new
                    {
                        dl.maDaiLy,
                        dl.tenDaiLy,
                        dl.diaChi,
                        dl.soDienThoai,
                        dl.email
                    }).ToList();

                if (ketQua.Count > 0)
                {
                    dgvDSDaiLy.DataSource = ketQua;

                    dgvDSDaiLy.Columns["maDaiLy"]!.HeaderText = "Mã Đại Lý";
                    dgvDSDaiLy.Columns["tenDaiLy"]!.HeaderText = "Tên Đại Lý";
                    dgvDSDaiLy.Columns["diaChi"]!.HeaderText = "Địa Chỉ";
                    dgvDSDaiLy.Columns["soDienThoai"]!.HeaderText = "Số Điện Thoại";
                    dgvDSDaiLy.Columns["email"]!.HeaderText = "Email";
                    dgvDSDaiLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvDSDaiLy_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDSDaiLy.Rows[e.RowIndex].Cells["maDaiLy"].Value != null)
            {
                DataGridViewRow row = dgvDSDaiLy.Rows[e.RowIndex];

                txtMaDaiLy.Text = row.Cells["maDaiLy"].Value?.ToString();
                txtTenDaiLy.Text = row.Cells["tenDaiLy"].Value?.ToString();
                txtDiaChi.Text = row.Cells["diaChi"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["soDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();
            }
        }
    }
}


