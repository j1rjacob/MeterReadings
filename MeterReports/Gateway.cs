using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.Model;
using TMF.Reports.UTIL;

namespace MeterReports
{
    public partial class Gateway : Form
    {
        private Label LabelShow;
        private Button ButtonDelete;
        private Button ButtonSave;
        private Button ButtonEdit;
        private Button ButtonNew;
        private Button ButtonSearch;
        private DataGridView DataGridViewGateway;
        private TextBox TextBoxSimCard;
        private TextBox TextBoxX;
        private TextBox TextBoxSearch;
        private TextBox TextBoxMac;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox TextBoxDescription;
        private Label label7;
        private DateTimePicker DateTimePickerInstallationDate;
        private Label label8;
        private Label label9;
        private DateTimePicker DateTimePickerMaintenanceDate;
        private ComboBox ComboBoxStatus;
        private Label label10;
        private TextBox TextBoxIPAddress;
        private Label label11;
        private ComboBox ComboBoxDMZ;
        private Label label12;
        private ComboBox ComboBoxCity;
        private TextBox TextBoxY;
        private Label label1;

        private readonly TMF.Reports.BLL.Gateway _gateway;
        private bool _save;


        private string _gatewayMac;
        private readonly TMF.Reports.BLL.DMZ _dmz;
        private readonly TMF.Reports.BLL.City _city;
        private Button ButtonExport;
        private Button ButtonImport;
        private OpenFileDialog openFileDialogGateway;
        private SaveFileDialog saveFileDialogGateway;
        private DataGridViewTextBoxColumn ColMacAddress;
        private DataGridViewTextBoxColumn ColX;
        private DataGridViewTextBoxColumn ColY;
        private DataGridViewTextBoxColumn ColDescription;
        private DataGridViewTextBoxColumn ColInstallationDate;
        private DataGridViewTextBoxColumn ColMaintenanceDate;
        private DataGridViewTextBoxColumn ColStatus;
        private DataGridViewTextBoxColumn ColIPAddress;
        private DataGridViewTextBoxColumn ColDMZ;
        private DataGridViewTextBoxColumn ColCity;
        private ErrorProvider errorProviderGateway;
        private IContainer components;
        private readonly CustomUser _currentUser;
        public Gateway(CustomUser currentUser)
        {
            InitializeComponent();
            _gateway = new TMF.Reports.BLL.Gateway();
            _currentUser = currentUser;
            _dmz = new TMF.Reports.BLL.DMZ();
            _city = new TMF.Reports.BLL.City();
            _save = true;
            _gatewayMac = "";
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gateway));
            this.LabelShow = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.DataGridViewGateway = new System.Windows.Forms.DataGridView();
            this.ColMacAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstallationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaintenanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDMZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxSimCard = new System.Windows.Forms.TextBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TextBoxMac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePickerInstallationDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTimePickerMaintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxIPAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBoxDMZ = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.openFileDialogGateway = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogGateway = new System.Windows.Forms.SaveFileDialog();
            this.errorProviderGateway = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGateway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGateway)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.Location = new System.Drawing.Point(16, 328);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(262, 22);
            this.LabelShow.TabIndex = 24;
            this.LabelShow.Text = "SHOWING 1 OF 10 RECORDS";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(459, 265);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(136, 56);
            this.ButtonDelete.TabIndex = 19;
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
            this.ButtonSave.Location = new System.Drawing.Point(315, 265);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(136, 56);
            this.ButtonSave.TabIndex = 20;
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
            this.ButtonEdit.Location = new System.Drawing.Point(171, 265);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(136, 56);
            this.ButtonEdit.TabIndex = 21;
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
            this.ButtonNew.Location = new System.Drawing.Point(27, 265);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(136, 56);
            this.ButtonNew.TabIndex = 22;
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
            this.ButtonSearch.TabIndex = 23;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // DataGridViewGateway
            // 
            this.DataGridViewGateway.AllowUserToAddRows = false;
            this.DataGridViewGateway.AllowUserToDeleteRows = false;
            this.DataGridViewGateway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewGateway.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMacAddress,
            this.ColX,
            this.ColY,
            this.ColDescription,
            this.ColInstallationDate,
            this.ColMaintenanceDate,
            this.ColStatus,
            this.ColIPAddress,
            this.ColDMZ,
            this.ColCity});
            this.DataGridViewGateway.Location = new System.Drawing.Point(16, 352);
            this.DataGridViewGateway.Name = "DataGridViewGateway";
            this.DataGridViewGateway.ReadOnly = true;
            this.DataGridViewGateway.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewGateway.Size = new System.Drawing.Size(872, 150);
            this.DataGridViewGateway.TabIndex = 18;
            this.DataGridViewGateway.SelectionChanged += new System.EventHandler(this.DataGridViewGateway_SelectionChanged);
            // 
            // ColMacAddress
            // 
            this.ColMacAddress.DataPropertyName = "MacAddress";
            this.ColMacAddress.HeaderText = "MacAddress";
            this.ColMacAddress.Name = "ColMacAddress";
            this.ColMacAddress.ReadOnly = true;
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
            // ColDescription
            // 
            this.ColDescription.DataPropertyName = "Description";
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            // 
            // ColInstallationDate
            // 
            this.ColInstallationDate.DataPropertyName = "InstallationDate";
            this.ColInstallationDate.HeaderText = "Installation Date";
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
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // ColIPAddress
            // 
            this.ColIPAddress.DataPropertyName = "IPAddress";
            this.ColIPAddress.HeaderText = "IPAddress";
            this.ColIPAddress.Name = "ColIPAddress";
            this.ColIPAddress.ReadOnly = true;
            // 
            // ColDMZ
            // 
            this.ColDMZ.DataPropertyName = "DMZId";
            this.ColDMZ.HeaderText = "DMZ";
            this.ColDMZ.Name = "ColDMZ";
            this.ColDMZ.ReadOnly = true;
            this.ColDMZ.Visible = false;
            // 
            // ColCity
            // 
            this.ColCity.DataPropertyName = "CityId";
            this.ColCity.HeaderText = "City";
            this.ColCity.Name = "ColCity";
            this.ColCity.ReadOnly = true;
            this.ColCity.Visible = false;
            // 
            // TextBoxSimCard
            // 
            this.TextBoxSimCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSimCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSimCard.Location = new System.Drawing.Point(216, 101);
            this.TextBoxSimCard.Name = "TextBoxSimCard";
            this.TextBoxSimCard.Size = new System.Drawing.Size(216, 27);
            this.TextBoxSimCard.TabIndex = 14;
            // 
            // TextBoxX
            // 
            this.TextBoxX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxX.Location = new System.Drawing.Point(216, 132);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(216, 27);
            this.TextBoxX.TabIndex = 15;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(336, 8);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(384, 27);
            this.TextBoxSearch.TabIndex = 16;
            // 
            // TextBoxMac
            // 
            this.TextBoxMac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMac.Location = new System.Drawing.Point(216, 69);
            this.TextBoxMac.Name = "TextBoxMac";
            this.TextBoxMac.Size = new System.Drawing.Size(216, 27);
            this.TextBoxMac.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "SIM CARD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "MAC ADDRESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "DESCRIPTION";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(216, 196);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(216, 27);
            this.TextBoxDescription.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "INSTALLATION DATE";
            // 
            // DateTimePickerInstallationDate
            // 
            this.DateTimePickerInstallationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerInstallationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerInstallationDate.Location = new System.Drawing.Point(216, 227);
            this.DateTimePickerInstallationDate.Name = "DateTimePickerInstallationDate";
            this.DateTimePickerInstallationDate.Size = new System.Drawing.Size(216, 27);
            this.DateTimePickerInstallationDate.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "STATUS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "MAINTENANCE DATE";
            // 
            // DateTimePickerMaintenanceDate
            // 
            this.DateTimePickerMaintenanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerMaintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerMaintenanceDate.Location = new System.Drawing.Point(672, 80);
            this.DateTimePickerMaintenanceDate.Name = "DateTimePickerMaintenanceDate";
            this.DateTimePickerMaintenanceDate.Size = new System.Drawing.Size(216, 27);
            this.DateTimePickerMaintenanceDate.TabIndex = 26;
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxStatus.Location = new System.Drawing.Point(672, 112);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxStatus.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(549, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "IP ADDRESS";
            // 
            // TextBoxIPAddress
            // 
            this.TextBoxIPAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxIPAddress.Location = new System.Drawing.Point(672, 144);
            this.TextBoxIPAddress.Name = "TextBoxIPAddress";
            this.TextBoxIPAddress.Size = new System.Drawing.Size(216, 27);
            this.TextBoxIPAddress.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(619, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 22);
            this.label11.TabIndex = 12;
            this.label11.Text = "DMZ";
            // 
            // ComboBoxDMZ
            // 
            this.ComboBoxDMZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDMZ.FormattingEnabled = true;
            this.ComboBoxDMZ.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxDMZ.Location = new System.Drawing.Point(672, 176);
            this.ComboBoxDMZ.Name = "ComboBoxDMZ";
            this.ComboBoxDMZ.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxDMZ.TabIndex = 25;
            this.ComboBoxDMZ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxDMZ_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(616, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "CITY";
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Items.AddRange(new object[] {
            "ACTIVE",
            "NOT ACTIVE"});
            this.ComboBoxCity.Location = new System.Drawing.Point(672, 208);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxCity.TabIndex = 25;
            this.ComboBoxCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxCity_MouseClick);
            // 
            // TextBoxY
            // 
            this.TextBoxY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxY.Location = new System.Drawing.Point(216, 162);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(216, 27);
            this.TextBoxY.TabIndex = 15;
            // 
            // ButtonExport
            // 
            this.ButtonExport.AutoSize = true;
            this.ButtonExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonExport.BackgroundImage")));
            this.ButtonExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExport.Location = new System.Drawing.Point(603, 264);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(136, 56);
            this.ButtonExport.TabIndex = 19;
            this.ButtonExport.Text = "EXPORT";
            this.ButtonExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // ButtonImport
            // 
            this.ButtonImport.AutoSize = true;
            this.ButtonImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonImport.BackgroundImage")));
            this.ButtonImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImport.Location = new System.Drawing.Point(747, 264);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(136, 56);
            this.ButtonImport.TabIndex = 19;
            this.ButtonImport.Text = "IMPORT";
            this.ButtonImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // openFileDialogGateway
            // 
            this.openFileDialogGateway.DefaultExt = "csv";
            this.openFileDialogGateway.FileName = "Gateway";
            this.openFileDialogGateway.Filter = "CSV |*.csv";
            // 
            // saveFileDialogGateway
            // 
            this.saveFileDialogGateway.DefaultExt = "csv";
            this.saveFileDialogGateway.FileName = "Gateway";
            this.saveFileDialogGateway.Filter = "CSV |*.csv";
            // 
            // errorProviderGateway
            // 
            this.errorProviderGateway.ContainerControl = this;
            // 
            // Gateway
            // 
            this.ClientSize = new System.Drawing.Size(907, 512);
            this.Controls.Add(this.DateTimePickerMaintenanceDate);
            this.Controls.Add(this.DateTimePickerInstallationDate);
            this.Controls.Add(this.ComboBoxCity);
            this.Controls.Add(this.ComboBoxDMZ);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.ButtonExport);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.DataGridViewGateway);
            this.Controls.Add(this.TextBoxSimCard);
            this.Controls.Add(this.TextBoxIPAddress);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxY);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxMac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gateway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway";
            this.Load += new System.EventHandler(this.Gateway_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGateway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGateway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Gateway_Load(object sender, EventArgs e)
        {
            BindGatewayWithDataGrid();
            ResetControls();
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            TextBoxMac.Enabled = true;
            TextBoxSimCard.Enabled = true;
            TextBoxX.Enabled = true;
            TextBoxY.Enabled = true;
            DateTimePickerInstallationDate.Enabled = true;
            DateTimePickerMaintenanceDate.Enabled = true;
            ComboBoxStatus.Enabled = true;
            TextBoxIPAddress.Enabled = true;
            ComboBoxDMZ.Enabled = true;
            ComboBoxCity.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxDescription.Text = "";
            TextBoxMac.Text = "";
            TextBoxSimCard.Text = "";
            TextBoxX.Text = "";
            TextBoxY.Text = "";
            DateTimePickerInstallationDate.Text = "";
            DateTimePickerMaintenanceDate.Text = "";
            ComboBoxStatus.Text = "";
            TextBoxIPAddress.Text = "";
            ComboBoxDMZ.Items.Clear();
            ComboBoxCity.Items.Clear();
            _gatewayMac = "";
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxDescription.Enabled = true;
            TextBoxDescription.Enabled = true;
            TextBoxMac.Enabled = true;
            TextBoxSimCard.Enabled = true;
            TextBoxX.Enabled = true;
            TextBoxY.Enabled = true;
            DateTimePickerInstallationDate.Enabled = true;
            DateTimePickerMaintenanceDate.Enabled = true;
            ComboBoxStatus.Enabled = true;
            TextBoxIPAddress.Enabled = true;
            ComboBoxDMZ.Enabled = true;
            ComboBoxCity.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            _save = false;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
                SaveGateway();
            else
                EditGateway();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text) &&
                _currentUser.Role == "Administrator")
            {
                var deleteGateway = _gateway.Delete(new SmartDB(), _gatewayMac);

                bool flag = deleteGateway.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Gateway Deleted");
                    ResetControls();
                    BindGatewayWithDataGrid();
                }
                else
                {
                    MessageBox.Show(deleteGateway.Message);
                }
            }
            else
            {
                MessageBox.Show("No gateway to delete. Contact admin");
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindGatewayWithDataGrid();
        }
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialogGateway.ShowDialog() == DialogResult.OK)
            {
                Task.Factory.StartNew(() => ExportGateways(saveFileDialogGateway));
            }
        }
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogGateway.ShowDialog() == DialogResult.OK)
                {
                    //var f = new ImportGateway(openFileDialogGateway.FileNames);
                    //f.ShowDialog();
                    Task.Factory.StartNew(() => BulkGateway.Import(openFileDialogGateway.FileNames));
                }
                MessageBox.Show("Import was successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Import was not successful");
            }
            
            ResetControls();
        }
        private void ComboBoxDMZ_MouseClick(object sender, MouseEventArgs e)
        {
            GetDMZ();
        }
        private void ComboBoxCity_MouseClick(object sender, MouseEventArgs e)
        {
            GetCities();
        }
        private void DataGridViewGateway_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                LabelShow.Text = $"Showing {DataGridViewGateway.CurrentRow.Index + 1} index of {DataGridViewGateway.RowCount} records";

                var gatewayId = DataGridViewGateway.CurrentRow.Cells[0].Value.ToString();
                ReturnInfo getGateway = _gateway.GetGatewayById(new SmartDB(), gatewayId);

                bool flag = getGateway.Code == ErrorEnum.NoError;
                TMF.Reports.Model.Gateway gateway = (TMF.Reports.Model.Gateway)getGateway.BizObject;

                
                ReturnInfo getDMZ = _dmz.GetDMZById(new SmartDB(), Convert.ToInt32(gateway.DMZId));
                TMF.Reports.Model.DMZ dmz = (TMF.Reports.Model.DMZ)getDMZ.BizObject;

                ReturnInfo getCity = _city.GetCityById(new SmartDB(), gateway.CityId.Trim());
                TMF.Reports.Model.City city = (TMF.Reports.Model.City)getCity.BizObject;
               

                if (!string.IsNullOrEmpty(gateway.MacAddress))
                {
                    TextBoxMac.Text = gateway.MacAddress;
                    TextBoxX.Text = gateway.X.ToString();
                    TextBoxY.Text = gateway.Y.ToString();
                    TextBoxDescription.Text = gateway.Description;
                    DateTimePickerInstallationDate.Text = Convert.ToDateTime(gateway.InstallationDate).ToString();
                    DateTimePickerMaintenanceDate.Text = Convert.ToDateTime(gateway.MaintenanceDate).ToString();
                    ComboBoxStatus.Text = gateway.Status;
                    TextBoxIPAddress.Text = gateway.IPAddress;
                    ComboBoxDMZ.Text = dmz.Description;
                    ComboBoxCity.Text = city.Description;
                    _gatewayMac = gateway.MacAddress;
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
        private void SaveGateway()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                TMF.Reports.Model.Gateway gateway = new TMF.Reports.Model.Gateway()
                {   //TODO User id for CreatedBy
                    MacAddress = TextBoxMac.Text,
                    SimCard = TextBoxSimCard.Text,
                    X = Convert.ToDecimal(TextBoxX.Text),
                    Y = Convert.ToDecimal(TextBoxY.Text),
                    Description = TextBoxDescription.Text,
                    InstallationDate = DateTime.Parse(DateTimePickerInstallationDate.Text),
                    MaintenanceDate = DateTime.Parse(DateTimePickerMaintenanceDate.Text),
                    Status = ComboBoxStatus.Text,
                    IPAddress = TextBoxIPAddress.Text,
                    DMZId = ComboBoxDMZ.Text,
                    CityId = ComboBoxCity.Text,
                    CreatedBy = _currentUser.Id.ToString(),
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = 0
                };

                var createGateway = _gateway.Create(new SmartDB(), ref gateway);

                bool flag = createGateway.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Gateway Created");
                    ResetControls();
                    BindGatewayWithDataGrid();
                }
                else
                {
                    MessageBox.Show(createGateway.Code.ToString());
                }
            }
            else
                MessageBox.Show("No gateway to save or Contact Admin.");
        }
        private void EditGateway()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {   //Todo EditedBy
                var lockcount = GetLockCount(_gatewayMac);

                TMF.Reports.Model.Gateway gateway = new TMF.Reports.Model.Gateway()
                {
                    MacAddress = _gatewayMac,
                    SimCard = TextBoxSimCard.Text,
                    X = Convert.ToDecimal(TextBoxX.Text),
                    Y = Convert.ToDecimal(TextBoxY.Text),
                    Description = TextBoxDescription.Text,
                    InstallationDate = DateTime.Parse(DateTimePickerInstallationDate.Text),
                    MaintenanceDate = DateTime.Parse(DateTimePickerMaintenanceDate.Text),
                    Status = ComboBoxStatus.Text,
                    IPAddress = TextBoxIPAddress.Text,
                    DMZId = ComboBoxDMZ.Text,
                    CityId = ComboBoxCity.Text,
                    EditedBy = _currentUser.Id.ToString(),
                    DocDate = DateTime.Now,
                    Show = 1,
                    LockCount = lockcount
                };

                var updateGateway = _gateway.Update(new SmartDB(), gateway);

                bool flag = updateGateway.Code == ErrorEnum.NoError;
                if (flag)
                {
                    MessageBox.Show("Gateway Updated");
                    ResetControls();
                    BindGatewayWithDataGrid();
                }
                else
                {
                    MessageBox.Show(updateGateway.Message);
                }
            }
            else
            {
                MessageBox.Show("No gateway to edit or Contact Admin.");
            }
        }
        private void GetCities()
        {
            ComboBoxCity.Items.Clear();
            ReturnInfo getCity = _city.GetCityList(new SmartDB());
            List<City> cities = (List<City>)getCity.BizObject;
            foreach (var city in cities)
            {
                ComboBoxCity.Items.Add(city.Description);
            }
        }
        private void GetDMZ()
        {
            ComboBoxDMZ.Items.Clear();
            ReturnInfo getDMZ = _dmz.GetDMZList(new SmartDB());
            List<TMF.Reports.Model.DMZ> dmzs = (List<TMF.Reports.Model.DMZ>)getDMZ.BizObject;
            foreach (var dmz in dmzs)
            {
                ComboBoxDMZ.Items.Add(dmz.Description);
            }
        }
        private void ResetControls()
        {
            TextBoxDescription.Enabled = false;
            TextBoxMac.Enabled = false;
            TextBoxSimCard.Enabled = false;
            TextBoxX.Enabled = false;
            TextBoxY.Enabled = false;
            DateTimePickerInstallationDate.Enabled = false;
            DateTimePickerMaintenanceDate.Enabled = false;
            ComboBoxStatus.Enabled = false;
            TextBoxIPAddress.Enabled = false;
            ComboBoxDMZ.Enabled = false;
            ComboBoxCity.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxDescription.Text = "";
            TextBoxMac.Text = "";
            TextBoxSimCard.Text = "";
            TextBoxX.Text = "";
            TextBoxY.Text = "";
            DateTimePickerInstallationDate.Text = "";
            DateTimePickerMaintenanceDate.Text = "";
            ComboBoxStatus.Text = "";
            TextBoxIPAddress.Text = "";
            ComboBoxDMZ.Items.Clear();
            ComboBoxCity.Items.Clear();
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindGatewayWithDataGrid();
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
            IInfo info = _gateway.GetGatewayById(new SmartDB(), Id);
            var lockcount = (info.BizObject as TMF.Reports.Model.Gateway).LockCount;
            return lockcount;
        }
        private void BindGatewayWithDataGrid()
        {   //TODO: Refactor this for reuse.
            try
            {
                ReturnInfo getGatewayList = _gateway.GetGatewayBySimCard(new SmartDB(), TextBoxSearch.Text);
                //bool flag = getCityList.Code == ErrorEnum.NoError;
                List<TMF.Reports.Model.Gateway> gateway = (List<TMF.Reports.Model.Gateway>)getGatewayList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.Gateway>(gateway);
                var source = new BindingSource(bindingList, null);
                DataGridViewGateway.AutoGenerateColumns = false;
                DataGridViewGateway.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewGateway.CurrentRow.Index + 1} index of {DataGridViewGateway.RowCount} records";
            }
            catch (Exception)
            {
                return;
            }
}
        #endregion
        private void ExportGateways(SaveFileDialog sfdGateway)
        {
            StreamWriter sr;
            string line = "";
            StringBuilder fileContents = new StringBuilder();
            
            fileContents.Append("MacAddress, SimCard, X, Y, Description, InstallationDate, " +
                                "MaintenanceDate, Status, IPAddress, DMZId, CityId, " +
                                "Createdby, Editedby, DocDate, Show, LockCount\r\n");
            //if (saveFileDialogGateway.ShowDialog() == DialogResult.OK)
            //{
                sr = new StreamWriter(sfdGateway.FileName, false);
                try
                {
                    ReturnInfo getGatewayList = _gateway.GetGatewayBySimCard(new SmartDB(), TextBoxSearch.Text);
                    List<TMF.Reports.Model.Gateway> gateways = (List<TMF.Reports.Model.Gateway>)getGatewayList.BizObject;
                    
                    foreach (var gw in gateways)
                    {
                        line = gw.MacAddress + ",";
                        line += gw.SimCard + ",";
                        line += gw.X + ",";
                        line += gw.Y + ",";
                        line += gw.Description + ",";
                        line += gw.InstallationDate + ",";
                        line += gw.MaintenanceDate + ",";
                        line += gw.Status + ",";
                        line += gw.IPAddress + ",";
                        line += gw.DMZId + ",";
                        line += gw.CityId + ",";
                        line += gw.CreatedBy + ",";
                        line += gw.EditedBy + ",";
                        line += gw.DocDate + ",";
                        line += gw.Show + ",";
                        line += gw.LockCount + "\r\n";
                        fileContents.Append(line);
                    }
                    sr.Write(fileContents);
                    sr.Flush();
                    sr.Close();
                MessageBox.Show("Export Successful");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while exporting file!");
                }
            //}
        }
    }
}
