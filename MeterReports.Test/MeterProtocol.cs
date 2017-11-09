using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture()]
    public class MeterProtocol
    {
        private readonly TMF.Reports.BLL.MeterProtocol _meterProtocol;
        public MeterProtocol()
        {
            _meterProtocol = new TMF.Reports.BLL.MeterProtocol();
        }
        [Test]
        public void MeterProtocol_INS_True()
        {
            //Arrange
            TMF.Reports.Model.MeterProtocol meterProtocol = new TMF.Reports.Model.MeterProtocol()
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
            var createMeterProtocol = _meterProtocol.Create(new SmartDB(), ref meterProtocol);
            bool flag = createMeterProtocol.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterProtocol_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterProtocol = _meterProtocol.GetMeterProtocolById(new SmartDB(), "9086b56203164748a61c6c485b55fe78");
            bool flag = getMeterProtocol.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterProtocol_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getMeterProtocol = _meterProtocol.GetMeterProtocolByDescription(new SmartDB(), "Al Damman");
            bool flag = getMeterProtocol.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterProtocol_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.MeterProtocol meterProtocol = new TMF.Reports.Model.MeterProtocol()
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
            var updateMeterProtocol = _meterProtocol.Update(new SmartDB(), meterProtocol);
            bool flag = updateMeterProtocol.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void MeterProtocol_DEL_True()
        {
            //Arrange
            //Act
            var deleteMeterProtocol = _meterProtocol.Delete(new SmartDB(), "6ca10b442a894258bd135cc9b0ddcb1e");
            bool flag = deleteMeterProtocol.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
