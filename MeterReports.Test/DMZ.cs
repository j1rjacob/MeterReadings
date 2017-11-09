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
        [Test]
        public void DMZ_INS_True()
        {
            //Arrange
            TMF.Reports.Model.DMZ dmz = new TMF.Reports.Model.DMZ()
            {
                Id = Guid.NewGuid().ToString("N"),
                Description = "DMZ2",
                TotalNumberOfMeters = 25,
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
        public void DMZ_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getDMZ = _dmz.GetDMZById(new SmartDB(), "329ae1c48fe347b384133fbfff5d54b8");
            bool flag = getDMZ.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void DMZ_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getDMZ = _dmz.GetDMZByDescription(new SmartDB(), "DMZ2");
            bool flag = getDMZ.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }

        [Test]
        public void DMZ_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.DMZ dmz = new TMF.Reports.Model.DMZ()
            {
                Id = "0d5be89393f447b393445d1d21509442",
                Description = "DMZ0",
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
        public void DMZ_DEL_True()
        {
            //Arrange
            //Act
            var deleteDMZ = _dmz.Delete(new SmartDB(), "0d5be89393f447b393445d1d21509442");
            bool flag = deleteDMZ.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
