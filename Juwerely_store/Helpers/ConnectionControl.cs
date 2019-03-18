using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juwerely_store.Helpers
{
    public class ConnectionControl
    {
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder sql = new SqlConnectionStringBuilder();
            sql.DataSource = Properties.Settings.Default.DBServerName;
            sql.InitialCatalog = Properties.Settings.Default.DBDatabaseName;
            sql.IntegratedSecurity = Properties.Settings.Default.DBUseIntegratedSecurity;

            if (!sql.IntegratedSecurity)
            {
                sql.UserID = Properties.Settings.Default.DBUserName;
                sql.Password = Properties.Settings.Default.DBPassword;
            }

            return sql.ConnectionString;
        }

        public static void SetConnectionString(string serverName, string dbName, bool integratedSecurity = true, string userId = "", string password = "")
        {
            Properties.Settings.Default.DBServerName = serverName;
            Properties.Settings.Default.DBDatabaseName = dbName;
            Properties.Settings.Default.DBUseIntegratedSecurity = integratedSecurity;
            Properties.Settings.Default.DBUserName = userId;
            Properties.Settings.Default.DBPassword = password;
        }
    }
}
