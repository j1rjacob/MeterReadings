using System.Windows;

namespace WpfMeterReport
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User 
    {
        public User()
        {
            InitializeComponent();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new MainWindow();
            f.Show();
            this.Close();
        }
    }
}
