using DoAn.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    public partial class usXeMayDien : UserControl
    {
        public usXeMayDien()
        {
            InitializeComponent();
            using (var context = new DataDbContext())
            {
                BindingSource xeMaypDienBindingSource = new BindingSource();
                xeMaypDienBindingSource.DataSource = context.ThongTinXe.Where(d => d.maDongXe == "1").ToList();
                dgvDSXeMayDien.DataSource = xeMaypDienBindingSource;
                dgvDSXeMayDien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDSXeMayDien.Columns["gia"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";
                dgvDSXeMayDien.Columns["DaiLy"]!.Visible = false;
                dgvDSXeMayDien.Columns["DongXe"]!.Visible = false;
                dgvDSXeMayDien.Columns["ChiTietHoaDons"]!.Visible = false;
                dgvDSXeMayDien.Columns["BaoHanhs"]!.Visible = false;
                dgvDSXeMayDien.Columns["HinhAnh"]!.Visible = false; // Ẩn cột hình ảnh nếu không cần hiển thị
                dgvDSXeMayDien.Columns["TonXes"]!.Visible = false;
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
    }
}
