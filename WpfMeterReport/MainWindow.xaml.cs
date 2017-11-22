using MahApps.Metro.Controls;
using System.Windows;

namespace WpfMeterReport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonGateway_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new GatewayLogs();
            f.Show();
            this.Close();
        }

        private void ButtonMeter_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new MeterReadings();
            f.Show();
            this.Close();
        }

        private void ButtonLogOut_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new Login();
            f.Show();
            this.Close();
        }

        private void ButtonUser_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new User();
            f.Show();
            this.Close();
        }
    }
}
