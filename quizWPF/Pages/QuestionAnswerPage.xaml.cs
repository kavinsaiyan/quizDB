using quizWPF.Logic;
using System.Windows;
using System.Windows.Controls;


namespace quizWPF.Pages
{
    /// <summary>
    /// Interaction logic for QuestionAnswerPage.xaml
    /// </summary>
    public partial class QuestionAnswerPage : Page
    {
        private QuestionAnswerModel questionAnswer;

        private int indexOfThisPage = -1;

        public QuestionAnswerPage(QuestionAnswerModel questionAnswerModel,int pageNo)
        {
            questionAnswer = questionAnswerModel;
            InitializeComponent();

            //set the components
            Question.Text = questionAnswer.Question;
            AnswerButton0.Content = questionAnswer.Answer1;
            AnswerButton1.Content = questionAnswer.Answer2;
            AnswerButton2.Content = questionAnswer.Answer3;
            AnswerButton3.Content = questionAnswer.Answer4;

            //set the index of the page
            indexOfThisPage = pageNo;
        }

        public void AddProperties(QuestionAnswerModel questionAnswerModel, int pageNo) 
        {
            questionAnswer = questionAnswerModel;
            InitializeComponent();

            //set the components
            Question.Text = questionAnswer.Question;
            AnswerButton0.Content = questionAnswer.Answer1;
            AnswerButton1.Content = questionAnswer.Answer2;
            AnswerButton2.Content = questionAnswer.Answer3;
            AnswerButton3.Content = questionAnswer.Answer4;

            //set the index of the page
            indexOfThisPage = pageNo;
        }

        private void AnswerButton0_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            questionAnswer.LockedAnswer = 1;
            System.Diagnostics.Debug.WriteLine("LAnswer: "+QuizProcessor.listOfQuestions[indexOfThisPage].LockedAnswer);
        }

        private void AnswerButton1_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            questionAnswer.LockedAnswer = 2;
            System.Diagnostics.Debug.WriteLine("LAnswer: " + QuizProcessor.listOfQuestions[indexOfThisPage].LockedAnswer);

        }

        private void AnswerButton2_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            questionAnswer.LockedAnswer = 3; System.Diagnostics.Debug.WriteLine("LAnswer: " + QuizProcessor.listOfQuestions[indexOfThisPage].LockedAnswer);

        }

        private void AnswerButton3_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            questionAnswer.LockedAnswer = 4; System.Diagnostics.Debug.WriteLine("LAnswer: " + QuizProcessor.listOfQuestions[indexOfThisPage].LockedAnswer);

        }

        private void NextQuestionButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (indexOfThisPage == QuizProcessor.pages.Count - 1)
                SubmitTestButton.IsEnabled = true;
            if (indexOfThisPage < QuizProcessor.pages.Count-1)
                NavigationService.Navigate(QuizProcessor.pages[indexOfThisPage + 1]);
        }

        private void SubmitTestButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //calculate the score
            QuizProcessor.CalculateTheScore();

            //navigate to the final page
            NavigationService.Navigate(new FinalPage());
        }

        private void PreviousQuestionButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (indexOfThisPage >= 1)
                NavigationService.Navigate(QuizProcessor.pages[indexOfThisPage - 1]);
        }

    }
}
