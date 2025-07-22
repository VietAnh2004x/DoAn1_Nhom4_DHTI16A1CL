using System.Data;
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
            chartTopSanPham.ChartAreas.Clear(); // Xóa các ChartArea cũ để thiết lập lại
            chartTopSanPham.ChartAreas.Add(new ChartArea("ChartArea1")); // Thêm ChartArea mặc định

            // Thiết lập ChartArea
            chartTopSanPham.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            chartTopSanPham.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn để dễ đọc
            chartTopSanPham.ChartAreas[0].AxisX.Interval = 1; // Khoảng cách giữa các nhãn
            chartTopSanPham.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Ẩn lưới dọc
            chartTopSanPham.ChartAreas[0].AxisX.Title = ""; // Có thể đặt tiêu đề trục X nếu cần
            chartTopSanPham.ChartAreas[0].AxisY.MajorGrid.Enabled = true; // Hiện lưới ngang
            chartTopSanPham.ChartAreas[0].AxisY.Title = "Số lượng bán"; // Tiêu đề trục Y
            // Thêm vào sau phần thiết lập ChartArea của chartTopSanPham
            chartTopSanPham.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartTopSanPham.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            chartTopSanPham.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartTopSanPham.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 11, FontStyle.Bold);

            Series barSeries = new Series("Sản phẩm bán chạy") // Tên Series này sẽ không xuất hiện trong Legend nếu bạn thêm LegendItem thủ công
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true, // Hiển thị giá trị số trên đỉnh cột
                Color = Color.LightGray, // Màu mặc định cho series, sẽ bị ghi đè bởi DataPoint.Color
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

            // Thay đổi tiêu đề biểu đồ
            chartTopSanPham.Titles.Clear();
            chartTopSanPham.Titles.Add(new Title("Top 3 Sản Phẩm Bán Chạy",
                                              Docking.Top,
                                              new Font("Arial", 12, FontStyle.Bold), // Điều chỉnh font size ở đây
                                              Color.Black));
            chartTopSanPham.Update();


            // --- Biểu đồ Doanh Thu Theo 3 Tháng Gần Nhất ---
            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.ChartAreas.Add(new ChartArea("ChartArea1"));

            // Thiết lập ChartArea
            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn
            chartDoanhThu.ChartAreas[0].AxisX.Interval = 1;
            chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Ẩn lưới dọc
            chartDoanhThu.ChartAreas[0].AxisY.MajorGrid.Enabled = true; // Hiện lưới ngang
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)"; // Tiêu đề trục Y
            // Thêm vào sau phần thiết lập ChartArea của chartDoanhThu
            chartDoanhThu.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            chartDoanhThu.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 11, FontStyle.Bold);

            Series columnSeries = new Series("Doanh thu theo tháng") // Tên Series
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true, // Hiển thị giá trị số trên đỉnh cột
                Color = Color.LightGray, // Màu mặc định
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

            // Thay đổi tiêu đề biểu đồ
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add(new Title("Doanh Thu Theo 3 Tháng Gần Nhất",
                                             Docking.Top,
                                             new Font("Arial", 12, FontStyle.Bold), // Điều chỉnh font size ở đây
                                             Color.Black));

            chartDoanhThu.Update();
        }
    }
}
