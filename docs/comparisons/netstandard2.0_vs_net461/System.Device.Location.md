# System.Device.Location

``` diff
+namespace System.Device.Location {
+    public class CivicAddress {
+        public static readonly CivicAddress Unknown;
+        public CivicAddress();
+        public CivicAddress(string addressLine1, string addressLine2, string building, string city, string countryRegion, string floorLevel, string postalCode, string stateProvince);
+        public string AddressLine1 { get; set; }
+        public string AddressLine2 { get; set; }
+        public string Building { get; set; }
+        public string City { get; set; }
+        public string CountryRegion { get; set; }
+        public string FloorLevel { get; set; }
+        public bool IsUnknown { get; }
+        public string PostalCode { get; set; }
+        public string StateProvince { get; set; }
+    }
+    public sealed class CivicAddressResolver : ICivicAddressResolver {
+        public CivicAddressResolver();
+        public event EventHandler<ResolveAddressCompletedEventArgs> ResolveAddressCompleted;
+        public CivicAddress ResolveAddress(GeoCoordinate coordinate);
+        public void ResolveAddressAsync(GeoCoordinate coordinate);
+    }
+    public class GeoCoordinate : IEquatable<GeoCoordinate> {
+        public static readonly GeoCoordinate Unknown;
+        public GeoCoordinate();
+        public GeoCoordinate(double latitude, double longitude);
+        public GeoCoordinate(double latitude, double longitude, double altitude);
+        public GeoCoordinate(double latitude, double longitude, double altitude, double horizontalAccuracy, double verticalAccuracy, double speed, double course);
+        public double Altitude { get; set; }
+        public double Course { get; set; }
+        public double HorizontalAccuracy { get; set; }
+        public bool IsUnknown { get; }
+        public double Latitude { get; set; }
+        public double Longitude { get; set; }
+        public double Speed { get; set; }
+        public double VerticalAccuracy { get; set; }
+        public bool Equals(GeoCoordinate other);
+        public override bool Equals(object obj);
+        public double GetDistanceTo(GeoCoordinate other);
+        public override int GetHashCode();
+        public static bool operator ==(GeoCoordinate left, GeoCoordinate right);
+        public static bool operator !=(GeoCoordinate left, GeoCoordinate right);
+        public override string ToString();
+    }
+    public class GeoCoordinateWatcher : IDisposable, IGeoPositionWatcher<GeoCoordinate>, INotifyPropertyChanged {
+        public GeoCoordinateWatcher();
+        public GeoCoordinateWatcher(GeoPositionAccuracy desiredAccuracy);
+        public GeoPositionAccuracy DesiredAccuracy { get; private set; }
+        public double MovementThreshold { get; set; }
+        public GeoPositionPermission Permission { get; }
+        public GeoPosition<GeoCoordinate> Position { get; }
+        public GeoPositionStatus Status { get; }
+        public event EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>> PositionChanged;
+        public event EventHandler<GeoPositionStatusChangedEventArgs> StatusChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        event EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>> System.Device.Location.IGeoPositionWatcher<System.Device.Location.GeoCoordinate>.PositionChanged;
+        event EventHandler<GeoPositionStatusChangedEventArgs> System.Device.Location.IGeoPositionWatcher<System.Device.Location.GeoCoordinate>.StatusChanged;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~GeoCoordinateWatcher();
+        protected void OnPositionChanged(GeoPositionChangedEventArgs<GeoCoordinate> e);
+        protected void OnPositionStatusChanged(GeoPositionStatusChangedEventArgs e);
+        protected void OnPropertyChanged(string propertyName);
+        public void Start();
+        public void Start(bool suppressPermissionPrompt);
+        public void Stop();
+        public bool TryStart(bool suppressPermissionPrompt, TimeSpan timeout);
+    }
+    public class GeoPosition<T> {
+        public GeoPosition();
+        public GeoPosition(DateTimeOffset timestamp, T position);
+        public T Location { get; set; }
+        public DateTimeOffset Timestamp { get; set; }
+    }
+    public enum GeoPositionAccuracy {
+        Default = 0,
+        High = 1,
+    }
+    public class GeoPositionChangedEventArgs<T> : EventArgs {
+        public GeoPositionChangedEventArgs(GeoPosition<T> position);
+        public GeoPosition<T> Position { get; private set; }
+    }
+    public enum GeoPositionPermission {
+        Denied = 2,
+        Granted = 1,
+        Unknown = 0,
+    }
+    public enum GeoPositionStatus {
+        Disabled = 3,
+        Initializing = 1,
+        NoData = 2,
+        Ready = 0,
+    }
+    public class GeoPositionStatusChangedEventArgs : EventArgs {
+        public GeoPositionStatusChangedEventArgs(GeoPositionStatus status);
+        public GeoPositionStatus Status { get; private set; }
+    }
+    public interface ICivicAddressResolver {
+        event EventHandler<ResolveAddressCompletedEventArgs> ResolveAddressCompleted;
+        CivicAddress ResolveAddress(GeoCoordinate coordinate);
+        void ResolveAddressAsync(GeoCoordinate coordinate);
+    }
+    public interface IGeoPositionWatcher<T> {
+        GeoPosition<T> Position { get; }
+        GeoPositionStatus Status { get; }
+        event EventHandler<GeoPositionChangedEventArgs<T>> PositionChanged;
+        event EventHandler<GeoPositionStatusChangedEventArgs> StatusChanged;
+        void Start();
+        void Start(bool suppressPermissionPrompt);
+        void Stop();
+        bool TryStart(bool suppressPermissionPrompt, TimeSpan timeout);
+    }
+    public class ResolveAddressCompletedEventArgs : AsyncCompletedEventArgs {
+        public ResolveAddressCompletedEventArgs(CivicAddress address, Exception error, bool cancelled, object userState);
+        public CivicAddress Address { get; private set; }
+    }
+}
```

