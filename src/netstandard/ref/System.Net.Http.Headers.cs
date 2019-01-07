// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Net.Http.Headers
{
    public partial class AuthenticationHeaderValue : System.ICloneable
    {
        public AuthenticationHeaderValue(string scheme) { }
        public AuthenticationHeaderValue(string scheme, string parameter) { }
        public string Parameter { get { throw null; } }
        public string Scheme { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.AuthenticationHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.AuthenticationHeaderValue parsedValue) { throw null; }
    }
    public partial class CacheControlHeaderValue : System.ICloneable
    {
        public CacheControlHeaderValue() { }
        public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Extensions { get { throw null; } }
        public System.Nullable<System.TimeSpan> MaxAge { get { throw null; } set { } }
        public bool MaxStale { get { throw null; } set { } }
        public System.Nullable<System.TimeSpan> MaxStaleLimit { get { throw null; } set { } }
        public System.Nullable<System.TimeSpan> MinFresh { get { throw null; } set { } }
        public bool MustRevalidate { get { throw null; } set { } }
        public bool NoCache { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> NoCacheHeaders { get { throw null; } }
        public bool NoStore { get { throw null; } set { } }
        public bool NoTransform { get { throw null; } set { } }
        public bool OnlyIfCached { get { throw null; } set { } }
        public bool Private { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> PrivateHeaders { get { throw null; } }
        public bool ProxyRevalidate { get { throw null; } set { } }
        public bool Public { get { throw null; } set { } }
        public System.Nullable<System.TimeSpan> SharedMaxAge { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.CacheControlHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.CacheControlHeaderValue parsedValue) { throw null; }
    }
    public partial class ContentDispositionHeaderValue : System.ICloneable
    {
        protected ContentDispositionHeaderValue(System.Net.Http.Headers.ContentDispositionHeaderValue source) { }
        public ContentDispositionHeaderValue(string dispositionType) { }
        public System.Nullable<System.DateTimeOffset> CreationDate { get { throw null; } set { } }
        public string DispositionType { get { throw null; } set { } }
        public string FileName { get { throw null; } set { } }
        public string FileNameStar { get { throw null; } set { } }
        public System.Nullable<System.DateTimeOffset> ModificationDate { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> ReadDate { get { throw null; } set { } }
        public System.Nullable<long> Size { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.ContentDispositionHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.ContentDispositionHeaderValue parsedValue) { throw null; }
    }
    public partial class ContentRangeHeaderValue : System.ICloneable
    {
        public ContentRangeHeaderValue(long length) { }
        public ContentRangeHeaderValue(long from, long to) { }
        public ContentRangeHeaderValue(long from, long to, long length) { }
        public System.Nullable<long> From { get { throw null; } }
        public bool HasLength { get { throw null; } }
        public bool HasRange { get { throw null; } }
        public System.Nullable<long> Length { get { throw null; } }
        public System.Nullable<long> To { get { throw null; } }
        public string Unit { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.ContentRangeHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.ContentRangeHeaderValue parsedValue) { throw null; }
    }
    public partial class EntityTagHeaderValue : System.ICloneable
    {
        public EntityTagHeaderValue(string tag) { }
        public EntityTagHeaderValue(string tag, bool isWeak) { }
        public static System.Net.Http.Headers.EntityTagHeaderValue Any { get { throw null; } }
        public bool IsWeak { get { throw null; } }
        public string Tag { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.EntityTagHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.EntityTagHeaderValue parsedValue) { throw null; }
    }
    public sealed partial class HttpContentHeaders : System.Net.Http.Headers.HttpHeaders
    {
        internal HttpContentHeaders() { }
        public System.Collections.Generic.ICollection<string> Allow { get { throw null; } }
        public System.Net.Http.Headers.ContentDispositionHeaderValue ContentDisposition { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> ContentEncoding { get { throw null; } }
        public System.Collections.Generic.ICollection<string> ContentLanguage { get { throw null; } }
        public System.Nullable<long> ContentLength { get { throw null; } set { } }
        public System.Uri ContentLocation { get { throw null; } set { } }
        public byte[] ContentMD5 { get { throw null; } set { } }
        public System.Net.Http.Headers.ContentRangeHeaderValue ContentRange { get { throw null; } set { } }
        public System.Net.Http.Headers.MediaTypeHeaderValue ContentType { get { throw null; } set { } }
        public System.Nullable<System.DateTimeOffset> Expires { get { throw null; } set { } }
        public System.Nullable<System.DateTimeOffset> LastModified { get { throw null; } set { } }
    }
    public abstract partial class HttpHeaders : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<string>>>, System.Collections.IEnumerable
    {
        protected HttpHeaders() { }
        public void Add(string name, System.Collections.Generic.IEnumerable<string> values) { }
        public void Add(string name, string value) { }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<string>>> GetEnumerator() { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetValues(string name) { throw null; }
        public bool Remove(string name) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
        public bool TryAddWithoutValidation(string name, System.Collections.Generic.IEnumerable<string> values) { throw null; }
        public bool TryAddWithoutValidation(string name, string value) { throw null; }
        public bool TryGetValues(string name, out System.Collections.Generic.IEnumerable<string> values) { throw null; }
    }
    public sealed partial class HttpHeaderValueCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : class
    {
        internal HttpHeaderValueCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { throw null; }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public void ParseAdd(string input) { }
        public bool Remove(T item) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
        public bool TryParseAdd(string input) { throw null; }
    }
    public sealed partial class HttpRequestHeaders : System.Net.Http.Headers.HttpHeaders
    {
        internal HttpRequestHeaders() { }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue> Accept { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue> AcceptCharset { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue> AcceptEncoding { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue> AcceptLanguage { get { throw null; } }
        public System.Net.Http.Headers.AuthenticationHeaderValue Authorization { get { throw null; } set { } }
        public System.Net.Http.Headers.CacheControlHeaderValue CacheControl { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<string> Connection { get { throw null; } }
        public System.Nullable<bool> ConnectionClose { get { throw null; } set { } }
        public System.Nullable<System.DateTimeOffset> Date { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueWithParametersHeaderValue> Expect { get { throw null; } }
        public System.Nullable<bool> ExpectContinue { get { throw null; } set { } }
        public string From { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.EntityTagHeaderValue> IfMatch { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> IfModifiedSince { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.EntityTagHeaderValue> IfNoneMatch { get { throw null; } }
        public System.Net.Http.Headers.RangeConditionHeaderValue IfRange { get { throw null; } set { } }
        public System.Nullable<System.DateTimeOffset> IfUnmodifiedSince { get { throw null; } set { } }
        public System.Nullable<int> MaxForwards { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue> Pragma { get { throw null; } }
        public System.Net.Http.Headers.AuthenticationHeaderValue ProxyAuthorization { get { throw null; } set { } }
        public System.Net.Http.Headers.RangeHeaderValue Range { get { throw null; } set { } }
        public System.Uri Referrer { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue> TE { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<string> Trailer { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue> TransferEncoding { get { throw null; } }
        public System.Nullable<bool> TransferEncodingChunked { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue> Upgrade { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue> UserAgent { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue> Via { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue> Warning { get { throw null; } }
    }
    public sealed partial class HttpResponseHeaders : System.Net.Http.Headers.HttpHeaders
    {
        internal HttpResponseHeaders() { }
        public System.Net.Http.Headers.HttpHeaderValueCollection<string> AcceptRanges { get { throw null; } }
        public System.Nullable<System.TimeSpan> Age { get { throw null; } set { } }
        public System.Net.Http.Headers.CacheControlHeaderValue CacheControl { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<string> Connection { get { throw null; } }
        public System.Nullable<bool> ConnectionClose { get { throw null; } set { } }
        public System.Nullable<System.DateTimeOffset> Date { get { throw null; } set { } }
        public System.Net.Http.Headers.EntityTagHeaderValue ETag { get { throw null; } set { } }
        public System.Uri Location { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue> Pragma { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue> ProxyAuthenticate { get { throw null; } }
        public System.Net.Http.Headers.RetryConditionHeaderValue RetryAfter { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue> Server { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<string> Trailer { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue> TransferEncoding { get { throw null; } }
        public System.Nullable<bool> TransferEncodingChunked { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue> Upgrade { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<string> Vary { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue> Via { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue> Warning { get { throw null; } }
        public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue> WwwAuthenticate { get { throw null; } }
    }
    public partial class MediaTypeHeaderValue : System.ICloneable
    {
        protected MediaTypeHeaderValue(System.Net.Http.Headers.MediaTypeHeaderValue source) { }
        public MediaTypeHeaderValue(string mediaType) { }
        public string CharSet { get { throw null; } set { } }
        public string MediaType { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.MediaTypeHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.MediaTypeHeaderValue parsedValue) { throw null; }
    }
    public sealed partial class MediaTypeWithQualityHeaderValue : System.Net.Http.Headers.MediaTypeHeaderValue, System.ICloneable
    {
        public MediaTypeWithQualityHeaderValue(string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public MediaTypeWithQualityHeaderValue(string mediaType, double quality) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public System.Nullable<double> Quality { get { throw null; } set { } }
        public static new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.MediaTypeWithQualityHeaderValue parsedValue) { throw null; }
    }
    public partial class NameValueHeaderValue : System.ICloneable
    {
        protected NameValueHeaderValue(System.Net.Http.Headers.NameValueHeaderValue source) { }
        public NameValueHeaderValue(string name) { }
        public NameValueHeaderValue(string name, string value) { }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.NameValueHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.NameValueHeaderValue parsedValue) { throw null; }
    }
    public partial class NameValueWithParametersHeaderValue : System.Net.Http.Headers.NameValueHeaderValue, System.ICloneable
    {
        protected NameValueWithParametersHeaderValue(System.Net.Http.Headers.NameValueWithParametersHeaderValue source) : base (default(System.Net.Http.Headers.NameValueHeaderValue)) { }
        public NameValueWithParametersHeaderValue(string name) : base (default(System.Net.Http.Headers.NameValueHeaderValue)) { }
        public NameValueWithParametersHeaderValue(string name, string value) : base (default(System.Net.Http.Headers.NameValueHeaderValue)) { }
        public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static new System.Net.Http.Headers.NameValueWithParametersHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.NameValueWithParametersHeaderValue parsedValue) { throw null; }
    }
    public partial class ProductHeaderValue : System.ICloneable
    {
        public ProductHeaderValue(string name) { }
        public ProductHeaderValue(string name, string version) { }
        public string Name { get { throw null; } }
        public string Version { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.ProductHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.ProductHeaderValue parsedValue) { throw null; }
    }
    public partial class ProductInfoHeaderValue : System.ICloneable
    {
        public ProductInfoHeaderValue(System.Net.Http.Headers.ProductHeaderValue product) { }
        public ProductInfoHeaderValue(string comment) { }
        public ProductInfoHeaderValue(string productName, string productVersion) { }
        public string Comment { get { throw null; } }
        public System.Net.Http.Headers.ProductHeaderValue Product { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.ProductInfoHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.ProductInfoHeaderValue parsedValue) { throw null; }
    }
    public partial class RangeConditionHeaderValue : System.ICloneable
    {
        public RangeConditionHeaderValue(System.DateTimeOffset date) { }
        public RangeConditionHeaderValue(System.Net.Http.Headers.EntityTagHeaderValue entityTag) { }
        public RangeConditionHeaderValue(string entityTag) { }
        public System.Nullable<System.DateTimeOffset> Date { get { throw null; } }
        public System.Net.Http.Headers.EntityTagHeaderValue EntityTag { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.RangeConditionHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.RangeConditionHeaderValue parsedValue) { throw null; }
    }
    public partial class RangeHeaderValue : System.ICloneable
    {
        public RangeHeaderValue() { }
        public RangeHeaderValue(System.Nullable<long> from, System.Nullable<long> to) { }
        public System.Collections.Generic.ICollection<System.Net.Http.Headers.RangeItemHeaderValue> Ranges { get { throw null; } }
        public string Unit { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.RangeHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.RangeHeaderValue parsedValue) { throw null; }
    }
    public partial class RangeItemHeaderValue : System.ICloneable
    {
        public RangeItemHeaderValue(System.Nullable<long> from, System.Nullable<long> to) { }
        public System.Nullable<long> From { get { throw null; } }
        public System.Nullable<long> To { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RetryConditionHeaderValue : System.ICloneable
    {
        public RetryConditionHeaderValue(System.DateTimeOffset date) { }
        public RetryConditionHeaderValue(System.TimeSpan delta) { }
        public System.Nullable<System.DateTimeOffset> Date { get { throw null; } }
        public System.Nullable<System.TimeSpan> Delta { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.RetryConditionHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.RetryConditionHeaderValue parsedValue) { throw null; }
    }
    public partial class StringWithQualityHeaderValue : System.ICloneable
    {
        public StringWithQualityHeaderValue(string value) { }
        public StringWithQualityHeaderValue(string value, double quality) { }
        public System.Nullable<double> Quality { get { throw null; } }
        public string Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.StringWithQualityHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.StringWithQualityHeaderValue parsedValue) { throw null; }
    }
    public partial class TransferCodingHeaderValue : System.ICloneable
    {
        protected TransferCodingHeaderValue(System.Net.Http.Headers.TransferCodingHeaderValue source) { }
        public TransferCodingHeaderValue(string value) { }
        public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get { throw null; } }
        public string Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.TransferCodingHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.TransferCodingHeaderValue parsedValue) { throw null; }
    }
    public sealed partial class TransferCodingWithQualityHeaderValue : System.Net.Http.Headers.TransferCodingHeaderValue, System.ICloneable
    {
        public TransferCodingWithQualityHeaderValue(string value) : base (default(System.Net.Http.Headers.TransferCodingHeaderValue)) { }
        public TransferCodingWithQualityHeaderValue(string value, double quality) : base (default(System.Net.Http.Headers.TransferCodingHeaderValue)) { }
        public System.Nullable<double> Quality { get { throw null; } set { } }
        public static new System.Net.Http.Headers.TransferCodingWithQualityHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.TransferCodingWithQualityHeaderValue parsedValue) { throw null; }
    }
    public partial class ViaHeaderValue : System.ICloneable
    {
        public ViaHeaderValue(string protocolVersion, string receivedBy) { }
        public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName) { }
        public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName, string comment) { }
        public string Comment { get { throw null; } }
        public string ProtocolName { get { throw null; } }
        public string ProtocolVersion { get { throw null; } }
        public string ReceivedBy { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.ViaHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.ViaHeaderValue parsedValue) { throw null; }
    }
    public partial class WarningHeaderValue : System.ICloneable
    {
        public WarningHeaderValue(int code, string agent, string text) { }
        public WarningHeaderValue(int code, string agent, string text, System.DateTimeOffset date) { }
        public string Agent { get { throw null; } }
        public int Code { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> Date { get { throw null; } }
        public string Text { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.Http.Headers.WarningHeaderValue Parse(string input) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.WarningHeaderValue parsedValue) { throw null; }
    }
}
