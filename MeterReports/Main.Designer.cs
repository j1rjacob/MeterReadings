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
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Gateway");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Meter");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Meter Type");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Meter Protocol");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Meter Size");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("City");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("DMZ");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Meter Reading");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("System Management", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Meter 1", 2, 2);
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Meter 2", 2, 2);
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Gateway 1", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Gateway 2", 1, 1);
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Riyadh", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Dammam");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Jeddah");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterConsumptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterReadingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMain.Location = new System.Drawing.Point(0, 24);
            this.treeViewMain.Name = "treeViewMain";
            treeNode28.Name = "Node1";
            treeNode28.Text = "User";
            treeNode29.Name = "Node2";
            treeNode29.Text = "Gateway";
            treeNode30.Name = "Node0";
            treeNode30.Text = "Meter";
            treeNode31.Name = "Node1";
            treeNode31.Text = "Meter Type";
            treeNode32.Name = "Node0";
            treeNode32.Text = "Meter Protocol";
            treeNode33.Name = "Node3";
            treeNode33.Text = "Meter Size";
            treeNode34.Name = "Node1";
            treeNode34.Text = "City";
            treeNode45.Name = "Node2";
            treeNode45.Text = "DMZ";
            treeNode46.Name = "Node0";
            treeNode46.Text = "Meter Reading";
            treeNode47.Name = "Node0";
            treeNode47.Text = "System Management";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode47});
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
            this.chartToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.fileManagementToolStripMenuItem,
            this.reportsToolStripMenuItem});
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
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
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
            treeNode48.ImageIndex = 2;
            treeNode48.Name = "NodeMeter1";
            treeNode48.SelectedImageIndex = 2;
            treeNode48.Text = "Meter 1";
            treeNode49.ImageIndex = 2;
            treeNode49.Name = "NodeMeter2";
            treeNode49.SelectedImageIndex = 2;
            treeNode49.Text = "Meter 2";
            treeNode50.ImageIndex = 1;
            treeNode50.Name = "NodeGateway1";
            treeNode50.SelectedImageIndex = 1;
            treeNode50.Text = "Gateway 1";
            treeNode51.ImageIndex = 1;
            treeNode51.Name = "NodeGateway2";
            treeNode51.SelectedImageIndex = 1;
            treeNode51.Text = "Gateway 2";
            treeNode52.Name = "NodeRiyadh";
            treeNode52.Text = "Riyadh";
            treeNode53.Name = "NodeDammam";
            treeNode53.Text = "Dammam";
            treeNode54.Name = "NodeJeddah";
            treeNode54.Text = "Jeddah";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53,
            treeNode54});
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
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waterConsumptionToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // waterConsumptionToolStripMenuItem
            // 
            this.waterConsumptionToolStripMenuItem.Name = "waterConsumptionToolStripMenuItem";
            this.waterConsumptionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.waterConsumptionToolStripMenuItem.Text = "Water Consumption";
            this.waterConsumptionToolStripMenuItem.Click += new System.EventHandler(this.waterConsumptionToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meterReadingsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // meterReadingsToolStripMenuItem
            // 
            this.meterReadingsToolStripMenuItem.Name = "meterReadingsToolStripMenuItem";
            this.meterReadingsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.meterReadingsToolStripMenuItem.Text = "Meter Readings";
            this.meterReadingsToolStripMenuItem.Click += new System.EventHandler(this.meterReadingsToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterConsumptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterReadingsToolStripMenuItem;
    }
}