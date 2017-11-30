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
    }
}
