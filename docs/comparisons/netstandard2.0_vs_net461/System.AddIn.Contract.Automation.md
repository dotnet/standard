# System.AddIn.Contract.Automation

``` diff
+namespace System.AddIn.Contract.Automation {
+    public interface IRemoteDelegateContract : IContract, IRemoteObjectContract {
+        RemoteArgument InvokeDelegate(IRemoteArgumentArrayContract args);
+    }
+    public interface IRemoteEventInfoContract : IContract {
+        IRemoteMethodInfoContract GetAddMethod();
+        RemoteMemberData GetMemberData();
+        IRemoteMethodInfoContract GetRemoveMethod();
+    }
+    public interface IRemoteFieldInfoContract : IContract {
+        RemoteFieldData GetFieldData();
+        RemoteArgument GetValue(IRemoteObjectContract obj);
+        void SetValue(IRemoteObjectContract obj, RemoteArgument value, int localeId);
+    }
+    public interface IRemoteMethodInfoContract : IContract {
+        RemoteMethodData GetMethodData();
+        RemoteArgument Invoke(IRemoteObjectContract target, BindingFlags bindingFlags, IRemoteArgumentArrayContract parameters, int localeId);
+    }
+    public interface IRemoteObjectContract : IContract {
+        IRemoteTypeContract GetRemoteType();
+        RemoteArgument RemoteCast(string canonicalName);
+    }
+    public interface IRemotePropertyInfoContract : IContract {
+        IRemoteMethodInfoContract GetGetMethod();
+        RemotePropertyData GetPropertyData();
+        IRemoteMethodInfoContract GetSetMethod();
+        RemoteArgument GetValue(IRemoteObjectContract obj, BindingFlags bindingFlags, IRemoteArgumentArrayContract index, int localeId);
+        void SetValue(IRemoteObjectContract target, ref RemoteArgument value, BindingFlags bindingFlags, IRemoteArgumentArrayContract index, int localeId);
+    }
+    public interface IRemoteTypeContract : IContract {
+        string GetCanonicalName();
+        IRemoteEventInfoContract GetEvent(string name, BindingFlags bindingFlags);
+        IArrayContract<IRemoteEventInfoContract> GetEvents(BindingFlags bindingFlags);
+        IRemoteFieldInfoContract GetField(string name, BindingFlags bindingFlags);
+        IArrayContract<IRemoteFieldInfoContract> GetFields(BindingFlags bindingFlags);
+        IRemoteTypeContract GetInterface(string canonicalName);
+        IArrayContract<IRemoteTypeContract> GetInterfaces();
+        IArrayContract<IContract> GetMember(string name, MemberTypes memberTypes, BindingFlags bindingFlags);
+        IArrayContract<IContract> GetMembers(BindingFlags bindingFlags);
+        IRemoteMethodInfoContract GetMethod(string name, BindingFlags bindingFlags, IArrayContract<IRemoteTypeContract> remoteTypes);
+        IArrayContract<IRemoteMethodInfoContract> GetMethods(BindingFlags bindingFlags);
+        IArrayContract<IRemotePropertyInfoContract> GetProperties(BindingFlags bindingFlags);
+        IRemotePropertyInfoContract GetProperty(string name, BindingFlags bindingFlags, IRemoteTypeContract remoteReturnType, IArrayContract<IRemoteTypeContract> remoteTypes);
+        RemoteTypeData GetTypeData();
+        RemoteArgument InvokeMember(string name, BindingFlags bindingFlags, IRemoteObjectContract target, IRemoteArgumentArrayContract remoteArgs, bool[] remoteArgModifiers, int localeId);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RemoteFieldData {
+        public IRemoteTypeContract FieldType;
+        public RemoteMemberData MemberData;
+        public FieldAttributes Attributes;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RemoteMemberData {
+        public IRemoteTypeContract DeclaringType;
+        public string Name;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RemoteMethodData {
+        public RemoteMemberData MemberData;
+        public RemoteParameterData ReturnParameter;
+        public RemoteParameterData[] Parameters;
+        public MethodAttributes Attributes;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RemoteParameterData {
+        public IRemoteTypeContract ParameterType;
+        public RemoteArgument DefaultValue;
+        public bool IsByRef;
+        public bool IsParameterArray;
+        public int Position;
+        public ParameterAttributes Attributes;
+        public string Name;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RemotePropertyData {
+        public IRemoteTypeContract PropertyType;
+        public RemoteMemberData MemberData;
+        public RemoteParameterData[] IndexParameters;
+        public bool CanRead;
+        public bool CanWrite;
+        public PropertyAttributes Attributes;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RemoteTypeData {
+        public IRemoteTypeContract BaseType;
+        public IRemoteTypeContract ElementType;
+        public RemoteMemberData MemberData;
+        public bool IsArray;
+        public bool IsByRef;
+        public int ArrayRank;
+        public TypeAttributes Attributes;
+        public string AssemblyName;
+        public string AssemblyQualifiedName;
+        public string FullName;
+        public TypeCode TypeCode;
+    }
+}
```

