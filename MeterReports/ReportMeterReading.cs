using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class ReportMeterReading : Form
    {
        public ReportMeterReading()
        {
            InitializeComponent();
        }

        private void LoadReport()
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Application.StartupPath + "\\CrystalReport1.rpt");
            CrystalReportViewer.ReportSource = cryRpt;
            CrystalReportViewer.Refresh();
        }
    }
}
