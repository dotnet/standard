# System.ServiceModel.Persistence

``` diff
+namespace System.ServiceModel.Persistence {
+    public class InstanceLockException : PersistenceException {
+        public InstanceLockException();
+        public InstanceLockException(Guid id);
+        public InstanceLockException(Guid id, Exception innerException);
+        public InstanceLockException(Guid id, string message);
+        public InstanceLockException(Guid id, string message, Exception innerException);
+        protected InstanceLockException(SerializationInfo info, StreamingContext context);
+        public InstanceLockException(string message);
+        public InstanceLockException(string message, Exception innerException);
+        public Guid InstanceId { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class InstanceNotFoundException : PersistenceException {
+        public InstanceNotFoundException();
+        public InstanceNotFoundException(Guid id);
+        public InstanceNotFoundException(Guid id, Exception innerException);
+        public InstanceNotFoundException(Guid id, string message);
+        public InstanceNotFoundException(Guid id, string message, Exception innerException);
+        protected InstanceNotFoundException(SerializationInfo info, StreamingContext context);
+        public InstanceNotFoundException(string message);
+        public InstanceNotFoundException(string message, Exception innerException);
+        public Guid InstanceId { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public abstract class LockingPersistenceProvider : PersistenceProvider {
+        protected LockingPersistenceProvider(Guid id);
+        public override IAsyncResult BeginCreate(object instance, TimeSpan timeout, AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginCreate(object instance, TimeSpan timeout, bool unlockInstance, AsyncCallback callback, object state);
+        public override IAsyncResult BeginLoad(TimeSpan timeout, AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginLoad(TimeSpan timeout, bool lockInstance, AsyncCallback callback, object state);
+        public override IAsyncResult BeginLoadIfChanged(TimeSpan timeout, object instanceToken, AsyncCallback callback, object state);
+        public virtual IAsyncResult BeginLoadIfChanged(TimeSpan timeout, object instanceToken, bool lockInstance, AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginUnlock(TimeSpan timeout, AsyncCallback callback, object state);
+        public override IAsyncResult BeginUpdate(object instance, TimeSpan timeout, AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginUpdate(object instance, TimeSpan timeout, bool unlockInstance, AsyncCallback callback, object state);
+        public override object Create(object instance, TimeSpan timeout);
+        public abstract object Create(object instance, TimeSpan timeout, bool unlockInstance);
+        public abstract void EndUnlock(IAsyncResult result);
+        public override object Load(TimeSpan timeout);
+        public abstract object Load(TimeSpan timeout, bool lockInstance);
+        public virtual bool LoadIfChanged(TimeSpan timeout, object instanceToken, bool lockInstance, out object instance);
+        public override bool LoadIfChanged(TimeSpan timeout, object instanceToken, out object instance);
+        public abstract void Unlock(TimeSpan timeout);
+        public override object Update(object instance, TimeSpan timeout);
+        public abstract object Update(object instance, TimeSpan timeout, bool unlockInstance);
+    }
+    public class PersistenceException : CommunicationException {
+        public PersistenceException();
+        protected PersistenceException(SerializationInfo info, StreamingContext context);
+        public PersistenceException(string message);
+        public PersistenceException(string message, Exception innerException);
+    }
+    public abstract class PersistenceProvider : CommunicationObject {
+        protected PersistenceProvider(Guid id);
+        public Guid Id { get; }
+        public abstract IAsyncResult BeginCreate(object instance, TimeSpan timeout, AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginDelete(object instance, TimeSpan timeout, AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginLoad(TimeSpan timeout, AsyncCallback callback, object state);
+        public virtual IAsyncResult BeginLoadIfChanged(TimeSpan timeout, object instanceToken, AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginUpdate(object instance, TimeSpan timeout, AsyncCallback callback, object state);
+        public abstract object Create(object instance, TimeSpan timeout);
+        public abstract void Delete(object instance, TimeSpan timeout);
+        public abstract object EndCreate(IAsyncResult result);
+        public abstract void EndDelete(IAsyncResult result);
+        public abstract object EndLoad(IAsyncResult result);
+        public virtual bool EndLoadIfChanged(IAsyncResult result, out object instance);
+        public abstract object EndUpdate(IAsyncResult result);
+        public abstract object Load(TimeSpan timeout);
+        public virtual bool LoadIfChanged(TimeSpan timeout, object instanceToken, out object instance);
+        public abstract object Update(object instance, TimeSpan timeout);
+    }
+    public abstract class PersistenceProviderFactory : CommunicationObject {
+        protected PersistenceProviderFactory();
+        public abstract PersistenceProvider CreateProvider(Guid id);
+    }
+    public class SqlPersistenceProviderFactory : PersistenceProviderFactory {
+        public SqlPersistenceProviderFactory(NameValueCollection parameters);
+        public SqlPersistenceProviderFactory(string connectionString);
+        public SqlPersistenceProviderFactory(string connectionString, bool serializeAsText);
+        public SqlPersistenceProviderFactory(string connectionString, bool serializeAsText, TimeSpan lockTimeout);
+        public string ConnectionString { get; set; }
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        public TimeSpan LockTimeout { get; set; }
+        public bool SerializeAsText { get; set; }
+        public override PersistenceProvider CreateProvider(Guid id);
+        protected override void OnAbort();
+        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override void OnClose(TimeSpan timeout);
+        protected override void OnEndClose(IAsyncResult result);
+        protected override void OnEndOpen(IAsyncResult result);
+        protected override void OnOpen(TimeSpan timeout);
+    }
+}
```

