using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace MeterReport
{
    public partial class frmMain : MetroForm
    {
        private static frmMain _instance;
        public frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mlBack; }
            set { mlBack = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mlBack.Visible = false;
            _instance = this;
            ucDashBoard uc =new ucDashBoard();
            uc.Dock = DockStyle.Right;
            mPanel.Controls.Add(uc);
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            //mPanel.Controls["ucDashBoard"].BringToFront();
            mlBack.Visible = false;

            _instance = this;
            ucDashBoard uc = new ucDashBoard();
            uc.Dock = DockStyle.Right;
            Instance.MetroContainer.Controls.Clear();
            Instance.MetroContainer.Controls.Add(uc);
        }
    }
}
