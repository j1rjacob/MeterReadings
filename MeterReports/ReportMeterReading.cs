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
            cryRpt.Load(Application.StartupPath + "\\Reports\\TopMeters.rpt");
            CrystalReportViewer.ReportSource = cryRpt;
            CrystalReportViewer.Refresh();
        }

        private void ReportMeterReading_Load(object sender, System.EventArgs e)
        {
            LoadReport();
        }
    }
}
