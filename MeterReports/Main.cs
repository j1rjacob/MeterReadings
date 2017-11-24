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

        private bool OpenForms<T>()
        {
            bool result=false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.WindowState = FormWindowState.Normal;                    
                    result =true;
                    break;
                }
            }
            return result;
        }
        private void treeViewMain_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeViewMain.SelectedNode;
            
            switch (node.Text)
            {
                case "User":
                    var user = new User();
                    if (!OpenForms<User>())
                    {
                        user.MdiParent = this;
                        user.Show();
                    }
                    break;
                case "Gateway":
                    var gw = new Gateway();
                    if (!OpenForms<Gateway>())
                    {
                        gw.MdiParent = this;
                        gw.Show();
                    }
                    break;
                case "Meter":
                    var m = new Meter();
                    if (!OpenForms<Meter>())
                    {
                        m.MdiParent = this;
                        m.Show();
                    }
                    break;
                case "MeterType":
                    var mt = new MeterType();
                    if (!OpenForms<MeterType>())
                    {
                        mt.MdiParent = this;
                        mt.Show();
                    }
                    break;
                case "DMZ":
                    var d = new DMZ();
                    if (!OpenForms<DMZ>())
                    {
                        d.MdiParent = this;
                        d.Show();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
