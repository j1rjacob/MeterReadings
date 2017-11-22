using System.Windows;

namespace WpfMeterReport
{
    /// <summary>
    /// Interaction logic for Meters.xaml
    /// </summary>
    public partial class Meters
    {
        private bool _saveSetting;

        public Meters(bool SaveSetting) 
        {
            InitializeComponent();
            _saveSetting = SaveSetting;
        }

        private void Meter_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show(_saveSetting.ToString());
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new MeterReadings();
            f.Show();
            this.Close();
        }

        private void ButtonMeterType_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new MeterType();
            f.ShowDialog();
        }
    }
}
