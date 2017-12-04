using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.Model;

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
        private readonly CustomUser _currentUser;
        private bool _save;
        private string _meterSerialNumber;
        public Meter(CustomUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _meter = new TMF.Reports.BLL.Meter();
            _meterType = new TMF.Reports.BLL.MeterType();
            _meterSize = new TMF.Reports.BLL.MeterSize();
            _meterProtocol = new TMF.Reports.BLL.MeterProtocol();
            _dmz = new TMF.Reports.BLL.DMZ();
            _city = new TMF.Reports.BLL.City();

            _save = true;
            _meterSerialNumber = "";
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
            _meterSerialNumber = "";
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
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
            if (!string.IsNullOrWhiteSpace(TextBoxSerialNumber.Text) &&
                _currentUser.Role == "Administrator")
            {
                var deleteMeter = _meter.Delete(new SmartDB(), _meterSerialNumber);

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
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            ExportMeters();
        }
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            ImportMeters();
        }
        private void DataGridViewMeter_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewMeter.CurrentRow.Index + 1} index of {DataGridViewMeter.RowCount} records";

            try
            {
                var serialNumber = DataGridViewMeter.CurrentRow.Cells[0].Value.ToString();
                ReturnInfo getMeter = _meter.GetMeterById(new SmartDB(), serialNumber);
                bool flag = getMeter.Code == ErrorEnum.NoError;
                TMF.Reports.Model.Meter meter = (TMF.Reports.Model.Meter)getMeter.BizObject;

            ReturnInfo getMeterType = _meterType.GetMeterTypeById(new SmartDB(), Convert.ToInt32(meter.MeterTypeId));
            TMF.Reports.Model.MeterType meterType = (TMF.Reports.Model.MeterType)getMeterType.BizObject;
            ReturnInfo getMeterSize = _meterSize.GetMeterSizeById(new SmartDB(), Convert.ToInt32(meter.MeterSizeId));
            TMF.Reports.Model.MeterSize meterSize = (TMF.Reports.Model.MeterSize)getMeterSize.BizObject;
            ReturnInfo getMeterProtocol = _meterProtocol.GetMeterProtocolById(new SmartDB(), Convert.ToInt32(meter.MeterProtocolId));
            TMF.Reports.Model.MeterProtocol meterProtocol = (TMF.Reports.Model.MeterProtocol)getMeterProtocol.BizObject;
            ReturnInfo getDMZ = _dmz.GetDMZById(new SmartDB(), Convert.ToInt32(meter.DMZId));
            TMF.Reports.Model.DMZ dmz = (TMF.Reports.Model.DMZ)getDMZ.BizObject;
            ReturnInfo getCity = _city.GetCityById(new SmartDB(), meter.CityId);
            TMF.Reports.Model.City city = (TMF.Reports.Model.City)getCity.BizObject;

            if (!string.IsNullOrEmpty(meter.SerialNumber))
                {
                    _meterSerialNumber = meter.SerialNumber;
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
            catch (Exception)
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
                {
                    SerialNumber = TextBoxSerialNumber.Text,
                    X = Convert.ToDecimal(TextBoxX.Text),
                    Y = Convert.ToDecimal(TextBoxY.Text),
                    Status = ComboBoxStatus.Text,
                    HCN = TextBoxHCN.Text,
                    InstallationDate = DateTime.Now,
                    MaintenanceDate = DateTime.Now,
                    MeterTypeId = ComboBoxMeterType.Text,
                    MeterSizeId = ComboBoxMeterSize.Text,
                    MeterProtocolId = ComboBoxMeterProtocol.Text,
                    DMZId = ComboBoxDMZ.Text,
                    CityId = ComboBoxCity.Text,
                    CreatedBy = _currentUser.Id.ToString(),
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
            {
                var lockcount = GetLockCount(_meterSerialNumber);

                TMF.Reports.Model.Meter meter = new TMF.Reports.Model.Meter()
                {
                    SerialNumber = TextBoxSerialNumber.Text,
                    X = Convert.ToDecimal(TextBoxX.Text),
                    Y = Convert.ToDecimal(TextBoxY.Text),
                    Status = ComboBoxStatus.Text,
                    HCN = TextBoxHCN.Text,
                    InstallationDate = DateTime.Now,
                    MaintenanceDate = DateTime.Now,
                    MeterTypeId = ComboBoxMeterType.Text,
                    MeterSizeId = ComboBoxMeterSize.Text,
                    MeterProtocolId = ComboBoxMeterProtocol.Text,
                    DMZId = ComboBoxDMZ.Text,
                    CityId = ComboBoxCity.Text,
                    EditedBy = _currentUser.Id.ToString(),
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
            if (keyData == Keys.Escape || keyData == Keys.F5)
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
                ReturnInfo getMeterList = _meter.GetMeterBySerialNumber(new SmartDB(), TextBoxSearch.Text);
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
        private void ExportMeters()
        {
            StreamWriter sr;
            string line = "";
            StringBuilder fileContents = new StringBuilder();

            fileContents.Append("SERIAL_NUMBER, X, Y, STATUS, HCN, INSTALLATION_DATE" +
                                "MAINTENANCE_DATE, METER_TYPE_ID, METER_SIZE_ID," +
                                "METER_PROTOCOL_ID, DMZ_ID, CITY_ID, " +
                                "CREATED_BY, EDITED_BY, DOC_DATE, SHOW, LOCK_COUNT\r\n");
            if (saveFileDialogMeter.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamWriter(saveFileDialogMeter.FileName, false);
                try
                {
                    ReturnInfo getMeterList = _meter.GetMeterBySerialNumber(new SmartDB(), TextBoxSearch.Text);
                    List<TMF.Reports.Model.Meter> meter = (List<TMF.Reports.Model.Meter>)getMeterList.BizObject;

                    foreach (var m in meter)
                    {
                        line = m.SerialNumber + ",";
                        line += m.X + ",";
                        line += m.Y + ",";
                        line += m.Status + ",";
                        line += m.HCN + ",";
                        line += m.InstallationDate + ",";
                        line += m.MaintenanceDate + ",";
                        line += m.MeterTypeId + ",";
                        line += m.MeterSizeId + ",";
                        line += m.MeterProtocolId + ",";
                        line += m.DMZId + ",";
                        line += m.CityId + ",";
                        line += m.CreatedBy + ",";
                        line += m.EditedBy + ",";
                        line += m.DocDate + ",";
                        line += m.Show + ",";
                        line += m.LockCount + "\r\n";
                        fileContents.Append(line);
                    }

                    sr.Write(fileContents);
                    sr.Flush();
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while exporting file!");
                }

            }
        }
        private void ImportMeters()
        {
            try
            {
                if (openFileDialogMeter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string[] allLines = File.ReadAllLines(openFileDialogMeter.FileName);

                    var query = from line in allLines
                                let data = line.Split(',')
                                select new
                                {
                                    Id = data[0],
                                    SerialNumber = data[1],
                                    X = data[2],
                                    Y = data[3],
                                    Status = data[4],
                                    HCN = data[5],
                                    InstallationDate = data[6],
                                    MaintenanceDate = data[7],
                                    MeterTypeId = data[8],
                                    MeterSizeId = data[9],
                                    MeterProtocolId = data[10],
                                    CityId = data[11],
                                    CreatedBy = data[12],
                                    EditedBy = data[13],
                                    DocDate = data[14],
                                    Show = data[15],
                                    Locked = data[16],
                                };
                    foreach (var q in query.ToList().Skip(1))
                    {
                        MessageBox.Show(q.Id + " " +
                                        q.SerialNumber + " " +
                                        q.X + " " +
                                        q.Y + " " +
                                        q.Status + " " +
                                        q.HCN + " " +
                                        q.InstallationDate + " " +
                                        q.MaintenanceDate + " " +
                                        q.MeterTypeId + " " +
                                        q.MeterSizeId + " " +
                                        q.MeterProtocolId + " " +
                                        q.CityId + " " +
                                        q.CreatedBy + " " +
                                        q.EditedBy + " " +
                                        q.DocDate + " " +
                                        q.Show + " " +
                                        q.Locked);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while importing file!");
            }
        }
    }
}
