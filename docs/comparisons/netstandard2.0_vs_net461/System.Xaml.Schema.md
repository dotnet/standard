# System.Xaml.Schema

``` diff
+namespace System.Xaml.Schema {
+    public enum AllowedMemberLocations {
+        Any = 3,
+        Attribute = 1,
+        MemberElement = 2,
+        None = 0,
+    }
+    public enum ShouldSerializeResult {
+        Default = 0,
+        False = 2,
+        True = 1,
+    }
+    public enum XamlCollectionKind : byte {
+        Array = (byte)3,
+        Collection = (byte)1,
+        Dictionary = (byte)2,
+        None = (byte)0,
+    }
+    public class XamlMemberInvoker {
+        protected XamlMemberInvoker();
+        public XamlMemberInvoker(XamlMember member);
+        public MethodInfo UnderlyingGetter { get; }
+        public MethodInfo UnderlyingSetter { get; }
+        public static XamlMemberInvoker UnknownInvoker { get; }
+        public virtual object GetValue(object instance);
+        public virtual void SetValue(object instance, object value);
+        public virtual ShouldSerializeResult ShouldSerializeValue(object instance);
+    }
+    public class XamlTypeInvoker {
+        protected XamlTypeInvoker();
+        public XamlTypeInvoker(XamlType type);
+        public EventHandler<XamlSetMarkupExtensionEventArgs> SetMarkupExtensionHandler { get; }
+        public EventHandler<XamlSetTypeConverterEventArgs> SetTypeConverterHandler { get; }
+        public static XamlTypeInvoker UnknownInvoker { get; }
+        public virtual void AddToCollection(object instance, object item);
+        public virtual void AddToDictionary(object instance, object key, object item);
+        public virtual object CreateInstance(object[] arguments);
+        public virtual MethodInfo GetAddMethod(XamlType contentType);
+        public virtual MethodInfo GetEnumeratorMethod();
+        public virtual IEnumerator GetItems(object instance);
+    }
+    public class XamlTypeName {
+        public XamlTypeName();
+        public XamlTypeName(string xamlNamespace, string name);
+        public XamlTypeName(string xamlNamespace, string name, IEnumerable<XamlTypeName> typeArguments);
+        public XamlTypeName(XamlType xamlType);
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public IList<XamlTypeName> TypeArguments { get; }
+        public static XamlTypeName Parse(string typeName, IXamlNamespaceResolver namespaceResolver);
+        public static IList<XamlTypeName> ParseList(string typeNameList, IXamlNamespaceResolver namespaceResolver);
+        public override string ToString();
+        public static string ToString(IList<XamlTypeName> typeNameList, INamespacePrefixLookup prefixLookup);
+        public string ToString(INamespacePrefixLookup prefixLookup);
+        public static bool TryParse(string typeName, IXamlNamespaceResolver namespaceResolver, out XamlTypeName result);
+        public static bool TryParseList(string typeNameList, IXamlNamespaceResolver namespaceResolver, out IList<XamlTypeName> result);
+    }
+    public class XamlTypeTypeConverter : TypeConverter {
+        public XamlTypeTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class XamlValueConverter<TConverterBase> : IEquatable<XamlValueConverter<TConverterBase>> where TConverterBase : class {
+        public XamlValueConverter(Type converterType, XamlType targetType);
+        public XamlValueConverter(Type converterType, XamlType targetType, string name);
+        public TConverterBase ConverterInstance { get; }
+        public Type ConverterType { get; private set; }
+        public string Name { get; private set; }
+        public XamlType TargetType { get; private set; }
+        protected virtual TConverterBase CreateInstance();
+        public override bool Equals(object obj);
+        public bool Equals(XamlValueConverter<TConverterBase> other);
+        public override int GetHashCode();
+        public static bool operator ==(XamlValueConverter<TConverterBase> converter1, XamlValueConverter<TConverterBase> converter2);
+        public static bool operator !=(XamlValueConverter<TConverterBase> converter1, XamlValueConverter<TConverterBase> converter2);
+        public override string ToString();
+    }
+}
```

