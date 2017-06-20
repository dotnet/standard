# System.Runtime.Remoting.Lifetime

``` diff
+namespace System.Runtime.Remoting.Lifetime {
+    public class ClientSponsor : MarshalByRefObject, ISponsor {
+        public ClientSponsor();
+        public ClientSponsor(TimeSpan renewalTime);
+        public TimeSpan RenewalTime { get; set; }
+        public void Close();
+        ~ClientSponsor();
+        public override object InitializeLifetimeService();
+        public bool Register(MarshalByRefObject obj);
+        public TimeSpan Renewal(ILease lease);
+        public void Unregister(MarshalByRefObject obj);
+    }
+    public interface ILease {
+        TimeSpan CurrentLeaseTime { get; }
+        LeaseState CurrentState { get; }
+        TimeSpan InitialLeaseTime { get; set; }
+        TimeSpan RenewOnCallTime { get; set; }
+        TimeSpan SponsorshipTimeout { get; set; }
+        void Register(ISponsor obj);
+        void Register(ISponsor obj, TimeSpan renewalTime);
+        TimeSpan Renew(TimeSpan renewalTime);
+        void Unregister(ISponsor obj);
+    }
+    public interface ISponsor {
+        TimeSpan Renewal(ILease lease);
+    }
+    public enum LeaseState {
+        Active = 2,
+        Expired = 4,
+        Initial = 1,
+        Null = 0,
+        Renewing = 3,
+    }
+    public sealed class LifetimeServices {
+        public LifetimeServices();
+        public static TimeSpan LeaseManagerPollTime { get; set; }
+        public static TimeSpan LeaseTime { get; set; }
+        public static TimeSpan RenewOnCallTime { get; set; }
+        public static TimeSpan SponsorshipTimeout { get; set; }
+    }
+}
```

