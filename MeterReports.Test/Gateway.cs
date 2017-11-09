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
                Description = "Al Jeddah",
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
            ReturnInfo getGateway= _gateway.GetGatewayById(new SmartDB(), "9086b56203164748a61c6c485b55fe78");
            bool flag = getGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Gateway_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getGateway = _gateway.GetGatewayByDescription(new SmartDB(), "Al Damman");
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
                Id = "6ca10b442a894258bd135cc9b0ddcb1e",
                Description = "Al Kharj",
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
            var deleteGateway = _gateway.Delete(new SmartDB(), "6ca10b442a894258bd135cc9b0ddcb1e");
            bool flag = deleteGateway.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
