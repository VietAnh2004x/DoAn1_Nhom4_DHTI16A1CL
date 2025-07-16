using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.TongQuan
{
    partial class usTongQuan
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

        private void InitializeComponent()
        {
            tbTong = new TableLayoutPanel();
            tbHienThi = new TableLayoutPanel();
            txtSoDonHang = new Label();
            txtDoanhThu = new Label();
            txtSoLuongXeMayDien = new Label();
            txtSoLuongXeDapDien = new Label();
            lblSoDonHang = new Label();
            lblDoanhThu = new Label();
            lblSoLuongXeMayDien = new Label();
            lblSoLuongXeDapDien = new Label();
            tbBangBieu = new TableLayoutPanel();
            tbTong.SuspendLayout();
            tbHienThi.SuspendLayout();
            SuspendLayout();
            // 
            // tbTong
            // 
            tbTong.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbTong.ColumnCount = 1;
            tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tbTong.Controls.Add(tbHienThi, 0, 0);
            tbTong.Controls.Add(tbBangBieu, 0, 1);
            tbTong.Dock = DockStyle.Fill;
            tbTong.Location = new Point(0, 0);
            tbTong.Margin = new Padding(4, 5, 4, 5);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 2;
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tbTong.Size = new Size(1067, 692);
            tbTong.TabIndex = 1;
            // 
            // tbHienThi
            // 
            tbHienThi.ColumnCount = 4;
            tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbHienThi.Controls.Add(txtSoDonHang, 3, 1);
            tbHienThi.Controls.Add(txtDoanhThu, 2, 1);
            tbHienThi.Controls.Add(txtSoLuongXeMayDien, 1, 1);
            tbHienThi.Controls.Add(txtSoLuongXeDapDien, 0, 1);
            tbHienThi.Controls.Add(lblSoDonHang, 3, 0);
            tbHienThi.Controls.Add(lblDoanhThu, 2, 0);
            tbHienThi.Controls.Add(lblSoLuongXeMayDien, 1, 0);
            tbHienThi.Controls.Add(lblSoLuongXeDapDien, 0, 0);
            tbHienThi.Dock = DockStyle.Fill;
            tbHienThi.Location = new Point(4, 5);
            tbHienThi.Margin = new Padding(4, 5, 4, 5);
            tbHienThi.Name = "tbHienThi";
            tbHienThi.RowCount = 2;
            tbHienThi.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tbHienThi.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tbHienThi.Size = new Size(1059, 220);
            tbHienThi.TabIndex = 0;
            // 
            // txtSoDonHang
            // 
            txtSoDonHang.BackColor = Color.FromArgb(255, 204, 229);
            txtSoDonHang.Dock = DockStyle.Fill;
            txtSoDonHang.Font = new Font("Segoe UI Semibold", 16F);
            txtSoDonHang.ForeColor = Color.DarkRed;
            txtSoDonHang.Location = new Point(796, 132);
            txtSoDonHang.Margin = new Padding(4, 0, 4, 0);
            txtSoDonHang.Name = "txtSoDonHang";
            txtSoDonHang.Size = new Size(259, 88);
            txtSoDonHang.TabIndex = 7;
            txtSoDonHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDoanhThu
            // 
            txtDoanhThu.BackColor = Color.FromArgb(255, 255, 204);
            txtDoanhThu.Dock = DockStyle.Fill;
            txtDoanhThu.Font = new Font("Segoe UI Semibold", 16F);
            txtDoanhThu.ForeColor = Color.DarkOrange;
            txtDoanhThu.Location = new Point(532, 132);
            txtDoanhThu.Margin = new Padding(4, 0, 4, 0);
            txtDoanhThu.Name = "txtDoanhThu";
            txtDoanhThu.Size = new Size(256, 88);
            txtDoanhThu.TabIndex = 6;
            txtDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSoLuongXeMayDien
            // 
            txtSoLuongXeMayDien.BackColor = Color.FromArgb(204, 255, 229);
            txtSoLuongXeMayDien.Dock = DockStyle.Fill;
            txtSoLuongXeMayDien.Font = new Font("Segoe UI Semibold", 16F);
            txtSoLuongXeMayDien.ForeColor = Color.DarkGreen;
            txtSoLuongXeMayDien.Location = new Point(268, 132);
            txtSoLuongXeMayDien.Margin = new Padding(4, 0, 4, 0);
            txtSoLuongXeMayDien.Name = "txtSoLuongXeMayDien";
            txtSoLuongXeMayDien.Size = new Size(256, 88);
            txtSoLuongXeMayDien.TabIndex = 5;
            txtSoLuongXeMayDien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSoLuongXeDapDien
            // 
            txtSoLuongXeDapDien.BackColor = Color.FromArgb(204, 229, 255);
            txtSoLuongXeDapDien.Dock = DockStyle.Fill;
            txtSoLuongXeDapDien.Font = new Font("Segoe UI Semibold", 16F);
            txtSoLuongXeDapDien.ForeColor = Color.DarkBlue;
            txtSoLuongXeDapDien.Location = new Point(4, 132);
            txtSoLuongXeDapDien.Margin = new Padding(4, 0, 4, 0);
            txtSoLuongXeDapDien.Name = "txtSoLuongXeDapDien";
            txtSoLuongXeDapDien.Size = new Size(256, 88);
            txtSoLuongXeDapDien.TabIndex = 4;
            txtSoLuongXeDapDien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoDonHang
            // 
            lblSoDonHang.BackColor = Color.FromArgb(255, 204, 229);
            lblSoDonHang.Dock = DockStyle.Fill;
            lblSoDonHang.Font = new Font("Segoe UI Semibold", 16F);
            lblSoDonHang.ForeColor = Color.DarkRed;
            lblSoDonHang.Location = new Point(796, 0);
            lblSoDonHang.Margin = new Padding(4, 0, 4, 0);
            lblSoDonHang.Name = "lblSoDonHang";
            lblSoDonHang.Padding = new Padding(13, 0, 13, 0);
            lblSoDonHang.Size = new Size(259, 132);
            lblSoDonHang.TabIndex = 3;
            lblSoDonHang.Text = "Tổng số khách hàng mua hôm nay";
            lblSoDonHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.BackColor = Color.FromArgb(255, 255, 204);
            lblDoanhThu.Dock = DockStyle.Fill;
            lblDoanhThu.Font = new Font("Segoe UI Semibold", 16F);
            lblDoanhThu.ForeColor = Color.DarkOrange;
            lblDoanhThu.Location = new Point(532, 0);
            lblDoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Padding = new Padding(13, 0, 13, 0);
            lblDoanhThu.Size = new Size(256, 132);
            lblDoanhThu.TabIndex = 2;
            lblDoanhThu.Text = "Doanh thu hôm nay";
            lblDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoLuongXeMayDien
            // 
            lblSoLuongXeMayDien.BackColor = Color.FromArgb(204, 255, 229);
            lblSoLuongXeMayDien.Dock = DockStyle.Fill;
            lblSoLuongXeMayDien.Font = new Font("Segoe UI Semibold", 16F);
            lblSoLuongXeMayDien.ForeColor = Color.DarkGreen;
            lblSoLuongXeMayDien.Location = new Point(268, 0);
            lblSoLuongXeMayDien.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongXeMayDien.Name = "lblSoLuongXeMayDien";
            lblSoLuongXeMayDien.Padding = new Padding(13, 0, 13, 0);
            lblSoLuongXeMayDien.Size = new Size(256, 132);
            lblSoLuongXeMayDien.TabIndex = 1;
            lblSoLuongXeMayDien.Text = "Tổng số xe máy điện hiện có";
            lblSoLuongXeMayDien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoLuongXeDapDien
            // 
            lblSoLuongXeDapDien.BackColor = Color.FromArgb(204, 229, 255);
            lblSoLuongXeDapDien.Dock = DockStyle.Fill;
            lblSoLuongXeDapDien.Font = new Font("Segoe UI Semibold", 16F);
            lblSoLuongXeDapDien.ForeColor = Color.DarkBlue;
            lblSoLuongXeDapDien.Location = new Point(4, 0);
            lblSoLuongXeDapDien.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongXeDapDien.Name = "lblSoLuongXeDapDien";
            lblSoLuongXeDapDien.Padding = new Padding(13, 0, 13, 0);
            lblSoLuongXeDapDien.Size = new Size(256, 132);
            lblSoLuongXeDapDien.TabIndex = 0;
            lblSoLuongXeDapDien.Text = "Tổng số xe đạp điện hiện có";
            lblSoLuongXeDapDien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbBangBieu
            // 
            tbBangBieu.ColumnCount = 2;
            tbBangBieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbBangBieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbBangBieu.Dock = DockStyle.Fill;
            tbBangBieu.Location = new Point(4, 235);
            tbBangBieu.Margin = new Padding(4, 5, 4, 5);
            tbBangBieu.Name = "tbBangBieu";
            tbBangBieu.RowCount = 1;
            tbBangBieu.RowStyles.Add(new RowStyle(SizeType.Absolute, 337F));
            tbBangBieu.Size = new Size(1059, 452);
            tbBangBieu.TabIndex = 1;
            // 
            // usTongQuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbTong);
            Margin = new Padding(4, 5, 4, 5);
            Name = "usTongQuan";
            Size = new Size(1067, 692);
            tbTong.ResumeLayout(false);
            tbHienThi.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbHienThi;
        private System.Windows.Forms.Label txtSoDonHang;
        private System.Windows.Forms.Label txtDoanhThu;
        private System.Windows.Forms.Label txtSoLuongXeMayDien;
        private System.Windows.Forms.Label txtSoLuongXeDapDien;
        private System.Windows.Forms.Label lblSoDonHang;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblSoLuongXeMayDien;
        private System.Windows.Forms.Label lblSoLuongXeDapDien;
        private System.Windows.Forms.TableLayoutPanel tbBangBieu;
        private Chart chartTopSanPham;
        private Chart chartDoanhThu;
    }
}
