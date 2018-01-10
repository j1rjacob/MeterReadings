using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class FormWaterConsumption : Form
    {
        public FormWaterConsumption()
        {
            InitializeComponent();

            cartesianChart1.Series = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {4, 5, 6, 8},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {2, 5, 6, 7},
                    StackMode = StackMode.Values,
                    DataLabels = true
                }
            };

            //adding series updates and animates the chart
            cartesianChart1.Series.Add(new StackedColumnSeries
            {
                Values = new ChartValues<double> { 6, 2, 7 },
                StackMode = StackMode.Values
            });

            //adding values also updates and animates
            cartesianChart1.Series[2].Values.Add(4d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "KSA",
                Labels = new[] { "Riyadh", "Jizan", "Dammam", "Jeddah" },
                Separator = DefaultAxes.CleanSeparator
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Usage",
                LabelFormatter = value => value + " m3"
            });
        }
    }
}
