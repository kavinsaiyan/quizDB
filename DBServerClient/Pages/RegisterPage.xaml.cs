using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DBServerClient.Models;
using DBServerClient.Logic;

namespace DBServerClient.Pages
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public Organisation organisation { get; set; } = new Organisation();

        public RegisterPage()
        {
            InitializeComponent();
            DataContext = organisation;
        }

        private async void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterButton.IsEnabled = false;
            await LoginRegisterHelper.RegisterAuthenticateAsync(organisation);
            //go to login page
            NavigationService.GoBack();
            RegisterButton.IsEnabled = true;
        }
    }
}