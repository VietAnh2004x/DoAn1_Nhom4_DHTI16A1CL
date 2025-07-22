using DoAn1_Nhom4_DHTI16A1CL.Forms.TongQuan;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.MainForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            usSideBar sidebar = new usSideBar(LoadUserControl);
            sidebar.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(sidebar, 0, 0);

            LoadUserControl(new usTongQuan());
        }

        private void LoadUserControl(UserControl uc)
        {
            if (tableLayoutPanel1.Controls.Count > 1)
                tableLayoutPanel1.Controls.RemoveAt(1);

            uc.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(uc, 1, 0);
        }

    }
}
