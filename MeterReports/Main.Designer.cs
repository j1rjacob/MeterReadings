namespace MeterReports
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Gateway");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Meter");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Meter Type");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Meter Protocol");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Meter Size");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("City");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("DMZ");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Meter Reading");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("System Management", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Meter 1", 2, 2);
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Meter 2", 2, 2);
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Gateway 1", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Gateway 2", 1, 1);
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Riyadh", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Dammam");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Jeddah");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatewayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterProtocolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterReadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMain.Location = new System.Drawing.Point(0, 24);
            this.treeViewMain.Name = "treeViewMain";
            treeNode11.Name = "Node1";
            treeNode11.Text = "User";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Gateway";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Meter";
            treeNode14.Name = "Node1";
            treeNode14.Text = "Meter Type";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Meter Protocol";
            treeNode16.Name = "Node3";
            treeNode16.Text = "Meter Size";
            treeNode17.Name = "Node1";
            treeNode17.Text = "City";
            treeNode35.Name = "Node2";
            treeNode35.Text = "DMZ";
            treeNode36.Name = "Node0";
            treeNode36.Text = "Meter Reading";
            treeNode37.Name = "Node0";
            treeNode37.Text = "System Management";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode37});
            this.treeViewMain.Size = new System.Drawing.Size(168, 442);
            this.treeViewMain.TabIndex = 1;
            this.treeViewMain.Visible = false;
            this.treeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMain_AfterSelect);
            this.treeViewMain.DoubleClick += new System.EventHandler(this.treeViewMain_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.fileManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // fileManagementToolStripMenuItem
            // 
            this.fileManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.gatewayToolStripMenuItem,
            this.meterToolStripMenuItem,
            this.meterTypeToolStripMenuItem,
            this.meterProtocolToolStripMenuItem,
            this.meterSizeToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.dMZToolStripMenuItem,
            this.meterReadingToolStripMenuItem});
            this.fileManagementToolStripMenuItem.Name = "fileManagementToolStripMenuItem";
            this.fileManagementToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.fileManagementToolStripMenuItem.Text = "System Management";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // gatewayToolStripMenuItem
            // 
            this.gatewayToolStripMenuItem.Name = "gatewayToolStripMenuItem";
            this.gatewayToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gatewayToolStripMenuItem.Text = "Gateway";
            this.gatewayToolStripMenuItem.Click += new System.EventHandler(this.gatewayToolStripMenuItem_Click);
            // 
            // meterToolStripMenuItem
            // 
            this.meterToolStripMenuItem.Name = "meterToolStripMenuItem";
            this.meterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.meterToolStripMenuItem.Text = "Meter";
            this.meterToolStripMenuItem.Click += new System.EventHandler(this.meterToolStripMenuItem_Click);
            // 
            // meterTypeToolStripMenuItem
            // 
            this.meterTypeToolStripMenuItem.Name = "meterTypeToolStripMenuItem";
            this.meterTypeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.meterTypeToolStripMenuItem.Text = "Meter Type";
            this.meterTypeToolStripMenuItem.Click += new System.EventHandler(this.meterTypeToolStripMenuItem_Click);
            // 
            // meterProtocolToolStripMenuItem
            // 
            this.meterProtocolToolStripMenuItem.Name = "meterProtocolToolStripMenuItem";
            this.meterProtocolToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.meterProtocolToolStripMenuItem.Text = "Meter Protocol";
            this.meterProtocolToolStripMenuItem.Click += new System.EventHandler(this.meterProtocolToolStripMenuItem_Click);
            // 
            // meterSizeToolStripMenuItem
            // 
            this.meterSizeToolStripMenuItem.Name = "meterSizeToolStripMenuItem";
            this.meterSizeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.meterSizeToolStripMenuItem.Text = "Meter Size";
            this.meterSizeToolStripMenuItem.Click += new System.EventHandler(this.meterSizeToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // dMZToolStripMenuItem
            // 
            this.dMZToolStripMenuItem.Name = "dMZToolStripMenuItem";
            this.dMZToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dMZToolStripMenuItem.Text = "DMZ";
            this.dMZToolStripMenuItem.Click += new System.EventHandler(this.dMZToolStripMenuItem_Click);
            // 
            // meterReadingToolStripMenuItem
            // 
            this.meterReadingToolStripMenuItem.Name = "meterReadingToolStripMenuItem";
            this.meterReadingToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.meterReadingToolStripMenuItem.Text = "Meter Reading";
            this.meterReadingToolStripMenuItem.Click += new System.EventHandler(this.meterReadingToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageListMain;
            this.treeView1.Location = new System.Drawing.Point(168, 24);
            this.treeView1.Name = "treeView1";
            treeNode38.ImageIndex = 2;
            treeNode38.Name = "NodeMeter1";
            treeNode38.SelectedImageIndex = 2;
            treeNode38.Text = "Meter 1";
            treeNode39.ImageIndex = 2;
            treeNode39.Name = "NodeMeter2";
            treeNode39.SelectedImageIndex = 2;
            treeNode39.Text = "Meter 2";
            treeNode40.ImageIndex = 1;
            treeNode40.Name = "NodeGateway1";
            treeNode40.SelectedImageIndex = 1;
            treeNode40.Text = "Gateway 1";
            treeNode41.ImageIndex = 1;
            treeNode41.Name = "NodeGateway2";
            treeNode41.SelectedImageIndex = 1;
            treeNode41.Text = "Gateway 2";
            treeNode42.Name = "NodeRiyadh";
            treeNode42.Text = "Riyadh";
            treeNode43.Name = "NodeDammam";
            treeNode43.Text = "Dammam";
            treeNode44.Name = "NodeJeddah";
            treeNode44.Text = "Jeddah";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43,
            treeNode44});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(168, 442);
            this.treeView1.TabIndex = 5;
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "region.png");
            this.imageListMain.Images.SetKeyName(1, "gateway.png");
            this.imageListMain.Images.SetKeyName(2, "energymeter.png");
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 466);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.treeViewMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatewayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterReadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterProtocolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
    }
}