using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Forms.QLXe
{
    public partial class frmPhieuThemXe : Form
    {
        public frmPhieuThemXe()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenXe.Clear();
            txtMauSac.Clear();
            cboLoaiXe.SelectedIndex = -1;
            txtDonGia.Clear();
            txtSoLuong.Clear();
            dtpNgayNhap.Value = DateTime.Now;
            txtDungLuongAcQuy.Clear();  
            txtNhaCungCap.Clear();
            txtSoBinhAcQuy.Clear();
            picAnhXe.Image = null;
        }
    }
}
