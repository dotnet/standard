# System.Runtime.Remoting.Activation

``` diff
+namespace System.Runtime.Remoting.Activation {
+    public enum ActivatorLevel {
+        AppDomain = 12,
+        Construction = 4,
+        Context = 8,
+        Machine = 20,
+        Process = 16,
+    }
+    public interface IActivator {
+        ActivatorLevel Level { get; }
+        IActivator NextActivator { get; set; }
+        IConstructionReturnMessage Activate(IConstructionCallMessage msg);
+    }
+    public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage {
+        Type ActivationType { get; }
+        string ActivationTypeName { get; }
+        IActivator Activator { get; set; }
+        object[] CallSiteActivationAttributes { get; }
+        IList ContextProperties { get; }
+    }
+    public interface IConstructionReturnMessage : IMessage, IMethodMessage, IMethodReturnMessage
+    public sealed class UrlAttribute : ContextAttribute {
+        public UrlAttribute(string callsiteURL);
+        public string UrlValue { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg);
+        public override bool IsContextOK(Context ctx, IConstructionCallMessage msg);
+    }
+}
```

