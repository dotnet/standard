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
namespace System.Security.Claims
{
    public static partial class DynamicRoleClaimProvider
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("Use ClaimsAuthenticationManager to add claims to a ClaimsIdentity", true)]
        public static void AddDynamicRoleClaims(System.Security.Claims.ClaimsIdentity claimsIdentity, System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> claims) { }
    }
}