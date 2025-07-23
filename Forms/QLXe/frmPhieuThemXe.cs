using DoAn.Data_Access_Layer;
using DoAn.Data_Transfer_Objects;

namespace DoAn.Forms.QLXe
{
    public partial class frmPhieuThemXe : Form
    {
        // Đường dẫn tương đối folder ảnh trong thư mục chạy
        private readonly string imageFolder = Path.Combine("Resources", "hinhAnh");

        // Biến lưu đường dẫn tương đối của ảnh để lưu vào DB
        private string imagePath = null!;

        public frmPhieuThemXe()
        {
            InitializeComponent();
            this.Load += frmPhieuThemXe_Load!;
        }

        private void frmPhieuThemXe_Load(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                cboLoaiXe.DataSource = context.DongXe.ToList();
                cboLoaiXe.DisplayMember = "tenDongXe";
                cboLoaiXe.ValueMember = "maDongXe";
                cboLoaiXe.SelectedIndex = -1;

                cboTenDaiLy.DataSource = context.DaiLy.ToList();
                cboTenDaiLy.DisplayMember = "tenDaiLy";
                cboTenDaiLy.ValueMember = "maDaiLy";
                cboTenDaiLy.SelectedIndex = -1;
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh xe điện";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = ofd.FileName;
                    string fileName = Path.GetFileName(selectedPath); // Giữ nguyên tên file gốc

                    // Đường dẫn tới thư mục Resources\hinhAnh
                    string folderPath = Path.Combine(Application.StartupPath, "Resources", "hinhAnh");
                    if (!Directory.Exists(folderPath))
                        Directory.CreateDirectory(folderPath);

                    string targetPath = Path.Combine(folderPath, fileName);

                    // Nếu ảnh đang hiển thị thì dispose để tránh lỗi
                    if (picAnhXe.Image != null)
                    {
                        picAnhXe.Image.Dispose();
                        picAnhXe.Image = null;
                    }

                    // Copy file (cho phép ghi đè)
                    File.Copy(selectedPath, targetPath, true);

                    // Mở ảnh tránh bị khóa file
                    using (var fs = new FileStream(targetPath, FileMode.Open, FileAccess.Read))
                    {
                        picAnhXe.Image = Image.FromStream(fs);
                    }
                    picAnhXe.SizeMode = PictureBoxSizeMode.Zoom;

                    // Lưu tên file gốc
                    imagePath = fileName;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {


                var xe = new ThongTinXe
                {
                    maXe = txtMaXe.Text.Trim(),
                    tenXe = txtTenXe.Text.Trim(),
                    maDongXe = cboLoaiXe.SelectedValue?.ToString() ?? "",
                    maDaiLy = cboTenDaiLy.SelectedValue?.ToString() ?? "",
                    mauSac = txtMauSac.Text.Trim(),
                    dungLuongAcQuy = txtDungLuongAcQuy.Text.Trim(),
                    soBinhAcQuy = txtSoBinhAcQuy.Text.Trim(),
                    hinhAnh = imagePath,
                    giaBan = Convert.ToDecimal(txtGiaBan.Text.Trim())
                };



                using (var context = new DataDbContext())
                {
                    context.ThongTinXe.Add(xe);
                    context.SaveChanges();
                }

                MessageBox.Show("Thêm xe điện  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm load ảnh từ đường dẫn tương đối đã lưu trong DB
        private void LoadImageFromRelativePath(string relativePath)
        {
            if (string.IsNullOrEmpty(relativePath))
            {
                picAnhXe.Image = null;
                return;
            }

            string fullPath = Path.Combine(Application.StartupPath, relativePath);
            if (File.Exists(fullPath))
            {
                if (picAnhXe.Image != null)
                {
                    picAnhXe.Image.Dispose();
                    picAnhXe.Image = null;
                }
                using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    picAnhXe.Image = Image.FromStream(fs);
                }
                picAnhXe.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh: " + fullPath, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                picAnhXe.Image = null;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtMaXe.Clear();
            txtTenXe.Clear();
            cboLoaiXe.SelectedIndex = -1;
            cboTenDaiLy.SelectedIndex = -1;
            txtMauSac.Clear();
            txtGiaBan.Clear();
            txtDungLuongAcQuy.Clear();
            txtSoBinhAcQuy.Clear();
            if (picAnhXe.Image != null)
            {
                picAnhXe.Image.Dispose();
                picAnhXe.Image = null;
            }
            imagePath = null!;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
