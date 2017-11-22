using System.Windows;

namespace WpfMeterReport
{
    /// <summary>
    /// Interaction logic for Gateway.xaml
    /// </summary>
    public partial class Gateway 
    {
        private bool _saveSetting;

        public Gateway(bool SaveSetting)
        {
            InitializeComponent();
            _saveSetting = SaveSetting;
        }

        private void ButtonSave_OnClick(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void ButtonBack_OnClick(object sender, System.Windows.RoutedEventArgs e)
        {
            var f = new GatewayLogs();
            f.Show();
            this.Close();
        }

        private void Gateway_OnLoaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_saveSetting.ToString());
        }
    }
}
