using System;

namespace MeterReport
{
    public partial class Protocol : MetroFramework.Controls.MetroUserControl
    {
        public Protocol()
        {
            InitializeComponent();
        }

        private void Protocol_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var f = new Login();
            f.ShowDialog();
        }
    }
}
