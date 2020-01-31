using System.Windows;
using quizWPF.Pages;

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

            //get to the starting page
            RegisterUser page1 = new RegisterUser();
            Main.Content = page1;
        }

    }
}
