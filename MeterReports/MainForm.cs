using System;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel1.Width = Convert.ToInt32(Convert.ToDecimal(Screen.PrimaryScreen.Bounds.Width) * 0.90m);
            treeView1.Width = Convert.ToInt32(Convert.ToDecimal(Screen.PrimaryScreen.Bounds.Width) * 0.10m);
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }
    }
}
