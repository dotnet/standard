# System.Runtime.Remoting.Proxies

``` diff
+namespace System.Runtime.Remoting.Proxies {
+    public class ProxyAttribute : Attribute, IContextAttribute {
+        public ProxyAttribute();
+        public virtual MarshalByRefObject CreateInstance(Type serverType);
+        public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext);
+        public void GetPropertiesForNewContext(IConstructionCallMessage msg);
+        public bool IsContextOK(Context ctx, IConstructionCallMessage msg);
+    }
+    public abstract class RealProxy {
+        protected RealProxy();
+        protected RealProxy(Type classToProxy);
+        protected RealProxy(Type classToProxy, IntPtr stub, object stubData);
+        protected void AttachServer(MarshalByRefObject s);
+        public virtual ObjRef CreateObjRef(Type requestedType);
+        protected MarshalByRefObject DetachServer();
+        public virtual IntPtr GetCOMIUnknown(bool fIsMarshalled);
+        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        public Type GetProxiedType();
+        public static object GetStubData(RealProxy rp);
+        public virtual object GetTransparentProxy();
+        protected MarshalByRefObject GetUnwrappedServer();
+        public IConstructionReturnMessage InitializeServerObject(IConstructionCallMessage ctorMsg);
+        public abstract IMessage Invoke(IMessage msg);
+        public virtual void SetCOMIUnknown(IntPtr i);
+        public static void SetStubData(RealProxy rp, object stubData);
+        public virtual IntPtr SupportsInterface(ref Guid iid);
+    }
+}
```

