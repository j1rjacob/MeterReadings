using System;
using System.Windows.Forms;
using TMF.Core;

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
            var id = Guid.NewGuid().ToString("N");
            TMF.Reports.Model.City city = new TMF.Reports.Model.City()
            {
                Id = id,
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
    }
}
