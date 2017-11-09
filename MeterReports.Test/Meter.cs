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
                SerialNumber = "08BC8EB4",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
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
            ReturnInfo getMeter = _meter.GetMeterById(new SmartDB(), "9086b56203164748a61c6c485b55fe78");
            bool flag = getMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void Meter_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeter = _meter.GetMeterByDescription(new SmartDB(), "08BC8EB4");
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
                Id = "6ca10b442a894258bd135cc9b0ddcb1e",
                SerialNumber = "08BC8EB4",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
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
            var deleteMeter = _meter.Delete(new SmartDB(), "6ca10b442a894258bd135cc9b0ddcb1e");
            bool flag = deleteMeter.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
