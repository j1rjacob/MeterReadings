using System;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class MainTest : Form
    {
        public MainTest()
        {
            InitializeComponent();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Citi))
                {
                    form.WindowState = FormWindowState.Normal;
                    return;
                }
            }

            if (node.Text == "City")
            {
                Citi uc = new Citi();
                uc.MdiParent = this;
                uc.Show();
            }
            if (node.Text == "DMZ")
            {
                DMZ uc = new DMZ();
                uc.MdiParent = this;
                uc.Show();
            }
        }
    }
}
