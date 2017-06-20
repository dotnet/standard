# System.Workflow.Runtime.Configuration

``` diff
+namespace System.Workflow.Runtime.Configuration {
+    public class WorkflowRuntimeSection : ConfigurationSection {
+        public WorkflowRuntimeSection();
+        public NameValueConfigurationCollection CommonParameters { get; }
+        public bool EnablePerformanceCounters { get; set; }
+        public string Name { get; set; }
+        public WorkflowRuntimeServiceElementCollection Services { get; }
+        public bool ValidateOnCreate { get; set; }
+        public int WorkflowDefinitionCacheCapacity { get; set; }
+    }
+    public class WorkflowRuntimeServiceElement : ConfigurationElement {
+        public WorkflowRuntimeServiceElement();
+        public NameValueCollection Parameters { get; }
+        public string Type { get; set; }
+        protected override bool OnDeserializeUnrecognizedAttribute(string name, string value);
+    }
+    public class WorkflowRuntimeServiceElementCollection : ConfigurationElementCollection {
+        public WorkflowRuntimeServiceElementCollection();
+        public void Add(WorkflowRuntimeServiceElement serviceSettings);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement settings);
+    }
+}
```

