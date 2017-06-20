# System.Collections.ObjectModel

``` diff
 namespace System.Collections.ObjectModel {
     public abstract class KeyedCollection<TKey, TItem> : Collection<TItem> {
+        public bool TryGetValue(TKey key, out TItem item);
     }
 }
```

