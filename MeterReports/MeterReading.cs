using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class MeterReading : Form
    {
        private readonly TMF.Reports.BLL.MeterReading _meterReading;
        private bool _save;
        private string _meterReadingId;
        public MeterReading()
        {
            InitializeComponent();
            _meterReading = new TMF.Reports.BLL.MeterReading();
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
            TextBoxDescription.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxDescription.Text = "";
            //TextBoxTotalMeters.Text = "";
            _meterReadingId = "";
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
                //TextBoxTotalMeters.Text = meterReading.TotalNumberOfMeters.ToString();
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
                    //TotalNumberOfMeters = 0,
                    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
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
                    EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
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
            TextBoxSearch.Text = "";
            TextBoxDescription.Text = "";
            //TextBoxTotalMeters.Text = "";
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
            IInfo info = _meterReading.GetMeterReadingById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.MeterReading).LockCount;
            return lockcount;
        }
        private void BindMeterReadingWithDataGrid()
        {   //TODO: Refactor this for reuse.
            ReturnInfo getMeterReadingList = _meterReading.GetMeterReadingByDescription(new SmartDB(), TextBoxSearch.Text);
            //bool flag = getCityList.Code == ErrorEnum.NoError;
            List<TMF.Reports.Model.MeterReading> meterReading = (List<TMF.Reports.Model.MeterReading>)getMeterReadingList.BizObject;
            var bindingList = new BindingList<TMF.Reports.Model.MeterReading>(meterReading);
            var source = new BindingSource(bindingList, null);
            DataGridViewMeterReading.AutoGenerateColumns = false;
            DataGridViewMeterReading.DataSource = source;
            LabelShow.Text = $"Showing {DataGridViewMeterReading.CurrentRow.Index + 1} index of {DataGridViewMeterReading.RowCount} records";
        }
        #endregion
    }
}
