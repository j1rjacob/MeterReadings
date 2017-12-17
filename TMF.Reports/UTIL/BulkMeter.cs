using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TMF.Core;

namespace TMF.Reports.UTIL
{
    public class BulkMeter
    {
        private static string _csvFilename;
        private static string _gw;
        private static int _final;
        public static void Import(string[] ofdFilenames)
        {
            int count = 0;

            using (SqlConnection connection =
                new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                connection.Open();

                foreach (var filename in ofdFilenames)
                {
                    DataTable newMeter = MakeTable.Meter(filename);
                    DataTable fetchMeter = FetchTable.GetMeter();
                    
                    var fMeter = new HashSet<string>(fetchMeter.AsEnumerable()
                        .Select(x => x.Field<string>("SerialNumber")));
                    DataTable dtUniqueGateway = newMeter.AsEnumerable()
                        .Where(x => !fMeter.Contains(x.Field<string>("SerialNumber")))
                        .CopyToDataTable();

                    using (SqlBulkCopy s = new SqlBulkCopy(connection))
                    {
                        s.DestinationTableName = "Meter";
                        s.ColumnMappings.Add("SerialNumber", "SerialNumber");
                        s.ColumnMappings.Add("X", "X");
                        s.ColumnMappings.Add("Y", "Y");
                        s.ColumnMappings.Add("Status", "Status");
                        s.ColumnMappings.Add("HCN", "HCN");
                        s.ColumnMappings.Add("InstallationDate", "InstallationDate");
                        s.ColumnMappings.Add("MaintenanceDate", "MaintenanceDate");
                        s.ColumnMappings.Add("MeterTypeId", "MeterTypeId");
                        s.ColumnMappings.Add("MeterSizeId", "MeterSizeId");
                        s.ColumnMappings.Add("MeterProtocolId", "MeterProtocolId");
                        s.ColumnMappings.Add("DMZId", "DMZId");
                        s.ColumnMappings.Add("CityId", "CityId");
                        s.ColumnMappings.Add("Createdby", "Createdby");
                        s.ColumnMappings.Add("Editedby", "Editedby");
                        s.ColumnMappings.Add("DocDate", "DocDate");
                        s.ColumnMappings.Add("Show", "Show");
                        s.ColumnMappings.Add("LockCount", "LockCount");
                        try
                        {
                            s.WriteToServer(dtUniqueGateway);
                            Console.WriteLine($"Importing was successful.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Contact Admin: {ex.Message}", "Import");
                        }
                    }
                }
            }
        }
    }
}
