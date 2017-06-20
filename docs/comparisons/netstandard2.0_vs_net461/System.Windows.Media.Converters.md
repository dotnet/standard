# System.Windows.Media.Converters

``` diff
+namespace System.Windows.Media.Converters {
+    public abstract class BaseIListConverter : TypeConverter {
+        protected BaseIListConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class BoolIListConverter : BaseIListConverter {
+        public BoolIListConverter();
+    }
+    public class BrushValueSerializer : ValueSerializer {
+        public BrushValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class CacheModeValueSerializer : ValueSerializer {
+        public CacheModeValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public sealed class CharIListConverter : BaseIListConverter {
+        public CharIListConverter();
+    }
+    public class DoubleCollectionValueSerializer : ValueSerializer {
+        public DoubleCollectionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public sealed class DoubleIListConverter : BaseIListConverter {
+        public DoubleIListConverter();
+    }
+    public class GeometryValueSerializer : ValueSerializer {
+        public GeometryValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class Int32CollectionValueSerializer : ValueSerializer {
+        public Int32CollectionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class MatrixValueSerializer : ValueSerializer {
+        public MatrixValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class PathFigureCollectionValueSerializer : ValueSerializer {
+        public PathFigureCollectionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class PointCollectionValueSerializer : ValueSerializer {
+        public PointCollectionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public sealed class PointIListConverter : BaseIListConverter {
+        public PointIListConverter();
+    }
+    public class TransformValueSerializer : ValueSerializer {
+        public TransformValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public sealed class UShortIListConverter : BaseIListConverter {
+        public UShortIListConverter();
+    }
+    public class VectorCollectionValueSerializer : ValueSerializer {
+        public VectorCollectionValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+}
```

