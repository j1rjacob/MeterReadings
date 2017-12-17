namespace MeterReports
{
    partial class Citi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citi));
            this.LabelShow = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.DataGridViewCity = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalMeters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxTotalMeters = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderCity = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.Location = new System.Drawing.Point(19, 208);
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
            this.ButtonDelete.Location = new System.Drawing.Point(504, 140);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(151, 56);
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
            this.ButtonSave.Location = new System.Drawing.Point(344, 140);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(151, 56);
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
            this.ButtonEdit.Location = new System.Drawing.Point(184, 140);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(151, 56);
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
            this.ButtonNew.Location = new System.Drawing.Point(16, 140);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(151, 56);
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
            this.ButtonSearch.Location = new System.Drawing.Point(505, 8);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(151, 56);
            this.ButtonSearch.TabIndex = 23;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // DataGridViewCity
            // 
            this.DataGridViewCity.AllowUserToAddRows = false;
            this.DataGridViewCity.AllowUserToDeleteRows = false;
            this.DataGridViewCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColDescription,
            this.ColTotalMeters});
            this.DataGridViewCity.Location = new System.Drawing.Point(16, 236);
            this.DataGridViewCity.Name = "DataGridViewCity";
            this.DataGridViewCity.ReadOnly = true;
            this.DataGridViewCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCity.Size = new System.Drawing.Size(640, 150);
            this.DataGridViewCity.TabIndex = 18;
            this.DataGridViewCity.SelectionChanged += new System.EventHandler(this.DataGridViewCity_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColDescription
            // 
            this.ColDescription.DataPropertyName = "Description";
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            this.ColDescription.Width = 300;
            // 
            // ColTotalMeters
            // 
            this.ColTotalMeters.DataPropertyName = "TotalNumberOfMeters";
            this.ColTotalMeters.HeaderText = "Total Number of Meters";
            this.ColTotalMeters.Name = "ColTotalMeters";
            this.ColTotalMeters.ReadOnly = true;
            this.ColTotalMeters.Width = 280;
            // 
            // TextBoxTotalMeters
            // 
            this.TextBoxTotalMeters.Enabled = false;
            this.TextBoxTotalMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTotalMeters.Location = new System.Drawing.Point(280, 105);
            this.TextBoxTotalMeters.Name = "TextBoxTotalMeters";
            this.TextBoxTotalMeters.Size = new System.Drawing.Size(376, 27);
            this.TextBoxTotalMeters.TabIndex = 14;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(217, 12);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(280, 27);
            this.TextBoxSearch.TabIndex = 16;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxDescription.Enabled = false;
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(280, 70);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(376, 27);
            this.TextBoxDescription.TabIndex = 17;
            this.TextBoxDescription.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDescription_Validating);
            this.TextBoxDescription.Validated += new System.EventHandler(this.TextBoxDescription_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "TOTAL NUMBER OF METERS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "DESCRIPTION";
            // 
            // errorProviderCity
            // 
            this.errorProviderCity.ContainerControl = this;
            // 
            // Citi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(677, 397);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.DataGridViewCity);
            this.Controls.Add(this.TextBoxTotalMeters);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Citi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City";
            this.Load += new System.EventHandler(this.Citi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelShow;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridView DataGridViewCity;
        private System.Windows.Forms.TextBox TextBoxTotalMeters;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalMeters;
        private System.Windows.Forms.ErrorProvider errorProviderCity;
    }
}