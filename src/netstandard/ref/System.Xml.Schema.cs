// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Xml.Schema
{
    public static partial class Extensions
    {
        public static System.Xml.Schema.IXmlSchemaInfo GetSchemaInfo(this System.Xml.Linq.XAttribute source) { throw null; }
        public static System.Xml.Schema.IXmlSchemaInfo GetSchemaInfo(this System.Xml.Linq.XElement source) { throw null; }
        public static void Validate(this System.Xml.Linq.XAttribute source, System.Xml.Schema.XmlSchemaObject partialValidationType, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.ValidationEventHandler validationEventHandler) { }
        public static void Validate(this System.Xml.Linq.XAttribute source, System.Xml.Schema.XmlSchemaObject partialValidationType, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.ValidationEventHandler validationEventHandler, bool addSchemaInfo) { }
        public static void Validate(this System.Xml.Linq.XDocument source, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.ValidationEventHandler validationEventHandler) { }
        public static void Validate(this System.Xml.Linq.XDocument source, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.ValidationEventHandler validationEventHandler, bool addSchemaInfo) { }
        public static void Validate(this System.Xml.Linq.XElement source, System.Xml.Schema.XmlSchemaObject partialValidationType, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.ValidationEventHandler validationEventHandler) { }
        public static void Validate(this System.Xml.Linq.XElement source, System.Xml.Schema.XmlSchemaObject partialValidationType, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.ValidationEventHandler validationEventHandler, bool addSchemaInfo) { }
    }
    public partial interface IXmlSchemaInfo
    {
        bool IsDefault { get; }
        bool IsNil { get; }
        System.Xml.Schema.XmlSchemaSimpleType MemberType { get; }
        System.Xml.Schema.XmlSchemaAttribute SchemaAttribute { get; }
        System.Xml.Schema.XmlSchemaElement SchemaElement { get; }
        System.Xml.Schema.XmlSchemaType SchemaType { get; }
        System.Xml.Schema.XmlSchemaValidity Validity { get; }
    }
    public partial class ValidationEventArgs : System.EventArgs
    {
        internal ValidationEventArgs() { }
        public System.Xml.Schema.XmlSchemaException Exception { get { throw null; } }
        public string Message { get { throw null; } }
        public System.Xml.Schema.XmlSeverityType Severity { get { throw null; } }
    }
    public delegate void ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e);
    public sealed partial class XmlAtomicValue : System.Xml.XPath.XPathItem, System.ICloneable
    {
        internal XmlAtomicValue() { }
        public override bool IsNode { get { throw null; } }
        public override object TypedValue { get { throw null; } }
        public override string Value { get { throw null; } }
        public override bool ValueAsBoolean { get { throw null; } }
        public override System.DateTime ValueAsDateTime { get { throw null; } }
        public override double ValueAsDouble { get { throw null; } }
        public override int ValueAsInt { get { throw null; } }
        public override long ValueAsLong { get { throw null; } }
        public override System.Type ValueType { get { throw null; } }
        public override System.Xml.Schema.XmlSchemaType XmlType { get { throw null; } }
        public System.Xml.Schema.XmlAtomicValue Clone() { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public override object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver) { throw null; }
    }
    [System.Xml.Serialization.XmlRootAttribute("schema", Namespace="http://www.w3.org/2001/XMLSchema")]
    public partial class XmlSchema : System.Xml.Schema.XmlSchemaObject
    {
        public const string InstanceNamespace = "http://www.w3.org/2001/XMLSchema-instance";
        public const string Namespace = "http://www.w3.org/2001/XMLSchema";
        public XmlSchema() { }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaForm.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("attributeFormDefault")]
        public System.Xml.Schema.XmlSchemaForm AttributeFormDefault { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable AttributeGroups { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Attributes { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaDerivationMethod.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("blockDefault")]
        public System.Xml.Schema.XmlSchemaDerivationMethod BlockDefault { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaForm.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("elementFormDefault")]
        public System.Xml.Schema.XmlSchemaForm ElementFormDefault { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Elements { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaDerivationMethod.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("finalDefault")]
        public System.Xml.Schema.XmlSchemaDerivationMethod FinalDefault { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Groups { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("import", typeof(System.Xml.Schema.XmlSchemaImport))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(System.Xml.Schema.XmlSchemaInclude))]
        [System.Xml.Serialization.XmlElementAttribute("redefine", typeof(System.Xml.Schema.XmlSchemaRedefine))]
        public System.Xml.Schema.XmlSchemaObjectCollection Includes { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool IsCompiled { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroup))]
        [System.Xml.Serialization.XmlElementAttribute("complexType", typeof(System.Xml.Schema.XmlSchemaComplexType))]
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(System.Xml.Schema.XmlSchemaElement))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroup))]
        [System.Xml.Serialization.XmlElementAttribute("notation", typeof(System.Xml.Schema.XmlSchemaNotation))]
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Notations { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable SchemaTypes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("targetNamespace", DataType="anyURI")]
        public string TargetNamespace { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] UnhandledAttributes { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("version", DataType="token")]
        public string Version { get { throw null; } set { } }
        [System.ObsoleteAttribute("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
        public void Compile(System.Xml.Schema.ValidationEventHandler validationEventHandler) { }
        [System.ObsoleteAttribute("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
        public void Compile(System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlResolver resolver) { }
        public static System.Xml.Schema.XmlSchema Read(System.IO.Stream stream, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public static System.Xml.Schema.XmlSchema Read(System.IO.TextReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public static System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public void Write(System.IO.Stream stream) { }
        public void Write(System.IO.Stream stream, System.Xml.XmlNamespaceManager namespaceManager) { }
        public void Write(System.IO.TextWriter writer) { }
        public void Write(System.IO.TextWriter writer, System.Xml.XmlNamespaceManager namespaceManager) { }
        public void Write(System.Xml.XmlWriter writer) { }
        public void Write(System.Xml.XmlWriter writer, System.Xml.XmlNamespaceManager namespaceManager) { }
    }
    public partial class XmlSchemaAll : System.Xml.Schema.XmlSchemaGroupBase
    {
        public XmlSchemaAll() { }
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(System.Xml.Schema.XmlSchemaElement))]
        public override System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
    }
    public partial class XmlSchemaAnnotated : System.Xml.Schema.XmlSchemaObject
    {
        public XmlSchemaAnnotated() { }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        public System.Xml.Schema.XmlSchemaAnnotation Annotation { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] UnhandledAttributes { get { throw null; } set { } }
    }
    public partial class XmlSchemaAnnotation : System.Xml.Schema.XmlSchemaObject
    {
        public XmlSchemaAnnotation() { }
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("appinfo", typeof(System.Xml.Schema.XmlSchemaAppInfo))]
        [System.Xml.Serialization.XmlElementAttribute("documentation", typeof(System.Xml.Schema.XmlSchemaDocumentation))]
        public System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] UnhandledAttributes { get { throw null; } set { } }
    }
    public partial class XmlSchemaAny : System.Xml.Schema.XmlSchemaParticle
    {
        public XmlSchemaAny() { }
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaContentProcessing.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("processContents")]
        public System.Xml.Schema.XmlSchemaContentProcessing ProcessContents { get { throw null; } set { } }
    }
    public partial class XmlSchemaAnyAttribute : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaAnyAttribute() { }
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaContentProcessing.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("processContents")]
        public System.Xml.Schema.XmlSchemaContentProcessing ProcessContents { get { throw null; } set { } }
    }
    public partial class XmlSchemaAppInfo : System.Xml.Schema.XmlSchemaObject
    {
        public XmlSchemaAppInfo() { }
        [System.Xml.Serialization.XmlAnyElementAttribute]
        [System.Xml.Serialization.XmlTextAttribute]
        public System.Xml.XmlNode[] Markup { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("source", DataType="anyURI")]
        public string Source { get { throw null; } set { } }
    }
    public partial class XmlSchemaAttribute : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaAttribute() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaSimpleType AttributeSchemaType { get { throw null; } }
        [System.ObsoleteAttribute("This property has been deprecated. Please use AttributeSchemaType property that returns a strongly typed attribute type. https://go.microsoft.com/fwlink/?linkid=14202")]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public object AttributeType { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("default")]
        public string DefaultValue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("fixed")]
        public string FixedValue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaForm.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        public System.Xml.Schema.XmlSchemaForm Form { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public System.Xml.XmlQualifiedName RefName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("simpleType")]
        public System.Xml.Schema.XmlSchemaSimpleType SchemaType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public System.Xml.XmlQualifiedName SchemaTypeName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaUse.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("use")]
        public System.Xml.Schema.XmlSchemaUse Use { get { throw null; } set { } }
    }
    public partial class XmlSchemaAttributeGroup : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaAttributeGroup() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaAttributeGroup RedefinedAttributeGroup { get { throw null; } }
    }
    public partial class XmlSchemaAttributeGroupRef : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaAttributeGroupRef() { }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public System.Xml.XmlQualifiedName RefName { get { throw null; } set { } }
    }
    public partial class XmlSchemaChoice : System.Xml.Schema.XmlSchemaGroupBase
    {
        public XmlSchemaChoice() { }
        [System.Xml.Serialization.XmlElementAttribute("any", typeof(System.Xml.Schema.XmlSchemaAny))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(System.Xml.Schema.XmlSchemaElement))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public override System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
    }
    [System.ObsoleteAttribute("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
    public sealed partial class XmlSchemaCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public XmlSchemaCollection() { }
        public XmlSchemaCollection(System.Xml.XmlNameTable nametable) { }
        public int Count { get { throw null; } }
        public System.Xml.Schema.XmlSchema this[string ns] { get { throw null; } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public System.Xml.Schema.XmlSchema Add(string ns, string uri) { throw null; }
        public System.Xml.Schema.XmlSchema Add(string ns, System.Xml.XmlReader reader) { throw null; }
        public System.Xml.Schema.XmlSchema Add(string ns, System.Xml.XmlReader reader, System.Xml.XmlResolver resolver) { throw null; }
        public System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema) { throw null; }
        public System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema, System.Xml.XmlResolver resolver) { throw null; }
        public void Add(System.Xml.Schema.XmlSchemaCollection schema) { }
        public bool Contains(string ns) { throw null; }
        public bool Contains(System.Xml.Schema.XmlSchema schema) { throw null; }
        public void CopyTo(System.Xml.Schema.XmlSchema[] array, int index) { }
        public System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class XmlSchemaCollectionEnumerator : System.Collections.IEnumerator
    {
        internal XmlSchemaCollectionEnumerator() { }
        public System.Xml.Schema.XmlSchema Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        bool System.Collections.IEnumerator.MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public sealed partial class XmlSchemaCompilationSettings
    {
        public XmlSchemaCompilationSettings() { }
        public bool EnableUpaCheck { get { throw null; } set { } }
    }
    public partial class XmlSchemaComplexContent : System.Xml.Schema.XmlSchemaContentModel
    {
        public XmlSchemaComplexContent() { }
        [System.Xml.Serialization.XmlElementAttribute("extension", typeof(System.Xml.Schema.XmlSchemaComplexContentExtension))]
        [System.Xml.Serialization.XmlElementAttribute("restriction", typeof(System.Xml.Schema.XmlSchemaComplexContentRestriction))]
        public override System.Xml.Schema.XmlSchemaContent Content { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("mixed")]
        public bool IsMixed { get { throw null; } set { } }
    }
    public partial class XmlSchemaComplexContentExtension : System.Xml.Schema.XmlSchemaContent
    {
        public XmlSchemaComplexContentExtension() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(System.Xml.Schema.XmlSchemaAll))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public System.Xml.Schema.XmlSchemaParticle Particle { get { throw null; } set { } }
    }
    public partial class XmlSchemaComplexContentRestriction : System.Xml.Schema.XmlSchemaContent
    {
        public XmlSchemaComplexContentRestriction() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(System.Xml.Schema.XmlSchemaAll))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public System.Xml.Schema.XmlSchemaParticle Particle { get { throw null; } set { } }
    }
    public partial class XmlSchemaComplexType : System.Xml.Schema.XmlSchemaType
    {
        public XmlSchemaComplexType() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable AttributeUses { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaAnyAttribute AttributeWildcard { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaDerivationMethod.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("block")]
        public System.Xml.Schema.XmlSchemaDerivationMethod Block { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod BlockResolved { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("complexContent", typeof(System.Xml.Schema.XmlSchemaComplexContent))]
        [System.Xml.Serialization.XmlElementAttribute("simpleContent", typeof(System.Xml.Schema.XmlSchemaSimpleContent))]
        public System.Xml.Schema.XmlSchemaContentModel ContentModel { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaContentType ContentType { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaParticle ContentTypeParticle { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("abstract")]
        public bool IsAbstract { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("mixed")]
        public override bool IsMixed { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(System.Xml.Schema.XmlSchemaAll))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public System.Xml.Schema.XmlSchemaParticle Particle { get { throw null; } set { } }
    }
    public abstract partial class XmlSchemaContent : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaContent() { }
    }
    public abstract partial class XmlSchemaContentModel : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaContentModel() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public abstract System.Xml.Schema.XmlSchemaContent Content { get; set; }
    }
    public enum XmlSchemaContentProcessing
    {
        [System.Xml.Serialization.XmlEnumAttribute("lax")]
        Lax = 2,
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 0,
        [System.Xml.Serialization.XmlEnumAttribute("skip")]
        Skip = 1,
        [System.Xml.Serialization.XmlEnumAttribute("strict")]
        Strict = 3,
    }
    public enum XmlSchemaContentType
    {
        ElementOnly = 2,
        Empty = 1,
        Mixed = 3,
        TextOnly = 0,
    }
    public abstract partial class XmlSchemaDatatype
    {
        internal XmlSchemaDatatype() { }
        public abstract System.Xml.XmlTokenizedType TokenizedType { get; }
        public virtual System.Xml.Schema.XmlTypeCode TypeCode { get { throw null; } }
        public abstract System.Type ValueType { get; }
        public virtual System.Xml.Schema.XmlSchemaDatatypeVariety Variety { get { throw null; } }
        public virtual object ChangeType(object value, System.Type targetType) { throw null; }
        public virtual object ChangeType(object value, System.Type targetType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype) { throw null; }
        public abstract object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
    }
    public enum XmlSchemaDatatypeVariety
    {
        Atomic = 0,
        List = 1,
        Union = 2,
    }
    [System.FlagsAttribute]
    public enum XmlSchemaDerivationMethod
    {
        [System.Xml.Serialization.XmlEnumAttribute("#all")]
        All = 255,
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Empty = 0,
        [System.Xml.Serialization.XmlEnumAttribute("extension")]
        Extension = 2,
        [System.Xml.Serialization.XmlEnumAttribute("list")]
        List = 8,
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 256,
        [System.Xml.Serialization.XmlEnumAttribute("restriction")]
        Restriction = 4,
        [System.Xml.Serialization.XmlEnumAttribute("substitution")]
        Substitution = 1,
        [System.Xml.Serialization.XmlEnumAttribute("union")]
        Union = 16,
    }
    public partial class XmlSchemaDocumentation : System.Xml.Schema.XmlSchemaObject
    {
        public XmlSchemaDocumentation() { }
        [System.Xml.Serialization.XmlAttributeAttribute("xml:lang")]
        public string Language { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyElementAttribute]
        [System.Xml.Serialization.XmlTextAttribute]
        public System.Xml.XmlNode[] Markup { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("source", DataType="anyURI")]
        public string Source { get { throw null; } set { } }
    }
    public partial class XmlSchemaElement : System.Xml.Schema.XmlSchemaParticle
    {
        public XmlSchemaElement() { }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaDerivationMethod.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("block")]
        public System.Xml.Schema.XmlSchemaDerivationMethod Block { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod BlockResolved { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("key", typeof(System.Xml.Schema.XmlSchemaKey))]
        [System.Xml.Serialization.XmlElementAttribute("keyref", typeof(System.Xml.Schema.XmlSchemaKeyref))]
        [System.Xml.Serialization.XmlElementAttribute("unique", typeof(System.Xml.Schema.XmlSchemaUnique))]
        public System.Xml.Schema.XmlSchemaObjectCollection Constraints { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("default")]
        public string DefaultValue { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaType ElementSchemaType { get { throw null; } }
        [System.ObsoleteAttribute("This property has been deprecated. Please use ElementSchemaType property that returns a strongly typed element type. https://go.microsoft.com/fwlink/?linkid=14202")]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public object ElementType { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaDerivationMethod.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("final")]
        public System.Xml.Schema.XmlSchemaDerivationMethod Final { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod FinalResolved { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("fixed")]
        public string FixedValue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaForm.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        public System.Xml.Schema.XmlSchemaForm Form { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("abstract")]
        public bool IsAbstract { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("nillable")]
        public bool IsNillable { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public System.Xml.XmlQualifiedName RefName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("complexType", typeof(System.Xml.Schema.XmlSchemaComplexType))]
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaType SchemaType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public System.Xml.XmlQualifiedName SchemaTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("substitutionGroup")]
        public System.Xml.XmlQualifiedName SubstitutionGroup { get { throw null; } set { } }
    }
    public partial class XmlSchemaEnumerationFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaEnumerationFacet() { }
    }
    public partial class XmlSchemaException : System.SystemException
    {
        public XmlSchemaException() { }
        protected XmlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XmlSchemaException(string message) { }
        public XmlSchemaException(string message, System.Exception innerException) { }
        public XmlSchemaException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string Message { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObject SourceSchemaObject { get { throw null; } }
        public string SourceUri { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class XmlSchemaExternal : System.Xml.Schema.XmlSchemaObject
    {
        protected XmlSchemaExternal() { }
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchema Schema { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("schemaLocation", DataType="anyURI")]
        public string SchemaLocation { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] UnhandledAttributes { get { throw null; } set { } }
    }
    public abstract partial class XmlSchemaFacet : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaFacet() { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("fixed")]
        public virtual bool IsFixed { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get { throw null; } set { } }
    }
    public enum XmlSchemaForm
    {
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 0,
        [System.Xml.Serialization.XmlEnumAttribute("qualified")]
        Qualified = 1,
        [System.Xml.Serialization.XmlEnumAttribute("unqualified")]
        Unqualified = 2,
    }
    public partial class XmlSchemaFractionDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaFractionDigitsFacet() { }
    }
    public partial class XmlSchemaGroup : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaGroup() { }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(System.Xml.Schema.XmlSchemaAll))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public System.Xml.Schema.XmlSchemaGroupBase Particle { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
    }
    public abstract partial class XmlSchemaGroupBase : System.Xml.Schema.XmlSchemaParticle
    {
        internal XmlSchemaGroupBase() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public abstract System.Xml.Schema.XmlSchemaObjectCollection Items { get; }
    }
    public partial class XmlSchemaGroupRef : System.Xml.Schema.XmlSchemaParticle
    {
        public XmlSchemaGroupRef() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaGroupBase Particle { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public System.Xml.XmlQualifiedName RefName { get { throw null; } set { } }
    }
    public partial class XmlSchemaIdentityConstraint : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaIdentityConstraint() { }
        [System.Xml.Serialization.XmlElementAttribute("field", typeof(System.Xml.Schema.XmlSchemaXPath))]
        public System.Xml.Schema.XmlSchemaObjectCollection Fields { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("selector", typeof(System.Xml.Schema.XmlSchemaXPath))]
        public System.Xml.Schema.XmlSchemaXPath Selector { get { throw null; } set { } }
    }
    public partial class XmlSchemaImport : System.Xml.Schema.XmlSchemaExternal
    {
        public XmlSchemaImport() { }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        public System.Xml.Schema.XmlSchemaAnnotation Annotation { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("namespace", DataType="anyURI")]
        public string Namespace { get { throw null; } set { } }
    }
    public partial class XmlSchemaInclude : System.Xml.Schema.XmlSchemaExternal
    {
        public XmlSchemaInclude() { }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        public System.Xml.Schema.XmlSchemaAnnotation Annotation { get { throw null; } set { } }
    }
    public sealed partial class XmlSchemaInference
    {
        public XmlSchemaInference() { }
        public System.Xml.Schema.XmlSchemaInference.InferenceOption Occurrence { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaInference.InferenceOption TypeInference { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument) { throw null; }
        public System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas) { throw null; }
        public enum InferenceOption
        {
            Relaxed = 1,
            Restricted = 0,
        }
    }
    public partial class XmlSchemaInferenceException : System.Xml.Schema.XmlSchemaException
    {
        public XmlSchemaInferenceException() { }
        protected XmlSchemaInferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XmlSchemaInferenceException(string message) { }
        public XmlSchemaInferenceException(string message, System.Exception innerException) { }
        public XmlSchemaInferenceException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class XmlSchemaInfo : System.Xml.Schema.IXmlSchemaInfo
    {
        public XmlSchemaInfo() { }
        public System.Xml.Schema.XmlSchemaContentType ContentType { get { throw null; } set { } }
        public bool IsDefault { get { throw null; } set { } }
        public bool IsNil { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaSimpleType MemberType { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaAttribute SchemaAttribute { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaElement SchemaElement { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaType SchemaType { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaValidity Validity { get { throw null; } set { } }
    }
    public partial class XmlSchemaKey : System.Xml.Schema.XmlSchemaIdentityConstraint
    {
        public XmlSchemaKey() { }
    }
    public partial class XmlSchemaKeyref : System.Xml.Schema.XmlSchemaIdentityConstraint
    {
        public XmlSchemaKeyref() { }
        [System.Xml.Serialization.XmlAttributeAttribute("refer")]
        public System.Xml.XmlQualifiedName Refer { get { throw null; } set { } }
    }
    public partial class XmlSchemaLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaLengthFacet() { }
    }
    public partial class XmlSchemaMaxExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaMaxExclusiveFacet() { }
    }
    public partial class XmlSchemaMaxInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaMaxInclusiveFacet() { }
    }
    public partial class XmlSchemaMaxLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaMaxLengthFacet() { }
    }
    public partial class XmlSchemaMinExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaMinExclusiveFacet() { }
    }
    public partial class XmlSchemaMinInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaMinInclusiveFacet() { }
    }
    public partial class XmlSchemaMinLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaMinLengthFacet() { }
    }
    public partial class XmlSchemaNotation : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaNotation() { }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("public")]
        public string Public { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("system")]
        public string System { get { throw null; } set { } }
    }
    public abstract partial class XmlSchemaNumericFacet : System.Xml.Schema.XmlSchemaFacet
    {
        protected XmlSchemaNumericFacet() { }
    }
    public abstract partial class XmlSchemaObject
    {
        protected XmlSchemaObject() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int LineNumber { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int LinePosition { get { throw null; } set { } }
        [System.Xml.Serialization.XmlNamespaceDeclarationsAttribute]
        public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObject Parent { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string SourceUri { get { throw null; } set { } }
    }
    public partial class XmlSchemaObjectCollection : System.Collections.CollectionBase
    {
        public XmlSchemaObjectCollection() { }
        public XmlSchemaObjectCollection(System.Xml.Schema.XmlSchemaObject parent) { }
        public virtual System.Xml.Schema.XmlSchemaObject this[int index] { get { throw null; } set { } }
        public int Add(System.Xml.Schema.XmlSchemaObject item) { throw null; }
        public bool Contains(System.Xml.Schema.XmlSchemaObject item) { throw null; }
        public void CopyTo(System.Xml.Schema.XmlSchemaObject[] array, int index) { }
        public new System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Xml.Schema.XmlSchemaObject item) { throw null; }
        public void Insert(int index, System.Xml.Schema.XmlSchemaObject item) { }
        protected override void OnClear() { }
        protected override void OnInsert(int index, object item) { }
        protected override void OnRemove(int index, object item) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        public void Remove(System.Xml.Schema.XmlSchemaObject item) { }
    }
    public partial class XmlSchemaObjectEnumerator : System.Collections.IEnumerator
    {
        internal XmlSchemaObjectEnumerator() { }
        public System.Xml.Schema.XmlSchemaObject Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
        bool System.Collections.IEnumerator.MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public partial class XmlSchemaObjectTable
    {
        internal XmlSchemaObjectTable() { }
        public int Count { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObject this[System.Xml.XmlQualifiedName name] { get { throw null; } }
        public System.Collections.ICollection Names { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public bool Contains(System.Xml.XmlQualifiedName name) { throw null; }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
    }
    public abstract partial class XmlSchemaParticle : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaParticle() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public decimal MaxOccurs { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("maxOccurs")]
        public string MaxOccursString { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public decimal MinOccurs { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("minOccurs")]
        public string MinOccursString { get { throw null; } set { } }
    }
    public partial class XmlSchemaPatternFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaPatternFacet() { }
    }
    public partial class XmlSchemaRedefine : System.Xml.Schema.XmlSchemaExternal
    {
        public XmlSchemaRedefine() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable AttributeGroups { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Groups { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroup))]
        [System.Xml.Serialization.XmlElementAttribute("complexType", typeof(System.Xml.Schema.XmlSchemaComplexType))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroup))]
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable SchemaTypes { get { throw null; } }
    }
    public partial class XmlSchemaSequence : System.Xml.Schema.XmlSchemaGroupBase
    {
        public XmlSchemaSequence() { }
        [System.Xml.Serialization.XmlElementAttribute("any", typeof(System.Xml.Schema.XmlSchemaAny))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(System.Xml.Schema.XmlSchemaElement))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public override System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
    }
    public partial class XmlSchemaSet
    {
        public XmlSchemaSet() { }
        public XmlSchemaSet(System.Xml.XmlNameTable nameTable) { }
        public System.Xml.Schema.XmlSchemaCompilationSettings CompilationSettings { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObjectTable GlobalAttributes { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObjectTable GlobalElements { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObjectTable GlobalTypes { get { throw null; } }
        public bool IsCompiled { get { throw null; } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public System.Xml.Schema.XmlSchema Add(string targetNamespace, string schemaUri) { throw null; }
        public System.Xml.Schema.XmlSchema Add(string targetNamespace, System.Xml.XmlReader schemaDocument) { throw null; }
        public System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema) { throw null; }
        public void Add(System.Xml.Schema.XmlSchemaSet schemas) { }
        public void Compile() { }
        public bool Contains(string targetNamespace) { throw null; }
        public bool Contains(System.Xml.Schema.XmlSchema schema) { throw null; }
        public void CopyTo(System.Xml.Schema.XmlSchema[] schemas, int index) { }
        public System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema) { throw null; }
        public bool RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove) { throw null; }
        public System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema) { throw null; }
        public System.Collections.ICollection Schemas() { throw null; }
        public System.Collections.ICollection Schemas(string targetNamespace) { throw null; }
    }
    public partial class XmlSchemaSimpleContent : System.Xml.Schema.XmlSchemaContentModel
    {
        public XmlSchemaSimpleContent() { }
        [System.Xml.Serialization.XmlElementAttribute("extension", typeof(System.Xml.Schema.XmlSchemaSimpleContentExtension))]
        [System.Xml.Serialization.XmlElementAttribute("restriction", typeof(System.Xml.Schema.XmlSchemaSimpleContentRestriction))]
        public override System.Xml.Schema.XmlSchemaContent Content { get { throw null; } set { } }
    }
    public partial class XmlSchemaSimpleContentExtension : System.Xml.Schema.XmlSchemaContent
    {
        public XmlSchemaSimpleContentExtension() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
    }
    public partial class XmlSchemaSimpleContentRestriction : System.Xml.Schema.XmlSchemaContent
    {
        public XmlSchemaSimpleContentRestriction() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaSimpleType BaseType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("enumeration", typeof(System.Xml.Schema.XmlSchemaEnumerationFacet))]
        [System.Xml.Serialization.XmlElementAttribute("fractionDigits", typeof(System.Xml.Schema.XmlSchemaFractionDigitsFacet))]
        [System.Xml.Serialization.XmlElementAttribute("length", typeof(System.Xml.Schema.XmlSchemaLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxExclusive", typeof(System.Xml.Schema.XmlSchemaMaxExclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxInclusive", typeof(System.Xml.Schema.XmlSchemaMaxInclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxLength", typeof(System.Xml.Schema.XmlSchemaMaxLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minExclusive", typeof(System.Xml.Schema.XmlSchemaMinExclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minInclusive", typeof(System.Xml.Schema.XmlSchemaMinInclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minLength", typeof(System.Xml.Schema.XmlSchemaMinLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("pattern", typeof(System.Xml.Schema.XmlSchemaPatternFacet))]
        [System.Xml.Serialization.XmlElementAttribute("totalDigits", typeof(System.Xml.Schema.XmlSchemaTotalDigitsFacet))]
        [System.Xml.Serialization.XmlElementAttribute("whiteSpace", typeof(System.Xml.Schema.XmlSchemaWhiteSpaceFacet))]
        public System.Xml.Schema.XmlSchemaObjectCollection Facets { get { throw null; } }
    }
    public partial class XmlSchemaSimpleType : System.Xml.Schema.XmlSchemaType
    {
        public XmlSchemaSimpleType() { }
        [System.Xml.Serialization.XmlElementAttribute("list", typeof(System.Xml.Schema.XmlSchemaSimpleTypeList))]
        [System.Xml.Serialization.XmlElementAttribute("restriction", typeof(System.Xml.Schema.XmlSchemaSimpleTypeRestriction))]
        [System.Xml.Serialization.XmlElementAttribute("union", typeof(System.Xml.Schema.XmlSchemaSimpleTypeUnion))]
        public System.Xml.Schema.XmlSchemaSimpleTypeContent Content { get { throw null; } set { } }
    }
    public abstract partial class XmlSchemaSimpleTypeContent : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaSimpleTypeContent() { }
    }
    public partial class XmlSchemaSimpleTypeList : System.Xml.Schema.XmlSchemaSimpleTypeContent
    {
        public XmlSchemaSimpleTypeList() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaSimpleType BaseItemType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaSimpleType ItemType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("itemType")]
        public System.Xml.XmlQualifiedName ItemTypeName { get { throw null; } set { } }
    }
    public partial class XmlSchemaSimpleTypeRestriction : System.Xml.Schema.XmlSchemaSimpleTypeContent
    {
        public XmlSchemaSimpleTypeRestriction() { }
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaSimpleType BaseType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("enumeration", typeof(System.Xml.Schema.XmlSchemaEnumerationFacet))]
        [System.Xml.Serialization.XmlElementAttribute("fractionDigits", typeof(System.Xml.Schema.XmlSchemaFractionDigitsFacet))]
        [System.Xml.Serialization.XmlElementAttribute("length", typeof(System.Xml.Schema.XmlSchemaLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxExclusive", typeof(System.Xml.Schema.XmlSchemaMaxExclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxInclusive", typeof(System.Xml.Schema.XmlSchemaMaxInclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxLength", typeof(System.Xml.Schema.XmlSchemaMaxLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minExclusive", typeof(System.Xml.Schema.XmlSchemaMinExclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minInclusive", typeof(System.Xml.Schema.XmlSchemaMinInclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minLength", typeof(System.Xml.Schema.XmlSchemaMinLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("pattern", typeof(System.Xml.Schema.XmlSchemaPatternFacet))]
        [System.Xml.Serialization.XmlElementAttribute("totalDigits", typeof(System.Xml.Schema.XmlSchemaTotalDigitsFacet))]
        [System.Xml.Serialization.XmlElementAttribute("whiteSpace", typeof(System.Xml.Schema.XmlSchemaWhiteSpaceFacet))]
        public System.Xml.Schema.XmlSchemaObjectCollection Facets { get { throw null; } }
    }
    public partial class XmlSchemaSimpleTypeUnion : System.Xml.Schema.XmlSchemaSimpleTypeContent
    {
        public XmlSchemaSimpleTypeUnion() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaSimpleType[] BaseMemberTypes { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaObjectCollection BaseTypes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("memberTypes")]
        public System.Xml.XmlQualifiedName[] MemberTypes { get { throw null; } set { } }
    }
    public partial class XmlSchemaTotalDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaTotalDigitsFacet() { }
    }
    public partial class XmlSchemaType : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaType() { }
        [System.ObsoleteAttribute("This property has been deprecated. Please use BaseXmlSchemaType property that returns a strongly typed base schema type. https://go.microsoft.com/fwlink/?linkid=14202")]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public object BaseSchemaType { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaType BaseXmlSchemaType { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDatatype Datatype { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod DerivedBy { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Xml.Schema.XmlSchemaDerivationMethod.None)]
        [System.Xml.Serialization.XmlAttributeAttribute("final")]
        public System.Xml.Schema.XmlSchemaDerivationMethod Final { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod FinalResolved { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public virtual bool IsMixed { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlTypeCode TypeCode { get { throw null; } }
        public static System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.Schema.XmlTypeCode typeCode) { throw null; }
        public static System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName) { throw null; }
        public static System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode) { throw null; }
        public static System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName) { throw null; }
        public static bool IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except) { throw null; }
    }
    public partial class XmlSchemaUnique : System.Xml.Schema.XmlSchemaIdentityConstraint
    {
        public XmlSchemaUnique() { }
    }
    public enum XmlSchemaUse
    {
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 0,
        [System.Xml.Serialization.XmlEnumAttribute("optional")]
        Optional = 1,
        [System.Xml.Serialization.XmlEnumAttribute("prohibited")]
        Prohibited = 2,
        [System.Xml.Serialization.XmlEnumAttribute("required")]
        Required = 3,
    }
    public partial class XmlSchemaValidationException : System.Xml.Schema.XmlSchemaException
    {
        public XmlSchemaValidationException() { }
        protected XmlSchemaValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XmlSchemaValidationException(string message) { }
        public XmlSchemaValidationException(string message, System.Exception innerException) { }
        public XmlSchemaValidationException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        public object SourceObject { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected internal void SetSourceObject(object sourceObject) { }
    }
    [System.FlagsAttribute]
    public enum XmlSchemaValidationFlags
    {
        AllowXmlAttributes = 16,
        None = 0,
        ProcessIdentityConstraints = 8,
        ProcessInlineSchema = 1,
        ProcessSchemaLocation = 2,
        ReportValidationWarnings = 4,
    }
    public sealed partial class XmlSchemaValidator
    {
        public XmlSchemaValidator(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags) { }
        public System.Xml.IXmlLineInfo LineInfoProvider { get { throw null; } set { } }
        public System.Uri SourceUri { get { throw null; } set { } }
        public object ValidationEventSender { get { throw null; } set { } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public void AddSchema(System.Xml.Schema.XmlSchema schema) { }
        public void EndValidation() { }
        public System.Xml.Schema.XmlSchemaAttribute[] GetExpectedAttributes() { throw null; }
        public System.Xml.Schema.XmlSchemaParticle[] GetExpectedParticles() { throw null; }
        public void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes) { }
        public void Initialize() { }
        public void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType) { }
        public void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        public object ValidateAttribute(string localName, string namespaceUri, string attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo) { throw null; }
        public object ValidateAttribute(string localName, string namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo) { throw null; }
        public void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        public void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }
        public object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo) { throw null; }
        public object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, object typedValue) { throw null; }
        public void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        public void ValidateText(string elementValue) { }
        public void ValidateText(System.Xml.Schema.XmlValueGetter elementValue) { }
        public void ValidateWhitespace(string elementValue) { }
        public void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue) { }
    }
    public enum XmlSchemaValidity
    {
        Invalid = 2,
        NotKnown = 0,
        Valid = 1,
    }
    public partial class XmlSchemaWhiteSpaceFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaWhiteSpaceFacet() { }
    }
    public partial class XmlSchemaXPath : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaXPath() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("xpath")]
        public string XPath { get { throw null; } set { } }
    }
    public enum XmlSeverityType
    {
        Error = 0,
        Warning = 1,
    }
    public enum XmlTypeCode
    {
        AnyAtomicType = 10,
        AnyUri = 28,
        Attribute = 5,
        Base64Binary = 27,
        Boolean = 13,
        Byte = 46,
        Comment = 8,
        Date = 20,
        DateTime = 18,
        DayTimeDuration = 54,
        Decimal = 14,
        Document = 3,
        Double = 16,
        Duration = 17,
        Element = 4,
        Entity = 39,
        Float = 15,
        GDay = 24,
        GMonth = 25,
        GMonthDay = 23,
        GYear = 22,
        GYearMonth = 21,
        HexBinary = 26,
        Id = 37,
        Idref = 38,
        Int = 44,
        Integer = 40,
        Item = 1,
        Language = 33,
        Long = 43,
        Name = 35,
        Namespace = 6,
        NCName = 36,
        NegativeInteger = 42,
        NmToken = 34,
        Node = 2,
        None = 0,
        NonNegativeInteger = 47,
        NonPositiveInteger = 41,
        NormalizedString = 31,
        Notation = 30,
        PositiveInteger = 52,
        ProcessingInstruction = 7,
        QName = 29,
        Short = 45,
        String = 12,
        Text = 9,
        Time = 19,
        Token = 32,
        UnsignedByte = 51,
        UnsignedInt = 49,
        UnsignedLong = 48,
        UnsignedShort = 50,
        UntypedAtomic = 11,
        YearMonthDuration = 53,
    }
    public delegate object XmlValueGetter();
}
