using Microsoft.AspNet.Identity;
using System;
using System.Windows.Forms;
using TMF.Reports.BLL;
using TMF.Reports.Model;

namespace MeterReports
{
    public partial class Main : Form
    {
        private readonly CustomUser _currentUser;
        private CustomUserStore _userStore;
        private UserManager<CustomUser, int> _userManager;
        public Main(CustomUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _userStore = new CustomUserStore(new CustomUserDbContext());
            _userManager = new UserManager<CustomUser, int>(_userStore);
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
                    userToolStripMenuItem.PerformClick();
                    break;
                case "Gateway":
                    gatewayToolStripMenuItem.PerformClick();
                    break;
                case "Meter":
                    meterToolStripMenuItem.PerformClick();
                    break;
                case "MeterType":
                    meterTypeToolStripMenuItem.PerformClick();
                    break;
                case "DMZ":
                    dMZToolStripMenuItem.PerformClick();
                    break;
                case "MeterReading":
                    meterReadingToolStripMenuItem.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(_currentUser.Id.ToString());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = _userManager.FindById(_currentUser.Id);
            user.Locked = 0;
            _userManager.Update(user);

            var l = new Login();
            l.Show();
            this.Hide();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            logoutToolStripMenuItem.PerformClick();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = new User(_currentUser);
            if (!OpenForms<User>())
            {
                user.MdiParent = this;
                user.Show();
            }
        }

        private void gatewayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gw = new Gateway(_currentUser);
            if (!OpenForms<Gateway>())
            {
                gw.MdiParent = this;
                gw.Show();
            }
        }

        private void meterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new Meter(_currentUser);
            if (!OpenForms<Meter>())
            {
                m.MdiParent = this;
                m.Show();
            }
        }

        private void meterTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mt = new MeterType(_currentUser);
            if (!OpenForms<MeterType>())
            {
                mt.MdiParent = this;
                mt.Show();
            }
        }

        private void dMZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = new DMZ(_currentUser);
            if (!OpenForms<DMZ>())
            {
                d.MdiParent = this;
                d.Show();
            }
        }

        private void meterReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new MeterReading(_currentUser);
            if (!OpenForms<MeterReading>())
            {
                m.MdiParent = this;
                m.Show();
            }
        }
    }
}
