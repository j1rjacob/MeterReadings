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
            macAddress.AutoIncrement = true;
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
            ipAddress.ColumnName = "IPAdress";
            newGateway.Columns.Add(ipAddress);

            DataColumn DMZId = new DataColumn();
            DMZId.DataType = Type.GetType("System.Int32");
            DMZId.ColumnName = "BackFlowAlr";
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
                {   //RDS
                    var query = from line in allLines
                        let data = line.Split(',')
                        select new
                        {
                            MAC_ADDRESS = data[0],
                            SIM_CARD = data[1],
                            X = data[2],
                            Y = data[3],
                            DESCRIPTION = data[4],
                            INSTALLATION_DATE = data[5],
                            MAINTENANCE_DATE = data[6],
                            STATUS = data[7],
                            IP_ADDRESS = data[8],
                            DMZ_ID = data[9],
                            CITY_ID = data[10],
                            CREATED_BY = data[11],
                            EDITED_BY = data[12],
                            DOC_DATE = data[13],
                            SHOW = data[14],
                            LOCK_COUNT = data[15],
                        };
                    DataRow row;
                    foreach (var q in query.ToList().Skip(1))
                    {
                        row = newGateway.NewRow();
                        row["MacAddress"] = q.MAC_ADDRESS;
                        row["SimCard"] = q.SIM_CARD;
                        row["X"] = q.X;
                        row["Y"] = q.Y;
                        row["Description"] = q.DESCRIPTION;
                        row["InstallationDate"] = DateTime.ParseExact(q.INSTALLATION_DATE, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["MaintenanceDate"] = DateTime.ParseExact(q.MAINTENANCE_DATE, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["Status"] = q.STATUS;
                        row["IPAddress"] = q.IP_ADDRESS;
                        row["DMZId"] = Convert.ToInt32(q.DMZ_ID);
                        row["CityId"] = q.CITY_ID;
                        row["Createdby"] = q.CREATED_BY;
                        row["Editedby"] = q.EDITED_BY;
                        row["DocDate"] = DateTime.ParseExact(q.DOC_DATE, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US"));
                        row["Show"] = Convert.ToInt32(q.SHOW);
                        row["LockCount"] = Convert.ToInt32(q.LOCK_COUNT);
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
            DataColumn meterReadingId = new DataColumn();
            meterReadingId.DataType = Type.GetType("System.Int32");
            meterReadingId.ColumnName = "Id";
            meterReadingId.AutoIncrement = true;
            newMeter.Columns.Add(meterReadingId);

            DataColumn serialNumber = new DataColumn();
            serialNumber.DataType = Type.GetType("System.String");
            serialNumber.ColumnName = "SerialNumber";
            newMeter.Columns.Add(serialNumber);

            DataColumn readingDate = new DataColumn();
            readingDate.DataType = Type.GetType("System.DateTime");
            readingDate.ColumnName = "ReadingDate";
            newMeter.Columns.Add(readingDate);

            DataColumn csvType = new DataColumn();
            csvType.DataType = Type.GetType("System.String");
            csvType.ColumnName = "CSVType";
            newMeter.Columns.Add(csvType);

            DataColumn readingValue = new DataColumn();
            readingValue.DataType = Type.GetType("System.String");
            readingValue.ColumnName = "ReadingValue";
            newMeter.Columns.Add(readingValue);

            DataColumn lowBatteryAlr = new DataColumn();
            lowBatteryAlr.DataType = Type.GetType("System.Int32");
            lowBatteryAlr.ColumnName = "LowBatteryAlr";
            newMeter.Columns.Add(lowBatteryAlr);

            DataColumn leakAlr = new DataColumn();
            leakAlr.DataType = Type.GetType("System.Int32");
            leakAlr.ColumnName = "LeakAlr";
            newMeter.Columns.Add(leakAlr);

            DataColumn magneticTamperAlr = new DataColumn();
            magneticTamperAlr.DataType = Type.GetType("System.Int32");
            magneticTamperAlr.ColumnName = "MagneticTamperAlr";
            newMeter.Columns.Add(magneticTamperAlr);

            DataColumn meterErrorAlr = new DataColumn();
            meterErrorAlr.DataType = Type.GetType("System.Int32");
            meterErrorAlr.ColumnName = "MeterErrorAlr";
            newMeter.Columns.Add(meterErrorAlr);

            DataColumn backFlowAlr = new DataColumn();
            backFlowAlr.DataType = Type.GetType("System.Int32");
            backFlowAlr.ColumnName = "BackFlowAlr";
            newMeter.Columns.Add(backFlowAlr);

            DataColumn brokenPipeAlr = new DataColumn();
            brokenPipeAlr.DataType = System.Type.GetType("System.Int32");
            brokenPipeAlr.ColumnName = "BrokenPipeAlr";
            newMeter.Columns.Add(brokenPipeAlr);

            DataColumn emptyPipeAlr = new DataColumn();
            emptyPipeAlr.DataType = Type.GetType("System.Int32");
            emptyPipeAlr.ColumnName = "EmptyPipeAlr";
            newMeter.Columns.Add(emptyPipeAlr);

            DataColumn specificErr = new DataColumn();
            specificErr.DataType = Type.GetType("System.Int32");
            specificErr.ColumnName = "SpecificErr";
            newMeter.Columns.Add(specificErr);

            // Create an array for DataColumn objects.
            DataColumn[] keys = new DataColumn[1];
            keys[0] = meterReadingId;
            newMeter.PrimaryKey = keys;

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
                        row = newMeter.NewRow();
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
