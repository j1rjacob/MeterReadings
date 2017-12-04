using System.Windows.Forms;
using TMF.Reports.Model;

namespace MeterReports
{
    public partial class GatewayLogs : Form
    {
        private Button ButtonSearch;
        private Label label1;
        private Label LabelShow;
        private DataGridView DataGridViewGatewayLogs;
        private DateTimePicker DateTimePickerDateFrom;
        private DateTimePicker DateTimePickerDateTo;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn ColDate;
        private DataGridViewTextBoxColumn ColMeterRAWCount;
        private DataGridViewTextBoxColumn ColMeterOMSCount;
        private Label label2;
        private readonly CustomUser _currentUser;

        public GatewayLogs(CustomUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GatewayLogs));
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelShow = new System.Windows.Forms.Label();
            this.DataGridViewGatewayLogs = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMeterRAWCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMeterOMSCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGatewayLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AutoSize = true;
            this.ButtonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.BackgroundImage")));
            this.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(576, 13);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(151, 56);
            this.ButtonSearch.TabIndex = 25;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date To";
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.Location = new System.Drawing.Point(16, 72);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(262, 22);
            this.LabelShow.TabIndex = 28;
            this.LabelShow.Text = "SHOWING 1 OF 10 RECORDS";
            // 
            // DataGridViewGatewayLogs
            // 
            this.DataGridViewGatewayLogs.AllowUserToAddRows = false;
            this.DataGridViewGatewayLogs.AllowUserToDeleteRows = false;
            this.DataGridViewGatewayLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewGatewayLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.ColDate,
            this.ColMeterRAWCount,
            this.ColMeterOMSCount});
            this.DataGridViewGatewayLogs.Location = new System.Drawing.Point(16, 96);
            this.DataGridViewGatewayLogs.Name = "DataGridViewGatewayLogs";
            this.DataGridViewGatewayLogs.ReadOnly = true;
            this.DataGridViewGatewayLogs.Size = new System.Drawing.Size(712, 344);
            this.DataGridViewGatewayLogs.TabIndex = 27;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // ColMeterRAWCount
            // 
            this.ColMeterRAWCount.HeaderText = "MeterRAWCount";
            this.ColMeterRAWCount.Name = "ColMeterRAWCount";
            this.ColMeterRAWCount.ReadOnly = true;
            // 
            // ColMeterOMSCount
            // 
            this.ColMeterOMSCount.HeaderText = "MeterOMSCount";
            this.ColMeterOMSCount.Name = "ColMeterOMSCount";
            this.ColMeterOMSCount.ReadOnly = true;
            // 
            // DateTimePickerDateFrom
            // 
            this.DateTimePickerDateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerDateFrom.Location = new System.Drawing.Point(112, 16);
            this.DateTimePickerDateFrom.Name = "DateTimePickerDateFrom";
            this.DateTimePickerDateFrom.Size = new System.Drawing.Size(160, 27);
            this.DateTimePickerDateFrom.TabIndex = 29;
            // 
            // DateTimePickerDateTo
            // 
            this.DateTimePickerDateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerDateTo.Location = new System.Drawing.Point(390, 16);
            this.DateTimePickerDateTo.Name = "DateTimePickerDateTo";
            this.DateTimePickerDateTo.Size = new System.Drawing.Size(160, 27);
            this.DateTimePickerDateTo.TabIndex = 29;
            // 
            // GatewayLogs
            // 
            this.ClientSize = new System.Drawing.Size(742, 453);
            this.Controls.Add(this.DateTimePickerDateTo);
            this.Controls.Add(this.DateTimePickerDateFrom);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.DataGridViewGatewayLogs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GatewayLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway Logs";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGatewayLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
