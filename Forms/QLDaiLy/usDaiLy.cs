using DoAn.Data_Access_Layer;
using DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLDaiLy
{
    public partial class usDaiLy : UserControl
    {
        public usDaiLy()
        {
            InitializeComponent();
            using (var context = new DataDbContext())
            {
                BindingSource daiLyBindingSource = new BindingSource();
                daiLyBindingSource.DataSource = context.Daily.ToList();
                dgvDSDaiLy.DataSource = daiLyBindingSource;

                dgvDSDaiLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDSDaiLy.Columns["Xes"]!.Visible = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuDaiLy phieuDaiLyForm = new frmPhieuDaiLy();
            if (phieuDaiLyForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm đại lý thành công!");
            else
                MessageBox.Show("Thêm đại lý thất bại!");
        }
    }
}
