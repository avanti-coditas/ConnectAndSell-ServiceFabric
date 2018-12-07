using System;
using System.Runtime.Serialization;

namespace DataModels
{
    public delegate void NewLoginEventHandler(object sender, NewLoginEventArgs e);

    [DataContract]
    public class NewLoginEventArgs : EventArgs
    {
        #region Fields
        #endregion

        #region Accessors
        [DataMember]
        public string UserDomain { get; set; }          //public string UserSidString { get; set; }       BBB DomainLogin

        [DataMember]
        public string LoginId { get; set; }

        [DataMember]
        public string Password { get; set; }

        //[DataMember]
        //public User.Roles Role { get; set; }

        //[DataMember]
        //public User User { get; set; }

        [DataMember]
        public NewLoginException Ex { get; set; }

        [DataMember]
        public DateTime EngineTime { get; set; }

        [DataMember]
        public bool WithPrejudice { get; set; }

        [DataMember]
        public bool ShowCallCounters { get; set; }

        [DataMember]
        public string AppName { get; set; }

        [DataMember]
        public string AppVersionNumber { get; set; }

        [DataMember]
        public string DotNetVersionNumber { get; set; }

        [DataMember]
        public string IPAddress { get; set; }

        [DataMember]
        public string GenChanId { get; set; }

        [DataMember]
        public bool TraceGenuineChannels { get; set; }

        [DataMember]
        public string TimeZoneId { get; set; }

        [DataMember]
        public string CryptoKey { get; set; }

        [DataMember]
        public bool BrowserUser { get; set; }           //BBB WebAppFilterTracking 	9/4/2012
        #endregion

        #region Lifecycle
        //BBB DomainLogin   9/28/2012
        //public LoginEventArgs(string UserSidString, string LoginId, string Password, User.Roles Role, bool WithPrejudice, string AppName, string AppVersionNumber, string DotNetVersionNumber, string TimeZoneId, string GenChanId, bool BrowserUser)   

        public NewLoginEventArgs()
        {
        }
        public NewLoginEventArgs(string UserDomain, string LoginId, string Password, /*User.Roles Role,*/ bool WithPrejudice, string AppName, string AppVersionNumber, string DotNetVersionNumber, string TimeZoneId, string GenChanId, bool BrowserUser)
        {
            this.UserDomain = UserDomain;
            this.LoginId = LoginId;
            this.Password = Password;
            // this.Role = Role;
            this.WithPrejudice = WithPrejudice;
            this.AppName = AppName;
            this.AppVersionNumber = AppVersionNumber;
            this.DotNetVersionNumber = DotNetVersionNumber;
            this.TimeZoneId = TimeZoneId;
            this.GenChanId = GenChanId;
            this.BrowserUser = BrowserUser;
        }

        public NewLoginEventArgs(string LoginId, string LoginPw, /*User.Roles Role,*/ bool WithPrejudice, string AppName, string AppVersionNumber, string DotNetVersionNumber, string TimeZoneId, string GenChanId, bool BrowserUser)
        {
            this.LoginId = LoginId;
            this.Password = LoginPw;
            //this.Role = Role;
            this.WithPrejudice = WithPrejudice;
            this.AppName = AppName;
            this.AppVersionNumber = AppVersionNumber;
            this.DotNetVersionNumber = DotNetVersionNumber;
            this.TimeZoneId = TimeZoneId;
            this.GenChanId = GenChanId;
            this.BrowserUser = BrowserUser;
        }
        #endregion

        #region Methods
        #endregion
    }
}
