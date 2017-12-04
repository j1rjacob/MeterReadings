using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMF.Core;
using TMF.Reports.UTIL;

namespace MeterReports
{
    public partial class Import : Form
    {
        private Label LabelDuplicate;
        private ProgressBar ProgressBarImportStatus;
        private OpenFileDialog openFileDialogImport;
        private Label LabelImported;
        private readonly TMF.Reports.BLL.GatewayLog _gatewayLog;
        private readonly TMF.Reports.BLL.Gateway _gatewayL;
        private readonly TMF.Reports.BLL.DMZ _dmz;
        private readonly TMF.Reports.BLL.City _city;
        private int _max = 0;
        private string _gateway;
        private string _csvFilename;
        private List<string> _duplicateCSVFile = new List<string>();
        private List<string> _duplicateMac = new List<string>();
        private Button ButtonReplace;
        private Button ButtonSkip;
        private string[] _fileNames;

        public Import(string[] fileNames)
        {
            InitializeComponent();
            _gatewayLog = new TMF.Reports.BLL.GatewayLog();
            _gatewayL = new TMF.Reports.BLL.Gateway();
            _fileNames = fileNames;
            _dmz = new TMF.Reports.BLL.DMZ();
            _city = new TMF.Reports.BLL.City();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.LabelImported = new System.Windows.Forms.Label();
            this.LabelDuplicate = new System.Windows.Forms.Label();
            this.ProgressBarImportStatus = new System.Windows.Forms.ProgressBar();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            this.ButtonReplace = new System.Windows.Forms.Button();
            this.ButtonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelImported
            // 
            this.LabelImported.AutoSize = true;
            this.LabelImported.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelImported.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelImported.Location = new System.Drawing.Point(14, 8);
            this.LabelImported.Name = "LabelImported";
            this.LabelImported.Size = new System.Drawing.Size(253, 18);
            this.LabelImported.TabIndex = 38;
            this.LabelImported.Text = "Number of imported CSV File/s: 0 Ok";
            // 
            // LabelDuplicate
            // 
            this.LabelDuplicate.AutoSize = true;
            this.LabelDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDuplicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDuplicate.Location = new System.Drawing.Point(14, 40);
            this.LabelDuplicate.Name = "LabelDuplicate";
            this.LabelDuplicate.Size = new System.Drawing.Size(237, 18);
            this.LabelDuplicate.TabIndex = 38;
            this.LabelDuplicate.Text = "Number of duplicated CSV File/s: 0";
            // 
            // ProgressBarImportStatus
            // 
            this.ProgressBarImportStatus.Location = new System.Drawing.Point(9, 72);
            this.ProgressBarImportStatus.Name = "ProgressBarImportStatus";
            this.ProgressBarImportStatus.Size = new System.Drawing.Size(367, 23);
            this.ProgressBarImportStatus.TabIndex = 39;
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.DefaultExt = "csv";
            this.openFileDialogImport.FileName = "GTW_RDS";
            this.openFileDialogImport.Filter = "CSV |*.csv";
            this.openFileDialogImport.Multiselect = true;
            // 
            // ButtonReplace
            // 
            this.ButtonReplace.AutoSize = true;
            this.ButtonReplace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonReplace.BackgroundImage")));
            this.ButtonReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReplace.Location = new System.Drawing.Point(8, 104);
            this.ButtonReplace.Name = "ButtonReplace";
            this.ButtonReplace.Size = new System.Drawing.Size(176, 56);
            this.ButtonReplace.TabIndex = 49;
            this.ButtonReplace.Text = "REPLACE ALL";
            this.ButtonReplace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonReplace.UseVisualStyleBackColor = true;
            this.ButtonReplace.Visible = false;
            this.ButtonReplace.Click += new System.EventHandler(this.ButtonReplace_Click);
            // 
            // ButtonSkip
            // 
            this.ButtonSkip.AutoSize = true;
            this.ButtonSkip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSkip.BackgroundImage")));
            this.ButtonSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSkip.Location = new System.Drawing.Point(200, 104);
            this.ButtonSkip.Name = "ButtonSkip";
            this.ButtonSkip.Size = new System.Drawing.Size(176, 56);
            this.ButtonSkip.TabIndex = 50;
            this.ButtonSkip.Text = "SKIP ALL";
            this.ButtonSkip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSkip.UseVisualStyleBackColor = true;
            this.ButtonSkip.Visible = false;
            this.ButtonSkip.Click += new System.EventHandler(this.ButtonSkip_Click);
            // 
            // Import
            // 
            this.ClientSize = new System.Drawing.Size(382, 107);
            this.Controls.Add(this.ButtonSkip);
            this.Controls.Add(this.ButtonReplace);
            this.Controls.Add(this.ProgressBarImportStatus);
            this.Controls.Add(this.LabelDuplicate);
            this.Controls.Add(this.LabelImported);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Meter Reading";
            this.Load += new System.EventHandler(this.Import_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Import_Load(object sender, EventArgs e)
        {
            ImportMeterSerialNumber();
        }
        private void ButtonReplace_Click(object sender, EventArgs e)
        {
           ProgressBarImportStatus.Maximum = _max = _duplicateCSVFile.Count;
           ImportDuplicatedMeterSerialNumber();
        }

        private void ImportDuplicatedMeterSerialNumber()
        {
            throw new NotImplementedException();
        }

        private void ImportMeterSerialNumber()
        {
                //_duplicateMac = MacDuplicate.Get(openFileDialogImport.FileNames);
                //_duplicateCSVFile = CSVDuplicate.Get(openFileDialogImport.FileNames);
                //ProgressBarImportStatus.Maximum = 
                //    _max = (openFileDialogImport.FileNames.Length - _duplicateCSVFile.Count);
                //Task.Factory.StartNew(() => ImportBulkRDSCSV());
                _duplicateMac = MacDuplicate.Get(_fileNames);
                _duplicateCSVFile = CSVDuplicate.Get(_fileNames);
                ProgressBarImportStatus.Maximum = 
                    _max = (_fileNames.Length - _duplicateCSVFile.Count);
                Task.Factory.StartNew(() => ImportBulkRDSCSV());

                //TODO: Decouple; Error same count on imported and duplicated.
                //Task.Factory.StartNew(() => BulkRDS
                //.Import(openFileDialogImport.FileNames,
                //                                           _max,
                //                                           ProgressBarImportStatus,
                //                                           LabelImported,
                //                                           LabelDuplicate));
        }
        private void ButtonSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ImportBulkRDSCSV()
        {
            int count = 0;

            using (SqlConnection connection =
                new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                connection.Open();
                foreach (var filename in _fileNames)
                {
                    _gateway = Path.GetFileName((Path.GetDirectoryName(filename)));
                    _csvFilename = (Path.GetFileName(filename));
                    if (!_duplicateCSVFile.Contains(_csvFilename))
                    {   // Create a table with some rows.
                        DataTable newMeterReading = MakeTable.RDS(filename);
                        // Create the SqlBulkCopy object.
                        using (SqlBulkCopy s = new SqlBulkCopy(connection))
                        {
                            s.DestinationTableName = "MeterReading";
                            s.ColumnMappings.Add("SerialNumber", "SerialNumber");
                            s.ColumnMappings.Add("ReadingDate", "ReadingDate");
                            s.ColumnMappings.Add("ReadingValue", "ReadingValue");
                            s.ColumnMappings.Add("LowBatteryAlr", "LowBatteryAlr");
                            s.ColumnMappings.Add("LeakAlr", "LeakAlr");
                            s.ColumnMappings.Add("MagneticTamperAlr", "MagneticTamperAlr");
                            s.ColumnMappings.Add("MeterErrorAlr", "MeterErrorAlr");
                            s.ColumnMappings.Add("BackFlowAlr", "BackFlowAlr");
                            s.ColumnMappings.Add("BrokenPipeAlr", "BrokenPipeAlr");
                            s.ColumnMappings.Add("EmptyPipeAlr", "EmptyPipeAlr");
                            s.ColumnMappings.Add("SpecificErr", "SpecificErr");
                            try
                            {
                                // Write from the source to the destination.
                                s.WriteToServer(newMeterReading);
                                
                                //Add GatewayLog
                                TMF.Reports.Model.GatewayLog gatewayLog = new TMF.Reports.Model.GatewayLog()
                                {
                                    RDS = 1,
                                    OMS = 0,
                                    GatewayMacAddress = _gateway,
                                    CSVFilename = _csvFilename,
                                    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                                    EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                                    DocDate = DateTime.Now,
                                    Show = 1,
                                    LockCount = 0
                                };
                                var createGatewayLog = _gatewayLog.Create(new SmartDB(), ref gatewayLog);

                                //ADD Mac Address in Gateway
                                if (!_duplicateMac.Contains(_gateway))
                                { 
                                TMF.Reports.Model.Gateway gatewayC = new TMF.Reports.Model.Gateway()
                                    {
                                        MacAddress = Regex.Replace(_gateway, @"^(..)(..)(..)(..)(..)(..)$", "$1:$2:$3:$4:$5:$6"),
                                        SimCard = null,
                                        X = 0,
                                        Y = 0,
                                        Description = null,
                                        InstallationDate = DateTime.Parse("06/20/1986"),
                                        MaintenanceDate = DateTime.Parse("06/20/1986"),
                                        Status = "Active",
                                        IPAddress = "192.0.0.1",
                                        CreatedBy = "1",
                                        EditedBy = "1",
                                        DocDate = DateTime.Now,
                                        Show = 1,
                                        LockCount = 0
                                    };
                                    _gatewayL.Create(new SmartDB(), ref gatewayC);
                                }
                                //TODO ADD Meter Serial to Meter Table via stored proc REPORT METER_SYNCSERIALNUMBER_METERREADING
                                bool flag = createGatewayLog.Code == ErrorEnum.NoError;
                                if (flag)
                                {
                                    ProgressBarImportStatus.Invoke((Action)delegate
                                    {
                                        ProgressBarImportStatus.Increment(1);
                                    });
                                    count++;
                                    if (count == _max)
                                    {
                                        LabelImported.Invoke((Action)delegate
                                        {
                                            LabelImported.Text = $"Number of imported CSV File/s: {count} Ok";
                                        });
                                        MessageBox.Show("Importing was successful.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"Contact Admin: Gateway log error", "Import");
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Contact Admin: {ex.Message}", "Import");
                            }
                        }
                    }
                }
            }
            LabelDuplicate.Invoke((Action)delegate
            {
                LabelDuplicate.Text = $"Number of duplicated CSV File/ s: {_duplicateCSVFile.Count}";
            });
        }
    }
}
