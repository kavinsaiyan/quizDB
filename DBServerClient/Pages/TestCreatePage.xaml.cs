using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using DBServerClient.Models;
using DBServerClient.Logic;
namespace DBServerClient.Pages
{
    /// <summary>
    /// Interaction logic for TestCreatePage.xaml
    /// </summary>
    public partial class TestCreatePage : Page
    {
        public Test test { get; set; } = new Test();
        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text

        public TestCreatePage()
        {
            DataContext = test;
            InitializeComponent();
        }

        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void TextBoxPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private async void CreateTestButton_Click(object sender, RoutedEventArgs e)
        {
            //create the test requirements
            await TestCreateViewHelper.CreateTest(test);

            //go to the next page
            NavigationService.Navigate(new EnterQAPage(test.NoOfQuestions));
        }
    }
}
