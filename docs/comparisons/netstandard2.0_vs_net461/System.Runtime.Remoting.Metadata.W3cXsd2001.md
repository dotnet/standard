# System.Runtime.Remoting.Metadata.W3cXsd2001

``` diff
+namespace System.Runtime.Remoting.Metadata.W3cXsd2001 {
+    public interface ISoapXsd {
+        string GetXsdType();
+    }
+    public sealed class SoapAnyUri : ISoapXsd {
+        public SoapAnyUri();
+        public SoapAnyUri(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapAnyUri Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapBase64Binary : ISoapXsd {
+        public SoapBase64Binary();
+        public SoapBase64Binary(byte[] value);
+        public byte[] Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapBase64Binary Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapDate : ISoapXsd {
+        public SoapDate();
+        public SoapDate(DateTime value);
+        public SoapDate(DateTime value, int sign);
+        public int Sign { get; set; }
+        public DateTime Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapDate Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapDateTime {
+        public SoapDateTime();
+        public static string XsdType { get; }
+        public static DateTime Parse(string value);
+        public static string ToString(DateTime value);
+    }
+    public sealed class SoapDay : ISoapXsd {
+        public SoapDay();
+        public SoapDay(DateTime value);
+        public DateTime Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapDay Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapDuration {
+        public SoapDuration();
+        public static string XsdType { get; }
+        public static TimeSpan Parse(string value);
+        public static string ToString(TimeSpan timeSpan);
+    }
+    public sealed class SoapEntities : ISoapXsd {
+        public SoapEntities();
+        public SoapEntities(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapEntities Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapEntity : ISoapXsd {
+        public SoapEntity();
+        public SoapEntity(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapEntity Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapHexBinary : ISoapXsd {
+        public SoapHexBinary();
+        public SoapHexBinary(byte[] value);
+        public byte[] Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapHexBinary Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapId : ISoapXsd {
+        public SoapId();
+        public SoapId(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapId Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapIdref : ISoapXsd {
+        public SoapIdref();
+        public SoapIdref(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapIdref Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapIdrefs : ISoapXsd {
+        public SoapIdrefs();
+        public SoapIdrefs(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapIdrefs Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapInteger : ISoapXsd {
+        public SoapInteger();
+        public SoapInteger(decimal value);
+        public decimal Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapInteger Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapLanguage : ISoapXsd {
+        public SoapLanguage();
+        public SoapLanguage(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapLanguage Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapMonth : ISoapXsd {
+        public SoapMonth();
+        public SoapMonth(DateTime value);
+        public DateTime Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapMonth Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapMonthDay : ISoapXsd {
+        public SoapMonthDay();
+        public SoapMonthDay(DateTime value);
+        public DateTime Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapMonthDay Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapName : ISoapXsd {
+        public SoapName();
+        public SoapName(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapName Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapNcName : ISoapXsd {
+        public SoapNcName();
+        public SoapNcName(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapNcName Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapNegativeInteger : ISoapXsd {
+        public SoapNegativeInteger();
+        public SoapNegativeInteger(decimal value);
+        public decimal Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapNegativeInteger Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapNmtoken : ISoapXsd {
+        public SoapNmtoken();
+        public SoapNmtoken(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapNmtoken Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapNmtokens : ISoapXsd {
+        public SoapNmtokens();
+        public SoapNmtokens(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapNmtokens Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapNonNegativeInteger : ISoapXsd {
+        public SoapNonNegativeInteger();
+        public SoapNonNegativeInteger(decimal value);
+        public decimal Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapNonNegativeInteger Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapNonPositiveInteger : ISoapXsd {
+        public SoapNonPositiveInteger();
+        public SoapNonPositiveInteger(decimal value);
+        public decimal Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapNonPositiveInteger Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapNormalizedString : ISoapXsd {
+        public SoapNormalizedString();
+        public SoapNormalizedString(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapNormalizedString Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapNotation : ISoapXsd {
+        public SoapNotation();
+        public SoapNotation(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapNotation Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapPositiveInteger : ISoapXsd {
+        public SoapPositiveInteger();
+        public SoapPositiveInteger(decimal value);
+        public decimal Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapPositiveInteger Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapQName : ISoapXsd {
+        public SoapQName();
+        public SoapQName(string value);
+        public SoapQName(string key, string name);
+        public SoapQName(string key, string name, string namespaceValue);
+        public string Key { get; set; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapQName Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapTime : ISoapXsd {
+        public SoapTime();
+        public SoapTime(DateTime value);
+        public DateTime Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapTime Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapToken : ISoapXsd {
+        public SoapToken();
+        public SoapToken(string value);
+        public string Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapToken Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapYear : ISoapXsd {
+        public SoapYear();
+        public SoapYear(DateTime value);
+        public SoapYear(DateTime value, int sign);
+        public int Sign { get; set; }
+        public DateTime Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapYear Parse(string value);
+        public override string ToString();
+    }
+    public sealed class SoapYearMonth : ISoapXsd {
+        public SoapYearMonth();
+        public SoapYearMonth(DateTime value);
+        public SoapYearMonth(DateTime value, int sign);
+        public int Sign { get; set; }
+        public DateTime Value { get; set; }
+        public static string XsdType { get; }
+        public string GetXsdType();
+        public static SoapYearMonth Parse(string value);
+        public override string ToString();
+    }
+}
```

