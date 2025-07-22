using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoHanh
{
    public partial class usBaoHanh : UserControl
    {
        public usBaoHanh()
        {
            InitializeComponent();
            using (var context = new DoAn1_Nhom4_DHTI16A1CL.Data_Access_Layer.DataDbContext())
            {
                BindingSource baoHanhBindingSource = new BindingSource();
                baoHanhBindingSource.DataSource = context.BaoHanh.ToList();
                dgvDSBaoHanh.DataSource = baoHanhBindingSource;
                dgvDSBaoHanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDSBaoHanh.Columns["HoaDon"]!.Visible = false;
                dgvDSBaoHanh.Columns["Xe"]!.Visible = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuBaoHanh phieuBaoHanhForm = new frmPhieuBaoHanh();
            if (phieuBaoHanhForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm phiếu bảo hành thành công!");
            else
                MessageBox.Show("Thêm phiếu bảo hành thất bại!");
        }

    }
}
