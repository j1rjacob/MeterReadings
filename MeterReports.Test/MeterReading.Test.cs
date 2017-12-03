using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture()]
    public class MeterReading
    {
        private readonly TMF.Reports.BLL.MeterReading _meterReading;
        public MeterReading()
        {
            _meterReading = new TMF.Reports.BLL.MeterReading();
        }
        [Test]
        public void MeterReading_INS_True()
        {
            //Arrange
            TMF.Reports.Model.MeterReading meterReading = new TMF.Reports.Model.MeterReading()
            {
                Id = Guid.NewGuid().ToString("N"),
                SerialNumber = "0B85EE6C",
                ReadingDate = DateTime.Now,
                ReadingValue = "2A5C36571122368CCEA",
                LowBatteryAlr = 1,
                LeakAlr = 0,
                MagneticTamperAlr = 1,
                MeterErrorAlr = 1,
                BackFlowAlr = 0,
                BrokenPipeAlr = 0,
                EmptyPipeAlr = 0,
                SpecificErr = 0,
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var createMeterReading = _meterReading.Create(new SmartDB(), ref meterReading);
            bool flag = createMeterReading.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterReading_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterReading = _meterReading.GetMeterReadingById(new SmartDB(), "0e65b6d270c14b5c9c2f88915b22421f");
            bool flag = getMeterReading.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterReading_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterReading = _meterReading.GetMeterReadingBySerialNumber(new SmartDB(), "0B85EEEE");
            bool flag = getMeterReading.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterReading_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.MeterReading meterReading = new TMF.Reports.Model.MeterReading()
            {
                Id = "99ec376bd55f422085789bb89ee93664",
                SerialNumber = "0B85EEEE",
                ReadingDate = DateTime.Now,
                ReadingValue = "2A5C36571122368CCEA",
                LowBatteryAlr = 0,
                LeakAlr = 0,
                MagneticTamperAlr = 0,
                MeterErrorAlr = 0,
                BackFlowAlr = 0,
                BrokenPipeAlr = 0,
                EmptyPipeAlr = 0,
                SpecificErr = 0,
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var updateMeterReading = _meterReading.Update(new SmartDB(), meterReading);
            bool flag = updateMeterReading.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterReading_DEL_True()
        {
            //Arrange
            //Act
            var deleteMeterReading = _meterReading.Delete(new SmartDB(), "99ec376bd55f422085789bb89ee93664");
            bool flag = deleteMeterReading.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
