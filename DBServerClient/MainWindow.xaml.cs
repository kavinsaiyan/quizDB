using System.Windows;
using System;
using System.Threading.Tasks;
using DBServerClient.Pages;
using DBServerClient.Logic;
using Squirrel;
namespace DBServerClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoginRegisterMenuPage menuPage = new LoginRegisterMenuPage();

            LoginRegisterHelper.mainFrame = Main;             
            
            Main.Content = menuPage;

            //try to update if possible
            Task.Run(async () => { await CheckForUpdates(); });
        }

        public async Task CheckForUpdates()
        {
            Task<UpdateManager> manager;
            using (manager = UpdateManager.GitHubUpdateManager(@"https://github.com/kavinsaiyan/quizDB"))
            {
                var val = await manager.Result.UpdateApp();
            }
            manager.Result.Dispose();
            manager = null;
            GC.WaitForFullGCComplete();
        }
    }
}
