using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.UTIL;

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
        private readonly TMF.Core.Model.UserInfo _currentUser;
        private bool _save;
        private string _meterSerialNumber;
        public Meter(TMF.Core.Model.UserInfo currentUser)
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
            TextBoxSerialNumber.Focus();
            //Check Serial Number if exist then edit
            //reset
            //edit
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
            TextBoxX.Focus();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
            {
                SaveMeter();
            }
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
                MessageBox.Show("No meter to delete or Contact Admin.");
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindMeterWithDataGrid();
        }
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialogMeter.ShowDialog() == DialogResult.OK)
            {
                Task.Factory.StartNew(() => ExportMeters(saveFileDialogMeter));
            }
        }
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogMeter.ShowDialog() == DialogResult.OK)
                {
                    ImportMeters(openFileDialogMeter.FileNames);
                }
                MessageBox.Show("Import was successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Import was not successful");
            }

            ResetControls();
        }
        private void DataGridViewMeter_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _meterSerialNumber = DataGridViewMeter.CurrentRow.Cells[0].Value.ToString();
                TextBoxSerialNumber.Text = DataGridViewMeter.CurrentRow.Cells[0].Value.ToString();
                TextBoxX.Text = DataGridViewMeter.CurrentRow.Cells[1].Value.ToString();
                TextBoxY.Text = DataGridViewMeter.CurrentRow.Cells[2].Value.ToString();
                ComboBoxStatus.Text = DataGridViewMeter.CurrentRow.Cells[3].Value.ToString();
                TextBoxHCN.Text = DataGridViewMeter.CurrentRow.Cells[4].Value.ToString();
                DateTimePickerInstallationDate.Text = DataGridViewMeter.CurrentRow.Cells[5].Value.ToString();
                DateTimePickerMaintenanceDate.Text = DataGridViewMeter.CurrentRow.Cells[6].Value.ToString();
                ComboBoxMeterType.Text = DataGridViewMeter.CurrentRow.Cells[7].Value.ToString();
                ComboBoxMeterSize.Text = DataGridViewMeter.CurrentRow.Cells[8].Value.ToString();
                ComboBoxMeterProtocol.Text = DataGridViewMeter.CurrentRow.Cells[9].Value.ToString();
                ComboBoxDMZ.Text = DataGridViewMeter.CurrentRow.Cells[10].Value.ToString();
                ComboBoxCity.Text = DataGridViewMeter.CurrentRow.Cells[11].Value.ToString();
                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;
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
        private void TextBoxSerialNumber_Leave(object sender, EventArgs e)
        {
            ButtonSearch.PerformClick();
            ReturnInfo getMeter = _meter.GetMeterBySerialNumber(new SmartDB(), TextBoxSerialNumber.Text);
            bool flag = getMeter.Code == ErrorEnum.NoError;
            if (flag)
            {
                ButtonEdit.PerformClick();
            }
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
                MessageBox.Show("No meter to save or Contact Admin.");
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
                    BindMeterWithDataGrid();
                    ResetControls();

                    ((Main)this.MdiParent).GetCities();

                }
                else
                {
                    MessageBox.Show(updateMeter.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter to edit or Contact Admin.");
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
            DateTimePickerMaintenanceDate.Text = DateTime.Now.ToString();
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
            Task.Factory.StartNew(() => BindMeterWithDataGrid());
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
                DataGridViewMeter.AutoGenerateColumns = false;
                FillGrid();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion
        private void ExportMeters(SaveFileDialog sfdMeter)
        {
            StreamWriter sr;
            string line = "";
            StringBuilder fileContents = new StringBuilder();

            fileContents.Append("SERIAL_NUMBER, X, Y, STATUS, HCN, INSTALLATION_DATE," +
                                "MAINTENANCE_DATE, METER_TYPE_ID, METER_SIZE_ID," +
                                "METER_PROTOCOL_ID, DMZ_ID, CITY_ID, " +
                                "CREATED_BY, EDITED_BY, DOC_DATE, SHOW, LOCK_COUNT\r\n");
            
            sr = new StreamWriter(sfdMeter.FileName, false);
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
                MessageBox.Show("Export Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Error while exporting file!");
            }
        }
        private void ImportMeters(string[] fileNames)
        {
            //TODO: Decouple; Error same count on imported and duplicated.
            try
            {
                Task.Factory.StartNew(() => BulkMeter.Import(fileNames));
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error importing file {e.Message}");
            }
        }
        #region Paging
        private int _mintTotalRecords = 0;
        private int _mintPageSize = 0;
        private int _mintPageCount = 0;
        private int _mintCurrentPage = 0;
        private void FillGrid()
        {
            _mintPageSize = 6;
            _mintTotalRecords = GetCount();
            _mintPageCount = _mintTotalRecords / _mintPageSize;

            if (_mintTotalRecords % _mintPageSize > 0)
                _mintPageCount++;

            _mintCurrentPage = 1;
            LoadPage();
        }
        public int GetCount()
        {
            int intCount = 0;
            using (SqlConnection connection =
                new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                connection.Open();
          
                string strSql = "SELECT COUNT(SerialNumber) FROM Meter " +
                                "WHERE SerialNumber LIKE @SerialNumber " +
                                "OR X LIKE @SerialNumber " +
                                "OR Y LIKE @SerialNumber " +
                                "OR Status LIKE @SerialNumber " +
                                "OR HCN LIKE @SerialNumber " +
                                "OR InstallationDate LIKE @SerialNumber " +
                                "OR MaintenanceDate LIKE @SerialNumber " +
                                "OR MeterTypeId LIKE (SELECT DISTINCT Id FROM MeterType Where Description LIKE @SerialNumber) " +
                                "OR MeterSizeId LIKE (SELECT DISTINCT Id FROM MeterSize Where Description LIKE @SerialNumber) " +
                                "OR MeterProtocolId LIKE (SELECT DISTINCT Id FROM MeterProtocol Where Description LIKE @SerialNumber) " +
                                "OR CityId LIKE (SELECT DISTINCT Id FROM City Where Description LIKE @SerialNumber) " +
                                "OR DMZId LIKE (SELECT DISTINCT Id FROM DMZ Where Description LIKE @SerialNumber)";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@SerialNumber", "%" + TextBoxSearch.Text + "%");
                intCount = (int)cmd.ExecuteScalar();
                cmd.Dispose();
            }
            return intCount;
        }
        public void LoadPage()
        {
            string strSql = "";
            int intSkip = 1;

            intSkip = _mintCurrentPage;
            
            SqlConnection conn = new SmartDB().Connection;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd = new SqlCommand("REPORT METER_PAGING", conn);
                cmd.Parameters.Add(new SqlParameter("@PageNumber", intSkip));
                cmd.Parameters.Add(new SqlParameter("@RowspPage", _mintPageSize));
                cmd.Parameters.Add(new SqlParameter("@Query", string.IsNullOrWhiteSpace(TextBoxSearch.Text) ? TextBoxSerialNumber.Text : TextBoxSearch.Text));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
                
                DataGridViewMeter.Invoke((Action)delegate { DataGridViewMeter.DataSource = dt; });

                lblStatus.Invoke((Action)delegate
                {
                    lblStatus.Text = (_mintCurrentPage) +
                                     " / " + _mintPageCount;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

        }
        public void GoFirst()
        {
            _mintCurrentPage = 1;
            LoadPage();
        }
        public void GoPrevious()
        {
            if (_mintCurrentPage == 1)
                _mintCurrentPage = 1;
            else
                _mintCurrentPage--;

            LoadPage();
        }
        public void GoNext()
        {
            if (_mintCurrentPage == _mintPageCount)
                _mintCurrentPage = _mintPageCount;
            else
                _mintCurrentPage++;
            
            LoadPage();
        }
        public void GoLast()
        {
            _mintCurrentPage = _mintPageCount;
            LoadPage();
        }
        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            GoFirst();
        }
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            GoPrevious();
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            GoNext();
        }
        private void ButtonLast_Click(object sender, EventArgs e)
        {
            GoLast();
        }
        #endregion
    }
}
