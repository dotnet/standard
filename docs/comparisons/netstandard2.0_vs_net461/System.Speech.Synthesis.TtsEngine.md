# System.Speech.Synthesis.TtsEngine

``` diff
+namespace System.Speech.Synthesis.TtsEngine {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ContourPoint : IEquatable<ContourPoint> {
+        public ContourPoint(float start, float change, ContourPointChangeType changeType);
+        public float Change { get; }
+        public ContourPointChangeType ChangeType { get; }
+        public float Start { get; }
+        public override bool Equals(object obj);
+        public bool Equals(ContourPoint other);
+        public override int GetHashCode();
+        public static bool operator ==(ContourPoint point1, ContourPoint point2);
+        public static bool operator !=(ContourPoint point1, ContourPoint point2);
+    }
+    public enum ContourPointChangeType {
+        Hz = 0,
+        Percentage = 1,
+    }
+    public enum EmphasisBreak {
+        Default = -7,
+        ExtraStrong = -6,
+        ExtraWeak = -2,
+        Medium = -4,
+        None = -1,
+        Strong = -5,
+        Weak = -3,
+    }
+    public enum EmphasisWord {
+        Default = 0,
+        Moderate = 2,
+        None = 3,
+        Reduced = 4,
+        Strong = 1,
+    }
+    public enum EventParameterType {
+        Object = 2,
+        Pointer = 3,
+        String = 4,
+        Token = 1,
+        Undefined = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FragmentState : IEquatable<FragmentState> {
+        public FragmentState(TtsEngineAction action, int langId, int emphasis, int duration, SayAs sayAs, Prosody prosody, char[] phonemes);
+        public TtsEngineAction Action { get; internal set; }
+        public int Duration { get; internal set; }
+        public int Emphasis { get; internal set; }
+        public int LangId { get; internal set; }
+        public char[] Phoneme { get; internal set; }
+        public Prosody Prosody { get; internal set; }
+        public SayAs SayAs { get; internal set; }
+        public override bool Equals(object obj);
+        public bool Equals(FragmentState other);
+        public override int GetHashCode();
+        public static bool operator ==(FragmentState state1, FragmentState state2);
+        public static bool operator !=(FragmentState state1, FragmentState state2);
+    }
+    public interface ITtsEngineSite {
+        int Actions { get; }
+        int EventInterest { get; }
+        int Rate { get; }
+        int Volume { get; }
+        void AddEvents(SpeechEventInfo[] events, int count);
+        void CompleteSkip(int skipped);
+        SkipInfo GetSkipInfo();
+        Stream LoadResource(Uri uri, string mediaType);
+        int Write(IntPtr data, int count);
+    }
+    public class Prosody {
+        public Prosody();
+        public int Duration { get; set; }
+        public ProsodyNumber Pitch { get; set; }
+        public ProsodyNumber Range { get; set; }
+        public ProsodyNumber Rate { get; set; }
+        public ProsodyNumber Volume { get; set; }
+        public ContourPoint[] GetContourPoints();
+        public void SetContourPoints(ContourPoint[] points);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ProsodyNumber : IEquatable<ProsodyNumber> {
+        public const int AbsoluteNumber = 2147483647;
+        public ProsodyNumber(int ssmlAttributeId);
+        public ProsodyNumber(float number);
+        public bool IsNumberPercent { get; internal set; }
+        public float Number { get; internal set; }
+        public int SsmlAttributeId { get; internal set; }
+        public ProsodyUnit Unit { get; internal set; }
+        public override bool Equals(object obj);
+        public bool Equals(ProsodyNumber other);
+        public override int GetHashCode();
+        public static bool operator ==(ProsodyNumber prosodyNumber1, ProsodyNumber prosodyNumber2);
+        public static bool operator !=(ProsodyNumber prosodyNumber1, ProsodyNumber prosodyNumber2);
+    }
+    public enum ProsodyPitch {
+        Default = 0,
+        ExtraHigh = 5,
+        ExtraLow = 1,
+        High = 4,
+        Low = 2,
+        Medium = 3,
+    }
+    public enum ProsodyRange {
+        Default = 0,
+        ExtraHigh = 5,
+        ExtraLow = 1,
+        High = 4,
+        Low = 2,
+        Medium = 3,
+    }
+    public enum ProsodyRate {
+        Default = 0,
+        ExtraFast = 5,
+        ExtraSlow = 1,
+        Fast = 4,
+        Medium = 3,
+        Slow = 2,
+    }
+    public enum ProsodyUnit {
+        Default = 0,
+        Hz = 1,
+        Semitone = 2,
+    }
+    public enum ProsodyVolume {
+        Default = -1,
+        ExtraLoud = -7,
+        ExtraSoft = -3,
+        Loud = -6,
+        Medium = -5,
+        Silent = -2,
+        Soft = -4,
+    }
+    public class SayAs {
+        public SayAs();
+        public string Detail { get; set; }
+        public string Format { get; set; }
+        public string InterpretAs { get; set; }
+    }
+    public class SkipInfo {
+        public SkipInfo();
+        public int Count { get; set; }
+        public int Type { get; set; }
+    }
+    public enum SpeakOutputFormat {
+        Text = 1,
+        WaveFormat = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct SpeechEventInfo : IEquatable<SpeechEventInfo> {
+        public SpeechEventInfo(short eventId, short parameterType, int param1, IntPtr param2);
+        public short EventId { get; internal set; }
+        public int Param1 { get; internal set; }
+        public IntPtr Param2 { get; internal set; }
+        public short ParameterType { get; internal set; }
+        public override bool Equals(object obj);
+        public bool Equals(SpeechEventInfo other);
+        public override int GetHashCode();
+        public static bool operator ==(SpeechEventInfo event1, SpeechEventInfo event2);
+        public static bool operator !=(SpeechEventInfo event1, SpeechEventInfo event2);
+    }
+    public class TextFragment {
+        public TextFragment();
+        public FragmentState State { get; set; }
+        public int TextLength { get; set; }
+        public int TextOffset { get; set; }
+        public string TextToSpeak { get; set; }
+    }
+    public enum TtsEngineAction {
+        Bookmark = 3,
+        ParseUnknownTag = 7,
+        Pronounce = 2,
+        Silence = 1,
+        Speak = 0,
+        SpellOut = 4,
+        StartParagraph = 6,
+        StartSentence = 5,
+    }
+    public abstract class TtsEngineSsml {
+        protected TtsEngineSsml(string registryKey);
+        public abstract void AddLexicon(Uri uri, string mediaType, ITtsEngineSite site);
+        public abstract IntPtr GetOutputFormat(SpeakOutputFormat speakOutputFormat, IntPtr targetWaveFormat);
+        public abstract void RemoveLexicon(Uri uri, ITtsEngineSite site);
+        public abstract void Speak(TextFragment[] fragment, IntPtr waveHeader, ITtsEngineSite site);
+    }
+    public enum TtsEventId {
+        AudioLevel = 9,
+        Bookmark = 4,
+        EndInputStream = 2,
+        Phoneme = 6,
+        SentenceBoundary = 7,
+        StartInputStream = 1,
+        Viseme = 8,
+        VoiceChange = 3,
+        WordBoundary = 5,
+    }
+}
```

