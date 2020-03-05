using Npgsql;
using Dapper;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace quizWPF.Logic
{
    public static class DataAccess
    {
        //refers to the database connection being used
        public enum ConnectionType { PSQL, MySQL, Oracle, MSSQL};

        //default database to query is postgresql
        public static ConnectionType connectionType = ConnectionType.PSQL;

        //to hold the table name
        private static string TestName = string.Empty;

        //to hold the organisation name
        private static string OrganisationName = string.Empty;

        public static IDbConnection GetConnection() 
        {
            IDbConnection dbConnection = null;
            switch (connectionType) 
            {
                case ConnectionType.PSQL:
                    dbConnection = new NpgsqlConnection(Connector.GetConnectionString());
                    break;
                case ConnectionType.MSSQL:
                    dbConnection = new SqlConnection(Connector.GetConnectionString());
                    break;
                case ConnectionType.MySQL:
                    dbConnection = new MySqlConnection(Connector.GetConnectionString());
                    break;
                case ConnectionType.Oracle:
                    dbConnection = new OracleConnection(Connector.GetConnectionString());
                    break;
            }
            return dbConnection;
        }

        public static List<QuestionAnswerModel> GetList() 
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                var res = conn.Query<QuestionAnswerModel>($"SELECT * FROM \"{OrganisationName}{TestName}\"").ToList();
                conn.Close();
                return res;
            }
        }

        public static void RegisterUser(string Name) 
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                conn.Execute($"INSERT INTO \"{OrganisationName}{TestName}Users\"(\"Name\", \"Score\",\"StartTime\") VALUES ('{Name}',0,NOW()); ");
                conn.Close();
            }
        }

        public static void RegisterUserScore(string Name,int score)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                conn.Execute($"UPDATE \"{OrganisationName}{TestName}Users\" SET  \"Score\"={score},\"Duration\" = age(NOW(),\"StartTime\") WHERE \"Name\"='{Name}'; ");
                conn.Close();
            }
        }

        //the actual organisation search
        public static async Task<List<string>> GetOrgNames(string orgName) 
        {
            var e = await Task.Run(
                    //The return of the below action method is encapsulated
                    //in a Task<> , so it is necessayr to use 'await'
                    //therefore it should run asyncronously I presume
                    () => 
                        {
                            using (IDbConnection conn = GetConnection()) 
                            {
                                return conn.Query<string>($"select \"Name\" from \"Organisations\" where \"Name\" like '%{orgName}%'").ToList(); 
                            }
                        }
                );
            return e;
        }

        //the actual test search
        public static async Task<List<string>> GetTestNames(string orgName,string testName)
        {
            var e = await Task.Run(
                    //The return of the below action method is encapsulated
                    //in a Task<> , so it is necessayr to use 'await'
                    //therefore it should run asyncronously I presume
                    () =>
                    {
                        using (IDbConnection conn = GetConnection())
                        {
                            return conn.Query<string>($"select \"TestName\" from \"{orgName}\" where \"TestName\" like '%{testName}%'").ToList();
                        }
                    }
                );
            return e;
        }

        //set the test name 
        public static void SetTestName(string testName,string OrgName) 
        {
            OrganisationName = OrgName;
            TestName = testName;
        }
    }
}
