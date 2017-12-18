using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.Model;

namespace MeterReports
{
    public partial class MeterType : Form
    {
        private readonly TMF.Reports.BLL.MeterType _meterType;
        private readonly CustomUser _currentUser;
        private bool _save;
        private int _meterTypeId;
        public MeterType(CustomUser currentUser)
        {
            InitializeComponent();
            _meterType = new TMF.Reports.BLL.MeterType();
            _currentUser = currentUser;
            _save = true;
            _meterTypeId = 0;
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
            _meterTypeId = 0;
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
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text) &&
                _currentUser.Role == "Administrator")
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
                MessageBox.Show("No meter type to delete or Contact Admin.");
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindMeterTypeWithDataGrid();
        }
        private void DataGridViewMeterType_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewMeterType.CurrentRow.Index + 1} index of {DataGridViewMeterType.RowCount} records";

            int meterId;
            try
            {
                meterId = (int)DataGridViewMeterType.CurrentRow.Cells[0].Value;
            }
            catch (Exception ex)
            {
                return;
            }
            ReturnInfo getMeterType = _meterType.GetMeterTypeById(new SmartDB(), meterId);

            bool flag = getMeterType.Code == ErrorEnum.NoError;

            TMF.Reports.Model.MeterType meterType = (TMF.Reports.Model.MeterType)getMeterType.BizObject;

            try
            {
                if (meterType.Id == 0 ? false : true)
                {
                    TextBoxDescription.Text = meterType.Description;
                    _meterTypeId = meterType.Id;
                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        #region PriveteMethod
        private void SaveMeterType()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                TMF.Reports.Model.MeterType meterType = new TMF.Reports.Model.MeterType()
                {   
                    Description = TextBoxDescription.Text,
                    CreatedBy = _currentUser.Id.ToString(),
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
                MessageBox.Show("No meter type to save or Contact Admin.");
        }
        private void EditMeterType()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   
                var lockcount = GetLockCount(_meterTypeId);

                TMF.Reports.Model.MeterType meterType = new TMF.Reports.Model.MeterType()
                {
                    Id = _meterTypeId,
                    Description = TextBoxDescription.Text,
                    EditedBy = _currentUser.Id.ToString(),
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
                MessageBox.Show("No meter type to edit or Contact Admin.");
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
            BindMeterTypeWithDataGrid();
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
        private int GetLockCount(int Id)
        {
            IInfo info = _meterType.GetMeterTypeById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.MeterType).LockCount;
            return lockcount;
        }
        private void BindMeterTypeWithDataGrid()
        {   //TODO: Refactor this for reuse.
            ReturnInfo getMeterTypeList = _meterType.GetMeterTypeDescription(new SmartDB(), TextBoxSearch.Text);
            
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
