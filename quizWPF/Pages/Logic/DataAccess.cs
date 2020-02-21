using Npgsql;
using Dapper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quizWPF.Logic
{
    public static class DataAccess
    {
        private static string LoadConnectionString() 
        {
            var uriString = "postgres://pbghhoex:LvtN5U7BkK8KK9FLKC8OBRLs19PmwZOh@rajje.db.elephantsql.com:5432/pbghhoex";
            var uri = new Uri(uriString);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var port = uri.Port > 0 ? uri.Port : 5432;
            var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                uri.Host, db, user, passwd, port);
            return connStr;
        }

        public static List<QuestionAnswerModel> GetList() 
        {
            using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
            {
                conn.Open();
                var res = conn.Query<QuestionAnswerModel>("SELECT * FROM \"public\".\"QuestionsAndAnswers\" LIMIT 100 ").ToList();
                conn.Close();
                return res;
            }
        }

        public async static Task RegisterUser(string Name) 
        {
            await Task.Run(() =>
            {
                using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
                {
                    conn.Open();
                    conn.Execute($"INSERT INTO \"public\".\"Users\"(\"Name\", \"Score\") VALUES ('{Name}','0'); ");
                    conn.Close();
                }
            });
        }

        public static void RegisterUserScore(string Name,int score)
        {
            using (IDbConnection conn = new NpgsqlConnection(LoadConnectionString()))
            {
                conn.Open();
                conn.Execute($"UPDATE \"public\".\"Users\" SET  \"Score\"='{score}' WHERE \"Name\"='{Name}'; ");
                conn.Close();
            }
        }
    }
}
