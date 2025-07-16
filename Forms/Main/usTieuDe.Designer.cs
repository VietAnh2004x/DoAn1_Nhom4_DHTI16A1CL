namespace DoAn1.Forms.Main
{
    partial class usTieuDe
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
            components = new System.ComponentModel.Container();
            icTieuDe = new FontAwesome.Sharp.IconPictureBox();
            lblTieuDe = new Label();
            blinkingTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)icTieuDe).BeginInit();
            SuspendLayout();
            // 
            // icTieuDe
            // 
            icTieuDe.BackColor = Color.Transparent;
            icTieuDe.ForeColor = Color.FromArgb(52, 152, 219);
            icTieuDe.IconChar = FontAwesome.Sharp.IconChar.None;
            icTieuDe.IconColor = Color.FromArgb(52, 152, 219);
            icTieuDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icTieuDe.IconSize = 48;
            icTieuDe.Location = new Point(27, 17);
            icTieuDe.Name = "icTieuDe";
            icTieuDe.Size = new Size(48, 48);
            icTieuDe.TabIndex = 0;
            icTieuDe.TabStop = false;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(44, 62, 80);
            lblTieuDe.Location = new Point(87, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(0, 41);
            lblTieuDe.TabIndex = 1;
            // 
            // blinkingTimer
            // 
            blinkingTimer.Enabled = true;
            blinkingTimer.Interval = 500;
            blinkingTimer.Tick += BlinkingTimer_Tick;
            // 
            // usTieuDe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTieuDe);
            Controls.Add(icTieuDe);
            Name = "usTieuDe";
            Size = new Size(989, 83);
            ((System.ComponentModel.ISupportInitialize)icTieuDe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private FontAwesome.Sharp.IconPictureBox icTieuDe;
        private Label lblTieuDe;

        private System.Windows.Forms.Timer blinkingTimer;
        private int colorIndex = 0;
        private Color[] blinkingColors = new Color[]
        {
            Color.OrangeRed,
            Color.Tomato,
            Color.Goldenrod,
            Color.Gold,
            Color.YellowGreen,
            Color.LimeGreen,
            Color.MediumSeaGreen,
            Color.MediumTurquoise,
            Color.Turquoise,
            Color.DeepSkyBlue,
            Color.CornflowerBlue,
            Color.RoyalBlue,
            Color.MediumSlateBlue,
            Color.SlateBlue,
            Color.MediumOrchid,
            Color.Orchid,
            Color.HotPink,
            Color.DeepPink,
            Color.Crimson,
            Color.IndianRed
        };
    }
}
