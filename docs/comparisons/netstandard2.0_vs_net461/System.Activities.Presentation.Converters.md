# System.Activities.Presentation.Converters

``` diff
+namespace System.Activities.Presentation.Converters {
+    public class ArgumentToExpressionConverter : IValueConverter {
+        public ArgumentToExpressionConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+    public class ArgumentToExpressionModelItemConverter : IMultiValueConverter {
+        public ArgumentToExpressionModelItemConverter();
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+    public sealed class ModelPropertyEntryToModelItemConverter : IMultiValueConverter, IValueConverter {
+        public ModelPropertyEntryToModelItemConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+    public class ModelPropertyEntryToOwnerActivityConverter : IValueConverter {
+        public ModelPropertyEntryToOwnerActivityConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+    public class ModelToObjectValueConverter : IValueConverter {
+        public ModelToObjectValueConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+    public class ObjectToModelValueConverter : IMultiValueConverter {
+        public ObjectToModelValueConverter();
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+}
```

