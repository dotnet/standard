# System.Workflow.ComponentModel.Serialization

``` diff
+namespace System.Workflow.ComponentModel.Serialization {
+    public class ActivityCodeDomSerializationManager : IDesignerSerializationManager, IServiceProvider {
+        public ActivityCodeDomSerializationManager(IDesignerSerializationManager manager);
+        public ContextStack Context { get; }
+        public PropertyDescriptorCollection Properties { get; }
+        protected IDesignerSerializationManager SerializationManager { get; set; }
+        public event ResolveNameEventHandler ResolveName;
+        public event EventHandler SerializationComplete;
+        public void AddSerializationProvider(IDesignerSerializationProvider provider);
+        public object CreateInstance(Type type, ICollection arguments, string name, bool addToContainer);
+        public object GetInstance(string name);
+        public string GetName(object value);
+        public object GetSerializer(Type objectType, Type serializerType);
+        public object GetService(Type serviceType);
+        public Type GetType(string typeName);
+        public void RemoveSerializationProvider(IDesignerSerializationProvider provider);
+        public void ReportError(object errorInformation);
+        public void SetName(object instance, string name);
+    }
+    public class ActivityCodeDomSerializer : DependencyObjectCodeDomSerializer {
+        public static readonly DependencyProperty MarkupFileNameProperty;
+        public ActivityCodeDomSerializer();
+        public override object Serialize(IDesignerSerializationManager manager, object obj);
+    }
+    public class ActivityMarkupSerializer : WorkflowMarkupSerializer {
+        public static readonly DependencyProperty EndColumnProperty;
+        public static readonly DependencyProperty EndLineProperty;
+        public static readonly DependencyProperty StartColumnProperty;
+        public static readonly DependencyProperty StartLineProperty;
+        public ActivityMarkupSerializer();
+        protected override object CreateInstance(WorkflowMarkupSerializationManager serializationManager, Type type);
+        protected override void OnAfterSerialize(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected override void OnBeforeSerialize(WorkflowMarkupSerializationManager serializationManager, object obj);
+    }
+    public sealed class ActivitySurrogateSelector : SurrogateSelector {
+        public ActivitySurrogateSelector();
+        public static ActivitySurrogateSelector Default { get; }
+        public override ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
+    }
+    public class ActivityTypeCodeDomSerializer : TypeCodeDomSerializer {
+        public ActivityTypeCodeDomSerializer();
+        public override object Deserialize(IDesignerSerializationManager manager, CodeTypeDeclaration declaration);
+        protected override CodeMemberMethod GetInitializeMethod(IDesignerSerializationManager manager, CodeTypeDeclaration typeDecl, object value);
+        protected override CodeMemberMethod[] GetInitializeMethods(IDesignerSerializationManager manager, CodeTypeDeclaration typeDecl);
+        public override CodeTypeDeclaration Serialize(IDesignerSerializationManager manager, object root, ICollection members);
+    }
+    public class CompositeActivityMarkupSerializer : ActivityMarkupSerializer {
+        public CompositeActivityMarkupSerializer();
+    }
+    public sealed class ConstructorArgumentAttribute : Attribute {
+        public ConstructorArgumentAttribute(string argumentName);
+        public string ArgumentName { get; }
+    }
+    public sealed class ContentPropertyAttribute : Attribute {
+        public ContentPropertyAttribute();
+        public ContentPropertyAttribute(string name);
+        public string Name { get; }
+    }
+    public class DependencyObjectCodeDomSerializer : CodeDomSerializer {
+        public DependencyObjectCodeDomSerializer();
+        public override object Serialize(IDesignerSerializationManager manager, object obj);
+    }
+    public abstract class MarkupExtension {
+        protected MarkupExtension();
+        public abstract object ProvideValue(IServiceProvider provider);
+    }
+    public sealed class RuntimeNamePropertyAttribute : Attribute {
+        public RuntimeNamePropertyAttribute(string name);
+        public string Name { get; }
+    }
+    public class WorkflowMarkupSerializationException : Exception {
+        public WorkflowMarkupSerializationException();
+        protected WorkflowMarkupSerializationException(SerializationInfo info, StreamingContext context);
+        public WorkflowMarkupSerializationException(string message);
+        public WorkflowMarkupSerializationException(string message, Exception innerException);
+        public WorkflowMarkupSerializationException(string message, Exception innerException, int lineNumber, int columnNumber);
+        public WorkflowMarkupSerializationException(string message, int lineNumber, int columnNumber);
+        public int LineNumber { get; }
+        public int LinePosition { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class WorkflowMarkupSerializationManager : IDesignerSerializationManager, IServiceProvider {
+        public WorkflowMarkupSerializationManager(IDesignerSerializationManager manager);
+        public ContextStack Context { get; }
+        public Assembly LocalAssembly { get; set; }
+        protected internal IDesignerSerializationManager SerializationManager { get; set; }
+        PropertyDescriptorCollection System.ComponentModel.Design.Serialization.IDesignerSerializationManager.Properties { get; }
+        event ResolveNameEventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ResolveName;
+        event EventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SerializationComplete;
+        public void AddSerializationProvider(IDesignerSerializationProvider provider);
+        public object GetSerializer(Type objectType, Type serializerType);
+        public object GetService(Type serviceType);
+        public virtual Type GetType(string typeName);
+        public virtual Type GetType(XmlQualifiedName xmlQualifiedName);
+        public virtual XmlQualifiedName GetXmlQualifiedName(Type type, out string prefix);
+        public void RemoveSerializationProvider(IDesignerSerializationProvider provider);
+        public void ReportError(object errorInformation);
+        object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.CreateInstance(Type type, ICollection arguments, string name, bool addToContainer);
+        object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetInstance(string name);
+        string System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetName(object value);
+        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SetName(object instance, string name);
+    }
+    public class WorkflowMarkupSerializer {
+        public static readonly DependencyProperty ClrNamespacesProperty;
+        public static readonly DependencyProperty EventsProperty;
+        public static readonly DependencyProperty XClassProperty;
+        public static readonly DependencyProperty XCodeProperty;
+        public WorkflowMarkupSerializer();
+        protected internal virtual void AddChild(WorkflowMarkupSerializationManager serializationManager, object parentObject, object childObj);
+        protected internal virtual bool CanSerializeToString(WorkflowMarkupSerializationManager serializationManager, object value);
+        protected internal virtual void ClearChildren(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected virtual object CreateInstance(WorkflowMarkupSerializationManager serializationManager, Type type);
+        public object Deserialize(IDesignerSerializationManager serializationManager, XmlReader reader);
+        public object Deserialize(XmlReader reader);
+        protected internal virtual object DeserializeFromString(WorkflowMarkupSerializationManager serializationManager, Type propertyType, string value);
+        protected internal virtual IList GetChildren(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected internal virtual EventInfo[] GetEvents(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected internal virtual PropertyInfo[] GetProperties(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected virtual void OnAfterDeserialize(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected virtual void OnAfterSerialize(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected virtual void OnBeforeDeserialize(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected virtual void OnBeforeSerialize(WorkflowMarkupSerializationManager serializationManager, object obj);
+        public void Serialize(IDesignerSerializationManager serializationManager, XmlWriter writer, object obj);
+        public void Serialize(XmlWriter writer, object obj);
+        protected internal virtual string SerializeToString(WorkflowMarkupSerializationManager serializationManager, object value);
+        protected internal virtual bool ShouldSerializeValue(WorkflowMarkupSerializationManager serializationManager, object value);
+    }
+    public sealed class XmlnsDefinitionAttribute : Attribute {
+        public XmlnsDefinitionAttribute(string xmlNamespace, string clrNamespace);
+        public string AssemblyName { get; set; }
+        public string ClrNamespace { get; }
+        public string XmlNamespace { get; }
+    }
+    public sealed class XmlnsPrefixAttribute : Attribute {
+        public XmlnsPrefixAttribute(string xmlNamespace, string prefix);
+        public string Prefix { get; }
+        public string XmlNamespace { get; }
+    }
+}
```

