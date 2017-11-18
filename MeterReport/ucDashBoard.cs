using System;
using System.Windows.Forms;

namespace MeterReport
{
    public partial class ucDashBoard : MetroFramework.Controls.MetroUserControl
    {
        private MetroFramework.Controls.MetroTile metroTileType;
        private MetroFramework.Controls.MetroTile metroTileProtocol;
        private MetroFramework.Controls.MetroTile metroTileSize;
        private MetroFramework.Controls.MetroTile metroTileMeter;

        public ucDashBoard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.metroTileType = new MetroFramework.Controls.MetroTile();
            this.metroTileProtocol = new MetroFramework.Controls.MetroTile();
            this.metroTileSize = new MetroFramework.Controls.MetroTile();
            this.metroTileMeter = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileType
            // 
            this.metroTileType.ActiveControl = null;
            this.metroTileType.Location = new System.Drawing.Point(8, 8);
            this.metroTileType.Name = "metroTileType";
            this.metroTileType.Size = new System.Drawing.Size(80, 64);
            this.metroTileType.TabIndex = 0;
            this.metroTileType.Text = "Type";
            this.metroTileType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileType.UseSelectable = true;
            this.metroTileType.Click += new System.EventHandler(this.metroTileType_Click);
            // 
            // metroTileProtocol
            // 
            this.metroTileProtocol.ActiveControl = null;
            this.metroTileProtocol.Location = new System.Drawing.Point(96, 8);
            this.metroTileProtocol.Name = "metroTileProtocol";
            this.metroTileProtocol.Size = new System.Drawing.Size(72, 64);
            this.metroTileProtocol.TabIndex = 0;
            this.metroTileProtocol.Text = "Protocol";
            this.metroTileProtocol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileProtocol.UseSelectable = true;
            this.metroTileProtocol.Click += new System.EventHandler(this.metroTileProtocol_Click);
            // 
            // metroTileSize
            // 
            this.metroTileSize.ActiveControl = null;
            this.metroTileSize.Location = new System.Drawing.Point(176, 8);
            this.metroTileSize.Name = "metroTileSize";
            this.metroTileSize.Size = new System.Drawing.Size(64, 64);
            this.metroTileSize.TabIndex = 0;
            this.metroTileSize.Text = "Size";
            this.metroTileSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSize.UseSelectable = true;
            // 
            // metroTileMeter
            // 
            this.metroTileMeter.ActiveControl = null;
            this.metroTileMeter.Location = new System.Drawing.Point(8, 80);
            this.metroTileMeter.Name = "metroTileMeter";
            this.metroTileMeter.Size = new System.Drawing.Size(232, 64);
            this.metroTileMeter.TabIndex = 0;
            this.metroTileMeter.Text = "Meter";
            this.metroTileMeter.UseSelectable = true;
            // 
            // ucDashBoard
            // 
            this.Controls.Add(this.metroTileSize);
            this.Controls.Add(this.metroTileProtocol);
            this.Controls.Add(this.metroTileMeter);
            this.Controls.Add(this.metroTileType);
            this.Name = "ucDashBoard";
            this.Size = new System.Drawing.Size(250, 479);
            this.Load += new System.EventHandler(this.ucDashBoard_Load);
            this.ResumeLayout(false);

        }

        private void ucDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void metroTileType_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucType"))
            {
                ucType uc = new ucType();
                uc.Dock = DockStyle.Bottom;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucType"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void metroTileProtocol_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("Protocol"))
            {
                Protocol uc = new Protocol();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["Protocol"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }
    }
}
