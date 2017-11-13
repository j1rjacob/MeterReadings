using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class MeterType : Form
    {
        private readonly TMF.Reports.BLL.MeterType _meterType;
        private bool _save;
        private string _meterTypeId;
        public MeterType()
        {
            InitializeComponent();
            _meterType = new TMF.Reports.BLL.MeterType();
            _save = true;
            _meterTypeId = "";
        }
        private void MeterType_Load(object sender, EventArgs e)
        {
            BindMeterTypeWithDataGrid();
            ResetControls();
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxDescription.Text = "";
            _meterTypeId = "";
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
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
                SaveMeterType();
            else
                EditMeterType();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                var deleteMeterType = _meterType.Delete(new SmartDB(), _meterTypeId);

                bool flag = deleteMeterType.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Type Deleted");
                    ResetControls();
                    BindMeterTypeWithDataGrid();
                }
                else
                {
                    MessageBox.Show(deleteMeterType.Message);
                }
            }
            else
                MessageBox.Show("No meter type to delete.");
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindMeterTypeWithDataGrid();
        }
        private void DataGridViewMeterType_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewMeterType.CurrentRow.Index + 1} index of {DataGridViewMeterType.RowCount} records";

            var meterId = DataGridViewMeterType.CurrentRow.Cells[0].Value.ToString();
            ReturnInfo getMeterType = _meterType.GetMeterTypeById(new SmartDB(), meterId);

            bool flag = getMeterType.Code == ErrorEnum.NoError;

            TMF.Reports.Model.MeterType meterType = (TMF.Reports.Model.MeterType)getMeterType.BizObject;
            if (!string.IsNullOrEmpty(meterType.Id))
            {
                TextBoxDescription.Text = meterType.Description;
                _meterTypeId = meterType.Id;
                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;
            }
        }
        #region PriveteMethod
        private void SaveMeterType()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                TMF.Reports.Model.MeterType meterType = new TMF.Reports.Model.MeterType()
                {   //TODO User id for CreatedBy
                    Id = Guid.NewGuid().ToString("N"),
                    Description = TextBoxDescription.Text,
                    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = 0
                };

                var createMeterType = _meterType.Create(new SmartDB(), ref meterType);

                bool flag = createMeterType.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Type Created");
                    ResetControls();
                    BindMeterTypeWithDataGrid();
                }
                else
                {
                    MessageBox.Show(createMeterType.Code.ToString());
                }
            }
            else
                MessageBox.Show("No meter type to save.");
        }
        private void EditMeterType()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   //Todo EditedBy
                var lockcount = GetLockCount(_meterTypeId);

                TMF.Reports.Model.MeterType meterType = new TMF.Reports.Model.MeterType()
                {
                    Id = _meterTypeId,
                    Description = TextBoxDescription.Text,
                    EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = lockcount
                };

                var updateMeterType = _meterType.Update(new SmartDB(), meterType);

                bool flag = updateMeterType.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Type Updated");
                    ResetControls();
                    BindMeterTypeWithDataGrid();
                }
                else
                {
                    MessageBox.Show(updateMeterType.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter type to edit.");
            }
        }
        private void ResetControls()
        {
            TextBoxDescription.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxDescription.Text = "";
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
            IInfo info = _meterType.GetMeterTypeById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.MeterType).LockCount;
            return lockcount;
        }
        private void BindMeterTypeWithDataGrid()
        {   //TODO: Refactor this for reuse.
            ReturnInfo getMeterTypeList = _meterType.GetMeterTypeDescription(new SmartDB(), TextBoxSearch.Text);
            //bool flag = getCityList.Code == ErrorEnum.NoError;
            List<TMF.Reports.Model.MeterType> meterType = (List<TMF.Reports.Model.MeterType>)getMeterTypeList.BizObject;
            var bindingList = new BindingList<TMF.Reports.Model.MeterType>(meterType);
            var source = new BindingSource(bindingList, null);
            DataGridViewMeterType.AutoGenerateColumns = false;
            DataGridViewMeterType.DataSource = source;
            LabelShow.Text = $"Showing {DataGridViewMeterType.CurrentRow.Index + 1} index of {DataGridViewMeterType.RowCount} records";
        }
        #endregion
    }
}
