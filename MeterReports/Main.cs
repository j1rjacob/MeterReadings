using System;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(User))
                {
                    form.WindowState = FormWindowState.Normal;
                    return;
                }
                if (form.GetType() == typeof(Gateway))
                {
                    form.WindowState = FormWindowState.Normal;
                    return;
                }
                if (form.GetType() == typeof(Meter))
                {
                    form.WindowState = FormWindowState.Normal;
                    return;
                }
                if (form.GetType() == typeof(Gateway))
                {
                    form.WindowState = FormWindowState.Normal;
                    return;
                }
                if (form.GetType() == typeof(Gateway))
                {
                    form.WindowState = FormWindowState.Normal;
                    return;
                }
            }

            if (node.Text == "User")
            {
                User user = new User();
                user.MdiParent = this;
                user.Show();
            }
            if (node.Text == "Gateway")
            {
                Gateway gw = new Gateway();
                gw.MdiParent = this;
                gw.Show();
            }
            if (node.Text == "Meter")
            {
                Meter m = new Meter();
                m.MdiParent = this;
                m.Show();
            }
            if (node.Text == "MeterType")
            {
                MeterType m = new MeterType();
                m.MdiParent = this;
                m.Show();
            }
            if (node.Text == "DMZ")
            {
                DMZ dmz = new DMZ();
                dmz.MdiParent = this;
                dmz.Show();
            }
        }
    }
}
