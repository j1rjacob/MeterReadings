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
                Description = "Al Jeddah",
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
            ReturnInfo getMeterSize = _meterSize.GetMeterSizeById(new SmartDB(), "9086b56203164748a61c6c485b55fe78");
            bool flag = getMeterSize.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterSize_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterSize = _meterSize.GetMeterSizeByDescription(new SmartDB(), "Al Damman");
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
                Id = "6ca10b442a894258bd135cc9b0ddcb1e",
                Description = "Al Kharj",
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
            var deleteMeterSize = _meterSize.Delete(new SmartDB(), "6ca10b442a894258bd135cc9b0ddcb1e");
            bool flag = deleteMeterSize.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
