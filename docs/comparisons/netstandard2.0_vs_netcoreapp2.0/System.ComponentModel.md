# System.ComponentModel

``` diff
 namespace System.ComponentModel {
     public sealed class AsyncOperation {
+        ~AsyncOperation();
     }
     public abstract class BaseNumberConverter : TypeConverter {
-        public override bool CanConvertTo(ITypeDescriptorContext context, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
     }
     public class DefaultValueAttribute : Attribute {
+        public DefaultValueAttribute(sbyte value);
+        public DefaultValueAttribute(ushort value);
+        public DefaultValueAttribute(uint value);
+        public DefaultValueAttribute(ulong value);
     }
 }
```

