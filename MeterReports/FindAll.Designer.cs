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
            this.label1 = new System.Windows.Forms.Label();
            this.TreeViewFind = new System.Windows.Forms.TreeView();
            this.imageListFind = new System.Windows.Forms.ImageList(this.components);
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
            // TreeViewFind
            // 
            this.TreeViewFind.Location = new System.Drawing.Point(24, 72);
            this.TreeViewFind.Name = "TreeViewFind";
            this.TreeViewFind.Size = new System.Drawing.Size(376, 440);
            this.TreeViewFind.TabIndex = 41;
            // 
            // imageListFind
            // 
            this.imageListFind.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFind.ImageStream")));
            this.imageListFind.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFind.Images.SetKeyName(0, "region.png");
            this.imageListFind.Images.SetKeyName(1, "gateway.png");
            this.imageListFind.Images.SetKeyName(2, "energymeter.png");
            this.imageListFind.Images.SetKeyName(3, "info.png");
            // 
            // FindAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 528);
            this.Controls.Add(this.TreeViewFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView TreeViewFind;
        private System.Windows.Forms.ImageList imageListFind;
    }
}