/*
APIs removed/broken by this factoring:

*/

namespace System.Management.Instrumentation
{
    public partial class InstanceNotFoundException : System.Management.Instrumentation.InstrumentationException
    {
        public InstanceNotFoundException() { }
        protected InstanceNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceNotFoundException(string message) { }
        public InstanceNotFoundException(string message, System.Exception innerException) { }
    }
    public partial class InstrumentationBaseException : System.Exception
    {
        public InstrumentationBaseException() { }
        protected InstrumentationBaseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstrumentationBaseException(string message) { }
        public InstrumentationBaseException(string message, System.Exception innerException) { }
    }
    public partial class InstrumentationException : System.Management.Instrumentation.InstrumentationBaseException
    {
        public InstrumentationException() { }
        public InstrumentationException(System.Exception innerException) { }
        protected InstrumentationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstrumentationException(string message) { }
        public InstrumentationException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(96), AllowMultiple=false)]
    public sealed partial class ManagementBindAttribute : System.Management.Instrumentation.ManagementNewInstanceAttribute
    {
        public ManagementBindAttribute() { }
        public System.Type Schema { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class ManagementCommitAttribute : System.Management.Instrumentation.ManagementMemberAttribute
    {
        public ManagementCommitAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public sealed partial class ManagementConfigurationAttribute : System.Management.Instrumentation.ManagementMemberAttribute
    {
        public ManagementConfigurationAttribute() { }
        public System.Management.Instrumentation.ManagementConfigurationType Mode { get { throw null; } set { } }
        public System.Type Schema { get { throw null; } set { } }
    }
    public enum ManagementConfigurationType
    {
        Apply = 0,
        OnCommit = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(96), AllowMultiple=false)]
    public sealed partial class ManagementCreateAttribute : System.Management.Instrumentation.ManagementNewInstanceAttribute
    {
        public ManagementCreateAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
    public sealed partial class ManagementEntityAttribute : System.Attribute
    {
        public ManagementEntityAttribute() { }
        public bool External { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public bool Singleton { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(96), AllowMultiple=false)]
    public sealed partial class ManagementEnumeratorAttribute : System.Management.Instrumentation.ManagementNewInstanceAttribute
    {
        public ManagementEnumeratorAttribute() { }
        public System.Type Schema { get { throw null; } set { } }
    }
    public enum ManagementHostingModel
    {
        Decoupled = 0,
        LocalService = 2,
        LocalSystem = 3,
        NetworkService = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public sealed partial class ManagementKeyAttribute : System.Management.Instrumentation.ManagementMemberAttribute
    {
        public ManagementKeyAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
    public abstract partial class ManagementMemberAttribute : System.Attribute
    {
        protected ManagementMemberAttribute() { }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), AllowMultiple=false)]
    public sealed partial class ManagementNameAttribute : System.Attribute
    {
        public ManagementNameAttribute(string name) { }
        public string Name { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(96), AllowMultiple=false)]
    public abstract partial class ManagementNewInstanceAttribute : System.Management.Instrumentation.ManagementMemberAttribute
    {
        protected ManagementNewInstanceAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public sealed partial class ManagementProbeAttribute : System.Management.Instrumentation.ManagementMemberAttribute
    {
        public ManagementProbeAttribute() { }
        public System.Type Schema { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
    public sealed partial class ManagementReferenceAttribute : System.Attribute
    {
        public ManagementReferenceAttribute() { }
        public string Type { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false)]
    public sealed partial class ManagementRemoveAttribute : System.Management.Instrumentation.ManagementMemberAttribute
    {
        public ManagementRemoveAttribute() { }
        public System.Type Schema { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false)]
    public sealed partial class ManagementTaskAttribute : System.Management.Instrumentation.ManagementMemberAttribute
    {
        public ManagementTaskAttribute() { }
        public System.Type Schema { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    public sealed partial class WmiConfigurationAttribute : System.Attribute
    {
        public WmiConfigurationAttribute(string scope) { }
        public string HostingGroup { get { throw null; } set { } }
        public System.Management.Instrumentation.ManagementHostingModel HostingModel { get { throw null; } set { } }
        public bool IdentifyLevel { get { throw null; } set { } }
        public string NamespaceSecurity { get { throw null; } set { } }
        public string Scope { get { throw null; } }
        public string SecurityRestriction { get { throw null; } set { } }
    }
}