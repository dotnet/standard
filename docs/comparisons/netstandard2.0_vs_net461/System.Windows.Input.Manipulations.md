# System.Windows.Input.Manipulations

``` diff
+namespace System.Windows.Input.Manipulations {
+    public sealed class InertiaExpansionBehavior2D : InertiaParameters2D {
+        public InertiaExpansionBehavior2D();
+        public float DesiredDeceleration { get; set; }
+        public float DesiredExpansionX { get; set; }
+        public float DesiredExpansionY { get; set; }
+        public float InitialRadius { get; set; }
+        public float InitialVelocityX { get; set; }
+        public float InitialVelocityY { get; set; }
+    }
+    public abstract class InertiaParameters2D
+    public class InertiaProcessor2D {
+        public InertiaProcessor2D();
+        public InertiaExpansionBehavior2D ExpansionBehavior { get; set; }
+        public float InitialOriginX { get; set; }
+        public float InitialOriginY { get; set; }
+        public bool IsRunning { get; }
+        public InertiaRotationBehavior2D RotationBehavior { get; set; }
+        public InertiaTranslationBehavior2D TranslationBehavior { get; set; }
+        public event EventHandler<Manipulation2DCompletedEventArgs> Completed;
+        public event EventHandler<Manipulation2DDeltaEventArgs> Delta;
+        public void Complete(long timestamp);
+        public bool Process(long timestamp);
+        public void SetParameters(InertiaParameters2D parameters);
+    }
+    public sealed class InertiaRotationBehavior2D : InertiaParameters2D {
+        public InertiaRotationBehavior2D();
+        public float DesiredDeceleration { get; set; }
+        public float DesiredRotation { get; set; }
+        public float InitialVelocity { get; set; }
+    }
+    public sealed class InertiaTranslationBehavior2D : InertiaParameters2D {
+        public InertiaTranslationBehavior2D();
+        public float DesiredDeceleration { get; set; }
+        public float DesiredDisplacement { get; set; }
+        public float InitialVelocityX { get; set; }
+        public float InitialVelocityY { get; set; }
+    }
+    public class Manipulation2DCompletedEventArgs : EventArgs {
+        public float OriginX { get; }
+        public float OriginY { get; }
+        public ManipulationDelta2D Total { get; }
+        public ManipulationVelocities2D Velocities { get; }
+    }
+    public class Manipulation2DDeltaEventArgs : EventArgs {
+        public ManipulationDelta2D Cumulative { get; }
+        public ManipulationDelta2D Delta { get; }
+        public float OriginX { get; }
+        public float OriginY { get; }
+        public ManipulationVelocities2D Velocities { get; }
+    }
+    public class Manipulation2DStartedEventArgs : EventArgs {
+        public float OriginX { get; }
+        public float OriginY { get; }
+    }
+    public class ManipulationDelta2D {
+        public float ExpansionX { get; }
+        public float ExpansionY { get; }
+        public float Rotation { get; }
+        public float ScaleX { get; }
+        public float ScaleY { get; }
+        public float TranslationX { get; }
+        public float TranslationY { get; }
+    }
+    public abstract class ManipulationParameters2D
+    public sealed class ManipulationPivot2D : ManipulationParameters2D {
+        public ManipulationPivot2D();
+        public float Radius { get; set; }
+        public float X { get; set; }
+        public float Y { get; set; }
+    }
+    public class ManipulationProcessor2D {
+        public ManipulationProcessor2D(Manipulations2D supportedManipulations);
+        public ManipulationProcessor2D(Manipulations2D supportedManipulations, ManipulationPivot2D pivot);
+        public float MinimumScaleRotateRadius { get; set; }
+        public ManipulationPivot2D Pivot { get; set; }
+        public Manipulations2D SupportedManipulations { get; set; }
+        public event EventHandler<Manipulation2DCompletedEventArgs> Completed;
+        public event EventHandler<Manipulation2DDeltaEventArgs> Delta;
+        public event EventHandler<Manipulation2DStartedEventArgs> Started;
+        public void CompleteManipulation(long timestamp);
+        public void ProcessManipulators(long timestamp, IEnumerable<Manipulator2D> manipulators);
+        public void SetParameters(ManipulationParameters2D parameters);
+    }
+    public enum Manipulations2D {
+        All = 15,
+        None = 0,
+        Rotate = 8,
+        Scale = 4,
+        Translate = 3,
+        TranslateX = 1,
+        TranslateY = 2,
+    }
+    public class ManipulationVelocities2D {
+        public static readonly ManipulationVelocities2D Zero;
+        public float AngularVelocity { get; }
+        public float ExpansionVelocityX { get; }
+        public float ExpansionVelocityY { get; }
+        public float LinearVelocityX { get; }
+        public float LinearVelocityY { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Manipulator2D {
+        public Manipulator2D(int id, float x, float y);
+        public int Id { get; set; }
+        public float X { get; set; }
+        public float Y { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(Manipulator2D manipulator1, Manipulator2D manipulator2);
+        public static bool operator !=(Manipulator2D manipulator1, Manipulator2D manipulator2);
+    }
+}
```

