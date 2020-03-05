using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DBServerClient.Logic;
using DBServerClient.Models;

namespace DBServerClient.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public Organisation organisation { get; set; } = new Organisation();

        public LoginPage()
        {
            InitializeComponent();
            this.DataContext = organisation;
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = false;
            var b =  await LoginRegisterHelper.LoginAuthenticateAsync(organisation);
            if (b) {

                //get the parent frame's parent frame
                var parentObject = VisualTreeHelper.GetParent(this);
                var grandParentFrame = VisualTreeHelper.GetParent(parentObject) as Frame;

                //change the page of the frame
                LoginRegisterHelper.mainFrame.Content = new TestViewCreateMenu(organisation.Name);

                //remove the reference to main display in loginregisterHelper
                LoginRegisterHelper.mainFrame = null;
            }
            LoginButton.IsEnabled = true;

        }
    }
}
