using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using TMF.Maps;

namespace MeterReports
{
    public partial class GPS : Form
    {
        SerialPort _GPSCommPort;
        SerialPort _GPSSp;
        private EGIS.ShapeFileLib.PointD _marker = new EGIS.ShapeFileLib.PointD(0, 0);
        private EGIS.ShapeFileLib.PointD _currentMarkerPosition = new EGIS.ShapeFileLib.PointD(0, 0);
        private int _currentPacketIndex = 0;
        private const int _markerWidth = 10;
        private List<GPSPacket> _gpsDataList = new List<GPSPacket>();
        GPSPacket _gpsPoint;
        KSAMetersRenderSettings _rs;        

        public GPS()
        {
            InitializeComponent();

            LoadMaps();

            _gpsPoint = new GPSPacket();

            _gpsPoint.Latitude = 0;// 21.2303608;
            _gpsPoint.Longitude = 0;//40.4112419166667;
            _marker.X = _gpsPoint.Longitude;
            _marker.Y = _gpsPoint.Latitude;

            _GPSCommPort = new SerialPort();
            _GPSCommPort.BaudRate = 19200;
            _GPSCommPort.Parity = Parity.None;
            _GPSCommPort.StopBits = StopBits.One;
            _GPSCommPort.DataBits = 8;
            _GPSCommPort.Handshake = Handshake.RequestToSendXOnXOff;
            _GPSCommPort.DataReceived += new SerialDataReceivedEventHandler(GPSDataReceivedHandler);
        }
        private void LoadMaps()
        {   //TODO: Insert of map every DMZ must be dynamic
            string currentDIR = Application.StartupPath;
            //string roadsshapefile = currentDIR + "\\Taif OSM\\Taif Roads.shp";
            string roadsshapefile = currentDIR + "\\Maps\\ksa.shp";
            string metersshapefile = currentDIR + "\\Maps\\Taif Meters EPSG4326.shp";

            if (File.Exists(roadsshapefile))
                OpenRoadsfile(roadsshapefile);
            else
            {
                MessageBox.Show("Taif Map not found! Exiting program", "Error");
                Application.Exit();
            }

            if (File.Exists(metersshapefile))
                OpenMetersfile(metersshapefile);
            else
            {
                MessageBox.Show("Meter Map unfound! Exiting program", " Error ");
                Application.Exit();
            }
        }
        private void OpenRoadsfile(string path)
        {
            sfMapGIS.ClearShapeFiles();

            sfMapGIS.AddShapeFile(path, "Roads", "");

            EGIS.ShapeFileLib.ShapeFile sf = sfMapGIS[0];

            sf.RenderSettings.UseToolTip = false;
            sf.RenderSettings.ToolTipFieldName = sf.RenderSettings.FieldName;
            sf.RenderSettings.IsSelectable = false;
        }
        private void OpenMetersfile(string path)
        {
            sfMapGIS.AddShapeFile(path, "meters", "");

            EGIS.ShapeFileLib.ShapeFile sf = sfMapGIS[1];

            _rs = new KSAMetersRenderSettings(sf.RenderSettings, "Serial Num", sf);
            sf.RenderSettings.CustomRenderSettings = _rs;

            sf.RenderSettings.UseToolTip = false;
            sf.RenderSettings.ToolTipFieldName = sf.RenderSettings.FieldName;
            sf.RenderSettings.IsSelectable = false;

            sf.SelectRecord(0, true);
        }
        private void GPSDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            _GPSSp = (SerialPort)sender;

            string gpsstring = _GPSSp.ReadLine();
            //System.Diagnostics.Debug.WriteLine(gpsstring);

            if (gpsstring.Contains("$GPGGA"))
            {
                _gpsPoint.UpdateGPS(gpsstring);
                _marker.X = _gpsPoint.Longitude;
                _marker.Y = _gpsPoint.Latitude;

                System.Diagnostics.Debug.WriteLine(_gpsPoint.Longitude + " " + _gpsPoint.Latitude);
                
                sfMapGIS.Invoke((Action)delegate { sfMapGIS.Refresh(); });
            }
        }
        private void sfMapGIS_MouseUp(object sender, MouseEventArgs e)
        {
            //display a message box of a shape's attributes if it is clicked (within 5 pixels)
            Point pt = new Point(e.X, e.Y);
            //loop backwards on the shapefiles as layers are drawn in the order
            for (int n = sfMapGIS.ShapeFileCount - 1; n >= 0; --n)
            {
                int recordNumber = sfMapGIS.GetShapeIndexAtPixelCoord(n, pt, 5);
                if (recordNumber >= 0)
                {
                    StringBuilder sb = new StringBuilder();
                    string[] attributeValues = sfMapGIS[n].GetAttributeFieldValues(recordNumber);
                    string[] fieldNames = sfMapGIS[n].GetAttributeFieldNames();
                    for (int i = 0; i < fieldNames.Length; ++i)
                    {
                        if (i > 0) sb.Append("\n");
                        sb.Append(string.Format("{0}:{1}", fieldNames[i], attributeValues[i].Trim()));
                    }
                    MessageBox.Show(this, sb.ToString());
                    return;
                }
            }
        }
        private void sfMapGIS_Paint(object sender, PaintEventArgs e)
        {
            DrawMarker(e.Graphics, _marker.X, _marker.Y);
            //DrawCurrentMarker(e.Graphics, _currentMarkerPosition.X, _currentMarkerPosition.Y);
        }
        private void DrawMarker(Graphics g, double locX, double locY)
        {
            Point pt = sfMapGIS.GisPointToPixelCoord(locX, locY);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //draw a marker centered at the gis location
            //alternative is to draw an image/icon
            g.DrawLine(Pens.Red, pt.X, pt.Y - _markerWidth, pt.X, pt.Y + _markerWidth);
            g.DrawLine(Pens.Red, pt.X - _markerWidth, pt.Y, pt.X + _markerWidth, pt.Y);
            pt.Offset(-_markerWidth / 2, -_markerWidth / 2);
            g.FillEllipse(Brushes.Yellow, pt.X, pt.Y, _markerWidth, _markerWidth);
            g.DrawEllipse(Pens.Red, pt.X, pt.Y, _markerWidth, _markerWidth);
        }

        private void DrawCurrentMarker(Graphics g, double locX, double locY)
        {
            //convert the gis location to pixel coordinates
            Point pt = sfMapGIS.GisPointToPixelCoord(locX, locY);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //draw a marker centered at the gis location
            //alternative is to draw an image/icon
            g.DrawLine(Pens.Red, pt.X, pt.Y - _markerWidth, pt.X, pt.Y + _markerWidth);
            g.DrawLine(Pens.Red, pt.X - _markerWidth, pt.Y, pt.X + _markerWidth, pt.Y);
            pt.Offset(-_markerWidth / 2, -_markerWidth / 2);
            g.FillEllipse(Brushes.Blue, pt.X, pt.Y, _markerWidth, _markerWidth);
            g.DrawEllipse(Pens.Red, pt.X, pt.Y, _markerWidth, _markerWidth);
        }

        private void ProcessGPSData()
        {
            //gpsDataList = this.ProcessGPSDataFile(Application.StartupPath + "\\gpsdata.txt");
            //if (gpsDataList.Count > 0)
            //{
            var x = 23.77568D;
            var y = 40.68224D;
                //_currentMarkerPosition = new EGIS.ShapeFileLib.PointD(gpsDataList[0].Longitude, gpsDataList[0].Latitude);
                _currentMarkerPosition = new EGIS.ShapeFileLib.PointD(x, y);
                sfMapGIS.CentrePoint2D = _currentMarkerPosition;
            //}
            currentPacketIndex = 0;
        }
        //private List<GPSPacket> gpsDataList = new List<GPSPacket>();
        private int currentPacketIndex = 0;

        private void GPS_Load(object sender, EventArgs e)
        {
            try
            {
                ProcessGPSData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }        
    }
}
