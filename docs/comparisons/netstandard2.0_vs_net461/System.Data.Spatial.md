# System.Data.Spatial

``` diff
+namespace System.Data.Spatial {
+    public class DbGeography {
+        public Nullable<double> Area { get; }
+        public int CoordinateSystemId { get; }
+        public static int DefaultCoordinateSystemId { get; }
+        public int Dimension { get; }
+        public Nullable<int> ElementCount { get; }
+        public Nullable<double> Elevation { get; }
+        public DbGeography EndPoint { get; }
+        public Nullable<bool> IsClosed { get; }
+        public bool IsEmpty { get; }
+        public Nullable<double> Latitude { get; }
+        public Nullable<double> Length { get; }
+        public Nullable<double> Longitude { get; }
+        public Nullable<double> Measure { get; }
+        public Nullable<int> PointCount { get; }
+        public object ProviderValue { get; }
+        public string SpatialTypeName { get; }
+        public DbGeography StartPoint { get; }
+        public DbGeographyWellKnownValue WellKnownValue { get; set; }
+        public byte[] AsBinary();
+        public string AsGml();
+        public string AsText();
+        public DbGeography Buffer(Nullable<double> distance);
+        public DbGeography Difference(DbGeography other);
+        public bool Disjoint(DbGeography other);
+        public Nullable<double> Distance(DbGeography other);
+        public DbGeography ElementAt(int index);
+        public static DbGeography FromBinary(byte[] wellKnownBinary);
+        public static DbGeography FromBinary(byte[] wellKnownBinary, int coordinateSystemId);
+        public static DbGeography FromGml(string geographyMarkup);
+        public static DbGeography FromGml(string geographyMarkup, int coordinateSystemId);
+        public static DbGeography FromText(string wellKnownText);
+        public static DbGeography FromText(string wellKnownText, int coordinateSystemId);
+        public static DbGeography GeographyCollectionFromBinary(byte[] geographyCollectionWellKnownBinary, int coordinateSystemId);
+        public static DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId);
+        public DbGeography Intersection(DbGeography other);
+        public bool Intersects(DbGeography other);
+        public static DbGeography LineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId);
+        public static DbGeography LineFromText(string lineWellKnownText, int coordinateSystemId);
+        public static DbGeography MultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId);
+        public static DbGeography MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);
+        public static DbGeography MultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId);
+        public static DbGeography MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);
+        public static DbGeography MultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId);
+        public static DbGeography MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId);
+        public DbGeography PointAt(int index);
+        public static DbGeography PointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId);
+        public static DbGeography PointFromText(string pointWellKnownText, int coordinateSystemId);
+        public static DbGeography PolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId);
+        public static DbGeography PolygonFromText(string polygonWellKnownText, int coordinateSystemId);
+        public bool SpatialEquals(DbGeography other);
+        public DbGeography SymmetricDifference(DbGeography other);
+        public override string ToString();
+        public DbGeography Union(DbGeography other);
+    }
+    public sealed class DbGeographyWellKnownValue {
+        public DbGeographyWellKnownValue();
+        public int CoordinateSystemId { get; set; }
+        public byte[] WellKnownBinary { get; set; }
+        public string WellKnownText { get; set; }
+    }
+    public class DbGeometry {
+        public Nullable<double> Area { get; }
+        public DbGeometry Boundary { get; }
+        public DbGeometry Centroid { get; }
+        public DbGeometry ConvexHull { get; }
+        public int CoordinateSystemId { get; }
+        public static int DefaultCoordinateSystemId { get; }
+        public int Dimension { get; }
+        public Nullable<int> ElementCount { get; }
+        public Nullable<double> Elevation { get; }
+        public DbGeometry EndPoint { get; }
+        public DbGeometry Envelope { get; }
+        public DbGeometry ExteriorRing { get; }
+        public Nullable<int> InteriorRingCount { get; }
+        public Nullable<bool> IsClosed { get; }
+        public bool IsEmpty { get; }
+        public Nullable<bool> IsRing { get; }
+        public bool IsSimple { get; }
+        public bool IsValid { get; }
+        public Nullable<double> Length { get; }
+        public Nullable<double> Measure { get; }
+        public Nullable<int> PointCount { get; }
+        public DbGeometry PointOnSurface { get; }
+        public object ProviderValue { get; }
+        public string SpatialTypeName { get; }
+        public DbGeometry StartPoint { get; }
+        public DbGeometryWellKnownValue WellKnownValue { get; set; }
+        public Nullable<double> XCoordinate { get; }
+        public Nullable<double> YCoordinate { get; }
+        public byte[] AsBinary();
+        public string AsGml();
+        public string AsText();
+        public DbGeometry Buffer(Nullable<double> distance);
+        public bool Contains(DbGeometry other);
+        public bool Crosses(DbGeometry other);
+        public DbGeometry Difference(DbGeometry other);
+        public bool Disjoint(DbGeometry other);
+        public Nullable<double> Distance(DbGeometry other);
+        public DbGeometry ElementAt(int index);
+        public static DbGeometry FromBinary(byte[] wellKnownBinary);
+        public static DbGeometry FromBinary(byte[] wellKnownBinary, int coordinateSystemId);
+        public static DbGeometry FromGml(string geometryMarkup);
+        public static DbGeometry FromGml(string geometryMarkup, int coordinateSystemId);
+        public static DbGeometry FromText(string wellKnownText);
+        public static DbGeometry FromText(string wellKnownText, int coordinateSystemId);
+        public static DbGeometry GeometryCollectionFromBinary(byte[] geometryCollectionWellKnownBinary, int coordinateSystemId);
+        public static DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId);
+        public DbGeometry InteriorRingAt(int index);
+        public DbGeometry Intersection(DbGeometry other);
+        public bool Intersects(DbGeometry other);
+        public static DbGeometry LineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId);
+        public static DbGeometry LineFromText(string lineWellKnownText, int coordinateSystemId);
+        public static DbGeometry MultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId);
+        public static DbGeometry MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);
+        public static DbGeometry MultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId);
+        public static DbGeometry MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);
+        public static DbGeometry MultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId);
+        public static DbGeometry MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId);
+        public bool Overlaps(DbGeometry other);
+        public DbGeometry PointAt(int index);
+        public static DbGeometry PointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId);
+        public static DbGeometry PointFromText(string pointWellKnownText, int coordinateSystemId);
+        public static DbGeometry PolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId);
+        public static DbGeometry PolygonFromText(string polygonWellKnownText, int coordinateSystemId);
+        public bool Relate(DbGeometry other, string matrix);
+        public bool SpatialEquals(DbGeometry other);
+        public DbGeometry SymmetricDifference(DbGeometry other);
+        public override string ToString();
+        public bool Touches(DbGeometry other);
+        public DbGeometry Union(DbGeometry other);
+        public bool Within(DbGeometry other);
+    }
+    public sealed class DbGeometryWellKnownValue {
+        public DbGeometryWellKnownValue();
+        public int CoordinateSystemId { get; set; }
+        public byte[] WellKnownBinary { get; set; }
+        public string WellKnownText { get; set; }
+    }
+    public abstract class DbSpatialDataReader {
+        protected DbSpatialDataReader();
+        public abstract DbGeography GetGeography(int ordinal);
+        public abstract DbGeometry GetGeometry(int ordinal);
+    }
+    public abstract class DbSpatialServices {
+        protected DbSpatialServices();
+        public static DbSpatialServices Default { get; }
+        public abstract byte[] AsBinary(DbGeography geographyValue);
+        public abstract byte[] AsBinary(DbGeometry geometryValue);
+        public abstract string AsGml(DbGeography geographyValue);
+        public abstract string AsGml(DbGeometry geometryValue);
+        public abstract string AsText(DbGeography geographyValue);
+        public abstract string AsText(DbGeometry geometryValue);
+        public virtual string AsTextIncludingElevationAndMeasure(DbGeography geographyValue);
+        public virtual string AsTextIncludingElevationAndMeasure(DbGeometry geometryValue);
+        public abstract DbGeography Buffer(DbGeography geographyValue, double distance);
+        public abstract DbGeometry Buffer(DbGeometry geometryValue, double distance);
+        public abstract bool Contains(DbGeometry geometryValue, DbGeometry otherGeometry);
+        protected static DbGeography CreateGeography(DbSpatialServices spatialServices, object providerValue);
+        protected static DbGeometry CreateGeometry(DbSpatialServices spatialServices, object providerValue);
+        public abstract object CreateProviderValue(DbGeographyWellKnownValue wellKnownValue);
+        public abstract object CreateProviderValue(DbGeometryWellKnownValue wellKnownValue);
+        public abstract DbGeographyWellKnownValue CreateWellKnownValue(DbGeography geographyValue);
+        public abstract DbGeometryWellKnownValue CreateWellKnownValue(DbGeometry geometryValue);
+        public abstract bool Crosses(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract DbGeography Difference(DbGeography geographyValue, DbGeography otherGeography);
+        public abstract DbGeometry Difference(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract bool Disjoint(DbGeography geographyValue, DbGeography otherGeography);
+        public abstract bool Disjoint(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract double Distance(DbGeography geographyValue, DbGeography otherGeography);
+        public abstract double Distance(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract DbGeography ElementAt(DbGeography geographyValue, int index);
+        public abstract DbGeometry ElementAt(DbGeometry geometryValue, int index);
+        public abstract DbGeography GeographyCollectionFromBinary(byte[] geographyCollectionWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId);
+        public abstract DbGeography GeographyFromBinary(byte[] wellKnownBinary);
+        public abstract DbGeography GeographyFromBinary(byte[] wellKnownBinary, int coordinateSystemId);
+        public abstract DbGeography GeographyFromGml(string geographyMarkup);
+        public abstract DbGeography GeographyFromGml(string geographyMarkup, int coordinateSystemId);
+        public abstract DbGeography GeographyFromProviderValue(object providerValue);
+        public abstract DbGeography GeographyFromText(string wellKnownText);
+        public abstract DbGeography GeographyFromText(string wellKnownText, int coordinateSystemId);
+        public abstract DbGeography GeographyLineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeography GeographyLineFromText(string lineWellKnownText, int coordinateSystemId);
+        public abstract DbGeography GeographyMultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeography GeographyMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);
+        public abstract DbGeography GeographyMultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeography GeographyMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);
+        public abstract DbGeography GeographyMultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeography GeographyMultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId);
+        public abstract DbGeography GeographyPointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeography GeographyPointFromText(string pointWellKnownText, int coordinateSystemId);
+        public abstract DbGeography GeographyPolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeography GeographyPolygonFromText(string polygonWellKnownText, int coordinateSystemId);
+        public abstract DbGeometry GeometryCollectionFromBinary(byte[] geometryCollectionWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId);
+        public abstract DbGeometry GeometryFromBinary(byte[] wellKnownBinary);
+        public abstract DbGeometry GeometryFromBinary(byte[] wellKnownBinary, int coordinateSystemId);
+        public abstract DbGeometry GeometryFromGml(string geometryMarkup);
+        public abstract DbGeometry GeometryFromGml(string geometryMarkup, int coordinateSystemId);
+        public abstract DbGeometry GeometryFromProviderValue(object providerValue);
+        public abstract DbGeometry GeometryFromText(string wellKnownText);
+        public abstract DbGeometry GeometryFromText(string wellKnownText, int coordinateSystemId);
+        public abstract DbGeometry GeometryLineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeometry GeometryLineFromText(string lineWellKnownText, int coordinateSystemId);
+        public abstract DbGeometry GeometryMultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeometry GeometryMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);
+        public abstract DbGeometry GeometryMultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeometry GeometryMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);
+        public abstract DbGeometry GeometryMultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeometry GeometryMultiPolygonFromText(string multiPolygonKnownText, int coordinateSystemId);
+        public abstract DbGeometry GeometryPointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeometry GeometryPointFromText(string pointWellKnownText, int coordinateSystemId);
+        public abstract DbGeometry GeometryPolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId);
+        public abstract DbGeometry GeometryPolygonFromText(string polygonWellKnownText, int coordinateSystemId);
+        public abstract Nullable<double> GetArea(DbGeography geographyValue);
+        public abstract Nullable<double> GetArea(DbGeometry geometryValue);
+        public abstract DbGeometry GetBoundary(DbGeometry geometryValue);
+        public abstract DbGeometry GetCentroid(DbGeometry geometryValue);
+        public abstract DbGeometry GetConvexHull(DbGeometry geometryValue);
+        public abstract int GetCoordinateSystemId(DbGeography geographyValue);
+        public abstract int GetCoordinateSystemId(DbGeometry geometryValue);
+        public abstract int GetDimension(DbGeography geographyValue);
+        public abstract int GetDimension(DbGeometry geometryValue);
+        public abstract Nullable<int> GetElementCount(DbGeography geographyValue);
+        public abstract Nullable<int> GetElementCount(DbGeometry geometryValue);
+        public abstract Nullable<double> GetElevation(DbGeography geographyValue);
+        public abstract Nullable<double> GetElevation(DbGeometry geometryValue);
+        public abstract DbGeography GetEndPoint(DbGeography geographyValue);
+        public abstract DbGeometry GetEndPoint(DbGeometry geometryValue);
+        public abstract DbGeometry GetEnvelope(DbGeometry geometryValue);
+        public abstract DbGeometry GetExteriorRing(DbGeometry geometryValue);
+        public abstract Nullable<int> GetInteriorRingCount(DbGeometry geometryValue);
+        public abstract Nullable<bool> GetIsClosed(DbGeography geographyValue);
+        public abstract Nullable<bool> GetIsClosed(DbGeometry geometryValue);
+        public abstract bool GetIsEmpty(DbGeography geographyValue);
+        public abstract bool GetIsEmpty(DbGeometry geometryValue);
+        public abstract Nullable<bool> GetIsRing(DbGeometry geometryValue);
+        public abstract bool GetIsSimple(DbGeometry geometryValue);
+        public abstract bool GetIsValid(DbGeometry geometryValue);
+        public abstract Nullable<double> GetLatitude(DbGeography geographyValue);
+        public abstract Nullable<double> GetLength(DbGeography geographyValue);
+        public abstract Nullable<double> GetLength(DbGeometry geometryValue);
+        public abstract Nullable<double> GetLongitude(DbGeography geographyValue);
+        public abstract Nullable<double> GetMeasure(DbGeography geographyValue);
+        public abstract Nullable<double> GetMeasure(DbGeometry geometryValue);
+        public abstract Nullable<int> GetPointCount(DbGeography geographyValue);
+        public abstract Nullable<int> GetPointCount(DbGeometry geometryValue);
+        public abstract DbGeometry GetPointOnSurface(DbGeometry geometryValue);
+        public abstract string GetSpatialTypeName(DbGeography geographyValue);
+        public abstract string GetSpatialTypeName(DbGeometry geometryValue);
+        public abstract DbGeography GetStartPoint(DbGeography geographyValue);
+        public abstract DbGeometry GetStartPoint(DbGeometry geometryValue);
+        public abstract Nullable<double> GetXCoordinate(DbGeometry geometryValue);
+        public abstract Nullable<double> GetYCoordinate(DbGeometry geometryValue);
+        public abstract DbGeometry InteriorRingAt(DbGeometry geometryValue, int index);
+        public abstract DbGeography Intersection(DbGeography geographyValue, DbGeography otherGeography);
+        public abstract DbGeometry Intersection(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract bool Intersects(DbGeography geographyValue, DbGeography otherGeography);
+        public abstract bool Intersects(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract bool Overlaps(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract DbGeography PointAt(DbGeography geographyValue, int index);
+        public abstract DbGeometry PointAt(DbGeometry geometryValue, int index);
+        public abstract bool Relate(DbGeometry geometryValue, DbGeometry otherGeometry, string matrix);
+        public abstract bool SpatialEquals(DbGeography geographyValue, DbGeography otherGeography);
+        public abstract bool SpatialEquals(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract DbGeography SymmetricDifference(DbGeography geographyValue, DbGeography otherGeography);
+        public abstract DbGeometry SymmetricDifference(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract bool Touches(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract DbGeography Union(DbGeography geographyValue, DbGeography otherGeography);
+        public abstract DbGeometry Union(DbGeometry geometryValue, DbGeometry otherGeometry);
+        public abstract bool Within(DbGeometry geometryValue, DbGeometry otherGeometry);
+    }
+}
```

