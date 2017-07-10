# System.Windows.Media.Media3D

``` diff
+namespace System.Windows.Media.Media3D {
+    public abstract class AffineTransform3D : Transform3D {
+        public override bool IsAffine { get; }
+        public new AffineTransform3D Clone();
+        public new AffineTransform3D CloneCurrentValue();
+    }
+    public sealed class AmbientLight : Light {
+        public AmbientLight();
+        public AmbientLight(Color ambientColor);
+        public new AmbientLight Clone();
+        public new AmbientLight CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class AxisAngleRotation3D : Rotation3D {
+        public static readonly DependencyProperty AngleProperty;
+        public static readonly DependencyProperty AxisProperty;
+        public AxisAngleRotation3D();
+        public AxisAngleRotation3D(Vector3D axis, double angle);
+        public double Angle { get; set; }
+        public Vector3D Axis { get; set; }
+        public new AxisAngleRotation3D Clone();
+        public new AxisAngleRotation3D CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public abstract class Camera : Animatable, DUCE.IResource, IFormattable {
+        public static readonly DependencyProperty TransformProperty;
+        public Transform3D Transform { get; set; }
+        public new Camera Clone();
+        public new Camera CloneCurrentValue();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class ContainerUIElement3D : UIElement3D {
+        public ContainerUIElement3D();
+        public Visual3DCollection Children { get; }
+        protected override int Visual3DChildrenCount { get; }
+        protected override Visual3D GetVisual3DChild(int index);
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public sealed class DiffuseMaterial : Material {
+        public static readonly DependencyProperty AmbientColorProperty;
+        public static readonly DependencyProperty BrushProperty;
+        public static readonly DependencyProperty ColorProperty;
+        public DiffuseMaterial();
+        public DiffuseMaterial(Brush brush);
+        public Color AmbientColor { get; set; }
+        public Brush Brush { get; set; }
+        public Color Color { get; set; }
+        public new DiffuseMaterial Clone();
+        public new DiffuseMaterial CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class DirectionalLight : Light {
+        public static readonly DependencyProperty DirectionProperty;
+        public DirectionalLight();
+        public DirectionalLight(Color diffuseColor, Vector3D direction);
+        public Vector3D Direction { get; set; }
+        public new DirectionalLight Clone();
+        public new DirectionalLight CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class EmissiveMaterial : Material {
+        public static readonly DependencyProperty BrushProperty;
+        public static readonly DependencyProperty ColorProperty;
+        public EmissiveMaterial();
+        public EmissiveMaterial(Brush brush);
+        public Brush Brush { get; set; }
+        public Color Color { get; set; }
+        public new EmissiveMaterial Clone();
+        public new EmissiveMaterial CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public class GeneralTransform2DTo3D : Freezable {
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public Point3D Transform(Point point);
+        public bool TryTransform(Point inPoint, out Point3D result);
+    }
+    public abstract class GeneralTransform3D : Animatable, IFormattable {
+        public abstract GeneralTransform3D Inverse { get; }
+        public new GeneralTransform3D Clone();
+        public new GeneralTransform3D CloneCurrentValue();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        public Point3D Transform(Point3D point);
+        public abstract Rect3D TransformBounds(Rect3D rect);
+        public abstract bool TryTransform(Point3D inPoint, out Point3D result);
+    }
+    public sealed class GeneralTransform3DCollection : Animatable, ICollection, ICollection<GeneralTransform3D>, IEnumerable, IEnumerable<GeneralTransform3D>, IList, IList<GeneralTransform3D> {
+        public GeneralTransform3DCollection();
+        public GeneralTransform3DCollection(IEnumerable<GeneralTransform3D> collection);
+        public GeneralTransform3DCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Media3D.GeneralTransform3D>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public GeneralTransform3D this[int index] { get; set; }
+        public void Add(GeneralTransform3D value);
+        public void Clear();
+        public new GeneralTransform3DCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new GeneralTransform3DCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(GeneralTransform3D value);
+        public void CopyTo(GeneralTransform3D[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public GeneralTransform3DCollection.Enumerator GetEnumerator();
+        public int IndexOf(GeneralTransform3D value);
+        public void Insert(int index, GeneralTransform3D value);
+        public bool Remove(GeneralTransform3D value);
+        public void RemoveAt(int index);
+        IEnumerator<GeneralTransform3D> System.Collections.Generic.IEnumerable<System.Windows.Media.Media3D.GeneralTransform3D>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<GeneralTransform3D> {
+            public GeneralTransform3D Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class GeneralTransform3DGroup : GeneralTransform3D {
+        public static readonly DependencyProperty ChildrenProperty;
+        public GeneralTransform3DGroup();
+        public GeneralTransform3DCollection Children { get; set; }
+        public override GeneralTransform3D Inverse { get; }
+        public new GeneralTransform3DGroup Clone();
+        public new GeneralTransform3DGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public override Rect3D TransformBounds(Rect3D rect);
+        public override bool TryTransform(Point3D inPoint, out Point3D result);
+    }
+    public class GeneralTransform3DTo2D : Freezable {
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public Point Transform(Point3D point);
+        public Rect TransformBounds(Rect3D rect3D);
+        public bool TryTransform(Point3D inPoint, out Point result);
+    }
+    public abstract class Geometry3D : Animatable, DUCE.IResource {
+        public abstract Rect3D Bounds { get; }
+        public new Geometry3D Clone();
+        public new Geometry3D CloneCurrentValue();
+    }
+    public sealed class GeometryModel3D : Model3D {
+        public static readonly DependencyProperty BackMaterialProperty;
+        public static readonly DependencyProperty GeometryProperty;
+        public static readonly DependencyProperty MaterialProperty;
+        public GeometryModel3D();
+        public GeometryModel3D(Geometry3D geometry, Material material);
+        public Material BackMaterial { get; set; }
+        public Geometry3D Geometry { get; set; }
+        public Material Material { get; set; }
+        public new GeometryModel3D Clone();
+        public new GeometryModel3D CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public abstract class HitTestParameters3D
+    public abstract class Light : Model3D {
+        public static readonly DependencyProperty ColorProperty;
+        public Color Color { get; set; }
+        public new Light Clone();
+        public new Light CloneCurrentValue();
+    }
+    public abstract class Material : Animatable, DUCE.IResource, IFormattable {
+        public new Material Clone();
+        public new Material CloneCurrentValue();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class MaterialCollection : Animatable, ICollection, ICollection<Material>, IEnumerable, IEnumerable<Material>, IList, IList<Material> {
+        public MaterialCollection();
+        public MaterialCollection(IEnumerable<Material> collection);
+        public MaterialCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Media3D.Material>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Material this[int index] { get; set; }
+        public void Add(Material value);
+        public void Clear();
+        public new MaterialCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new MaterialCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Material value);
+        public void CopyTo(Material[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public MaterialCollection.Enumerator GetEnumerator();
+        public int IndexOf(Material value);
+        public void Insert(int index, Material value);
+        public bool Remove(Material value);
+        public void RemoveAt(int index);
+        IEnumerator<Material> System.Collections.Generic.IEnumerable<System.Windows.Media.Media3D.Material>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Material> {
+            public Material Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class MaterialGroup : Material {
+        public static readonly DependencyProperty ChildrenProperty;
+        public MaterialGroup();
+        public MaterialCollection Children { get; set; }
+        public new MaterialGroup Clone();
+        public new MaterialGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Matrix3D : IFormattable {
+        public Matrix3D(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double offsetX, double offsetY, double offsetZ, double m44);
+        public double Determinant { get; }
+        public bool HasInverse { get; }
+        public static Matrix3D Identity { get; }
+        public bool IsAffine { get; }
+        public bool IsIdentity { get; }
+        public double M11 { get; set; }
+        public double M12 { get; set; }
+        public double M13 { get; set; }
+        public double M14 { get; set; }
+        public double M21 { get; set; }
+        public double M22 { get; set; }
+        public double M23 { get; set; }
+        public double M24 { get; set; }
+        public double M31 { get; set; }
+        public double M32 { get; set; }
+        public double M33 { get; set; }
+        public double M34 { get; set; }
+        public double M44 { get; set; }
+        public double OffsetX { get; set; }
+        public double OffsetY { get; set; }
+        public double OffsetZ { get; set; }
+        public void Append(Matrix3D matrix);
+        public override bool Equals(object o);
+        public bool Equals(Matrix3D value);
+        public static bool Equals(Matrix3D matrix1, Matrix3D matrix2);
+        public override int GetHashCode();
+        public void Invert();
+        public static Matrix3D Multiply(Matrix3D matrix1, Matrix3D matrix2);
+        public static bool operator ==(Matrix3D matrix1, Matrix3D matrix2);
+        public static bool operator !=(Matrix3D matrix1, Matrix3D matrix2);
+        public static Matrix3D operator *(Matrix3D matrix1, Matrix3D matrix2);
+        public static Matrix3D Parse(string source);
+        public void Prepend(Matrix3D matrix);
+        public void Rotate(Quaternion quaternion);
+        public void RotateAt(Quaternion quaternion, Point3D center);
+        public void RotateAtPrepend(Quaternion quaternion, Point3D center);
+        public void RotatePrepend(Quaternion quaternion);
+        public void Scale(Vector3D scale);
+        public void ScaleAt(Vector3D scale, Point3D center);
+        public void ScaleAtPrepend(Vector3D scale, Point3D center);
+        public void ScalePrepend(Vector3D scale);
+        public void SetIdentity();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        public Point3D Transform(Point3D point);
+        public void Transform(Point3D[] points);
+        public Point4D Transform(Point4D point);
+        public void Transform(Point4D[] points);
+        public Vector3D Transform(Vector3D vector);
+        public void Transform(Vector3D[] vectors);
+        public void Translate(Vector3D offset);
+        public void TranslatePrepend(Vector3D offset);
+    }
+    public sealed class Matrix3DConverter : TypeConverter {
+        public Matrix3DConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class MatrixCamera : Camera {
+        public static readonly DependencyProperty ProjectionMatrixProperty;
+        public static readonly DependencyProperty ViewMatrixProperty;
+        public MatrixCamera();
+        public MatrixCamera(Matrix3D viewMatrix, Matrix3D projectionMatrix);
+        public Matrix3D ProjectionMatrix { get; set; }
+        public Matrix3D ViewMatrix { get; set; }
+        public new MatrixCamera Clone();
+        public new MatrixCamera CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class MatrixTransform3D : Transform3D {
+        public static readonly DependencyProperty MatrixProperty;
+        public MatrixTransform3D();
+        public MatrixTransform3D(Matrix3D matrix);
+        public override bool IsAffine { get; }
+        public Matrix3D Matrix { get; set; }
+        public override Matrix3D Value { get; }
+        public new MatrixTransform3D Clone();
+        public new MatrixTransform3D CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class MeshGeometry3D : Geometry3D {
+        public static readonly DependencyProperty NormalsProperty;
+        public static readonly DependencyProperty PositionsProperty;
+        public static readonly DependencyProperty TextureCoordinatesProperty;
+        public static readonly DependencyProperty TriangleIndicesProperty;
+        public MeshGeometry3D();
+        public override Rect3D Bounds { get; }
+        public Vector3DCollection Normals { get; set; }
+        public Point3DCollection Positions { get; set; }
+        public PointCollection TextureCoordinates { get; set; }
+        public Int32Collection TriangleIndices { get; set; }
+        public new MeshGeometry3D Clone();
+        public new MeshGeometry3D CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+    }
+    public abstract class Model3D : Animatable, DUCE.IResource, IFormattable {
+        public static readonly DependencyProperty TransformProperty;
+        public Rect3D Bounds { get; }
+        public Transform3D Transform { get; set; }
+        public new Model3D Clone();
+        public new Model3D CloneCurrentValue();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class Model3DCollection : Animatable, ICollection, ICollection<Model3D>, IEnumerable, IEnumerable<Model3D>, IList, IList<Model3D> {
+        public Model3DCollection();
+        public Model3DCollection(IEnumerable<Model3D> collection);
+        public Model3DCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Media3D.Model3D>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Model3D this[int index] { get; set; }
+        public void Add(Model3D value);
+        public void Clear();
+        public new Model3DCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new Model3DCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Model3D value);
+        public void CopyTo(Model3D[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public Model3DCollection.Enumerator GetEnumerator();
+        public int IndexOf(Model3D value);
+        public void Insert(int index, Model3D value);
+        public bool Remove(Model3D value);
+        public void RemoveAt(int index);
+        IEnumerator<Model3D> System.Collections.Generic.IEnumerable<System.Windows.Media.Media3D.Model3D>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Model3D> {
+            public Model3D Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class Model3DGroup : Model3D {
+        public static readonly DependencyProperty ChildrenProperty;
+        public Model3DGroup();
+        public Model3DCollection Children { get; set; }
+        public new Model3DGroup Clone();
+        public new Model3DGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class ModelUIElement3D : UIElement3D {
+        public static readonly DependencyProperty ModelProperty;
+        public ModelUIElement3D();
+        public Model3D Model { get; set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public class ModelVisual3D : Visual3D, IAddChild {
+        public static readonly DependencyProperty ContentProperty;
+        public static readonly new DependencyProperty TransformProperty;
+        public ModelVisual3D();
+        public Visual3DCollection Children { get; }
+        public Model3D Content { get; set; }
+        public new Transform3D Transform { get; set; }
+        protected sealed override int Visual3DChildrenCount { get; }
+        protected sealed override Visual3D GetVisual3DChild(int index);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class OrthographicCamera : ProjectionCamera {
+        public static readonly DependencyProperty WidthProperty;
+        public OrthographicCamera();
+        public OrthographicCamera(Point3D position, Vector3D lookDirection, Vector3D upDirection, double width);
+        public double Width { get; set; }
+        public new OrthographicCamera Clone();
+        public new OrthographicCamera CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class PerspectiveCamera : ProjectionCamera {
+        public static readonly DependencyProperty FieldOfViewProperty;
+        public PerspectiveCamera();
+        public PerspectiveCamera(Point3D position, Vector3D lookDirection, Vector3D upDirection, double fieldOfView);
+        public double FieldOfView { get; set; }
+        public new PerspectiveCamera Clone();
+        public new PerspectiveCamera CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Point3D : IFormattable {
+        public Point3D(double x, double y, double z);
+        public double X { get; set; }
+        public double Y { get; set; }
+        public double Z { get; set; }
+        public static Point3D Add(Point3D point, Vector3D vector);
+        public override bool Equals(object o);
+        public bool Equals(Point3D value);
+        public static bool Equals(Point3D point1, Point3D point2);
+        public override int GetHashCode();
+        public static Point3D Multiply(Point3D point, Matrix3D matrix);
+        public void Offset(double offsetX, double offsetY, double offsetZ);
+        public static Point3D operator +(Point3D point, Vector3D vector);
+        public static bool operator ==(Point3D point1, Point3D point2);
+        public static explicit operator Vector3D (Point3D point);
+        public static explicit operator Point4D (Point3D point);
+        public static bool operator !=(Point3D point1, Point3D point2);
+        public static Point3D operator *(Point3D point, Matrix3D matrix);
+        public static Vector3D operator -(Point3D point1, Point3D point2);
+        public static Point3D operator -(Point3D point, Vector3D vector);
+        public static Point3D Parse(string source);
+        public static Vector3D Subtract(Point3D point1, Point3D point2);
+        public static Point3D Subtract(Point3D point, Vector3D vector);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class Point3DCollection : Freezable, ICollection, ICollection<Point3D>, IEnumerable, IEnumerable<Point3D>, IFormattable, IList, IList<Point3D> {
+        public Point3DCollection();
+        public Point3DCollection(IEnumerable<Point3D> collection);
+        public Point3DCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Media3D.Point3D>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Point3D this[int index] { get; set; }
+        public void Add(Point3D value);
+        public void Clear();
+        public new Point3DCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new Point3DCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Point3D value);
+        public void CopyTo(Point3D[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public Point3DCollection.Enumerator GetEnumerator();
+        public int IndexOf(Point3D value);
+        public void Insert(int index, Point3D value);
+        public static Point3DCollection Parse(string source);
+        public bool Remove(Point3D value);
+        public void RemoveAt(int index);
+        IEnumerator<Point3D> System.Collections.Generic.IEnumerable<System.Windows.Media.Media3D.Point3D>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Point3D> {
+            public Point3D Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class Point3DCollectionConverter : TypeConverter {
+        public Point3DCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class Point3DConverter : TypeConverter {
+        public Point3DConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Point4D : IFormattable {
+        public Point4D(double x, double y, double z, double w);
+        public double W { get; set; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public double Z { get; set; }
+        public static Point4D Add(Point4D point1, Point4D point2);
+        public override bool Equals(object o);
+        public bool Equals(Point4D value);
+        public static bool Equals(Point4D point1, Point4D point2);
+        public override int GetHashCode();
+        public static Point4D Multiply(Point4D point, Matrix3D matrix);
+        public void Offset(double deltaX, double deltaY, double deltaZ, double deltaW);
+        public static Point4D operator +(Point4D point1, Point4D point2);
+        public static bool operator ==(Point4D point1, Point4D point2);
+        public static bool operator !=(Point4D point1, Point4D point2);
+        public static Point4D operator *(Point4D point, Matrix3D matrix);
+        public static Point4D operator -(Point4D point1, Point4D point2);
+        public static Point4D Parse(string source);
+        public static Point4D Subtract(Point4D point1, Point4D point2);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class Point4DConverter : TypeConverter {
+        public Point4DConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class PointLight : PointLightBase {
+        public PointLight();
+        public PointLight(Color diffuseColor, Point3D position);
+        public new PointLight Clone();
+        public new PointLight CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public abstract class PointLightBase : Light {
+        public static readonly DependencyProperty ConstantAttenuationProperty;
+        public static readonly DependencyProperty LinearAttenuationProperty;
+        public static readonly DependencyProperty PositionProperty;
+        public static readonly DependencyProperty QuadraticAttenuationProperty;
+        public static readonly DependencyProperty RangeProperty;
+        public double ConstantAttenuation { get; set; }
+        public double LinearAttenuation { get; set; }
+        public Point3D Position { get; set; }
+        public double QuadraticAttenuation { get; set; }
+        public double Range { get; set; }
+        public new PointLightBase Clone();
+        public new PointLightBase CloneCurrentValue();
+    }
+    public abstract class ProjectionCamera : Camera {
+        public static readonly DependencyProperty FarPlaneDistanceProperty;
+        public static readonly DependencyProperty LookDirectionProperty;
+        public static readonly DependencyProperty NearPlaneDistanceProperty;
+        public static readonly DependencyProperty PositionProperty;
+        public static readonly DependencyProperty UpDirectionProperty;
+        public double FarPlaneDistance { get; set; }
+        public Vector3D LookDirection { get; set; }
+        public double NearPlaneDistance { get; set; }
+        public Point3D Position { get; set; }
+        public Vector3D UpDirection { get; set; }
+        public new ProjectionCamera Clone();
+        public new ProjectionCamera CloneCurrentValue();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Quaternion : IFormattable {
+        public Quaternion(double x, double y, double z, double w);
+        public Quaternion(Vector3D axisOfRotation, double angleInDegrees);
+        public double Angle { get; }
+        public Vector3D Axis { get; }
+        public static Quaternion Identity { get; }
+        public bool IsIdentity { get; }
+        public bool IsNormalized { get; }
+        public double W { get; set; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public double Z { get; set; }
+        public static Quaternion Add(Quaternion left, Quaternion right);
+        public void Conjugate();
+        public override bool Equals(object o);
+        public bool Equals(Quaternion value);
+        public static bool Equals(Quaternion quaternion1, Quaternion quaternion2);
+        public override int GetHashCode();
+        public void Invert();
+        public static Quaternion Multiply(Quaternion left, Quaternion right);
+        public void Normalize();
+        public static Quaternion operator +(Quaternion left, Quaternion right);
+        public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2);
+        public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2);
+        public static Quaternion operator *(Quaternion left, Quaternion right);
+        public static Quaternion operator -(Quaternion left, Quaternion right);
+        public static Quaternion Parse(string source);
+        public static Quaternion Slerp(Quaternion from, Quaternion to, double t);
+        public static Quaternion Slerp(Quaternion from, Quaternion to, double t, bool useShortestPath);
+        public static Quaternion Subtract(Quaternion left, Quaternion right);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class QuaternionConverter : TypeConverter {
+        public QuaternionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class QuaternionRotation3D : Rotation3D {
+        public static readonly DependencyProperty QuaternionProperty;
+        public QuaternionRotation3D();
+        public QuaternionRotation3D(Quaternion quaternion);
+        public Quaternion Quaternion { get; set; }
+        public new QuaternionRotation3D Clone();
+        public new QuaternionRotation3D CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class RayHitTestParameters : HitTestParameters3D {
+        public RayHitTestParameters(Point3D origin, Vector3D direction);
+        public Vector3D Direction { get; }
+        public Point3D Origin { get; }
+    }
+    public abstract class RayHitTestResult : HitTestResult {
+        public abstract double DistanceToRayOrigin { get; }
+        public Model3D ModelHit { get; }
+        public abstract Point3D PointHit { get; }
+        public new Visual3D VisualHit { get; }
+    }
+    public sealed class RayMeshGeometry3DHitTestResult : RayHitTestResult {
+        public override double DistanceToRayOrigin { get; }
+        public MeshGeometry3D MeshHit { get; }
+        public override Point3D PointHit { get; }
+        public int VertexIndex1 { get; }
+        public int VertexIndex2 { get; }
+        public int VertexIndex3 { get; }
+        public double VertexWeight1 { get; }
+        public double VertexWeight2 { get; }
+        public double VertexWeight3 { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Rect3D : IFormattable {
+        public Rect3D(double x, double y, double z, double sizeX, double sizeY, double sizeZ);
+        public Rect3D(Point3D location, Size3D size);
+        public static Rect3D Empty { get; }
+        public bool IsEmpty { get; }
+        public Point3D Location { get; set; }
+        public Size3D Size { get; set; }
+        public double SizeX { get; set; }
+        public double SizeY { get; set; }
+        public double SizeZ { get; set; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public double Z { get; set; }
+        public bool Contains(double x, double y, double z);
+        public bool Contains(Point3D point);
+        public bool Contains(Rect3D rect);
+        public override bool Equals(object o);
+        public bool Equals(Rect3D value);
+        public static bool Equals(Rect3D rect1, Rect3D rect2);
+        public override int GetHashCode();
+        public void Intersect(Rect3D rect);
+        public static Rect3D Intersect(Rect3D rect1, Rect3D rect2);
+        public bool IntersectsWith(Rect3D rect);
+        public void Offset(double offsetX, double offsetY, double offsetZ);
+        public static Rect3D Offset(Rect3D rect, double offsetX, double offsetY, double offsetZ);
+        public static Rect3D Offset(Rect3D rect, Vector3D offsetVector);
+        public void Offset(Vector3D offsetVector);
+        public static bool operator ==(Rect3D rect1, Rect3D rect2);
+        public static bool operator !=(Rect3D rect1, Rect3D rect2);
+        public static Rect3D Parse(string source);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        public void Union(Point3D point);
+        public void Union(Rect3D rect);
+        public static Rect3D Union(Rect3D rect, Point3D point);
+        public static Rect3D Union(Rect3D rect1, Rect3D rect2);
+    }
+    public sealed class Rect3DConverter : TypeConverter {
+        public Rect3DConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class RotateTransform3D : AffineTransform3D {
+        public static readonly DependencyProperty CenterXProperty;
+        public static readonly DependencyProperty CenterYProperty;
+        public static readonly DependencyProperty CenterZProperty;
+        public static readonly DependencyProperty RotationProperty;
+        public RotateTransform3D();
+        public RotateTransform3D(Rotation3D rotation);
+        public RotateTransform3D(Rotation3D rotation, double centerX, double centerY, double centerZ);
+        public RotateTransform3D(Rotation3D rotation, Point3D center);
+        public double CenterX { get; set; }
+        public double CenterY { get; set; }
+        public double CenterZ { get; set; }
+        public Rotation3D Rotation { get; set; }
+        public override Matrix3D Value { get; }
+        public new RotateTransform3D Clone();
+        public new RotateTransform3D CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public abstract class Rotation3D : Animatable, DUCE.IResource, IFormattable {
+        public static Rotation3D Identity { get; }
+        public new Rotation3D Clone();
+        public new Rotation3D CloneCurrentValue();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class ScaleTransform3D : AffineTransform3D {
+        public static readonly DependencyProperty CenterXProperty;
+        public static readonly DependencyProperty CenterYProperty;
+        public static readonly DependencyProperty CenterZProperty;
+        public static readonly DependencyProperty ScaleXProperty;
+        public static readonly DependencyProperty ScaleYProperty;
+        public static readonly DependencyProperty ScaleZProperty;
+        public ScaleTransform3D();
+        public ScaleTransform3D(double scaleX, double scaleY, double scaleZ);
+        public ScaleTransform3D(double scaleX, double scaleY, double scaleZ, double centerX, double centerY, double centerZ);
+        public ScaleTransform3D(Vector3D scale);
+        public ScaleTransform3D(Vector3D scale, Point3D center);
+        public double CenterX { get; set; }
+        public double CenterY { get; set; }
+        public double CenterZ { get; set; }
+        public double ScaleX { get; set; }
+        public double ScaleY { get; set; }
+        public double ScaleZ { get; set; }
+        public override Matrix3D Value { get; }
+        public new ScaleTransform3D Clone();
+        public new ScaleTransform3D CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Size3D : IFormattable {
+        public Size3D(double x, double y, double z);
+        public static Size3D Empty { get; }
+        public bool IsEmpty { get; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public double Z { get; set; }
+        public override bool Equals(object o);
+        public bool Equals(Size3D value);
+        public static bool Equals(Size3D size1, Size3D size2);
+        public override int GetHashCode();
+        public static bool operator ==(Size3D size1, Size3D size2);
+        public static explicit operator Vector3D (Size3D size);
+        public static explicit operator Point3D (Size3D size);
+        public static bool operator !=(Size3D size1, Size3D size2);
+        public static Size3D Parse(string source);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class Size3DConverter : TypeConverter {
+        public Size3DConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class SpecularMaterial : Material {
+        public static readonly DependencyProperty BrushProperty;
+        public static readonly DependencyProperty ColorProperty;
+        public static readonly DependencyProperty SpecularPowerProperty;
+        public SpecularMaterial();
+        public SpecularMaterial(Brush brush, double specularPower);
+        public Brush Brush { get; set; }
+        public Color Color { get; set; }
+        public double SpecularPower { get; set; }
+        public new SpecularMaterial Clone();
+        public new SpecularMaterial CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class SpotLight : PointLightBase {
+        public static readonly DependencyProperty DirectionProperty;
+        public static readonly DependencyProperty InnerConeAngleProperty;
+        public static readonly DependencyProperty OuterConeAngleProperty;
+        public SpotLight();
+        public SpotLight(Color diffuseColor, Point3D position, Vector3D direction, double outerConeAngle, double innerConeAngle);
+        public Vector3D Direction { get; set; }
+        public double InnerConeAngle { get; set; }
+        public double OuterConeAngle { get; set; }
+        public new SpotLight Clone();
+        public new SpotLight CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public abstract class Transform3D : GeneralTransform3D, DUCE.IResource {
+        public static Transform3D Identity { get; }
+        public override GeneralTransform3D Inverse { get; }
+        public abstract bool IsAffine { get; }
+        public abstract Matrix3D Value { get; }
+        public new Transform3D Clone();
+        public new Transform3D CloneCurrentValue();
+        public new Point3D Transform(Point3D point);
+        public void Transform(Point3D[] points);
+        public Point4D Transform(Point4D point);
+        public void Transform(Point4D[] points);
+        public Vector3D Transform(Vector3D vector);
+        public void Transform(Vector3D[] vectors);
+        public override Rect3D TransformBounds(Rect3D rect);
+        public override bool TryTransform(Point3D inPoint, out Point3D result);
+    }
+    public sealed class Transform3DCollection : Animatable, ICollection, ICollection<Transform3D>, IEnumerable, IEnumerable<Transform3D>, IList, IList<Transform3D> {
+        public Transform3DCollection();
+        public Transform3DCollection(IEnumerable<Transform3D> collection);
+        public Transform3DCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Media3D.Transform3D>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Transform3D this[int index] { get; set; }
+        public void Add(Transform3D value);
+        public void Clear();
+        public new Transform3DCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new Transform3DCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Transform3D value);
+        public void CopyTo(Transform3D[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public Transform3DCollection.Enumerator GetEnumerator();
+        public int IndexOf(Transform3D value);
+        public void Insert(int index, Transform3D value);
+        public bool Remove(Transform3D value);
+        public void RemoveAt(int index);
+        IEnumerator<Transform3D> System.Collections.Generic.IEnumerable<System.Windows.Media.Media3D.Transform3D>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Transform3D> {
+            public Transform3D Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class Transform3DGroup : Transform3D {
+        public static readonly DependencyProperty ChildrenProperty;
+        public Transform3DGroup();
+        public Transform3DCollection Children { get; set; }
+        public override bool IsAffine { get; }
+        public override Matrix3D Value { get; }
+        public new Transform3DGroup Clone();
+        public new Transform3DGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class TranslateTransform3D : AffineTransform3D {
+        public static readonly DependencyProperty OffsetXProperty;
+        public static readonly DependencyProperty OffsetYProperty;
+        public static readonly DependencyProperty OffsetZProperty;
+        public TranslateTransform3D();
+        public TranslateTransform3D(double offsetX, double offsetY, double offsetZ);
+        public TranslateTransform3D(Vector3D offset);
+        public double OffsetX { get; set; }
+        public double OffsetY { get; set; }
+        public double OffsetZ { get; set; }
+        public override Matrix3D Value { get; }
+        public new TranslateTransform3D Clone();
+        public new TranslateTransform3D CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Vector3D : IFormattable {
+        public Vector3D(double x, double y, double z);
+        public double Length { get; }
+        public double LengthSquared { get; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public double Z { get; set; }
+        public static Point3D Add(Vector3D vector, Point3D point);
+        public static Vector3D Add(Vector3D vector1, Vector3D vector2);
+        public static double AngleBetween(Vector3D vector1, Vector3D vector2);
+        public static Vector3D CrossProduct(Vector3D vector1, Vector3D vector2);
+        public static Vector3D Divide(Vector3D vector, double scalar);
+        public static double DotProduct(Vector3D vector1, Vector3D vector2);
+        public override bool Equals(object o);
+        public bool Equals(Vector3D value);
+        public static bool Equals(Vector3D vector1, Vector3D vector2);
+        public override int GetHashCode();
+        public static Vector3D Multiply(double scalar, Vector3D vector);
+        public static Vector3D Multiply(Vector3D vector, double scalar);
+        public static Vector3D Multiply(Vector3D vector, Matrix3D matrix);
+        public void Negate();
+        public void Normalize();
+        public static Point3D operator +(Vector3D vector, Point3D point);
+        public static Vector3D operator +(Vector3D vector1, Vector3D vector2);
+        public static Vector3D operator /(Vector3D vector, double scalar);
+        public static bool operator ==(Vector3D vector1, Vector3D vector2);
+        public static explicit operator Point3D (Vector3D vector);
+        public static explicit operator Size3D (Vector3D vector);
+        public static bool operator !=(Vector3D vector1, Vector3D vector2);
+        public static Vector3D operator *(double scalar, Vector3D vector);
+        public static Vector3D operator *(Vector3D vector, double scalar);
+        public static Vector3D operator *(Vector3D vector, Matrix3D matrix);
+        public static Point3D operator -(Vector3D vector, Point3D point);
+        public static Vector3D operator -(Vector3D vector1, Vector3D vector2);
+        public static Vector3D operator -(Vector3D vector);
+        public static Vector3D Parse(string source);
+        public static Point3D Subtract(Vector3D vector, Point3D point);
+        public static Vector3D Subtract(Vector3D vector1, Vector3D vector2);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class Vector3DCollection : Freezable, ICollection, ICollection<Vector3D>, IEnumerable, IEnumerable<Vector3D>, IFormattable, IList, IList<Vector3D> {
+        public Vector3DCollection();
+        public Vector3DCollection(IEnumerable<Vector3D> collection);
+        public Vector3DCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Media3D.Vector3D>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Vector3D this[int index] { get; set; }
+        public void Add(Vector3D value);
+        public void Clear();
+        public new Vector3DCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new Vector3DCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Vector3D value);
+        public void CopyTo(Vector3D[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public Vector3DCollection.Enumerator GetEnumerator();
+        public int IndexOf(Vector3D value);
+        public void Insert(int index, Vector3D value);
+        public static Vector3DCollection Parse(string source);
+        public bool Remove(Vector3D value);
+        public void RemoveAt(int index);
+        IEnumerator<Vector3D> System.Collections.Generic.IEnumerable<System.Windows.Media.Media3D.Vector3D>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Vector3D> {
+            public Vector3D Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class Vector3DCollectionConverter : TypeConverter {
+        public Vector3DCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class Vector3DConverter : TypeConverter {
+        public Vector3DConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class Viewport2DVisual3D : Visual3D {
+        public static readonly DependencyProperty CacheModeProperty;
+        public static readonly DependencyProperty GeometryProperty;
+        public static readonly DependencyProperty IsVisualHostMaterialProperty;
+        public static readonly DependencyProperty MaterialProperty;
+        public static readonly DependencyProperty VisualProperty;
+        public Viewport2DVisual3D();
+        public CacheMode CacheMode { get; set; }
+        public Geometry3D Geometry { get; set; }
+        public Material Material { get; set; }
+        public Visual Visual { get; set; }
+        protected override int Visual3DChildrenCount { get; }
+        public static bool GetIsVisualHostMaterial(Material element);
+        protected override Visual3D GetVisual3DChild(int index);
+        public static void SetIsVisualHostMaterial(Material element, bool value);
+    }
+    public sealed class Viewport3DVisual : Visual, DUCE.IResource, IVisual3DContainer {
+        public static readonly DependencyProperty CameraProperty;
+        public static readonly DependencyProperty ViewportProperty;
+        public Viewport3DVisual();
+        public BitmapEffect BitmapEffect { get; set; }
+        public BitmapEffectInput BitmapEffectInput { get; set; }
+        public Camera Camera { get; set; }
+        public Visual3DCollection Children { get; }
+        public Geometry Clip { get; set; }
+        public Rect ContentBounds { get; }
+        public Rect DescendantBounds { get; }
+        public Vector Offset { get; set; }
+        public double Opacity { get; set; }
+        public Brush OpacityMask { get; set; }
+        public DependencyObject Parent { get; }
+        public Transform Transform { get; set; }
+        public Rect Viewport { get; set; }
+        public new void HitTest(HitTestFilterCallback filterCallback, HitTestResultCallback resultCallback, HitTestParameters hitTestParameters);
+        public new HitTestResult HitTest(Point point);
+        protected override GeometryHitTestResult HitTestCore(GeometryHitTestParameters hitTestParameters);
+    }
+    public abstract class Visual3D : DependencyObject, DUCE.IResource, IAnimatable, IVisual3DContainer {
+        public static readonly DependencyProperty TransformProperty;
+        public bool HasAnimatedProperties { get; }
+        public Transform3D Transform { get; set; }
+        protected virtual int Visual3DChildrenCount { get; }
+        protected Model3D Visual3DModel { get; set; }
+        protected void AddVisual3DChild(Visual3D child);
+        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock);
+        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock, HandoffBehavior handoffBehavior);
+        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation);
+        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation, HandoffBehavior handoffBehavior);
+        public DependencyObject FindCommonVisualAncestor(DependencyObject otherVisual);
+        public object GetAnimationBaseValue(DependencyProperty dp);
+        protected virtual Visual3D GetVisual3DChild(int index);
+        public bool IsAncestorOf(DependencyObject descendant);
+        public bool IsDescendantOf(DependencyObject ancestor);
+        protected internal virtual void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved);
+        protected internal virtual void OnVisualParentChanged(DependencyObject oldParent);
+        protected void RemoveVisual3DChild(Visual3D child);
+        public GeneralTransform3D TransformToAncestor(Visual3D ancestor);
+        public GeneralTransform3DTo2D TransformToAncestor(Visual ancestor);
+        public GeneralTransform3D TransformToDescendant(Visual3D descendant);
+    }
+    public sealed class Visual3DCollection : ICollection, ICollection<Visual3D>, IEnumerable, IEnumerable<Visual3D>, IList, IList<Visual3D> {
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Media3D.Visual3D>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Visual3D this[int index] { get; set; }
+        public void Add(Visual3D value);
+        public void Clear();
+        public bool Contains(Visual3D value);
+        public void CopyTo(Visual3D[] array, int index);
+        public Visual3DCollection.Enumerator GetEnumerator();
+        public int IndexOf(Visual3D value);
+        public void Insert(int index, Visual3D value);
+        public bool Remove(Visual3D value);
+        public void RemoveAt(int index);
+        IEnumerator<Visual3D> System.Collections.Generic.IEnumerable<System.Windows.Media.Media3D.Visual3D>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Visual3D> {
+            public Visual3D Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+}
```

