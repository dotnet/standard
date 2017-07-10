# System.Collections.Specialized

``` diff
 namespace System.Collections.Specialized {
+    public class CollectionChangedEventManager : WeakEventManager {
+        public static void AddHandler(INotifyCollectionChanged source, EventHandler<NotifyCollectionChangedEventArgs> handler);
+        public static void AddListener(INotifyCollectionChanged source, IWeakEventListener listener);
+        protected override WeakEventManager.ListenerList NewListenerList();
+        public static void RemoveHandler(INotifyCollectionChanged source, EventHandler<NotifyCollectionChangedEventArgs> handler);
+        public static void RemoveListener(INotifyCollectionChanged source, IWeakEventListener listener);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
 }
```

