using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Forms.Main
{
    public partial class usLogo : UserControl
    {
        private System.Windows.Forms.Timer scrollTimer;
        private int textX = 0;
        private int scrollSpeed = 2;
        private string marqueeText = "  Xin chào  ";
        private Font marqueeFont = new Font("Arial", 16, FontStyle.Bold);
        private Brush marqueeBrush = Brushes.RoyalBlue;
        public usLogo()
        {
            InitializeComponent();

            // Giúp vẽ mượt, không nhấp nháy
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();

            scrollTimer = new System.Windows.Forms.Timer();
            scrollTimer.Interval = 30; // càng thấp càng mượt
            scrollTimer.Tick += ScrollTimer_Tick!;
            scrollTimer.Start();
        }

        // Phương thức để gán lời chào từ MainForm
        public void SetLoiChao(string loiChao)
        {
            marqueeText = "  " + loiChao + "  ";
            textX = -TextRenderer.MeasureText(marqueeText, marqueeFont).Width; // reset vị trí chữ
        }
        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            textX += scrollSpeed;

            int textWidth = TextRenderer.MeasureText(marqueeText, marqueeFont).Width;
            if (textX > this.Width)
                textX = -textWidth;

            Invalidate(); // gọi lại OnPaint để vẽ lại
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ dòng chữ chính
            e.Graphics.DrawString(marqueeText, marqueeFont, marqueeBrush, textX, this.Height - 40);

            // Tính chiều rộng của chữ
            int textWidth = (int)e.Graphics.MeasureString(marqueeText, marqueeFont).Width;

            // Vẽ phần đầu tiếp nối nếu cần
            if (textX + textWidth < this.Width)
            {
                e.Graphics.DrawString(marqueeText, marqueeFont, marqueeBrush, textX + textWidth, this.Height - 40);
            }
        }
    }

}
