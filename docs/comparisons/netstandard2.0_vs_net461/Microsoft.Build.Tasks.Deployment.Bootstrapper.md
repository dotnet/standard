# Microsoft.Build.Tasks.Deployment.Bootstrapper

``` diff
+namespace Microsoft.Build.Tasks.Deployment.Bootstrapper {
+    public class BootstrapperBuilder : IBootstrapperBuilder {
+        public BootstrapperBuilder();
+        public BootstrapperBuilder(string visualStudioVersion);
+        public string Path { get; set; }
+        public ProductCollection Products { get; }
+        public BuildResults Build(BuildSettings settings);
+        public string[] GetOutputFolders(string[] productCodes, string culture, string fallbackCulture, ComponentsLocation componentsLocation);
+    }
+    public class BuildMessage : IBuildMessage {
+        public int HelpId { get; }
+        public string HelpKeyword { get; }
+        public string Message { get; }
+        public BuildMessageSeverity Severity { get; }
+    }
+    public enum BuildMessageSeverity {
+        Error = 2,
+        Info = 0,
+        Warning = 1,
+    }
+    public class BuildResults : IBuildResults {
+        public string[] ComponentFiles { get; }
+        public string KeyFile { get; }
+        public BuildMessage[] Messages { get; }
+        public bool Succeeded { get; }
+    }
+    public class BuildSettings : IBuildSettings {
+        public BuildSettings();
+        public string ApplicationFile { get; set; }
+        public string ApplicationName { get; set; }
+        public bool ApplicationRequiresElevation { get; set; }
+        public string ApplicationUrl { get; set; }
+        public ComponentsLocation ComponentsLocation { get; set; }
+        public string ComponentsUrl { get; set; }
+        public bool CopyComponents { get; set; }
+        public int FallbackLCID { get; set; }
+        public int LCID { get; set; }
+        public string OutputPath { get; set; }
+        public ProductBuilderCollection ProductBuilders { get; }
+        public string SupportUrl { get; set; }
+        public bool Validate { get; set; }
+    }
+    public enum ComponentsLocation {
+        Absolute = 2,
+        HomeSite = 0,
+        Relative = 1,
+    }
+    public interface IBootstrapperBuilder {
+        string Path { get; set; }
+        ProductCollection Products { get; }
+        BuildResults Build(BuildSettings settings);
+    }
+    public interface IBuildMessage {
+        int HelpId { get; }
+        string HelpKeyword { get; }
+        string Message { get; }
+        BuildMessageSeverity Severity { get; }
+    }
+    public interface IBuildResults {
+        string[] ComponentFiles { get; }
+        string KeyFile { get; }
+        BuildMessage[] Messages { get; }
+        bool Succeeded { get; }
+    }
+    public interface IBuildSettings {
+        string ApplicationFile { get; set; }
+        string ApplicationName { get; set; }
+        bool ApplicationRequiresElevation { get; set; }
+        string ApplicationUrl { get; set; }
+        ComponentsLocation ComponentsLocation { get; set; }
+        string ComponentsUrl { get; set; }
+        bool CopyComponents { get; set; }
+        int FallbackLCID { get; set; }
+        int LCID { get; set; }
+        string OutputPath { get; set; }
+        ProductBuilderCollection ProductBuilders { get; }
+        string SupportUrl { get; set; }
+        bool Validate { get; set; }
+    }
+    public interface IProduct {
+        ProductCollection Includes { get; }
+        string Name { get; }
+        ProductBuilder ProductBuilder { get; }
+        string ProductCode { get; }
+    }
+    public interface IProductBuilder {
+        Product Product { get; }
+    }
+    public interface IProductBuilderCollection {
+        void Add(ProductBuilder builder);
+    }
+    public interface IProductCollection {
+        int Count { get; }
+        Product Item(int index);
+        Product Product(string productCode);
+    }
+    public class Product : IProduct {
+        public Product();
+        public ProductCollection Includes { get; }
+        public string Name { get; }
+        public ProductBuilder ProductBuilder { get; }
+        public string ProductCode { get; }
+    }
+    public class ProductBuilder : IProductBuilder {
+        public Product Product { get; }
+    }
+    public class ProductBuilderCollection : IEnumerable, IProductBuilderCollection {
+        public void Add(ProductBuilder builder);
+        public IEnumerator GetEnumerator();
+    }
+    public class ProductCollection : IEnumerable, IProductCollection {
+        public int Count { get; }
+        public IEnumerator GetEnumerator();
+        public Product Item(int index);
+        public Product Product(string productCode);
+    }
+}
```

