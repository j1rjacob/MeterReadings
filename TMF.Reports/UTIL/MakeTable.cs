using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace TMF.Reports.UTIL
{
    public static class MakeTable
    {
        public static DataTable RDS(string Filename)
        {
            DataTable newMeterReading = new DataTable("MeterReading");

            // Add three column objects to the table. 
            DataColumn meterReadingId = new DataColumn();
            meterReadingId.DataType = Type.GetType("System.Int32");
            meterReadingId.ColumnName = "Id";
            meterReadingId.AutoIncrement = true;
            newMeterReading.Columns.Add(meterReadingId);

            DataColumn serialNumber = new DataColumn();
            serialNumber.DataType = Type.GetType("System.String");
            serialNumber.ColumnName = "SerialNumber";
            newMeterReading.Columns.Add(serialNumber);

            DataColumn readingDate = new DataColumn();
            readingDate.DataType = Type.GetType("System.DateTime");
            readingDate.ColumnName = "ReadingDate";
            newMeterReading.Columns.Add(readingDate);

            DataColumn csvType = new DataColumn();
            csvType.DataType = Type.GetType("System.String");
            csvType.ColumnName = "CSVType";
            newMeterReading.Columns.Add(csvType);

            DataColumn readingValue = new DataColumn();
            readingValue.DataType = Type.GetType("System.String");
            readingValue.ColumnName = "ReadingValue";
            newMeterReading.Columns.Add(readingValue);

            DataColumn lowBatteryAlr = new DataColumn();
            lowBatteryAlr.DataType = Type.GetType("System.Int32");
            lowBatteryAlr.ColumnName = "LowBatteryAlr";
            newMeterReading.Columns.Add(lowBatteryAlr);

            DataColumn leakAlr = new DataColumn();
            leakAlr.DataType = Type.GetType("System.Int32");
            leakAlr.ColumnName = "LeakAlr";
            newMeterReading.Columns.Add(leakAlr);

            DataColumn magneticTamperAlr = new DataColumn();
            magneticTamperAlr.DataType = Type.GetType("System.Int32");
            magneticTamperAlr.ColumnName = "MagneticTamperAlr";
            newMeterReading.Columns.Add(magneticTamperAlr);

            DataColumn meterErrorAlr = new DataColumn();
            meterErrorAlr.DataType = Type.GetType("System.Int32");
            meterErrorAlr.ColumnName = "MeterErrorAlr";
            newMeterReading.Columns.Add(meterErrorAlr);

            DataColumn backFlowAlr = new DataColumn();
            backFlowAlr.DataType = Type.GetType("System.Int32");
            backFlowAlr.ColumnName = "BackFlowAlr";
            newMeterReading.Columns.Add(backFlowAlr);

            DataColumn brokenPipeAlr = new DataColumn();
            brokenPipeAlr.DataType = System.Type.GetType("System.Int32");
            brokenPipeAlr.ColumnName = "BrokenPipeAlr";
            newMeterReading.Columns.Add(brokenPipeAlr);

            DataColumn emptyPipeAlr = new DataColumn();
            emptyPipeAlr.DataType = Type.GetType("System.Int32");
            emptyPipeAlr.ColumnName = "EmptyPipeAlr";
            newMeterReading.Columns.Add(emptyPipeAlr);

            DataColumn specificErr = new DataColumn();
            specificErr.DataType = Type.GetType("System.Int32");
            specificErr.ColumnName = "SpecificErr";
            newMeterReading.Columns.Add(specificErr);

            // Create an array for DataColumn objects.
            DataColumn[] keys = new DataColumn[1];
            keys[0] = meterReadingId;
            newMeterReading.PrimaryKey = keys;

            try
            {
                string[] allLines = File.ReadAllLines(Filename);
                var columnCount = allLines[0].Split(',').Length;
                if (columnCount == 11)
                {   //RDS
                    var query = from line in allLines
                        let data = line.Split(',')
                        select new
                        {
                            Meter_Address = data[0],
                            Reading_Date = data[1],
                            Reading_Value_L = data[2],
                            Low_Battery_Alr = data[3],
                            Leak_Alr = data[4],
                            Magnetic_Tamper_Alr = data[5],
                            Meter_Error_Alr = data[6],
                            Back_Flow_Alr = data[7],
                            Broken_Pipe_Alr = data[8],
                            Empty_Pipe_Alr = data[9],
                            Specific_Alr = data[10]
                        };
                    DataRow row;
                    foreach (var q in query.ToList().Skip(1))
                    {
                        row = newMeterReading.NewRow();
                        row["SerialNumber"] = q.Meter_Address.Replace("-", "");
                        row["ReadingDate"] = DateTime.ParseExact(q.Reading_Date, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["CSVType"] = "RDS";
                        row["ReadingValue"] = q.Reading_Value_L;
                        row["LowBatteryAlr"] = Convert.ToInt32(q.Low_Battery_Alr);
                        row["LeakAlr"] = Convert.ToInt32(q.Leak_Alr);
                        row["MagneticTamperAlr"] = Convert.ToInt32(q.Magnetic_Tamper_Alr);
                        row["MeterErrorAlr"] = Convert.ToInt32(q.Meter_Error_Alr);
                        row["BackFlowAlr"] = Convert.ToInt32(q.Back_Flow_Alr);
                        row["BrokenPipeAlr"] = Convert.ToInt32(q.Broken_Pipe_Alr);
                        row["EmptyPipeAlr"] = Convert.ToInt32(q.Empty_Pipe_Alr);
                        row["SpecificErr"] = Convert.ToInt32(q.Specific_Alr);
                        newMeterReading.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Contact Admin: {ex.Message}", "Import");
            }

            newMeterReading.AcceptChanges();

            return newMeterReading;
        } 
        public static DataTable Gateway(string Filename)
        {
            DataTable newGateway = new DataTable("Gateway");

            // Add three column objects to the table. 
            DataColumn macAddress = new DataColumn();
            macAddress.DataType = Type.GetType("System.String");
            macAddress.ColumnName = "MacAddress";
            //macAddress.AutoIncrement = true;
            newGateway.Columns.Add(macAddress);

            DataColumn simCard = new DataColumn();
            simCard.DataType = Type.GetType("System.String");
            simCard.ColumnName = "SimCard";
            newGateway.Columns.Add(simCard);

            DataColumn x = new DataColumn();
            x.DataType = Type.GetType("System.Decimal");
            x.ColumnName = "X";
            newGateway.Columns.Add(x);
            
            DataColumn y = new DataColumn();
            y.DataType = Type.GetType("System.Decimal");
            y.ColumnName = "Y";
            newGateway.Columns.Add(y);

            DataColumn description = new DataColumn();
            description.DataType = Type.GetType("System.String");
            description.ColumnName = "Description";
            newGateway.Columns.Add(description);

            DataColumn installationDate = new DataColumn();
            installationDate.DataType = Type.GetType("System.DateTime");
            installationDate.ColumnName = "InstallationDate";
            newGateway.Columns.Add(installationDate);
           
            DataColumn maintenanceDate = new DataColumn();
            maintenanceDate.DataType = Type.GetType("System.DateTime");
            maintenanceDate.ColumnName = "MaintenanceDate";
            newGateway.Columns.Add(maintenanceDate);

            DataColumn status = new DataColumn();
            status.DataType = Type.GetType("System.String");
            status.ColumnName = "Status";
            newGateway.Columns.Add(status);

            DataColumn ipAddress = new DataColumn();
            ipAddress.DataType = Type.GetType("System.String");
            ipAddress.ColumnName = "IPAddress";
            newGateway.Columns.Add(ipAddress);

            DataColumn DMZId = new DataColumn();
            DMZId.DataType = Type.GetType("System.Int32");
            DMZId.ColumnName = "DMZId";
            newGateway.Columns.Add(DMZId);

            DataColumn cityId = new DataColumn();
            cityId.DataType = Type.GetType("System.String");
            cityId.ColumnName = "CityId";
            newGateway.Columns.Add(cityId);

            DataColumn createdBy = new DataColumn();
            createdBy.DataType = Type.GetType("System.String");
            createdBy.ColumnName = "CreatedBy";
            newGateway.Columns.Add(createdBy);

            DataColumn editedBy = new DataColumn();
            editedBy.DataType = Type.GetType("System.String");
            editedBy.ColumnName = "EditedBy";
            newGateway.Columns.Add(editedBy);

            DataColumn docDate = new DataColumn();
            docDate.DataType = Type.GetType("System.DateTime");
            docDate.ColumnName = "DocDate";
            newGateway.Columns.Add(docDate);

            DataColumn show = new DataColumn();
            show.DataType = Type.GetType("System.Int32");
            show.ColumnName = "Show";
            newGateway.Columns.Add(show);

            DataColumn lockCount = new DataColumn();
            lockCount.DataType = Type.GetType("System.Int32");
            lockCount.ColumnName = "LockCount";
            newGateway.Columns.Add(lockCount);

            // Create an array for DataColumn objects.
            DataColumn[] keys = new DataColumn[1];
            keys[0] = macAddress;
            newGateway.PrimaryKey = keys;

            try
            {
                string[] allLines = File.ReadAllLines(Filename);
                var columnCount = allLines[0].Split(',').Length;
                if (columnCount == 16)
                {//Gateway
                    var query = from line in allLines
                                let data = line.Split(',')
                                select new
                                {
                                    MacAddress = data[0],
                                    SimCard = data[1],
                                    X = data[2],
                                    Y = data[3],
                                    Description = data[4],
                                    InstallationDate = data[5],
                                    MaintenanceDate = data[6],
                                    Status = data[7],
                                    IPAddress = data[8],
                                    DMZId = data[9],
                                    CityId = data[10],
                                    CreatedBy = data[11],
                                    EditedBy = data[12],
                                    DocDate = data[13],
                                    Show = data[14],
                                    LockCount = data[15]
                                };
                    DataRow row;
                    foreach (var q in query.ToList().Skip(1))
                    {
                        row = newGateway.NewRow();
                        row["MacAddress"] = q.MacAddress;
                        row["SimCard"] = q.SimCard;
                        row["X"] = Convert.ToDecimal(q.X);
                        row["Y"] = Convert.ToDecimal(q.Y);
                        row["Description"] = q.Description;
                        row["InstallationDate"] = Convert.ToDateTime(q.InstallationDate); //DateTime.ParseExact(q.InstallationDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["MaintenanceDate"] = Convert.ToDateTime(q.MaintenanceDate); //DateTime.ParseExact(q.MaintenanceDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["Status"] = q.Status;
                        row["IPAddress"] = q.IPAddress;
                        row["DMZId"] = Convert.ToInt32(q.DMZId);
                        row["CityId"] = q.CityId;
                        row["Createdby"] = q.CreatedBy;
                        row["Editedby"] = q.EditedBy;
                        row["DocDate"] = Convert.ToDateTime(q.DocDate); //DateTime.ParseExact(q.DocDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["Show"] = Convert.ToInt32(q.Show);
                        row["LockCount"] = Convert.ToInt32(q.LockCount);
                        Console.WriteLine(row);
                        newGateway.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Contact Admin: {ex.Message}", "Import");
            }

            newGateway.AcceptChanges();

            return newGateway;
        }
        public static DataTable Meter(string Filename)
        {
            DataTable newMeter = new DataTable("Meter");

            // Add three column objects to the table. 
            DataColumn serialNumber = new DataColumn();
            serialNumber.DataType = Type.GetType("System.String");
            serialNumber.ColumnName = "SerialNumber";
            //serialNumber.AutoIncrement = true;
            newMeter.Columns.Add(serialNumber);

            DataColumn X = new DataColumn();
            X.DataType = Type.GetType("System.Decimal");
            X.ColumnName = "X";
            newMeter.Columns.Add(X);

            DataColumn Y = new DataColumn();
            Y.DataType = Type.GetType("System.Decimal");
            Y.ColumnName = "Y";
            newMeter.Columns.Add(Y);

            DataColumn status = new DataColumn();
            status.DataType = Type.GetType("System.String");
            status.ColumnName = "Status";
            newMeter.Columns.Add(status);

            DataColumn hcn = new DataColumn();
            hcn.DataType = Type.GetType("System.String");
            hcn.ColumnName = "HCN";
            newMeter.Columns.Add(hcn);

            DataColumn installationDate = new DataColumn();
            installationDate.DataType = Type.GetType("System.DateTime");
            installationDate.ColumnName = "InstallationDate";
            newMeter.Columns.Add(installationDate);

            DataColumn maintenanceDate = new DataColumn();
            maintenanceDate.DataType = Type.GetType("System.DateTime");
            maintenanceDate.ColumnName = "MaintenanceDate";
            newMeter.Columns.Add(maintenanceDate);

            DataColumn meterTypeId = new DataColumn();
            meterTypeId.DataType = Type.GetType("System.Int32");
            meterTypeId.ColumnName = "MeterTypeId";
            newMeter.Columns.Add(meterTypeId);

            DataColumn meterSizeId = new DataColumn();
            meterSizeId.DataType = Type.GetType("System.Int32");
            meterSizeId.ColumnName = "MeterSizeId";
            newMeter.Columns.Add(meterSizeId);

            DataColumn meterProtocolId = new DataColumn();
            meterProtocolId.DataType = System.Type.GetType("System.Int32");
            meterProtocolId.ColumnName = "MeterProtocolId";
            newMeter.Columns.Add(meterProtocolId);

            DataColumn dmzId = new DataColumn();
            dmzId.DataType = Type.GetType("System.Int32");
            dmzId.ColumnName = "DMZId";
            newMeter.Columns.Add(dmzId);

            DataColumn cityId = new DataColumn();
            cityId.DataType = Type.GetType("System.String");
            cityId.ColumnName = "CityId";
            newMeter.Columns.Add(cityId);

            DataColumn createdBy = new DataColumn();
            createdBy.DataType = Type.GetType("System.String");
            createdBy.ColumnName = "CreatedBy";
            newMeter.Columns.Add(createdBy);

            DataColumn editedBy = new DataColumn();
            editedBy.DataType = Type.GetType("System.String");
            editedBy.ColumnName = "EditedBy";
            newMeter.Columns.Add(editedBy);

            DataColumn docDate = new DataColumn();
            docDate.DataType = Type.GetType("System.DateTime");
            docDate.ColumnName = "DocDate";
            newMeter.Columns.Add(docDate);

            DataColumn show = new DataColumn();
            show.DataType = Type.GetType("System.Int32");
            show.ColumnName = "Show";
            newMeter.Columns.Add(show);

            DataColumn lockCount = new DataColumn();
            lockCount.DataType = Type.GetType("System.Int32");
            lockCount.ColumnName = "LockCount";
            newMeter.Columns.Add(lockCount);

            // Create an array for DataColumn objects.
            DataColumn[] keys = new DataColumn[1];
            keys[0] = serialNumber;
            newMeter.PrimaryKey = keys;

            try
            {
                string[] allLines = File.ReadAllLines(Filename);
                var columnCount = allLines[0].Split(',').Length;
                if (columnCount == 17)
                {   //RDS
                    var query = from line in allLines
                        let data = line.Split(',')
                        select new
                        {
                            SerialNumber = data[0],
                            X = data[1],
                            Y = data[2],
                            Status = data[3],
                            HCN = data[4],
                            InstallationDate = data[5],
                            MaintenanceDate = data[6],
                            MeterTypeId = data[7],
                            MeterSizeId = data[8],
                            MeterProtocolId = data[9],
                            DMZId = data[10],
                            CityId = data[11],
                            Createdby = data[12],
                            Editedby = data[13],
                            DocDate = data[14],
                            Show = data[15],
                            LockCount = data[16],
                        };
                    DataRow row;
                    foreach (var q in query.ToList().Skip(1))
                    {
                        row = newMeter.NewRow();
                        row["SerialNumber"] = q.SerialNumber;
                        row["X"] = q.X;
                        row["Y"] = q.Y;
                        row["Status"] = q.Status;
                        row["HCN"] = q.HCN;
                        row["InstallationDate"] = Convert.ToDateTime(q.InstallationDate); //DateTime.ParseExact(q.InstallationDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["MaintenanceDate"] = Convert.ToDateTime(q.MaintenanceDate); //DateTime.ParseExact(q.MaintenanceDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["MeterTypeId"] = q.MeterTypeId;
                        row["MeterSizeId"] = q.MeterSizeId;
                        row["MeterProtocolId"] = q.MeterProtocolId;
                        row["DMZId"] = Convert.ToInt32(q.DMZId);
                        row["CityId"] = q.CityId;
                        row["Createdby"] = q.Createdby;
                        row["Editedby"] = q.Editedby;
                        row["DocDate"] = Convert.ToDateTime(q.DocDate); //DateTime.ParseExact(q.DocDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["Show"] = Convert.ToInt32(q.Show);
                        row["LockCount"] = Convert.ToInt32(q.LockCount);
                        newMeter.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Contact Admin: {ex.Message}", "Import");
            }

            newMeter.AcceptChanges();

            return newMeter;
        } 
    }
}
