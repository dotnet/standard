# System.Data.Entity.Design.PluralizationServices

``` diff
+namespace System.Data.Entity.Design.PluralizationServices {
+    public interface ICustomPluralizationMapping {
+        void AddWord(string singular, string plural);
+    }
+    public abstract class PluralizationService {
+        protected PluralizationService();
+        public CultureInfo Culture { get; protected set; }
+        public static PluralizationService CreateService(CultureInfo culture);
+        public abstract bool IsPlural(string word);
+        public abstract bool IsSingular(string word);
+        public abstract string Pluralize(string word);
+        public abstract string Singularize(string word);
+    }
+}
```

