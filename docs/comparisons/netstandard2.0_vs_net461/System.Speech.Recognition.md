# System.Speech.Recognition

``` diff
+namespace System.Speech.Recognition {
+    public class AudioLevelUpdatedEventArgs : EventArgs {
+        public int AudioLevel { get; }
+    }
+    public enum AudioSignalProblem {
+        None = 0,
+        NoSignal = 2,
+        TooFast = 5,
+        TooLoud = 3,
+        TooNoisy = 1,
+        TooSlow = 6,
+        TooSoft = 4,
+    }
+    public class AudioSignalProblemOccurredEventArgs : EventArgs {
+        public int AudioLevel { get; }
+        public TimeSpan AudioPosition { get; }
+        public AudioSignalProblem AudioSignalProblem { get; }
+        public TimeSpan RecognizerAudioPosition { get; }
+    }
+    public enum AudioState {
+        Silence = 1,
+        Speech = 2,
+        Stopped = 0,
+    }
+    public class AudioStateChangedEventArgs : EventArgs {
+        public AudioState AudioState { get; }
+    }
+    public class Choices {
+        public Choices();
+        public Choices(params GrammarBuilder[] alternateChoices);
+        public Choices(params string[] phrases);
+        public void Add(params GrammarBuilder[] alternateChoices);
+        public void Add(params string[] phrases);
+        public GrammarBuilder ToGrammarBuilder();
+    }
+    public class DictationGrammar : Grammar {
+        public DictationGrammar();
+        public DictationGrammar(string topic);
+        public void SetDictationContext(string precedingText, string subsequentText);
+    }
+    public enum DisplayAttributes {
+        ConsumeLeadingSpaces = 16,
+        None = 0,
+        OneTrailingSpace = 4,
+        TwoTrailingSpaces = 8,
+        ZeroTrailingSpaces = 2,
+    }
+    public class EmulateRecognizeCompletedEventArgs : AsyncCompletedEventArgs {
+        public RecognitionResult Result { get; }
+    }
+    public class Grammar {
+        protected Grammar();
+        public Grammar(Stream stream);
+        public Grammar(Stream stream, string ruleName);
+        public Grammar(Stream stream, string ruleName, object[] parameters);
+        public Grammar(Stream stream, string ruleName, Uri baseUri);
+        public Grammar(Stream stream, string ruleName, Uri baseUri, object[] parameters);
+        public Grammar(GrammarBuilder builder);
+        public Grammar(SrgsDocument srgsDocument);
+        public Grammar(SrgsDocument srgsDocument, string ruleName);
+        public Grammar(SrgsDocument srgsDocument, string ruleName, object[] parameters);
+        public Grammar(SrgsDocument srgsDocument, string ruleName, Uri baseUri);
+        public Grammar(SrgsDocument srgsDocument, string ruleName, Uri baseUri, object[] parameters);
+        public Grammar(string path);
+        public Grammar(string path, string ruleName);
+        public Grammar(string path, string ruleName, object[] parameters);
+        public bool Enabled { get; set; }
+        protected internal virtual bool IsStg { get; }
+        public bool Loaded { get; }
+        public string Name { get; set; }
+        public int Priority { get; set; }
+        protected string ResourceName { get; set; }
+        public string RuleName { get; }
+        public float Weight { get; set; }
+        public event EventHandler<SpeechRecognizedEventArgs> SpeechRecognized;
+        public static Grammar LoadLocalizedGrammarFromType(Type type, params object[] onInitParameters);
+        protected void StgInit(object[] parameters);
+    }
+    public class GrammarBuilder {
+        public GrammarBuilder();
+        public GrammarBuilder(Choices alternateChoices);
+        public GrammarBuilder(GrammarBuilder builder, int minRepeat, int maxRepeat);
+        public GrammarBuilder(SemanticResultKey key);
+        public GrammarBuilder(SemanticResultValue value);
+        public GrammarBuilder(string phrase);
+        public GrammarBuilder(string phrase, int minRepeat, int maxRepeat);
+        public GrammarBuilder(string phrase, SubsetMatchingMode subsetMatchingCriteria);
+        public CultureInfo Culture { get; set; }
+        public string DebugShowPhrases { get; }
+        public static GrammarBuilder Add(Choices choices, GrammarBuilder builder);
+        public static GrammarBuilder Add(GrammarBuilder builder, Choices choices);
+        public static GrammarBuilder Add(GrammarBuilder builder1, GrammarBuilder builder2);
+        public static GrammarBuilder Add(GrammarBuilder builder, string phrase);
+        public static GrammarBuilder Add(string phrase, GrammarBuilder builder);
+        public void Append(Choices alternateChoices);
+        public void Append(GrammarBuilder builder);
+        public void Append(GrammarBuilder builder, int minRepeat, int maxRepeat);
+        public void Append(SemanticResultKey key);
+        public void Append(SemanticResultValue value);
+        public void Append(string phrase);
+        public void Append(string phrase, int minRepeat, int maxRepeat);
+        public void Append(string phrase, SubsetMatchingMode subsetMatchingCriteria);
+        public void AppendDictation();
+        public void AppendDictation(string category);
+        public void AppendRuleReference(string path);
+        public void AppendRuleReference(string path, string rule);
+        public void AppendWildcard();
+        public static GrammarBuilder operator +(Choices choices, GrammarBuilder builder);
+        public static GrammarBuilder operator +(GrammarBuilder builder, Choices choices);
+        public static GrammarBuilder operator +(GrammarBuilder builder1, GrammarBuilder builder2);
+        public static GrammarBuilder operator +(GrammarBuilder builder, string phrase);
+        public static GrammarBuilder operator +(string phrase, GrammarBuilder builder);
+        public static implicit operator GrammarBuilder (Choices choices);
+        public static implicit operator GrammarBuilder (SemanticResultKey semanticKey);
+        public static implicit operator GrammarBuilder (SemanticResultValue semanticValue);
+        public static implicit operator GrammarBuilder (string phrase);
+    }
+    public class LoadGrammarCompletedEventArgs : AsyncCompletedEventArgs {
+        public Grammar Grammar { get; }
+    }
+    public abstract class RecognitionEventArgs : EventArgs {
+        public RecognitionResult Result { get; }
+    }
+    public sealed class RecognitionResult : RecognizedPhrase, ISerializable {
+        public ReadOnlyCollection<RecognizedPhrase> Alternates { get; }
+        public RecognizedAudio Audio { get; }
+        public RecognizedAudio GetAudioForWordRange(RecognizedWordUnit firstWord, RecognizedWordUnit lastWord);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class RecognizeCompletedEventArgs : AsyncCompletedEventArgs {
+        public TimeSpan AudioPosition { get; }
+        public bool BabbleTimeout { get; }
+        public bool InitialSilenceTimeout { get; }
+        public bool InputStreamEnded { get; }
+        public RecognitionResult Result { get; }
+    }
+    public class RecognizedAudio {
+        public TimeSpan AudioPosition { get; }
+        public TimeSpan Duration { get; }
+        public SpeechAudioFormatInfo Format { get; }
+        public DateTime StartTime { get; }
+        public RecognizedAudio GetRange(TimeSpan audioPosition, TimeSpan duration);
+        public void WriteToAudioStream(Stream outputStream);
+        public void WriteToWaveStream(Stream outputStream);
+    }
+    public class RecognizedPhrase {
+        public float Confidence { get; }
+        public Grammar Grammar { get; }
+        public int HomophoneGroupId { get; }
+        public ReadOnlyCollection<RecognizedPhrase> Homophones { get; }
+        public Collection<ReplacementText> ReplacementWordUnits { get; }
+        public SemanticValue Semantics { get; }
+        public string Text { get; }
+        public ReadOnlyCollection<RecognizedWordUnit> Words { get; }
+        public IXPathNavigable ConstructSmlFromSemantics();
+    }
+    public class RecognizedWordUnit {
+        public RecognizedWordUnit(string text, float confidence, string pronunciation, string lexicalForm, DisplayAttributes displayAttributes, TimeSpan audioPosition, TimeSpan audioDuration);
+        public float Confidence { get; }
+        public DisplayAttributes DisplayAttributes { get; }
+        public string LexicalForm { get; }
+        public string Pronunciation { get; }
+        public string Text { get; }
+    }
+    public enum RecognizeMode {
+        Multiple = 1,
+        Single = 0,
+    }
+    public class RecognizerInfo : IDisposable {
+        public IDictionary<string, string> AdditionalInfo { get; }
+        public CultureInfo Culture { get; }
+        public string Description { get; }
+        public string Id { get; }
+        public string Name { get; }
+        public ReadOnlyCollection<SpeechAudioFormatInfo> SupportedAudioFormats { get; }
+        public void Dispose();
+    }
+    public enum RecognizerState {
+        Listening = 1,
+        Stopped = 0,
+    }
+    public class RecognizerUpdateReachedEventArgs : EventArgs {
+        public TimeSpan AudioPosition { get; }
+        public object UserToken { get; }
+    }
+    public class ReplacementText {
+        public int CountOfWords { get; }
+        public DisplayAttributes DisplayAttributes { get; }
+        public int FirstWordIndex { get; }
+        public string Text { get; }
+    }
+    public class SemanticResultKey {
+        public SemanticResultKey(string semanticResultKey, params GrammarBuilder[] builders);
+        public SemanticResultKey(string semanticResultKey, params string[] phrases);
+        public GrammarBuilder ToGrammarBuilder();
+    }
+    public class SemanticResultValue {
+        public SemanticResultValue(object value);
+        public SemanticResultValue(GrammarBuilder builder, object value);
+        public SemanticResultValue(string phrase, object value);
+        public GrammarBuilder ToGrammarBuilder();
+    }
+    public sealed class SemanticValue : ICollection<KeyValuePair<string, SemanticValue>>, IDictionary<string, SemanticValue>, IEnumerable, IEnumerable<KeyValuePair<string, SemanticValue>> {
+        public SemanticValue(object value);
+        public SemanticValue(string keyName, object value, float confidence);
+        public float Confidence { get; }
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.IsReadOnly { get; }
+        ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.Keys { get; }
+        ICollection<SemanticValue> System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.Values { get; }
+        public SemanticValue this[string key] { get; set; }
+        public object Value { get; internal set; }
+        public bool Contains(KeyValuePair<string, SemanticValue> item);
+        public bool ContainsKey(string key);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.Add(KeyValuePair<string, SemanticValue> key);
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.Clear();
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.CopyTo(KeyValuePair<string, SemanticValue>[] array, int index);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.Remove(KeyValuePair<string, SemanticValue> key);
+        void System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.Add(string key, SemanticValue value);
+        bool System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.Remove(string key);
+        bool System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.TryGetValue(string key, out SemanticValue value);
+        IEnumerator<KeyValuePair<string, SemanticValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class SpeechDetectedEventArgs : EventArgs {
+        public TimeSpan AudioPosition { get; }
+    }
+    public class SpeechHypothesizedEventArgs : RecognitionEventArgs
+    public class SpeechRecognitionEngine : IDisposable {
+        public SpeechRecognitionEngine();
+        public SpeechRecognitionEngine(CultureInfo culture);
+        public SpeechRecognitionEngine(RecognizerInfo recognizerInfo);
+        public SpeechRecognitionEngine(string recognizerId);
+        public SpeechAudioFormatInfo AudioFormat { get; }
+        public int AudioLevel { get; }
+        public TimeSpan AudioPosition { get; }
+        public AudioState AudioState { get; }
+        public TimeSpan BabbleTimeout { get; set; }
+        public TimeSpan EndSilenceTimeout { get; set; }
+        public TimeSpan EndSilenceTimeoutAmbiguous { get; set; }
+        public ReadOnlyCollection<Grammar> Grammars { get; }
+        public TimeSpan InitialSilenceTimeout { get; set; }
+        public int MaxAlternates { get; set; }
+        public TimeSpan RecognizerAudioPosition { get; }
+        public RecognizerInfo RecognizerInfo { get; }
+        public event EventHandler<AudioLevelUpdatedEventArgs> AudioLevelUpdated;
+        public event EventHandler<AudioSignalProblemOccurredEventArgs> AudioSignalProblemOccurred;
+        public event EventHandler<AudioStateChangedEventArgs> AudioStateChanged;
+        public event EventHandler<EmulateRecognizeCompletedEventArgs> EmulateRecognizeCompleted;
+        public event EventHandler<LoadGrammarCompletedEventArgs> LoadGrammarCompleted;
+        public event EventHandler<RecognizeCompletedEventArgs> RecognizeCompleted;
+        public event EventHandler<RecognizerUpdateReachedEventArgs> RecognizerUpdateReached;
+        public event EventHandler<SpeechDetectedEventArgs> SpeechDetected;
+        public event EventHandler<SpeechHypothesizedEventArgs> SpeechHypothesized;
+        public event EventHandler<SpeechRecognitionRejectedEventArgs> SpeechRecognitionRejected;
+        public event EventHandler<SpeechRecognizedEventArgs> SpeechRecognized;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public RecognitionResult EmulateRecognize(RecognizedWordUnit[] wordUnits, CompareOptions compareOptions);
+        public RecognitionResult EmulateRecognize(string inputText);
+        public RecognitionResult EmulateRecognize(string inputText, CompareOptions compareOptions);
+        public void EmulateRecognizeAsync(RecognizedWordUnit[] wordUnits, CompareOptions compareOptions);
+        public void EmulateRecognizeAsync(string inputText);
+        public void EmulateRecognizeAsync(string inputText, CompareOptions compareOptions);
+        public static ReadOnlyCollection<RecognizerInfo> InstalledRecognizers();
+        public void LoadGrammar(Grammar grammar);
+        public void LoadGrammarAsync(Grammar grammar);
+        public object QueryRecognizerSetting(string settingName);
+        public RecognitionResult Recognize();
+        public RecognitionResult Recognize(TimeSpan initialSilenceTimeout);
+        public void RecognizeAsync();
+        public void RecognizeAsync(RecognizeMode mode);
+        public void RecognizeAsyncCancel();
+        public void RecognizeAsyncStop();
+        public void RequestRecognizerUpdate();
+        public void RequestRecognizerUpdate(object userToken);
+        public void RequestRecognizerUpdate(object userToken, TimeSpan audioPositionAheadToRaiseUpdate);
+        public void SetInputToAudioStream(Stream audioSource, SpeechAudioFormatInfo audioFormat);
+        public void SetInputToDefaultAudioDevice();
+        public void SetInputToNull();
+        public void SetInputToWaveFile(string path);
+        public void SetInputToWaveStream(Stream audioSource);
+        public void UnloadAllGrammars();
+        public void UnloadGrammar(Grammar grammar);
+        public void UpdateRecognizerSetting(string settingName, int updatedValue);
+        public void UpdateRecognizerSetting(string settingName, string updatedValue);
+    }
+    public class SpeechRecognitionRejectedEventArgs : RecognitionEventArgs
+    public class SpeechRecognizedEventArgs : RecognitionEventArgs
+    public class SpeechRecognizer : IDisposable {
+        public SpeechRecognizer();
+        public SpeechAudioFormatInfo AudioFormat { get; }
+        public int AudioLevel { get; }
+        public TimeSpan AudioPosition { get; }
+        public AudioState AudioState { get; }
+        public bool Enabled { get; set; }
+        public ReadOnlyCollection<Grammar> Grammars { get; }
+        public int MaxAlternates { get; set; }
+        public bool PauseRecognizerOnRecognition { get; set; }
+        public TimeSpan RecognizerAudioPosition { get; }
+        public RecognizerInfo RecognizerInfo { get; }
+        public RecognizerState State { get; }
+        public event EventHandler<AudioLevelUpdatedEventArgs> AudioLevelUpdated;
+        public event EventHandler<AudioSignalProblemOccurredEventArgs> AudioSignalProblemOccurred;
+        public event EventHandler<AudioStateChangedEventArgs> AudioStateChanged;
+        public event EventHandler<EmulateRecognizeCompletedEventArgs> EmulateRecognizeCompleted;
+        public event EventHandler<LoadGrammarCompletedEventArgs> LoadGrammarCompleted;
+        public event EventHandler<RecognizerUpdateReachedEventArgs> RecognizerUpdateReached;
+        public event EventHandler<SpeechDetectedEventArgs> SpeechDetected;
+        public event EventHandler<SpeechHypothesizedEventArgs> SpeechHypothesized;
+        public event EventHandler<SpeechRecognitionRejectedEventArgs> SpeechRecognitionRejected;
+        public event EventHandler<SpeechRecognizedEventArgs> SpeechRecognized;
+        public event EventHandler<StateChangedEventArgs> StateChanged;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public RecognitionResult EmulateRecognize(RecognizedWordUnit[] wordUnits, CompareOptions compareOptions);
+        public RecognitionResult EmulateRecognize(string inputText);
+        public RecognitionResult EmulateRecognize(string inputText, CompareOptions compareOptions);
+        public void EmulateRecognizeAsync(RecognizedWordUnit[] wordUnits, CompareOptions compareOptions);
+        public void EmulateRecognizeAsync(string inputText);
+        public void EmulateRecognizeAsync(string inputText, CompareOptions compareOptions);
+        public void LoadGrammar(Grammar grammar);
+        public void LoadGrammarAsync(Grammar grammar);
+        public void RequestRecognizerUpdate();
+        public void RequestRecognizerUpdate(object userToken);
+        public void RequestRecognizerUpdate(object userToken, TimeSpan audioPositionAheadToRaiseUpdate);
+        public void UnloadAllGrammars();
+        public void UnloadGrammar(Grammar grammar);
+    }
+    public class SpeechUI {
+        public static bool SendTextFeedback(RecognitionResult result, string feedback, bool isSuccessfulAction);
+    }
+    public class StateChangedEventArgs : EventArgs {
+        public RecognizerState RecognizerState { get; }
+    }
+    public enum SubsetMatchingMode {
+        OrderedSubset = 1,
+        OrderedSubsetContentRequired = 3,
+        Subsequence = 0,
+        SubsequenceContentRequired = 2,
+    }
+}
```

