# System.Windows.Media.Effects

``` diff
+namespace System.Windows.Media.Effects {
+    public sealed class BevelBitmapEffect : BitmapEffect {
+        public static readonly DependencyProperty BevelWidthProperty;
+        public static readonly DependencyProperty EdgeProfileProperty;
+        public static readonly DependencyProperty LightAngleProperty;
+        public static readonly DependencyProperty ReliefProperty;
+        public static readonly DependencyProperty SmoothnessProperty;
+        public BevelBitmapEffect();
+        public double BevelWidth { get; set; }
+        public EdgeProfile EdgeProfile { get; set; }
+        public double LightAngle { get; set; }
+        public double Relief { get; set; }
+        public double Smoothness { get; set; }
+        public new BevelBitmapEffect Clone();
+        public new BevelBitmapEffect CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override SafeHandle CreateUnmanagedEffect();
+        protected override void UpdateUnmanagedPropertyState(SafeHandle unmanagedEffect);
+    }
+    public abstract class BitmapEffect : Animatable {
+        protected BitmapEffect();
+        public new BitmapEffect Clone();
+        public new BitmapEffect CloneCurrentValue();
+        protected static SafeHandle CreateBitmapEffectOuter();
+        protected abstract SafeHandle CreateUnmanagedEffect();
+        public BitmapSource GetOutput(BitmapEffectInput input);
+        protected static void InitializeBitmapEffect(SafeHandle outerObject, SafeHandle innerObject);
+        protected static void SetValue(SafeHandle effect, string propertyName, object value);
+        protected abstract void UpdateUnmanagedPropertyState(SafeHandle unmanagedEffect);
+    }
+    public sealed class BitmapEffectCollection : Animatable, ICollection, ICollection<BitmapEffect>, IEnumerable, IEnumerable<BitmapEffect>, IList, IList<BitmapEffect> {
+        public BitmapEffectCollection();
+        public BitmapEffectCollection(IEnumerable<BitmapEffect> collection);
+        public BitmapEffectCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Effects.BitmapEffect>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public BitmapEffect this[int index] { get; set; }
+        public void Add(BitmapEffect value);
+        public void Clear();
+        public new BitmapEffectCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new BitmapEffectCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(BitmapEffect value);
+        public void CopyTo(BitmapEffect[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public BitmapEffectCollection.Enumerator GetEnumerator();
+        public int IndexOf(BitmapEffect value);
+        public void Insert(int index, BitmapEffect value);
+        public bool Remove(BitmapEffect value);
+        public void RemoveAt(int index);
+        IEnumerator<BitmapEffect> System.Collections.Generic.IEnumerable<System.Windows.Media.Effects.BitmapEffect>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<BitmapEffect> {
+            public BitmapEffect Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class BitmapEffectGroup : BitmapEffect {
+        public static readonly DependencyProperty ChildrenProperty;
+        public BitmapEffectGroup();
+        public BitmapEffectCollection Children { get; set; }
+        public new BitmapEffectGroup Clone();
+        public new BitmapEffectGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override SafeHandle CreateUnmanagedEffect();
+        protected override void UpdateUnmanagedPropertyState(SafeHandle unmanagedEffect);
+    }
+    public sealed class BitmapEffectInput : Animatable {
+        public static readonly DependencyProperty AreaToApplyEffectProperty;
+        public static readonly DependencyProperty AreaToApplyEffectUnitsProperty;
+        public static readonly DependencyProperty InputProperty;
+        public BitmapEffectInput();
+        public BitmapEffectInput(BitmapSource input);
+        public Rect AreaToApplyEffect { get; set; }
+        public BrushMappingMode AreaToApplyEffectUnits { get; set; }
+        public static BitmapSource ContextInputSource { get; }
+        public BitmapSource Input { get; set; }
+        public new BitmapEffectInput Clone();
+        public new BitmapEffectInput CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public bool ShouldSerializeInput();
+    }
+    public sealed class BlurBitmapEffect : BitmapEffect {
+        public static readonly DependencyProperty KernelTypeProperty;
+        public static readonly DependencyProperty RadiusProperty;
+        public BlurBitmapEffect();
+        public KernelType KernelType { get; set; }
+        public double Radius { get; set; }
+        public new BlurBitmapEffect Clone();
+        public new BlurBitmapEffect CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override SafeHandle CreateUnmanagedEffect();
+        protected override void UpdateUnmanagedPropertyState(SafeHandle unmanagedEffect);
+    }
+    public sealed class BlurEffect : Effect {
+        public static readonly DependencyProperty KernelTypeProperty;
+        public static readonly DependencyProperty RadiusProperty;
+        public static readonly DependencyProperty RenderingBiasProperty;
+        public BlurEffect();
+        public KernelType KernelType { get; set; }
+        public double Radius { get; set; }
+        public RenderingBias RenderingBias { get; set; }
+        public new BlurEffect Clone();
+        public new BlurEffect CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class DropShadowBitmapEffect : BitmapEffect {
+        public static readonly DependencyProperty ColorProperty;
+        public static readonly DependencyProperty DirectionProperty;
+        public static readonly DependencyProperty NoiseProperty;
+        public static readonly DependencyProperty OpacityProperty;
+        public static readonly DependencyProperty ShadowDepthProperty;
+        public static readonly DependencyProperty SoftnessProperty;
+        public DropShadowBitmapEffect();
+        public Color Color { get; set; }
+        public double Direction { get; set; }
+        public double Noise { get; set; }
+        public double Opacity { get; set; }
+        public double ShadowDepth { get; set; }
+        public double Softness { get; set; }
+        public new DropShadowBitmapEffect Clone();
+        public new DropShadowBitmapEffect CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override SafeHandle CreateUnmanagedEffect();
+        protected override void UpdateUnmanagedPropertyState(SafeHandle unmanagedEffect);
+    }
+    public sealed class DropShadowEffect : Effect {
+        public static readonly DependencyProperty BlurRadiusProperty;
+        public static readonly DependencyProperty ColorProperty;
+        public static readonly DependencyProperty DirectionProperty;
+        public static readonly DependencyProperty OpacityProperty;
+        public static readonly DependencyProperty RenderingBiasProperty;
+        public static readonly DependencyProperty ShadowDepthProperty;
+        public DropShadowEffect();
+        public double BlurRadius { get; set; }
+        public Color Color { get; set; }
+        public double Direction { get; set; }
+        public double Opacity { get; set; }
+        public RenderingBias RenderingBias { get; set; }
+        public double ShadowDepth { get; set; }
+        public new DropShadowEffect Clone();
+        public new DropShadowEffect CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public enum EdgeProfile {
+        BulgedUp = 3,
+        CurvedIn = 1,
+        CurvedOut = 2,
+        Linear = 0,
+    }
+    public abstract class Effect : Animatable, DUCE.IResource {
+        protected Effect();
+        protected internal virtual GeneralTransform EffectMapping { get; }
+        public static Brush ImplicitInput { get; private set; }
+        public new Effect Clone();
+        public new Effect CloneCurrentValue();
+    }
+    public sealed class EmbossBitmapEffect : BitmapEffect {
+        public static readonly DependencyProperty LightAngleProperty;
+        public static readonly DependencyProperty ReliefProperty;
+        public EmbossBitmapEffect();
+        public double LightAngle { get; set; }
+        public double Relief { get; set; }
+        public new EmbossBitmapEffect Clone();
+        public new EmbossBitmapEffect CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override SafeHandle CreateUnmanagedEffect();
+        protected override void UpdateUnmanagedPropertyState(SafeHandle unmanagedEffect);
+    }
+    public enum KernelType {
+        Box = 1,
+        Gaussian = 0,
+    }
+    public sealed class OuterGlowBitmapEffect : BitmapEffect {
+        public static readonly DependencyProperty GlowColorProperty;
+        public static readonly DependencyProperty GlowSizeProperty;
+        public static readonly DependencyProperty NoiseProperty;
+        public static readonly DependencyProperty OpacityProperty;
+        public OuterGlowBitmapEffect();
+        public Color GlowColor { get; set; }
+        public double GlowSize { get; set; }
+        public double Noise { get; set; }
+        public double Opacity { get; set; }
+        public new OuterGlowBitmapEffect Clone();
+        public new OuterGlowBitmapEffect CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override SafeHandle CreateUnmanagedEffect();
+        protected override void UpdateUnmanagedPropertyState(SafeHandle unmanagedEffect);
+    }
+    public sealed class PixelShader : Animatable, DUCE.IResource {
+        public static readonly DependencyProperty ShaderRenderModeProperty;
+        public static readonly DependencyProperty UriSourceProperty;
+        public PixelShader();
+        public ShaderRenderMode ShaderRenderMode { get; set; }
+        public Uri UriSource { get; set; }
+        public static event EventHandler InvalidPixelShaderEncountered;
+        public new PixelShader Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new PixelShader CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public void SetStreamSource(Stream source);
+    }
+    public enum RenderingBias {
+        Performance = 0,
+        Quality = 1,
+    }
+    public enum SamplingMode {
+        Auto = 2,
+        Bilinear = 1,
+        NearestNeighbor = 0,
+    }
+    public abstract class ShaderEffect : Effect {
+        protected static readonly DependencyProperty PixelShaderProperty;
+        protected ShaderEffect();
+        protected int DdxUvDdyUvRegisterIndex { get; set; }
+        protected double PaddingBottom { get; set; }
+        protected double PaddingLeft { get; set; }
+        protected double PaddingRight { get; set; }
+        protected double PaddingTop { get; set; }
+        protected PixelShader PixelShader { get; set; }
+        public new ShaderEffect Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new ShaderEffect CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        protected static PropertyChangedCallback PixelShaderConstantCallback(int floatRegisterIndex);
+        protected static PropertyChangedCallback PixelShaderSamplerCallback(int samplerRegisterIndex);
+        protected static PropertyChangedCallback PixelShaderSamplerCallback(int samplerRegisterIndex, SamplingMode samplingMode);
+        protected static DependencyProperty RegisterPixelShaderSamplerProperty(string dpName, Type ownerType, int samplerRegisterIndex);
+        protected static DependencyProperty RegisterPixelShaderSamplerProperty(string dpName, Type ownerType, int samplerRegisterIndex, SamplingMode samplingMode);
+        protected void UpdateShaderValue(DependencyProperty dp);
+    }
+    public enum ShaderRenderMode {
+        Auto = 0,
+        HardwareOnly = 2,
+        SoftwareOnly = 1,
+    }
+}
```

