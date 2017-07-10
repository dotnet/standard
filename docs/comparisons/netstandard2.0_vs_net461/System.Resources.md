# System.Resources

``` diff
 namespace System.Resources {
     public class ResourceManager {
+        protected Hashtable ResourceSets;
+        protected string BaseNameField;
     }
     public class ResourceSet : IDisposable, IEnumerable {
+        protected Hashtable Table;
+        protected IResourceReader Reader;
     }
+    public sealed class ResXDataNode : ISerializable {
+        public ResXDataNode(string name, object value);
+        public ResXDataNode(string name, object value, Func<Type, string> typeNameConverter);
+        public ResXDataNode(string name, ResXFileRef fileRef);
+        public ResXDataNode(string name, ResXFileRef fileRef, Func<Type, string> typeNameConverter);
+        public string Comment { get; set; }
+        public ResXFileRef FileRef { get; }
+        public string Name { get; set; }
+        public Point GetNodePosition();
+        public object GetValue(ITypeResolutionService typeResolver);
+        public object GetValue(AssemblyName[] names);
+        public string GetValueTypeName(ITypeResolutionService typeResolver);
+        public string GetValueTypeName(AssemblyName[] names);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+    }
+    public class ResXFileRef {
+        public ResXFileRef(string fileName, string typeName);
+        public ResXFileRef(string fileName, string typeName, Encoding textFileEncoding);
+        public string FileName { get; }
+        public Encoding TextFileEncoding { get; }
+        public string TypeName { get; }
+        public override string ToString();
+        public class Converter : TypeConverter {
+            public Converter();
+            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        }
+    }
+    public class ResXResourceReader : IDisposable, IEnumerable, IResourceReader {
+        public ResXResourceReader(Stream stream);
+        public ResXResourceReader(Stream stream, ITypeResolutionService typeResolver);
+        public ResXResourceReader(Stream stream, AssemblyName[] assemblyNames);
+        public ResXResourceReader(TextReader reader);
+        public ResXResourceReader(TextReader reader, ITypeResolutionService typeResolver);
+        public ResXResourceReader(TextReader reader, AssemblyName[] assemblyNames);
+        public ResXResourceReader(string fileName);
+        public ResXResourceReader(string fileName, ITypeResolutionService typeResolver);
+        public ResXResourceReader(string fileName, AssemblyName[] assemblyNames);
+        public string BasePath { get; set; }
+        public bool UseResXDataNodes { get; set; }
+        public void Close();
+        protected virtual void Dispose(bool disposing);
+        ~ResXResourceReader();
+        public static ResXResourceReader FromFileContents(string fileContents);
+        public static ResXResourceReader FromFileContents(string fileContents, ITypeResolutionService typeResolver);
+        public static ResXResourceReader FromFileContents(string fileContents, AssemblyName[] assemblyNames);
+        public IDictionaryEnumerator GetEnumerator();
+        public IDictionaryEnumerator GetMetadataEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.IDisposable.Dispose();
+    }
+    public class ResXResourceSet : ResourceSet {
+        public ResXResourceSet(Stream stream);
+        public ResXResourceSet(string fileName);
+        public override Type GetDefaultReader();
+        public override Type GetDefaultWriter();
+    }
+    public class ResXResourceWriter : IDisposable, IResourceWriter {
+        public static readonly string BinSerializedObjectMimeType;
+        public static readonly string ByteArraySerializedObjectMimeType;
+        public static readonly string DefaultSerializedObjectMimeType;
+        public static readonly string ResMimeType;
+        public static readonly string ResourceSchema;
+        public static readonly string SoapSerializedObjectMimeType;
+        public static readonly string Version;
+        public ResXResourceWriter(Stream stream);
+        public ResXResourceWriter(Stream stream, Func<Type, string> typeNameConverter);
+        public ResXResourceWriter(TextWriter textWriter);
+        public ResXResourceWriter(TextWriter textWriter, Func<Type, string> typeNameConverter);
+        public ResXResourceWriter(string fileName);
+        public ResXResourceWriter(string fileName, Func<Type, string> typeNameConverter);
+        public string BasePath { get; set; }
+        public virtual void AddAlias(string aliasName, AssemblyName assemblyName);
+        public void AddMetadata(string name, byte[] value);
+        public void AddMetadata(string name, object value);
+        public void AddMetadata(string name, string value);
+        public void AddResource(ResXDataNode node);
+        public void AddResource(string name, byte[] value);
+        public void AddResource(string name, object value);
+        public void AddResource(string name, string value);
+        public void Close();
+        public virtual void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~ResXResourceWriter();
+        public void Generate();
+    }
 }
```

