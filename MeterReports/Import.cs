using System;
using System.IO;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using TMF.Core;

namespace MeterReports
{
    public partial class Import : Form
    {
        private Label label2;
        private ProgressBar progressBar1;
        private Button ButtonReplace;
        private Button ButtonSkip;
        private OpenFileDialog openFileDialogImport;
        private Label label1;
        private readonly TMF.Reports.BLL.MeterReading _meterReading;

        public Import()
        {
            InitializeComponent();
            _meterReading = new TMF.Reports.BLL.MeterReading();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ButtonReplace = new System.Windows.Forms.Button();
            this.ButtonSkip = new System.Windows.Forms.Button();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))),
                ((int) (((byte) (0)))));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Number of Meter Updated: 10 Ok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Number of Meter Duplicated: 20";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(367, 23);
            this.progressBar1.TabIndex = 39;
            // 
            // ButtonReplace
            // 
            this.ButtonReplace.AutoSize = true;
            this.ButtonReplace.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("ButtonReplace.BackgroundImage")));
            this.ButtonReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.ButtonSkip.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("ButtonSkip.BackgroundImage")));
            this.ButtonSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Meter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonReplace_Click(object sender, EventArgs e)
        {//TODO CHANGE THIS REAL IMPORT
            ImportMeterSerialNumber();
        }

        private void ImportMeterSerialNumber()
        {
            throw new NotImplementedException();
        }

        private void ButtonSkip_Click(object sender, EventArgs e)
        {
            if (openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialogImport.FileNames)
                {
                    try
                    {
                        string[] allLines = File.ReadAllLines(file);

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
                            foreach (var q in query.ToList().Skip(1))
                            {
                                //MessageBox.Show(q.Meter_Address);
                                TMF.Reports.Model.MeterReading meterReading = new TMF.Reports.Model.MeterReading()
                                {   //TODO User id for CreatedBy
                                    Id = Guid.NewGuid().ToString("N"),
                                    SerialNumber = q.Meter_Address,
                                    ReadingDate = Convert.ToDateTime(q.Reading_Date),
                                    CSVType = "RDS",
                                    ReadingValue = q.Reading_Value_L,
                                    LowBatteryAlr = Convert.ToInt32(q.Low_Battery_Alr),
                                    LeakAlr = Convert.ToInt32(q.Leak_Alr),
                                    MagneticTamperAlr = Convert.ToInt32(q.Magnetic_Tamper_Alr),
                                    MeterErrorAlr = Convert.ToInt32(q.Meter_Error_Alr),
                                    BackFlowAlr = Convert.ToInt32(q.Back_Flow_Alr),
                                    BrokenPipeAlr = Convert.ToInt32(q.Broken_Pipe_Alr),
                                    EmptyPipeAlr = Convert.ToInt32(q.Empty_Pipe_Alr),
                                    SpecificErr = Convert.ToInt32(q.Specific_Alr),
                                    CreatedBy = "1",
                                    DocDate = DateTime.Now,
                                    Show = 1,
                                    LockCount = 0
                                };
                                var createMeterReading = _meterReading.Create(new SmartDB(), ref meterReading);
                            }
                        }
                        if (columnCount == 13)
                        {   //OMS
                                var query = from line in allLines
                                let data = line.Split(',')
                                select new
                                {
                                    Meter_Address = data[0],
                                    Reading_Date = data[1],
                                    Reading_Value = data[2],
                                    Flow_Rate_Value = data[3],
                                    App_Busy_Alr = data[4],
                                    Any_App_Error_Alr = data[5],
                                    Abnormal_Condition_Alr = data[6],
                                    Low_Power_Battery_Alr = data[7],
                                    Permanent_Error_Alr = data[8],
                                    Temporary_Error_Alr = data[9],
                                    Specific_Error1_Alr = data[10],
                                    Specific_Error2_Alr = data[11],
                                    Specific_Error3_Alr = data[12]
                                };
                            foreach (var q in query.ToList().Skip(1))
                            {
                                TMF.Reports.Model.MeterReading meterReading = new TMF.Reports.Model.MeterReading()
                                {   //TODO User id for CreatedBy
                                    Id = Guid.NewGuid().ToString("N"),
                                    SerialNumber = q.Meter_Address,
                                    ReadingDate = Convert.ToDateTime(q.Reading_Date),
                                    CSVType = "OMS",
                                    ReadingValue = q.Reading_Value,
                                    FlowRateValue = Convert.ToInt32(q.Flow_Rate_Value),
                                    AppBusyAlr = Convert.ToInt32(q.App_Busy_Alr),
                                    AnyAppErrorAlr = Convert.ToInt32(q.Any_App_Error_Alr),
                                    AbnormalConditionAlr = Convert.ToInt32(q.Abnormal_Condition_Alr),
                                    LowBatteryAlr = Convert.ToInt32(q.Low_Power_Battery_Alr),
                                    PermanentErrorAlr = Convert.ToInt32(q.Permanent_Error_Alr),
                                    TemporaryErrorAlr = Convert.ToInt32(q.Temporary_Error_Alr),
                                    SpecificError1Alr = Convert.ToInt32(q.Specific_Error1_Alr),
                                    SpecificError2Alr = Convert.ToInt32(q.Specific_Error2_Alr),
                                    SpecificError3Alr = Convert.ToInt32(q.Specific_Error3_Alr),
                                    CreatedBy = "1",
                                    DocDate = DateTime.Now,
                                    Show = 1,
                                    LockCount = 0
                                };
                                var createMeterReading = _meterReading.Create(new SmartDB(), ref meterReading);
                            }
                        }
                    }
                    catch (SecurityException ex)
                    {
                        //The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                                        "Error message: " + ex.Message + "\n\n" +
                                        "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        //Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                                        + ". You may not have permission to read the file, or " +
                                        "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }
    }
}
