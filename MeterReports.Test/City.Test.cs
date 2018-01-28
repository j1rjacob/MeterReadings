using NUnit.Framework;
using System;
using System.Linq;
using TMF.Core;
using TMF.Core.Model;
using TMF.DataAccess;
using TMF.Reports.UTIL;

namespace MeterReports.Test
{
    [TestFixture]
    public class City
    {
        private readonly TMF.Reports.BLL.City _city;
        private readonly TMF_Meter_ReadingsEntities _context;

        public City()
        {
            _city = new TMF.Reports.BLL.City();
            _context = new TMF_Meter_ReadingsEntities(GenUtil.EFConnectionString());
        }
        [Test]
        public void City_INS_True()
        {
            bool flag = false;

            try
            {
                using (_context)
                {
                    var city = new TMF.DataAccess.City()
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        Description = "MEDINAH",
                        TotalNumberOfMeters = 0,
                        Createdby = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                        DocDate = DateTime.Now,
                        Show = 1,
                        LockCount = 0
                    };

                    _context.Cities.Add(city);
                    _context.SaveChanges();
                    flag = true;
                }
            }
            catch (Exception)
            {
                flag = false;
            }

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
            int totCities = 0;
            using (_context)
            {
                var query = _context.Cities.ToList();
                totCities = query.Count;
            }
            Assert.AreEqual(5, totCities);
        }
    }
}
