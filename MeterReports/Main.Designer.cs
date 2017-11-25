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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Gateway");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Meter");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("MeterType");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("DMZ");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("File Management", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatewayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMain.Location = new System.Drawing.Point(0, 24);
            this.treeViewMain.Name = "treeViewMain";
            treeNode13.Name = "Node1";
            treeNode13.Text = "User";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Gateway";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Meter";
            treeNode16.Name = "Node1";
            treeNode16.Text = "MeterType";
            treeNode17.Name = "Node2";
            treeNode17.Text = "DMZ";
            treeNode18.Name = "Node0";
            treeNode18.Text = "File Management";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeViewMain.Size = new System.Drawing.Size(121, 442);
            this.treeViewMain.TabIndex = 1;
            this.treeViewMain.DoubleClick += new System.EventHandler(this.treeViewMain_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoFilesToolStripMenuItem,
            this.gotoAllToolStripMenuItem});
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.gotoToolStripMenuItem.Text = "Goto";
            // 
            // gotoFilesToolStripMenuItem
            // 
            this.gotoFilesToolStripMenuItem.Name = "gotoFilesToolStripMenuItem";
            this.gotoFilesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.gotoFilesToolStripMenuItem.Text = "Goto Files";
            // 
            // gotoAllToolStripMenuItem
            // 
            this.gotoAllToolStripMenuItem.Name = "gotoAllToolStripMenuItem";
            this.gotoAllToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.gotoAllToolStripMenuItem.Text = "Goto All";
            // 
            // fileManagementToolStripMenuItem
            // 
            this.fileManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.gatewayToolStripMenuItem,
            this.meterToolStripMenuItem,
            this.meterTypeToolStripMenuItem,
            this.dMZToolStripMenuItem});
            this.fileManagementToolStripMenuItem.Name = "fileManagementToolStripMenuItem";
            this.fileManagementToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.fileManagementToolStripMenuItem.Text = "File Management";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // gatewayToolStripMenuItem
            // 
            this.gatewayToolStripMenuItem.Name = "gatewayToolStripMenuItem";
            this.gatewayToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.gatewayToolStripMenuItem.Text = "Gateway";
            // 
            // meterToolStripMenuItem
            // 
            this.meterToolStripMenuItem.Name = "meterToolStripMenuItem";
            this.meterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.meterToolStripMenuItem.Text = "Meter";
            // 
            // meterTypeToolStripMenuItem
            // 
            this.meterTypeToolStripMenuItem.Name = "meterTypeToolStripMenuItem";
            this.meterTypeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.meterTypeToolStripMenuItem.Text = "Meter Type";
            // 
            // dMZToolStripMenuItem
            // 
            this.dMZToolStripMenuItem.Name = "dMZToolStripMenuItem";
            this.dMZToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dMZToolStripMenuItem.Text = "DMZ";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 466);
            this.Controls.Add(this.treeViewMain);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatewayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}