# System.Json

``` diff
+namespace System.Json {
+    public class JsonArray : JsonValue, ICollection<JsonValue>, IEnumerable, IEnumerable<JsonValue>, IList<JsonValue> {
+        public JsonArray(IEnumerable<JsonValue> items);
+        public JsonArray(params JsonValue[] items);
+        public override int Count { get; }
+        public bool IsReadOnly { get; }
+        public override JsonType JsonType { get; }
+        public sealed override JsonValue this[int index] { get; set; }
+        public void Add(JsonValue item);
+        public void AddRange(IEnumerable<JsonValue> items);
+        public void AddRange(params JsonValue[] items);
+        public void Clear();
+        public bool Contains(JsonValue item);
+        public void CopyTo(JsonValue[] array, int arrayIndex);
+        public int IndexOf(JsonValue item);
+        public void Insert(int index, JsonValue item);
+        public bool Remove(JsonValue item);
+        public void RemoveAt(int index);
+        public override void Save(Stream stream);
+        IEnumerator<JsonValue> System.Collections.Generic.IEnumerable<System.Json.JsonValue>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class JsonObject : JsonValue, ICollection<KeyValuePair<string, JsonValue>>, IDictionary<string, JsonValue>, IEnumerable, IEnumerable<KeyValuePair<string, JsonValue>> {
+        public JsonObject(IEnumerable<KeyValuePair<string, JsonValue>> items);
+        public JsonObject(params KeyValuePair<string, JsonValue>[] items);
+        public override int Count { get; }
+        public override JsonType JsonType { get; }
+        public ICollection<string> Keys { get; }
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.IsReadOnly { get; }
+        public sealed override JsonValue this[string key] { get; set; }
+        public ICollection<JsonValue> Values { get; }
+        public void Add(KeyValuePair<string, JsonValue> pair);
+        public void Add(string key, JsonValue value);
+        public void AddRange(IEnumerable<KeyValuePair<string, JsonValue>> items);
+        public void AddRange(params KeyValuePair<string, JsonValue>[] items);
+        public void Clear();
+        public override bool ContainsKey(string key);
+        public void CopyTo(KeyValuePair<string, JsonValue>[] array, int arrayIndex);
+        public IEnumerator<KeyValuePair<string, JsonValue>> GetEnumerator();
+        public bool Remove(string key);
+        public override void Save(Stream stream);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.Contains(KeyValuePair<string, JsonValue> item);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.Remove(KeyValuePair<string, JsonValue> item);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(string key, out JsonValue value);
+    }
+    public class JsonPrimitive : JsonValue {
+        public JsonPrimitive(bool value);
+        public JsonPrimitive(byte value);
+        public JsonPrimitive(char value);
+        public JsonPrimitive(DateTime value);
+        public JsonPrimitive(DateTimeOffset value);
+        public JsonPrimitive(Decimal value);
+        public JsonPrimitive(double value);
+        public JsonPrimitive(Guid value);
+        public JsonPrimitive(short value);
+        public JsonPrimitive(int value);
+        public JsonPrimitive(long value);
+        public JsonPrimitive(sbyte value);
+        public JsonPrimitive(float value);
+        public JsonPrimitive(string value);
+        public JsonPrimitive(TimeSpan value);
+        public JsonPrimitive(ushort value);
+        public JsonPrimitive(uint value);
+        public JsonPrimitive(ulong value);
+        public JsonPrimitive(Uri value);
+        public override JsonType JsonType { get; }
+        public override void Save(Stream stream);
+    }
+    public enum JsonType {
+        Array = 3,
+        Boolean = 4,
+        Number = 1,
+        Object = 2,
+        String = 0,
+    }
+    public abstract class JsonValue : IEnumerable {
+        protected JsonValue();
+        public virtual int Count { get; }
+        public abstract JsonType JsonType { get; }
+        public virtual JsonValue this[int index] { get; set; }
+        public virtual JsonValue this[string key] { get; set; }
+        public virtual bool ContainsKey(string key);
+        public static JsonValue Load(Stream stream);
+        public static JsonValue Load(TextReader textReader);
+        public static implicit operator JsonValue (bool value);
+        public static implicit operator JsonValue (byte value);
+        public static implicit operator JsonValue (char value);
+        public static implicit operator JsonValue (DateTime value);
+        public static implicit operator JsonValue (DateTimeOffset value);
+        public static implicit operator JsonValue (Decimal value);
+        public static implicit operator JsonValue (double value);
+        public static implicit operator JsonValue (Guid value);
+        public static implicit operator JsonValue (short value);
+        public static implicit operator JsonValue (int value);
+        public static implicit operator JsonValue (long value);
+        public static implicit operator bool (JsonValue value);
+        public static implicit operator byte (JsonValue value);
+        public static implicit operator char (JsonValue value);
+        public static implicit operator Decimal (JsonValue value);
+        public static implicit operator double (JsonValue value);
+        public static implicit operator float (JsonValue value);
+        public static implicit operator int (JsonValue value);
+        public static implicit operator long (JsonValue value);
+        public static implicit operator sbyte (JsonValue value);
+        public static implicit operator short (JsonValue value);
+        public static implicit operator string (JsonValue value);
+        public static implicit operator uint (JsonValue value);
+        public static implicit operator ulong (JsonValue value);
+        public static implicit operator ushort (JsonValue value);
+        public static implicit operator DateTime (JsonValue value);
+        public static implicit operator DateTimeOffset (JsonValue value);
+        public static implicit operator TimeSpan (JsonValue value);
+        public static implicit operator Guid (JsonValue value);
+        public static implicit operator Uri (JsonValue value);
+        public static implicit operator JsonValue (sbyte value);
+        public static implicit operator JsonValue (float value);
+        public static implicit operator JsonValue (string value);
+        public static implicit operator JsonValue (TimeSpan value);
+        public static implicit operator JsonValue (ushort value);
+        public static implicit operator JsonValue (uint value);
+        public static implicit operator JsonValue (ulong value);
+        public static implicit operator JsonValue (Uri value);
+        public static JsonValue Parse(string jsonString);
+        public virtual void Save(Stream stream);
+        public virtual void Save(TextWriter textWriter);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public override string ToString();
+    }
+}
```

