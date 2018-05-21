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
        public User CheckNickName(string SignUp_UserName)
        {
            return _service.CheckNickName(SignUp_UserName);
        }
        public void SignUp_NewUser(string FullName, string NickName, string Password)
        {
            _service.SignUp_NewUser(FullName, NickName, Password);
        }
        public bool CheckAccount(string NickName, string Password)
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
    }
}
