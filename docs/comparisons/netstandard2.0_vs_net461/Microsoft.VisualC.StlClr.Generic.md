# Microsoft.VisualC.StlClr.Generic

``` diff
+namespace Microsoft.VisualC.StlClr.Generic {
+    public class ConstContainerBidirectionalIterator<TValue> : IBidirectionalIterator<TValue> {
+        public ConstContainerBidirectionalIterator();
+        public ConstContainerBidirectionalIterator(ConstContainerBidirectionalIterator<TValue> _Right);
+        public ConstContainerBidirectionalIterator(ContainerBidirectionalIterator<TValue> _Right);
+        public ConstContainerBidirectionalIterator(INode<TValue> _Node);
+        public virtual object Clone();
+        public virtual object container();
+        public bool equal_to(ConstContainerBidirectionalIterator<TValue> _Right);
+        public virtual bool equal_to(IInputIterator<TValue> _Right);
+        public virtual int get_bias();
+        public virtual ref TValue get_cref();
+        public virtual object get_node();
+        public virtual ref TValue get_ref();
+        public virtual void next();
+        public ConstContainerBidirectionalIterator<TValue> op_Assign(ConstContainerBidirectionalIterator<TValue> _Right);
+        public ConstContainerBidirectionalIterator<TValue> op_Assign(ContainerBidirectionalIterator<TValue> _Right);
+        public void operator --(ref ConstContainerBidirectionalIterator<TValue> );
+        public void operator --(ref ConstContainerBidirectionalIterator<TValue> , int A_0);
+        public bool operator ==(ConstContainerBidirectionalIterator<TValue> _Right);
+        public bool operator ==(IInputIterator<TValue> _Right);
+        public implicit operator IBidirectionalIterator<TValue> ();
+        public void operator ++(ref ConstContainerBidirectionalIterator<TValue> );
+        public void operator ++(ref ConstContainerBidirectionalIterator<TValue> , int A_0);
+        public bool operator !=(ConstContainerBidirectionalIterator<TValue> _Right);
+        public bool operator !=(IInputIterator<TValue> _Right);
+        public static ref TValue op_MemberSelection(ConstContainerBidirectionalIterator<TValue> _Left);
+        public static ref TValue op_PointerDereference(ConstContainerBidirectionalIterator<TValue> _Left);
+        public virtual void prev();
+        public virtual bool valid();
+    }
+    public class ConstContainerRandomAccessIterator<TValue> : IRandomAccessIterator<TValue> {
+        public ConstContainerRandomAccessIterator();
+        public ConstContainerRandomAccessIterator(ConstContainerRandomAccessIterator<TValue> _Right);
+        public ConstContainerRandomAccessIterator(ContainerRandomAccessIterator<TValue> _Right);
+        public ConstContainerRandomAccessIterator(IRandomAccessContainer<TValue> _Cont, int _Offset);
+        public ref TValue this[int _Pos] { get; }
+        public virtual object Clone();
+        public virtual object container();
+        public int distance(ConstContainerRandomAccessIterator<TValue> _Right);
+        public virtual int distance(IRandomAccessIterator<TValue> _Right);
+        public bool equal_to(ConstContainerRandomAccessIterator<TValue> _Right);
+        public virtual bool equal_to(IInputIterator<TValue> _Right);
+        public virtual int get_bias();
+        public virtual ref TValue get_cref();
+        public virtual object get_node();
+        public virtual ref TValue get_ref();
+        public bool less_than(ConstContainerRandomAccessIterator<TValue> _Right);
+        public virtual bool less_than(IRandomAccessIterator<TValue> _Right);
+        public virtual int move(int _Offset);
+        public virtual void next();
+        public void operator +(ref ConstContainerRandomAccessIterator<TValue> , int _Right);
+        public static void operator +(ref ConstContainerRandomAccessIterator<TValue> , int _Left, ConstContainerRandomAccessIterator<TValue> _Right);
+        public ConstContainerRandomAccessIterator<TValue> op_Assign(ConstContainerRandomAccessIterator<TValue> _Right);
+        public ConstContainerRandomAccessIterator<TValue> op_Assign(ContainerRandomAccessIterator<TValue> _Right);
+        public void operator --(ref ConstContainerRandomAccessIterator<TValue> );
+        public void operator --(ref ConstContainerRandomAccessIterator<TValue> , int A_0);
+        public bool operator ==(ConstContainerRandomAccessIterator<TValue> _Right);
+        public bool operator ==(IInputIterator<TValue> _Right);
+        public bool operator >(ConstContainerRandomAccessIterator<TValue> _Right);
+        public static bool operator >(IRandomAccessIterator<TValue> _Left, ConstContainerRandomAccessIterator<TValue> _Right);
+        public bool operator >=(ConstContainerRandomAccessIterator<TValue> _Right);
+        public bool operator >=(IRandomAccessIterator<TValue> _Right);
+        public implicit operator IRandomAccessIterator<TValue> ();
+        public void operator ++(ref ConstContainerRandomAccessIterator<TValue> );
+        public void operator ++(ref ConstContainerRandomAccessIterator<TValue> , int A_0);
+        public bool operator !=(ConstContainerRandomAccessIterator<TValue> _Right);
+        public bool operator !=(IInputIterator<TValue> _Right);
+        public bool operator <(ConstContainerRandomAccessIterator<TValue> _Right);
+        public bool operator <(IRandomAccessIterator<TValue> _Right);
+        public bool operator <=(ConstContainerRandomAccessIterator<TValue> _Right);
+        public static bool operator <=(IRandomAccessIterator<TValue> _Left, ConstContainerRandomAccessIterator<TValue> _Right);
+        public static ref TValue op_MemberSelection(ConstContainerRandomAccessIterator<TValue> _Left);
+        public static ref TValue op_PointerDereference(ConstContainerRandomAccessIterator<TValue> _Left);
+        public void operator -(ref ConstContainerRandomAccessIterator<TValue> , int _Right);
+        public int operator -(IRandomAccessIterator<TValue> _Right);
+        public virtual void prev();
+        public virtual bool valid();
+    }
+    public class ConstReverseBidirectionalIterator<TValue> : IBidirectionalIterator<TValue> {
+        public ConstReverseBidirectionalIterator();
+        public ConstReverseBidirectionalIterator(ConstReverseBidirectionalIterator<TValue> _Right);
+        public ConstReverseBidirectionalIterator(IBidirectionalIterator<TValue> _Iter);
+        public ConstReverseBidirectionalIterator(ReverseBidirectionalIterator<TValue> _Iter);
+        public IBidirectionalIterator<TValue> base();
+        public virtual object Clone();
+        public virtual object container();
+        public bool equal_to(ConstReverseBidirectionalIterator<TValue> _Right);
+        public virtual bool equal_to(IInputIterator<TValue> _Right);
+        public virtual int get_bias();
+        public virtual ref TValue get_cref();
+        public virtual object get_node();
+        public virtual ref TValue get_ref();
+        public virtual void next();
+        public ConstReverseBidirectionalIterator<TValue> op_Assign(ConstReverseBidirectionalIterator<TValue> _Right);
+        public ConstReverseBidirectionalIterator<TValue> op_Assign(ReverseBidirectionalIterator<TValue> _Right);
+        public void operator --(ref ConstReverseBidirectionalIterator<TValue> );
+        public void operator --(ref ConstReverseBidirectionalIterator<TValue> , int A_0);
+        public bool operator ==(ConstReverseBidirectionalIterator<TValue> _Right);
+        public bool operator ==(IInputIterator<TValue> _Right);
+        public implicit operator IBidirectionalIterator<TValue> ();
+        public void operator ++(ref ConstReverseBidirectionalIterator<TValue> );
+        public void operator ++(ref ConstReverseBidirectionalIterator<TValue> , int A_0);
+        public bool operator !=(ConstReverseBidirectionalIterator<TValue> _Right);
+        public bool operator !=(IInputIterator<TValue> _Right);
+        public static ref TValue op_MemberSelection(ConstReverseBidirectionalIterator<TValue> _Left);
+        public static ref TValue op_PointerDereference(ConstReverseBidirectionalIterator<TValue> _Left);
+        public virtual void prev();
+        public virtual bool valid();
+    }
+    public class ConstReverseRandomAccessIterator<TValue> : IRandomAccessIterator<TValue> {
+        public ConstReverseRandomAccessIterator();
+        public ConstReverseRandomAccessIterator(ConstReverseRandomAccessIterator<TValue> _Right);
+        public ConstReverseRandomAccessIterator(IRandomAccessIterator<TValue> _Iter);
+        public ConstReverseRandomAccessIterator(ReverseRandomAccessIterator<TValue> _Iter);
+        public ref TValue this[int _Pos] { get; }
+        public IRandomAccessIterator<TValue> base();
+        public virtual object Clone();
+        public virtual object container();
+        public int distance(ConstReverseRandomAccessIterator<TValue> _Right);
+        public virtual int distance(IRandomAccessIterator<TValue> _Right);
+        public bool equal_to(ConstReverseRandomAccessIterator<TValue> _Right);
+        public virtual bool equal_to(IInputIterator<TValue> _Right);
+        public virtual int get_bias();
+        public virtual ref TValue get_cref();
+        public virtual object get_node();
+        public virtual ref TValue get_ref();
+        public bool less_than(ConstReverseRandomAccessIterator<TValue> _Right);
+        public virtual bool less_than(IRandomAccessIterator<TValue> _Right);
+        public virtual int move(int _Offset);
+        public virtual void next();
+        public void operator +(ref ConstReverseRandomAccessIterator<TValue> , int _Right);
+        public static void operator +(ref ConstReverseRandomAccessIterator<TValue> , int _Left, ConstReverseRandomAccessIterator<TValue> _Right);
+        public ConstReverseRandomAccessIterator<TValue> op_Assign(ConstReverseRandomAccessIterator<TValue> _Right);
+        public ConstReverseRandomAccessIterator<TValue> op_Assign(ReverseRandomAccessIterator<TValue> _Right);
+        public void operator --(ref ConstReverseRandomAccessIterator<TValue> );
+        public void operator --(ref ConstReverseRandomAccessIterator<TValue> , int A_0);
+        public bool operator ==(ConstReverseRandomAccessIterator<TValue> _Right);
+        public bool operator >(ConstReverseRandomAccessIterator<TValue> _Right);
+        public bool operator >=(ConstReverseRandomAccessIterator<TValue> _Right);
+        public implicit operator IRandomAccessIterator<TValue> ();
+        public void operator ++(ref ConstReverseRandomAccessIterator<TValue> );
+        public void operator ++(ref ConstReverseRandomAccessIterator<TValue> , int A_0);
+        public bool operator !=(ConstReverseRandomAccessIterator<TValue> _Right);
+        public bool operator <(ConstReverseRandomAccessIterator<TValue> _Right);
+        public bool operator <=(ConstReverseRandomAccessIterator<TValue> _Right);
+        public static ref TValue op_MemberSelection(ConstReverseRandomAccessIterator<TValue> _Left);
+        public static ref TValue op_PointerDereference(ConstReverseRandomAccessIterator<TValue> _Left);
+        public void operator -(ref ConstReverseRandomAccessIterator<TValue> , int _Right);
+        public int operator -(IRandomAccessIterator<TValue> _Right);
+        public virtual void prev();
+        public virtual bool valid();
+    }
+    public class ContainerBidirectionalIterator<TValue> : IBidirectionalIterator<TValue> {
+        public ContainerBidirectionalIterator();
+        public ContainerBidirectionalIterator(ContainerBidirectionalIterator<TValue> _Right);
+        public ContainerBidirectionalIterator(INode<TValue> _Node);
+        public virtual object Clone();
+        public virtual object container();
+        public bool equal_to(ContainerBidirectionalIterator<TValue> _Right);
+        public virtual bool equal_to(IInputIterator<TValue> _Right);
+        public virtual int get_bias();
+        public virtual ref TValue get_cref();
+        public virtual object get_node();
+        public virtual ref TValue get_ref();
+        public virtual void next();
+        public ContainerBidirectionalIterator<TValue> op_Assign(ContainerBidirectionalIterator<TValue> _Right);
+        public void operator --(ref ContainerBidirectionalIterator<TValue> );
+        public void operator --(ref ContainerBidirectionalIterator<TValue> , int A_0);
+        public bool operator ==(ContainerBidirectionalIterator<TValue> _Right);
+        public bool operator ==(IInputIterator<TValue> _Right);
+        public implicit operator IBidirectionalIterator<TValue> ();
+        public void operator ++(ref ContainerBidirectionalIterator<TValue> );
+        public void operator ++(ref ContainerBidirectionalIterator<TValue> , int A_0);
+        public bool operator !=(ContainerBidirectionalIterator<TValue> _Right);
+        public bool operator !=(IInputIterator<TValue> _Right);
+        public static ref TValue op_MemberSelection(ContainerBidirectionalIterator<TValue> _Left);
+        public static ref TValue op_PointerDereference(ContainerBidirectionalIterator<TValue> _Left);
+        public virtual void prev();
+        public virtual bool valid();
+    }
+    public class ContainerRandomAccessIterator<TValue> : IRandomAccessIterator<TValue> {
+        public ContainerRandomAccessIterator();
+        public ContainerRandomAccessIterator(ContainerRandomAccessIterator<TValue> _Right);
+        public ContainerRandomAccessIterator(IRandomAccessContainer<TValue> _Cont, int _Offset);
+        public TValue this[int _Pos] { get; set; }
+        public virtual object Clone();
+        public virtual object container();
+        public int distance(ContainerRandomAccessIterator<TValue> _Right);
+        public virtual int distance(IRandomAccessIterator<TValue> _Right);
+        public bool equal_to(ContainerRandomAccessIterator<TValue> _Right);
+        public virtual bool equal_to(IInputIterator<TValue> _Right);
+        public virtual int get_bias();
+        public virtual ref TValue get_cref();
+        public virtual object get_node();
+        public virtual ref TValue get_ref();
+        public bool less_than(ContainerRandomAccessIterator<TValue> _Right);
+        public virtual bool less_than(IRandomAccessIterator<TValue> _Right);
+        public virtual int move(int _Offset);
+        public virtual void next();
+        public void operator +(ref ContainerRandomAccessIterator<TValue> , int _Right);
+        public static void operator +(ref ContainerRandomAccessIterator<TValue> , int _Left, ContainerRandomAccessIterator<TValue> _Right);
+        public ContainerRandomAccessIterator<TValue> op_Assign(ContainerRandomAccessIterator<TValue> _Right);
+        public void operator --(ref ContainerRandomAccessIterator<TValue> );
+        public void operator --(ref ContainerRandomAccessIterator<TValue> , int A_0);
+        public bool operator ==(ContainerRandomAccessIterator<TValue> _Right);
+        public bool operator ==(IInputIterator<TValue> _Right);
+        public bool operator >(ContainerRandomAccessIterator<TValue> _Right);
+        public static bool operator >(IRandomAccessIterator<TValue> _Left, ContainerRandomAccessIterator<TValue> _Right);
+        public bool operator >=(ContainerRandomAccessIterator<TValue> _Right);
+        public bool operator >=(IRandomAccessIterator<TValue> _Right);
+        public implicit operator IRandomAccessIterator<TValue> ();
+        public void operator ++(ref ContainerRandomAccessIterator<TValue> );
+        public void operator ++(ref ContainerRandomAccessIterator<TValue> , int A_0);
+        public bool operator !=(ContainerRandomAccessIterator<TValue> _Right);
+        public bool operator !=(IInputIterator<TValue> _Right);
+        public bool operator <(ContainerRandomAccessIterator<TValue> _Right);
+        public bool operator <(IRandomAccessIterator<TValue> _Right);
+        public bool operator <=(ContainerRandomAccessIterator<TValue> _Right);
+        public static bool operator <=(IRandomAccessIterator<TValue> _Left, ContainerRandomAccessIterator<TValue> _Right);
+        public static ref TValue op_MemberSelection(ContainerRandomAccessIterator<TValue> _Left);
+        public static ref TValue op_PointerDereference(ContainerRandomAccessIterator<TValue> _Left);
+        public void operator -(ref ContainerRandomAccessIterator<TValue> , int _Right);
+        public int operator -(IRandomAccessIterator<TValue> _Right);
+        public virtual void prev();
+        public virtual bool valid();
+    }
+    public interface IBaseIterator<TValue> : ICloneable {
+        object container();
+        int get_bias();
+        object get_node();
+        void next();
+        bool valid();
+    }
+    public interface IBidirectionalContainer<TValue> {
+        uint get_generation();
+    }
+    public interface IBidirectionalIterator<TValue> : IForwardIterator<TValue> {
+        void prev();
+    }
+    public interface IForwardIterator<TValue> : IInputIterator<TValue>, IOutputIterator<TValue>
+    public interface IInputIterator<TValue> : IBaseIterator<TValue> {
+        bool equal_to(IInputIterator<TValue> A_0);
+        ref TValue get_cref();
+    }
+    public interface INode<TValue> {
+        ref TValue _Value { get; set; }
+        IBidirectionalContainer<TValue> container();
+        bool is_head();
+        INode<TValue> next_node();
+        INode<TValue> prev_node();
+    }
+    public interface IOutputIterator<TValue> : IBaseIterator<TValue> {
+        ref TValue get_ref();
+    }
+    public interface IRandomAccessContainer<TValue> {
+        ref TValue at_bias(int A_0);
+        bool valid_bias(int A_0);
+    }
+    public interface IRandomAccessIterator<TValue> : IBidirectionalIterator<TValue> {
+        int distance(IRandomAccessIterator<TValue> _Right);
+        bool less_than(IRandomAccessIterator<TValue> _Right);
+        int move(int _Offset);
+    }
+    public class ReverseBidirectionalIterator<TValue> : IBidirectionalIterator<TValue> {
+        public ReverseBidirectionalIterator();
+        public ReverseBidirectionalIterator(IBidirectionalIterator<TValue> _Iter);
+        public ReverseBidirectionalIterator(ReverseBidirectionalIterator<TValue> _Right);
+        public IBidirectionalIterator<TValue> base();
+        public virtual object Clone();
+        public virtual object container();
+        public virtual bool equal_to(IInputIterator<TValue> _Right);
+        public bool equal_to(ReverseBidirectionalIterator<TValue> _Right);
+        public virtual int get_bias();
+        public virtual ref TValue get_cref();
+        public virtual object get_node();
+        public virtual ref TValue get_ref();
+        public virtual void next();
+        public ReverseBidirectionalIterator<TValue> op_Assign(ReverseBidirectionalIterator<TValue> _Right);
+        public void operator --(ref ReverseBidirectionalIterator<TValue> );
+        public void operator --(ref ReverseBidirectionalIterator<TValue> , int A_0);
+        public bool operator ==(IInputIterator<TValue> _Right);
+        public bool operator ==(ReverseBidirectionalIterator<TValue> _Right);
+        public implicit operator IBidirectionalIterator<TValue> ();
+        public void operator ++(ref ReverseBidirectionalIterator<TValue> );
+        public void operator ++(ref ReverseBidirectionalIterator<TValue> , int A_0);
+        public bool operator !=(IInputIterator<TValue> _Right);
+        public bool operator !=(ReverseBidirectionalIterator<TValue> _Right);
+        public static ref TValue op_MemberSelection(ReverseBidirectionalIterator<TValue> _Left);
+        public static ref TValue op_PointerDereference(ReverseBidirectionalIterator<TValue> _Left);
+        public virtual void prev();
+        public virtual bool valid();
+    }
+    public class ReverseRandomAccessIterator<TValue> : IRandomAccessIterator<TValue> {
+        public ReverseRandomAccessIterator();
+        public ReverseRandomAccessIterator(IRandomAccessIterator<TValue> _Iter);
+        public ReverseRandomAccessIterator(ReverseRandomAccessIterator<TValue> _Right);
+        public TValue this[int _Pos] { get; set; }
+        public IRandomAccessIterator<TValue> base();
+        public virtual object Clone();
+        public virtual object container();
+        public virtual int distance(IRandomAccessIterator<TValue> _Right);
+        public int distance(ReverseRandomAccessIterator<TValue> _Right);
+        public virtual bool equal_to(IInputIterator<TValue> _Right);
+        public bool equal_to(ReverseRandomAccessIterator<TValue> _Right);
+        public virtual int get_bias();
+        public virtual ref TValue get_cref();
+        public virtual object get_node();
+        public virtual ref TValue get_ref();
+        public virtual bool less_than(IRandomAccessIterator<TValue> _Right);
+        public bool less_than(ReverseRandomAccessIterator<TValue> _Right);
+        public virtual int move(int _Offset);
+        public virtual void next();
+        public void operator +(ref ReverseRandomAccessIterator<TValue> , int _Right);
+        public static void operator +(ref ReverseRandomAccessIterator<TValue> , int _Left, ReverseRandomAccessIterator<TValue> _Right);
+        public ReverseRandomAccessIterator<TValue> op_Assign(ReverseRandomAccessIterator<TValue> _Right);
+        public void operator --(ref ReverseRandomAccessIterator<TValue> );
+        public void operator --(ref ReverseRandomAccessIterator<TValue> , int A_0);
+        public bool operator ==(ReverseRandomAccessIterator<TValue> _Right);
+        public bool operator >(ReverseRandomAccessIterator<TValue> _Right);
+        public bool operator >=(ReverseRandomAccessIterator<TValue> _Right);
+        public implicit operator IRandomAccessIterator<TValue> ();
+        public void operator ++(ref ReverseRandomAccessIterator<TValue> );
+        public void operator ++(ref ReverseRandomAccessIterator<TValue> , int A_0);
+        public bool operator !=(ReverseRandomAccessIterator<TValue> _Right);
+        public bool operator <(ReverseRandomAccessIterator<TValue> _Right);
+        public bool operator <=(ReverseRandomAccessIterator<TValue> _Right);
+        public static ref TValue op_MemberSelection(ReverseRandomAccessIterator<TValue> _Left);
+        public static ref TValue op_PointerDereference(ReverseRandomAccessIterator<TValue> _Left);
+        public int operator -(IRandomAccessIterator<TValue> _Right);
+        public void operator -(ref ReverseRandomAccessIterator<TValue> , int _Right);
+        public virtual void prev();
+        public virtual bool valid();
+    }
+}
```

