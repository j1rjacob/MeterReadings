using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture()]
    public class GatewayLog
    {
        private readonly TMF.Reports.BLL.GatewayLog _gatewayLog;
        public GatewayLog()
        {
            _gatewayLog = new TMF.Reports.BLL.GatewayLog();
        }
        [Test]
        public void GatewayLog_INS_True()
        {
            //Arrange
            TMF.Reports.Model.GatewayLog gatewayLog = new TMF.Reports.Model.GatewayLog()
            {
                Id = Guid.NewGuid().ToString("N"),
                LogDateTime = DateTime.Now,
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var createGatewayLog = _gatewayLog.Create(new SmartDB(), ref gatewayLog);
            bool flag = createGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void GatewayLog_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getGatewayLog = _gatewayLog.GetGatewayLogById(new SmartDB(), "9086b56203164748a61c6c485b55fe78");
            bool flag = getGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void GatewayLog_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getGatewayLog = _gatewayLog.GetGatewayLogByDescription(new SmartDB(), "Al Damman");
            bool flag = getGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void GatewayLog_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.GatewayLog gatewayLog = new TMF.Reports.Model.GatewayLog()
            {
                Id = "6ca10b442a894258bd135cc9b0ddcb1e",
                LogDateTime = DateTime.Now,
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var updateGatewayLog = _gatewayLog.Update(new SmartDB(), gatewayLog);
            bool flag = updateGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void GatewayLog_DEL_True()
        {
            //Arrange
            //Act
            var deleteGatewayLog = _gatewayLog.Delete(new SmartDB(), "6ca10b442a894258bd135cc9b0ddcb1e");
            bool flag = deleteGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
