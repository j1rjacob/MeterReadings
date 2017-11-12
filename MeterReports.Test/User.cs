using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MeterReports.Test
{
    [TestFixture]
    public class User
    {
        [Test]
        public void Login_UserCredential_True()
        {
            //Arrange //Act
            var user = TMF.Reports.BLL.User.CheckPassword("junarjacob", "Password123!");
            
            //Assert
            Assert.IsTrue(user);
        }
    }
}
