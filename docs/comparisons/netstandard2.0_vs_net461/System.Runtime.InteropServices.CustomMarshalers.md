# System.Runtime.InteropServices.CustomMarshalers

``` diff
+namespace System.Runtime.InteropServices.CustomMarshalers {
+    public class EnumerableToDispatchMarshaler : ICustomMarshaler {
+        public virtual void CleanUpManagedData(object pManagedObj);
+        public virtual void CleanUpNativeData(IntPtr pNativeData);
+        public static ICustomMarshaler GetInstance(string pstrCookie);
+        public virtual int GetNativeDataSize();
+        public virtual IntPtr MarshalManagedToNative(object pManagedObj);
+        public virtual object MarshalNativeToManaged(IntPtr pNativeData);
+    }
+    public class EnumeratorToEnumVariantMarshaler : ICustomMarshaler {
+        public virtual void CleanUpManagedData(object pManagedObj);
+        public virtual void CleanUpNativeData(IntPtr pNativeData);
+        public static ICustomMarshaler GetInstance(string pstrCookie);
+        public virtual int GetNativeDataSize();
+        public virtual IntPtr MarshalManagedToNative(object pManagedObj);
+        public virtual object MarshalNativeToManaged(IntPtr pNativeData);
+    }
+    public class ExpandoToDispatchExMarshaler : ICustomMarshaler {
+        public virtual void CleanUpManagedData(object pManagedObj);
+        public virtual void CleanUpNativeData(IntPtr pNativeData);
+        public static ICustomMarshaler GetInstance(string pstrCookie);
+        public virtual int GetNativeDataSize();
+        public virtual IntPtr MarshalManagedToNative(object pManagedObj);
+        public virtual object MarshalNativeToManaged(IntPtr pNativeData);
+    }
+    public class TypeToTypeInfoMarshaler : ICustomMarshaler {
+        public virtual void CleanUpManagedData(object pManagedObj);
+        public virtual void CleanUpNativeData(IntPtr pNativeData);
+        public static ICustomMarshaler GetInstance(string pstrCookie);
+        public virtual int GetNativeDataSize();
+        public virtual IntPtr MarshalManagedToNative(object pManagedObj);
+        public virtual object MarshalNativeToManaged(IntPtr pNativeData);
+    }
+}
```

