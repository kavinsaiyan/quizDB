using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using DBServerClient.Models;
using DBServerClient.Logic;
namespace DBServerClient.Pages
{
    /// <summary>
    /// Interaction logic for TestViewPage.xaml
    /// </summary>
    public partial class TestViewPage : Page
    {
        public Test test { get; set; } = new Test();

        public List<QuestionAndAnswer> QAList { get; set; } = new List<QuestionAndAnswer>();

        public List<User> UserList { get; set; } = new List<User>();


        public TestViewPage()
        {
            InitializeComponent();

            //to get the name
            DataContext = test;
        }

        private async void TestSearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TestNameTextBox.Text))
            {
                TestNameListBox.ItemsSource = await TestCreateViewHelper.dataAccess.GetTestNames(TestNameTextBox.Text,TestCreateViewHelper.organisationName);
            }
        }

        private async void GetTestButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedTestLabel.Text)) 
            {
                QADataGrid.ItemsSource = await TestCreateViewHelper.dataAccess.GetQAAsync
                    (TestCreateViewHelper.organisationName+SelectedTestLabel.Text);
                UsersDataGrid.ItemsSource = await TestCreateViewHelper.dataAccess.GetUsersAsync(TestCreateViewHelper.organisationName + SelectedTestLabel.Text);
            }
        }

        private void TestNameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TestNameListBox.SelectedItem.ToString()!=null)
            SelectedTestLabel.Text = TestNameListBox.SelectedItem.ToString();
        }
    }
}