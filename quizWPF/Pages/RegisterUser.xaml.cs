using quizWPF.Logic;
using System.Windows;
using System.Windows.Controls;


namespace quizWPF.Pages
{
    /// <summary>
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : Page
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text)) return;

            //register the user
            QuizProcessor.RegisterUser(Name.Text);

            //navigate to question and answer page
            QuizProcessor.GeneratePages();

            //navigate to the first question
            NavigationService.Navigate(QuizProcessor.pages[0]);
        }
    }
}
