using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TMF.Core;

namespace TMF.Reports.UTIL
{
    public static class BulkRDS
    {
        private static BLL.GatewayLog _gatewayLog = new BLL.GatewayLog();
        private static BLL.Gateway _gateway = new TMF.Reports.BLL.Gateway();
        private static string _csvFilename;
        private static string _gw;
        public static void Import(string[] ofdFilenames, int max, 
                                  ProgressBar ProgressBarImportStatus, 
                                  Label LabelImported, 
                                  Label LabelDuplicate)
        {
            int count = 0;

            using (SqlConnection connection =
                new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                connection.Open();
                foreach (var filename in ofdFilenames)
                {
                    _gw = Path.GetFileName((Path.GetDirectoryName(filename)));
                    _csvFilename = (Path.GetFileName(filename));

                    if (!CSVDuplicate.Get(ofdFilenames).Contains(_csvFilename))
                    {
                        // Create a table with some rows.
                        DataTable newMeterReading = MakeTable.RDS(filename);

                        // Create the SqlBulkCopy object.
                        using (SqlBulkCopy s = new SqlBulkCopy(connection))
                        {
                            s.DestinationTableName = "MeterReading";
                            s.ColumnMappings.Add("SerialNumber", "SerialNumber");
                            s.ColumnMappings.Add("ReadingDate", "ReadingDate");
                            s.ColumnMappings.Add("CSVType", "CSVType");
                            s.ColumnMappings.Add("ReadingValue", "ReadingValue");
                            s.ColumnMappings.Add("LowBatteryAlr", "LowBatteryAlr");
                            s.ColumnMappings.Add("LeakAlr", "LeakAlr");
                            s.ColumnMappings.Add("MagneticTamperAlr", "MagneticTamperAlr");
                            s.ColumnMappings.Add("MeterErrorAlr", "MeterErrorAlr");
                            s.ColumnMappings.Add("BackFlowAlr", "BackFlowAlr");
                            s.ColumnMappings.Add("BrokenPipeAlr", "BrokenPipeAlr");
                            s.ColumnMappings.Add("EmptyPipeAlr", "EmptyPipeAlr");
                            s.ColumnMappings.Add("SpecificErr", "SpecificErr");
                            try
                            {
                                // Write from the source to the destination.
                                s.WriteToServer(newMeterReading);

                                //Add GatewayLog
                                TMF.Reports.Model.GatewayLog gatewayLog = new TMF.Reports.Model.GatewayLog()
                                {
                                    RDS = 1,
                                    OMS = 0,
                                    GatewayMacAddress = _gw,
                                    CSVFilename = _csvFilename,
                                    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                                    EditedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                                    DocDate = DateTime.Now,
                                    Show = 1,
                                    LockCount = 0
                                };
                                var createGatewayLog = _gatewayLog.Create(new SmartDB(), ref gatewayLog);

                                //ADD Mac Address in Gateway
                                if (!MacDuplicate.Get(ofdFilenames).Contains(_gw))
                                {
                                    TMF.Reports.Model.Gateway gatewayC = new TMF.Reports.Model.Gateway()
                                    {
                                        MacAddress = Regex.Replace(_gw, @"^(..)(..)(..)(..)(..)(..)$", "$1:$2:$3:$4:$5:$6"),
                                        SimCard = null,
                                        X = 0,
                                        Y = 0,
                                        Description = null,
                                        InstallationDate = DateTime.Parse("06/20/1986"),
                                        MaintenanceDate = DateTime.Parse("06/20/1986"),
                                        Status = "Active",
                                        IPAddress = "192.0.0.1",
                                        DMZId = null,
                                        CityId = null,
                                        CreatedBy = "1",
                                        EditedBy = "1",
                                        DocDate = DateTime.Now,
                                        Show = 1,
                                        LockCount = 0
                                    };
                                    _gateway.Create(new SmartDB(), ref gatewayC);
                                }

                                //TODO ADD Meter Serial to Meter Table via stored proc REPORT METER_SYNCSERIALNUMBER_METERREADING

                                bool flag = createGatewayLog.Code == ErrorEnum.NoError;
                                if (flag)
                                {
                                    ProgressBarImportStatus.Invoke((Action)delegate
                                    {
                                        ProgressBarImportStatus.Increment(1);
                                    });
                                    count++;
                                    if (count == max)
                                    {
                                        LabelImported.Invoke((Action)delegate
                                        {
                                            LabelImported.Text = $"Number of imported CSV File/s: {count} Ok";
                                        });
                                        Console.WriteLine($"Importing was successful.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Contact Admin: Gateway log error", "Import");
                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Contact Admin: {ex.Message}", "Import");
                            }
                        }
                    }
                }
            }
            LabelDuplicate.Invoke((Action)delegate
            {
                LabelDuplicate.Text = $"Number of duplicated CSV File/ s: {CSVDuplicate.Get(ofdFilenames).Count}";
            });
        }
    }
}
