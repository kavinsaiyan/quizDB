using DBServerClient.Models;
using DBServerClient.Logic;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using Dapper;
using System.Threading.Tasks;
using System.Linq;

namespace DBServerClient.DataAccess
{
    public class DataAccess_PSQL : IDataAccess
    {
        public ConnectionString connectionString { get; set; } = new ConnectionString();

        public DataAccess_PSQL() 
        {
            connectionString.SetDefaultPSQLConnSettings();
        }

        //creates the test table for the test also with the test user table
        public async Task CreateTestTableAsync(string testName,string orgname)
        {
            await Task.Run(
                    () => {
                        using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
                        {
                            conn.Execute($"CREATE TABLE \"{orgname}{testName}\" (\"Slno\" INTEGER NOT NULL,\"Question\"	TEXT NOT NULL,\"Answer1\" TEXT,\"Answer2\" TEXT,\"Answer3\" TEXT,\"Answer4\" TEXT,\"CorrectAnswer\"	INTEGER NOT NULL,PRIMARY KEY(\"Slno\")); " +
                                $"CREATE TABLE \"{orgname}{testName}Users\" (\"Name\" TEXT NOT NULL,\"Score\" INTEGER,\"StartTime\" TIMESTAMP,\"Duration\" INTERVAL,PRIMARY KEY(\"Name\"));");
                        }
                    }
                );
        }

        public string LoadConnectionString()
        {
            return connectionString.ToString();
        }

        //used to authenticate the organisation
        public async Task<int> LoginOrgainsationAsync(Organisation org) 
        {
            int auth = 0;
            await Task.Run(
                    () =>
                    {
                        using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
                        {
                            auth = conn.ExecuteScalar<int>($"select CheckPassword('{org.Name}','{org.Password}')");
                        }
                    }
                );
            return auth;
        }

        //create new organisation entry and also create a separate table for that organisation
        public async Task RegisterOrgainsationAsync(Organisation org)
        {
            await Task.Run(
                    () => {
                        using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
                        {
                            conn.Execute($"insert into \"Organisations\" values ('{org.Name}','{org.Location}','{org.Password}');" +
                                $"CREATE TABLE \"{org.Name}\" (\"TestName\" TEXT NOT NULL,\"Duration\" INTEGER,\"NoOfQuestions\" INTEGER, PRIMARY KEY(\"TestName\")); ");
                        }
                    }
                );
        }

        //insert new test entry in the respective organisation table
        public async Task UpdateOrganisationTableAsync(string orgName, Test test)
        {
            await Task.Run(
                    () => {
                        using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString())) 
                        {
                            conn.Execute($"insert into \"{orgName}\" values ('{test.TestName}',{test.Duration},{test.NoOfQuestions});");
                        }
                    }
                );
        }

        //upload the questions for the test
        public async Task UploadQuestionsAndAnswersAsync(string testTableName,List<QuestionAndAnswer> questionAndAnswers)
        {
            await Task.Run(
                     () => {
                         using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
                         {
                             conn.Execute($"insert into \"{testTableName}\" values(@Slno,@Question,@Answer1," +
                                 $"@Answer2,@Answer3,@Answer4,@CorrectAnswer);",questionAndAnswers);
                         }
                     }
                 );
        }

        //return the Questions And Answers List
        public async Task<List<QuestionAndAnswer>> GetQAAsync(string testName) 
        {
            List<QuestionAndAnswer> list = new List<QuestionAndAnswer>();
             await Task.Run(
                 () => {
                     using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
                     {
                         list = conn.Query<QuestionAndAnswer>($"select * from \"{testName}\";").ToList();
                     }
                 }
             );
            return list;
        }

        //return the Users List
        public async Task<List<User>> GetUsersAsync(string testName)
        {
            List<User> list = new List<User>();
            await Task.Run(
                () => {
                    using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
                    {
                        list = conn.Query<User>($"select * from \"{testName}Users\";").ToList();
                    }
                }
            );
            return list;
        }

        //the actual test search
        public async Task<List<string>> GetTestNames(string testName,string orgname)
        {
            var e = await Task.Run(
                    //The return of the below action method is encapsulated
                    //in a Task<> , so it is necessayr to use 'await'
                    //therefore it should run asyncronously I presume
                    () =>
                    {
                        using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
                        {
                            return conn.Query<string>($"select \"TestName\" from \"{orgname}\" where \"TestName\" like '%{testName}%'").ToList();
                        }
                    }
                );
            return e;
        }

    }
}
