using System;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class MainForm : Form
    {
        private static MainForm _instance;
        public MainForm()
        {
            InitializeComponent();
        }

        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainForm();
                return _instance;
            }
        }

        public System.Windows.Forms.Panel MainContainer
        {
            get { return MainPanel; }
            set { MainPanel = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPanel.Width = Convert.ToInt32(Convert.ToDecimal(Screen.PrimaryScreen.Bounds.Width) * 0.90m);
            treeViewMain.Width = Convert.ToInt32(Convert.ToDecimal(Screen.PrimaryScreen.Bounds.Width) * 0.10m);
        }

        private void treeViewMain_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeViewMain.SelectedNode;

            MainPanel.Controls.Clear();
            if (node.Text == "City")
            {
                ucCity uc = new ucCity();
                uc.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(uc);
            }
            if (node.Text == "DMZ")
            {
                ucDMZ uc = new ucDMZ();
                uc.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(uc);
            }
        }
    }
}
