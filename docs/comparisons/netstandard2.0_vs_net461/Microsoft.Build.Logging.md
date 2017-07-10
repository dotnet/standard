# Microsoft.Build.Logging

``` diff
+namespace Microsoft.Build.Logging {
+    public delegate void ColorResetter();
+    public delegate void ColorSetter(ConsoleColor color);
+    public class ConfigurableForwardingLogger : IForwardingLogger, ILogger, INodeLogger {
+        public ConfigurableForwardingLogger();
+        public IEventRedirector BuildEventRedirector { get; set; }
+        public int NodeId { get; set; }
+        public string Parameters { get; set; }
+        public LoggerVerbosity Verbosity { get; set; }
+        protected virtual void ForwardToCentralLogger(BuildEventArgs e);
+        public virtual void Initialize(IEventSource eventSource);
+        public void Initialize(IEventSource eventSource, int nodeCount);
+        public virtual void Shutdown();
+    }
+    public class ConsoleLogger : ILogger, INodeLogger {
+        public ConsoleLogger();
+        public ConsoleLogger(LoggerVerbosity verbosity);
+        public ConsoleLogger(LoggerVerbosity verbosity, WriteHandler write, ColorSetter colorSet, ColorResetter colorReset);
+        public string Parameters { get; set; }
+        public bool ShowSummary { get; set; }
+        public bool SkipProjectStartedText { get; set; }
+        public LoggerVerbosity Verbosity { get; set; }
+        protected WriteHandler WriteHandler { get; set; }
+        public void ApplyParameter(string parameterName, string parameterValue);
+        public void BuildFinishedHandler(object sender, BuildFinishedEventArgs e);
+        public void BuildStartedHandler(object sender, BuildStartedEventArgs e);
+        public void CustomEventHandler(object sender, CustomBuildEventArgs e);
+        public void ErrorHandler(object sender, BuildErrorEventArgs e);
+        public virtual void Initialize(IEventSource eventSource);
+        public virtual void Initialize(IEventSource eventSource, int nodeCount);
+        public void MessageHandler(object sender, BuildMessageEventArgs e);
+        public void ProjectFinishedHandler(object sender, ProjectFinishedEventArgs e);
+        public void ProjectStartedHandler(object sender, ProjectStartedEventArgs e);
+        public virtual void Shutdown();
+        public void TargetFinishedHandler(object sender, TargetFinishedEventArgs e);
+        public void TargetStartedHandler(object sender, TargetStartedEventArgs e);
+        public void TaskFinishedHandler(object sender, TaskFinishedEventArgs e);
+        public void TaskStartedHandler(object sender, TaskStartedEventArgs e);
+        public void WarningHandler(object sender, BuildWarningEventArgs e);
+    }
+    public class DistributedFileLogger : IForwardingLogger, ILogger, INodeLogger {
+        public DistributedFileLogger();
+        public IEventRedirector BuildEventRedirector { get; set; }
+        public int NodeId { get; set; }
+        public string Parameters { get; set; }
+        public LoggerVerbosity Verbosity { get; set; }
+        public void Initialize(IEventSource eventSource);
+        public void Initialize(IEventSource eventSource, int nodeCount);
+        public void Shutdown();
+    }
+    public class FileLogger : ConsoleLogger {
+        public FileLogger();
+        public override void Initialize(IEventSource eventSource);
+        public override void Initialize(IEventSource eventSource, int nodeCount);
+        public override void Shutdown();
+    }
+    public class ForwardingLoggerRecord {
+        public ForwardingLoggerRecord(ILogger centralLogger, LoggerDescription forwardingLoggerDescription);
+        public ILogger CentralLogger { get; private set; }
+        public LoggerDescription ForwardingLoggerDescription { get; private set; }
+    }
+    public class LoggerDescription : INodePacketTranslatable {
+        public LoggerDescription(string loggerClassName, string loggerAssemblyName, string loggerAssemblyFile, string loggerSwitchParameters, LoggerVerbosity verbosity);
+        public string LoggerSwitchParameters { get; }
+        public LoggerVerbosity Verbosity { get; }
+        public ILogger CreateLogger();
+    }
+    public delegate void WriteHandler(string message);
+}
```

