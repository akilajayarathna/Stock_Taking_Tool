using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stock_Taking_Tool
{
    public static class cls_MainDb
    {
        private const string DbUser = "sa";
        private const string DbPassword = "itonimta";

        public static string Server { get; private set; }
        public static string Database { get; private set; }

        public static bool IsConfigurd 
        {
            get { return !string.IsNullOrWhiteSpace(Server) && !string.IsNullOrWhiteSpace(Database); }
        }
        public static void Load()
        {
            Server = Stock_Taking_Tool.Properties.Settings.Default.ServerName;
            Database = Stock_Taking_Tool.Properties.Settings.Default.DatabaseName;
        }

        public static void Save(string server, string database)
        {
            Server = server.Trim();
            Database = database.Trim();
            Stock_Taking_Tool.Properties.Settings.Default.ServerName = server;
            Stock_Taking_Tool.Properties.Settings.Default.DatabaseName = database;
            Stock_Taking_Tool.Properties.Settings.Default.Save();
        }

        public static string BuildConnectionString(string server, string database)
        {
            return new SqlConnectionStringBuilder
            {
                DataSource = server.Trim(),
                InitialCatalog = database.Trim(),
                UserID = DbUser,
                Password = DbPassword,
                TrustServerCertificate = true,
                ConnectTimeout = 10
            }.ConnectionString;
        }

        public static string ConnectionString
        {
            get { return BuildConnectionString(Server, Database); }
        }
    }
}
