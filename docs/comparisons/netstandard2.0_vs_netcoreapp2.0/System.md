# System

``` diff
 namespace System {
     public class AggregateException : Exception {
+        public override string Message { get; }
     }
-    public sealed class AppDomain : MarshalByRefObject {
+    public class AppDomain : MarshalByRefObject {
-        public new Type GetType();

-        public override object InitializeLifetimeService();

     }
+    public sealed class ApplicationIdentity : ISerializable {
+        public ApplicationIdentity(string applicationIdentityFullName);
+        public string CodeBase { get; }
+        public string FullName { get; }
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
     public abstract class Array : ICloneable, ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable {
+        public static void Fill<T>(T[] array, T value);
+        public static void Fill<T>(T[] array, T value, int startIndex, int count);
+        public static void Reverse<T>(T[] array);
+        public static void Reverse<T>(T[] array, int index, int length);
     }
     [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
     public struct ArraySegment<T> : ICollection<T>, IEnumerable, IEnumerable<T>, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T> {
+        public static ArraySegment<T> Empty { get; }
+        public T this[int index] { get; set; }
+        public void CopyTo(ArraySegment<T> destination);
+        public void CopyTo(T[] destination);
+        public void CopyTo(T[] destination, int destinationIndex);
+        public ArraySegment<T>.Enumerator GetEnumerator();
+        public static implicit operator ArraySegment<T> (T[] array);
+        public ArraySegment<T> Slice(int index);
+        public ArraySegment<T> Slice(int index, int count);
+        public T[] ToArray();
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T> {
+            public T Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public void Dispose();
+            public bool MoveNext();
+            void System.Collections.IEnumerator.Reset();
+        }
     }
     public static class BitConverter {
+        public static float Int32BitsToSingle(int value);
+        public static int SingleToInt32Bits(float value);
     }
     [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
     public struct DateTime : IComparable, IComparable<DateTime>, IConvertible, IEquatable<DateTime>, IFormattable, ISerializable {
+        int System.IComparable.CompareTo(object value);
+        TypeCode System.IConvertible.GetTypeCode();
     }
-    public class DuplicateWaitObjectException : ArgumentException
+    public class DuplicateWaitObjectException : ArgumentException, ISerializable
     public abstract class Enum : ValueType, IComparable, IConvertible, IFormattable {
+        public static TEnum Parse<TEnum>(string value) where TEnum : struct;
+        public static TEnum Parse<TEnum>(string value, bool ignoreCase) where TEnum : struct;
+        TypeCode System.IConvertible.GetTypeCode();
+        public static bool TryParse(Type enumType, string value, bool ignoreCase, out object result);
+        public static bool TryParse(Type enumType, string value, out object result);
     }
     public static class GC {
+        public static long GetAllocatedBytesForCurrentThread();
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct IntPtr : ISerializable {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct IntPtr : IEquatable<IntPtr>, ISerializable {
+        bool System.IEquatable<System.IntPtr>.Equals(IntPtr other);
     }
     public class Lazy<T> {
+        public Lazy(T value);
     }
     public sealed class LocalDataStoreSlot {
+        ~LocalDataStoreSlot();
     }
     public static class Math {
+        public static byte Clamp(byte value, byte min, byte max);
+        public static decimal Clamp(decimal value, decimal min, decimal max);
+        public static double Clamp(double value, double min, double max);
+        public static short Clamp(short value, short min, short max);
+        public static int Clamp(int value, int min, int max);
+        public static long Clamp(long value, long min, long max);
+        public static sbyte Clamp(sbyte value, sbyte min, sbyte max);
+        public static float Clamp(float value, float min, float max);
+        public static ushort Clamp(ushort value, ushort min, ushort max);
+        public static uint Clamp(uint value, uint min, uint max);
+        public static ulong Clamp(ulong value, ulong min, ulong max);
     }
+    public static class MathF {
+        public const float E = 2.71828175f;
+        public const float PI = 3.14159274f;
+        public static float Abs(float x);
+        public static float Acos(float x);
+        public static float Asin(float x);
+        public static float Atan(float x);
+        public static float Atan2(float y, float x);
+        public static float Ceiling(float x);
+        public static float Cos(float x);
+        public static float Cosh(float x);
+        public static float Exp(float x);
+        public static float Floor(float x);
+        public static float IEEERemainder(float x, float y);
+        public static float Log(float x);
+        public static float Log(float x, float y);
+        public static float Log10(float x);
+        public static float Max(float x, float y);
+        public static float Min(float x, float y);
+        public static float Pow(float x, float y);
+        public static float Round(float x);
+        public static float Round(float x, int digits);
+        public static float Round(float x, int digits, MidpointRounding mode);
+        public static float Round(float x, MidpointRounding mode);
+        public static int Sign(float x);
+        public static float Sin(float x);
+        public static float Sinh(float x);
+        public static float Sqrt(float x);
+        public static float Tan(float x);
+        public static float Tanh(float x);
+        public static float Truncate(float x);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ReadOnlySpan<T> {
+        public unsafe ReadOnlySpan(void* pointer, int length);
+        public ReadOnlySpan(T[] array);
+        public ReadOnlySpan(T[] array, int start);
+        public ReadOnlySpan(T[] array, int start, int length);
+        public static ReadOnlySpan<T> Empty { get; }
+        public bool IsEmpty { get; }
+        public int Length { get; }
+        public T this[int index] { get; }
+        public void CopyTo(Span<T> destination);
+        public static ReadOnlySpan<T> DangerousCreate(object obj, ref T objectData, int length);
+        public ref T DangerousGetPinnableReference();
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(ReadOnlySpan<T> left, ReadOnlySpan<T> right);
+        public static implicit operator ReadOnlySpan<T> (ArraySegment<T> arraySegment);
+        public static implicit operator ReadOnlySpan<T> (T[] array);
+        public static bool operator !=(ReadOnlySpan<T> left, ReadOnlySpan<T> right);
+        public ReadOnlySpan<T> Slice(int start);
+        public ReadOnlySpan<T> Slice(int start, int length);
+        public T[] ToArray();
+        public bool TryCopyTo(Span<T> destination);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Span<T> {
+        public unsafe Span(void* pointer, int length);
+        public Span(T[] array);
+        public Span(T[] array, int start);
+        public Span(T[] array, int start, int length);
+        public static Span<T> Empty { get; }
+        public bool IsEmpty { get; }
+        public int Length { get; }
+        public ref T this[int index] { get; }
+        public void Clear();
+        public void CopyTo(Span<T> destination);
+        public static Span<T> DangerousCreate(object obj, ref T objectData, int length);
+        public ref T DangerousGetPinnableReference();
+        public override bool Equals(object obj);
+        public void Fill(T value);
+        public override int GetHashCode();
+        public static bool operator ==(Span<T> left, Span<T> right);
+        public static implicit operator Span<T> (ArraySegment<T> arraySegment);
+        public static implicit operator ReadOnlySpan<T> (Span<T> span);
+        public static implicit operator Span<T> (T[] array);
+        public static bool operator !=(Span<T> left, Span<T> right);
+        public Span<T> Slice(int start);
+        public Span<T> Slice(int start, int length);
+        public T[] ToArray();
+        public bool TryCopyTo(Span<T> destination);
+    }
+    public static class SpanExtensions {
+        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> source) where T : struct;
+        public static Span<byte> AsBytes<T>(this Span<T> source) where T : struct;
+        public static ReadOnlySpan<T> AsReadOnlySpan<T>(this ArraySegment<T> arraySegment);
+        public static ReadOnlySpan<T> AsReadOnlySpan<T>(this T[] array);
+        public static ReadOnlySpan<char> AsSpan(this string text);
+        public static Span<T> AsSpan<T>(this ArraySegment<T> arraySegment);
+        public static Span<T> AsSpan<T>(this T[] array);
+        public static void CopyTo<T>(this T[] array, Span<T> destination);
+        public static int IndexOf(this ReadOnlySpan<byte> span, byte value);
+        public static int IndexOf(this ReadOnlySpan<byte> span, ReadOnlySpan<byte> value);
+        public static int IndexOf(this Span<byte> span, byte value);
+        public static int IndexOf(this Span<byte> span, ReadOnlySpan<byte> value);
+        public static int IndexOf<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value) where T : struct, IEquatable<T>;
+        public static int IndexOf<T>(this ReadOnlySpan<T> span, T value) where T : struct, IEquatable<T>;
+        public static int IndexOf<T>(this Span<T> span, ReadOnlySpan<T> value) where T : struct, IEquatable<T>;
+        public static int IndexOf<T>(this Span<T> span, T value) where T : struct, IEquatable<T>;
+        public static int IndexOfAny(this ReadOnlySpan<byte> span, byte value0, byte value1);
+        public static int IndexOfAny(this ReadOnlySpan<byte> span, byte value0, byte value1, byte value2);
+        public static int IndexOfAny(this ReadOnlySpan<byte> span, ReadOnlySpan<byte> values);
+        public static int IndexOfAny(this Span<byte> span, byte value0, byte value1);
+        public static int IndexOfAny(this Span<byte> span, byte value0, byte value1, byte value2);
+        public static int IndexOfAny(this Span<byte> span, ReadOnlySpan<byte> values);
+        public static ReadOnlySpan<TTo> NonPortableCast<TFrom, TTo>(this ReadOnlySpan<TFrom> source) where TFrom : struct where TTo : struct;
+        public static Span<TTo> NonPortableCast<TFrom, TTo>(this Span<TFrom> source) where TFrom : struct where TTo : struct;
+        public static bool SequenceEqual(this ReadOnlySpan<byte> first, ReadOnlySpan<byte> second);
+        public static bool SequenceEqual(this Span<byte> first, ReadOnlySpan<byte> second);
+        public static bool SequenceEqual<T>(this ReadOnlySpan<T> first, ReadOnlySpan<T> second) where T : struct, IEquatable<T>;
+        public static bool SequenceEqual<T>(this Span<T> first, ReadOnlySpan<T> second) where T : struct, IEquatable<T>;
+        public static bool StartsWith(this ReadOnlySpan<byte> span, ReadOnlySpan<byte> value);
+        public static bool StartsWith(this Span<byte> span, ReadOnlySpan<byte> value);
+        public static bool StartsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value) where T : struct, IEquatable<T>;
+        public static bool StartsWith<T>(this Span<T> span, ReadOnlySpan<T> value) where T : struct, IEquatable<T>;
+    }
     public sealed class String : ICloneable, IComparable, IComparable<string>, IConvertible, IEnumerable, IEnumerable<char>, IEquatable<string> {
+        public bool EndsWith(char value);
+        public int GetHashCode(StringComparison comparisonType);
+        public static String Join(char separator, params object[] values);
+        public static String Join(char separator, params string[] value);
+        public static String Join(char separator, string[] value, int startIndex, int count);
+        public static String Join<T>(char separator, IEnumerable<T> values);
+        public String Replace(String oldValue, String newValue, bool ignoreCase, CultureInfo culture);
+        public String Replace(String oldValue, String newValue, StringComparison comparisonType);
+        public string[] Split(char separator, int count, StringSplitOptions options=(StringSplitOptions)(0));
+        public string[] Split(char separator, StringSplitOptions options=(StringSplitOptions)(0));
+        public string[] Split(String separator, int count, StringSplitOptions options=(StringSplitOptions)(0));
+        public string[] Split(String separator, StringSplitOptions options=(StringSplitOptions)(0));
+        public bool StartsWith(char value);
+        public String Trim(char trimChar);
+        public String TrimEnd();
+        public String TrimEnd(char trimChar);
+        public String TrimStart();
+        public String TrimStart(char trimChar);
     }
     public abstract class StringComparer : IComparer, IComparer<string>, IEqualityComparer, IEqualityComparer<string> {
+        public static StringComparer FromComparison(StringComparison comparisonType);
+        bool System.Collections.IEqualityComparer.Equals(object x, object y);
+        int System.Collections.IEqualityComparer.GetHashCode(object obj);
     }
     [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
     public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable {
+        public TimeSpan Divide(double divisor);
+        public double Divide(TimeSpan ts);
+        public TimeSpan Multiply(double factor);
+        public static TimeSpan operator /(TimeSpan timeSpan, double divisor);
+        public static double operator /(TimeSpan t1, TimeSpan t2);
+        public static TimeSpan operator *(double factor, TimeSpan timeSpan);
+        public static TimeSpan operator *(TimeSpan timeSpan, double factor);
     }
-    public class Tuple<T1> : IComparable, IStructuralComparable, IStructuralEquatable {
+    public class Tuple<T1> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    public class Tuple<T1, T2> : IComparable, IStructuralComparable, IStructuralEquatable {
+    public class Tuple<T1, T2> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    public class Tuple<T1, T2, T3> : IComparable, IStructuralComparable, IStructuralEquatable {
+    public class Tuple<T1, T2, T3> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    public class Tuple<T1, T2, T3, T4> : IComparable, IStructuralComparable, IStructuralEquatable {
+    public class Tuple<T1, T2, T3, T4> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    public class Tuple<T1, T2, T3, T4, T5> : IComparable, IStructuralComparable, IStructuralEquatable {
+    public class Tuple<T1, T2, T3, T4, T5> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    public class Tuple<T1, T2, T3, T4, T5, T6> : IComparable, IStructuralComparable, IStructuralEquatable {
+    public class Tuple<T1, T2, T3, T4, T5, T6> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IComparable, IStructuralComparable, IStructuralEquatable {
+    public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IComparable, IStructuralComparable, IStructuralEquatable {
+    public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
     public abstract class Type : MemberInfo, IReflect {
+        public virtual bool IsSZArray { get; }
+        public virtual bool IsTypeDefinition { get; }
+        public virtual bool IsVariableBoundArray { get; }
     }
-    public class TypeUnloadedException : SystemException
+    public class TypeUnloadedException : SystemException, ISerializable
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct UIntPtr : ISerializable {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct UIntPtr : IEquatable<UIntPtr>, ISerializable {
+        bool System.IEquatable<System.UIntPtr>.Equals(UIntPtr other);
     }
+    public enum UriIdnScope {
+        All = 2,
+        AllExceptIntranet = 1,
+        None = 0,
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
-    public struct ValueTuple : IComparable, IComparable<ValueTuple>, IEquatable<ValueTuple>, IStructuralComparable, IStructuralEquatable {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct ValueTuple : IComparable, IComparable<ValueTuple>, IEquatable<ValueTuple>, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1> : IComparable, IComparable<ValueTuple<T1>>, IEquatable<ValueTuple<T1>>, IStructuralComparable, IStructuralEquatable {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ValueTuple<T1> : IComparable, IComparable<ValueTuple<T1>>, IEquatable<ValueTuple<T1>>, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2> : IComparable, IComparable<ValueTuple<T1, T2>>, IEquatable<ValueTuple<T1, T2>>, IStructuralComparable, IStructuralEquatable {
+    public struct ValueTuple<T1, T2> : IComparable, IComparable<ValueTuple<T1, T2>>, IEquatable<ValueTuple<T1, T2>>, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3> : IComparable, IComparable<ValueTuple<T1, T2, T3>>, IEquatable<ValueTuple<T1, T2, T3>>, IStructuralComparable, IStructuralEquatable {
+    public struct ValueTuple<T1, T2, T3> : IComparable, IComparable<ValueTuple<T1, T2, T3>>, IEquatable<ValueTuple<T1, T2, T3>>, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralComparable, IStructuralEquatable {
+    public struct ValueTuple<T1, T2, T3, T4> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4, T5> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralComparable, IStructuralEquatable {
+    public struct ValueTuple<T1, T2, T3, T4, T5> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4, T5, T6> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralComparable, IStructuralEquatable {
+    public struct ValueTuple<T1, T2, T3, T4, T5, T6> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralComparable, IStructuralEquatable {
+    public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralComparable, IStructuralEquatable, ITuple {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralComparable, IStructuralEquatable where TRest : struct {
+    public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralComparable, IStructuralEquatable, ITuple where TRest : struct {
+        object System.Runtime.CompilerServices.ITuple.this[int index] { get; }
+        int System.Runtime.CompilerServices.ITuple.Length { get; }
     }
     public sealed class WeakReference<T> : ISerializable where T : class {
+        ~WeakReference();
     }
 }
```

