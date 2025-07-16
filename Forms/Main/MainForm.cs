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
            // Logo
            usLogo logo = new usLogo();
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
