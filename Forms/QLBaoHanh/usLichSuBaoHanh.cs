
﻿using DoAn.Data_Access_Layer;
using DoAn.Data_Transfer_Objects;
using DoAn.Forms.QLBaoHanh;
using Microsoft.EntityFrameworkCore;
﻿using DoAn1.Data_Access_Layer;
using System.Data;

namespace DoAn1.Forms.QLBaoHanh
{
    public partial class usLichSuBaoHanh : UserControl
    {
        public usLichSuBaoHanh()
        {
            InitializeComponent();
            SetupDateTimePicker();
            LoadBaoHanh();
        }

        private void SetupDateTimePicker()
        {
        }

        private void LoadBaoHanh()
        {
            try
            {
                using (var context = new DataDbContext())
                {
                    var lichSuList = (from ls in context.LichSuBaoHanh
                                      join nv in context.NhanVien on ls.maNV equals nv.maNV
                                      join bh in context.BaoHanh on ls.maBaoHanh equals bh.maBaoHanh
                                      select new
                                      {
                                          ls.MaLSBH,
                                          ls.maBaoHanh,
                                          ls.NgayBaoHanh,
                                          ls.NoiDungBaoHanh,
                                          TenNV = nv.hoTen,
                                          GhiChu = ls.GhiChu
                                         
                                      }).ToList();

                    dgvDSLSBaoHanh.DataSource = lichSuList;
                    dgvDSLSBaoHanh.Columns["MaLSBH"].HeaderText = "Mã Lịch Sử BH";
                    dgvDSLSBaoHanh.Columns["maBaoHanh"].HeaderText = "Mã Bảo Hành";
                    dgvDSLSBaoHanh.Columns["NgayBaoHanh"].HeaderText = "Ngày Bảo Hành";
                    dgvDSLSBaoHanh.Columns["NoiDungBaoHanh"].HeaderText = "Nội Dung Bảo Hành";
                    dgvDSLSBaoHanh.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
                    dgvDSLSBaoHanh.Columns["GhiChu"].HeaderText = "Ghi Chú";
                    var first = lichSuList.FirstOrDefault();
                    if (first != null)
                    {
                        txtMaBH.Text = first.maBaoHanh;
                        txtTenNV.Text = first.TenNV;
                        txtNoiDung.Text = first.NoiDungBaoHanh;
                        dtpNgayBaoHanh.Value = first.NgayBaoHanh;
                        txtGhiChu.Text = first.GhiChu ?? "";
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu lịch sử bảo hành nào.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            frmLichSuBaoHanh LichSuBaoHanhForm = new frmLichSuBaoHanh();
            LichSuBaoHanhForm.ShowDialog();
            LoadBaoHanh(); // Tải lại danh sách sau khi thêm mới
        }

        private void dgvDSLSBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại được click
                DataGridViewRow row = dgvDSLSBaoHanh.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột trong dòng đó (giả sử bạn đặt tên cột đúng)
                txtMaBH.Text = row.Cells["maBaoHanh"].Value?.ToString() ?? "";
                txtTenNV.Text = row.Cells["TenNV"].Value?.ToString() ?? ""; // Tên nhân viên, nếu có cột này
                txtNoiDung.Text = row.Cells["NoiDungBaoHanh"].Value?.ToString() ?? "";

                // Ngày bảo hành, chuyển kiểu
                if (DateTime.TryParse(row.Cells["NgayBaoHanh"].Value?.ToString(), out DateTime ngay))
                {
                    dtpNgayBaoHanh.Value = ngay;
                }
                else
                {
                    dtpNgayBaoHanh.Value = DateTime.Now;
                }

                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSLSBaoHanh.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một bản ghi để sửa.");
                    return;
                }

                string maLSBH = dgvDSLSBaoHanh.CurrentRow.Cells["MaLSBH"].Value.ToString();

                using (var context = new DataDbContext())
                {
                    var lichSu = context.LichSuBaoHanh.FirstOrDefault(ls => ls.MaLSBH == maLSBH);
                    if (lichSu == null)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để sửa.");
                        return;
                    }

                    // Chỉ cập nhật các trường trong LichSuBaoHanh
                    lichSu.maBaoHanh = txtMaBH.Text.Trim();
                    lichSu.NoiDungBaoHanh = txtNoiDung.Text.Trim();
                    lichSu.NgayBaoHanh = dtpNgayBaoHanh.Value;
                    lichSu.GhiChu = txtGhiChu.Text.Trim();

                    

                    context.SaveChanges();

                    MessageBox.Show("Sửa bản ghi thành công.");
                    LoadBaoHanh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSLSBaoHanh.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một bản ghi để xóa.");
                    return;
                }

                string maLSBH = dgvDSLSBaoHanh.CurrentRow.Cells["MaLSBH"].Value.ToString();

                using (var context = new DataDbContext())
                {
                    var lichSu = context.LichSuBaoHanh.FirstOrDefault(ls => ls.MaLSBH == maLSBH);
                    if (lichSu == null)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa.");
                        return;
                    }

                    if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.LichSuBaoHanh.Remove(lichSu);
                        context.SaveChanges();
                        MessageBox.Show("Xóa bản ghi thành công.");
                        LoadBaoHanh();
                        btnLamMoi_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
           
            txtMaBH.Clear();
            txtTenNV.Clear();
           
            txtNoiDung.Clear();
            txtGhiChu.Clear();
            dtpNgayBaoHanh.Value = DateTime.Now;
           LoadBaoHanh();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DataDbContext())
                {
                    string keyword = txtTimKiem.Text.Trim();

                    if (string.IsNullOrEmpty(keyword))
                    {
                        MessageBox.Show("Vui lòng nhập mã Lịch Sử Bảo Hành hoặc Mã Bảo Hành để tìm kiếm.");
                        return;
                    }

                    var query = context.LichSuBaoHanh.AsQueryable();

                    // Kiểm tra mã nhập vào để lọc dữ liệu phù hợp
                    if (keyword.StartsWith("LSBH", StringComparison.OrdinalIgnoreCase))
                    {
                        string keyLower = keyword.ToLower();
                        query = query.Where(ls => ls.MaLSBH.ToLower() == keyLower);
                    }
                    else if (keyword.StartsWith("BH", StringComparison.OrdinalIgnoreCase))
                    {
                        string keyLower = keyword.ToLower();
                        query = query.Where(ls => ls.maBaoHanh.ToLower() == keyLower);
                    }
                    else
                    {
                        MessageBox.Show("Mã nhập không hợp lệ. Vui lòng nhập mã LSBH hoặc BH đúng định dạng.");
                        return;
                    }

                    var results = (from ls in query
                                   join nv in context.NhanVien on ls.maNV equals nv.maNV into nvGroup
                                   from nv in nvGroup.DefaultIfEmpty()
                                   select new
                                   {
                                       ls.MaLSBH,
                                       ls.maBaoHanh,
                                       ls.NgayBaoHanh,
                                       ls.NoiDungBaoHanh,
                                       TenNV = nv != null ? nv.hoTen : "Không xác định",
                                       ls.GhiChu
                                   }).ToList();

                    if (results.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp.");
                    }

                    dgvDSLSBaoHanh.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }


    }
}
