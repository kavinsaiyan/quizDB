using System.Threading.Tasks;
using System.Collections.Generic;
using DBServerClient.DataAccess;
using DBServerClient.Models;

namespace DBServerClient.Logic
{
    public static class TestCreateViewHelper
    {
        public static string organisationName = string.Empty;

        private static string testName = string.Empty;

        public static DataAccess_PSQL dataAccess = new DataAccess_PSQL();

        //execute the necessary queries
        public static async Task CreateTest(Test test) 
        {
            //set the test Name 
            testName = test.TestName;

            //insert test into redpective organisation table
            await dataAccess.UpdateOrganisationTableAsync(organisationName, test);
            
            //create new test table
            await dataAccess.CreateTestTableAsync(test.TestName,organisationName);
        }

        //populate the question numbers(SlNo's) of the given list
        public static void QAListPopulateSlNo(int noOfQuestions,out List<QuestionAndAnswer> list) 
        {
            int slNo = 1;
            list = new List<QuestionAndAnswer>();
            for (int i = 0; i <noOfQuestions; i++) 
            {
                list.Add(new QuestionAndAnswer() { Slno = slNo++ });
            }
        }

        //upload the questions and answers
        public static async Task UploadQuestionsAndAnswersAsync(List<QuestionAndAnswer> list) 
        {
           await dataAccess.UploadQuestionsAndAnswersAsync(organisationName+testName,list);
        }

        //get the test names
        public static async Task<List<string>> GetTestNames(string testName) 
        {
            return await dataAccess.GetTestNames(testName,organisationName);
        }
    }
}