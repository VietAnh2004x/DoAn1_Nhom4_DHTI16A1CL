using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn.Forms.TongQuan
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
            // KHỞI TẠO CÁC BIỂU ĐỒ TRƯỚC CÁC CONTROLS KHÁC ĐỂ TRÁNH LỖI PHỤ THUỘC
            this.chartTopSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.tbTong = new TableLayoutPanel();
            this.tbHienThi = new TableLayoutPanel();
            this.txtSoDonHang = new Label();
            this.txtDoanhThu = new Label();
            this.txtSoLuongXeMayDien = new Label();
            this.txtSoLuongXeDapDien = new Label();
            this.lblSoDonHang = new Label();
            this.lblDoanhThu = new Label();
            this.lblSoLuongXeMayDien = new Label();
            this.lblSoLuongXeDapDien = new Label();
            this.tbBangBieu = new TableLayoutPanel();

            // Bắt đầu cấu hình cho Chart
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();

            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbBangBieu.SuspendLayout(); // Thêm dòng này để xử lý layout của tbBangBieu

            this.SuspendLayout();

            //
            // tbTong
            //
            this.tbTong.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // Changed from Absolute to Percent for flexibility
            this.tbTong.Controls.Add(this.tbHienThi, 0, 0);
            this.tbTong.Controls.Add(this.tbBangBieu, 0, 1);
            this.tbTong.Dock = DockStyle.Fill;
            this.tbTong.Location = new Point(0, 0);
            this.tbTong.Margin = new Padding(4, 5, 4, 5);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // Increased percentage for display area
            this.tbTong.RowStyles.Add(new RowStyle(SizeType.Percent, 70F)); // Increased percentage for charts
            this.tbTong.Size = new Size(1067, 692);
            this.tbTong.TabIndex = 1;
            //
            // tbHienThi
            //
            this.tbHienThi.ColumnCount = 4;
            this.tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tbHienThi.Controls.Add(this.txtSoDonHang, 3, 1);
            this.tbHienThi.Controls.Add(this.txtDoanhThu, 2, 1);
            this.tbHienThi.Controls.Add(this.txtSoLuongXeMayDien, 1, 1);
            this.tbHienThi.Controls.Add(this.txtSoLuongXeDapDien, 0, 1);
            this.tbHienThi.Controls.Add(this.lblSoDonHang, 3, 0);
            this.tbHienThi.Controls.Add(this.lblDoanhThu, 2, 0);
            this.tbHienThi.Controls.Add(this.lblSoLuongXeMayDien, 1, 0);
            this.tbHienThi.Controls.Add(this.lblSoLuongXeDapDien, 0, 0);
            this.tbHienThi.Dock = DockStyle.Fill;
            this.tbHienThi.Location = new Point(4, 5);
            this.tbHienThi.Margin = new Padding(4, 5, 4, 5);
            this.tbHienThi.Name = "tbHienThi";
            this.tbHienThi.RowCount = 2;
            this.tbHienThi.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            this.tbHienThi.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            this.tbHienThi.Size = new Size(1059, 207); // Kích thước này sẽ tự động được điều chỉnh bởi tbTong
            this.tbHienThi.TabIndex = 0;
            //
            // txtSoDonHang
            //
            this.txtSoDonHang.BackColor = Color.FromArgb(255, 204, 229);
            this.txtSoDonHang.Dock = DockStyle.Fill;
            this.txtSoDonHang.Font = new Font("Segoe UI Semibold", 16F);
            this.txtSoDonHang.ForeColor = Color.DarkRed;
            this.txtSoDonHang.Location = new Point(796, 124); // Adjusted based on new row heights
            this.txtSoDonHang.Margin = new Padding(4, 0, 4, 0);
            this.txtSoDonHang.Name = "txtSoDonHang";
            this.txtSoDonHang.Size = new Size(259, 83);
            this.txtSoDonHang.TabIndex = 7;
            this.txtSoDonHang.TextAlign = ContentAlignment.MiddleCenter;
            //
            // txtDoanhThu
            //
            this.txtDoanhThu.BackColor = Color.FromArgb(255, 255, 204);
            this.txtDoanhThu.Dock = DockStyle.Fill;
            this.txtDoanhThu.Font = new Font("Segoe UI Semibold", 16F);
            this.txtDoanhThu.ForeColor = Color.DarkOrange;
            this.txtDoanhThu.Location = new Point(532, 124); // Adjusted
            this.txtDoanhThu.Margin = new Padding(4, 0, 4, 0);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new Size(256, 83);
            this.txtDoanhThu.TabIndex = 6;
            this.txtDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            //
            // txtSoLuongXeMayDien
            //
            this.txtSoLuongXeMayDien.BackColor = Color.FromArgb(204, 255, 229);
            this.txtSoLuongXeMayDien.Dock = DockStyle.Fill;
            this.txtSoLuongXeMayDien.Font = new Font("Segoe UI Semibold", 16F);
            this.txtSoLuongXeMayDien.ForeColor = Color.DarkGreen;
            this.txtSoLuongXeMayDien.Location = new Point(268, 124); // Adjusted
            this.txtSoLuongXeMayDien.Margin = new Padding(4, 0, 4, 0);
            this.txtSoLuongXeMayDien.Name = "txtSoLuongXeMayDien";
            this.txtSoLuongXeMayDien.Size = new Size(256, 83);
            this.txtSoLuongXeMayDien.TabIndex = 5;
            this.txtSoLuongXeMayDien.TextAlign = ContentAlignment.MiddleCenter;
            //
            // txtSoLuongXeDapDien
            //
            this.txtSoLuongXeDapDien.BackColor = Color.FromArgb(204, 229, 255);
            this.txtSoLuongXeDapDien.Dock = DockStyle.Fill;
            this.txtSoLuongXeDapDien.Font = new Font("Segoe UI Semibold", 16F);
            this.txtSoLuongXeDapDien.ForeColor = Color.DarkBlue;
            this.txtSoLuongXeDapDien.Location = new Point(4, 124); // Adjusted
            this.txtSoLuongXeDapDien.Margin = new Padding(4, 0, 4, 0);
            this.txtSoLuongXeDapDien.Name = "txtSoLuongXeDapDien";
            this.txtSoLuongXeDapDien.Size = new Size(256, 83);
            this.txtSoLuongXeDapDien.TabIndex = 4;
            this.txtSoLuongXeDapDien.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSoDonHang
            //
            this.lblSoDonHang.BackColor = Color.FromArgb(255, 204, 229);
            this.lblSoDonHang.Dock = DockStyle.Fill;
            this.lblSoDonHang.Font = new Font("Segoe UI Semibold", 16F);
            this.lblSoDonHang.ForeColor = Color.DarkRed;
            this.lblSoDonHang.Location = new Point(796, 0);
            this.lblSoDonHang.Margin = new Padding(4, 0, 4, 0);
            this.lblSoDonHang.Name = "lblSoDonHang";
            this.lblSoDonHang.Padding = new Padding(13, 0, 13, 0);
            this.lblSoDonHang.Size = new Size(259, 124); // Adjusted
            this.lblSoDonHang.TabIndex = 3;
            this.lblSoDonHang.Text = "Tổng số khách hàng mua hôm nay";
            this.lblSoDonHang.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblDoanhThu
            //
            this.lblDoanhThu.BackColor = Color.FromArgb(255, 255, 204);
            this.lblDoanhThu.Dock = DockStyle.Fill;
            this.lblDoanhThu.Font = new Font("Segoe UI Semibold", 16F);
            this.lblDoanhThu.ForeColor = Color.DarkOrange;
            this.lblDoanhThu.Location = new Point(532, 0);
            this.lblDoanhThu.Margin = new Padding(4, 0, 4, 0);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Padding = new Padding(13, 0, 13, 0);
            this.lblDoanhThu.Size = new Size(256, 124); // Adjusted
            this.lblDoanhThu.TabIndex = 2;
            this.lblDoanhThu.Text = "Doanh thu hôm nay";
            this.lblDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSoLuongXeMayDien
            //
            this.lblSoLuongXeMayDien.BackColor = Color.FromArgb(204, 255, 229);
            this.lblSoLuongXeMayDien.Dock = DockStyle.Fill;
            this.lblSoLuongXeMayDien.Font = new Font("Segoe UI Semibold", 16F);
            this.lblSoLuongXeMayDien.ForeColor = Color.DarkGreen;
            this.lblSoLuongXeMayDien.Location = new Point(268, 0);
            this.lblSoLuongXeMayDien.Margin = new Padding(4, 0, 4, 0);
            this.lblSoLuongXeMayDien.Name = "lblSoLuongXeMayDien";
            this.lblSoLuongXeMayDien.Padding = new Padding(13, 0, 13, 0);
            this.lblSoLuongXeMayDien.Size = new Size(256, 124); // Adjusted
            this.lblSoLuongXeMayDien.TabIndex = 1;
            this.lblSoLuongXeMayDien.Text = "Tổng số xe máy điện hiện có";
            this.lblSoLuongXeMayDien.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSoLuongXeDapDien
            //
            this.lblSoLuongXeDapDien.BackColor = Color.FromArgb(204, 229, 255);
            this.lblSoLuongXeDapDien.Dock = DockStyle.Fill;
            this.lblSoLuongXeDapDien.Font = new Font("Segoe UI Semibold", 16F);
            this.lblSoLuongXeDapDien.ForeColor = Color.DarkBlue;
            this.lblSoLuongXeDapDien.Location = new Point(4, 0);
            this.lblSoLuongXeDapDien.Margin = new Padding(4, 0, 4, 0);
            this.lblSoLuongXeDapDien.Name = "lblSoLuongXeDapDien";
            this.lblSoLuongXeDapDien.Padding = new Padding(13, 0, 13, 0);
            this.lblSoLuongXeDapDien.Size = new Size(256, 124); // Adjusted
            this.lblSoLuongXeDapDien.TabIndex = 0;
            this.lblSoLuongXeDapDien.Text = "Tổng số xe đạp điện hiện có";
            this.lblSoLuongXeDapDien.TextAlign = ContentAlignment.MiddleCenter;
            //
            // tbBangBieu
            //
            this.tbBangBieu.ColumnCount = 2;
            this.tbBangBieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tbBangBieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            // THÊM CÁC BIỂU ĐỒ VÀO tbBangBieu
            this.tbBangBieu.Controls.Add(this.chartTopSanPham, 0, 0);
            this.tbBangBieu.Controls.Add(this.chartDoanhThu, 1, 0);
            this.tbBangBieu.Dock = DockStyle.Fill;
            this.tbBangBieu.Location = new Point(4, 217); // Adjusted starting Y based on new tbHienThi size
            this.tbBangBieu.Margin = new Padding(4, 5, 4, 5);
            this.tbBangBieu.Name = "tbBangBieu";
            this.tbBangBieu.RowCount = 1;
            this.tbBangBieu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // Adjusted
            this.tbBangBieu.Size = new Size(1059, 470); // Adjusted size
            this.tbBangBieu.TabIndex = 1;

            //
            // chartTopSanPham
            //
            this.chartTopSanPham.Dock = DockStyle.Fill;
            this.chartTopSanPham.Location = new Point(3, 3); // Position within TableLayoutPanel
            this.chartTopSanPham.Name = "chartTopSanPham";
            this.chartTopSanPham.Size = new Size(523, 464); // Adjusted size
            this.chartTopSanPham.TabIndex = 0;
            this.chartTopSanPham.Text = "chart1";
            // Thêm ChartArea cho chartTopSanPham
            ChartArea chartArea1 = new ChartArea("ChartArea1");
            this.chartTopSanPham.ChartAreas.Add(chartArea1);

            //
            // chartDoAn1_Nhom4_DHTI16A1CLhThu
            //
            this.chartDoanhThu.Dock = DockStyle.Fill;
            this.chartDoanhThu.Location = new Point(532, 3); // Position within TableLayoutPanel
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Size = new Size(524, 464); // Adjusted size
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "chart2";
            // Thêm ChartArea cho chartDoanhThu
            ChartArea chartArea2 = new ChartArea("ChartArea1"); // Có thể đặt tên khác nếu muốn (ví dụ "ChartArea2")
            this.chartDoanhThu.ChartAreas.Add(chartArea2);


            //
            // usTongQuan
            //
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.tbTong);
            this.Margin = new Padding(4, 5, 4, 5);
            this.Name = "usTongQuan";
            this.Size = new Size(1067, 692);

            // Kết thúc cấu hình cho Chart
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();

            this.tbTong.ResumeLayout(false);
            this.tbHienThi.ResumeLayout(false);
            this.tbBangBieu.ResumeLayout(false); // Thêm dòng này
            this.ResumeLayout(false);

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
        private Chart chartTopSanPham; // Đã khai báo
        private Chart chartDoanhThu;   // Đã khai báo
    }
}