# System.Data.Entity.Design.AspNet

``` diff
+namespace System.Data.Entity.Design.AspNet {
+    public class EntityDesignerBuildProvider : BuildProvider {
+        public EntityDesignerBuildProvider();
+        public override void GenerateCode(AssemblyBuilder assemblyBuilder);
+        public override BuildProviderResultFlags GetResultFlags(CompilerResults results);
+    }
+    public class EntityModelBuildProvider : BuildProvider {
+        public EntityModelBuildProvider();
+        public override void GenerateCode(AssemblyBuilder assemblyBuilder);
+        public override BuildProviderResultFlags GetResultFlags(CompilerResults results);
+    }
+    public class MappingModelBuildProvider : BuildProvider {
+        public MappingModelBuildProvider();
+        public override void GenerateCode(AssemblyBuilder assemblyBuilder);
+        public override BuildProviderResultFlags GetResultFlags(CompilerResults results);
+    }
+    public class StorageModelBuildProvider : BuildProvider {
+        public StorageModelBuildProvider();
+        public override void GenerateCode(AssemblyBuilder assemblyBuilder);
+        public override BuildProviderResultFlags GetResultFlags(CompilerResults results);
+    }
+}
```

