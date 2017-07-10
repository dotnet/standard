# System.Windows.Documents.DocumentStructures

``` diff
+namespace System.Windows.Documents.DocumentStructures {
+    public class BlockElement {
+        public BlockElement();
+    }
+    public class FigureStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<NamedElement> {
+        public FigureStructure();
+        public void Add(NamedElement element);
+        IEnumerator<NamedElement> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.NamedElement>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class ListItemStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<BlockElement> {
+        public ListItemStructure();
+        public string Marker { get; set; }
+        public void Add(BlockElement element);
+        IEnumerator<BlockElement> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.BlockElement>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class ListStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<ListItemStructure> {
+        public ListStructure();
+        public void Add(ListItemStructure listItem);
+        IEnumerator<ListItemStructure> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.ListItemStructure>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class NamedElement : BlockElement {
+        public NamedElement();
+        public string NameReference { get; set; }
+    }
+    public class ParagraphStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<NamedElement> {
+        public ParagraphStructure();
+        public void Add(NamedElement element);
+        IEnumerator<NamedElement> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.NamedElement>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class SectionStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<BlockElement> {
+        public SectionStructure();
+        public void Add(BlockElement element);
+        IEnumerator<BlockElement> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.BlockElement>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class SemanticBasicElement : BlockElement
+    public class StoryBreak : BlockElement {
+        public StoryBreak();
+    }
+    public class StoryFragment : IAddChild, IEnumerable, IEnumerable<BlockElement> {
+        public StoryFragment();
+        public string FragmentName { get; set; }
+        public string FragmentType { get; set; }
+        public string StoryName { get; set; }
+        public void Add(BlockElement element);
+        IEnumerator<BlockElement> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.BlockElement>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class StoryFragments : IAddChild, IEnumerable, IEnumerable<StoryFragment> {
+        public StoryFragments();
+        public void Add(StoryFragment storyFragment);
+        IEnumerator<StoryFragment> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.StoryFragment>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class TableCellStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<BlockElement> {
+        public TableCellStructure();
+        public int ColumnSpan { get; set; }
+        public int RowSpan { get; set; }
+        public void Add(BlockElement element);
+        IEnumerator<BlockElement> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.BlockElement>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class TableRowGroupStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<TableRowStructure> {
+        public TableRowGroupStructure();
+        public void Add(TableRowStructure tableRow);
+        IEnumerator<TableRowStructure> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.TableRowStructure>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class TableRowStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<TableCellStructure> {
+        public TableRowStructure();
+        public void Add(TableCellStructure tableCell);
+        IEnumerator<TableCellStructure> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.TableCellStructure>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class TableStructure : SemanticBasicElement, IAddChild, IEnumerable, IEnumerable<TableRowGroupStructure> {
+        public TableStructure();
+        public void Add(TableRowGroupStructure tableRowGroup);
+        IEnumerator<TableRowGroupStructure> System.Collections.Generic.IEnumerable<System.Windows.Documents.DocumentStructures.TableRowGroupStructure>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+}
```

