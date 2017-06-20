# Microsoft.JScript

``` diff
+namespace Microsoft.JScript {
+    public abstract class ActivationObject : ScriptObject, IActivationObject {
+        protected ArrayList field_table;
+        protected virtual JSVariableField CreateField(string name, FieldAttributes attributeFlags, object value);
+        public virtual object GetDefaultThisObject();
+        public virtual FieldInfo GetField(string name, int lexLevel);
+        public virtual GlobalScope GetGlobalScope();
+        public virtual FieldInfo GetLocalField(string name);
+        public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
+        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        public object GetMemberValue(string name, int lexlevel);
+    }
+    public sealed class ActiveXObjectConstructor : ScriptFunction {
+        public new object CreateInstance(params object[] args);
+        public object Invoke();
+    }
+    public sealed class ArgumentsObject : JSObject {
+        public object callee;
+        public object caller;
+        public object length;
+    }
+    public sealed class ArrayConstructor : ScriptFunction {
+        public ArrayObject ConstructArray(object[] args);
+        public new ArrayObject CreateInstance(params object[] args);
+        public ArrayObject Invoke(params object[] args);
+    }
+    public sealed class ArrayLiteral : AST {
+        public ArrayLiteral(Context context, ASTList elements);
+    }
+    public class ArrayObject : JSObject {
+        public virtual object length { get; set; }
+        protected void SpliceSlowly(uint start, uint deleteCount, object[] args, ArrayObject outArray, uint oldLength, uint newLength);
+    }
+    public class ArrayPrototype : ArrayObject {
+        public static ArrayConstructor constructor { get; }
+        public static ArrayObject concat(object thisob, VsaEngine engine, params object[] args);
+        public static string join(object thisob, object separator);
+        public static object pop(object thisob);
+        public static long push(object thisob, params object[] args);
+        public static object reverse(object thisob);
+        public static object shift(object thisob);
+        public static ArrayObject slice(object thisob, VsaEngine engine, double start, object end);
+        public static object sort(object thisob, object function);
+        public static ArrayObject splice(object thisob, VsaEngine engine, double start, double deleteCnt, params object[] args);
+        public static string toLocaleString(object thisob);
+        public static string toString(object thisob);
+        public static object unshift(object thisob, params object[] args);
+    }
+    public class ArrayWrapper : ArrayObject {
+        public override object length { get; set; }
+        public new Type GetType();
+    }
+    public sealed class AssemblyCustomAttributeList : AST
+    public abstract class AST
+    public sealed class ASTList : AST
+    public abstract class BinaryOp : AST {
+        protected AST operand1;
+        protected AST operand2;
+        protected JSToken operatorTok;
+        protected MethodInfo operatorMeth;
+        protected Type type1;
+        protected Type type2;
+        protected MethodInfo GetOperator(IReflect ir1, IReflect ir2);
+    }
+    public abstract class Binding : AST {
+        protected bool isAssignmentToDefaultIndexedProperty;
+        protected bool isFullyResolved;
+        protected bool isNonVirtual;
+        protected MemberInfo defaultMember;
+        protected string name;
+        protected abstract object GetObject();
+        protected abstract void HandleNoSuchMemberError();
+        public static bool IsMissing(object value);
+        protected void ResolveRHValue();
+        protected abstract void TranslateToILObject(ILGenerator il, Type obtype, bool noValue);
+        protected abstract void TranslateToILWithDupOfThisOb(ILGenerator il);
+    }
+    public sealed class BitwiseBinary : BinaryOp {
+        public BitwiseBinary(int operatorTok);
+        public object EvaluateBitwiseBinary(object v1, object v2);
+    }
+    public sealed class Block : AST
+    public class BlockScope : ActivationObject {
+        public BlockScope(ScriptObject parent, string name, int scopeId);
+        protected override JSVariableField CreateField(string name, FieldAttributes attributeFlags, object value);
+    }
+    public sealed class BooleanConstructor : ScriptFunction {
+        public new BooleanObject CreateInstance(params object[] args);
+        public bool Invoke(object arg);
+    }
+    public class BooleanObject : JSObject {
+        protected BooleanObject(ScriptObject prototype, Type subType);
+        public new Type GetType();
+    }
+    public class BooleanPrototype : BooleanObject {
+        protected BooleanPrototype(ObjectPrototype parent, Type baseType);
+        public static BooleanConstructor constructor { get; }
+        public static string toString(object thisob);
+        public static object valueOf(object thisob);
+    }
+    public sealed class BreakOutOfFinally : ApplicationException {
+        public int target;
+        public BreakOutOfFinally(int target);
+        public BreakOutOfFinally(string m);
+        public BreakOutOfFinally(string m, Exception e);
+        public override void GetObjectData(SerializationInfo s, StreamingContext c);
+    }
+    public sealed class Closure : ScriptFunction {
+        public object arguments;
+        public object caller;
+        public Closure(FunctionObject func);
+        public override string ToString();
+    }
+    public enum CmdLineError {
+        AssemblyNotFound = 2001,
+        CannotCreateEngine = 2002,
+        CompilerConstant = 2003,
+        DuplicateFileAsSourceAndAssembly = 2004,
+        DuplicateResourceFile = 2005,
+        DuplicateResourceName = 2006,
+        DuplicateSourceFile = 2007,
+        ErrorSavingCompiledState = 2008,
+        IncompatibleTargets = 2038,
+        InvalidAssembly = 2009,
+        InvalidCharacters = 2036,
+        InvalidCodePage = 2010,
+        InvalidDefinition = 2011,
+        InvalidForCompilerOptions = 2037,
+        InvalidLocaleID = 2012,
+        InvalidPlatform = 2039,
+        InvalidSourceFile = 2014,
+        InvalidTarget = 2013,
+        InvalidVersion = 2031,
+        InvalidWarningLevel = 2015,
+        LAST = 2039,
+        ManagedResourceNotFound = 2022,
+        MissingDefineArgument = 2018,
+        MissingExtension = 2019,
+        MissingLibArgument = 2020,
+        MissingReference = 2034,
+        MissingVersionInfo = 2021,
+        MultipleOutputNames = 2016,
+        MultipleTargets = 2017,
+        MultipleWin32Resources = 2033,
+        NestedResponseFiles = 2023,
+        NoCodePage = 2024,
+        NoError = 0,
+        NoFileName = 2025,
+        NoInputSourcesSpecified = 2026,
+        NoLocaleID = 2027,
+        NoWarningLevel = 2028,
+        ResourceNotFound = 2029,
+        SourceFileTooBig = 2032,
+        SourceNotFound = 2035,
+        UnknownOption = 2030,
+        Unspecified = 2999,
+    }
+    public class CmdLineException : Exception {
+        public CmdLineException();
+        public CmdLineException(CmdLineError errorCode, CultureInfo culture);
+        public CmdLineException(CmdLineError errorCode, string context, CultureInfo culture);
+        protected CmdLineException(SerializationInfo s, StreamingContext c);
+        public CmdLineException(string m);
+        public CmdLineException(string m, Exception e);
+        public override string Message { get; }
+        public override void GetObjectData(SerializationInfo s, StreamingContext c);
+        public string ResourceKey(CmdLineError errorCode);
+    }
+    public class CmdLineOptionParser {
+        public CmdLineOptionParser();
+        public static string IsArgumentOption(string option, string prefix);
+        public static string IsArgumentOption(string option, string shortPrefix, string longPrefix);
+        public static object IsBooleanOption(string option, string prefix);
+        public static object IsBooleanOption(string option, string shortPrefix, string longPrefix);
+        public static bool IsSimpleOption(string option, string prefix);
+    }
+    public class COMCharStream : Stream {
+        public COMCharStream(IMessageReceiver messageReceiver);
+        public override bool CanRead { get; }
+        public override bool CanSeek { get; }
+        public override bool CanWrite { get; }
+        public override long Length { get; }
+        public override long Position { get; set; }
+        public override void Close();
+        public override void Flush();
+        public override int Read(byte[] buffer, int offset, int count);
+        public override long Seek(long offset, SeekOrigin origin);
+        public override void SetLength(long value);
+        public override void Write(byte[] buffer, int offset, int count);
+    }
+    public class COMFieldInfo : FieldInfo, MemberInfoInitializer {
+        public COMFieldInfo();
+        public override FieldAttributes Attributes { get; }
+        public override Type DeclaringType { get; }
+        public override RuntimeFieldHandle FieldHandle { get; }
+        public override Type FieldType { get; }
+        public override MemberTypes MemberType { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public COMMemberInfo GetCOMMemberInfo();
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type t, bool inherit);
+        public override object GetValue(object obj);
+        public virtual void Initialize(string name, COMMemberInfo dispatch);
+        public override bool IsDefined(Type t, bool inherit);
+        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);
+    }
+    public interface COMMemberInfo {
+        object Call(BindingFlags invokeAttr, Binder binder, object[] arguments, CultureInfo culture);
+        object GetValue(BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
+        void SetValue(object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
+    }
+    public class COMMethodInfo : JSMethod, MemberInfoInitializer {
+        protected COMMemberInfo _comObject;
+        protected static readonly ParameterInfo[] EmptyParams;
+        protected string _name;
+        public COMMethodInfo();
+        public override MethodAttributes Attributes { get; }
+        public override Type DeclaringType { get; }
+        public override MemberTypes MemberType { get; }
+        public override RuntimeMethodHandle MethodHandle { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public override Type ReturnType { get; }
+        public override ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
+        public override MethodInfo GetBaseDefinition();
+        public COMMemberInfo GetCOMMemberInfo();
+        public override MethodImplAttributes GetMethodImplementationFlags();
+        public override ParameterInfo[] GetParameters();
+        public virtual void Initialize(string name, COMMemberInfo dispatch);
+        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        public override string ToString();
+    }
+    public sealed class COMPropertyInfo : PropertyInfo, MemberInfoInitializer {
+        public COMPropertyInfo();
+        public override PropertyAttributes Attributes { get; }
+        public override bool CanRead { get; }
+        public override bool CanWrite { get; }
+        public override Type DeclaringType { get; }
+        public override MemberTypes MemberType { get; }
+        public override string Name { get; }
+        public override Type PropertyType { get; }
+        public override Type ReflectedType { get; }
+        public override MethodInfo[] GetAccessors(bool nonPublic);
+        public COMMemberInfo GetCOMMemberInfo();
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type t, bool inherit);
+        public override MethodInfo GetGetMethod(bool nonPublic);
+        public override ParameterInfo[] GetIndexParameters();
+        public override MethodInfo GetSetMethod(bool nonPublic);
+        public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
+        public void Initialize(string name, COMMemberInfo dispatch);
+        public override bool IsDefined(Type t, bool inherit);
+        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
+    }
+    public class Context {
+        public int EndColumn { get; }
+        public int EndLine { get; }
+        public int EndPosition { get; }
+        public int StartColumn { get; }
+        public int StartLine { get; }
+        public int StartPosition { get; }
+        public string GetCode();
+        public JSToken GetToken();
+    }
+    public sealed class ContinueOutOfFinally : ApplicationException {
+        public int target;
+        public ContinueOutOfFinally();
+        public ContinueOutOfFinally(int target);
+        public ContinueOutOfFinally(string m);
+        public ContinueOutOfFinally(string m, Exception e);
+        public override void GetObjectData(SerializationInfo s, StreamingContext c);
+    }
+    public sealed class Convert {
+        public Convert();
+        public static double CheckIfDoubleIsInteger(double d);
+        public static float CheckIfSingleIsInteger(float s);
+        public static object Coerce(object value, object type);
+        public static object Coerce2(object value, TypeCode target, bool truncationPermitted);
+        public static object CoerceT(object value, Type t, bool explicitOK);
+        public static bool IsBadIndex(AST ast);
+        public static void ThrowTypeMismatch(object val);
+        public static bool ToBoolean(double d);
+        public static bool ToBoolean(object value);
+        public static bool ToBoolean(object value, bool explicitConversion);
+        public static object ToForInObject(object value, VsaEngine engine);
+        public static int ToInt32(object value);
+        public static object ToNativeArray(object value, RuntimeTypeHandle handle);
+        public static double ToNumber(object value);
+        public static double ToNumber(string str);
+        public static object ToObject(object value, VsaEngine engine);
+        public static object ToObject2(object value, VsaEngine engine);
+        public static string ToString(bool b);
+        public static string ToString(double d);
+        public static string ToString(object value, bool explicitOK);
+    }
+    public class DateConstructor : ScriptFunction {
+        public new DateObject CreateInstance(params object[] args);
+        public string Invoke();
+        public static double parse(string str);
+        public static double UTC(object year, object month, object date, object hours, object minutes, object seconds, object ms);
+    }
+    public class DateObject : JSObject
+    public class DatePrototype : DateObject {
+        public static DateConstructor constructor { get; }
+        public static double getDate(object thisob);
+        public static double getDay(object thisob);
+        public static double getFullYear(object thisob);
+        public static double getHours(object thisob);
+        public static double getMilliseconds(object thisob);
+        public static double getMinutes(object thisob);
+        public static double getMonth(object thisob);
+        public static double getSeconds(object thisob);
+        public static double getTime(object thisob);
+        public static double getTimezoneOffset(object thisob);
+        public static double getUTCDate(object thisob);
+        public static double getUTCDay(object thisob);
+        public static double getUTCFullYear(object thisob);
+        public static double getUTCHours(object thisob);
+        public static double getUTCMilliseconds(object thisob);
+        public static double getUTCMinutes(object thisob);
+        public static double getUTCMonth(object thisob);
+        public static double getUTCSeconds(object thisob);
+        public static object getVarDate(object thisob);
+        public static double getYear(object thisob);
+        public static double setDate(object thisob, double ddate);
+        public static double setFullYear(object thisob, double dyear, object month, object date);
+        public static double setHours(object thisob, double dhour, object min, object sec, object msec);
+        public static double setMilliseconds(object thisob, double dmsec);
+        public static double setMinutes(object thisob, double dmin, object sec, object msec);
+        public static double setMonth(object thisob, double dmonth, object date);
+        public static double setSeconds(object thisob, double dsec, object msec);
+        public static double setTime(object thisob, double time);
+        public static double setUTCDate(object thisob, double ddate);
+        public static double setUTCFullYear(object thisob, double dyear, object month, object date);
+        public static double setUTCHours(object thisob, double dhour, object min, object sec, object msec);
+        public static double setUTCMilliseconds(object thisob, double dmsec);
+        public static double setUTCMinutes(object thisob, double dmin, object sec, object msec);
+        public static double setUTCMonth(object thisob, double dmonth, object date);
+        public static double setUTCSeconds(object thisob, double dsec, object msec);
+        public static double setYear(object thisob, double dyear);
+        public static string toDateString(object thisob);
+        public static string toGMTString(object thisob);
+        public static string toLocaleDateString(object thisob);
+        public static string toLocaleString(object thisob);
+        public static string toLocaleTimeString(object thisob);
+        public static string toString(object thisob);
+        public static string toTimeString(object thisob);
+        public static string toUTCString(object thisob);
+        public static double valueOf(object thisob);
+    }
+    public class DebugBreak : AST
+    public class DebugConvert : IDebugConvert, IDebugConvert2 {
+        public DebugConvert();
+        public string BooleanToString(bool value);
+        public string ByteToString(byte value, int radix);
+        public string DecimalToString(decimal value);
+        public string DoubleToDateString(double value);
+        public string DoubleToString(double value);
+        public string GetErrorMessageForHR(int hr, IJSVsaEngine engine);
+        public object GetManagedCharObject(ushort i);
+        public object GetManagedInt64Object(long i);
+        public object GetManagedObject(object value);
+        public object GetManagedUInt64Object(ulong i);
+        public string Int16ToString(short value, int radix);
+        public string Int32ToString(int value, int radix);
+        public string Int64ToString(long value, int radix);
+        public string RegexpToString(string source, bool ignoreCase, bool global, bool multiline);
+        public string SByteToString(sbyte value, int radix);
+        public string SingleToString(float value);
+        public string StringToPrintable(string source);
+        public object ToPrimitive(object value, TypeCode typeCode, bool truncationPermitted);
+        public string UInt16ToString(ushort value, int radix);
+        public string UInt32ToString(uint value, int radix);
+        public string UInt64ToString(ulong value, int radix);
+    }
+    public class DocumentContext
+    public sealed class DynamicFieldInfo {
+        public object value;
+        public string fieldTypeName;
+        public string name;
+        public DynamicFieldInfo(string name, object value);
+        public DynamicFieldInfo(string name, object value, string fieldTypeName);
+    }
+    public sealed class Empty {
+        public static readonly Empty Value;
+    }
+    public class EndOfFile : ParserException
+    public sealed class EnumeratorConstructor : ScriptFunction {
+        public new EnumeratorObject CreateInstance(params object[] args);
+        public object Invoke();
+    }
+    public class EnumeratorObject : JSObject {
+        protected IEnumerator enumerator;
+        protected void LoadObject();
+    }
+    public class EnumeratorPrototype : JSObject {
+        public static EnumeratorConstructor constructor { get; }
+        public static bool atEnd(object thisob);
+        public static object item(object thisob);
+        public static void moveFirst(object thisob);
+        public static void moveNext(object thisob);
+    }
+    public class Equality : BinaryOp {
+        public Equality(int operatorTok);
+        public bool EvaluateEquality(object v1, object v2);
+        public static bool JScriptEquals(object v1, object v2);
+    }
+    public sealed class ErrorConstructor : ScriptFunction {
+        public new ErrorObject CreateInstance(params object[] args);
+        public object Invoke(params object[] args);
+    }
+    public class ErrorObject : JSObject {
+        public object description;
+        public object message;
+        public object number;
+        public static explicit operator Exception (ErrorObject err);
+        public static Exception ToException(ErrorObject err);
+    }
+    public class ErrorPrototype : JSObject {
+        public readonly string name;
+        public ErrorConstructor constructor { get; }
+        public static string toString(object thisob);
+    }
+    public enum ErrorType {
+        EvalError = 1,
+        OtherError = 0,
+        RangeError = 2,
+        ReferenceError = 3,
+        SyntaxError = 4,
+        TypeError = 5,
+        URIError = 6,
+    }
+    public sealed class Eval : AST {
+        public static object JScriptEvaluate(object source, VsaEngine engine);
+        public static object JScriptEvaluate(object source, object unsafeOption, VsaEngine engine);
+    }
+    public sealed class EvalErrorObject : ErrorObject
+    public class Expando : Attribute {
+        public Expando();
+    }
+    public abstract class FieldAccessor {
+        protected FieldAccessor();
+        public abstract object GetValue(object thisob);
+        public abstract void SetValue(object thisob, object value);
+    }
+    public sealed class ForIn : AST {
+        public static IEnumerator JScriptGetEnumerator(object coll);
+    }
+    public sealed class FunctionConstructor : ScriptFunction {
+        public new ScriptFunction CreateInstance(params object[] args);
+        public ScriptFunction Invoke(params object[] args);
+    }
+    public sealed class FunctionDeclaration : AST {
+        public static Closure JScriptFunctionDeclaration(RuntimeTypeHandle handle, string name, string method_name, string[] formal_parameters, JSLocalField[] fields, bool must_save_stack_locals, bool hasArgumentsObject, string text, object declaringObject, VsaEngine engine);
+    }
+    public sealed class FunctionExpression : AST {
+        public static FunctionObject JScriptFunctionExpression(RuntimeTypeHandle handle, string name, string method_name, string[] formal_params, JSLocalField[] fields, bool must_save_stack_locals, bool hasArgumentsObject, string text, VsaEngine engine);
+    }
+    public sealed class FunctionObject : ScriptFunction {
+        public override string ToString();
+    }
+    public class FunctionPrototype : ScriptFunction {
+        public static FunctionConstructor constructor { get; }
+        public static object apply(object thisob, object thisarg, object argArray);
+        public static object call(object thisob, object thisarg, params object[] args);
+        public static string toString(object thisob);
+    }
+    public sealed class FunctionWrapper : ScriptFunction {
+        public override string ToString();
+    }
+    public class GlobalObject {
+        protected ActiveXObjectConstructor originalActiveXObjectField;
+        protected ArrayConstructor originalArrayField;
+        protected BooleanConstructor originalBooleanField;
+        protected DateConstructor originalDateField;
+        public static readonly Empty undefined;
+        protected EnumeratorConstructor originalEnumeratorField;
+        protected ErrorConstructor originalErrorField;
+        protected ErrorConstructor originalEvalErrorField;
+        protected ErrorConstructor originalRangeErrorField;
+        protected ErrorConstructor originalReferenceErrorField;
+        protected ErrorConstructor originalSyntaxErrorField;
+        protected ErrorConstructor originalTypeErrorField;
+        protected ErrorConstructor originalURIErrorField;
+        protected FunctionConstructor originalFunctionField;
+        protected NumberConstructor originalNumberField;
+        protected ObjectConstructor originalObjectField;
+        protected ObjectPrototype originalObjectPrototypeField;
+        protected RegExpConstructor originalRegExpField;
+        protected StringConstructor originalStringField;
+        protected VBArrayConstructor originalVBArrayField;
+        public const double Infinity = 1.0 / 0.0;
+        public const double NaN = 0.0 / 0.0;
+        public static ActiveXObjectConstructor ActiveXObject { get; }
+        public static ArrayConstructor Array { get; }
+        public static BooleanConstructor Boolean { get; }
+        public static Type boolean { get; }
+        public static Type @byte { get; }
+        public static Type @char { get; }
+        public static DateConstructor Date { get; }
+        public static Type @decimal { get; }
+        public static Type @double { get; }
+        public static EnumeratorConstructor Enumerator { get; }
+        public static ErrorConstructor Error { get; }
+        public static ErrorConstructor EvalError { get; }
+        public static Type @float { get; }
+        public static FunctionConstructor Function { get; }
+        public static Type @int { get; }
+        public static Type @long { get; }
+        public static MathObject Math { get; }
+        public static NumberConstructor Number { get; }
+        public static ObjectConstructor Object { get; }
+        public static ErrorConstructor RangeError { get; }
+        public static ErrorConstructor ReferenceError { get; }
+        public static RegExpConstructor RegExp { get; }
+        public static Type @sbyte { get; }
+        public static Type @short { get; }
+        public static StringConstructor String { get; }
+        public static ErrorConstructor SyntaxError { get; }
+        public static ErrorConstructor TypeError { get; }
+        public static Type @uint { get; }
+        public static Type @ulong { get; }
+        public static ErrorConstructor URIError { get; }
+        public static Type @ushort { get; }
+        public static VBArrayConstructor VBArray { get; }
+        public static Type @void { get; }
+        public static void CollectGarbage();
+        public static string decodeURI(object encodedURI);
+        public static string decodeURIComponent(object encodedURI);
+        public static string encodeURI(object uri);
+        public static string encodeURIComponent(object uriComponent);
+        public static string escape(object @string);
+        public static object eval(object x);
+        public static object GetObject(object moniker, object progId);
+        public static bool isFinite(double number);
+        public static bool isNaN(object num);
+        public static double parseFloat(object @string);
+        public static double parseInt(object @string, object radix);
+        public static string ScriptEngine();
+        public static int ScriptEngineBuildVersion();
+        public static int ScriptEngineMajorVersion();
+        public static int ScriptEngineMinorVersion();
+        public static string unescape(object @string);
+    }
+    public sealed class Globals {
+        public static VsaEngine contextEngine;
+        public static ArrayObject ConstructArray(params object[] args);
+        public static ArrayObject ConstructArrayLiteral(object[] args);
+    }
+    public class GlobalScope : ActivationObject, IExpando, IReflect {
+        public GlobalScope(GlobalScope parent, VsaEngine engine);
+        public FieldInfo AddField(string name);
+        public override object GetDefaultThisObject();
+        public override FieldInfo GetField(string name, int lexLevel);
+        public override FieldInfo[] GetFields(BindingFlags bindingAttr);
+        public override GlobalScope GetGlobalScope();
+        public override FieldInfo GetLocalField(string name);
+        public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
+        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        public override MethodInfo[] GetMethods(BindingFlags bindingAttr);
+        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr);
+        MethodInfo System.Runtime.InteropServices.Expando.IExpando.AddMethod(string name, Delegate method);
+        PropertyInfo System.Runtime.InteropServices.Expando.IExpando.AddProperty(string name);
+        void System.Runtime.InteropServices.Expando.IExpando.RemoveMember(MemberInfo m);
+    }
+    public class Hide : Attribute {
+        public Hide();
+    }
+    public interface IActivationObject {
+        object GetDefaultThisObject();
+        FieldInfo GetField(string name, int lexLevel);
+        GlobalScope GetGlobalScope();
+        FieldInfo GetLocalField(string name);
+        object GetMemberValue(string name, int lexlevel);
+    }
+    public interface IAuthorServices {
+        IParseText GetCodeSense();
+        IColorizeText GetColorizer();
+    }
+    public interface IColorizeText {
+        ITokenEnumerator Colorize(string sourceCode, SourceState state);
+        SourceState GetStateForText(string sourceCode, SourceState currentState);
+    }
+    public interface IDebugConvert {
+        string BooleanToString(bool value);
+        string ByteToString(byte value, int radix);
+        string DoubleToDateString(double value);
+        string DoubleToString(double value);
+        string GetErrorMessageForHR(int hr, IJSVsaEngine engine);
+        object GetManagedCharObject(ushort i);
+        object GetManagedInt64Object(long i);
+        object GetManagedObject(object value);
+        object GetManagedUInt64Object(ulong i);
+        string Int16ToString(short value, int radix);
+        string Int32ToString(int value, int radix);
+        string Int64ToString(long value, int radix);
+        string RegexpToString(string source, bool ignoreCase, bool global, bool multiline);
+        string SByteToString(sbyte value, int radix);
+        string SingleToString(float value);
+        string StringToPrintable(string source);
+        object ToPrimitive(object value, TypeCode typeCode, bool truncationPermitted);
+        string UInt16ToString(ushort value, int radix);
+        string UInt32ToString(uint value, int radix);
+        string UInt64ToString(ulong value, int radix);
+    }
+    public interface IDebugConvert2 {
+        string DecimalToString(decimal value);
+    }
+    public interface IDebuggerObject {
+        bool HasEnumerableMember(string name);
+        bool IsCOMObject();
+        bool IsEqual(IDebuggerObject o);
+        bool IsScriptFunction();
+        bool IsScriptObject();
+    }
+    public interface IDebugScriptScope {
+        void SetThisValue(object thisValue);
+    }
+    public interface IDebugType {
+        bool HasInstance(object o);
+    }
+    public interface IDebugVsaScriptCodeItem {
+        object Evaluate();
+        bool ParseNamedBreakPoint(string input, out string functionName, out int nargs, out string arguments, out string returnType, out ulong offset);
+    }
+    public interface IDefineEvent {
+        object AddEvent(string code, int startLine);
+    }
+    public interface IEngine2 {
+        IJSVsaEngine Clone(AppDomain domain);
+        bool CompileEmpty();
+        void ConnectEvents();
+        void DisconnectEvents();
+        Assembly GetAssembly();
+        IVsaScriptScope GetGlobalScope();
+        Module GetModule();
+        void InitVsaEngine(string rootMoniker, IJSVsaSite site);
+        void Interrupt();
+        void RegisterEventSource(string name);
+        void Restart();
+        void Run(AppDomain domain);
+        void RunEmpty();
+    }
+    public interface IErrorHandler {
+        bool OnCompilerError(IVsaFullErrorInfo error);
+    }
+    public interface IMessageReceiver {
+        void Message(string strValue);
+    }
+    public interface IMethodsCompletionInfo
+    public sealed class Import : AST {
+        public static void JScriptImport(string name, VsaEngine engine);
+    }
+    public sealed class In : BinaryOp {
+        public static bool JScriptIn(object v1, object v2);
+    }
+    public interface INeedEngine {
+        VsaEngine GetEngine();
+        void SetEngine(VsaEngine engine);
+    }
+    public sealed class Instanceof : BinaryOp {
+        public static bool JScriptInstanceof(object v1, object v2);
+    }
+    public interface IObjectCompletionInfo
+    public interface IParseText {
+        void Parse(string code, IErrorHandler error);
+    }
+    public interface IRedirectOutput {
+        void SetOutputStream(IMessageReceiver output);
+    }
+    public interface ISite2 {
+        object[] GetParentChain(object obj);
+    }
+    public interface ITokenColorInfo {
+        TokenColor Color { get; }
+        int EndPosition { get; }
+        int StartPosition { get; }
+    }
+    public interface ITokenEnumerator {
+        ITokenColorInfo GetNext();
+        void Reset();
+    }
+    public interface IVsaFullErrorInfo : IJSVsaError {
+        int EndLine { get; }
+    }
+    public interface IVsaScriptCodeItem : IJSVsaCodeItem, IJSVsaItem {
+        int StartColumn { get; set; }
+        int StartLine { get; set; }
+        object Execute();
+    }
+    public interface IVsaScriptScope : IJSVsaItem {
+        IVsaScriptScope Parent { get; }
+        IJSVsaItem AddItem(string itemName, JSVsaItemType type);
+        IJSVsaItem CreateDynamicItem(string itemName, JSVsaItemType type);
+        IJSVsaItem GetItem(string itemName);
+        IJSVsaItem GetItemAtIndex(int index);
+        int GetItemCount();
+        object GetObject();
+        void RemoveItem(IJSVsaItem item);
+        void RemoveItem(string itemName);
+        void RemoveItemAtIndex(int index);
+    }
+    public interface IWrappedMember {
+        object GetWrappedObject();
+    }
+    public class JSAuthor : IAuthorServices {
+        public JSAuthor();
+        public virtual IParseText GetCodeSense();
+        public virtual IColorizeText GetColorizer();
+    }
+    public enum JSBuiltin {
+        Array_concat = 1,
+        Array_join = 2,
+        Array_pop = 3,
+        Array_push = 4,
+        Array_reverse = 5,
+        Array_shift = 6,
+        Array_slice = 7,
+        Array_sort = 8,
+        Array_splice = 9,
+        Array_toLocaleString = 10,
+        Array_toString = 11,
+        Array_unshift = 12,
+        Boolean_toString = 13,
+        Boolean_valueOf = 14,
+        Date_getDate = 15,
+        Date_getDay = 16,
+        Date_getFullYear = 17,
+        Date_getHours = 18,
+        Date_getMilliseconds = 19,
+        Date_getMinutes = 20,
+        Date_getMonth = 21,
+        Date_getSeconds = 22,
+        Date_getTime = 23,
+        Date_getTimezoneOffset = 24,
+        Date_getUTCDate = 25,
+        Date_getUTCDay = 26,
+        Date_getUTCFullYear = 27,
+        Date_getUTCHours = 28,
+        Date_getUTCMilliseconds = 29,
+        Date_getUTCMinutes = 30,
+        Date_getUTCMonth = 31,
+        Date_getUTCSeconds = 32,
+        Date_getVarDate = 33,
+        Date_getYear = 34,
+        Date_parse = 35,
+        Date_setDate = 36,
+        Date_setFullYear = 37,
+        Date_setHours = 38,
+        Date_setMilliseconds = 40,
+        Date_setMinutes = 39,
+        Date_setMonth = 41,
+        Date_setSeconds = 42,
+        Date_setTime = 43,
+        Date_setUTCDate = 44,
+        Date_setUTCFullYear = 45,
+        Date_setUTCHours = 46,
+        Date_setUTCMilliseconds = 48,
+        Date_setUTCMinutes = 47,
+        Date_setUTCMonth = 49,
+        Date_setUTCSeconds = 50,
+        Date_setYear = 51,
+        Date_toDateString = 52,
+        Date_toGMTString = 53,
+        Date_toLocaleDateString = 54,
+        Date_toLocaleString = 55,
+        Date_toLocaleTimeString = 56,
+        Date_toString = 57,
+        Date_toTimeString = 58,
+        Date_toUTCString = 59,
+        Date_UTC = 60,
+        Date_valueOf = 61,
+        Enumerator_atEnd = 62,
+        Enumerator_item = 63,
+        Enumerator_moveFirst = 64,
+        Enumerator_moveNext = 65,
+        Error_toString = 66,
+        Function_apply = 67,
+        Function_call = 68,
+        Function_toString = 69,
+        Global_CollectGarbage = 70,
+        Global_decodeURI = 71,
+        Global_decodeURIComponent = 72,
+        Global_encodeURI = 73,
+        Global_encodeURIComponent = 74,
+        Global_escape = 75,
+        Global_eval = 76,
+        Global_GetObject = 77,
+        Global_isFinite = 79,
+        Global_isNaN = 78,
+        Global_parseFloat = 80,
+        Global_parseInt = 81,
+        Global_ScriptEngine = 82,
+        Global_ScriptEngineBuildVersion = 83,
+        Global_ScriptEngineMajorVersion = 84,
+        Global_ScriptEngineMinorVersion = 85,
+        Global_unescape = 86,
+        Math_abs = 87,
+        Math_acos = 88,
+        Math_asin = 89,
+        Math_atan = 90,
+        Math_atan2 = 91,
+        Math_ceil = 92,
+        Math_cos = 93,
+        Math_exp = 94,
+        Math_floor = 95,
+        Math_log = 96,
+        Math_max = 97,
+        Math_min = 98,
+        Math_pow = 99,
+        Math_random = 100,
+        Math_round = 101,
+        Math_sin = 102,
+        Math_sqrt = 103,
+        Math_tan = 104,
+        None = 0,
+        Number_toExponential = 105,
+        Number_toFixed = 106,
+        Number_toLocaleString = 107,
+        Number_toPrecision = 108,
+        Number_toString = 109,
+        Number_valueOf = 110,
+        Object_hasOwnProperty = 111,
+        Object_isPrototypeOf = 112,
+        Object_propertyIsEnumerable = 113,
+        Object_toLocaleString = 114,
+        Object_toString = 115,
+        Object_valueOf = 116,
+        RegExp_compile = 117,
+        RegExp_exec = 118,
+        RegExp_test = 119,
+        RegExp_toString = 120,
+        String_anchor = 121,
+        String_big = 122,
+        String_blink = 123,
+        String_bold = 124,
+        String_charAt = 125,
+        String_charCodeAt = 126,
+        String_concat = 127,
+        String_fixed = 128,
+        String_fontcolor = 129,
+        String_fontsize = 130,
+        String_fromCharCode = 131,
+        String_indexOf = 132,
+        String_italics = 133,
+        String_lastIndexOf = 134,
+        String_link = 135,
+        String_localeCompare = 136,
+        String_match = 137,
+        String_replace = 138,
+        String_search = 139,
+        String_slice = 140,
+        String_small = 141,
+        String_split = 142,
+        String_strike = 143,
+        String_sub = 144,
+        String_substr = 145,
+        String_substring = 146,
+        String_sup = 147,
+        String_toLocaleLowerCase = 148,
+        String_toLocaleUpperCase = 149,
+        String_toLowerCase = 150,
+        String_toString = 151,
+        String_toUpperCase = 152,
+        String_valueOf = 153,
+        VBArray_dimensions = 154,
+        VBArray_getItem = 155,
+        VBArray_lbound = 156,
+        VBArray_toArray = 157,
+        VBArray_ubound = 158,
+    }
+    public sealed class JSConstructor : ConstructorInfo {
+        public override MethodAttributes Attributes { get; }
+        public override Type DeclaringType { get; }
+        public override MemberTypes MemberType { get; }
+        public override RuntimeMethodHandle MethodHandle { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type t, bool inherit);
+        public override MethodImplAttributes GetMethodImplementationFlags();
+        public override ParameterInfo[] GetParameters();
+        public override object Invoke(object obj, BindingFlags options, Binder binder, object[] parameters, CultureInfo culture);
+        public override object Invoke(BindingFlags options, Binder binder, object[] parameters, CultureInfo culture);
+        public override bool IsDefined(Type type, bool inherit);
+    }
+    public sealed class JScriptCodeProvider : CodeDomProvider {
+        public JScriptCodeProvider();
+        public override string FileExtension { get; }
+        public override ICodeCompiler CreateCompiler();
+        public override ICodeGenerator CreateGenerator();
+    }
+    public class JScriptException : ApplicationException, IJSVsaError, IVsaFullErrorInfo {
+        public JScriptException();
+        public JScriptException(JSError errorNumber);
+        protected JScriptException(SerializationInfo info, StreamingContext context);
+        public JScriptException(string m);
+        public JScriptException(string m, Exception e);
+        public int Column { get; }
+        public string Description { get; }
+        public int EndColumn { get; }
+        public int EndLine { get; }
+        public int ErrorNumber { get; }
+        public int Line { get; }
+        public string LineText { get; }
+        public override string Message { get; }
+        string Microsoft.JScript.Vsa.IJSVsaError.Description { get; }
+        int Microsoft.JScript.Vsa.IJSVsaError.Number { get; }
+        public int Number { get; }
+        public int Severity { get; }
+        public IJSVsaItem SourceItem { get; }
+        public string SourceMoniker { get; }
+        public override string StackTrace { get; }
+        public int StartColumn { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum JSError {
+        AbstractCannotBePrivate = 1157,
+        AbstractCannotBeStatic = 1216,
+        AbstractWithBody = 1192,
+        ActionNotSupported = 445,
+        AmbiguousBindingBecauseOfEval = 1150,
+        AmbiguousBindingBecauseOfWith = 1149,
+        AmbiguousConstructorCall = 1184,
+        AmbiguousMatch = 1183,
+        ArrayLengthAssignIncorrect = 5030,
+        ArrayLengthConstructIncorrect = 5029,
+        ArrayMayBeCopied = 1215,
+        AssemblyAttributesMustBeGlobal = 1249,
+        AssignmentToReadOnly = 5040,
+        BadBreak = 1019,
+        BadContinue = 1020,
+        BadFunctionDeclaration = 1199,
+        BadHexDigit = 1023,
+        BadLabel = 1025,
+        BadModifierInInterface = 1224,
+        BadOctalLiteral = 1242,
+        BadPropertyDeclaration = 1200,
+        BadReturn = 1018,
+        BadSwitch = 1103,
+        BadThrow = 1239,
+        BadVariableDeclaration = 1198,
+        BadWayToLeaveFinally = 1190,
+        BaseClassIsExpandoAlready = 1156,
+        BooleanExpected = 5010,
+        CannotAssignToFunctionResult = 5003,
+        CannotBeAbstract = 1212,
+        CannotCallSecurityMethodLateBound = 5044,
+        CannotChangeVisibility = 1171,
+        CannotInstantiateAbstractClass = 1214,
+        CannotNestPositionDirective = 1119,
+        CannotReturnValueFromVoidFunction = 1182,
+        CannotUseNameOfClass = 1124,
+        CannotUseStaticSecurityAttribute = 5045,
+        CantAssignThis = 5000,
+        CantCreateObject = 429,
+        CcInvalidElif = 1106,
+        CcInvalidElse = 1105,
+        CcInvalidEnd = 1104,
+        CcInvalidInDebugger = 1256,
+        CcOff = 1030,
+        CircularDefinition = 1120,
+        ClashWithProperty = 1177,
+        ClassNotAllowed = 1109,
+        ConstructorMayNotHaveReturnType = 1233,
+        CustomAttributeUsedMoreThanOnce = 1236,
+        DateExpected = 5006,
+        DelegatesShouldNotBeExplicitlyConstructed = 1258,
+        Deprecated = 1121,
+        DifferentReturnTypeFromBase = 1176,
+        DoesNotHaveAnAddress = 1203,
+        DupDefault = 1027,
+        DuplicateMethod = 1251,
+        DuplicateName = 1111,
+        DuplicateNamedParameter = 5036,
+        DupVisibility = 1101,
+        EnumeratorExpected = 5015,
+        EnumNotAllowed = 1230,
+        ErrEOF = 1107,
+        ExceptionFromHResult = 6011,
+        ExecutablesCannotBeLocalized = 1254,
+        ExpandoClassShouldNotImpleEnumerable = 1162,
+        ExpandoMustBePublic = 1257,
+        ExpandoPrecludesAbstract = 1222,
+        ExpandoPrecludesOverride = 1220,
+        ExpandoPrecludesStatic = 1250,
+        ExpectedAssembly = 1248,
+        ExpressionExpected = 1195,
+        FileNotFound = 53,
+        FinalPrecludesAbstract = 1209,
+        FractionOutOfRange = 5026,
+        FuncEvalAborted = 6000,
+        FuncEvalBadLocation = 6007,
+        FuncEvalBadThreadNotStarted = 6005,
+        FuncEvalBadThreadState = 6004,
+        FuncEvalThreadSleepWaitJoin = 6003,
+        FuncEvalThreadSuspended = 6002,
+        FuncEvalTimedout = 6001,
+        FuncEvalWebMethod = 6008,
+        FunctionExpected = 5002,
+        GetAndSetAreInconsistent = 1142,
+        HidesAbstractInBase = 1172,
+        HidesParentMember = 1170,
+        IllegalAssignment = 5008,
+        IllegalChar = 1014,
+        IllegalEval = 5033,
+        IllegalParamArrayAttribute = 1221,
+        IllegalUseOfSuper = 1189,
+        IllegalUseOfThis = 1122,
+        IllegalVisibility = 1102,
+        ImplicitlyReferencedAssemblyNotFound = 1259,
+        ImpossibleConversion = 1208,
+        IncompatibleAssemblyReference = 1267,
+        IncompatibleVisibility = 1108,
+        IncorrectNumberOfIndices = 5042,
+        InstanceNotAccessibleFromStatic = 1243,
+        InterfaceIllegalInInterface = 1227,
+        InternalError = 51,
+        InvalidAssemblyKeyFile = 1268,
+        InvalidBaseTypeForEnum = 1213,
+        InvalidCall = 5,
+        InvalidCustomAttribute = 1143,
+        InvalidCustomAttributeArgument = 1144,
+        InvalidCustomAttributeClassOrCtor = 1146,
+        InvalidCustomAttributeTarget = 1231,
+        InvalidDebugDirective = 1235,
+        InvalidElse = 1034,
+        InvalidImport = 1229,
+        InvalidLanguageOption = 1179,
+        InvalidPositionDirective = 1114,
+        InvalidPrototype = 5023,
+        InvalidResource = 1262,
+        ItemNotAllowedOnExpandoClass = 1152,
+        KeywordUsedAsIdentifier = 1137,
+        MemberInitializerCannotContainFuncExpr = 1270,
+        MemberTypeCLSCompliantMismatch = 1265,
+        MethodClashOnExpandoSuperClass = 1155,
+        MethodInBaseIsNotVirtual = 1174,
+        MethodNotAllowedOnExpandoClass = 1153,
+        MissingConstructForAttributes = 1160,
+        MissingNameParameter = 5037,
+        MoreNamedParametersThanArguments = 5038,
+        MustBeEOL = 1115,
+        MustImplementMethod = 1128,
+        MustProvideNameForNamedParameter = 5035,
+        NeedArrayObject = 5031,
+        NeedCompileTimeConstant = 1110,
+        NeedInstance = 1210,
+        NeedInterface = 1129,
+        NeedObject = 424,
+        NeedType = 1112,
+        NestedInstanceTypeCannotBeExtendedByStatic = 1237,
+        NewNotSpecifiedInMethodDeclaration = 1173,
+        NoAt = 1032,
+        NoCatch = 1033,
+        NoCcEnd = 1029,
+        NoColon = 1003,
+        NoComma = 1100,
+        NoCommaOrTypeDefinitionError = 1191,
+        NoCommentEnd = 1016,
+        NoConstructor = 5032,
+        NoEqual = 1011,
+        NoError = 0,
+        NoFuncEvalAllowed = 6006,
+        NoIdentifier = 1010,
+        NoLabel = 1026,
+        NoLeftCurly = 1008,
+        NoLeftParen = 1005,
+        NoMemberIdentifier = 1028,
+        NoMethodInBaseToNew = 1175,
+        NoMethodInBaseToOverride = 1180,
+        NonCLSCompliantMember = 1163,
+        NonCLSCompliantType = 1264,
+        NonClsException = 5046,
+        NonStaticWithTypeName = 1245,
+        NonSupportedInDebugger = 5039,
+        NoRightBracket = 1007,
+        NoRightBracketOrComma = 1194,
+        NoRightCurly = 1009,
+        NoRightParen = 1006,
+        NoRightParenOrComma = 1193,
+        NoSemicolon = 1004,
+        NoSuchMember = 1151,
+        NoSuchStaticMember = 1246,
+        NoSuchType = 1241,
+        NotAccessible = 1123,
+        NotAllowedInSuperConstructorCall = 1140,
+        NotAnExpandoFunction = 1252,
+        NotCollection = 451,
+        NotConst = 1031,
+        NotDeletable = 1164,
+        NotIndexable = 1158,
+        NotInsideClass = 1113,
+        NotMeantToBeCalledDirectly = 1141,
+        NotOKToCallSuper = 1188,
+        NotValidForConstructor = 1181,
+        NotValidVersionString = 1253,
+        NotYetImplemented = 5034,
+        NoVarInEnum = 1228,
+        NoWhile = 1024,
+        NumberExpected = 5001,
+        ObjectExpected = 5007,
+        OctalLiteralsAreDeprecated = 1186,
+        OLENoPropOrMethod = 438,
+        OnlyClassesAllowed = 1161,
+        OnlyClassesAndPackagesAllowed = 1234,
+        OutOfMemory = 7,
+        OutOfStack = 28,
+        OverrideAndHideUsedTogether = 1178,
+        PackageExpected = 1165,
+        PackageInWrongContext = 1232,
+        ParamListNotLast = 1240,
+        PossibleBadConversion = 1260,
+        PossibleBadConversionFromString = 1261,
+        PrecisionOutOfRange = 5027,
+        PropertyLevelAttributesMustBeOnGetter = 1238,
+        RefParamsNonSupportedInDebugger = 5043,
+        RegExpExpected = 5016,
+        RegExpSyntax = 5017,
+        ShouldBeAbstract = 1223,
+        SideEffectsDisallowed = 6012,
+        StaticIsAlreadyFinal = 1217,
+        StaticMethodsCannotHide = 1219,
+        StaticMethodsCannotOverride = 1218,
+        StaticMissingInStaticInit = 1159,
+        StaticRequiresTypeName = 1244,
+        StaticVarNotAvailable = 6009,
+        StringConcatIsSlow = 1255,
+        StringExpected = 5005,
+        SuperClassConstructorNotAccessible = 1185,
+        SuspectAssignment = 1206,
+        SuspectLoopCondition = 1247,
+        SuspectSemicolon = 1207,
+        SyntaxError = 1002,
+        TooFewParameters = 1204,
+        TooManyParameters = 1148,
+        TooManyTokensSkipped = 1197,
+        TypeAssemblyCLSCompliantMismatch = 1266,
+        TypeCannotBeExtended = 1134,
+        TypeMismatch = 13,
+        TypeNameTooLong = 1269,
+        TypeObjectNotAvailable = 6010,
+        UncaughtException = 5022,
+        UndeclaredVariable = 1135,
+        UndefinedIdentifier = 5009,
+        UnexpectedSemicolon = 1196,
+        UnreachableCatch = 1133,
+        UnterminatedString = 1015,
+        URIDecodeError = 5025,
+        URIEncodeError = 5024,
+        UselessAssignment = 1205,
+        UselessExpression = 1169,
+        VariableLeftUninitialized = 1136,
+        VariableMightBeUnitialized = 1187,
+        VarIllegalInInterface = 1226,
+        VBArrayExpected = 5013,
+        WriteOnlyProperty = 5041,
+        WrongDirective = 1118,
+        WrongUseOfAddressOf = 1263,
+    }
+    public abstract class JSField : FieldInfo {
+        protected JSField();
+        public override FieldAttributes Attributes { get; }
+        public override Type DeclaringType { get; }
+        public override RuntimeFieldHandle FieldHandle { get; }
+        public override Type FieldType { get; }
+        public override MemberTypes MemberType { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type t, bool inherit);
+        public override bool IsDefined(Type type, bool inherit);
+    }
+    public sealed class JSFieldInfo : FieldInfo {
+        public override FieldAttributes Attributes { get; }
+        public override Type DeclaringType { get; }
+        public override RuntimeFieldHandle FieldHandle { get; }
+        public override Type FieldType { get; }
+        public override MemberTypes MemberType { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type t, bool inherit);
+        public override object GetValue(object obj);
+        public override bool IsDefined(Type type, bool inherit);
+        public new void SetValue(object obj, object value);
+        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);
+    }
+    public class JSFunctionAttribute : Attribute {
+        public JSFunctionAttribute(JSFunctionAttributeEnum value);
+        public JSFunctionAttribute(JSFunctionAttributeEnum value, JSBuiltin builtinFunction);
+        public JSFunctionAttributeEnum GetAttributeValue();
+    }
+    public enum JSFunctionAttributeEnum {
+        ClassicFunction = 35,
+        ClassicNestedFunction = 47,
+        HasArguments = 1,
+        HasEngine = 32,
+        HasStackFrame = 8,
+        HasThisObject = 2,
+        HasVarArgs = 16,
+        IsExpandoMethod = 64,
+        IsInstanceNestedClassConstructor = 128,
+        IsNested = 4,
+        NestedFunction = 44,
+        None = 0,
+    }
+    public sealed class JSLocalField : JSVariableField {
+        public JSLocalField(string name, RuntimeTypeHandle handle, int slotNumber);
+        public override Type FieldType { get; }
+        public override object GetValue(object obj);
+        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo locale);
+    }
+    public abstract class JSMethod : MethodInfo {
+        public override MemberTypes MemberType { get; }
+        public override RuntimeMethodHandle MethodHandle { get; }
+        public override Type ReflectedType { get; }
+        public override ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
+        public override MethodInfo GetBaseDefinition();
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type t, bool inherit);
+        public override MethodImplAttributes GetMethodImplementationFlags();
+        public override object Invoke(object obj, BindingFlags options, Binder binder, object[] parameters, CultureInfo culture);
+        public sealed override bool IsDefined(Type type, bool inherit);
+    }
+    public sealed class JSMethodInfo : MethodInfo {
+        public override MethodAttributes Attributes { get; }
+        public override Type DeclaringType { get; }
+        public override MemberTypes MemberType { get; }
+        public override RuntimeMethodHandle MethodHandle { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public override Type ReturnType { get; }
+        public override ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
+        public override MethodInfo GetBaseDefinition();
+        public sealed override object[] GetCustomAttributes(bool inherit);
+        public sealed override object[] GetCustomAttributes(Type type, bool inherit);
+        public override MethodImplAttributes GetMethodImplementationFlags();
+        public override ParameterInfo[] GetParameters();
+        public override object Invoke(object obj, BindingFlags options, Binder binder, object[] parameters, CultureInfo culture);
+        public sealed override bool IsDefined(Type type, bool inherit);
+        public override string ToString();
+    }
+    public class JSObject : ScriptObject, IEnumerable, IExpando, IReflect {
+        protected ArrayList field_table;
+        public JSObject();
+        public FieldInfo AddField(string name);
+        public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
+        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        public void SetMemberValue2(string name, object value);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        MethodInfo System.Runtime.InteropServices.Expando.IExpando.AddMethod(string name, Delegate method);
+        PropertyInfo System.Runtime.InteropServices.Expando.IExpando.AddProperty(string name);
+        void System.Runtime.InteropServices.Expando.IExpando.RemoveMember(MemberInfo m);
+        public override string ToString();
+    }
+    public class JSParser {
+        public JSParser(Context context);
+        public ScriptBlock Parse();
+        public Block ParseEvalBody();
+    }
+    public class JSPrototypeObject : JSObject {
+        public object constructor;
+    }
+    public sealed class JSScanner {
+        public JSScanner();
+        public JSScanner(Context sourceContext);
+        public int GetCurrentLine();
+        public int GetCurrentPosition(bool absolute);
+        public void GetNextToken();
+        public string GetSourceCode();
+        public int GetStartLinePosition();
+        public string GetStringLiteral();
+        public bool GotEndOfLine();
+        public static bool IsKeyword(JSToken token);
+        public static bool IsOperator(JSToken token);
+        public void SetAuthoringMode(bool mode);
+        public void SetSource(Context sourceContext);
+        public int SkipMultiLineComment();
+    }
+    public enum JSToken {
+        Abstract = 15,
+        AccessField = 38,
+        Assert = 104,
+        Assign = 69,
+        BitwiseAnd = 52,
+        BitwiseAndAssign = 74,
+        BitwiseNot = 40,
+        BitwiseOr = 50,
+        BitwiseOrAssign = 75,
+        BitwiseXor = 51,
+        BitwiseXorAssign = 76,
+        Boolean = 105,
+        Break = 6,
+        Byte = 106,
+        Case = 84,
+        Catch = 85,
+        Char = 107,
+        Class = 24,
+        Colon = 82,
+        Comma = 83,
+        Comment = 102,
+        ConditionalIf = 81,
+        Const = 23,
+        Continue = 5,
+        Debugger = 86,
+        Decimal = 108,
+        Decrement = 45,
+        Default = 87,
+        Delete = 41,
+        Divide = 65,
+        DivideAssign = 73,
+        Do = 3,
+        Double = 109,
+        DoubleColon = 110,
+        Else = 88,
+        EndOfFile = 0,
+        EndOfLine = 132,
+        Ensure = 112,
+        Enum = 111,
+        Equal = 53,
+        Event = 21,
+        Export = 89,
+        Extends = 90,
+        False = 30,
+        Final = 20,
+        Finally = 91,
+        FirstBinaryOp = 46,
+        FirstOp = 39,
+        Float = 113,
+        For = 2,
+        Function = 25,
+        Get = 92,
+        Goto = 114,
+        GreaterThan = 57,
+        GreaterThanEqual = 60,
+        Identifier = 32,
+        If = 1,
+        Implements = 93,
+        Import = 8,
+        In = 68,
+        Increment = 44,
+        Instanceof = 67,
+        Int = 115,
+        IntegerLiteral = 34,
+        Interface = 94,
+        Internal = 14,
+        Invariant = 116,
+        LastAssign = 80,
+        LastBinaryOp = 80,
+        LastOp = 83,
+        LastPPOperator = 66,
+        LeftBracket = 37,
+        LeftCurly = 26,
+        LeftParen = 36,
+        LeftShift = 61,
+        LeftShiftAssign = 78,
+        LessThan = 58,
+        LessThanEqual = 59,
+        LogicalAnd = 49,
+        LogicalNot = 39,
+        LogicalOr = 48,
+        Long = 117,
+        Minus = 47,
+        MinusAssign = 71,
+        Modulo = 66,
+        ModuloAssign = 77,
+        Multiply = 64,
+        MultiplyAssign = 72,
+        Namespace = 118,
+        Native = 119,
+        New = 95,
+        None = -1,
+        NotEqual = 54,
+        Null = 28,
+        NumericLiteral = 35,
+        Package = 13,
+        ParamArray = 126,
+        Plus = 46,
+        PlusAssign = 70,
+        PreProcessDirective = 133,
+        PreProcessorConstant = 101,
+        Private = 18,
+        Protected = 19,
+        Public = 16,
+        Require = 120,
+        Return = 7,
+        RightBracket = 100,
+        RightCurly = 99,
+        RightParen = 98,
+        RightShift = 62,
+        RightShiftAssign = 79,
+        Sbyte = 121,
+        Semicolon = 27,
+        Set = 96,
+        Short = 122,
+        Static = 17,
+        StrictEqual = 55,
+        StrictNotEqual = 56,
+        StringLiteral = 33,
+        Super = 97,
+        Switch = 10,
+        Synchronized = 123,
+        This = 31,
+        Throw = 11,
+        Throws = 125,
+        Transient = 124,
+        True = 29,
+        Try = 12,
+        Typeof = 43,
+        Uint = 129,
+        Ulong = 130,
+        UnsignedRightShift = 63,
+        UnsignedRightShiftAssign = 80,
+        UnterminatedComment = 103,
+        Use = 131,
+        Ushort = 128,
+        Var = 22,
+        Void = 42,
+        Volatile = 127,
+        While = 4,
+        With = 9,
+    }
+    public abstract class JSVariableField : JSField {
+        public override FieldAttributes Attributes { get; }
+        public override Type DeclaringType { get; }
+        public override Type FieldType { get; }
+        public override string Name { get; }
+        public override object[] GetCustomAttributes(bool inherit);
+    }
+    public sealed class LateBinding {
+        public object obj;
+        public LateBinding(string name);
+        public LateBinding(string name, object obj);
+        public object Call(object[] arguments, bool construct, bool brackets, VsaEngine engine);
+        public static object CallValue(object thisob, object val, object[] arguments, bool construct, bool brackets, VsaEngine engine);
+        public static object CallValue2(object val, object thisob, object[] arguments, bool construct, bool brackets, VsaEngine engine);
+        public bool Delete();
+        public static bool DeleteMember(object obj, string name);
+        public object GetNonMissingValue();
+        public object GetValue2();
+        public static void SetIndexedPropertyValueStatic(object obj, object[] arguments, object value);
+        public void SetValue(object value);
+    }
+    public sealed class LenientArrayPrototype : ArrayPrototype {
+        public object concat;
+        public object constructor;
+        public object join;
+        public object pop;
+        public object push;
+        public object reverse;
+        public object shift;
+        public object slice;
+        public object sort;
+        public object splice;
+        public object toLocaleString;
+        public object toString;
+        public object unshift;
+    }
+    public sealed class LenientBooleanPrototype : BooleanPrototype {
+        public object constructor;
+        public object toString;
+        public object valueOf;
+    }
+    public sealed class LenientDateConstructor : DateConstructor {
+        public object parse;
+        public object UTC;
+    }
+    public sealed class LenientDatePrototype : DatePrototype {
+        public object constructor;
+        public object getDate;
+        public object getDay;
+        public object getFullYear;
+        public object getHours;
+        public object getMilliseconds;
+        public object getMinutes;
+        public object getMonth;
+        public object getSeconds;
+        public object getTime;
+        public object getTimezoneOffset;
+        public object getUTCDate;
+        public object getUTCDay;
+        public object getUTCFullYear;
+        public object getUTCHours;
+        public object getUTCMilliseconds;
+        public object getUTCMinutes;
+        public object getUTCMonth;
+        public object getUTCSeconds;
+        public object getVarDate;
+        public object getYear;
+        public object setDate;
+        public object setFullYear;
+        public object setHours;
+        public object setMilliseconds;
+        public object setMinutes;
+        public object setMonth;
+        public object setSeconds;
+        public object setTime;
+        public object setUTCDate;
+        public object setUTCFullYear;
+        public object setUTCHours;
+        public object setUTCMilliseconds;
+        public object setUTCMinutes;
+        public object setUTCMonth;
+        public object setUTCSeconds;
+        public object setYear;
+        public object toDateString;
+        public object toGMTString;
+        public object toLocaleDateString;
+        public object toLocaleString;
+        public object toLocaleTimeString;
+        public object toString;
+        public object toTimeString;
+        public object toUTCString;
+        public object valueOf;
+    }
+    public sealed class LenientEnumeratorPrototype : EnumeratorPrototype {
+        public object atEnd;
+        public object constructor;
+        public object item;
+        public object moveFirst;
+        public object moveNext;
+    }
+    public sealed class LenientErrorPrototype : ErrorPrototype {
+        public object constructor;
+        public new object name;
+        public object toString;
+    }
+    public sealed class LenientFunctionPrototype : FunctionPrototype {
+        public object apply;
+        public object call;
+        public object constructor;
+        public object toString;
+    }
+    public sealed class LenientGlobalObject : GlobalObject {
+        public object boolean;
+        public object @byte;
+        public object @char;
+        public object @decimal;
+        public object decodeURI;
+        public object decodeURIComponent;
+        public object @double;
+        public object encodeURI;
+        public object encodeURIComponent;
+        public object escape;
+        public object eval;
+        public object @float;
+        public object GetObject;
+        public new object Infinity;
+        public object @int;
+        public object isFinite;
+        public object isNaN;
+        public object @long;
+        public new object NaN;
+        public object parseFloat;
+        public object parseInt;
+        public object @sbyte;
+        public object ScriptEngine;
+        public object ScriptEngineBuildVersion;
+        public object ScriptEngineMajorVersion;
+        public object ScriptEngineMinorVersion;
+        public object @short;
+        public object @uint;
+        public object @ulong;
+        public new object undefined;
+        public object unescape;
+        public object @ushort;
+        public object @void;
+        public new object ActiveXObject { get; set; }
+        public new object Array { get; set; }
+        public new object Boolean { get; set; }
+        public new object Date { get; set; }
+        public new object Enumerator { get; set; }
+        public new object Error { get; set; }
+        public new object EvalError { get; set; }
+        public new object Function { get; set; }
+        public new object Math { get; set; }
+        public new object Number { get; set; }
+        public new object Object { get; set; }
+        public new object RangeError { get; set; }
+        public new object ReferenceError { get; set; }
+        public new object RegExp { get; set; }
+        public new object String { get; set; }
+        public new object SyntaxError { get; set; }
+        public new object TypeError { get; set; }
+        public new object URIError { get; set; }
+        public new object VBArray { get; set; }
+    }
+    public sealed class LenientMathObject : MathObject {
+        public new const double E = 2.7182818284590451;
+        public new const double LN10 = 2.3025850929940459;
+        public new const double LN2 = 0.69314718055994529;
+        public new const double LOG10E = 0.43429448190325182;
+        public new const double LOG2E = 1.4426950408889634;
+        public new const double PI = 3.1415926535897931;
+        public new const double SQRT1_2 = 0.70710678118654757;
+        public new const double SQRT2 = 1.4142135623730951;
+        public object abs;
+        public object acos;
+        public object asin;
+        public object atan;
+        public object atan2;
+        public object ceil;
+        public object cos;
+        public object exp;
+        public object floor;
+        public object log;
+        public object max;
+        public object min;
+        public object pow;
+        public object random;
+        public object round;
+        public object sin;
+        public object sqrt;
+        public object tan;
+    }
+    public sealed class LenientNumberPrototype : NumberPrototype {
+        public object constructor;
+        public object toExponential;
+        public object toFixed;
+        public object toLocaleString;
+        public object toPrecision;
+        public object toString;
+        public object valueOf;
+    }
+    public class LenientObjectPrototype : ObjectPrototype {
+        public object constructor;
+        public object hasOwnProperty;
+        public object isPrototypeOf;
+        public object propertyIsEnumerable;
+        public object toLocaleString;
+        public object toString;
+        public object valueOf;
+    }
+    public sealed class LenientRegExpPrototype : RegExpPrototype {
+        public object compile;
+        public object constructor;
+        public object exec;
+        public object test;
+        public object toString;
+    }
+    public class LenientStringConstructor : StringConstructor {
+        public object fromCharCode;
+    }
+    public sealed class LenientStringPrototype : StringPrototype {
+        public object anchor;
+        public object big;
+        public object blink;
+        public object bold;
+        public object charAt;
+        public object charCodeAt;
+        public object concat;
+        public object constructor;
+        public object @fixed;
+        public object fontcolor;
+        public object fontsize;
+        public object indexOf;
+        public object italics;
+        public object lastIndexOf;
+        public object link;
+        public object localeCompare;
+        public object match;
+        public object replace;
+        public object search;
+        public object slice;
+        public object small;
+        public object split;
+        public object strike;
+        public object sub;
+        public object substr;
+        public object substring;
+        public object sup;
+        public object toLocaleLowerCase;
+        public object toLocaleUpperCase;
+        public object toLowerCase;
+        public object toString;
+        public object toUpperCase;
+        public object valueOf;
+    }
+    public sealed class LenientVBArrayPrototype : VBArrayPrototype {
+        public object constructor;
+        public object dimensions;
+        public object getItem;
+        public object lbound;
+        public object toArray;
+        public object ubound;
+    }
+    public class MathObject : JSObject {
+        public const double E = 2.7182818284590451;
+        public const double LN10 = 2.3025850929940459;
+        public const double LN2 = 0.69314718055994529;
+        public const double LOG10E = 0.43429448190325182;
+        public const double LOG2E = 1.4426950408889634;
+        public const double PI = 3.1415926535897931;
+        public const double SQRT1_2 = 0.70710678118654757;
+        public const double SQRT2 = 1.4142135623730951;
+        public static double abs(double d);
+        public static double acos(double x);
+        public static double asin(double x);
+        public static double atan(double x);
+        public static double atan2(double dy, double dx);
+        public static double ceil(double x);
+        public static double cos(double x);
+        public static double exp(double x);
+        public static double floor(double x);
+        public static double log(double x);
+        public static double max(object x, object y, params object[] args);
+        public static double min(object x, object y, params object[] args);
+        public static double pow(double dx, double dy);
+        public static double random();
+        public static double round(double d);
+        public static double sin(double x);
+        public static double sqrt(double x);
+        public static double tan(double x);
+    }
+    public interface MemberInfoInitializer {
+        COMMemberInfo GetCOMMemberInfo();
+        void Initialize(string name, COMMemberInfo dispatch);
+    }
+    public sealed class MemberInfoList
+    public abstract class MethodInvoker {
+        protected MethodInvoker();
+        public abstract object Invoke(object thisob, object[] parameters);
+    }
+    public sealed class Missing {
+        public static readonly Missing Value;
+    }
+    public sealed class Namespace {
+        public static Namespace GetNamespace(string name, VsaEngine engine);
+    }
+    public class NoContextException : ApplicationException {
+        public NoContextException();
+        protected NoContextException(SerializationInfo s, StreamingContext c);
+        public NoContextException(string m);
+        public NoContextException(string m, Exception e);
+    }
+    public class NotRecommended : Attribute {
+        public NotRecommended(string message);
+        public bool IsError { get; }
+        public string Message { get; }
+    }
+    public class NumberConstructor : ScriptFunction {
+        public const double MAX_VALUE = 1.7976931348623157E+308;
+        public const double MIN_VALUE = 4.94065645841247E-324;
+        public const double NaN = 0.0 / 0.0;
+        public const double NEGATIVE_INFINITY = -1.0 / 0.0;
+        public const double POSITIVE_INFINITY = 1.0 / 0.0;
+        public new NumberObject CreateInstance(params object[] args);
+        public double Invoke(object arg);
+    }
+    public class NumberObject : JSObject {
+        protected NumberObject(ScriptObject parent, object value);
+        public new Type GetType();
+    }
+    public class NumberPrototype : NumberObject {
+        public static NumberConstructor constructor { get; }
+        public static string toExponential(object thisob, object fractionDigits);
+        public static string toFixed(object thisob, double fractionDigits);
+        public static string toLocaleString(object thisob);
+        public static string toPrecision(object thisob, object precision);
+        public static string toString(object thisob, object radix);
+        public static object valueOf(object thisob);
+    }
+    public sealed class NumericBinary : BinaryOp {
+        public NumericBinary(int operatorTok);
+        public static object DoOp(object v1, object v2, JSToken operatorTok);
+        public object EvaluateNumericBinary(object v1, object v2);
+    }
+    public sealed class NumericUnary : UnaryOp {
+        public NumericUnary(int operatorTok);
+        public object EvaluateUnary(object v);
+    }
+    public sealed class ObjectConstructor : ScriptFunction {
+        public JSObject ConstructObject();
+        public new object CreateInstance(params object[] args);
+        public object Invoke(params object[] args);
+    }
+    public class ObjectPrototype : JSObject {
+        public static ObjectConstructor constructor { get; }
+        public static bool hasOwnProperty(object thisob, object name);
+        public static bool isPrototypeOf(object thisob, object ob);
+        public static bool propertyIsEnumerable(object thisob, object name);
+        public static string toLocaleString(object thisob);
+        public static string toString(object thisob);
+        public static object valueOf(object thisob);
+    }
+    public class Override : Attribute {
+        public Override();
+    }
+    public sealed class Package : AST {
+        public static void JScriptPackage(string rootName, VsaEngine engine);
+    }
+    public class ParserException : Exception
+    public sealed class Plus : BinaryOp {
+        public Plus();
+        public static object DoOp(object v1, object v2);
+        public object EvaluatePlus(object v1, object v2);
+    }
+    public class PostOrPrefixOperator : UnaryOp {
+        public PostOrPrefixOperator(int operatorTok);
+        public object EvaluatePostOrPrefix(ref object v);
+    }
+    public sealed class RangeErrorObject : ErrorObject
+    public class ReferenceAttribute : Attribute {
+        public string reference;
+        public ReferenceAttribute(string reference);
+    }
+    public sealed class ReferenceErrorObject : ErrorObject
+    public sealed class RegExpConstructor : ScriptFunction {
+        public object index { get; }
+        public object input { get; set; }
+        public object lastIndex { get; }
+        public object lastMatch { get; }
+        public object lastParen { get; }
+        public object leftContext { get; }
+        public object rightContext { get; }
+        public object Construct(string pattern, bool ignoreCase, bool global, bool multiline);
+        public new RegExpObject CreateInstance(params object[] args);
+        public RegExpObject Invoke(params object[] args);
+    }
+    public sealed class RegExpMatch : ArrayObject
+    public sealed class RegExpObject : JSObject {
+        public bool global { get; }
+        public bool ignoreCase { get; }
+        public object lastIndex { get; set; }
+        public bool multiline { get; }
+        public string source { get; }
+        public override string ToString();
+    }
+    public class RegExpPrototype : JSObject {
+        public static RegExpConstructor constructor { get; }
+        public static RegExpObject compile(object thisob, object source, object flags);
+        public static object exec(object thisob, object input);
+        public static bool test(object thisob, object input);
+        public static string toString(object thisob);
+    }
+    public class Relational : BinaryOp {
+        public Relational(int operatorTok);
+        public double EvaluateRelational(object v1, object v2);
+        public static double JScriptCompare(object v1, object v2);
+    }
+    public sealed class ReturnOutOfFinally : ApplicationException {
+        public ReturnOutOfFinally();
+        public ReturnOutOfFinally(string m);
+        public ReturnOutOfFinally(string m, Exception e);
+    }
+    public static class Runtime {
+        public static long DoubleToInt64(double val);
+        public static new bool Equals(object v1, object v2);
+        public static long UncheckedDecimalToInt64(decimal val);
+    }
+    public class ScriptBlock : AST
+    public abstract class ScriptFunction : JSObject {
+        protected int ilength;
+        protected ScriptFunction(ScriptObject parent, string name);
+        public virtual int length { get; set; }
+        public object prototype { get; set; }
+        public object CreateInstance(params object[] args);
+        protected ScriptObject GetPrototypeForConstructedObject();
+        public object Invoke(object thisob, params object[] args);
+        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
+        public override string ToString();
+    }
+    public abstract class ScriptObject : IReflect {
+        protected ScriptObject parent;
+        public VsaEngine engine;
+        public object this[double index] { get; set; }
+        public object this[int index] { get; set; }
+        public object this[params object[] pars] { get; set; }
+        public object this[string name] { get; set; }
+        public virtual Type UnderlyingSystemType { get; }
+        public FieldInfo GetField(string name, BindingFlags bindingAttr);
+        public virtual FieldInfo[] GetFields(BindingFlags bindingAttr);
+        public abstract MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
+        public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        public MethodInfo GetMethod(string name, BindingFlags bindingAttr);
+        public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
+        public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr);
+        public ScriptObject GetParent();
+        public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr);
+        public PropertyInfo GetProperty(string name, BindingFlags bindingAttr);
+        public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
+        public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo locale, string[] namedParameters);
+        protected static MemberInfo[] WrapMembers(MemberInfo member, object obj);
+        protected static MemberInfo[] WrapMembers(MemberInfo[] members, object obj);
+        protected static MemberInfo[] WrapMembers(MemberInfo[] members, object obj, SimpleHashtable cache);
+    }
+    public class ScriptStream {
+        public static TextWriter Error;
+        public static TextWriter Out;
+        public ScriptStream();
+        public static void PrintStackTrace();
+        public static void PrintStackTrace(Exception e);
+        public static void Write(string str);
+        public static void WriteLine(string str);
+    }
+    public sealed class SimpleHashtable {
+        public SimpleHashtable(uint threshold);
+        public object this[object key] { get; set; }
+        public IDictionaryEnumerator GetEnumerator();
+        public void Remove(object key);
+    }
+    public enum SourceState {
+        STATE_COLOR_COMMENT = 1,
+        STATE_COLOR_NORMAL = 0,
+        STATE_COLOR_STRING = 2,
+    }
+    public sealed class StackFrame : ScriptObject, IActivationObject {
+        public object closureInstance;
+        public object[] localVars;
+        public object GetDefaultThisObject();
+        public FieldInfo GetField(string name, int lexLevel);
+        public GlobalScope GetGlobalScope();
+        public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
+        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        public object GetMemberValue(string name, int lexlevel);
+        FieldInfo Microsoft.JScript.IActivationObject.GetLocalField(string name);
+        public static void PushStackFrameForMethod(object thisob, JSLocalField[] fields, VsaEngine engine);
+        public static void PushStackFrameForStaticMethod(RuntimeTypeHandle thisclass, JSLocalField[] fields, VsaEngine engine);
+    }
+    public class StrictEquality : BinaryOp {
+        public static bool JScriptStrictEquals(object v1, object v2);
+    }
+    public class StringConstructor : ScriptFunction {
+        public new StringObject CreateInstance(params object[] args);
+        public static string fromCharCode(params object[] args);
+        public string Invoke(object arg);
+    }
+    public class StringObject : JSObject {
+        protected StringObject(ScriptObject prototype, string value);
+        public int length { get; }
+        public override bool Equals(object ob);
+        public override int GetHashCode();
+        public new Type GetType();
+    }
+    public class StringPrototype : StringObject {
+        public static StringConstructor constructor { get; }
+        public static string anchor(object thisob, object anchorName);
+        public static string big(object thisob);
+        public static string blink(object thisob);
+        public static string bold(object thisob);
+        public static string charAt(object thisob, double pos);
+        public static object charCodeAt(object thisob, double pos);
+        public static string concat(object thisob, params object[] args);
+        public static string @fixed(object thisob);
+        public static string fontcolor(object thisob, object colorName);
+        public static string fontsize(object thisob, object fontSize);
+        public static int indexOf(object thisob, object searchString, double position);
+        public static string italics(object thisob);
+        public static int lastIndexOf(object thisob, object searchString, double position);
+        public static string link(object thisob, object linkRef);
+        public static int localeCompare(object thisob, object thatob);
+        public static object match(object thisob, VsaEngine engine, object regExp);
+        public static string replace(object thisob, object regExp, object replacement);
+        public static int search(object thisob, VsaEngine engine, object regExp);
+        public static string slice(object thisob, double start, object end);
+        public static string small(object thisob);
+        public static ArrayObject split(object thisob, VsaEngine engine, object separator, object limit);
+        public static string strike(object thisob);
+        public static string sub(object thisob);
+        public static string substr(object thisob, double start, object count);
+        public static string substring(object thisob, double start, object end);
+        public static string sup(object thisob);
+        public static string toLocaleLowerCase(object thisob);
+        public static string toLocaleUpperCase(object thisob);
+        public static string toLowerCase(object thisob);
+        public static string toString(object thisob);
+        public static string toUpperCase(object thisob);
+        public static object valueOf(object thisob);
+    }
+    public sealed class SuperTypeMembersSorter
+    public sealed class SyntaxErrorObject : ErrorObject
+    public sealed class Throw : AST {
+        public static Exception JScriptThrow(object value);
+    }
+    public enum TokenColor {
+        COLOR_COMMENT = 3,
+        COLOR_CONDITIONAL_COMP = 7,
+        COLOR_IDENTIFIER = 1,
+        COLOR_KEYWORD = 2,
+        COLOR_NUMBER = 5,
+        COLOR_OPERATOR = 4,
+        COLOR_STRING = 6,
+        COLOR_TEXT = 0,
+    }
+    public sealed class Try : AST {
+        public static object JScriptExceptionValue(object e, VsaEngine engine);
+        public static void PushHandlerScope(VsaEngine engine, string id, int scopeId);
+    }
+    public sealed class TypedArray : IReflect {
+        public TypedArray(IReflect elementType, int rank);
+        public Type UnderlyingSystemType { get; }
+        public override bool Equals(object obj);
+        public FieldInfo GetField(string name, BindingFlags bindingAttr);
+        public FieldInfo[] GetFields(BindingFlags bindingAttr);
+        public override int GetHashCode();
+        public MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
+        public MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        public MethodInfo GetMethod(string name, BindingFlags bindingAttr);
+        public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
+        public MethodInfo[] GetMethods(BindingFlags bindingAttr);
+        public PropertyInfo[] GetProperties(BindingFlags bindingAttr);
+        public PropertyInfo GetProperty(string name, BindingFlags bindingAttr);
+        public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
+        public object InvokeMember(string name, BindingFlags flags, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo locale, string[] namedParameters);
+        public override string ToString();
+    }
+    public sealed class TypeErrorObject : ErrorObject
+    public sealed class Typeof : UnaryOp {
+        public static string JScriptTypeof(object value);
+    }
+    public sealed class TypeReflector : ScriptObject {
+        public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
+        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
+    }
+    public abstract class UnaryOp : AST {
+        protected AST operand;
+    }
+    public sealed class URIErrorObject : ErrorObject
+    public sealed class VBArrayConstructor : ScriptFunction {
+        public new object CreateInstance(params object[] args);
+    }
+    public class VBArrayObject : JSObject {
+        public VBArrayObject(VBArrayPrototype parent, Array array);
+    }
+    public class VBArrayPrototype : JSObject {
+        public static VBArrayConstructor constructor { get; }
+        public static int dimensions(object thisob);
+        public static object getItem(object thisob, params object[] args);
+        public static int lbound(object thisob, object dimension);
+        public static ArrayObject toArray(object thisob, VsaEngine engine);
+        public static int ubound(object thisob, object dimension);
+    }
+    public abstract class VsaItem : IJSVsaItem {
+        protected JSVsaItemFlag flag;
+        protected JSVsaItemType type;
+        protected bool isDirty;
+        protected string name;
+        public virtual bool IsDirty { get; set; }
+        public JSVsaItemType ItemType { get; }
+        public virtual string Name { get; set; }
+        public virtual object GetOption(string name);
+        public virtual void SetOption(string name, object value);
+    }
+    public sealed class VsaItems : IEnumerable, IJSVsaItems {
+        public VsaItems(VsaEngine engine);
+        public int Count { get; }
+        public IJSVsaItem this[int index] { get; }
+        public IJSVsaItem this[string itemName] { get; }
+        public void Close();
+        public IJSVsaItem CreateItem(string name, JSVsaItemType itemType, JSVsaItemFlag itemFlag);
+        public IEnumerator GetEnumerator();
+        public void Remove(int itemIndex);
+        public void Remove(string itemName);
+    }
+    public enum VSAITEMTYPE2 {
+        EXPRESSION = 22,
+        HOSTOBJECT = 16,
+        HOSTSCOPE = 17,
+        HOSTSCOPEANDOBJECT = 18,
+        None = 0,
+        SCRIPTBLOCK = 20,
+        SCRIPTSCOPE = 19,
+        STATEMENT = 21,
+    }
+    public sealed class With : AST {
+        public static object JScriptWith(object withOb, VsaEngine engine);
+    }
+}
```

