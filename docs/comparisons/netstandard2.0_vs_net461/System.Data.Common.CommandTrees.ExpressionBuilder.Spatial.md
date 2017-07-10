# System.Data.Common.CommandTrees.ExpressionBuilder.Spatial

``` diff
+namespace System.Data.Common.CommandTrees.ExpressionBuilder.Spatial {
+    public static class SpatialEdmFunctions {
+        public static DbFunctionExpression Area(this DbExpression spatialValue);
+        public static DbFunctionExpression AsBinary(this DbExpression spatialValue);
+        public static DbFunctionExpression AsGml(this DbExpression spatialValue);
+        public static DbFunctionExpression AsText(this DbExpression spatialValue);
+        public static DbFunctionExpression Centroid(this DbExpression geometryValue);
+        public static DbFunctionExpression CoordinateSystemId(this DbExpression spatialValue);
+        public static DbFunctionExpression Distance(this DbExpression spatialValue1, DbExpression spatialValue2);
+        public static DbFunctionExpression Elevation(this DbExpression spatialValue);
+        public static DbFunctionExpression EndPoint(this DbExpression spatialValue);
+        public static DbFunctionExpression ExteriorRing(this DbExpression geometryValue);
+        public static DbFunctionExpression GeographyCollectionFromBinary(DbExpression geographyCollectionWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyCollectionFromText(DbExpression geographyCollectionWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyFromBinary(DbExpression wellKnownBinaryValue);
+        public static DbFunctionExpression GeographyFromBinary(DbExpression wellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyFromGml(DbExpression geographyMarkup);
+        public static DbFunctionExpression GeographyFromGml(DbExpression geographyMarkup, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyFromText(DbExpression wellKnownText);
+        public static DbFunctionExpression GeographyFromText(DbExpression wellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyLineFromBinary(DbExpression lineWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyLineFromText(DbExpression lineWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyMultiLineFromBinary(DbExpression multiLineWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyMultiLineFromText(DbExpression multiLineWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyMultiPointFromBinary(DbExpression multiPointWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyMultiPointFromText(DbExpression multiPointWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyMultiPolygonFromBinary(DbExpression multiPolygonWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyMultiPolygonFromText(DbExpression multiPolygonWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyPointFromBinary(DbExpression pointWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyPointFromText(DbExpression pointWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyPolygonFromBinary(DbExpression polygonWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeographyPolygonFromText(DbExpression polygonWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryCollectionFromBinary(DbExpression geometryCollectionWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryCollectionFromText(DbExpression geometryCollectionWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryFromBinary(DbExpression wellKnownBinaryValue);
+        public static DbFunctionExpression GeometryFromBinary(DbExpression wellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryFromGml(DbExpression geometryMarkup);
+        public static DbFunctionExpression GeometryFromGml(DbExpression geometryMarkup, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryFromText(DbExpression wellKnownText);
+        public static DbFunctionExpression GeometryFromText(DbExpression wellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryLineFromBinary(DbExpression lineWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryLineFromText(DbExpression lineWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryMultiLineFromBinary(DbExpression multiLineWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryMultiLineFromText(DbExpression multiLineWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryMultiPointFromBinary(DbExpression multiPointWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryMultiPointFromText(DbExpression multiPointWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryMultiPolygonFromBinary(DbExpression multiPolygonWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryMultiPolygonFromText(DbExpression multiPolygonWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryPointFromBinary(DbExpression pointWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryPointFromText(DbExpression pointWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryPolygonFromBinary(DbExpression polygonWellKnownBinaryValue, DbExpression coordinateSystemId);
+        public static DbFunctionExpression GeometryPolygonFromText(DbExpression polygonWellKnownText, DbExpression coordinateSystemId);
+        public static DbFunctionExpression InteriorRingAt(this DbExpression geometryValue, DbExpression indexValue);
+        public static DbFunctionExpression InteriorRingCount(this DbExpression geometryValue);
+        public static DbFunctionExpression IsClosedSpatial(this DbExpression spatialValue);
+        public static DbFunctionExpression IsEmptySpatial(this DbExpression spatialValue);
+        public static DbFunctionExpression IsRing(this DbExpression geometryValue);
+        public static DbFunctionExpression IsSimpleGeometry(this DbExpression geometryValue);
+        public static DbFunctionExpression IsValidGeometry(this DbExpression geometryValue);
+        public static DbFunctionExpression Latitude(this DbExpression geographyValue);
+        public static DbFunctionExpression Longitude(this DbExpression geographyValue);
+        public static DbFunctionExpression Measure(this DbExpression spatialValue);
+        public static DbFunctionExpression PointAt(this DbExpression spatialValue, DbExpression indexValue);
+        public static DbFunctionExpression PointCount(this DbExpression spatialValue);
+        public static DbFunctionExpression PointOnSurface(this DbExpression geometryValue);
+        public static DbFunctionExpression SpatialBoundary(this DbExpression geometryValue);
+        public static DbFunctionExpression SpatialBuffer(this DbExpression spatialValue, DbExpression distance);
+        public static DbFunctionExpression SpatialContains(this DbExpression geometryValue1, DbExpression geometryValue2);
+        public static DbFunctionExpression SpatialConvexHull(this DbExpression geometryValue);
+        public static DbFunctionExpression SpatialCrosses(this DbExpression geometryValue1, DbExpression geometryValue2);
+        public static DbFunctionExpression SpatialDifference(this DbExpression spatialValue1, DbExpression spatialValue2);
+        public static DbFunctionExpression SpatialDimension(this DbExpression spatialValue);
+        public static DbFunctionExpression SpatialDisjoint(this DbExpression spatialValue1, DbExpression spatialValue2);
+        public static DbFunctionExpression SpatialElementAt(this DbExpression spatialValue, DbExpression indexValue);
+        public static DbFunctionExpression SpatialElementCount(this DbExpression spatialValue);
+        public static DbFunctionExpression SpatialEnvelope(this DbExpression geometryValue);
+        public static DbFunctionExpression SpatialEquals(this DbExpression spatialValue1, DbExpression spatialValue2);
+        public static DbFunctionExpression SpatialIntersection(this DbExpression spatialValue1, DbExpression spatialValue2);
+        public static DbFunctionExpression SpatialIntersects(this DbExpression spatialValue1, DbExpression spatialValue2);
+        public static DbFunctionExpression SpatialLength(this DbExpression spatialValue);
+        public static DbFunctionExpression SpatialOverlaps(this DbExpression geometryValue1, DbExpression geometryValue2);
+        public static DbFunctionExpression SpatialRelate(this DbExpression geometryValue1, DbExpression geometryValue2, DbExpression intersectionPatternMatrix);
+        public static DbFunctionExpression SpatialSymmetricDifference(this DbExpression spatialValue1, DbExpression spatialValue2);
+        public static DbFunctionExpression SpatialTouches(this DbExpression geometryValue1, DbExpression geometryValue2);
+        public static DbFunctionExpression SpatialTypeName(this DbExpression spatialValue);
+        public static DbFunctionExpression SpatialUnion(this DbExpression spatialValue1, DbExpression spatialValue2);
+        public static DbFunctionExpression SpatialWithin(this DbExpression geometryValue1, DbExpression geometryValue2);
+        public static DbFunctionExpression StartPoint(this DbExpression spatialValue);
+        public static DbFunctionExpression XCoordinate(this DbExpression geometryValue);
+        public static DbFunctionExpression YCoordinate(this DbExpression geometryValue);
+    }
+}
```

