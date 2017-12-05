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
                case "Meter Type":
                    meterTypeToolStripMenuItem.PerformClick();
                    break;
                case "Meter Protocol":
                    meterProtocolToolStripMenuItem.PerformClick();
                    break;
                case "Meter Size":
                    meterSizeToolStripMenuItem.PerformClick();
                    break;
                case "City":
                    cityToolStripMenuItem.PerformClick();
                    break;
                case "DMZ":
                    dMZToolStripMenuItem.PerformClick();
                    break;
                case "Meter Reading":
                    meterReadingToolStripMenuItem.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(_currentUser.Id.ToString());
            logoutToolStripMenuItem.Text = $"Logout {_currentUser.UserName}";
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = _userManager.FindById(_currentUser.Id);
            user.Locked = 0;
            _userManager.Update(user);

            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }

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
        private void meterProtocolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mp = new MeterProtocol(_currentUser);
            if (!OpenForms<MeterType>())
            {
                mp.MdiParent = this;
                mp.Show();
            }
        }
        private void meterSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ms = new MeterSize(_currentUser);
            if (!OpenForms<MeterType>())
            {
                ms.MdiParent = this;
                ms.Show();
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
        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ct = new Citi(_currentUser);
            if (!OpenForms<DMZ>())
            {
                ct.MdiParent = this;
                ct.Show();
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
