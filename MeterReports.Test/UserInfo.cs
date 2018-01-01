using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;

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
                Id = 6,
                UserId = "1",
                Password = "qwerty123!",
                Name = "Junar A. Jacob",
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

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
