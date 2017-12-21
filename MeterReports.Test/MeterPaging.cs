using NUnit.Framework;
using System;
using System.Data;
using System.Data.SqlClient;
using TMF.Core;

namespace MeterReports.Test
{
    [TestFixture]
    public class MeterPaging
    {
        [Test]
        public void Paging_Equal_10()
        {
            //Arrange
            SqlConnection conn = new SmartDB().Connection;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd = new SqlCommand("REPORT METER_PAGING", conn);
                cmd.Parameters.Add(new SqlParameter("@PageNumber", 1));
                cmd.Parameters.Add(new SqlParameter("@RowspPage", 10));
                cmd.Parameters.Add(new SqlParameter("@Query", ""));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception)
            {
               
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            //Act
            //var createCity = _city.Create(new SmartDB(), ref city);
            //bool flag = createCity.Code == ErrorEnum.NoError;
            int x=dt.Rows.Count;
            //Assert
            Assert.AreEqual(x,9);
        }
    }
}
