﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class City : Form
    {
        private readonly TMF.Reports.BLL.City _city;
        public City()
        {
            InitializeComponent();
            _city = new TMF.Reports.BLL.City();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            TMF.Reports.Model.City city = new TMF.Reports.Model.City()
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

            var createCity = _city.Create(new SmartDB(), ref city);  

            bool flag = createCity.Code == ErrorEnum.NoError;
            if (flag)
            {
                MessageBox.Show("City Created");
            }
            else
            {
                MessageBox.Show(createCity.Code.ToString());
            }
        }

        private void City_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            TMF.Reports.Model.City city = new TMF.Reports.Model.City()
            {
                Id = "c87725a3d5354801a7deedd157550f8e",
                Description = "Al Kharj",
                TotalNumberOfMeters = 50,
                CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                DocDate = DateTime.Now,
                Show = 1,
                LockCount = 0
            };

            var updateCity = _city.Update(new SmartDB(), city);

            bool flag = updateCity.Code == ErrorEnum.NoError;
            if (flag)
            {
                MessageBox.Show("City Updated");
            }
            else
            {
                MessageBox.Show(updateCity.Code.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var deleteCity = _city.Delete(new SmartDB(), "c87725a3d5354801a7deedd157550f8e");

            bool flag = deleteCity.Code == ErrorEnum.NoError;
            if (flag)
            {
                MessageBox.Show("City Deleted");
            }
            else
            {
                MessageBox.Show(deleteCity.Code.ToString());
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ReturnInfo getCityList = _city.GetCityList(new SmartDB()); 

            bool flag = getCityList.Code == ErrorEnum.NoError;

            foreach (var prop in getCityList.BizObject.GetType().GetProperties())
            {
                Debug.WriteLine("{0} = {1}", prop.Name, prop.GetValue(getCityList.BizObject, null));
            }

            //TMF.Reports.Model.City city = (TMF.Reports.Model.City)getCityList.BizObject;

            //Type cityType = typeof(City);

            //FieldInfo[] fields = cityType.GetFields(BindingFlags.Public
            //                                      | BindingFlags.Instance);

            //Console.WriteLine("Displaying the values of the fields of {0}:",
            //    cityType);
            //for (int i = 0; i < fields.Length; i++)
            //{
            //    Debug.WriteLine("   {0}:\t'{1}'",
            //        fields[i].Name, fields[i].GetValue(city));
            //}

            if (flag)
            {
                MessageBox.Show("City List");
            }
            else
            {
                MessageBox.Show(getCityList.Code.ToString());
            }
        }
    }
}
