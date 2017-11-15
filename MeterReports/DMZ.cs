﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class DMZ : Form
    {
        private Label LabelShow;
        private Button ButtonDelete;
        private Button ButtonSave;
        private Button ButtonEdit;
        private Button ButtonNew;
        private Button ButtonSearch;
        private DataGridView DataGridViewDMZ;
        private TextBox TextBoxTotalMeters;
        private TextBox TextBoxSearch;
        private TextBox TextBoxDescription;
        private Label label2;
        private Label label3;
        private ComboBox ComboBoxCity;
        private Label label1;

        private readonly TMF.Reports.BLL.DMZ _dmz;
        private readonly TMF.Reports.BLL.City _city;
        private bool _save;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColDescription;
        private DataGridViewTextBoxColumn ColCity;
        private DataGridViewTextBoxColumn ColTotMeter;
        private int _dmzId;
        public DMZ()
        {
            InitializeComponent();
            _dmz = new TMF.Reports.BLL.DMZ();
            _city = new TMF.Reports.BLL.City();
            _save = true;
            _dmzId = 0;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMZ));
            this.LabelShow = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.DataGridViewDMZ = new System.Windows.Forms.DataGridView();
            this.TextBoxTotalMeters = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDMZ)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.Location = new System.Drawing.Point(19, 240);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(262, 22);
            this.LabelShow.TabIndex = 36;
            this.LabelShow.Text = "SHOWING 1 OF 10 RECORDS";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(504, 166);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(151, 56);
            this.ButtonDelete.TabIndex = 31;
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
            this.ButtonSave.Location = new System.Drawing.Point(344, 167);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(151, 56);
            this.ButtonSave.TabIndex = 32;
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
            this.ButtonEdit.Location = new System.Drawing.Point(184, 167);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(151, 56);
            this.ButtonEdit.TabIndex = 33;
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
            this.ButtonNew.Location = new System.Drawing.Point(16, 167);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(151, 56);
            this.ButtonNew.TabIndex = 34;
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
            this.ButtonSearch.Location = new System.Drawing.Point(505, 4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(151, 56);
            this.ButtonSearch.TabIndex = 35;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // DataGridViewDMZ
            // 
            this.DataGridViewDMZ.AllowUserToAddRows = false;
            this.DataGridViewDMZ.AllowUserToDeleteRows = false;
            this.DataGridViewDMZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDMZ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColDescription,
            this.ColCity,
            this.ColTotMeter});
            this.DataGridViewDMZ.Location = new System.Drawing.Point(16, 268);
            this.DataGridViewDMZ.MultiSelect = false;
            this.DataGridViewDMZ.Name = "DataGridViewDMZ";
            this.DataGridViewDMZ.ReadOnly = true;
            this.DataGridViewDMZ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDMZ.Size = new System.Drawing.Size(640, 150);
            this.DataGridViewDMZ.TabIndex = 30;
            this.DataGridViewDMZ.SelectionChanged += new System.EventHandler(this.DataGridViewDMZ_SelectionChanged);
            // 
            // TextBoxTotalMeters
            // 
            this.TextBoxTotalMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTotalMeters.Location = new System.Drawing.Point(280, 132);
            this.TextBoxTotalMeters.Name = "TextBoxTotalMeters";
            this.TextBoxTotalMeters.Size = new System.Drawing.Size(376, 27);
            this.TextBoxTotalMeters.TabIndex = 27;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(217, 8);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(280, 27);
            this.TextBoxSearch.TabIndex = 28;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(280, 66);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(376, 27);
            this.TextBoxDescription.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "TOTAL NUMBER OF METERS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "DESCRIPTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "CITY";
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Location = new System.Drawing.Point(280, 98);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.Size = new System.Drawing.Size(376, 28);
            this.ComboBoxCity.TabIndex = 37;
            this.ComboBoxCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxCity_MouseClick);
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
            this.ColDescription.Width = 200;
            // 
            // ColCity
            // 
            this.ColCity.DataPropertyName = "CityId";
            this.ColCity.HeaderText = "City";
            this.ColCity.Name = "ColCity";
            this.ColCity.ReadOnly = true;
            this.ColCity.Visible = false;
            // 
            // ColTotMeter
            // 
            this.ColTotMeter.DataPropertyName = "TotalNumberOfMeters";
            this.ColTotMeter.HeaderText = "Total Number of Meters";
            this.ColTotMeter.Name = "ColTotMeter";
            this.ColTotMeter.ReadOnly = true;
            this.ColTotMeter.Width = 200;
            // 
            // DMZ
            // 
            this.ClientSize = new System.Drawing.Size(670, 428);
            this.Controls.Add(this.ComboBoxCity);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.DataGridViewDMZ);
            this.Controls.Add(this.TextBoxTotalMeters);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DMZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMZ";
            this.Load += new System.EventHandler(this.DMZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDMZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DMZ_Load(object sender, EventArgs e)
        {
            BindDMZWithDataGrid();
            ResetControls();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ComboBoxCity.Enabled = true;
            TextBoxTotalMeters.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxDescription.Text = "";
            ComboBoxCity.Items.Clear();
            TextBoxTotalMeters.Text = "";
            _dmzId = 0;
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            ComboBoxCity.Enabled = true;
            TextBoxTotalMeters.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = true;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            _save = false;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
                SaveDMZ();
            else
                EditDMZ();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                var deleteDMZ = _dmz.Delete(new SmartDB(), _dmzId);

                bool flag = deleteDMZ.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("DMZ Deleted");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show(deleteDMZ.Message);
                }
            }
            else
            {
                MessageBox.Show("No DMZ to delete.");
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindDMZWithDataGrid();
        }
        private void DataGridViewDMZ_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewDMZ.CurrentRow.Index + 1} index of {DataGridViewDMZ.RowCount} records";

            var dmzId = (int)DataGridViewDMZ.CurrentRow.Cells[0].Value;
            ReturnInfo getDMZ = _dmz.GetDMZById(new SmartDB(), dmzId);

            bool flag = getDMZ.Code == ErrorEnum.NoError;

            TMF.Reports.Model.DMZ dmz = (TMF.Reports.Model.DMZ)getDMZ.BizObject;
            
            try
            {
                ReturnInfo getCity = _city.GetCityById(new SmartDB(), dmz.CityId.Trim());
                TMF.Reports.Model.City city = (TMF.Reports.Model.City)getCity.BizObject;

                if (dmz.Id == 0 ? false : true)
                {
                    TextBoxDescription.Text = dmz.Description;
                    ComboBoxCity.Text = city.Description;
                    TextBoxTotalMeters.Text = dmz.TotalNumberOfMeters.ToString();
                    _dmzId = dmz.Id;
                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void ComboBoxCity_MouseClick(object sender, MouseEventArgs e)
        {
            GetCities();
        }
        #region PriveteMethod
        private void SaveDMZ()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                TMF.Reports.Model.DMZ dmz = new TMF.Reports.Model.DMZ()
                {   //TODO User id for CreatedBy
                    Description = TextBoxDescription.Text,
                    CityId = ComboBoxCity.Text,
                    TotalNumberOfMeters = Convert.ToInt32(TextBoxTotalMeters.Text),
                    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = 0
                };

                var createDMZ = _dmz.Create(new SmartDB(), ref dmz);

                bool flag = createDMZ.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("DMZ Created");
                    ResetControls();
                    BindDMZWithDataGrid();
                }
                else
                {
                    MessageBox.Show(createDMZ.Code.ToString());
                }
            }
            else
                MessageBox.Show("No DMZ to save.");
        }
        private void EditDMZ()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   //Todo EditedBy
                var lockcount = GetLockCount(_dmzId);

                TMF.Reports.Model.DMZ dmz = new TMF.Reports.Model.DMZ()
                {
                    Id = _dmzId,
                    Description = TextBoxDescription.Text,
                    CityId = ComboBoxCity.Text,
                    TotalNumberOfMeters = Convert.ToInt32(TextBoxTotalMeters.Text),
                    EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = lockcount
                };

                var updateDMZ = _dmz.Update(new SmartDB(), dmz);

                bool flag = updateDMZ.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("DMZ Updated");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show(updateDMZ.Message);
                }
            }
            else
            {
                MessageBox.Show("No DMZ to edit.");
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
        private void ResetControls()
        {
            TextBoxDescription.Enabled = false;
            ComboBoxCity.Enabled = false;
            TextBoxTotalMeters.Enabled = false;
            TextBoxSearch.Text = "";
            ComboBoxCity.Items.Clear();
            TextBoxDescription.Text = "";
            TextBoxTotalMeters.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindDMZWithDataGrid();
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
            IInfo info = _dmz.GetDMZById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.DMZ).LockCount;
            return lockcount;
        }
        private void BindDMZWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                ReturnInfo getDMZList = _dmz.GetDMZByDescription(new SmartDB(), TextBoxSearch.Text);
                //bool flag = getCityList.Code == ErrorEnum.NoError;
                List<TMF.Reports.Model.DMZ> dmz = (List<TMF.Reports.Model.DMZ>)getDMZList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.DMZ>(dmz);
                var source = new BindingSource(bindingList, null);
                DataGridViewDMZ.AutoGenerateColumns = false;
                DataGridViewDMZ.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewDMZ.CurrentRow.Index + 1} index of {DataGridViewDMZ.RowCount} records";
            }
            catch (Exception e)
            {
                return;
            }
        }
        #endregion
    }
}
