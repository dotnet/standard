# System.Web.Configuration.Internal

``` diff
+namespace System.Web.Configuration.Internal {
+    public interface IInternalConfigWebHost {
+        string GetConfigPathFromSiteIDAndVPath(string siteID, string vpath);
+        void GetSiteIDAndVPathFromConfigPath(string configPath, out string siteID, out string vpath);
+    }
+}
```

