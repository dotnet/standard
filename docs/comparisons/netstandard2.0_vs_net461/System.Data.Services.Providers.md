# System.Data.Services.Providers

``` diff
+namespace System.Data.Services.Providers {
+    public static class DataServiceProviderMethods {
+        public static int Compare(bool left, bool right);
+        public static int Compare(Guid left, Guid right);
+        public static int Compare(Nullable<bool> left, Nullable<bool> right);
+        public static int Compare(Nullable<Guid> left, Nullable<Guid> right);
+        public static int Compare(string left, string right);
+        public static object Convert(object value, ResourceType type);
+        public static IEnumerable<T> GetSequenceValue<T>(object value, ResourceProperty property);
+        public static object GetValue(object value, ResourceProperty property);
+        public static bool TypeIs(object value, ResourceType type);
+    }
+    public interface IDataServiceMetadataProvider {
+        string ContainerName { get; }
+        string ContainerNamespace { get; }
+        IEnumerable<ResourceSet> ResourceSets { get; }
+        IEnumerable<ServiceOperation> ServiceOperations { get; }
+        IEnumerable<ResourceType> Types { get; }
+        IEnumerable<ResourceType> GetDerivedTypes(ResourceType resourceType);
+        ResourceAssociationSet GetResourceAssociationSet(ResourceSet resourceSet, ResourceType resourceType, ResourceProperty resourceProperty);
+        bool HasDerivedTypes(ResourceType resourceType);
+        bool TryResolveResourceSet(string name, out ResourceSet resourceSet);
+        bool TryResolveResourceType(string name, out ResourceType resourceType);
+        bool TryResolveServiceOperation(string name, out ServiceOperation serviceOperation);
+    }
+    public interface IDataServicePagingProvider {
+        object[] GetContinuationToken(IEnumerator enumerator);
+        void SetContinuationToken(IQueryable query, ResourceType resourceType, object[] continuationToken);
+    }
+    public interface IDataServiceQueryProvider {
+        object CurrentDataSource { get; set; }
+        bool IsNullPropagationRequired { get; }
+        object GetOpenPropertyValue(object target, string propertyName);
+        IEnumerable<KeyValuePair<string, object>> GetOpenPropertyValues(object target);
+        object GetPropertyValue(object target, ResourceProperty resourceProperty);
+        IQueryable GetQueryRootForResourceSet(ResourceSet resourceSet);
+        ResourceType GetResourceType(object target);
+        object InvokeServiceOperation(ServiceOperation serviceOperation, object[] parameters);
+    }
+    public interface IDataServiceStreamProvider {
+        int StreamBufferSize { get; }
+        void DeleteStream(object entity, DataServiceOperationContext operationContext);
+        Stream GetReadStream(object entity, string etag, Nullable<bool> checkETagForEquality, DataServiceOperationContext operationContext);
+        Uri GetReadStreamUri(object entity, DataServiceOperationContext operationContext);
+        string GetStreamContentType(object entity, DataServiceOperationContext operationContext);
+        string GetStreamETag(object entity, DataServiceOperationContext operationContext);
+        Stream GetWriteStream(object entity, string etag, Nullable<bool> checkETagForEquality, DataServiceOperationContext operationContext);
+        string ResolveType(string entitySetName, DataServiceOperationContext operationContext);
+    }
+    public interface IDataServiceUpdateProvider : IUpdatable {
+        void SetConcurrencyValues(object resourceCookie, Nullable<bool> checkForEquality, IEnumerable<KeyValuePair<string, object>> concurrencyValues);
+    }
+    public static class OpenTypeMethods {
+        public static object Add(object left, object right);
+        public static object AndAlso(object left, object right);
+        public static object Ceiling(object value);
+        public static object Concat(object first, object second);
+        public static object Convert(object value, ResourceType type);
+        public static object Day(object dateTime);
+        public static object Divide(object left, object right);
+        public static object EndsWith(object targetString, object substring);
+        public static object Equal(object left, object right);
+        public static object Floor(object value);
+        public static object GetValue(object value, string propertyName);
+        public static object GreaterThan(object left, object right);
+        public static object GreaterThanOrEqual(object left, object right);
+        public static object Hour(object dateTime);
+        public static object IndexOf(object targetString, object substring);
+        public static object Length(object value);
+        public static object LessThan(object left, object right);
+        public static object LessThanOrEqual(object left, object right);
+        public static object Minute(object dateTime);
+        public static object Modulo(object left, object right);
+        public static object Month(object dateTime);
+        public static object Multiply(object left, object right);
+        public static object Negate(object value);
+        public static object Not(object value);
+        public static object NotEqual(object left, object right);
+        public static object OrElse(object left, object right);
+        public static object Replace(object targetString, object substring, object newString);
+        public static object Round(object value);
+        public static object Second(object dateTime);
+        public static object StartsWith(object targetString, object substring);
+        public static object Substring(object targetString, object startIndex);
+        public static object Substring(object targetString, object startIndex, object length);
+        public static object SubstringOf(object substring, object targetString);
+        public static object Subtract(object left, object right);
+        public static object ToLower(object targetString);
+        public static object ToUpper(object targetString);
+        public static object Trim(object targetString);
+        public static object TypeIs(object value, ResourceType type);
+        public static object Year(object dateTime);
+    }
+    public sealed class ResourceAssociationSet {
+        public ResourceAssociationSet(string name, ResourceAssociationSetEnd end1, ResourceAssociationSetEnd end2);
+        public ResourceAssociationSetEnd End1 { get; }
+        public ResourceAssociationSetEnd End2 { get; }
+        public string Name { get; }
+    }
+    public sealed class ResourceAssociationSetEnd {
+        public ResourceAssociationSetEnd(ResourceSet resourceSet, ResourceType resourceType, ResourceProperty resourceProperty);
+        public ResourceProperty ResourceProperty { get; }
+        public ResourceSet ResourceSet { get; }
+        public ResourceType ResourceType { get; }
+    }
+    public class ResourceProperty {
+        public ResourceProperty(string name, ResourcePropertyKind kind, ResourceType propertyResourceType);
+        public bool CanReflectOnInstanceTypeProperty { get; set; }
+        public object CustomState { get; set; }
+        public bool IsReadOnly { get; }
+        public ResourcePropertyKind Kind { get; internal set; }
+        public string MimeType { get; set; }
+        public string Name { get; }
+        public ResourceType ResourceType { get; }
+        public void SetReadOnly();
+    }
+    public enum ResourcePropertyKind {
+        ComplexType = 4,
+        ETag = 32,
+        Key = 2,
+        Primitive = 1,
+        ResourceReference = 8,
+        ResourceSetReference = 16,
+    }
+    public class ResourceSet {
+        public ResourceSet(string name, ResourceType elementType);
+        public object CustomState { get; set; }
+        public bool IsReadOnly { get; }
+        public string Name { get; }
+        public ResourceType ResourceType { get; }
+        public void SetReadOnly();
+    }
+    public class ResourceType {
+        public ResourceType(Type instanceType, ResourceTypeKind resourceTypeKind, ResourceType baseType, string namespaceName, string name, bool isAbstract);
+        public ResourceType BaseType { get; }
+        public bool CanReflectOnInstanceType { get; set; }
+        public object CustomState { get; set; }
+        public ReadOnlyCollection<ResourceProperty> ETagProperties { get; }
+        public string FullName { get; }
+        public Type InstanceType { get; }
+        public bool IsAbstract { get; }
+        public bool IsMediaLinkEntry { get; set; }
+        public bool IsOpenType { get; set; }
+        public bool IsReadOnly { get; }
+        public ReadOnlyCollection<ResourceProperty> KeyProperties { get; }
+        public string Name { get; }
+        public string Namespace { get; }
+        public ReadOnlyCollection<ResourceProperty> Properties { get; }
+        public ReadOnlyCollection<ResourceProperty> PropertiesDeclaredOnThisType { get; }
+        public ResourceTypeKind ResourceTypeKind { get; }
+        public void AddEntityPropertyMappingAttribute(EntityPropertyMappingAttribute attribute);
+        public void AddProperty(ResourceProperty property);
+        public static ResourceType GetPrimitiveResourceType(Type type);
+        protected virtual IEnumerable<ResourceProperty> LoadPropertiesDeclaredOnThisType();
+        public void SetReadOnly();
+    }
+    public enum ResourceTypeKind {
+        ComplexType = 1,
+        EntityType = 0,
+        Primitive = 2,
+    }
+    public class ServiceOperation {
+        public ServiceOperation(string name, ServiceOperationResultKind resultKind, ResourceType resultType, ResourceSet resultSet, string method, IEnumerable<ServiceOperationParameter> parameters);
+        public object CustomState { get; set; }
+        public bool IsReadOnly { get; }
+        public string Method { get; }
+        public string MimeType { get; set; }
+        public string Name { get; }
+        public ReadOnlyCollection<ServiceOperationParameter> Parameters { get; }
+        public ResourceSet ResourceSet { get; }
+        public ServiceOperationResultKind ResultKind { get; }
+        public ResourceType ResultType { get; }
+        public void SetReadOnly();
+    }
+    public class ServiceOperationParameter {
+        public ServiceOperationParameter(string name, ResourceType parameterType);
+        public object CustomState { get; set; }
+        public bool IsReadOnly { get; }
+        public string Name { get; }
+        public ResourceType ParameterType { get; }
+        public void SetReadOnly();
+    }
+    public enum ServiceOperationResultKind {
+        DirectValue = 0,
+        Enumeration = 1,
+        QueryWithMultipleResults = 2,
+        QueryWithSingleResult = 3,
+        Void = 4,
+    }
+}
```

