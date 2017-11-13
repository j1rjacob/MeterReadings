using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class Citi : Form
    {
        private readonly TMF.Reports.BLL.City _city;
        private bool _save;
        public Citi()
        {
            InitializeComponent();
            _city = new TMF.Reports.BLL.City();
            _save = true;
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            _save = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
            {
                SaveCity();
            }
            else
            {
                EditCity();
            }
        }
        private void SaveCity()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                TMF.Reports.Model.City city = new TMF.Reports.Model.City()
                {   //TODO User id for CreatedBy
                    Id = Guid.NewGuid().ToString("N"),
                    Description = TextBoxDescription.Text,
                    TotalNumberOfMeters = 0,
                    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = 0
                };

                var createCity = _city.Create(new SmartDB(), ref city);

                bool flag = createCity.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("City Created");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show(createCity.Code.ToString());
                }
            }
            else
            {
                MessageBox.Show("No city to save.");
            }
        }
        private void EditCity()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   //Todo City Id and EditedBy
                var lockcount = GetLockCount("0b556630167441a5ae971049e66e4d89");

                TMF.Reports.Model.City city = new TMF.Reports.Model.City()
                {
                    Id = "0b556630167441a5ae971049e66e4d89",
                    Description = "Al Dammam",
                    EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = lockcount
                };

                var updateCity = _city.Update(new SmartDB(), city);

                bool flag = updateCity.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("City Updated");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show(updateCity.Message);
                }
            }
            else
            {
                MessageBox.Show("No city to edit.");
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   //TODO City Id
                var deleteCity = _city.Delete(new SmartDB(), "5d7ec79f53ac4fff9df8d71eca290da8");

                bool flag = deleteCity.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("City Deleted");
                }
                else
                {
                    MessageBox.Show(deleteCity.Message);
                }
            }
            else
            {
                MessageBox.Show("No city to delete.");
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }
        private void ResetControls()
        {
            TextBoxDescription.Enabled = false;
            TextBoxDescription.Text = "";
            TextBoxTotalMeters.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                ResetControls();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private int GetLockCount(string Id)
        {
            IInfo info = _city.GetCityById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.City).LockCount;
            return lockcount;
        }
        private void BindCityWithDataGrid()
        {
            ReturnInfo getCityList = _city.GetCityList(new SmartDB());
            bool flag = getCityList.Code == ErrorEnum.NoError;
            List<TMF.Reports.Model.City> city = (List<TMF.Reports.Model.City>)getCityList.BizObject;
            var bindingList = new BindingList<TMF.Reports.Model.City>(city);
            var source = new BindingSource(bindingList, null);
            DataGridViewCity.AutoGenerateColumns = false;
            DataGridViewCity.DataSource = source;
        }
        private void Citi_Load(object sender, EventArgs e)
        {
            TextBoxDescription.Text = "Al Jeddah";

            BindCityWithDataGrid();
        }


    }
}
