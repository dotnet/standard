# System.Runtime.Serialization.Formatters

``` diff
 namespace System.Runtime.Serialization.Formatters {
+    public interface IFieldInfo {
+        string[] FieldNames { get; set; }
+        Type[] FieldTypes { get; set; }
+    }
+    public sealed class InternalRM {
+        public InternalRM();
+        public static void InfoSoap(params object[] messages);
+        public static bool SoapCheckEnabled();
+    }
+    public sealed class InternalST {
+        public static void InfoSoap(params object[] messages);
+        public static Assembly LoadAssemblyFromString(string assemblyString);
+        public static void SerializationSetValue(FieldInfo fi, object target, object value);
+        public static void Soap(params object[] messages);
+        public static void SoapAssert(bool condition, string message);
+        public static bool SoapCheckEnabled();
+    }
+    public interface ISoapMessage {
+        Header[] Headers { get; set; }
+        string MethodName { get; set; }
+        string[] ParamNames { get; set; }
+        Type[] ParamTypes { get; set; }
+        object[] ParamValues { get; set; }
+        string XmlNameSpace { get; set; }
+    }
+    public sealed class ServerFault {
+        public ServerFault(string exceptionType, string message, string stackTrace);
+        public string ExceptionMessage { get; set; }
+        public string ExceptionType { get; set; }
+        public string StackTrace { get; set; }
+    }
+    public sealed class SoapFault : ISerializable {
+        public SoapFault();
+        public SoapFault(string faultCode, string faultString, string faultActor, ServerFault serverFault);
+        public object Detail { get; set; }
+        public string FaultActor { get; set; }
+        public string FaultCode { get; set; }
+        public string FaultString { get; set; }
+        public void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class SoapMessage : ISoapMessage {
+        public SoapMessage();
+        public Header[] Headers { get; set; }
+        public string MethodName { get; set; }
+        public string[] ParamNames { get; set; }
+        public Type[] ParamTypes { get; set; }
+        public object[] ParamValues { get; set; }
+        public string XmlNameSpace { get; set; }
+    }
 }
```

