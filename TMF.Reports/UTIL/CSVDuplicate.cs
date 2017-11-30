using System.Collections.Generic;
using System.IO;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.UTIL
{
    public static class CSVDuplicate
    {
        private static BLL.GatewayLog _gatewayLog = new BLL.GatewayLog();
        private static string _csvFilename;
        private static string _gateway;
        public static List<string> Get(string[] Filenames)
        {
            List<string> DuplicateCSV = new List<string>();
            foreach (var filename in Filenames)
            {
                _gateway = Path.GetFileName((Path.GetDirectoryName(filename)));
                _csvFilename = (Path.GetFileName(filename));

                //add to list gatewaylog duplicate
                ReturnInfo getGatewayLog = _gatewayLog.GetRecordsByMacCsv(new SmartDB(), _gateway, _csvFilename);
                bool flag = getGatewayLog.Code == ErrorEnum.NoError;
                if (flag)
                {
                    DuplicateCSV.Add(_csvFilename);
                }
            }
            return DuplicateCSV;
        }
    }
}
