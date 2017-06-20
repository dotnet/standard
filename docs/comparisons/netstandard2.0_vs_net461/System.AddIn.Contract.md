# System.AddIn.Contract

``` diff
+namespace System.AddIn.Contract {
+    public interface IContract {
+        int AcquireLifetimeToken();
+        int GetRemoteHashCode();
+        IContract QueryContract(string contractIdentifier);
+        bool RemoteEquals(IContract contract);
+        string RemoteToString();
+        void RevokeLifetimeToken(int token);
+    }
+    public interface IEnumeratorContract<T> : IDisposable {
+        T GetCurrent();
+        bool MoveNext();
+        void Reset();
+    }
+    public interface IExecutorExtensionContract : IContract {
+        void AssemblyLoaded(string assemblyName);
+        void AssemblyLoadedFrom(string assemblyFile);
+        void AssemblyLoading(string assemblyName);
+        void AssemblyLoadingFrom(string assemblyFile);
+        void EntryPointStarted(IContract entryPoint);
+        void EntryPointStarting(string assemblyName, string startupClass, IRemoteArgumentArrayContract initArgs);
+        void ExecutorCreated();
+    }
+    public interface IListContract<T> : IContract {
+        void Add(T item);
+        void Clear();
+        bool Contains(T item);
+        int GetCount();
+        IEnumeratorContract<T> GetEnumeratorContract();
+        bool GetIsReadOnly();
+        T GetItem(int index);
+        int IndexOf(T item);
+        void Insert(int index, T item);
+        bool Remove(T item);
+        void RemoveAt(int index);
+        void SetItem(int index, T item);
+    }
+    public interface INativeHandleContract : IContract {
+        IntPtr GetHandle();
+    }
+    public interface IProfferServiceContract : IContract {
+        void ProfferService(string serviceIdentifier, IServiceProviderContract service);
+        void RevokeService(string serviceIdentifier);
+    }
+    public interface ISerializableObjectContract : IContract, IRemoteArgumentCollectionContract, IRemoteArgumentDictionaryContract, IRemoteArgumentEnumerableContract {
+        string GetCanonicalName();
+        SerializableObjectData GetSerializableObjectData();
+    }
+    public interface IServiceProviderContract : IContract {
+        IContract QueryService(string serviceIdentifier, string serviceContractIdentifier);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RemoteArgument {
+        public RemoteArgument(IContract value);
+        public RemoteArgument(IContract value, bool isByRef);
+        public RemoteArgument(RemoteArgumentKind remoteArgKind, TypeCode typeCode);
+        public RemoteArgument(RemoteArgumentKind remoteArgKind, TypeCode typeCode, bool isByRef);
+        public RemoteArgument(Array array);
+        public RemoteArgument(Array array, bool isByRef);
+        public RemoteArgument(bool value);
+        public RemoteArgument(bool value, bool isByRef);
+        public RemoteArgument(byte value);
+        public RemoteArgument(byte value, bool isByRef);
+        public RemoteArgument(char value);
+        public RemoteArgument(char value, bool isByRef);
+        public RemoteArgument(DateTime value);
+        public RemoteArgument(DateTime value, bool isByRef);
+        public RemoteArgument(DBNull value);
+        public RemoteArgument(DBNull value, bool isByRef);
+        public RemoteArgument(decimal value);
+        public RemoteArgument(decimal value, bool isByRef);
+        public RemoteArgument(double value);
+        public RemoteArgument(double value, bool isByRef);
+        public RemoteArgument(short value);
+        public RemoteArgument(short value, bool isByRef);
+        public RemoteArgument(int value);
+        public RemoteArgument(int value, bool isByRef);
+        public RemoteArgument(long value);
+        public RemoteArgument(long value, bool isByRef);
+        public RemoteArgument(sbyte value);
+        public RemoteArgument(sbyte value, bool isByRef);
+        public RemoteArgument(float value);
+        public RemoteArgument(float value, bool isByRef);
+        public RemoteArgument(string value);
+        public RemoteArgument(string value, bool isByRef);
+        public RemoteArgument(ushort value);
+        public RemoteArgument(ushort value, bool isByRef);
+        public RemoteArgument(uint value);
+        public RemoteArgument(uint value, bool isByRef);
+        public RemoteArgument(ulong value);
+        public RemoteArgument(ulong value, bool isByRef);
+        public Array ArrayValue { get; set; }
+        public bool BooleanValue { get; set; }
+        public byte ByteValue { get; set; }
+        public char CharValue { get; set; }
+        public IContract ContractValue { get; set; }
+        public DateTime DateTimeValue { get; set; }
+        public DBNull DBNullValue { get; set; }
+        public decimal DecimalValue { get; set; }
+        public double DoubleValue { get; set; }
+        public short Int16Value { get; set; }
+        public int Int32Value { get; set; }
+        public long Int64Value { get; set; }
+        public bool IsByRef { get; set; }
+        public Missing MissingValue { get; }
+        public RemoteArgumentKind RemoteArgumentKind { get; }
+        public sbyte SByteValue { get; set; }
+        public float SingleValue { get; set; }
+        public string StringValue { get; set; }
+        public TypeCode TypeCode { get; }
+        public ushort UInt16Value { get; set; }
+        public uint UInt32Value { get; set; }
+        public ulong UInt64Value { get; set; }
+        public static RemoteArgument CreateRemoteArgument(object value);
+        public static RemoteArgument CreateRemoteArgument(object value, bool isByRef);
+        public static RemoteArgument CreateRemoteArgument(object value, bool isByRef, TypeCode typeCodeToUse);
+    }
+    public enum RemoteArgumentKind {
+        Contract = 3,
+        Intrinsic = 1,
+        IntrinsicArray = 2,
+        Missing = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct SerializableObjectData {
+        public bool IsArray;
+        public bool IsArrayElement;
+        public int[] DimensionLengths;
+        public int[] DimensionLowerBounds;
+        public int[] ElementIndexes;
+        public long ObjectId;
+        public long ParentId;
+        public string MemberName;
+    }
+}
```

