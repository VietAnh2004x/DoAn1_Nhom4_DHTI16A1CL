using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLHoaDon
{
    public partial class usHoaDon : UserControl
    {
        public usHoaDon()
        {
            InitializeComponent();
            using (var context = new DoAn.Data_Access_Layer.DataDbContext())
            {
                BindingSource hoaDonBindingSource = new BindingSource();
                hoaDonBindingSource.DataSource = context.HoaDon.ToList();
                dgvDSHoaDon.DataSource = hoaDonBindingSource;

                dgvDSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDSHoaDon.Columns["tongTien"]!.DefaultCellStyle.Format = "#,##0 'VNĐ'";

                dgvDSHoaDon.Columns["ChiTietHoaDons"]!.Visible = false;
                dgvDSHoaDon.Columns["BaoHanhs"]!.Visible = false;
                dgvDSHoaDon.Columns["KhachHang"]!.Visible = false;
                dgvDSHoaDon.Columns["TaiKhoan"]!.Visible = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuHoaDon frmPhieuHoaDon = new frmPhieuHoaDon();
            if (frmPhieuHoaDon.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm hóa đơn thành công!");
            else
                MessageBox.Show("Thêm hóa đơn thất bại!");
        }
    }
}
