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
                RDS = 1,
                OMS = 0,
                GatewayMacAddress = "1CBA8C98F4CB",
                CSVFilename = "GTW_RDS_20170725_003000.csv",
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
            ReturnInfo getGatewayLog = _gatewayLog.GetGatewayLogById(new SmartDB(), "2DC56AF9-D0D4-E711-9C17-645A043F454D");
            bool flag = getGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void GatewayLog_SearchByMacCsv_True()
        {
            //Arrange
            //Act
            ReturnInfo getGatewayLog = _gatewayLog.GetRecordsByMacCsv(new SmartDB(), "1CBA8C98F4CB", "GTW_RDS_20170725_003000.csv");
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
                Id = "2DC56AF9-D0D4-E711-9C17-645A043F454D",
                RDS = 0,
                OMS = 0,
                GatewayMacAddress = "1CBA8C98F4CB",
                CSVFilename = "GTW_RDS_20170725_003000.csv",
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
            var deleteGatewayLog = _gatewayLog.Delete(new SmartDB(), "2DC56AF9-D0D4-E711-9C17-645A043F454D");
            bool flag = deleteGatewayLog.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
