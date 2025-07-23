namespace DoAn.Forms.Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tbTong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tbTong.Controls.Add(tbTrai, 0, 0);
            tbTong.Controls.Add(tbPhai, 1, 0);
            tbTong.Dock = DockStyle.Fill;
            tbTong.Location = new Point(0, 0);
            tbTong.Margin = new Padding(3, 2, 3, 2);
            tbTong.Name = "tbTong";
            tbTong.RowCount = 1;
            tbTong.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tbTong.Size = new Size(1300, 900);
            tbTong.TabIndex = 0;
            // 
            // tbTrai
            // 
            tbTrai.ColumnCount = 1;
            tbTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 279F));
            tbTrai.Controls.Add(panelLogo, 0, 0);
            tbTrai.Controls.Add(panelSideBar, 0, 1);
            tbTrai.Dock = DockStyle.Fill;
            tbTrai.Location = new Point(3, 2);
            tbTrai.Margin = new Padding(3, 2, 3, 2);
            tbTrai.Name = "tbTrai";
            tbTrai.RowCount = 2;
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tbTrai.Size = new Size(293, 896);
            tbTrai.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Fill;
            panelLogo.Location = new Point(3, 2);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(287, 220);
            panelLogo.TabIndex = 0;
            // 
            // panelSideBar
            // 
            panelSideBar.Dock = DockStyle.Fill;
            panelSideBar.Location = new Point(3, 226);
            panelSideBar.Margin = new Padding(3, 2, 3, 2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(287, 668);
            panelSideBar.TabIndex = 1;
            // 
            // tbPhai
            // 
            tbPhai.ColumnCount = 1;
            tbPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tbPhai.Controls.Add(panelTieuDe, 0, 0);
            tbPhai.Controls.Add(panelNoiDung, 0, 1);
            tbPhai.Dock = DockStyle.Fill;
            tbPhai.Location = new Point(302, 2);
            tbPhai.Margin = new Padding(3, 2, 3, 2);
            tbPhai.Name = "tbPhai";
            tbPhai.RowCount = 2;
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tbPhai.Size = new Size(995, 896);
            tbPhai.TabIndex = 1;
            // 
            // panelTieuDe
            // 
            panelTieuDe.Dock = DockStyle.Fill;
            panelTieuDe.Location = new Point(3, 2);
            panelTieuDe.Margin = new Padding(3, 2, 3, 2);
            panelTieuDe.Name = "panelTieuDe";
            panelTieuDe.Size = new Size(989, 85);
            panelTieuDe.TabIndex = 0;
            // 
            // panelNoiDung
            // 
            panelNoiDung.Dock = DockStyle.Fill;
            panelNoiDung.Location = new Point(3, 91);
            panelNoiDung.Margin = new Padding(3, 2, 3, 2);
            panelNoiDung.Name = "panelNoiDung";
            panelNoiDung.Size = new Size(989, 803);
            panelNoiDung.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(1300, 900);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1138, 600);
            Controls.Add(tbTong);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
