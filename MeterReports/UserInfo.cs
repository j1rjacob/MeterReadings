using System;
using System.Windows.Forms;
using TMF.Core;

namespace MeterReports
{
    public partial class UserInfo : Form
    {
        private readonly TMF.Core.UserInfoBLL _userInfo;
        public UserInfo()
        {
            InitializeComponent();
            _userInfo = new UserInfoBLL();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            TMF.Core.Model.UserInfo user = new TMF.Core.Model.UserInfo()
            {
                Id = Guid.NewGuid().ToString("N"),
                UserId = "123457",
                Password = "qwerty123!",
                Name = "Junar A. Pakuna",
                Email = "junarjacob@yahoo.com",
                RoleId = "1",
                IsDelete = false,
                IsLock = true,
                CreatedBy = "1",
                DateCreated = DateTime.Now,
                EditedBy = "1",
                DateEdited = DateTime.Now,
                LockCount = 1,
                Remark = "none",
                IsLogin = false,
                IsActive = true
            };

            //Act
            var createUser = _userInfo.Create(new SmartDB(), ref user);
            bool flag = createUser.Code == ErrorEnum.NoError;

            MessageBox.Show(flag.ToString());
        }
    }
}
