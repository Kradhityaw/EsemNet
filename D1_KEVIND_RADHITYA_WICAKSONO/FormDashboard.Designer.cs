namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKomputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPaketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePotonganHargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Size = new System.Drawing.Size(316, 888);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 10, 150, 10);
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(275, 56);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterKomputerToolStripMenuItem,
            this.masterPaketToolStripMenuItem,
            this.masterMemberToolStripMenuItem,
            this.masterKodePotonganHargaToolStripMenuItem});
            this.masterDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterDataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 10, 40, 10);
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(275, 56);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            this.masterDataToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masterKomputerToolStripMenuItem
            // 
            this.masterKomputerToolStripMenuItem.Name = "masterKomputerToolStripMenuItem";
            this.masterKomputerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.masterKomputerToolStripMenuItem.Size = new System.Drawing.Size(612, 40);
            this.masterKomputerToolStripMenuItem.Text = "Master Komputer";
            this.masterKomputerToolStripMenuItem.Click += new System.EventHandler(this.masterKomputerToolStripMenuItem_Click);
            // 
            // masterPaketToolStripMenuItem
            // 
            this.masterPaketToolStripMenuItem.Name = "masterPaketToolStripMenuItem";
            this.masterPaketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.masterPaketToolStripMenuItem.Size = new System.Drawing.Size(612, 40);
            this.masterPaketToolStripMenuItem.Text = "Master Paket";
            this.masterPaketToolStripMenuItem.Click += new System.EventHandler(this.masterPaketToolStripMenuItem_Click);
            // 
            // masterMemberToolStripMenuItem
            // 
            this.masterMemberToolStripMenuItem.Name = "masterMemberToolStripMenuItem";
            this.masterMemberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.masterMemberToolStripMenuItem.Size = new System.Drawing.Size(612, 40);
            this.masterMemberToolStripMenuItem.Text = "Master Member";
            this.masterMemberToolStripMenuItem.Click += new System.EventHandler(this.masterMemberToolStripMenuItem_Click);
            // 
            // masterKodePotonganHargaToolStripMenuItem
            // 
            this.masterKodePotonganHargaToolStripMenuItem.Name = "masterKodePotonganHargaToolStripMenuItem";
            this.masterKodePotonganHargaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.masterKodePotonganHargaToolStripMenuItem.Size = new System.Drawing.Size(612, 40);
            this.masterKodePotonganHargaToolStripMenuItem.Text = "Master Kode Potongan Harga";
            this.masterKodePotonganHargaToolStripMenuItem.Click += new System.EventHandler(this.masterKodePotonganHargaToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaksiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 10, 40, 10);
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(275, 56);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 10, 40, 10);
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(275, 56);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(316, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 888);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 888);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem masterKomputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterPaketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePotonganHargaToolStripMenuItem;
    }
}