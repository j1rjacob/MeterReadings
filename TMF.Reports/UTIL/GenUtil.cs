using System.Data.Entity.Core.EntityClient;
using TMF.Core;

namespace TMF.Reports.UTIL
{
    public static class GenUtil
    {
        public static string UppercaseFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }

        public static string EFConnectionString()
        {
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            var connectionSettings = new SmartDB().Connection;
            
            entityBuilder.Provider = "System.Data.SqlClient";
            
            entityBuilder.ProviderConnectionString = connectionSettings.ConnectionString;
            
            entityBuilder.Metadata = "res://*/TMFModel.csdl|res://*/TMFModel.ssdl|res://*/TMFModel.msl";
            return entityBuilder.ConnectionString;
        }
    }
}
