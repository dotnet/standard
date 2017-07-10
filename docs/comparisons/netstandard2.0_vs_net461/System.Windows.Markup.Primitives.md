# System.Windows.Markup.Primitives

``` diff
+namespace System.Windows.Markup.Primitives {
+    public abstract class MarkupObject {
+        public abstract AttributeCollection Attributes { get; }
+        public abstract object Instance { get; }
+        public abstract Type ObjectType { get; }
+        public virtual IEnumerable<MarkupProperty> Properties { get; }
+        public abstract void AssignRootContext(IValueSerializerContext context);
+    }
+    public abstract class MarkupProperty {
+        public abstract AttributeCollection Attributes { get; }
+        public virtual DependencyProperty DependencyProperty { get; }
+        public virtual bool IsAttached { get; }
+        public virtual bool IsComposite { get; }
+        public virtual bool IsConstructorArgument { get; }
+        public virtual bool IsContent { get; }
+        public virtual bool IsKey { get; }
+        public virtual bool IsValueAsString { get; }
+        public abstract IEnumerable<MarkupObject> Items { get; }
+        public abstract string Name { get; }
+        public virtual PropertyDescriptor PropertyDescriptor { get; }
+        public abstract Type PropertyType { get; }
+        public abstract string StringValue { get; }
+        public abstract IEnumerable<Type> TypeReferences { get; }
+        public abstract object Value { get; }
+    }
+    public sealed class MarkupWriter : IDisposable {
+        public void Dispose();
+        public static MarkupObject GetMarkupObjectFor(object instance);
+        public static MarkupObject GetMarkupObjectFor(object instance, XamlDesignerSerializationManager manager);
+    }
+}
```

