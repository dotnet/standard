# System.Configuration

``` diff
+namespace System.Configuration {
+    public sealed class ApplicationScopedSettingAttribute : SettingAttribute {
+        public ApplicationScopedSettingAttribute();
+    }
+    public abstract class ApplicationSettingsBase : SettingsBase, INotifyPropertyChanged {
+        protected ApplicationSettingsBase();
+        protected ApplicationSettingsBase(IComponent owner);
+        protected ApplicationSettingsBase(IComponent owner, string settingsKey);
+        protected ApplicationSettingsBase(string settingsKey);
+        public override SettingsContext Context { get; }
+        public override SettingsPropertyCollection Properties { get; }
+        public override SettingsPropertyValueCollection PropertyValues { get; }
+        public override SettingsProviderCollection Providers { get; }
+        public string SettingsKey { get; set; }
+        public override object this[string propertyName] { get; set; }
+        public event PropertyChangedEventHandler PropertyChanged;
+        public event SettingChangingEventHandler SettingChanging;
+        public event SettingsLoadedEventHandler SettingsLoaded;
+        public event SettingsSavingEventHandler SettingsSaving;
+        public object GetPreviousVersion(string propertyName);
+        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e);
+        protected virtual void OnSettingChanging(object sender, SettingChangingEventArgs e);
+        protected virtual void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e);
+        protected virtual void OnSettingsSaving(object sender, CancelEventArgs e);
+        public void Reload();
+        public void Reset();
+        public override void Save();
+        public virtual void Upgrade();
+    }
+    public sealed class ApplicationSettingsGroup : ConfigurationSectionGroup {
+        public ApplicationSettingsGroup();
+    }
+    public class AppSettingsReader {
+        public AppSettingsReader();
+        public object GetValue(string key, Type type);
+    }
+    public sealed class AppSettingsSection : ConfigurationSection {
+        public AppSettingsSection();
+        public string File { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public KeyValueConfigurationCollection Settings { get; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override object GetRuntimeObject();
+        protected override bool IsModified();
+        protected override void Reset(ConfigurationElement parentSection);
+        protected override string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode);
+    }
+    public sealed class CallbackValidator : ConfigurationValidatorBase {
+        public CallbackValidator(Type type, ValidatorCallback callback);
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class CallbackValidatorAttribute : ConfigurationValidatorAttribute {
+        public CallbackValidatorAttribute();
+        public string CallbackMethodName { get; set; }
+        public Type Type { get; set; }
+        public override ConfigurationValidatorBase ValidatorInstance { get; }
+    }
+    public sealed class ClientSettingsSection : ConfigurationSection {
+        public ClientSettingsSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SettingElementCollection Settings { get; }
+    }
+    public sealed class CommaDelimitedStringCollection : StringCollection {
+        public CommaDelimitedStringCollection();
+        public bool IsModified { get; }
+        public new bool IsReadOnly { get; }
+        public new string this[int index] { get; set; }
+        public new void Add(string value);
+        public new void AddRange(string[] range);
+        public new void Clear();
+        public CommaDelimitedStringCollection Clone();
+        public new void Insert(int index, string value);
+        public new void Remove(string value);
+        public void SetReadOnly();
+        public override string ToString();
+    }
+    public sealed class CommaDelimitedStringCollectionConverter : ConfigurationConverterBase {
+        public CommaDelimitedStringCollectionConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public sealed class Configuration {
+        public AppSettingsSection AppSettings { get; }
+        public Func<string, string> AssemblyStringTransformer { get; set; }
+        public ConnectionStringsSection ConnectionStrings { get; }
+        public ContextInformation EvaluationContext { get; }
+        public string FilePath { get; }
+        public bool HasFile { get; }
+        public ConfigurationLocationCollection Locations { get; }
+        public bool NamespaceDeclared { get; set; }
+        public ConfigurationSectionGroup RootSectionGroup { get; }
+        public ConfigurationSectionGroupCollection SectionGroups { get; }
+        public ConfigurationSectionCollection Sections { get; }
+        public FrameworkName TargetFramework { get; set; }
+        public Func<string, string> TypeStringTransformer { get; set; }
+        public ConfigurationSection GetSection(string sectionName);
+        public ConfigurationSectionGroup GetSectionGroup(string sectionGroupName);
+        public void Save();
+        public void Save(ConfigurationSaveMode saveMode);
+        public void Save(ConfigurationSaveMode saveMode, bool forceSaveAll);
+        public void SaveAs(string filename);
+        public void SaveAs(string filename, ConfigurationSaveMode saveMode);
+        public void SaveAs(string filename, ConfigurationSaveMode saveMode, bool forceSaveAll);
+    }
+    public enum ConfigurationAllowDefinition {
+        Everywhere = 300,
+        MachineOnly = 0,
+        MachineToApplication = 200,
+        MachineToWebRoot = 100,
+    }
+    public enum ConfigurationAllowExeDefinition {
+        MachineOnly = 0,
+        MachineToApplication = 100,
+        MachineToLocalUser = 300,
+        MachineToRoamingUser = 200,
+    }
+    public sealed class ConfigurationCollectionAttribute : Attribute {
+        public ConfigurationCollectionAttribute(Type itemType);
+        public string AddItemName { get; set; }
+        public string ClearItemsName { get; set; }
+        public ConfigurationElementCollectionType CollectionType { get; set; }
+        public Type ItemType { get; }
+        public string RemoveItemName { get; set; }
+    }
+    public abstract class ConfigurationConverterBase : TypeConverter {
+        protected ConfigurationConverterBase();
+        public override bool CanConvertFrom(ITypeDescriptorContext ctx, Type type);
+        public override bool CanConvertTo(ITypeDescriptorContext ctx, Type type);
+    }
+    public abstract class ConfigurationElement {
+        protected ConfigurationElement();
+        public Configuration CurrentConfiguration { get; }
+        public ElementInformation ElementInformation { get; }
+        protected virtual ConfigurationElementProperty ElementProperty { get; }
+        protected ContextInformation EvaluationContext { get; }
+        protected bool HasContext { get; }
+        public ConfigurationLockCollection LockAllAttributesExcept { get; }
+        public ConfigurationLockCollection LockAllElementsExcept { get; }
+        public ConfigurationLockCollection LockAttributes { get; }
+        public ConfigurationLockCollection LockElements { get; }
+        public bool LockItem { get; set; }
+        protected virtual ConfigurationPropertyCollection Properties { get; }
+        protected object this[ConfigurationProperty prop] { get; set; }
+        protected object this[string propertyName] { get; set; }
+        protected virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        public override bool Equals(object compareTo);
+        public override int GetHashCode();
+        protected virtual string GetTransformedAssemblyString(string assemblyName);
+        protected virtual string GetTransformedTypeString(string typeName);
+        protected virtual void Init();
+        protected virtual void InitializeDefault();
+        protected virtual bool IsModified();
+        public virtual bool IsReadOnly();
+        protected virtual void ListErrors(IList errorList);
+        protected virtual bool OnDeserializeUnrecognizedAttribute(string name, string value);
+        protected virtual bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+        protected virtual object OnRequiredPropertyNotFound(string name);
+        protected virtual void PostDeserialize();
+        protected virtual void PreSerialize(XmlWriter writer);
+        protected virtual void Reset(ConfigurationElement parentElement);
+        protected virtual void ResetModified();
+        protected virtual bool SerializeElement(XmlWriter writer, bool serializeCollectionKey);
+        protected virtual bool SerializeToXmlElement(XmlWriter writer, string elementName);
+        protected void SetPropertyValue(ConfigurationProperty prop, object value, bool ignoreLocks);
+        protected virtual void SetReadOnly();
+        protected virtual void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public abstract class ConfigurationElementCollection : ConfigurationElement, ICollection, IEnumerable {
+        protected ConfigurationElementCollection();
+        protected ConfigurationElementCollection(IComparer comparer);
+        protected string AddElementName { get; set; }
+        protected string ClearElementName { get; set; }
+        public virtual ConfigurationElementCollectionType CollectionType { get; }
+        public int Count { get; }
+        protected virtual string ElementName { get; }
+        public bool EmitClear { get; set; }
+        public bool IsSynchronized { get; }
+        protected string RemoveElementName { get; set; }
+        public object SyncRoot { get; }
+        protected virtual bool ThrowOnDuplicate { get; }
+        protected virtual void BaseAdd(ConfigurationElement element);
+        protected void BaseAdd(ConfigurationElement element, bool throwIfExists);
+        protected virtual void BaseAdd(int index, ConfigurationElement element);
+        protected void BaseClear();
+        protected ConfigurationElement BaseGet(int index);
+        protected ConfigurationElement BaseGet(object key);
+        protected object[] BaseGetAllKeys();
+        protected object BaseGetKey(int index);
+        protected int BaseIndexOf(ConfigurationElement element);
+        protected bool BaseIsRemoved(object key);
+        protected void BaseRemove(object key);
+        protected void BaseRemoveAt(int index);
+        public void CopyTo(ConfigurationElement[] array, int index);
+        protected abstract ConfigurationElement CreateNewElement();
+        protected virtual ConfigurationElement CreateNewElement(string elementName);
+        public override bool Equals(object compareTo);
+        protected abstract object GetElementKey(ConfigurationElement element);
+        public IEnumerator GetEnumerator();
+        public override int GetHashCode();
+        protected virtual bool IsElementName(string elementName);
+        protected virtual bool IsElementRemovable(ConfigurationElement element);
+        protected override bool IsModified();
+        public override bool IsReadOnly();
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override void ResetModified();
+        protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey);
+        protected override void SetReadOnly();
+        void System.Collections.ICollection.CopyTo(Array arr, int index);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public enum ConfigurationElementCollectionType {
+        AddRemoveClearMap = 1,
+        AddRemoveClearMapAlternate = 3,
+        BasicMap = 0,
+        BasicMapAlternate = 2,
+    }
+    public sealed class ConfigurationElementProperty {
+        public ConfigurationElementProperty(ConfigurationValidatorBase validator);
+        public ConfigurationValidatorBase Validator { get; }
+    }
+    public class ConfigurationErrorsException : ConfigurationException {
+        public ConfigurationErrorsException();
+        protected ConfigurationErrorsException(SerializationInfo info, StreamingContext context);
+        public ConfigurationErrorsException(string message);
+        public ConfigurationErrorsException(string message, Exception inner);
+        public ConfigurationErrorsException(string message, Exception inner, string filename, int line);
+        public ConfigurationErrorsException(string message, Exception inner, XmlNode node);
+        public ConfigurationErrorsException(string message, Exception inner, XmlReader reader);
+        public ConfigurationErrorsException(string message, string filename, int line);
+        public ConfigurationErrorsException(string message, XmlNode node);
+        public ConfigurationErrorsException(string message, XmlReader reader);
+        public override string BareMessage { get; }
+        public ICollection Errors { get; }
+        public override string Filename { get; }
+        public override int Line { get; }
+        public override string Message { get; }
+        public static string GetFilename(XmlNode node);
+        public static string GetFilename(XmlReader reader);
+        public static int GetLineNumber(XmlNode node);
+        public static int GetLineNumber(XmlReader reader);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class ConfigurationException : SystemException {
+        public ConfigurationException();
+        protected ConfigurationException(SerializationInfo info, StreamingContext context);
+        public ConfigurationException(string message);
+        public ConfigurationException(string message, Exception inner);
+        public ConfigurationException(string message, Exception inner, string filename, int line);
+        public ConfigurationException(string message, Exception inner, XmlNode node);
+        public ConfigurationException(string message, string filename, int line);
+        public ConfigurationException(string message, XmlNode node);
+        public virtual string BareMessage { get; }
+        public virtual string Filename { get; }
+        public virtual int Line { get; }
+        public override string Message { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public static string GetXmlNodeFilename(XmlNode node);
+        public static int GetXmlNodeLineNumber(XmlNode node);
+    }
+    public class ConfigurationFileMap : ICloneable {
+        public ConfigurationFileMap();
+        public ConfigurationFileMap(string machineConfigFilename);
+        public string MachineConfigFilename { get; set; }
+        public virtual object Clone();
+    }
+    public class ConfigurationLocation {
+        public string Path { get; }
+        public Configuration OpenConfiguration();
+    }
+    public class ConfigurationLocationCollection : ReadOnlyCollectionBase {
+        public ConfigurationLocation this[int index] { get; }
+    }
+    public sealed class ConfigurationLockCollection : ICollection, IEnumerable {
+        public string AttributeList { get; }
+        public int Count { get; }
+        public bool HasParentElements { get; }
+        public bool IsModified { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public void Add(string name);
+        public void Clear();
+        public bool Contains(string name);
+        public void CopyTo(string[] array, int index);
+        public IEnumerator GetEnumerator();
+        public bool IsReadOnly(string name);
+        public void Remove(string name);
+        public void SetFromList(string attributeList);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public static class ConfigurationManager {
+        public static NameValueCollection AppSettings { get; }
+        public static ConnectionStringSettingsCollection ConnectionStrings { get; }
+        public static object GetSection(string sectionName);
+        public static Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel);
+        public static Configuration OpenExeConfiguration(string exePath);
+        public static Configuration OpenMachineConfiguration();
+        public static Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel);
+        public static Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel, bool preLoad);
+        public static Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap);
+        public static void RefreshSection(string sectionName);
+    }
+    public sealed class ConfigurationProperty {
+        public ConfigurationProperty(string name, Type type);
+        public ConfigurationProperty(string name, Type type, object defaultValue);
+        public ConfigurationProperty(string name, Type type, object defaultValue, TypeConverter typeConverter, ConfigurationValidatorBase validator, ConfigurationPropertyOptions options);
+        public ConfigurationProperty(string name, Type type, object defaultValue, TypeConverter typeConverter, ConfigurationValidatorBase validator, ConfigurationPropertyOptions options, string description);
+        public ConfigurationProperty(string name, Type type, object defaultValue, ConfigurationPropertyOptions options);
+        public TypeConverter Converter { get; }
+        public object DefaultValue { get; }
+        public string Description { get; }
+        public bool IsAssemblyStringTransformationRequired { get; }
+        public bool IsDefaultCollection { get; }
+        public bool IsKey { get; }
+        public bool IsRequired { get; }
+        public bool IsTypeStringTransformationRequired { get; }
+        public bool IsVersionCheckRequired { get; }
+        public string Name { get; }
+        public Type Type { get; }
+        public ConfigurationValidatorBase Validator { get; }
+    }
+    public sealed class ConfigurationPropertyAttribute : Attribute {
+        public ConfigurationPropertyAttribute(string name);
+        public object DefaultValue { get; set; }
+        public bool IsDefaultCollection { get; set; }
+        public bool IsKey { get; set; }
+        public bool IsRequired { get; set; }
+        public string Name { get; }
+        public ConfigurationPropertyOptions Options { get; set; }
+    }
+    public class ConfigurationPropertyCollection : ICollection, IEnumerable {
+        public ConfigurationPropertyCollection();
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public ConfigurationProperty this[string name] { get; }
+        public void Add(ConfigurationProperty property);
+        public void Clear();
+        public bool Contains(string name);
+        public void CopyTo(ConfigurationProperty[] array, int index);
+        public IEnumerator GetEnumerator();
+        public bool Remove(string name);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public enum ConfigurationPropertyOptions {
+        IsAssemblyStringTransformationRequired = 16,
+        IsDefaultCollection = 1,
+        IsKey = 4,
+        IsRequired = 2,
+        IsTypeStringTransformationRequired = 8,
+        IsVersionCheckRequired = 32,
+        None = 0,
+    }
+    public enum ConfigurationSaveMode {
+        Full = 2,
+        Minimal = 1,
+        Modified = 0,
+    }
+    public abstract class ConfigurationSection : ConfigurationElement {
+        protected ConfigurationSection();
+        public SectionInformation SectionInformation { get; }
+        protected virtual void DeserializeSection(XmlReader reader);
+        protected virtual object GetRuntimeObject();
+        protected override bool IsModified();
+        protected override void ResetModified();
+        protected virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode);
+        protected virtual bool ShouldSerializeElementInTargetVersion(ConfigurationElement element, string elementName, FrameworkName targetFramework);
+        protected virtual bool ShouldSerializePropertyInTargetVersion(ConfigurationProperty property, string propertyName, FrameworkName targetFramework, ConfigurationElement parentConfigurationElement);
+        protected virtual bool ShouldSerializeSectionInTargetVersion(FrameworkName targetFramework);
+    }
+    public sealed class ConfigurationSectionCollection : NameObjectCollectionBase {
+        public override int Count { get; }
+        public override NameObjectCollectionBase.KeysCollection Keys { get; }
+        public ConfigurationSection this[int index] { get; }
+        public ConfigurationSection this[string name] { get; }
+        public void Add(string name, ConfigurationSection section);
+        public void Clear();
+        public void CopyTo(ConfigurationSection[] array, int index);
+        public ConfigurationSection Get(int index);
+        public ConfigurationSection Get(string name);
+        public override IEnumerator GetEnumerator();
+        public string GetKey(int index);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public class ConfigurationSectionGroup {
+        public ConfigurationSectionGroup();
+        public bool IsDeclarationRequired { get; }
+        public bool IsDeclared { get; }
+        public string Name { get; }
+        public string SectionGroupName { get; }
+        public ConfigurationSectionGroupCollection SectionGroups { get; }
+        public ConfigurationSectionCollection Sections { get; }
+        public string Type { get; set; }
+        public void ForceDeclaration();
+        public void ForceDeclaration(bool force);
+        protected virtual bool ShouldSerializeSectionGroupInTargetVersion(FrameworkName targetFramework);
+    }
+    public sealed class ConfigurationSectionGroupCollection : NameObjectCollectionBase {
+        public override int Count { get; }
+        public override NameObjectCollectionBase.KeysCollection Keys { get; }
+        public ConfigurationSectionGroup this[int index] { get; }
+        public ConfigurationSectionGroup this[string name] { get; }
+        public void Add(string name, ConfigurationSectionGroup sectionGroup);
+        public void Clear();
+        public void CopyTo(ConfigurationSectionGroup[] array, int index);
+        public ConfigurationSectionGroup Get(int index);
+        public ConfigurationSectionGroup Get(string name);
+        public override IEnumerator GetEnumerator();
+        public string GetKey(int index);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class ConfigurationSettings {
+        public static NameValueCollection AppSettings { get; }
+        public static object GetConfig(string sectionName);
+    }
+    public enum ConfigurationUserLevel {
+        None = 0,
+        PerUserRoaming = 10,
+        PerUserRoamingAndLocal = 20,
+    }
+    public class ConfigurationValidatorAttribute : Attribute {
+        protected ConfigurationValidatorAttribute();
+        public ConfigurationValidatorAttribute(Type validator);
+        public virtual ConfigurationValidatorBase ValidatorInstance { get; }
+        public Type ValidatorType { get; }
+    }
+    public abstract class ConfigurationValidatorBase {
+        protected ConfigurationValidatorBase();
+        public virtual bool CanValidate(Type type);
+        public abstract void Validate(object value);
+    }
+    public sealed class ConfigXmlDocument : XmlDocument, IConfigErrorInfo {
+        public ConfigXmlDocument();
+        public string Filename { get; }
+        public int LineNumber { get; }
+        string System.Configuration.Internal.IConfigErrorInfo.Filename { get; }
+        int System.Configuration.Internal.IConfigErrorInfo.LineNumber { get; }
+        public override XmlAttribute CreateAttribute(string prefix, string localName, string namespaceUri);
+        public override XmlCDataSection CreateCDataSection(string data);
+        public override XmlComment CreateComment(string data);
+        public override XmlElement CreateElement(string prefix, string localName, string namespaceUri);
+        public override XmlSignificantWhitespace CreateSignificantWhitespace(string data);
+        public override XmlText CreateTextNode(string text);
+        public override XmlWhitespace CreateWhitespace(string data);
+        public override void Load(string filename);
+        public void LoadSingleElement(string filename, XmlTextReader sourceReader);
+    }
+    public sealed class ConnectionStringSettings : ConfigurationElement {
+        public ConnectionStringSettings();
+        public ConnectionStringSettings(string name, string connectionString);
+        public ConnectionStringSettings(string name, string connectionString, string providerName);
+        public string ConnectionString { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string ProviderName { get; set; }
+        public override string ToString();
+    }
+    public sealed class ConnectionStringSettingsCollection : ConfigurationElementCollection {
+        public ConnectionStringSettingsCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ConnectionStringSettings this[int index] { get; set; }
+        public new ConnectionStringSettings this[string name] { get; }
+        public void Add(ConnectionStringSettings settings);
+        protected override void BaseAdd(int index, ConfigurationElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(ConnectionStringSettings settings);
+        public void Remove(ConnectionStringSettings settings);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class ConnectionStringsSection : ConfigurationSection {
+        public ConnectionStringsSection();
+        public ConnectionStringSettingsCollection ConnectionStrings { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override object GetRuntimeObject();
+    }
+    public sealed class ContextInformation {
+        public object HostingContext { get; }
+        public bool IsMachineLevel { get; }
+        public object GetSection(string sectionName);
+    }
+    public sealed class DefaultSection : ConfigurationSection {
+        public DefaultSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void DeserializeSection(XmlReader xmlReader);
+        protected override bool IsModified();
+        protected override void Reset(ConfigurationElement parentSection);
+        protected override void ResetModified();
+        protected override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode);
+    }
+    public sealed class DefaultSettingValueAttribute : Attribute {
+        public DefaultSettingValueAttribute(string value);
+        public string Value { get; }
+    }
+    public sealed class DefaultValidator : ConfigurationValidatorBase {
+        public DefaultValidator();
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public class DictionarySectionHandler : IConfigurationSectionHandler {
+        public DictionarySectionHandler();
+        protected virtual string KeyAttributeName { get; }
+        protected virtual string ValueAttributeName { get; }
+        public virtual object Create(object parent, object context, XmlNode section);
+    }
+    public sealed class DpapiProtectedConfigurationProvider : ProtectedConfigurationProvider {
+        public DpapiProtectedConfigurationProvider();
+        public bool UseMachineProtection { get; }
+        public override XmlNode Decrypt(XmlNode encryptedNode);
+        public override XmlNode Encrypt(XmlNode node);
+        public override void Initialize(string name, NameValueCollection configurationValues);
+    }
+    public sealed class ElementInformation {
+        public ICollection Errors { get; }
+        public bool IsCollection { get; }
+        public bool IsLocked { get; }
+        public bool IsPresent { get; }
+        public int LineNumber { get; }
+        public PropertyInformationCollection Properties { get; }
+        public string Source { get; }
+        public Type Type { get; }
+        public ConfigurationValidatorBase Validator { get; }
+    }
+    public sealed class ExeConfigurationFileMap : ConfigurationFileMap {
+        public ExeConfigurationFileMap();
+        public ExeConfigurationFileMap(string machineConfigFileName);
+        public string ExeConfigFilename { get; set; }
+        public string LocalUserConfigFilename { get; set; }
+        public string RoamingUserConfigFilename { get; set; }
+        public override object Clone();
+    }
+    public sealed class ExeContext {
+        public string ExePath { get; }
+        public ConfigurationUserLevel UserLevel { get; }
+    }
+    public sealed class GenericEnumConverter : ConfigurationConverterBase {
+        public GenericEnumConverter(Type typeEnum);
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public interface IApplicationSettingsProvider {
+        SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);
+        void Reset(SettingsContext context);
+        void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
+    }
+    public interface IConfigurationSectionHandler {
+        object Create(object parent, object configContext, XmlNode section);
+    }
+    public interface IConfigurationSystem {
+        object GetConfig(string configKey);
+        void Init();
+    }
+    public sealed class IdnElement : ConfigurationElement {
+        public IdnElement();
+        public UriIdnScope Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class IgnoreSection : ConfigurationSection {
+        public IgnoreSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void DeserializeSection(XmlReader xmlReader);
+        protected override bool IsModified();
+        protected override void Reset(ConfigurationElement parentSection);
+        protected override void ResetModified();
+        protected override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode);
+    }
+    public class IgnoreSectionHandler : IConfigurationSectionHandler {
+        public IgnoreSectionHandler();
+        public virtual object Create(object parent, object configContext, XmlNode section);
+    }
+    public sealed class InfiniteIntConverter : ConfigurationConverterBase {
+        public InfiniteIntConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public sealed class InfiniteTimeSpanConverter : ConfigurationConverterBase {
+        public InfiniteTimeSpanConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public class IntegerValidator : ConfigurationValidatorBase {
+        public IntegerValidator(int minValue, int maxValue);
+        public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive);
+        public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive, int resolution);
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class IntegerValidatorAttribute : ConfigurationValidatorAttribute {
+        public IntegerValidatorAttribute();
+        public bool ExcludeRange { get; set; }
+        public int MaxValue { get; set; }
+        public int MinValue { get; set; }
+        public override ConfigurationValidatorBase ValidatorInstance { get; }
+    }
+    public interface IPersistComponentSettings {
+        bool SaveSettings { get; set; }
+        string SettingsKey { get; set; }
+        void LoadComponentSettings();
+        void ResetComponentSettings();
+        void SaveComponentSettings();
+    }
+    public sealed class IriParsingElement : ConfigurationElement {
+        public IriParsingElement();
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public interface ISettingsProviderService {
+        SettingsProvider GetSettingsProvider(SettingsProperty property);
+    }
+    public class KeyValueConfigurationCollection : ConfigurationElementCollection {
+        public KeyValueConfigurationCollection();
+        public string[] AllKeys { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public new KeyValueConfigurationElement this[string key] { get; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(KeyValueConfigurationElement keyValue);
+        public void Add(string key, string value);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string key);
+    }
+    public class KeyValueConfigurationElement : ConfigurationElement {
+        public KeyValueConfigurationElement(string key, string value);
+        public string Key { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Value { get; set; }
+        protected override void Init();
+    }
+    public class LocalFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider {
+        public LocalFileSettingsProvider();
+        public override string ApplicationName { get; set; }
+        public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);
+        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties);
+        public override void Initialize(string name, NameValueCollection values);
+        public void Reset(SettingsContext context);
+        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values);
+        public void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
+    }
+    public class LongValidator : ConfigurationValidatorBase {
+        public LongValidator(long minValue, long maxValue);
+        public LongValidator(long minValue, long maxValue, bool rangeIsExclusive);
+        public LongValidator(long minValue, long maxValue, bool rangeIsExclusive, long resolution);
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class LongValidatorAttribute : ConfigurationValidatorAttribute {
+        public LongValidatorAttribute();
+        public bool ExcludeRange { get; set; }
+        public long MaxValue { get; set; }
+        public long MinValue { get; set; }
+        public override ConfigurationValidatorBase ValidatorInstance { get; }
+    }
+    public sealed class NameValueConfigurationCollection : ConfigurationElementCollection {
+        public NameValueConfigurationCollection();
+        public string[] AllKeys { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public new NameValueConfigurationElement this[string name] { get; set; }
+        public void Add(NameValueConfigurationElement nameValue);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(NameValueConfigurationElement nameValue);
+        public void Remove(string name);
+    }
+    public sealed class NameValueConfigurationElement : ConfigurationElement {
+        public NameValueConfigurationElement(string name, string value);
+        public string Name { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Value { get; set; }
+    }
+    public class NameValueFileSectionHandler : IConfigurationSectionHandler {
+        public NameValueFileSectionHandler();
+        public object Create(object parent, object configContext, XmlNode section);
+    }
+    public class NameValueSectionHandler : IConfigurationSectionHandler {
+        public NameValueSectionHandler();
+        protected virtual string KeyAttributeName { get; }
+        protected virtual string ValueAttributeName { get; }
+        public object Create(object parent, object context, XmlNode section);
+    }
+    public sealed class NoSettingsVersionUpgradeAttribute : Attribute {
+        public NoSettingsVersionUpgradeAttribute();
+    }
+    public enum OverrideMode {
+        Allow = 1,
+        Deny = 2,
+        Inherit = 0,
+    }
+    public class PositiveTimeSpanValidator : ConfigurationValidatorBase {
+        public PositiveTimeSpanValidator();
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class PositiveTimeSpanValidatorAttribute : ConfigurationValidatorAttribute {
+        public PositiveTimeSpanValidatorAttribute();
+        public override ConfigurationValidatorBase ValidatorInstance { get; }
+    }
+    public sealed class PropertyInformation {
+        public TypeConverter Converter { get; }
+        public object DefaultValue { get; }
+        public string Description { get; }
+        public bool IsKey { get; }
+        public bool IsLocked { get; }
+        public bool IsModified { get; }
+        public bool IsRequired { get; }
+        public int LineNumber { get; }
+        public string Name { get; }
+        public string Source { get; }
+        public Type Type { get; }
+        public ConfigurationValidatorBase Validator { get; }
+        public object Value { get; set; }
+        public PropertyValueOrigin ValueOrigin { get; }
+    }
+    public sealed class PropertyInformationCollection : NameObjectCollectionBase {
+        public PropertyInformation this[string propertyName] { get; }
+        public void CopyTo(PropertyInformation[] array, int index);
+        public override IEnumerator GetEnumerator();
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum PropertyValueOrigin {
+        Default = 0,
+        Inherited = 1,
+        SetHere = 2,
+    }
+    public static class ProtectedConfiguration {
+        public const string DataProtectionProviderName = "DataProtectionConfigurationProvider";
+        public const string ProtectedDataSectionName = "configProtectedData";
+        public const string RsaProviderName = "RsaProtectedConfigurationProvider";
+        public static string DefaultProvider { get; }
+        public static ProtectedConfigurationProviderCollection Providers { get; }
+    }
+    public abstract class ProtectedConfigurationProvider : ProviderBase {
+        protected ProtectedConfigurationProvider();
+        public abstract XmlNode Decrypt(XmlNode encryptedNode);
+        public abstract XmlNode Encrypt(XmlNode node);
+    }
+    public class ProtectedConfigurationProviderCollection : ProviderCollection {
+        public ProtectedConfigurationProviderCollection();
+        public new ProtectedConfigurationProvider this[string name] { get; }
+        public override void Add(ProviderBase provider);
+    }
+    public sealed class ProtectedConfigurationSection : ConfigurationSection {
+        public ProtectedConfigurationSection();
+        public string DefaultProvider { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+    }
+    public class ProtectedProviderSettings : ConfigurationElement {
+        public ProtectedProviderSettings();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+    }
+    public sealed class ProviderSettings : ConfigurationElement {
+        public ProviderSettings();
+        public ProviderSettings(string name, string type);
+        public string Name { get; set; }
+        public NameValueCollection Parameters { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+        protected override bool IsModified();
+        protected override bool OnDeserializeUnrecognizedAttribute(string name, string value);
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public sealed class ProviderSettingsCollection : ConfigurationElementCollection {
+        public ProviderSettingsCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettings this[int index] { get; set; }
+        public new ProviderSettings this[string key] { get; }
+        public void Add(ProviderSettings provider);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+    }
+    public class RegexStringValidator : ConfigurationValidatorBase {
+        public RegexStringValidator(string regex);
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class RegexStringValidatorAttribute : ConfigurationValidatorAttribute {
+        public RegexStringValidatorAttribute(string regex);
+        public string Regex { get; }
+        public override ConfigurationValidatorBase ValidatorInstance { get; }
+    }
+    public sealed class RsaProtectedConfigurationProvider : ProtectedConfigurationProvider {
+        public RsaProtectedConfigurationProvider();
+        public string CspProviderName { get; }
+        public string KeyContainerName { get; }
+        public RSAParameters RsaPublicKey { get; }
+        public bool UseFIPS { get; }
+        public bool UseMachineContainer { get; }
+        public bool UseOAEP { get; }
+        public void AddKey(int keySize, bool exportable);
+        public override XmlNode Decrypt(XmlNode encryptedNode);
+        public void DeleteKey();
+        public override XmlNode Encrypt(XmlNode node);
+        public void ExportKey(string xmlFileName, bool includePrivateParameters);
+        public void ImportKey(string xmlFileName, bool exportable);
+        public override void Initialize(string name, NameValueCollection configurationValues);
+    }
+    public sealed class SchemeSettingElement : ConfigurationElement {
+        public SchemeSettingElement();
+        public GenericUriParserOptions GenericUriParserOptions { get; }
+        public string Name { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class SchemeSettingElementCollection : ConfigurationElementCollection {
+        public SchemeSettingElementCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        public SchemeSettingElement this[int index] { get; }
+        public new SchemeSettingElement this[string name] { get; }
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(SchemeSettingElement element);
+    }
+    public sealed class SectionInformation {
+        public ConfigurationAllowDefinition AllowDefinition { get; set; }
+        public ConfigurationAllowExeDefinition AllowExeDefinition { get; set; }
+        public bool AllowLocation { get; set; }
+        public bool AllowOverride { get; set; }
+        public string ConfigSource { get; set; }
+        public bool ForceSave { get; set; }
+        public bool InheritInChildApplications { get; set; }
+        public bool IsDeclarationRequired { get; }
+        public bool IsDeclared { get; }
+        public bool IsLocked { get; }
+        public bool IsProtected { get; }
+        public string Name { get; }
+        public OverrideMode OverrideMode { get; set; }
+        public OverrideMode OverrideModeDefault { get; set; }
+        public OverrideMode OverrideModeEffective { get; }
+        public ProtectedConfigurationProvider ProtectionProvider { get; }
+        public bool RequirePermission { get; set; }
+        public bool RestartOnExternalChanges { get; set; }
+        public string SectionName { get; }
+        public string Type { get; set; }
+        public void ForceDeclaration();
+        public void ForceDeclaration(bool force);
+        public ConfigurationSection GetParentSection();
+        public string GetRawXml();
+        public void ProtectSection(string protectionProvider);
+        public void RevertToParent();
+        public void SetRawXml(string rawXml);
+        public void UnprotectSection();
+    }
+    public class SettingAttribute : Attribute {
+        public SettingAttribute();
+    }
+    public class SettingChangingEventArgs : CancelEventArgs {
+        public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel);
+        public object NewValue { get; }
+        public string SettingClass { get; }
+        public string SettingKey { get; }
+        public string SettingName { get; }
+    }
+    public delegate void SettingChangingEventHandler(object sender, SettingChangingEventArgs e);
+    public sealed class SettingElement : ConfigurationElement {
+        public SettingElement();
+        public SettingElement(string name, SettingsSerializeAs serializeAs);
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SettingsSerializeAs SerializeAs { get; set; }
+        public SettingValueElement Value { get; set; }
+        public override bool Equals(object settings);
+        public override int GetHashCode();
+    }
+    public sealed class SettingElementCollection : ConfigurationElementCollection {
+        public SettingElementCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        public void Add(SettingElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        public SettingElement Get(string elementKey);
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(SettingElement element);
+    }
+    public class SettingsAttributeDictionary : Hashtable {
+        public SettingsAttributeDictionary();
+        public SettingsAttributeDictionary(SettingsAttributeDictionary attributes);
+    }
+    public abstract class SettingsBase {
+        protected SettingsBase();
+        public virtual SettingsContext Context { get; }
+        public bool IsSynchronized { get; }
+        public virtual SettingsPropertyCollection Properties { get; }
+        public virtual SettingsPropertyValueCollection PropertyValues { get; }
+        public virtual SettingsProviderCollection Providers { get; }
+        public virtual object this[string propertyName] { get; set; }
+        public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers);
+        public virtual void Save();
+        public static SettingsBase Synchronized(SettingsBase settingsBase);
+    }
+    public class SettingsContext : Hashtable {
+        public SettingsContext();
+    }
+    public sealed class SettingsDescriptionAttribute : Attribute {
+        public SettingsDescriptionAttribute(string description);
+        public string Description { get; }
+    }
+    public sealed class SettingsGroupDescriptionAttribute : Attribute {
+        public SettingsGroupDescriptionAttribute(string description);
+        public string Description { get; }
+    }
+    public sealed class SettingsGroupNameAttribute : Attribute {
+        public SettingsGroupNameAttribute(string groupName);
+        public string GroupName { get; }
+    }
+    public class SettingsLoadedEventArgs : EventArgs {
+        public SettingsLoadedEventArgs(SettingsProvider provider);
+        public SettingsProvider Provider { get; }
+    }
+    public delegate void SettingsLoadedEventHandler(object sender, SettingsLoadedEventArgs e);
+    public enum SettingsManageability {
+        Roaming = 0,
+    }
+    public sealed class SettingsManageabilityAttribute : Attribute {
+        public SettingsManageabilityAttribute(SettingsManageability manageability);
+        public SettingsManageability Manageability { get; }
+    }
+    public class SettingsProperty {
+        public SettingsProperty(SettingsProperty propertyToCopy);
+        public SettingsProperty(string name);
+        public SettingsProperty(string name, Type propertyType, SettingsProvider provider, bool isReadOnly, object defaultValue, SettingsSerializeAs serializeAs, SettingsAttributeDictionary attributes, bool throwOnErrorDeserializing, bool throwOnErrorSerializing);
+        public virtual SettingsAttributeDictionary Attributes { get; }
+        public virtual object DefaultValue { get; set; }
+        public virtual bool IsReadOnly { get; set; }
+        public virtual string Name { get; set; }
+        public virtual Type PropertyType { get; set; }
+        public virtual SettingsProvider Provider { get; set; }
+        public virtual SettingsSerializeAs SerializeAs { get; set; }
+        public bool ThrowOnErrorDeserializing { get; set; }
+        public bool ThrowOnErrorSerializing { get; set; }
+    }
+    public class SettingsPropertyCollection : ICloneable, ICollection, IEnumerable {
+        public SettingsPropertyCollection();
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public SettingsProperty this[string name] { get; }
+        public void Add(SettingsProperty property);
+        public void Clear();
+        public object Clone();
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        protected virtual void OnAdd(SettingsProperty property);
+        protected virtual void OnAddComplete(SettingsProperty property);
+        protected virtual void OnClear();
+        protected virtual void OnClearComplete();
+        protected virtual void OnRemove(SettingsProperty property);
+        protected virtual void OnRemoveComplete(SettingsProperty property);
+        public void Remove(string name);
+        public void SetReadOnly();
+    }
+    public class SettingsPropertyIsReadOnlyException : Exception {
+        public SettingsPropertyIsReadOnlyException();
+        protected SettingsPropertyIsReadOnlyException(SerializationInfo info, StreamingContext context);
+        public SettingsPropertyIsReadOnlyException(string message);
+        public SettingsPropertyIsReadOnlyException(string message, Exception innerException);
+    }
+    public class SettingsPropertyNotFoundException : Exception {
+        public SettingsPropertyNotFoundException();
+        protected SettingsPropertyNotFoundException(SerializationInfo info, StreamingContext context);
+        public SettingsPropertyNotFoundException(string message);
+        public SettingsPropertyNotFoundException(string message, Exception innerException);
+    }
+    public class SettingsPropertyValue {
+        public SettingsPropertyValue(SettingsProperty property);
+        public bool Deserialized { get; set; }
+        public bool IsDirty { get; set; }
+        public string Name { get; }
+        public SettingsProperty Property { get; }
+        public object PropertyValue { get; set; }
+        public object SerializedValue { get; set; }
+        public bool UsingDefaultValue { get; }
+    }
+    public class SettingsPropertyValueCollection : ICloneable, ICollection, IEnumerable {
+        public SettingsPropertyValueCollection();
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public SettingsPropertyValue this[string name] { get; }
+        public void Add(SettingsPropertyValue property);
+        public void Clear();
+        public object Clone();
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string name);
+        public void SetReadOnly();
+    }
+    public class SettingsPropertyWrongTypeException : Exception {
+        public SettingsPropertyWrongTypeException();
+        protected SettingsPropertyWrongTypeException(SerializationInfo info, StreamingContext context);
+        public SettingsPropertyWrongTypeException(string message);
+        public SettingsPropertyWrongTypeException(string message, Exception innerException);
+    }
+    public abstract class SettingsProvider : ProviderBase {
+        protected SettingsProvider();
+        public abstract string ApplicationName { get; set; }
+        public abstract SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection);
+        public abstract void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection);
+    }
+    public sealed class SettingsProviderAttribute : Attribute {
+        public SettingsProviderAttribute(string providerTypeName);
+        public SettingsProviderAttribute(Type providerType);
+        public string ProviderTypeName { get; }
+    }
+    public class SettingsProviderCollection : ProviderCollection {
+        public SettingsProviderCollection();
+        public new SettingsProvider this[string name] { get; }
+        public override void Add(ProviderBase provider);
+    }
+    public delegate void SettingsSavingEventHandler(object sender, CancelEventArgs e);
+    public enum SettingsSerializeAs {
+        Binary = 2,
+        ProviderSpecific = 3,
+        String = 0,
+        Xml = 1,
+    }
+    public sealed class SettingsSerializeAsAttribute : Attribute {
+        public SettingsSerializeAsAttribute(SettingsSerializeAs serializeAs);
+        public SettingsSerializeAs SerializeAs { get; }
+    }
+    public sealed class SettingValueElement : ConfigurationElement {
+        public SettingValueElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlNode ValueXml { get; set; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        public override bool Equals(object settingValue);
+        public override int GetHashCode();
+        protected override bool IsModified();
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override void ResetModified();
+        protected override bool SerializeToXmlElement(XmlWriter writer, string elementName);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public class SingleTagSectionHandler : IConfigurationSectionHandler {
+        public SingleTagSectionHandler();
+        public virtual object Create(object parent, object context, XmlNode section);
+    }
+    public enum SpecialSetting {
+        ConnectionString = 0,
+        WebServiceUrl = 1,
+    }
+    public sealed class SpecialSettingAttribute : Attribute {
+        public SpecialSettingAttribute(SpecialSetting specialSetting);
+        public SpecialSetting SpecialSetting { get; }
+    }
+    public class StringValidator : ConfigurationValidatorBase {
+        public StringValidator(int minLength);
+        public StringValidator(int minLength, int maxLength);
+        public StringValidator(int minLength, int maxLength, string invalidCharacters);
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class StringValidatorAttribute : ConfigurationValidatorAttribute {
+        public StringValidatorAttribute();
+        public string InvalidCharacters { get; set; }
+        public int MaxLength { get; set; }
+        public int MinLength { get; set; }
+        public override ConfigurationValidatorBase ValidatorInstance { get; }
+    }
+    public sealed class SubclassTypeValidator : ConfigurationValidatorBase {
+        public SubclassTypeValidator(Type baseClass);
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class SubclassTypeValidatorAttribute : ConfigurationValidatorAttribute {
+        public SubclassTypeValidatorAttribute(Type baseClass);
+        public Type BaseClass { get; }
+        public override ConfigurationValidatorBase ValidatorInstance { get; }
+    }
+    public class TimeSpanMinutesConverter : ConfigurationConverterBase {
+        public TimeSpanMinutesConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public sealed class TimeSpanMinutesOrInfiniteConverter : TimeSpanMinutesConverter {
+        public TimeSpanMinutesOrInfiniteConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public class TimeSpanSecondsConverter : ConfigurationConverterBase {
+        public TimeSpanSecondsConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public sealed class TimeSpanSecondsOrInfiniteConverter : TimeSpanSecondsConverter {
+        public TimeSpanSecondsOrInfiniteConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public class TimeSpanValidator : ConfigurationValidatorBase {
+        public TimeSpanValidator(TimeSpan minValue, TimeSpan maxValue);
+        public TimeSpanValidator(TimeSpan minValue, TimeSpan maxValue, bool rangeIsExclusive);
+        public TimeSpanValidator(TimeSpan minValue, TimeSpan maxValue, bool rangeIsExclusive, long resolutionInSeconds);
+        public override bool CanValidate(Type type);
+        public override void Validate(object value);
+    }
+    public sealed class TimeSpanValidatorAttribute : ConfigurationValidatorAttribute {
+        public const string TimeSpanMaxValue = "10675199.02:48:05.4775807";
+        public const string TimeSpanMinValue = "-10675199.02:48:05.4775808";
+        public TimeSpanValidatorAttribute();
+        public bool ExcludeRange { get; set; }
+        public TimeSpan MaxValue { get; }
+        public string MaxValueString { get; set; }
+        public TimeSpan MinValue { get; }
+        public string MinValueString { get; set; }
+        public override ConfigurationValidatorBase ValidatorInstance { get; }
+    }
+    public sealed class TypeNameConverter : ConfigurationConverterBase {
+        public TypeNameConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public sealed class UriSection : ConfigurationSection {
+        public UriSection();
+        public IdnElement Idn { get; }
+        public IriParsingElement IriParsing { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SchemeSettingElementCollection SchemeSettings { get; }
+    }
+    public sealed class UserScopedSettingAttribute : SettingAttribute {
+        public UserScopedSettingAttribute();
+    }
+    public sealed class UserSettingsGroup : ConfigurationSectionGroup {
+        public UserSettingsGroup();
+    }
+    public delegate void ValidatorCallback(object value);
+    public sealed class WhiteSpaceTrimStringConverter : ConfigurationConverterBase {
+        public WhiteSpaceTrimStringConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+}
```

