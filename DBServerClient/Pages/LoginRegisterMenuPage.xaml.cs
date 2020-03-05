using System.Windows;
using System.Windows.Controls;
using DBServerClient.Logic;
using DBServerClient.DataAccess;

namespace DBServerClient.Pages
{
    /// <summary>
    /// Interaction logic for LoginRegisterMenuPage.xaml
    /// </summary>
    public partial class LoginRegisterMenuPage : Page
    {
        public LoginPage loginPage = new LoginPage();

        public RegisterPage registerPage = new RegisterPage();

        public LoginRegisterMenuPage()
        {
            InitializeComponent();

            LoginRegisterHelper.dataAccess = new DataAccess_PSQL();

            Display.Content = loginPage ;
        }

        private void RegisterMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = registerPage;
        }

        private void LoginMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = loginPage;
        }
    }
}