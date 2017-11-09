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
                MeterRAWCount = 6,
                MeterOMSCount = 9,
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
            ReturnInfo getGatewayLog = _gatewayLog.GetGatewayLogById(new SmartDB(), "510f6d72822b4b2dbca23a4e9f64d504");
            bool flag = getGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void GatewayLog_SearchByLogDateTime_True()
        {
            //Arrange
            //Act
            ReturnInfo getGatewayLog = _gatewayLog.GetGatewayLogByLogDateTime(new SmartDB(), "2017-11-09");
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
                Id = "329ae1c48fe347b384133fbfff5d54b8",
                LogDateTime = DateTime.Now,
                MeterRAWCount = 5,
                MeterOMSCount = 10,
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
            var deleteGatewayLog = _gatewayLog.Delete(new SmartDB(), "510f6d72822b4b2dbca23a4e9f64d504");
            bool flag = deleteGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
