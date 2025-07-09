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
