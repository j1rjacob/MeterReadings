using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.Model;

namespace MeterReports
{
    public partial class MeterSize : Form
    {
        private Label LabelShow;
        private Button ButtonDelete;
        private Button ButtonSave;
        private Button ButtonEdit;
        private Button ButtonNew;
        private Button ButtonSearch;
        private DataGridView DataGridViewMeterSize;
        private TextBox TextBoxDescription;
        private TextBox TextBoxSearch;
        private Label label2;

        private readonly TMF.Reports.BLL.MeterSize _meterSize;
        private readonly CustomUser _currentUser;
        private bool _save;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColDescription;
        private ErrorProvider errorProviderMeterSize;
        private IContainer components;
        private int _meterSizeId;
        public MeterSize(CustomUser currentUser)
        {
            InitializeComponent();
            _meterSize = new TMF.Reports.BLL.MeterSize();
            _currentUser = currentUser;
            _save = true;
            _meterSizeId = 0;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeterSize));
            this.LabelShow = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.DataGridViewMeterSize = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderMeterSize = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMeterSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMeterSize)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.Location = new System.Drawing.Point(16, 176);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(262, 22);
            this.LabelShow.TabIndex = 48;
            this.LabelShow.Text = "SHOWING 1 OF 10 RECORDS";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(501, 108);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(151, 56);
            this.ButtonDelete.TabIndex = 43;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(341, 108);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(151, 56);
            this.ButtonSave.TabIndex = 44;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AutoSize = true;
            this.ButtonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.BackgroundImage")));
            this.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.Location = new System.Drawing.Point(181, 108);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(151, 56);
            this.ButtonEdit.TabIndex = 45;
            this.ButtonEdit.Text = "EDIT";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.AutoSize = true;
            this.ButtonNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNew.BackgroundImage")));
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Location = new System.Drawing.Point(13, 108);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(151, 56);
            this.ButtonNew.TabIndex = 46;
            this.ButtonNew.Text = "NEW";
            this.ButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AutoSize = true;
            this.ButtonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.BackgroundImage")));
            this.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(502, 8);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(151, 56);
            this.ButtonSearch.TabIndex = 47;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // DataGridViewMeterSize
            // 
            this.DataGridViewMeterSize.AllowUserToAddRows = false;
            this.DataGridViewMeterSize.AllowUserToDeleteRows = false;
            this.DataGridViewMeterSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMeterSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColDescription});
            this.DataGridViewMeterSize.Location = new System.Drawing.Point(13, 204);
            this.DataGridViewMeterSize.Name = "DataGridViewMeterSize";
            this.DataGridViewMeterSize.ReadOnly = true;
            this.DataGridViewMeterSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMeterSize.Size = new System.Drawing.Size(640, 150);
            this.DataGridViewMeterSize.TabIndex = 42;
            this.DataGridViewMeterSize.SelectionChanged += new System.EventHandler(this.DataGridViewMeterSize_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColDescription
            // 
            this.ColDescription.DataPropertyName = "Description";
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            this.ColDescription.Width = 500;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(152, 73);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(501, 27);
            this.TextBoxDescription.TabIndex = 39;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(214, 12);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(280, 27);
            this.TextBoxSearch.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "DESCRIPTION";
            // 
            // errorProviderMeterSize
            // 
            this.errorProviderMeterSize.ContainerControl = this;
            // 
            // MeterSize
            // 
            this.ClientSize = new System.Drawing.Size(670, 367);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.DataGridViewMeterSize);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MeterSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meter Size";
            this.Load += new System.EventHandler(this.MeterSize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMeterSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMeterSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void MeterSize_Load(object sender, EventArgs e)
        {
            BindMeterSizeWithDataGrid();
            ResetControls();
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxDescription.Text = "";
            _meterSizeId = 0;
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
                SaveMeterSize();
            else
                EditMeterSize();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text) &&
                _currentUser.Role == "Administrator")
            {
                var deleteMeterSize = _meterSize.Delete(new SmartDB(), _meterSizeId);

                bool flag = deleteMeterSize.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Size Deleted");
                    ResetControls();
                    BindMeterSizeWithDataGrid();
                }
                else
                {
                    MessageBox.Show(deleteMeterSize.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter size to delete.");
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindMeterSizeWithDataGrid();
        }
        private void DataGridViewMeterSize_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewMeterSize.CurrentRow.Index + 1} index of {DataGridViewMeterSize.RowCount} records";

            var meterSizeId = (int)DataGridViewMeterSize.CurrentRow.Cells[0].Value;
            ReturnInfo getMeterSize = _meterSize.GetMeterSizeById(new SmartDB(), meterSizeId);

            bool flag = getMeterSize.Code == ErrorEnum.NoError;

            TMF.Reports.Model.MeterSize meterSize = (TMF.Reports.Model.MeterSize)getMeterSize.BizObject;
            try
            {
                if (meterSize.Id == 0 ? false : true)
                {
                    TextBoxDescription.Text = meterSize.Description;
                    _meterSizeId = meterSize.Id;
                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                return;
            }
        }
        #region PriveteMethod
        private void SaveMeterSize()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                TMF.Reports.Model.MeterSize meterType = new TMF.Reports.Model.MeterSize()
                {   //TODO User id for CreatedBy
                    Description = TextBoxDescription.Text,
                    CreatedBy = _currentUser.Id.ToString(),
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = 0
                };

                var createMeterSize = _meterSize.Create(new SmartDB(), ref meterType);

                bool flag = createMeterSize.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Size Created");
                    ResetControls();
                    BindMeterSizeWithDataGrid();
                }
                else
                {
                    MessageBox.Show(createMeterSize.Message);
                }
            }
            else
                MessageBox.Show("No meter size to save.");
        }
        private void EditMeterSize()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   //Todo EditedBy
                var lockcount = GetLockCount(_meterSizeId);

                TMF.Reports.Model.MeterSize meterSize = new TMF.Reports.Model.MeterSize()
                {
                    Id = _meterSizeId,
                    Description = TextBoxDescription.Text,
                    EditedBy = _currentUser.Id.ToString(),
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = lockcount
                };

                var updateMeterSize = _meterSize.Update(new SmartDB(), meterSize);

                bool flag = updateMeterSize.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Meter Size Updated");
                    ResetControls();
                    BindMeterSizeWithDataGrid();
                }
                else
                {
                    MessageBox.Show(updateMeterSize.Message);
                }
            }
            else
            {
                MessageBox.Show("No meter size to edit.");
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
            BindMeterSizeWithDataGrid();
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
            IInfo info = _meterSize.GetMeterSizeById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.MeterSize).LockCount;
            return lockcount;
        }
        private void BindMeterSizeWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                ReturnInfo getMeterSizeList = _meterSize.GetMeterSizeByDescription(new SmartDB(), TextBoxSearch.Text);
                //bool flag = getCityList.Code == ErrorEnum.NoError;
                List<TMF.Reports.Model.MeterSize> meterSize = (List<TMF.Reports.Model.MeterSize>)getMeterSizeList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.MeterSize>(meterSize);
                var source = new BindingSource(bindingList, null);
                DataGridViewMeterSize.AutoGenerateColumns = false;
                DataGridViewMeterSize.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewMeterSize.CurrentRow.Index + 1} index of {DataGridViewMeterSize.RowCount} records";
            }
            catch (Exception e)
            {
                return;
            }
        }
        #endregion
    }
}
