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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Gateway");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Meter");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Meter Type");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Meter Protocol");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Meter Size");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("City");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("DMZ");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Meter Reading");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("System Management", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterConsumptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterReadingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeViewMeters = new System.Windows.Forms.TreeView();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMain.Location = new System.Drawing.Point(0, 24);
            this.treeViewMain.Name = "treeViewMain";
            treeNode1.Name = "Node1";
            treeNode1.Text = "User";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Gateway";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Meter";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Meter Type";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Meter Protocol";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Meter Size";
            treeNode7.Name = "Node1";
            treeNode7.Text = "City";
            treeNode8.Name = "Node2";
            treeNode8.Text = "DMZ";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Meter Reading";
            treeNode10.Name = "Node0";
            treeNode10.Text = "System Management";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
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
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
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
            // TreeViewMeters
            // 
            this.TreeViewMeters.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeViewMeters.ImageIndex = 0;
            this.TreeViewMeters.ImageList = this.imageListMain;
            this.TreeViewMeters.Location = new System.Drawing.Point(168, 24);
            this.TreeViewMeters.Name = "TreeViewMeters";
            this.TreeViewMeters.SelectedImageIndex = 0;
            this.TreeViewMeters.Size = new System.Drawing.Size(168, 442);
            this.TreeViewMeters.TabIndex = 5;
            this.TreeViewMeters.Visible = false;
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "region.png");
            this.imageListMain.Images.SetKeyName(1, "gateway.png");
            this.imageListMain.Images.SetKeyName(2, "energymeter.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 466);
            this.Controls.Add(this.TreeViewMeters);
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
        private System.Windows.Forms.TreeView TreeViewMeters;
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