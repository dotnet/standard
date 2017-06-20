# System.Collections.Generic

``` diff
 namespace System.Collections.Generic {
+    public static class CollectionExtensions {
+        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key);
+        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue);
+        public static bool Remove<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, out TValue value);
+        public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value);
+    }
     public class Dictionary<TKey, TValue> : ICollection, ICollection<KeyValuePair<TKey, TValue>>, IDeserializationCallback, IDictionary, IDictionary<TKey, TValue>, IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue>, ISerializable {
+        public Dictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection);
+        public Dictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer);
+        public bool Remove(TKey key, out TValue value);
+        public bool TryAdd(TKey key, TValue value);
     }
     public class HashSet<T> : ICollection<T>, IDeserializationCallback, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>, ISerializable, ISet<T> {
+        public HashSet(int capacity);
+        public HashSet(int capacity, IEqualityComparer<T> comparer);
+        public bool TryGetValue(T equalValue, out T actualValue);
     }
+    public static class KeyValuePair {
+        public static KeyValuePair<TKey, TValue> Create<TKey, TValue>(TKey key, TValue value);
+    }
     [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
     public struct KeyValuePair<TKey, TValue> {
+        public void Deconstruct(out TKey key, out TValue value);
     }
     public class Queue<T> : ICollection, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T> {
+        public bool TryDequeue(out T result);
+        public bool TryPeek(out T result);
     }
     public class SortedSet<T> : ICollection, ICollection<T>, IDeserializationCallback, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>, ISerializable, ISet<T> {
+        public bool TryGetValue(T equalValue, out T actualValue);
     }
     public class Stack<T> : ICollection, IEnumerable, IEnumerable<T>, IReadOnlyCollection<T> {
+        public bool TryPeek(out T result);
+        public bool TryPop(out T result);
     }
 }
```

