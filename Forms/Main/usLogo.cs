using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Forms.Main
{
    public partial class usLogo : UserControl
    {
        public usLogo()
        {
            InitializeComponent();

            // Giúp vẽ mượt, không nhấp nháy
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();

            scrollTimer = new System.Windows.Forms.Timer();
            scrollTimer.Interval = 30; // càng thấp càng mượt
            scrollTimer.Tick += ScrollTimer_Tick;
            scrollTimer.Start();
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
