namespace MeterReports
{
    partial class Meter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meter));
            this.DateTimePickerMaintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerInstallationDate = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxDMZ = new System.Windows.Forms.ComboBox();
            this.ComboBoxMeterProtocol = new System.Windows.Forms.ComboBox();
            this.ComboBoxMeterType = new System.Windows.Forms.ComboBox();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.LabelShow = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.DataGridViewMeter = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstallationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaintenanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMeterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMeterSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMeterProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDMZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextBoxHCN = new System.Windows.Forms.TextBox();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.ComboBoxMeterSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMeter)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePickerMaintenanceDate
            // 
            this.DateTimePickerMaintenanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerMaintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerMaintenanceDate.Location = new System.Drawing.Point(672, 80);
            this.DateTimePickerMaintenanceDate.Name = "DateTimePickerMaintenanceDate";
            this.DateTimePickerMaintenanceDate.Size = new System.Drawing.Size(216, 27);
            this.DateTimePickerMaintenanceDate.TabIndex = 56;
            // 
            // DateTimePickerInstallationDate
            // 
            this.DateTimePickerInstallationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerInstallationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerInstallationDate.Location = new System.Drawing.Point(216, 240);
            this.DateTimePickerInstallationDate.Name = "DateTimePickerInstallationDate";
            this.DateTimePickerInstallationDate.Size = new System.Drawing.Size(216, 27);
            this.DateTimePickerInstallationDate.TabIndex = 55;
            // 
            // ComboBoxDMZ
            // 
            this.ComboBoxDMZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDMZ.FormattingEnabled = true;
            this.ComboBoxDMZ.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxDMZ.Location = new System.Drawing.Point(672, 208);
            this.ComboBoxDMZ.Name = "ComboBoxDMZ";
            this.ComboBoxDMZ.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxDMZ.TabIndex = 54;
            this.ComboBoxDMZ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxDMZ_MouseClick);
            // 
            // ComboBoxMeterProtocol
            // 
            this.ComboBoxMeterProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMeterProtocol.FormattingEnabled = true;
            this.ComboBoxMeterProtocol.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxMeterProtocol.Location = new System.Drawing.Point(672, 176);
            this.ComboBoxMeterProtocol.Name = "ComboBoxMeterProtocol";
            this.ComboBoxMeterProtocol.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxMeterProtocol.TabIndex = 53;
            this.ComboBoxMeterProtocol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxMeterProtocol_MouseClick);
            // 
            // ComboBoxMeterType
            // 
            this.ComboBoxMeterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMeterType.FormattingEnabled = true;
            this.ComboBoxMeterType.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxMeterType.Location = new System.Drawing.Point(672, 112);
            this.ComboBoxMeterType.Name = "ComboBoxMeterType";
            this.ComboBoxMeterType.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxMeterType.TabIndex = 52;
            this.ComboBoxMeterType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxMeterType_MouseClick);
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxStatus.Location = new System.Drawing.Point(216, 176);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxStatus.TabIndex = 51;
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.Location = new System.Drawing.Point(16, 344);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(262, 22);
            this.LabelShow.TabIndex = 50;
            this.LabelShow.Text = "SHOWING 1 OF 10 RECORDS";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(632, 277);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(151, 56);
            this.ButtonDelete.TabIndex = 45;
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
            this.ButtonSave.Location = new System.Drawing.Point(472, 277);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(151, 56);
            this.ButtonSave.TabIndex = 46;
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
            this.ButtonEdit.Location = new System.Drawing.Point(312, 277);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(151, 56);
            this.ButtonEdit.TabIndex = 47;
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
            this.ButtonNew.Location = new System.Drawing.Point(144, 277);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(151, 56);
            this.ButtonNew.TabIndex = 48;
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
            this.ButtonSearch.Location = new System.Drawing.Point(736, 8);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(151, 56);
            this.ButtonSearch.TabIndex = 49;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // DataGridViewMeter
            // 
            this.DataGridViewMeter.AllowUserToAddRows = false;
            this.DataGridViewMeter.AllowUserToDeleteRows = false;
            this.DataGridViewMeter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMeter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColSerialNumber,
            this.ColX,
            this.ColY,
            this.ColStatus,
            this.ColHCN,
            this.ColInstallationDate,
            this.ColMaintenanceDate,
            this.ColMeterType,
            this.ColMeterSize,
            this.ColMeterProtocol,
            this.ColDMZ,
            this.ColCity});
            this.DataGridViewMeter.Location = new System.Drawing.Point(16, 372);
            this.DataGridViewMeter.Name = "DataGridViewMeter";
            this.DataGridViewMeter.ReadOnly = true;
            this.DataGridViewMeter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMeter.Size = new System.Drawing.Size(872, 150);
            this.DataGridViewMeter.TabIndex = 44;
            this.DataGridViewMeter.SelectionChanged += new System.EventHandler(this.DataGridViewMeter_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColSerialNumber
            // 
            this.ColSerialNumber.DataPropertyName = "SerialNumber";
            this.ColSerialNumber.HeaderText = "SerialNumber";
            this.ColSerialNumber.Name = "ColSerialNumber";
            this.ColSerialNumber.ReadOnly = true;
            // 
            // ColX
            // 
            this.ColX.DataPropertyName = "X";
            this.ColX.HeaderText = "X";
            this.ColX.Name = "ColX";
            this.ColX.ReadOnly = true;
            // 
            // ColY
            // 
            this.ColY.DataPropertyName = "Y";
            this.ColY.HeaderText = "Y";
            this.ColY.Name = "ColY";
            this.ColY.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // ColHCN
            // 
            this.ColHCN.DataPropertyName = "HCN";
            this.ColHCN.HeaderText = "HCN";
            this.ColHCN.Name = "ColHCN";
            this.ColHCN.ReadOnly = true;
            // 
            // ColInstallationDate
            // 
            this.ColInstallationDate.DataPropertyName = "InstallationDate";
            this.ColInstallationDate.HeaderText = "InstallationDate";
            this.ColInstallationDate.Name = "ColInstallationDate";
            this.ColInstallationDate.ReadOnly = true;
            // 
            // ColMaintenanceDate
            // 
            this.ColMaintenanceDate.DataPropertyName = "MaintenanceDate";
            this.ColMaintenanceDate.HeaderText = "MaintenanceDate";
            this.ColMaintenanceDate.Name = "ColMaintenanceDate";
            this.ColMaintenanceDate.ReadOnly = true;
            // 
            // ColMeterType
            // 
            this.ColMeterType.DataPropertyName = "MeterType";
            this.ColMeterType.HeaderText = "MeterType";
            this.ColMeterType.Name = "ColMeterType";
            this.ColMeterType.ReadOnly = true;
            this.ColMeterType.Visible = false;
            // 
            // ColMeterSize
            // 
            this.ColMeterSize.DataPropertyName = "MeterSize";
            this.ColMeterSize.HeaderText = "MeterSize";
            this.ColMeterSize.Name = "ColMeterSize";
            this.ColMeterSize.ReadOnly = true;
            this.ColMeterSize.Visible = false;
            // 
            // ColMeterProtocol
            // 
            this.ColMeterProtocol.DataPropertyName = "MeterProtocol";
            this.ColMeterProtocol.HeaderText = "MeterProtocol";
            this.ColMeterProtocol.Name = "ColMeterProtocol";
            this.ColMeterProtocol.ReadOnly = true;
            this.ColMeterProtocol.Visible = false;
            // 
            // ColDMZ
            // 
            this.ColDMZ.DataPropertyName = "DMZ";
            this.ColDMZ.HeaderText = "DMZ";
            this.ColDMZ.Name = "ColDMZ";
            this.ColDMZ.ReadOnly = true;
            this.ColDMZ.Visible = false;
            // 
            // ColCity
            // 
            this.ColCity.DataPropertyName = "City";
            this.ColCity.HeaderText = "City";
            this.ColCity.Name = "ColCity";
            this.ColCity.ReadOnly = true;
            this.ColCity.Visible = false;
            // 
            // TextBoxX
            // 
            this.TextBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxX.Location = new System.Drawing.Point(216, 114);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(216, 27);
            this.TextBoxX.TabIndex = 38;
            // 
            // TextBoxHCN
            // 
            this.TextBoxHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHCN.Location = new System.Drawing.Point(216, 209);
            this.TextBoxHCN.Name = "TextBoxHCN";
            this.TextBoxHCN.Size = new System.Drawing.Size(216, 27);
            this.TextBoxHCN.TabIndex = 40;
            // 
            // TextBoxY
            // 
            this.TextBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxY.Location = new System.Drawing.Point(216, 145);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(216, 27);
            this.TextBoxY.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "MAINTENANCE DATE";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(336, 8);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(384, 27);
            this.TextBoxSearch.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "INSTALLATION DATE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(616, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 22);
            this.label12.TabIndex = 34;
            this.label12.Text = "DMZ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(488, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 22);
            this.label11.TabIndex = 33;
            this.label11.Text = "METER PROTOCOL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(536, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "METER TYPE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(549, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "METER SIZE";
            // 
            // TextBoxSerialNumber
            // 
            this.TextBoxSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSerialNumber.Location = new System.Drawing.Point(216, 82);
            this.TextBoxSerialNumber.Name = "TextBoxSerialNumber";
            this.TextBoxSerialNumber.Size = new System.Drawing.Size(216, 27);
            this.TextBoxSerialNumber.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "HCN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "STATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "SERIAL NUMBER";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(616, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 22);
            this.label13.TabIndex = 34;
            this.label13.Text = "CITY";
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxCity.Location = new System.Drawing.Point(672, 240);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxCity.TabIndex = 54;
            this.ComboBoxCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxCity_MouseClick);
            // 
            // ComboBoxMeterSize
            // 
            this.ComboBoxMeterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMeterSize.FormattingEnabled = true;
            this.ComboBoxMeterSize.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxMeterSize.Location = new System.Drawing.Point(672, 144);
            this.ComboBoxMeterSize.Name = "ComboBoxMeterSize";
            this.ComboBoxMeterSize.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxMeterSize.TabIndex = 52;
            this.ComboBoxMeterSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxMeterSize_MouseClick);
            // 
            // Meter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 532);
            this.Controls.Add(this.DateTimePickerMaintenanceDate);
            this.Controls.Add(this.DateTimePickerInstallationDate);
            this.Controls.Add(this.ComboBoxCity);
            this.Controls.Add(this.ComboBoxDMZ);
            this.Controls.Add(this.ComboBoxMeterProtocol);
            this.Controls.Add(this.ComboBoxMeterSize);
            this.Controls.Add(this.ComboBoxMeterType);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.DataGridViewMeter);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.TextBoxHCN);
            this.Controls.Add(this.TextBoxY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxSerialNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Meter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meter";
            this.Load += new System.EventHandler(this.Meter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMeter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerMaintenanceDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerInstallationDate;
        private System.Windows.Forms.ComboBox ComboBoxDMZ;
        private System.Windows.Forms.ComboBox ComboBoxMeterProtocol;
        private System.Windows.Forms.ComboBox ComboBoxMeterType;
        private System.Windows.Forms.ComboBox ComboBoxStatus;
        private System.Windows.Forms.Label LabelShow;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridView DataGridViewMeter;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.TextBox TextBoxHCN;
        private System.Windows.Forms.TextBox TextBoxY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxSerialNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboBoxCity;
        private System.Windows.Forms.ComboBox ComboBoxMeterSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstallationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaintenanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMeterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMeterSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMeterProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDMZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCity;
    }
}