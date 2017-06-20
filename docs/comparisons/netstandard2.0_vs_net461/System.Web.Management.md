# System.Web.Management

``` diff
+namespace System.Web.Management {
+    public abstract class BufferedWebEventProvider : WebEventProvider {
+        protected BufferedWebEventProvider();
+        public string BufferMode { get; }
+        public bool UseBuffering { get; }
+        public override void Flush();
+        public override void Initialize(string name, NameValueCollection config);
+        public override void ProcessEvent(WebBaseEvent eventRaised);
+        public abstract void ProcessEventFlush(WebEventBufferFlushInfo flushInfo);
+        public override void Shutdown();
+    }
+    public sealed class EventLogWebEventProvider : WebEventProvider, IInternalWebEventProvider {
+        public override void Flush();
+        public override void Initialize(string name, NameValueCollection config);
+        public override void ProcessEvent(WebBaseEvent eventRaised);
+        public override void Shutdown();
+    }
+    public enum EventNotificationType {
+        Flush = 2,
+        Regular = 0,
+        Unbuffered = 3,
+        Urgent = 1,
+    }
+    public sealed class IisTraceWebEventProvider : WebEventProvider {
+        public IisTraceWebEventProvider();
+        public override void Flush();
+        public override void Initialize(string name, NameValueCollection config);
+        public override void ProcessEvent(WebBaseEvent eventRaised);
+        public override void Shutdown();
+    }
+    public interface IRegiisUtility {
+        void ProtectedConfigAction(long actionToPerform, string firstArgument, string secondArgument, string providerName, string appPath, string site, string cspOrLocation, int keySize, out IntPtr exception);
+        void RegisterAsnetMmcAssembly(int doReg, string assemblyName, string binaryDirectory, out IntPtr exception);
+        void RegisterSystemWebAssembly(int doReg, out IntPtr exception);
+        void RemoveBrowserCaps(out IntPtr exception);
+    }
+    public interface IWebEventCustomEvaluator {
+        bool CanFire(WebBaseEvent raisedEvent, RuleFiringRecord record);
+    }
+    public sealed class MailEventNotificationInfo {
+        public WebBaseEventCollection Events { get; }
+        public int EventsDiscardedByBuffer { get; }
+        public int EventsDiscardedDueToMessageLimit { get; }
+        public int EventsInBuffer { get; }
+        public int EventsInNotification { get; }
+        public int EventsRemaining { get; }
+        public DateTime LastNotificationUtc { get; }
+        public MailMessage Message { get; }
+        public int MessageSequence { get; }
+        public int MessagesInNotification { get; }
+        public int NotificationSequence { get; }
+        public EventNotificationType NotificationType { get; }
+    }
+    public abstract class MailWebEventProvider : BufferedWebEventProvider {
+        public override void Initialize(string name, NameValueCollection config);
+        public override void ProcessEvent(WebBaseEvent eventRaised);
+        public override void ProcessEventFlush(WebEventBufferFlushInfo flushInfo);
+        public override void Shutdown();
+    }
+    public sealed class RegiisUtility : IRegiisUtility {
+        public RegiisUtility();
+        public void ProtectedConfigAction(long options, string firstArgument, string secondArgument, string providerName, string appPath, string site, string cspOrLocation, int keySize, out IntPtr exception);
+        public void RegisterAsnetMmcAssembly(int doReg, string typeName, string binaryDirectory, out IntPtr exception);
+        public void RegisterSystemWebAssembly(int doReg, out IntPtr exception);
+        public void RemoveBrowserCaps(out IntPtr exception);
+    }
+    public sealed class RuleFiringRecord {
+        public DateTime LastFired { get; }
+        public int TimesRaised { get; }
+    }
+    public enum SessionStateType {
+        Custom = 2,
+        Persisted = 1,
+        Temporary = 0,
+    }
+    public sealed class SimpleMailWebEventProvider : MailWebEventProvider, IInternalWebEventProvider {
+        public override void Initialize(string name, NameValueCollection config);
+    }
+    public sealed class SqlExecutionException : SystemException {
+        public SqlExecutionException();
+        public SqlExecutionException(string message);
+        public SqlExecutionException(string message, Exception innerException);
+        public SqlExecutionException(string message, string server, string database, string sqlFile, string commands, SqlException sqlException);
+        public string Commands { get; }
+        public string Database { get; }
+        public SqlException Exception { get; }
+        public string Server { get; }
+        public string SqlFile { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum SqlFeatures {
+        All = 1073741855,
+        Membership = 1,
+        None = 0,
+        Personalization = 8,
+        Profile = 2,
+        RoleManager = 4,
+        SqlWebEventProvider = 16,
+    }
+    public static class SqlServices {
+        public static string GenerateApplicationServicesScripts(bool install, SqlFeatures features, string database);
+        public static string GenerateSessionStateScripts(bool install, SessionStateType type, string customDatabase);
+        public static void Install(string server, string user, string password, string database, SqlFeatures features);
+        public static void Install(string server, string database, SqlFeatures features);
+        public static void Install(string database, SqlFeatures features, string connectionString);
+        public static void InstallSessionState(string server, string user, string password, string customDatabase, SessionStateType type);
+        public static void InstallSessionState(string server, string customDatabase, SessionStateType type);
+        public static void InstallSessionState(string customDatabase, SessionStateType type, string connectionString);
+        public static void Uninstall(string server, string user, string password, string database, SqlFeatures features);
+        public static void Uninstall(string server, string database, SqlFeatures features);
+        public static void Uninstall(string database, SqlFeatures features, string connectionString);
+        public static void UninstallSessionState(string server, string user, string password, string customDatabase, SessionStateType type);
+        public static void UninstallSessionState(string server, string customDatabase, SessionStateType type);
+        public static void UninstallSessionState(string customDatabase, SessionStateType type, string connectionString);
+    }
+    public class SqlWebEventProvider : BufferedWebEventProvider, IInternalWebEventProvider {
+        protected internal SqlWebEventProvider();
+        protected virtual void EventProcessingComplete(WebBaseEventCollection raisedEvents);
+        public override void Initialize(string name, NameValueCollection config);
+        public override void ProcessEvent(WebBaseEvent eventRaised);
+        public override void ProcessEventFlush(WebEventBufferFlushInfo flushInfo);
+        public override void Shutdown();
+    }
+    public sealed class TemplatedMailWebEventProvider : MailWebEventProvider, IInternalWebEventProvider {
+        public static MailEventNotificationInfo CurrentNotification { get; }
+        public override void Initialize(string name, NameValueCollection config);
+    }
+    public sealed class TraceWebEventProvider : WebEventProvider, IInternalWebEventProvider {
+        public override void Flush();
+        public override void Initialize(string name, NameValueCollection config);
+        public override void ProcessEvent(WebBaseEvent eventRaised);
+        public override void Shutdown();
+    }
+    public sealed class WebApplicationInformation {
+        public string ApplicationDomain { get; }
+        public string ApplicationPath { get; }
+        public string ApplicationVirtualPath { get; }
+        public string MachineName { get; }
+        public string TrustLevel { get; }
+        public void FormatToString(WebEventFormatter formatter);
+        public override string ToString();
+    }
+    public class WebApplicationLifetimeEvent : WebManagementEvent {
+        protected internal WebApplicationLifetimeEvent(string message, object eventSource, int eventCode);
+        protected internal WebApplicationLifetimeEvent(string message, object eventSource, int eventCode, int eventDetailCode);
+        protected internal override void IncrementPerfCounters();
+    }
+    public class WebAuditEvent : WebManagementEvent {
+        protected internal WebAuditEvent(string message, object eventSource, int eventCode);
+        protected internal WebAuditEvent(string message, object eventSource, int eventCode, int eventDetailCode);
+        public WebRequestInformation RequestInformation { get; }
+    }
+    public class WebAuthenticationFailureAuditEvent : WebFailureAuditEvent {
+        protected internal WebAuthenticationFailureAuditEvent(string message, object eventSource, int eventCode, int eventDetailCode, string nameToAuthenticate);
+        protected internal WebAuthenticationFailureAuditEvent(string message, object eventSource, int eventCode, string nameToAuthenticate);
+        public string NameToAuthenticate { get; }
+    }
+    public class WebAuthenticationSuccessAuditEvent : WebSuccessAuditEvent {
+        protected internal WebAuthenticationSuccessAuditEvent(string message, object eventSource, int eventCode, int eventDetailCode, string nameToAuthenticate);
+        protected internal WebAuthenticationSuccessAuditEvent(string message, object eventSource, int eventCode, string nameToAuthenticate);
+        public string NameToAuthenticate { get; }
+    }
+    public class WebBaseErrorEvent : WebManagementEvent {
+        protected internal WebBaseErrorEvent(string message, object eventSource, int eventCode, Exception e);
+        protected internal WebBaseErrorEvent(string message, object eventSource, int eventCode, int eventDetailCode, Exception e);
+        public Exception ErrorException { get; }
+        protected internal override void IncrementPerfCounters();
+    }
+    public class WebBaseEvent {
+        protected internal WebBaseEvent(string message, object eventSource, int eventCode);
+        protected internal WebBaseEvent(string message, object eventSource, int eventCode, int eventDetailCode);
+        public static WebApplicationInformation ApplicationInformation { get; }
+        public int EventCode { get; }
+        public int EventDetailCode { get; }
+        public Guid EventID { get; }
+        public long EventOccurrence { get; }
+        public long EventSequence { get; }
+        public object EventSource { get; }
+        public DateTime EventTime { get; }
+        public DateTime EventTimeUtc { get; }
+        public string Message { get; }
+        public virtual void FormatCustomEventDetails(WebEventFormatter formatter);
+        protected internal virtual void IncrementPerfCounters();
+        public virtual void Raise();
+        public static void Raise(WebBaseEvent eventRaised);
+        public override string ToString();
+        public virtual string ToString(bool includeAppInfo, bool includeCustomEventDetails);
+    }
+    public sealed class WebBaseEventCollection : ReadOnlyCollectionBase {
+        public WebBaseEventCollection(ICollection events);
+        public WebBaseEvent this[int index] { get; }
+        public bool Contains(WebBaseEvent value);
+        public int IndexOf(WebBaseEvent value);
+    }
+    public class WebErrorEvent : WebBaseErrorEvent {
+        protected internal WebErrorEvent(string message, object eventSource, int eventCode, Exception exception);
+        protected internal WebErrorEvent(string message, object eventSource, int eventCode, int eventDetailCode, Exception exception);
+        public WebRequestInformation RequestInformation { get; }
+        public WebThreadInformation ThreadInformation { get; }
+        protected internal override void IncrementPerfCounters();
+    }
+    public sealed class WebEventBufferFlushInfo {
+        public WebBaseEventCollection Events { get; }
+        public int EventsDiscardedSinceLastNotification { get; }
+        public int EventsInBuffer { get; }
+        public DateTime LastNotificationUtc { get; }
+        public int NotificationSequence { get; }
+        public EventNotificationType NotificationType { get; }
+    }
+    public sealed class WebEventCodes {
+        public const int ApplicationCodeBase = 1000;
+        public const int ApplicationCompilationEnd = 1004;
+        public const int ApplicationCompilationStart = 1003;
+        public const int ApplicationDetailCodeBase = 50000;
+        public const int ApplicationHeartbeat = 1005;
+        public const int ApplicationShutdown = 1002;
+        public const int ApplicationShutdownBinDirChangeOrDirectoryRename = 50007;
+        public const int ApplicationShutdownBrowsersDirChangeOrDirectoryRename = 50008;
+        public const int ApplicationShutdownBuildManagerChange = 50017;
+        public const int ApplicationShutdownChangeInGlobalAsax = 50003;
+        public const int ApplicationShutdownChangeInSecurityPolicyFile = 50006;
+        public const int ApplicationShutdownCodeDirChangeOrDirectoryRename = 50009;
+        public const int ApplicationShutdownConfigurationChange = 50004;
+        public const int ApplicationShutdownHostingEnvironment = 50002;
+        public const int ApplicationShutdownHttpRuntimeClose = 50013;
+        public const int ApplicationShutdownIdleTimeout = 50011;
+        public const int ApplicationShutdownInitializationError = 50014;
+        public const int ApplicationShutdownMaxRecompilationsReached = 50015;
+        public const int ApplicationShutdownPhysicalApplicationPathChanged = 50012;
+        public const int ApplicationShutdownResourcesDirChangeOrDirectoryRename = 50010;
+        public const int ApplicationShutdownUnknown = 50001;
+        public const int ApplicationShutdownUnloadAppDomainCalled = 50005;
+        public const int ApplicationStart = 1001;
+        public const int AuditCodeBase = 4000;
+        public const int AuditDetailCodeBase = 50200;
+        public const int AuditFileAuthorizationFailure = 4008;
+        public const int AuditFileAuthorizationSuccess = 4004;
+        public const int AuditFormsAuthenticationFailure = 4005;
+        public const int AuditFormsAuthenticationSuccess = 4001;
+        public const int AuditInvalidViewStateFailure = 4009;
+        public const int AuditMembershipAuthenticationFailure = 4006;
+        public const int AuditMembershipAuthenticationSuccess = 4002;
+        public const int AuditUnhandledAccessException = 4011;
+        public const int AuditUnhandledSecurityException = 4010;
+        public const int AuditUrlAuthorizationFailure = 4007;
+        public const int AuditUrlAuthorizationSuccess = 4003;
+        public const int ErrorCodeBase = 3000;
+        public const int ExpiredTicketFailure = 50202;
+        public const int InvalidEventCode = -1;
+        public const int InvalidTicketFailure = 50201;
+        public const int InvalidViewState = 50204;
+        public const int InvalidViewStateMac = 50203;
+        public const int MiscCodeBase = 6000;
+        public const int RequestCodeBase = 2000;
+        public const int RequestTransactionAbort = 2002;
+        public const int RequestTransactionComplete = 2001;
+        public const int RuntimeErrorPostTooLarge = 3004;
+        public const int RuntimeErrorRequestAbort = 3001;
+        public const int RuntimeErrorUnhandledException = 3005;
+        public const int RuntimeErrorValidationFailure = 3003;
+        public const int RuntimeErrorViewStateFailure = 3002;
+        public const int RuntimeErrorWebResourceFailure = 3012;
+        public const int SqlProviderEventsDropped = 50301;
+        public const int StateServerConnectionError = 50016;
+        public const int UndefinedEventCode = 0;
+        public const int UndefinedEventDetailCode = 0;
+        public const int WebErrorCompilationError = 3007;
+        public const int WebErrorConfigurationError = 3008;
+        public const int WebErrorObjectStateFormatterDeserializationError = 3011;
+        public const int WebErrorOtherError = 3009;
+        public const int WebErrorParserError = 3006;
+        public const int WebErrorPropertyDeserializationError = 3010;
+        public const int WebEventDetailCodeBase = 50300;
+        public const int WebEventProviderInformation = 6001;
+        public const int WebExtendedBase = 100000;
+    }
+    public class WebEventFormatter {
+        public int IndentationLevel { get; set; }
+        public int TabSize { get; set; }
+        public void AppendLine(string s);
+        public new string ToString();
+    }
+    public static class WebEventManager {
+        public static void Flush();
+        public static void Flush(string providerName);
+    }
+    public abstract class WebEventProvider : ProviderBase {
+        protected WebEventProvider();
+        public abstract void Flush();
+        public abstract void ProcessEvent(WebBaseEvent raisedEvent);
+        public abstract void Shutdown();
+    }
+    public class WebFailureAuditEvent : WebAuditEvent {
+        protected internal WebFailureAuditEvent(string message, object eventSource, int eventCode);
+        protected internal WebFailureAuditEvent(string message, object eventSource, int eventCode, int eventDetailCode);
+        protected internal override void IncrementPerfCounters();
+    }
+    public class WebHeartbeatEvent : WebManagementEvent {
+        protected internal WebHeartbeatEvent(string message, int eventCode);
+        public WebProcessStatistics ProcessStatistics { get; }
+    }
+    public class WebManagementEvent : WebBaseEvent {
+        protected internal WebManagementEvent(string message, object eventSource, int eventCode);
+        protected internal WebManagementEvent(string message, object eventSource, int eventCode, int eventDetailCode);
+        public WebProcessInformation ProcessInformation { get; }
+    }
+    public sealed class WebProcessInformation {
+        public string AccountName { get; }
+        public int ProcessID { get; }
+        public string ProcessName { get; }
+        public void FormatToString(WebEventFormatter formatter);
+    }
+    public class WebProcessStatistics {
+        public WebProcessStatistics();
+        public int AppDomainCount { get; }
+        public long ManagedHeapSize { get; }
+        public long PeakWorkingSet { get; }
+        public DateTime ProcessStartTime { get; }
+        public int RequestsExecuting { get; }
+        public int RequestsQueued { get; }
+        public int RequestsRejected { get; }
+        public int ThreadCount { get; }
+        public long WorkingSet { get; }
+        public virtual void FormatToString(WebEventFormatter formatter);
+    }
+    public class WebRequestErrorEvent : WebBaseErrorEvent {
+        protected internal WebRequestErrorEvent(string message, object eventSource, int eventCode, Exception exception);
+        protected internal WebRequestErrorEvent(string message, object eventSource, int eventCode, int eventDetailCode, Exception exception);
+        public WebRequestInformation RequestInformation { get; }
+        public WebThreadInformation ThreadInformation { get; }
+        protected internal override void IncrementPerfCounters();
+    }
+    public class WebRequestEvent : WebManagementEvent {
+        protected internal WebRequestEvent(string message, object eventSource, int eventCode);
+        protected internal WebRequestEvent(string message, object eventSource, int eventCode, int eventDetailCode);
+        public WebRequestInformation RequestInformation { get; }
+        protected internal override void IncrementPerfCounters();
+    }
+    public sealed class WebRequestInformation {
+        public IPrincipal Principal { get; }
+        public string RequestPath { get; }
+        public string RequestUrl { get; }
+        public string ThreadAccountName { get; }
+        public string UserHostAddress { get; }
+        public void FormatToString(WebEventFormatter formatter);
+    }
+    public class WebServiceErrorEvent : WebRequestErrorEvent {
+        protected internal WebServiceErrorEvent(string message, object eventSource, Exception exception);
+        public static int WebServiceErrorEventCode { get; }
+    }
+    public class WebSuccessAuditEvent : WebAuditEvent {
+        protected internal WebSuccessAuditEvent(string message, object eventSource, int eventCode);
+        protected internal WebSuccessAuditEvent(string message, object eventSource, int eventCode, int eventDetailCode);
+        protected internal override void IncrementPerfCounters();
+    }
+    public sealed class WebThreadInformation {
+        public bool IsImpersonating { get; }
+        public string StackTrace { get; }
+        public string ThreadAccountName { get; }
+        public int ThreadID { get; }
+        public void FormatToString(WebEventFormatter formatter);
+    }
+    public class WebViewStateFailureAuditEvent : WebFailureAuditEvent {
+        protected internal WebViewStateFailureAuditEvent(string message, object eventSource, int eventCode, int eventDetailCode, ViewStateException viewStateException);
+        protected internal WebViewStateFailureAuditEvent(string message, object eventSource, int eventCode, ViewStateException viewStateException);
+        public ViewStateException ViewStateException { get; }
+    }
+    public class WmiWebEventProvider : WebEventProvider {
+        public WmiWebEventProvider();
+        public override void Flush();
+        public override void Initialize(string name, NameValueCollection config);
+        public override void ProcessEvent(WebBaseEvent eventRaised);
+        public override void Shutdown();
+    }
+}
```

