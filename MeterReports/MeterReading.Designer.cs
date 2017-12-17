namespace MeterReports
{
    partial class MeterReading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeterReading));
            this.TabControlMeterReading = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridViewLatestMeterReading = new System.Windows.Forms.DataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxLeakAlr = new System.Windows.Forms.TextBox();
            this.TextBoxSpecificErr = new System.Windows.Forms.TextBox();
            this.TextBoxReadingDate = new System.Windows.Forms.TextBox();
            this.TextBoxBrokenPipeAlr = new System.Windows.Forms.TextBox();
            this.TextBoxBackflowAlr = new System.Windows.Forms.TextBox();
            this.TextBoxErrorAlr = new System.Windows.Forms.TextBox();
            this.TextBoxMagneticTmprAlr = new System.Windows.Forms.TextBox();
            this.TextBoxLowBattAlr = new System.Windows.Forms.TextBox();
            this.TextBoxReadingValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxEmptyPipeAlr = new System.Windows.Forms.TextBox();
            this.TextBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonLast = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.DataGridViewMeterReading = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReadingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReadingValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLowBattAlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLeakAlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMagneticTmprAlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColErrorAlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBackFlowAlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBrokenPipeAlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmptyPipeAlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSpecificErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMeterReading = new System.Windows.Forms.SaveFileDialog();
            this.errorProviderMeterReading = new System.Windows.Forms.ErrorProvider(this.components);
            this.BindingSourceMeterReading = new System.Windows.Forms.BindingSource(this.components);
            this.TabControlMeterReading.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLatestMeterReading)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMeterReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMeterReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceMeterReading)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMeterReading
            // 
            this.TabControlMeterReading.Controls.Add(this.tabPage1);
            this.TabControlMeterReading.Controls.Add(this.tabPage2);
            this.TabControlMeterReading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMeterReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlMeterReading.Location = new System.Drawing.Point(0, 0);
            this.TabControlMeterReading.Multiline = true;
            this.TabControlMeterReading.Name = "TabControlMeterReading";
            this.TabControlMeterReading.SelectedIndex = 0;
            this.TabControlMeterReading.Size = new System.Drawing.Size(905, 525);
            this.TabControlMeterReading.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataGridViewLatestMeterReading);
            this.tabPage1.Controls.Add(this.ButtonImport);
            this.tabPage1.Controls.Add(this.ButtonExport);
            this.tabPage1.Controls.Add(this.ButtonDelete);
            this.tabPage1.Controls.Add(this.ButtonSave);
            this.tabPage1.Controls.Add(this.ButtonEdit);
            this.tabPage1.Controls.Add(this.ButtonNew);
            this.tabPage1.Controls.Add(this.ButtonSearch);
            this.tabPage1.Controls.Add(this.TextBoxLeakAlr);
            this.tabPage1.Controls.Add(this.TextBoxSpecificErr);
            this.tabPage1.Controls.Add(this.TextBoxReadingDate);
            this.tabPage1.Controls.Add(this.TextBoxBrokenPipeAlr);
            this.tabPage1.Controls.Add(this.TextBoxBackflowAlr);
            this.tabPage1.Controls.Add(this.TextBoxErrorAlr);
            this.tabPage1.Controls.Add(this.TextBoxMagneticTmprAlr);
            this.tabPage1.Controls.Add(this.TextBoxLowBattAlr);
            this.tabPage1.Controls.Add(this.TextBoxReadingValue);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TextBoxSearch);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.TextBoxEmptyPipeAlr);
            this.tabPage1.Controls.Add(this.TextBoxSerialNumber);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "METER INFORMATION";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridViewLatestMeterReading
            // 
            this.DataGridViewLatestMeterReading.AllowUserToAddRows = false;
            this.DataGridViewLatestMeterReading.AllowUserToDeleteRows = false;
            this.DataGridViewLatestMeterReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLatestMeterReading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.ColSN,
            this.ColRD,
            this.ColRV,
            this.ColLBA,
            this.ColLA,
            this.ColMTA,
            this.ColEA,
            this.ColBA,
            this.ColBPA,
            this.ColEPA,
            this.ColSE});
            this.DataGridViewLatestMeterReading.Location = new System.Drawing.Point(10, 281);
            this.DataGridViewLatestMeterReading.Name = "DataGridViewLatestMeterReading";
            this.DataGridViewLatestMeterReading.ReadOnly = true;
            this.DataGridViewLatestMeterReading.Size = new System.Drawing.Size(878, 142);
            this.DataGridViewLatestMeterReading.TabIndex = 82;
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "Id";
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Visible = false;
            // 
            // ColSN
            // 
            this.ColSN.DataPropertyName = "SerialNumber";
            this.ColSN.HeaderText = "SerialNumber";
            this.ColSN.Name = "ColSN";
            this.ColSN.ReadOnly = true;
            // 
            // ColRD
            // 
            this.ColRD.DataPropertyName = "ReadingDate";
            this.ColRD.HeaderText = "ReadingDate";
            this.ColRD.Name = "ColRD";
            this.ColRD.ReadOnly = true;
            // 
            // ColRV
            // 
            this.ColRV.DataPropertyName = "ReadingValue";
            this.ColRV.HeaderText = "ReadingValue";
            this.ColRV.Name = "ColRV";
            this.ColRV.ReadOnly = true;
            // 
            // ColLBA
            // 
            this.ColLBA.DataPropertyName = "LowBatteryAlr";
            this.ColLBA.HeaderText = "LowBattAlr";
            this.ColLBA.Name = "ColLBA";
            this.ColLBA.ReadOnly = true;
            // 
            // ColLA
            // 
            this.ColLA.DataPropertyName = "LeakAlr";
            this.ColLA.HeaderText = "LeakAlr";
            this.ColLA.Name = "ColLA";
            this.ColLA.ReadOnly = true;
            // 
            // ColMTA
            // 
            this.ColMTA.DataPropertyName = "MagneticTamperAlr";
            this.ColMTA.HeaderText = "MagneticTmprAlr";
            this.ColMTA.Name = "ColMTA";
            this.ColMTA.ReadOnly = true;
            // 
            // ColEA
            // 
            this.ColEA.DataPropertyName = "MeterErrorAlr";
            this.ColEA.HeaderText = "ErrorAlr";
            this.ColEA.Name = "ColEA";
            this.ColEA.ReadOnly = true;
            // 
            // ColBA
            // 
            this.ColBA.DataPropertyName = "BackFlowAlr";
            this.ColBA.HeaderText = "BackflowAlr";
            this.ColBA.Name = "ColBA";
            this.ColBA.ReadOnly = true;
            // 
            // ColBPA
            // 
            this.ColBPA.DataPropertyName = "BrokenPipeAlr";
            this.ColBPA.HeaderText = "BrokenPipeAlr";
            this.ColBPA.Name = "ColBPA";
            this.ColBPA.ReadOnly = true;
            // 
            // ColEPA
            // 
            this.ColEPA.DataPropertyName = "EmptyPipeAlr";
            this.ColEPA.HeaderText = "EmptyPipeAlr";
            this.ColEPA.Name = "ColEPA";
            this.ColEPA.ReadOnly = true;
            // 
            // ColSE
            // 
            this.ColSE.DataPropertyName = "SpecificErr";
            this.ColSE.HeaderText = "SpecificErr";
            this.ColSE.Name = "ColSE";
            this.ColSE.ReadOnly = true;
            // 
            // ButtonImport
            // 
            this.ButtonImport.AutoSize = true;
            this.ButtonImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonImport.BackgroundImage")));
            this.ButtonImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImport.Location = new System.Drawing.Point(736, 432);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(136, 56);
            this.ButtonImport.TabIndex = 80;
            this.ButtonImport.Text = "IMPORT";
            this.ButtonImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // ButtonExport
            // 
            this.ButtonExport.AutoSize = true;
            this.ButtonExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonExport.BackgroundImage")));
            this.ButtonExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExport.Location = new System.Drawing.Point(592, 432);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(136, 56);
            this.ButtonExport.TabIndex = 81;
            this.ButtonExport.Text = "EXPORT";
            this.ButtonExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(448, 432);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(136, 56);
            this.ButtonDelete.TabIndex = 75;
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
            this.ButtonSave.Location = new System.Drawing.Point(304, 432);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(136, 56);
            this.ButtonSave.TabIndex = 76;
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
            this.ButtonEdit.Location = new System.Drawing.Point(152, 432);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(136, 56);
            this.ButtonEdit.TabIndex = 77;
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
            this.ButtonNew.Location = new System.Drawing.Point(8, 432);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(136, 56);
            this.ButtonNew.TabIndex = 78;
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
            this.ButtonSearch.Location = new System.Drawing.Point(720, 8);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(151, 56);
            this.ButtonSearch.TabIndex = 79;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxLeakAlr
            // 
            this.TextBoxLeakAlr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxLeakAlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLeakAlr.Location = new System.Drawing.Point(216, 208);
            this.TextBoxLeakAlr.Name = "TextBoxLeakAlr";
            this.TextBoxLeakAlr.Size = new System.Drawing.Size(216, 27);
            this.TextBoxLeakAlr.TabIndex = 68;
            // 
            // TextBoxSpecificErr
            // 
            this.TextBoxSpecificErr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSpecificErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSpecificErr.Location = new System.Drawing.Point(655, 208);
            this.TextBoxSpecificErr.Name = "TextBoxSpecificErr";
            this.TextBoxSpecificErr.Size = new System.Drawing.Size(216, 27);
            this.TextBoxSpecificErr.TabIndex = 68;
            // 
            // TextBoxReadingDate
            // 
            this.TextBoxReadingDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxReadingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxReadingDate.Location = new System.Drawing.Point(216, 112);
            this.TextBoxReadingDate.Name = "TextBoxReadingDate";
            this.TextBoxReadingDate.Size = new System.Drawing.Size(216, 27);
            this.TextBoxReadingDate.TabIndex = 68;
            // 
            // TextBoxBrokenPipeAlr
            // 
            this.TextBoxBrokenPipeAlr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxBrokenPipeAlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBrokenPipeAlr.Location = new System.Drawing.Point(656, 143);
            this.TextBoxBrokenPipeAlr.Name = "TextBoxBrokenPipeAlr";
            this.TextBoxBrokenPipeAlr.Size = new System.Drawing.Size(216, 27);
            this.TextBoxBrokenPipeAlr.TabIndex = 70;
            // 
            // TextBoxBackflowAlr
            // 
            this.TextBoxBackflowAlr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxBackflowAlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBackflowAlr.Location = new System.Drawing.Point(656, 113);
            this.TextBoxBackflowAlr.Name = "TextBoxBackflowAlr";
            this.TextBoxBackflowAlr.Size = new System.Drawing.Size(216, 27);
            this.TextBoxBackflowAlr.TabIndex = 70;
            // 
            // TextBoxErrorAlr
            // 
            this.TextBoxErrorAlr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxErrorAlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxErrorAlr.Location = new System.Drawing.Point(656, 80);
            this.TextBoxErrorAlr.Name = "TextBoxErrorAlr";
            this.TextBoxErrorAlr.Size = new System.Drawing.Size(216, 27);
            this.TextBoxErrorAlr.TabIndex = 69;
            // 
            // TextBoxMagneticTmprAlr
            // 
            this.TextBoxMagneticTmprAlr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxMagneticTmprAlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMagneticTmprAlr.Location = new System.Drawing.Point(216, 239);
            this.TextBoxMagneticTmprAlr.Name = "TextBoxMagneticTmprAlr";
            this.TextBoxMagneticTmprAlr.Size = new System.Drawing.Size(216, 27);
            this.TextBoxMagneticTmprAlr.TabIndex = 69;
            // 
            // TextBoxLowBattAlr
            // 
            this.TextBoxLowBattAlr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxLowBattAlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLowBattAlr.Location = new System.Drawing.Point(216, 176);
            this.TextBoxLowBattAlr.Name = "TextBoxLowBattAlr";
            this.TextBoxLowBattAlr.Size = new System.Drawing.Size(216, 27);
            this.TextBoxLowBattAlr.TabIndex = 70;
            // 
            // TextBoxReadingValue
            // 
            this.TextBoxReadingValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxReadingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxReadingValue.Location = new System.Drawing.Point(216, 144);
            this.TextBoxReadingValue.Name = "TextBoxReadingValue";
            this.TextBoxReadingValue.Size = new System.Drawing.Size(216, 27);
            this.TextBoxReadingValue.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(488, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 22);
            this.label9.TabIndex = 66;
            this.label9.Text = "EMPTY PIPE ALR";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(320, 8);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(384, 27);
            this.TextBoxSearch.TabIndex = 72;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(468, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 22);
            this.label18.TabIndex = 65;
            this.label18.Text = "BROKEN PIPE ALR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 22);
            this.label7.TabIndex = 65;
            this.label7.Text = "LOW BATT ALR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(512, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 62;
            this.label8.Text = "SPECIFIC ERR";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(488, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 22);
            this.label17.TabIndex = 60;
            this.label17.Text = "BACKFLOW ALR";
            // 
            // TextBoxEmptyPipeAlr
            // 
            this.TextBoxEmptyPipeAlr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxEmptyPipeAlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmptyPipeAlr.Location = new System.Drawing.Point(655, 176);
            this.TextBoxEmptyPipeAlr.Name = "TextBoxEmptyPipeAlr";
            this.TextBoxEmptyPipeAlr.Size = new System.Drawing.Size(216, 27);
            this.TextBoxEmptyPipeAlr.TabIndex = 73;
            // 
            // TextBoxSerialNumber
            // 
            this.TextBoxSerialNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSerialNumber.Location = new System.Drawing.Point(216, 80);
            this.TextBoxSerialNumber.Name = "TextBoxSerialNumber";
            this.TextBoxSerialNumber.Size = new System.Drawing.Size(216, 27);
            this.TextBoxSerialNumber.TabIndex = 73;
            this.TextBoxSerialNumber.TextChanged += new System.EventHandler(this.TextBoxSerialNumber_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(525, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 22);
            this.label16.TabIndex = 57;
            this.label16.Text = "ERROR ALR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 22);
            this.label15.TabIndex = 59;
            this.label15.Text = "MAGNETIC TMPR ALR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 57;
            this.label4.Text = "READING VALUE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(104, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 22);
            this.label14.TabIndex = 58;
            this.label14.Text = "LEAK ALR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "READING DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 67;
            this.label1.Text = "SERIAL NUMBER";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonFirst);
            this.tabPage2.Controls.Add(this.ButtonPrevious);
            this.tabPage2.Controls.Add(this.ButtonNext);
            this.tabPage2.Controls.Add(this.ButtonLast);
            this.tabPage2.Controls.Add(this.lblStatus);
            this.tabPage2.Controls.Add(this.DataGridViewMeterReading);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(897, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LIST OF RECORDS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.AutoSize = true;
            this.ButtonFirst.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFirst.Image")));
            this.ButtonFirst.Location = new System.Drawing.Point(8, 8);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(30, 30);
            this.ButtonFirst.TabIndex = 89;
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.AutoSize = true;
            this.ButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrevious.Image")));
            this.ButtonPrevious.Location = new System.Drawing.Point(40, 8);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(30, 30);
            this.ButtonPrevious.TabIndex = 89;
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.AutoSize = true;
            this.ButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNext.Image")));
            this.ButtonNext.Location = new System.Drawing.Point(232, 6);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(30, 30);
            this.ButtonNext.TabIndex = 89;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonLast
            // 
            this.ButtonLast.AutoSize = true;
            this.ButtonLast.Image = global::MeterReports.Properties.Resources.last;
            this.ButtonLast.Location = new System.Drawing.Point(264, 6);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(30, 30);
            this.ButtonLast.TabIndex = 89;
            this.ButtonLast.UseVisualStyleBackColor = true;
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Enabled = false;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Location = new System.Drawing.Point(72, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(152, 20);
            this.lblStatus.TabIndex = 88;
            this.lblStatus.Text = "0 / 0";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridViewMeterReading
            // 
            this.DataGridViewMeterReading.AllowUserToAddRows = false;
            this.DataGridViewMeterReading.AllowUserToDeleteRows = false;
            this.DataGridViewMeterReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMeterReading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColSerialNumber,
            this.ColReadingDate,
            this.ColReadingValue,
            this.ColLowBattAlr,
            this.ColLeakAlr,
            this.ColMagneticTmprAlr,
            this.ColErrorAlr,
            this.ColBackFlowAlr,
            this.ColBrokenPipeAlr,
            this.ColEmptyPipeAlr,
            this.ColSpecificErr});
            this.DataGridViewMeterReading.Location = new System.Drawing.Point(8, 40);
            this.DataGridViewMeterReading.Name = "DataGridViewMeterReading";
            this.DataGridViewMeterReading.ReadOnly = true;
            this.DataGridViewMeterReading.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMeterReading.Size = new System.Drawing.Size(872, 448);
            this.DataGridViewMeterReading.TabIndex = 81;
            this.DataGridViewMeterReading.SelectionChanged += new System.EventHandler(this.DataGridViewMeterReading_SelectionChanged);
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
            // ColReadingDate
            // 
            this.ColReadingDate.DataPropertyName = "ReadingDate";
            this.ColReadingDate.HeaderText = "ReadingDate";
            this.ColReadingDate.Name = "ColReadingDate";
            this.ColReadingDate.ReadOnly = true;
            // 
            // ColReadingValue
            // 
            this.ColReadingValue.DataPropertyName = "ReadingValue";
            this.ColReadingValue.HeaderText = "ReadingValue";
            this.ColReadingValue.Name = "ColReadingValue";
            this.ColReadingValue.ReadOnly = true;
            // 
            // ColLowBattAlr
            // 
            this.ColLowBattAlr.DataPropertyName = "LowBatteryAlr";
            this.ColLowBattAlr.HeaderText = "LowBattAlr";
            this.ColLowBattAlr.Name = "ColLowBattAlr";
            this.ColLowBattAlr.ReadOnly = true;
            // 
            // ColLeakAlr
            // 
            this.ColLeakAlr.DataPropertyName = "LeakAlr";
            this.ColLeakAlr.HeaderText = "LeakAlr";
            this.ColLeakAlr.Name = "ColLeakAlr";
            this.ColLeakAlr.ReadOnly = true;
            // 
            // ColMagneticTmprAlr
            // 
            this.ColMagneticTmprAlr.DataPropertyName = "MagneticTamperAlr";
            this.ColMagneticTmprAlr.HeaderText = "MagneticTmprAlr";
            this.ColMagneticTmprAlr.Name = "ColMagneticTmprAlr";
            this.ColMagneticTmprAlr.ReadOnly = true;
            // 
            // ColErrorAlr
            // 
            this.ColErrorAlr.DataPropertyName = "MeterErrorAlr";
            this.ColErrorAlr.HeaderText = "ErrorAlr";
            this.ColErrorAlr.Name = "ColErrorAlr";
            this.ColErrorAlr.ReadOnly = true;
            // 
            // ColBackFlowAlr
            // 
            this.ColBackFlowAlr.DataPropertyName = "BackFlowAlr";
            this.ColBackFlowAlr.HeaderText = "BackFlowAlr";
            this.ColBackFlowAlr.Name = "ColBackFlowAlr";
            this.ColBackFlowAlr.ReadOnly = true;
            // 
            // ColBrokenPipeAlr
            // 
            this.ColBrokenPipeAlr.DataPropertyName = "BrokenPipeAlr";
            this.ColBrokenPipeAlr.HeaderText = "BrokenPipeAlr";
            this.ColBrokenPipeAlr.Name = "ColBrokenPipeAlr";
            this.ColBrokenPipeAlr.ReadOnly = true;
            // 
            // ColEmptyPipeAlr
            // 
            this.ColEmptyPipeAlr.DataPropertyName = "EmptyPipeAlr";
            this.ColEmptyPipeAlr.HeaderText = "EmptyPipeAlr";
            this.ColEmptyPipeAlr.Name = "ColEmptyPipeAlr";
            this.ColEmptyPipeAlr.ReadOnly = true;
            // 
            // ColSpecificErr
            // 
            this.ColSpecificErr.DataPropertyName = "SpecificErr";
            this.ColSpecificErr.HeaderText = "SpecificErr";
            this.ColSpecificErr.Name = "ColSpecificErr";
            this.ColSpecificErr.ReadOnly = true;
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.DefaultExt = "csv";
            this.openFileDialogImport.FileName = "GTW_RDS";
            this.openFileDialogImport.Filter = "CSV |*.csv";
            this.openFileDialogImport.Multiselect = true;
            // 
            // saveFileDialogMeterReading
            // 
            this.saveFileDialogMeterReading.DefaultExt = "csv";
            this.saveFileDialogMeterReading.Filter = "CSV |*.csv";
            // 
            // errorProviderMeterReading
            // 
            this.errorProviderMeterReading.ContainerControl = this;
            // 
            // BindingSourceMeterReading
            // 
            this.BindingSourceMeterReading.Filter = "0";
            // 
            // MeterReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 525);
            this.Controls.Add(this.TabControlMeterReading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MeterReading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meter Reading";
            this.Load += new System.EventHandler(this.MeterReading_Load);
            this.TabControlMeterReading.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLatestMeterReading)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMeterReading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMeterReading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceMeterReading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMeterReading;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxReadingDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxSerialNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGridViewMeterReading;
        private System.Windows.Forms.TextBox TextBoxLeakAlr;
        private System.Windows.Forms.TextBox TextBoxBackflowAlr;
        private System.Windows.Forms.TextBox TextBoxMagneticTmprAlr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBoxSpecificErr;
        private System.Windows.Forms.TextBox TextBoxBrokenPipeAlr;
        private System.Windows.Forms.TextBox TextBoxErrorAlr;
        private System.Windows.Forms.TextBox TextBoxLowBattAlr;
        private System.Windows.Forms.TextBox TextBoxReadingValue;
        private System.Windows.Forms.TextBox TextBoxEmptyPipeAlr;
        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.OpenFileDialog openFileDialogImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReadingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReadingValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLowBattAlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLeakAlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMagneticTmprAlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColErrorAlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBackFlowAlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBrokenPipeAlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmptyPipeAlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSpecificErr;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMeterReading;
        private System.Windows.Forms.DataGridView DataGridViewLatestMeterReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSE;
        private System.Windows.Forms.ErrorProvider errorProviderMeterReading;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.BindingSource BindingSourceMeterReading;
        private System.Windows.Forms.Button ButtonFirst;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonLast;
    }
}