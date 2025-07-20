using FontAwesome.Sharp;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoAn1.Forms.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Tạo lời chào theo quyền
            string loiChao = "Xin chào ";

            switch (Session.MaQuyen)
            {
                case "1":
                    loiChao += "chủ cửa hàng";
                    break;
                case "2":
                    loiChao += "quản lý";
                    break;
                default:
                    loiChao += "nhân viên";
                    break;
            }

            // Logo
            usLogo logo = new usLogo();
            logo.SetLoiChao(loiChao); // Gửi lời chào tới chữ chạy
            logo.Dock = DockStyle.Fill;
            panelLogo.Controls.Add(logo);

            // Tiêu đề
            usTieuDe TieuDe = new usTieuDe();
            TieuDe.Dock = DockStyle.Fill;
            panelTieuDe.Controls.Add(TieuDe);

            // Sidebar
            usSideBar sideBar = new usSideBar((title, icon, uc) =>
            {
                TieuDe.SetTieuDe(title, icon);
                LoadUserControl(uc);
            });
            sideBar.Dock = DockStyle.Fill;
            panelSideBar.Controls.Add(sideBar);
        }

        private void LoadUserControl(UserControl uc)
        {
            panelNoiDung.Controls.Clear(); // Dọn sạch cũ
            uc.Dock = DockStyle.Fill;
            panelNoiDung.Controls.Add(uc);
        }
    }
}
