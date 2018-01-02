using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture()]
    public class UserInfo
    {
        private readonly TMF.Core.UserInfoBLL _userInfo;
        
        public UserInfo()
        {
            _userInfo = new UserInfoBLL();
        }
        [Test]
        public void REPORT_USERINFO_INS_RETURN_TRUE()
        {
            //Arrange
            TMF.Core.Model.UserInfo user = new TMF.Core.Model.UserInfo()
            {
                Id = Guid.NewGuid().ToString("N"),
                Username = "j1rjacob",
                Password = "qwerty123",
                Name = "Junar A. Jacob",
                Role = (int)UserLevel.Administrator,
                IsActive = true
            };

            //Act
            var createUser = _userInfo.Create(new SmartDB(), ref user);
            bool flag = createUser.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }

        [Test]
        public void REPORT_USERINFO_UPD_RETURN_TRUE()
        {
            //Arrange
            TMF.Core.Model.UserInfo user1 = new TMF.Core.Model.UserInfo()
            {
                Id = "5f43cb949fe94af8aae1e277492cea1b",
                Username = "j1rjacob",
                Password = "qwerty123",
                Name = "Junar Jacob",
                Role = (int)UserLevel.Administrator,
                IsActive = true
            };

            //Act
            var updateUser = _userInfo.Update(new SmartDB(), user1);
            bool flag = updateUser.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }

        [Test]
        public void REPORT_USERINFO_DEL_RETURN_TRUE()
        {
            //Act
            var updateUser = _userInfo.Delete(new SmartDB(), "5f43cb949fe94af8aae1e277492cea1b");
            bool flag = updateUser.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void REPORT_USERINFO_DEL_RETURN_LST_Equal()
        {
            //Act
            var getUserList = _userInfo.GetUserList(new SmartDB());
            bool flag = getUserList.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void REPORT_USERINFO_USERNAMEPWD_EQUAL()
        {
            //Act
            var getUserList = _userInfo.GetUserByUsernamePassword(new SmartDB(), "j1rjacob", "qwerty123");
            bool flag = getUserList.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void REPORT_USERINFO_NAME_EQUAL()
        {
            //Act
            var getUserList = _userInfo.GetUserByName(new SmartDB(), "Junar A. Jacob");
            bool flag = getUserList.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
