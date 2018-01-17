using EGIS.ShapeFileLib;
using System.Collections.Generic;
using System.Drawing;

namespace TMF.Maps
{
    public class KSAMetersRenderSettings : ICustomRenderSettings
    {
        private List<Color> colorList;
        RenderSettings defaultSettings;
        Dictionary<string, int> metersListGIS;

        public KSAMetersRenderSettings(RenderSettings defaultSettings, string typeField, Dictionary<string, Color> roadtypeColors)
        {
            this.defaultSettings = defaultSettings;
            BuildColorList(defaultSettings, typeField, roadtypeColors);
        }

        public KSAMetersRenderSettings(RenderSettings defaultSettings, string serialNbr, ShapeFile shpfile)
        {
            this.defaultSettings = defaultSettings;
            this.defaultSettings.FillInterior = true;
            this.defaultSettings.OutlineColor = Color.Transparent;
            this.defaultSettings.MinZoomLevel = -1;
            this.defaultSettings.MaxZoomLevel = -1;

            this.defaultSettings.UseToolTip = false;
            this.defaultSettings.IsSelectable = false;

            BuildColorList(defaultSettings, serialNbr, shpfile);
        }

        private void BuildColorList(RenderSettings defaultSettings, string typeField, Dictionary<string, Color> roadtypeColors)
        {
            int fieldIndex = defaultSettings.DbfReader.IndexOfFieldName(typeField);
            if (fieldIndex >= 0)
            {
                colorList = new List<Color>();
                int numRecords = defaultSettings.DbfReader.DbfRecordHeader.RecordCount;
                for (int n = 0; n < numRecords; ++n)
                {
                    string nextField = defaultSettings.DbfReader.GetField(n, fieldIndex).Trim();
                    if (roadtypeColors.ContainsKey(nextField))
                    {
                        colorList.Add(roadtypeColors[nextField]);
                    }
                    else
                    {
                        colorList.Add(defaultSettings.FillColor);
                    }
                }
            }
        }

        private void BuildColorList(RenderSettings defaultSettings, string serialNbr, ShapeFile shpfile)
        {
            int fieldIndex = defaultSettings.DbfReader.IndexOfFieldName(serialNbr);
            if (fieldIndex >= 0)
            {
                colorList = new List<System.Drawing.Color>();
                metersListGIS = new Dictionary<string, int>(40000);

                int numRecords = defaultSettings.DbfReader.DbfRecordHeader.RecordCount;
                for (int n = 0; n < numRecords; ++n)
                {
                    colorList.Add(Color.Red);
                    metersListGIS.Add(shpfile.GetAttributeFieldValues(n)[fieldIndex].Trim(), n);
                }
            }
            else
            {
                //MessageBox.Show("Couldn't find Field Name");
            }
        }

        public bool UseCustomTooltips { get { return false; } }

        public bool UseCustomImageSymbols { get { return false; } }

        public Color GetRecordFillColor(int recordNumber)
        {
            if (colorList != null)
            {
                return colorList[recordNumber];
            }
            return defaultSettings.FillColor;
        }

        public Color GetRecordFontColor(int recordNumber)
        {
            return defaultSettings.FontColor;
        }

        public Image GetRecordImageSymbol(int recordNumber)
        {
            return defaultSettings.GetImageSymbol();
        }

        public Color GetRecordOutlineColor(int recordNumber)
        {
            return defaultSettings.OutlineColor;
        }

        public string GetRecordToolTip(int recordNumber)
        {
            return "";
        }

        public bool RenderShape(int recordNumber)
        {
            return true;
        }
    }
}
