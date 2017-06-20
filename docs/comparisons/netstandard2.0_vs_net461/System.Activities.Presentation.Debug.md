# System.Activities.Presentation.Debug

``` diff
+namespace System.Activities.Presentation.Debug {
+    public enum BreakpointTypes {
+        Bounded = 2,
+        Conditional = 4,
+        Enabled = 1,
+        None = 0,
+    }
+    public class DebuggerService : IDesignerDebugView {
+        public DebuggerService(EditingContext context);
+        public SourceLocation CurrentContext { get; set; }
+        public SourceLocation CurrentLocation { get; set; }
+        public bool HideSourceFileName { get; set; }
+        public bool IsDebugging { get; set; }
+        public SourceLocation SelectedLocation { get; }
+        public void DeleteBreakpoint(SourceLocation sourceLocation);
+        public void EnsureVisible(SourceLocation sourceLocation);
+        public IDictionary<SourceLocation, BreakpointTypes> GetBreakpointLocations();
+        public SourceLocation GetExactLocation(SourceLocation approximateLocation);
+        public void InsertBreakpoint(SourceLocation sourceLocation, BreakpointTypes breakpointType);
+        public void ResetBreakpoints();
+        public void UpdateBreakpoint(SourceLocation sourceLocation, BreakpointTypes newBreakpointType);
+        public void UpdateSourceLocations(Dictionary<object, SourceLocation> newSourceLocationMapping);
+    }
+    public interface IDesignerDebugView {
+        SourceLocation CurrentContext { get; set; }
+        SourceLocation CurrentLocation { get; set; }
+        bool HideSourceFileName { get; set; }
+        bool IsDebugging { get; set; }
+        SourceLocation SelectedLocation { get; }
+        void DeleteBreakpoint(SourceLocation sourceLocation);
+        void EnsureVisible(SourceLocation sourceLocation);
+        IDictionary<SourceLocation, BreakpointTypes> GetBreakpointLocations();
+        SourceLocation GetExactLocation(SourceLocation approximateLocation);
+        void InsertBreakpoint(SourceLocation sourceLocation, BreakpointTypes breakpointType);
+        void ResetBreakpoints();
+        void UpdateBreakpoint(SourceLocation sourceLocation, BreakpointTypes breakpointType);
+    }
+}
```

