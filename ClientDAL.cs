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
        public Message[] GetAllMessages()
        {
            return _service.GetAllMessages();
        }
        public LogUser[] GetAllLogs()
        {
            return _service.GetAllLogs();
        }
        public User CheckNickName(string signUp_UserName)
        {
            return _service.CheckNickName(signUp_UserName);
        }
        public void SignUp_NewUser(string fullName, string nickName, string password)
        {
            _service.SignUp_NewUser(fullName, nickName, password);
        }
        public User CheckAccount(string nickName, string password)
        {
            return _service.CheckAccount(nickName, password);
        }
        public void LogUser(string nickName)
        {
            _service.LogUser(nickName);
        }
        public User ForgotPass(string forgotPass_NickName)
        {
            return _service.ForgotPass(forgotPass_NickName);
        }
        public User CanCreateAdmin()
        {
            return _service.CanCreateAdmin();
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
        public void CreateMessage(string text, int myUserId, int toUserId)
        {
            _service.CreateMessage(text, myUserId, toUserId);
        }
        public void CreateAdmin()
        {
            _service.CreateAdmin();
        }
        public int[] GetToUsersId(int toUserId, int myUserId)
        {
            return _service.GetToUsersId(toUserId, myUserId);
        }
        public int[] GetMyUsersId(int toUserId, int myUserId)
        {
            return _service.GetMyUsersId(toUserId, myUserId);
        }
        public string[] GetMessages(int toUserId, int myUserId)
        {
            return _service.GetMessages(toUserId, myUserId);
        }
        public DateTime[] GetTimeMessages(int toUserId, int myUserId)
        {
            return _service.GetTimeMessages(toUserId, myUserId);
        }
        public void CreateAdmin()
        {
            _service.CreateAdmin();
        }
    }
}
