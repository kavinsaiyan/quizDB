using System;
namespace DBServerClient.Models
{
    public class ConnectionString
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }

        public override string ToString() 
        {
            return string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                Server, Database, UserID, Password, Port);
        }

        public void SetDefaultPSQLConnSettings()
        {
            var uriString = "postgres://pbghhoex:LvtN5U7BkK8KK9FLKC8OBRLs19PmwZOh@rajje.db.elephantsql.com:5432/pbghhoex";
            var uri = new Uri(uriString);
            Database = uri.AbsolutePath.Trim('/');
            UserID = uri.UserInfo.Split(':')[0];
            Password = uri.UserInfo.Split(':')[1];
            Port = (uri.Port > 0 ? uri.Port : 5432).ToString();
            Server = uri.Host;
        }
    }
}
