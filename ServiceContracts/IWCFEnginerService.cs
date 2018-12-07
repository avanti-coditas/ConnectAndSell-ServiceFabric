using DataModels;
using System;
using System.ServiceModel;

namespace ServiceContracts
{
    [ServiceContract]
    public interface IWCFEngineService
    {

        [OperationContract(IsOneWay = false)]
        [FaultContract(typeof(NewLoginException))]
        NewLoginEventArgs DoCommandLineLogin(string LoginId, string LoginPw, /*User.Roles Role,*/ string AppName, string AppVersionNumber, string DotNetVersionNumber, string TimeZoneId, string GenChanId, bool BrowserUser);

        //[OperationContract(IsOneWay = false)]
        //[FaultContract(typeof(NewLoginException))]
        //NewLoginEventArgs DoDomainLogin(string UserDomainName, string LoginId, User.Roles Role, string AppName, string AppVersionNumber, string DotNetVersionNumber, string TimeZoneId, string GenChanId, bool BrowserUser);

        //[OperationContract(IsOneWay = false)]
        //[FaultContract(typeof(NewLoginException))]
        //NewLoginEventArgs DoInteractiveLogin(string LoginId, string Password, User.Roles Role, bool WithPrejudice, string AppName, string AppVersionNumber, string DotNetVersionNumber, string TimeZoneId, string GenChanId, bool BrowserUser);

        //[OperationContract(IsOneWay = true)]
        //void RecordActivity(Activity.Types Type, string UserIdentifier, string CampaignIdentifier, int SessionId,
        //    string Message, string Datum);

        //[OperationContract(IsOneWay = false)]
        //string GetUserInboundChannel(string UserIdentifier, bool? AsteriskQueuesEnabled = null);


        //[OperationContract(IsOneWay = true)]
        //void HangUpUser(string CampaignIdentifier, string UserIdentifier);

        //[OperationContract(IsOneWay = false)]
        //string EngineVersion();

        //[OperationContract(IsOneWay = false)]
        //void TransferCall(int SessionId, string UserIdentifier, int LeadTransitId, int LeadId, string ContactFirstName,
        //    string Number, int PrimaryNumberIndex, bool IsDirectCall);

        //[OperationContract(IsOneWay = false)]
        //void ChangeUserState(object sender, int UserID, string UserIdentifier, User.AppStates UserState);

        //[OperationContract(IsOneWay = false)]
        //StringCollection GetActiveUserList();

        //[OperationContract(IsOneWay = false)]
        //User GetActiveUser(string UserIdentifier);

        //[OperationContract(IsOneWay = false)]
        //UserCollection GetActiveUserCollection();

        //[OperationContract(IsOneWay = true)]
        //void ChangeUserField(User User, User.Fields FieldName);


        //[OperationContract(IsOneWay = false)]
        //DateTime SystemUtcTime();

        //[OperationContract(IsOneWay = true)]
        //void SendAppCommand(int UserID, string UserIdentifier, AppCommands AppCommand);

        //[OperationContract(IsOneWay = false)]
        //Campaign GetActiveCampaign(string CampaignIdentifier);

        //[OperationContract(IsOneWay = false)]
        //CampaignCollection GetActiveCampaignCollection();

        //[OperationContract(IsOneWay = true)]
        //void SendUserNotification(string Sender, int SessionId, string UserIdentifier, string Message);

        //[OperationContract(IsOneWay = false)]
        //UserCheckinEventArgs CheckIn(int UserId, string UserIdentifier, int SeqCounter, DateTime SendTime, int PrevSeqCounter, int PrevAvgRoundTripTime);

        //[OperationContract(IsOneWay = false)]
        //void LogUserOut(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void TransferSettings(string Key, object Value);
        //[OperationContract(IsOneWay = true)]
        //void TransferListSettings(object sender, int ListId, string Key, string Value);

        //[OperationContract(IsOneWay = false)]
        //void ImpersonateSettings(int ImpersonatingUserId, int ToImpersonateUserId, Boolean impersonateStatus);

        //[OperationContract(IsOneWay = true)]
        //void RefreshConnectStatus(int SessionId);

        //[OperationContract(IsOneWay = true)]
        //void PlayAudio(string UserIdentifier, string FilePath);

        //[OperationContract(IsOneWay = true)]
        //void ListenForActivities(User User, bool Flag);

        //[OperationContract(IsOneWay = true)]
        //void LogoutTestUser(User TestUser, String TestboxName);

        //[OperationContract(IsOneWay = true)]
        //void LoginTestUser(User TestUser, String TestboxName);

        //[OperationContract(IsOneWay = false)]
        //bool ToggleTraceState(string TraceName);

        //[OperationContract(IsOneWay = false)]
        //bool SetSolverOption(string userIdentifier, SolverTypeOption solverTypeOption, SolverValueOption solverValueOption);

        //[OperationContract(IsOneWay = false)]
        //bool GetTraceState(string TraceName);

        //[OperationContract(IsOneWay = false)]
        //void BulkDeactivateLeads(string CampaignIdentifier, string UserIdentifier, List<int> LeadIds, bool PersistActiveCall);

        //[OperationContract(IsOneWay = true)]
        //void ReportModuleException(string ModuleName, byte[] Ex);

        //[OperationContract(IsOneWay = true)]
        //void ReportException(string ModuleName, byte[] Ex, string Addendum);

        //[OperationContract(IsOneWay = true)]
        //void BulkActivateLeadsByActive(string CampaignIdentifier, string UserIdentifier, List<int> LeadIds, bool PersistActiveCall);

        //[OperationContract(IsOneWay = true)]
        //void BulkActivateLeads(string CampaignIdentifier, string UserIdentifier, List<int> LeadIds);

        //[OperationContract(IsOneWay = true)]
        //void SetupConnectorTestCampaign(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void EnrichSessionLead(int sessionId, int leadId, string enrichedPhone, bool isSuspectedDirectCall);

        //[OperationContract(IsOneWay = true)]
        //void NotifyNewLeadsForInjection(int sessionId);

        //[OperationContract(IsOneWay = true)]
        //void NotifyNewLeadSet(int SessionId, string ListName, bool IsInternationalList);

        //[OperationContract(IsOneWay = true)]
        //void SpawnDirectSession(string UserIdentifier, int UserId, bool IsDialerSession, bool IsNativeSfdcSession, bool IsCOLV, int SessionId = 0);

        //[OperationContract(IsOneWay = true)]
        //void SetSessionParameter(string UserIdentifier, int SessionId, SessionParameters ParameterType, object Parameter, object[] ParameterArray = null);

        //[OperationContract(IsOneWay = true)]
        //void SetMlParameters(int SessionId, Dictionary<int, ListSettings.MlStatistics> MlParameters);

        //[OperationContract(IsOneWay = true)]
        //void ChangeVoicemailInSession(string UserIdentifier, int SessionId, bool UseVoicemail, string VoicemailFileName);

        //[OperationContract(IsOneWay = true)]
        //void ChangeGreetingInSession(string UserIdentifier, int SessionId, bool UseGreeting, int GreetingId);

        //[OperationContract(IsOneWay = true)]
        //void SendCalendarInvite(string UserIdentifier, string Recipient, string CcList, string MessageBody, int AptLabelId, string AdditionalInfo);

        //[OperationContract(IsOneWay = true)]
        //void SendMail(string UserIdentifier, string Recipient, string CcList, string Subject, string MessageBody);

        //[OperationContract(IsOneWay = false)]
        //void UpdateCacheObject(string UserId, CacheType CacheName, CacheActionType CacheAction, DbObject Record);

        //[OperationContract(IsOneWay = true)]
        //void BroadcastSchedulerChangeNotification(int UserId, SchedulerPersistType PersistType, DxAppointment Target);

        //[OperationContract(IsOneWay = true)]
        //void TurnOffVoicemail(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void TurnOnVoicemail(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void TurnOffGreeting(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void TurnOnGreeting(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void SaveIVRPath(string SessionIdentifier, string UserIdentifier, IVRPathAction Action, Contact Contact);

        //[OperationContract(IsOneWay = true)]
        //void PlayDTMF(string SessionIdentifier, string UserIdentifier, IVRPathAction PlayDTMFAction, int NumberIndex, string DTMFSequence);

        //[OperationContract(IsOneWay = true)]
        //void LeaveVoicemail(string sessionIdentifier, string userIdentifier, string fileName);

        //[OperationContract(IsOneWay = true)]
        //void ListenToVoicemailByFile(string userIdentifier, string fileName);

        //[OperationContract(IsOneWay = true)]
        //void ListenToVoicemail(string userIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void ListenToGreetingWithFileName(string UserIdentifier, string fileName);

        //[OperationContract(IsOneWay = true)]
        //void ListenToGreeting(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void ListenToDefaultGreeting(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void StopRecordingVoicemail(string UserIdentifier, int Length, string fileName);

        //[OperationContract(IsOneWay = true)]
        //void StopRecordingGreeting(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void StopRecordingGreetingWithLength(string UserIdentifier, int length, string fileName);

        //[OperationContract(IsOneWay = true)]
        //void StartRecordingVoicemailByFile(string userIdentifier, string fileName);

        //[OperationContract(IsOneWay = true)]
        //void StartRecordingVoicemail(string userIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void StartRecordingVoicemailWithFileName(string userIdentifier, string fileName);

        //[OperationContract(IsOneWay = true)]
        //void StartRecordingGreeting(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void StartRecordingGreetingWithFileName(string UserIdentifier, string fileName);

        //[OperationContract(IsOneWay = true)]
        //void CallMe(string UserIdentifier, string Number, bool SaveNumber);

        //[OperationContract(IsOneWay = true)]
        //void CancelAgentCallAlert(string UserIdentifier, string Number);

        //[OperationContract(IsOneWay = true)]
        //void SendAgentCallAlert(string UserIdentifier, string UserName, string CampaignIdentifier, string ClientName, string CompanyName, string ContactName, string ContactTitle, string ContactCountry, string Number, string Message, string PitcherName, Dnc.DNCTypes DNCType);

        //[OperationContract(IsOneWay = true)]
        //void SendChunk(User User, int StartByte, int TransferCount, byte[] Bytes);

        //[OperationContract(IsOneWay = false)]
        //byte[] GetChunk(User User, int StartByte, int TransferCount);

        //[OperationContract(IsOneWay = true)]
        //void PassEmEvent(string SourceUser, string TargetUser, string Identifier, EmOption Option, object Info1);

        //[OperationContract(IsOneWay = true)]
        //void GetLeadCounts(int SessionId);

        //[OperationContract(IsOneWay = true)]
        //void StopLeadExport(string UserIdentifier);

        //[OperationContract(IsOneWay = false)]
        //List<CallAlertEventArgs> GetActiveCallAlerts();

        //[OperationContract(IsOneWay = true)]
        //[UseNetDataContractSerializer]
        //void StartLeadExport(User User, ExportGroupingType GroupingOption, string Name, DbFieldCollection ExportFields, string ExportFormat);

        //[OperationContract(IsOneWay = true)]
        //void StopLeadImport(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void StartLeadImport(User User, bool IsDuplicateCheck);

        //[OperationContract(IsOneWay = true)]
        //void UserKillSession(Campaign Campaign);

        //[OperationContract(IsOneWay = true)]
        //void KillSession(string UserIdentifier, int SessionId);

        //[OperationContract(IsOneWay = true)]
        //void SendMySessionReport(User User, DateTime From, DateTime To);

        //[OperationContract(IsOneWay = true)]
        //void NotifyGeneralAlert(User User, AlertEventArgs.AlertType AlertType, object Value);

        //[OperationContract(IsOneWay = true)]
        //void StartManualSession(string UserIdentifier, Campaign Campaign);


        //[OperationContract(IsOneWay = true)]
        //void SavePhoneCallInfo(int SessionId, string UserIdentifier, int PhoneCallId, PhoneNumber PhoneNumber, int ReportCode, string ReportComment);

        //[OperationContract(IsOneWay = false)]
        //void SaveCallRecord(int SessionId, string UserIdentifier, Call Call);
        //[OperationContract(IsOneWay = false)]
        //void NotifyBadNumber(int SessionId, string PrimaryNumber, int PrimaryNumberIndex);
        //[OperationContract(IsOneWay = false)]
        //void ChangeLeadState(int SessionId, string UserIdentifier, Lead Lead);

        //[OperationContract(IsOneWay = false)]
        //void SaveMultiTouchLog(int ContactId, int ListId, string ActionType, string Template, string UserName, string ClientName, int RuleId, int? SessionId, int? StepCount);
        //[OperationContract(IsOneWay = false)]
        //void TransferStatus(int SessionId, string UserIdentifier, int ListId, int ContactId, MultitouchActionTypes action, string actionStep);

        //[OperationContract(IsOneWay = true)]
        //void DisconnectFromConference(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void ListenToConference(string PitcherLoginId, string UserIdentifier, string CoachingAction);

        //[OperationContract(IsOneWay = true)]
        //void HangUpOutboundCall(string UserIdentifier, Activity.HangupReasons HangupReason);

        //[OperationContract(IsOneWay = true)]
        //void DialNumber(int SessionId, string UserIdentifier, int NumberIndex, string Number, string CallerId, Contact Contact = null);

        //[OperationContract(IsOneWay = true)]
        //void ChangeCampaignState(string UserIdentifier, int SessionId, Campaign.StatusType Status);

        //[OperationContract(IsOneWay = false)]
        //[UseNetDataContractSerializer]
        //object GetCurrentChannelMap();

        //[OperationContract(IsOneWay = false)]
        //UserStatusCollection GetUserStatusTable();

        //[OperationContract(IsOneWay = false)]
        //[UseNetDataContractSerializer]
        //object GetPhoneSystemStatus();

        //[OperationContract(IsOneWay = true)]
        //void RefreshPhoneSystemLoginInfo(string UserIdentification);

        //[OperationContract(IsOneWay = true)]
        //void SetDataLinkLatency(int Latency);

        //[OperationContract(IsOneWay = false)]
        //int GetDataLinkLatency();

        //[OperationContract(IsOneWay = true)]
        //void RunSqlLoadTest(string Test);

        //[OperationContract(IsOneWay = true)]
        //void ResetCallerIds();

        //[OperationContract(IsOneWay = true)]
        //void ReloadSystemParameters();

        //[OperationContract(IsOneWay = true)]
        //void ResetCountryInfo();

        //[OperationContract(IsOneWay = true)]
        //void ResetPhoneConnection(string UserIdentifier, string PhoneSwitchName);

        //[OperationContract(IsOneWay = true)]
        //void ResetPhoneSystemConfiguration(string UserIdentifier);

        //[OperationContract(IsOneWay = false)]
        //Campaign SyncCampaign(string CampaignIdentifier);

        //[OperationContract(IsOneWay = false)]
        //Campaign SyncCampaignByID(int SessionId);

        //[OperationContract(IsOneWay = false)]
        //object GetSysPar(string ParName);

        //[OperationContract(IsOneWay = false)]
        //MultiTouchEventArgs MultiTouchSettings(object sender, Dictionary<int, List<ListSettings.MultitouchRuleCustom>> ListRule, Dictionary<string, int> ContactHistoryAttempts);

        //[OperationContract(IsOneWay = false)]
        //UserEventArgs CreateOrUpdateUser(UserEventArgs newUserArgs, string loginId, string appName, string appVersionNumber, string dotNetVersionNumber, string timeZoneId, bool browserUser);

        //[OperationContract(IsOneWay = false)]
        //Dictionary<string, long> GetDatabaseSizes();

        //[OperationContract(IsOneWay = false)]
        //bool IsValidVersion(string UserIdentifier, string AppName, string AppVersion);

        //[OperationContract(IsOneWay = true)]
        //void AudioQualityIssue(int Userid, string UserIdentifier);

        //[OperationContract(IsOneWay = false)]
        //void SetCallBack(string UserIdentifier);

        //[OperationContract(IsOneWay = true)]
        //void DoHotTransfer(string UserIdentifier, string Number, string CallerId, TransferRequestType RequestType);

        //[OperationContract(IsOneWay = false)]
        //void NotifyNewLeadForDirectInjection(int SessionId, bool isClickToConnectLightning, int leadId);

        //[OperationContract(IsOneWay = false)]
        //void ActivateLead(int sessionId, int leadId);

        //[OperationContract(IsOneWay = true)]
        //void ChangeLeadPriorityInSession(int SessionId, int leadId, int CallingPriority);

        //[OperationContract(IsOneWay = true)]
        //void EditDetailsOfLeads(int SessionId, int leadId, String FirstName, String LastName, String CompanyName, String Title, String Phone1, String Phone2);

        //[OperationContract]
        //void InsertLeadToSession(int sessionID, int leadID);

        //[OperationContract]
        //object GetGlobalSettings(string Key);

        //[OperationContract(IsOneWay = true)]
        //void MarkNumberAsZeroTalkTime(string PhoneNumber, string Country);
        //[OperationContract(IsOneWay = true)]
        //void BumpPriorityForTransferPredictedLeads(int SessionId, Dictionary<int, bool> ContactTransferPredictionMap);

        //[OperationContract(IsOneWay = true)]
        //void SendContactVoiceMailStatus(int Sessionid, int ContactId, int LeadId, DateTime LastVoiceMail, string Source);

        //[OperationContract(IsOneWay = true)]
        //void CloseUserCallBackChannel(string UserName);

        //[OperationContract(IsOneWay = true)]
        //void UpdateLeadCounts(int SessionId, int thrown, int transferred);

        //[OperationContract(IsOneWay = true)]
        //void LeadsDetailUpdate(string CampaignIdentifier, string UserIdentifier, List<LeadDetail> LeadsDetails, bool PersistActiveCall);

        //[OperationContract(IsOneWay = false)]
        //Int32[] GracefullyExitedLeads(int sessionId, string UserIdentifier);
    }

    //public interface IWCFCallbackService
    //{
    //    //[UseNetDataContractSerializer]
    //    //[OperationContract(IsOneWay = true)]
    //    //void SendCommand(RemoteCommand command);
    //}
}
