using quizWPF.Pages;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace quizWPF.Logic
{
    public static class QuizProcessor
    {
        public static List<QuestionAnswerModel> listOfQuestions=null;

        public static QuestionAnswerPage questionAnswerPage = new QuestionAnswerPage();

        private static string USerName = string.Empty;
        public static int USerScore = 0;

        public static bool CansubmitTest = false;

        static QuizProcessor() 
        {
            listOfQuestions = DataAccess.GetList();
            if (listOfQuestions.Count < 0)
                throw new System.Exception("List of Questions Could not be loaded");
        }

        public static async Task RegisterUser(string Name) 
        {
            //register user 
            USerName = Name;
            if (!string.IsNullOrEmpty(USerName))
               await DataAccess.RegisterUser(USerName);
            //else
            //    throw new System.Exception("The Name is Empty");
        }

        public static void CalculateTheScore() 
        {
            //set user score first
            foreach (var e in listOfQuestions)
            {
                if (e.LockedAnswer == e.CorrectAnswer)
                    USerScore++;
            }

            if (USerScore >= listOfQuestions.Count) USerScore = listOfQuestions.Count;
            if (USerScore <= 0) USerScore = 0;

            if (!string.IsNullOrEmpty(USerName))
                DataAccess.RegisterUserScore(USerName, USerScore);
        }
    }
}
