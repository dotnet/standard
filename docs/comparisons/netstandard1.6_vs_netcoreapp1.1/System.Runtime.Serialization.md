# System.Runtime.Serialization

``` diff
+namespace System.Runtime.Serialization {
+    public sealed class CollectionDataContractAttribute : Attribute {
+        public CollectionDataContractAttribute();
+        public bool IsItemNameSetExplicitly { get; }
+        public bool IsKeyNameSetExplicitly { get; }
+        public bool IsNameSetExplicitly { get; }
+        public bool IsNamespaceSetExplicitly { get; }
+        public bool IsReference { get; set; }
+        public bool IsReferenceSetExplicitly { get; }
+        public bool IsValueNameSetExplicitly { get; }
+        public string ItemName { get; set; }
+        public string KeyName { get; set; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public string ValueName { get; set; }
+    }
+    public sealed class ContractNamespaceAttribute : Attribute {
+        public ContractNamespaceAttribute(string contractNamespace);
+        public string ClrNamespace { get; set; }
+        public string ContractNamespace { get; }
+    }
+    public sealed class DataContractAttribute : Attribute {
+        public DataContractAttribute();
+        public bool IsNameSetExplicitly { get; }
+        public bool IsNamespaceSetExplicitly { get; }
+        public bool IsReference { get; set; }
+        public bool IsReferenceSetExplicitly { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+    }
+    public abstract class DataContractResolver {
+        protected DataContractResolver();
+        public abstract Type ResolveName(string typeName, string typeNamespace, Type declaredType, DataContractResolver knownTypeResolver);
+        public abstract bool TryResolveType(Type type, Type declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace);
+    }
+    public sealed class DataContractSerializer : XmlObjectSerializer {
+        public DataContractSerializer(Type type);
+        public DataContractSerializer(Type type, IEnumerable<Type> knownTypes);
+        public DataContractSerializer(Type type, DataContractSerializerSettings settings);
+        public DataContractSerializer(Type type, string rootName, string rootNamespace);
+        public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes);
+        public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace);
+        public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes);
+        public bool IgnoreExtensionDataObject { get; }
+        public ReadOnlyCollection<Type> KnownTypes { get; }
+        public int MaxItemsInObjectGraph { get; }
+        public bool PreserveObjectReferences { get; }
+        public bool SerializeReadOnlyTypes { get; }
+        public override bool IsStartObject(XmlDictionaryReader reader);
+        public override bool IsStartObject(XmlReader reader);
+        public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName);
+        public override object ReadObject(XmlReader reader);
+        public override object ReadObject(XmlReader reader, bool verifyObjectName);
+        public override void WriteEndObject(XmlDictionaryWriter writer);
+        public override void WriteEndObject(XmlWriter writer);
+        public override void WriteObject(XmlWriter writer, object graph);
+        public override void WriteObjectContent(XmlDictionaryWriter writer, object graph);
+        public override void WriteObjectContent(XmlWriter writer, object graph);
+        public override void WriteStartObject(XmlDictionaryWriter writer, object graph);
+        public override void WriteStartObject(XmlWriter writer, object graph);
+    }
+    public static class DataContractSerializerExtensions {
+        public static ISerializationSurrogateProvider GetSerializationSurrogateProvider(this DataContractSerializer serializer);
+        public static void SetSerializationSurrogateProvider(this DataContractSerializer serializer, ISerializationSurrogateProvider provider);
+    }
+    public class DataContractSerializerSettings {
+        public DataContractSerializerSettings();
+        public DataContractResolver DataContractResolver { get; set; }
+        public IEnumerable<Type> KnownTypes { get; set; }
+        public int MaxItemsInObjectGraph { get; set; }
+        public bool PreserveObjectReferences { get; set; }
+        public XmlDictionaryString RootName { get; set; }
+        public XmlDictionaryString RootNamespace { get; set; }
+        public bool SerializeReadOnlyTypes { get; set; }
+    }
+    public sealed class DataMemberAttribute : Attribute {
+        public DataMemberAttribute();
+        public bool EmitDefaultValue { get; set; }
+        public bool IsNameSetExplicitly { get; }
+        public bool IsRequired { get; set; }
+        public string Name { get; set; }
+        public int Order { get; set; }
+    }
+    public class DateTimeFormat {
+        public DateTimeFormat(string formatString);
+        public DateTimeFormat(string formatString, IFormatProvider formatProvider);
+        public DateTimeStyles DateTimeStyles { get; set; }
+        public IFormatProvider FormatProvider { get; }
+        public string FormatString { get; }
+    }
+    public enum EmitTypeInformation {
+        Always = 1,
+        AsNeeded = 0,
+        Never = 2,
+    }
+    public sealed class EnumMemberAttribute : Attribute {
+        public EnumMemberAttribute();
+        public bool IsValueSetExplicitly { get; }
+        public string Value { get; set; }
+    }
+    public interface IDeserializationCallback {
+        void OnDeserialization(object sender);
+    }
+    public interface IFormatterConverter {
+        object Convert(object value, Type type);
+        object Convert(object value, TypeCode typeCode);
+        bool ToBoolean(object value);
+        byte ToByte(object value);
+        char ToChar(object value);
+        DateTime ToDateTime(object value);
+        decimal ToDecimal(object value);
+        double ToDouble(object value);
+        short ToInt16(object value);
+        int ToInt32(object value);
+        long ToInt64(object value);
+        sbyte ToSByte(object value);
+        float ToSingle(object value);
+        string ToString(object value);
+        ushort ToUInt16(object value);
+        uint ToUInt32(object value);
+        ulong ToUInt64(object value);
+    }
+    public sealed class IgnoreDataMemberAttribute : Attribute {
+        public IgnoreDataMemberAttribute();
+    }
+    public class InvalidDataContractException : Exception {
+        public InvalidDataContractException();
+        public InvalidDataContractException(string message);
+        public InvalidDataContractException(string message, Exception innerException);
+    }
+    public interface ISerializable {
+        void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public interface ISerializationSurrogateProvider {
+        object GetDeserializedObject(object obj, Type targetType);
+        object GetObjectToSerialize(object obj, Type targetType);
+        Type GetSurrogateType(Type type);
+    }
+    public sealed class KnownTypeAttribute : Attribute {
+        public KnownTypeAttribute(string methodName);
+        public KnownTypeAttribute(Type type);
+        public string MethodName { get; }
+        public Type Type { get; }
+    }
+    public sealed class OnDeserializedAttribute : Attribute {
+        public OnDeserializedAttribute();
+    }
+    public sealed class OnDeserializingAttribute : Attribute {
+        public OnDeserializingAttribute();
+    }
+    public sealed class OnSerializedAttribute : Attribute {
+        public OnSerializedAttribute();
+    }
+    public sealed class OnSerializingAttribute : Attribute {
+        public OnSerializingAttribute();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct SerializationEntry {
+        public string Name { get; }
+        public Type ObjectType { get; }
+        public object Value { get; }
+    }
+    public class SerializationException : Exception {
+        public SerializationException();
+        public SerializationException(string message);
+        public SerializationException(string message, Exception innerException);
+    }
+    public sealed class SerializationInfo {
+        public SerializationInfo(Type type, IFormatterConverter converter);
+        public string AssemblyName { get; set; }
+        public string FullTypeName { get; set; }
+        public int MemberCount { get; }
+        public Type ObjectType { get; }
+        public void AddValue(string name, bool value);
+        public void AddValue(string name, byte value);
+        public void AddValue(string name, char value);
+        public void AddValue(string name, DateTime value);
+        public void AddValue(string name, decimal value);
+        public void AddValue(string name, double value);
+        public void AddValue(string name, short value);
+        public void AddValue(string name, int value);
+        public void AddValue(string name, long value);
+        public void AddValue(string name, object value);
+        public void AddValue(string name, object value, Type type);
+        public void AddValue(string name, sbyte value);
+        public void AddValue(string name, float value);
+        public void AddValue(string name, ushort value);
+        public void AddValue(string name, uint value);
+        public void AddValue(string name, ulong value);
+        public bool GetBoolean(string name);
+        public byte GetByte(string name);
+        public char GetChar(string name);
+        public DateTime GetDateTime(string name);
+        public decimal GetDecimal(string name);
+        public double GetDouble(string name);
+        public SerializationInfoEnumerator GetEnumerator();
+        public short GetInt16(string name);
+        public int GetInt32(string name);
+        public long GetInt64(string name);
+        public sbyte GetSByte(string name);
+        public float GetSingle(string name);
+        public string GetString(string name);
+        public ushort GetUInt16(string name);
+        public uint GetUInt32(string name);
+        public ulong GetUInt64(string name);
+        public object GetValue(string name, Type type);
+        public void SetType(Type type);
+    }
+    public sealed class SerializationInfoEnumerator : IEnumerator {
+        public SerializationEntry Current { get; }
+        public string Name { get; }
+        public Type ObjectType { get; }
+        object System.Collections.IEnumerator.Current { get; }
+        public object Value { get; }
+        public bool MoveNext();
+        public void Reset();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct StreamingContext {
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public abstract class XmlObjectSerializer {
+        protected XmlObjectSerializer();
+        public abstract bool IsStartObject(XmlDictionaryReader reader);
+        public virtual bool IsStartObject(XmlReader reader);
+        public virtual object ReadObject(Stream stream);
+        public virtual object ReadObject(XmlDictionaryReader reader);
+        public abstract object ReadObject(XmlDictionaryReader reader, bool verifyObjectName);
+        public virtual object ReadObject(XmlReader reader);
+        public virtual object ReadObject(XmlReader reader, bool verifyObjectName);
+        public abstract void WriteEndObject(XmlDictionaryWriter writer);
+        public virtual void WriteEndObject(XmlWriter writer);
+        public virtual void WriteObject(Stream stream, object graph);
+        public virtual void WriteObject(XmlDictionaryWriter writer, object graph);
+        public virtual void WriteObject(XmlWriter writer, object graph);
+        public abstract void WriteObjectContent(XmlDictionaryWriter writer, object graph);
+        public virtual void WriteObjectContent(XmlWriter writer, object graph);
+        public abstract void WriteStartObject(XmlDictionaryWriter writer, object graph);
+        public virtual void WriteStartObject(XmlWriter writer, object graph);
+    }
+}
```

