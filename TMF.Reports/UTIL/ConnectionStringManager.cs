using System;
using System.Configuration;
using System.Data.SqlClient;

namespace TMF.Reports.UTIL
{
    public static class ConnectionStringManager
    {
        public static void Create(string datasource, string initialCatalog, string userId, string password)
        {
            try
            {
                var integratedSecurity = string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password);
                
                var connectionBuilder = new SqlConnectionStringBuilder
                {
                    DataSource = datasource,
                    InitialCatalog = initialCatalog,
                    UserID = userId,
                    Password = password,
                    PersistSecurityInfo = true
                };
               
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
               
                var connectionString = config.ConnectionStrings.ConnectionStrings["DefaultConnection"];
                if (connectionString == null)
                {
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings
                    {
                        Name = "DefaultConnection",
                        ConnectionString = connectionBuilder.ConnectionString,
                        ProviderName = "System.Data.SqlClient" 
                    });
                }
                else
                {
                    connectionString.ConnectionString = connectionBuilder.ConnectionString;
                }
               
                config.Save(ConfigurationSaveMode.Modified);
            }
            catch (Exception)
            {
                //TODO: Handle exception
                Console.WriteLine("Error adding connection string");
            }
        }
    }
}
