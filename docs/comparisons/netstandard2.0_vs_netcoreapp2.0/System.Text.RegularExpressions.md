# System.Text.RegularExpressions

``` diff
 namespace System.Text.RegularExpressions {
-    public class CaptureCollection : ICollection, IEnumerable {
+    public class CaptureCollection : ICollection, ICollection<Capture>, IEnumerable, IEnumerable<Capture>, IList, IList<Capture>, IReadOnlyCollection<Capture>, IReadOnlyList<Capture> {
+        Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.this[int index] { get; set; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public void CopyTo(Capture[] array, int arrayIndex);
+        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item);
+        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear();
+        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item);
+        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item);
+        IEnumerator<Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator();
+        int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item);
+        void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item);
+        void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index);
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
     }
     public class Group : Capture {
+        public string Name { get; }
     }
-    public class GroupCollection : ICollection, IEnumerable {
+    public class GroupCollection : ICollection, ICollection<Group>, IEnumerable, IEnumerable<Group>, IList, IList<Group>, IReadOnlyCollection<Group>, IReadOnlyList<Group> {
+        Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.this[int index] { get; set; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public void CopyTo(Group[] array, int arrayIndex);
+        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item);
+        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear();
+        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item);
+        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item);
+        IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator();
+        int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item);
+        void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item);
+        void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index);
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
     }
-    public class MatchCollection : ICollection, IEnumerable {
+    public class MatchCollection : ICollection, ICollection<Match>, IEnumerable, IEnumerable<Match>, IList, IList<Match>, IReadOnlyCollection<Match>, IReadOnlyList<Match> {
+        Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.this[int index] { get; set; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public void CopyTo(Match[] array, int arrayIndex);
+        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item);
+        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear();
+        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item);
+        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item);
+        IEnumerator<Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator();
+        int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item);
+        void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item);
+        void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index);
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
     }
 }
```

