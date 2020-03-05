using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using DBServerClient.Models;
using DBServerClient.Logic;
namespace DBServerClient.Pages
{
    /// <summary>
    /// Interaction logic for EnterQAPage.xaml
    /// </summary>
    public partial class EnterQAPage : Page
    {
        public List<QuestionAndAnswer> questionAndAnswers;
        int noOfQuestions;
        int currentIndex;
        bool readyToBeUploaded;
        public EnterQAPage(int numberOfQuestions)
        {
            InitializeComponent();
            //initialize the list
            noOfQuestions = numberOfQuestions;

            //populate and set the slno's
            TestCreateViewHelper.QAListPopulateSlNo(noOfQuestions,out questionAndAnswers);

            //set status of entering the questions
            readyToBeUploaded = false;

            //set the first question
            currentIndex = 0;
            QuestionTextBlock.Text = "Question Number:1";
            DataContext = questionAndAnswers[currentIndex];
        }

        private void Option1RadioButton_Click(object sender, RoutedEventArgs e)
        {
            questionAndAnswers[currentIndex].CorrectAnswer = 1;
        }

        private void Option2RadioButton_Click(object sender, RoutedEventArgs e)
        {
            questionAndAnswers[currentIndex].CorrectAnswer = 2;
        }

        private void Option3RadioButton_Click(object sender, RoutedEventArgs e)
        {
            questionAndAnswers[currentIndex].CorrectAnswer = 3;
        }

        private void Option4RadioButton_Click(object sender, RoutedEventArgs e)
        {
            questionAndAnswers[currentIndex].CorrectAnswer = 4;
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                DataContext = questionAndAnswers[--currentIndex];
                QuestionTextBlock.Text = $"Question Number:{currentIndex+1}";
            }
        }

        private async void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            if (readyToBeUploaded)
            {
                UploadButton.IsEnabled = false;
                await TestCreateViewHelper.UploadQuestionsAndAnswersAsync(questionAndAnswers);
                NavigationService.Navigate(new AlertPage());
                UploadButton.IsEnabled = true;
                readyToBeUploaded = false;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex<(noOfQuestions-1)) 
            {
                DataContext = questionAndAnswers[++currentIndex];
                QuestionTextBlock.Text = $"Question Number:{currentIndex + 1}";
            }
            if (!readyToBeUploaded) readyToBeUploaded = (currentIndex == (noOfQuestions - 1)) ? true : false;
        }
    }
}
