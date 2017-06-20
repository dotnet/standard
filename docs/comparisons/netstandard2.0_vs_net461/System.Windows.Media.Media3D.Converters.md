# System.Windows.Media.Media3D.Converters

``` diff
+namespace System.Windows.Media.Media3D.Converters {
+    public class Matrix3DValueSerializer : ValueSerializer {
+        public Matrix3DValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class Point3DCollectionValueSerializer : ValueSerializer {
+        public Point3DCollectionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class Point3DValueSerializer : ValueSerializer {
+        public Point3DValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class Point4DValueSerializer : ValueSerializer {
+        public Point4DValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class QuaternionValueSerializer : ValueSerializer {
+        public QuaternionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class Rect3DValueSerializer : ValueSerializer {
+        public Rect3DValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class Size3DValueSerializer : ValueSerializer {
+        public Size3DValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class Vector3DCollectionValueSerializer : ValueSerializer {
+        public Vector3DCollectionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class Vector3DValueSerializer : ValueSerializer {
+        public Vector3DValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+}
```

