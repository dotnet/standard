# System.Runtime.Serialization.Configuration

``` diff
+namespace System.Runtime.Serialization.Configuration {
+    public sealed class DataContractSerializerSection : ConfigurationSection {
+        public DataContractSerializerSection();
+        public DeclaredTypeElementCollection DeclaredTypes { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class DeclaredTypeElement : ConfigurationElement {
+        public DeclaredTypeElement();
+        public DeclaredTypeElement(string typeName);
+        public TypeElementCollection KnownTypes { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+        protected override void PostDeserialize();
+    }
+    public sealed class DeclaredTypeElementCollection : ConfigurationElementCollection {
+        public DeclaredTypeElementCollection();
+        public DeclaredTypeElement this[int index] { get; set; }
+        public new DeclaredTypeElement this[string typeName] { get; set; }
+        public void Add(DeclaredTypeElement element);
+        public void Clear();
+        public bool Contains(string typeName);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(DeclaredTypeElement element);
+        public void Remove(DeclaredTypeElement element);
+        public void Remove(string typeName);
+        public void RemoveAt(int index);
+    }
+    public sealed class NetDataContractSerializerSection : ConfigurationSection {
+        public NetDataContractSerializerSection();
+        public bool EnableUnsafeTypeForwarding { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ParameterElement : ConfigurationElement {
+        public ParameterElement();
+        public ParameterElement(int index);
+        public ParameterElement(string typeName);
+        public int Index { get; set; }
+        public ParameterElementCollection Parameters { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+        protected override void PostDeserialize();
+        protected override void PreSerialize(XmlWriter writer);
+    }
+    public sealed class ParameterElementCollection : ConfigurationElementCollection {
+        public ParameterElementCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        public ParameterElement this[int index] { get; set; }
+        public void Add(ParameterElement element);
+        public void Clear();
+        public bool Contains(string typeName);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(ParameterElement element);
+        public void Remove(ParameterElement element);
+        public void RemoveAt(int index);
+    }
+    public sealed class SerializationSectionGroup : ConfigurationSectionGroup {
+        public SerializationSectionGroup();
+        public DataContractSerializerSection DataContractSerializer { get; }
+        public NetDataContractSerializerSection NetDataContractSerializer { get; }
+        public static SerializationSectionGroup GetSectionGroup(Configuration config);
+    }
+    public sealed class TypeElement : ConfigurationElement {
+        public TypeElement();
+        public TypeElement(string typeName);
+        public int Index { get; set; }
+        public ParameterElementCollection Parameters { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class TypeElementCollection : ConfigurationElementCollection {
+        public TypeElementCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        public TypeElement this[int index] { get; set; }
+        public void Add(TypeElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(TypeElement element);
+        public void Remove(TypeElement element);
+        public void RemoveAt(int index);
+    }
+}
```

