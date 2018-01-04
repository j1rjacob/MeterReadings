using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class MeterReading : Form
    {
        private readonly TMF.Reports.BLL.MeterReading _meterReading;
        private readonly TMF.Core.Model.UserInfo _currentUser;
        private bool _save;
        private string _meterReadingId;


        public MeterReading(TMF.Core.Model.UserInfo currentUser)
        {
            InitializeComponent();
            _meterReading = new TMF.Reports.BLL.MeterReading();
            _currentUser = currentUser;
            _save = true;
            _meterReadingId = "";
        }
        private void MeterReading_Load(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxSerialNumber.Enabled = true;
            TextBoxReadingDate.Enabled = true;
            TextBoxReadingValue.Enabled = true;
            TextBoxLowBattAlr.Enabled = true;
            TextBoxLeakAlr.Enabled = true;
            TextBoxMagneticTmprAlr.Enabled = true;
            TextBoxErrorAlr.Enabled = true;
            TextBoxBackflowAlr.Enabled = true;
            TextBoxBrokenPipeAlr.Enabled = true;
            TextBoxEmptyPipeAlr.Enabled = true;
            TextBoxSpecificErr.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxSerialNumber.Text = "";
            TextBoxReadingDate.Text = "";
            TextBoxReadingValue.Text = "";
            TextBoxLowBattAlr.Text = "";
            TextBoxLeakAlr.Text = "";
            TextBoxMagneticTmprAlr.Text = "";
            TextBoxErrorAlr.Text = "";
            TextBoxBackflowAlr.Text = "";
            TextBoxBrokenPipeAlr.Text = "";
            TextBoxEmptyPipeAlr.Text = "";
            TextBoxSpecificErr.Text = "";
            _meterReadingId = "";
            TextBoxSerialNumber.Focus();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxSerialNumber.Enabled = true;
            TextBoxReadingDate.Enabled = true;
            TextBoxReadingValue.Enabled = true;
            TextBoxLowBattAlr.Enabled = true;
            TextBoxLeakAlr.Enabled = true;
            TextBoxMagneticTmprAlr.Enabled = true;
            TextBoxErrorAlr.Enabled = true;
            TextBoxBackflowAlr.Enabled = true;
            TextBoxBrokenPipeAlr.Enabled = true;
            TextBoxEmptyPipeAlr.Enabled = true;
            TextBoxSpecificErr.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            _save = false;
            TextBoxSerialNumber.Focus();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
                SaveMeterReading();
            else
                EditMeterReading();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxSerialNumber.Text) &&
                _currentUser.Role == "Administrator")
            {
                var deleteMeterReading = _meterReading.Delete(new SmartDB(), _meterReadingId);

                bool flag = deleteMeterReading.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Reading Deleted");
                    ResetControls();
                    //BindMeterReadingWithDataGrid();
                }
                else
                {
                    MessageBox.Show(deleteMeterReading.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter reading to delete or Contact Admin.");
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text != "")
            {
                FillGrid();
                BindMeterReadingLatestWithDataGrid();
            }
            else
            {
                return;
            }
        }
        private void TextBoxSerialNumber_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSerialNumber.Text != "")
            {
                BindMeterReadingLatestWithDataGrid();
            }
            else
            {
                DataGridViewLatestMeterReading.DataSource = null;
            }

        }
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialogMeterReading.ShowDialog() == DialogResult.OK)
            {
                Task.Factory.StartNew(() => ExportMeterReadings(saveFileDialogMeterReading));
            }
        }
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            if (openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                var f = new Import(openFileDialogImport.FileNames);
                f.ShowDialog();
            }
        }
        private void DataGridViewMeterReading_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var meterReadingId = DataGridViewMeterReading.CurrentRow.Cells[0].Value.ToString() ?? "";
                ReturnInfo getMeterReading = _meterReading.GetMeterReadingById(new SmartDB(), meterReadingId);

                bool flag = getMeterReading.Code == ErrorEnum.NoError;

                TMF.Reports.Model.MeterReading meterReading = (TMF.Reports.Model.MeterReading)getMeterReading.BizObject;
                if (!string.IsNullOrEmpty(meterReading.Id))
                {
                    TextBoxSerialNumber.Text = meterReading.SerialNumber;
                    TextBoxReadingDate.Text = meterReading.ReadingDate.ToString();
                    TextBoxReadingValue.Text = meterReading.ReadingValue;
                    TextBoxLowBattAlr.Text = meterReading.LowBatteryAlr.ToString();
                    TextBoxLeakAlr.Text = meterReading.LeakAlr.ToString();
                    TextBoxMagneticTmprAlr.Text = meterReading.MagneticTamperAlr.ToString();
                    TextBoxErrorAlr.Text = meterReading.MeterErrorAlr.ToString();
                    TextBoxBackflowAlr.Text = meterReading.BackFlowAlr.ToString();
                    TextBoxBrokenPipeAlr.Text = meterReading.BrokenPipeAlr.ToString();
                    TextBoxEmptyPipeAlr.Text = meterReading.EmptyPipeAlr.ToString();
                    TextBoxSpecificErr.Text = meterReading.SpecificErr.ToString();
                    _meterReadingId = meterReading.Id;
                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;
                }
            }
            catch (Exception)
            {
                ResetControls();
            }
        }
        #region PriveteMethod
        private void SaveMeterReading()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxSerialNumber.Text))
            {
                TMF.Reports.Model.MeterReading meterReading = new TMF.Reports.Model.MeterReading()
                {
                    SerialNumber = TextBoxSerialNumber.Text,
                    ReadingDate = Convert.ToDateTime(TextBoxReadingDate.Text),
                    ReadingValue = TextBoxReadingValue.Text,
                    LowBatteryAlr = Convert.ToInt32(TextBoxLowBattAlr.Text),
                    LeakAlr = Convert.ToInt32(TextBoxLeakAlr.Text),
                    MagneticTamperAlr = Convert.ToInt32(TextBoxMagneticTmprAlr.Text),
                    MeterErrorAlr = Convert.ToInt32(TextBoxErrorAlr.Text),
                    BackFlowAlr = Convert.ToInt32(TextBoxBackflowAlr.Text),
                    BrokenPipeAlr = Convert.ToInt32(TextBoxBrokenPipeAlr.Text),
                    EmptyPipeAlr = Convert.ToInt32(TextBoxEmptyPipeAlr.Text),
                    SpecificErr = Convert.ToInt32(TextBoxSpecificErr.Text),
                    CreatedBy = _currentUser.Id,
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = 0
                };

                var createMeterReading = _meterReading.Create(new SmartDB(), ref meterReading);

                bool flag = createMeterReading.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Reading Created");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show(createMeterReading.Code.ToString());
                }
            }
            else
                MessageBox.Show("No meter reading to save or Contact Admin.");
        }
        private void EditMeterReading()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxSerialNumber.Text))
            {   //Todo EditedBy
                var lockcount = GetLockCount(_meterReadingId);

                TMF.Reports.Model.MeterReading meterReading = new TMF.Reports.Model.MeterReading()
                {
                    Id = _meterReadingId,
                    SerialNumber = TextBoxSerialNumber.Text,
                    ReadingDate = Convert.ToDateTime(TextBoxReadingDate.Text),
                    ReadingValue = TextBoxReadingValue.Text,
                    LowBatteryAlr = Convert.ToInt32(TextBoxLowBattAlr.Text),
                    LeakAlr = Convert.ToInt32(TextBoxLeakAlr.Text),
                    MagneticTamperAlr = Convert.ToInt32(TextBoxLeakAlr.Text),
                    MeterErrorAlr = Convert.ToInt32(TextBoxErrorAlr.Text),
                    BackFlowAlr = Convert.ToInt32(TextBoxBackflowAlr.Text),
                    BrokenPipeAlr = Convert.ToInt32(TextBoxBrokenPipeAlr.Text),
                    EmptyPipeAlr = Convert.ToInt32(TextBoxEmptyPipeAlr.Text),
                    SpecificErr = Convert.ToInt32(TextBoxSpecificErr.Text),
                    EditedBy = _currentUser.Id.ToString(),
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = lockcount
                };

                var updateMeterReading = _meterReading.Update(new SmartDB(), meterReading);

                bool flag = updateMeterReading.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Reading Updated");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show(updateMeterReading.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter reading to edit or Contact Admin.");
            }
        }
        private void ResetControls()
        {
            TextBoxSerialNumber.Enabled = false;
            TextBoxReadingDate.Enabled = false;
            TextBoxReadingValue.Enabled = false;
            TextBoxLowBattAlr.Enabled = false;
            TextBoxLeakAlr.Enabled = false;
            TextBoxMagneticTmprAlr.Enabled = false;
            TextBoxErrorAlr.Enabled = false;
            TextBoxBackflowAlr.Enabled = false;
            TextBoxBrokenPipeAlr.Enabled = false;
            TextBoxEmptyPipeAlr.Enabled = false;
            TextBoxSpecificErr.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxSerialNumber.Text = "";
            TextBoxReadingDate.Text = "";
            TextBoxReadingValue.Text = "";
            TextBoxLowBattAlr.Text = "";
            TextBoxLeakAlr.Text = "";
            TextBoxMagneticTmprAlr.Text = "";
            TextBoxErrorAlr.Text = "";
            TextBoxBackflowAlr.Text = "";
            TextBoxBrokenPipeAlr.Text = "";
            TextBoxEmptyPipeAlr.Text = "";
            TextBoxSpecificErr.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            Task.Factory.StartNew(() => BindMeterReadingWithDataGrid());
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
            IInfo info = _meterReading.GetMeterReadingById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.MeterReading).LockCount;
            return lockcount;
        }
        private int perPage = 10;
        private int currentPage = 1;
        private int pageCount = 0;
        private int pageSize = 0;
        private void BindMeterReadingWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                DataGridViewMeterReading.AutoGenerateColumns = false;
                FillGrid();
            }
            catch (Exception)
            {
                return;
            }
        }
        private void BindMeterReadingLatestWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                ReturnInfo getMeterReadingList = _meterReading.GetLatestMeterReadingRecord(new SmartDB(), TextBoxSerialNumber.Text);
              
                List<TMF.Reports.Model.MeterReading> meterReading = (List<TMF.Reports.Model.MeterReading>)getMeterReadingList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.MeterReading>(meterReading);
                var source = new BindingSource(bindingList, null);
                DataGridViewLatestMeterReading.AutoGenerateColumns = false;
                DataGridViewLatestMeterReading.DataSource = source;
            }
            catch (Exception)
            {
                return;
            }
        }
        private void ExportMeterReadings(SaveFileDialog sfdMeterReading)
        {
            StreamWriter sr;
            string line = "";
            StringBuilder fileContents = new StringBuilder();

            fileContents.Append("Id, SerialNumber, ReadingDate, ReadingValue, LowBatteryAlr, LeakAlr, " +
                                "MagneticTamperAlr, MeterErrorAlr, BackFlowAlr, BrokenPipeAlr, EmptyPipeAlr, " +
                                "SpecificErr, Createdby, Editedby, DocDate, Show, LockCount\r\n");
           
            sr = new StreamWriter(sfdMeterReading.FileName, false);
            try
            {
                ReturnInfo getMeterReadingList = _meterReading.GetMeterReadingList(new SmartDB());
                List<TMF.Reports.Model.MeterReading> meterReadings = (List<TMF.Reports.Model.MeterReading>)getMeterReadingList.BizObject;

                foreach (var mr in meterReadings)
                {
                    line = mr.Id + ",";
                    line += mr.SerialNumber + ",";
                    line += mr.ReadingDate + ",";
                    line += mr.ReadingValue + ",";
                    line += mr.LowBatteryAlr + ",";
                    line += mr.LeakAlr + ",";
                    line += mr.MagneticTamperAlr + ",";
                    line += mr.MeterErrorAlr + ",";
                    line += mr.BackFlowAlr + ",";
                    line += mr.BrokenPipeAlr + ",";
                    line += mr.EmptyPipeAlr + ",";
                    line += mr.SpecificErr + ",";
                    line += mr.CreatedBy + ",";
                    line += mr.EditedBy + ",";
                    line += mr.DocDate + ",";
                    line += mr.Show + ",";
                    line += mr.LockCount + "\r\n";
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
            //}
        }
        #endregion

        #region Paging
        private int _mintTotalRecords = 0;
        private int _mintPageSize = 0;
        private int _mintPageCount = 0;
        private int _mintCurrentPage = 1;
        private void FillGrid()
        {
            _mintPageSize = 18;
            _mintTotalRecords = GetCount();
            _mintPageCount = _mintTotalRecords / _mintPageSize;

            if (_mintTotalRecords % _mintPageSize > 0)
                _mintPageCount++;

            _mintCurrentPage = 0;
            LoadPage();
        }
        public int GetCount()
        {
            int intCount = 0;
            using (SqlConnection connection =
                new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                connection.Open();
                string strSql = "SELECT Rows FROM SYSINDEXES " +
                                "WHERE Id = OBJECT_ID('MeterReading') AND IndId < 2 ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                
                intCount = (int)cmd.ExecuteScalar();
                cmd.Dispose();
            }
            return intCount;
        }
        public void LoadPage()
        {
            string strSql = "";
            int intSkip = 0;

            intSkip = (_mintCurrentPage * _mintPageSize);
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            using (SqlConnection connection =
                new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                strSql = "SELECT TOP " + _mintPageSize +
                         " * FROM MeterReading WHERE Id NOT IN " +
                         "(SELECT TOP " + intSkip + " Id FROM MeterReading)" +
                         "AND SerialNumber LIKE @SerialNumber";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@SerialNumber", "%" + TextBoxSearch.Text + "%");
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "MeterReading");

                var source = new BindingSource(ds.Tables["MeterReading"].DefaultView, null);
             
                DataGridViewMeterReading.Invoke((Action)delegate { DataGridViewMeterReading.DataSource = source; });
                lblStatus.Text = (_mintCurrentPage + 1) +
                                      " / " + _mintPageCount;
                cmd.Dispose();
                da.Dispose();
                ds.Dispose();
            }
        }
        public void GoFirst()
        {
            _mintCurrentPage = 0;
            LoadPage();
        }
        public void GoPrevious()
        {
            if (_mintCurrentPage == _mintPageCount)
                _mintCurrentPage = _mintPageCount - 1;

            _mintCurrentPage--;

            if (_mintCurrentPage < 1)
                _mintCurrentPage = 0;

            LoadPage();
        }
        public void GoNext()
        {
            _mintCurrentPage++;

            if (_mintCurrentPage > (_mintPageCount - 1))
                _mintCurrentPage = _mintPageCount - 1;

            LoadPage();
        }
        public void GoLast()
        {
            _mintCurrentPage = _mintPageCount - 1;
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
