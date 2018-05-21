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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Client_Cursova;
namespace Client_UI
{
    public partial class WindowLog2 : Window
    {
        private readonly ClientDAL _dal = new ClientDAL();
        public WindowLog2()
        {
            InitializeComponent();
        }
        private void ForgotPass_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Label).Foreground = new SolidColorBrush(Color.FromRgb(243, 44, 44));
        }
        private void ForgotPass_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Label).Foreground = new SolidColorBrush(Color.FromRgb(66, 66, 66));
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Close();
        }
        private void ForgotPass_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ForgotPassWindow.IsOpen = true;
        }
        private void PackIcon_LogIn_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Password_Login.Text = Login_Password.Password;
            TextBox_Password_Login.Visibility = Visibility.Visible;
            Login_Password.Visibility = Visibility.Hidden;
        }
        private void PackIcon_LogIn_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_Password_Login.Visibility = Visibility.Hidden;
            Login_Password.Visibility = Visibility.Visible;
            Login_Password.Focus();
        }
        private void PackIcon_SignUp_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_Password_SignUp.Text = SignUp_Password.Password;
            TextBox_Password_SignUp.Visibility = Visibility.Visible;
            SignUp_Password.Visibility = Visibility.Hidden;
        }
        private void PackIcon_SignUp_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_Password_SignUp.Visibility = Visibility.Hidden;
            SignUp_Password.Visibility = Visibility.Visible;
            SignUp_Password.Focus();
        }

        private void SIGNUP_End_Registration_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow.IsOpen = true;
            var checkNickName = _dal.CheckNickName(SignUp_UserName.Text);
            if (checkNickName == null &&
                SignUp_FullName.Text != string.Empty &&
                SignUp_Password.Password != string.Empty)
            {
                _dal.SignUp_NewUser(SignUp_FullName.Text, SignUp_UserName.Text,
                                    SignUp_Password.Password);
                InfoTextBlock.Text = "Registration was successful!!";
                SignUp_FullName.Text = string.Empty;
                SignUp_Password.Password = string.Empty;
                SignUp_UserName.Text = string.Empty;
            }
            else
            {
                if (checkNickName != null)
                {
                    InfoTextBlock.Text = "This User Name was created!";
                }
                if (SignUp_FullName.Text == string.Empty ||
                    SignUp_UserName.Text == string.Empty ||
                    SignUp_Password.Password == string.Empty)
                {
                    InfoTextBlock.Text = "Invalid Data";
                }
            }
        }
        ////////////
        private void LOGIN_Click(object sender, RoutedEventArgs e)
        {
            CheckLoginWindow.IsOpen = true;
            if (_dal.CheckAccount(Login_UserName.Text, Login_Password.Password) == true)
            {
                TextBlock_Check_Login.Text = "Hello " + Login_UserName.Text;
                _dal.LogUser(Login_UserName.Text);

            }
            else
            {
                TextBlock_Check_Login.Text = "Invalid data!!";
            }
        }
        private void CheckLogin_Click(object sender, RoutedEventArgs e)
        {
            if (_dal.CheckAccount(Login_UserName.Text, Login_Password.Password) == true)
            {
                WindowChat windowChat = new WindowChat();
                windowChat.MyUserName.Content = Login_UserName.Text;
                this.Owner.Close();
                windowChat.Show();
            }
            CheckLoginWindow.IsOpen = false;
        }
        private void ForgotPass_UserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var forgotAccount = _dal.ForgotPass(ForgotPass_UserName.Text);
            if (forgotAccount != null)
            {
                Login_UserName.Text = forgotAccount.NickName;
                Login_Password.Password = forgotAccount.Password;
                ForgotPass_Info.Content = "Such a name exists";
            }
            else
            {
                ForgotPass_Info.Content = "UserName not found!!";
                Login_UserName.Text = String.Empty;
                Login_Password.Password = String.Empty;
            }
        }
    }
}

