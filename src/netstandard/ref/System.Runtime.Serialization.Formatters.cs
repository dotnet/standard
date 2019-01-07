// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.Serialization.Formatters
{
    public enum FormatterAssemblyStyle
    {
        Full = 1,
        Simple = 0,
    }
    public enum FormatterTypeStyle
    {
        TypesAlways = 1,
        TypesWhenNeeded = 0,
        XsdString = 2,
    }
    public partial interface IFieldInfo
    {
        string[] FieldNames { get; set; }
        System.Type[] FieldTypes { get; set; }
    }
    public enum TypeFilterLevel
    {
        Full = 3,
        Low = 2,
    }
}
