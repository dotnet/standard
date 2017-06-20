# System.Activities.Core.Presentation.Factories

``` diff
+namespace System.Activities.Core.Presentation.Factories {
+    public sealed class ForEachWithBodyFactory<T> : IActivityTemplateFactory {
+        public ForEachWithBodyFactory();
+        public Activity Create(DependencyObject target);
+    }
+    public sealed class ParallelForEachWithBodyFactory<T> : IActivityTemplateFactory {
+        public ParallelForEachWithBodyFactory();
+        public Activity Create(DependencyObject target);
+    }
+    public sealed class PickWithTwoBranchesFactory : IActivityTemplateFactory {
+        public PickWithTwoBranchesFactory();
+        public Activity Create(DependencyObject target);
+    }
+    public sealed class StateMachineWithInitialStateFactory : IActivityTemplateFactory {
+        public StateMachineWithInitialStateFactory();
+        public Activity Create(DependencyObject target);
+    }
+}
```

