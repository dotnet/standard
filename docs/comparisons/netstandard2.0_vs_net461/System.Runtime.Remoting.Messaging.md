# System.Runtime.Remoting.Messaging

``` diff
+namespace System.Runtime.Remoting.Messaging {
+    public class AsyncResult : IAsyncResult, IMessageSink {
+        public virtual object AsyncDelegate { get; }
+        public virtual object AsyncState { get; }
+        public virtual WaitHandle AsyncWaitHandle { get; }
+        public virtual bool CompletedSynchronously { get; }
+        public bool EndInvokeCalled { get; set; }
+        public virtual bool IsCompleted { get; }
+        public IMessageSink NextSink { get; }
+        public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
+        public virtual IMessage GetReplyMessage();
+        public virtual void SetMessageCtrl(IMessageCtrl mc);
+        public virtual IMessage SyncProcessMessage(IMessage msg);
+    }
+    public sealed class CallContext {
+        public static object HostContext { get; set; }
+        public static void FreeNamedDataSlot(string name);
+        public static object GetData(string name);
+        public static Header[] GetHeaders();
+        public static object LogicalGetData(string name);
+        public static void LogicalSetData(string name, object data);
+        public static void SetData(string name, object data);
+        public static void SetHeaders(Header[] headers);
+    }
+    public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage {
+        public ConstructionCall(Header[] headers);
+        public ConstructionCall(IMessage m);
+        public Type ActivationType { get; }
+        public string ActivationTypeName { get; }
+        public IActivator Activator { get; set; }
+        public object[] CallSiteActivationAttributes { get; }
+        public IList ContextProperties { get; }
+        public override IDictionary Properties { get; }
+    }
+    public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMessage, IMethodMessage, IMethodReturnMessage {
+        public ConstructionResponse(Header[] h, IMethodCallMessage mcm);
+        public override IDictionary Properties { get; }
+    }
+    public class Header {
+        public bool MustUnderstand;
+        public object Value;
+        public string HeaderNamespace;
+        public string Name;
+        public Header(string _Name, object _Value);
+        public Header(string _Name, object _Value, bool _MustUnderstand);
+        public Header(string _Name, object _Value, bool _MustUnderstand, string _HeaderNamespace);
+    }
+    public delegate object HeaderHandler(Header[] headers);
+    public interface ILogicalThreadAffinative
+    public interface IMessage {
+        IDictionary Properties { get; }
+    }
+    public interface IMessageCtrl {
+        void Cancel(int msToCancel);
+    }
+    public interface IMessageSink {
+        IMessageSink NextSink { get; }
+        IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
+        IMessage SyncProcessMessage(IMessage msg);
+    }
+    public interface IMethodCallMessage : IMessage, IMethodMessage {
+        int InArgCount { get; }
+        object[] InArgs { get; }
+        object GetInArg(int argNum);
+        string GetInArgName(int index);
+    }
+    public interface IMethodMessage : IMessage {
+        int ArgCount { get; }
+        object[] Args { get; }
+        bool HasVarArgs { get; }
+        LogicalCallContext LogicalCallContext { get; }
+        MethodBase MethodBase { get; }
+        string MethodName { get; }
+        object MethodSignature { get; }
+        string TypeName { get; }
+        string Uri { get; }
+        object GetArg(int argNum);
+        string GetArgName(int index);
+    }
+    public interface IMethodReturnMessage : IMessage, IMethodMessage {
+        Exception Exception { get; }
+        int OutArgCount { get; }
+        object[] OutArgs { get; }
+        object ReturnValue { get; }
+        object GetOutArg(int argNum);
+        string GetOutArgName(int index);
+    }
+    public class InternalMessageWrapper {
+        protected IMessage WrappedMessage;
+        public InternalMessageWrapper(IMessage msg);
+    }
+    public interface IRemotingFormatter : IFormatter {
+        object Deserialize(Stream serializationStream, HeaderHandler handler);
+        void Serialize(Stream serializationStream, object graph, Header[] headers);
+    }
+    public sealed class LogicalCallContext : ICloneable, ISerializable {
+        public bool HasInfo { get; }
+        public object Clone();
+        public void FreeNamedDataSlot(string name);
+        public object GetData(string name);
+        public void GetObjectData(SerializationInfo info, StreamingContext context);
+        public void SetData(string name, object data);
+    }
+    public delegate bool MessageSurrogateFilter(string key, object value);
+    public class MethodCall : IInternalMessage, IMessage, IMethodCallMessage, IMethodMessage, ISerializable, ISerializationRootObject {
+        protected IDictionary ExternalProperties;
+        protected IDictionary InternalProperties;
+        public MethodCall(Header[] h1);
+        public MethodCall(IMessage msg);
+        public int ArgCount { get; }
+        public object[] Args { get; }
+        public bool HasVarArgs { get; }
+        public int InArgCount { get; }
+        public object[] InArgs { get; }
+        public LogicalCallContext LogicalCallContext { get; }
+        public MethodBase MethodBase { get; }
+        public string MethodName { get; }
+        public object MethodSignature { get; }
+        public virtual IDictionary Properties { get; }
+        public string TypeName { get; }
+        public string Uri { get; set; }
+        public object GetArg(int argNum);
+        public string GetArgName(int index);
+        public object GetInArg(int argNum);
+        public string GetInArgName(int index);
+        public void GetObjectData(SerializationInfo info, StreamingContext context);
+        public virtual object HeaderHandler(Header[] h);
+        public virtual void Init();
+        public void ResolveMethod();
+        public void RootSetObjectData(SerializationInfo info, StreamingContext ctx);
+    }
+    public class MethodCallMessageWrapper : InternalMessageWrapper, IMessage, IMethodCallMessage, IMethodMessage {
+        public MethodCallMessageWrapper(IMethodCallMessage msg);
+        public virtual int ArgCount { get; }
+        public virtual object[] Args { get; set; }
+        public virtual bool HasVarArgs { get; }
+        public virtual int InArgCount { get; }
+        public virtual object[] InArgs { get; }
+        public virtual LogicalCallContext LogicalCallContext { get; }
+        public virtual MethodBase MethodBase { get; }
+        public virtual string MethodName { get; }
+        public virtual object MethodSignature { get; }
+        public virtual IDictionary Properties { get; }
+        public virtual string TypeName { get; }
+        public virtual string Uri { get; set; }
+        public virtual object GetArg(int argNum);
+        public virtual string GetArgName(int index);
+        public virtual object GetInArg(int argNum);
+        public virtual string GetInArgName(int index);
+    }
+    public class MethodResponse : IInternalMessage, IMessage, IMethodMessage, IMethodReturnMessage, ISerializable, ISerializationRootObject {
+        protected IDictionary ExternalProperties;
+        protected IDictionary InternalProperties;
+        public MethodResponse(Header[] h1, IMethodCallMessage mcm);
+        public int ArgCount { get; }
+        public object[] Args { get; }
+        public Exception Exception { get; }
+        public bool HasVarArgs { get; }
+        public LogicalCallContext LogicalCallContext { get; }
+        public MethodBase MethodBase { get; }
+        public string MethodName { get; }
+        public object MethodSignature { get; }
+        public int OutArgCount { get; }
+        public object[] OutArgs { get; }
+        public virtual IDictionary Properties { get; }
+        public object ReturnValue { get; }
+        public string TypeName { get; }
+        public string Uri { get; set; }
+        public object GetArg(int argNum);
+        public string GetArgName(int index);
+        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        public object GetOutArg(int argNum);
+        public string GetOutArgName(int index);
+        public virtual object HeaderHandler(Header[] h);
+        public void RootSetObjectData(SerializationInfo info, StreamingContext ctx);
+    }
+    public class MethodReturnMessageWrapper : InternalMessageWrapper, IMessage, IMethodMessage, IMethodReturnMessage {
+        public MethodReturnMessageWrapper(IMethodReturnMessage msg);
+        public virtual int ArgCount { get; }
+        public virtual object[] Args { get; set; }
+        public virtual Exception Exception { get; set; }
+        public virtual bool HasVarArgs { get; }
+        public virtual LogicalCallContext LogicalCallContext { get; }
+        public virtual MethodBase MethodBase { get; }
+        public virtual string MethodName { get; }
+        public virtual object MethodSignature { get; }
+        public virtual int OutArgCount { get; }
+        public virtual object[] OutArgs { get; }
+        public virtual IDictionary Properties { get; }
+        public virtual object ReturnValue { get; set; }
+        public virtual string TypeName { get; }
+        public string Uri { get; set; }
+        public virtual object GetArg(int argNum);
+        public virtual string GetArgName(int index);
+        public virtual object GetOutArg(int argNum);
+        public virtual string GetOutArgName(int index);
+    }
+    public class OneWayAttribute : Attribute {
+        public OneWayAttribute();
+    }
+    public class RemotingSurrogateSelector : ISurrogateSelector {
+        public RemotingSurrogateSelector();
+        public MessageSurrogateFilter Filter { get; set; }
+        public virtual void ChainSelector(ISurrogateSelector selector);
+        public virtual ISurrogateSelector GetNextSelector();
+        public object GetRootObject();
+        public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout);
+        public void SetRootObject(object obj);
+        public virtual void UseSoapFormat();
+    }
+    public class ReturnMessage : IMessage, IMethodMessage, IMethodReturnMessage {
+        public ReturnMessage(Exception e, IMethodCallMessage mcm);
+        public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm);
+        public int ArgCount { get; }
+        public object[] Args { get; }
+        public Exception Exception { get; }
+        public bool HasVarArgs { get; }
+        public LogicalCallContext LogicalCallContext { get; }
+        public MethodBase MethodBase { get; }
+        public string MethodName { get; }
+        public object MethodSignature { get; }
+        public int OutArgCount { get; }
+        public object[] OutArgs { get; }
+        public virtual IDictionary Properties { get; }
+        public virtual object ReturnValue { get; }
+        public string TypeName { get; }
+        public string Uri { get; set; }
+        public object GetArg(int argNum);
+        public string GetArgName(int index);
+        public object GetOutArg(int argNum);
+        public string GetOutArgName(int index);
+    }
+}
```

