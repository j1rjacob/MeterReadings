using NUnit.Framework;
using System;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture]
    public class City
    {
        private readonly TMF.Reports.BLL.City _city;
        public City()
        {
            _city = new TMF.Reports.BLL.City();
        }
        [Test]
        public void City_INS_True()
        {
            //Arrange
            TMF.Reports.Model.City city = new TMF.Reports.Model.City()
            {
                Id = Guid.NewGuid().ToString("N"),
                Description = "Al Damman",
                TotalNumberOfMeters = 50,
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var createCity = _city.Create(new SmartDB(), ref city);
            bool flag = createCity.Code == ErrorEnum.NoError;
            
            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void City_SearchById_True()
        {
            //Arrange
            //Act
            ReturnInfo getCity = _city.GetCityById(new SmartDB(), "1a29dac39ece4856ad2c59880b1cacce");
            bool flag = getCity.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void City_SearchByDescription_True()
        {
            //Arrange
            //Act
            ReturnInfo getCity = _city.GetCityByDescription(new SmartDB(), "Al Damman");
            bool flag = getCity.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void City_UPD_True()
        {
            //Arrange
            TMF.Reports.Model.City city = new TMF.Reports.Model.City()
            {
                Id = "57b84d38ca424b109eaf7993e167babb",
                Description = "AL DAMMAM",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            //Act
            var updateCity = _city.Update(new SmartDB(), city);
            bool flag = updateCity.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void City_DEL_True()
        {
            //Arrange
            //Act
            var deleteCity = _city.Delete(new SmartDB(), "6ca10b442a894258bd135cc9b0ddcb1e");
            bool flag = deleteCity.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        public void City_LST_Equal()
        {
            //Arrange
            //Act
            ReturnInfo city = _city.GetCityList(new SmartDB());
            bool flag = city.Code == ErrorEnum.NoError;

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
