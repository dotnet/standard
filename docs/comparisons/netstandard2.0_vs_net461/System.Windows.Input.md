# System.Windows.Input

``` diff
 namespace System.Windows.Input {
+    public class AccessKeyEventArgs : EventArgs {
+        public bool IsMultiple { get; }
+        public string Key { get; }
+    }
+    public sealed class AccessKeyManager {
+        public static readonly RoutedEvent AccessKeyPressedEvent;
+        public static void AddAccessKeyPressedHandler(DependencyObject element, AccessKeyPressedEventHandler handler);
+        public static bool IsKeyRegistered(object scope, string key);
+        public static bool ProcessKey(object scope, string key, bool isMultiple);
+        public static void Register(string key, IInputElement element);
+        public static void RemoveAccessKeyPressedHandler(DependencyObject element, AccessKeyPressedEventHandler handler);
+        public static void Unregister(string key, IInputElement element);
+    }
+    public class AccessKeyPressedEventArgs : RoutedEventArgs {
+        public AccessKeyPressedEventArgs();
+        public AccessKeyPressedEventArgs(string key);
+        public string Key { get; }
+        public object Scope { get; set; }
+        public UIElement Target { get; set; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void AccessKeyPressedEventHandler(object sender, AccessKeyPressedEventArgs e);
+    public static class ApplicationCommands {
+        public static RoutedUICommand CancelPrint { get; }
+        public static RoutedUICommand Close { get; }
+        public static RoutedUICommand ContextMenu { get; }
+        public static RoutedUICommand Copy { get; }
+        public static RoutedUICommand CorrectionList { get; }
+        public static RoutedUICommand Cut { get; }
+        public static RoutedUICommand Delete { get; }
+        public static RoutedUICommand Find { get; }
+        public static RoutedUICommand Help { get; }
+        public static RoutedUICommand New { get; }
+        public static RoutedUICommand NotACommand { get; }
+        public static RoutedUICommand Open { get; }
+        public static RoutedUICommand Paste { get; }
+        public static RoutedUICommand Print { get; }
+        public static RoutedUICommand PrintPreview { get; }
+        public static RoutedUICommand Properties { get; }
+        public static RoutedUICommand Redo { get; }
+        public static RoutedUICommand Replace { get; }
+        public static RoutedUICommand Save { get; }
+        public static RoutedUICommand SaveAs { get; }
+        public static RoutedUICommand SelectAll { get; }
+        public static RoutedUICommand Stop { get; }
+        public static RoutedUICommand Undo { get; }
+    }
+    public class CanExecuteChangedEventManager : WeakEventManager {
+        public static void AddHandler(ICommand source, EventHandler<EventArgs> handler);
+        protected override bool Purge(object source, object data, bool purgeAll);
+        public static void RemoveHandler(ICommand source, EventHandler<EventArgs> handler);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
+    public sealed class CanExecuteRoutedEventArgs : RoutedEventArgs {
+        public bool CanExecute { get; set; }
+        public ICommand Command { get; }
+        public bool ContinueRouting { get; set; }
+        public object Parameter { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object target);
+    }
+    public delegate void CanExecuteRoutedEventHandler(object sender, CanExecuteRoutedEventArgs e);
+    public enum CaptureMode {
+        Element = 1,
+        None = 0,
+        SubTree = 2,
+    }
+    public class CommandBinding {
+        public CommandBinding();
+        public CommandBinding(ICommand command);
+        public CommandBinding(ICommand command, ExecutedRoutedEventHandler executed);
+        public CommandBinding(ICommand command, ExecutedRoutedEventHandler executed, CanExecuteRoutedEventHandler canExecute);
+        public ICommand Command { get; set; }
+        public event CanExecuteRoutedEventHandler CanExecute;
+        public event ExecutedRoutedEventHandler Executed;
+        public event CanExecuteRoutedEventHandler PreviewCanExecute;
+        public event ExecutedRoutedEventHandler PreviewExecuted;
+    }
+    public sealed class CommandBindingCollection : ICollection, IEnumerable, IList {
+        public CommandBindingCollection();
+        public CommandBindingCollection(IList commandBindings);
+        public int Count { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public CommandBinding this[int index] { get; set; }
+        public int Add(CommandBinding commandBinding);
+        public void AddRange(ICollection collection);
+        public void Clear();
+        public bool Contains(CommandBinding commandBinding);
+        public void CopyTo(CommandBinding[] commandBindings, int index);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(CommandBinding value);
+        public void Insert(int index, CommandBinding commandBinding);
+        public void Remove(CommandBinding commandBinding);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object commandBinding);
+        bool System.Collections.IList.Contains(object key);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object commandBinding);
+    }
+    public sealed class CommandConverter : TypeConverter {
+        public CommandConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class CommandManager {
+        public static readonly RoutedEvent CanExecuteEvent;
+        public static readonly RoutedEvent ExecutedEvent;
+        public static readonly RoutedEvent PreviewCanExecuteEvent;
+        public static readonly RoutedEvent PreviewExecutedEvent;
+        public static event EventHandler RequerySuggested;
+        public static void AddCanExecuteHandler(UIElement element, CanExecuteRoutedEventHandler handler);
+        public static void AddExecutedHandler(UIElement element, ExecutedRoutedEventHandler handler);
+        public static void AddPreviewCanExecuteHandler(UIElement element, CanExecuteRoutedEventHandler handler);
+        public static void AddPreviewExecutedHandler(UIElement element, ExecutedRoutedEventHandler handler);
+        public static void InvalidateRequerySuggested();
+        public static void RegisterClassCommandBinding(Type type, CommandBinding commandBinding);
+        public static void RegisterClassInputBinding(Type type, InputBinding inputBinding);
+        public static void RemoveCanExecuteHandler(UIElement element, CanExecuteRoutedEventHandler handler);
+        public static void RemoveExecutedHandler(UIElement element, ExecutedRoutedEventHandler handler);
+        public static void RemovePreviewCanExecuteHandler(UIElement element, CanExecuteRoutedEventHandler handler);
+        public static void RemovePreviewExecutedHandler(UIElement element, ExecutedRoutedEventHandler handler);
+    }
+    public static class ComponentCommands {
+        public static RoutedUICommand ExtendSelectionDown { get; }
+        public static RoutedUICommand ExtendSelectionLeft { get; }
+        public static RoutedUICommand ExtendSelectionRight { get; }
+        public static RoutedUICommand ExtendSelectionUp { get; }
+        public static RoutedUICommand MoveDown { get; }
+        public static RoutedUICommand MoveFocusBack { get; }
+        public static RoutedUICommand MoveFocusDown { get; }
+        public static RoutedUICommand MoveFocusForward { get; }
+        public static RoutedUICommand MoveFocusPageDown { get; }
+        public static RoutedUICommand MoveFocusPageUp { get; }
+        public static RoutedUICommand MoveFocusUp { get; }
+        public static RoutedUICommand MoveLeft { get; }
+        public static RoutedUICommand MoveRight { get; }
+        public static RoutedUICommand MoveToEnd { get; }
+        public static RoutedUICommand MoveToHome { get; }
+        public static RoutedUICommand MoveToPageDown { get; }
+        public static RoutedUICommand MoveToPageUp { get; }
+        public static RoutedUICommand MoveUp { get; }
+        public static RoutedUICommand ScrollByLine { get; }
+        public static RoutedUICommand ScrollPageDown { get; }
+        public static RoutedUICommand ScrollPageLeft { get; }
+        public static RoutedUICommand ScrollPageRight { get; }
+        public static RoutedUICommand ScrollPageUp { get; }
+        public static RoutedUICommand SelectToEnd { get; }
+        public static RoutedUICommand SelectToHome { get; }
+        public static RoutedUICommand SelectToPageDown { get; }
+        public static RoutedUICommand SelectToPageUp { get; }
+    }
+    public sealed class Cursor : IDisposable {
+        public Cursor(Stream cursorStream);
+        public Cursor(Stream cursorStream, bool scaleWithDpi);
+        public Cursor(string cursorFile);
+        public Cursor(string cursorFile, bool scaleWithDpi);
+        public void Dispose();
+        ~Cursor();
+        public override string ToString();
+    }
+    public class CursorConverter : TypeConverter {
+        public CursorConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public static class Cursors {
+        public static Cursor AppStarting { get; }
+        public static Cursor Arrow { get; }
+        public static Cursor ArrowCD { get; }
+        public static Cursor Cross { get; }
+        public static Cursor Hand { get; }
+        public static Cursor Help { get; }
+        public static Cursor IBeam { get; }
+        public static Cursor No { get; }
+        public static Cursor None { get; }
+        public static Cursor Pen { get; }
+        public static Cursor ScrollAll { get; }
+        public static Cursor ScrollE { get; }
+        public static Cursor ScrollN { get; }
+        public static Cursor ScrollNE { get; }
+        public static Cursor ScrollNS { get; }
+        public static Cursor ScrollNW { get; }
+        public static Cursor ScrollS { get; }
+        public static Cursor ScrollSE { get; }
+        public static Cursor ScrollSW { get; }
+        public static Cursor ScrollW { get; }
+        public static Cursor ScrollWE { get; }
+        public static Cursor SizeAll { get; }
+        public static Cursor SizeNESW { get; }
+        public static Cursor SizeNS { get; }
+        public static Cursor SizeNWSE { get; }
+        public static Cursor SizeWE { get; }
+        public static Cursor UpArrow { get; }
+        public static Cursor Wait { get; }
+    }
+    public enum CursorType {
+        AppStarting = 3,
+        Arrow = 2,
+        ArrowCD = 27,
+        Cross = 4,
+        Hand = 14,
+        Help = 5,
+        IBeam = 6,
+        No = 1,
+        None = 0,
+        Pen = 15,
+        ScrollAll = 18,
+        ScrollE = 22,
+        ScrollN = 19,
+        ScrollNE = 24,
+        ScrollNS = 16,
+        ScrollNW = 23,
+        ScrollS = 20,
+        ScrollSE = 26,
+        ScrollSW = 25,
+        ScrollW = 21,
+        ScrollWE = 17,
+        SizeAll = 7,
+        SizeNESW = 8,
+        SizeNS = 9,
+        SizeNWSE = 10,
+        SizeWE = 11,
+        UpArrow = 12,
+        Wait = 13,
+    }
+    public sealed class ExecutedRoutedEventArgs : RoutedEventArgs {
+        public ICommand Command { get; }
+        public object Parameter { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object target);
+    }
+    public delegate void ExecutedRoutedEventHandler(object sender, ExecutedRoutedEventArgs e);
+    public static class FocusManager {
+        public static readonly DependencyProperty FocusedElementProperty;
+        public static readonly DependencyProperty IsFocusScopeProperty;
+        public static readonly RoutedEvent GotFocusEvent;
+        public static readonly RoutedEvent LostFocusEvent;
+        public static void AddGotFocusHandler(DependencyObject element, RoutedEventHandler handler);
+        public static void AddLostFocusHandler(DependencyObject element, RoutedEventHandler handler);
+        public static IInputElement GetFocusedElement(DependencyObject element);
+        public static DependencyObject GetFocusScope(DependencyObject element);
+        public static bool GetIsFocusScope(DependencyObject element);
+        public static void RemoveGotFocusHandler(DependencyObject element, RoutedEventHandler handler);
+        public static void RemoveLostFocusHandler(DependencyObject element, RoutedEventHandler handler);
+        public static void SetFocusedElement(DependencyObject element, IInputElement value);
+        public static void SetIsFocusScope(DependencyObject element, bool value);
+    }
+    public enum FocusNavigationDirection {
+        Down = 7,
+        First = 2,
+        Last = 3,
+        Left = 4,
+        Next = 0,
+        Previous = 1,
+        Right = 5,
+        Up = 6,
+    }
+    public interface ICommandSource {
+        ICommand Command { get; }
+        object CommandParameter { get; }
+        IInputElement CommandTarget { get; }
+    }
+    public interface IInputLanguageSource {
+        CultureInfo CurrentInputLanguage { get; set; }
+        IEnumerable InputLanguageList { get; }
+        void Initialize();
+        void Uninitialize();
+    }
+    public interface IManipulator {
+        int Id { get; }
+        event EventHandler Updated;
+        Point GetPosition(IInputElement relativeTo);
+        void ManipulationEnded(bool cancel);
+    }
+    public enum ImeConversionModeValues {
+        Alphanumeric = 512,
+        CharCode = 16,
+        DoNotCare = -2147483648,
+        Eudc = 64,
+        Fixed = 256,
+        FullShape = 4,
+        Katakana = 2,
+        Native = 1,
+        NoConversion = 32,
+        Roman = 8,
+        Symbol = 128,
+    }
+    public enum ImeSentenceModeValues {
+        Automatic = 4,
+        Conversation = 16,
+        DoNotCare = -2147483648,
+        None = 0,
+        PhrasePrediction = 8,
+        PluralClause = 1,
+        SingleConversion = 2,
+    }
+    public class InertiaExpansionBehavior {
+        public InertiaExpansionBehavior();
+        public double DesiredDeceleration { get; set; }
+        public Vector DesiredExpansion { get; set; }
+        public double InitialRadius { get; set; }
+        public Vector InitialVelocity { get; set; }
+    }
+    public class InertiaRotationBehavior {
+        public InertiaRotationBehavior();
+        public double DesiredDeceleration { get; set; }
+        public double DesiredRotation { get; set; }
+        public double InitialVelocity { get; set; }
+    }
+    public class InertiaTranslationBehavior {
+        public InertiaTranslationBehavior();
+        public double DesiredDeceleration { get; set; }
+        public double DesiredDisplacement { get; set; }
+        public Vector InitialVelocity { get; set; }
+    }
+    public class InputBinding : Freezable, ICommandSource {
+        public static readonly DependencyProperty CommandParameterProperty;
+        public static readonly DependencyProperty CommandProperty;
+        public static readonly DependencyProperty CommandTargetProperty;
+        protected InputBinding();
+        public InputBinding(ICommand command, InputGesture gesture);
+        public ICommand Command { get; set; }
+        public object CommandParameter { get; set; }
+        public IInputElement CommandTarget { get; set; }
+        public virtual InputGesture Gesture { get; set; }
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+    }
+    public sealed class InputBindingCollection : ICollection, IEnumerable, IList {
+        public InputBindingCollection();
+        public InputBindingCollection(IList inputBindings);
+        public int Count { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public InputBinding this[int index] { get; set; }
+        public int Add(InputBinding inputBinding);
+        public void AddRange(ICollection collection);
+        public void Clear();
+        public bool Contains(InputBinding key);
+        public void CopyTo(InputBinding[] inputBindings, int index);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(InputBinding value);
+        public void Insert(int index, InputBinding inputBinding);
+        public void Remove(InputBinding inputBinding);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object inputBinding);
+        bool System.Collections.IList.Contains(object key);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object inputBinding);
+    }
+    public abstract class InputDevice : DispatcherObject {
+        protected InputDevice();
+        public abstract PresentationSource ActiveSource { get; }
+        public abstract IInputElement Target { get; }
+    }
+    public class InputEventArgs : RoutedEventArgs {
+        public InputEventArgs(InputDevice inputDevice, int timestamp);
+        public InputDevice Device { get; internal set; }
+        public int Timestamp { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void InputEventHandler(object sender, InputEventArgs e);
+    public abstract class InputGesture {
+        protected InputGesture();
+        public abstract bool Matches(object targetElement, InputEventArgs inputEventArgs);
+    }
+    public sealed class InputGestureCollection : ICollection, IEnumerable, IList {
+        public InputGestureCollection();
+        public InputGestureCollection(IList inputGestures);
+        public int Count { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public InputGesture this[int index] { get; set; }
+        public int Add(InputGesture inputGesture);
+        public void AddRange(ICollection collection);
+        public void Clear();
+        public bool Contains(InputGesture key);
+        public void CopyTo(InputGesture[] inputGestures, int index);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(InputGesture value);
+        public void Insert(int index, InputGesture inputGesture);
+        public void Remove(InputGesture inputGesture);
+        public void RemoveAt(int index);
+        public void Seal();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object inputGesture);
+        bool System.Collections.IList.Contains(object key);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object inputGesture);
+    }
+    public class InputLanguageChangedEventArgs : InputLanguageEventArgs {
+        public InputLanguageChangedEventArgs(CultureInfo newLanguageId, CultureInfo previousLanguageId);
+    }
+    public class InputLanguageChangingEventArgs : InputLanguageEventArgs {
+        public InputLanguageChangingEventArgs(CultureInfo newLanguageId, CultureInfo previousLanguageId);
+        public bool Rejected { get; set; }
+    }
+    public abstract class InputLanguageEventArgs : EventArgs {
+        protected InputLanguageEventArgs(CultureInfo newLanguageId, CultureInfo previousLanguageId);
+        public virtual CultureInfo NewLanguage { get; }
+        public virtual CultureInfo PreviousLanguage { get; }
+    }
+    public delegate void InputLanguageEventHandler(object sender, InputLanguageEventArgs e);
+    public sealed class InputLanguageManager : DispatcherObject {
+        public static readonly DependencyProperty InputLanguageProperty;
+        public static readonly DependencyProperty RestoreInputLanguageProperty;
+        public IEnumerable AvailableInputLanguages { get; }
+        public static InputLanguageManager Current { get; }
+        public CultureInfo CurrentInputLanguage { get; set; }
+        public event InputLanguageEventHandler InputLanguageChanged;
+        public event InputLanguageEventHandler InputLanguageChanging;
+        public static CultureInfo GetInputLanguage(DependencyObject target);
+        public static bool GetRestoreInputLanguage(DependencyObject target);
+        public void RegisterInputLanguageSource(IInputLanguageSource inputLanguageSource);
+        public void ReportInputLanguageChanged(CultureInfo newLanguageId, CultureInfo previousLanguageId);
+        public bool ReportInputLanguageChanging(CultureInfo newLanguageId, CultureInfo previousLanguageId);
+        public static void SetInputLanguage(DependencyObject target, CultureInfo inputLanguage);
+        public static void SetRestoreInputLanguage(DependencyObject target, bool restore);
+    }
+    public sealed class InputManager : DispatcherObject {
+        public static InputManager Current { get; }
+        public ICollection InputProviders { get; }
+        public bool IsInMenuMode { get; }
+        public InputDevice MostRecentInputDevice { get; internal set; }
+        public KeyboardDevice PrimaryKeyboardDevice { get; }
+        public MouseDevice PrimaryMouseDevice { get; }
+        public event EventHandler EnterMenuMode;
+        public event EventHandler HitTestInvalidatedAsync;
+        public event EventHandler LeaveMenuMode;
+        public event NotifyInputEventHandler PostNotifyInput;
+        public event ProcessInputEventHandler PostProcessInput;
+        public event NotifyInputEventHandler PreNotifyInput;
+        public event PreProcessInputEventHandler PreProcessInput;
+        public void PopMenuMode(PresentationSource menuSite);
+        public bool ProcessInput(InputEventArgs input);
+        public void PushMenuMode(PresentationSource menuSite);
+    }
+    public class InputMethod : DispatcherObject {
+        public static readonly DependencyProperty InputScopeProperty;
+        public static readonly DependencyProperty IsInputMethodEnabledProperty;
+        public static readonly DependencyProperty IsInputMethodSuspendedProperty;
+        public static readonly DependencyProperty PreferredImeConversionModeProperty;
+        public static readonly DependencyProperty PreferredImeSentenceModeProperty;
+        public static readonly DependencyProperty PreferredImeStateProperty;
+        public bool CanShowConfigurationUI { get; }
+        public bool CanShowRegisterWordUI { get; }
+        public static InputMethod Current { get; }
+        public InputMethodState HandwritingState { get; set; }
+        public ImeConversionModeValues ImeConversionMode { get; set; }
+        public ImeSentenceModeValues ImeSentenceMode { get; set; }
+        public InputMethodState ImeState { get; set; }
+        public InputMethodState MicrophoneState { get; set; }
+        public SpeechMode SpeechMode { get; set; }
+        public event InputMethodStateChangedEventHandler StateChanged;
+        public static InputScope GetInputScope(DependencyObject target);
+        public static bool GetIsInputMethodEnabled(DependencyObject target);
+        public static bool GetIsInputMethodSuspended(DependencyObject target);
+        public static ImeConversionModeValues GetPreferredImeConversionMode(DependencyObject target);
+        public static ImeSentenceModeValues GetPreferredImeSentenceMode(DependencyObject target);
+        public static InputMethodState GetPreferredImeState(DependencyObject target);
+        public static void SetInputScope(DependencyObject target, InputScope value);
+        public static void SetIsInputMethodEnabled(DependencyObject target, bool value);
+        public static void SetIsInputMethodSuspended(DependencyObject target, bool value);
+        public static void SetPreferredImeConversionMode(DependencyObject target, ImeConversionModeValues value);
+        public static void SetPreferredImeSentenceMode(DependencyObject target, ImeSentenceModeValues value);
+        public static void SetPreferredImeState(DependencyObject target, InputMethodState value);
+        public void ShowConfigureUI();
+        public void ShowConfigureUI(UIElement element);
+        public void ShowRegisterWordUI();
+        public void ShowRegisterWordUI(string registeredText);
+        public void ShowRegisterWordUI(UIElement element, string registeredText);
+    }
+    public enum InputMethodState {
+        DoNotCare = 2,
+        Off = 0,
+        On = 1,
+    }
+    public class InputMethodStateChangedEventArgs : EventArgs {
+        public bool IsHandwritingStateChanged { get; }
+        public bool IsImeConversionModeChanged { get; }
+        public bool IsImeSentenceModeChanged { get; }
+        public bool IsImeStateChanged { get; }
+        public bool IsMicrophoneStateChanged { get; }
+        public bool IsSpeechModeChanged { get; }
+    }
+    public delegate void InputMethodStateChangedEventHandler(object sender, InputMethodStateChangedEventArgs e);
+    public enum InputMode {
+        Foreground = 0,
+        Sink = 1,
+    }
+    public class InputScope {
+        public InputScope();
+        public IList Names { get; }
+        public IList PhraseList { get; }
+        public string RegularExpression { get; set; }
+        public string SrgsMarkup { get; set; }
+    }
+    public class InputScopeConverter : TypeConverter {
+        public InputScopeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class InputScopeName : IAddChild {
+        public InputScopeName();
+        public InputScopeName(InputScopeNameValue nameValue);
+        public InputScopeNameValue NameValue { get; set; }
+        public void AddChild(object value);
+        public void AddText(string name);
+    }
+    public class InputScopeNameConverter : TypeConverter {
+        public InputScopeNameConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum InputScopeNameValue {
+        AddressCity = 17,
+        AddressCountryName = 18,
+        AddressCountryShortName = 19,
+        AddressStateOrProvince = 16,
+        AddressStreet = 15,
+        AlphanumericFullWidth = 41,
+        AlphanumericHalfWidth = 40,
+        Bopomofo = 43,
+        CurrencyAmount = 21,
+        CurrencyAmountAndSymbol = 20,
+        CurrencyChinese = 42,
+        Date = 22,
+        DateDay = 24,
+        DateDayName = 27,
+        DateMonth = 23,
+        DateMonthName = 26,
+        DateYear = 25,
+        Default = 0,
+        Digits = 28,
+        EmailSmtpAddress = 5,
+        EmailUserName = 4,
+        FileName = 3,
+        FullFilePath = 2,
+        Hanja = 47,
+        Hiragana = 44,
+        KatakanaFullWidth = 46,
+        KatakanaHalfWidth = 45,
+        LogOnName = 6,
+        Number = 29,
+        NumberFullWidth = 39,
+        OneChar = 30,
+        Password = 31,
+        PersonalFullName = 7,
+        PersonalGivenName = 9,
+        PersonalMiddleName = 10,
+        PersonalNamePrefix = 8,
+        PersonalNameSuffix = 12,
+        PersonalSurname = 11,
+        PhraseList = -1,
+        PostalAddress = 13,
+        PostalCode = 14,
+        RegularExpression = -2,
+        Srgs = -3,
+        TelephoneAreaCode = 34,
+        TelephoneCountryCode = 33,
+        TelephoneLocalNumber = 35,
+        TelephoneNumber = 32,
+        Time = 36,
+        TimeHour = 37,
+        TimeMinorSec = 38,
+        Url = 1,
+        Xml = -4,
+    }
+    public class InputScopePhrase : IAddChild {
+        public InputScopePhrase();
+        public InputScopePhrase(string name);
+        public string Name { get; set; }
+        public void AddChild(object value);
+        public void AddText(string name);
+    }
+    public enum InputType {
+        Command = 5,
+        Hid = 3,
+        Keyboard = 0,
+        Mouse = 1,
+        Stylus = 2,
+        Text = 4,
+    }
+    public enum Key {
+        A = 44,
+        AbntC1 = 147,
+        AbntC2 = 148,
+        Add = 85,
+        Apps = 72,
+        Attn = 163,
+        B = 45,
+        Back = 2,
+        BrowserBack = 122,
+        BrowserFavorites = 127,
+        BrowserForward = 123,
+        BrowserHome = 128,
+        BrowserRefresh = 124,
+        BrowserSearch = 126,
+        BrowserStop = 125,
+        C = 46,
+        Cancel = 1,
+        Capital = 8,
+        CapsLock = 8,
+        Clear = 5,
+        CrSel = 164,
+        D = 47,
+        D0 = 34,
+        D1 = 35,
+        D2 = 36,
+        D3 = 37,
+        D4 = 38,
+        D5 = 39,
+        D6 = 40,
+        D7 = 41,
+        D8 = 42,
+        D9 = 43,
+        DbeAlphanumeric = 157,
+        DbeCodeInput = 167,
+        DbeDbcsChar = 161,
+        DbeDetermineString = 169,
+        DbeEnterDialogConversionMode = 170,
+        DbeEnterImeConfigureMode = 165,
+        DbeEnterWordRegisterMode = 164,
+        DbeFlushString = 166,
+        DbeHiragana = 159,
+        DbeKatakana = 158,
+        DbeNoCodeInput = 168,
+        DbeNoRoman = 163,
+        DbeRoman = 162,
+        DbeSbcsChar = 160,
+        DeadCharProcessed = 172,
+        Decimal = 88,
+        Delete = 32,
+        Divide = 89,
+        Down = 26,
+        E = 48,
+        End = 21,
+        Enter = 6,
+        EraseEof = 166,
+        Escape = 13,
+        Execute = 29,
+        ExSel = 165,
+        F = 49,
+        F1 = 90,
+        F10 = 99,
+        F11 = 100,
+        F12 = 101,
+        F13 = 102,
+        F14 = 103,
+        F15 = 104,
+        F16 = 105,
+        F17 = 106,
+        F18 = 107,
+        F19 = 108,
+        F2 = 91,
+        F20 = 109,
+        F21 = 110,
+        F22 = 111,
+        F23 = 112,
+        F24 = 113,
+        F3 = 92,
+        F4 = 93,
+        F5 = 94,
+        F6 = 95,
+        F7 = 96,
+        F8 = 97,
+        F9 = 98,
+        FinalMode = 11,
+        G = 50,
+        H = 51,
+        HangulMode = 9,
+        HanjaMode = 12,
+        Help = 33,
+        Home = 22,
+        I = 52,
+        ImeAccept = 16,
+        ImeConvert = 14,
+        ImeModeChange = 17,
+        ImeNonConvert = 15,
+        ImeProcessed = 155,
+        Insert = 31,
+        J = 53,
+        JunjaMode = 10,
+        K = 54,
+        KanaMode = 9,
+        KanjiMode = 12,
+        L = 55,
+        LaunchApplication1 = 138,
+        LaunchApplication2 = 139,
+        LaunchMail = 136,
+        Left = 23,
+        LeftAlt = 120,
+        LeftCtrl = 118,
+        LeftShift = 116,
+        LineFeed = 4,
+        LWin = 70,
+        M = 56,
+        MediaNextTrack = 132,
+        MediaPlayPause = 135,
+        MediaPreviousTrack = 133,
+        MediaStop = 134,
+        Multiply = 84,
+        N = 57,
+        Next = 20,
+        NoName = 169,
+        None = 0,
+        NumLock = 114,
+        NumPad0 = 74,
+        NumPad1 = 75,
+        NumPad2 = 76,
+        NumPad3 = 77,
+        NumPad4 = 78,
+        NumPad5 = 79,
+        NumPad6 = 80,
+        NumPad7 = 81,
+        NumPad8 = 82,
+        NumPad9 = 83,
+        O = 58,
+        Oem1 = 140,
+        Oem102 = 154,
+        Oem2 = 145,
+        Oem3 = 146,
+        Oem4 = 149,
+        Oem5 = 150,
+        Oem6 = 151,
+        Oem7 = 152,
+        Oem8 = 153,
+        OemAttn = 157,
+        OemAuto = 160,
+        OemBackslash = 154,
+        OemBackTab = 162,
+        OemClear = 171,
+        OemCloseBrackets = 151,
+        OemComma = 142,
+        OemCopy = 159,
+        OemEnlw = 161,
+        OemFinish = 158,
+        OemMinus = 143,
+        OemOpenBrackets = 149,
+        OemPeriod = 144,
+        OemPipe = 150,
+        OemPlus = 141,
+        OemQuestion = 145,
+        OemQuotes = 152,
+        OemSemicolon = 140,
+        OemTilde = 146,
+        P = 59,
+        Pa1 = 170,
+        PageDown = 20,
+        PageUp = 19,
+        Pause = 7,
+        Play = 167,
+        Print = 28,
+        PrintScreen = 30,
+        Prior = 19,
+        Q = 60,
+        R = 61,
+        Return = 6,
+        Right = 25,
+        RightAlt = 121,
+        RightCtrl = 119,
+        RightShift = 117,
+        RWin = 71,
+        S = 62,
+        Scroll = 115,
+        Select = 27,
+        SelectMedia = 137,
+        Separator = 86,
+        Sleep = 73,
+        Snapshot = 30,
+        Space = 18,
+        Subtract = 87,
+        System = 156,
+        T = 63,
+        Tab = 3,
+        U = 64,
+        Up = 24,
+        V = 65,
+        VolumeDown = 130,
+        VolumeMute = 129,
+        VolumeUp = 131,
+        W = 66,
+        X = 67,
+        Y = 68,
+        Z = 69,
+        Zoom = 168,
+    }
+    public class KeyBinding : InputBinding {
+        public static readonly DependencyProperty KeyProperty;
+        public static readonly DependencyProperty ModifiersProperty;
+        public KeyBinding();
+        public KeyBinding(ICommand command, Key key, ModifierKeys modifiers);
+        public KeyBinding(ICommand command, KeyGesture gesture);
+        public override InputGesture Gesture { get; set; }
+        public Key Key { get; set; }
+        public ModifierKeys Modifiers { get; set; }
+        protected override Freezable CreateInstanceCore();
+    }
+    public static class Keyboard {
+        public static readonly RoutedEvent GotKeyboardFocusEvent;
+        public static readonly RoutedEvent KeyboardInputProviderAcquireFocusEvent;
+        public static readonly RoutedEvent KeyDownEvent;
+        public static readonly RoutedEvent KeyUpEvent;
+        public static readonly RoutedEvent LostKeyboardFocusEvent;
+        public static readonly RoutedEvent PreviewGotKeyboardFocusEvent;
+        public static readonly RoutedEvent PreviewKeyboardInputProviderAcquireFocusEvent;
+        public static readonly RoutedEvent PreviewKeyDownEvent;
+        public static readonly RoutedEvent PreviewKeyUpEvent;
+        public static readonly RoutedEvent PreviewLostKeyboardFocusEvent;
+        public static RestoreFocusMode DefaultRestoreFocusMode { get; set; }
+        public static IInputElement FocusedElement { get; }
+        public static ModifierKeys Modifiers { get; }
+        public static KeyboardDevice PrimaryDevice { get; }
+        public static void AddGotKeyboardFocusHandler(DependencyObject element, KeyboardFocusChangedEventHandler handler);
+        public static void AddKeyboardInputProviderAcquireFocusHandler(DependencyObject element, KeyboardInputProviderAcquireFocusEventHandler handler);
+        public static void AddKeyDownHandler(DependencyObject element, KeyEventHandler handler);
+        public static void AddKeyUpHandler(DependencyObject element, KeyEventHandler handler);
+        public static void AddLostKeyboardFocusHandler(DependencyObject element, KeyboardFocusChangedEventHandler handler);
+        public static void AddPreviewGotKeyboardFocusHandler(DependencyObject element, KeyboardFocusChangedEventHandler handler);
+        public static void AddPreviewKeyboardInputProviderAcquireFocusHandler(DependencyObject element, KeyboardInputProviderAcquireFocusEventHandler handler);
+        public static void AddPreviewKeyDownHandler(DependencyObject element, KeyEventHandler handler);
+        public static void AddPreviewKeyUpHandler(DependencyObject element, KeyEventHandler handler);
+        public static void AddPreviewLostKeyboardFocusHandler(DependencyObject element, KeyboardFocusChangedEventHandler handler);
+        public static void ClearFocus();
+        public static IInputElement Focus(IInputElement element);
+        public static KeyStates GetKeyStates(Key key);
+        public static bool IsKeyDown(Key key);
+        public static bool IsKeyToggled(Key key);
+        public static bool IsKeyUp(Key key);
+        public static void RemoveGotKeyboardFocusHandler(DependencyObject element, KeyboardFocusChangedEventHandler handler);
+        public static void RemoveKeyboardInputProviderAcquireFocusHandler(DependencyObject element, KeyboardInputProviderAcquireFocusEventHandler handler);
+        public static void RemoveKeyDownHandler(DependencyObject element, KeyEventHandler handler);
+        public static void RemoveKeyUpHandler(DependencyObject element, KeyEventHandler handler);
+        public static void RemoveLostKeyboardFocusHandler(DependencyObject element, KeyboardFocusChangedEventHandler handler);
+        public static void RemovePreviewGotKeyboardFocusHandler(DependencyObject element, KeyboardFocusChangedEventHandler handler);
+        public static void RemovePreviewKeyboardInputProviderAcquireFocusHandler(DependencyObject element, KeyboardInputProviderAcquireFocusEventHandler handler);
+        public static void RemovePreviewKeyDownHandler(DependencyObject element, KeyEventHandler handler);
+        public static void RemovePreviewKeyUpHandler(DependencyObject element, KeyEventHandler handler);
+        public static void RemovePreviewLostKeyboardFocusHandler(DependencyObject element, KeyboardFocusChangedEventHandler handler);
+    }
+    public abstract class KeyboardDevice : InputDevice {
+        protected KeyboardDevice(InputManager inputManager);
+        public override PresentationSource ActiveSource { get; }
+        public RestoreFocusMode DefaultRestoreFocusMode { get; set; }
+        public IInputElement FocusedElement { get; }
+        public ModifierKeys Modifiers { get; }
+        public override IInputElement Target { get; }
+        public void ClearFocus();
+        public IInputElement Focus(IInputElement element);
+        public KeyStates GetKeyStates(Key key);
+        protected abstract KeyStates GetKeyStatesFromSystem(Key key);
+        public bool IsKeyDown(Key key);
+        public bool IsKeyToggled(Key key);
+        public bool IsKeyUp(Key key);
+    }
+    public class KeyboardEventArgs : InputEventArgs {
+        public KeyboardEventArgs(KeyboardDevice keyboard, int timestamp);
+        public KeyboardDevice KeyboardDevice { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void KeyboardEventHandler(object sender, KeyboardEventArgs e);
+    public class KeyboardFocusChangedEventArgs : KeyboardEventArgs {
+        public KeyboardFocusChangedEventArgs(KeyboardDevice keyboard, int timestamp, IInputElement oldFocus, IInputElement newFocus);
+        public IInputElement NewFocus { get; }
+        public IInputElement OldFocus { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void KeyboardFocusChangedEventHandler(object sender, KeyboardFocusChangedEventArgs e);
+    public class KeyboardInputProviderAcquireFocusEventArgs : KeyboardEventArgs {
+        public KeyboardInputProviderAcquireFocusEventArgs(KeyboardDevice keyboard, int timestamp, bool focusAcquired);
+        public bool FocusAcquired { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void KeyboardInputProviderAcquireFocusEventHandler(object sender, KeyboardInputProviderAcquireFocusEventArgs e);
+    public sealed class KeyboardNavigation {
+        public static readonly DependencyProperty AcceptsReturnProperty;
+        public static readonly DependencyProperty ControlTabNavigationProperty;
+        public static readonly DependencyProperty DirectionalNavigationProperty;
+        public static readonly DependencyProperty IsTabStopProperty;
+        public static readonly DependencyProperty TabIndexProperty;
+        public static readonly DependencyProperty TabNavigationProperty;
+        public static bool GetAcceptsReturn(DependencyObject element);
+        public static KeyboardNavigationMode GetControlTabNavigation(DependencyObject element);
+        public static KeyboardNavigationMode GetDirectionalNavigation(DependencyObject element);
+        public static bool GetIsTabStop(DependencyObject element);
+        public static int GetTabIndex(DependencyObject element);
+        public static KeyboardNavigationMode GetTabNavigation(DependencyObject element);
+        public static void SetAcceptsReturn(DependencyObject element, bool enabled);
+        public static void SetControlTabNavigation(DependencyObject element, KeyboardNavigationMode mode);
+        public static void SetDirectionalNavigation(DependencyObject element, KeyboardNavigationMode mode);
+        public static void SetIsTabStop(DependencyObject element, bool isTabStop);
+        public static void SetTabIndex(DependencyObject element, int index);
+        public static void SetTabNavigation(DependencyObject element, KeyboardNavigationMode mode);
+    }
+    public enum KeyboardNavigationMode {
+        Contained = 4,
+        Continue = 0,
+        Cycle = 2,
+        Local = 5,
+        None = 3,
+        Once = 1,
+    }
+    public class KeyConverter : TypeConverter {
+        public KeyConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class KeyEventArgs : KeyboardEventArgs {
+        public KeyEventArgs(KeyboardDevice keyboard, PresentationSource inputSource, int timestamp, Key key);
+        public Key DeadCharProcessedKey { get; }
+        public Key ImeProcessedKey { get; }
+        public PresentationSource InputSource { get; }
+        public bool IsDown { get; }
+        public bool IsRepeat { get; }
+        public bool IsToggled { get; }
+        public bool IsUp { get; }
+        public Key Key { get; }
+        public KeyStates KeyStates { get; }
+        public Key SystemKey { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void KeyEventHandler(object sender, KeyEventArgs e);
+    public class KeyGesture : InputGesture {
+        public KeyGesture(Key key);
+        public KeyGesture(Key key, ModifierKeys modifiers);
+        public KeyGesture(Key key, ModifierKeys modifiers, string displayString);
+        public string DisplayString { get; }
+        public Key Key { get; }
+        public ModifierKeys Modifiers { get; }
+        public string GetDisplayStringForCulture(CultureInfo culture);
+        public override bool Matches(object targetElement, InputEventArgs inputEventArgs);
+    }
+    public class KeyGestureConverter : TypeConverter {
+        public KeyGestureConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class KeyGestureValueSerializer : ValueSerializer {
+        public KeyGestureValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public static class KeyInterop {
+        public static Key KeyFromVirtualKey(int virtualKey);
+        public static int VirtualKeyFromKey(Key key);
+    }
+    public enum KeyStates : byte {
+        Down = (byte)1,
+        None = (byte)0,
+        Toggled = (byte)2,
+    }
+    public class KeyValueSerializer : ValueSerializer {
+        public KeyValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public static class Manipulation {
+        public static void AddManipulator(UIElement element, IManipulator manipulator);
+        public static void CompleteManipulation(UIElement element);
+        public static IInputElement GetManipulationContainer(UIElement element);
+        public static ManipulationModes GetManipulationMode(UIElement element);
+        public static ManipulationPivot GetManipulationPivot(UIElement element);
+        public static bool IsManipulationActive(UIElement element);
+        public static void RemoveManipulator(UIElement element, IManipulator manipulator);
+        public static void SetManipulationContainer(UIElement element, IInputElement container);
+        public static void SetManipulationMode(UIElement element, ManipulationModes mode);
+        public static void SetManipulationParameter(UIElement element, ManipulationParameters2D parameter);
+        public static void SetManipulationPivot(UIElement element, ManipulationPivot pivot);
+        public static void StartInertia(UIElement element);
+    }
+    public sealed class ManipulationBoundaryFeedbackEventArgs : InputEventArgs {
+        public ManipulationDelta BoundaryFeedback { get; private set; }
+        public IInputElement ManipulationContainer { get; private set; }
+        public IEnumerable<IManipulator> Manipulators { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public sealed class ManipulationCompletedEventArgs : InputEventArgs {
+        public ManipulationVelocities FinalVelocities { get; private set; }
+        public bool IsInertial { get; private set; }
+        public IInputElement ManipulationContainer { get; private set; }
+        public Point ManipulationOrigin { get; private set; }
+        public IEnumerable<IManipulator> Manipulators { get; }
+        public ManipulationDelta TotalManipulation { get; private set; }
+        public bool Cancel();
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public class ManipulationDelta {
+        public ManipulationDelta(Vector translation, double rotation, Vector scale, Vector expansion);
+        public Vector Expansion { get; private set; }
+        public double Rotation { get; private set; }
+        public Vector Scale { get; private set; }
+        public Vector Translation { get; private set; }
+    }
+    public sealed class ManipulationDeltaEventArgs : InputEventArgs {
+        public ManipulationDelta CumulativeManipulation { get; private set; }
+        public ManipulationDelta DeltaManipulation { get; private set; }
+        public bool IsInertial { get; private set; }
+        public IInputElement ManipulationContainer { get; private set; }
+        public Point ManipulationOrigin { get; private set; }
+        public IEnumerable<IManipulator> Manipulators { get; }
+        public ManipulationVelocities Velocities { get; private set; }
+        public bool Cancel();
+        public void Complete();
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+        public void ReportBoundaryFeedback(ManipulationDelta unusedManipulation);
+        public void StartInertia();
+    }
+    public sealed class ManipulationInertiaStartingEventArgs : InputEventArgs {
+        public InertiaExpansionBehavior ExpansionBehavior { get; set; }
+        public ManipulationVelocities InitialVelocities { get; private set; }
+        public IInputElement ManipulationContainer { get; private set; }
+        public Point ManipulationOrigin { get; set; }
+        public IEnumerable<IManipulator> Manipulators { get; }
+        public InertiaRotationBehavior RotationBehavior { get; set; }
+        public InertiaTranslationBehavior TranslationBehavior { get; set; }
+        public bool Cancel();
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+        public void SetInertiaParameter(InertiaParameters2D parameter);
+    }
+    public enum ManipulationModes {
+        All = 15,
+        None = 0,
+        Rotate = 4,
+        Scale = 8,
+        Translate = 3,
+        TranslateX = 1,
+        TranslateY = 2,
+    }
+    public class ManipulationPivot {
+        public ManipulationPivot();
+        public ManipulationPivot(Point center, double radius);
+        public Point Center { get; set; }
+        public double Radius { get; set; }
+    }
+    public sealed class ManipulationStartedEventArgs : InputEventArgs {
+        public IInputElement ManipulationContainer { get; private set; }
+        public Point ManipulationOrigin { get; private set; }
+        public IEnumerable<IManipulator> Manipulators { get; }
+        public bool Cancel();
+        public void Complete();
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public sealed class ManipulationStartingEventArgs : InputEventArgs {
+        public bool IsSingleTouchEnabled { get; set; }
+        public IInputElement ManipulationContainer { get; set; }
+        public IEnumerable<IManipulator> Manipulators { get; }
+        public ManipulationModes Mode { get; set; }
+        public ManipulationPivot Pivot { get; set; }
+        public bool Cancel();
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+        public void SetManipulationParameter(ManipulationParameters2D parameter);
+    }
+    public class ManipulationVelocities {
+        public ManipulationVelocities(Vector linearVelocity, double angularVelocity, Vector expansionVelocity);
+        public double AngularVelocity { get; private set; }
+        public Vector ExpansionVelocity { get; private set; }
+        public Vector LinearVelocity { get; private set; }
+    }
+    public static class MediaCommands {
+        public static RoutedUICommand BoostBass { get; }
+        public static RoutedUICommand ChannelDown { get; }
+        public static RoutedUICommand ChannelUp { get; }
+        public static RoutedUICommand DecreaseBass { get; }
+        public static RoutedUICommand DecreaseMicrophoneVolume { get; }
+        public static RoutedUICommand DecreaseTreble { get; }
+        public static RoutedUICommand DecreaseVolume { get; }
+        public static RoutedUICommand FastForward { get; }
+        public static RoutedUICommand IncreaseBass { get; }
+        public static RoutedUICommand IncreaseMicrophoneVolume { get; }
+        public static RoutedUICommand IncreaseTreble { get; }
+        public static RoutedUICommand IncreaseVolume { get; }
+        public static RoutedUICommand MuteMicrophoneVolume { get; }
+        public static RoutedUICommand MuteVolume { get; }
+        public static RoutedUICommand NextTrack { get; }
+        public static RoutedUICommand Pause { get; }
+        public static RoutedUICommand Play { get; }
+        public static RoutedUICommand PreviousTrack { get; }
+        public static RoutedUICommand Record { get; }
+        public static RoutedUICommand Rewind { get; }
+        public static RoutedUICommand Select { get; }
+        public static RoutedUICommand Stop { get; }
+        public static RoutedUICommand ToggleMicrophoneOnOff { get; }
+        public static RoutedUICommand TogglePlayPause { get; }
+    }
+    public enum ModifierKeys {
+        Alt = 1,
+        Control = 2,
+        None = 0,
+        Shift = 4,
+        Windows = 8,
+    }
+    public class ModifierKeysConverter : TypeConverter {
+        public ModifierKeysConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public static bool IsDefinedModifierKeys(ModifierKeys modifierKeys);
+    }
+    public class ModifierKeysValueSerializer : ValueSerializer {
+        public ModifierKeysValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public static class Mouse {
+        public const int MouseWheelDeltaForOneLine = 120;
+        public static readonly RoutedEvent GotMouseCaptureEvent;
+        public static readonly RoutedEvent LostMouseCaptureEvent;
+        public static readonly RoutedEvent MouseDownEvent;
+        public static readonly RoutedEvent MouseEnterEvent;
+        public static readonly RoutedEvent MouseLeaveEvent;
+        public static readonly RoutedEvent MouseMoveEvent;
+        public static readonly RoutedEvent MouseUpEvent;
+        public static readonly RoutedEvent MouseWheelEvent;
+        public static readonly RoutedEvent PreviewMouseDownEvent;
+        public static readonly RoutedEvent PreviewMouseDownOutsideCapturedElementEvent;
+        public static readonly RoutedEvent PreviewMouseMoveEvent;
+        public static readonly RoutedEvent PreviewMouseUpEvent;
+        public static readonly RoutedEvent PreviewMouseUpOutsideCapturedElementEvent;
+        public static readonly RoutedEvent PreviewMouseWheelEvent;
+        public static readonly RoutedEvent QueryCursorEvent;
+        public static IInputElement Captured { get; }
+        public static IInputElement DirectlyOver { get; }
+        public static MouseButtonState LeftButton { get; }
+        public static MouseButtonState MiddleButton { get; }
+        public static Cursor OverrideCursor { get; set; }
+        public static MouseDevice PrimaryDevice { get; }
+        public static MouseButtonState RightButton { get; }
+        public static MouseButtonState XButton1 { get; }
+        public static MouseButtonState XButton2 { get; }
+        public static void AddGotMouseCaptureHandler(DependencyObject element, MouseEventHandler handler);
+        public static void AddLostMouseCaptureHandler(DependencyObject element, MouseEventHandler handler);
+        public static void AddMouseDownHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void AddMouseEnterHandler(DependencyObject element, MouseEventHandler handler);
+        public static void AddMouseLeaveHandler(DependencyObject element, MouseEventHandler handler);
+        public static void AddMouseMoveHandler(DependencyObject element, MouseEventHandler handler);
+        public static void AddMouseUpHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void AddMouseWheelHandler(DependencyObject element, MouseWheelEventHandler handler);
+        public static void AddPreviewMouseDownHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void AddPreviewMouseDownOutsideCapturedElementHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void AddPreviewMouseMoveHandler(DependencyObject element, MouseEventHandler handler);
+        public static void AddPreviewMouseUpHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void AddPreviewMouseUpOutsideCapturedElementHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void AddPreviewMouseWheelHandler(DependencyObject element, MouseWheelEventHandler handler);
+        public static void AddQueryCursorHandler(DependencyObject element, QueryCursorEventHandler handler);
+        public static bool Capture(IInputElement element);
+        public static bool Capture(IInputElement element, CaptureMode captureMode);
+        public static int GetIntermediatePoints(IInputElement relativeTo, Point[] points);
+        public static Point GetPosition(IInputElement relativeTo);
+        public static void RemoveGotMouseCaptureHandler(DependencyObject element, MouseEventHandler handler);
+        public static void RemoveLostMouseCaptureHandler(DependencyObject element, MouseEventHandler handler);
+        public static void RemoveMouseDownHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void RemoveMouseEnterHandler(DependencyObject element, MouseEventHandler handler);
+        public static void RemoveMouseLeaveHandler(DependencyObject element, MouseEventHandler handler);
+        public static void RemoveMouseMoveHandler(DependencyObject element, MouseEventHandler handler);
+        public static void RemoveMouseUpHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void RemoveMouseWheelHandler(DependencyObject element, MouseWheelEventHandler handler);
+        public static void RemovePreviewMouseDownHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void RemovePreviewMouseDownOutsideCapturedElementHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void RemovePreviewMouseMoveHandler(DependencyObject element, MouseEventHandler handler);
+        public static void RemovePreviewMouseUpHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void RemovePreviewMouseUpOutsideCapturedElementHandler(DependencyObject element, MouseButtonEventHandler handler);
+        public static void RemovePreviewMouseWheelHandler(DependencyObject element, MouseWheelEventHandler handler);
+        public static void RemoveQueryCursorHandler(DependencyObject element, QueryCursorEventHandler handler);
+        public static bool SetCursor(Cursor cursor);
+        public static void Synchronize();
+        public static void UpdateCursor();
+    }
+    public enum MouseAction : byte {
+        LeftClick = (byte)1,
+        LeftDoubleClick = (byte)5,
+        MiddleClick = (byte)3,
+        MiddleDoubleClick = (byte)7,
+        None = (byte)0,
+        RightClick = (byte)2,
+        RightDoubleClick = (byte)6,
+        WheelClick = (byte)4,
+    }
+    public class MouseActionConverter : TypeConverter {
+        public MouseActionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class MouseActionValueSerializer : ValueSerializer {
+        public MouseActionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class MouseBinding : InputBinding {
+        public static readonly DependencyProperty MouseActionProperty;
+        public MouseBinding();
+        public MouseBinding(ICommand command, MouseGesture gesture);
+        public override InputGesture Gesture { get; set; }
+        public MouseAction MouseAction { get; set; }
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+    }
+    public enum MouseButton {
+        Left = 0,
+        Middle = 1,
+        Right = 2,
+        XButton1 = 3,
+        XButton2 = 4,
+    }
+    public class MouseButtonEventArgs : MouseEventArgs {
+        public MouseButtonEventArgs(MouseDevice mouse, int timestamp, MouseButton button);
+        public MouseButtonEventArgs(MouseDevice mouse, int timestamp, MouseButton button, StylusDevice stylusDevice);
+        public MouseButtonState ButtonState { get; }
+        public MouseButton ChangedButton { get; }
+        public int ClickCount { get; internal set; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void MouseButtonEventHandler(object sender, MouseButtonEventArgs e);
+    public enum MouseButtonState {
+        Pressed = 1,
+        Released = 0,
+    }
+    public abstract class MouseDevice : InputDevice {
+        public override PresentationSource ActiveSource { get; }
+        public IInputElement Captured { get; }
+        public IInputElement DirectlyOver { get; }
+        public MouseButtonState LeftButton { get; }
+        public MouseButtonState MiddleButton { get; }
+        public Cursor OverrideCursor { get; set; }
+        public MouseButtonState RightButton { get; }
+        public override IInputElement Target { get; }
+        public MouseButtonState XButton1 { get; }
+        public MouseButtonState XButton2 { get; }
+        public bool Capture(IInputElement element);
+        public bool Capture(IInputElement element, CaptureMode captureMode);
+        protected MouseButtonState GetButtonState(MouseButton mouseButton);
+        protected Point GetClientPosition();
+        protected Point GetClientPosition(PresentationSource presentationSource);
+        public Point GetPosition(IInputElement relativeTo);
+        protected Point GetScreenPosition();
+        public bool SetCursor(Cursor cursor);
+        public void Synchronize();
+        public void UpdateCursor();
+    }
+    public class MouseEventArgs : InputEventArgs {
+        public MouseEventArgs(MouseDevice mouse, int timestamp);
+        public MouseEventArgs(MouseDevice mouse, int timestamp, StylusDevice stylusDevice);
+        public MouseButtonState LeftButton { get; }
+        public MouseButtonState MiddleButton { get; }
+        public MouseDevice MouseDevice { get; }
+        public MouseButtonState RightButton { get; }
+        public StylusDevice StylusDevice { get; }
+        public MouseButtonState XButton1 { get; }
+        public MouseButtonState XButton2 { get; }
+        public Point GetPosition(IInputElement relativeTo);
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void MouseEventHandler(object sender, MouseEventArgs e);
+    public class MouseGesture : InputGesture {
+        public MouseGesture();
+        public MouseGesture(MouseAction mouseAction);
+        public MouseGesture(MouseAction mouseAction, ModifierKeys modifiers);
+        public ModifierKeys Modifiers { get; set; }
+        public MouseAction MouseAction { get; set; }
+        public override bool Matches(object targetElement, InputEventArgs inputEventArgs);
+    }
+    public class MouseGestureConverter : TypeConverter {
+        public MouseGestureConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class MouseGestureValueSerializer : ValueSerializer {
+        public MouseGestureValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class MouseWheelEventArgs : MouseEventArgs {
+        public MouseWheelEventArgs(MouseDevice mouse, int timestamp, int delta);
+        public int Delta { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void MouseWheelEventHandler(object sender, MouseWheelEventArgs e);
+    public static class NavigationCommands {
+        public static RoutedUICommand BrowseBack { get; }
+        public static RoutedUICommand BrowseForward { get; }
+        public static RoutedUICommand BrowseHome { get; }
+        public static RoutedUICommand BrowseStop { get; }
+        public static RoutedUICommand DecreaseZoom { get; }
+        public static RoutedUICommand Favorites { get; }
+        public static RoutedUICommand FirstPage { get; }
+        public static RoutedUICommand GoToPage { get; }
+        public static RoutedUICommand IncreaseZoom { get; }
+        public static RoutedUICommand LastPage { get; }
+        public static RoutedUICommand NavigateJournal { get; }
+        public static RoutedUICommand NextPage { get; }
+        public static RoutedUICommand PreviousPage { get; }
+        public static RoutedUICommand Refresh { get; }
+        public static RoutedUICommand Search { get; }
+        public static RoutedUICommand Zoom { get; }
+    }
+    public class NotifyInputEventArgs : EventArgs {
+        public InputManager InputManager { get; }
+        public StagingAreaInputItem StagingItem { get; }
+    }
+    public delegate void NotifyInputEventHandler(object sender, NotifyInputEventArgs e);
+    public sealed class PreProcessInputEventArgs : ProcessInputEventArgs {
+        public bool Canceled { get; }
+        public void Cancel();
+    }
+    public delegate void PreProcessInputEventHandler(object sender, PreProcessInputEventArgs e);
+    public class ProcessInputEventArgs : NotifyInputEventArgs {
+        public StagingAreaInputItem PeekInput();
+        public StagingAreaInputItem PopInput();
+        public StagingAreaInputItem PushInput(InputEventArgs input, StagingAreaInputItem promote);
+        public StagingAreaInputItem PushInput(StagingAreaInputItem input);
+    }
+    public delegate void ProcessInputEventHandler(object sender, ProcessInputEventArgs e);
+    public class QueryCursorEventArgs : MouseEventArgs {
+        public QueryCursorEventArgs(MouseDevice mouse, int timestamp);
+        public QueryCursorEventArgs(MouseDevice mouse, int timestamp, StylusDevice stylusDevice);
+        public Cursor Cursor { get; set; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void QueryCursorEventHandler(object sender, QueryCursorEventArgs e);
+    public enum RestoreFocusMode {
+        Auto = 0,
+        None = 1,
+    }
+    public class RoutedCommand : ICommand {
+        public RoutedCommand();
+        public RoutedCommand(string name, Type ownerType);
+        public RoutedCommand(string name, Type ownerType, InputGestureCollection inputGestures);
+        public InputGestureCollection InputGestures { get; }
+        public string Name { get; }
+        public Type OwnerType { get; }
+        public event EventHandler CanExecuteChanged;
+        public bool CanExecute(object parameter, IInputElement target);
+        public void Execute(object parameter, IInputElement target);
+        bool System.Windows.Input.ICommand.CanExecute(object parameter);
+        void System.Windows.Input.ICommand.Execute(object parameter);
+    }
+    public class RoutedUICommand : RoutedCommand {
+        public RoutedUICommand();
+        public RoutedUICommand(string text, string name, Type ownerType);
+        public RoutedUICommand(string text, string name, Type ownerType, InputGestureCollection inputGestures);
+        public string Text { get; set; }
+    }
+    public enum SpeechMode {
+        Command = 1,
+        Dictation = 0,
+        Indeterminate = 2,
+    }
+    public class StagingAreaInputItem {
+        public InputEventArgs Input { get; }
+        public object GetData(object key);
+        public void SetData(object key, object value);
+    }
+    public static class Stylus {
+        public static readonly DependencyProperty IsFlicksEnabledProperty;
+        public static readonly DependencyProperty IsPressAndHoldEnabledProperty;
+        public static readonly DependencyProperty IsTapFeedbackEnabledProperty;
+        public static readonly DependencyProperty IsTouchFeedbackEnabledProperty;
+        public static readonly RoutedEvent GotStylusCaptureEvent;
+        public static readonly RoutedEvent LostStylusCaptureEvent;
+        public static readonly RoutedEvent PreviewStylusButtonDownEvent;
+        public static readonly RoutedEvent PreviewStylusButtonUpEvent;
+        public static readonly RoutedEvent PreviewStylusDownEvent;
+        public static readonly RoutedEvent PreviewStylusInAirMoveEvent;
+        public static readonly RoutedEvent PreviewStylusInRangeEvent;
+        public static readonly RoutedEvent PreviewStylusMoveEvent;
+        public static readonly RoutedEvent PreviewStylusOutOfRangeEvent;
+        public static readonly RoutedEvent PreviewStylusSystemGestureEvent;
+        public static readonly RoutedEvent PreviewStylusUpEvent;
+        public static readonly RoutedEvent StylusButtonDownEvent;
+        public static readonly RoutedEvent StylusButtonUpEvent;
+        public static readonly RoutedEvent StylusDownEvent;
+        public static readonly RoutedEvent StylusEnterEvent;
+        public static readonly RoutedEvent StylusInAirMoveEvent;
+        public static readonly RoutedEvent StylusInRangeEvent;
+        public static readonly RoutedEvent StylusLeaveEvent;
+        public static readonly RoutedEvent StylusMoveEvent;
+        public static readonly RoutedEvent StylusOutOfRangeEvent;
+        public static readonly RoutedEvent StylusSystemGestureEvent;
+        public static readonly RoutedEvent StylusUpEvent;
+        public static IInputElement Captured { get; }
+        public static StylusDevice CurrentStylusDevice { get; }
+        public static IInputElement DirectlyOver { get; }
+        public static void AddGotStylusCaptureHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddLostStylusCaptureHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddPreviewStylusButtonDownHandler(DependencyObject element, StylusButtonEventHandler handler);
+        public static void AddPreviewStylusButtonUpHandler(DependencyObject element, StylusButtonEventHandler handler);
+        public static void AddPreviewStylusDownHandler(DependencyObject element, StylusDownEventHandler handler);
+        public static void AddPreviewStylusInAirMoveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddPreviewStylusInRangeHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddPreviewStylusMoveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddPreviewStylusOutOfRangeHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddPreviewStylusSystemGestureHandler(DependencyObject element, StylusSystemGestureEventHandler handler);
+        public static void AddPreviewStylusUpHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddStylusButtonDownHandler(DependencyObject element, StylusButtonEventHandler handler);
+        public static void AddStylusButtonUpHandler(DependencyObject element, StylusButtonEventHandler handler);
+        public static void AddStylusDownHandler(DependencyObject element, StylusDownEventHandler handler);
+        public static void AddStylusEnterHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddStylusInAirMoveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddStylusInRangeHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddStylusLeaveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddStylusMoveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddStylusOutOfRangeHandler(DependencyObject element, StylusEventHandler handler);
+        public static void AddStylusSystemGestureHandler(DependencyObject element, StylusSystemGestureEventHandler handler);
+        public static void AddStylusUpHandler(DependencyObject element, StylusEventHandler handler);
+        public static bool Capture(IInputElement element);
+        public static bool Capture(IInputElement element, CaptureMode captureMode);
+        public static bool GetIsFlicksEnabled(DependencyObject element);
+        public static bool GetIsPressAndHoldEnabled(DependencyObject element);
+        public static bool GetIsTapFeedbackEnabled(DependencyObject element);
+        public static bool GetIsTouchFeedbackEnabled(DependencyObject element);
+        public static void RemoveGotStylusCaptureHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemoveLostStylusCaptureHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemovePreviewStylusButtonDownHandler(DependencyObject element, StylusButtonEventHandler handler);
+        public static void RemovePreviewStylusButtonUpHandler(DependencyObject element, StylusButtonEventHandler handler);
+        public static void RemovePreviewStylusDownHandler(DependencyObject element, StylusDownEventHandler handler);
+        public static void RemovePreviewStylusInAirMoveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemovePreviewStylusInRangeHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemovePreviewStylusMoveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemovePreviewStylusOutOfRangeHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemovePreviewStylusSystemGestureHandler(DependencyObject element, StylusSystemGestureEventHandler handler);
+        public static void RemovePreviewStylusUpHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemoveStylusButtonDownHandler(DependencyObject element, StylusButtonEventHandler handler);
+        public static void RemoveStylusButtonUpHandler(DependencyObject element, StylusButtonEventHandler handler);
+        public static void RemoveStylusDownHandler(DependencyObject element, StylusDownEventHandler handler);
+        public static void RemoveStylusEnterHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemoveStylusInAirMoveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemoveStylusInRangeHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemoveStylusLeaveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemoveStylusMoveHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemoveStylusOutOfRangeHandler(DependencyObject element, StylusEventHandler handler);
+        public static void RemoveStylusSystemGestureHandler(DependencyObject element, StylusSystemGestureEventHandler handler);
+        public static void RemoveStylusUpHandler(DependencyObject element, StylusEventHandler handler);
+        public static void SetIsFlicksEnabled(DependencyObject element, bool enabled);
+        public static void SetIsPressAndHoldEnabled(DependencyObject element, bool enabled);
+        public static void SetIsTapFeedbackEnabled(DependencyObject element, bool enabled);
+        public static void SetIsTouchFeedbackEnabled(DependencyObject element, bool enabled);
+        public static void Synchronize();
+    }
+    public class StylusButton {
+        public Guid Guid { get; }
+        public string Name { get; }
+        public StylusButtonState StylusButtonState { get; }
+        public StylusDevice StylusDevice { get; }
+        public override string ToString();
+    }
+    public class StylusButtonCollection : ReadOnlyCollection<StylusButton> {
+        public StylusButton GetStylusButtonByGuid(Guid guid);
+    }
+    public class StylusButtonEventArgs : StylusEventArgs {
+        public StylusButtonEventArgs(StylusDevice stylusDevice, int timestamp, StylusButton button);
+        public StylusButton StylusButton { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void StylusButtonEventHandler(object sender, StylusButtonEventArgs e);
+    public enum StylusButtonState {
+        Down = 1,
+        Up = 0,
+    }
+    public sealed class StylusDevice : InputDevice {
+        public override PresentationSource ActiveSource { get; }
+        public IInputElement Captured { get; }
+        public IInputElement DirectlyOver { get; }
+        public int Id { get; }
+        public bool InAir { get; }
+        public bool InRange { get; }
+        public bool Inverted { get; }
+        public bool IsValid { get; }
+        public string Name { get; }
+        public StylusButtonCollection StylusButtons { get; }
+        public TabletDevice TabletDevice { get; }
+        public override IInputElement Target { get; }
+        public bool Capture(IInputElement element);
+        public bool Capture(IInputElement element, CaptureMode captureMode);
+        public Point GetPosition(IInputElement relativeTo);
+        public StylusPointCollection GetStylusPoints(IInputElement relativeTo);
+        public StylusPointCollection GetStylusPoints(IInputElement relativeTo, StylusPointDescription subsetToReformatTo);
+        public void Synchronize();
+        public override string ToString();
+    }
+    public class StylusDeviceCollection : ReadOnlyCollection<StylusDevice>
+    public class StylusDownEventArgs : StylusEventArgs {
+        public StylusDownEventArgs(StylusDevice stylusDevice, int timestamp);
+        public int TapCount { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void StylusDownEventHandler(object sender, StylusDownEventArgs e);
+    public class StylusEventArgs : InputEventArgs {
+        public StylusEventArgs(StylusDevice stylus, int timestamp);
+        public bool InAir { get; }
+        public bool Inverted { get; }
+        public StylusDevice StylusDevice { get; }
+        public Point GetPosition(IInputElement relativeTo);
+        public StylusPointCollection GetStylusPoints(IInputElement relativeTo);
+        public StylusPointCollection GetStylusPoints(IInputElement relativeTo, StylusPointDescription subsetToReformatTo);
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void StylusEventHandler(object sender, StylusEventArgs e);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct StylusPoint : IEquatable<StylusPoint> {
+        public static readonly double MaxXY;
+        public static readonly double MinXY;
+        public StylusPoint(double x, double y);
+        public StylusPoint(double x, double y, float pressureFactor);
+        public StylusPoint(double x, double y, float pressureFactor, StylusPointDescription stylusPointDescription, int[] additionalValues);
+        public StylusPointDescription Description { get; internal set; }
+        public float PressureFactor { get; set; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public override bool Equals(object o);
+        public bool Equals(StylusPoint value);
+        public static bool Equals(StylusPoint stylusPoint1, StylusPoint stylusPoint2);
+        public override int GetHashCode();
+        public int GetPropertyValue(StylusPointProperty stylusPointProperty);
+        public bool HasProperty(StylusPointProperty stylusPointProperty);
+        public static bool operator ==(StylusPoint stylusPoint1, StylusPoint stylusPoint2);
+        public static explicit operator Point (StylusPoint stylusPoint);
+        public static bool operator !=(StylusPoint stylusPoint1, StylusPoint stylusPoint2);
+        public void SetPropertyValue(StylusPointProperty stylusPointProperty, int value);
+        public Point ToPoint();
+    }
+    public class StylusPointCollection : Collection<StylusPoint> {
+        public StylusPointCollection();
+        public StylusPointCollection(IEnumerable<StylusPoint> stylusPoints);
+        public StylusPointCollection(IEnumerable<Point> points);
+        public StylusPointCollection(int initialCapacity);
+        public StylusPointCollection(StylusPointDescription stylusPointDescription);
+        public StylusPointCollection(StylusPointDescription stylusPointDescription, int initialCapacity);
+        public StylusPointDescription Description { get; }
+        public event EventHandler Changed;
+        public void Add(StylusPointCollection stylusPoints);
+        protected sealed override void ClearItems();
+        public StylusPointCollection Clone();
+        protected sealed override void InsertItem(int index, StylusPoint stylusPoint);
+        protected virtual void OnChanged(EventArgs e);
+        public static explicit operator Point[] (StylusPointCollection stylusPoints);
+        public StylusPointCollection Reformat(StylusPointDescription subsetToReformatTo);
+        protected sealed override void RemoveItem(int index);
+        protected sealed override void SetItem(int index, StylusPoint stylusPoint);
+        public int[] ToHiMetricArray();
+    }
+    public class StylusPointDescription {
+        public StylusPointDescription();
+        public StylusPointDescription(IEnumerable<StylusPointPropertyInfo> stylusPointPropertyInfos);
+        public int PropertyCount { get; }
+        public static bool AreCompatible(StylusPointDescription stylusPointDescription1, StylusPointDescription stylusPointDescription2);
+        public static StylusPointDescription GetCommonDescription(StylusPointDescription stylusPointDescription, StylusPointDescription stylusPointDescriptionPreserveInfo);
+        public StylusPointPropertyInfo GetPropertyInfo(StylusPointProperty stylusPointProperty);
+        public ReadOnlyCollection<StylusPointPropertyInfo> GetStylusPointProperties();
+        public bool HasProperty(StylusPointProperty stylusPointProperty);
+        public bool IsSubsetOf(StylusPointDescription stylusPointDescriptionSuperset);
+    }
+    public static class StylusPointProperties {
+        public static readonly StylusPointProperty AltitudeOrientation;
+        public static readonly StylusPointProperty AzimuthOrientation;
+        public static readonly StylusPointProperty BarrelButton;
+        public static readonly StylusPointProperty ButtonPressure;
+        public static readonly StylusPointProperty Height;
+        public static readonly StylusPointProperty NormalPressure;
+        public static readonly StylusPointProperty PacketStatus;
+        public static readonly StylusPointProperty PitchRotation;
+        public static readonly StylusPointProperty RollRotation;
+        public static readonly StylusPointProperty SecondaryTipButton;
+        public static readonly StylusPointProperty SerialNumber;
+        public static readonly StylusPointProperty SystemTouch;
+        public static readonly StylusPointProperty TangentPressure;
+        public static readonly StylusPointProperty TipButton;
+        public static readonly StylusPointProperty TwistOrientation;
+        public static readonly StylusPointProperty Width;
+        public static readonly StylusPointProperty X;
+        public static readonly StylusPointProperty XTiltOrientation;
+        public static readonly StylusPointProperty Y;
+        public static readonly StylusPointProperty YawRotation;
+        public static readonly StylusPointProperty YTiltOrientation;
+        public static readonly StylusPointProperty Z;
+    }
+    public class StylusPointProperty {
+        public StylusPointProperty(Guid identifier, bool isButton);
+        protected StylusPointProperty(StylusPointProperty stylusPointProperty);
+        public Guid Id { get; }
+        public bool IsButton { get; }
+        public override string ToString();
+    }
+    public class StylusPointPropertyInfo : StylusPointProperty {
+        public StylusPointPropertyInfo(StylusPointProperty stylusPointProperty);
+        public StylusPointPropertyInfo(StylusPointProperty stylusPointProperty, int minimum, int maximum, StylusPointPropertyUnit unit, float resolution);
+        public int Maximum { get; }
+        public int Minimum { get; }
+        public float Resolution { get; }
+        public StylusPointPropertyUnit Unit { get; }
+    }
+    public enum StylusPointPropertyUnit {
+        Centimeters = 2,
+        Degrees = 3,
+        Grams = 7,
+        Inches = 1,
+        None = 0,
+        Pounds = 6,
+        Radians = 4,
+        Seconds = 5,
+    }
+    public class StylusSystemGestureEventArgs : StylusEventArgs {
+        public StylusSystemGestureEventArgs(StylusDevice stylusDevice, int timestamp, SystemGesture systemGesture);
+        public SystemGesture SystemGesture { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void StylusSystemGestureEventHandler(object sender, StylusSystemGestureEventArgs e);
+    public enum SystemGesture {
+        Drag = 19,
+        Flick = 31,
+        HoldEnter = 21,
+        HoldLeave = 22,
+        HoverEnter = 23,
+        HoverLeave = 24,
+        None = 0,
+        RightDrag = 20,
+        RightTap = 18,
+        Tap = 16,
+        TwoFingerTap = 4352,
+    }
+    public static class Tablet {
+        public static TabletDevice CurrentTabletDevice { get; }
+        public static TabletDeviceCollection TabletDevices { get; }
+    }
+    public sealed class TabletDevice : InputDevice {
+        public override PresentationSource ActiveSource { get; }
+        public int Id { get; }
+        public string Name { get; }
+        public string ProductId { get; }
+        public StylusDeviceCollection StylusDevices { get; }
+        public ReadOnlyCollection<StylusPointProperty> SupportedStylusPointProperties { get; }
+        public TabletHardwareCapabilities TabletHardwareCapabilities { get; }
+        public override IInputElement Target { get; }
+        public TabletDeviceType Type { get; }
+        public override string ToString();
+    }
+    public class TabletDeviceCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public TabletDevice this[int index] { get; }
+        public void CopyTo(TabletDevice[] array, int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public enum TabletDeviceType {
+        Stylus = 0,
+        Touch = 1,
+    }
+    public enum TabletHardwareCapabilities {
+        HardProximity = 4,
+        Integrated = 1,
+        None = 0,
+        StylusHasPhysicalIds = 8,
+        StylusMustTouch = 2,
+        SupportsPressure = 1073741824,
+    }
+    public class TextComposition : DispatcherObject {
+        public TextComposition(InputManager inputManager, IInputElement source, string resultText);
+        public TextComposition(InputManager inputManager, IInputElement source, string resultText, TextCompositionAutoComplete autoComplete);
+        public TextCompositionAutoComplete AutoComplete { get; }
+        public string CompositionText { get; protected set; }
+        public string ControlText { get; protected set; }
+        public string SystemCompositionText { get; protected set; }
+        public string SystemText { get; protected set; }
+        public string Text { get; protected set; }
+        public virtual void Complete();
+    }
+    public enum TextCompositionAutoComplete {
+        Off = 0,
+        On = 1,
+    }
+    public class TextCompositionEventArgs : InputEventArgs {
+        public TextCompositionEventArgs(InputDevice inputDevice, TextComposition composition);
+        public string ControlText { get; }
+        public string SystemText { get; }
+        public string Text { get; }
+        public TextComposition TextComposition { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void TextCompositionEventHandler(object sender, TextCompositionEventArgs e);
+    public sealed class TextCompositionManager : DispatcherObject {
+        public static readonly RoutedEvent PreviewTextInputEvent;
+        public static readonly RoutedEvent PreviewTextInputStartEvent;
+        public static readonly RoutedEvent PreviewTextInputUpdateEvent;
+        public static readonly RoutedEvent TextInputEvent;
+        public static readonly RoutedEvent TextInputStartEvent;
+        public static readonly RoutedEvent TextInputUpdateEvent;
+        public static void AddPreviewTextInputHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void AddPreviewTextInputStartHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void AddPreviewTextInputUpdateHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void AddTextInputHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void AddTextInputStartHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void AddTextInputUpdateHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static bool CompleteComposition(TextComposition composition);
+        public static void RemovePreviewTextInputHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void RemovePreviewTextInputStartHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void RemovePreviewTextInputUpdateHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void RemoveTextInputHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void RemoveTextInputStartHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static void RemoveTextInputUpdateHandler(DependencyObject element, TextCompositionEventHandler handler);
+        public static bool StartComposition(TextComposition composition);
+        public static bool UpdateComposition(TextComposition composition);
+    }
+    public static class Touch {
+        public static event TouchFrameEventHandler FrameReported;
+    }
+    public enum TouchAction {
+        Down = 0,
+        Move = 1,
+        Up = 2,
+    }
+    public abstract class TouchDevice : InputDevice, IManipulator {
+        protected TouchDevice(int deviceId);
+        public sealed override PresentationSource ActiveSource { get; }
+        public IInputElement Captured { get; }
+        public CaptureMode CaptureMode { get; }
+        public IInputElement DirectlyOver { get; }
+        public int Id { get; }
+        public bool IsActive { get; }
+        int System.Windows.Input.IManipulator.Id { get; }
+        public sealed override IInputElement Target { get; }
+        public event EventHandler Activated;
+        public event EventHandler Deactivated;
+        public event EventHandler Updated;
+        protected void Activate();
+        public bool Capture(IInputElement element);
+        public bool Capture(IInputElement element, CaptureMode captureMode);
+        protected void Deactivate();
+        public abstract TouchPointCollection GetIntermediateTouchPoints(IInputElement relativeTo);
+        public abstract TouchPoint GetTouchPoint(IInputElement relativeTo);
+        protected virtual void OnCapture(IInputElement element, CaptureMode captureMode);
+        protected virtual void OnManipulationEnded(bool cancel);
+        protected virtual void OnManipulationStarted();
+        protected bool ReportDown();
+        protected bool ReportMove();
+        protected bool ReportUp();
+        protected void SetActiveSource(PresentationSource activeSource);
+        public void Synchronize();
+        Point System.Windows.Input.IManipulator.GetPosition(IInputElement relativeTo);
+        void System.Windows.Input.IManipulator.ManipulationEnded(bool cancel);
+    }
+    public class TouchEventArgs : InputEventArgs {
+        public TouchEventArgs(TouchDevice touchDevice, int timestamp);
+        public TouchDevice TouchDevice { get; }
+        public TouchPointCollection GetIntermediateTouchPoints(IInputElement relativeTo);
+        public TouchPoint GetTouchPoint(IInputElement relativeTo);
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public sealed class TouchFrameEventArgs : EventArgs {
+        public int Timestamp { get; private set; }
+        public TouchPoint GetPrimaryTouchPoint(IInputElement relativeTo);
+        public TouchPointCollection GetTouchPoints(IInputElement relativeTo);
+        public void SuspendMousePromotionUntilTouchUp();
+    }
+    public delegate void TouchFrameEventHandler(object sender, TouchFrameEventArgs e);
+    public class TouchPoint : IEquatable<TouchPoint> {
+        public TouchPoint(TouchDevice device, Point position, Rect bounds, TouchAction action);
+        public TouchAction Action { get; private set; }
+        public Rect Bounds { get; private set; }
+        public Point Position { get; private set; }
+        public Size Size { get; }
+        public TouchDevice TouchDevice { get; private set; }
+        bool System.IEquatable<System.Windows.Input.TouchPoint>.Equals(TouchPoint other);
+    }
+    public class TouchPointCollection : Collection<TouchPoint> {
+        public TouchPointCollection();
+    }
+    public class TraversalRequest {
+        public TraversalRequest(FocusNavigationDirection focusNavigationDirection);
+        public FocusNavigationDirection FocusNavigationDirection { get; }
+        public bool Wrapped { get; set; }
+    }
 }
```

