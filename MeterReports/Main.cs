using Microsoft.AspNet.Identity;
using System;
using System.Windows.Forms;
using TMF.Reports.Model;

namespace MeterReports
{
    public partial class Main : Form
    {
        private readonly CustomUser _currentUser;
        private UserManager<CustomUser, int> _userManager;
        public Main(CustomUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
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
                    var gw = new Gateway(_currentUser);
                    if (!OpenForms<Gateway>())
                    {
                        gw.MdiParent = this;
                        gw.Show();
                    }
                    break;
                case "Meter":
                    var m = new Meter(_currentUser);
                    if (!OpenForms<Meter>())
                    {
                        m.MdiParent = this;
                        m.Show();
                    }
                    break;
                case "MeterType":
                    var mt = new MeterType(_currentUser);
                    if (!OpenForms<MeterType>())
                    {
                        mt.MdiParent = this;
                        mt.Show();
                    }
                    break;
                case "DMZ":
                    var d = new DMZ(_currentUser);
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

        private void Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_currentUser.Id.ToString());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = _userManager.FindById(_currentUser.Id);
            user.Locked = 0;
            _userManager.Update(user);

            this.Close();
        }
    }
}
