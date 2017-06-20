# System.ComponentModel.Design.Serialization

``` diff
 namespace System.ComponentModel.Design.Serialization {
+    public abstract class BasicDesignerLoader : DesignerLoader, IDesignerLoaderService {
+        protected BasicDesignerLoader();
+        protected IDesignerLoaderHost LoaderHost { get; }
+        public override bool Loading { get; }
+        protected virtual bool Modified { get; set; }
+        protected object PropertyProvider { get; set; }
+        protected bool ReloadPending { get; }
+        public override void BeginLoad(IDesignerLoaderHost host);
+        public override void Dispose();
+        protected virtual bool EnableComponentNotification(bool enable);
+        public override void Flush();
+        protected object GetService(Type serviceType);
+        protected virtual void Initialize();
+        protected virtual bool IsReloadNeeded();
+        protected virtual void OnBeginLoad();
+        protected virtual void OnBeginUnload();
+        protected virtual void OnEndLoad(bool successful, ICollection errors);
+        protected virtual void OnModifying();
+        protected abstract void PerformFlush(IDesignerSerializationManager serializationManager);
+        protected abstract void PerformLoad(IDesignerSerializationManager serializationManager);
+        protected void Reload(BasicDesignerLoader.ReloadOptions flags);
+        protected virtual void ReportFlushErrors(ICollection errors);
+        protected void SetBaseComponentClassName(string name);
+        void System.ComponentModel.Design.Serialization.IDesignerLoaderService.AddLoadDependency();
+        void System.ComponentModel.Design.Serialization.IDesignerLoaderService.DependentLoadComplete(bool successful, ICollection errorCollection);
+        bool System.ComponentModel.Design.Serialization.IDesignerLoaderService.Reload();
+        protected enum ReloadOptions {
+            Default = 0,
+            Force = 2,
+            ModifyOnError = 1,
+            NoFlush = 4,
+        }
+    }
+    public sealed class CodeDomComponentSerializationService : ComponentSerializationService {
+        public CodeDomComponentSerializationService();
+        public CodeDomComponentSerializationService(IServiceProvider provider);
+        public override SerializationStore CreateStore();
+        public override ICollection Deserialize(SerializationStore store);
+        public override ICollection Deserialize(SerializationStore store, IContainer container);
+        public override void DeserializeTo(SerializationStore store, IContainer container, bool validateRecycledTypes, bool applyDefaults);
+        public override SerializationStore LoadStore(Stream stream);
+        public override void Serialize(SerializationStore store, object value);
+        public override void SerializeAbsolute(SerializationStore store, object value);
+        public override void SerializeMember(SerializationStore store, object owningObject, MemberDescriptor member);
+        public override void SerializeMemberAbsolute(SerializationStore store, object owningObject, MemberDescriptor member);
+    }
+    public abstract class CodeDomDesignerLoader : BasicDesignerLoader, IDesignerSerializationService, INameCreationService {
+        protected CodeDomDesignerLoader();
+        protected abstract CodeDomProvider CodeDomProvider { get; }
+        protected abstract ITypeResolutionService TypeResolutionService { get; }
+        public override void Dispose();
+        protected override void Initialize();
+        protected override bool IsReloadNeeded();
+        protected override void OnBeginLoad();
+        protected override void OnBeginUnload();
+        protected virtual void OnComponentRename(object component, string oldName, string newName);
+        protected override void OnEndLoad(bool successful, ICollection errors);
+        protected abstract CodeCompileUnit Parse();
+        protected override void PerformFlush(IDesignerSerializationManager manager);
+        protected override void PerformLoad(IDesignerSerializationManager manager);
+        ICollection System.ComponentModel.Design.Serialization.IDesignerSerializationService.Deserialize(object serializationData);
+        object System.ComponentModel.Design.Serialization.IDesignerSerializationService.Serialize(ICollection objects);
+        string System.ComponentModel.Design.Serialization.INameCreationService.CreateName(IContainer container, Type dataType);
+        bool System.ComponentModel.Design.Serialization.INameCreationService.IsValidName(string name);
+        void System.ComponentModel.Design.Serialization.INameCreationService.ValidateName(string name);
+        protected abstract void Write(CodeCompileUnit unit);
+    }
+    public enum CodeDomLocalizationModel {
+        None = 0,
+        PropertyAssignment = 1,
+        PropertyReflection = 2,
+    }
+    public sealed class CodeDomLocalizationProvider : IDesignerSerializationProvider, IDisposable {
+        public CodeDomLocalizationProvider(IServiceProvider provider, CodeDomLocalizationModel model);
+        public CodeDomLocalizationProvider(IServiceProvider provider, CodeDomLocalizationModel model, CultureInfo[] supportedCultures);
+        public void Dispose();
+        object System.ComponentModel.Design.Serialization.IDesignerSerializationProvider.GetSerializer(IDesignerSerializationManager manager, object currentSerializer, Type objectType, Type serializerType);
+    }
+    public class CodeDomSerializer : CodeDomSerializerBase {
+        public CodeDomSerializer();
+        public virtual object Deserialize(IDesignerSerializationManager manager, object codeObject);
+        protected object DeserializeStatementToInstance(IDesignerSerializationManager manager, CodeStatement statement);
+        public virtual string GetTargetComponentName(CodeStatement statement, CodeExpression expression, Type targetType);
+        public virtual object Serialize(IDesignerSerializationManager manager, object value);
+        public virtual object SerializeAbsolute(IDesignerSerializationManager manager, object value);
+        public virtual CodeStatementCollection SerializeMember(IDesignerSerializationManager manager, object owningObject, MemberDescriptor member);
+        public virtual CodeStatementCollection SerializeMemberAbsolute(IDesignerSerializationManager manager, object owningObject, MemberDescriptor member);
+        protected CodeExpression SerializeToReferenceExpression(IDesignerSerializationManager manager, object value);
+    }
+    public abstract class CodeDomSerializerBase {
+        protected object DeserializeExpression(IDesignerSerializationManager manager, string name, CodeExpression expression);
+        protected virtual object DeserializeInstance(IDesignerSerializationManager manager, Type type, object[] parameters, string name, bool addToContainer);
+        protected void DeserializePropertiesFromResources(IDesignerSerializationManager manager, object value, Attribute[] filter);
+        protected void DeserializeStatement(IDesignerSerializationManager manager, CodeStatement statement);
+        protected static AttributeCollection GetAttributesFromTypeHelper(IDesignerSerializationManager manager, Type type);
+        protected static AttributeCollection GetAttributesHelper(IDesignerSerializationManager manager, object instance);
+        protected static EventDescriptorCollection GetEventsHelper(IDesignerSerializationManager manager, object instance, Attribute[] attributes);
+        protected CodeExpression GetExpression(IDesignerSerializationManager manager, object value);
+        protected static PropertyDescriptorCollection GetPropertiesHelper(IDesignerSerializationManager manager, object instance, Attribute[] attributes);
+        protected static Type GetReflectionTypeFromTypeHelper(IDesignerSerializationManager manager, Type type);
+        protected static Type GetReflectionTypeHelper(IDesignerSerializationManager manager, object instance);
+        protected CodeDomSerializer GetSerializer(IDesignerSerializationManager manager, object value);
+        protected CodeDomSerializer GetSerializer(IDesignerSerializationManager manager, Type valueType);
+        protected static TypeDescriptionProvider GetTargetFrameworkProvider(IServiceProvider provider, object instance);
+        protected string GetUniqueName(IDesignerSerializationManager manager, object value);
+        protected bool IsSerialized(IDesignerSerializationManager manager, object value);
+        protected bool IsSerialized(IDesignerSerializationManager manager, object value, bool honorPreset);
+        protected CodeExpression SerializeCreationExpression(IDesignerSerializationManager manager, object value, out bool isComplete);
+        protected void SerializeEvent(IDesignerSerializationManager manager, CodeStatementCollection statements, object value, EventDescriptor descriptor);
+        protected void SerializeEvents(IDesignerSerializationManager manager, CodeStatementCollection statements, object value, params Attribute[] filter);
+        protected void SerializeProperties(IDesignerSerializationManager manager, CodeStatementCollection statements, object value, Attribute[] filter);
+        protected void SerializePropertiesToResources(IDesignerSerializationManager manager, CodeStatementCollection statements, object value, Attribute[] filter);
+        protected void SerializeProperty(IDesignerSerializationManager manager, CodeStatementCollection statements, object value, PropertyDescriptor propertyToSerialize);
+        protected void SerializeResource(IDesignerSerializationManager manager, string resourceName, object value);
+        protected void SerializeResourceInvariant(IDesignerSerializationManager manager, string resourceName, object value);
+        protected CodeExpression SerializeToExpression(IDesignerSerializationManager manager, object value);
+        protected CodeExpression SerializeToResourceExpression(IDesignerSerializationManager manager, object value);
+        protected CodeExpression SerializeToResourceExpression(IDesignerSerializationManager manager, object value, bool ensureInvariant);
+        protected void SetExpression(IDesignerSerializationManager manager, object value, CodeExpression expression);
+        protected void SetExpression(IDesignerSerializationManager manager, object value, CodeExpression expression, bool isPreset);
+    }
+    public class CodeDomSerializerException : SystemException {
+        public CodeDomSerializerException(Exception ex, CodeLinePragma linePragma);
+        public CodeDomSerializerException(Exception ex, IDesignerSerializationManager manager);
+        protected CodeDomSerializerException(SerializationInfo info, StreamingContext context);
+        public CodeDomSerializerException(string message, CodeLinePragma linePragma);
+        public CodeDomSerializerException(string message, IDesignerSerializationManager manager);
+        public CodeLinePragma LinePragma { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class CollectionCodeDomSerializer : CodeDomSerializer {
+        public CollectionCodeDomSerializer();
+        protected bool MethodSupportsSerialization(MethodInfo method);
+        public override object Serialize(IDesignerSerializationManager manager, object value);
+        protected virtual object SerializeCollection(IDesignerSerializationManager manager, CodeExpression targetExpression, Type targetType, ICollection originalCollection, ICollection valuesToSerialize);
+    }
+    public class DesignerSerializationManager : IDesignerSerializationManager, IServiceProvider {
+        public DesignerSerializationManager();
+        public DesignerSerializationManager(IServiceProvider provider);
+        public IContainer Container { get; set; }
+        public IList Errors { get; }
+        public bool PreserveNames { get; set; }
+        public object PropertyProvider { get; set; }
+        public bool RecycleInstances { get; set; }
+        ContextStack System.ComponentModel.Design.Serialization.IDesignerSerializationManager.Context { get; }
+        PropertyDescriptorCollection System.ComponentModel.Design.Serialization.IDesignerSerializationManager.Properties { get; }
+        public bool ValidateRecycledTypes { get; set; }
+        public event EventHandler SessionCreated;
+        public event EventHandler SessionDisposed;
+        event ResolveNameEventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ResolveName;
+        event EventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SerializationComplete;
+        protected virtual object CreateInstance(Type type, ICollection arguments, string name, bool addToContainer);
+        public IDisposable CreateSession();
+        public Type GetRuntimeType(string typeName);
+        public object GetSerializer(Type objectType, Type serializerType);
+        protected virtual object GetService(Type serviceType);
+        protected virtual Type GetType(string typeName);
+        protected virtual void OnResolveName(ResolveNameEventArgs e);
+        protected virtual void OnSessionCreated(EventArgs e);
+        protected virtual void OnSessionDisposed(EventArgs e);
+        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.AddSerializationProvider(IDesignerSerializationProvider provider);
+        object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.CreateInstance(Type type, ICollection arguments, string name, bool addToContainer);
+        object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetInstance(string name);
+        string System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetName(object value);
+        object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetSerializer(Type objectType, Type serializerType);
+        Type System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetType(string typeName);
+        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.RemoveSerializationProvider(IDesignerSerializationProvider provider);
+        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ReportError(object errorInformation);
+        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SetName(object instance, string name);
+        object System.IServiceProvider.GetService(Type serviceType);
+    }
+    public sealed class ExpressionContext {
+        public ExpressionContext(CodeExpression expression, Type expressionType, object owner);
+        public ExpressionContext(CodeExpression expression, Type expressionType, object owner, object presetValue);
+        public CodeExpression Expression { get; }
+        public Type ExpressionType { get; }
+        public object Owner { get; }
+        public object PresetValue { get; }
+    }
+    public interface ICodeDomDesignerReload {
+        bool ShouldReloadDesigner(CodeCompileUnit newTree);
+    }
+    public abstract class MemberCodeDomSerializer : CodeDomSerializerBase {
+        protected MemberCodeDomSerializer();
+        public abstract void Serialize(IDesignerSerializationManager manager, object value, MemberDescriptor descriptor, CodeStatementCollection statements);
+        public abstract bool ShouldSerialize(IDesignerSerializationManager manager, object value, MemberDescriptor descriptor);
+    }
+    public sealed class ObjectStatementCollection : IEnumerable {
+        public CodeStatementCollection this[object statementOwner] { get; }
+        public bool ContainsKey(object statementOwner);
+        public IDictionaryEnumerator GetEnumerator();
+        public void Populate(ICollection statementOwners);
+        public void Populate(object owner);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class RootContext {
+        public RootContext(CodeExpression expression, object value);
+        public CodeExpression Expression { get; }
+        public object Value { get; }
+    }
+    public sealed class SerializeAbsoluteContext {
+        public SerializeAbsoluteContext();
+        public SerializeAbsoluteContext(MemberDescriptor member);
+        public MemberDescriptor Member { get; }
+        public bool ShouldSerialize(MemberDescriptor member);
+    }
+    public sealed class StatementContext {
+        public StatementContext();
+        public ObjectStatementCollection StatementCollection { get; }
+    }
+    public class TypeCodeDomSerializer : CodeDomSerializerBase {
+        public TypeCodeDomSerializer();
+        public virtual object Deserialize(IDesignerSerializationManager manager, CodeTypeDeclaration declaration);
+        protected virtual CodeMemberMethod GetInitializeMethod(IDesignerSerializationManager manager, CodeTypeDeclaration declaration, object value);
+        protected virtual CodeMemberMethod[] GetInitializeMethods(IDesignerSerializationManager manager, CodeTypeDeclaration declaration);
+        public virtual CodeTypeDeclaration Serialize(IDesignerSerializationManager manager, object root, ICollection members);
+    }
 }
```

