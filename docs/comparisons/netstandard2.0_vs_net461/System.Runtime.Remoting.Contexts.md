# System.Runtime.Remoting.Contexts

``` diff
+namespace System.Runtime.Remoting.Contexts {
+    public class Context {
+        public Context();
+        public virtual int ContextID { get; }
+        public virtual IContextProperty[] ContextProperties { get; }
+        public static Context DefaultContext { get; }
+        public static LocalDataStoreSlot AllocateDataSlot();
+        public static LocalDataStoreSlot AllocateNamedDataSlot(string name);
+        public void DoCallBack(CrossContextDelegate deleg);
+        ~Context();
+        public static void FreeNamedDataSlot(string name);
+        public virtual void Freeze();
+        public static object GetData(LocalDataStoreSlot slot);
+        public static LocalDataStoreSlot GetNamedDataSlot(string name);
+        public virtual IContextProperty GetProperty(string name);
+        public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx);
+        public static void SetData(LocalDataStoreSlot slot, object data);
+        public virtual void SetProperty(IContextProperty prop);
+        public override string ToString();
+        public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx);
+    }
+    public class ContextAttribute : Attribute, IContextAttribute, IContextProperty {
+        protected string AttributeName;
+        public ContextAttribute(string name);
+        public virtual string Name { get; }
+        public override bool Equals(object o);
+        public virtual void Freeze(Context newContext);
+        public override int GetHashCode();
+        public virtual void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg);
+        public virtual bool IsContextOK(Context ctx, IConstructionCallMessage ctorMsg);
+        public virtual bool IsNewContextOK(Context newCtx);
+    }
+    public class ContextProperty {
+        public virtual string Name { get; }
+        public virtual object Property { get; }
+    }
+    public delegate void CrossContextDelegate();
+    public interface IContextAttribute {
+        void GetPropertiesForNewContext(IConstructionCallMessage msg);
+        bool IsContextOK(Context ctx, IConstructionCallMessage msg);
+    }
+    public interface IContextProperty {
+        string Name { get; }
+        void Freeze(Context newContext);
+        bool IsNewContextOK(Context newCtx);
+    }
+    public interface IContextPropertyActivator {
+        void CollectFromClientContext(IConstructionCallMessage msg);
+        void CollectFromServerContext(IConstructionReturnMessage msg);
+        bool DeliverClientContextToServerContext(IConstructionCallMessage msg);
+        bool DeliverServerContextToClientContext(IConstructionReturnMessage msg);
+        bool IsOKToActivate(IConstructionCallMessage msg);
+    }
+    public interface IContributeClientContextSink {
+        IMessageSink GetClientContextSink(IMessageSink nextSink);
+    }
+    public interface IContributeDynamicSink {
+        IDynamicMessageSink GetDynamicSink();
+    }
+    public interface IContributeEnvoySink {
+        IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);
+    }
+    public interface IContributeObjectSink {
+        IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
+    }
+    public interface IContributeServerContextSink {
+        IMessageSink GetServerContextSink(IMessageSink nextSink);
+    }
+    public interface IDynamicMessageSink {
+        void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);
+        void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
+    }
+    public interface IDynamicProperty {
+        string Name { get; }
+    }
+    public class SynchronizationAttribute : ContextAttribute, IContributeClientContextSink, IContributeServerContextSink {
+        public const int NOT_SUPPORTED = 1;
+        public const int REQUIRED = 4;
+        public const int REQUIRES_NEW = 8;
+        public const int SUPPORTED = 2;
+        public SynchronizationAttribute();
+        public SynchronizationAttribute(bool reEntrant);
+        public SynchronizationAttribute(int flag);
+        public SynchronizationAttribute(int flag, bool reEntrant);
+        public virtual bool IsReEntrant { get; }
+        public virtual bool Locked { get; set; }
+        public virtual IMessageSink GetClientContextSink(IMessageSink nextSink);
+        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg);
+        public virtual IMessageSink GetServerContextSink(IMessageSink nextSink);
+        public override bool IsContextOK(Context ctx, IConstructionCallMessage msg);
+    }
+}
```

