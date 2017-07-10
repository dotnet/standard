# System.Windows.Markup.Localizer

``` diff
+namespace System.Windows.Markup.Localizer {
+    public abstract class BamlLocalizabilityResolver {
+        protected BamlLocalizabilityResolver();
+        public abstract ElementLocalizability GetElementLocalizability(string assembly, string className);
+        public abstract LocalizabilityAttribute GetPropertyLocalizability(string assembly, string className, string property);
+        public abstract string ResolveAssemblyFromClass(string className);
+        public abstract string ResolveFormattingTagToClass(string formattingTag);
+    }
+    public class BamlLocalizableResource {
+        public BamlLocalizableResource();
+        public BamlLocalizableResource(string content, string comments, LocalizationCategory category, bool modifiable, bool readable);
+        public LocalizationCategory Category { get; set; }
+        public string Comments { get; set; }
+        public string Content { get; set; }
+        public bool Modifiable { get; set; }
+        public bool Readable { get; set; }
+        public override bool Equals(object other);
+        public override int GetHashCode();
+    }
+    public class BamlLocalizableResourceKey {
+        public BamlLocalizableResourceKey(string uid, string className, string propertyName);
+        public string AssemblyName { get; }
+        public string ClassName { get; }
+        public string PropertyName { get; }
+        public string Uid { get; }
+        public override bool Equals(object other);
+        public bool Equals(BamlLocalizableResourceKey other);
+        public override int GetHashCode();
+    }
+    public sealed class BamlLocalizationDictionary : ICollection, IDictionary, IEnumerable {
+        public BamlLocalizationDictionary();
+        public int Count { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public ICollection Keys { get; }
+        public BamlLocalizableResourceKey RootElementKey { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        object System.Collections.IDictionary.this[object key] { get; set; }
+        public BamlLocalizableResource this[BamlLocalizableResourceKey key] { get; set; }
+        public ICollection Values { get; }
+        public void Add(BamlLocalizableResourceKey key, BamlLocalizableResource value);
+        public void Clear();
+        public bool Contains(BamlLocalizableResourceKey key);
+        public void CopyTo(DictionaryEntry[] array, int arrayIndex);
+        public BamlLocalizationDictionaryEnumerator GetEnumerator();
+        public void Remove(BamlLocalizableResourceKey key);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        void System.Collections.IDictionary.Add(object key, object value);
+        bool System.Collections.IDictionary.Contains(object key);
+        IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
+        void System.Collections.IDictionary.Remove(object key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class BamlLocalizationDictionaryEnumerator : IDictionaryEnumerator, IEnumerator {
+        public DictionaryEntry Current { get; }
+        public DictionaryEntry Entry { get; }
+        public BamlLocalizableResourceKey Key { get; }
+        object System.Collections.IDictionaryEnumerator.Key { get; }
+        object System.Collections.IDictionaryEnumerator.Value { get; }
+        object System.Collections.IEnumerator.Current { get; }
+        public BamlLocalizableResource Value { get; }
+        public bool MoveNext();
+        public void Reset();
+    }
+    public class BamlLocalizer {
+        public BamlLocalizer(Stream source);
+        public BamlLocalizer(Stream source, BamlLocalizabilityResolver resolver);
+        public BamlLocalizer(Stream source, BamlLocalizabilityResolver resolver, TextReader comments);
+        public event BamlLocalizerErrorNotifyEventHandler ErrorNotify;
+        public BamlLocalizationDictionary ExtractResources();
+        protected virtual void OnErrorNotify(BamlLocalizerErrorNotifyEventArgs e);
+        public void UpdateBaml(Stream target, BamlLocalizationDictionary updates);
+    }
+    public enum BamlLocalizerError {
+        DuplicateElement = 1,
+        DuplicateUid = 0,
+        IncompleteElementPlaceholder = 2,
+        InvalidCommentingXml = 3,
+        InvalidLocalizationAttributes = 4,
+        InvalidLocalizationComments = 5,
+        InvalidUid = 6,
+        MismatchedElements = 7,
+        SubstitutionAsPlaintext = 8,
+        UidMissingOnChildElement = 9,
+        UnknownFormattingTag = 10,
+    }
+    public class BamlLocalizerErrorNotifyEventArgs : EventArgs {
+        public BamlLocalizerError Error { get; }
+        public BamlLocalizableResourceKey Key { get; }
+    }
+    public delegate void BamlLocalizerErrorNotifyEventHandler(object sender, BamlLocalizerErrorNotifyEventArgs e);
+    public class ElementLocalizability {
+        public ElementLocalizability();
+        public ElementLocalizability(string formattingTag, LocalizabilityAttribute attribute);
+        public LocalizabilityAttribute Attribute { get; set; }
+        public string FormattingTag { get; set; }
+    }
+}
```

