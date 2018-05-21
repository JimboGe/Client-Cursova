using System;
using System.Windows;
using System.Windows.Input;

namespace Client_UI
{
   
    public partial class WindowChat : Window
    {
        public WindowChat()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void BackToLogin(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        ///////
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void ShowAllUsers()
        { }

        private void UserClick(object sender, RoutedEventArgs e)
        { }
        private void ChangeBackgroundUserClick(object sender)
        { }
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        { }
        private void SendMessage()
        { }
        private void Text_Message_GotFocus(object sender, RoutedEventArgs e)
        { }
        private void Text_Message_LostFocus(object sender, RoutedEventArgs e)
        { }
        private void FillMessage()
        { }
        private void ShowMessage()
        { }
        private void ShowAllMessages()
        { }
        private void FillAllMessages()
        { }
        private void UserIsOffline()
        { }

        /////////
        private void AdminIsOnline()
        {
            Text_Message.Visibility = Visibility.Hidden;
            SendMessage_Button.Visibility = Visibility.Hidden;
            ScrollViewer_MyStack.Visibility = Visibility.Hidden;
            Users_StackPanel.Visibility = Visibility.Hidden;
            DataGrid_Admin.Visibility = Visibility.Visible;
            StackPanel_Settings.Visibility = Visibility.Visible;
        }
        private void Admin_ShowAllUsers_Click(object sender, RoutedEventArgs e)
        { }
        private void Admin_ShowHistoryMessages_Click(object sender, RoutedEventArgs e)
        { }
        private void Admin_ShowConnectionHistory_Click(object sender, RoutedEventArgs e)
        { }
        private void Admin_CreateNewDataGridTextColumn(string Header, string Binding)
        { }
        private void Admin_ShowAllUsers()
        { }
        private void Admin_HistoryMessages()
        { }
        private void Admin_ConnectionHistory()
        { }
        private void Window_MouseEnter(object sender, MouseEventArgs e)
        { }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void Window_Closed(object sender, EventArgs e)
        {

        }

    }
}
