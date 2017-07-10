# System.Xml.Serialization.Configuration

``` diff
+namespace System.Xml.Serialization.Configuration {
+    public sealed class DateTimeSerializationSection : ConfigurationSection {
+        public DateTimeSerializationSection();
+        public DateTimeSerializationSection.DateTimeSerializationMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public enum DateTimeSerializationMode {
+            Default = 0,
+            Local = 2,
+            Roundtrip = 1,
+        }
+    }
+    public class RootedPathValidator : ConfigurationValidatorBase {
+        public RootedPathValidator();
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class SchemaImporterExtensionElement : ConfigurationElement {
+        public SchemaImporterExtensionElement();
+        public SchemaImporterExtensionElement(string name, string type);
+        public SchemaImporterExtensionElement(string name, Type type);
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Type Type { get; set; }
+    }
+    public sealed class SchemaImporterExtensionElementCollection : ConfigurationElementCollection {
+        public SchemaImporterExtensionElementCollection();
+        public SchemaImporterExtensionElement this[int index] { get; set; }
+        public new SchemaImporterExtensionElement this[string name] { get; set; }
+        public void Add(SchemaImporterExtensionElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(SchemaImporterExtensionElement element);
+        public void Remove(string name);
+        public void Remove(SchemaImporterExtensionElement element);
+        public void RemoveAt(int index);
+    }
+    public sealed class SchemaImporterExtensionsSection : ConfigurationSection {
+        public SchemaImporterExtensionsSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SchemaImporterExtensionElementCollection SchemaImporterExtensions { get; }
+        protected override void InitializeDefault();
+    }
+    public sealed class SerializationSectionGroup : ConfigurationSectionGroup {
+        public SerializationSectionGroup();
+        public DateTimeSerializationSection DateTimeSerialization { get; }
+        public SchemaImporterExtensionsSection SchemaImporterExtensions { get; }
+        public XmlSerializerSection XmlSerializer { get; }
+    }
+    public sealed class XmlSerializerSection : ConfigurationSection {
+        public XmlSerializerSection();
+        public bool CheckDeserializeAdvances { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string TempFilesLocation { get; set; }
+        public bool UseLegacySerializerGeneration { get; set; }
+    }
+}
```

