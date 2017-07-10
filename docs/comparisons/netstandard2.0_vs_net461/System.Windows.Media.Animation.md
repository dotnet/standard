# System.Windows.Media.Animation

``` diff
+namespace System.Windows.Media.Animation {
+    public abstract class Animatable : Freezable, DUCE.IResource, IAnimatable {
+        protected Animatable();
+        public bool HasAnimatedProperties { get; }
+        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock);
+        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock, HandoffBehavior handoffBehavior);
+        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation);
+        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation, HandoffBehavior handoffBehavior);
+        public new Animatable Clone();
+        protected override bool FreezeCore(bool isChecking);
+        public object GetAnimationBaseValue(DependencyProperty dp);
+        public static bool ShouldSerializeStoredWeakReference(DependencyObject target);
+    }
+    public class AnimationClock : Clock {
+        protected internal AnimationClock(AnimationTimeline animation);
+        public new AnimationTimeline Timeline { get; }
+        public object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue);
+    }
+    public sealed class AnimationException : SystemException {
+        public AnimationClock Clock { get; }
+        public DependencyProperty Property { get; }
+        public IAnimatable Target { get; }
+    }
+    public abstract class AnimationTimeline : Timeline {
+        public static readonly DependencyProperty IsAdditiveProperty;
+        public static readonly DependencyProperty IsCumulativeProperty;
+        protected AnimationTimeline();
+        public virtual bool IsDestinationDefault { get; }
+        public abstract Type TargetPropertyType { get; }
+        protected internal override Clock AllocateClock();
+        public new AnimationTimeline Clone();
+        public new AnimationClock CreateClock();
+        public virtual object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected override Duration GetNaturalDurationCore(Clock clock);
+    }
+    public class BackEase : EasingFunctionBase {
+        public static readonly DependencyProperty AmplitudeProperty;
+        public BackEase();
+        public double Amplitude { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public sealed class BeginStoryboard : TriggerAction {
+        public static readonly DependencyProperty StoryboardProperty;
+        public BeginStoryboard();
+        public HandoffBehavior HandoffBehavior { get; set; }
+        public string Name { get; set; }
+        public Storyboard Storyboard { get; set; }
+    }
+    public abstract class BooleanAnimationBase : AnimationTimeline {
+        protected BooleanAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new BooleanAnimationBase Clone();
+        public bool GetCurrentValue(bool defaultOriginValue, bool defaultDestinationValue, AnimationClock animationClock);
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract bool GetCurrentValueCore(bool defaultOriginValue, bool defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class BooleanAnimationUsingKeyFrames : BooleanAnimationBase, IAddChild, IKeyFrameAnimation {
+        public BooleanAnimationUsingKeyFrames();
+        public BooleanKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new BooleanAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new BooleanAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override bool GetCurrentValueCore(bool defaultOriginValue, bool defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class BooleanKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected BooleanKeyFrame();
+        protected BooleanKeyFrame(bool value);
+        protected BooleanKeyFrame(bool value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public bool Value { get; set; }
+        public bool InterpolateValue(bool baseValue, double keyFrameProgress);
+        protected abstract bool InterpolateValueCore(bool baseValue, double keyFrameProgress);
+    }
+    public class BooleanKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public BooleanKeyFrameCollection();
+        public int Count { get; }
+        public static BooleanKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public BooleanKeyFrame this[int index] { get; set; }
+        public int Add(BooleanKeyFrame keyFrame);
+        public void Clear();
+        public new BooleanKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(BooleanKeyFrame keyFrame);
+        public void CopyTo(BooleanKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(BooleanKeyFrame keyFrame);
+        public void Insert(int index, BooleanKeyFrame keyFrame);
+        public void Remove(BooleanKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class BounceEase : EasingFunctionBase {
+        public static readonly DependencyProperty BouncesProperty;
+        public static readonly DependencyProperty BouncinessProperty;
+        public BounceEase();
+        public int Bounces { get; set; }
+        public double Bounciness { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class ByteAnimation : ByteAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public ByteAnimation();
+        public ByteAnimation(byte fromValue, byte toValue, Duration duration);
+        public ByteAnimation(byte fromValue, byte toValue, Duration duration, FillBehavior fillBehavior);
+        public ByteAnimation(byte toValue, Duration duration);
+        public ByteAnimation(byte toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<byte> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<byte> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<byte> To { get; set; }
+        public new ByteAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override byte GetCurrentValueCore(byte defaultOriginValue, byte defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class ByteAnimationBase : AnimationTimeline {
+        protected ByteAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new ByteAnimationBase Clone();
+        public byte GetCurrentValue(byte defaultOriginValue, byte defaultDestinationValue, AnimationClock animationClock);
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract byte GetCurrentValueCore(byte defaultOriginValue, byte defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class ByteAnimationUsingKeyFrames : ByteAnimationBase, IAddChild, IKeyFrameAnimation {
+        public ByteAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public ByteKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new ByteAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new ByteAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override byte GetCurrentValueCore(byte defaultOriginValue, byte defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class ByteKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected ByteKeyFrame();
+        protected ByteKeyFrame(byte value);
+        protected ByteKeyFrame(byte value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public byte Value { get; set; }
+        public byte InterpolateValue(byte baseValue, double keyFrameProgress);
+        protected abstract byte InterpolateValueCore(byte baseValue, double keyFrameProgress);
+    }
+    public class ByteKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public ByteKeyFrameCollection();
+        public int Count { get; }
+        public static ByteKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public ByteKeyFrame this[int index] { get; set; }
+        public int Add(ByteKeyFrame keyFrame);
+        public void Clear();
+        public new ByteKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(ByteKeyFrame keyFrame);
+        public void CopyTo(ByteKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(ByteKeyFrame keyFrame);
+        public void Insert(int index, ByteKeyFrame keyFrame);
+        public void Remove(ByteKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public abstract class CharAnimationBase : AnimationTimeline {
+        protected CharAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new CharAnimationBase Clone();
+        public char GetCurrentValue(char defaultOriginValue, char defaultDestinationValue, AnimationClock animationClock);
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract char GetCurrentValueCore(char defaultOriginValue, char defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class CharAnimationUsingKeyFrames : CharAnimationBase, IAddChild, IKeyFrameAnimation {
+        public CharAnimationUsingKeyFrames();
+        public CharKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new CharAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new CharAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override char GetCurrentValueCore(char defaultOriginValue, char defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class CharKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected CharKeyFrame();
+        protected CharKeyFrame(char value);
+        protected CharKeyFrame(char value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public char Value { get; set; }
+        public char InterpolateValue(char baseValue, double keyFrameProgress);
+        protected abstract char InterpolateValueCore(char baseValue, double keyFrameProgress);
+    }
+    public class CharKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public CharKeyFrameCollection();
+        public int Count { get; }
+        public static CharKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public CharKeyFrame this[int index] { get; set; }
+        public int Add(CharKeyFrame keyFrame);
+        public void Clear();
+        public new CharKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(CharKeyFrame keyFrame);
+        public void CopyTo(CharKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(CharKeyFrame keyFrame);
+        public void Insert(int index, CharKeyFrame keyFrame);
+        public void Remove(CharKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class CircleEase : EasingFunctionBase {
+        public CircleEase();
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class Clock : DispatcherObject {
+        protected internal Clock(Timeline timeline);
+        public ClockController Controller { get; }
+        public Nullable<double> CurrentGlobalSpeed { get; }
+        protected TimeSpan CurrentGlobalTime { get; }
+        public Nullable<int> CurrentIteration { get; }
+        public Nullable<double> CurrentProgress { get; }
+        public ClockState CurrentState { get; }
+        public Nullable<TimeSpan> CurrentTime { get; }
+        public bool HasControllableRoot { get; }
+        public bool IsPaused { get; }
+        public Duration NaturalDuration { get; }
+        public Clock Parent { get; }
+        public Timeline Timeline { get; }
+        public event EventHandler Completed;
+        public event EventHandler CurrentGlobalSpeedInvalidated;
+        public event EventHandler CurrentStateInvalidated;
+        public event EventHandler CurrentTimeInvalidated;
+        public event EventHandler RemoveRequested;
+        protected virtual void DiscontinuousTimeMovement();
+        protected virtual bool GetCanSlip();
+        protected virtual TimeSpan GetCurrentTimeCore();
+        protected virtual void SpeedChanged();
+        protected virtual void Stopped();
+    }
+    public class ClockCollection : ICollection<Clock>, IEnumerable, IEnumerable<Clock> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public Clock this[int index] { get; }
+        public void Add(Clock item);
+        public void Clear();
+        public bool Contains(Clock item);
+        public void CopyTo(Clock[] array, int index);
+        public override bool Equals(object obj);
+        public static bool Equals(ClockCollection objA, ClockCollection objB);
+        public override int GetHashCode();
+        public static bool operator ==(ClockCollection objA, ClockCollection objB);
+        public static bool operator !=(ClockCollection objA, ClockCollection objB);
+        public bool Remove(Clock item);
+        IEnumerator<Clock> System.Collections.Generic.IEnumerable<System.Windows.Media.Animation.Clock>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class ClockController : DispatcherObject {
+        public Clock Clock { get; }
+        public double SpeedRatio { get; set; }
+        public void Begin();
+        public void Pause();
+        public void Remove();
+        public void Resume();
+        public void Seek(TimeSpan offset, TimeSeekOrigin origin);
+        public void SeekAlignedToLastTick(TimeSpan offset, TimeSeekOrigin origin);
+        public void SkipToFill();
+        public void Stop();
+    }
+    public class ClockGroup : Clock {
+        protected internal ClockGroup(TimelineGroup timelineGroup);
+        public ClockCollection Children { get; }
+        public new TimelineGroup Timeline { get; }
+    }
+    public enum ClockState {
+        Active = 0,
+        Filling = 1,
+        Stopped = 2,
+    }
+    public class ColorAnimation : ColorAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public ColorAnimation();
+        public ColorAnimation(Color toValue, Duration duration);
+        public ColorAnimation(Color toValue, Duration duration, FillBehavior fillBehavior);
+        public ColorAnimation(Color fromValue, Color toValue, Duration duration);
+        public ColorAnimation(Color fromValue, Color toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Color> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Color> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Color> To { get; set; }
+        public new ColorAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Color GetCurrentValueCore(Color defaultOriginValue, Color defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class ColorAnimationBase : AnimationTimeline {
+        protected ColorAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new ColorAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Color GetCurrentValue(Color defaultOriginValue, Color defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Color GetCurrentValueCore(Color defaultOriginValue, Color defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class ColorAnimationUsingKeyFrames : ColorAnimationBase, IAddChild, IKeyFrameAnimation {
+        public ColorAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public ColorKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new ColorAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new ColorAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Color GetCurrentValueCore(Color defaultOriginValue, Color defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class ColorKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected ColorKeyFrame();
+        protected ColorKeyFrame(Color value);
+        protected ColorKeyFrame(Color value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Color Value { get; set; }
+        public Color InterpolateValue(Color baseValue, double keyFrameProgress);
+        protected abstract Color InterpolateValueCore(Color baseValue, double keyFrameProgress);
+    }
+    public class ColorKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public ColorKeyFrameCollection();
+        public int Count { get; }
+        public static ColorKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public ColorKeyFrame this[int index] { get; set; }
+        public int Add(ColorKeyFrame keyFrame);
+        public void Clear();
+        public new ColorKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(ColorKeyFrame keyFrame);
+        public void CopyTo(ColorKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(ColorKeyFrame keyFrame);
+        public void Insert(int index, ColorKeyFrame keyFrame);
+        public void Remove(ColorKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public abstract class ControllableStoryboardAction : TriggerAction {
+        public string BeginStoryboardName { get; set; }
+    }
+    public class CubicEase : EasingFunctionBase {
+        public CubicEase();
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class DecimalAnimation : DecimalAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public DecimalAnimation();
+        public DecimalAnimation(decimal fromValue, decimal toValue, Duration duration);
+        public DecimalAnimation(decimal fromValue, decimal toValue, Duration duration, FillBehavior fillBehavior);
+        public DecimalAnimation(decimal toValue, Duration duration);
+        public DecimalAnimation(decimal toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<decimal> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<decimal> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<decimal> To { get; set; }
+        public new DecimalAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override decimal GetCurrentValueCore(decimal defaultOriginValue, decimal defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class DecimalAnimationBase : AnimationTimeline {
+        protected DecimalAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new DecimalAnimationBase Clone();
+        public decimal GetCurrentValue(decimal defaultOriginValue, decimal defaultDestinationValue, AnimationClock animationClock);
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract decimal GetCurrentValueCore(decimal defaultOriginValue, decimal defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class DecimalAnimationUsingKeyFrames : DecimalAnimationBase, IAddChild, IKeyFrameAnimation {
+        public DecimalAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public DecimalKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new DecimalAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new DecimalAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override decimal GetCurrentValueCore(decimal defaultOriginValue, decimal defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class DecimalKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected DecimalKeyFrame();
+        protected DecimalKeyFrame(decimal value);
+        protected DecimalKeyFrame(decimal value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public decimal Value { get; set; }
+        public decimal InterpolateValue(decimal baseValue, double keyFrameProgress);
+        protected abstract decimal InterpolateValueCore(decimal baseValue, double keyFrameProgress);
+    }
+    public class DecimalKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public DecimalKeyFrameCollection();
+        public int Count { get; }
+        public static DecimalKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DecimalKeyFrame this[int index] { get; set; }
+        public int Add(DecimalKeyFrame keyFrame);
+        public void Clear();
+        public new DecimalKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(DecimalKeyFrame keyFrame);
+        public void CopyTo(DecimalKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(DecimalKeyFrame keyFrame);
+        public void Insert(int index, DecimalKeyFrame keyFrame);
+        public void Remove(DecimalKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class DiscreteBooleanKeyFrame : BooleanKeyFrame {
+        public DiscreteBooleanKeyFrame();
+        public DiscreteBooleanKeyFrame(bool value);
+        public DiscreteBooleanKeyFrame(bool value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override bool InterpolateValueCore(bool baseValue, double keyFrameProgress);
+    }
+    public class DiscreteByteKeyFrame : ByteKeyFrame {
+        public DiscreteByteKeyFrame();
+        public DiscreteByteKeyFrame(byte value);
+        public DiscreteByteKeyFrame(byte value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override byte InterpolateValueCore(byte baseValue, double keyFrameProgress);
+    }
+    public class DiscreteCharKeyFrame : CharKeyFrame {
+        public DiscreteCharKeyFrame();
+        public DiscreteCharKeyFrame(char value);
+        public DiscreteCharKeyFrame(char value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override char InterpolateValueCore(char baseValue, double keyFrameProgress);
+    }
+    public class DiscreteColorKeyFrame : ColorKeyFrame {
+        public DiscreteColorKeyFrame();
+        public DiscreteColorKeyFrame(Color value);
+        public DiscreteColorKeyFrame(Color value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Color InterpolateValueCore(Color baseValue, double keyFrameProgress);
+    }
+    public class DiscreteDecimalKeyFrame : DecimalKeyFrame {
+        public DiscreteDecimalKeyFrame();
+        public DiscreteDecimalKeyFrame(decimal value);
+        public DiscreteDecimalKeyFrame(decimal value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override decimal InterpolateValueCore(decimal baseValue, double keyFrameProgress);
+    }
+    public class DiscreteDoubleKeyFrame : DoubleKeyFrame {
+        public DiscreteDoubleKeyFrame();
+        public DiscreteDoubleKeyFrame(double value);
+        public DiscreteDoubleKeyFrame(double value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override double InterpolateValueCore(double baseValue, double keyFrameProgress);
+    }
+    public class DiscreteInt16KeyFrame : Int16KeyFrame {
+        public DiscreteInt16KeyFrame();
+        public DiscreteInt16KeyFrame(short value);
+        public DiscreteInt16KeyFrame(short value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override short InterpolateValueCore(short baseValue, double keyFrameProgress);
+    }
+    public class DiscreteInt32KeyFrame : Int32KeyFrame {
+        public DiscreteInt32KeyFrame();
+        public DiscreteInt32KeyFrame(int value);
+        public DiscreteInt32KeyFrame(int value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override int InterpolateValueCore(int baseValue, double keyFrameProgress);
+    }
+    public class DiscreteInt64KeyFrame : Int64KeyFrame {
+        public DiscreteInt64KeyFrame();
+        public DiscreteInt64KeyFrame(long value);
+        public DiscreteInt64KeyFrame(long value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override long InterpolateValueCore(long baseValue, double keyFrameProgress);
+    }
+    public class DiscreteMatrixKeyFrame : MatrixKeyFrame {
+        public DiscreteMatrixKeyFrame();
+        public DiscreteMatrixKeyFrame(Matrix value);
+        public DiscreteMatrixKeyFrame(Matrix value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Matrix InterpolateValueCore(Matrix baseValue, double keyFrameProgress);
+    }
+    public class DiscreteObjectKeyFrame : ObjectKeyFrame {
+        public DiscreteObjectKeyFrame();
+        public DiscreteObjectKeyFrame(object value);
+        public DiscreteObjectKeyFrame(object value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override object InterpolateValueCore(object baseValue, double keyFrameProgress);
+    }
+    public class DiscretePoint3DKeyFrame : Point3DKeyFrame {
+        public DiscretePoint3DKeyFrame();
+        public DiscretePoint3DKeyFrame(Point3D value);
+        public DiscretePoint3DKeyFrame(Point3D value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Point3D InterpolateValueCore(Point3D baseValue, double keyFrameProgress);
+    }
+    public class DiscretePointKeyFrame : PointKeyFrame {
+        public DiscretePointKeyFrame();
+        public DiscretePointKeyFrame(Point value);
+        public DiscretePointKeyFrame(Point value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Point InterpolateValueCore(Point baseValue, double keyFrameProgress);
+    }
+    public class DiscreteQuaternionKeyFrame : QuaternionKeyFrame {
+        public DiscreteQuaternionKeyFrame();
+        public DiscreteQuaternionKeyFrame(Quaternion value);
+        public DiscreteQuaternionKeyFrame(Quaternion value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Quaternion InterpolateValueCore(Quaternion baseValue, double keyFrameProgress);
+    }
+    public class DiscreteRectKeyFrame : RectKeyFrame {
+        public DiscreteRectKeyFrame();
+        public DiscreteRectKeyFrame(Rect value);
+        public DiscreteRectKeyFrame(Rect value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Rect InterpolateValueCore(Rect baseValue, double keyFrameProgress);
+    }
+    public class DiscreteRotation3DKeyFrame : Rotation3DKeyFrame {
+        public DiscreteRotation3DKeyFrame();
+        public DiscreteRotation3DKeyFrame(Rotation3D value);
+        public DiscreteRotation3DKeyFrame(Rotation3D value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Rotation3D InterpolateValueCore(Rotation3D baseValue, double keyFrameProgress);
+    }
+    public class DiscreteSingleKeyFrame : SingleKeyFrame {
+        public DiscreteSingleKeyFrame();
+        public DiscreteSingleKeyFrame(float value);
+        public DiscreteSingleKeyFrame(float value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override float InterpolateValueCore(float baseValue, double keyFrameProgress);
+    }
+    public class DiscreteSizeKeyFrame : SizeKeyFrame {
+        public DiscreteSizeKeyFrame();
+        public DiscreteSizeKeyFrame(Size value);
+        public DiscreteSizeKeyFrame(Size value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Size InterpolateValueCore(Size baseValue, double keyFrameProgress);
+    }
+    public class DiscreteStringKeyFrame : StringKeyFrame {
+        public DiscreteStringKeyFrame();
+        public DiscreteStringKeyFrame(string value);
+        public DiscreteStringKeyFrame(string value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override string InterpolateValueCore(string baseValue, double keyFrameProgress);
+    }
+    public class DiscreteThicknessKeyFrame : ThicknessKeyFrame {
+        public DiscreteThicknessKeyFrame();
+        public DiscreteThicknessKeyFrame(Thickness value);
+        public DiscreteThicknessKeyFrame(Thickness value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Thickness InterpolateValueCore(Thickness baseValue, double keyFrameProgress);
+    }
+    public class DiscreteVector3DKeyFrame : Vector3DKeyFrame {
+        public DiscreteVector3DKeyFrame();
+        public DiscreteVector3DKeyFrame(Vector3D value);
+        public DiscreteVector3DKeyFrame(Vector3D value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Vector3D InterpolateValueCore(Vector3D baseValue, double keyFrameProgress);
+    }
+    public class DiscreteVectorKeyFrame : VectorKeyFrame {
+        public DiscreteVectorKeyFrame();
+        public DiscreteVectorKeyFrame(Vector value);
+        public DiscreteVectorKeyFrame(Vector value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Vector InterpolateValueCore(Vector baseValue, double keyFrameProgress);
+    }
+    public class DoubleAnimation : DoubleAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public DoubleAnimation();
+        public DoubleAnimation(double fromValue, double toValue, Duration duration);
+        public DoubleAnimation(double fromValue, double toValue, Duration duration, FillBehavior fillBehavior);
+        public DoubleAnimation(double toValue, Duration duration);
+        public DoubleAnimation(double toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<double> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<double> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<double> To { get; set; }
+        public new DoubleAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override double GetCurrentValueCore(double defaultOriginValue, double defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class DoubleAnimationBase : AnimationTimeline {
+        protected DoubleAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new DoubleAnimationBase Clone();
+        public double GetCurrentValue(double defaultOriginValue, double defaultDestinationValue, AnimationClock animationClock);
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract double GetCurrentValueCore(double defaultOriginValue, double defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class DoubleAnimationUsingKeyFrames : DoubleAnimationBase, IAddChild, IKeyFrameAnimation {
+        public DoubleAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public DoubleKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new DoubleAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new DoubleAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override double GetCurrentValueCore(double defaultOriginValue, double defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public class DoubleAnimationUsingPath : DoubleAnimationBase {
+        public static readonly DependencyProperty PathGeometryProperty;
+        public static readonly DependencyProperty SourceProperty;
+        public DoubleAnimationUsingPath();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public PathGeometry PathGeometry { get; set; }
+        public PathAnimationSource Source { get; set; }
+        public new DoubleAnimationUsingPath Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override double GetCurrentValueCore(double defaultOriginValue, double defaultDestinationValue, AnimationClock animationClock);
+        protected override void OnChanged();
+    }
+    public abstract class DoubleKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected DoubleKeyFrame();
+        protected DoubleKeyFrame(double value);
+        protected DoubleKeyFrame(double value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public double Value { get; set; }
+        public double InterpolateValue(double baseValue, double keyFrameProgress);
+        protected abstract double InterpolateValueCore(double baseValue, double keyFrameProgress);
+    }
+    public class DoubleKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public DoubleKeyFrameCollection();
+        public int Count { get; }
+        public static DoubleKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DoubleKeyFrame this[int index] { get; set; }
+        public int Add(DoubleKeyFrame keyFrame);
+        public void Clear();
+        public new DoubleKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(DoubleKeyFrame keyFrame);
+        public void CopyTo(DoubleKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(DoubleKeyFrame keyFrame);
+        public void Insert(int index, DoubleKeyFrame keyFrame);
+        public void Remove(DoubleKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class EasingByteKeyFrame : ByteKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingByteKeyFrame();
+        public EasingByteKeyFrame(byte value);
+        public EasingByteKeyFrame(byte value, KeyTime keyTime);
+        public EasingByteKeyFrame(byte value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override byte InterpolateValueCore(byte baseValue, double keyFrameProgress);
+    }
+    public class EasingColorKeyFrame : ColorKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingColorKeyFrame();
+        public EasingColorKeyFrame(Color value);
+        public EasingColorKeyFrame(Color value, KeyTime keyTime);
+        public EasingColorKeyFrame(Color value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Color InterpolateValueCore(Color baseValue, double keyFrameProgress);
+    }
+    public class EasingDecimalKeyFrame : DecimalKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingDecimalKeyFrame();
+        public EasingDecimalKeyFrame(decimal value);
+        public EasingDecimalKeyFrame(decimal value, KeyTime keyTime);
+        public EasingDecimalKeyFrame(decimal value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override decimal InterpolateValueCore(decimal baseValue, double keyFrameProgress);
+    }
+    public class EasingDoubleKeyFrame : DoubleKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingDoubleKeyFrame();
+        public EasingDoubleKeyFrame(double value);
+        public EasingDoubleKeyFrame(double value, KeyTime keyTime);
+        public EasingDoubleKeyFrame(double value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override double InterpolateValueCore(double baseValue, double keyFrameProgress);
+    }
+    public abstract class EasingFunctionBase : Freezable, IEasingFunction {
+        public static readonly DependencyProperty EasingModeProperty;
+        protected EasingFunctionBase();
+        public EasingMode EasingMode { get; set; }
+        public double Ease(double normalizedTime);
+        protected abstract double EaseInCore(double normalizedTime);
+    }
+    public class EasingInt16KeyFrame : Int16KeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingInt16KeyFrame();
+        public EasingInt16KeyFrame(short value);
+        public EasingInt16KeyFrame(short value, KeyTime keyTime);
+        public EasingInt16KeyFrame(short value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override short InterpolateValueCore(short baseValue, double keyFrameProgress);
+    }
+    public class EasingInt32KeyFrame : Int32KeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingInt32KeyFrame();
+        public EasingInt32KeyFrame(int value);
+        public EasingInt32KeyFrame(int value, KeyTime keyTime);
+        public EasingInt32KeyFrame(int value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override int InterpolateValueCore(int baseValue, double keyFrameProgress);
+    }
+    public class EasingInt64KeyFrame : Int64KeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingInt64KeyFrame();
+        public EasingInt64KeyFrame(long value);
+        public EasingInt64KeyFrame(long value, KeyTime keyTime);
+        public EasingInt64KeyFrame(long value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override long InterpolateValueCore(long baseValue, double keyFrameProgress);
+    }
+    public enum EasingMode {
+        EaseIn = 0,
+        EaseInOut = 2,
+        EaseOut = 1,
+    }
+    public class EasingPoint3DKeyFrame : Point3DKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingPoint3DKeyFrame();
+        public EasingPoint3DKeyFrame(Point3D value);
+        public EasingPoint3DKeyFrame(Point3D value, KeyTime keyTime);
+        public EasingPoint3DKeyFrame(Point3D value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Point3D InterpolateValueCore(Point3D baseValue, double keyFrameProgress);
+    }
+    public class EasingPointKeyFrame : PointKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingPointKeyFrame();
+        public EasingPointKeyFrame(Point value);
+        public EasingPointKeyFrame(Point value, KeyTime keyTime);
+        public EasingPointKeyFrame(Point value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Point InterpolateValueCore(Point baseValue, double keyFrameProgress);
+    }
+    public class EasingQuaternionKeyFrame : QuaternionKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty UseShortestPathProperty;
+        public EasingQuaternionKeyFrame();
+        public EasingQuaternionKeyFrame(Quaternion value);
+        public EasingQuaternionKeyFrame(Quaternion value, KeyTime keyTime);
+        public EasingQuaternionKeyFrame(Quaternion value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        public bool UseShortestPath { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Quaternion InterpolateValueCore(Quaternion baseValue, double keyFrameProgress);
+    }
+    public class EasingRectKeyFrame : RectKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingRectKeyFrame();
+        public EasingRectKeyFrame(Rect value);
+        public EasingRectKeyFrame(Rect value, KeyTime keyTime);
+        public EasingRectKeyFrame(Rect value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Rect InterpolateValueCore(Rect baseValue, double keyFrameProgress);
+    }
+    public class EasingRotation3DKeyFrame : Rotation3DKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingRotation3DKeyFrame();
+        public EasingRotation3DKeyFrame(Rotation3D value);
+        public EasingRotation3DKeyFrame(Rotation3D value, KeyTime keyTime);
+        public EasingRotation3DKeyFrame(Rotation3D value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Rotation3D InterpolateValueCore(Rotation3D baseValue, double keyFrameProgress);
+    }
+    public class EasingSingleKeyFrame : SingleKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingSingleKeyFrame();
+        public EasingSingleKeyFrame(float value);
+        public EasingSingleKeyFrame(float value, KeyTime keyTime);
+        public EasingSingleKeyFrame(float value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override float InterpolateValueCore(float baseValue, double keyFrameProgress);
+    }
+    public class EasingSizeKeyFrame : SizeKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingSizeKeyFrame();
+        public EasingSizeKeyFrame(Size value);
+        public EasingSizeKeyFrame(Size value, KeyTime keyTime);
+        public EasingSizeKeyFrame(Size value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Size InterpolateValueCore(Size baseValue, double keyFrameProgress);
+    }
+    public class EasingThicknessKeyFrame : ThicknessKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingThicknessKeyFrame();
+        public EasingThicknessKeyFrame(Thickness value);
+        public EasingThicknessKeyFrame(Thickness value, KeyTime keyTime);
+        public EasingThicknessKeyFrame(Thickness value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Thickness InterpolateValueCore(Thickness baseValue, double keyFrameProgress);
+    }
+    public class EasingVector3DKeyFrame : Vector3DKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingVector3DKeyFrame();
+        public EasingVector3DKeyFrame(Vector3D value);
+        public EasingVector3DKeyFrame(Vector3D value, KeyTime keyTime);
+        public EasingVector3DKeyFrame(Vector3D value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Vector3D InterpolateValueCore(Vector3D baseValue, double keyFrameProgress);
+    }
+    public class EasingVectorKeyFrame : VectorKeyFrame {
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public EasingVectorKeyFrame();
+        public EasingVectorKeyFrame(Vector value);
+        public EasingVectorKeyFrame(Vector value, KeyTime keyTime);
+        public EasingVectorKeyFrame(Vector value, KeyTime keyTime, IEasingFunction easingFunction);
+        public IEasingFunction EasingFunction { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Vector InterpolateValueCore(Vector baseValue, double keyFrameProgress);
+    }
+    public class ElasticEase : EasingFunctionBase {
+        public static readonly DependencyProperty OscillationsProperty;
+        public static readonly DependencyProperty SpringinessProperty;
+        public ElasticEase();
+        public int Oscillations { get; set; }
+        public double Springiness { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class ExponentialEase : EasingFunctionBase {
+        public static readonly DependencyProperty ExponentProperty;
+        public ExponentialEase();
+        public double Exponent { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public enum FillBehavior {
+        HoldEnd = 0,
+        Stop = 1,
+    }
+    public enum HandoffBehavior {
+        Compose = 1,
+        SnapshotAndReplace = 0,
+    }
+    public interface IAnimatable {
+        bool HasAnimatedProperties { get; }
+        void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock);
+        void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock, HandoffBehavior handoffBehavior);
+        void BeginAnimation(DependencyProperty dp, AnimationTimeline animation);
+        void BeginAnimation(DependencyProperty dp, AnimationTimeline animation, HandoffBehavior handoffBehavior);
+        object GetAnimationBaseValue(DependencyProperty dp);
+    }
+    public interface IEasingFunction {
+        double Ease(double normalizedTime);
+    }
+    public interface IKeyFrame {
+        KeyTime KeyTime { get; set; }
+        object Value { get; set; }
+    }
+    public interface IKeyFrameAnimation {
+        IList KeyFrames { get; set; }
+    }
+    public class Int16Animation : Int16AnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public Int16Animation();
+        public Int16Animation(short fromValue, short toValue, Duration duration);
+        public Int16Animation(short fromValue, short toValue, Duration duration, FillBehavior fillBehavior);
+        public Int16Animation(short toValue, Duration duration);
+        public Int16Animation(short toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<short> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<short> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<short> To { get; set; }
+        public new Int16Animation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override short GetCurrentValueCore(short defaultOriginValue, short defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class Int16AnimationBase : AnimationTimeline {
+        protected Int16AnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new Int16AnimationBase Clone();
+        public short GetCurrentValue(short defaultOriginValue, short defaultDestinationValue, AnimationClock animationClock);
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract short GetCurrentValueCore(short defaultOriginValue, short defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class Int16AnimationUsingKeyFrames : Int16AnimationBase, IAddChild, IKeyFrameAnimation {
+        public Int16AnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Int16KeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new Int16AnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new Int16AnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override short GetCurrentValueCore(short defaultOriginValue, short defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class Int16KeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected Int16KeyFrame();
+        protected Int16KeyFrame(short value);
+        protected Int16KeyFrame(short value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public short Value { get; set; }
+        public short InterpolateValue(short baseValue, double keyFrameProgress);
+        protected abstract short InterpolateValueCore(short baseValue, double keyFrameProgress);
+    }
+    public class Int16KeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public Int16KeyFrameCollection();
+        public int Count { get; }
+        public static Int16KeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Int16KeyFrame this[int index] { get; set; }
+        public int Add(Int16KeyFrame keyFrame);
+        public void Clear();
+        public new Int16KeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(Int16KeyFrame keyFrame);
+        public void CopyTo(Int16KeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(Int16KeyFrame keyFrame);
+        public void Insert(int index, Int16KeyFrame keyFrame);
+        public void Remove(Int16KeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class Int32Animation : Int32AnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public Int32Animation();
+        public Int32Animation(int fromValue, int toValue, Duration duration);
+        public Int32Animation(int fromValue, int toValue, Duration duration, FillBehavior fillBehavior);
+        public Int32Animation(int toValue, Duration duration);
+        public Int32Animation(int toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<int> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<int> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<int> To { get; set; }
+        public new Int32Animation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override int GetCurrentValueCore(int defaultOriginValue, int defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class Int32AnimationBase : AnimationTimeline {
+        protected Int32AnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new Int32AnimationBase Clone();
+        public int GetCurrentValue(int defaultOriginValue, int defaultDestinationValue, AnimationClock animationClock);
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract int GetCurrentValueCore(int defaultOriginValue, int defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class Int32AnimationUsingKeyFrames : Int32AnimationBase, IAddChild, IKeyFrameAnimation {
+        public Int32AnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Int32KeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new Int32AnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new Int32AnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override int GetCurrentValueCore(int defaultOriginValue, int defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class Int32KeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected Int32KeyFrame();
+        protected Int32KeyFrame(int value);
+        protected Int32KeyFrame(int value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public int Value { get; set; }
+        public int InterpolateValue(int baseValue, double keyFrameProgress);
+        protected abstract int InterpolateValueCore(int baseValue, double keyFrameProgress);
+    }
+    public class Int32KeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public Int32KeyFrameCollection();
+        public int Count { get; }
+        public static Int32KeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Int32KeyFrame this[int index] { get; set; }
+        public int Add(Int32KeyFrame keyFrame);
+        public void Clear();
+        public new Int32KeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(Int32KeyFrame keyFrame);
+        public void CopyTo(Int32KeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(Int32KeyFrame keyFrame);
+        public void Insert(int index, Int32KeyFrame keyFrame);
+        public void Remove(Int32KeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class Int64Animation : Int64AnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public Int64Animation();
+        public Int64Animation(long fromValue, long toValue, Duration duration);
+        public Int64Animation(long fromValue, long toValue, Duration duration, FillBehavior fillBehavior);
+        public Int64Animation(long toValue, Duration duration);
+        public Int64Animation(long toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<long> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<long> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<long> To { get; set; }
+        public new Int64Animation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override long GetCurrentValueCore(long defaultOriginValue, long defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class Int64AnimationBase : AnimationTimeline {
+        protected Int64AnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new Int64AnimationBase Clone();
+        public long GetCurrentValue(long defaultOriginValue, long defaultDestinationValue, AnimationClock animationClock);
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract long GetCurrentValueCore(long defaultOriginValue, long defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class Int64AnimationUsingKeyFrames : Int64AnimationBase, IAddChild, IKeyFrameAnimation {
+        public Int64AnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Int64KeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new Int64AnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new Int64AnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override long GetCurrentValueCore(long defaultOriginValue, long defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class Int64KeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected Int64KeyFrame();
+        protected Int64KeyFrame(long value);
+        protected Int64KeyFrame(long value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public long Value { get; set; }
+        public long InterpolateValue(long baseValue, double keyFrameProgress);
+        protected abstract long InterpolateValueCore(long baseValue, double keyFrameProgress);
+    }
+    public class Int64KeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public Int64KeyFrameCollection();
+        public int Count { get; }
+        public static Int64KeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Int64KeyFrame this[int index] { get; set; }
+        public int Add(Int64KeyFrame keyFrame);
+        public void Clear();
+        public new Int64KeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(Int64KeyFrame keyFrame);
+        public void CopyTo(Int64KeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(Int64KeyFrame keyFrame);
+        public void Insert(int index, Int64KeyFrame keyFrame);
+        public void Remove(Int64KeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class KeySpline : Freezable, IFormattable {
+        public KeySpline();
+        public KeySpline(double x1, double y1, double x2, double y2);
+        public KeySpline(Point controlPoint1, Point controlPoint2);
+        public Point ControlPoint1 { get; set; }
+        public Point ControlPoint2 { get; set; }
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public double GetSplineProgress(double linearProgress);
+        protected override void OnChanged();
+        string System.IFormattable.ToString(string format, IFormatProvider formatProvider);
+        public override string ToString();
+        public string ToString(IFormatProvider formatProvider);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct KeyTime : IEquatable<KeyTime> {
+        public static KeyTime Paced { get; }
+        public double Percent { get; }
+        public TimeSpan TimeSpan { get; }
+        public KeyTimeType Type { get; }
+        public static KeyTime Uniform { get; }
+        public override bool Equals(object value);
+        public bool Equals(KeyTime value);
+        public static bool Equals(KeyTime keyTime1, KeyTime keyTime2);
+        public static KeyTime FromPercent(double percent);
+        public static KeyTime FromTimeSpan(TimeSpan timeSpan);
+        public override int GetHashCode();
+        public static bool operator ==(KeyTime keyTime1, KeyTime keyTime2);
+        public static implicit operator KeyTime (TimeSpan timeSpan);
+        public static bool operator !=(KeyTime keyTime1, KeyTime keyTime2);
+        public override string ToString();
+    }
+    public enum KeyTimeType : byte {
+        Paced = (byte)3,
+        Percent = (byte)1,
+        TimeSpan = (byte)2,
+        Uniform = (byte)0,
+    }
+    public class LinearByteKeyFrame : ByteKeyFrame {
+        public LinearByteKeyFrame();
+        public LinearByteKeyFrame(byte value);
+        public LinearByteKeyFrame(byte value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override byte InterpolateValueCore(byte baseValue, double keyFrameProgress);
+    }
+    public class LinearColorKeyFrame : ColorKeyFrame {
+        public LinearColorKeyFrame();
+        public LinearColorKeyFrame(Color value);
+        public LinearColorKeyFrame(Color value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Color InterpolateValueCore(Color baseValue, double keyFrameProgress);
+    }
+    public class LinearDecimalKeyFrame : DecimalKeyFrame {
+        public LinearDecimalKeyFrame();
+        public LinearDecimalKeyFrame(decimal value);
+        public LinearDecimalKeyFrame(decimal value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override decimal InterpolateValueCore(decimal baseValue, double keyFrameProgress);
+    }
+    public class LinearDoubleKeyFrame : DoubleKeyFrame {
+        public LinearDoubleKeyFrame();
+        public LinearDoubleKeyFrame(double value);
+        public LinearDoubleKeyFrame(double value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override double InterpolateValueCore(double baseValue, double keyFrameProgress);
+    }
+    public class LinearInt16KeyFrame : Int16KeyFrame {
+        public LinearInt16KeyFrame();
+        public LinearInt16KeyFrame(short value);
+        public LinearInt16KeyFrame(short value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override short InterpolateValueCore(short baseValue, double keyFrameProgress);
+    }
+    public class LinearInt32KeyFrame : Int32KeyFrame {
+        public LinearInt32KeyFrame();
+        public LinearInt32KeyFrame(int value);
+        public LinearInt32KeyFrame(int value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override int InterpolateValueCore(int baseValue, double keyFrameProgress);
+    }
+    public class LinearInt64KeyFrame : Int64KeyFrame {
+        public LinearInt64KeyFrame();
+        public LinearInt64KeyFrame(long value);
+        public LinearInt64KeyFrame(long value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override long InterpolateValueCore(long baseValue, double keyFrameProgress);
+    }
+    public class LinearPoint3DKeyFrame : Point3DKeyFrame {
+        public LinearPoint3DKeyFrame();
+        public LinearPoint3DKeyFrame(Point3D value);
+        public LinearPoint3DKeyFrame(Point3D value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Point3D InterpolateValueCore(Point3D baseValue, double keyFrameProgress);
+    }
+    public class LinearPointKeyFrame : PointKeyFrame {
+        public LinearPointKeyFrame();
+        public LinearPointKeyFrame(Point value);
+        public LinearPointKeyFrame(Point value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Point InterpolateValueCore(Point baseValue, double keyFrameProgress);
+    }
+    public class LinearQuaternionKeyFrame : QuaternionKeyFrame {
+        public static readonly DependencyProperty UseShortestPathProperty;
+        public LinearQuaternionKeyFrame();
+        public LinearQuaternionKeyFrame(Quaternion value);
+        public LinearQuaternionKeyFrame(Quaternion value, KeyTime keyTime);
+        public bool UseShortestPath { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Quaternion InterpolateValueCore(Quaternion baseValue, double keyFrameProgress);
+    }
+    public class LinearRectKeyFrame : RectKeyFrame {
+        public LinearRectKeyFrame();
+        public LinearRectKeyFrame(Rect value);
+        public LinearRectKeyFrame(Rect value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Rect InterpolateValueCore(Rect baseValue, double keyFrameProgress);
+    }
+    public class LinearRotation3DKeyFrame : Rotation3DKeyFrame {
+        public LinearRotation3DKeyFrame();
+        public LinearRotation3DKeyFrame(Rotation3D value);
+        public LinearRotation3DKeyFrame(Rotation3D value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Rotation3D InterpolateValueCore(Rotation3D baseValue, double keyFrameProgress);
+    }
+    public class LinearSingleKeyFrame : SingleKeyFrame {
+        public LinearSingleKeyFrame();
+        public LinearSingleKeyFrame(float value);
+        public LinearSingleKeyFrame(float value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override float InterpolateValueCore(float baseValue, double keyFrameProgress);
+    }
+    public class LinearSizeKeyFrame : SizeKeyFrame {
+        public LinearSizeKeyFrame();
+        public LinearSizeKeyFrame(Size value);
+        public LinearSizeKeyFrame(Size value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Size InterpolateValueCore(Size baseValue, double keyFrameProgress);
+    }
+    public class LinearThicknessKeyFrame : ThicknessKeyFrame {
+        public LinearThicknessKeyFrame();
+        public LinearThicknessKeyFrame(Thickness value);
+        public LinearThicknessKeyFrame(Thickness value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Thickness InterpolateValueCore(Thickness baseValue, double keyFrameProgress);
+    }
+    public class LinearVector3DKeyFrame : Vector3DKeyFrame {
+        public LinearVector3DKeyFrame();
+        public LinearVector3DKeyFrame(Vector3D value);
+        public LinearVector3DKeyFrame(Vector3D value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Vector3D InterpolateValueCore(Vector3D baseValue, double keyFrameProgress);
+    }
+    public class LinearVectorKeyFrame : VectorKeyFrame {
+        public LinearVectorKeyFrame();
+        public LinearVectorKeyFrame(Vector value);
+        public LinearVectorKeyFrame(Vector value, KeyTime keyTime);
+        protected override Freezable CreateInstanceCore();
+        protected override Vector InterpolateValueCore(Vector baseValue, double keyFrameProgress);
+    }
+    public abstract class MatrixAnimationBase : AnimationTimeline {
+        protected MatrixAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new MatrixAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Matrix GetCurrentValue(Matrix defaultOriginValue, Matrix defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Matrix GetCurrentValueCore(Matrix defaultOriginValue, Matrix defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class MatrixAnimationUsingKeyFrames : MatrixAnimationBase, IAddChild, IKeyFrameAnimation {
+        public MatrixAnimationUsingKeyFrames();
+        public MatrixKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new MatrixAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new MatrixAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Matrix GetCurrentValueCore(Matrix defaultOriginValue, Matrix defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public class MatrixAnimationUsingPath : MatrixAnimationBase {
+        public static readonly DependencyProperty DoesRotateWithTangentProperty;
+        public static readonly DependencyProperty IsAngleCumulativeProperty;
+        public static readonly DependencyProperty IsOffsetCumulativeProperty;
+        public static readonly DependencyProperty PathGeometryProperty;
+        public MatrixAnimationUsingPath();
+        public bool DoesRotateWithTangent { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsAngleCumulative { get; set; }
+        public bool IsOffsetCumulative { get; set; }
+        public PathGeometry PathGeometry { get; set; }
+        public new MatrixAnimationUsingPath Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Matrix GetCurrentValueCore(Matrix defaultOriginValue, Matrix defaultDestinationValue, AnimationClock animationClock);
+        protected override void OnChanged();
+    }
+    public abstract class MatrixKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected MatrixKeyFrame();
+        protected MatrixKeyFrame(Matrix value);
+        protected MatrixKeyFrame(Matrix value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Matrix Value { get; set; }
+        public Matrix InterpolateValue(Matrix baseValue, double keyFrameProgress);
+        protected abstract Matrix InterpolateValueCore(Matrix baseValue, double keyFrameProgress);
+    }
+    public class MatrixKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public MatrixKeyFrameCollection();
+        public int Count { get; }
+        public static MatrixKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public MatrixKeyFrame this[int index] { get; set; }
+        public int Add(MatrixKeyFrame keyFrame);
+        public void Clear();
+        public new MatrixKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(MatrixKeyFrame keyFrame);
+        public void CopyTo(MatrixKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(MatrixKeyFrame keyFrame);
+        public void Insert(int index, MatrixKeyFrame keyFrame);
+        public void Remove(MatrixKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public abstract class ObjectAnimationBase : AnimationTimeline {
+        protected ObjectAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new ObjectAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected abstract object GetCurrentValueCore(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class ObjectAnimationUsingKeyFrames : ObjectAnimationBase, IAddChild, IKeyFrameAnimation {
+        public ObjectAnimationUsingKeyFrames();
+        public ObjectKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new ObjectAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new ObjectAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override object GetCurrentValueCore(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class ObjectKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected ObjectKeyFrame();
+        protected ObjectKeyFrame(object value);
+        protected ObjectKeyFrame(object value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public object Value { get; set; }
+        public object InterpolateValue(object baseValue, double keyFrameProgress);
+        protected abstract object InterpolateValueCore(object baseValue, double keyFrameProgress);
+    }
+    public class ObjectKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public ObjectKeyFrameCollection();
+        public int Count { get; }
+        public static ObjectKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public ObjectKeyFrame this[int index] { get; set; }
+        public int Add(ObjectKeyFrame keyFrame);
+        public void Clear();
+        public new ObjectKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(ObjectKeyFrame keyFrame);
+        public void CopyTo(ObjectKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(ObjectKeyFrame keyFrame);
+        public void Insert(int index, ObjectKeyFrame keyFrame);
+        public void Remove(ObjectKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class ParallelTimeline : TimelineGroup {
+        public static readonly DependencyProperty SlipBehaviorProperty;
+        public ParallelTimeline();
+        public ParallelTimeline(Nullable<TimeSpan> beginTime);
+        public ParallelTimeline(Nullable<TimeSpan> beginTime, Duration duration);
+        public ParallelTimeline(Nullable<TimeSpan> beginTime, Duration duration, RepeatBehavior repeatBehavior);
+        public SlipBehavior SlipBehavior { get; set; }
+        public new ParallelTimeline Clone();
+        public new ParallelTimeline CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override Duration GetNaturalDurationCore(Clock clock);
+    }
+    public enum PathAnimationSource : byte {
+        Angle = (byte)2,
+        X = (byte)0,
+        Y = (byte)1,
+    }
+    public sealed class PauseStoryboard : ControllableStoryboardAction {
+        public PauseStoryboard();
+    }
+    public class Point3DAnimation : Point3DAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public Point3DAnimation();
+        public Point3DAnimation(Point3D toValue, Duration duration);
+        public Point3DAnimation(Point3D toValue, Duration duration, FillBehavior fillBehavior);
+        public Point3DAnimation(Point3D fromValue, Point3D toValue, Duration duration);
+        public Point3DAnimation(Point3D fromValue, Point3D toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Point3D> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Point3D> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Point3D> To { get; set; }
+        public new Point3DAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Point3D GetCurrentValueCore(Point3D defaultOriginValue, Point3D defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class Point3DAnimationBase : AnimationTimeline {
+        protected Point3DAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new Point3DAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Point3D GetCurrentValue(Point3D defaultOriginValue, Point3D defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Point3D GetCurrentValueCore(Point3D defaultOriginValue, Point3D defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class Point3DAnimationUsingKeyFrames : Point3DAnimationBase, IAddChild, IKeyFrameAnimation {
+        public Point3DAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Point3DKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new Point3DAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new Point3DAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Point3D GetCurrentValueCore(Point3D defaultOriginValue, Point3D defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class Point3DKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected Point3DKeyFrame();
+        protected Point3DKeyFrame(Point3D value);
+        protected Point3DKeyFrame(Point3D value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Point3D Value { get; set; }
+        public Point3D InterpolateValue(Point3D baseValue, double keyFrameProgress);
+        protected abstract Point3D InterpolateValueCore(Point3D baseValue, double keyFrameProgress);
+    }
+    public class Point3DKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public Point3DKeyFrameCollection();
+        public int Count { get; }
+        public static Point3DKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Point3DKeyFrame this[int index] { get; set; }
+        public int Add(Point3DKeyFrame keyFrame);
+        public void Clear();
+        public new Point3DKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(Point3DKeyFrame keyFrame);
+        public void CopyTo(Point3DKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(Point3DKeyFrame keyFrame);
+        public void Insert(int index, Point3DKeyFrame keyFrame);
+        public void Remove(Point3DKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class PointAnimation : PointAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public PointAnimation();
+        public PointAnimation(Point toValue, Duration duration);
+        public PointAnimation(Point toValue, Duration duration, FillBehavior fillBehavior);
+        public PointAnimation(Point fromValue, Point toValue, Duration duration);
+        public PointAnimation(Point fromValue, Point toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Point> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Point> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Point> To { get; set; }
+        public new PointAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Point GetCurrentValueCore(Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class PointAnimationBase : AnimationTimeline {
+        protected PointAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new PointAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Point GetCurrentValue(Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Point GetCurrentValueCore(Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class PointAnimationUsingKeyFrames : PointAnimationBase, IAddChild, IKeyFrameAnimation {
+        public PointAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public PointKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new PointAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new PointAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Point GetCurrentValueCore(Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public class PointAnimationUsingPath : PointAnimationBase {
+        public static readonly DependencyProperty PathGeometryProperty;
+        public PointAnimationUsingPath();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public PathGeometry PathGeometry { get; set; }
+        public new PointAnimationUsingPath Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Point GetCurrentValueCore(Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock);
+        protected override void OnChanged();
+    }
+    public abstract class PointKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected PointKeyFrame();
+        protected PointKeyFrame(Point value);
+        protected PointKeyFrame(Point value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Point Value { get; set; }
+        public Point InterpolateValue(Point baseValue, double keyFrameProgress);
+        protected abstract Point InterpolateValueCore(Point baseValue, double keyFrameProgress);
+    }
+    public class PointKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public PointKeyFrameCollection();
+        public int Count { get; }
+        public static PointKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public PointKeyFrame this[int index] { get; set; }
+        public int Add(PointKeyFrame keyFrame);
+        public void Clear();
+        public new PointKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(PointKeyFrame keyFrame);
+        public void CopyTo(PointKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(PointKeyFrame keyFrame);
+        public void Insert(int index, PointKeyFrame keyFrame);
+        public void Remove(PointKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class PowerEase : EasingFunctionBase {
+        public static readonly DependencyProperty PowerProperty;
+        public PowerEase();
+        public double Power { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class QuadraticEase : EasingFunctionBase {
+        public QuadraticEase();
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class QuarticEase : EasingFunctionBase {
+        public QuarticEase();
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class QuaternionAnimation : QuaternionAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public static readonly DependencyProperty UseShortestPathProperty;
+        public QuaternionAnimation();
+        public QuaternionAnimation(Quaternion toValue, Duration duration);
+        public QuaternionAnimation(Quaternion toValue, Duration duration, FillBehavior fillBehavior);
+        public QuaternionAnimation(Quaternion fromValue, Quaternion toValue, Duration duration);
+        public QuaternionAnimation(Quaternion fromValue, Quaternion toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Quaternion> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Quaternion> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Quaternion> To { get; set; }
+        public bool UseShortestPath { get; set; }
+        public new QuaternionAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Quaternion GetCurrentValueCore(Quaternion defaultOriginValue, Quaternion defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class QuaternionAnimationBase : AnimationTimeline {
+        protected QuaternionAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new QuaternionAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Quaternion GetCurrentValue(Quaternion defaultOriginValue, Quaternion defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Quaternion GetCurrentValueCore(Quaternion defaultOriginValue, Quaternion defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class QuaternionAnimationUsingKeyFrames : QuaternionAnimationBase, IAddChild, IKeyFrameAnimation {
+        public QuaternionAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public QuaternionKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new QuaternionAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new QuaternionAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Quaternion GetCurrentValueCore(Quaternion defaultOriginValue, Quaternion defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class QuaternionKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected QuaternionKeyFrame();
+        protected QuaternionKeyFrame(Quaternion value);
+        protected QuaternionKeyFrame(Quaternion value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Quaternion Value { get; set; }
+        public Quaternion InterpolateValue(Quaternion baseValue, double keyFrameProgress);
+        protected abstract Quaternion InterpolateValueCore(Quaternion baseValue, double keyFrameProgress);
+    }
+    public class QuaternionKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public QuaternionKeyFrameCollection();
+        public int Count { get; }
+        public static QuaternionKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public QuaternionKeyFrame this[int index] { get; set; }
+        public int Add(QuaternionKeyFrame keyFrame);
+        public void Clear();
+        public new QuaternionKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(QuaternionKeyFrame keyFrame);
+        public void CopyTo(QuaternionKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(QuaternionKeyFrame keyFrame);
+        public void Insert(int index, QuaternionKeyFrame keyFrame);
+        public void Remove(QuaternionKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class QuinticEase : EasingFunctionBase {
+        public QuinticEase();
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class RectAnimation : RectAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public RectAnimation();
+        public RectAnimation(Rect toValue, Duration duration);
+        public RectAnimation(Rect toValue, Duration duration, FillBehavior fillBehavior);
+        public RectAnimation(Rect fromValue, Rect toValue, Duration duration);
+        public RectAnimation(Rect fromValue, Rect toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Rect> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Rect> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Rect> To { get; set; }
+        public new RectAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Rect GetCurrentValueCore(Rect defaultOriginValue, Rect defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class RectAnimationBase : AnimationTimeline {
+        protected RectAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new RectAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Rect GetCurrentValue(Rect defaultOriginValue, Rect defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Rect GetCurrentValueCore(Rect defaultOriginValue, Rect defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class RectAnimationUsingKeyFrames : RectAnimationBase, IAddChild, IKeyFrameAnimation {
+        public RectAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public RectKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new RectAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new RectAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Rect GetCurrentValueCore(Rect defaultOriginValue, Rect defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class RectKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected RectKeyFrame();
+        protected RectKeyFrame(Rect value);
+        protected RectKeyFrame(Rect value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Rect Value { get; set; }
+        public Rect InterpolateValue(Rect baseValue, double keyFrameProgress);
+        protected abstract Rect InterpolateValueCore(Rect baseValue, double keyFrameProgress);
+    }
+    public class RectKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public RectKeyFrameCollection();
+        public int Count { get; }
+        public static RectKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public RectKeyFrame this[int index] { get; set; }
+        public int Add(RectKeyFrame keyFrame);
+        public void Clear();
+        public new RectKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(RectKeyFrame keyFrame);
+        public void CopyTo(RectKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(RectKeyFrame keyFrame);
+        public void Insert(int index, RectKeyFrame keyFrame);
+        public void Remove(RectKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public sealed class RemoveStoryboard : ControllableStoryboardAction {
+        public RemoveStoryboard();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RepeatBehavior : IFormattable {
+        public RepeatBehavior(double count);
+        public RepeatBehavior(TimeSpan duration);
+        public double Count { get; }
+        public TimeSpan Duration { get; }
+        public static RepeatBehavior Forever { get; }
+        public bool HasCount { get; }
+        public bool HasDuration { get; }
+        public override bool Equals(object value);
+        public bool Equals(RepeatBehavior repeatBehavior);
+        public static bool Equals(RepeatBehavior repeatBehavior1, RepeatBehavior repeatBehavior2);
+        public override int GetHashCode();
+        public static bool operator ==(RepeatBehavior repeatBehavior1, RepeatBehavior repeatBehavior2);
+        public static bool operator !=(RepeatBehavior repeatBehavior1, RepeatBehavior repeatBehavior2);
+        string System.IFormattable.ToString(string format, IFormatProvider formatProvider);
+        public override string ToString();
+        public string ToString(IFormatProvider formatProvider);
+    }
+    public sealed class RepeatBehaviorConverter : TypeConverter {
+        public RepeatBehaviorConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo cultureInfo, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public sealed class ResumeStoryboard : ControllableStoryboardAction {
+        public ResumeStoryboard();
+    }
+    public class Rotation3DAnimation : Rotation3DAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public Rotation3DAnimation();
+        public Rotation3DAnimation(Rotation3D toValue, Duration duration);
+        public Rotation3DAnimation(Rotation3D toValue, Duration duration, FillBehavior fillBehavior);
+        public Rotation3DAnimation(Rotation3D fromValue, Rotation3D toValue, Duration duration);
+        public Rotation3DAnimation(Rotation3D fromValue, Rotation3D toValue, Duration duration, FillBehavior fillBehavior);
+        public Rotation3D By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Rotation3D From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Rotation3D To { get; set; }
+        public new Rotation3DAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Rotation3D GetCurrentValueCore(Rotation3D defaultOriginValue, Rotation3D defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class Rotation3DAnimationBase : AnimationTimeline {
+        protected Rotation3DAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new Rotation3DAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Rotation3D GetCurrentValue(Rotation3D defaultOriginValue, Rotation3D defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Rotation3D GetCurrentValueCore(Rotation3D defaultOriginValue, Rotation3D defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class Rotation3DAnimationUsingKeyFrames : Rotation3DAnimationBase, IAddChild, IKeyFrameAnimation {
+        public Rotation3DAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Rotation3DKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new Rotation3DAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new Rotation3DAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Rotation3D GetCurrentValueCore(Rotation3D defaultOriginValue, Rotation3D defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class Rotation3DKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected Rotation3DKeyFrame();
+        protected Rotation3DKeyFrame(Rotation3D value);
+        protected Rotation3DKeyFrame(Rotation3D value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Rotation3D Value { get; set; }
+        public Rotation3D InterpolateValue(Rotation3D baseValue, double keyFrameProgress);
+        protected abstract Rotation3D InterpolateValueCore(Rotation3D baseValue, double keyFrameProgress);
+    }
+    public class Rotation3DKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public Rotation3DKeyFrameCollection();
+        public int Count { get; }
+        public static Rotation3DKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Rotation3DKeyFrame this[int index] { get; set; }
+        public int Add(Rotation3DKeyFrame keyFrame);
+        public void Clear();
+        public new Rotation3DKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(Rotation3DKeyFrame keyFrame);
+        public void CopyTo(Rotation3DKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(Rotation3DKeyFrame keyFrame);
+        public void Insert(int index, Rotation3DKeyFrame keyFrame);
+        public void Remove(Rotation3DKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public sealed class SeekStoryboard : ControllableStoryboardAction {
+        public SeekStoryboard();
+        public TimeSpan Offset { get; set; }
+        public TimeSeekOrigin Origin { get; set; }
+        public bool ShouldSerializeOffset();
+    }
+    public sealed class SetStoryboardSpeedRatio : ControllableStoryboardAction {
+        public SetStoryboardSpeedRatio();
+        public double SpeedRatio { get; set; }
+    }
+    public class SineEase : EasingFunctionBase {
+        public SineEase();
+        protected override Freezable CreateInstanceCore();
+        protected override double EaseInCore(double normalizedTime);
+    }
+    public class SingleAnimation : SingleAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public SingleAnimation();
+        public SingleAnimation(float fromValue, float toValue, Duration duration);
+        public SingleAnimation(float fromValue, float toValue, Duration duration, FillBehavior fillBehavior);
+        public SingleAnimation(float toValue, Duration duration);
+        public SingleAnimation(float toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<float> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<float> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<float> To { get; set; }
+        public new SingleAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override float GetCurrentValueCore(float defaultOriginValue, float defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class SingleAnimationBase : AnimationTimeline {
+        protected SingleAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new SingleAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public float GetCurrentValue(float defaultOriginValue, float defaultDestinationValue, AnimationClock animationClock);
+        protected abstract float GetCurrentValueCore(float defaultOriginValue, float defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class SingleAnimationUsingKeyFrames : SingleAnimationBase, IAddChild, IKeyFrameAnimation {
+        public SingleAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public SingleKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new SingleAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new SingleAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override float GetCurrentValueCore(float defaultOriginValue, float defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class SingleKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected SingleKeyFrame();
+        protected SingleKeyFrame(float value);
+        protected SingleKeyFrame(float value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public float Value { get; set; }
+        public float InterpolateValue(float baseValue, double keyFrameProgress);
+        protected abstract float InterpolateValueCore(float baseValue, double keyFrameProgress);
+    }
+    public class SingleKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public SingleKeyFrameCollection();
+        public int Count { get; }
+        public static SingleKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public SingleKeyFrame this[int index] { get; set; }
+        public int Add(SingleKeyFrame keyFrame);
+        public void Clear();
+        public new SingleKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(SingleKeyFrame keyFrame);
+        public void CopyTo(SingleKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(SingleKeyFrame keyFrame);
+        public void Insert(int index, SingleKeyFrame keyFrame);
+        public void Remove(SingleKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class SizeAnimation : SizeAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public SizeAnimation();
+        public SizeAnimation(Size toValue, Duration duration);
+        public SizeAnimation(Size toValue, Duration duration, FillBehavior fillBehavior);
+        public SizeAnimation(Size fromValue, Size toValue, Duration duration);
+        public SizeAnimation(Size fromValue, Size toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Size> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Size> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Size> To { get; set; }
+        public new SizeAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Size GetCurrentValueCore(Size defaultOriginValue, Size defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class SizeAnimationBase : AnimationTimeline {
+        protected SizeAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new SizeAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Size GetCurrentValue(Size defaultOriginValue, Size defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Size GetCurrentValueCore(Size defaultOriginValue, Size defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class SizeAnimationUsingKeyFrames : SizeAnimationBase, IAddChild, IKeyFrameAnimation {
+        public SizeAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public SizeKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new SizeAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new SizeAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Size GetCurrentValueCore(Size defaultOriginValue, Size defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class SizeKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected SizeKeyFrame();
+        protected SizeKeyFrame(Size value);
+        protected SizeKeyFrame(Size value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Size Value { get; set; }
+        public Size InterpolateValue(Size baseValue, double keyFrameProgress);
+        protected abstract Size InterpolateValueCore(Size baseValue, double keyFrameProgress);
+    }
+    public class SizeKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public SizeKeyFrameCollection();
+        public int Count { get; }
+        public static SizeKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public SizeKeyFrame this[int index] { get; set; }
+        public int Add(SizeKeyFrame keyFrame);
+        public void Clear();
+        public new SizeKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(SizeKeyFrame keyFrame);
+        public void CopyTo(SizeKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(SizeKeyFrame keyFrame);
+        public void Insert(int index, SizeKeyFrame keyFrame);
+        public void Remove(SizeKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public sealed class SkipStoryboardToFill : ControllableStoryboardAction {
+        public SkipStoryboardToFill();
+    }
+    public enum SlipBehavior {
+        Grow = 0,
+        Slip = 1,
+    }
+    public class SplineByteKeyFrame : ByteKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineByteKeyFrame();
+        public SplineByteKeyFrame(byte value);
+        public SplineByteKeyFrame(byte value, KeyTime keyTime);
+        public SplineByteKeyFrame(byte value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override byte InterpolateValueCore(byte baseValue, double keyFrameProgress);
+    }
+    public class SplineColorKeyFrame : ColorKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineColorKeyFrame();
+        public SplineColorKeyFrame(Color value);
+        public SplineColorKeyFrame(Color value, KeyTime keyTime);
+        public SplineColorKeyFrame(Color value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Color InterpolateValueCore(Color baseValue, double keyFrameProgress);
+    }
+    public class SplineDecimalKeyFrame : DecimalKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineDecimalKeyFrame();
+        public SplineDecimalKeyFrame(decimal value);
+        public SplineDecimalKeyFrame(decimal value, KeyTime keyTime);
+        public SplineDecimalKeyFrame(decimal value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override decimal InterpolateValueCore(decimal baseValue, double keyFrameProgress);
+    }
+    public class SplineDoubleKeyFrame : DoubleKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineDoubleKeyFrame();
+        public SplineDoubleKeyFrame(double value);
+        public SplineDoubleKeyFrame(double value, KeyTime keyTime);
+        public SplineDoubleKeyFrame(double value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override double InterpolateValueCore(double baseValue, double keyFrameProgress);
+    }
+    public class SplineInt16KeyFrame : Int16KeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineInt16KeyFrame();
+        public SplineInt16KeyFrame(short value);
+        public SplineInt16KeyFrame(short value, KeyTime keyTime);
+        public SplineInt16KeyFrame(short value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override short InterpolateValueCore(short baseValue, double keyFrameProgress);
+    }
+    public class SplineInt32KeyFrame : Int32KeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineInt32KeyFrame();
+        public SplineInt32KeyFrame(int value);
+        public SplineInt32KeyFrame(int value, KeyTime keyTime);
+        public SplineInt32KeyFrame(int value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override int InterpolateValueCore(int baseValue, double keyFrameProgress);
+    }
+    public class SplineInt64KeyFrame : Int64KeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineInt64KeyFrame();
+        public SplineInt64KeyFrame(long value);
+        public SplineInt64KeyFrame(long value, KeyTime keyTime);
+        public SplineInt64KeyFrame(long value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override long InterpolateValueCore(long baseValue, double keyFrameProgress);
+    }
+    public class SplinePoint3DKeyFrame : Point3DKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplinePoint3DKeyFrame();
+        public SplinePoint3DKeyFrame(Point3D value);
+        public SplinePoint3DKeyFrame(Point3D value, KeyTime keyTime);
+        public SplinePoint3DKeyFrame(Point3D value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Point3D InterpolateValueCore(Point3D baseValue, double keyFrameProgress);
+    }
+    public class SplinePointKeyFrame : PointKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplinePointKeyFrame();
+        public SplinePointKeyFrame(Point value);
+        public SplinePointKeyFrame(Point value, KeyTime keyTime);
+        public SplinePointKeyFrame(Point value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Point InterpolateValueCore(Point baseValue, double keyFrameProgress);
+    }
+    public class SplineQuaternionKeyFrame : QuaternionKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public static readonly DependencyProperty UseShortestPathProperty;
+        public SplineQuaternionKeyFrame();
+        public SplineQuaternionKeyFrame(Quaternion value);
+        public SplineQuaternionKeyFrame(Quaternion value, KeyTime keyTime);
+        public SplineQuaternionKeyFrame(Quaternion value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        public bool UseShortestPath { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Quaternion InterpolateValueCore(Quaternion baseValue, double keyFrameProgress);
+    }
+    public class SplineRectKeyFrame : RectKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineRectKeyFrame();
+        public SplineRectKeyFrame(Rect value);
+        public SplineRectKeyFrame(Rect value, KeyTime keyTime);
+        public SplineRectKeyFrame(Rect value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Rect InterpolateValueCore(Rect baseValue, double keyFrameProgress);
+    }
+    public class SplineRotation3DKeyFrame : Rotation3DKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineRotation3DKeyFrame();
+        public SplineRotation3DKeyFrame(Rotation3D value);
+        public SplineRotation3DKeyFrame(Rotation3D value, KeyTime keyTime);
+        public SplineRotation3DKeyFrame(Rotation3D value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Rotation3D InterpolateValueCore(Rotation3D baseValue, double keyFrameProgress);
+    }
+    public class SplineSingleKeyFrame : SingleKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineSingleKeyFrame();
+        public SplineSingleKeyFrame(float value);
+        public SplineSingleKeyFrame(float value, KeyTime keyTime);
+        public SplineSingleKeyFrame(float value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override float InterpolateValueCore(float baseValue, double keyFrameProgress);
+    }
+    public class SplineSizeKeyFrame : SizeKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineSizeKeyFrame();
+        public SplineSizeKeyFrame(Size value);
+        public SplineSizeKeyFrame(Size value, KeyTime keyTime);
+        public SplineSizeKeyFrame(Size value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Size InterpolateValueCore(Size baseValue, double keyFrameProgress);
+    }
+    public class SplineThicknessKeyFrame : ThicknessKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineThicknessKeyFrame();
+        public SplineThicknessKeyFrame(Thickness value);
+        public SplineThicknessKeyFrame(Thickness value, KeyTime keyTime);
+        public SplineThicknessKeyFrame(Thickness value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Thickness InterpolateValueCore(Thickness baseValue, double keyFrameProgress);
+    }
+    public class SplineVector3DKeyFrame : Vector3DKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineVector3DKeyFrame();
+        public SplineVector3DKeyFrame(Vector3D value);
+        public SplineVector3DKeyFrame(Vector3D value, KeyTime keyTime);
+        public SplineVector3DKeyFrame(Vector3D value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Vector3D InterpolateValueCore(Vector3D baseValue, double keyFrameProgress);
+    }
+    public class SplineVectorKeyFrame : VectorKeyFrame {
+        public static readonly DependencyProperty KeySplineProperty;
+        public SplineVectorKeyFrame();
+        public SplineVectorKeyFrame(Vector value);
+        public SplineVectorKeyFrame(Vector value, KeyTime keyTime);
+        public SplineVectorKeyFrame(Vector value, KeyTime keyTime, KeySpline keySpline);
+        public KeySpline KeySpline { get; set; }
+        protected override Freezable CreateInstanceCore();
+        protected override Vector InterpolateValueCore(Vector baseValue, double keyFrameProgress);
+    }
+    public sealed class StopStoryboard : ControllableStoryboardAction {
+        public StopStoryboard();
+    }
+    public class Storyboard : ParallelTimeline {
+        public static readonly DependencyProperty TargetNameProperty;
+        public static readonly DependencyProperty TargetProperty;
+        public static readonly DependencyProperty TargetPropertyProperty;
+        public Storyboard();
+        public void Begin();
+        public void Begin(FrameworkContentElement containingObject);
+        public void Begin(FrameworkContentElement containingObject, bool isControllable);
+        public void Begin(FrameworkContentElement containingObject, HandoffBehavior handoffBehavior);
+        public void Begin(FrameworkContentElement containingObject, HandoffBehavior handoffBehavior, bool isControllable);
+        public void Begin(FrameworkElement containingObject);
+        public void Begin(FrameworkElement containingObject, bool isControllable);
+        public void Begin(FrameworkElement containingObject, FrameworkTemplate frameworkTemplate);
+        public void Begin(FrameworkElement containingObject, FrameworkTemplate frameworkTemplate, bool isControllable);
+        public void Begin(FrameworkElement containingObject, FrameworkTemplate frameworkTemplate, HandoffBehavior handoffBehavior);
+        public void Begin(FrameworkElement containingObject, FrameworkTemplate frameworkTemplate, HandoffBehavior handoffBehavior, bool isControllable);
+        public void Begin(FrameworkElement containingObject, HandoffBehavior handoffBehavior);
+        public void Begin(FrameworkElement containingObject, HandoffBehavior handoffBehavior, bool isControllable);
+        public new Storyboard Clone();
+        protected override Freezable CreateInstanceCore();
+        public double GetCurrentGlobalSpeed();
+        public Nullable<double> GetCurrentGlobalSpeed(FrameworkContentElement containingObject);
+        public Nullable<double> GetCurrentGlobalSpeed(FrameworkElement containingObject);
+        public int GetCurrentIteration();
+        public Nullable<int> GetCurrentIteration(FrameworkContentElement containingObject);
+        public Nullable<int> GetCurrentIteration(FrameworkElement containingObject);
+        public double GetCurrentProgress();
+        public Nullable<double> GetCurrentProgress(FrameworkContentElement containingObject);
+        public Nullable<double> GetCurrentProgress(FrameworkElement containingObject);
+        public ClockState GetCurrentState();
+        public ClockState GetCurrentState(FrameworkContentElement containingObject);
+        public ClockState GetCurrentState(FrameworkElement containingObject);
+        public TimeSpan GetCurrentTime();
+        public Nullable<TimeSpan> GetCurrentTime(FrameworkContentElement containingObject);
+        public Nullable<TimeSpan> GetCurrentTime(FrameworkElement containingObject);
+        public bool GetIsPaused();
+        public bool GetIsPaused(FrameworkContentElement containingObject);
+        public bool GetIsPaused(FrameworkElement containingObject);
+        public static DependencyObject GetTarget(DependencyObject element);
+        public static string GetTargetName(DependencyObject element);
+        public static PropertyPath GetTargetProperty(DependencyObject element);
+        public void Pause();
+        public void Pause(FrameworkContentElement containingObject);
+        public void Pause(FrameworkElement containingObject);
+        public void Remove();
+        public void Remove(FrameworkContentElement containingObject);
+        public void Remove(FrameworkElement containingObject);
+        public void Resume();
+        public void Resume(FrameworkContentElement containingObject);
+        public void Resume(FrameworkElement containingObject);
+        public void Seek(TimeSpan offset);
+        public void Seek(TimeSpan offset, TimeSeekOrigin origin);
+        public void Seek(FrameworkContentElement containingObject, TimeSpan offset, TimeSeekOrigin origin);
+        public void Seek(FrameworkElement containingObject, TimeSpan offset, TimeSeekOrigin origin);
+        public void SeekAlignedToLastTick(TimeSpan offset);
+        public void SeekAlignedToLastTick(TimeSpan offset, TimeSeekOrigin origin);
+        public void SeekAlignedToLastTick(FrameworkContentElement containingObject, TimeSpan offset, TimeSeekOrigin origin);
+        public void SeekAlignedToLastTick(FrameworkElement containingObject, TimeSpan offset, TimeSeekOrigin origin);
+        public void SetSpeedRatio(double speedRatio);
+        public void SetSpeedRatio(FrameworkContentElement containingObject, double speedRatio);
+        public void SetSpeedRatio(FrameworkElement containingObject, double speedRatio);
+        public static void SetTarget(DependencyObject element, DependencyObject value);
+        public static void SetTargetName(DependencyObject element, string name);
+        public static void SetTargetProperty(DependencyObject element, PropertyPath path);
+        public void SkipToFill();
+        public void SkipToFill(FrameworkContentElement containingObject);
+        public void SkipToFill(FrameworkElement containingObject);
+        public void Stop();
+        public void Stop(FrameworkContentElement containingObject);
+        public void Stop(FrameworkElement containingObject);
+    }
+    public abstract class StringAnimationBase : AnimationTimeline {
+        protected StringAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new StringAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public string GetCurrentValue(string defaultOriginValue, string defaultDestinationValue, AnimationClock animationClock);
+        protected abstract string GetCurrentValueCore(string defaultOriginValue, string defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class StringAnimationUsingKeyFrames : StringAnimationBase, IAddChild, IKeyFrameAnimation {
+        public StringAnimationUsingKeyFrames();
+        public StringKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new StringAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new StringAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override string GetCurrentValueCore(string defaultOriginValue, string defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class StringKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected StringKeyFrame();
+        protected StringKeyFrame(string value);
+        protected StringKeyFrame(string value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public string Value { get; set; }
+        public string InterpolateValue(string baseValue, double keyFrameProgress);
+        protected abstract string InterpolateValueCore(string baseValue, double keyFrameProgress);
+    }
+    public class StringKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public StringKeyFrameCollection();
+        public int Count { get; }
+        public static StringKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public StringKeyFrame this[int index] { get; set; }
+        public int Add(StringKeyFrame keyFrame);
+        public void Clear();
+        public new StringKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(StringKeyFrame keyFrame);
+        public void CopyTo(StringKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(StringKeyFrame keyFrame);
+        public void Insert(int index, StringKeyFrame keyFrame);
+        public void Remove(StringKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class ThicknessAnimation : ThicknessAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public ThicknessAnimation();
+        public ThicknessAnimation(Thickness toValue, Duration duration);
+        public ThicknessAnimation(Thickness toValue, Duration duration, FillBehavior fillBehavior);
+        public ThicknessAnimation(Thickness fromValue, Thickness toValue, Duration duration);
+        public ThicknessAnimation(Thickness fromValue, Thickness toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Thickness> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Thickness> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Thickness> To { get; set; }
+        public new ThicknessAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Thickness GetCurrentValueCore(Thickness defaultOriginValue, Thickness defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class ThicknessAnimationBase : AnimationTimeline {
+        protected ThicknessAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new ThicknessAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Thickness GetCurrentValue(Thickness defaultOriginValue, Thickness defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Thickness GetCurrentValueCore(Thickness defaultOriginValue, Thickness defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class ThicknessAnimationUsingKeyFrames : ThicknessAnimationBase, IAddChild, IKeyFrameAnimation {
+        public ThicknessAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public ThicknessKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new ThicknessAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new ThicknessAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Thickness GetCurrentValueCore(Thickness defaultOriginValue, Thickness defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class ThicknessKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected ThicknessKeyFrame();
+        protected ThicknessKeyFrame(Thickness value);
+        protected ThicknessKeyFrame(Thickness value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Thickness Value { get; set; }
+        public Thickness InterpolateValue(Thickness baseValue, double keyFrameProgress);
+        protected abstract Thickness InterpolateValueCore(Thickness baseValue, double keyFrameProgress);
+    }
+    public class ThicknessKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public ThicknessKeyFrameCollection();
+        public int Count { get; }
+        public static ThicknessKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public ThicknessKeyFrame this[int index] { get; set; }
+        public int Add(ThicknessKeyFrame keyFrame);
+        public void Clear();
+        public new ThicknessKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(ThicknessKeyFrame keyFrame);
+        public void CopyTo(ThicknessKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(ThicknessKeyFrame keyFrame);
+        public void Insert(int index, ThicknessKeyFrame keyFrame);
+        public void Remove(ThicknessKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public abstract class Timeline : Animatable {
+        public static readonly DependencyProperty AccelerationRatioProperty;
+        public static readonly DependencyProperty AutoReverseProperty;
+        public static readonly DependencyProperty BeginTimeProperty;
+        public static readonly DependencyProperty DecelerationRatioProperty;
+        public static readonly DependencyProperty DesiredFrameRateProperty;
+        public static readonly DependencyProperty DurationProperty;
+        public static readonly DependencyProperty FillBehaviorProperty;
+        public static readonly DependencyProperty NameProperty;
+        public static readonly DependencyProperty RepeatBehaviorProperty;
+        public static readonly DependencyProperty SpeedRatioProperty;
+        protected Timeline();
+        protected Timeline(Nullable<TimeSpan> beginTime);
+        protected Timeline(Nullable<TimeSpan> beginTime, Duration duration);
+        protected Timeline(Nullable<TimeSpan> beginTime, Duration duration, RepeatBehavior repeatBehavior);
+        public double AccelerationRatio { get; set; }
+        public bool AutoReverse { get; set; }
+        public Nullable<TimeSpan> BeginTime { get; set; }
+        public double DecelerationRatio { get; set; }
+        public Duration Duration { get; set; }
+        public FillBehavior FillBehavior { get; set; }
+        public string Name { get; set; }
+        public RepeatBehavior RepeatBehavior { get; set; }
+        public double SpeedRatio { get; set; }
+        public event EventHandler Completed;
+        public event EventHandler CurrentGlobalSpeedInvalidated;
+        public event EventHandler CurrentStateInvalidated;
+        public event EventHandler CurrentTimeInvalidated;
+        public event EventHandler RemoveRequested;
+        protected internal virtual Clock AllocateClock();
+        public new Timeline Clone();
+        public new Timeline CloneCurrentValue();
+        public Clock CreateClock();
+        public Clock CreateClock(bool hasControllableRoot);
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public static Nullable<int> GetDesiredFrameRate(Timeline timeline);
+        protected internal Duration GetNaturalDuration(Clock clock);
+        protected virtual Duration GetNaturalDurationCore(Clock clock);
+        public static void SetDesiredFrameRate(Timeline timeline, Nullable<int> desiredFrameRate);
+    }
+    public sealed class TimelineCollection : Animatable, ICollection, ICollection<Timeline>, IEnumerable, IEnumerable<Timeline>, IList, IList<Timeline> {
+        public TimelineCollection();
+        public TimelineCollection(IEnumerable<Timeline> collection);
+        public TimelineCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Animation.Timeline>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Timeline this[int index] { get; set; }
+        public void Add(Timeline value);
+        public void Clear();
+        public new TimelineCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new TimelineCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Timeline value);
+        public void CopyTo(Timeline[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public TimelineCollection.Enumerator GetEnumerator();
+        public int IndexOf(Timeline value);
+        public void Insert(int index, Timeline value);
+        public bool Remove(Timeline value);
+        public void RemoveAt(int index);
+        IEnumerator<Timeline> System.Collections.Generic.IEnumerable<System.Windows.Media.Animation.Timeline>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Timeline> {
+            public Timeline Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public abstract class TimelineGroup : Timeline, IAddChild {
+        public static readonly DependencyProperty ChildrenProperty;
+        protected TimelineGroup();
+        protected TimelineGroup(Nullable<TimeSpan> beginTime);
+        protected TimelineGroup(Nullable<TimeSpan> beginTime, Duration duration);
+        protected TimelineGroup(Nullable<TimeSpan> beginTime, Duration duration, RepeatBehavior repeatBehavior);
+        public TimelineCollection Children { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        protected internal override Clock AllocateClock();
+        public new TimelineGroup Clone();
+        public new TimelineGroup CloneCurrentValue();
+        public new ClockGroup CreateClock();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public enum TimeSeekOrigin {
+        BeginTime = 0,
+        Duration = 1,
+    }
+    public class Vector3DAnimation : Vector3DAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public Vector3DAnimation();
+        public Vector3DAnimation(Vector3D toValue, Duration duration);
+        public Vector3DAnimation(Vector3D toValue, Duration duration, FillBehavior fillBehavior);
+        public Vector3DAnimation(Vector3D fromValue, Vector3D toValue, Duration duration);
+        public Vector3DAnimation(Vector3D fromValue, Vector3D toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Vector3D> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Vector3D> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Vector3D> To { get; set; }
+        public new Vector3DAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Vector3D GetCurrentValueCore(Vector3D defaultOriginValue, Vector3D defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class Vector3DAnimationBase : AnimationTimeline {
+        protected Vector3DAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new Vector3DAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Vector3D GetCurrentValue(Vector3D defaultOriginValue, Vector3D defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Vector3D GetCurrentValueCore(Vector3D defaultOriginValue, Vector3D defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class Vector3DAnimationUsingKeyFrames : Vector3DAnimationBase, IAddChild, IKeyFrameAnimation {
+        public Vector3DAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Vector3DKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new Vector3DAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new Vector3DAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Vector3D GetCurrentValueCore(Vector3D defaultOriginValue, Vector3D defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class Vector3DKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected Vector3DKeyFrame();
+        protected Vector3DKeyFrame(Vector3D value);
+        protected Vector3DKeyFrame(Vector3D value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Vector3D Value { get; set; }
+        public Vector3D InterpolateValue(Vector3D baseValue, double keyFrameProgress);
+        protected abstract Vector3D InterpolateValueCore(Vector3D baseValue, double keyFrameProgress);
+    }
+    public class Vector3DKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public Vector3DKeyFrameCollection();
+        public int Count { get; }
+        public static Vector3DKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Vector3DKeyFrame this[int index] { get; set; }
+        public int Add(Vector3DKeyFrame keyFrame);
+        public void Clear();
+        public new Vector3DKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(Vector3DKeyFrame keyFrame);
+        public void CopyTo(Vector3DKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(Vector3DKeyFrame keyFrame);
+        public void Insert(int index, Vector3DKeyFrame keyFrame);
+        public void Remove(Vector3DKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+    public class VectorAnimation : VectorAnimationBase {
+        public static readonly DependencyProperty ByProperty;
+        public static readonly DependencyProperty EasingFunctionProperty;
+        public static readonly DependencyProperty FromProperty;
+        public static readonly DependencyProperty ToProperty;
+        public VectorAnimation();
+        public VectorAnimation(Vector toValue, Duration duration);
+        public VectorAnimation(Vector toValue, Duration duration, FillBehavior fillBehavior);
+        public VectorAnimation(Vector fromValue, Vector toValue, Duration duration);
+        public VectorAnimation(Vector fromValue, Vector toValue, Duration duration, FillBehavior fillBehavior);
+        public Nullable<Vector> By { get; set; }
+        public IEasingFunction EasingFunction { get; set; }
+        public Nullable<Vector> From { get; set; }
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public Nullable<Vector> To { get; set; }
+        public new VectorAnimation Clone();
+        protected override Freezable CreateInstanceCore();
+        protected override Vector GetCurrentValueCore(Vector defaultOriginValue, Vector defaultDestinationValue, AnimationClock animationClock);
+    }
+    public abstract class VectorAnimationBase : AnimationTimeline {
+        protected VectorAnimationBase();
+        public sealed override Type TargetPropertyType { get; }
+        public new VectorAnimationBase Clone();
+        public sealed override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);
+        public Vector GetCurrentValue(Vector defaultOriginValue, Vector defaultDestinationValue, AnimationClock animationClock);
+        protected abstract Vector GetCurrentValueCore(Vector defaultOriginValue, Vector defaultDestinationValue, AnimationClock animationClock);
+    }
+    public class VectorAnimationUsingKeyFrames : VectorAnimationBase, IAddChild, IKeyFrameAnimation {
+        public VectorAnimationUsingKeyFrames();
+        public bool IsAdditive { get; set; }
+        public bool IsCumulative { get; set; }
+        public VectorKeyFrameCollection KeyFrames { get; set; }
+        IList System.Windows.Media.Animation.IKeyFrameAnimation.KeyFrames { get; set; }
+        protected virtual void AddChild(object child);
+        protected virtual void AddText(string childText);
+        public new VectorAnimationUsingKeyFrames Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new VectorAnimationUsingKeyFrames CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected sealed override Vector GetCurrentValueCore(Vector defaultOriginValue, Vector defaultDestinationValue, AnimationClock animationClock);
+        protected sealed override Duration GetNaturalDurationCore(Clock clock);
+        protected override void OnChanged();
+        public bool ShouldSerializeKeyFrames();
+        void System.Windows.Markup.IAddChild.AddChild(object child);
+        void System.Windows.Markup.IAddChild.AddText(string childText);
+    }
+    public abstract class VectorKeyFrame : Freezable, IKeyFrame {
+        public static readonly DependencyProperty KeyTimeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        protected VectorKeyFrame();
+        protected VectorKeyFrame(Vector value);
+        protected VectorKeyFrame(Vector value, KeyTime keyTime);
+        public KeyTime KeyTime { get; set; }
+        object System.Windows.Media.Animation.IKeyFrame.Value { get; set; }
+        public Vector Value { get; set; }
+        public Vector InterpolateValue(Vector baseValue, double keyFrameProgress);
+        protected abstract Vector InterpolateValueCore(Vector baseValue, double keyFrameProgress);
+    }
+    public class VectorKeyFrameCollection : Freezable, ICollection, IEnumerable, IList {
+        public VectorKeyFrameCollection();
+        public int Count { get; }
+        public static VectorKeyFrameCollection Empty { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public VectorKeyFrame this[int index] { get; set; }
+        public int Add(VectorKeyFrame keyFrame);
+        public void Clear();
+        public new VectorKeyFrameCollection Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool Contains(VectorKeyFrame keyFrame);
+        public void CopyTo(VectorKeyFrame[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(VectorKeyFrame keyFrame);
+        public void Insert(int index, VectorKeyFrame keyFrame);
+        public void Remove(VectorKeyFrame keyFrame);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object keyFrame);
+        bool System.Collections.IList.Contains(object keyFrame);
+        int System.Collections.IList.IndexOf(object keyFrame);
+        void System.Collections.IList.Insert(int index, object keyFrame);
+        void System.Collections.IList.Remove(object keyFrame);
+    }
+}
```

