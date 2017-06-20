# System.ComponentModel.DataAnnotations

``` diff
+namespace System.ComponentModel.DataAnnotations {
+    public class AssociatedMetadataTypeTypeDescriptionProvider : TypeDescriptionProvider {
+        public AssociatedMetadataTypeTypeDescriptionProvider(Type type);
+        public AssociatedMetadataTypeTypeDescriptionProvider(Type type, Type associatedMetadataType);
+        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance);
+    }
+    public sealed class AssociationAttribute : Attribute {
+        public AssociationAttribute(string name, string thisKey, string otherKey);
+        public bool IsForeignKey { get; set; }
+        public string Name { get; }
+        public string OtherKey { get; }
+        public IEnumerable<string> OtherKeyMembers { get; }
+        public string ThisKey { get; }
+        public IEnumerable<string> ThisKeyMembers { get; }
+    }
+    public sealed class BindableTypeAttribute : Attribute {
+        public BindableTypeAttribute();
+        public bool IsBindable { get; set; }
+    }
+    public class CompareAttribute : ValidationAttribute {
+        public CompareAttribute(string otherProperty);
+        public string OtherProperty { get; private set; }
+        public string OtherPropertyDisplayName { get; internal set; }
+        public override bool RequiresValidationContext { get; }
+        public override string FormatErrorMessage(string name);
+        protected override ValidationResult IsValid(object value, ValidationContext validationContext);
+    }
+    public sealed class ConcurrencyCheckAttribute : Attribute {
+        public ConcurrencyCheckAttribute();
+    }
+    public sealed class CreditCardAttribute : DataTypeAttribute {
+        public CreditCardAttribute();
+        public override bool IsValid(object value);
+    }
+    public sealed class CustomValidationAttribute : ValidationAttribute {
+        public CustomValidationAttribute(Type validatorType, string method);
+        public string Method { get; }
+        public override object TypeId { get; }
+        public Type ValidatorType { get; }
+        public override string FormatErrorMessage(string name);
+        protected override ValidationResult IsValid(object value, ValidationContext validationContext);
+    }
+    public enum DataType {
+        CreditCard = 14,
+        Currency = 6,
+        Custom = 0,
+        Date = 2,
+        DateTime = 1,
+        Duration = 4,
+        EmailAddress = 10,
+        Html = 8,
+        ImageUrl = 13,
+        MultilineText = 9,
+        Password = 11,
+        PhoneNumber = 5,
+        PostalCode = 15,
+        Text = 7,
+        Time = 3,
+        Upload = 16,
+        Url = 12,
+    }
+    public class DataTypeAttribute : ValidationAttribute {
+        public DataTypeAttribute(DataType dataType);
+        public DataTypeAttribute(string customDataType);
+        public string CustomDataType { get; private set; }
+        public DataType DataType { get; private set; }
+        public DisplayFormatAttribute DisplayFormat { get; protected set; }
+        public virtual string GetDataTypeName();
+        public override bool IsValid(object value);
+    }
+    public sealed class DisplayAttribute : Attribute {
+        public DisplayAttribute();
+        public bool AutoGenerateField { get; set; }
+        public bool AutoGenerateFilter { get; set; }
+        public string Description { get; set; }
+        public string GroupName { get; set; }
+        public string Name { get; set; }
+        public int Order { get; set; }
+        public string Prompt { get; set; }
+        public Type ResourceType { get; set; }
+        public string ShortName { get; set; }
+        public Nullable<bool> GetAutoGenerateField();
+        public Nullable<bool> GetAutoGenerateFilter();
+        public string GetDescription();
+        public string GetGroupName();
+        public string GetName();
+        public Nullable<int> GetOrder();
+        public string GetPrompt();
+        public string GetShortName();
+    }
+    public class DisplayColumnAttribute : Attribute {
+        public DisplayColumnAttribute(string displayColumn);
+        public DisplayColumnAttribute(string displayColumn, string sortColumn);
+        public DisplayColumnAttribute(string displayColumn, string sortColumn, bool sortDescending);
+        public string DisplayColumn { get; private set; }
+        public string SortColumn { get; private set; }
+        public bool SortDescending { get; private set; }
+    }
+    public class DisplayFormatAttribute : Attribute {
+        public DisplayFormatAttribute();
+        public bool ApplyFormatInEditMode { get; set; }
+        public bool ConvertEmptyStringToNull { get; set; }
+        public string DataFormatString { get; set; }
+        public bool HtmlEncode { get; set; }
+        public string NullDisplayText { get; set; }
+    }
+    public sealed class EditableAttribute : Attribute {
+        public EditableAttribute(bool allowEdit);
+        public bool AllowEdit { get; private set; }
+        public bool AllowInitialValue { get; set; }
+    }
+    public sealed class EmailAddressAttribute : DataTypeAttribute {
+        public EmailAddressAttribute();
+        public override bool IsValid(object value);
+    }
+    public sealed class EnumDataTypeAttribute : DataTypeAttribute {
+        public EnumDataTypeAttribute(Type enumType);
+        public Type EnumType { get; private set; }
+        public override bool IsValid(object value);
+    }
+    public sealed class FileExtensionsAttribute : DataTypeAttribute {
+        public FileExtensionsAttribute();
+        public string Extensions { get; set; }
+        public override string FormatErrorMessage(string name);
+        public override bool IsValid(object value);
+    }
+    public sealed class FilterUIHintAttribute : Attribute {
+        public FilterUIHintAttribute(string filterUIHint);
+        public FilterUIHintAttribute(string filterUIHint, string presentationLayer);
+        public FilterUIHintAttribute(string filterUIHint, string presentationLayer, params object[] controlParameters);
+        public IDictionary<string, object> ControlParameters { get; }
+        public string FilterUIHint { get; }
+        public string PresentationLayer { get; }
+        public override object TypeId { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public interface IValidatableObject {
+        IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
+    }
+    public sealed class KeyAttribute : Attribute {
+        public KeyAttribute();
+    }
+    public class MaxLengthAttribute : ValidationAttribute {
+        public MaxLengthAttribute();
+        public MaxLengthAttribute(int length);
+        public int Length { get; private set; }
+        public override string FormatErrorMessage(string name);
+        public override bool IsValid(object value);
+    }
+    public sealed class MetadataTypeAttribute : Attribute {
+        public MetadataTypeAttribute(Type metadataClassType);
+        public Type MetadataClassType { get; }
+    }
+    public class MinLengthAttribute : ValidationAttribute {
+        public MinLengthAttribute(int length);
+        public int Length { get; private set; }
+        public override string FormatErrorMessage(string name);
+        public override bool IsValid(object value);
+    }
+    public sealed class PhoneAttribute : DataTypeAttribute {
+        public PhoneAttribute();
+        public override bool IsValid(object value);
+    }
+    public class RangeAttribute : ValidationAttribute {
+        public RangeAttribute(double minimum, double maximum);
+        public RangeAttribute(int minimum, int maximum);
+        public RangeAttribute(Type type, string minimum, string maximum);
+        public object Maximum { get; private set; }
+        public object Minimum { get; private set; }
+        public Type OperandType { get; private set; }
+        public override string FormatErrorMessage(string name);
+        public override bool IsValid(object value);
+    }
+    public class RegularExpressionAttribute : ValidationAttribute {
+        public RegularExpressionAttribute(string pattern);
+        public int MatchTimeoutInMilliseconds { get; set; }
+        public string Pattern { get; private set; }
+        public override string FormatErrorMessage(string name);
+        public override bool IsValid(object value);
+    }
+    public class RequiredAttribute : ValidationAttribute {
+        public RequiredAttribute();
+        public bool AllowEmptyStrings { get; set; }
+        public override bool IsValid(object value);
+    }
+    public class ScaffoldColumnAttribute : Attribute {
+        public ScaffoldColumnAttribute(bool scaffold);
+        public bool Scaffold { get; private set; }
+    }
+    public class ScaffoldTableAttribute : Attribute {
+        public ScaffoldTableAttribute(bool scaffold);
+        public bool Scaffold { get; private set; }
+    }
+    public class StringLengthAttribute : ValidationAttribute {
+        public StringLengthAttribute(int maximumLength);
+        public int MaximumLength { get; private set; }
+        public int MinimumLength { get; set; }
+        public override string FormatErrorMessage(string name);
+        public override bool IsValid(object value);
+    }
+    public sealed class TimestampAttribute : Attribute {
+        public TimestampAttribute();
+    }
+    public class UIHintAttribute : Attribute {
+        public UIHintAttribute(string uiHint);
+        public UIHintAttribute(string uiHint, string presentationLayer);
+        public UIHintAttribute(string uiHint, string presentationLayer, params object[] controlParameters);
+        public IDictionary<string, object> ControlParameters { get; }
+        public string PresentationLayer { get; }
+        public override object TypeId { get; }
+        public string UIHint { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class UrlAttribute : DataTypeAttribute {
+        public UrlAttribute();
+        public override bool IsValid(object value);
+    }
+    public abstract class ValidationAttribute : Attribute {
+        protected ValidationAttribute();
+        protected ValidationAttribute(Func<string> errorMessageAccessor);
+        protected ValidationAttribute(string errorMessage);
+        public string ErrorMessage { get; set; }
+        public string ErrorMessageResourceName { get; set; }
+        public Type ErrorMessageResourceType { get; set; }
+        protected string ErrorMessageString { get; }
+        public virtual bool RequiresValidationContext { get; }
+        public virtual string FormatErrorMessage(string name);
+        public ValidationResult GetValidationResult(object value, ValidationContext validationContext);
+        public virtual bool IsValid(object value);
+        protected virtual ValidationResult IsValid(object value, ValidationContext validationContext);
+        public void Validate(object value, ValidationContext validationContext);
+        public void Validate(object value, string name);
+    }
+    public sealed class ValidationContext : IServiceProvider {
+        public ValidationContext(object instance);
+        public ValidationContext(object instance, IDictionary<object, object> items);
+        public ValidationContext(object instance, IServiceProvider serviceProvider, IDictionary<object, object> items);
+        public string DisplayName { get; set; }
+        public IDictionary<object, object> Items { get; }
+        public string MemberName { get; set; }
+        public object ObjectInstance { get; }
+        public Type ObjectType { get; }
+        public IServiceContainer ServiceContainer { get; }
+        public object GetService(Type serviceType);
+        public void InitializeServiceProvider(Func<Type, object> serviceProvider);
+    }
+    public class ValidationException : Exception {
+        public ValidationException();
+        public ValidationException(ValidationResult validationResult, ValidationAttribute validatingAttribute, object value);
+        protected ValidationException(SerializationInfo info, StreamingContext context);
+        public ValidationException(string message);
+        public ValidationException(string errorMessage, ValidationAttribute validatingAttribute, object value);
+        public ValidationException(string message, Exception innerException);
+        public ValidationAttribute ValidationAttribute { get; private set; }
+        public ValidationResult ValidationResult { get; }
+        public object Value { get; private set; }
+    }
+    public class ValidationResult {
+        public static readonly ValidationResult Success;
+        protected ValidationResult(ValidationResult validationResult);
+        public ValidationResult(string errorMessage);
+        public ValidationResult(string errorMessage, IEnumerable<string> memberNames);
+        public string ErrorMessage { get; set; }
+        public IEnumerable<string> MemberNames { get; }
+        public override string ToString();
+    }
+    public static class Validator {
+        public static bool TryValidateObject(object instance, ValidationContext validationContext, ICollection<ValidationResult> validationResults);
+        public static bool TryValidateObject(object instance, ValidationContext validationContext, ICollection<ValidationResult> validationResults, bool validateAllProperties);
+        public static bool TryValidateProperty(object value, ValidationContext validationContext, ICollection<ValidationResult> validationResults);
+        public static bool TryValidateValue(object value, ValidationContext validationContext, ICollection<ValidationResult> validationResults, IEnumerable<ValidationAttribute> validationAttributes);
+        public static void ValidateObject(object instance, ValidationContext validationContext);
+        public static void ValidateObject(object instance, ValidationContext validationContext, bool validateAllProperties);
+        public static void ValidateProperty(object value, ValidationContext validationContext);
+        public static void ValidateValue(object value, ValidationContext validationContext, IEnumerable<ValidationAttribute> validationAttributes);
+    }
+}
```

