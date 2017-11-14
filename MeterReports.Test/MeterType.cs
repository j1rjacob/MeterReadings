using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture()]
    public class MeterType
    {
        private readonly TMF.Reports.BLL.MeterType _meterType;
        public MeterType()
        {
            _meterType = new TMF.Reports.BLL.MeterType();
        }
        [Test]
        public void MeterType_INS_True()
        {
            //Arrange
            TMF.Reports.Model.MeterType meterType = new TMF.Reports.Model.MeterType()
            {
                Description = "B+",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var createMeterType = _meterType.Create(new SmartDB(), ref meterType);
            bool flag = createMeterType.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterType_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterType = _meterType.GetMeterTypeById(new SmartDB(), 1);
            bool flag = getMeterType.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterType_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterType = _meterType.GetMeterTypeDescription(new SmartDB(), "A+");
            bool flag = getMeterType.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterType_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.MeterType meterType = new TMF.Reports.Model.MeterType()
            {
                Id = 1,
                Description = "B-",
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var updateMeterType = _meterType.Update(new SmartDB(), meterType);
            bool flag = updateMeterType.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterType_DEL_True()
        {
            //Arrange
            //Act
            var deleteMeterType = _meterType.Delete(new SmartDB(), 1);
            bool flag = deleteMeterType.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
