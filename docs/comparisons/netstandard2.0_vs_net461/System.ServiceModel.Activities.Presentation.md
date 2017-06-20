# System.ServiceModel.Activities.Presentation

``` diff
+namespace System.ServiceModel.Activities.Presentation {
+    public static class ServiceContractImporter {
+        public const string ContractTypeViewStateKey = "contractType";
+        public static IEnumerable<ActivityTemplateFactoryBuilder> GenerateActivityTemplates(Type contractType);
+        public static string SaveActivityTemplate(ActivityTemplateFactoryBuilder activityTemplate);
+        public static Type SelectContractType(AssemblyName localAssemblyName, IList<AssemblyName> referencedAssemblies, EditingContext editingContext);
+    }
+}
```

