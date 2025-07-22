namespace DoAn1.Forms.Main
{
    partial class MainForm
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
            tbTong = new TableLayoutPanel();
            tbTrai = new TableLayoutPanel();
            panelLogo = new Panel();
            panelSideBar = new Panel();
            tbPhai = new TableLayoutPanel();
            panelTieuDe = new Panel();
            panelNoiDung = new Panel();
            tbTong.SuspendLayout();
            tbTrai.SuspendLayout();
            tbPhai.SuspendLayout();
            SuspendLayout();
            // 
            // tbTong
            // 
            tbTong.ColumnCount = 2;
            tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tbTong.Controls.Add(tbTrai, 0, 0);
            tbTong.Controls.Add(tbPhai, 1, 0);
            tbTong.Dock = DockStyle.Fill;
            tbTong.Location = new Point(0, 0);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 1;
            tbTong.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbTong.Size = new Size(1300, 900);
            tbTong.TabIndex = 0;
            // 
            // tbTrai
            // 
            tbTrai.ColumnCount = 1;
            tbTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbTrai.Controls.Add(panelLogo, 0, 0);
            tbTrai.Controls.Add(panelSideBar, 0, 1);
            tbTrai.Dock = DockStyle.Fill;
            tbTrai.Location = new Point(3, 3);
            tbTrai.Name = "tbTrai";
            tbTrai.RowCount = 2;
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tbTrai.Size = new Size(319, 894);
            tbTrai.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Fill;
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(313, 172);
            panelLogo.TabIndex = 0;
            // 
            // panelSideBar
            // 
            panelSideBar.Dock = DockStyle.Fill;
            panelSideBar.Location = new Point(3, 181);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(313, 710);
            panelSideBar.TabIndex = 1;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbPhai.Controls.Add(panelTieuDe, 0, 0);
            tbPhai.Controls.Add(panelNoiDung, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(328, 3);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tbPhai.Size = new Size(969, 894);
            tbPhai.TabIndex = 1;
            // 
            // panelTieuDe
            // 
            panelTieuDe.Dock = DockStyle.Fill;
            panelTieuDe.Location = new Point(3, 3);
            panelTieuDe.Name = "panelTieuDe";
            panelTieuDe.Size = new Size(963, 128);
            panelTieuDe.TabIndex = 0;
            // 
            // panelNoiDung
            // 
            panelNoiDung.Dock = DockStyle.Fill;
            panelNoiDung.Location = new Point(3, 137);
            panelNoiDung.Name = "panelNoiDung";
            panelNoiDung.Size = new Size(963, 754);
            panelNoiDung.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            AutoScrollMinSize = new Size(1300, 900);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1300, 800);
            Controls.Add(tbTong);
            Name = "MainForm";
            Text = "Quản Lí Xe Điện";
            Load += MainForm_Load;
            tbTong.ResumeLayout(false);
            tbTrai.ResumeLayout(false);
            tbPhai.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tbTong;
        private TableLayoutPanel tbTrai;
        private TableLayoutPanel tbPhai;
        private Panel panelLogo;
        private Panel panelSideBar;
        private Panel panelTieuDe;
        private Panel panelNoiDung;
    }
}
