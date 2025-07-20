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
        private TongQuanBLL tongQuanBLL;

        public usTongQuan()
        {
            InitializeComponent();
            tongQuanBLL = new TongQuanBLL();
            Load_DuLieu();
        }

        private void Load_DuLieu()
        {
            // Lấy dữ liệu từ TongQuanBLL
            int soLuongXeDapDien = tongQuanBLL.LaySoLuongXeTheoLoai("Xe đạp điện");
            int soLuongXeMayDien = tongQuanBLL.LaySoLuongXeTheoLoai("Xe máy điện");
            decimal tongDoanhThu = tongQuanBLL.LayTongDoanhThu();
            int soDonHang = tongQuanBLL.LaySoLuongDonHang();

            // Lấy TOP 3 sản phẩm bán chạy
            List<(string TenXe, int SoLuong)> topSanPhamBanChay = tongQuanBLL.LayTopSanPhamBanChay(3);

            // Lấy Doanh thu theo tháng và chỉ lấy 3 tháng đầu tiên (đã sắp xếp)
            List<(int Thang, decimal TongTien)> doanhThuTheoThang = tongQuanBLL.LayDoanhThuTheoThang()
                                                                       .OrderBy(x => x.Thang)
                                                                       .Take(3)
                                                                       .ToList();

            // Gán số liệu vào các TextBox
            txtSoLuongXeDapDien.Text = $"{soLuongXeDapDien} Xe";
            txtSoLuongXeMayDien.Text = $"{soLuongXeMayDien} Xe";
            txtDoanhThu.Text = $"{tongDoanhThu:N0} VNĐ";
            txtSoDonHang.Text = $"{soDonHang} Đơn hàng";

            // Định nghĩa một mảng màu để sử dụng
            Color[] colors = { Color.MediumTurquoise, Color.LightCoral, Color.LightGreen, Color.LightSalmon, Color.LightSkyBlue, Color.Violet };

            // --- Biểu đồ Top 3 Sản phẩm bán chạy ---
            chartTopSanPham.Series.Clear();
            chartTopSanPham.Legends.Clear(); // Bỏ chú thích đi
            chartTopSanPham.ChartAreas.Clear(); // Xóa các ChartArea cũ
            chartTopSanPham.ChartAreas.Add(new ChartArea("ChartArea1")); // Thêm ChartArea mặc định

            // Thiết lập ChartArea cho trục X
            chartTopSanPham.ChartAreas[0].AxisX.LabelStyle.Enabled = true; // Bật nhãn trục X
            chartTopSanPham.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn để dễ đọc nếu tên dài
            chartTopSanPham.ChartAreas[0].AxisX.Interval = 1; // Đảm bảo khoảng cách giữa các nhãn là 1
            chartTopSanPham.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Ẩn lưới dọc
            chartTopSanPham.ChartAreas[0].AxisX.MajorTickMark.Enabled = false; // Ẩn dấu tích chính trên trục X
            chartTopSanPham.ChartAreas[0].AxisX.Title = ""; // Bỏ tiêu đề trục X nếu không cần

            // Thiết lập ChartArea cho trục Y
            chartTopSanPham.ChartAreas[0].AxisY.MajorGrid.Enabled = true; // Hiện lưới ngang
            chartTopSanPham.ChartAreas[0].AxisY.Title = "Số lượng bán"; // Tiêu đề trục Y


            Series barSeries = new Series("Top sản phẩm bán chạy") // Tên Series này sẽ không hiển thị trong legend nữa
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true, // Hiển thị giá trị số trên đỉnh cột
                // IsVisibleInLegend = false, // Không hiển thị series này trong legend mặc định
                CustomProperties = "PointWidth=0.8" // Thiết lập PointWidth cho tất cả các điểm trong series
            };

            int colorIndex = 0;
            foreach (var item in topSanPhamBanChay)
            {
                DataPoint dp = new DataPoint();
                dp.SetValueXY(item.TenXe, item.SoLuong);
                dp.Color = colors[colorIndex % colors.Length]; // Gán màu cho từng cột
                barSeries.Points.Add(dp);
                colorIndex++;
            }
            chartTopSanPham.Series.Add(barSeries);

            chartTopSanPham.Titles.Clear();
            chartTopSanPham.Titles.Add("Top 3 Sản Phẩm Bán Chạy");
            chartTopSanPham.Update();


            // --- Biểu đồ Doanh Thu Theo 3 Tháng Gần Nhất ---
            chartDoanhThu.Series.Clear();
            chartDoanhThu.Legends.Clear(); // Bỏ chú thích đi
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.ChartAreas.Add(new ChartArea("ChartArea1"));

            // Thiết lập ChartArea cho trục X
            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn
            chartDoanhThu.ChartAreas[0].AxisX.Interval = 1;
            chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartDoanhThu.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chartDoanhThu.ChartAreas[0].AxisX.Title = ""; // Bỏ tiêu đề trục X

            // Thiết lập ChartArea cho trục Y
            chartDoanhThu.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";


            Series columnSeries = new Series("Doanh thu theo tháng") // Tên Series
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true, // Hiển thị giá trị số trên đỉnh cột
                // IsVisibleInLegend = false,
                CustomProperties = "PointWidth=0.8" // Thiết lập PointWidth
            };

            colorIndex = 0;
            foreach (var item in doanhThuTheoThang.OrderBy(x => x.Thang))
            {
                string thangLabel = $"Tháng {item.Thang}";
                DataPoint dp = new DataPoint();
                dp.SetValueXY(thangLabel, item.TongTien);
                dp.Color = colors[colorIndex % colors.Length]; // Gán màu cho từng cột
                columnSeries.Points.Add(dp);
                colorIndex++;
            }
            chartDoanhThu.Series.Add(columnSeries);

            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add("Doanh Thu Theo 3 Tháng Gần Nhất");
            chartDoanhThu.Update();
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
