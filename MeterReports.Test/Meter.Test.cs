using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture()]
    public class Meter
    {
        private readonly TMF.Reports.BLL.Meter _meter;
        public Meter()
        {
            _meter = new TMF.Reports.BLL.Meter();
        }
        [Test]
        public void Meter_INS_True()
        {
            //Arrange
            TMF.Reports.Model.Meter meter = new TMF.Reports.Model.Meter()
            {
                SerialNumber = "10110148216",
                X = 0,
                Y = 0,
                Status = "Active",
                HCN = null,
                InstallationDate = DateTime.Now,
                MaintenanceDate = DateTime.Now,
                MeterTypeId = null,
                MeterSizeId = null,
                MeterProtocolId = null,
                DMZId = null,
                CityId = null,
                CreatedBy = "1",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var createMeter = _meter.Create(new SmartDB(), ref meter);
            bool flag = createMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Meter_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeter = _meter.GetMeterById(new SmartDB(), "10110111913");
            bool flag = getMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Meter_SearchBySerialNumber_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeter = _meter.GetMeterBySerialNumber(new SmartDB(), "10110148216");
            bool flag = getMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Meter_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.Meter meter = new TMF.Reports.Model.Meter()
            {
                SerialNumber = "10110148216",
                X = 6.6545218m,
                Y = 21.25455511m,
                Status = "Active",
                HCN = "HCN",
                InstallationDate = DateTime.Now,
                MaintenanceDate = DateTime.Now,
                MeterTypeId = "O+",
                MeterSizeId = "10m",
                MeterProtocolId = "PROTOCOL B",
                DMZId = "DMZ0",
                CityId = "AL DAMMAM",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var updateMeter = _meter.Update(new SmartDB(), meter);
            bool flag = updateMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Meter_DEL_True()
        {
            //Arrange
            //Act
            var deleteMeter = _meter.Delete(new SmartDB(), "e730b81865494ca78389dd7765286e08");
            bool flag = deleteMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
