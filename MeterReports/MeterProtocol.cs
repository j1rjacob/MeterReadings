using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class MeterProtocol : Form
    {
        private readonly TMF.Reports.BLL.MeterProtocol _meterProtocol;
        private bool _save;
        private int _meterProtocolId;
        public MeterProtocol()
        {
            InitializeComponent();
            _meterProtocol = new TMF.Reports.BLL.MeterProtocol();
            _save = true;
            _meterProtocolId = 0;
        }

        private void MeterProtocol_Load(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxDescription.Text = "";
            _meterProtocolId = 0;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = true;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            _save = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
                SaveMeterProtocol();
            else
                EditMeterProtocol();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                var deleteMeterProtocol = _meterProtocol.Delete(new SmartDB(), _meterProtocolId);

                bool flag = deleteMeterProtocol.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Protocol Deleted");
                    ResetControls();
                    BindMeterProtocolWithDataGrid();
                }
                else
                {
                    MessageBox.Show(deleteMeterProtocol.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter protocol to delete.");
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindMeterProtocolWithDataGrid();
        }

        private void DataGridViewMeterProtocol_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewMeterProtocol.CurrentRow.Index + 1} index of {DataGridViewMeterProtocol.RowCount} records";

            var meterProtocolId = (int)DataGridViewMeterProtocol.CurrentRow.Cells[0].Value;
            ReturnInfo getMeterProtocol = _meterProtocol.GetMeterProtocolById(new SmartDB(), meterProtocolId);

            bool flag = getMeterProtocol.Code == ErrorEnum.NoError;

            try
            {
                TMF.Reports.Model.MeterProtocol meterProtocol = (TMF.Reports.Model.MeterProtocol)getMeterProtocol.BizObject;
                if (meterProtocol.Id == 0 ? false : true)
                {
                    TextBoxDescription.Text = meterProtocol.Description;
                    _meterProtocolId = meterProtocol.Id;
                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #region PriveteMethod
        private void SaveMeterProtocol()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                TMF.Reports.Model.MeterProtocol meterProtocol = new TMF.Reports.Model.MeterProtocol()
                {   //TODO User id for CreatedBy
                    Description = TextBoxDescription.Text,
                    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = 0
                };

                var createMeterProtocol = _meterProtocol.Create(new SmartDB(), ref meterProtocol);

                bool flag = createMeterProtocol.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Protocol Created");
                    ResetControls();
                    BindMeterProtocolWithDataGrid();
                }
                else
                {
                    MessageBox.Show(createMeterProtocol.Message);
                }
            }
            else
                MessageBox.Show("No meter protocol to save.");
        }
        private void EditMeterProtocol()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   //Todo EditedBy
                var lockcount = GetLockCount(_meterProtocolId);

                TMF.Reports.Model.MeterProtocol meterProtocol = new TMF.Reports.Model.MeterProtocol()
                {
                    Id = _meterProtocolId,
                    Description = TextBoxDescription.Text,
                    EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = lockcount
                };

                var updateMeterProtocol = _meterProtocol.Update(new SmartDB(), meterProtocol);

                bool flag = updateMeterProtocol.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Protocol Updated");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show(updateMeterProtocol.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter protocol to edit.");
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
            BindMeterProtocolWithDataGrid();
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
        private int GetLockCount(int Id)
        {
            IInfo info = _meterProtocol.GetMeterProtocolById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.MeterProtocol).LockCount;
            return lockcount;
        }
        private void BindMeterProtocolWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                ReturnInfo getMeterProtocolList = _meterProtocol.GetMeterProtocolByDescription(new SmartDB(), TextBoxSearch.Text);
                //bool flag = getCityList.Code == ErrorEnum.NoError;
                List<TMF.Reports.Model.MeterProtocol> meterProtocol = (List<TMF.Reports.Model.MeterProtocol>)getMeterProtocolList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.MeterProtocol>(meterProtocol);
                var source = new BindingSource(bindingList, null);
                DataGridViewMeterProtocol.AutoGenerateColumns = false;
                DataGridViewMeterProtocol.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewMeterProtocol.CurrentRow.Index + 1} index of {DataGridViewMeterProtocol.RowCount} records";
            }
            catch (Exception e)
            {
                return;
            }
        }
        #endregion
    }
}
