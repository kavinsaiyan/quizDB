using System.Collections.Generic;
using System.Threading.Tasks;
using DBServerClient.Models;
namespace DBServerClient.DataAccess
{
    public interface IDataAccess
    {
        ConnectionString connectionString { get; set; }

        string LoadConnectionString();

        Task<int> LoginOrgainsationAsync(Organisation organisation);

        Task RegisterOrgainsationAsync(Organisation organisation);

        Task UpdateOrganisationTableAsync(string orgName,Test test);

        Task CreateTestTableAsync(string testName, string orgname);

        Task UploadQuestionsAndAnswersAsync(string testTableName,List<QuestionAndAnswer> questionAndAnswers);

        Task<List<QuestionAndAnswer>> GetQAAsync(string testName);

        Task<List<User>> GetUsersAsync(string testName);

        Task<List<string>> GetTestNames(string testName, string orgname);
    }
}
