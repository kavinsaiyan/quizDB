using System.Windows;
using System.Windows.Controls;
using DBServerClient.Logic;
namespace DBServerClient.Pages
{
    /// <summary>
    /// Interaction logic for TestViewCreateMenu.xaml
    /// </summary>
    public partial class TestViewCreateMenu : Page
    {
        public TestCreatePage createPage = new TestCreatePage();
        public TestViewPage viewPage = new TestViewPage();
        public TestViewCreateMenu(string orgName)
        {
            //set the current oganisation name
            TestCreateViewHelper.organisationName = orgName;
            InitializeComponent();

            //set the start page
            Display.Content = createPage;
        }

        private void ViewTestButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = viewPage;
        }

        private void CreateTestButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = createPage;
        }
    }
}
