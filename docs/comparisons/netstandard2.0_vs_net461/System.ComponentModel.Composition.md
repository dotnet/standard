# System.ComponentModel.Composition

``` diff
+namespace System.ComponentModel.Composition {
+    public static class AttributedModelServices {
+        public static ComposablePart AddExportedValue<T>(this CompositionBatch batch, string contractName, T exportedValue);
+        public static ComposablePart AddExportedValue<T>(this CompositionBatch batch, T exportedValue);
+        public static ComposablePart AddPart(this CompositionBatch batch, object attributedPart);
+        public static void ComposeExportedValue<T>(this CompositionContainer container, string contractName, T exportedValue);
+        public static void ComposeExportedValue<T>(this CompositionContainer container, T exportedValue);
+        public static void ComposeParts(this CompositionContainer container, params object[] attributedParts);
+        public static ComposablePart CreatePart(ComposablePartDefinition partDefinition, object attributedPart);
+        public static ComposablePart CreatePart(object attributedPart);
+        public static ComposablePart CreatePart(object attributedPart, ReflectionContext reflectionContext);
+        public static ComposablePartDefinition CreatePartDefinition(Type type, ICompositionElement origin);
+        public static ComposablePartDefinition CreatePartDefinition(Type type, ICompositionElement origin, bool ensureIsDiscoverable);
+        public static bool Exports(this ComposablePartDefinition part, Type contractType);
+        public static bool Exports<T>(this ComposablePartDefinition part);
+        public static string GetContractName(Type type);
+        public static TMetadataView GetMetadataView<TMetadataView>(IDictionary<string, object> metadata);
+        public static string GetTypeIdentity(MethodInfo method);
+        public static string GetTypeIdentity(Type type);
+        public static bool Imports(this ComposablePartDefinition part, Type contractType);
+        public static bool Imports(this ComposablePartDefinition part, Type contractType, ImportCardinality importCardinality);
+        public static bool Imports<T>(this ComposablePartDefinition part);
+        public static bool Imports<T>(this ComposablePartDefinition part, ImportCardinality importCardinality);
+        public static ComposablePart SatisfyImportsOnce(this ICompositionService compositionService, object attributedPart);
+        public static ComposablePart SatisfyImportsOnce(this ICompositionService compositionService, object attributedPart, ReflectionContext reflectionContext);
+    }
+    public class CatalogReflectionContextAttribute : Attribute {
+        public CatalogReflectionContextAttribute(Type reflectionContextType);
+        public ReflectionContext CreateReflectionContext();
+    }
+    public class ChangeRejectedException : CompositionException {
+        public ChangeRejectedException();
+        public ChangeRejectedException(IEnumerable<CompositionError> errors);
+        public ChangeRejectedException(string message);
+        public ChangeRejectedException(string message, Exception innerException);
+        public override string Message { get; }
+    }
+    public class CompositionContractMismatchException : Exception {
+        public CompositionContractMismatchException();
+        protected CompositionContractMismatchException(SerializationInfo info, StreamingContext context);
+        public CompositionContractMismatchException(string message);
+        public CompositionContractMismatchException(string message, Exception innerException);
+    }
+    public class CompositionError {
+        public CompositionError(string message);
+        public CompositionError(string message, ICompositionElement element);
+        public CompositionError(string message, ICompositionElement element, Exception exception);
+        public CompositionError(string message, Exception exception);
+        public string Description { get; }
+        public ICompositionElement Element { get; }
+        public Exception Exception { get; }
+        public override string ToString();
+    }
+    public class CompositionException : Exception {
+        public CompositionException();
+        public CompositionException(IEnumerable<CompositionError> errors);
+        public CompositionException(string message);
+        public CompositionException(string message, Exception innerException);
+        public ReadOnlyCollection<CompositionError> Errors { get; }
+        public override string Message { get; }
+        public ReadOnlyCollection<Exception> RootCauses { get; }
+    }
+    public enum CreationPolicy {
+        Any = 0,
+        NonShared = 2,
+        Shared = 1,
+    }
+    public class ExportAttribute : Attribute {
+        public ExportAttribute();
+        public ExportAttribute(string contractName);
+        public ExportAttribute(string contractName, Type contractType);
+        public ExportAttribute(Type contractType);
+        public string ContractName { get; private set; }
+        public Type ContractType { get; private set; }
+    }
+    public class ExportFactory<T> {
+        public ExportFactory(Func<Tuple<T, Action>> exportLifetimeContextCreator);
+        public ExportLifetimeContext<T> CreateExport();
+    }
+    public class ExportFactory<T, TMetadata> : ExportFactory<T> {
+        public ExportFactory(Func<Tuple<T, Action>> exportLifetimeContextCreator, TMetadata metadata);
+        public TMetadata Metadata { get; }
+    }
+    public sealed class ExportLifetimeContext<T> : IDisposable {
+        public ExportLifetimeContext(T value, Action disposeAction);
+        public T Value { get; }
+        public void Dispose();
+    }
+    public sealed class ExportMetadataAttribute : Attribute {
+        public ExportMetadataAttribute(string name, object value);
+        public bool IsMultiple { get; set; }
+        public string Name { get; private set; }
+        public object Value { get; private set; }
+    }
+    public interface ICompositionService {
+        void SatisfyImportsOnce(ComposablePart part);
+    }
+    public class ImportAttribute : Attribute, IAttributedImport {
+        public ImportAttribute();
+        public ImportAttribute(string contractName);
+        public ImportAttribute(string contractName, Type contractType);
+        public ImportAttribute(Type contractType);
+        public bool AllowDefault { get; set; }
+        public bool AllowRecomposition { get; set; }
+        public string ContractName { get; private set; }
+        public Type ContractType { get; private set; }
+        public CreationPolicy RequiredCreationPolicy { get; set; }
+        public ImportSource Source { get; set; }
+    }
+    public class ImportCardinalityMismatchException : Exception {
+        public ImportCardinalityMismatchException();
+        protected ImportCardinalityMismatchException(SerializationInfo info, StreamingContext context);
+        public ImportCardinalityMismatchException(string message);
+        public ImportCardinalityMismatchException(string message, Exception innerException);
+    }
+    public class ImportingConstructorAttribute : Attribute {
+        public ImportingConstructorAttribute();
+    }
+    public class ImportManyAttribute : Attribute, IAttributedImport {
+        public ImportManyAttribute();
+        public ImportManyAttribute(string contractName);
+        public ImportManyAttribute(string contractName, Type contractType);
+        public ImportManyAttribute(Type contractType);
+        public bool AllowRecomposition { get; set; }
+        public string ContractName { get; private set; }
+        public Type ContractType { get; private set; }
+        public CreationPolicy RequiredCreationPolicy { get; set; }
+        public ImportSource Source { get; set; }
+    }
+    public enum ImportSource {
+        Any = 0,
+        Local = 1,
+        NonLocal = 2,
+    }
+    public class InheritedExportAttribute : ExportAttribute {
+        public InheritedExportAttribute();
+        public InheritedExportAttribute(string contractName);
+        public InheritedExportAttribute(string contractName, Type contractType);
+        public InheritedExportAttribute(Type contractType);
+    }
+    public interface IPartImportsSatisfiedNotification {
+        void OnImportsSatisfied();
+    }
+    public sealed class MetadataAttributeAttribute : Attribute {
+        public MetadataAttributeAttribute();
+    }
+    public sealed class MetadataViewImplementationAttribute : Attribute {
+        public MetadataViewImplementationAttribute(Type implementationType);
+        public Type ImplementationType { get; private set; }
+    }
+    public sealed class PartCreationPolicyAttribute : Attribute {
+        public PartCreationPolicyAttribute(CreationPolicy creationPolicy);
+        public CreationPolicy CreationPolicy { get; private set; }
+    }
+    public sealed class PartMetadataAttribute : Attribute {
+        public PartMetadataAttribute(string name, object value);
+        public string Name { get; private set; }
+        public object Value { get; private set; }
+    }
+    public sealed class PartNotDiscoverableAttribute : Attribute {
+        public PartNotDiscoverableAttribute();
+    }
+}
```

