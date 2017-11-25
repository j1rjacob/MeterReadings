using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            TextBoxCsvType.Enabled = true;
            TextBoxReadingValue.Enabled = true;
            TextBoxDescription.Enabled = true;
            TextBoxLowBattAlr.Enabled = true;
            TextBoxLeakAlr.Enabled = true;
            TextBoxMagneticTmprAlr.Enabled = true;
            TextBoxErrorAlr.Enabled = true;
            TextBoxBackflowAlr.Enabled = true;
            TextBoxBrokenPipeAlr.Enabled = true;
            TextBoxEmptyPipeAlr.Enabled = true;
            TextBoxSpecificErr.Enabled = true;
            TextBoxFlowRateValue.Enabled = true;
            TextBoxAppBusyAlr.Enabled = true;
            TextBoxAnyAppErrAlr.Enabled = true;
            TextBoxAbnCondAlr.Enabled = true;
            TextBoxPermErrAlr.Enabled = true;
            TextBoxTempErrAlr.Enabled = true;
            TextBoxSpecErr1.Enabled = true;
            TextBoxSpecErr2.Enabled = true;
            TextBoxSpecErr3.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxSerialNumber.Text = "";
            TextBoxReadingDate.Text = "";
            TextBoxCsvType.Text = "";
            TextBoxReadingValue.Text = "";
            TextBoxDescription.Text = "";
            TextBoxLowBattAlr.Text = "";
            TextBoxLeakAlr.Text = "";
            TextBoxMagneticTmprAlr.Text = "";
            TextBoxErrorAlr.Text = "";
            TextBoxBackflowAlr.Text = "";
            TextBoxBrokenPipeAlr.Text = "";
            TextBoxEmptyPipeAlr.Text = "";
            TextBoxSpecificErr.Text = "";
            TextBoxFlowRateValue.Text = "";
            TextBoxAppBusyAlr.Text = "";
            TextBoxAnyAppErrAlr.Text = "";
            TextBoxAbnCondAlr.Text = "";
            TextBoxPermErrAlr.Text = "";
            TextBoxTempErrAlr.Text = "";
            TextBoxSpecErr1.Text = "";
            TextBoxSpecErr2.Text = "";
            TextBoxSpecErr3.Text = "";
            _meterReadingId = "";
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxSerialNumber.Enabled = true;
            TextBoxReadingDate.Enabled = true;
            TextBoxCsvType.Enabled = true;
            TextBoxReadingValue.Enabled = true;
            TextBoxDescription.Enabled = true;
            TextBoxLowBattAlr.Enabled = true;
            TextBoxLeakAlr.Enabled = true;
            TextBoxMagneticTmprAlr.Enabled = true;
            TextBoxErrorAlr.Enabled = true;
            TextBoxBackflowAlr.Enabled = true;
            TextBoxBrokenPipeAlr.Enabled = true;
            TextBoxEmptyPipeAlr.Enabled = true;
            TextBoxSpecificErr.Enabled = true;
            TextBoxFlowRateValue.Enabled = true;
            TextBoxAppBusyAlr.Enabled = true;
            TextBoxAnyAppErrAlr.Enabled = true;
            TextBoxAbnCondAlr.Enabled = true;
            TextBoxPermErrAlr.Enabled = true;
            TextBoxTempErrAlr.Enabled = true;
            TextBoxSpecErr1.Enabled = true;
            TextBoxSpecErr2.Enabled = true;
            TextBoxSpecErr3.Enabled = true;
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
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
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
                TextBoxCsvType.Text = meterReading.CSVType;
                TextBoxReadingValue.Text = meterReading.ReadingValue;
                TextBoxDescription.Text = meterReading.Description;
                TextBoxLowBattAlr.Text = meterReading.LowBatteryAlr.ToString();
                TextBoxLeakAlr.Text = meterReading.LeakAlr.ToString();
                TextBoxMagneticTmprAlr.Text = meterReading.MagneticTamperAlr.ToString();
                TextBoxErrorAlr.Text = meterReading.MeterErrorAlr.ToString();
                TextBoxBackflowAlr.Text = meterReading.BackFlowAlr.ToString();
                TextBoxBrokenPipeAlr.Text = meterReading.BrokenPipeAlr.ToString();
                TextBoxEmptyPipeAlr.Text = meterReading.EmptyPipeAlr.ToString();
                TextBoxSpecificErr.Text = meterReading.SpecificErr.ToString();
                TextBoxFlowRateValue.Text = meterReading.FlowRateValue.ToString();
                TextBoxAppBusyAlr.Text = meterReading.AppBusyAlr.ToString();
                TextBoxAnyAppErrAlr.Text = meterReading.AnyAppErrorAlr.ToString();
                TextBoxAbnCondAlr.Text = meterReading.AbnormalConditionAlr.ToString();
                TextBoxPermErrAlr.Text = meterReading.PermanentErrorAlr.ToString();
                TextBoxTempErrAlr.Text = meterReading.TemporaryErrorAlr.ToString();
                TextBoxSpecErr1.Text = meterReading.SpecificError1Alr.ToString();
                TextBoxSpecErr2.Text = meterReading.SpecificError2Alr.ToString();
                TextBoxSpecErr3.Text = meterReading.SpecificError3Alr.ToString();
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
                {   //TODO User id for CreatedBy
                    Id = Guid.NewGuid().ToString("N"),
                    SerialNumber = TextBoxSerialNumber.Text,
                    ReadingDate = Convert.ToDateTime(TextBoxReadingDate.Text),
                    CSVType = TextBoxCsvType.Text,
                    ReadingValue = TextBoxReadingValue.Text,
                    Description = TextBoxDescription.Text,
                    LowBatteryAlr = Convert.ToInt32(TextBoxLowBattAlr.Text),
                    LeakAlr = Convert.ToInt32(TextBoxLeakAlr.Text),
                    MagneticTamperAlr = Convert.ToInt32(TextBoxMagneticTmprAlr.Text),
                    MeterErrorAlr = Convert.ToInt32(TextBoxErrorAlr.Text),
                    BackFlowAlr = Convert.ToInt32(TextBoxBackflowAlr.Text),
                    BrokenPipeAlr = Convert.ToInt32(TextBoxBrokenPipeAlr.Text),
                    EmptyPipeAlr = Convert.ToInt32(TextBoxEmptyPipeAlr.Text),
                    SpecificErr = Convert.ToInt32(TextBoxSpecificErr.Text),
                    FlowRateValue = Convert.ToInt32(TextBoxFlowRateValue.Text),
                    AppBusyAlr = Convert.ToInt32(TextBoxAppBusyAlr.Text),
                    AnyAppErrorAlr = Convert.ToInt32(TextBoxAnyAppErrAlr.Text),
                    AbnormalConditionAlr = Convert.ToInt32(TextBoxAbnCondAlr.Text),
                    PermanentErrorAlr = Convert.ToInt32(TextBoxPermErrAlr.Text),
                    TemporaryErrorAlr = Convert.ToInt32(TextBoxTempErrAlr.Text),
                    SpecificError1Alr = Convert.ToInt32(TextBoxSpecErr1.Text),
                    SpecificError2Alr = Convert.ToInt32(TextBoxSpecErr2.Text),
                    SpecificError3Alr = Convert.ToInt32(TextBoxSpecErr3.Text),
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
                    CSVType = TextBoxCsvType.Text,
                    ReadingValue = TextBoxReadingValue.Text,
                    Description = TextBoxDescription.Text,
                    LowBatteryAlr = Convert.ToInt32(TextBoxLowBattAlr.Text),
                    LeakAlr = Convert.ToInt32(TextBoxLeakAlr.Text),
                    MagneticTamperAlr = Convert.ToInt32(TextBoxLeakAlr.Text),
                    MeterErrorAlr = Convert.ToInt32(TextBoxErrorAlr.Text),
                    BackFlowAlr = Convert.ToInt32(TextBoxBackflowAlr.Text),
                    BrokenPipeAlr = Convert.ToInt32(TextBoxBrokenPipeAlr.Text),
                    EmptyPipeAlr = Convert.ToInt32(TextBoxEmptyPipeAlr.Text),
                    SpecificErr = Convert.ToInt32(TextBoxSpecificErr.Text),
                    FlowRateValue = Convert.ToInt32(TextBoxFlowRateValue.Text),
                    AppBusyAlr = Convert.ToInt32(TextBoxAppBusyAlr.Text),
                    AnyAppErrorAlr = Convert.ToInt32(TextBoxAnyAppErrAlr.Text),
                    AbnormalConditionAlr = Convert.ToInt32(TextBoxAbnCondAlr.Text),
                    PermanentErrorAlr = Convert.ToInt32(TextBoxPermErrAlr.Text),
                    TemporaryErrorAlr = Convert.ToInt32(TextBoxTempErrAlr.Text),
                    SpecificError1Alr = Convert.ToInt32(TextBoxSpecErr1.Text),
                    SpecificError2Alr = Convert.ToInt32(TextBoxSpecErr2.Text),
                    SpecificError3Alr = Convert.ToInt32(TextBoxSpecErr3.Text),
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
            TextBoxCsvType.Enabled = false;
            TextBoxReadingValue.Enabled = false;
            TextBoxDescription.Enabled = false;
            TextBoxLowBattAlr.Enabled = false;
            TextBoxLeakAlr.Enabled = false;
            TextBoxMagneticTmprAlr.Enabled = false;
            TextBoxErrorAlr.Enabled = false;
            TextBoxBackflowAlr.Enabled = false;
            TextBoxBrokenPipeAlr.Enabled = false;
            TextBoxEmptyPipeAlr.Enabled = false;
            TextBoxSpecificErr.Enabled = false;
            TextBoxFlowRateValue.Enabled = false;
            TextBoxAppBusyAlr.Enabled = false;
            TextBoxAnyAppErrAlr.Enabled = false;
            TextBoxAbnCondAlr.Enabled = false;
            TextBoxPermErrAlr.Enabled = false;
            TextBoxTempErrAlr.Enabled = false;
            TextBoxSpecErr1.Enabled = false;
            TextBoxSpecErr2.Enabled = false;
            TextBoxSpecErr3.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxSerialNumber.Text = "";
            TextBoxReadingDate.Text = "";
            TextBoxCsvType.Text = "";
            TextBoxReadingValue.Text = "";
            TextBoxDescription.Text = "";
            TextBoxLowBattAlr.Text = "";
            TextBoxLeakAlr.Text = "";
            TextBoxMagneticTmprAlr.Text = "";
            TextBoxErrorAlr.Text = "";
            TextBoxBackflowAlr.Text = "";
            TextBoxBrokenPipeAlr.Text = "";
            TextBoxEmptyPipeAlr.Text = "";
            TextBoxSpecificErr.Text = "";
            TextBoxFlowRateValue.Text = "";
            TextBoxAppBusyAlr.Text = "";
            TextBoxAnyAppErrAlr.Text = "";
            TextBoxAbnCondAlr.Text = "";
            TextBoxPermErrAlr.Text = "";
            TextBoxTempErrAlr.Text = "";
            TextBoxSpecErr1.Text = "";
            TextBoxSpecErr2.Text = "";
            TextBoxSpecErr3.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindMeterReadingWithDataGrid();
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
            IInfo info = _meterReading.GetMeterReadingById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.MeterReading).LockCount;
            return lockcount;
        }
        private void BindMeterReadingWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                ReturnInfo getMeterReadingList = _meterReading.GetMeterReadingByDescription(new SmartDB(), TextBoxSearch.Text);
                //bool flag = getCityList.Code == ErrorEnum.NoError;
                List<TMF.Reports.Model.MeterReading> meterReading = (List<TMF.Reports.Model.MeterReading>)getMeterReadingList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.MeterReading>(meterReading);
                var source = new BindingSource(bindingList, null);
                DataGridViewMeterReading.AutoGenerateColumns = false;
                DataGridViewMeterReading.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewMeterReading.CurrentRow.Index + 1} index of {DataGridViewMeterReading.RowCount} records";
            }
            catch (Exception e)
            {
                return;
            }
        }
        #endregion
    }
}
