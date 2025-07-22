using FontAwesome.Sharp;

namespace DoAn.Forms.Main
{
    public partial class usTieuDe : UserControl
    {
        public usTieuDe()
        {
            InitializeComponent();
        }
        public void SetTieuDe(string title, IconChar icon)
        {
            lblTieuDe.Text = title;
            icTieuDe.IconChar = icon;
        }
        private void BlinkingTimer_Tick(object sender, EventArgs e)
        {
            lblTieuDe.ForeColor = blinkingColors[colorIndex];
            icTieuDe.ForeColor = blinkingColors[colorIndex];

            colorIndex = (colorIndex + 1) % blinkingColors.Length;
        }
    }
}   
