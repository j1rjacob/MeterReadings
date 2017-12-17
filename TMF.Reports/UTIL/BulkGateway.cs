using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TMF.Core;

namespace TMF.Reports.UTIL
{
    public class BulkGateway
    {
        private static BLL.GatewayLog _gatewayLog = new BLL.GatewayLog();
        private static BLL.Gateway _gateway = new BLL.Gateway();
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
                    // Create a table with some rows.
                    DataTable newGateway = MakeTable.Gateway(filename);

                    //TODO Create temptable
                    DataTable fetchGateway = FetchTable.GetGateway();

                    //DataTable dtUniqueGateway = newGateway.AsEnumerable().Distinct().Except(
                    //    fetchGateway.AsEnumerable(), DataRowComparer.Default).CopyToDataTable();
                    var fGateway = new HashSet<string>(fetchGateway.AsEnumerable()
                        .Select(x => x.Field<string>("MacAddress")));
                    DataTable dtUniqueGateway = newGateway.AsEnumerable()
                        .Where(x => !fGateway.Contains(x.Field<string>("MacAddress")))
                        .CopyToDataTable();
                    
                    using (SqlBulkCopy s = new SqlBulkCopy(connection))
                    {
                        s.DestinationTableName = "Gateway";
                        s.ColumnMappings.Add("MacAddress", "MacAddress");
                        s.ColumnMappings.Add("SimCard", "SimCard");
                        s.ColumnMappings.Add("X", "X");
                        s.ColumnMappings.Add("Y", "Y");
                        s.ColumnMappings.Add("Description", "Description");
                        s.ColumnMappings.Add("InstallationDate", "InstallationDate");
                        s.ColumnMappings.Add("MaintenanceDate", "MaintenanceDate");
                        s.ColumnMappings.Add("IPAddress", "IPAddress");
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
