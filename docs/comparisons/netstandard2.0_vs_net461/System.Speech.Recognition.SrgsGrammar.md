# System.Speech.Recognition.SrgsGrammar

``` diff
+namespace System.Speech.Recognition.SrgsGrammar {
+    public class SrgsDocument {
+        public SrgsDocument();
+        public SrgsDocument(GrammarBuilder builder);
+        public SrgsDocument(SrgsRule grammarRootRule);
+        public SrgsDocument(string path);
+        public SrgsDocument(XmlReader srgsGrammar);
+        public Collection<string> AssemblyReferences { get; }
+        public Collection<string> CodeBehind { get; }
+        public CultureInfo Culture { get; set; }
+        public bool Debug { get; set; }
+        public Collection<string> ImportNamespaces { get; }
+        public string Language { get; set; }
+        public SrgsGrammarMode Mode { get; set; }
+        public string Namespace { get; set; }
+        public SrgsPhoneticAlphabet PhoneticAlphabet { get; set; }
+        public SrgsRule Root { get; set; }
+        public SrgsRulesCollection Rules { get; }
+        public string Script { get; set; }
+        public Uri XmlBase { get; set; }
+        public void WriteSrgs(XmlWriter srgsGrammar);
+    }
+    public abstract class SrgsElement : MarshalByRefObject {
+        protected SrgsElement();
+    }
+    public static class SrgsGrammarCompiler {
+        public static void Compile(SrgsDocument srgsGrammar, Stream outputStream);
+        public static void Compile(string inputPath, Stream outputStream);
+        public static void Compile(XmlReader reader, Stream outputStream);
+        public static void CompileClassLibrary(SrgsDocument srgsGrammar, string outputPath, string[] referencedAssemblies, string keyFile);
+        public static void CompileClassLibrary(string[] inputPaths, string outputPath, string[] referencedAssemblies, string keyFile);
+        public static void CompileClassLibrary(XmlReader reader, string outputPath, string[] referencedAssemblies, string keyFile);
+    }
+    public enum SrgsGrammarMode {
+        Dtmf = 1,
+        Voice = 0,
+    }
+    public class SrgsItem : SrgsElement {
+        public SrgsItem();
+        public SrgsItem(int repeatCount);
+        public SrgsItem(int min, int max);
+        public SrgsItem(int min, int max, params SrgsElement[] elements);
+        public SrgsItem(int min, int max, string text);
+        public SrgsItem(params SrgsElement[] elements);
+        public SrgsItem(string text);
+        public Collection<SrgsElement> Elements { get; }
+        public int MaxRepeat { get; }
+        public int MinRepeat { get; }
+        public float RepeatProbability { get; set; }
+        public float Weight { get; set; }
+        public void Add(SrgsElement element);
+        public void SetRepeat(int count);
+        public void SetRepeat(int minRepeat, int maxRepeat);
+    }
+    public class SrgsNameValueTag : SrgsElement {
+        public SrgsNameValueTag();
+        public SrgsNameValueTag(object value);
+        public SrgsNameValueTag(string name, object value);
+        public string Name { get; set; }
+        public object Value { get; set; }
+    }
+    public class SrgsOneOf : SrgsElement {
+        public SrgsOneOf();
+        public SrgsOneOf(params SrgsItem[] items);
+        public SrgsOneOf(params string[] items);
+        public Collection<SrgsItem> Items { get; }
+        public void Add(SrgsItem item);
+    }
+    public enum SrgsPhoneticAlphabet {
+        Ipa = 1,
+        Sapi = 0,
+        Ups = 2,
+    }
+    public class SrgsRule {
+        public SrgsRule(string id);
+        public SrgsRule(string id, params SrgsElement[] elements);
+        public string BaseClass { get; set; }
+        public Collection<SrgsElement> Elements { get; }
+        public string Id { get; set; }
+        public string OnError { get; set; }
+        public string OnInit { get; set; }
+        public string OnParse { get; set; }
+        public string OnRecognition { get; set; }
+        public SrgsRuleScope Scope { get; set; }
+        public string Script { get; set; }
+        public void Add(SrgsElement element);
+    }
+    public class SrgsRuleRef : SrgsElement {
+        public static readonly SrgsRuleRef Dictation;
+        public static readonly SrgsRuleRef Garbage;
+        public static readonly SrgsRuleRef MnemonicSpelling;
+        public static readonly SrgsRuleRef Null;
+        public static readonly SrgsRuleRef Void;
+        public SrgsRuleRef(SrgsRule rule);
+        public SrgsRuleRef(SrgsRule rule, string semanticKey);
+        public SrgsRuleRef(SrgsRule rule, string semanticKey, string parameters);
+        public SrgsRuleRef(Uri uri);
+        public SrgsRuleRef(Uri uri, string rule);
+        public SrgsRuleRef(Uri uri, string rule, string semanticKey);
+        public SrgsRuleRef(Uri uri, string rule, string semanticKey, string parameters);
+        public string Params { get; }
+        public string SemanticKey { get; }
+        public Uri Uri { get; }
+    }
+    public sealed class SrgsRulesCollection : KeyedCollection<string, SrgsRule> {
+        public SrgsRulesCollection();
+        public void Add(params SrgsRule[] rules);
+        protected override string GetKeyForItem(SrgsRule rule);
+    }
+    public enum SrgsRuleScope {
+        Private = 1,
+        Public = 0,
+    }
+    public class SrgsSemanticInterpretationTag : SrgsElement {
+        public SrgsSemanticInterpretationTag();
+        public SrgsSemanticInterpretationTag(string script);
+        public string Script { get; set; }
+    }
+    public class SrgsSubset : SrgsElement {
+        public SrgsSubset(string text);
+        public SrgsSubset(string text, SubsetMatchingMode matchingMode);
+        public SubsetMatchingMode MatchingMode { get; set; }
+        public string Text { get; set; }
+    }
+    public class SrgsText : SrgsElement {
+        public SrgsText();
+        public SrgsText(string text);
+        public string Text { get; set; }
+    }
+    public class SrgsToken : SrgsElement {
+        public SrgsToken(string text);
+        public string Display { get; set; }
+        public string Pronunciation { get; set; }
+        public string Text { get; set; }
+    }
+}
```

