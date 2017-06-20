# System.AddIn.Contract.Collections

``` diff
+namespace System.AddIn.Contract.Collections {
+    public interface IArrayContract<C> : IContract, IEnumerableContract<C> where C : IContract {
+        int GetCount();
+        C GetItem(int index);
+        void SetItem(int index, C value);
+    }
+    public interface ICollectionContract<C> : IContract, IEnumerableContract<C> where C : IContract {
+        void Add(C item);
+        void Clear();
+        bool Contains(C item);
+        void CopyTo(C[] array, int arrayIndex);
+        int GetCount();
+        bool GetIsReadOnly();
+        bool Remove(C item);
+    }
+    public interface IEnumerableContract<C> : IContract where C : IContract {
+        IEnumeratorContract<C> GetEnumeratorContract();
+    }
+    public interface IEnumeratorContract<C> : IContract where C : IContract {
+        C GetCurrent();
+        bool MoveNext();
+        void Reset();
+    }
+    public interface IListContract<C> : ICollectionContract<C>, IContract, IEnumerableContract<C> where C : IContract {
+        C GetItem(int index);
+        int IndexOf(C item);
+        void Insert(int index, C item);
+        void RemoveAt(int index);
+        void SetItem(int index, C value);
+    }
+    public interface IRemoteArgumentArrayContract : IContract, IRemoteArgumentCollectionContract, IRemoteArgumentEnumerableContract {
+        RemoteArgument GetItem(int index);
+        void SetItem(int index, RemoteArgument value);
+    }
+    public interface IRemoteArgumentArrayListContract : IContract, IRemoteArgumentArrayContract, IRemoteArgumentCollectionContract, IRemoteArgumentEnumerableContract {
+        void Add(RemoteArgument newItem);
+        void Clear();
+        bool Contains(RemoteArgument item);
+        int IndexOf(RemoteArgument item);
+        void Insert(int index, RemoteArgument item);
+        void Remove(RemoteArgument item);
+        void RemoveAt(int index);
+    }
+    public interface IRemoteArgumentCollectionContract : IContract, IRemoteArgumentEnumerableContract {
+        int GetCount();
+    }
+    public interface IRemoteArgumentDictionaryContract : IContract, IRemoteArgumentCollectionContract, IRemoteArgumentEnumerableContract {
+        void Add(RemoteArgument key, RemoteArgument value);
+        void Clear();
+        bool ContainsKey(RemoteArgument key);
+        new IRemoteArgumentDictionaryEnumeratorContract GetEnumeratorContract();
+        RemoteArgument GetItem(RemoteArgument key);
+        IRemoteArgumentCollectionContract GetKeys();
+        IRemoteArgumentCollectionContract GetValues();
+        bool Remove(RemoteArgument key);
+        void SetItem(RemoteArgument key, RemoteArgument value);
+    }
+    public interface IRemoteArgumentDictionaryEnumeratorContract : IContract, IRemoteArgumentEnumeratorContract {
+        RemoteArgumentDictionaryEntry GetEntry();
+        RemoteArgument GetKey();
+        RemoteArgument GetValue();
+    }
+    public interface IRemoteArgumentEnumerableContract : IContract {
+        IRemoteArgumentEnumeratorContract GetEnumeratorContract();
+    }
+    public interface IRemoteArgumentEnumeratorContract : IContract {
+        RemoteArgument GetCurrent();
+        bool MoveNext();
+        void Reset();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RemoteArgumentDictionaryEntry {
+        public RemoteArgument Key;
+        public RemoteArgument Value;
+        public RemoteArgumentDictionaryEntry(RemoteArgument key, RemoteArgument value);
+    }
+}
```

