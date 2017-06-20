# System.Web.ModelBinding

``` diff
+namespace System.Web.ModelBinding {
+    public class ArrayModelBinder<TElement> : CollectionModelBinder<TElement> {
+        public ArrayModelBinder();
+        protected override bool CreateOrReplaceCollection(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext, IList<TElement> newCollection);
+    }
+    public sealed class ArrayModelBinderProvider : ModelBinderProvider {
+        public ArrayModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public abstract class AssociatedMetadataProvider : ModelMetadataProvider {
+        protected AssociatedMetadataProvider();
+        protected abstract ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName);
+        protected virtual IEnumerable<Attribute> FilterAttributes(Type containerType, PropertyDescriptor propertyDescriptor, IEnumerable<Attribute> attributes);
+        public override IEnumerable<ModelMetadata> GetMetadataForProperties(object container, Type containerType);
+        protected virtual ModelMetadata GetMetadataForProperty(Func<object> modelAccessor, Type containerType, PropertyDescriptor propertyDescriptor);
+        public override ModelMetadata GetMetadataForProperty(Func<object> modelAccessor, Type containerType, string propertyName);
+        public override ModelMetadata GetMetadataForType(Func<object> modelAccessor, Type modelType);
+        protected virtual ICustomTypeDescriptor GetTypeDescriptor(Type type);
+    }
+    public abstract class AssociatedValidatorProvider : ModelValidatorProvider {
+        protected AssociatedValidatorProvider();
+        protected virtual ICustomTypeDescriptor GetTypeDescriptor(Type type);
+        public sealed override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ModelBindingExecutionContext context);
+        protected abstract IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ModelBindingExecutionContext context, IEnumerable<Attribute> attributes);
+    }
+    public sealed class BinaryDataModelBinderProvider : ModelBinderProvider {
+        public BinaryDataModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public enum BindingBehavior {
+        Never = 1,
+        Optional = 0,
+        Required = 2,
+    }
+    public class BindingBehaviorAttribute : Attribute {
+        public BindingBehaviorAttribute(BindingBehavior behavior);
+        public BindingBehavior Behavior { get; private set; }
+        public override object TypeId { get; }
+    }
+    public sealed class BindNeverAttribute : BindingBehaviorAttribute {
+        public BindNeverAttribute();
+    }
+    public sealed class BindRequiredAttribute : BindingBehaviorAttribute {
+        public BindRequiredAttribute();
+    }
+    public class CollectionModelBinder<TElement> : IModelBinder {
+        public CollectionModelBinder();
+        public virtual bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+        protected virtual bool CreateOrReplaceCollection(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext, IList<TElement> newCollection);
+    }
+    public sealed class CollectionModelBinderProvider : ModelBinderProvider {
+        public CollectionModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public class ComplexModel {
+        public ComplexModel(ModelMetadata modelMetadata, IEnumerable<ModelMetadata> propertyMetadata);
+        public ModelMetadata ModelMetadata { get; private set; }
+        public ReadOnlyCollection<ModelMetadata> PropertyMetadata { get; private set; }
+        public IDictionary<ModelMetadata, ComplexModelResult> Results { get; private set; }
+    }
+    public sealed class ComplexModelBinder : IModelBinder {
+        public ComplexModelBinder();
+        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public sealed class ComplexModelBinderProvider : ModelBinderProvider {
+        public ComplexModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public sealed class ComplexModelResult {
+        public ComplexModelResult(object model, ModelValidationNode validationNode);
+        public object Model { get; private set; }
+        public ModelValidationNode ValidationNode { get; private set; }
+    }
+    public sealed class ControlAttribute : ValueProviderSourceAttribute {
+        public ControlAttribute();
+        public ControlAttribute(string controlID);
+        public ControlAttribute(string controlID, string propertyName);
+        public string ControlID { get; private set; }
+        public string PropertyName { get; private set; }
+        public override string GetModelName();
+        public override IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class ControlValueProvider : SimpleValueProvider {
+        public ControlValueProvider(ModelBindingExecutionContext modelBindingExecutionContext, string propertyName);
+        public string PropertyName { get; private set; }
+        protected override object FetchValue(string controlId);
+    }
+    public sealed class CookieAttribute : ValueProviderSourceAttribute, IUnvalidatedValueProviderSource, IValueProviderSource {
+        public CookieAttribute();
+        public CookieAttribute(string name);
+        public string Name { get; private set; }
+        public bool ValidateInput { get; set; }
+        public override string GetModelName();
+        public override IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class CookieValueProvider : IUnvalidatedValueProvider, IValueProvider {
+        public CookieValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+        public bool ContainsPrefix(string prefix);
+        public ValueProviderResult GetValue(string key);
+        public ValueProviderResult GetValue(string key, bool skipValidation);
+    }
+    public class DataAnnotationsModelMetadata : ModelMetadata {
+        public DataAnnotationsModelMetadata(DataAnnotationsModelMetadataProvider provider, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName, DisplayColumnAttribute displayColumnAttribute);
+        protected override string GetSimpleDisplayText();
+    }
+    public class DataAnnotationsModelMetadataProvider : AssociatedMetadataProvider {
+        public DataAnnotationsModelMetadataProvider();
+        protected override ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName);
+    }
+    public delegate ModelValidator DataAnnotationsModelValidationFactory(ModelMetadata metadata, ModelBindingExecutionContext context, ValidationAttribute attribute);
+    public class DataAnnotationsModelValidator : ModelValidator {
+        public DataAnnotationsModelValidator(ModelMetadata metadata, ModelBindingExecutionContext context, ValidationAttribute attribute);
+        protected internal ValidationAttribute Attribute { get; private set; }
+        protected internal string ErrorMessage { get; }
+        public override bool IsRequired { get; }
+        public override IEnumerable<ModelValidationResult> Validate(object container);
+    }
+    public class DataAnnotationsModelValidator<TAttribute> : DataAnnotationsModelValidator where TAttribute : ValidationAttribute {
+        public DataAnnotationsModelValidator(ModelMetadata metadata, ModelBindingExecutionContext context, TAttribute attribute);
+        protected new TAttribute Attribute { get; }
+    }
+    public class DataAnnotationsModelValidatorProvider : AssociatedValidatorProvider {
+        public DataAnnotationsModelValidatorProvider();
+        public static bool AddImplicitRequiredAttributeForValueTypes { get; set; }
+        protected override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ModelBindingExecutionContext context, IEnumerable<Attribute> attributes);
+        public static void RegisterAdapter(Type attributeType, Type adapterType);
+        public static void RegisterAdapterFactory(Type attributeType, DataAnnotationsModelValidationFactory factory);
+        public static void RegisterDefaultAdapter(Type adapterType);
+        public static void RegisterDefaultAdapterFactory(DataAnnotationsModelValidationFactory factory);
+        public static void RegisterDefaultValidatableObjectAdapter(Type adapterType);
+        public static void RegisterDefaultValidatableObjectAdapterFactory(DataAnnotationsValidatableObjectAdapterFactory factory);
+        public static void RegisterValidatableObjectAdapter(Type modelType, Type adapterType);
+        public static void RegisterValidatableObjectAdapterFactory(Type modelType, DataAnnotationsValidatableObjectAdapterFactory factory);
+    }
+    public delegate ModelValidator DataAnnotationsValidatableObjectAdapterFactory(ModelMetadata metadata, ModelBindingExecutionContext context);
+    public class DefaultModelBinder : IModelBinder {
+        public DefaultModelBinder();
+        public ModelBinderProviderCollection Providers { get; private set; }
+        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public class DictionaryModelBinder<TKey, TValue> : CollectionModelBinder<KeyValuePair<TKey, TValue>> {
+        public DictionaryModelBinder();
+        protected override bool CreateOrReplaceCollection(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext, IList<KeyValuePair<TKey, TValue>> newCollection);
+    }
+    public sealed class DictionaryModelBinderProvider : ModelBinderProvider {
+        public DictionaryModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public class DictionaryValueProvider<TValue> : IValueProvider {
+        public DictionaryValueProvider(IDictionary<string, TValue> dictionary, CultureInfo culture);
+        public virtual bool ContainsPrefix(string prefix);
+        public virtual ValueProviderResult GetValue(string key);
+    }
+    public class EmptyModelMetadataProvider : AssociatedMetadataProvider {
+        public EmptyModelMetadataProvider();
+        protected override ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName);
+    }
+    public sealed class ExtensibleModelBinderAttribute : Attribute {
+        public ExtensibleModelBinderAttribute(Type binderType);
+        public Type BinderType { get; private set; }
+        public bool SuppressPrefixCheck { get; set; }
+    }
+    public sealed class FormAttribute : ValueProviderSourceAttribute, IUnvalidatedValueProviderSource, IValueProviderSource {
+        public FormAttribute();
+        public FormAttribute(string fieldName);
+        public string FieldName { get; private set; }
+        public bool ValidateInput { get; set; }
+        public override string GetModelName();
+        public override IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class FormValueProvider : NameValueCollectionValueProvider {
+        public FormValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class GenericModelBinderProvider : ModelBinderProvider {
+        public GenericModelBinderProvider(Type modelType, Func<Type[], IModelBinder> modelBinderFactory);
+        public GenericModelBinderProvider(Type modelType, Type modelBinderType);
+        public GenericModelBinderProvider(Type modelType, IModelBinder modelBinder);
+        public Type ModelType { get; }
+        public bool SuppressPrefixCheck { get; set; }
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public interface IMetadataAware {
+        void OnMetadataCreated(ModelMetadata metadata);
+    }
+    public interface IModelBinder {
+        bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public interface IModelNameProvider {
+        string GetModelName();
+    }
+    public interface IUnvalidatedValueProvider : IValueProvider {
+        ValueProviderResult GetValue(string key, bool skipValidation);
+    }
+    public interface IUnvalidatedValueProviderSource : IValueProviderSource {
+        bool ValidateInput { get; set; }
+    }
+    public interface IValueProvider {
+        bool ContainsPrefix(string prefix);
+        ValueProviderResult GetValue(string key);
+    }
+    public interface IValueProviderSource {
+        IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class KeyValuePairModelBinder<TKey, TValue> : IModelBinder {
+        public KeyValuePairModelBinder();
+        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public sealed class KeyValuePairModelBinderProvider : ModelBinderProvider {
+        public KeyValuePairModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public class ModelBinderDictionary : ICollection<KeyValuePair<Type, IModelBinder>>, IDictionary<Type, IModelBinder>, IEnumerable, IEnumerable<KeyValuePair<Type, IModelBinder>> {
+        public ModelBinderDictionary();
+        public int Count { get; }
+        public IModelBinder DefaultBinder { get; set; }
+        public bool IsReadOnly { get; }
+        public ICollection<Type> Keys { get; }
+        public IModelBinder this[Type key] { get; set; }
+        public ICollection<IModelBinder> Values { get; }
+        public void Add(KeyValuePair<Type, IModelBinder> item);
+        public void Add(Type key, IModelBinder value);
+        public void Clear();
+        public bool Contains(KeyValuePair<Type, IModelBinder> item);
+        public bool ContainsKey(Type key);
+        public void CopyTo(KeyValuePair<Type, IModelBinder>[] array, int arrayIndex);
+        public IEnumerator<KeyValuePair<Type, IModelBinder>> GetEnumerator();
+        public bool Remove(KeyValuePair<Type, IModelBinder> item);
+        public bool Remove(Type key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(Type key, out IModelBinder value);
+    }
+    public delegate string ModelBinderErrorMessageProvider(ModelBindingExecutionContext modelBindingExecutionContext, ModelMetadata modelMetadata, object incomingValue);
+    public static class ModelBinderErrorMessageProviders {
+        public static ModelBinderErrorMessageProvider TypeConversionErrorMessageProvider { get; set; }
+        public static ModelBinderErrorMessageProvider ValueRequiredErrorMessageProvider { get; set; }
+    }
+    public abstract class ModelBinderProvider {
+        protected ModelBinderProvider();
+        public abstract IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public sealed class ModelBinderProviderCollection : Collection<ModelBinderProvider> {
+        public ModelBinderProviderCollection();
+        public ModelBinderProviderCollection(IList<ModelBinderProvider> list);
+        public IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+        protected override void InsertItem(int index, ModelBinderProvider item);
+        public void RegisterBinderForGenericType(Type modelType, Func<Type[], IModelBinder> modelBinderFactory);
+        public void RegisterBinderForGenericType(Type modelType, Type modelBinderType);
+        public void RegisterBinderForGenericType(Type modelType, IModelBinder modelBinder);
+        public void RegisterBinderForType(Type modelType, Func<IModelBinder> modelBinderFactory);
+        public void RegisterBinderForType(Type modelType, IModelBinder modelBinder);
+        protected override void SetItem(int index, ModelBinderProvider item);
+    }
+    public sealed class ModelBinderProviderOptionsAttribute : Attribute {
+        public ModelBinderProviderOptionsAttribute();
+        public bool FrontOfList { get; set; }
+    }
+    public static class ModelBinderProviders {
+        public static ModelBinderProviderCollection Providers { get; }
+    }
+    public static class ModelBinders {
+        public static ModelBinderDictionary Binders { get; }
+    }
+    public class ModelBindingContext {
+        public ModelBindingContext();
+        public ModelBindingContext(ModelBindingContext bindingContext);
+        public object Model { get; set; }
+        public ModelBinderProviderCollection ModelBinderProviders { get; set; }
+        public ModelMetadata ModelMetadata { get; set; }
+        public string ModelName { get; set; }
+        public ModelStateDictionary ModelState { get; set; }
+        public Type ModelType { get; }
+        public IDictionary<string, ModelMetadata> PropertyMetadata { get; }
+        public bool ValidateRequest { get; set; }
+        public ModelValidationNode ValidationNode { get; set; }
+        public IValueProvider ValueProvider { get; set; }
+    }
+    public class ModelBindingExecutionContext {
+        public ModelBindingExecutionContext(HttpContextBase httpContext, ModelStateDictionary modelState);
+        public virtual HttpContextBase HttpContext { get; }
+        public virtual ModelStateDictionary ModelState { get; }
+        public virtual TService GetService<TService>();
+        public virtual void PublishService<TService>(TService service);
+        public virtual TService TryGetService<TService>();
+    }
+    public class ModelError {
+        public ModelError(Exception exception);
+        public ModelError(Exception exception, string errorMessage);
+        public ModelError(string errorMessage);
+        public string ErrorMessage { get; private set; }
+        public Exception Exception { get; private set; }
+    }
+    public class ModelErrorCollection : Collection<ModelError> {
+        public ModelErrorCollection();
+        public void Add(Exception exception);
+        public void Add(string errorMessage);
+    }
+    public class ModelMetadata {
+        public const int DefaultOrder = 10000;
+        public ModelMetadata(ModelMetadataProvider provider, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName);
+        public virtual Dictionary<string, object> AdditionalValues { get; }
+        public Type ContainerType { get; }
+        public virtual bool ConvertEmptyStringToNull { get; set; }
+        public virtual string DataTypeName { get; set; }
+        public virtual string Description { get; set; }
+        public virtual string DisplayFormatString { get; set; }
+        public virtual string DisplayName { get; set; }
+        public virtual string EditFormatString { get; set; }
+        public virtual bool HideSurroundingHtml { get; set; }
+        public virtual bool IsComplexType { get; }
+        public bool IsNullableValueType { get; }
+        public virtual bool IsReadOnly { get; set; }
+        public virtual bool IsRequired { get; set; }
+        public object Model { get; set; }
+        public Type ModelType { get; }
+        public virtual string NullDisplayText { get; set; }
+        public virtual int Order { get; set; }
+        public virtual IEnumerable<ModelMetadata> Properties { get; }
+        public string PropertyName { get; }
+        protected ModelMetadataProvider Provider { get; set; }
+        public virtual bool RequestValidationEnabled { get; set; }
+        public virtual string ShortDisplayName { get; set; }
+        public virtual bool ShowForDisplay { get; set; }
+        public virtual bool ShowForEdit { get; set; }
+        public virtual string SimpleDisplayText { get; set; }
+        public virtual string TemplateHint { get; set; }
+        public virtual string Watermark { get; set; }
+        public string GetDisplayName();
+        protected virtual string GetSimpleDisplayText();
+        public virtual IEnumerable<ModelValidator> GetValidators(ModelBindingExecutionContext context);
+    }
+    public abstract class ModelMetadataProvider {
+        protected ModelMetadataProvider();
+        public abstract IEnumerable<ModelMetadata> GetMetadataForProperties(object container, Type containerType);
+        public abstract ModelMetadata GetMetadataForProperty(Func<object> modelAccessor, Type containerType, string propertyName);
+        public abstract ModelMetadata GetMetadataForType(Func<object> modelAccessor, Type modelType);
+    }
+    public static class ModelMetadataProviders {
+        public static ModelMetadataProvider Current { get; set; }
+    }
+    public class ModelState {
+        public ModelState();
+        public ModelErrorCollection Errors { get; }
+        public ValueProviderResult Value { get; set; }
+    }
+    public class ModelStateDictionary : ICollection<KeyValuePair<string, ModelState>>, IDictionary<string, ModelState>, IEnumerable, IEnumerable<KeyValuePair<string, ModelState>> {
+        public ModelStateDictionary();
+        public ModelStateDictionary(ModelStateDictionary dictionary);
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsValid { get; }
+        public ICollection<string> Keys { get; }
+        public ModelState this[string key] { get; set; }
+        public ICollection<ModelState> Values { get; }
+        public void Add(KeyValuePair<string, ModelState> item);
+        public void Add(string key, ModelState value);
+        public void AddModelError(string key, Exception exception);
+        public void AddModelError(string key, string errorMessage);
+        public void Clear();
+        public bool Contains(KeyValuePair<string, ModelState> item);
+        public bool ContainsKey(string key);
+        public void CopyTo(KeyValuePair<string, ModelState>[] array, int arrayIndex);
+        public IEnumerator<KeyValuePair<string, ModelState>> GetEnumerator();
+        public bool IsValidField(string key);
+        public void Merge(ModelStateDictionary dictionary);
+        public bool Remove(KeyValuePair<string, ModelState> item);
+        public bool Remove(string key);
+        public void SetModelValue(string key, ValueProviderResult value);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(string key, out ModelState value);
+    }
+    public sealed class ModelValidatedEventArgs : EventArgs {
+        public ModelValidatedEventArgs(ModelBindingExecutionContext modelBindingExecutionContext, ModelValidationNode parentNode);
+        public ModelBindingExecutionContext ModelBindingExecutionContext { get; private set; }
+        public ModelValidationNode ParentNode { get; private set; }
+    }
+    public sealed class ModelValidatingEventArgs : CancelEventArgs {
+        public ModelValidatingEventArgs(ModelBindingExecutionContext modelBindingExecutionContext, ModelValidationNode parentNode);
+        public ModelBindingExecutionContext ModelBindingExecutionContext { get; private set; }
+        public ModelValidationNode ParentNode { get; private set; }
+    }
+    public sealed class ModelValidationNode {
+        public ModelValidationNode(ModelMetadata modelMetadata, string modelStateKey);
+        public ModelValidationNode(ModelMetadata modelMetadata, string modelStateKey, IEnumerable<ModelValidationNode> childNodes);
+        public ICollection<ModelValidationNode> ChildNodes { get; private set; }
+        public ModelMetadata ModelMetadata { get; private set; }
+        public string ModelStateKey { get; private set; }
+        public bool SuppressValidation { get; set; }
+        public bool ValidateAllProperties { get; set; }
+        public event EventHandler<ModelValidatedEventArgs> Validated;
+        public event EventHandler<ModelValidatingEventArgs> Validating;
+        public void CombineWith(ModelValidationNode otherNode);
+        public void Validate(ModelBindingExecutionContext modelBindingExecutionContext);
+        public void Validate(ModelBindingExecutionContext modelBindingExecutionContext, ModelValidationNode parentNode);
+    }
+    public class ModelValidationResult {
+        public ModelValidationResult();
+        public string MemberName { get; set; }
+        public string Message { get; set; }
+    }
+    public abstract class ModelValidator {
+        protected ModelValidator(ModelMetadata metadata, ModelBindingExecutionContext modelBindingExecutionContext);
+        public virtual bool IsRequired { get; }
+        protected internal ModelMetadata Metadata { get; private set; }
+        protected internal ModelBindingExecutionContext ModelBindingExecutionContext { get; private set; }
+        public static ModelValidator GetModelValidator(ModelMetadata metadata, ModelBindingExecutionContext context);
+        public abstract IEnumerable<ModelValidationResult> Validate(object container);
+    }
+    public abstract class ModelValidatorProvider {
+        protected ModelValidatorProvider();
+        public abstract IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ModelBindingExecutionContext context);
+    }
+    public class ModelValidatorProviderCollection : Collection<ModelValidatorProvider> {
+        public ModelValidatorProviderCollection();
+        public ModelValidatorProviderCollection(IList<ModelValidatorProvider> list);
+        public IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ModelBindingExecutionContext context);
+        protected override void InsertItem(int index, ModelValidatorProvider item);
+        protected override void SetItem(int index, ModelValidatorProvider item);
+    }
+    public static class ModelValidatorProviders {
+        public static ModelValidatorProviderCollection Providers { get; }
+    }
+    public class MutableObjectModelBinder : IModelBinder {
+        public MutableObjectModelBinder();
+        public virtual bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+        protected virtual bool CanUpdateProperty(ModelMetadata propertyMetadata);
+        protected virtual object CreateModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+        protected virtual void EnsureModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+        protected virtual IEnumerable<ModelMetadata> GetMetadataForProperties(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+        protected virtual void SetProperty(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext, ModelMetadata propertyMetadata, ComplexModelResult complexModelResult);
+    }
+    public sealed class MutableObjectModelBinderProvider : ModelBinderProvider {
+        public MutableObjectModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public class NameValueCollectionValueProvider : IUnvalidatedValueProvider, IValueProvider {
+        public NameValueCollectionValueProvider(NameValueCollection collection, NameValueCollection unvalidatedCollection, CultureInfo culture);
+        public NameValueCollectionValueProvider(NameValueCollection collection, CultureInfo culture);
+        public virtual bool ContainsPrefix(string prefix);
+        public virtual ValueProviderResult GetValue(string key);
+        public virtual ValueProviderResult GetValue(string key, bool skipValidation);
+    }
+    public sealed class ProfileAttribute : ValueProviderSourceAttribute {
+        public ProfileAttribute();
+        public ProfileAttribute(string key);
+        public string Key { get; private set; }
+        public override string GetModelName();
+        public override IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class ProfileValueProvider : SimpleValueProvider {
+        public ProfileValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+        protected override object FetchValue(string key);
+    }
+    public sealed class QueryStringAttribute : ValueProviderSourceAttribute, IUnvalidatedValueProviderSource, IValueProviderSource {
+        public QueryStringAttribute();
+        public QueryStringAttribute(string key);
+        public string Key { get; private set; }
+        public bool ValidateInput { get; set; }
+        public override string GetModelName();
+        public override IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class QueryStringValueProvider : NameValueCollectionValueProvider {
+        public QueryStringValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class RangeAttributeAdapter : DataAnnotationsModelValidator<RangeAttribute> {
+        public RangeAttributeAdapter(ModelMetadata metadata, ModelBindingExecutionContext context, RangeAttribute attribute);
+    }
+    public sealed class RegularExpressionAttributeAdapter : DataAnnotationsModelValidator<RegularExpressionAttribute> {
+        public RegularExpressionAttributeAdapter(ModelMetadata metadata, ModelBindingExecutionContext context, RegularExpressionAttribute attribute);
+    }
+    public sealed class RequiredAttributeAdapter : DataAnnotationsModelValidator<RequiredAttribute> {
+        public RequiredAttributeAdapter(ModelMetadata metadata, ModelBindingExecutionContext context, RequiredAttribute attribute);
+    }
+    public sealed class RouteDataAttribute : ValueProviderSourceAttribute {
+        public RouteDataAttribute();
+        public RouteDataAttribute(string key);
+        public string Key { get; private set; }
+        public override string GetModelName();
+        public override IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class RouteDataValueProvider : DictionaryValueProvider<object> {
+        public RouteDataValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class SessionAttribute : ValueProviderSourceAttribute {
+        public SessionAttribute();
+        public SessionAttribute(string name);
+        public string Name { get; private set; }
+        public override string GetModelName();
+        public override IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class SimpleModelBinderProvider : ModelBinderProvider {
+        public SimpleModelBinderProvider(Type modelType, Func<IModelBinder> modelBinderFactory);
+        public SimpleModelBinderProvider(Type modelType, IModelBinder modelBinder);
+        public Type ModelType { get; }
+        public bool SuppressPrefixCheck { get; set; }
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public abstract class SimpleValueProvider : IValueProvider {
+        protected SimpleValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+        protected SimpleValueProvider(ModelBindingExecutionContext modelBindingExecutionContext, CultureInfo cultureInfo);
+        protected ModelBindingExecutionContext ModelBindingExecutionContext { get; private set; }
+        public virtual bool ContainsPrefix(string prefix);
+        protected abstract object FetchValue(string key);
+        public virtual ValueProviderResult GetValue(string key);
+    }
+    public sealed class StringLengthAttributeAdapter : DataAnnotationsModelValidator<StringLengthAttribute> {
+        public StringLengthAttributeAdapter(ModelMetadata metadata, ModelBindingExecutionContext context, StringLengthAttribute attribute);
+    }
+    public sealed class TypeConverterModelBinder : IModelBinder {
+        public TypeConverterModelBinder();
+        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public sealed class TypeConverterModelBinderProvider : ModelBinderProvider {
+        public TypeConverterModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public sealed class TypeMatchModelBinder : IModelBinder {
+        public TypeMatchModelBinder();
+        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public sealed class TypeMatchModelBinderProvider : ModelBinderProvider {
+        public TypeMatchModelBinderProvider();
+        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext);
+    }
+    public sealed class UserProfileAttribute : Attribute, IValueProviderSource {
+        public UserProfileAttribute();
+        public IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class UserProfileValueProvider : SimpleValueProvider {
+        public UserProfileValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+        protected override object FetchValue(string key);
+    }
+    public class ValidatableObjectAdapter : ModelValidator {
+        public ValidatableObjectAdapter(ModelMetadata metadata, ModelBindingExecutionContext context);
+        public override IEnumerable<ModelValidationResult> Validate(object container);
+    }
+    public class ValueProviderCollection : Collection<IValueProvider>, IUnvalidatedValueProvider, IValueProvider {
+        public ValueProviderCollection();
+        public ValueProviderCollection(IList<IValueProvider> list);
+        public virtual bool ContainsPrefix(string prefix);
+        public virtual ValueProviderResult GetValue(string key);
+        public virtual ValueProviderResult GetValue(string key, bool skipValidation);
+        protected override void InsertItem(int index, IValueProvider item);
+        protected override void SetItem(int index, IValueProvider item);
+    }
+    public class ValueProviderResult {
+        protected ValueProviderResult();
+        public ValueProviderResult(object rawValue, string attemptedValue, CultureInfo culture);
+        public string AttemptedValue { get; protected set; }
+        public CultureInfo Culture { get; protected set; }
+        public object RawValue { get; protected set; }
+        public object ConvertTo(Type type);
+        public virtual object ConvertTo(Type type, CultureInfo culture);
+    }
+    public abstract class ValueProviderSourceAttribute : Attribute, IModelNameProvider, IValueProviderSource {
+        protected ValueProviderSourceAttribute();
+        public virtual string GetModelName();
+        public abstract IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class ViewStateAttribute : ValueProviderSourceAttribute {
+        public ViewStateAttribute();
+        public ViewStateAttribute(string key);
+        public string Key { get; private set; }
+        public override string GetModelName();
+        public override IValueProvider GetValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+    }
+    public sealed class ViewStateValueProvider : SimpleValueProvider {
+        public ViewStateValueProvider(ModelBindingExecutionContext modelBindingExecutionContext);
+        protected override object FetchValue(string key);
+    }
+}
```

