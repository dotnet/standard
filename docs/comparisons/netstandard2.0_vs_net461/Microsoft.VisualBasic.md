# Microsoft.VisualBasic

``` diff
+namespace Microsoft.VisualBasic {
+    public enum AppWinStyle : short {
+        Hide = (short)0,
+        MaximizedFocus = (short)3,
+        MinimizedFocus = (short)2,
+        MinimizedNoFocus = (short)6,
+        NormalFocus = (short)1,
+        NormalNoFocus = (short)4,
+    }
+    public enum AudioPlayMode {
+        Background = 1,
+        BackgroundLoop = 2,
+        WaitToComplete = 0,
+    }
+    public enum CallType {
+        Get = 2,
+        Let = 4,
+        Method = 1,
+        Set = 8,
+    }
+    public sealed class Collection : ICollection, IDeserializationCallback, IList, ISerializable {
+        public Collection();
+        public int Count { get; }
+        int ICollectionCount { get; }
+        bool ICollectionIsSynchronized { get; }
+        object ICollectionSyncRoot { get; }
+        bool IListIsFixedSize { get; }
+        bool IListIsReadOnly { get; }
+        [System.Runtime.CompilerServices.IndexerName("IListItem")]
+        object this[int index] { get; set; }
+        public object this[int Index] { get; }
+        public object this[object Index] { get; }
+        public object this[string Key] { get; }
+        public void Add(object Item, string Key=null, object Before=null, object After=null);
+        public void Clear();
+        public bool Contains(string Key);
+        public IEnumerator GetEnumerator();
+        void GetObjectData(SerializationInfo info, StreamingContext context);
+        void ICollectionCopyTo(Array array, int index);
+        IEnumerator ICollectionGetEnumerator();
+        int IListAdd(object value);
+        void IListClear();
+        bool IListContains(object value);
+        int IListIndexOf(object value);
+        void IListInsert(int index, object value);
+        void IListRemove(object value);
+        void IListRemoveAt(int index);
+        void OnDeserialization(object sender);
+        public void Remove(int Index);
+        public void Remove(string Key);
+    }
+    public sealed class ComClassAttribute : Attribute {
+        public ComClassAttribute();
+        public ComClassAttribute(string _ClassID);
+        public ComClassAttribute(string _ClassID, string _InterfaceID);
+        public ComClassAttribute(string _ClassID, string _InterfaceID, string _EventId);
+        public string ClassID { get; }
+        public string EventID { get; }
+        public string InterfaceID { get; }
+        public bool InterfaceShadows { get; set; }
+    }
+    public enum CompareMethod {
+        Binary = 0,
+        Text = 1,
+    }
+    public sealed class Constants {
+        public const AppWinStyle vbHide = (short)0;
+        public const AppWinStyle vbMaximizedFocus = (short)3;
+        public const AppWinStyle vbMinimizedFocus = (short)2;
+        public const AppWinStyle vbMinimizedNoFocus = (short)6;
+        public const AppWinStyle vbNormalFocus = (short)1;
+        public const AppWinStyle vbNormalNoFocus = (short)4;
+        public const CallType vbGet = 2;
+        public const CallType vbLet = 4;
+        public const CallType vbMethod = 1;
+        public const CallType vbSet = 8;
+        public const CompareMethod vbBinaryCompare = 0;
+        public const CompareMethod vbTextCompare = 1;
+        public const DateFormat vbGeneralDate = 0;
+        public const DateFormat vbLongDate = 1;
+        public const DateFormat vbLongTime = 3;
+        public const DateFormat vbShortDate = 2;
+        public const DateFormat vbShortTime = 4;
+        public const FileAttribute vbArchive = 32;
+        public const FileAttribute vbDirectory = 16;
+        public const FileAttribute vbHidden = 2;
+        public const FileAttribute vbNormal = 0;
+        public const FileAttribute vbReadOnly = 1;
+        public const FileAttribute vbSystem = 4;
+        public const FileAttribute vbVolume = 8;
+        public const FirstDayOfWeek vbFriday = 6;
+        public const FirstDayOfWeek vbMonday = 2;
+        public const FirstDayOfWeek vbSaturday = 7;
+        public const FirstDayOfWeek vbSunday = 1;
+        public const FirstDayOfWeek vbThursday = 5;
+        public const FirstDayOfWeek vbTuesday = 3;
+        public const FirstDayOfWeek vbUseSystemDayOfWeek = 0;
+        public const FirstDayOfWeek vbWednesday = 4;
+        public const FirstWeekOfYear vbFirstFourDays = 2;
+        public const FirstWeekOfYear vbFirstFullWeek = 3;
+        public const FirstWeekOfYear vbFirstJan1 = 1;
+        public const FirstWeekOfYear vbUseSystem = 0;
+        public const MsgBoxResult vbAbort = 3;
+        public const MsgBoxResult vbCancel = 2;
+        public const MsgBoxResult vbIgnore = 5;
+        public const MsgBoxResult vbNo = 7;
+        public const MsgBoxResult vbOK = 1;
+        public const MsgBoxResult vbRetry = 4;
+        public const MsgBoxResult vbYes = 6;
+        public const MsgBoxStyle vbAbortRetryIgnore = 2;
+        public const MsgBoxStyle vbApplicationModal = 0;
+        public const MsgBoxStyle vbCritical = 16;
+        public const MsgBoxStyle vbDefaultButton1 = 0;
+        public const MsgBoxStyle vbDefaultButton2 = 256;
+        public const MsgBoxStyle vbDefaultButton3 = 512;
+        public const MsgBoxStyle vbExclamation = 48;
+        public const MsgBoxStyle vbInformation = 64;
+        public const MsgBoxStyle vbMsgBoxHelp = 16384;
+        public const MsgBoxStyle vbMsgBoxRight = 524288;
+        public const MsgBoxStyle vbMsgBoxRtlReading = 1048576;
+        public const MsgBoxStyle vbMsgBoxSetForeground = 65536;
+        public const MsgBoxStyle vbOKCancel = 1;
+        public const MsgBoxStyle vbOKOnly = 0;
+        public const MsgBoxStyle vbQuestion = 32;
+        public const MsgBoxStyle vbRetryCancel = 5;
+        public const MsgBoxStyle vbSystemModal = 4096;
+        public const MsgBoxStyle vbYesNo = 4;
+        public const MsgBoxStyle vbYesNoCancel = 3;
+        public const TriState vbFalse = 0;
+        public const TriState vbTrue = -1;
+        public const TriState vbUseDefault = -2;
+        public const VariantType vbArray = 8192;
+        public const VariantType vbBoolean = 11;
+        public const VariantType vbByte = 17;
+        public const VariantType vbCurrency = 6;
+        public const VariantType vbDate = 7;
+        public const VariantType vbDecimal = 14;
+        public const VariantType vbDouble = 5;
+        public const VariantType vbEmpty = 0;
+        public const VariantType vbInteger = 3;
+        public const VariantType vbLong = 20;
+        public const VariantType vbNull = 1;
+        public const VariantType vbObject = 9;
+        public const VariantType vbSingle = 4;
+        public const VariantType vbString = 8;
+        public const VariantType vbUserDefinedType = 36;
+        public const VariantType vbVariant = 12;
+        public const VbStrConv vbHiragana = 32;
+        public const VbStrConv vbKatakana = 16;
+        public const VbStrConv vbLinguisticCasing = 1024;
+        public const VbStrConv vbLowerCase = 2;
+        public const VbStrConv vbNarrow = 8;
+        public const VbStrConv vbProperCase = 3;
+        public const VbStrConv vbSimplifiedChinese = 256;
+        public const VbStrConv vbTraditionalChinese = 512;
+        public const VbStrConv vbUpperCase = 1;
+        public const VbStrConv vbWide = 4;
+        public const int vbObjectError = -2147221504;
+        public const string vbBack = "\b";
+        public const string vbCr = "\r";
+        public const string vbCrLf = "\r\n";
+        public const string vbFormFeed = "\f";
+        public const string vbLf = "\n";
+        public const string vbNewLine = "\r\n";
+        public const string vbNullChar = "\0";
+        public const string vbNullString = null;
+        public const string vbTab = "\t";
+        public const string vbVerticalTab = "\v";
+    }
+    public sealed class ControlChars {
+        public const char Back = '\b';
+        public const char Cr = '\r';
+        public const char FormFeed = '\f';
+        public const char Lf = '\n';
+        public const char NullChar = '\0';
+        public const char Quote = '"';
+        public const char Tab = '\t';
+        public const char VerticalTab = '\v';
+        public const string CrLf = "\r\n";
+        public const string NewLine = "\r\n";
+        public ControlChars();
+    }
+    public sealed class Conversion {
+        public static object CTypeDynamic(object Expression, Type TargetType);
+        public static TargetType CTypeDynamic<TargetType>(object Expression);
+        public static string ErrorToString();
+        public static string ErrorToString(int ErrorNumber);
+        public static decimal Fix(decimal Number);
+        public static double Fix(double Number);
+        public static short Fix(short Number);
+        public static int Fix(int Number);
+        public static long Fix(long Number);
+        public static object Fix(object Number);
+        public static float Fix(float Number);
+        public static string Hex(byte Number);
+        public static string Hex(short Number);
+        public static string Hex(int Number);
+        public static string Hex(long Number);
+        public static string Hex(object Number);
+        public static string Hex(sbyte Number);
+        public static string Hex(ushort Number);
+        public static string Hex(uint Number);
+        public static string Hex(ulong Number);
+        public static decimal Int(decimal Number);
+        public static double Int(double Number);
+        public static short Int(short Number);
+        public static int Int(int Number);
+        public static long Int(long Number);
+        public static object Int(object Number);
+        public static float Int(float Number);
+        public static string Oct(byte Number);
+        public static string Oct(short Number);
+        public static string Oct(int Number);
+        public static string Oct(long Number);
+        public static string Oct(object Number);
+        public static string Oct(sbyte Number);
+        public static string Oct(ushort Number);
+        public static string Oct(uint Number);
+        public static string Oct(ulong Number);
+        public static string Str(object Number);
+        public static int Val(char Expression);
+        public static double Val(object Expression);
+        public static double Val(string InputStr);
+    }
+    public sealed class DateAndTime {
+        public static string DateString { get; set; }
+        public static DateTime Now { get; }
+        public static DateTime TimeOfDay { get; set; }
+        public static double Timer { get; }
+        public static string TimeString { get; set; }
+        public static DateTime Today { get; set; }
+        public static DateTime DateAdd(DateInterval Interval, double Number, DateTime DateValue);
+        public static DateTime DateAdd(string Interval, double Number, object DateValue);
+        public static long DateDiff(DateInterval Interval, DateTime Date1, DateTime Date2, FirstDayOfWeek DayOfWeek=(FirstDayOfWeek)(1), FirstWeekOfYear WeekOfYear=(FirstWeekOfYear)(1));
+        public static long DateDiff(string Interval, object Date1, object Date2, FirstDayOfWeek DayOfWeek=(FirstDayOfWeek)(1), FirstWeekOfYear WeekOfYear=(FirstWeekOfYear)(1));
+        public static int DatePart(DateInterval Interval, DateTime DateValue, FirstDayOfWeek FirstDayOfWeekValue=(FirstDayOfWeek)(1), FirstWeekOfYear FirstWeekOfYearValue=(FirstWeekOfYear)(1));
+        public static int DatePart(string Interval, object DateValue, FirstDayOfWeek DayOfWeek=(FirstDayOfWeek)(1), FirstWeekOfYear WeekOfYear=(FirstWeekOfYear)(1));
+        public static DateTime DateSerial(int Year, int Month, int Day);
+        public static DateTime DateValue(string StringDate);
+        public static int Day(DateTime DateValue);
+        public static int Hour(DateTime TimeValue);
+        public static int Minute(DateTime TimeValue);
+        public static int Month(DateTime DateValue);
+        public static string MonthName(int Month, bool Abbreviate=false);
+        public static int Second(DateTime TimeValue);
+        public static DateTime TimeSerial(int Hour, int Minute, int Second);
+        public static DateTime TimeValue(string StringTime);
+        public static int Weekday(DateTime DateValue, FirstDayOfWeek DayOfWeek=(FirstDayOfWeek)(1));
+        public static string WeekdayName(int Weekday, bool Abbreviate=false, FirstDayOfWeek FirstDayOfWeekValue=(FirstDayOfWeek)(0));
+        public static int Year(DateTime DateValue);
+    }
+    public enum DateFormat {
+        GeneralDate = 0,
+        LongDate = 1,
+        LongTime = 3,
+        ShortDate = 2,
+        ShortTime = 4,
+    }
+    public enum DateInterval {
+        Day = 4,
+        DayOfYear = 3,
+        Hour = 7,
+        Minute = 8,
+        Month = 2,
+        Quarter = 1,
+        Second = 9,
+        Weekday = 6,
+        WeekOfYear = 5,
+        Year = 0,
+    }
+    public enum DueDate {
+        BegOfPeriod = 1,
+        EndOfPeriod = 0,
+    }
+    public sealed class ErrObject {
+        public string Description { get; set; }
+        public int Erl { get; }
+        public int HelpContext { get; set; }
+        public string HelpFile { get; set; }
+        public int LastDllError { get; }
+        public int Number { get; set; }
+        public string Source { get; set; }
+        public void Clear();
+        public Exception GetException();
+        public void Raise(int Number, object Source=null, object Description=null, object HelpFile=null, object HelpContext=null);
+    }
+    public enum FileAttribute {
+        Archive = 32,
+        Directory = 16,
+        Hidden = 2,
+        Normal = 0,
+        ReadOnly = 1,
+        System = 4,
+        Volume = 8,
+    }
+    public sealed class FileSystem {
+        public static void ChDir(string Path);
+        public static void ChDrive(char Drive);
+        public static void ChDrive(string Drive);
+        public static string CurDir();
+        public static string CurDir(char Drive);
+        public static string Dir();
+        public static string Dir(string PathName, FileAttribute Attributes=(FileAttribute)(0));
+        public static bool EOF(int FileNumber);
+        public static OpenMode FileAttr(int FileNumber);
+        public static void FileClose(params int[] FileNumbers);
+        public static void FileCopy(string Source, string Destination);
+        public static DateTime FileDateTime(string PathName);
+        public static void FileGet(int FileNumber, ref Array Value, long RecordNumber=(long)-1, bool ArrayIsDynamic=false, bool StringIsFixedLength=false);
+        public static void FileGet(int FileNumber, ref bool Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref byte Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref char Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref DateTime Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref decimal Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref double Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref short Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref int Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref long Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref float Value, long RecordNumber=(long)-1);
+        public static void FileGet(int FileNumber, ref string Value, long RecordNumber=(long)-1, bool StringIsFixedLength=false);
+        public static void FileGet(int FileNumber, ref ValueType Value, long RecordNumber=(long)-1);
+        public static void FileGetObject(int FileNumber, ref object Value, long RecordNumber=(long)-1);
+        public static long FileLen(string PathName);
+        public static void FileOpen(int FileNumber, string FileName, OpenMode Mode, OpenAccess Access=(OpenAccess)(-1), OpenShare Share=(OpenShare)(-1), int RecordLength=-1);
+        public static void FilePut(int FileNumber, Array Value, long RecordNumber=(long)-1, bool ArrayIsDynamic=false, bool StringIsFixedLength=false);
+        public static void FilePut(int FileNumber, bool Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, byte Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, char Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, DateTime Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, decimal Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, double Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, short Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, int Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, long Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, float Value, long RecordNumber=(long)-1);
+        public static void FilePut(int FileNumber, string Value, long RecordNumber=(long)-1, bool StringIsFixedLength=false);
+        public static void FilePut(int FileNumber, ValueType Value, long RecordNumber=(long)-1);
+        public static void FilePut(object FileNumber, object Value, object RecordNumber=-1);
+        public static void FilePutObject(int FileNumber, object Value, long RecordNumber=(long)-1);
+        public static void FileWidth(int FileNumber, int RecordWidth);
+        public static int FreeFile();
+        public static FileAttribute GetAttr(string PathName);
+        public static void Input(int FileNumber, ref bool Value);
+        public static void Input(int FileNumber, ref byte Value);
+        public static void Input(int FileNumber, ref char Value);
+        public static void Input(int FileNumber, ref DateTime Value);
+        public static void Input(int FileNumber, ref decimal Value);
+        public static void Input(int FileNumber, ref double Value);
+        public static void Input(int FileNumber, ref short Value);
+        public static void Input(int FileNumber, ref int Value);
+        public static void Input(int FileNumber, ref long Value);
+        public static void Input(int FileNumber, ref object Value);
+        public static void Input(int FileNumber, ref float Value);
+        public static void Input(int FileNumber, ref string Value);
+        public static string InputString(int FileNumber, int CharCount);
+        public static void Kill(string PathName);
+        public static string LineInput(int FileNumber);
+        public static long Loc(int FileNumber);
+        public static void Lock(int FileNumber);
+        public static void Lock(int FileNumber, long Record);
+        public static void Lock(int FileNumber, long FromRecord, long ToRecord);
+        public static long LOF(int FileNumber);
+        public static void MkDir(string Path);
+        public static void Print(int FileNumber, params object[] Output);
+        public static void PrintLine(int FileNumber, params object[] Output);
+        public static void Rename(string OldPath, string NewPath);
+        public static void Reset();
+        public static void RmDir(string Path);
+        public static long Seek(int FileNumber);
+        public static void Seek(int FileNumber, long Position);
+        public static void SetAttr(string PathName, FileAttribute Attributes);
+        public static SpcInfo SPC(short Count);
+        public static TabInfo TAB();
+        public static TabInfo TAB(short Column);
+        public static void Unlock(int FileNumber);
+        public static void Unlock(int FileNumber, long Record);
+        public static void Unlock(int FileNumber, long FromRecord, long ToRecord);
+        public static void Write(int FileNumber, params object[] Output);
+        public static void WriteLine(int FileNumber, params object[] Output);
+    }
+    public sealed class Financial {
+        public static double DDB(double Cost, double Salvage, double Life, double Period, double Factor=2);
+        public static double FV(double Rate, double NPer, double Pmt, double PV=0, DueDate Due=(DueDate)(0));
+        public static double IPmt(double Rate, double Per, double NPer, double PV, double FV=0, DueDate Due=(DueDate)(0));
+        public static double IRR(ref double[] ValueArray, double Guess=0.1);
+        public static double MIRR(ref double[] ValueArray, double FinanceRate, double ReinvestRate);
+        public static double NPer(double Rate, double Pmt, double PV, double FV=0, DueDate Due=(DueDate)(0));
+        public static double NPV(double Rate, ref double[] ValueArray);
+        public static double Pmt(double Rate, double NPer, double PV, double FV=0, DueDate Due=(DueDate)(0));
+        public static double PPmt(double Rate, double Per, double NPer, double PV, double FV=0, DueDate Due=(DueDate)(0));
+        public static double PV(double Rate, double NPer, double Pmt, double FV=0, DueDate Due=(DueDate)(0));
+        public static double Rate(double NPer, double Pmt, double PV, double FV=0, DueDate Due=(DueDate)(0), double Guess=0.1);
+        public static double SLN(double Cost, double Salvage, double Life);
+        public static double SYD(double Cost, double Salvage, double Life, double Period);
+    }
+    public enum FirstDayOfWeek {
+        Friday = 6,
+        Monday = 2,
+        Saturday = 7,
+        Sunday = 1,
+        System = 0,
+        Thursday = 5,
+        Tuesday = 3,
+        Wednesday = 4,
+    }
+    public enum FirstWeekOfYear {
+        FirstFourDays = 2,
+        FirstFullWeek = 3,
+        Jan1 = 1,
+        System = 0,
+    }
+    public sealed class Globals {
+        public static string ScriptEngine { get; }
+        public static int ScriptEngineBuildVersion { get; }
+        public static int ScriptEngineMajorVersion { get; }
+        public static int ScriptEngineMinorVersion { get; }
+    }
+    public sealed class HideModuleNameAttribute : Attribute {
+        public HideModuleNameAttribute();
+    }
+    public sealed class Information {
+        public static int Erl();
+        public static ErrObject Err();
+        public static bool IsArray(object VarName);
+        public static bool IsDate(object Expression);
+        public static bool IsDBNull(object Expression);
+        public static bool IsError(object Expression);
+        public static bool IsNothing(object Expression);
+        public static bool IsNumeric(object Expression);
+        public static bool IsReference(object Expression);
+        public static int LBound(Array Array, int Rank=1);
+        public static int QBColor(int Color);
+        public static int RGB(int Red, int Green, int Blue);
+        public static string SystemTypeName(string VbName);
+        public static string TypeName(object VarName);
+        public static int UBound(Array Array, int Rank=1);
+        public static VariantType VarType(object VarName);
+        public static string VbTypeName(string UrtName);
+    }
+    public sealed class Interaction {
+        public static void AppActivate(int ProcessId);
+        public static void AppActivate(string Title);
+        public static void Beep();
+        public static object CallByName(object ObjectRef, string ProcName, CallType UseCallType, params object[] Args);
+        public static object Choose(double Index, params object[] Choice);
+        public static string Command();
+        public static object CreateObject(string ProgId, string ServerName="");
+        public static void DeleteSetting(string AppName, string Section=null, string Key=null);
+        public static string Environ(int Expression);
+        public static string Environ(string Expression);
+        public static string[,] GetAllSettings(string AppName, string Section);
+        public static object GetObject(string PathName=null, string Class=null);
+        public static string GetSetting(string AppName, string Section, string Key, string Default="");
+        public static object IIf(bool Expression, object TruePart, object FalsePart);
+        public static string InputBox(string Prompt, string Title="", string DefaultResponse="", int XPos=-1, int YPos=-1);
+        public static MsgBoxResult MsgBox(object Prompt, MsgBoxStyle Buttons=(MsgBoxStyle)(0), object Title=null);
+        public static string Partition(long Number, long Start, long Stop, long Interval);
+        public static void SaveSetting(string AppName, string Section, string Key, string Setting);
+        public static int Shell(string PathName, AppWinStyle Style=(AppWinStyle)(2), bool Wait=false, int Timeout=-1);
+        public static object Switch(params object[] VarExpr);
+    }
+    public enum MsgBoxResult {
+        Abort = 3,
+        Cancel = 2,
+        Ignore = 5,
+        No = 7,
+        Ok = 1,
+        Retry = 4,
+        Yes = 6,
+    }
+    public enum MsgBoxStyle {
+        AbortRetryIgnore = 2,
+        ApplicationModal = 0,
+        Critical = 16,
+        DefaultButton1 = 0,
+        DefaultButton2 = 256,
+        DefaultButton3 = 512,
+        Exclamation = 48,
+        Information = 64,
+        MsgBoxHelp = 16384,
+        MsgBoxRight = 524288,
+        MsgBoxRtlReading = 1048576,
+        MsgBoxSetForeground = 65536,
+        OkCancel = 1,
+        OkOnly = 0,
+        Question = 32,
+        RetryCancel = 5,
+        SystemModal = 4096,
+        YesNo = 4,
+        YesNoCancel = 3,
+    }
+    public sealed class MyGroupCollectionAttribute : Attribute {
+        public MyGroupCollectionAttribute(string typeToCollect, string createInstanceMethodName, string disposeInstanceMethodName, string defaultInstanceAlias);
+        public string CreateMethod { get; }
+        public string DefaultInstanceAlias { get; }
+        public string DisposeMethod { get; }
+        public string MyGroupName { get; }
+    }
+    public enum OpenAccess {
+        Default = -1,
+        Read = 1,
+        ReadWrite = 3,
+        Write = 2,
+    }
+    public enum OpenMode {
+        Append = 8,
+        Binary = 32,
+        Input = 1,
+        Output = 2,
+        Random = 4,
+    }
+    public enum OpenShare {
+        Default = -1,
+        LockRead = 2,
+        LockReadWrite = 0,
+        LockWrite = 1,
+        Shared = 3,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct SpcInfo {
+        public short Count;
+    }
+    public sealed class Strings {
+        public static int Asc(char String);
+        public static int Asc(string String);
+        public static int AscW(char String);
+        public static int AscW(string String);
+        public static char Chr(int CharCode);
+        public static char ChrW(int CharCode);
+        public static string[] Filter(object[] Source, string Match, bool Include=true, CompareMethod Compare=(CompareMethod)(0));
+        public static string[] Filter(string[] Source, string Match, bool Include=true, CompareMethod Compare=(CompareMethod)(0));
+        public static string Format(object Expression, string Style="");
+        public static string FormatCurrency(object Expression, int NumDigitsAfterDecimal=-1, TriState IncludeLeadingDigit=(TriState)(-2), TriState UseParensForNegativeNumbers=(TriState)(-2), TriState GroupDigits=(TriState)(-2));
+        public static string FormatDateTime(DateTime Expression, DateFormat NamedFormat=(DateFormat)(0));
+        public static string FormatNumber(object Expression, int NumDigitsAfterDecimal=-1, TriState IncludeLeadingDigit=(TriState)(-2), TriState UseParensForNegativeNumbers=(TriState)(-2), TriState GroupDigits=(TriState)(-2));
+        public static string FormatPercent(object Expression, int NumDigitsAfterDecimal=-1, TriState IncludeLeadingDigit=(TriState)(-2), TriState UseParensForNegativeNumbers=(TriState)(-2), TriState GroupDigits=(TriState)(-2));
+        public static char GetChar(string str, int Index);
+        public static int InStr(int Start, string String1, string String2, CompareMethod Compare=(CompareMethod)(0));
+        public static int InStr(string String1, string String2, CompareMethod Compare=(CompareMethod)(0));
+        public static int InStrRev(string StringCheck, string StringMatch, int Start=-1, CompareMethod Compare=(CompareMethod)(0));
+        public static string Join(object[] SourceArray, string Delimiter=" ");
+        public static string Join(string[] SourceArray, string Delimiter=" ");
+        public static char LCase(char Value);
+        public static string LCase(string Value);
+        public static string Left(string str, int Length);
+        public static int Len(bool Expression);
+        public static int Len(byte Expression);
+        public static int Len(char Expression);
+        public static int Len(DateTime Expression);
+        public static int Len(decimal Expression);
+        public static int Len(double Expression);
+        public static int Len(short Expression);
+        public static int Len(int Expression);
+        public static int Len(long Expression);
+        public static int Len(object Expression);
+        public static int Len(sbyte Expression);
+        public static int Len(float Expression);
+        public static int Len(string Expression);
+        public static int Len(ushort Expression);
+        public static int Len(uint Expression);
+        public static int Len(ulong Expression);
+        public static string LSet(string Source, int Length);
+        public static string LTrim(string str);
+        public static string Mid(string str, int Start);
+        public static string Mid(string str, int Start, int Length);
+        public static string Replace(string Expression, string Find, string Replacement, int Start=1, int Count=-1, CompareMethod Compare=(CompareMethod)(0));
+        public static string Right(string str, int Length);
+        public static string RSet(string Source, int Length);
+        public static string RTrim(string str);
+        public static string Space(int Number);
+        public static string[] Split(string Expression, string Delimiter=" ", int Limit=-1, CompareMethod Compare=(CompareMethod)(0));
+        public static int StrComp(string String1, string String2, CompareMethod Compare=(CompareMethod)(0));
+        public static string StrConv(string str, VbStrConv Conversion, int LocaleID=0);
+        public static string StrDup(int Number, char Character);
+        public static object StrDup(int Number, object Character);
+        public static string StrDup(int Number, string Character);
+        public static string StrReverse(string Expression);
+        public static string Trim(string str);
+        public static char UCase(char Value);
+        public static string UCase(string Value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct TabInfo {
+        public short Column;
+    }
+    public enum TriState {
+        False = 0,
+        True = -1,
+        UseDefault = -2,
+    }
+    public enum VariantType {
+        Array = 8192,
+        Boolean = 11,
+        Byte = 17,
+        Char = 18,
+        Currency = 6,
+        DataObject = 13,
+        Date = 7,
+        Decimal = 14,
+        Double = 5,
+        Empty = 0,
+        Error = 10,
+        Integer = 3,
+        Long = 20,
+        Null = 1,
+        Object = 9,
+        Short = 2,
+        Single = 4,
+        String = 8,
+        UserDefinedType = 36,
+        Variant = 12,
+    }
+    public class VBCodeProvider : CodeDomProvider {
+        public VBCodeProvider();
+        public VBCodeProvider(IDictionary<string, string> providerOptions);
+        public override string FileExtension { get; }
+        public override LanguageOptions LanguageOptions { get; }
+        public override ICodeCompiler CreateCompiler();
+        public override ICodeGenerator CreateGenerator();
+        public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options);
+        public override TypeConverter GetConverter(Type type);
+    }
+    public sealed class VBFixedArrayAttribute : Attribute {
+        public VBFixedArrayAttribute(int UpperBound1);
+        public VBFixedArrayAttribute(int UpperBound1, int UpperBound2);
+        public int[] Bounds { get; }
+        public int Length { get; }
+    }
+    public sealed class VBFixedStringAttribute : Attribute {
+        public VBFixedStringAttribute(int Length);
+        public int Length { get; }
+    }
+    public sealed class VBMath {
+        public static void Randomize();
+        public static void Randomize(double Number);
+        public static float Rnd();
+        public static float Rnd(float Number);
+    }
+    public enum VbStrConv {
+        Hiragana = 32,
+        Katakana = 16,
+        LinguisticCasing = 1024,
+        Lowercase = 2,
+        Narrow = 8,
+        None = 0,
+        ProperCase = 3,
+        SimplifiedChinese = 256,
+        TraditionalChinese = 512,
+        Uppercase = 1,
+        Wide = 4,
+    }
+}
```

