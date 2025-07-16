using DoAn.Data_Access_Layer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Forms.QLTonKho
{
    public partial class usTonKho : UserControl
    {
        public usTonKho()
        {
            InitializeComponent();
            LoadTonXe();
        }
        private void LoadTonXe()
        {
            using (var context = new DataDbContext())
            {
                var danhSachTonXe = (from ton in context.TonXe
                                     join xe in context.ThongTinXe
                                     on ton.maXe equals xe.maXe
                                     select new
                                     {
                                         ton.maNhap,
                                         ton.maXe,
                                         xe.tenXe,
                                         ton.ngayNhap,
                                         ton.soLuong
                                     }).ToList();
                dgvDSTonKho.DataSource = danhSachTonXe.ToList();
            }
            dgvDSTonKho.Columns["maNhap"].HeaderText = "Mã Nhập";
            dgvDSTonKho.Columns["maXe"].HeaderText = "Mã Xe";
            dgvDSTonKho.Columns["tenXe"].HeaderText = "Tên Xe";
            dgvDSTonKho.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
            dgvDSTonKho.Columns["soLuong"].HeaderText = "Số Lượng";

            dgvDSTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvDSTonKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDSTonKho.Rows[e.RowIndex].Cells["tenXe"].Value != null)
            {
                DataGridViewRow row = dgvDSTonKho.Rows[e.RowIndex];

                txtTenXe.Text = row.Cells["tenXe"].Value?.ToString();
                txtNgayNhap.Text = Convert.ToDateTime(row.Cells["ngayNhap"].Value).ToString("dd/MM/yyyy");
                txtSoLuong.Text = row.Cells["soLuong"].Value?.ToString();
            }
        }
    }
}
