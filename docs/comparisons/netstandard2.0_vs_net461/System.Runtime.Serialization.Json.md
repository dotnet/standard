# System.Runtime.Serialization.Json

``` diff
 namespace System.Runtime.Serialization.Json {
     public sealed class DataContractJsonSerializer : XmlObjectSerializer {
+        public DataContractJsonSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation);
+        public DataContractJsonSerializer(Type type, string rootName, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation);
+        public DataContractJsonSerializer(Type type, XmlDictionaryString rootName, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation);
+        public IDataContractSurrogate DataContractSurrogate { get; }
     }
     public class DataContractJsonSerializerSettings {
+        public IDataContractSurrogate DataContractSurrogate { get; set; }
     }
 }
```

