using System.Collections.Generic;
using System.IO;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.UTIL
{
    public static class MacDuplicate
    {
        private static BLL.Gateway _gateway = new BLL.Gateway();
        private static string _csvFilename;
        private static string _gw;

        public static List<string> Get(string[] Filenames)
        {
            List<string> DuplicateMac = new List<string>();
            foreach (var filename in Filenames)
            {
                _gw = Path.GetFileName((Path.GetDirectoryName(filename)));
                _csvFilename = (Path.GetFileName(filename));

                //Add to list gateway duplicate
                ReturnInfo getGateway = _gateway.GetGatewayById(new SmartDB(), _gw);
                bool flag = getGateway.Code == ErrorEnum.NoError;
                if (flag)
                {
                    DuplicateMac.Add(_csvFilename);
                }
            }
            return DuplicateMac;
        }
    }
}
