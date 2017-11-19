namespace MeterReports
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DataGridViewUser = new System.Windows.Forms.DataGridView();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelShow = new System.Windows.Forms.Label();
            this.ComboBoxRole = new System.Windows.Forms.ComboBox();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(163, 96);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(216, 27);
            this.TextBoxUsername.TabIndex = 4;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(163, 61);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(216, 27);
            this.TextBoxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "ROLE";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(163, 136);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '$';
            this.TextBoxPassword.Size = new System.Drawing.Size(216, 27);
            this.TextBoxPassword.TabIndex = 5;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(163, 12);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(280, 27);
            this.TextBoxSearch.TabIndex = 5;
            // 
            // DataGridViewUser
            // 
            this.DataGridViewUser.AllowUserToAddRows = false;
            this.DataGridViewUser.AllowUserToDeleteRows = false;
            this.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColUsername,
            this.ColRole});
            this.DataGridViewUser.Location = new System.Drawing.Point(19, 304);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.ReadOnly = true;
            this.DataGridViewUser.Size = new System.Drawing.Size(640, 150);
            this.DataGridViewUser.TabIndex = 6;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AutoSize = true;
            this.ButtonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.BackgroundImage")));
            this.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(451, 8);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(151, 56);
            this.ButtonSearch.TabIndex = 7;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.AutoSize = true;
            this.ButtonNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNew.BackgroundImage")));
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Location = new System.Drawing.Point(19, 208);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(151, 56);
            this.ButtonNew.TabIndex = 7;
            this.ButtonNew.Text = "NEW";
            this.ButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AutoSize = true;
            this.ButtonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.BackgroundImage")));
            this.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.Location = new System.Drawing.Point(187, 208);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(151, 56);
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "EDIT";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(347, 208);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(151, 56);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(507, 208);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(151, 56);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.Location = new System.Drawing.Point(22, 276);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(262, 22);
            this.LabelShow.TabIndex = 8;
            this.LabelShow.Text = "SHOWING 1 OF 10 RECORDS";
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.Items.AddRange(new object[] {
            "Administrator",
            "Encoder"});
            this.ComboBoxRole.Location = new System.Drawing.Point(163, 176);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxRole.TabIndex = 9;
            this.ComboBoxRole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxRole_MouseClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColUsername
            // 
            this.ColUsername.DataPropertyName = "UserName";
            this.ColUsername.HeaderText = "Username";
            this.ColUsername.Name = "ColUsername";
            this.ColUsername.ReadOnly = true;
            // 
            // ColRole
            // 
            this.ColRole.HeaderText = "Role";
            this.ColRole.Name = "ColRole";
            this.ColRole.ReadOnly = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 464);
            this.Controls.Add(this.ComboBoxRole);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.DataGridViewUser);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DataGridView DataGridViewUser;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelShow;
        private System.Windows.Forms.ComboBox ComboBoxRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRole;
    }
}