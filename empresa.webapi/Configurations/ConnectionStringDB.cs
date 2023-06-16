using Microsoft.Data.SqlClient;

namespace empresa.webapi.Configurations
{
    public class ConnectionStringDB
    {
        public SqlConnectionStringBuilder ConnectionStringApi(string Database)
        {
            var host = GlobalConfiguration.Configuration["ConnectionStrings:host"];
            var port = GlobalConfiguration.Configuration["ConnectionStrings:port"];
            var user = GlobalConfiguration.Configuration["ConnectionStrings:user"];
            var pass = GlobalConfiguration.Configuration["ConnectionStrings:pass"];

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                DataSource = $"{host},{port}",
                InitialCatalog = Database,
                UserID = user,
                Password = pass,
            };

            builder.ApplicationName = "dispositivos.webapi";
            builder.Encrypt = false;
            builder["Trusted_Connection"] = false;

            return builder;
        }
    }
}
