using DoAn1.Data_Access_Layer;
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
                                         ton.soLuong,
                                         ton.donGiaNhap,
                                         tongTien = ton.soLuong * ton.donGiaNhap
                                     }).ToList();

                dgvDSTonKho.DataSource = danhSachTonXe;
            }

            // Cấu hình hiển thị DataGridView
            dgvDSTonKho.Columns["maNhap"].HeaderText = "Mã Nhập";
            dgvDSTonKho.Columns["maXe"].HeaderText = "Mã Xe";
            dgvDSTonKho.Columns["tenXe"].HeaderText = "Tên Xe";
            dgvDSTonKho.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
            dgvDSTonKho.Columns["soLuong"].HeaderText = "Số Lượng";
            dgvDSTonKho.Columns["donGiaNhap"].HeaderText = "Đơn Giá Nhập";
            dgvDSTonKho.Columns["tongTien"].HeaderText = "Tổng Tiền";

            dgvDSTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSTonKho.Columns["donGiaNhap"].DefaultCellStyle.Format = "N0";
            dgvDSTonKho.Columns["tongTien"].DefaultCellStyle.Format = "N0";
        }

     
        private void dgvDSTonKho_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDSTonKho.Rows[e.RowIndex].Cells["tenXe"].Value != null)
            {
                DataGridViewRow row = dgvDSTonKho.Rows[e.RowIndex];

                txtTenXe.Text = row.Cells["tenXe"].Value?.ToString();
                txtNgayNhap.Text = Convert.ToDateTime(row.Cells["ngayNhap"].Value).ToString("dd/MM/yyyy");
                txtSoLuong.Text = row.Cells["soLuong"].Value?.ToString();
                txtDongianhap.Text = Convert.ToDecimal(row.Cells["donGiaNhap"].Value).ToString("N0") + " VNĐ";
                txtTongTienNhap.Text = Convert.ToDecimal(row.Cells["tongTien"].Value).ToString("N0") + " VNĐ";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            using (var context = new DataDbContext())
            {
                var danhSach = (from ton in context.TonXe
                                join xe in context.ThongTinXe on ton.maXe equals xe.maXe
                                select new
                                {
                                    ton.maNhap,
                                    ton.maXe,
                                    xe.tenXe,
                                    ton.ngayNhap,
                                    ton.soLuong,
                                    ton.donGiaNhap,
                                    tongTien = ton.soLuong * ton.donGiaNhap
                                }).ToList();  // Thực thi truy vấn ở đây

                // Bước 2: Lọc trong bộ nhớ (LINQ to Objects)
                var ketQua = danhSach.Where(x =>
                    x.maNhap.ToLower().Contains(tuKhoa) ||
                    x.maXe.ToLower().Contains(tuKhoa) ||
                    x.tenXe.ToLower().Contains(tuKhoa) ||
                    x.ngayNhap.ToString("dd/MM/yyyy").Contains(tuKhoa) ||
                    x.soLuong.ToString().Contains(tuKhoa) ||
                    x.donGiaNhap.ToString().Contains(tuKhoa)
                ).ToList();

                dgvDSTonKho.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Nếu không nhập gì → load lại toàn bộ
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadTonXe();
            }
        }
    }
}
