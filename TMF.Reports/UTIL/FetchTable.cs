using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using TMF.Core;

namespace TMF.Reports.UTIL
{
    public static class FetchTable
    {   //TODO Check when no data on the table
        public static DataTable GetGateway()
        {
            //DataTable dt = null;
            //SqlCommand cmd;
            //SqlDataAdapter da;
            ////DataSet ds = new DataSet();
            //using (SqlConnection connection =
            //        new SqlConnection(new SmartDB().Connection.ConnectionString))
            //{
            //    //Select only the n records.
            //    var strSql = "SELECT * FROM Gateway";

            //    cmd = connection.CreateCommand();
            //    cmd.CommandText = strSql;
            //    da = new SqlDataAdapter(cmd);
            //    //da.Fill(ds, "MeterReading");

            //    using (dt = new DataTable())
            //    {
            //        da.Fill(dt);
            //    }
            //    cmd.Dispose();
            //    da.Dispose();
            //    //ds.Dispose();
            //}
            using (SqlConnection conn = new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Gateway", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        ds.Locale = CultureInfo.InvariantCulture;
                        da.Fill(ds, "Gateway");

                        DataTable gateways = ds.Tables["Gateway"];

                        IEnumerable<DataRow> query =
                            from g in gateways.AsEnumerable()
                            select g;

                        // Create a table from the query.
                        DataTable boundTable = query.CopyToDataTable<DataRow>();
                        return boundTable;
                    }
                    //using (SqlDataReader dr = cmd.ExecuteReader())
                    //{
                    //    dt = new DataTable();
                    //    dt.Load(dr);
                    //    //return tb;
                    //}
                }
            }
            //return dt;
        }
        public static DataTable GetMeter()
        {
            using (SqlConnection conn = new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Meter", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        ds.Locale = CultureInfo.InvariantCulture;
                        da.Fill(ds, "Meter");

                        DataTable meters = ds.Tables["Meter"];

                        IEnumerable<DataRow> query =
                            from m in meters.AsEnumerable()
                            select m;

                        // Create a table from the query.
                        DataTable boundTable = query.CopyToDataTable<DataRow>();
                        return boundTable;
                    }
                }
            }
        }
    }
}