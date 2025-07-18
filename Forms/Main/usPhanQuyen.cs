using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1.Data_Access_Layer;
using Microsoft.EntityFrameworkCore;
namespace DoAn.Forms.Main
{
    public partial class usPhanQuyen : UserControl
    {
        public usPhanQuyen()
        {
            InitializeComponent();
        }

        private void usPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
            LoadDanhSachQuyen();
        }

        private void LoadDanhSachTaiKhoan()
        {
            using (var context = new DataDbContext())
            {
                var taiKhoans = context.TaiKhoan
                    .Include(t => t.PhanQuyen)
                    .Select(t => new
                    {
                        t.tenTaiKhoan,
                        Quyen = t.PhanQuyen.tenQuyen
                    }).ToList();

                dgvTaiKhoan.DataSource = taiKhoans;
            }
        }

        private void LoadDanhSachQuyen()
        {
            using (var context = new DataDbContext())
            {
                var quyens = context.PhanQuyen.ToList();
                cboQuyen.DataSource = quyens;
                cboQuyen.DisplayMember = "tenQuyen";
                cboQuyen.ValueMember = "maQuyen";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                string tenTK = dgvTaiKhoan.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString();
                string maQuyenMoi = cboQuyen.SelectedValue.ToString();

                using (var context = new DataDbContext())
                {
                    var tk = context.TaiKhoan.FirstOrDefault(t => t.tenTaiKhoan == tenTK);
                    if (tk != null)
                    {
                        tk.maQuyen = maQuyenMoi;
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachTaiKhoan();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
