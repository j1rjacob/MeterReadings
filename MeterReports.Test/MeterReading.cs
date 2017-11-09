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
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
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
            ReturnInfo getMeterReading = _meterReading.GetMeterReadingById(new SmartDB(), "9086b56203164748a61c6c485b55fe78");
            bool flag = getMeterReading.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterReading_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterReading = _meterReading.GetMeterReadingByDescription(new SmartDB(), "0B85EE6B");
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
                Id = "6ca10b442a894258bd135cc9b0ddcb1e",
                SerialNumber = "0B85EE6B",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
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
            var deleteMeterReading = _meterReading.Delete(new SmartDB(), "6ca10b442a894258bd135cc9b0ddcb1e");
            bool flag = deleteMeterReading.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
