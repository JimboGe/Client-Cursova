using System;
using System.Windows;
using System.Windows.Input;
using Client_Cursova;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Documents;
using System.Data;
using System.Linq;
using System.Windows.Data;

namespace Client_UI
{
    public partial class WindowChat : Window
    {
        private readonly ClientDAL _dal = new ClientDAL();
        string toUserName = string.Empty;
        bool admin_AllUsers_Click = false;
        bool admin_HistoryMessages_Click = false;
        bool admin_ConnectionHistory_Click = false;
        bool focus_Message_Text = false;
        bool user_Click = false;
        int myUserId;
        int toUserId;

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
        private void Text_Message_GotFocus(object sender, RoutedEventArgs e)
        {
            focus_Message_Text = true;
        }
        private void Text_Message_LostFocus(object sender, RoutedEventArgs e)
        {
            focus_Message_Text = false;
        }
        //
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in _dal.GetAllUsers())
            {
                if (item.NickName != MyUserName.Content.ToString())
                // && item.NickName != admin.NickName)
                {
                    Button newUser = new Button()
                    {
                        Content = $"{item.NickName}",
                        Foreground = Brushes.Black,
                        Background = Brushes.Transparent,
                        BorderBrush = Brushes.OrangeRed
                    };
                    newUser.Click += new RoutedEventHandler(UserClick);
                    MyStack.Children.Add(newUser);
                }
            }
            //if (MyUserName.Content.ToString() == admin.NickName)
            //{
            //    AdminIsOnline();
            //}
        }
        private void UserClick(object sender, RoutedEventArgs e)
        {
            user_Click = true;
            toUserName = (sender as Button).Content.ToString();
            ChangeBackgroundUserClick(sender);
            SendMessage_Button.Visibility = Visibility.Visible;
            StackPanel_Messages.Visibility = Visibility.Visible;
            Text_Message.Visibility = Visibility.Visible;
            ScrollViewer_Messages.PageDown();
        }
        private void ChangeBackgroundUserClick(object sender)
        {
            foreach (var item in MyStack.Children)
            {
                if (item is Button)
                {
                    if ((item as Button).Content.ToString() == toUserName)
                    {
                        (sender as Button).Background = new SolidColorBrush(Color.FromRgb(232, 52, 52));
                    }
                    else
                    {
                        (item as Button).Background = Brushes.Transparent;
                    }
                }
            }
        }
        ///
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {
            if (Text_Message.Text != string.Empty)
            {
                FillMessage();
                ShowMessage();
                Text_Message.Text = string.Empty;
            }
        }

        private void FillMessage()
        {
            myUserId = _dal.MyUserId(MyUserName.Content.ToString());
            toUserId = _dal.ToUserId(toUserName);
            _dal.CreateMessage(Text_Message.Text, myUserId, toUserId);
        }
        private void ShowMessage()
        {
            TextBlock My_Message = new TextBlock()
            {
                TextWrapping = TextWrapping.Wrap,
                FontSize = 16,
                Margin = new Thickness(10),
                MinWidth = 250,
                MinHeight = 40,
                MaxWidth = 320,
                HorizontalAlignment = HorizontalAlignment.Left,
                Padding = new Thickness(5),
                Background = new SolidColorBrush(Color.FromRgb(251, 180, 180))
            };
            My_Message.Inlines.Add(new Run(Text_Message.Text));
            My_Message.Inlines.Add(new Run(DateTime.Now.ToString().PadLeft(500))
            { Foreground = Brushes.Black, FontSize = 11 });
            StackPanel_Messages.Children.Add(My_Message);
            ScrollViewer_Messages.PageDown();
        }
        private void ShowAllMessages()
        { }
        private void FillAllMessages()
        {

        }
        private void UserIsOffline()
        {
            _dal.SetUserIsOffline(MyUserName.Content.ToString());
        }

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
        {
            admin_AllUsers_Click = true;
            admin_HistoryMessages_Click = false;
            admin_ConnectionHistory_Click = false;
            Admin_ShowAllUsers();
        }
        private void Admin_ShowHistoryMessages_Click(object sender, RoutedEventArgs e)
        {
            admin_AllUsers_Click = false;
            admin_HistoryMessages_Click = true;
            admin_ConnectionHistory_Click = false;
            Admin_HistoryMessages();
        }
        private void Admin_ShowConnectionHistory_Click(object sender, RoutedEventArgs e)
        {
            admin_AllUsers_Click = false;
            admin_HistoryMessages_Click = false;
            admin_ConnectionHistory_Click = true;
            Admin_ConnectionHistory();
        }
        private void Admin_CreateNewDataGridTextColumn(string Header, string Binding)
        {
            DataGridTextColumn textColumn = new DataGridTextColumn();
            textColumn.Header = Header;
            textColumn.Binding = new Binding(Binding);
            var result = DataGrid_Admin.Columns.Where(x => x.Header.ToString() == Header).FirstOrDefault();
            if (result == null)
            {
                DataGrid_Admin.Columns.Add(textColumn);
            }
        }
        private void Admin_ShowAllUsers()
        {
            DataGrid_Admin.Columns.Clear();
            DataGrid_Admin.Items.Clear();
            Admin_CreateNewDataGridTextColumn("Id", "Id");
            Admin_CreateNewDataGridTextColumn("Nick Name", "NickName");
            Admin_CreateNewDataGridTextColumn("Is Online", "IsOnline");
            foreach (var item in _dal.GetAllUsers())
            {
                DataGrid_Admin.Items.Add(item);
            }
        }
        private void Admin_HistoryMessages()
        {
            DataGrid_Admin.Columns.Clear();
            DataGrid_Admin.Items.Clear();
            Admin_CreateNewDataGridTextColumn("Id", "Id");
            Admin_CreateNewDataGridTextColumn("User Id", "UserId");
            Admin_CreateNewDataGridTextColumn("To User Id", "ToUserId");
            Admin_CreateNewDataGridTextColumn("Text", "Text");
            Admin_CreateNewDataGridTextColumn("Date", "Date");
            foreach (var item in _dal.GetAllMessages())
            {
                DataGrid_Admin.Items.Add(item);
            }
        }
        private void Admin_ConnectionHistory()
        {
            DataGrid_Admin.Columns.Clear();
            DataGrid_Admin.Items.Clear();
            Admin_CreateNewDataGridTextColumn("Id", "Id");
            Admin_CreateNewDataGridTextColumn("User", "UserName");
            Admin_CreateNewDataGridTextColumn("Connection Time", "ConnectionTime");
            foreach (var item in _dal.GetAllLogs())
            {
                DataGrid_Admin.Items.Add(item);
            }
        }
    
    private void Window_MouseEnter(object sender, MouseEventArgs e)
    {
            if (admin_AllUsers_Click == true)
            {
                Admin_ShowAllUsers();
            }
            if (admin_ConnectionHistory_Click == true)
            {
                Admin_ConnectionHistory();
            }
            if (admin_HistoryMessages_Click == true)
            {
                Admin_HistoryMessages();
            }
            if (user_Click == true)
            {
                ShowAllMessages();
            }
        }
    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
            if (focus_Message_Text == true)
            {
                if (e.Key == Key.Enter)
                {
                    SendMessage();
                }
            }
        }
    private void Window_Closed(object sender, EventArgs e)
    {
        _dal.SetUserIsOffline(MyUserName.Content.ToString());
    }

}
}
