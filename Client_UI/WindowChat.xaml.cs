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
using System.Collections.Generic;
using System.Windows.Threading;

namespace Client_UI
{
    public partial class WindowChat : Window
    {
        private readonly ClientDAL _dal = new ClientDAL();
        private string _toUserName = string.Empty;
        private bool _focus_Message_Text = false;
        private bool _user_Click = false;
        private bool _adminOnline = false;
        private int _myUserId;
        private int _toUserId;
        private int _counter_User = 0;
        private int _counter_Users = 0;
        private List<int> _toUserIdList;
        private List<int> _myUserIdList;
        private List<string> _msgList;
        private List<DateTime> _time_msgList;
        private DispatcherTimer _timer = new DispatcherTimer();
        private List<UserControl_ShowUser> _globalControls = new List<UserControl_ShowUser>();
       
        public WindowChat()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            this.Close();
        }
        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void BackToLogin(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
        private void Text_Message_GotFocus(object sender, RoutedEventArgs e)
        {
            _focus_Message_Text = true;
        }
        private void Text_Message_LostFocus(object sender, RoutedEventArgs e)
        {
            _focus_Message_Text = false;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _timer.Tick += new EventHandler(dispatcherTimer_Tick);
            _timer.Interval = new TimeSpan(0, 0, 2);
            _timer.Start();
            if (MyUserName.Content.ToString() == _dal.CanCreateAdmin().NickName)
            {
                _adminOnline = true;
            }
            else
            {
                _adminOnline = false;
            }
            CreateUsersUI();
            ShowUsersInfo();
            
            _counter_Users = _dal.GetAllUsers().Count();
        }
        private void CreateUsersUI()
        {
            _globalControls.Clear();
            MyStack.Children.Clear();
            foreach (var item in _dal.GetAllUsers())
            {
                if (item.NickName != MyUserName.Content.ToString()
                 && item.NickName != _dal.CanCreateAdmin().NickName)
                {
                    UserControl_ShowUser control = new UserControl_ShowUser();
                    control.UserControl_Circle_Online.Foreground = ChangeUserStatusColor(item);
                    control.UserControl_Name.Text = item.NickName;
                    control.Height = (this.Height * 0.7205) / 12;
                    _globalControls.Add(control);
                    Button newUser = new Button()
                    {
                        Content = control,
                        Tag = item.NickName,
                        Foreground = Brushes.Black,
                        Background = Brushes.Transparent,
                        BorderBrush = Brushes.Transparent,
                        Height = 60 + this.Height / 90,
                        HorizontalContentAlignment = HorizontalAlignment.Left,
                        Margin = new Thickness(0, 0, 20, 0)
                    };
                    newUser.Click += new RoutedEventHandler(UserClick);
                    MyStack.Children.Add(newUser);
                }
            }
        }
        private void FillUserInfo(Client_Cursova.ServiceReference1.User user, UserControl_ShowUser control)
        {
            var timeuser = _dal.GetUserLog(user.NickName).LastOrDefault().Date;//!!!!!
            var timenow = DateTime.Now;
            if (user.IsOnline == false)
            {
                if (timenow.Day - timeuser.Day <= 0)
                {
                    if (timenow.Hour - timeuser.Hour <= 0)
                    {
                        if (timenow.Minute - timeuser.Minute <= 0)
                        {
                            control.UserControl_Text_Online.Text = $"left {timenow.Second - timeuser.Second} second ago";
                        }
                        else
                        {
                            control.UserControl_Text_Online.Text = $"left {timenow.Minute - timeuser.Minute} min ago";
                        }
                    }
                }
                else
                {
                    control.UserControl_Text_Online.Text = $"left {timenow.Day - timeuser.Day} day ago";
                }
            }
            else
            {
                control.UserControl_Text_Online.Text = "online";
            }
            control.UserControl_Circle_Online.Foreground = ChangeUserStatusColor(user);
        }
        private void ShowUsersInfo()
        {
            _counter_User = 0;
            foreach (var item in _dal.GetAllUsers())
            {
                if (_adminOnline == false)
                {
                    if (item.NickName != MyUserName.Content.ToString()
                          && item.NickName != _dal.CanCreateAdmin().NickName)
                    {
                        FillUserInfo(item, _globalControls[_counter_User]);
                        if (_counter_User != _dal.GetAllUsers().Count() - 3)
                        {
                            _counter_User++;
                        }
                        else
                        {
                            _counter_User = 0;
                        }
                    }
                }
                else
                {
                    if (item.NickName != _dal.CanCreateAdmin().NickName)
                    {
                        FillUserInfo(item, _globalControls[_counter_User]);
                        if (_counter_User != _dal.GetAllUsers().Count() - 2)
                        {
                            _counter_User++;
                        }
                        else
                        {
                            _counter_User = 0;
                        }
                    }
                }
            }
        }
        private SolidColorBrush ChangeUserStatusColor(Client_Cursova.ServiceReference1.User user)
        {
            if (user.IsOnline == true)
            {
                return new SolidColorBrush(Color.FromRgb(255, 210, 0));
            }
            else
            {
                return new SolidColorBrush(Color.FromRgb(232, 52, 52));
            }
        }
        private void UserClick(object sender, RoutedEventArgs e)
        {
            if (_adminOnline == false)
            {
                _user_Click = true;
                _toUserName = (sender as Button).Tag.ToString();
                ShowAllMessages();
                ChangeBackgroundUserClick();
                SendMessage_Button.Visibility = Visibility.Visible;
                StackPanel_Messages.Visibility = Visibility.Visible;
                Text_Message.Visibility = Visibility.Visible;
                ScrollViewer_Messages.PageDown();
            }
            else
            {
                _toUserName = (sender as Button).Tag.ToString();
                GetUserLog();
                Text_Message.Visibility = Visibility.Hidden;
                SendMessage_Button.Visibility = Visibility.Hidden;
                DataGrid_Admin.Visibility = Visibility.Visible;
                ChangeBackgroundUserClick();
            }
        }
        private void ChangeBackgroundUserClick()
        {
            foreach (var item in MyStack.Children)
            {
                if (item is Button)
                {
                    if ((item as Button).Tag.ToString() == _toUserName)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromRgb(251, 185, 185));
                    }
                    else
                    {
                        (item as Button).Background = Brushes.Transparent;
                    }
                }
            }
        }
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
            _myUserId = _dal.MyUserId(MyUserName.Content.ToString());
            _toUserId = _dal.ToUserId(_toUserName);
            _dal.CreateMessage(Text_Message.Text, _myUserId, _toUserId, _toUserName, MyUserName.Content.ToString());
        }
        private void ShowMessage()
        {
            TextBlock My_Message = new TextBlock()
            {
                TextWrapping = TextWrapping.Wrap,
                FontSize = 16,
                Margin = new Thickness(10),
                MinWidth = (this.Width * 0.7389) / 3,
                MaxWidth = (this.Width * 0.7389) / 2,
                MinHeight = (this.Height * 0.7205) / 10,
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
        {
            StackPanel_Messages.Children.Clear();
            _myUserId = _dal.MyUserId(MyUserName.Content.ToString());
            _toUserId = _dal.ToUserId(_toUserName);
            _toUserIdList = _dal.GetToUsersId(_toUserId, _myUserId).ToList();
            _myUserIdList = _dal.GetMyUsersId(_toUserId, _myUserId).ToList();
            _msgList = _dal.GetMessages(_toUserId, _myUserId).ToList();
            _time_msgList = _dal.GetTimeMessages(_toUserId, _myUserId).ToList();
            FillAllMessages();
        }
        private void FillAllMessages()
        {
            for (int i = 0; i < _msgList.Count; i++)
            {
                TextBlock Message = new TextBlock()
                {
                    TextWrapping = TextWrapping.Wrap,
                    FontSize = 16,
                    Margin = new Thickness(10),
                    MinWidth = (this.Width * 0.7389) / 3,
                    MaxWidth = (this.Width * 0.7389) / 2,
                    MinHeight = (this.Height * 0.7205) / 10,
                    Padding = new Thickness(5)
                };
                Message.Inlines.Add(new Run(_msgList[i]));
                Message.Inlines.Add(new Run(_time_msgList[i].ToString().PadLeft(500))
                { FontSize = 11, Foreground = Brushes.Black });
                if (_toUserIdList[i] == _myUserId && _myUserIdList[i] == _toUserId)
                {
                    Message.HorizontalAlignment = HorizontalAlignment.Right;
                    Message.Background = new SolidColorBrush(Color.FromRgb(251, 209, 145));
                }
                if (_toUserIdList[i] == _toUserId && _myUserIdList[i] == _myUserId)
                {
                    Message.HorizontalAlignment = HorizontalAlignment.Left;
                    Message.Background = new SolidColorBrush(Color.FromRgb(251, 180, 180));
                }
                StackPanel_Messages.Children.Add(Message);
            }
        }
        private void UserIsOffline()
        {
            _dal.SetUserIsOffline(MyUserName.Content.ToString());
        }
        private void GetUserLog()
        {
            DataGrid_Admin.Columns.Clear();
            DataGrid_Admin.Items.Clear();
            Admin_CreateNewDataGridTextColumn("User", "UserName");
            Admin_CreateNewDataGridTextColumn("Description", "Description");
            Admin_CreateNewDataGridTextColumn("Date", "Date");
            foreach (var item in _dal.GetUserLog(_toUserName))
            {
                DataGrid_Admin.Items.Add(item);
            }
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
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (_focus_Message_Text == true)
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
            _timer.Stop();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (_adminOnline == true)
            {
                GetUserLog();
            }
            if (_user_Click == true)
            {
                ShowAllMessages();
            }
            if (_counter_Users == _dal.GetAllUsers().Count())
            {
                ShowUsersInfo();
            }
            else
            {
                CreateUsersUI();
                ShowUsersInfo();
                _counter_Users = _dal.GetAllUsers().Count();
            }
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ScrollViewer_MyStack.Height = (this.Height * 0.7205) - 103;
            MyUserName.Height = (this.Height * 0.7205) / 15;            
        }
    }
}
