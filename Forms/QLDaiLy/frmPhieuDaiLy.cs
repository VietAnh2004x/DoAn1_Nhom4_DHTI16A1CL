using DoAn1.Data_Access_Layer;
using DoAn1.Data_Transfer_Objects;
using System.Data;

namespace DoAn1.Forms.QLDaiLy
{
    public partial class frmPhieuDaiLy : Form
    {
        public frmPhieuDaiLy()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var context = new DataDbContext())
            {
                // Lấy phần số từ các mã có dạng "DL001", "DL002", ..., "DL100"
                var maLonNhat = context.DaiLy
                    .AsEnumerable() // Chuyển sang LINQ trên bộ nhớ (RAM)
                    .Select(dl => dl.maDaiLy)
                    .Where(ma => ma.StartsWith("DL"))
                    .Select(ma => int.Parse(ma.Substring(2)))
                    .DefaultIfEmpty(0)
                    .Max();

                string maDaiLyMoi = "DL" + (maLonNhat + 1).ToString("D3");

                var daily = new DaiLy
                {
                    maDaiLy = maDaiLyMoi,
                    tenDaiLy = txtTenDaiLy.Text.Trim(),
                    diaChi = txtDiaChi.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    soDienThoai = txtSoDienThoai.Text.Trim()
                };

                context.DaiLy.Add(daily);
                context.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            txtTenDaiLy.Clear();
        }
    }
}
