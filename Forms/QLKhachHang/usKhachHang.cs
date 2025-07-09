using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLKhachHang
{
    public partial class usKhachHang : UserControl
    {
        public usKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuKhachHang phieuKhachHangForm = new frmPhieuKhachHang();
            if(phieuKhachHangForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm khách hàng thành công!");
            else
                MessageBox.Show("Thêm khách hàng thất bại!");
        }
    }
}
