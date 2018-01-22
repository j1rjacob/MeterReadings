namespace MeterReports
{
    partial class GPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPS));
            this.sfMapGIS = new EGIS.Controls.SFMap();
            this.SuspendLayout();
            // 
            // sfMapGIS
            // 
            this.sfMapGIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfMapGIS.CentrePoint2D = ((EGIS.ShapeFileLib.PointD)(resources.GetObject("sfMapGIS.CentrePoint2D")));
            this.sfMapGIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfMapGIS.Location = new System.Drawing.Point(0, 0);
            this.sfMapGIS.MapBackColor = System.Drawing.SystemColors.Control;
            this.sfMapGIS.Name = "sfMapGIS";
            this.sfMapGIS.PanSelectMode = EGIS.Controls.PanSelectMode.Pan;
            this.sfMapGIS.RenderQuality = EGIS.ShapeFileLib.RenderQuality.Auto;
            this.sfMapGIS.Size = new System.Drawing.Size(897, 506);
            this.sfMapGIS.TabIndex = 0;
            this.sfMapGIS.UseMercatorProjection = false;
            this.sfMapGIS.ZoomLevel = 1D;
            this.sfMapGIS.ZoomToSelectedExtentWhenCtrlKeydown = false;
            this.sfMapGIS.Paint += new System.Windows.Forms.PaintEventHandler(this.sfMapGIS_Paint);
            this.sfMapGIS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sfMapGIS_MouseUp);
            // 
            // GPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 506);
            this.Controls.Add(this.sfMapGIS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GPS";
            this.Text = "GPS";
            this.Load += new System.EventHandler(this.GPS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EGIS.Controls.SFMap sfMapGIS;
    }
}