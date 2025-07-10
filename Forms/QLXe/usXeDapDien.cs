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
    public partial class usXeDapDien : UserControl
    {
        public usXeDapDien()
        {
            InitializeComponent();
            using (var context = new DataDbContext())
            {
                BindingSource xeDapDienBindingSource = new BindingSource();
                xeDapDienBindingSource.DataSource = context.ThongTinXe.Where(d => d.maDongXe == "2").ToList();
                dgvDSXeDapDien.DataSource = xeDapDienBindingSource;
                dgvDSXeDapDien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDSXeDapDien.Columns["gia"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";

                dgvDSXeDapDien.Columns["DaiLy"]!.Visible = false;
                dgvDSXeDapDien.Columns["DongXe"]!.Visible = false;
                dgvDSXeDapDien.Columns["ChiTietHoaDons"]!.Visible = false;
                dgvDSXeDapDien.Columns["BaoHanhs"]!.Visible = false;
                dgvDSXeDapDien.Columns["HinhAnh"]!.Visible = false; // Ẩn cột hình ảnh nếu không cần hiển thị
                dgvDSXeDapDien.Columns["TonXes"]!.Visible = false;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuThemXe phieuThemXeForm = new frmPhieuThemXe();
            if (phieuThemXeForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm xe đạp điện thành công!");
            else
                MessageBox.Show("Thêm xe đạp điện thất bại!");
        }

    }
}
