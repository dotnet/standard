# System.Drawing.Design

``` diff
+namespace System.Drawing.Design {
+    public class BitmapEditor : ImageEditor {
+        public BitmapEditor();
+        protected override string[] GetExtensions();
+        protected override string GetFileDialogDescription();
+        protected override Image LoadFromStream(Stream stream);
+    }
+    public sealed class CategoryNameCollection : ReadOnlyCollectionBase {
+        public CategoryNameCollection(CategoryNameCollection value);
+        public CategoryNameCollection(string[] value);
+        public string this[int index] { get; }
+        public bool Contains(string value);
+        public void CopyTo(string[] array, int index);
+        public int IndexOf(string value);
+    }
+    public class ColorEditor : UITypeEditor {
+        public ColorEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        public override bool GetPaintValueSupported(ITypeDescriptorContext context);
+        public override void PaintValue(PaintValueEventArgs e);
+    }
+    public class ContentAlignmentEditor : UITypeEditor {
+        public ContentAlignmentEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class CursorEditor : UITypeEditor {
+        public CursorEditor();
+        public override bool IsDropDownResizable { get; }
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class FontEditor : UITypeEditor {
+        public FontEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class FontNameEditor : UITypeEditor {
+        public FontNameEditor();
+        public override bool GetPaintValueSupported(ITypeDescriptorContext context);
+        public override void PaintValue(PaintValueEventArgs e);
+    }
+    public class IconEditor : UITypeEditor {
+        public IconEditor();
+        protected static string CreateExtensionsString(string[] extensions, string sep);
+        protected static string CreateFilterEntry(IconEditor e);
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        protected virtual string[] GetExtensions();
+        protected virtual string GetFileDialogDescription();
+        public override bool GetPaintValueSupported(ITypeDescriptorContext context);
+        protected virtual Icon LoadFromStream(Stream stream);
+        public override void PaintValue(PaintValueEventArgs e);
+    }
+    public class ImageEditor : UITypeEditor {
+        public ImageEditor();
+        protected static string CreateExtensionsString(string[] extensions, string sep);
+        protected static string CreateFilterEntry(ImageEditor e);
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        protected virtual string[] GetExtensions();
+        protected virtual string GetFileDialogDescription();
+        protected virtual Type[] GetImageExtenders();
+        public override bool GetPaintValueSupported(ITypeDescriptorContext context);
+        protected virtual Image LoadFromStream(Stream stream);
+        public override void PaintValue(PaintValueEventArgs e);
+    }
+    public interface IPropertyValueUIService {
+        event EventHandler PropertyUIValueItemsChanged;
+        void AddPropertyValueUIHandler(PropertyValueUIHandler newHandler);
+        PropertyValueUIItem[] GetPropertyUIValueItems(ITypeDescriptorContext context, PropertyDescriptor propDesc);
+        void NotifyPropertyValueUIItemsChanged();
+        void RemovePropertyValueUIHandler(PropertyValueUIHandler newHandler);
+    }
+    public interface IToolboxItemProvider {
+        ToolboxItemCollection Items { get; }
+    }
+    public interface IToolboxService {
+        CategoryNameCollection CategoryNames { get; }
+        string SelectedCategory { get; set; }
+        void AddCreator(ToolboxItemCreatorCallback creator, string format);
+        void AddCreator(ToolboxItemCreatorCallback creator, string format, IDesignerHost host);
+        void AddLinkedToolboxItem(ToolboxItem toolboxItem, IDesignerHost host);
+        void AddLinkedToolboxItem(ToolboxItem toolboxItem, string category, IDesignerHost host);
+        void AddToolboxItem(ToolboxItem toolboxItem);
+        void AddToolboxItem(ToolboxItem toolboxItem, string category);
+        ToolboxItem DeserializeToolboxItem(object serializedObject);
+        ToolboxItem DeserializeToolboxItem(object serializedObject, IDesignerHost host);
+        ToolboxItem GetSelectedToolboxItem();
+        ToolboxItem GetSelectedToolboxItem(IDesignerHost host);
+        ToolboxItemCollection GetToolboxItems();
+        ToolboxItemCollection GetToolboxItems(IDesignerHost host);
+        ToolboxItemCollection GetToolboxItems(string category);
+        ToolboxItemCollection GetToolboxItems(string category, IDesignerHost host);
+        bool IsSupported(object serializedObject, ICollection filterAttributes);
+        bool IsSupported(object serializedObject, IDesignerHost host);
+        bool IsToolboxItem(object serializedObject);
+        bool IsToolboxItem(object serializedObject, IDesignerHost host);
+        void Refresh();
+        void RemoveCreator(string format);
+        void RemoveCreator(string format, IDesignerHost host);
+        void RemoveToolboxItem(ToolboxItem toolboxItem);
+        void RemoveToolboxItem(ToolboxItem toolboxItem, string category);
+        void SelectedToolboxItemUsed();
+        object SerializeToolboxItem(ToolboxItem toolboxItem);
+        bool SetCursor();
+        void SetSelectedToolboxItem(ToolboxItem toolboxItem);
+    }
+    public interface IToolboxUser {
+        bool GetToolSupported(ToolboxItem tool);
+        void ToolPicked(ToolboxItem tool);
+    }
+    public class MetafileEditor : ImageEditor {
+        public MetafileEditor();
+        protected override string[] GetExtensions();
+        protected override string GetFileDialogDescription();
+        protected override Image LoadFromStream(Stream stream);
+    }
+    public class PaintValueEventArgs : EventArgs {
+        public PaintValueEventArgs(ITypeDescriptorContext context, object value, Graphics graphics, Rectangle bounds);
+        public Rectangle Bounds { get; }
+        public ITypeDescriptorContext Context { get; }
+        public Graphics Graphics { get; }
+        public object Value { get; }
+    }
+    public delegate void PropertyValueUIHandler(ITypeDescriptorContext context, PropertyDescriptor propDesc, ArrayList valueUIItemList);
+    public class PropertyValueUIItem {
+        public PropertyValueUIItem(Image uiItemImage, PropertyValueUIItemInvokeHandler handler, string tooltip);
+        public virtual Image Image { get; }
+        public virtual PropertyValueUIItemInvokeHandler InvokeHandler { get; }
+        public virtual string ToolTip { get; }
+        public virtual void Reset();
+    }
+    public delegate void PropertyValueUIItemInvokeHandler(ITypeDescriptorContext context, PropertyDescriptor descriptor, PropertyValueUIItem invokedItem);
+    public class ToolboxComponentsCreatedEventArgs : EventArgs {
+        public ToolboxComponentsCreatedEventArgs(IComponent[] components);
+        public IComponent[] Components { get; }
+    }
+    public delegate void ToolboxComponentsCreatedEventHandler(object sender, ToolboxComponentsCreatedEventArgs e);
+    public class ToolboxComponentsCreatingEventArgs : EventArgs {
+        public ToolboxComponentsCreatingEventArgs(IDesignerHost host);
+        public IDesignerHost DesignerHost { get; }
+    }
+    public delegate void ToolboxComponentsCreatingEventHandler(object sender, ToolboxComponentsCreatingEventArgs e);
+    public class ToolboxItem : ISerializable {
+        public ToolboxItem();
+        public ToolboxItem(Type toolType);
+        public AssemblyName AssemblyName { get; set; }
+        public Bitmap Bitmap { get; set; }
+        public string Company { get; set; }
+        public virtual string ComponentType { get; }
+        public AssemblyName[] DependentAssemblies { get; set; }
+        public string Description { get; set; }
+        public string DisplayName { get; set; }
+        public ICollection Filter { get; set; }
+        public bool IsTransient { get; set; }
+        public virtual bool Locked { get; }
+        public Bitmap OriginalBitmap { get; set; }
+        public IDictionary Properties { get; }
+        public string TypeName { get; set; }
+        public virtual string Version { get; }
+        public event ToolboxComponentsCreatedEventHandler ComponentsCreated;
+        public event ToolboxComponentsCreatingEventHandler ComponentsCreating;
+        protected void CheckUnlocked();
+        public IComponent[] CreateComponents();
+        public IComponent[] CreateComponents(IDesignerHost host);
+        public IComponent[] CreateComponents(IDesignerHost host, IDictionary defaultValues);
+        protected virtual IComponent[] CreateComponentsCore(IDesignerHost host);
+        protected virtual IComponent[] CreateComponentsCore(IDesignerHost host, IDictionary defaultValues);
+        protected virtual void Deserialize(SerializationInfo info, StreamingContext context);
+        public override bool Equals(object obj);
+        protected virtual object FilterPropertyValue(string propertyName, object value);
+        public override int GetHashCode();
+        public Type GetType(IDesignerHost host);
+        protected virtual Type GetType(IDesignerHost host, AssemblyName assemblyName, string typeName, bool reference);
+        public virtual void Initialize(Type type);
+        public virtual void Lock();
+        protected virtual void OnComponentsCreated(ToolboxComponentsCreatedEventArgs args);
+        protected virtual void OnComponentsCreating(ToolboxComponentsCreatingEventArgs args);
+        protected virtual void Serialize(SerializationInfo info, StreamingContext context);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+        protected void ValidatePropertyType(string propertyName, object value, Type expectedType, bool allowNull);
+        protected virtual object ValidatePropertyValue(string propertyName, object value);
+    }
+    public sealed class ToolboxItemCollection : ReadOnlyCollectionBase {
+        public ToolboxItemCollection(ToolboxItemCollection value);
+        public ToolboxItemCollection(ToolboxItem[] value);
+        public ToolboxItem this[int index] { get; }
+        public bool Contains(ToolboxItem value);
+        public void CopyTo(ToolboxItem[] array, int index);
+        public int IndexOf(ToolboxItem value);
+    }
+    public class ToolboxItemContainer : ISerializable {
+        public ToolboxItemContainer(ToolboxItem item);
+        protected ToolboxItemContainer(SerializationInfo info, StreamingContext context);
+        public ToolboxItemContainer(IDataObject data);
+        public bool IsCreated { get; }
+        public bool IsTransient { get; }
+        public virtual IDataObject ToolboxData { get; }
+        public override bool Equals(object obj);
+        public virtual ICollection GetFilter(ICollection creators);
+        public override int GetHashCode();
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        public virtual ToolboxItem GetToolboxItem(ICollection creators);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public void UpdateFilter(ToolboxItem item);
+    }
+    public sealed class ToolboxItemCreator {
+        public string Format { get; }
+        public ToolboxItem Create(IDataObject data);
+    }
+    public delegate ToolboxItem ToolboxItemCreatorCallback(object serializedObject, string format);
+    public abstract class ToolboxService : IComponentDiscoveryService, IToolboxService {
+        protected ToolboxService();
+        protected abstract CategoryNameCollection CategoryNames { get; }
+        protected abstract string SelectedCategory { get; set; }
+        protected abstract ToolboxItemContainer SelectedItemContainer { get; set; }
+        CategoryNameCollection System.Drawing.Design.IToolboxService.CategoryNames { get; }
+        string System.Drawing.Design.IToolboxService.SelectedCategory { get; set; }
+        protected virtual ToolboxItemContainer CreateItemContainer(ToolboxItem item, IDesignerHost link);
+        protected virtual ToolboxItemContainer CreateItemContainer(IDataObject dataObject);
+        protected virtual void FilterChanged();
+        protected abstract IList GetItemContainers();
+        protected abstract IList GetItemContainers(string categoryName);
+        public static ToolboxItem GetToolboxItem(Type toolType);
+        public static ToolboxItem GetToolboxItem(Type toolType, bool nonPublic);
+        public static ICollection GetToolboxItems(Assembly a, string newCodeBase);
+        public static ICollection GetToolboxItems(Assembly a, string newCodeBase, bool throwOnError);
+        public static ICollection GetToolboxItems(AssemblyName an);
+        public static ICollection GetToolboxItems(AssemblyName an, bool throwOnError);
+        protected virtual bool IsItemContainer(IDataObject dataObject, IDesignerHost host);
+        protected bool IsItemContainerSupported(ToolboxItemContainer container, IDesignerHost host);
+        protected abstract void Refresh();
+        protected virtual void SelectedItemContainerUsed();
+        protected virtual bool SetCursor();
+        ICollection System.ComponentModel.Design.IComponentDiscoveryService.GetComponentTypes(IDesignerHost designerHost, Type baseType);
+        void System.Drawing.Design.IToolboxService.AddCreator(ToolboxItemCreatorCallback creator, string format);
+        void System.Drawing.Design.IToolboxService.AddCreator(ToolboxItemCreatorCallback creator, string format, IDesignerHost host);
+        void System.Drawing.Design.IToolboxService.AddLinkedToolboxItem(ToolboxItem toolboxItem, IDesignerHost host);
+        void System.Drawing.Design.IToolboxService.AddLinkedToolboxItem(ToolboxItem toolboxItem, string category, IDesignerHost host);
+        void System.Drawing.Design.IToolboxService.AddToolboxItem(ToolboxItem toolboxItem);
+        void System.Drawing.Design.IToolboxService.AddToolboxItem(ToolboxItem toolboxItem, string category);
+        ToolboxItem System.Drawing.Design.IToolboxService.DeserializeToolboxItem(object serializedObject);
+        ToolboxItem System.Drawing.Design.IToolboxService.DeserializeToolboxItem(object serializedObject, IDesignerHost host);
+        ToolboxItem System.Drawing.Design.IToolboxService.GetSelectedToolboxItem();
+        ToolboxItem System.Drawing.Design.IToolboxService.GetSelectedToolboxItem(IDesignerHost host);
+        ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems();
+        ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(IDesignerHost host);
+        ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(string category);
+        ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(string category, IDesignerHost host);
+        bool System.Drawing.Design.IToolboxService.IsSupported(object serializedObject, ICollection filterAttributes);
+        bool System.Drawing.Design.IToolboxService.IsSupported(object serializedObject, IDesignerHost host);
+        bool System.Drawing.Design.IToolboxService.IsToolboxItem(object serializedObject);
+        bool System.Drawing.Design.IToolboxService.IsToolboxItem(object serializedObject, IDesignerHost host);
+        void System.Drawing.Design.IToolboxService.Refresh();
+        void System.Drawing.Design.IToolboxService.RemoveCreator(string format);
+        void System.Drawing.Design.IToolboxService.RemoveCreator(string format, IDesignerHost host);
+        void System.Drawing.Design.IToolboxService.RemoveToolboxItem(ToolboxItem toolboxItem);
+        void System.Drawing.Design.IToolboxService.RemoveToolboxItem(ToolboxItem toolboxItem, string category);
+        void System.Drawing.Design.IToolboxService.SelectedToolboxItemUsed();
+        object System.Drawing.Design.IToolboxService.SerializeToolboxItem(ToolboxItem toolboxItem);
+        bool System.Drawing.Design.IToolboxService.SetCursor();
+        void System.Drawing.Design.IToolboxService.SetSelectedToolboxItem(ToolboxItem toolboxItem);
+        public static void UnloadToolboxItems();
+    }
+    public class UITypeEditor {
+        public UITypeEditor();
+        public virtual bool IsDropDownResizable { get; }
+        public virtual object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public object EditValue(IServiceProvider provider, object value);
+        public UITypeEditorEditStyle GetEditStyle();
+        public virtual UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        public bool GetPaintValueSupported();
+        public virtual bool GetPaintValueSupported(ITypeDescriptorContext context);
+        public virtual void PaintValue(PaintValueEventArgs e);
+        public void PaintValue(object value, Graphics canvas, Rectangle rectangle);
+    }
+    public enum UITypeEditorEditStyle {
+        DropDown = 3,
+        Modal = 2,
+        None = 1,
+    }
+}
```

