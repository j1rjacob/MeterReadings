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
            panel1.Width = Convert.ToInt32(Convert.ToDecimal(Screen.PrimaryScreen.Bounds.Width) * 0.80m);
            panel2.Width = Convert.ToInt32(Convert.ToDecimal(Screen.PrimaryScreen.Bounds.Width) * 0.20m);
         
        
            //MessageBox.Show(Screen.PrimaryScreen.Bounds.Width.ToString());
            //MessageBox.Show(panel1.Width.ToString());
        }
        
    }
}
