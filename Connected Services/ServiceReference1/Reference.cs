﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_Cursova.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsOnlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_Cursova.ServiceReference1.LogUser[] LogUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_Cursova.ServiceReference1.Message[] MessagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOnline {
            get {
                return this.IsOnlineField;
            }
            set {
                if ((this.IsOnlineField.Equals(value) != true)) {
                    this.IsOnlineField = value;
                    this.RaisePropertyChanged("IsOnline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_Cursova.ServiceReference1.LogUser[] LogUser {
            get {
                return this.LogUserField;
            }
            set {
                if ((object.ReferenceEquals(this.LogUserField, value) != true)) {
                    this.LogUserField = value;
                    this.RaisePropertyChanged("LogUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_Cursova.ServiceReference1.Message[] Messages {
            get {
                return this.MessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.MessagesField, value) != true)) {
                    this.MessagesField = value;
                    this.RaisePropertyChanged("Messages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName {
            get {
                return this.NickNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NickNameField, value) != true)) {
                    this.NickNameField = value;
                    this.RaisePropertyChanged("NickName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LogUser", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class LogUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_Cursova.ServiceReference1.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_Cursova.ServiceReference1.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ToUserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_Cursova.ServiceReference1.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ToUserId {
            get {
                return this.ToUserIdField;
            }
            set {
                if ((this.ToUserIdField.Equals(value) != true)) {
                    this.ToUserIdField = value;
                    this.RaisePropertyChanged("ToUserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_Cursova.ServiceReference1.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllUsers", ReplyAction="http://tempuri.org/IService1/GetAllUsersResponse")]
        Client_Cursova.ServiceReference1.User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllUsers", ReplyAction="http://tempuri.org/IService1/GetAllUsersResponse")]
        System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMessages", ReplyAction="http://tempuri.org/IService1/GetAllMessagesResponse")]
        Client_Cursova.ServiceReference1.Message[] GetAllMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMessages", ReplyAction="http://tempuri.org/IService1/GetAllMessagesResponse")]
        System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.Message[]> GetAllMessagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserLog", ReplyAction="http://tempuri.org/IService1/GetUserLogResponse")]
        Client_Cursova.ServiceReference1.LogUser[] GetUserLog(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserLog", ReplyAction="http://tempuri.org/IService1/GetUserLogResponse")]
        System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.LogUser[]> GetUserLogAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckNickName", ReplyAction="http://tempuri.org/IService1/CheckNickNameResponse")]
        Client_Cursova.ServiceReference1.User CheckNickName(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckNickName", ReplyAction="http://tempuri.org/IService1/CheckNickNameResponse")]
        System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User> CheckNickNameAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SignUp_NewUser", ReplyAction="http://tempuri.org/IService1/SignUp_NewUserResponse")]
        void SignUp_NewUser(string fullName, string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SignUp_NewUser", ReplyAction="http://tempuri.org/IService1/SignUp_NewUserResponse")]
        System.Threading.Tasks.Task SignUp_NewUserAsync(string fullName, string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckAccount", ReplyAction="http://tempuri.org/IService1/CheckAccountResponse")]
        Client_Cursova.ServiceReference1.User CheckAccount(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckAccount", ReplyAction="http://tempuri.org/IService1/CheckAccountResponse")]
        System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User> CheckAccountAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ForgotPass", ReplyAction="http://tempuri.org/IService1/ForgotPassResponse")]
        Client_Cursova.ServiceReference1.User ForgotPass(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ForgotPass", ReplyAction="http://tempuri.org/IService1/ForgotPassResponse")]
        System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User> ForgotPassAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetUserIsOffline", ReplyAction="http://tempuri.org/IService1/SetUserIsOfflineResponse")]
        void SetUserIsOffline(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetUserIsOffline", ReplyAction="http://tempuri.org/IService1/SetUserIsOfflineResponse")]
        System.Threading.Tasks.Task SetUserIsOfflineAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetUserIsOnline", ReplyAction="http://tempuri.org/IService1/SetUserIsOnlineResponse")]
        void SetUserIsOnline(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetUserIsOnline", ReplyAction="http://tempuri.org/IService1/SetUserIsOnlineResponse")]
        System.Threading.Tasks.Task SetUserIsOnlineAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MyUserId", ReplyAction="http://tempuri.org/IService1/MyUserIdResponse")]
        int MyUserId(string myUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MyUserId", ReplyAction="http://tempuri.org/IService1/MyUserIdResponse")]
        System.Threading.Tasks.Task<int> MyUserIdAsync(string myUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToUserId", ReplyAction="http://tempuri.org/IService1/ToUserIdResponse")]
        int ToUserId(string toUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToUserId", ReplyAction="http://tempuri.org/IService1/ToUserIdResponse")]
        System.Threading.Tasks.Task<int> ToUserIdAsync(string toUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateMessage", ReplyAction="http://tempuri.org/IService1/CreateMessageResponse")]
        void CreateMessage(string text, int myUserId, int toUserId, string toUserName, string myUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateMessage", ReplyAction="http://tempuri.org/IService1/CreateMessageResponse")]
        System.Threading.Tasks.Task CreateMessageAsync(string text, int myUserId, int toUserId, string toUserName, string myUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CanCreateAdmin", ReplyAction="http://tempuri.org/IService1/CanCreateAdminResponse")]
        Client_Cursova.ServiceReference1.User CanCreateAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CanCreateAdmin", ReplyAction="http://tempuri.org/IService1/CanCreateAdminResponse")]
        System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User> CanCreateAdminAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAdmin", ReplyAction="http://tempuri.org/IService1/CreateAdminResponse")]
        void CreateAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAdmin", ReplyAction="http://tempuri.org/IService1/CreateAdminResponse")]
        System.Threading.Tasks.Task CreateAdminAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetToUsersId", ReplyAction="http://tempuri.org/IService1/GetToUsersIdResponse")]
        int[] GetToUsersId(int toUserId, int myUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetToUsersId", ReplyAction="http://tempuri.org/IService1/GetToUsersIdResponse")]
        System.Threading.Tasks.Task<int[]> GetToUsersIdAsync(int toUserId, int myUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMyUsersId", ReplyAction="http://tempuri.org/IService1/GetMyUsersIdResponse")]
        int[] GetMyUsersId(int toUserId, int myUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMyUsersId", ReplyAction="http://tempuri.org/IService1/GetMyUsersIdResponse")]
        System.Threading.Tasks.Task<int[]> GetMyUsersIdAsync(int toUserId, int myUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMessages", ReplyAction="http://tempuri.org/IService1/GetMessagesResponse")]
        string[] GetMessages(int toUserId, int myUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMessages", ReplyAction="http://tempuri.org/IService1/GetMessagesResponse")]
        System.Threading.Tasks.Task<string[]> GetMessagesAsync(int toUserId, int myUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTimeMessages", ReplyAction="http://tempuri.org/IService1/GetTimeMessagesResponse")]
        System.DateTime[] GetTimeMessages(int toUserId, int myUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTimeMessages", ReplyAction="http://tempuri.org/IService1/GetTimeMessagesResponse")]
        System.Threading.Tasks.Task<System.DateTime[]> GetTimeMessagesAsync(int toUserId, int myUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LogUser", ReplyAction="http://tempuri.org/IService1/LogUserResponse")]
        void LogUser(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LogUser", ReplyAction="http://tempuri.org/IService1/LogUserResponse")]
        System.Threading.Tasks.Task LogUserAsync(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client_Cursova.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client_Cursova.ServiceReference1.IService1>, Client_Cursova.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_Cursova.ServiceReference1.User[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public Client_Cursova.ServiceReference1.Message[] GetAllMessages() {
            return base.Channel.GetAllMessages();
        }
        
        public System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.Message[]> GetAllMessagesAsync() {
            return base.Channel.GetAllMessagesAsync();
        }
        
        public Client_Cursova.ServiceReference1.LogUser[] GetUserLog(string userName) {
            return base.Channel.GetUserLog(userName);
        }
        
        public System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.LogUser[]> GetUserLogAsync(string userName) {
            return base.Channel.GetUserLogAsync(userName);
        }
        
        public Client_Cursova.ServiceReference1.User CheckNickName(string userName) {
            return base.Channel.CheckNickName(userName);
        }
        
        public System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User> CheckNickNameAsync(string userName) {
            return base.Channel.CheckNickNameAsync(userName);
        }
        
        public void SignUp_NewUser(string fullName, string userName, string password) {
            base.Channel.SignUp_NewUser(fullName, userName, password);
        }
        
        public System.Threading.Tasks.Task SignUp_NewUserAsync(string fullName, string userName, string password) {
            return base.Channel.SignUp_NewUserAsync(fullName, userName, password);
        }
        
        public Client_Cursova.ServiceReference1.User CheckAccount(string userName, string password) {
            return base.Channel.CheckAccount(userName, password);
        }
        
        public System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User> CheckAccountAsync(string userName, string password) {
            return base.Channel.CheckAccountAsync(userName, password);
        }
        
        public Client_Cursova.ServiceReference1.User ForgotPass(string userName) {
            return base.Channel.ForgotPass(userName);
        }
        
        public System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User> ForgotPassAsync(string userName) {
            return base.Channel.ForgotPassAsync(userName);
        }
        
        public void SetUserIsOffline(string userName) {
            base.Channel.SetUserIsOffline(userName);
        }
        
        public System.Threading.Tasks.Task SetUserIsOfflineAsync(string userName) {
            return base.Channel.SetUserIsOfflineAsync(userName);
        }
        
        public void SetUserIsOnline(string userName) {
            base.Channel.SetUserIsOnline(userName);
        }
        
        public System.Threading.Tasks.Task SetUserIsOnlineAsync(string userName) {
            return base.Channel.SetUserIsOnlineAsync(userName);
        }
        
        public int MyUserId(string myUserName) {
            return base.Channel.MyUserId(myUserName);
        }
        
        public System.Threading.Tasks.Task<int> MyUserIdAsync(string myUserName) {
            return base.Channel.MyUserIdAsync(myUserName);
        }
        
        public int ToUserId(string toUserName) {
            return base.Channel.ToUserId(toUserName);
        }
        
        public System.Threading.Tasks.Task<int> ToUserIdAsync(string toUserName) {
            return base.Channel.ToUserIdAsync(toUserName);
        }
        
        public void CreateMessage(string text, int myUserId, int toUserId, string toUserName, string myUserName) {
            base.Channel.CreateMessage(text, myUserId, toUserId, toUserName, myUserName);
        }
        
        public System.Threading.Tasks.Task CreateMessageAsync(string text, int myUserId, int toUserId, string toUserName, string myUserName) {
            return base.Channel.CreateMessageAsync(text, myUserId, toUserId, toUserName, myUserName);
        }
        
        public Client_Cursova.ServiceReference1.User CanCreateAdmin() {
            return base.Channel.CanCreateAdmin();
        }
        
        public System.Threading.Tasks.Task<Client_Cursova.ServiceReference1.User> CanCreateAdminAsync() {
            return base.Channel.CanCreateAdminAsync();
        }
        
        public void CreateAdmin() {
            base.Channel.CreateAdmin();
        }
        
        public System.Threading.Tasks.Task CreateAdminAsync() {
            return base.Channel.CreateAdminAsync();
        }
        
        public int[] GetToUsersId(int toUserId, int myUserId) {
            return base.Channel.GetToUsersId(toUserId, myUserId);
        }
        
        public System.Threading.Tasks.Task<int[]> GetToUsersIdAsync(int toUserId, int myUserId) {
            return base.Channel.GetToUsersIdAsync(toUserId, myUserId);
        }
        
        public int[] GetMyUsersId(int toUserId, int myUserId) {
            return base.Channel.GetMyUsersId(toUserId, myUserId);
        }
        
        public System.Threading.Tasks.Task<int[]> GetMyUsersIdAsync(int toUserId, int myUserId) {
            return base.Channel.GetMyUsersIdAsync(toUserId, myUserId);
        }
        
        public string[] GetMessages(int toUserId, int myUserId) {
            return base.Channel.GetMessages(toUserId, myUserId);
        }
        
        public System.Threading.Tasks.Task<string[]> GetMessagesAsync(int toUserId, int myUserId) {
            return base.Channel.GetMessagesAsync(toUserId, myUserId);
        }
        
        public System.DateTime[] GetTimeMessages(int toUserId, int myUserId) {
            return base.Channel.GetTimeMessages(toUserId, myUserId);
        }
        
        public System.Threading.Tasks.Task<System.DateTime[]> GetTimeMessagesAsync(int toUserId, int myUserId) {
            return base.Channel.GetTimeMessagesAsync(toUserId, myUserId);
        }
        
        public void LogUser(string userName) {
            base.Channel.LogUser(userName);
        }
        
        public System.Threading.Tasks.Task LogUserAsync(string userName) {
            return base.Channel.LogUserAsync(userName);
        }
    }
}
