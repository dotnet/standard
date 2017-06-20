# System.Data.Services.Internal

``` diff
+namespace System.Data.Services.Internal {
+    public abstract class ExpandedWrapper<TExpandedElement> : IExpandedResult {
+        protected ExpandedWrapper();
+        public string Description { get; set; }
+        public TExpandedElement ExpandedElement { get; set; }
+        object System.Data.Services.IExpandedResult.ExpandedElement { get; }
+        public object GetExpandedPropertyValue(string name);
+        protected abstract object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        public TProperty4 ProjectedProperty4 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        public TProperty4 ProjectedProperty4 { get; set; }
+        public TProperty5 ProjectedProperty5 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        public TProperty4 ProjectedProperty4 { get; set; }
+        public TProperty5 ProjectedProperty5 { get; set; }
+        public TProperty6 ProjectedProperty6 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        public TProperty4 ProjectedProperty4 { get; set; }
+        public TProperty5 ProjectedProperty5 { get; set; }
+        public TProperty6 ProjectedProperty6 { get; set; }
+        public TProperty7 ProjectedProperty7 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7, TProperty8> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        public TProperty4 ProjectedProperty4 { get; set; }
+        public TProperty5 ProjectedProperty5 { get; set; }
+        public TProperty6 ProjectedProperty6 { get; set; }
+        public TProperty7 ProjectedProperty7 { get; set; }
+        public TProperty8 ProjectedProperty8 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7, TProperty8, TProperty9> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        public TProperty4 ProjectedProperty4 { get; set; }
+        public TProperty5 ProjectedProperty5 { get; set; }
+        public TProperty6 ProjectedProperty6 { get; set; }
+        public TProperty7 ProjectedProperty7 { get; set; }
+        public TProperty8 ProjectedProperty8 { get; set; }
+        public TProperty9 ProjectedProperty9 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7, TProperty8, TProperty9, TProperty10> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty10 ProjectedProperty10 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        public TProperty4 ProjectedProperty4 { get; set; }
+        public TProperty5 ProjectedProperty5 { get; set; }
+        public TProperty6 ProjectedProperty6 { get; set; }
+        public TProperty7 ProjectedProperty7 { get; set; }
+        public TProperty8 ProjectedProperty8 { get; set; }
+        public TProperty9 ProjectedProperty9 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7, TProperty8, TProperty9, TProperty10, TProperty11> : ExpandedWrapper<TExpandedElement> {
+        public ExpandedWrapper();
+        public TProperty0 ProjectedProperty0 { get; set; }
+        public TProperty1 ProjectedProperty1 { get; set; }
+        public TProperty10 ProjectedProperty10 { get; set; }
+        public TProperty11 ProjectedProperty11 { get; set; }
+        public TProperty2 ProjectedProperty2 { get; set; }
+        public TProperty3 ProjectedProperty3 { get; set; }
+        public TProperty4 ProjectedProperty4 { get; set; }
+        public TProperty5 ProjectedProperty5 { get; set; }
+        public TProperty6 ProjectedProperty6 { get; set; }
+        public TProperty7 ProjectedProperty7 { get; set; }
+        public TProperty8 ProjectedProperty8 { get; set; }
+        public TProperty9 ProjectedProperty9 { get; set; }
+        protected override object InternalGetExpandedPropertyValue(int nameIndex);
+    }
+    public abstract class ProjectedWrapper {
+        protected ProjectedWrapper();
+        public string PropertyNameList { get; set; }
+        public string ResourceTypeName { get; set; }
+        public object GetProjectedPropertyValue(string propertyName);
+        protected abstract object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper0 : ProjectedWrapper {
+        public ProjectedWrapper0();
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper1 : ProjectedWrapper {
+        public ProjectedWrapper1();
+        public object ProjectedProperty0 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper2 : ProjectedWrapper {
+        public ProjectedWrapper2();
+        public object ProjectedProperty0 { get; set; }
+        public object ProjectedProperty1 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper3 : ProjectedWrapper {
+        public ProjectedWrapper3();
+        public object ProjectedProperty0 { get; set; }
+        public object ProjectedProperty1 { get; set; }
+        public object ProjectedProperty2 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper4 : ProjectedWrapper {
+        public ProjectedWrapper4();
+        public object ProjectedProperty0 { get; set; }
+        public object ProjectedProperty1 { get; set; }
+        public object ProjectedProperty2 { get; set; }
+        public object ProjectedProperty3 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper5 : ProjectedWrapper {
+        public ProjectedWrapper5();
+        public object ProjectedProperty0 { get; set; }
+        public object ProjectedProperty1 { get; set; }
+        public object ProjectedProperty2 { get; set; }
+        public object ProjectedProperty3 { get; set; }
+        public object ProjectedProperty4 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper6 : ProjectedWrapper {
+        public ProjectedWrapper6();
+        public object ProjectedProperty0 { get; set; }
+        public object ProjectedProperty1 { get; set; }
+        public object ProjectedProperty2 { get; set; }
+        public object ProjectedProperty3 { get; set; }
+        public object ProjectedProperty4 { get; set; }
+        public object ProjectedProperty5 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper7 : ProjectedWrapper {
+        public ProjectedWrapper7();
+        public object ProjectedProperty0 { get; set; }
+        public object ProjectedProperty1 { get; set; }
+        public object ProjectedProperty2 { get; set; }
+        public object ProjectedProperty3 { get; set; }
+        public object ProjectedProperty4 { get; set; }
+        public object ProjectedProperty5 { get; set; }
+        public object ProjectedProperty6 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapper8 : ProjectedWrapper {
+        public ProjectedWrapper8();
+        public object ProjectedProperty0 { get; set; }
+        public object ProjectedProperty1 { get; set; }
+        public object ProjectedProperty2 { get; set; }
+        public object ProjectedProperty3 { get; set; }
+        public object ProjectedProperty4 { get; set; }
+        public object ProjectedProperty5 { get; set; }
+        public object ProjectedProperty6 { get; set; }
+        public object ProjectedProperty7 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public class ProjectedWrapperMany : ProjectedWrapper {
+        public ProjectedWrapperMany();
+        public ProjectedWrapperMany Next { get; set; }
+        public object ProjectedProperty0 { get; set; }
+        public object ProjectedProperty1 { get; set; }
+        public object ProjectedProperty2 { get; set; }
+        public object ProjectedProperty3 { get; set; }
+        public object ProjectedProperty4 { get; set; }
+        public object ProjectedProperty5 { get; set; }
+        public object ProjectedProperty6 { get; set; }
+        public object ProjectedProperty7 { get; set; }
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+    public sealed class ProjectedWrapperManyEnd : ProjectedWrapperMany {
+        public ProjectedWrapperManyEnd();
+        protected override object InternalGetProjectedPropertyValue(int propertyIndex);
+    }
+}
```

