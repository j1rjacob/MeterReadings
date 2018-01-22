namespace MeterReports
{
    partial class FindAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAll));
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(24, 32);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(376, 27);
            this.TextBoxSearch.TabIndex = 36;
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Items.AddRange(new object[] {
            "Region",
            "DMZ",
            "Gateway",
            "Meter"});
            this.ComboBoxCity.Location = new System.Drawing.Point(24, 91);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.Size = new System.Drawing.Size(376, 28);
            this.ComboBoxCity.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "FIND WHAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "LOCATION";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(24, 128);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(376, 384);
            this.treeView1.TabIndex = 41;
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "region.png");
            this.imageListMain.Images.SetKeyName(1, "gateway.png");
            this.imageListMain.Images.SetKeyName(2, "energymeter.png");
            this.imageListMain.Images.SetKeyName(3, "info.png");
            // 
            // FindAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 528);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxCity);
            this.Controls.Add(this.TextBoxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindAll";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.ComboBox ComboBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageListMain;
    }
}