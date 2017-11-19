using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NUnit.Framework;
using System.Collections.Generic;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture]
    public class User
    {
        private UserStore<IdentityUser> _userStore;
        private UserManager<IdentityUser> _userManager;
        private readonly TMF.Reports.BLL.User _user;

        public User()
        {
            _userStore = new UserStore<IdentityUser>();
            _userManager = new UserManager<IdentityUser>(_userStore);
            _user = new TMF.Reports.BLL.User();
        }
        [Test]
        public void Login_CheckUserCredential_True()
        {
            //Arrange //Act
            var user = TMF.Reports.BLL.User.CheckPassword("jacobj1r", "Pass123!word");

            //Assert
            Assert.IsTrue(user);
        }
        [Test]
        public void User_SaveUser_True()
        {
            //Arrange //Act
            var createUser = _userManager.Create(new IdentityUser("j1rjacob"), "Password123!");
            
            //Assert
            Assert.IsTrue(createUser.Succeeded);
        }
        [Test]
        public void User_UpdateUser_True()
        {
            //Arrange //Act
            var user = _userManager.FindByName("j1rjacob");

            user.UserName = "jacobj1r";
            user.PasswordHash = _userManager.PasswordHasher.HashPassword("Pass123!word");

            var flag = _userManager.Update(user);

            //Assert
            Assert.IsTrue(flag.Succeeded);
        }
        [Test]
        public void User_DeleteUser_True()
        {
            //Arrange 
            var user = _userManager.FindByName("jacobj1r");

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
