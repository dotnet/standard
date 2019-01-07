// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Collections
{
    public partial class ArrayList : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ICloneable
    {
        public ArrayList() { }
        public ArrayList(System.Collections.ICollection c) { }
        public ArrayList(int capacity) { }
        public virtual int Capacity { get { throw null; } set { } }
        public virtual int Count { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object this[int index] { get { throw null; } set { } }
        public virtual object SyncRoot { get { throw null; } }
        public static System.Collections.ArrayList Adapter(System.Collections.IList list) { throw null; }
        public virtual int Add(object value) { throw null; }
        public virtual void AddRange(System.Collections.ICollection c) { }
        public virtual int BinarySearch(int index, int count, object value, System.Collections.IComparer comparer) { throw null; }
        public virtual int BinarySearch(object value) { throw null; }
        public virtual int BinarySearch(object value, System.Collections.IComparer comparer) { throw null; }
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        public virtual bool Contains(object item) { throw null; }
        public virtual void CopyTo(System.Array array) { }
        public virtual void CopyTo(System.Array array, int arrayIndex) { }
        public virtual void CopyTo(int index, System.Array array, int arrayIndex, int count) { }
        public static System.Collections.ArrayList FixedSize(System.Collections.ArrayList list) { throw null; }
        public static System.Collections.IList FixedSize(System.Collections.IList list) { throw null; }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual System.Collections.IEnumerator GetEnumerator(int index, int count) { throw null; }
        public virtual System.Collections.ArrayList GetRange(int index, int count) { throw null; }
        public virtual int IndexOf(object value) { throw null; }
        public virtual int IndexOf(object value, int startIndex) { throw null; }
        public virtual int IndexOf(object value, int startIndex, int count) { throw null; }
        public virtual void Insert(int index, object value) { }
        public virtual void InsertRange(int index, System.Collections.ICollection c) { }
        public virtual int LastIndexOf(object value) { throw null; }
        public virtual int LastIndexOf(object value, int startIndex) { throw null; }
        public virtual int LastIndexOf(object value, int startIndex, int count) { throw null; }
        public static System.Collections.ArrayList ReadOnly(System.Collections.ArrayList list) { throw null; }
        public static System.Collections.IList ReadOnly(System.Collections.IList list) { throw null; }
        public virtual void Remove(object obj) { }
        public virtual void RemoveAt(int index) { }
        public virtual void RemoveRange(int index, int count) { }
        public static System.Collections.ArrayList Repeat(object value, int count) { throw null; }
        public virtual void Reverse() { }
        public virtual void Reverse(int index, int count) { }
        public virtual void SetRange(int index, System.Collections.ICollection c) { }
        public virtual void Sort() { }
        public virtual void Sort(System.Collections.IComparer comparer) { }
        public virtual void Sort(int index, int count, System.Collections.IComparer comparer) { }
        public static System.Collections.ArrayList Synchronized(System.Collections.ArrayList list) { throw null; }
        public static System.Collections.IList Synchronized(System.Collections.IList list) { throw null; }
        public virtual object[] ToArray() { throw null; }
        public virtual System.Array ToArray(System.Type type) { throw null; }
        public virtual void TrimToSize() { }
    }
    public sealed partial class BitArray : System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable
    {
        public BitArray(bool[] values) { }
        public BitArray(byte[] bytes) { }
        public BitArray(System.Collections.BitArray bits) { }
        public BitArray(int length) { }
        public BitArray(int length, bool defaultValue) { }
        public BitArray(int[] values) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public bool this[int index] { get { throw null; } set { } }
        public int Length { get { throw null; } set { } }
        public object SyncRoot { get { throw null; } }
        public System.Collections.BitArray And(System.Collections.BitArray value) { throw null; }
        public object Clone() { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public bool Get(int index) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public System.Collections.BitArray LeftShift(int count) { throw null; }
        public System.Collections.BitArray Not() { throw null; }
        public System.Collections.BitArray Or(System.Collections.BitArray value) { throw null; }
        public System.Collections.BitArray RightShift(int count) { throw null; }
        public void Set(int index, bool value) { }
        public void SetAll(bool value) { }
        public System.Collections.BitArray Xor(System.Collections.BitArray value) { throw null; }
    }
    public partial class CaseInsensitiveComparer : System.Collections.IComparer
    {
        public CaseInsensitiveComparer() { }
        public CaseInsensitiveComparer(System.Globalization.CultureInfo culture) { }
        public static System.Collections.CaseInsensitiveComparer Default { get { throw null; } }
        public static System.Collections.CaseInsensitiveComparer DefaultInvariant { get { throw null; } }
        public int Compare(object a, object b) { throw null; }
    }
    [System.ObsoleteAttribute("Please use StringComparer instead.")]
    public partial class CaseInsensitiveHashCodeProvider : System.Collections.IHashCodeProvider
    {
        public CaseInsensitiveHashCodeProvider() { }
        public CaseInsensitiveHashCodeProvider(System.Globalization.CultureInfo culture) { }
        public static System.Collections.CaseInsensitiveHashCodeProvider Default { get { throw null; } }
        public static System.Collections.CaseInsensitiveHashCodeProvider DefaultInvariant { get { throw null; } }
        public int GetHashCode(object obj) { throw null; }
    }
    public abstract partial class CollectionBase : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        protected CollectionBase() { }
        protected CollectionBase(int capacity) { }
        public int Capacity { get { throw null; } set { } }
        public int Count { get { throw null; } }
        protected System.Collections.ArrayList InnerList { get { throw null; } }
        protected System.Collections.IList List { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void Clear() { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected virtual void OnClear() { }
        protected virtual void OnClearComplete() { }
        protected virtual void OnInsert(int index, object value) { }
        protected virtual void OnInsertComplete(int index, object value) { }
        protected virtual void OnRemove(int index, object value) { }
        protected virtual void OnRemoveComplete(int index, object value) { }
        protected virtual void OnSet(int index, object oldValue, object newValue) { }
        protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }
        protected virtual void OnValidate(object value) { }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
    }
    public sealed partial class Comparer : System.Collections.IComparer, System.Runtime.Serialization.ISerializable
    {
        public static readonly System.Collections.Comparer Default;
        public static readonly System.Collections.Comparer DefaultInvariant;
        public Comparer(System.Globalization.CultureInfo culture) { }
        public int Compare(object a, object b) { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class DictionaryBase : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        protected DictionaryBase() { }
        public int Count { get { throw null; } }
        protected System.Collections.IDictionary Dictionary { get { throw null; } }
        protected System.Collections.Hashtable InnerHashtable { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IDictionary.IsFixedSize { get { throw null; } }
        bool System.Collections.IDictionary.IsReadOnly { get { throw null; } }
        object System.Collections.IDictionary.this[object key] { get { throw null; } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { throw null; } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { throw null; } }
        public void Clear() { }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
        protected virtual void OnClear() { }
        protected virtual void OnClearComplete() { }
        protected virtual object OnGet(object key, object currentValue) { throw null; }
        protected virtual void OnInsert(object key, object value) { }
        protected virtual void OnInsertComplete(object key, object value) { }
        protected virtual void OnRemove(object key, object value) { }
        protected virtual void OnRemoveComplete(object key, object value) { }
        protected virtual void OnSet(object key, object oldValue, object newValue) { }
        protected virtual void OnSetComplete(object key, object oldValue, object newValue) { }
        protected virtual void OnValidate(object key, object value) { }
        void System.Collections.IDictionary.Add(object key, object value) { }
        bool System.Collections.IDictionary.Contains(object key) { throw null; }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial struct DictionaryEntry
    {
        private object _dummy;
        public DictionaryEntry(object key, object value) { throw null; }
        public object Key { get { throw null; } set { } }
        public object Value { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void Deconstruct(out object key, out object value) { throw null; }
    }
    public partial class Hashtable : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.ICloneable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public Hashtable() { }
        public Hashtable(System.Collections.IDictionary d) { }
        public Hashtable(System.Collections.IDictionary d, System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use Hashtable(IDictionary, IEqualityComparer) instead.")]
        public Hashtable(System.Collections.IDictionary d, System.Collections.IHashCodeProvider hcp, System.Collections.IComparer comparer) { }
        public Hashtable(System.Collections.IDictionary d, float loadFactor) { }
        public Hashtable(System.Collections.IDictionary d, float loadFactor, System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use Hashtable(IDictionary, float, IEqualityComparer) instead.")]
        public Hashtable(System.Collections.IDictionary d, float loadFactor, System.Collections.IHashCodeProvider hcp, System.Collections.IComparer comparer) { }
        public Hashtable(System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use Hashtable(IEqualityComparer) instead.")]
        public Hashtable(System.Collections.IHashCodeProvider hcp, System.Collections.IComparer comparer) { }
        public Hashtable(int capacity) { }
        public Hashtable(int capacity, System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use Hashtable(int, IEqualityComparer) instead.")]
        public Hashtable(int capacity, System.Collections.IHashCodeProvider hcp, System.Collections.IComparer comparer) { }
        public Hashtable(int capacity, float loadFactor) { }
        public Hashtable(int capacity, float loadFactor, System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use Hashtable(int, float, IEqualityComparer) instead.")]
        public Hashtable(int capacity, float loadFactor, System.Collections.IHashCodeProvider hcp, System.Collections.IComparer comparer) { }
        protected Hashtable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        [System.ObsoleteAttribute("Please use KeyComparer properties.")]
        protected System.Collections.IComparer comparer { get { throw null; } set { } }
        public virtual int Count { get { throw null; } }
        protected System.Collections.IEqualityComparer EqualityComparer { get { throw null; } }
        [System.ObsoleteAttribute("Please use EqualityComparer property.")]
        protected System.Collections.IHashCodeProvider hcp { get { throw null; } set { } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object this[object key] { get { throw null; } set { } }
        public virtual System.Collections.ICollection Keys { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual System.Collections.ICollection Values { get { throw null; } }
        public virtual void Add(object key, object value) { }
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        public virtual bool Contains(object key) { throw null; }
        public virtual bool ContainsKey(object key) { throw null; }
        public virtual bool ContainsValue(object value) { throw null; }
        public virtual void CopyTo(System.Array array, int arrayIndex) { }
        public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
        protected virtual int GetHash(object key) { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual bool KeyEquals(object item, object key) { throw null; }
        public virtual void OnDeserialization(object sender) { }
        public virtual void Remove(object key) { }
        public static System.Collections.Hashtable Synchronized(System.Collections.Hashtable table) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial interface ICollection : System.Collections.IEnumerable
    {
        int Count { get; }
        bool IsSynchronized { get; }
        object SyncRoot { get; }
        void CopyTo(System.Array array, int index);
    }
    public partial interface IComparer
    {
        int Compare(object x, object y);
    }
    public partial interface IDictionary : System.Collections.ICollection, System.Collections.IEnumerable
    {
        bool IsFixedSize { get; }
        bool IsReadOnly { get; }
        object this[object key] { get; set; }
        System.Collections.ICollection Keys { get; }
        System.Collections.ICollection Values { get; }
        void Add(object key, object value);
        void Clear();
        bool Contains(object key);
        new System.Collections.IDictionaryEnumerator GetEnumerator();
        void Remove(object key);
    }
    public partial interface IDictionaryEnumerator : System.Collections.IEnumerator
    {
        System.Collections.DictionaryEntry Entry { get; }
        object Key { get; }
        object Value { get; }
    }
    public partial interface IEnumerable
    {
        System.Collections.IEnumerator GetEnumerator();
    }
    public partial interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }
    public partial interface IEqualityComparer
    {
        bool Equals(object x, object y);
        int GetHashCode(object obj);
    }
    [System.ObsoleteAttribute("Please use IEqualityComparer instead.")]
    public partial interface IHashCodeProvider
    {
        int GetHashCode(object obj);
    }
    public partial interface IList : System.Collections.ICollection, System.Collections.IEnumerable
    {
        bool IsFixedSize { get; }
        bool IsReadOnly { get; }
        object this[int index] { get; set; }
        int Add(object value);
        void Clear();
        bool Contains(object value);
        int IndexOf(object value);
        void Insert(int index, object value);
        void Remove(object value);
        void RemoveAt(int index);
    }
    public partial interface IStructuralComparable
    {
        int CompareTo(object other, System.Collections.IComparer comparer);
    }
    public partial interface IStructuralEquatable
    {
        bool Equals(object other, System.Collections.IEqualityComparer comparer);
        int GetHashCode(System.Collections.IEqualityComparer comparer);
    }
    public partial class Queue : System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable
    {
        public Queue() { }
        public Queue(System.Collections.ICollection col) { }
        public Queue(int capacity) { }
        public Queue(int capacity, float growFactor) { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        public virtual bool Contains(object obj) { throw null; }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual object Dequeue() { throw null; }
        public virtual void Enqueue(object obj) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual object Peek() { throw null; }
        public static System.Collections.Queue Synchronized(System.Collections.Queue queue) { throw null; }
        public virtual object[] ToArray() { throw null; }
        public virtual void TrimToSize() { }
    }
    public abstract partial class ReadOnlyCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable
    {
        protected ReadOnlyCollectionBase() { }
        public virtual int Count { get { throw null; } }
        protected System.Collections.ArrayList InnerList { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    }
    public partial class SortedList : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.ICloneable
    {
        public SortedList() { }
        public SortedList(System.Collections.IComparer comparer) { }
        public SortedList(System.Collections.IComparer comparer, int capacity) { }
        public SortedList(System.Collections.IDictionary d) { }
        public SortedList(System.Collections.IDictionary d, System.Collections.IComparer comparer) { }
        public SortedList(int initialCapacity) { }
        public virtual int Capacity { get { throw null; } set { } }
        public virtual int Count { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object this[object key] { get { throw null; } set { } }
        public virtual System.Collections.ICollection Keys { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual System.Collections.ICollection Values { get { throw null; } }
        public virtual void Add(object key, object value) { }
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        public virtual bool Contains(object key) { throw null; }
        public virtual bool ContainsKey(object key) { throw null; }
        public virtual bool ContainsValue(object value) { throw null; }
        public virtual void CopyTo(System.Array array, int arrayIndex) { }
        public virtual object GetByIndex(int index) { throw null; }
        public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
        public virtual object GetKey(int index) { throw null; }
        public virtual System.Collections.IList GetKeyList() { throw null; }
        public virtual System.Collections.IList GetValueList() { throw null; }
        public virtual int IndexOfKey(object key) { throw null; }
        public virtual int IndexOfValue(object value) { throw null; }
        public virtual void Remove(object key) { }
        public virtual void RemoveAt(int index) { }
        public virtual void SetByIndex(int index, object value) { }
        public static System.Collections.SortedList Synchronized(System.Collections.SortedList list) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public virtual void TrimToSize() { }
    }
    public partial class Stack : System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable
    {
        public Stack() { }
        public Stack(System.Collections.ICollection col) { }
        public Stack(int initialCapacity) { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        public virtual bool Contains(object obj) { throw null; }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual object Peek() { throw null; }
        public virtual object Pop() { throw null; }
        public virtual void Push(object obj) { }
        public static System.Collections.Stack Synchronized(System.Collections.Stack stack) { throw null; }
        public virtual object[] ToArray() { throw null; }
    }
    public static partial class StructuralComparisons
    {
        public static System.Collections.IComparer StructuralComparer { get { throw null; } }
        public static System.Collections.IEqualityComparer StructuralEqualityComparer { get { throw null; } }
    }
}
