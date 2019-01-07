// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Xml.Xsl
{
    public partial interface IXsltContextFunction
    {
        System.Xml.XPath.XPathResultType[] ArgTypes { get; }
        int Maxargs { get; }
        int Minargs { get; }
        System.Xml.XPath.XPathResultType ReturnType { get; }
        object Invoke(System.Xml.Xsl.XsltContext xsltContext, object[] args, System.Xml.XPath.XPathNavigator docContext);
    }
    public partial interface IXsltContextVariable
    {
        bool IsLocal { get; }
        bool IsParam { get; }
        System.Xml.XPath.XPathResultType VariableType { get; }
        object Evaluate(System.Xml.Xsl.XsltContext xsltContext);
    }
    public sealed partial class XslCompiledTransform
    {
        public XslCompiledTransform() { }
        public XslCompiledTransform(bool enableDebug) { }
        public System.Xml.XmlWriterSettings OutputSettings { get { throw null; } }
//CODEDOM        public System.CodeDom.Compiler.TempFileCollection TemporaryFiles { get { throw null; } }
//REFEMIT        public static System.CodeDom.Compiler.CompilerErrorCollection CompileToType(System.Xml.XmlReader stylesheet, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver, bool debug, System.Reflection.Emit.TypeBuilder typeBuilder, string scriptAssemblyPath) { throw null; }
        public void Load(System.Reflection.MethodInfo executeMethod, byte[] queryData, System.Type[] earlyBoundTypes) { }
        public void Load(string stylesheetUri) { }
        public void Load(string stylesheetUri, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) { }
        public void Load(System.Type compiledStylesheet) { }
        public void Load(System.Xml.XmlReader stylesheet) { }
        public void Load(System.Xml.XmlReader stylesheet, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) { }
        public void Transform(string inputUri, string resultsFile) { }
        public void Transform(string inputUri, System.Xml.XmlWriter results) { }
        public void Transform(string inputUri, System.Xml.Xsl.XsltArgumentList arguments, System.IO.Stream results) { }
        public void Transform(string inputUri, System.Xml.Xsl.XsltArgumentList arguments, System.IO.TextWriter results) { }
        public void Transform(string inputUri, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.Xsl.XsltArgumentList arguments, System.IO.Stream results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.Xsl.XsltArgumentList arguments, System.IO.TextWriter results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results, System.Xml.XmlResolver documentResolver) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList arguments, System.IO.Stream results) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList arguments, System.IO.TextWriter results) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results, System.Xml.XmlResolver documentResolver) { }
    }
    public partial class XsltArgumentList
    {
        public XsltArgumentList() { }
        public event System.Xml.Xsl.XsltMessageEncounteredEventHandler XsltMessageEncountered { add { } remove { } }
        public void AddExtensionObject(string namespaceUri, object extension) { }
        public void AddParam(string name, string namespaceUri, object parameter) { }
        public void Clear() { }
        public object GetExtensionObject(string namespaceUri) { throw null; }
        public object GetParam(string name, string namespaceUri) { throw null; }
        public object RemoveExtensionObject(string namespaceUri) { throw null; }
        public object RemoveParam(string name, string namespaceUri) { throw null; }
    }
    public partial class XsltCompileException : System.Xml.Xsl.XsltException
    {
        public XsltCompileException() { }
        public XsltCompileException(System.Exception inner, string sourceUri, int lineNumber, int linePosition) { }
        protected XsltCompileException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XsltCompileException(string message) { }
        public XsltCompileException(string message, System.Exception innerException) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class XsltContext : System.Xml.XmlNamespaceManager
    {
        protected XsltContext() : base (default(System.Xml.XmlNameTable)) { }
        protected XsltContext(System.Xml.NameTable table) : base (default(System.Xml.XmlNameTable)) { }
        public abstract bool Whitespace { get; }
        public abstract int CompareDocument(string baseUri, string nextbaseUri);
        public abstract bool PreserveWhitespace(System.Xml.XPath.XPathNavigator node);
        public abstract System.Xml.Xsl.IXsltContextFunction ResolveFunction(string prefix, string name, System.Xml.XPath.XPathResultType[] ArgTypes);
        public abstract System.Xml.Xsl.IXsltContextVariable ResolveVariable(string prefix, string name);
    }
    public partial class XsltException : System.SystemException
    {
        public XsltException() { }
        protected XsltException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XsltException(string message) { }
        public XsltException(string message, System.Exception innerException) { }
        public virtual int LineNumber { get { throw null; } }
        public virtual int LinePosition { get { throw null; } }
        public override string Message { get { throw null; } }
        public virtual string SourceUri { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class XsltMessageEncounteredEventArgs : System.EventArgs
    {
        protected XsltMessageEncounteredEventArgs() { }
        public abstract string Message { get; }
    }
    public delegate void XsltMessageEncounteredEventHandler(object sender, System.Xml.Xsl.XsltMessageEncounteredEventArgs e);
    public sealed partial class XslTransform
    {
        public XslTransform() { }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public void Load(string url) { }
        public void Load(string url, System.Xml.XmlResolver resolver) { }
        public void Load(System.Xml.XmlReader stylesheet) { }
        public void Load(System.Xml.XmlReader stylesheet, System.Xml.XmlResolver resolver) { }
//CAS        public void Load(System.Xml.XmlReader stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.XmlResolver resolver) { }
//CAS        public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public void Load(System.Xml.XPath.XPathNavigator stylesheet) { }
        public void Load(System.Xml.XPath.XPathNavigator stylesheet, System.Xml.XmlResolver resolver) { }
//CAS        public void Load(System.Xml.XPath.XPathNavigator stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public void Transform(string inputfile, string outputfile) { }
        public void Transform(string inputfile, string outputfile, System.Xml.XmlResolver resolver) { }
        public System.Xml.XmlReader Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args) { throw null; }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.IO.Stream output) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.IO.Stream output, System.Xml.XmlResolver resolver) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.IO.TextWriter output) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.IO.TextWriter output, System.Xml.XmlResolver resolver) { }
        public System.Xml.XmlReader Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlResolver resolver) { throw null; }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlWriter output) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlWriter output, System.Xml.XmlResolver resolver) { }
        public System.Xml.XmlReader Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args) { throw null; }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.IO.Stream output) { }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.IO.Stream output, System.Xml.XmlResolver resolver) { }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.IO.TextWriter output) { }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.IO.TextWriter output, System.Xml.XmlResolver resolver) { }
        public System.Xml.XmlReader Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlResolver resolver) { throw null; }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlWriter output) { }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlWriter output, System.Xml.XmlResolver resolver) { }
    }
    public sealed partial class XsltSettings
    {
        public XsltSettings() { }
        public XsltSettings(bool enableDocumentFunction, bool enableScript) { }
        public static System.Xml.Xsl.XsltSettings Default { get { throw null; } }
        public bool EnableDocumentFunction { get { throw null; } set { } }
        public bool EnableScript { get { throw null; } set { } }
        public static System.Xml.Xsl.XsltSettings TrustedXslt { get { throw null; } }
    }
}
