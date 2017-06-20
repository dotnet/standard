# System.Collections.Concurrent

``` diff
 namespace System.Collections.Concurrent {
     public class ConcurrentBag<T> : ICollection, IEnumerable, IEnumerable<T>, IProducerConsumerCollection<T>, IReadOnlyCollection<T> {
+        public void Clear();
     }
     public class ConcurrentDictionary<TKey, TValue> : ICollection, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, IDictionary<TKey, TValue>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue> {
+        public TValue AddOrUpdate<TArg>(TKey key, Func<TKey, TArg, TValue> addValueFactory, Func<TKey, TValue, TArg, TValue> updateValueFactory, TArg factoryArgument);
+        public TValue GetOrAdd<TArg>(TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument);
     }
     public class ConcurrentQueue<T> : ICollection, IEnumerable, IEnumerable<T>, IProducerConsumerCollection<T>, IReadOnlyCollection<T> {
+        public void Clear();
     }
 }
```

