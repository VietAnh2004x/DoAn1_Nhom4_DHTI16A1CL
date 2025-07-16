using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.TongQuan
{
    public partial class usTongQuan : UserControl
    {
        public usTongQuan()
        {
            InitializeComponent();
            Load_DuLieu();
        }

        private void Load_DuLieu()
        {

        }

        //private void LoadDashboard()
        //{
        //    // Gán số liệu
        //    txtSoLuongXeDapDien.Text = "45 Xe";
        //    txtSoLuongXeMayDien.Text = "30 Xe";
        //    txtDoanhThu.Text = "12,000,000 VNĐ";
        //    txtSoDonHang.Text = "9 Khách Hàng";

        //    // Bar Chart - Top sản phẩm bán chạy
        //    chartTopSanPham.Series.Clear();
        //    Series barSeries = new Series("Sản phẩm")
        //    {
        //        ChartType = SeriesChartType.Column,
        //    };
        //    barSeries.Points.AddXY("VinFast Feliz", 15);
        //    barSeries.Points.AddXY("Yadea G5", 10);
        //    barSeries.Points.AddXY("DatBike Weaver", 8);
        //    chartTopSanPham.Series.Add(barSeries);

        //    // Column Chart - Doanh thu theo tháng
        //    chartDoanhThu.Series.Clear();
        //    Series columnSeries = new Series("Doanh thu")
        //    {
        //        ChartType = SeriesChartType.Column
        //    };
        //    columnSeries.Points.AddXY("Tháng 1", 5000000);
        //    columnSeries.Points.AddXY("Tháng 2", 7000000);
        //    columnSeries.Points.AddXY("Tháng 3", 8500000);
        //    columnSeries.Points.AddXY("Tháng 4", 12000000);
        //    chartDoanhThu.Series.Add(columnSeries);
        //}
    }
}
