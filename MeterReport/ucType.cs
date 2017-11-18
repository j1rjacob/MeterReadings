using System;
using System.Linq;

namespace MeterReport
{
    public partial class ucType : MetroFramework.Controls.MetroUserControl
    {
        public ucType()
        {
            InitializeComponent();
        }

        private void ucType_Load(object sender, EventArgs e)
        {
            frmMain.Instance.MetroContainer.Controls.RemoveByKey("ucDashBoard");
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                categoryBindingSource.DataSource = db.Categories.ToList();
            }
        }
    }
}
