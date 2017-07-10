# System.Globalization

``` diff
 namespace System.Globalization {
+    public sealed class CultureAndRegionInfoBuilder {
+        public CultureAndRegionInfoBuilder(string cultureName, CultureAndRegionModifiers flags);
+        public Calendar[] AvailableCalendars { get; set; }
+        public CompareInfo CompareInfo { get; set; }
+        public CultureInfo ConsoleFallbackUICulture { get; set; }
+        public string CultureEnglishName { get; set; }
+        public string CultureName { get; }
+        public string CultureNativeName { get; set; }
+        public CultureTypes CultureTypes { get; }
+        public string CurrencyEnglishName { get; set; }
+        public string CurrencyNativeName { get; set; }
+        public int GeoId { get; set; }
+        public DateTimeFormatInfo GregorianDateTimeFormat { get; set; }
+        public string IetfLanguageTag { get; set; }
+        public bool IsMetric { get; set; }
+        public string ISOCurrencySymbol { get; set; }
+        public bool IsRightToLeft { get; set; }
+        public int KeyboardLayoutId { get; set; }
+        public int LCID { get; }
+        public NumberFormatInfo NumberFormat { get; set; }
+        public CultureInfo Parent { get; set; }
+        public string RegionEnglishName { get; set; }
+        public string RegionName { get; }
+        public string RegionNativeName { get; set; }
+        public TextInfo TextInfo { get; set; }
+        public string ThreeLetterISOLanguageName { get; set; }
+        public string ThreeLetterISORegionName { get; set; }
+        public string ThreeLetterWindowsLanguageName { get; set; }
+        public string ThreeLetterWindowsRegionName { get; set; }
+        public string TwoLetterISOLanguageName { get; set; }
+        public string TwoLetterISORegionName { get; set; }
+        public static CultureAndRegionInfoBuilder CreateFromLdml(string xmlFileName);
+        public void LoadDataFromCultureInfo(CultureInfo culture);
+        public void LoadDataFromRegionInfo(RegionInfo region);
+        public void Register();
+        public void Save(string filename);
+        public static void Unregister(string cultureName);
+    }
+    public enum CultureAndRegionModifiers {
+        Neutral = 1,
+        None = 0,
+        Replacement = 2,
+    }
-    public static class GlobalizationExtensions {
 {
-        public static StringComparer GetStringComparer(this CompareInfo compareInfo, CompareOptions options);

-    }
 }
```

