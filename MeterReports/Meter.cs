using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class Meter : Form
    {
        private readonly TMF.Reports.BLL.Meter _meter;
        private readonly TMF.Reports.BLL.MeterType _meterType;
        private readonly TMF.Reports.BLL.MeterSize _meterSize;
        private readonly TMF.Reports.BLL.MeterProtocol _meterProtocol;
        private readonly TMF.Reports.BLL.DMZ _dmz;
        private readonly TMF.Reports.BLL.City _city;
        private bool _save;
        private string _meterId;
        public Meter()
        {
            InitializeComponent();
            _meter = new TMF.Reports.BLL.Meter();
            _meterType = new TMF.Reports.BLL.MeterType();
            _meterSize = new TMF.Reports.BLL.MeterSize();
            _meterProtocol = new TMF.Reports.BLL.MeterProtocol();
            _dmz = new TMF.Reports.BLL.DMZ();
            _city = new TMF.Reports.BLL.City();

            _save = true;
            _meterId = "";
        }
        private void Meter_Load(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxSerialNumber.Enabled = true;
            TextBoxX.Enabled = true;
            TextBoxY.Enabled = true;
            ComboBoxStatus.Enabled = true;
            TextBoxHCN.Enabled = true;
            DateTimePickerInstallationDate.Enabled = true;
            DateTimePickerMaintenanceDate.Enabled = true;
            ComboBoxMeterType.Enabled = true;
            ComboBoxMeterSize.Enabled = true;
            ComboBoxMeterProtocol.Enabled = true;
            ComboBoxDMZ.Enabled = true;
            ComboBoxCity.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxSerialNumber.Text = "";
            TextBoxX.Text = "";
            TextBoxY.Text = "";
            ComboBoxStatus.Text = "";
            TextBoxHCN.Text = "";
            DateTimePickerInstallationDate.Text = "";
            DateTimePickerMaintenanceDate.Text = "";
            ComboBoxMeterType.Items.Clear();
            ComboBoxMeterSize.Items.Clear();
            ComboBoxMeterProtocol.Items.Clear();
            ComboBoxDMZ.Items.Clear();
            ComboBoxCity.Items.Clear();
            _meterId = "";
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxSerialNumber.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = true;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            _save = false;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
                SaveMeter();
            else
                EditMeter();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxSerialNumber.Text))
            {
                var deleteMeter = _meter.Delete(new SmartDB(), _meterId);

                bool flag = deleteMeter.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Deleted");
                    ResetControls();
                    BindMeterWithDataGrid();
                }
                else
                {
                    MessageBox.Show(deleteMeter.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter to delete.");
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindMeterWithDataGrid();
        }
        private void DataGridViewMeter_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewMeter.CurrentRow.Index + 1} index of {DataGridViewMeter.RowCount} records";

            var meterId = DataGridViewMeter.CurrentRow.Cells[0].Value.ToString();
            ReturnInfo getMeter = _meter.GetMeterById(new SmartDB(), meterId);

            bool flag = getMeter.Code == ErrorEnum.NoError;
            try
            {
                TMF.Reports.Model.Meter meter = (TMF.Reports.Model.Meter)getMeter.BizObject;

                ReturnInfo getMeterType = _meterType.GetMeterTypeById(new SmartDB(), meter.MeterTypeId);
                TMF.Reports.Model.MeterType meterType = (TMF.Reports.Model.MeterType)getMeterType.BizObject;
                ReturnInfo getMeterSize = _meterSize.GetMeterSizeById(new SmartDB(), meter.MeterTypeId);
                TMF.Reports.Model.MeterSize meterSize = (TMF.Reports.Model.MeterSize)getMeterSize.BizObject;
                ReturnInfo getMeterProtocol = _meterProtocol.GetMeterProtocolById(new SmartDB(), meter.MeterProtocolId);
                TMF.Reports.Model.MeterProtocol meterProtocol = (TMF.Reports.Model.MeterProtocol)getMeterProtocol.BizObject;
                ReturnInfo getDMZ = _dmz.GetDMZById(new SmartDB(), meter.DMZId);
                TMF.Reports.Model.DMZ dmz = (TMF.Reports.Model.DMZ)getDMZ.BizObject;
                ReturnInfo getCity = _city.GetCityById(new SmartDB(), meter.CityId);
                TMF.Reports.Model.City city = (TMF.Reports.Model.City)getCity.BizObject;
                  
                if (!string.IsNullOrEmpty(meter.Id))
                {
                    _meterId = meter.Id;
                    TextBoxSerialNumber.Text = meter.SerialNumber;
                    TextBoxX.Text = meter.X.ToString();
                    TextBoxY.Text = meter.Y.ToString();
                    ComboBoxStatus.Text = meter.Status;
                    TextBoxHCN.Text = meter.HCN;
                    DateTimePickerInstallationDate.Text = meter.InstallationDate.ToString();
                    DateTimePickerMaintenanceDate.Text = meter.MaintenanceDate.ToString();
                    ComboBoxMeterType.Text = meterType.Description;
                    ComboBoxMeterSize.Text = meterSize.Description;
                    ComboBoxMeterProtocol.Text = meterProtocol.Description;
                    ComboBoxDMZ.Text = dmz.Description;
                    ComboBoxCity.Text = city.Description;

                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;
    }
            }
            catch (Exception ex)
            {
                return;
            }
            
        }
        private void ComboBoxMeterType_MouseClick(object sender, MouseEventArgs e)
        {
            GetMeterType();
        }
        private void ComboBoxMeterSize_MouseClick(object sender, MouseEventArgs e)
        {
            GetMeterSize();
        }
        private void ComboBoxMeterProtocol_MouseClick(object sender, MouseEventArgs e)
        {
            GetMeterProtocol();
        }
        private void ComboBoxDMZ_MouseClick(object sender, MouseEventArgs e)
        {
            GetDMZ();
        }
        private void ComboBoxCity_MouseClick(object sender, MouseEventArgs e)
        {
            GetCities();
        }
        #region PriveteMethod
        private void SaveMeter()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxSerialNumber.Text))
            {
                TMF.Reports.Model.Meter meter = new TMF.Reports.Model.Meter()
                {   //TODO User id for CreatedBy
                    Id = Guid.NewGuid().ToString("N"),
                    SerialNumber = TextBoxSerialNumber.Text,
                    X = Convert.ToDecimal(TextBoxX.Text),
                    Y = Convert.ToDecimal(TextBoxY.Text),
                    Status = ComboBoxStatus.Text,
                    HCN = TextBoxHCN.Text,
                    InstallationDate = DateTime.Now,
                    MaintenanceDate = DateTime.Now,
                    MeterTypeId = Convert.ToInt32(ComboBoxMeterType.Text),
                    MeterSizeId = Convert.ToInt32(ComboBoxMeterSize.Text),
                    MeterProtocolId = Convert.ToInt32(ComboBoxMeterProtocol.Text),
                    DMZId = Convert.ToInt32(ComboBoxDMZ.Text),
                    CityId = ComboBoxCity.Text,
                    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = 0
                };

                var createMeter = _meter.Create(new SmartDB(), ref meter);

                bool flag = createMeter.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Created");
                    ResetControls();
                    BindMeterWithDataGrid();
                }
                else
                {
                    MessageBox.Show(createMeter.Code.ToString());
                }
            }
            else
                MessageBox.Show("No meter to save.");
        }
        private void EditMeter()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxSerialNumber.Text))
            {   //Todo EditedBy
                var lockcount = GetLockCount(_meterId);

                TMF.Reports.Model.Meter meter = new TMF.Reports.Model.Meter()
                {
                    Id = _meterId,
                    SerialNumber = TextBoxSerialNumber.Text,
                    X = Convert.ToDecimal(TextBoxX.Text),
                    Y = Convert.ToDecimal(TextBoxY.Text),
                    Status = ComboBoxStatus.Text,
                    HCN = TextBoxHCN.Text,
                    InstallationDate = DateTime.Now,
                    MaintenanceDate = DateTime.Now,
                    MeterTypeId = Convert.ToInt32(ComboBoxMeterType.Text),
                    MeterSizeId = Convert.ToInt32(ComboBoxMeterSize.Text),
                    MeterProtocolId = Convert.ToInt32(ComboBoxMeterProtocol.Text),
                    DMZId = Convert.ToInt32(ComboBoxDMZ.Text),
                    CityId = ComboBoxCity.Text,
                    EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = lockcount
                };

                var updateMeter = _meter.Update(new SmartDB(), meter);

                bool flag = updateMeter.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Updated");
                    ResetControls();
                    BindMeterWithDataGrid();
                }
                else
                {
                    MessageBox.Show(updateMeter.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter to edit.");
            }
        }
        private void GetCities()
        {
            ComboBoxCity.Items.Clear();
            ReturnInfo getCity = _city.GetCityList(new SmartDB());
            List<TMF.Reports.Model.City> cities = (List<TMF.Reports.Model.City>)getCity.BizObject;
            foreach (var city in cities)
            {
                ComboBoxCity.Items.Add(city.Description);
            }
        }
        private void GetMeterType()
        {
            ComboBoxMeterType.Items.Clear();
            ReturnInfo getMeterType = _meterType.GetMeterTypeList(new SmartDB());
            List<TMF.Reports.Model.MeterType> meterTypes = (List<TMF.Reports.Model.MeterType>)getMeterType.BizObject;
            foreach (var meterType in meterTypes)
            {
                ComboBoxMeterType.Items.Add(meterType.Description);
            }
        }
        private void GetMeterSize()
        {
            ComboBoxMeterSize.Items.Clear();
            ReturnInfo getMeterSize = _meterSize.GetMeterSizeList(new SmartDB());
            List<TMF.Reports.Model.MeterSize> meterSizes = (List<TMF.Reports.Model.MeterSize>)getMeterSize.BizObject;
            foreach (var meterSize in meterSizes)
            {
                ComboBoxMeterSize.Items.Add(meterSize.Description);
            }
        }
        private void GetMeterProtocol()
        {
            ComboBoxMeterProtocol.Items.Clear();
            ReturnInfo getMeterProtocol = _meterProtocol.GetMeterProtocolList(new SmartDB());
            List<TMF.Reports.Model.MeterProtocol> meterProtocols = (List<TMF.Reports.Model.MeterProtocol>)getMeterProtocol.BizObject;
            foreach (var meterProtocol in meterProtocols)
            {
                ComboBoxMeterProtocol.Items.Add(meterProtocol.Description);
            }
        }
        private void GetDMZ()
        {
            ComboBoxDMZ.Items.Clear();
            ReturnInfo getDMZ = _dmz.GetDMZList(new SmartDB());
            List<TMF.Reports.Model.DMZ> dmzs = (List<TMF.Reports.Model.DMZ>)getDMZ.BizObject;
            foreach (var dmz in dmzs)
            {
                ComboBoxDMZ.Items.Add(dmz.Description);
            }
        }
        private void ResetControls()
        {
            TextBoxSearch.Text = "";
            TextBoxSerialNumber.Enabled = false;
            TextBoxX.Enabled = false;
            TextBoxY.Enabled = false;
            ComboBoxStatus.Enabled = false;
            TextBoxHCN.Enabled = false;
            DateTimePickerInstallationDate.Enabled = false;
            DateTimePickerMaintenanceDate.Enabled = false;
            ComboBoxMeterType.Enabled = false;
            ComboBoxMeterSize.Enabled = false;
            ComboBoxMeterProtocol.Enabled = false;
            ComboBoxDMZ.Enabled = false;
            ComboBoxCity.Enabled = false;
            TextBoxSerialNumber.Text = "";
            TextBoxX.Text = "";
            TextBoxY.Text = "";
            ComboBoxStatus.Text = "";
            TextBoxHCN.Text = "";
            DateTimePickerInstallationDate.Text = "";
            DateTimePickerMaintenanceDate.Text = "";
            ComboBoxMeterType.Items.Clear();
            ComboBoxMeterSize.Items.Clear();
            ComboBoxMeterProtocol.Items.Clear();
            ComboBoxDMZ.Items.Clear();
            ComboBoxCity.Items.Clear();
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindMeterWithDataGrid();
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
            IInfo info = _meter.GetMeterById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.Meter).LockCount;
            return lockcount;
        }
        private void BindMeterWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                ReturnInfo getMeterList = _meter.GetMeterByDescription(new SmartDB(), TextBoxSearch.Text);
                //bool flag = getCityList.Code == ErrorEnum.NoError;
                List<TMF.Reports.Model.Meter> meter = (List<TMF.Reports.Model.Meter>)getMeterList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.Meter>(meter);
                var source = new BindingSource(bindingList, null);
                DataGridViewMeter.AutoGenerateColumns = false;
                DataGridViewMeter.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewMeter.CurrentRow.Index + 1} index of {DataGridViewMeter.RowCount} records";
            }
            catch (Exception e)
            {
                return;
            }
        }
        #endregion
    }
}
