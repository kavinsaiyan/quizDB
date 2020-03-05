using System.Windows;
using System;
using System.Threading.Tasks;
using quizWPF.Pages;
using quizWPF.Logic;
using Squirrel;
namespace quizWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //set reference to handle rules
            TestRulesHandler.MainWindow = this;

            //get to the starting page
            GetTestPage page1 = new GetTestPage();
            Main.Content = page1;

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
