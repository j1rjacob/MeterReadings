using Microsoft.AspNet.Identity;
using NUnit.Framework;
using System.Collections.Generic;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.BLL;
using TMF.Reports.Model;

namespace MeterReports.Test
{
    [TestFixture]
    public class User
    {
        private CustomUserStore _userStore;
        private UserManager<CustomUser, int> _userManager;
        private readonly TMF.Reports.BLL.User _user;

        public User()
        {
            _userStore = new CustomUserStore(new CustomUserDbContext());
            _userManager = new UserManager<CustomUser, int>(_userStore);
            _user = new TMF.Reports.BLL.User();
        }
        [Test]
        public void Login_CheckUserCredential_True()
        {
            //Arrange 
            var user = _userManager.FindByName("j1rjacob");
            //Act
            var checkuser = _userManager.CheckPassword(user, "Pass123!word");

            //Assert
            Assert.IsTrue(checkuser);
        }
        [Test]
        public void User_SaveUser_True()
        {
            //Arrange 
            CustomUser user = new CustomUser
            {
                FullName = "Jacob Junar",
                UserName = "j1rjacob1",
                Role ="Administrator"
            };
            
            //Act
            var createUser = _userManager.Create(user, "Password123!");
            
            //Assert
            Assert.IsTrue(createUser.Succeeded);
        }
        [Test]
        public void User_UpdateUser_True()
        {
            //Arrange //Act
            CustomUser user = _userManager.FindByName("j1rjacob1");

            user.UserName = "j1rjacob";
            user.PasswordHash = _userManager.PasswordHasher.HashPassword("Pass123!word");
            user.FullName = "Junar Jacob";
            user.Role = "Administrator";

            var flag = _userManager.Update(user);

            //Assert
            Assert.IsTrue(flag.Succeeded);
        }
        [Test]
        public void User_DeleteUser_True()
        {
            //Arrange 
            var user = _userManager.FindByName("j1rjacob1");

            //Act
            var flag = _userManager.Delete(user);

            //Assert
            Assert.IsTrue(flag.Succeeded);
        }
        [Test]
        public void User_GetUserByUserName_ListUserCount()
        {
            //Arrange 
            ReturnInfo getUserList = _user.GetUserByUserName(new SmartDB(), "");
            
            //Act
            List<TMF.Reports.Model.User> user = (List<TMF.Reports.Model.User>)getUserList.BizObject;

            //Assert
            Assert.AreEqual(user.Count,6);
        }
    }
}
