using System;
using System.Runtime.Serialization;

namespace DataModels
{
    [DataContract]
    public class NewLoginException
    {
        public enum ReasonType { OK, ID, Password, Privilege, Duplicate, Remoting, Other }
        #region Fields
        [DataMember]
        public ReasonType Source { get; set; }

        [DataMember]
        public string ExceptionText { get; set; }
        #endregion

        #region Accessors
        #endregion

        #region Lifecycle
        public NewLoginException()
        {
            Source = ReasonType.Other;
        }
        public NewLoginException(ReasonType type)
        {
            Source = type;
        }

        public NewLoginException(ReasonType Reason, string Message)
        {
            Source = Reason;
            ExceptionText = Message.ToString();
        }

        public NewLoginException(System.Exception ex)
            : this(ReasonType.Other, ex.Message)
        {

        }
        #endregion
    }
}