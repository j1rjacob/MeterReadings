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
                Id = Guid.NewGuid().ToString("N"),
                SerialNumber = "08BC8EC4",
                X = 5.6545218m,
                Y = 25.25455511m,
                Status = "Active",
                HCN = "HCN2",
                InstallationDate = DateTime.Now,
                MaintenanceDate = DateTime.Now,
                MeterTypeId = 1,
                MeterSizeId = 1,
                MeterProtocolId = 1,
                DMZId = 1,
                CityId = "57b84d38ca424b109eaf7993e167babb",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
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
            ReturnInfo getMeter = _meter.GetMeterById(new SmartDB(), "2fc271c287f14c0bae083aad1b4cc3c2");
            bool flag = getMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Meter_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeter = _meter.GetMeterByDescription(new SmartDB(), "08BC8EF4");
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
                Id = "e730b81865494ca78389dd7765286e07",
                SerialNumber = "08BC8EF4",
                X = 6.6545218m,
                Y = 21.25455511m,
                Status = "Active",
                HCN = "HCN",
                InstallationDate = DateTime.Now,
                MaintenanceDate = DateTime.Now,
                MeterTypeId = 1,
                MeterSizeId = 2,
                MeterProtocolId = 1,
                DMZId = 1,
                CityId = "57b84d38ca424b109eaf7993e167babb",
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
            var deleteMeter = _meter.Delete(new SmartDB(), "2fc271c287f14c0bae083aad1b4cc3c2");
            bool flag = deleteMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
