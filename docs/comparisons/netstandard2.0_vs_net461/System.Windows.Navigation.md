# System.Windows.Navigation

``` diff
+namespace System.Windows.Navigation {
+    public static class BaseUriHelper {
+        public static readonly DependencyProperty BaseUriProperty;
+        public static Uri GetBaseUri(DependencyObject element);
+    }
+    public abstract class CustomContentState {
+        protected CustomContentState();
+        public virtual string JournalEntryName { get; }
+        public abstract void Replay(NavigationService navigationService, NavigationMode mode);
+    }
+    public class FragmentNavigationEventArgs : EventArgs {
+        public string Fragment { get; }
+        public bool Handled { get; set; }
+        public object Navigator { get; }
+    }
+    public delegate void FragmentNavigationEventHandler(object sender, FragmentNavigationEventArgs e);
+    public interface IProvideCustomContentState {
+        CustomContentState GetContentState();
+    }
+    public class JournalEntry : DependencyObject, ISerializable {
+        public static readonly DependencyProperty KeepAliveProperty;
+        public static readonly DependencyProperty NameProperty;
+        protected JournalEntry(SerializationInfo info, StreamingContext context);
+        public CustomContentState CustomContentState { get; internal set; }
+        public string Name { get; set; }
+        public Uri Source { get; set; }
+        public static bool GetKeepAlive(DependencyObject dependencyObject);
+        public static string GetName(DependencyObject dependencyObject);
+        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        public static void SetKeepAlive(DependencyObject dependencyObject, bool keepAlive);
+        public static void SetName(DependencyObject dependencyObject, string name);
+    }
+    public sealed class JournalEntryListConverter : IValueConverter {
+        public JournalEntryListConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+    public enum JournalEntryPosition {
+        Back = 0,
+        Current = 1,
+        Forward = 2,
+    }
+    public sealed class JournalEntryUnifiedViewConverter : IMultiValueConverter {
+        public static readonly DependencyProperty JournalEntryPositionProperty;
+        public JournalEntryUnifiedViewConverter();
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+        public static JournalEntryPosition GetJournalEntryPosition(DependencyObject element);
+        public static void SetJournalEntryPosition(DependencyObject element, JournalEntryPosition position);
+    }
+    public enum JournalOwnership {
+        Automatic = 0,
+        OwnsJournal = 1,
+        UsesParentJournal = 2,
+    }
+    public delegate void LoadCompletedEventHandler(object sender, NavigationEventArgs e);
+    public delegate void NavigatedEventHandler(object sender, NavigationEventArgs e);
+    public class NavigatingCancelEventArgs : CancelEventArgs {
+        public object Content { get; }
+        public CustomContentState ContentStateToSave { get; set; }
+        public object ExtraData { get; }
+        public bool IsNavigationInitiator { get; }
+        public NavigationMode NavigationMode { get; }
+        public object Navigator { get; }
+        public CustomContentState TargetContentState { get; }
+        public Uri Uri { get; }
+        public WebRequest WebRequest { get; }
+    }
+    public delegate void NavigatingCancelEventHandler(object sender, NavigatingCancelEventArgs e);
+    public class NavigationEventArgs : EventArgs {
+        public object Content { get; }
+        public object ExtraData { get; }
+        public bool IsNavigationInitiator { get; }
+        public object Navigator { get; }
+        public Uri Uri { get; }
+        public WebResponse WebResponse { get; }
+    }
+    public class NavigationFailedEventArgs : EventArgs {
+        public Exception Exception { get; }
+        public object ExtraData { get; }
+        public bool Handled { get; set; }
+        public object Navigator { get; }
+        public Uri Uri { get; }
+        public WebRequest WebRequest { get; }
+        public WebResponse WebResponse { get; }
+    }
+    public delegate void NavigationFailedEventHandler(object sender, NavigationFailedEventArgs e);
+    public enum NavigationMode : byte {
+        Back = (byte)1,
+        Forward = (byte)2,
+        New = (byte)0,
+        Refresh = (byte)3,
+    }
+    public class NavigationProgressEventArgs : EventArgs {
+        public long BytesRead { get; }
+        public long MaxBytes { get; }
+        public object Navigator { get; }
+        public Uri Uri { get; }
+    }
+    public delegate void NavigationProgressEventHandler(object sender, NavigationProgressEventArgs e);
+    public sealed class NavigationService : IContentContainer {
+        public bool CanGoBack { get; }
+        public bool CanGoForward { get; }
+        public object Content { get; set; }
+        public Uri CurrentSource { get; }
+        public Uri Source { get; set; }
+        public event FragmentNavigationEventHandler FragmentNavigation;
+        public event LoadCompletedEventHandler LoadCompleted;
+        public event NavigatedEventHandler Navigated;
+        public event NavigatingCancelEventHandler Navigating;
+        public event NavigationFailedEventHandler NavigationFailed;
+        public event NavigationProgressEventHandler NavigationProgress;
+        public event NavigationStoppedEventHandler NavigationStopped;
+        public void AddBackEntry(CustomContentState state);
+        public static NavigationService GetNavigationService(DependencyObject dependencyObject);
+        public void GoBack();
+        public void GoForward();
+        public bool Navigate(object root);
+        public bool Navigate(object root, object navigationState);
+        public bool Navigate(Uri source);
+        public bool Navigate(Uri source, object navigationState);
+        public bool Navigate(Uri source, object navigationState, bool sandboxExternalContent);
+        public void Refresh();
+        public JournalEntry RemoveBackEntry();
+        public void StopLoading();
+    }
+    public delegate void NavigationStoppedEventHandler(object sender, NavigationEventArgs e);
+    public enum NavigationUIVisibility {
+        Automatic = 0,
+        Hidden = 2,
+        Visible = 1,
+    }
+    public class NavigationWindow : Window, IDownloader, IJournalNavigationScopeHost, INavigator, INavigatorBase, INavigatorImpl, IUriContext {
+        public static readonly DependencyProperty BackStackProperty;
+        public static readonly DependencyProperty CanGoBackProperty;
+        public static readonly DependencyProperty CanGoForwardProperty;
+        public static readonly DependencyProperty ForwardStackProperty;
+        public static readonly DependencyProperty SandboxExternalContentProperty;
+        public static readonly DependencyProperty ShowsNavigationUIProperty;
+        public static readonly DependencyProperty SourceProperty;
+        public NavigationWindow();
+        public IEnumerable BackStack { get; }
+        public bool CanGoBack { get; }
+        public bool CanGoForward { get; }
+        public Uri CurrentSource { get; }
+        public IEnumerable ForwardStack { get; }
+        public NavigationService NavigationService { get; }
+        public bool SandboxExternalContent { get; set; }
+        public bool ShowsNavigationUI { get; set; }
+        public Uri Source { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public event FragmentNavigationEventHandler FragmentNavigation;
+        public event LoadCompletedEventHandler LoadCompleted;
+        public event NavigatedEventHandler Navigated;
+        public event NavigatingCancelEventHandler Navigating;
+        public event NavigationFailedEventHandler NavigationFailed;
+        public event NavigationProgressEventHandler NavigationProgress;
+        public event NavigationStoppedEventHandler NavigationStopped;
+        public void AddBackEntry(CustomContentState state);
+        protected override void AddChild(object value);
+        protected override void AddText(string text);
+        public void GoBack();
+        public void GoForward();
+        public bool Navigate(object content);
+        public bool Navigate(object content, object extraData);
+        public bool Navigate(Uri source);
+        public bool Navigate(Uri source, object extraData);
+        public override void OnApplyTemplate();
+        protected override void OnClosed(EventArgs args);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        public void Refresh();
+        public JournalEntry RemoveBackEntry();
+        public override bool ShouldSerializeContent();
+        public void StopLoading();
+    }
+    public class PageFunction<T> : PageFunctionBase {
+        public PageFunction();
+        public event ReturnEventHandler<T> Return;
+        protected virtual void OnReturn(ReturnEventArgs<T> e);
+    }
+    public abstract class PageFunctionBase : Page {
+        protected PageFunctionBase();
+        public bool RemoveFromJournal { get; set; }
+        protected virtual void Start();
+    }
+    public class RequestNavigateEventArgs : RoutedEventArgs {
+        protected RequestNavigateEventArgs();
+        public RequestNavigateEventArgs(Uri uri, string target);
+        public string Target { get; }
+        public Uri Uri { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void RequestNavigateEventHandler(object sender, RequestNavigateEventArgs e);
+    public class ReturnEventArgs<T> : EventArgs {
+        public ReturnEventArgs();
+        public ReturnEventArgs(T result);
+        public T Result { get; set; }
+    }
+    public delegate void ReturnEventHandler<T>(object sender, ReturnEventArgs<T> e);
+}
```

