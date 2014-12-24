namespace TaskLibrary
{
    public partial class Database : System.Data.Entity.DbContext
    {
        public Database(string connectionString)
            : base(connectionString)
        {
        }
    }

    public class DB : Database
    {
        private DB(string connectionString) : base(connectionString)
        {
            
        }
        public static DB Connect(string host, string catalog, string user, string pass)
        {
            try
            {
                var sqlBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder
                {
                    DataSource = host,
                    InitialCatalog = catalog,
                    PersistSecurityInfo = true,
                    IntegratedSecurity = false,
                    MultipleActiveResultSets = true,

                    UserID = user,
                    Password = pass,
                };


                var entityConnectionStringBuilder = new System.Data.EntityClient.EntityConnectionStringBuilder
                {
                    Provider = "System.Data.SqlClient",
                    ProviderConnectionString = sqlBuilder.ConnectionString,
                    Metadata = "res://*/Database.csdl|res://*/Database.ssdl|res://*/Database.msl",
                };


                return new DB(entityConnectionStringBuilder.ConnectionString);
            }
            catch
            {
                return new DB("name=DatabaseConfiguration");
            }
        }
    }
}
