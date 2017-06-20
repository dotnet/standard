# System.Activities.Presentation.Metadata

``` diff
+namespace System.Activities.Presentation.Metadata {
+    public static class ActivityArgumentHelper {
+        public static void RegisterAccessorsGenerator(Type activityType, Func<Activity, IEnumerable<ArgumentAccessor>> argumentAccessorsGenerator);
+    }
+    public delegate void AttributeCallback(AttributeCallbackBuilder builder);
+    public sealed class AttributeCallbackBuilder {
+        public Type CallbackType { get; }
+        public void AddCustomAttributes(params Attribute[] attributes);
+        public void AddCustomAttributes(MemberDescriptor descriptor, params Attribute[] attributes);
+        public void AddCustomAttributes(MemberInfo member, params Attribute[] attributes);
+        public void AddCustomAttributes(string memberName, params Attribute[] attributes);
+        public void AddCustomAttributes(DependencyProperty dp, params Attribute[] attributes);
+    }
+    public sealed class AttributeTable {
+        public IEnumerable<Type> AttributedTypes { get; }
+        public bool ContainsAttributes(Type type);
+        public IEnumerable GetCustomAttributes(Type type);
+        public IEnumerable GetCustomAttributes(Type ownerType, MemberDescriptor descriptor);
+        public IEnumerable GetCustomAttributes(Type ownerType, MemberInfo member);
+        public IEnumerable GetCustomAttributes(Type ownerType, string memberName);
+        public IEnumerable GetCustomAttributes(Type ownerType, DependencyProperty dp);
+    }
+    public class AttributeTableBuilder {
+        public AttributeTableBuilder();
+        public void AddCallback(Type type, AttributeCallback callback);
+        public void AddCustomAttributes(Type type, params Attribute[] attributes);
+        public void AddCustomAttributes(Type ownerType, MemberDescriptor descriptor, params Attribute[] attributes);
+        public void AddCustomAttributes(Type ownerType, MemberInfo member, params Attribute[] attributes);
+        public void AddCustomAttributes(Type ownerType, string memberName, params Attribute[] attributes);
+        public void AddCustomAttributes(Type ownerType, DependencyProperty dp, params Attribute[] attributes);
+        public void AddTable(AttributeTable table);
+        public AttributeTable CreateTable();
+        public void ValidateTable();
+    }
+    public class AttributeTableValidationException : Exception {
+        public AttributeTableValidationException();
+        protected AttributeTableValidationException(SerializationInfo info, StreamingContext context);
+        public AttributeTableValidationException(string message);
+        public AttributeTableValidationException(string message, IEnumerable<string> validationErrors);
+        public AttributeTableValidationException(string message, Exception inner);
+        public AttributeTableValidationException(string message, Exception inner, IEnumerable<string> validationErrors);
+        public IEnumerable<string> ValidationErrors { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public interface IRegisterMetadata {
+        void Register();
+    }
+    public static class MetadataStore {
+        public static void AddAttributeTable(AttributeTable table);
+    }
+}
```

