# Microsoft.Build.Conversion

``` diff
+namespace Microsoft.Build.Conversion {
+    public sealed class ProjectFileConverter {
+        public ProjectFileConverter();
+        public bool ConversionSkippedBecauseProjectAlreadyConverted { get; }
+        public string[] ConversionWarnings { get; }
+        public bool IsUserFile { get; set; }
+        public string NewProjectFile { get; set; }
+        public string OldProjectFile { get; set; }
+        public string SolutionFile { get; set; }
+        public void Convert();
+        public void Convert(ProjectLoadSettings projectLoadSettings);
+        public void Convert(string msbuildBinPath);
+        public ProjectRootElement ConvertInMemory();
+        public Project ConvertInMemory(Engine engine);
+        public Project ConvertInMemory(Engine engine, ProjectLoadSettings projectLoadSettings);
+        public bool FSharpSpecificConversions(bool actuallyMakeChanges);
+    }
+}
```

