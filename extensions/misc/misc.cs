/*
APIs removed/broken by this factoring:

*/
namespace System.IODescriptionAttribute
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
    public partial class IODescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        public IODescriptionAttribute(string description) { }
        public override string Description { get { throw null; } }
    }
}
namespace System.Reflection
{
    public partial interface ICustomTypeProvider
    {
        System.Type GetCustomType();
    }
}
namespace System.Runtime
{
    public static partial class ProfileOptimization
    {
        public static void SetProfileRoot(string directoryPath) { }
        public static void StartProfile(string profile) { }
    }
}
namespace System.Runtime.CompilerServices
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class Closure
    {
        public readonly object[] Constants;
        public readonly object[] Locals;
        public Closure(object[] constants, object[] locals) { }
    }
}
namespace System.Security.Claims
{
    public static partial class DynamicRoleClaimProvider
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("Use ClaimsAuthenticationManager to add claims to a ClaimsIdentity", true)]
        public static void AddDynamicRoleClaims(System.Security.Claims.ClaimsIdentity claimsIdentity, System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> claims) { }
    }
}
namespace System.Windows.Markup
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(1244), AllowMultiple=false, Inherited=true)]
    public sealed partial class ValueSerializerAttribute : System.Attribute
    {
        public ValueSerializerAttribute(string valueSerializerTypeName) { }
        public ValueSerializerAttribute(System.Type valueSerializerType) { }
        public System.Type ValueSerializerType { get { throw null; } }
        public string ValueSerializerTypeName { get { throw null; } }
    }
}