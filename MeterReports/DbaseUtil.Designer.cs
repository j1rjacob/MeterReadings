namespace MeterReports
{
    partial class DbaseUtil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbaseUtil));
            this.TabControlDBaseUtil = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ProgressBarDBUtil = new System.Windows.Forms.ProgressBar();
            this.ComboBoxDBBackup = new System.Windows.Forms.ComboBox();
            this.ButtonDBBackup = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonGetPath = new System.Windows.Forms.Button();
            this.LabelDBRestorePercent = new System.Windows.Forms.Label();
            this.LabelDBRestoreStatus = new System.Windows.Forms.Label();
            this.TextBoxDBRestore = new System.Windows.Forms.TextBox();
            this.ProgressBarDBRestore = new System.Windows.Forms.ProgressBar();
            this.ButtonDBRestore = new System.Windows.Forms.Button();
            this.SaveFileDialogBackup = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialogDBRestore = new System.Windows.Forms.OpenFileDialog();
            this.TabControlDBaseUtil.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlDBaseUtil
            // 
            this.TabControlDBaseUtil.Controls.Add(this.tabPage1);
            this.TabControlDBaseUtil.Controls.Add(this.tabPage2);
            this.TabControlDBaseUtil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlDBaseUtil.Location = new System.Drawing.Point(0, 0);
            this.TabControlDBaseUtil.Name = "TabControlDBaseUtil";
            this.TabControlDBaseUtil.SelectedIndex = 0;
            this.TabControlDBaseUtil.Size = new System.Drawing.Size(821, 206);
            this.TabControlDBaseUtil.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPercent);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.ProgressBarDBUtil);
            this.tabPage1.Controls.Add(this.ComboBoxDBBackup);
            this.tabPage1.Controls.Add(this.ButtonDBBackup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(11, 118);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(26, 22);
            this.lblPercent.TabIndex = 39;
            this.lblPercent.Text = "%";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(8, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 22);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "Status";
            // 
            // ProgressBarDBUtil
            // 
            this.ProgressBarDBUtil.Location = new System.Drawing.Point(8, 144);
            this.ProgressBarDBUtil.Name = "ProgressBarDBUtil";
            this.ProgressBarDBUtil.Size = new System.Drawing.Size(800, 23);
            this.ProgressBarDBUtil.TabIndex = 37;
            // 
            // ComboBoxDBBackup
            // 
            this.ComboBoxDBBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDBBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDBBackup.FormattingEnabled = true;
            this.ComboBoxDBBackup.Location = new System.Drawing.Point(8, 32);
            this.ComboBoxDBBackup.Name = "ComboBoxDBBackup";
            this.ComboBoxDBBackup.Size = new System.Drawing.Size(632, 28);
            this.ComboBoxDBBackup.TabIndex = 36;
            this.ComboBoxDBBackup.Click += new System.EventHandler(this.ComboBoxDBBackup_Click);
            // 
            // ButtonDBBackup
            // 
            this.ButtonDBBackup.AutoSize = true;
            this.ButtonDBBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDBBackup.BackgroundImage")));
            this.ButtonDBBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDBBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDBBackup.Location = new System.Drawing.Point(656, 32);
            this.ButtonDBBackup.Name = "ButtonDBBackup";
            this.ButtonDBBackup.Size = new System.Drawing.Size(151, 56);
            this.ButtonDBBackup.TabIndex = 35;
            this.ButtonDBBackup.Text = "BACKUP";
            this.ButtonDBBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDBBackup.UseVisualStyleBackColor = true;
            this.ButtonDBBackup.Click += new System.EventHandler(this.ButtonDBBackup_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonGetPath);
            this.tabPage2.Controls.Add(this.LabelDBRestorePercent);
            this.tabPage2.Controls.Add(this.LabelDBRestoreStatus);
            this.tabPage2.Controls.Add(this.TextBoxDBRestore);
            this.tabPage2.Controls.Add(this.ProgressBarDBRestore);
            this.tabPage2.Controls.Add(this.ButtonDBRestore);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonGetPath
            // 
            this.ButtonGetPath.Location = new System.Drawing.Point(600, 32);
            this.ButtonGetPath.Name = "ButtonGetPath";
            this.ButtonGetPath.Size = new System.Drawing.Size(48, 27);
            this.ButtonGetPath.TabIndex = 42;
            this.ButtonGetPath.Text = ". . .";
            this.ButtonGetPath.UseVisualStyleBackColor = true;
            this.ButtonGetPath.Click += new System.EventHandler(this.ButtonGetPath_Click);
            // 
            // LabelDBRestorePercent
            // 
            this.LabelDBRestorePercent.AutoSize = true;
            this.LabelDBRestorePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDBRestorePercent.Location = new System.Drawing.Point(8, 104);
            this.LabelDBRestorePercent.Name = "LabelDBRestorePercent";
            this.LabelDBRestorePercent.Size = new System.Drawing.Size(26, 22);
            this.LabelDBRestorePercent.TabIndex = 41;
            this.LabelDBRestorePercent.Text = "%";
            // 
            // LabelDBRestoreStatus
            // 
            this.LabelDBRestoreStatus.AutoSize = true;
            this.LabelDBRestoreStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDBRestoreStatus.Location = new System.Drawing.Point(8, 80);
            this.LabelDBRestoreStatus.Name = "LabelDBRestoreStatus";
            this.LabelDBRestoreStatus.Size = new System.Drawing.Size(61, 22);
            this.LabelDBRestoreStatus.TabIndex = 40;
            this.LabelDBRestoreStatus.Text = "Status";
            // 
            // TextBoxDBRestore
            // 
            this.TextBoxDBRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDBRestore.Location = new System.Drawing.Point(8, 32);
            this.TextBoxDBRestore.Name = "TextBoxDBRestore";
            this.TextBoxDBRestore.Size = new System.Drawing.Size(584, 27);
            this.TextBoxDBRestore.TabIndex = 39;
            // 
            // ProgressBarDBRestore
            // 
            this.ProgressBarDBRestore.Location = new System.Drawing.Point(8, 136);
            this.ProgressBarDBRestore.Name = "ProgressBarDBRestore";
            this.ProgressBarDBRestore.Size = new System.Drawing.Size(800, 23);
            this.ProgressBarDBRestore.TabIndex = 38;
            // 
            // ButtonDBRestore
            // 
            this.ButtonDBRestore.AutoSize = true;
            this.ButtonDBRestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDBRestore.BackgroundImage")));
            this.ButtonDBRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDBRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDBRestore.Location = new System.Drawing.Point(656, 24);
            this.ButtonDBRestore.Name = "ButtonDBRestore";
            this.ButtonDBRestore.Size = new System.Drawing.Size(151, 56);
            this.ButtonDBRestore.TabIndex = 36;
            this.ButtonDBRestore.Text = "RESTORE";
            this.ButtonDBRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDBRestore.UseVisualStyleBackColor = true;
            this.ButtonDBRestore.Click += new System.EventHandler(this.ButtonDBRestore_Click);
            // 
            // SaveFileDialogBackup
            // 
            this.SaveFileDialogBackup.FileName = "TMFBackup";
            this.SaveFileDialogBackup.Filter = "BAK |*.bak";
            // 
            // OpenFileDialogDBRestore
            // 
            this.OpenFileDialogDBRestore.FileName = "openFileDialog1";
            // 
            // DbaseUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 206);
            this.Controls.Add(this.TabControlDBaseUtil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbaseUtil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Utililty";
            this.TabControlDBaseUtil.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlDBaseUtil;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonDBBackup;
        private System.Windows.Forms.Button ButtonDBRestore;
        private System.Windows.Forms.ProgressBar ProgressBarDBUtil;
        private System.Windows.Forms.ComboBox ComboBoxDBBackup;
        private System.Windows.Forms.ProgressBar ProgressBarDBRestore;
        private System.Windows.Forms.TextBox TextBoxDBRestore;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogBackup;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label LabelDBRestorePercent;
        private System.Windows.Forms.Label LabelDBRestoreStatus;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogDBRestore;
        private System.Windows.Forms.Button ButtonGetPath;
    }
}