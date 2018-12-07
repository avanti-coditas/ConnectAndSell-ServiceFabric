using DataModels;
using System.ServiceModel;
using System.Text;

namespace ServiceContracts
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerSession)]
    public class WCFEngineService : IWCFEngineService
    {
        public NewLoginEventArgs DoCommandLineLogin(string LoginId, string LoginPw, /*User.Roles Role,*/ string AppName, string AppVersionNumber, string DotNetVersionNumber, string TimeZoneId, string GenChanId, bool BrowserUser)
        {
            /*  start trace  */

            //if (TraceEngineLink)
            //    RecordActivity(Activity.Types.Trace, "EngineLink", "", 0, "Entering DoCommandLineLogin", LoginId);


            /*  set up a default response  */

            NewLoginEventArgs Result = new NewLoginEventArgs(LoginId, LoginPw, /*Role,*/ true, AppName, AppVersionNumber, DotNetVersionNumber, TimeZoneId, GenChanId, BrowserUser);

            /*  do the event  */

            //try
            //{
            //    if (UserLoggingIn != null)
            //        UserLoggingIn(null, Result);
            //}
            //catch (Exception ex)
            //{
            //    ReportException("DoCommandLineLogin", ex, LoginId);
            //}

            ///*  end trace  */

            //if (TraceEngineLink)
            //    RecordActivity(Activity.Types.Trace, "EngineLink", "", 0, "Exiting DoCommandLineLogin", LoginId);

            /*  send back the residue  */

            return Result;
        }
    }
}
