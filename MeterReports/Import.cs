﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class Import : Form
    {
        private Label LabelDuplicate;
        private ProgressBar ProgressBarImportStatus;
        private Button ButtonReplace;
        private Button ButtonSkip;
        private OpenFileDialog openFileDialogImport;
        private Label LabelImported;
        private readonly TMF.Reports.BLL.MeterReading _meterReading;
        private readonly TMF.Reports.BLL.GatewayLog _gatewayLog;
        private readonly TMF.Reports.BLL.Gateway _gatewayL;
        private int _max = 0;
        private string _gateway;
        private string _csvFilename;
        private List<string> _duplicateCSVFile = new List<string>();
        private List<string> _duplicateMac = new List<string>();
        private int _duplicateCount;

        public Import()
        {
            InitializeComponent();
            _meterReading = new TMF.Reports.BLL.MeterReading();
            _gatewayLog = new TMF.Reports.BLL.GatewayLog();
            _gatewayL = new TMF.Reports.BLL.Gateway();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.LabelImported = new System.Windows.Forms.Label();
            this.LabelDuplicate = new System.Windows.Forms.Label();
            this.ProgressBarImportStatus = new System.Windows.Forms.ProgressBar();
            this.ButtonReplace = new System.Windows.Forms.Button();
            this.ButtonSkip = new System.Windows.Forms.Button();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
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
            this.ButtonSkip.Click += new System.EventHandler(this.ButtonSkip_Click);
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.DefaultExt = "csv";
            this.openFileDialogImport.FileName = "GTW_RDS";
            this.openFileDialogImport.Filter = "CSV |*.csv";
            this.openFileDialogImport.Multiselect = true;
            // 
            // Import
            // 
            this.ClientSize = new System.Drawing.Size(382, 165);
            this.Controls.Add(this.ButtonSkip);
            this.Controls.Add(this.ButtonReplace);
            this.Controls.Add(this.ProgressBarImportStatus);
            this.Controls.Add(this.LabelDuplicate);
            this.Controls.Add(this.LabelImported);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Meter Reading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonReplace_Click(object sender, EventArgs e)
        {
            //TODO CHANGE THIS REAL IMPORT
            ProgressBarImportStatus.Maximum = 0;
            ImportMeterSerialNumber();
        }

        private void ImportMeterSerialNumber()
        {
            if (openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                //TODO Check if duplicate
                GetMacDuplicates();
                GetCSVDuplicates();
                ProgressBarImportStatus.Maximum = _max = (openFileDialogImport.FileNames.Length - _duplicateCount);
                Task.Factory.StartNew(() => ImportBulkRDSCSV());
            }
        }
        private void ButtonSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetMacDuplicates()
        {
            foreach (var filename in openFileDialogImport.FileNames)
            {
                _gateway = Path.GetFileName((Path.GetDirectoryName(filename)));
                _csvFilename = (Path.GetFileName(filename));

                //add to list duplicate
                ReturnInfo getGateway = _gatewayL.GetGatewayById(new SmartDB(), _gateway);
                bool flag = getGateway.Code == ErrorEnum.NoError;
                if (flag)
                {
                    _duplicateMac.Add(_csvFilename);
                    //_duplicateCount++;
                }
            }
        }
        private void GetCSVDuplicates()
        {
            _duplicateCSVFile.Clear();
            //using (SqlConnection connection =
            //    new SqlConnection(new SmartDB().Connection.ConnectionString))
            //{
            //    connection.Open();
                foreach (var filename in openFileDialogImport.FileNames)
                {
                    _gateway = Path.GetFileName((Path.GetDirectoryName(filename)));
                    _csvFilename = (Path.GetFileName(filename));

                    //add to list duplicate
                    ReturnInfo getGatewayLog = _gatewayLog.GetRecordsByMacCsv(new SmartDB(), _gateway, _csvFilename);
                    bool flag = getGatewayLog.Code == ErrorEnum.NoError;
                    if (flag)
                    {
                        _duplicateCSVFile.Add(_csvFilename);
                        _duplicateCount++;
                    }
                }
            //}
        }
        private void ImportBulkRDSCSV()
        {
            string connectionString = new SmartDB().Connection.ConnectionString;

            int count = 0;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var filename in openFileDialogImport.FileNames)
                {
                    _gateway = Path.GetFileName((Path.GetDirectoryName(filename)));
                    _csvFilename = (Path.GetFileName(filename));
                    
                    if (!_duplicateCSVFile.Contains(_csvFilename))
                    {
                        // Create a table with some rows.
                        DataTable newMeterReading = MakeTable(filename);

                        // Create the SqlBulkCopy object.
                        using (SqlBulkCopy s = new SqlBulkCopy(connection))
                        {
                            s.DestinationTableName = "MeterReading";
                            s.ColumnMappings.Add("SerialNumber", "SerialNumber");
                            s.ColumnMappings.Add("ReadingDate", "ReadingDate");
                            s.ColumnMappings.Add("CSVType", "CSVType");
                            s.ColumnMappings.Add("ReadingValue", "ReadingValue");
                            s.ColumnMappings.Add("LowBatteryAlr", "LowBatteryAlr");
                            s.ColumnMappings.Add("LeakAlr", "LeakAlr");
                            s.ColumnMappings.Add("MagneticTamperAlr", "MagneticTamperAlr");
                            s.ColumnMappings.Add("MeterErrorAlr", "MeterErrorAlr");
                            s.ColumnMappings.Add("BackFlowAlr", "BackFlowAlr");
                            s.ColumnMappings.Add("BrokenPipeAlr", "BrokenPipeAlr");
                            s.ColumnMappings.Add("EmptyPipeAlr", "EmptyPipeAlr");
                            s.ColumnMappings.Add("SpecificErr", "SpecificErr");
                            //TODO Add OMS Table
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

                                //ADD Mac Address in Gateway Table
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
                                        DMZId = null,
                                        CityId = null,
                                        CreatedBy = "1",
                                        EditedBy = "1",
                                        DocDate = DateTime.Now,
                                        Show = 1,
                                        LockCount = 0
                                    };
                                    var createGateway = _gatewayL.Create(new SmartDB(), ref gatewayC);
                                }

                                //TODO ADD Meter Serial to Meter Table via stored proc

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
                LabelDuplicate.Text = $"Number of duplicated CSV File/ s: {_duplicateCount}";
            });
        }
        private static DataTable MakeTable(string Filename)
        {
            DataTable newMeterReading = new DataTable("MeterReading");

            // Add three column objects to the table. 
            DataColumn meterReadingId = new DataColumn();
            meterReadingId.DataType = Type.GetType("System.Int32");
            meterReadingId.ColumnName = "Id";
            meterReadingId.AutoIncrement = true;
            newMeterReading.Columns.Add(meterReadingId);

            DataColumn serialNumber = new DataColumn();
            serialNumber.DataType = Type.GetType("System.String");
            serialNumber.ColumnName = "SerialNumber";
            newMeterReading.Columns.Add(serialNumber);

            DataColumn readingDate = new DataColumn();
            readingDate.DataType = Type.GetType("System.DateTime");
            readingDate.ColumnName = "ReadingDate";
            newMeterReading.Columns.Add(readingDate);

            DataColumn csvType = new DataColumn();
            csvType.DataType = Type.GetType("System.String");
            csvType.ColumnName = "CSVType";
            newMeterReading.Columns.Add(csvType);

            DataColumn readingValue = new DataColumn();
            readingValue.DataType = Type.GetType("System.String");
            readingValue.ColumnName = "ReadingValue";
            newMeterReading.Columns.Add(readingValue);

            DataColumn lowBatteryAlr = new DataColumn();
            lowBatteryAlr.DataType = Type.GetType("System.Int32");
            lowBatteryAlr.ColumnName = "LowBatteryAlr";
            newMeterReading.Columns.Add(lowBatteryAlr);

            DataColumn leakAlr = new DataColumn();
            leakAlr.DataType = Type.GetType("System.Int32");
            leakAlr.ColumnName = "LeakAlr";
            newMeterReading.Columns.Add(leakAlr);

            DataColumn magneticTamperAlr = new DataColumn();
            magneticTamperAlr.DataType = Type.GetType("System.Int32");
            magneticTamperAlr.ColumnName = "MagneticTamperAlr";
            newMeterReading.Columns.Add(magneticTamperAlr);

            DataColumn meterErrorAlr = new DataColumn();
            meterErrorAlr.DataType = Type.GetType("System.Int32");
            meterErrorAlr.ColumnName = "MeterErrorAlr";
            newMeterReading.Columns.Add(meterErrorAlr);

            DataColumn backFlowAlr = new DataColumn();
            backFlowAlr.DataType = Type.GetType("System.Int32");
            backFlowAlr.ColumnName = "BackFlowAlr";
            newMeterReading.Columns.Add(backFlowAlr);

            DataColumn brokenPipeAlr = new DataColumn();
            brokenPipeAlr.DataType = System.Type.GetType("System.Int32");
            brokenPipeAlr.ColumnName = "BrokenPipeAlr";
            newMeterReading.Columns.Add(brokenPipeAlr);

            DataColumn emptyPipeAlr = new DataColumn();
            emptyPipeAlr.DataType = Type.GetType("System.Int32");
            emptyPipeAlr.ColumnName = "EmptyPipeAlr";
            newMeterReading.Columns.Add(emptyPipeAlr);

            DataColumn specificErr = new DataColumn();
            specificErr.DataType = Type.GetType("System.Int32");
            specificErr.ColumnName = "SpecificErr";
            newMeterReading.Columns.Add(specificErr);

            //DataColumn flowratevalue = new DataColumn();
            //flowratevalue.DataType = Type.GetType("System.Int32");
            //flowratevalue.ColumnName = "FlowRateValue";
            //newMeterReading.Columns.Add(flowratevalue);

            //DataColumn appbusyalr = new DataColumn();
            //appbusyalr.DataType = Type.GetType("System.Int32");
            //appbusyalr.ColumnName = "AppBusyAlr";
            //newMeterReading.Columns.Add(appbusyalr);

            //DataColumn anyapperroralr = new DataColumn();
            //anyapperroralr.DataType = Type.GetType("System.Int32");
            //anyapperroralr.ColumnName = "AnyAppErrorAlr";
            //newMeterReading.Columns.Add(anyapperroralr);

            //DataColumn abnormalconditionalr = new DataColumn();
            //abnormalconditionalr.DataType = Type.GetType("System.Int32");
            //abnormalconditionalr.ColumnName = "AbnormalConditionAlr";
            //newMeterReading.Columns.Add(abnormalconditionalr);

            //DataColumn permanenterroralr = new DataColumn();
            //permanenterroralr.DataType = Type.GetType("System.Int32");
            //permanenterroralr.ColumnName = "PermanentErrorAlr";
            //newMeterReading.Columns.Add(permanenterroralr);

            //DataColumn temporaryerroralr = new DataColumn();
            //temporaryerroralr.DataType = Type.GetType("System.Int32");
            //temporaryerroralr.ColumnName = "TemporaryErrorAlr";
            //newMeterReading.Columns.Add(temporaryerroralr);

            //DataColumn specificerror1alr = new DataColumn();
            //specificerror1alr.DataType = Type.GetType("System.Int32");
            //specificerror1alr.ColumnName = "SpecificError1Alr";
            //newMeterReading.Columns.Add(specificerror1alr);

            //DataColumn specificerror2alr = new DataColumn();
            //specificerror2alr.DataType = Type.GetType("System.Int32");
            //specificerror2alr.ColumnName = "SpecificError2Alr";
            //newMeterReading.Columns.Add(specificerror2alr);

            //DataColumn specificerror3alr = new DataColumn();
            //specificerror3alr.DataType = Type.GetType("System.Int32");
            //specificerror3alr.ColumnName = "SpecificError3Alr";
            //newMeterReading.Columns.Add(specificerror3alr);

            // Create an array for DataColumn objects.
            DataColumn[] keys = new DataColumn[1];
            keys[0] = meterReadingId;
            newMeterReading.PrimaryKey = keys;

            //foreach (String file in Filenames)
            //{
            try
            {
                string[] allLines = File.ReadAllLines(Filename);
                var columnCount = allLines[0].Split(',').Length;
                if (columnCount == 11)
                {   //RDS
                    var query = from line in allLines
                                let data = line.Split(',')
                                select new
                                {
                                    Meter_Address = data[0],
                                    Reading_Date = data[1],
                                    Reading_Value_L = data[2],
                                    Low_Battery_Alr = data[3],
                                    Leak_Alr = data[4],
                                    Magnetic_Tamper_Alr = data[5],
                                    Meter_Error_Alr = data[6],
                                    Back_Flow_Alr = data[7],
                                    Broken_Pipe_Alr = data[8],
                                    Empty_Pipe_Alr = data[9],
                                    Specific_Alr = data[10]
                                };
                    DataRow row;
                    foreach (var q in query.ToList().Skip(1))
                    {
                        row = newMeterReading.NewRow();
                        row["SerialNumber"] = q.Meter_Address.Replace("-", "");
                        row["ReadingDate"] = DateTime.ParseExact(q.Reading_Date, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["CSVType"] = "RDS";
                        row["ReadingValue"] = q.Reading_Value_L;
                        row["LowBatteryAlr"] = Convert.ToInt32(q.Low_Battery_Alr);
                        row["LeakAlr"] = Convert.ToInt32(q.Leak_Alr);
                        row["MagneticTamperAlr"] = Convert.ToInt32(q.Magnetic_Tamper_Alr);
                        row["MeterErrorAlr"] = Convert.ToInt32(q.Meter_Error_Alr);
                        row["BackFlowAlr"] = Convert.ToInt32(q.Back_Flow_Alr);
                        row["BrokenPipeAlr"] = Convert.ToInt32(q.Broken_Pipe_Alr);
                        row["EmptyPipeAlr"] = Convert.ToInt32(q.Empty_Pipe_Alr);
                        row["SpecificErr"] = Convert.ToInt32(q.Specific_Alr);
                        newMeterReading.Rows.Add(row);
                    }
                }
                //if (columnCount == 13)
                //{ //OMS
                //    var query = from line in allLines
                //        let data = line.Split(',')
                //        select new
                //        {
                //            Meter_Address = data[0],
                //            Reading_Date = data[1],
                //            Reading_Value = data[2],
                //            Flow_Rate_Value = data[3],
                //            App_Busy_Alr = data[4],
                //            Any_App_Error_Alr = data[5],
                //            Abnormal_Condition_Alr = data[6],
                //            Low_Power_Battery_Alr = data[7],
                //            Permanent_Error_Alr = data[8],
                //            Temporary_Error_Alr = data[9],
                //            Specific_Error1_Alr = data[10],
                //            Specific_Error2_Alr = data[11],
                //            Specific_Error3_Alr = data[12]
                //        };
                //    DataRow row;
                //    foreach (var q in query.ToList().Skip(1))
                //    {
                //        row = newMeterReading.NewRow();
                //        row["SerialNumber"] = q.Meter_Address.Replace("-", "");
                //        row["ReadingDate"] = DateTime.ParseExact(q.Reading_Date, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                //        row["CSVType"] = "OMS";
                //        row["ReadingValue"] = q.Reading_Value;
                //        row["FlowRateValue"] = Convert.ToInt32(q.Flow_Rate_Value);
                //        row["AppBusyAlr"] = Convert.ToInt32(q.App_Busy_Alr);
                //        row["AnyAppErrorAlr"] = Convert.ToInt32(q.Any_App_Error_Alr);
                //        row["AbnormalConditionAlr"] = Convert.ToInt32(q.Abnormal_Condition_Alr);
                //        row["LowBatteryAlr"] = Convert.ToInt32(q.Low_Power_Battery_Alr);
                //        row["PermanentErrorAlr"] = Convert.ToInt32(q.Permanent_Error_Alr);
                //        row["TemporaryErrorAlr"] = Convert.ToInt32(q.Temporary_Error_Alr);
                //        row["SpecificError1Err"] = Convert.ToInt32(q.Specific_Error1_Alr);
                //        row["SpecificError2Err"] = Convert.ToInt32(q.Specific_Error2_Alr);
                //        row["SpecificError3Err"] = Convert.ToInt32(q.Specific_Error3_Alr);
                //        newMeterReading.Rows.Add(row);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Contact Admin: {ex.Message}", "Import");
            }
            //}
            newMeterReading.AcceptChanges();
            // Return the new DataTable. 
            return newMeterReading;
        }
    }
}
