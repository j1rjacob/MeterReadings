using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DMZ()
        {
            InitializeComponent();
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
            // 
            // DataGridViewDMZ
            // 
            this.DataGridViewDMZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDMZ.Location = new System.Drawing.Point(16, 268);
            this.DataGridViewDMZ.Name = "DataGridViewDMZ";
            this.DataGridViewDMZ.Size = new System.Drawing.Size(640, 150);
            this.DataGridViewDMZ.TabIndex = 30;
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
            this.Text = "DMZ";
            this.Load += new System.EventHandler(this.DMZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDMZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DMZ_Load(object sender, EventArgs e)
        {

        }
    }
}
