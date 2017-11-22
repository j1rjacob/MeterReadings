using Microsoft.AspNet.Identity;
using System.Windows;
using TMF.Reports.BLL;
using TMF.Reports.Model;

namespace WpfMeterReport
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login 
    {
        private CustomUserStore _userStore;
        private UserManager<CustomUser, int> _userManager;
        public Login()
        {
            InitializeComponent();
            _userStore = new CustomUserStore(new CustomUserDbContext());
            _userManager = new UserManager<CustomUser, int>(_userStore);
        }

        private void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
        {
            var user = _userManager.FindByName(TextBoxUsername.Text);
            if (_userManager.CheckPassword(user, PasswordBoxUser.Password.Trim()))
            {
                var f = new MainWindow();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password not match.");
            }
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
