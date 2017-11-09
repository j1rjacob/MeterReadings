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
                Id = Guid.NewGuid().ToString("N"),
                MacAddress = "12:AF:18:32:34:B5",
                SimCard = "09448833481",
                X = 5.56484m,
                Y = 12.56484m,
                Description = "SENSUS",
                InstallationDate = DateTime.Parse("06/21/1987"),
                MaintenanceDate = DateTime.Parse("06/20/1986"),
                Status = "Active",
                IPAddress = "192.0.0.1",
                DMZId = "329ae1c48fe347b384133fbfff5d54b8",
                CityId = "9086b56203164748a61c6c485b55fe78",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
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
            ReturnInfo getGateway= _gateway.GetGatewayById(new SmartDB(), "fbd36e6c99324984b1e6aeb8d3ac47f4");
            bool flag = getGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Gateway_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getGateway = _gateway.GetGatewayByDescription(new SmartDB(), "SENSUS");
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
                Id = "fbd36e6c99324984b1e6aeb8d3ac47f4",
                MacAddress = "12:AF:18:32:34:B5",
                SimCard = "09448833481",
                X = 5.56484m,
                Y = 12.56484m,
                Description = "SENSUS",
                InstallationDate = DateTime.Parse("06/21/1987"),
                MaintenanceDate = DateTime.Parse("06/20/1986"),
                Status = "Active",
                IPAddress = "192.168.58.7",
                DMZId = "329ae1c48fe347b384133fbfff5d54b8",
                CityId = "9086b56203164748a61c6c485b55fe78",
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
            var deleteGateway = _gateway.Delete(new SmartDB(), "98b19abe0fa045e4bd020f91ba44196b");
            bool flag = deleteGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
