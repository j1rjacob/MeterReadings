using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture()]
    public class Gateway
    {
        private readonly TMF.Reports.BLL.Gateway _gateway;
        public Gateway()
        {
            _gateway = new TMF.Reports.BLL.Gateway();
        }
        [Test]
        public void Gateway_INS_True()
        {
            //Arrange
            TMF.Reports.Model.Gateway gateway = new TMF.Reports.Model.Gateway()
            {
                MacAddress = "12:AF:18:32:34:C5",
                SimCard = null,
                X = 0,
                Y = 0,
                Description = null,
                InstallationDate = DateTime.Parse("06/20/1986"),
                MaintenanceDate = DateTime.Parse("06/20/1986"),
                Status = "Active",
                IPAddress = "192.0.0.1",
                DMZId = null,
                CityId = null,
                CreatedBy = "1",
                EditedBy = "1",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var createGateway = _gateway.Create(new SmartDB(), ref gateway);
            bool flag = createGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Gateway_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getGateway= _gateway.GetGatewayById(new SmartDB(), "e5bd9db0c995482a9ca73c27949b2c64");
            bool flag = getGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Gateway_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getGateway = _gateway.GetGatewayBySimCard(new SmartDB(), "09448833481");
            bool flag = getGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Gateway_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.Gateway gateway = new TMF.Reports.Model.Gateway()
            {
                Id = "e5bd9db0c995482a9ca73c27949b2c64",
                MacAddress = "12:AF:18:32:34:B5",
                SimCard = "09448833481",
                X = 5.56484m,
                Y = 12.56484m,
                Description = "SENSUS",
                InstallationDate = DateTime.Parse("06/21/1987"),
                MaintenanceDate = DateTime.Parse("06/20/1986"),
                Status = "Active",
                IPAddress = "192.168.58.7",
                DMZId = "DMZ1",
                CityId = "Al Riyadh",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var updateGateway = _gateway.Update(new SmartDB(), gateway);
            bool flag = updateGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Gateway_DEL_True()
        {
            //Arrange
            //Act
            var deleteGateway = _gateway.Delete(new SmartDB(), "e5bd9db0c995482a9ca73c27949b2c64");
            bool flag = deleteGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
