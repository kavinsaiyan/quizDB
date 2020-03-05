using System;
using System.Windows;
using System.Windows.Input;

namespace quizWPF.Logic
{
    public static class TestRulesHandler
    {
        //used to hold reference to MainWindow
        public static Window MainWindow = null;

        //to help with subscription to "Window.Deactivated" event
        private static EventHandler OnLostFocusDelegate =
                new EventHandler(OnLostFocus);

        //things to be done when test starts
        public static void HandleTestStart() 
        {
            //maximize the windows
            MainWindow.WindowState = WindowState.Maximized;
            //remove the minimize and maximize buttons
            MainWindow.WindowStyle = WindowStyle.None;
            //remove from taskbar
            MainWindow.ShowInTaskbar = false;
            //subscribe to lost focus
            MainWindow.Deactivated += OnLostFocusDelegate;
        }

        //things to be done when test is submitted
        public static void HandleTestSubmit()
        {
            //maximize the windows
            MainWindow.WindowState = WindowState.Normal;
            //remove the minimize and maximize buttons
            MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
            //remove from taskbar
            MainWindow.ShowInTaskbar = true;
            //unsubscribe from event
            MainWindow.Deactivated -= OnLostFocusDelegate;
        }

        //handle the lost focus event
        public static void OnLostFocus(object sender,EventArgs e)
        {
            //close the application 
            MainWindow.Close();
        }
    }
}
