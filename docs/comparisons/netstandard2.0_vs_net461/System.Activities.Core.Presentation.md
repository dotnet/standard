# System.Activities.Core.Presentation

``` diff
+namespace System.Activities.Core.Presentation {
+    public enum ConnectionPointType {
+        Default = 0,
+        Incoming = 1,
+        Outgoing = 2,
+    }
+    public class DesignerMetadata : IRegisterMetadata {
+        public DesignerMetadata();
+        public void Register();
+    }
+    public sealed class FinalState {
+        public FinalState();
+    }
+    public static class FlowchartDesignerCommands {
+        public static readonly RoutedCommand ConnectNodesCommand;
+    }
+    public sealed class GenericTypeArgumentConverter : IValueConverter {
+        public GenericTypeArgumentConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+    public class LocationChangedEventArgs : EventArgs {
+        public LocationChangedEventArgs(Point newLocation);
+        public Point NewLocation { get; }
+    }
+}
```

