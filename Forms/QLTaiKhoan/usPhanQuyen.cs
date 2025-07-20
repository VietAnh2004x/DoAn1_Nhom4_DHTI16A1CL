using DoAn1.Data_Access_Layer;
using DoAn1.Data_Transfer_Objects;
using Microsoft.EntityFrameworkCore;
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
                    .Include(t => t.PhanQuyen).Include(t => t.NhanVien)
                    .Select(t => new
                    {
                        TenTaiKhoan = t.tenTaiKhoan,
                        MatKhau = t.matKhau,
                        HoTen = t.NhanVien!.hoTen,
                        Quyen = t.PhanQuyen.tenQuyen
                    }).ToList();

                dgvTaiKhoan.DataSource = taiKhoans;
                dgvTaiKhoan.Columns["HoTen"]!.HeaderText = "Họ tên";
                dgvTaiKhoan.Columns["TenTaiKhoan"]!.HeaderText = "Tên tài khoản";
                dgvTaiKhoan.Columns["MatKhau"]!.HeaderText = "Mật khẩu";
                dgvTaiKhoan.Columns["Quyen"]!.HeaderText = "Quyền";
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
                string tenTK = dgvTaiKhoan.SelectedRows[0]!.Cells["TenTaiKhoan"]!.Value!.ToString()!;
                string maQuyenMoi = cboQuyen.SelectedValue!.ToString()!;

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                (!rdoNam.Checked && !rdoNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataDbContext())
            {
                string tenTK = txtTenTaiKhoan.Text.Trim();
                if (context.TaiKhoan.Any(t => t.tenTaiKhoan == tenTK))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm tài khoản
                var taiKhoan = new TaiKhoan
                {
                    tenTaiKhoan = tenTK,
                    matKhau = txtMatKhau.Text,
                    maQuyen = cboQuyen.SelectedValue!.ToString()!
                };

                var nhanVien = new NhanVien
                {
                    maNV = txtMaNV.Text.Trim(),
                    tenTaiKhoan = tenTK,
                    hoTen = txtHoTen.Text,
                    gioiTinh = GetGioiTinh(),
                    ngaySinh = dtpNgaySinh.Value,
                    ngayVaoLam = dtpNgayVaoLam.Value,
                    soDienThoai = txtSDT.Text,
                    email = txtEmail.Text
                };

                context.TaiKhoan.Add(taiKhoan);
                context.NhanVien.Add(nhanVien);
                context.SaveChanges();

                LoadDanhSachTaiKhoan();
                ClearInputs();
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTK = txtTenTaiKhoan.Text.Trim();

            using (var context = new DataDbContext())
            {
                var taiKhoan = context.TaiKhoan.FirstOrDefault(t => t.tenTaiKhoan == tenTK);
                var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.tenTaiKhoan == tenTK);

                if (taiKhoan != null && nhanVien != null)
                {
                    taiKhoan.matKhau = txtMatKhau.Text;
                    taiKhoan.maQuyen = cboQuyen!.SelectedValue!.ToString()!;

                    nhanVien.maNV = txtMaNV.Text;
                    nhanVien.hoTen = txtHoTen.Text;
                    nhanVien.gioiTinh = GetGioiTinh();
                    nhanVien.ngaySinh = dtpNgaySinh.Value;
                    nhanVien.ngayVaoLam = dtpNgayVaoLam.Value;
                    nhanVien.soDienThoai = txtSDT.Text;
                    nhanVien.email = txtEmail.Text;

                    context.SaveChanges();

                    LoadDanhSachTaiKhoan();
                    ClearInputs();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTK = dgvTaiKhoan.SelectedRows[0]!.Cells["TenTaiKhoan"]!.Value!.ToString()!;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var context = new DataDbContext())
                {
                    var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.tenTaiKhoan == tenTK);
                    if (nhanVien != null)
                        context.NhanVien.Remove(nhanVien);

                    var taiKhoan = context.TaiKhoan.FirstOrDefault(tk => tk.tenTaiKhoan == tenTK);
                    if (taiKhoan != null)
                        context.TaiKhoan.Remove(taiKhoan);

                    context.SaveChanges();
                    LoadDanhSachTaiKhoan();
                    ClearInputs();
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                string tenTK = dgvTaiKhoan!.SelectedRows[0]!.Cells["TenTaiKhoan"]!.Value!.ToString()!;

                using (var context = new DataDbContext())
                {
                    var tk = context.TaiKhoan.FirstOrDefault(t => t.tenTaiKhoan == tenTK);
                    var nv = context.NhanVien.FirstOrDefault(n => n.tenTaiKhoan == tenTK);

                    if (tk != null && nv != null)
                    {
                        txtTenTaiKhoan.Text = tk.tenTaiKhoan;
                        txtMatKhau.Text = tk.matKhau;
                        cboQuyen.SelectedValue = tk.maQuyen;

                        txtMaNV.Text = nv.maNV;
                        txtHoTen.Text = nv.hoTen;
                        txtEmail.Text = nv.email;
                        txtSDT.Text = nv.soDienThoai;
                        dtpNgaySinh.Value = nv.ngaySinh;
                        dtpNgayVaoLam.Value = nv.ngayVaoLam;

                        rdoNam.Checked = nv.gioiTinh == "Nam";
                        rdoNu.Checked = nv.gioiTinh == "Nữ";
                    }
                }
            }
        }

        private void ClearInputs()
        {
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayVaoLam.Value = DateTime.Now;
        }

        private string GetGioiTinh()
        {
            return rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : "");
        }
    }
}
