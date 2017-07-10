# System.Runtime.InteropServices.Expando

``` diff
+namespace System.Runtime.InteropServices.Expando {
+    public interface IExpando : IReflect {
+        FieldInfo AddField(string name);
+        MethodInfo AddMethod(string name, Delegate method);
+        PropertyInfo AddProperty(string name);
+        void RemoveMember(MemberInfo m);
+    }
+}
```

