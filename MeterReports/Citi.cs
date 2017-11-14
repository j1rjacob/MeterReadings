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
        private string _cityId;
        public Citi()
        {
            InitializeComponent();
            _city = new TMF.Reports.BLL.City();
            _save = true;
            _cityId = "";
        }
        private void Citi_Load(object sender, EventArgs e)
        {
            BindCityWithDataGrid();
            ResetControls();
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxDescription.Text = "";
            TextBoxTotalMeters.Text = "";
            _cityId = "";
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            _save = false;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
                SaveCity();
            else
                EditCity();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                var deleteCity = _city.Delete(new SmartDB(), _cityId);

                bool flag = deleteCity.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("City Deleted");
                    ResetControls();
                    BindCityWithDataGrid();
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
            BindCityWithDataGrid();
        }
        private void DataGridViewCity_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewCity.CurrentRow.Index + 1} index of {DataGridViewCity.RowCount} records";

            var cityId = DataGridViewCity.CurrentRow.Cells[0].Value.ToString();
            ReturnInfo getCity = _city.GetCityById(new SmartDB(), cityId);

            bool flag = getCity.Code == ErrorEnum.NoError;

            TMF.Reports.Model.City city = (TMF.Reports.Model.City)getCity.BizObject;
            if (!string.IsNullOrEmpty(city.Id))
            {
                TextBoxDescription.Text = city.Description;
                TextBoxTotalMeters.Text = city.TotalNumberOfMeters.ToString();
                _cityId = city.Id;
                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;
            }
        }
        #region PriveteMethod
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
                    BindCityWithDataGrid();
                }
                else
                {
                    MessageBox.Show(createCity.Code.ToString());
                }
            }
            else
                MessageBox.Show("No city to save.");
        }
        private void EditCity()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   //Todo EditedBy
                var lockcount = GetLockCount(_cityId);

                TMF.Reports.Model.City city = new TMF.Reports.Model.City()
                {
                    Id = _cityId,
                    Description = TextBoxDescription.Text,
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
                    BindCityWithDataGrid();
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
        private void ResetControls()
        {
            TextBoxDescription.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxDescription.Text = "";
            TextBoxTotalMeters.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindCityWithDataGrid();
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
        {   //TODO: Refactor this for reuse.
            ReturnInfo getCityList = _city.GetCityByDescription(new SmartDB(), TextBoxSearch.Text);
            //bool flag = getCityList.Code == ErrorEnum.NoError;
            List<TMF.Reports.Model.City> city = (List<TMF.Reports.Model.City>)getCityList.BizObject;
            var bindingList = new BindingList<TMF.Reports.Model.City>(city);
            var source = new BindingSource(bindingList, null);
            DataGridViewCity.AutoGenerateColumns = false;
            DataGridViewCity.DataSource = source;
            LabelShow.Text = $"Showing {DataGridViewCity.CurrentRow.Index + 1} index of {DataGridViewCity.RowCount} records";
        }
        #endregion
    }
}
