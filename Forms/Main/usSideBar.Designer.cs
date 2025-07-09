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
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.tbLogo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnQLDaiLy = new System.Windows.Forms.Button();
            this.btnQLBaoHanh = new System.Windows.Forms.Button();
            this.btnQLHoaDon = new System.Windows.Forms.Button();
            this.btnQLTonKho = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.subMenuPanel = new System.Windows.Forms.Panel();
            this.btnQLXeMayDien = new System.Windows.Forms.Button();
            this.btnQLXeDapDien = new System.Windows.Forms.Button();
            this.btnQLXe = new System.Windows.Forms.Button();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.tbTong.SuspendLayout();
            this.tbLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelButton.SuspendLayout();
            this.subMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTong
            // 
            this.tbTong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbTong.Controls.Add(this.tbLogo, 0, 0);
            this.tbTong.Controls.Add(this.panelButton, 0, 1);
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbTong.Size = new System.Drawing.Size(200, 750);
            this.tbTong.TabIndex = 0;
            // 
            // tbLogo
            // 
            this.tbLogo.ColumnCount = 1;
            this.tbLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tbLogo.Controls.Add(this.lblTieuDe, 0, 1);
            this.tbLogo.Controls.Add(this.picLogo, 0, 0);
            this.tbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogo.Location = new System.Drawing.Point(3, 3);
            this.tbLogo.Name = "tbLogo";
            this.tbLogo.RowCount = 2;
            this.tbLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLogo.Size = new System.Drawing.Size(194, 144);
            this.tbLogo.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblTieuDe.Location = new System.Drawing.Point(16, 116);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(162, 19);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Xin chào Vanh Vanh";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(35, 13);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(123, 92);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.panelButton.Controls.Add(this.btnDangXuat);
            this.panelButton.Controls.Add(this.btnQLTaiKhoan);
            this.panelButton.Controls.Add(this.btnBaoCao);
            this.panelButton.Controls.Add(this.btnQLDaiLy);
            this.panelButton.Controls.Add(this.btnQLBaoHanh);
            this.panelButton.Controls.Add(this.btnQLHoaDon);
            this.panelButton.Controls.Add(this.btnQLTonKho);
            this.panelButton.Controls.Add(this.btnQLKhachHang);
            this.panelButton.Controls.Add(this.subMenuPanel);
            this.panelButton.Controls.Add(this.btnQLXe);
            this.panelButton.Controls.Add(this.btnTongQuan);
            this.panelButton.Font = new System.Drawing.Font("Arial", 10F);
            this.panelButton.ForeColor = Color.White;
            this.panelButton.Location = new System.Drawing.Point(3, 153);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(194, 594);
            this.panelButton.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(194, 40);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(194, 40);
            this.btnQLTaiKhoan.TabIndex = 9;
            this.btnQLTaiKhoan.Text = "Quản Lí Tài Khoản";
            this.btnQLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(194, 40);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnQLDaiLy
            // 
            this.btnQLDaiLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDaiLy.FlatAppearance.BorderSize = 0;
            this.btnQLDaiLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDaiLy.Name = "btnQLDaiLy";
            this.btnQLDaiLy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLDaiLy.Size = new System.Drawing.Size(194, 40);
            this.btnQLDaiLy.TabIndex = 7;
            this.btnQLDaiLy.Text = "Quản Lí Đại Lý";
            this.btnQLDaiLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDaiLy.UseVisualStyleBackColor = false;
            this.btnQLDaiLy.Click += new System.EventHandler(this.btnQLDaiLy_Click);
            // 
            // btnQLBaoHanh
            // 
            this.btnQLBaoHanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLBaoHanh.FlatAppearance.BorderSize = 0;
            this.btnQLBaoHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLBaoHanh.Name = "btnQLBaoHanh";
            this.btnQLBaoHanh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLBaoHanh.Size = new System.Drawing.Size(194, 40);
            this.btnQLBaoHanh.TabIndex = 6;
            this.btnQLBaoHanh.Text = "Quản Lí Bảo Hành";
            this.btnQLBaoHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLBaoHanh.UseVisualStyleBackColor = false;
            this.btnQLBaoHanh.Click += new System.EventHandler(this.btnQLBaoHanh_Click);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHoaDon.FlatAppearance.BorderSize = 0;
            this.btnQLHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLHoaDon.Size = new System.Drawing.Size(194, 40);
            this.btnQLHoaDon.TabIndex = 5;
            this.btnQLHoaDon.Text = "Quản Lí Hóa Đơn";
            this.btnQLHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHoaDon.UseVisualStyleBackColor = false;
            this.btnQLHoaDon.Click += new System.EventHandler(this.btnQLHoaDon_Click);
            // 
            // btnQLTonKho
            // 
            this.btnQLTonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTonKho.FlatAppearance.BorderSize = 0;
            this.btnQLTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTonKho.Name = "btnQLTonKho";
            this.btnQLTonKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLTonKho.Size = new System.Drawing.Size(194, 40);
            this.btnQLTonKho.TabIndex = 4;
            this.btnQLTonKho.Text = "Quản Lí Tồn Kho";
            this.btnQLTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTonKho.UseVisualStyleBackColor = false;
            this.btnQLTonKho.Click += new System.EventHandler(this.btnQLTonKho_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLKhachHang.Size = new System.Drawing.Size(194, 40);
            this.btnQLKhachHang.TabIndex = 3;
            this.btnQLKhachHang.Text = "Quản Lí Khách Hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // subMenuPanel
            // 
            this.subMenuPanel.Controls.Add(this.btnQLXeMayDien);
            this.subMenuPanel.Controls.Add(this.btnQLXeDapDien);
            this.subMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuPanel.Name = "subMenuPanel";
            this.subMenuPanel.Size = new System.Drawing.Size(194, 0);
            this.subMenuPanel.TabIndex = 2;
            this.subMenuPanel.Visible = false;
            // 
            // btnQLXeMayDien
            // 
            this.btnQLXeMayDien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLXeMayDien.FlatAppearance.BorderSize = 0;
            this.btnQLXeMayDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLXeMayDien.Location = new System.Drawing.Point(0, 40);
            this.btnQLXeMayDien.Name = "btnQLXeMayDien";
            this.btnQLXeMayDien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnQLXeMayDien.Size = new System.Drawing.Size(194, 40);
            this.btnQLXeMayDien.TabIndex = 0;
            this.btnQLXeMayDien.Text = "Xe Máy Điện";
            this.btnQLXeMayDien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXeMayDien.UseVisualStyleBackColor = false;
            this.btnQLXeMayDien.Click += new System.EventHandler(this.btnQLXeMayDien_Click);
            // 
            // btnQLXeDapDien
            // 
            this.btnQLXeDapDien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLXeDapDien.FlatAppearance.BorderSize = 0;
            this.btnQLXeDapDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLXeDapDien.Location = new System.Drawing.Point(0, 0);
            this.btnQLXeDapDien.Name = "btnQLXeDapDien";
            this.btnQLXeDapDien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnQLXeDapDien.Size = new System.Drawing.Size(194, 40);
            this.btnQLXeDapDien.TabIndex = 1;
            this.btnQLXeDapDien.Text = "Xe Đạp Điện";
            this.btnQLXeDapDien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXeDapDien.UseVisualStyleBackColor = false;
            this.btnQLXeDapDien.Click += new System.EventHandler(this.btnQLXeDapDien_Click);
            // 
            // btnQLXe
            // 
            this.btnQLXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLXe.FlatAppearance.BorderSize = 0;
            this.btnQLXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLXe.Name = "btnQLXe";
            this.btnQLXe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLXe.Size = new System.Drawing.Size(194, 40);
            this.btnQLXe.TabIndex = 1;
            this.btnQLXe.Text = "Quản Lí Xe";
            this.btnQLXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXe.UseVisualStyleBackColor = false;
            this.btnQLXe.Click += new System.EventHandler(this.BtnQLXe_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTongQuan.FlatAppearance.BorderSize = 0;
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTongQuan.Size = new System.Drawing.Size(194, 40);
            this.btnTongQuan.TabIndex = 0;
            this.btnTongQuan.Text = "Tổng Quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.UseVisualStyleBackColor = false;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // usSideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbTong);
            this.Name = "usSideBar";
            this.Size = new System.Drawing.Size(200, 750);
            this.tbTong.ResumeLayout(false);
            this.tbLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.subMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void BtnQLXe_Click(object sender, EventArgs e)
        {
            subMenuVisible = !subMenuVisible;
            subMenuPanel.Visible = subMenuVisible;
            subMenuPanel.Height = subMenuVisible ? 90 : 0;
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
