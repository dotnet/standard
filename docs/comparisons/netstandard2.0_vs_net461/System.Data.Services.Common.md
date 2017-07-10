# System.Data.Services.Common

``` diff
+namespace System.Data.Services.Common {
+    public sealed class DataServiceEntityAttribute : Attribute {
+        public DataServiceEntityAttribute();
+    }
+    public sealed class DataServiceKeyAttribute : Attribute {
+        public DataServiceKeyAttribute(string keyName);
+        public DataServiceKeyAttribute(params string[] keyNames);
+        public ReadOnlyCollection<string> KeyNames { get; }
+    }
+    public enum DataServiceProtocolVersion {
+        V1 = 0,
+        V2 = 1,
+    }
+    public sealed class EntityPropertyMappingAttribute : Attribute {
+        public EntityPropertyMappingAttribute(string sourcePath, SyndicationItemProperty targetSyndicationItem, SyndicationTextContentKind targetTextContentKind, bool keepInContent);
+        public EntityPropertyMappingAttribute(string sourcePath, string targetPath, string targetNamespacePrefix, string targetNamespaceUri, bool keepInContent);
+        public bool KeepInContent { get; }
+        public string SourcePath { get; }
+        public string TargetNamespacePrefix { get; }
+        public string TargetNamespaceUri { get; }
+        public string TargetPath { get; }
+        public SyndicationItemProperty TargetSyndicationItem { get; }
+        public SyndicationTextContentKind TargetTextContentKind { get; }
+    }
+    public sealed class EntitySetAttribute : Attribute {
+        public EntitySetAttribute(string entitySet);
+        public string EntitySet { get; }
+    }
+    public sealed class HasStreamAttribute : Attribute {
+        public HasStreamAttribute();
+    }
+    public enum SyndicationItemProperty {
+        AuthorEmail = 1,
+        AuthorName = 2,
+        AuthorUri = 3,
+        ContributorEmail = 4,
+        ContributorName = 5,
+        ContributorUri = 6,
+        CustomProperty = 0,
+        Published = 8,
+        Rights = 9,
+        Summary = 10,
+        Title = 11,
+        Updated = 7,
+    }
+    public enum SyndicationTextContentKind {
+        Html = 1,
+        Plaintext = 0,
+        Xhtml = 2,
+    }
+}
```

