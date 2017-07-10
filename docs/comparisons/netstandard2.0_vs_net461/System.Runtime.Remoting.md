# System.Runtime.Remoting

``` diff
+namespace System.Runtime.Remoting {
+    public class ActivatedClientTypeEntry : TypeEntry {
+        public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl);
+        public ActivatedClientTypeEntry(Type type, string appUrl);
+        public string ApplicationUrl { get; }
+        public IContextAttribute[] ContextAttributes { get; set; }
+        public Type ObjectType { get; }
+        public override string ToString();
+    }
+    public class ActivatedServiceTypeEntry : TypeEntry {
+        public ActivatedServiceTypeEntry(string typeName, string assemblyName);
+        public ActivatedServiceTypeEntry(Type type);
+        public IContextAttribute[] ContextAttributes { get; set; }
+        public Type ObjectType { get; }
+        public override string ToString();
+    }
+    public enum CustomErrorsModes {
+        Off = 1,
+        On = 0,
+        RemoteOnly = 2,
+    }
+    public interface IChannelInfo {
+        object[] ChannelData { get; set; }
+    }
+    public interface IEnvoyInfo {
+        IMessageSink EnvoySinks { get; set; }
+    }
+    public class InternalRemotingServices {
+        public InternalRemotingServices();
+        public static void DebugOutChnl(string s);
+        public static SoapAttribute GetCachedSoapAttribute(object reflectionObject);
+        public static void RemotingAssert(bool condition, string message);
+        public static void RemotingTrace(params object[] messages);
+        public static void SetServerIdentity(MethodCall m, object srvID);
+    }
+    public interface IObjectHandle {
+        object Unwrap();
+    }
+    public interface IRemotingTypeInfo {
+        string TypeName { get; set; }
+        bool CanCastTo(Type fromType, object o);
+    }
+    public class ObjectHandle : MarshalByRefObject, IObjectHandle {
+        public ObjectHandle(object o);
+        public override object InitializeLifetimeService();
+        public object Unwrap();
+    }
+    public class ObjRef : IObjectReference, ISerializable {
+        public ObjRef();
+        public ObjRef(MarshalByRefObject o, Type requestedType);
+        protected ObjRef(SerializationInfo info, StreamingContext context);
+        public virtual IChannelInfo ChannelInfo { get; set; }
+        public virtual IEnvoyInfo EnvoyInfo { get; set; }
+        public virtual IRemotingTypeInfo TypeInfo { get; set; }
+        public virtual string URI { get; set; }
+        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        public virtual object GetRealObject(StreamingContext context);
+        public bool IsFromThisAppDomain();
+        public bool IsFromThisProcess();
+    }
+    public static class RemotingConfiguration {
+        public static string ApplicationId { get; }
+        public static string ApplicationName { get; set; }
+        public static CustomErrorsModes CustomErrorsMode { get; set; }
+        public static string ProcessId { get; }
+        public static void Configure(string filename);
+        public static void Configure(string filename, bool ensureSecurity);
+        public static bool CustomErrorsEnabled(bool isLocalRequest);
+        public static ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes();
+        public static ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes();
+        public static WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes();
+        public static WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes();
+        public static bool IsActivationAllowed(Type svrType);
+        public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(string typeName, string assemblyName);
+        public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType);
+        public static WellKnownClientTypeEntry IsWellKnownClientType(string typeName, string assemblyName);
+        public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType);
+        public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry);
+        public static void RegisterActivatedClientType(Type type, string appUrl);
+        public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry);
+        public static void RegisterActivatedServiceType(Type type);
+        public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry);
+        public static void RegisterWellKnownClientType(Type type, string objectUrl);
+        public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry);
+        public static void RegisterWellKnownServiceType(Type type, string objectUri, WellKnownObjectMode mode);
+    }
+    public class RemotingException : SystemException {
+        public RemotingException();
+        protected RemotingException(SerializationInfo info, StreamingContext context);
+        public RemotingException(string message);
+        public RemotingException(string message, Exception InnerException);
+    }
+    public static class RemotingServices {
+        public static object Connect(Type classToProxy, string url);
+        public static object Connect(Type classToProxy, string url, object data);
+        public static bool Disconnect(MarshalByRefObject obj);
+        public static IMethodReturnMessage ExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg);
+        public static IMessageSink GetEnvoyChainForProxy(MarshalByRefObject obj);
+        public static object GetLifetimeService(MarshalByRefObject obj);
+        public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg);
+        public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context);
+        public static string GetObjectUri(MarshalByRefObject obj);
+        public static ObjRef GetObjRefForProxy(MarshalByRefObject obj);
+        public static RealProxy GetRealProxy(object proxy);
+        public static Type GetServerTypeForUri(string URI);
+        public static string GetSessionIdForMethodMessage(IMethodMessage msg);
+        public static bool IsMethodOverloaded(IMethodMessage msg);
+        public static bool IsObjectOutOfAppDomain(object tp);
+        public static bool IsObjectOutOfContext(object tp);
+        public static bool IsOneWay(MethodBase method);
+        public static bool IsTransparentProxy(object proxy);
+        public static void LogRemotingStage(int stage);
+        public static ObjRef Marshal(MarshalByRefObject Obj);
+        public static ObjRef Marshal(MarshalByRefObject Obj, string URI);
+        public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType);
+        public static void SetObjectUriForMarshal(MarshalByRefObject obj, string uri);
+        public static object Unmarshal(ObjRef objectRef);
+        public static object Unmarshal(ObjRef objectRef, bool fRefine);
+    }
+    public class RemotingTimeoutException : RemotingException {
+        public RemotingTimeoutException();
+        public RemotingTimeoutException(string message);
+        public RemotingTimeoutException(string message, Exception InnerException);
+    }
+    public class ServerException : SystemException {
+        public ServerException();
+        public ServerException(string message);
+        public ServerException(string message, Exception InnerException);
+    }
+    public class SoapServices {
+        public static string XmlNsForClrType { get; }
+        public static string XmlNsForClrTypeWithAssembly { get; }
+        public static string XmlNsForClrTypeWithNs { get; }
+        public static string XmlNsForClrTypeWithNsAndAssembly { get; }
+        public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName);
+        public static bool DecodeXmlNamespaceForClrTypeNamespace(string inNamespace, out string typeNamespace, out string assemblyName);
+        public static void GetInteropFieldTypeAndNameFromXmlAttribute(Type containingType, string xmlAttribute, string xmlNamespace, out Type type, out string name);
+        public static void GetInteropFieldTypeAndNameFromXmlElement(Type containingType, string xmlElement, string xmlNamespace, out Type type, out string name);
+        public static Type GetInteropTypeFromXmlElement(string xmlElement, string xmlNamespace);
+        public static Type GetInteropTypeFromXmlType(string xmlType, string xmlTypeNamespace);
+        public static string GetSoapActionFromMethodBase(MethodBase mb);
+        public static bool GetTypeAndMethodNameFromSoapAction(string soapAction, out string typeName, out string methodName);
+        public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace);
+        public static string GetXmlNamespaceForMethodCall(MethodBase mb);
+        public static string GetXmlNamespaceForMethodResponse(MethodBase mb);
+        public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace);
+        public static bool IsClrTypeNamespace(string namespaceString);
+        public static bool IsSoapActionValidForMethodBase(string soapAction, MethodBase mb);
+        public static void PreLoad(Assembly assembly);
+        public static void PreLoad(Type type);
+        public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type);
+        public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type);
+        public static void RegisterSoapActionForMethodBase(MethodBase mb);
+        public static void RegisterSoapActionForMethodBase(MethodBase mb, string soapAction);
+    }
+    public class TypeEntry {
+        protected TypeEntry();
+        public string AssemblyName { get; set; }
+        public string TypeName { get; set; }
+    }
+    public class WellKnownClientTypeEntry : TypeEntry {
+        public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl);
+        public WellKnownClientTypeEntry(Type type, string objectUrl);
+        public string ApplicationUrl { get; set; }
+        public Type ObjectType { get; }
+        public string ObjectUrl { get; }
+        public override string ToString();
+    }
+    public enum WellKnownObjectMode {
+        SingleCall = 2,
+        Singleton = 1,
+    }
+    public class WellKnownServiceTypeEntry : TypeEntry {
+        public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode);
+        public WellKnownServiceTypeEntry(Type type, string objectUri, WellKnownObjectMode mode);
+        public IContextAttribute[] ContextAttributes { get; set; }
+        public WellKnownObjectMode Mode { get; }
+        public Type ObjectType { get; }
+        public string ObjectUri { get; }
+        public override string ToString();
+    }
+}
```

