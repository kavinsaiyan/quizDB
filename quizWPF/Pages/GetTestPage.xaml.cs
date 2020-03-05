using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using quizWPF.Logic;
namespace quizWPF.Pages
{
    /// <summary>
    /// Interaction logic for GetTestPage.xaml
    /// </summary>
    public partial class GetTestPage : Page
    {
        public GetTestPage()
        {
            InitializeComponent();
        }

        private async void OrgSearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(OrganisationTextBlock.Text)) 
                return;
            OrganisationListBox.ItemsSource = await DataAccess.GetOrgNames(OrganisationTextBlock.Text);
        }

        private async void TestSearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(OrganisationListBox.SelectedItem.ToString()) 
                || string.IsNullOrEmpty(TestNameTextBlock.Text))
                    return;
            TestNameListBox.ItemsSource = await DataAccess.GetTestNames(
                OrganisationListBox.SelectedItem.ToString(),TestNameTextBlock.Text);
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TestNameListBox.SelectedItem.ToString()))
                return;
           
            //set the test name
            DataAccess.SetTestName(SelectedTestLabel.Text,SelectedOrgLabel.Text);

            //move to register
            NavigationService.Navigate(new RegisterUser());
        }

        private void TestNameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedTestLabel.Text = TestNameListBox.SelectedItem.ToString();
        } 

        private void OrganisationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedOrgLabel.Text = OrganisationListBox.SelectedItem.ToString();
        }
    }
}
