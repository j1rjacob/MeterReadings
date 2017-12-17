using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMF.Reports.UTIL;

namespace MeterReports
{
    public partial class ImportGateway : Form
    {
        private ProgressBar ProgressBarImportStatus;
        private Label LabelDuplicate;
        private Label LabelImported;
        private string[] _fileNames;
        private IEnumerable<TMF.Reports.Model.Gateway> _removeDuplicateMac;
        public ImportGateway(string[] fileNames)
        {
            InitializeComponent();
            _fileNames = fileNames;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportGateway));
            this.ProgressBarImportStatus = new System.Windows.Forms.ProgressBar();
            this.LabelDuplicate = new System.Windows.Forms.Label();
            this.LabelImported = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBarImportStatus
            // 
            this.ProgressBarImportStatus.Location = new System.Drawing.Point(8, 74);
            this.ProgressBarImportStatus.Name = "ProgressBarImportStatus";
            this.ProgressBarImportStatus.Size = new System.Drawing.Size(367, 23);
            this.ProgressBarImportStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarImportStatus.TabIndex = 42;
            // 
            // LabelDuplicate
            // 
            this.LabelDuplicate.AutoSize = true;
            this.LabelDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDuplicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDuplicate.Location = new System.Drawing.Point(13, 42);
            this.LabelDuplicate.Name = "LabelDuplicate";
            this.LabelDuplicate.Size = new System.Drawing.Size(259, 18);
            this.LabelDuplicate.TabIndex = 40;
            this.LabelDuplicate.Text = "Number of duplicated MAC Address: 0";
            // 
            // LabelImported
            // 
            this.LabelImported.AutoSize = true;
            this.LabelImported.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelImported.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelImported.Location = new System.Drawing.Point(13, 10);
            this.LabelImported.Name = "LabelImported";
            this.LabelImported.Size = new System.Drawing.Size(287, 18);
            this.LabelImported.TabIndex = 41;
            this.LabelImported.Text = "Number of imported MAC Address/s: 0 Ok";
            // 
            // ImportGateway
            // 
            this.ClientSize = new System.Drawing.Size(382, 107);
            this.Controls.Add(this.ProgressBarImportStatus);
            this.Controls.Add(this.LabelDuplicate);
            this.Controls.Add(this.LabelImported);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportGateway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ImportGateway_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ImportGateway_Load(object sender, EventArgs e)
        {
            ImportMeterGateway();
        }

        private void ImportMeterGateway()
        {
            //foreach (var fileName in _fileNames)
            //{
            //    _removeDuplicateMac = MACDuplicateInCSV.Get(fileName);
            //}
           
            //ProgressBarImportStatus.Maximum =
            //    _max = (_fileNames.Length - _duplicateCSVFile.Count);

            //TODO: Decouple; Error same count on imported and duplicated.
            //LabelImported.Text = $"Number of imported MAC Address/s: {0} Ok";
            //LabelDuplicate.Text = $"Number of duplicated MAC Address/ s: {0}";
            try
            {
                Task.Factory.StartNew(() => BulkGateway.Import(_fileNames));
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error importing file {e.Message}");
            }
            
        }
    }
}
