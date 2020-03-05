using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizWPF.Logic
{
    //to be used for providing offline connection
    public static class Connector
    {
        //load the default psql connection
        static Connector() 
        {
            LoadPSQLConnectionString();
        }
        
        //holds the connection string 
        private static string ConnectionString = string.Empty;

        //to set the connection string
        public static void SetConnectionString(string server,string database,string userID,string password,string port) 
        {
            ConnectionString = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                server, database, userID, password, port);
        }

        //get the conection string
        public static string GetConnectionString() 
        {
            return ConnectionString;
        }

        //load the psql connection string
        private static void LoadPSQLConnectionString()
        {
            var uriString = "postgres://pbghhoex:LvtN5U7BkK8KK9FLKC8OBRLs19PmwZOh@rajje.db.elephantsql.com:5432/pbghhoex";
            var uri = new Uri(uriString);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var port = uri.Port > 0 ? uri.Port : 5432;
            SetConnectionString(uri.Host, db, user, passwd, port.ToString());
        }

    }
}
