# Microsoft.Build.Tasks.Windows

``` diff
+namespace Microsoft.Build.Tasks.Windows {
+    public sealed class FileClassifier : Task {
+        public FileClassifier();
+        public ITaskItem[] CLREmbeddedResource { get; set; }
+        public ITaskItem[] CLRResourceFiles { get; set; }
+        public ITaskItem[] CLRSatelliteEmbeddedResource { get; set; }
+        public string Culture { get; set; }
+        public ITaskItem[] MainEmbeddedFiles { get; set; }
+        public string OutputType { get; set; }
+        public ITaskItem[] SatelliteEmbeddedFiles { get; set; }
+        public ITaskItem[] SourceFiles { get; set; }
+        public override bool Execute();
+    }
+    public sealed class GenerateTemporaryTargetAssembly : Task {
+        public GenerateTemporaryTargetAssembly();
+        public string AssemblyName { get; set; }
+        public string CompileTargetName { get; set; }
+        public string CompileTypeName { get; set; }
+        public string CurrentProject { get; set; }
+        public ITaskItem[] GeneratedCodeFiles { get; set; }
+        public string IntermediateOutputPath { get; set; }
+        public string MSBuildBinPath { get; set; }
+        public ITaskItem[] ReferencePath { get; set; }
+        public string ReferencePathTypeName { get; set; }
+        public override bool Execute();
+    }
+    public sealed class GetWinFXPath : Task {
+        public GetWinFXPath();
+        public string WinFXNativePath { get; set; }
+        public string WinFXPath { get; set; }
+        public string WinFXWowPath { get; set; }
+        public override bool Execute();
+    }
+    public sealed class MarkupCompilePass1 : Task {
+        public MarkupCompilePass1();
+        public ITaskItem[] AllGeneratedFiles { get; set; }
+        public bool AlwaysCompileMarkupFilesInSeparateDomain { get; set; }
+        public ITaskItem[] ApplicationMarkup { get; set; }
+        public string[] AssembliesGeneratedDuringBuild { get; set; }
+        public string AssemblyName { get; set; }
+        public string AssemblyPublicKeyToken { get; set; }
+        public string AssemblyVersion { get; set; }
+        public ITaskItem[] ContentFiles { get; set; }
+        public string DefineConstants { get; set; }
+        public ITaskItem[] ExtraBuildControlFiles { get; set; }
+        public ITaskItem[] GeneratedBamlFiles { get; set; }
+        public ITaskItem[] GeneratedCodeFiles { get; set; }
+        public ITaskItem[] GeneratedLocalizationFiles { get; set; }
+        public string HostInBrowser { get; set; }
+        public bool IsRunningInVisualStudio { get; set; }
+        public string[] KnownReferencePaths { get; set; }
+        public string Language { get; set; }
+        public string LanguageSourceExtension { get; set; }
+        public string LocalizationDirectivesToLocFile { get; set; }
+        public string OutputPath { get; set; }
+        public string OutputType { get; set; }
+        public ITaskItem[] PageMarkup { get; set; }
+        public ITaskItem[] References { get; set; }
+        public bool RequirePass2ForMainAssembly { get; set; }
+        public bool RequirePass2ForSatelliteAssembly { get; set; }
+        public string RootNamespace { get; set; }
+        public ITaskItem[] SourceCodeFiles { get; set; }
+        public ITaskItem[] SplashScreen { get; set; }
+        public string UICulture { get; set; }
+        public bool XamlDebuggingInformation { get; set; }
+        public override bool Execute();
+    }
+    public sealed class MarkupCompilePass2 : Task {
+        public MarkupCompilePass2();
+        public bool AlwaysCompileMarkupFilesInSeparateDomain { get; set; }
+        public string[] AssembliesGeneratedDuringBuild { get; set; }
+        public string AssemblyName { get; set; }
+        public ITaskItem[] GeneratedBaml { get; set; }
+        public string[] KnownReferencePaths { get; set; }
+        public string Language { get; set; }
+        public string LocalizationDirectivesToLocFile { get; set; }
+        public string OutputPath { get; set; }
+        public string OutputType { get; set; }
+        public ITaskItem[] References { get; set; }
+        public string RootNamespace { get; set; }
+        public bool XamlDebuggingInformation { get; set; }
+        public override bool Execute();
+    }
+    public sealed class MergeLocalizationDirectives : Task {
+        public MergeLocalizationDirectives();
+        public ITaskItem[] GeneratedLocalizationFiles { get; set; }
+        public string OutputFile { get; set; }
+        public override bool Execute();
+    }
+    public sealed class ResourcesGenerator : Task {
+        public ResourcesGenerator();
+        public string OutputPath { get; set; }
+        public ITaskItem[] OutputResourcesFile { get; set; }
+        public ITaskItem[] ResourceFiles { get; set; }
+        public override bool Execute();
+    }
+    public sealed class UidManager : Task {
+        public UidManager();
+        public string IntermediateDirectory { get; set; }
+        public ITaskItem[] MarkupFiles { get; set; }
+        public string Task { get; set; }
+        public override bool Execute();
+    }
+    public sealed class UpdateManifestForBrowserApplication : Task {
+        public UpdateManifestForBrowserApplication();
+        public ITaskItem[] ApplicationManifest { get; set; }
+        public bool HostInBrowser { get; set; }
+        public override bool Execute();
+    }
+}
```

