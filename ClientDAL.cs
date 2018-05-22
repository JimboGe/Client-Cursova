using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_Cursova.ServiceReference1;
namespace Client_Cursova
{
    public class ClientDAL
    {
        private readonly Service1Client _service = new Service1Client();
        public User[] GetAllUsers()
        {
            return _service.GetAllUsers();
        }
        public Message[]GetAllMessages()
        {
            return _service.GetAllMessages();
        }
        public LogUser[] GetAllLogs()
        {
            return _service.GetAllLogs();
        }
        public User CheckNickName(string SignUp_UserName)
        {
            return _service.CheckNickName(SignUp_UserName);
        }
        public void SignUp_NewUser(string FullName, string NickName, string Password)
        {
            _service.SignUp_NewUser(FullName, NickName, Password);
        }
        public User CheckAccount(string NickName, string Password)
        {
            return _service.CheckAccount(NickName, Password);
        }
        public void LogUser(string NickName)
        {
            _service.LogUser(NickName);
        }
        public User ForgotPass(string ForgotPass_NickName)
        {
            return _service.ForgotPass(ForgotPass_NickName);
        }
        public void SetUserIsOffline(string nickName)
        {
             _service.SetUserIsOffline(nickName);
        }
        public void SetUserIsOnline(string nickName)
        {
            _service.SetUserIsOnline(nickName);
        }
        public int MyUserId(string myUserName)
        {
            return _service.MyUserId(myUserName);
        }
        public int ToUserId(string toUserName)
        {
            return _service.ToUserId(toUserName);
        }
        public void CreateMessage(string Text, int myUserId, int toUserId)
        {
            _service.CreateMessage(Text, myUserId, toUserId);
        }
        public void CreateAdmin()
        {
            _service.CreateAdmin();
        }
    }
}
