using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture()]
    public class MeterSize
    {
        private readonly TMF.Reports.BLL.MeterSize _meterSize;
        public MeterSize()
        {
            _meterSize = new TMF.Reports.BLL.MeterSize();
        }
        [Test]
        public void MeterSize_INS_True()
        {
            //Arrange
            TMF.Reports.Model.MeterSize meterSize = new TMF.Reports.Model.MeterSize()
            {
                Id = Guid.NewGuid().ToString("N"),
                Description = "20 inches",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var createMeterSize = _meterSize.Create(new SmartDB(), ref meterSize);
            bool flag = createMeterSize.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterSize_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterSize = _meterSize.GetMeterSizeById(new SmartDB(), "5942a09dd01e4fc0ba63af02354c4094");
            bool flag = getMeterSize.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterSize_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterSize = _meterSize.GetMeterSizeByDescription(new SmartDB(), "10 inches");
            bool flag = getMeterSize.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterSize_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.MeterSize meterSize = new TMF.Reports.Model.MeterSize()
            {
                Id = "e8d97e5e87314e3c8b59e639cce2e546",
                Description = "20 inches",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var updateMeterSize = _meterSize.Update(new SmartDB(), meterSize);
            bool flag = updateMeterSize.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterSize_DEL_True()
        {
            //Arrange
            //Act
            var deleteMeterSize = _meterSize.Delete(new SmartDB(), "e8d97e5e87314e3c8b59e639cce2e546");
            bool flag = deleteMeterSize.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
