namespace DoAn1.Forms.Main
{
    partial class usLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usLogo));
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(49, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(173, 133);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // usLogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picLogo);
            Name = "usLogo";
            Size = new Size(287, 217);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);

        }

        private PictureBox picLogo;

        private System.Windows.Forms.Timer scrollTimer;
        private int textX = 0;
        private int scrollSpeed = 2;
        private string marqueeText = "  Xin chào Quản Lý  ";
        private Font marqueeFont = new Font("Arial", 16, FontStyle.Bold);
        private Brush marqueeBrush = Brushes.RoyalBlue;

    }
}
