using NUnit.Framework;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture]
    public class DMZ
    {
        private readonly TMF.Reports.BLL.DMZ _dmz;
        public DMZ()
        {
            _dmz = new TMF.Reports.BLL.DMZ();
        }
        public void DMZ_INS_True()
        {
            //Arrange
            TMF.Reports.Model.DMZ dmz = new TMF.Reports.Model.DMZ()
            {
                Id = Guid.NewGuid().ToString("N"),
                Description = "Al Jeddah",
                TotalNumberOfMeters = 50,
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var createDMZ = _dmz.Create(new SmartDB(), ref dmz);
            bool flag = createDMZ.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void City_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getDMZ = _dmz.GetDMZById(new SmartDB(), "9086b56203164748a61c6c485b55fe78");
            bool flag = getDMZ.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void City_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getDMZ = _dmz.GetDMZByDescription(new SmartDB(), "Al Damman");
            bool flag = getDMZ.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }

        [Test]
        public void City_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.DMZ dmz = new TMF.Reports.Model.DMZ()
            {
                Id = "6ca10b442a894258bd135cc9b0ddcb1e",
                Description = "Al Kharj",
                TotalNumberOfMeters = 50,
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var updateDMZ = _dmz.Update(new SmartDB(), dmz);
            bool flag = updateDMZ.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }

        [Test]
        public void City_DEL_True()
        {
            //Arrange
            //Act
            var deleteDMZ = _dmz.Delete(new SmartDB(), "6ca10b442a894258bd135cc9b0ddcb1e");
            bool flag = deleteDMZ.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
