using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class UserInfo : Form
    {
        private readonly TMF.Core.UserInfoBLL _userInfo;
        private SHA1CryptoServiceProvider _sha1;  
        public UserInfo()
        {
            InitializeComponent();
            _userInfo = new UserInfoBLL();
            _sha1 = new SHA1CryptoServiceProvider();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            TMF.Core.Model.UserInfo user = new TMF.Core.Model.UserInfo()
            {
                Id = Guid.NewGuid().ToString("N"),
                Username = "j1rjacob",
                Password = "qwerty123",
                Name = "Junar A. Pakuna",
                Role = (int)UserLevel.Administrator, 
                IsActive = true
            };
            
            var createUser = _userInfo.Create(new SmartDB(), ref user);
            bool flag = createUser.Code == ErrorEnum.NoError;

            MessageBox.Show(flag.ToString());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            TMF.Core.Model.UserInfo user = new TMF.Core.Model.UserInfo()
            {
                Id = "5f43cb949fe94af8aae1e277492cea1b",
                Username = "nobolos",
                Password = "qwerty123",
                Name = "Junar A. Pakuna",
                Role = (int)UserLevel.Administrator,
                IsActive = true
            };

            //Act
            var createUser = _userInfo.Update(new SmartDB(), user);
            bool flag = createUser.Code == ErrorEnum.NoError;

            MessageBox.Show(flag.ToString());
        }
    }
}
