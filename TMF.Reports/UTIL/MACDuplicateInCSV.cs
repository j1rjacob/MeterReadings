using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.Model;

namespace TMF.Reports.UTIL
{
    public static class MACDuplicateInCSV
    {
        private static BLL.Gateway _gateway = new BLL.Gateway();
       
        public static List<Gateway> Get(string Filename)
        {
            List<Gateway> result = new List<Gateway>();
            try
            {
                string[] allLines = File.ReadAllLines(Filename);
                var columnCount = allLines[0].Split(',').Length;
                if (columnCount == 16)
                {   //Gateways
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
                            Createdby = data[11],
                            Editedby = data[12],
                            DocDate = data[13],
                            Show = data[14],
                            LockCount = data[15],
                        };
                    List<Gateway> gateway1 = (List<Gateway>) query.Select(q => new Model.Gateway
                    {
                        MacAddress = q.MacAddress,
                        SimCard = q.SimCard,
                        X = Convert.ToDecimal(q.X),
                        Y = Convert.ToDecimal(q.Y),
                        Description = q.Description,
                        InstallationDate = DateTime.ParseExact(q.InstallationDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US")),
                        MaintenanceDate = DateTime.ParseExact(q.MaintenanceDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US")),
                        Status = q.Status,
                        IPAddress = q.IPAddress,
                        DMZId = q.DMZId,
                        CityId = q.CityId,
                        CreatedBy = q.Createdby,
                        EditedBy = q.Editedby,
                        DocDate = DateTime.ParseExact(q.DocDate, "HH:mm:ss dd/MM/yyyy", new CultureInfo("en-US")),
                        Show = Convert.ToInt32(q.Show),
                        LockCount = Convert.ToInt32(q.LockCount)
                    });

                    //Retrieve all Gateways
                    ReturnInfo getGatewayList = _gateway.GetGatewayBySimCard(new SmartDB(), "");
                    //bool flag = getCityList.Code == ErrorEnum.NoError;
                    List<Gateway> gateway = (List<Gateway>)getGatewayList.BizObject;

                    result = (List<Gateway>) gateway1.Except(gateway);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Contact Admin: {ex.Message}", "Import Gateways");
            }
            return result;
        }
    }
}
