// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Xml.Resolvers
{
    [System.FlagsAttribute]
    public enum XmlKnownDtds
    {
        All = 65535,
        None = 0,
        Rss091 = 2,
        Xhtml10 = 1,
    }
    public partial class XmlPreloadedResolver : System.Xml.XmlResolver
    {
        public XmlPreloadedResolver() { }
        public XmlPreloadedResolver(System.Xml.Resolvers.XmlKnownDtds preloadedDtds) { }
        public XmlPreloadedResolver(System.Xml.XmlResolver fallbackResolver) { }
        public XmlPreloadedResolver(System.Xml.XmlResolver fallbackResolver, System.Xml.Resolvers.XmlKnownDtds preloadedDtds) { }
        public XmlPreloadedResolver(System.Xml.XmlResolver fallbackResolver, System.Xml.Resolvers.XmlKnownDtds preloadedDtds, System.Collections.Generic.IEqualityComparer<System.Uri> uriComparer) { }
        public override System.Net.ICredentials Credentials { set { } }
        public System.Collections.Generic.IEnumerable<System.Uri> PreloadedUris { get { throw null; } }
        public void Add(System.Uri uri, byte[] value) { }
        public void Add(System.Uri uri, byte[] value, int offset, int count) { }
        public void Add(System.Uri uri, System.IO.Stream value) { }
        public void Add(System.Uri uri, string value) { }
        public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public void Remove(System.Uri uri) { }
        public override System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
        public override bool SupportsType(System.Uri absoluteUri, System.Type type) { throw null; }
    }
}
