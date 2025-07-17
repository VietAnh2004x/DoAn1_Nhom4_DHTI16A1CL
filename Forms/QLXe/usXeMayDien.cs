using DoAn1.Data_Access_Layer;
using System.Data;

namespace DoAn1.Forms.QLXe
{
    public partial class usXeMayDien : UserControl
    {
        public usXeMayDien()
        {
            InitializeComponent();
            loadDanhSachXe();
        }
        public void loadDanhSachXe()
        {

            using (var context = new DataDbContext())
            {
                BindingSource xeDapDienBindingSource = new BindingSource();
                var danhSach = context.ThongTinXe.Where(d => d.maDongXe == "1")
                    .Select(x => new
                    {
                        x.maXe,
                        x.tenXe,
                        x.mauSac,
                        x.dungLuongAcQuy,
                        x.soBinhAcQuy,
                        gia = x.giaBan,
                        x.hinhAnh
                    })
                    .ToList();

                xeDapDienBindingSource.DataSource = danhSach;
                dgvDSXeMayDien.DataSource = xeDapDienBindingSource;

                dgvDSXeMayDien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Định dạng số tiền
                if (dgvDSXeMayDien.Columns.Contains("gia"))
                    dgvDSXeMayDien.Columns["gia"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";

                // ⚡ Cập nhật tiêu đề tiếng Việt
                dgvDSXeMayDien.Columns["maXe"]!.HeaderText = "Mã Xe";
                dgvDSXeMayDien.Columns["tenXe"]!.HeaderText = "Tên Xe";
                dgvDSXeMayDien.Columns["mauSac"]!.HeaderText = "Màu Sắc";
                dgvDSXeMayDien.Columns["dungLuongAcQuy"]!.HeaderText = "Dung Lượng Ắc Quy";
                dgvDSXeMayDien.Columns["soBinhAcQuy"]!.HeaderText = "Số Bình Ắc Quy";
                dgvDSXeMayDien.Columns["gia"]!.HeaderText = "Giá Bán";
                dgvDSXeMayDien.Columns["hinhAnh"]!.HeaderText = "Hình Ảnh";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuThemXe phieuThemXeForm = new frmPhieuThemXe();
            if (phieuThemXeForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm xe máy điện thành công!");
            else
                MessageBox.Show("Thêm xe máy điện thất bại!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            txtTenXe.Clear();
            txtGia.Clear();
            txtMauSac.Clear();
            txtDungLuongAcQuy.Clear();
            txtSoBinhAcQuy.Clear();

            picAnhXe.Image = null;

            loadDanhSachXe();

            dgvDSXeMayDien.ClearSelection();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSXeMayDien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một xe cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maXe = dgvDSXeMayDien.CurrentRow.Cells["maXe"]!.Value?.ToString();
            if (string.IsNullOrEmpty(maXe))
            {
                MessageBox.Show("Không tìm thấy mã xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DataDbContext())
            {
                // Tìm xe trong cơ sở dữ liệu
                var xeCanSua = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                if (xeCanSua == null)
                {
                    MessageBox.Show("Không tìm thấy xe trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Cập nhật thông tin
                    xeCanSua.tenXe = txtTenXe.Text.Trim();
                    xeCanSua.mauSac = txtMauSac.Text.Trim();
                    xeCanSua.dungLuongAcQuy = txtDungLuongAcQuy.Text.Trim();
                    xeCanSua.soBinhAcQuy = txtSoBinhAcQuy.Text.Trim();
                    string giaText = txtGia.Text.Replace("VNĐ", "").Replace(",", "").Trim();
                    if (decimal.TryParse(giaText, out decimal giaMoi))
                    {
                        xeCanSua.giaBan = giaMoi;
                    }
                    else
                    {
                        MessageBox.Show("Giá không hợp lệ! Vui lòng nhập đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    xeCanSua.hinhAnh = picAnhXe.Text.Trim(); // bạn phải thêm txtHinhAnh vào form nếu muốn sửa ảnh

                    // Lưu thay đổi
                    context.SaveChanges();

                    MessageBox.Show("Sửa thông tin xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh lại danh sách
                    loadDanhSachXe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSXeMayDien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một xe để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maXe = dgvDSXeMayDien.CurrentRow.Cells["maXe"]?.Value?.ToString();
            if (string.IsNullOrWhiteSpace(maXe))
            {
                MessageBox.Show("Không tìm thấy mã xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var context = new DataDbContext())
                {
                    var xeCanXoa = context.ThongTinXe.FirstOrDefault(x => x.maXe == maXe);
                    if (xeCanXoa == null)
                    {
                        MessageBox.Show("Không tìm thấy xe trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Xóa các liên kết phụ thuộc (nếu có)
                    var chiTietHoaDons = context.ChiTietHoaDon.Where(c => c.maXe == maXe);
                    var baoHanhs = context.BaoHanh.Where(b => b.maXe == maXe);
                    var tonXes = context.TonXe.Where(t => t.maXe == maXe);

                    context.ChiTietHoaDon.RemoveRange(chiTietHoaDons);
                    context.BaoHanh.RemoveRange(baoHanhs);
                    context.TonXe.RemoveRange(tonXes);

                    // Xóa xe chính
                    context.ThongTinXe.Remove(xeCanXoa);

                    // Lưu thay đổi
                    context.SaveChanges();

                    MessageBox.Show("Xóa xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachXe(); // Tải lại danh sách xe
                }
            }
            catch (Exception ex)
            {
                string loi = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Lỗi khi xóa xe: " + loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void dgvDSXeMayDien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSXeMayDien.Rows.Count)
            {
                DataGridViewRow row = dgvDSXeMayDien.Rows[e.RowIndex];

               
                txtTenXe.Text = row.Cells["tenXe"]?.Value?.ToString() ?? "";
                txtGia.Text = Convert.ToDecimal(row.Cells["gia"]?.Value ?? 0).ToString("#,##0 'VNĐ'");
                txtMauSac.Text = row.Cells["mauSac"]?.Value?.ToString() ?? "";
                txtDungLuongAcQuy.Text = row.Cells["dungLuongAcQuy"]?.Value?.ToString() ?? "";
                txtSoBinhAcQuy.Text = row.Cells["soBinhAcQuy"]?.Value?.ToString() ?? "";

                // Lấy tên file ảnh từ cột "HinhAnh" (ví dụ: A105A.jpg)
                string imageName = row.Cells["HinhAnh"]?.Value?.ToString();

                // Lấy đường dẫn thư mục hiện tại của chương trình (thường là bin\Debug\netX...)
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Tạo đường dẫn đầy đủ đến ảnh trong folder Resources/hinhAnh
                string imagePath = Path.Combine(projectDirectory, "Resources", "hinhAnh", imageName);

                if (!string.IsNullOrEmpty(imageName) && File.Exists(imagePath))
                {
                    try
                    {
                        // Giải phóng ảnh cũ tránh rò rỉ bộ nhớ
                        picAnhXe.Image?.Dispose();

                        // Mở file ảnh bằng stream để tránh lỗi khóa file
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            picAnhXe.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        picAnhXe.Image = null;
                        MessageBox.Show("Lỗi khi load ảnh: " + ex.Message, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    picAnhXe.Image = null;
                    MessageBox.Show("Không tìm thấy ảnh: " + imagePath, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

