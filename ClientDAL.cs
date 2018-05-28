using System;
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
        public LogUser[] GetUserLog(string userName)
        {
            return _service.GetUserLog(userName);
        }
        public User CheckNickName(string userName)
        {
            return _service.CheckNickName(userName);
        }
        public void LogUser(string userName)
        {
            _service.LogUser(userName);
        }
        public void SignUp_NewUser(string fullName, string userName, string password)
        {
            _service.SignUp_NewUser(fullName, userName, password);
        }
        public User CheckAccount(string userName, string password)
        {
            return _service.CheckAccount(userName, password);
        }
        public User ForgotPass(string userName)
        {
            return _service.ForgotPass(userName);
        }
        public User CanCreateAdmin()
        {
            return _service.CanCreateAdmin();
        }
        public void SetUserIsOffline(string userName)
        {
             _service.SetUserIsOffline(userName);
        }
        public void SetUserIsOnline(string userName)
        {
            _service.SetUserIsOnline(userName);
        }
        public int MyUserId(string myUserName)
        {
            return _service.MyUserId(myUserName);
        }
        public int ToUserId(string toUserName)
        {
            return _service.ToUserId(toUserName);
        }
        public void CreateMessage(string text, int myUserId, int toUserId, string toUserName, string myUserName)
        {
            _service.CreateMessage(text, myUserId, toUserId, toUserName, myUserName);
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
    }
}
