using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn1.Forms.TongQuan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThi = new System.Windows.Forms.TableLayoutPanel();
            this.txtSoDonHang = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.Label();
            this.txtSoLuongXeMayDien = new System.Windows.Forms.Label();
            this.txtSoLuongXeDapDien = new System.Windows.Forms.Label();
            this.lblSoDonHang = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblSoLuongXeMayDien = new System.Windows.Forms.Label();
            this.lblSoLuongXeDapDien = new System.Windows.Forms.Label();
            this.tbBangBieu = new System.Windows.Forms.TableLayoutPanel();
            this.chartTopSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbBangBieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTong
            // 
            this.tbTong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTong.Controls.Add(this.tbHienThi, 0, 0);
            this.tbTong.Controls.Add(this.tbBangBieu, 0, 1);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbTong.Size = new System.Drawing.Size(800, 450);
            this.tbTong.TabIndex = 1;
            // 
            // tbHienThi
            // 
            this.tbHienThi.ColumnCount = 4;
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbHienThi.Controls.Add(this.txtSoDonHang, 3, 1);
            this.tbHienThi.Controls.Add(this.txtDoanhThu, 2, 1);
            this.tbHienThi.Controls.Add(this.txtSoLuongXeMayDien, 1, 1);
            this.tbHienThi.Controls.Add(this.txtSoLuongXeDapDien, 0, 1);
            this.tbHienThi.Controls.Add(this.lblSoDonHang, 3, 0);
            this.tbHienThi.Controls.Add(this.lblDoanhThu, 2, 0);
            this.tbHienThi.Controls.Add(this.lblSoLuongXeMayDien, 1, 0);
            this.tbHienThi.Controls.Add(this.lblSoLuongXeDapDien, 0, 0);
            this.tbHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThi.Location = new System.Drawing.Point(3, 3);
            this.tbHienThi.Name = "tbHienThi";
            this.tbHienThi.RowCount = 2;
            this.tbHienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbHienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbHienThi.Size = new System.Drawing.Size(794, 61);
            this.tbHienThi.TabIndex = 0;
            // 
            // txtSoDonHang
            // 
            this.txtSoDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.txtSoDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoDonHang.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txtSoDonHang.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSoDonHang.Location = new System.Drawing.Point(597, 36);
            this.txtSoDonHang.Name = "txtSoDonHang";
            this.txtSoDonHang.Size = new System.Drawing.Size(194, 25);
            this.txtSoDonHang.TabIndex = 7;
            this.txtSoDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.txtDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txtDoanhThu.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtDoanhThu.Location = new System.Drawing.Point(399, 36);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(192, 25);
            this.txtDoanhThu.TabIndex = 6;
            this.txtDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoLuongXeMayDien
            // 
            this.txtSoLuongXeMayDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.txtSoLuongXeMayDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuongXeMayDien.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txtSoLuongXeMayDien.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSoLuongXeMayDien.Location = new System.Drawing.Point(201, 36);
            this.txtSoLuongXeMayDien.Name = "txtSoLuongXeMayDien";
            this.txtSoLuongXeMayDien.Size = new System.Drawing.Size(192, 25);
            this.txtSoLuongXeMayDien.TabIndex = 5;
            this.txtSoLuongXeMayDien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoLuongXeDapDien
            // 
            this.txtSoLuongXeDapDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtSoLuongXeDapDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuongXeDapDien.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txtSoLuongXeDapDien.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtSoLuongXeDapDien.Location = new System.Drawing.Point(3, 36);
            this.txtSoLuongXeDapDien.Name = "txtSoLuongXeDapDien";
            this.txtSoLuongXeDapDien.Size = new System.Drawing.Size(192, 25);
            this.txtSoLuongXeDapDien.TabIndex = 4;
            this.txtSoLuongXeDapDien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoDonHang
            // 
            this.lblSoDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.lblSoDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoDonHang.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblSoDonHang.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSoDonHang.Location = new System.Drawing.Point(597, 0);
            this.lblSoDonHang.Name = "lblSoDonHang";
            this.lblSoDonHang.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblSoDonHang.Size = new System.Drawing.Size(194, 36);
            this.lblSoDonHang.TabIndex = 3;
            this.lblSoDonHang.Text = "Tổng số khách hàng mua hôm nay";
            this.lblSoDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.lblDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblDoanhThu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDoanhThu.Location = new System.Drawing.Point(399, 0);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDoanhThu.Size = new System.Drawing.Size(192, 36);
            this.lblDoanhThu.TabIndex = 2;
            this.lblDoanhThu.Text = "Doanh thu hôm nay";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoLuongXeMayDien
            // 
            this.lblSoLuongXeMayDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.lblSoLuongXeMayDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoLuongXeMayDien.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblSoLuongXeMayDien.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSoLuongXeMayDien.Location = new System.Drawing.Point(201, 0);
            this.lblSoLuongXeMayDien.Name = "lblSoLuongXeMayDien";
            this.lblSoLuongXeMayDien.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblSoLuongXeMayDien.Size = new System.Drawing.Size(192, 36);
            this.lblSoLuongXeMayDien.TabIndex = 1;
            this.lblSoLuongXeMayDien.Text = "Tổng số xe máy điện hiện có";
            this.lblSoLuongXeMayDien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoLuongXeDapDien
            // 
            this.lblSoLuongXeDapDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lblSoLuongXeDapDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoLuongXeDapDien.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblSoLuongXeDapDien.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSoLuongXeDapDien.Location = new System.Drawing.Point(3, 0);
            this.lblSoLuongXeDapDien.Name = "lblSoLuongXeDapDien";
            this.lblSoLuongXeDapDien.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblSoLuongXeDapDien.Size = new System.Drawing.Size(192, 36);
            this.lblSoLuongXeDapDien.TabIndex = 0;
            this.lblSoLuongXeDapDien.Text = "Tổng số xe đạp điện hiện có";
            this.lblSoLuongXeDapDien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBangBieu
            // 
            this.tbBangBieu.ColumnCount = 2;
            this.tbBangBieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBangBieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBangBieu.Controls.Add(this.chartTopSanPham, 0, 0);
            this.tbBangBieu.Controls.Add(this.chartDoanhThu, 1, 0);
            this.tbBangBieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBangBieu.Location = new System.Drawing.Point(3, 70);
            this.tbBangBieu.Name = "tbBangBieu";
            this.tbBangBieu.RowCount = 1;
            this.tbBangBieu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tbBangBieu.Size = new System.Drawing.Size(794, 129);
            this.tbBangBieu.TabIndex = 1;
            // 
            // chartTopSanPham
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTopSanPham.ChartAreas.Add(chartArea1);
            this.chartTopSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTopSanPham.Legends.Add(legend1);
            this.chartTopSanPham.Location = new System.Drawing.Point(3, 3);
            this.chartTopSanPham.Name = "chartTopSanPham";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sản Phẩm";
            this.chartTopSanPham.Series.Add(series1);
            this.chartTopSanPham.Size = new System.Drawing.Size(391, 213);
            this.chartTopSanPham.TabIndex = 0;
            this.chartTopSanPham.Text = "Top Sản Phẩm";
            // 
            // chartDoanhThu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea2);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend2);
            this.chartDoanhThu.Location = new System.Drawing.Point(400, 3);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "VNĐ";
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(391, 213);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "Doanh Thu";
            // 
            // usTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbTong);
            this.Name = "usTongQuan";
            this.Size = new System.Drawing.Size(800, 450);
            this.tbTong.ResumeLayout(false);
            this.tbHienThi.ResumeLayout(false);
            this.tbBangBieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            // Gán số liệu
            txtSoLuongXeDapDien.Text = "45 Xe";
            txtSoLuongXeMayDien.Text = "30 Xe";
            txtDoanhThu.Text = "12,000,000 VNĐ";
            txtSoDonHang.Text = "9 Khách Hàng";

            // Bar Chart - Top sản phẩm bán chạy
            chartTopSanPham.Series.Clear();
            Series barSeries = new Series("Sản phẩm")
            {
                ChartType = SeriesChartType.Column,
            };
            barSeries.Points.AddXY("VinFast Feliz", 15);
            barSeries.Points.AddXY("Yadea G5", 10);
            barSeries.Points.AddXY("DatBike Weaver", 8);
            chartTopSanPham.Series.Add(barSeries);

            // Column Chart - Doanh thu theo tháng
            chartDoanhThu.Series.Clear();
            Series columnSeries = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column
            };
            columnSeries.Points.AddXY("Tháng 1", 5000000);
            columnSeries.Points.AddXY("Tháng 2", 7000000);
            columnSeries.Points.AddXY("Tháng 3", 8500000);
            columnSeries.Points.AddXY("Tháng 4", 12000000);
            chartDoanhThu.Series.Add(columnSeries);
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
