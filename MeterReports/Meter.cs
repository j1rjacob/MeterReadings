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
        private bool _save;
        private string _meterId;
        public Meter()
        {
            InitializeComponent();
            _meter = new TMF.Reports.BLL.Meter();
            _save = true;
            _meterId = "";
        }

        private void Meter_Load(object sender, EventArgs e)
        {
            BindMeterWithDataGrid();
            ResetControls();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxSerialNumber.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxSerialNumber.Text = "";
            TextBoxX.Text = "";
            _meterId = "";
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxSerialNumber.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = false;
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

            TMF.Reports.Model.Meter meter = (TMF.Reports.Model.Meter)getMeter.BizObject;
            if (!string.IsNullOrEmpty(meter.Id))
            {
                TextBoxSerialNumber.Text = meter.SerialNumber;
                //TextBoxTotalMeters.Text = meter.TotalNumberOfMeters.ToString();
                _meterId = meter.Id;
                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;
            }
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
                    //TotalNumberOfMeters = 0,
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
        private void ResetControls()
        {
            TextBoxSerialNumber.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxSerialNumber.Text = "";
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
            IInfo info = _meter.GetMeterById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.Meter).LockCount;
            return lockcount;
        }
        private void BindMeterWithDataGrid()
        {   //TODO: Refactor this for reuse.
            ReturnInfo getMeterList = _meter.GetMeterByDescription(new SmartDB(), TextBoxSearch.Text);
            //bool flag = getCityList.Code == ErrorEnum.NoError;
            List<TMF.Reports.Model.Meter> meter = (List<TMF.Reports.Model.Meter>)getMeterList.BizObject;
            var bindingList = new BindingList<TMF.Reports.Model.Meter>(meter);
            var source = new BindingSource(bindingList, null);
            DataGridViewMeter.AutoGenerateColumns = false;
            DataGridViewMeter.DataSource = source;
            LabelShow.Text = $"Showing {DataGridViewMeter.CurrentRow.Index + 1} index of {DataGridViewMeter.RowCount} records";
        }
        #endregion
    }
}
