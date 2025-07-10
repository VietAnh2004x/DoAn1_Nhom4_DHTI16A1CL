using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLTonKho
{
    public partial class usTonKho : UserControl
    {
        public usTonKho()
        {
            InitializeComponent();
            BindingSource tonKhoBindingSource = new BindingSource();
            using (var context = new DoAn.Data_Access_Layer.DataDbContext())
            {
                tonKhoBindingSource.DataSource = context.TonXe.ToList();
                dgvDSTonKho.DataSource = tonKhoBindingSource;
                dgvDSTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDSTonKho.Columns["Xe"]!.Visible = false;
            }
        }
    }
}
