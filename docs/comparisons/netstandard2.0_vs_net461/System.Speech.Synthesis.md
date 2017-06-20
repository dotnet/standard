# System.Speech.Synthesis

``` diff
+namespace System.Speech.Synthesis {
+    public class BookmarkReachedEventArgs : PromptEventArgs {
+        public TimeSpan AudioPosition { get; }
+        public string Bookmark { get; }
+    }
+    public class FilePrompt : Prompt {
+        public FilePrompt(string path, SynthesisMediaType media);
+        public FilePrompt(Uri promptFile, SynthesisMediaType media);
+    }
+    public class InstalledVoice {
+        public bool Enabled { get; set; }
+        public VoiceInfo VoiceInfo { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class PhonemeReachedEventArgs : PromptEventArgs {
+        public TimeSpan AudioPosition { get; }
+        public TimeSpan Duration { get; }
+        public SynthesizerEmphasis Emphasis { get; }
+        public string NextPhoneme { get; }
+        public string Phoneme { get; }
+    }
+    public class Prompt {
+        public Prompt(PromptBuilder promptBuilder);
+        public Prompt(string textToSpeak);
+        public Prompt(string textToSpeak, SynthesisTextFormat media);
+        public bool IsCompleted { get; internal set; }
+    }
+    public enum PromptBreak {
+        ExtraLarge = 5,
+        ExtraSmall = 1,
+        Large = 4,
+        Medium = 3,
+        None = 0,
+        Small = 2,
+    }
+    public class PromptBuilder {
+        public PromptBuilder();
+        public PromptBuilder(CultureInfo culture);
+        public CultureInfo Culture { get; set; }
+        public bool IsEmpty { get; }
+        public void AppendAudio(string path);
+        public void AppendAudio(Uri audioFile);
+        public void AppendAudio(Uri audioFile, string alternateText);
+        public void AppendBookmark(string bookmarkName);
+        public void AppendBreak();
+        public void AppendBreak(PromptBreak strength);
+        public void AppendBreak(TimeSpan duration);
+        public void AppendPromptBuilder(PromptBuilder promptBuilder);
+        public void AppendSsml(string path);
+        public void AppendSsml(Uri ssmlFile);
+        public void AppendSsml(XmlReader ssmlFile);
+        public void AppendSsmlMarkup(string ssmlMarkup);
+        public void AppendText(string textToSpeak);
+        public void AppendText(string textToSpeak, PromptEmphasis emphasis);
+        public void AppendText(string textToSpeak, PromptRate rate);
+        public void AppendText(string textToSpeak, PromptVolume volume);
+        public void AppendTextWithAlias(string textToSpeak, string substitute);
+        public void AppendTextWithHint(string textToSpeak, SayAs sayAs);
+        public void AppendTextWithHint(string textToSpeak, string sayAs);
+        public void AppendTextWithPronunciation(string textToSpeak, string pronunciation);
+        public void ClearContent();
+        public void EndParagraph();
+        public void EndSentence();
+        public void EndStyle();
+        public void EndVoice();
+        public void StartParagraph();
+        public void StartParagraph(CultureInfo culture);
+        public void StartSentence();
+        public void StartSentence(CultureInfo culture);
+        public void StartStyle(PromptStyle style);
+        public void StartVoice(CultureInfo culture);
+        public void StartVoice(VoiceGender gender);
+        public void StartVoice(VoiceGender gender, VoiceAge age);
+        public void StartVoice(VoiceGender gender, VoiceAge age, int voiceAlternate);
+        public void StartVoice(VoiceInfo voice);
+        public void StartVoice(string name);
+        public string ToXml();
+    }
+    public enum PromptEmphasis {
+        Moderate = 2,
+        None = 3,
+        NotSet = 0,
+        Reduced = 4,
+        Strong = 1,
+    }
+    public abstract class PromptEventArgs : AsyncCompletedEventArgs {
+        public Prompt Prompt { get; }
+    }
+    public enum PromptRate {
+        ExtraFast = 1,
+        ExtraSlow = 5,
+        Fast = 2,
+        Medium = 3,
+        NotSet = 0,
+        Slow = 4,
+    }
+    public class PromptStyle {
+        public PromptStyle();
+        public PromptStyle(PromptEmphasis emphasis);
+        public PromptStyle(PromptRate rate);
+        public PromptStyle(PromptVolume volume);
+        public PromptEmphasis Emphasis { get; set; }
+        public PromptRate Rate { get; set; }
+        public PromptVolume Volume { get; set; }
+    }
+    public enum PromptVolume {
+        Default = 7,
+        ExtraLoud = 6,
+        ExtraSoft = 2,
+        Loud = 5,
+        Medium = 4,
+        NotSet = 0,
+        Silent = 1,
+        Soft = 3,
+    }
+    public enum SayAs {
+        Date = 3,
+        Day = 13,
+        DayMonth = 10,
+        DayMonthYear = 4,
+        Month = 12,
+        MonthDay = 9,
+        MonthDayYear = 5,
+        MonthYear = 8,
+        NumberCardinal = 2,
+        NumberOrdinal = 1,
+        SpellOut = 0,
+        Telephone = 17,
+        Text = 18,
+        Time = 14,
+        Time12 = 16,
+        Time24 = 15,
+        Year = 11,
+        YearMonth = 7,
+        YearMonthDay = 6,
+    }
+    public class SpeakCompletedEventArgs : PromptEventArgs
+    public class SpeakProgressEventArgs : PromptEventArgs {
+        public TimeSpan AudioPosition { get; }
+        public int CharacterCount { get; internal set; }
+        public int CharacterPosition { get; }
+        public string Text { get; internal set; }
+    }
+    public class SpeakStartedEventArgs : PromptEventArgs
+    public sealed class SpeechSynthesizer : IDisposable {
+        public SpeechSynthesizer();
+        public int Rate { get; set; }
+        public SynthesizerState State { get; }
+        public VoiceInfo Voice { get; }
+        public int Volume { get; set; }
+        public event EventHandler<BookmarkReachedEventArgs> BookmarkReached;
+        public event EventHandler<PhonemeReachedEventArgs> PhonemeReached;
+        public event EventHandler<SpeakCompletedEventArgs> SpeakCompleted;
+        public event EventHandler<SpeakProgressEventArgs> SpeakProgress;
+        public event EventHandler<SpeakStartedEventArgs> SpeakStarted;
+        public event EventHandler<StateChangedEventArgs> StateChanged;
+        public event EventHandler<VisemeReachedEventArgs> VisemeReached;
+        public event EventHandler<VoiceChangeEventArgs> VoiceChange;
+        public void AddLexicon(Uri uri, string mediaType);
+        public void Dispose();
+        ~SpeechSynthesizer();
+        public Prompt GetCurrentlySpokenPrompt();
+        public ReadOnlyCollection<InstalledVoice> GetInstalledVoices();
+        public ReadOnlyCollection<InstalledVoice> GetInstalledVoices(CultureInfo culture);
+        public void Pause();
+        public void RemoveLexicon(Uri uri);
+        public void Resume();
+        public void SelectVoice(string name);
+        public void SelectVoiceByHints(VoiceGender gender);
+        public void SelectVoiceByHints(VoiceGender gender, VoiceAge age);
+        public void SelectVoiceByHints(VoiceGender gender, VoiceAge age, int voiceAlternate);
+        public void SelectVoiceByHints(VoiceGender gender, VoiceAge age, int voiceAlternate, CultureInfo culture);
+        public void SetOutputToAudioStream(Stream audioDestination, SpeechAudioFormatInfo formatInfo);
+        public void SetOutputToDefaultAudioDevice();
+        public void SetOutputToNull();
+        public void SetOutputToWaveFile(string path);
+        public void SetOutputToWaveFile(string path, SpeechAudioFormatInfo formatInfo);
+        public void SetOutputToWaveStream(Stream audioDestination);
+        public void Speak(Prompt prompt);
+        public void Speak(PromptBuilder promptBuilder);
+        public void Speak(string textToSpeak);
+        public void SpeakAsync(Prompt prompt);
+        public Prompt SpeakAsync(PromptBuilder promptBuilder);
+        public Prompt SpeakAsync(string textToSpeak);
+        public void SpeakAsyncCancel(Prompt prompt);
+        public void SpeakAsyncCancelAll();
+        public void SpeakSsml(string textToSpeak);
+        public Prompt SpeakSsmlAsync(string textToSpeak);
+    }
+    public class StateChangedEventArgs : EventArgs {
+        public SynthesizerState PreviousState { get; }
+        public SynthesizerState State { get; }
+    }
+    public enum SynthesisMediaType {
+        Ssml = 1,
+        Text = 0,
+        WaveAudio = 2,
+    }
+    public enum SynthesisTextFormat {
+        Ssml = 1,
+        Text = 0,
+    }
+    public enum SynthesizerEmphasis {
+        Emphasized = 2,
+        Stressed = 1,
+    }
+    public enum SynthesizerState {
+        Paused = 2,
+        Ready = 0,
+        Speaking = 1,
+    }
+    public class VisemeReachedEventArgs : PromptEventArgs {
+        public TimeSpan AudioPosition { get; }
+        public TimeSpan Duration { get; }
+        public SynthesizerEmphasis Emphasis { get; }
+        public int NextViseme { get; }
+        public int Viseme { get; }
+    }
+    public enum VoiceAge {
+        Adult = 30,
+        Child = 10,
+        NotSet = 0,
+        Senior = 65,
+        Teen = 15,
+    }
+    public class VoiceChangeEventArgs : PromptEventArgs {
+        public VoiceInfo Voice { get; }
+    }
+    public enum VoiceGender {
+        Female = 2,
+        Male = 1,
+        Neutral = 3,
+        NotSet = 0,
+    }
+    public class VoiceInfo {
+        public IDictionary<string, string> AdditionalInfo { get; }
+        public VoiceAge Age { get; }
+        public CultureInfo Culture { get; }
+        public string Description { get; }
+        public VoiceGender Gender { get; }
+        public string Id { get; }
+        public string Name { get; }
+        public ReadOnlyCollection<SpeechAudioFormatInfo> SupportedAudioFormats { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+}
```

