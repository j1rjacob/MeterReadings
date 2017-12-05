using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.Model;

namespace MeterReports
{
    public partial class MeterReading : Form
    {
        private readonly TMF.Reports.BLL.MeterReading _meterReading;
        private readonly CustomUser _currentUser;
        private bool _save;
        private string _meterReadingId;
        
        
        public MeterReading(CustomUser currentUser)
        {
            InitializeComponent();
            _meterReading = new TMF.Reports.BLL.MeterReading();
            _currentUser = currentUser;
            _currentUser = new CustomUser();
            _save = true;
            _meterReadingId = "";
        }
        private void MeterReading_Load(object sender, EventArgs e)
        {
            BindMeterReadingWithDataGrid();
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
                    BindMeterReadingWithDataGrid();
                }
                else
                {
                    MessageBox.Show(deleteMeterReading.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter reading to delete.");
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindMeterReadingWithDataGrid();
        }
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            ExportGateways();
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
            LabelShow.Text = $"Showing {DataGridViewMeterReading.CurrentRow.Index + 1} index of {DataGridViewMeterReading.RowCount} records";

            var meterReadingId = DataGridViewMeterReading.CurrentRow.Cells[0].Value.ToString();
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
        #region PriveteMethod
        private void SaveMeterReading()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxSerialNumber.Text))
            {
                TMF.Reports.Model.MeterReading meterReading = new TMF.Reports.Model.MeterReading()
                {   
                    //Id = Guid.NewGuid().ToString("N"),
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
                    CreatedBy = _currentUser.Id.ToString(),
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
                    BindMeterReadingWithDataGrid();
                }
                else
                {
                    MessageBox.Show(createMeterReading.Code.ToString());
                }
            }
            else
                MessageBox.Show("No meter reading to save.");
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
                    BindMeterReadingWithDataGrid();
                }
                else
                {
                    MessageBox.Show(updateMeterReading.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter reading to edit.");
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
            BindMeterReadingWithDataGrid();
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
        private void BindMeterReadingWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                ReturnInfo getMeterReadingList = _meterReading.GetMeterReadingBySerialNumber(new SmartDB(), TextBoxSearch.Text);
                //bool flag = getCityList.Code == ErrorEnum.NoError;
                List<TMF.Reports.Model.MeterReading> meterReading = (List<TMF.Reports.Model.MeterReading>)getMeterReadingList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.MeterReading>(meterReading);
                var source = new BindingSource(bindingList, null);
                DataGridViewMeterReading.AutoGenerateColumns = false;
                DataGridViewMeterReading.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewMeterReading.CurrentRow.Index + 1} index of {DataGridViewMeterReading.RowCount} records";
            }
            catch (Exception)
            {
                return;
            }
        }
        private void ExportGateways()
        {
            StreamWriter sr;
            string line = "";
            StringBuilder fileContents = new StringBuilder();

            fileContents.Append("Id, SerialNumber, ReadingDate, ReadingValue, LowBatteryAlr, LeakAlr, " +
                                "MagneticTamperAlr, MeterErrorAlr, BackFlowAlr, BrokenPipeAlr, EmptyPipeAlr, " +
                                "SpecificErr, Createdby, Editedby, DocDate, Show, LockCount\r\n");
            if (saveFileDialogMeterReading.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamWriter(saveFileDialogMeterReading.FileName, false);
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
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while exporting file!");
                }
            }
        }
        #endregion
    }
}
