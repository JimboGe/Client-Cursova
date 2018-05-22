using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Client_Cursova;
namespace Client_UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowLog2 w2 = new WindowLog2();
        DoubleAnimation Animation = new DoubleAnimation();
        private readonly ClientDAL _dal = new ClientDAL();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SIGNUP_Click(object sender, RoutedEventArgs e)
        {
            Animation.Duration = TimeSpan.FromSeconds(0.2);
            Animation.From = w2.Left;
            Animation.To = this.Left + 40;
            w2.BeginAnimation(Window.LeftProperty, Animation);
            w2.SignUp_FullName.Visibility = Visibility.Visible;
            w2.SignUp_Label.Visibility = Visibility.Visible;
            w2.SignUp_Password.Visibility = Visibility.Visible;
            w2.SignUp_UserName.Visibility = Visibility.Visible;
            w2.Icon_SignUp_AccountKey.Visibility = Visibility.Visible;
            w2.LogIn_Button.Visibility = Visibility.Hidden;
            w2.LogIn_Label.Visibility = Visibility.Hidden;
            w2.Login_Password.Visibility = Visibility.Hidden;
            w2.Login_UserName.Visibility = Visibility.Hidden;
            w2.ForgotPass_Label.Visibility = Visibility.Hidden;
            w2.Icon_SignUp_Account.Visibility = Visibility.Visible;
            w2.Icon_Login_AccountKey.Visibility = Visibility.Hidden;
            w2.Icon_Button_SignUp_Pass.Visibility = Visibility.Visible;
            w2.Icon_Button_Login_Pass.Visibility = Visibility.Hidden;
        }
        private void LOGIN_Click(object sender, RoutedEventArgs e)
        {
            Animation.Duration = TimeSpan.FromSeconds(0.2);
            Animation.From = w2.ActualWidth;
            Animation.To = this.ActualWidth - 110;
            w2.BeginAnimation(Window.LeftProperty, Animation);
            w2.SignUp_FullName.Visibility = Visibility.Hidden;
            w2.SignUp_Label.Visibility = Visibility.Hidden;
            w2.SignUp_Password.Visibility = Visibility.Hidden;
            w2.SignUp_UserName.Visibility = Visibility.Hidden;
            w2.Icon_SignUp_AccountKey.Visibility = Visibility.Hidden;
            w2.LogIn_Button.Visibility = Visibility.Visible;
            w2.LogIn_Label.Visibility = Visibility.Visible;
            w2.Login_Password.Visibility = Visibility.Visible;
            w2.Login_UserName.Visibility = Visibility.Visible;
            w2.ForgotPass_Label.Visibility = Visibility.Visible;
            w2.Icon_SignUp_Account.Visibility = Visibility.Hidden;
            w2.Icon_Login_AccountKey.Visibility = Visibility.Visible;
            w2.TextBox_Password_SignUp.Visibility = Visibility.Hidden;
            w2.Icon_Button_SignUp_Pass.Visibility = Visibility.Hidden;
            w2.Icon_Button_Login_Pass.Visibility = Visibility.Visible;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(_dal.CanCreateAdmin() == null)
            {
                _dal.CreateAdmin();
            }
            w2.Show();
            w2.Focus();
            w2.Owner = this;
            w2.Left = this.Left + 40;
        }

    }
}
