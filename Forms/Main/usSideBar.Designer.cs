using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.TongQuan
{
    partial class usSideBar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private bool subMenuVisible = false;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usSideBar));
            tbTong = new TableLayoutPanel();
            tbLogo = new TableLayoutPanel();
            lblTieuDe = new Label();
            picLogo = new PictureBox();
            panelButton = new Panel();
            btnDangXuat = new Button();
            btnQLTaiKhoan = new Button();
            btnBaoCao = new Button();
            btnQLDaiLy = new Button();
            btnQLBaoHanh = new Button();
            btnQLHoaDon = new Button();
            btnQLTonKho = new Button();
            btnQLKhachHang = new Button();
            subMenuPanel = new Panel();
            btnQLXeMayDien = new Button();
            btnQLXeDapDien = new Button();
            btnQLXe = new Button();
            btnTongQuan = new Button();
            tbTong.SuspendLayout();
            tbLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelButton.SuspendLayout();
            subMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tbTong
            // 
            tbTong.ColumnCount = 1;
            tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbTong.Controls.Add(tbLogo, 0, 0);
            tbTong.Controls.Add(panelButton, 0, 1);
            tbTong.Location = new Point(0, 0);
            tbTong.Margin = new Padding(4, 5, 4, 5);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 2;
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tbTong.Size = new Size(267, 1154);
            tbTong.TabIndex = 0;
            // 
            // tbLogo
            // 
            tbLogo.ColumnCount = 1;
            tbLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 259F));
            tbLogo.Controls.Add(picLogo, 0, 0);
            tbLogo.Controls.Add(lblTieuDe, 0, 1);
            tbLogo.Dock = DockStyle.Fill;
            tbLogo.Location = new Point(4, 5);
            tbLogo.Margin = new Padding(4, 5, 4, 5);
            tbLogo.Name = "tbLogo";
            tbLogo.RowCount = 2;
            tbLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tbLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbLogo.Size = new Size(259, 220);
            tbLogo.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Anchor = AnchorStyles.None;
            lblTieuDe.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(30, 90, 160);
            lblTieuDe.Location = new Point(21, 178);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(216, 29);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Xin chào Quản Lý";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Bottom;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(47, 18);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(164, 142);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelButton
            // 
            panelButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelButton.BackColor = Color.FromArgb(30, 90, 160);
            panelButton.Controls.Add(btnDangXuat);
            panelButton.Controls.Add(btnQLTaiKhoan);
            panelButton.Controls.Add(btnBaoCao);
            panelButton.Controls.Add(btnQLDaiLy);
            panelButton.Controls.Add(btnQLBaoHanh);
            panelButton.Controls.Add(btnQLHoaDon);
            panelButton.Controls.Add(btnQLTonKho);
            panelButton.Controls.Add(btnQLKhachHang);
            panelButton.Controls.Add(subMenuPanel);
            panelButton.Controls.Add(btnQLXe);
            panelButton.Controls.Add(btnTongQuan);
            panelButton.Font = new Font("Arial", 10F);
            panelButton.ForeColor = Color.White;
            panelButton.Location = new Point(4, 235);
            panelButton.Margin = new Padding(4, 5, 4, 5);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(259, 914);
            panelButton.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Location = new Point(0, 558);
            btnDangXuat.Margin = new Padding(4, 5, 4, 5);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(13, 0, 0, 0);
            btnDangXuat.Size = new Size(259, 55);
            btnDangXuat.TabIndex = 10;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnQLTaiKhoan
            // 
            btnQLTaiKhoan.Dock = DockStyle.Top;
            btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            btnQLTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnQLTaiKhoan.Location = new Point(0, 496);
            btnQLTaiKhoan.Margin = new Padding(4, 5, 4, 5);
            btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            btnQLTaiKhoan.Padding = new Padding(13, 0, 0, 0);
            btnQLTaiKhoan.Size = new Size(259, 55);
            btnQLTaiKhoan.TabIndex = 9;
            btnQLTaiKhoan.Text = "Quản Lí Tài Khoản";
            btnQLTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnQLTaiKhoan.UseVisualStyleBackColor = false;
            btnQLTaiKhoan.Click += btnQLTaiKhoan_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Dock = DockStyle.Top;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Location = new Point(0, 434);
            btnBaoCao.Margin = new Padding(4, 5, 4, 5);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(13, 0, 0, 0);
            btnBaoCao.Size = new Size(259, 55);
            btnBaoCao.TabIndex = 8;
            btnBaoCao.Text = "Báo Cáo";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnQLDaiLy
            // 
            btnQLDaiLy.Dock = DockStyle.Top;
            btnQLDaiLy.FlatAppearance.BorderSize = 0;
            btnQLDaiLy.FlatStyle = FlatStyle.Flat;
            btnQLDaiLy.Location = new Point(0, 372);
            btnQLDaiLy.Margin = new Padding(4, 5, 4, 5);
            btnQLDaiLy.Name = "btnQLDaiLy";
            btnQLDaiLy.Padding = new Padding(13, 0, 0, 0);
            btnQLDaiLy.Size = new Size(259, 55);
            btnQLDaiLy.TabIndex = 7;
            btnQLDaiLy.Text = "Quản Lí Đại Lý";
            btnQLDaiLy.TextAlign = ContentAlignment.MiddleLeft;
            btnQLDaiLy.UseVisualStyleBackColor = false;
            btnQLDaiLy.Click += btnQLDaiLy_Click;
            // 
            // btnQLBaoHanh
            // 
            btnQLBaoHanh.Dock = DockStyle.Top;
            btnQLBaoHanh.FlatAppearance.BorderSize = 0;
            btnQLBaoHanh.FlatStyle = FlatStyle.Flat;
            btnQLBaoHanh.Location = new Point(0, 310);
            btnQLBaoHanh.Margin = new Padding(4, 5, 4, 5);
            btnQLBaoHanh.Name = "btnQLBaoHanh";
            btnQLBaoHanh.Padding = new Padding(13, 0, 0, 0);
            btnQLBaoHanh.Size = new Size(259, 55);
            btnQLBaoHanh.TabIndex = 6;
            btnQLBaoHanh.Text = "Quản Lí Bảo Hành";
            btnQLBaoHanh.TextAlign = ContentAlignment.MiddleLeft;
            btnQLBaoHanh.UseVisualStyleBackColor = false;
            btnQLBaoHanh.Click += btnQLBaoHanh_Click;
            // 
            // btnQLHoaDon
            // 
            btnQLHoaDon.Dock = DockStyle.Top;
            btnQLHoaDon.FlatAppearance.BorderSize = 0;
            btnQLHoaDon.FlatStyle = FlatStyle.Flat;
            btnQLHoaDon.Location = new Point(0, 248);
            btnQLHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnQLHoaDon.Name = "btnQLHoaDon";
            btnQLHoaDon.Padding = new Padding(13, 0, 0, 0);
            btnQLHoaDon.Size = new Size(259, 55);
            btnQLHoaDon.TabIndex = 5;
            btnQLHoaDon.Text = "Quản Lí Hóa Đơn";
            btnQLHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnQLHoaDon.UseVisualStyleBackColor = false;
            btnQLHoaDon.Click += btnQLHoaDon_Click;
            // 
            // btnQLTonKho
            // 
            btnQLTonKho.Dock = DockStyle.Top;
            btnQLTonKho.FlatAppearance.BorderSize = 0;
            btnQLTonKho.FlatStyle = FlatStyle.Flat;
            btnQLTonKho.Location = new Point(0, 186);
            btnQLTonKho.Margin = new Padding(4, 5, 4, 5);
            btnQLTonKho.Name = "btnQLTonKho";
            btnQLTonKho.Padding = new Padding(13, 0, 0, 0);
            btnQLTonKho.Size = new Size(259, 55);
            btnQLTonKho.TabIndex = 4;
            btnQLTonKho.Text = "Quản Lí Tồn Kho";
            btnQLTonKho.TextAlign = ContentAlignment.MiddleLeft;
            btnQLTonKho.UseVisualStyleBackColor = false;
            btnQLTonKho.Click += btnQLTonKho_Click;
            // 
            // btnQLKhachHang
            // 
            btnQLKhachHang.Dock = DockStyle.Top;
            btnQLKhachHang.FlatAppearance.BorderSize = 0;
            btnQLKhachHang.FlatStyle = FlatStyle.Flat;
            btnQLKhachHang.Location = new Point(0, 124);
            btnQLKhachHang.Margin = new Padding(4, 5, 4, 5);
            btnQLKhachHang.Name = "btnQLKhachHang";
            btnQLKhachHang.Padding = new Padding(13, 0, 0, 0);
            btnQLKhachHang.Size = new Size(259, 55);
            btnQLKhachHang.TabIndex = 3;
            btnQLKhachHang.Text = "Quản Lí Khách Hàng";
            btnQLKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnQLKhachHang.UseVisualStyleBackColor = false;
            btnQLKhachHang.Click += btnQLKhachHang_Click;
            // 
            // subMenuPanel
            // 
            subMenuPanel.Controls.Add(btnQLXeMayDien);
            subMenuPanel.Controls.Add(btnQLXeDapDien);
            subMenuPanel.Dock = DockStyle.Top;
            subMenuPanel.Location = new Point(0, 124);
            subMenuPanel.Margin = new Padding(4, 5, 4, 5);
            subMenuPanel.Name = "subMenuPanel";
            subMenuPanel.Size = new Size(259, 0);
            subMenuPanel.TabIndex = 2;
            subMenuPanel.Visible = false;
            // 
            // btnQLXeMayDien
            // 
            btnQLXeMayDien.Dock = DockStyle.Top;
            btnQLXeMayDien.FlatAppearance.BorderSize = 0;
            btnQLXeMayDien.FlatStyle = FlatStyle.Flat;
            btnQLXeMayDien.Location = new Point(0, 62);
            btnQLXeMayDien.Margin = new Padding(4, 5, 4, 5);
            btnQLXeMayDien.Name = "btnQLXeMayDien";
            btnQLXeMayDien.Padding = new Padding(47, 0, 0, 0);
            btnQLXeMayDien.Size = new Size(259, 55);
            btnQLXeMayDien.TabIndex = 0;
            btnQLXeMayDien.Text = "Xe Máy Điện";
            btnQLXeMayDien.TextAlign = ContentAlignment.MiddleLeft;
            btnQLXeMayDien.UseVisualStyleBackColor = false;
            btnQLXeMayDien.Click += btnQLXeMayDien_Click;
            // 
            // btnQLXeDapDien
            // 
            btnQLXeDapDien.Dock = DockStyle.Top;
            btnQLXeDapDien.FlatAppearance.BorderSize = 0;
            btnQLXeDapDien.FlatStyle = FlatStyle.Flat;
            btnQLXeDapDien.Location = new Point(0, 0);
            btnQLXeDapDien.Margin = new Padding(4, 5, 4, 5);
            btnQLXeDapDien.Name = "btnQLXeDapDien";
            btnQLXeDapDien.Padding = new Padding(47, 0, 0, 0);
            btnQLXeDapDien.Size = new Size(259, 55);
            btnQLXeDapDien.TabIndex = 1;
            btnQLXeDapDien.Text = "Xe Đạp Điện";
            btnQLXeDapDien.TextAlign = ContentAlignment.MiddleLeft;
            btnQLXeDapDien.UseVisualStyleBackColor = false;
            btnQLXeDapDien.Click += btnQLXeDapDien_Click;
            // 
            // btnQLXe
            // 
            btnQLXe.Dock = DockStyle.Top;
            btnQLXe.FlatAppearance.BorderSize = 0;
            btnQLXe.FlatStyle = FlatStyle.Flat;
            btnQLXe.Location = new Point(0, 62);
            btnQLXe.Margin = new Padding(4, 5, 4, 5);
            btnQLXe.Name = "btnQLXe";
            btnQLXe.Padding = new Padding(13, 0, 0, 0);
            btnQLXe.Size = new Size(259, 55);
            btnQLXe.TabIndex = 1;
            btnQLXe.Text = "Quản Lí Xe";
            btnQLXe.TextAlign = ContentAlignment.MiddleLeft;
            btnQLXe.UseVisualStyleBackColor = false;
            btnQLXe.Click += BtnQLXe_Click;
            // 
            // btnTongQuan
            // 
            btnTongQuan.Dock = DockStyle.Top;
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.Location = new Point(0, 0);
            btnTongQuan.Margin = new Padding(4, 5, 4, 5);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Padding = new Padding(13, 0, 0, 0);
            btnTongQuan.Size = new Size(259, 55);
            btnTongQuan.TabIndex = 0;
            btnTongQuan.Text = "Tổng Quan";
            btnTongQuan.TextAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.UseVisualStyleBackColor = false;
            btnTongQuan.Click += btnTongQuan_Click;
            // 
            // usSideBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tbTong);
            Margin = new Padding(4, 5, 4, 5);
            Name = "usSideBar";
            Size = new Size(267, 1154);
            tbTong.ResumeLayout(false);
            tbLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelButton.ResumeLayout(false);
            subMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BtnQLXe_Click(object sender, EventArgs e)
        {
            subMenuVisible = !subMenuVisible;
            subMenuPanel.Visible = subMenuVisible;
            subMenuPanel.Height = subMenuVisible ? 110 : 0;
        }

        private void ActivateButton(Button btn)
        {
            // Reset nút trước đó
            if (currentButton != null)
            {
                currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160))))); // màu gốc
                currentButton.Font = new System.Drawing.Font("Arial", 10F);
            }

            // Đổi màu nút được bấm
            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(70, 130, 200);
            currentButton.Font = new System.Drawing.Font("Arial", 11F);
        }

        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnQLDaiLy;
        private System.Windows.Forms.Button btnQLBaoHanh;
        private System.Windows.Forms.Button btnQLHoaDon;
        private System.Windows.Forms.Button btnQLTonKho;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Button btnQLXe;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Panel subMenuPanel;
        private System.Windows.Forms.Button btnQLXeMayDien;
        private System.Windows.Forms.Button btnQLXeDapDien;
        private Button currentButton = null;
    }
}
