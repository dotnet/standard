# System.Linq

``` diff
 namespace System.Linq {
     public static class Enumerable {
+        public static IEnumerable<TSource> SkipLast<TSource>(this IEnumerable<TSource> source, int count);
+        public static IEnumerable<TSource> TakeLast<TSource>(this IEnumerable<TSource> source, int count);
+        public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source);
+        public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer);
     }
+    public static class ImmutableArrayExtensions {
+        public static T Aggregate<T>(this ImmutableArray<T> immutableArray, Func<T, T, T> func);
+        public static TAccumulate Aggregate<TAccumulate, T>(this ImmutableArray<T> immutableArray, TAccumulate seed, Func<TAccumulate, T, TAccumulate> func);
+        public static TResult Aggregate<TAccumulate, TResult, T>(this ImmutableArray<T> immutableArray, TAccumulate seed, Func<TAccumulate, T, TAccumulate> func, Func<TAccumulate, TResult> resultSelector);
+        public static bool All<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+        public static bool Any<T>(this ImmutableArray<T>.Builder builder);
+        public static bool Any<T>(this ImmutableArray<T> immutableArray);
+        public static bool Any<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+        public static T ElementAt<T>(this ImmutableArray<T> immutableArray, int index);
+        public static T ElementAtOrDefault<T>(this ImmutableArray<T> immutableArray, int index);
+        public static T First<T>(this ImmutableArray<T>.Builder builder);
+        public static T First<T>(this ImmutableArray<T> immutableArray);
+        public static T First<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+        public static T FirstOrDefault<T>(this ImmutableArray<T>.Builder builder);
+        public static T FirstOrDefault<T>(this ImmutableArray<T> immutableArray);
+        public static T FirstOrDefault<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+        public static T Last<T>(this ImmutableArray<T>.Builder builder);
+        public static T Last<T>(this ImmutableArray<T> immutableArray);
+        public static T Last<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+        public static T LastOrDefault<T>(this ImmutableArray<T>.Builder builder);
+        public static T LastOrDefault<T>(this ImmutableArray<T> immutableArray);
+        public static T LastOrDefault<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+        public static IEnumerable<TResult> Select<T, TResult>(this ImmutableArray<T> immutableArray, Func<T, TResult> selector);
+        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this ImmutableArray<TSource> immutableArray, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);
+        public static bool SequenceEqual<TDerived, TBase>(this ImmutableArray<TBase> immutableArray, IEnumerable<TDerived> items, IEqualityComparer<TBase> comparer=null) where TDerived : TBase;
+        public static bool SequenceEqual<TDerived, TBase>(this ImmutableArray<TBase> immutableArray, ImmutableArray<TDerived> items, IEqualityComparer<TBase> comparer=null) where TDerived : TBase;
+        public static bool SequenceEqual<TDerived, TBase>(this ImmutableArray<TBase> immutableArray, ImmutableArray<TDerived> items, Func<TBase, TBase, bool> predicate) where TDerived : TBase;
+        public static T Single<T>(this ImmutableArray<T> immutableArray);
+        public static T Single<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+        public static T SingleOrDefault<T>(this ImmutableArray<T> immutableArray);
+        public static T SingleOrDefault<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+        public static T[] ToArray<T>(this ImmutableArray<T> immutableArray);
+        public static Dictionary<TKey, T> ToDictionary<TKey, T>(this ImmutableArray<T> immutableArray, Func<T, TKey> keySelector);
+        public static Dictionary<TKey, T> ToDictionary<TKey, T>(this ImmutableArray<T> immutableArray, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer);
+        public static Dictionary<TKey, TElement> ToDictionary<TKey, TElement, T>(this ImmutableArray<T> immutableArray, Func<T, TKey> keySelector, Func<T, TElement> elementSelector);
+        public static Dictionary<TKey, TElement> ToDictionary<TKey, TElement, T>(this ImmutableArray<T> immutableArray, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer);
+        public static IEnumerable<T> Where<T>(this ImmutableArray<T> immutableArray, Func<T, bool> predicate);
+    }
-    public interface IOrderedEnumerable<TElement> : IEnumerable, IEnumerable<TElement>
+    public interface IOrderedEnumerable<out TElement> : IEnumerable, IEnumerable<TElement>
     public static class Queryable {
+        public static IQueryable<TSource> Append<TSource>(this IQueryable<TSource> source, TSource element);
+        public static IQueryable<TSource> Prepend<TSource>(this IQueryable<TSource> source, TSource element);
+        public static IQueryable<TSource> SkipLast<TSource>(this IQueryable<TSource> source, int count);
+        public static IQueryable<TSource> TakeLast<TSource>(this IQueryable<TSource> source, int count);
     }
 }
```

