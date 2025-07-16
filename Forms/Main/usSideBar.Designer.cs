namespace DoAn1.Forms.Main
{
    partial class usSideBar
    {
        private System.ComponentModel.IContainer components = null;
        private bool subMenuVisible = false;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnTongQuan = new FontAwesome.Sharp.IconButton();
            btnQLDanhMuc = new FontAwesome.Sharp.IconButton();
            btnBaoCao = new FontAwesome.Sharp.IconButton();
            btnQLTaiKhoan = new FontAwesome.Sharp.IconButton();
            btnDangXuat = new FontAwesome.Sharp.IconButton();
            btnQLXeMayDien = new FontAwesome.Sharp.IconButton();
            btnQLXeDapDien = new FontAwesome.Sharp.IconButton();
            btnQLTonKho = new FontAwesome.Sharp.IconButton();
            btnQLKhachHang = new FontAwesome.Sharp.IconButton();
            btnQLHoaDon = new FontAwesome.Sharp.IconButton();
            btnQLPhieuBaoHanh = new FontAwesome.Sharp.IconButton();
            btnQLDaiLy = new FontAwesome.Sharp.IconButton();
            subMenuPanel = new Panel();
            subMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnTongQuan
            // 
            btnTongQuan.Cursor = Cursors.Hand;
            btnTongQuan.Dock = DockStyle.Top;
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            btnTongQuan.IconColor = Color.White;
            btnTongQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTongQuan.IconSize = 24;
            btnTongQuan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.Location = new Point(0, 0);
            btnTongQuan.Margin = new Padding(0);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Padding = new Padding(10, 0, 0, 0);
            btnTongQuan.Size = new Size(248, 50);
            btnTongQuan.TabIndex = 0;
            btnTongQuan.Text = " Tổng Quan";
            btnTongQuan.TextAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTongQuan.UseVisualStyleBackColor = true;
            btnTongQuan.Click += btnTongQuan_Click;
            // 
            // btnQLDanhMuc
            // 
            btnQLDanhMuc.Cursor = Cursors.Hand;
            btnQLDanhMuc.Dock = DockStyle.Top;
            btnQLDanhMuc.FlatAppearance.BorderSize = 0;
            btnQLDanhMuc.FlatStyle = FlatStyle.Flat;
            btnQLDanhMuc.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btnQLDanhMuc.IconColor = Color.White;
            btnQLDanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLDanhMuc.IconSize = 24;
            btnQLDanhMuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDanhMuc.Location = new Point(0, 50);
            btnQLDanhMuc.Margin = new Padding(0);
            btnQLDanhMuc.Name = "btnQLDanhMuc";
            btnQLDanhMuc.Padding = new Padding(10, 0, 0, 0);
            btnQLDanhMuc.Size = new Size(248, 50);
            btnQLDanhMuc.TabIndex = 1;
            btnQLDanhMuc.Text = " Quản Lý Danh Mục";
            btnQLDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnQLDanhMuc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLDanhMuc.UseVisualStyleBackColor = true;
            btnQLDanhMuc.Click += btnQLDanhMuc_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Cursor = Cursors.Hand;
            btnBaoCao.Dock = DockStyle.Top;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnBaoCao.IconColor = Color.White;
            btnBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBaoCao.IconSize = 24;
            btnBaoCao.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.Location = new Point(0, 100);
            btnBaoCao.Margin = new Padding(0);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(10, 0, 0, 0);
            btnBaoCao.Size = new Size(248, 50);
            btnBaoCao.TabIndex = 2;
            btnBaoCao.Text = " Báo Cáo";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnQLTaiKhoan
            // 
            btnQLTaiKhoan.Cursor = Cursors.Hand;
            btnQLTaiKhoan.Dock = DockStyle.Top;
            btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            btnQLTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnQLTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnQLTaiKhoan.IconColor = Color.White;
            btnQLTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLTaiKhoan.IconSize = 24;
            btnQLTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLTaiKhoan.Location = new Point(0, 150);
            btnQLTaiKhoan.Margin = new Padding(0);
            btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            btnQLTaiKhoan.Padding = new Padding(10, 0, 0, 0);
            btnQLTaiKhoan.Size = new Size(248, 50);
            btnQLTaiKhoan.TabIndex = 3;
            btnQLTaiKhoan.Text = " Quản Lý Tài Khoản";
            btnQLTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnQLTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLTaiKhoan.UseVisualStyleBackColor = true;
            btnQLTaiKhoan.Click += btnQLTaiKhoan_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnDangXuat.IconColor = Color.White;
            btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDangXuat.IconSize = 24;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 200);
            btnDangXuat.Margin = new Padding(0);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(10, 0, 0, 0);
            btnDangXuat.Size = new Size(248, 50);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = " Đăng Xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnQLXeMayDien
            // 
            btnQLXeMayDien.Cursor = Cursors.Hand;
            btnQLXeMayDien.Dock = DockStyle.Top;
            btnQLXeMayDien.FlatAppearance.BorderSize = 0;
            btnQLXeMayDien.FlatStyle = FlatStyle.Flat;
            btnQLXeMayDien.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            btnQLXeMayDien.IconColor = Color.White;
            btnQLXeMayDien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLXeMayDien.IconSize = 24;
            btnQLXeMayDien.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLXeMayDien.Location = new Point(0, 50);
            btnQLXeMayDien.Margin = new Padding(0);
            btnQLXeMayDien.Name = "btnQLXeMayDien";
            btnQLXeMayDien.Padding = new Padding(30, 0, 0, 0);
            btnQLXeMayDien.Size = new Size(248, 50);
            btnQLXeMayDien.TabIndex = 0;
            btnQLXeMayDien.Text = " Quản Lý Xe Máy Điện";
            btnQLXeMayDien.TextAlign = ContentAlignment.MiddleLeft;
            btnQLXeMayDien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLXeMayDien.UseVisualStyleBackColor = true;
            btnQLXeMayDien.Click += btnQLXeMayDien_Click;
            // 
            // btnQLXeDapDien
            // 
            btnQLXeDapDien.Cursor = Cursors.Hand;
            btnQLXeDapDien.Dock = DockStyle.Top;
            btnQLXeDapDien.FlatAppearance.BorderSize = 0;
            btnQLXeDapDien.FlatStyle = FlatStyle.Flat;
            btnQLXeDapDien.IconChar = FontAwesome.Sharp.IconChar.Bicycle;
            btnQLXeDapDien.IconColor = Color.White;
            btnQLXeDapDien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLXeDapDien.IconSize = 24;
            btnQLXeDapDien.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLXeDapDien.Location = new Point(0, 0);
            btnQLXeDapDien.Margin = new Padding(0);
            btnQLXeDapDien.Name = "btnQLXeDapDien";
            btnQLXeDapDien.Padding = new Padding(30, 0, 0, 0);
            btnQLXeDapDien.Size = new Size(248, 50);
            btnQLXeDapDien.TabIndex = 1;
            btnQLXeDapDien.Text = " Quản Lý Xe Đạp Điện";
            btnQLXeDapDien.TextAlign = ContentAlignment.MiddleLeft;
            btnQLXeDapDien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLXeDapDien.UseVisualStyleBackColor = true;
            btnQLXeDapDien.Click += btnQLXeDapDien_Click;
            // 
            // btnQLTonKho
            // 
            btnQLTonKho.Cursor = Cursors.Hand;
            btnQLTonKho.Dock = DockStyle.Top;
            btnQLTonKho.FlatAppearance.BorderSize = 0;
            btnQLTonKho.FlatStyle = FlatStyle.Flat;
            btnQLTonKho.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnQLTonKho.IconColor = Color.White;
            btnQLTonKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLTonKho.IconSize = 24;
            btnQLTonKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLTonKho.Location = new Point(0, 100);
            btnQLTonKho.Margin = new Padding(0);
            btnQLTonKho.Name = "btnQLTonKho";
            btnQLTonKho.Padding = new Padding(30, 0, 0, 0);
            btnQLTonKho.Size = new Size(248, 50);
            btnQLTonKho.TabIndex = 2;
            btnQLTonKho.Text = " Quản Lý Tồn Kho";
            btnQLTonKho.TextAlign = ContentAlignment.MiddleLeft;
            btnQLTonKho.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLTonKho.UseVisualStyleBackColor = true;
            btnQLTonKho.Click += btnQLTonKho_Click;
            // 
            // btnQLKhachHang
            // 
            btnQLKhachHang.Cursor = Cursors.Hand;
            btnQLKhachHang.Dock = DockStyle.Top;
            btnQLKhachHang.FlatAppearance.BorderSize = 0;
            btnQLKhachHang.FlatStyle = FlatStyle.Flat;
            btnQLKhachHang.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnQLKhachHang.IconColor = Color.White;
            btnQLKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLKhachHang.IconSize = 24;
            btnQLKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLKhachHang.Location = new Point(0, 150);
            btnQLKhachHang.Margin = new Padding(0);
            btnQLKhachHang.Name = "btnQLKhachHang";
            btnQLKhachHang.Padding = new Padding(30, 0, 0, 0);
            btnQLKhachHang.Size = new Size(248, 50);
            btnQLKhachHang.TabIndex = 3;
            btnQLKhachHang.Text = " Quản Lý Khách Hàng";
            btnQLKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnQLKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLKhachHang.UseVisualStyleBackColor = true;
            btnQLKhachHang.Click += btnQLKhachHang_Click;
            // 
            // btnQLHoaDon
            // 
            btnQLHoaDon.Cursor = Cursors.Hand;
            btnQLHoaDon.Dock = DockStyle.Top;
            btnQLHoaDon.FlatAppearance.BorderSize = 0;
            btnQLHoaDon.FlatStyle = FlatStyle.Flat;
            btnQLHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnQLHoaDon.IconColor = Color.White;
            btnQLHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLHoaDon.IconSize = 24;
            btnQLHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLHoaDon.Location = new Point(0, 200);
            btnQLHoaDon.Margin = new Padding(0);
            btnQLHoaDon.Name = "btnQLHoaDon";
            btnQLHoaDon.Padding = new Padding(30, 0, 0, 0);
            btnQLHoaDon.Size = new Size(248, 50);
            btnQLHoaDon.TabIndex = 4;
            btnQLHoaDon.Text = " Quản Lý Hóa Đơn";
            btnQLHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnQLHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLHoaDon.UseVisualStyleBackColor = true;
            btnQLHoaDon.Click += btnQLHoaDon_Click;
            // 
            // btnQLPhieuBaoHanh
            // 
            btnQLPhieuBaoHanh.Cursor = Cursors.Hand;
            btnQLPhieuBaoHanh.Dock = DockStyle.Top;
            btnQLPhieuBaoHanh.FlatAppearance.BorderSize = 0;
            btnQLPhieuBaoHanh.FlatStyle = FlatStyle.Flat;
            btnQLPhieuBaoHanh.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnQLPhieuBaoHanh.IconColor = Color.White;
            btnQLPhieuBaoHanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLPhieuBaoHanh.IconSize = 24;
            btnQLPhieuBaoHanh.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLPhieuBaoHanh.Location = new Point(0, 250);
            btnQLPhieuBaoHanh.Margin = new Padding(0);
            btnQLPhieuBaoHanh.Name = "btnQLPhieuBaoHanh";
            btnQLPhieuBaoHanh.Padding = new Padding(30, 0, 0, 0);
            btnQLPhieuBaoHanh.Size = new Size(248, 50);
            btnQLPhieuBaoHanh.TabIndex = 5;
            btnQLPhieuBaoHanh.Text = " Quản Lý Phiếu Bảo Hành";
            btnQLPhieuBaoHanh.TextAlign = ContentAlignment.MiddleLeft;
            btnQLPhieuBaoHanh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLPhieuBaoHanh.UseVisualStyleBackColor = true;
            btnQLPhieuBaoHanh.Click += btnQLPhieuBaoHanh_Click;
            // 
            // btnQLDaiLy
            // 
            btnQLDaiLy.Cursor = Cursors.Hand;
            btnQLDaiLy.Dock = DockStyle.Top;
            btnQLDaiLy.FlatAppearance.BorderSize = 0;
            btnQLDaiLy.FlatStyle = FlatStyle.Flat;
            btnQLDaiLy.IconChar = FontAwesome.Sharp.IconChar.Building;
            btnQLDaiLy.IconColor = Color.White;
            btnQLDaiLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLDaiLy.IconSize = 24;
            btnQLDaiLy.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDaiLy.Location = new Point(0, 300);
            btnQLDaiLy.Margin = new Padding(0);
            btnQLDaiLy.Name = "btnQLDaiLy";
            btnQLDaiLy.Padding = new Padding(30, 0, 0, 0);
            btnQLDaiLy.Size = new Size(248, 50);
            btnQLDaiLy.TabIndex = 6;
            btnQLDaiLy.Text = " Quản Lý Đại Lý";
            btnQLDaiLy.TextAlign = ContentAlignment.MiddleLeft;
            btnQLDaiLy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLDaiLy.UseVisualStyleBackColor = true;
            btnQLDaiLy.Click += btnQLDaiLy_Click;
            // 
            // subMenuPanel
            // 
            subMenuPanel.Controls.Add(btnQLDaiLy);
            subMenuPanel.Controls.Add(btnQLPhieuBaoHanh);
            subMenuPanel.Controls.Add(btnQLHoaDon);
            subMenuPanel.Controls.Add(btnQLKhachHang);
            subMenuPanel.Controls.Add(btnQLTonKho);
            subMenuPanel.Controls.Add(btnQLXeMayDien);
            subMenuPanel.Controls.Add(btnQLXeDapDien);
            subMenuPanel.Dock = DockStyle.Top;
            subMenuPanel.Location = new Point(0, 100);
            subMenuPanel.Name = "subMenuPanel";
            subMenuPanel.Size = new Size(248, 0);
            subMenuPanel.TabIndex = 1;
            subMenuPanel.Visible = false;
            // 
            // usSideBar
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 90, 160);
            Controls.Add(btnDangXuat);
            Controls.Add(btnQLTaiKhoan);
            Controls.Add(btnBaoCao);
            Controls.Add(subMenuPanel);
            Controls.Add(btnQLDanhMuc);
            Controls.Add(btnTongQuan);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            Name = "usSideBar";
            Size = new Size(248, 710);
            subMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton btnTongQuan;
        private FontAwesome.Sharp.IconButton btnQLDanhMuc;
        private FontAwesome.Sharp.IconButton btnBaoCao;
        private FontAwesome.Sharp.IconButton btnQLTaiKhoan;
        private FontAwesome.Sharp.IconButton btnDangXuat;

        private FontAwesome.Sharp.IconButton btnQLXeMayDien;
        private FontAwesome.Sharp.IconButton btnQLXeDapDien;
        private FontAwesome.Sharp.IconButton btnQLTonKho;
        private FontAwesome.Sharp.IconButton btnQLKhachHang;
        private FontAwesome.Sharp.IconButton btnQLHoaDon;
        private FontAwesome.Sharp.IconButton btnQLPhieuBaoHanh;
        private FontAwesome.Sharp.IconButton btnQLDaiLy;

        private Panel subMenuPanel;
    }
}
