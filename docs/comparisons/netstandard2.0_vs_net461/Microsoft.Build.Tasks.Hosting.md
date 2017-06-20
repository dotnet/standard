# Microsoft.Build.Tasks.Hosting

``` diff
+namespace Microsoft.Build.Tasks.Hosting {
+    public interface ICscHostObject : ITaskHost {
+        void BeginInitialization();
+        bool Compile();
+        bool EndInitialization(out string errorMessage, out int errorCode);
+        bool IsDesignTime();
+        bool IsUpToDate();
+        bool SetAdditionalLibPaths(string[] additionalLibPaths);
+        bool SetAddModules(string[] addModules);
+        bool SetAllowUnsafeBlocks(bool allowUnsafeBlocks);
+        bool SetBaseAddress(string baseAddress);
+        bool SetCheckForOverflowUnderflow(bool checkForOverflowUnderflow);
+        bool SetCodePage(int codePage);
+        bool SetDebugType(string debugType);
+        bool SetDefineConstants(string defineConstants);
+        bool SetDelaySign(bool delaySignExplicitlySet, bool delaySign);
+        bool SetDisabledWarnings(string disabledWarnings);
+        bool SetDocumentationFile(string documentationFile);
+        bool SetEmitDebugInformation(bool emitDebugInformation);
+        bool SetErrorReport(string errorReport);
+        bool SetFileAlignment(int fileAlignment);
+        bool SetGenerateFullPaths(bool generateFullPaths);
+        bool SetKeyContainer(string keyContainer);
+        bool SetKeyFile(string keyFile);
+        bool SetLangVersion(string langVersion);
+        bool SetLinkResources(ITaskItem[] linkResources);
+        bool SetMainEntryPoint(string targetType, string mainEntryPoint);
+        bool SetModuleAssemblyName(string moduleAssemblyName);
+        bool SetNoConfig(bool noConfig);
+        bool SetNoStandardLib(bool noStandardLib);
+        bool SetOptimize(bool optimize);
+        bool SetOutputAssembly(string outputAssembly);
+        bool SetPdbFile(string pdbFile);
+        bool SetPlatform(string platform);
+        bool SetReferences(ITaskItem[] references);
+        bool SetResources(ITaskItem[] resources);
+        bool SetResponseFiles(ITaskItem[] responseFiles);
+        bool SetSources(ITaskItem[] sources);
+        bool SetTargetType(string targetType);
+        bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
+        bool SetWarningLevel(int warningLevel);
+        bool SetWarningsAsErrors(string warningsAsErrors);
+        bool SetWarningsNotAsErrors(string warningsNotAsErrors);
+        bool SetWin32Icon(string win32Icon);
+        bool SetWin32Resource(string win32Resource);
+    }
+    public interface ICscHostObject2 : ICscHostObject, ITaskHost {
+        bool SetWin32Manifest(string win32Manifest);
+    }
+    public interface ICscHostObject3 : ICscHostObject, ICscHostObject2, ITaskHost {
+        bool SetApplicationConfiguration(string applicationConfiguration);
+    }
+    public interface ICscHostObject4 : ICscHostObject, ICscHostObject2, ICscHostObject3, ITaskHost {
+        bool SetHighEntropyVA(bool highEntropyVA);
+        bool SetPlatformWith32BitPreference(string platformWith32BitPreference);
+        bool SetSubsystemVersion(string subsystemVersion);
+    }
+    public interface IVbcHostObject : ITaskHost {
+        void BeginInitialization();
+        bool Compile();
+        void EndInitialization();
+        bool IsDesignTime();
+        bool IsUpToDate();
+        bool SetAdditionalLibPaths(string[] additionalLibPaths);
+        bool SetAddModules(string[] addModules);
+        bool SetBaseAddress(string targetType, string baseAddress);
+        bool SetCodePage(int codePage);
+        bool SetDebugType(bool emitDebugInformation, string debugType);
+        bool SetDefineConstants(string defineConstants);
+        bool SetDelaySign(bool delaySign);
+        bool SetDisabledWarnings(string disabledWarnings);
+        bool SetDocumentationFile(string documentationFile);
+        bool SetErrorReport(string errorReport);
+        bool SetFileAlignment(int fileAlignment);
+        bool SetGenerateDocumentation(bool generateDocumentation);
+        bool SetImports(ITaskItem[] importsList);
+        bool SetKeyContainer(string keyContainer);
+        bool SetKeyFile(string keyFile);
+        bool SetLinkResources(ITaskItem[] linkResources);
+        bool SetMainEntryPoint(string mainEntryPoint);
+        bool SetNoConfig(bool noConfig);
+        bool SetNoStandardLib(bool noStandardLib);
+        bool SetNoWarnings(bool noWarnings);
+        bool SetOptimize(bool optimize);
+        bool SetOptionCompare(string optionCompare);
+        bool SetOptionExplicit(bool optionExplicit);
+        bool SetOptionStrict(bool optionStrict);
+        bool SetOptionStrictType(string optionStrictType);
+        bool SetOutputAssembly(string outputAssembly);
+        bool SetPlatform(string platform);
+        bool SetReferences(ITaskItem[] references);
+        bool SetRemoveIntegerChecks(bool removeIntegerChecks);
+        bool SetResources(ITaskItem[] resources);
+        bool SetResponseFiles(ITaskItem[] responseFiles);
+        bool SetRootNamespace(string rootNamespace);
+        bool SetSdkPath(string sdkPath);
+        bool SetSources(ITaskItem[] sources);
+        bool SetTargetCompactFramework(bool targetCompactFramework);
+        bool SetTargetType(string targetType);
+        bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
+        bool SetWarningsAsErrors(string warningsAsErrors);
+        bool SetWarningsNotAsErrors(string warningsNotAsErrors);
+        bool SetWin32Icon(string win32Icon);
+        bool SetWin32Resource(string win32Resource);
+    }
+    public interface IVbcHostObject2 : ITaskHost, IVbcHostObject {
+        bool SetModuleAssemblyName(string moduleAssemblyName);
+        bool SetOptionInfer(bool optionInfer);
+        bool SetWin32Manifest(string win32Manifest);
+    }
+    public interface IVbcHostObject3 : ITaskHost, IVbcHostObject, IVbcHostObject2 {
+        bool SetLanguageVersion(string languageVersion);
+    }
+    public interface IVbcHostObject4 : ITaskHost, IVbcHostObject, IVbcHostObject2, IVbcHostObject3 {
+        bool SetVBRuntime(string VBRuntime);
+    }
+    public interface IVbcHostObject5 : ITaskHost, IVbcHostObject, IVbcHostObject2, IVbcHostObject3, IVbcHostObject4 {
+        int CompileAsync(out IntPtr buildSucceededEvent, out IntPtr buildFailedEvent);
+        int EndCompile(bool buildSuccess);
+        IVbcHostObjectFreeThreaded GetFreeThreadedHostObject();
+        bool SetHighEntropyVA(bool highEntropyVA);
+        bool SetPlatformWith32BitPreference(string platformWith32BitPreference);
+        bool SetSubsystemVersion(string subsystemVersion);
+    }
+    public interface IVbcHostObjectFreeThreaded {
+        bool Compile();
+    }
+}
```

