# Microsoft.VisualC.StlClr

``` diff
+namespace Microsoft.VisualC.StlClr {
+    public delegate TResult BinaryDelegate<TArg1, TArg2, TResult>(TArg1 A_0, TArg2 A_1);
+    public class DequeEnumerator<TValue> : DequeEnumeratorBase<TValue>, IEnumerator<TValue> {
+        public DequeEnumerator(IDeque<TValue> _Cont, int _First);
+        public virtual new TValue Current { get; set; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        public override bool MoveNext();
+        public override void Reset();
+    }
+    public class DequeEnumeratorBase<TValue> : IEnumerator {
+        public DequeEnumeratorBase(IDeque<TValue> _Cont, int _First);
+        public virtual object Current { get; set; }
+        public virtual bool MoveNext();
+        public virtual void Reset();
+    }
+    public class GenericPair<TValue1, TValue2> {
+        public TValue1 first;
+        public TValue2 second;
+        public GenericPair();
+        public GenericPair(GenericPair<TValue1, TValue2> _Right);
+        public GenericPair(ref KeyValuePair<TValue1, TValue2> _Right);
+        public GenericPair(TValue1 _Val1);
+        public GenericPair(TValue1 _Val1, TValue2 _Val2);
+        public override bool Equals(object _Right_arg);
+        public GenericPair<TValue1, TValue2> op_Assign(GenericPair<TValue1, TValue2> _Right);
+        public void swap(GenericPair<TValue1, TValue2> _Right);
+    }
+    public class HashEnumerator<TKey, TValue> : HashEnumeratorBase<TKey, TValue>, IEnumerator<TValue> {
+        public HashEnumerator(INode<TValue> _First);
+        public virtual new TValue Current { get; set; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        public override bool MoveNext();
+        public override void Reset();
+    }
+    public class HashEnumeratorBase<TKey, TValue> : IEnumerator {
+        public HashEnumeratorBase(INode<TValue> _First);
+        public virtual object Current { get; set; }
+        public virtual bool MoveNext();
+        public virtual void Reset();
+    }
+    public interface IDeque<TValue> : ICloneable, ICollection, IEnumerable, IRandomAccessContainer<TValue> {
+        TValue back_item { get; set; }
+        TValue front_item { get; set; }
+        TValue this[int _Pos] { get; set; }
+        void assign(IInputIterator<TValue> _First, IInputIterator<TValue> _Last);
+        void assign(IEnumerable _Right);
+        void assign(int _Count, TValue _Val);
+        ref TValue at(int _Pos);
+        ref TValue back();
+        void begin(ref ContainerRandomAccessIterator<TValue> );
+        int begin_bias();
+        void clear();
+        bool empty();
+        void end(ref ContainerRandomAccessIterator<TValue> );
+        int end_bias();
+        void erase(ref ContainerRandomAccessIterator<TValue> , ContainerRandomAccessIterator<TValue> _Where);
+        void erase(ref ContainerRandomAccessIterator<TValue> , ContainerRandomAccessIterator<TValue> _First_iter, ContainerRandomAccessIterator<TValue> _Last_iter);
+        ref TValue front();
+        uint get_generation();
+        void insert(ref ContainerRandomAccessIterator<TValue> , ContainerRandomAccessIterator<TValue> _Where, TValue _Val);
+        void insert(ContainerRandomAccessIterator<TValue> _Where, IInputIterator<TValue> _First, IInputIterator<TValue> _Last);
+        void insert(ContainerRandomAccessIterator<TValue> _Where_iter, IEnumerable _Right);
+        void insert(ContainerRandomAccessIterator<TValue> _Where, int _Count, TValue _Val);
+        void pop_back();
+        void pop_front();
+        void push_back(TValue _Val);
+        void push_front(TValue _Val);
+        void rbegin(ref ReverseRandomAccessIterator<TValue> );
+        void rend(ref ReverseRandomAccessIterator<TValue> );
+        void resize(int _Newsize);
+        void resize(int _Newsize, TValue _Val);
+        int size();
+        void swap(IDeque<TValue> A_0);
+    }
+    public interface IHash<TKey, TValue> : IBidirectionalContainer<TValue>, ICloneable, ICollection, IEnumerable {
+        void begin(ref ContainerBidirectionalIterator<TValue> );
+        int bucket_count();
+        void clear();
+        int count(TKey _Keyval);
+        bool empty();
+        void end(ref ContainerBidirectionalIterator<TValue> );
+        void equal_range(ref GenericPair<ContainerBidirectionalIterator<TValue>, ContainerBidirectionalIterator<TValue>> , TKey _Keyval);
+        void erase(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _Where);
+        void erase(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _First_iter, ContainerBidirectionalIterator<TValue> _Last_iter);
+        int erase(TKey _Keyval);
+        void find(ref ContainerBidirectionalIterator<TValue> , TKey _Keyval);
+        UnaryDelegate<TKey, int> hash_delegate();
+        void insert(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _Where, TValue _Val);
+        void insert(IInputIterator<TValue> _First, IInputIterator<TValue> _Last);
+        void insert(ref GenericPair<ContainerBidirectionalIterator<TValue>, bool> , TValue _Val);
+        void insert(IEnumerable _Right);
+        BinaryDelegate<TKey, TKey, bool> key_comp();
+        float load_factor();
+        void lower_bound(ref ContainerBidirectionalIterator<TValue> , TKey _Keyval);
+        float max_load_factor();
+        void max_load_factor(float _Newmax);
+        void rbegin(ref ReverseBidirectionalIterator<TValue> );
+        void rehash(int _Buckets);
+        void rend(ref ReverseBidirectionalIterator<TValue> );
+        int size();
+        void swap(IHash<TKey, TValue> _Right);
+        void upper_bound(ref ContainerBidirectionalIterator<TValue> , TKey _Keyval);
+        BinaryDelegate<TValue, TValue, bool> value_comp();
+    }
+    public interface IList<TValue> : IBidirectionalContainer<TValue>, ICloneable, ICollection, IEnumerable {
+        TValue back_item { get; set; }
+        TValue front_item { get; set; }
+        void assign(IInputIterator<TValue> _First, IInputIterator<TValue> _Last);
+        void assign(IEnumerable _Right);
+        void assign(int _Count, TValue _Val);
+        ref TValue back();
+        void begin(ref ContainerBidirectionalIterator<TValue> );
+        void clear();
+        bool empty();
+        void end(ref ContainerBidirectionalIterator<TValue> );
+        void erase(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _Where);
+        void erase(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _First_iter, ContainerBidirectionalIterator<TValue> _Last_iter);
+        ref TValue front();
+        void insert(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _Where, TValue _Val);
+        void insert(ContainerBidirectionalIterator<TValue> _Where, IInputIterator<TValue> _First, IInputIterator<TValue> _Last);
+        void insert(ContainerBidirectionalIterator<TValue> _Where_iter, IEnumerable _Right);
+        void insert(ContainerBidirectionalIterator<TValue> _Where, int _Count, TValue _Val);
+        void merge(IList<TValue> _Right, BinaryDelegate<TValue, TValue, bool> _Pred);
+        void pop_back();
+        void pop_front();
+        void push_back(TValue _Val);
+        void push_front(TValue _Val);
+        void rbegin(ref ReverseBidirectionalIterator<TValue> );
+        void remove(TValue _Val);
+        void remove_if(UnaryDelegate<TValue, bool> _Pred);
+        void rend(ref ReverseBidirectionalIterator<TValue> );
+        void resize(int _Newsize);
+        void resize(int _Newsize, TValue _Val);
+        void reverse();
+        int size();
+        void sort(BinaryDelegate<TValue, TValue, bool> _Pred);
+        void splice(ContainerBidirectionalIterator<TValue> _Where, IList<TValue> _Right);
+        void splice(ContainerBidirectionalIterator<TValue> _Where, IList<TValue> _Right, ContainerBidirectionalIterator<TValue> _First);
+        void splice(ContainerBidirectionalIterator<TValue> _Where, IList<TValue> _Right, ContainerBidirectionalIterator<TValue> _First, ContainerBidirectionalIterator<TValue> _Last);
+        void swap(IList<TValue> _Right);
+        void unique(BinaryDelegate<TValue, TValue, bool> _Pred);
+    }
+    public interface IPriorityQueue<TValue, TCont> : ICloneable {
+        TValue top_item { get; set; }
+        void assign(IPriorityQueue<TValue, TCont> _Right);
+        bool empty();
+        TCont get_container();
+        void pop();
+        void push(TValue _Val);
+        int size();
+        ref TValue top();
+        BinaryDelegate<TValue, TValue, bool> value_comp();
+    }
+    public interface IQueue<TValue, TCont> : ICloneable {
+        void assign(IQueue<TValue, TCont> _Right);
+        ref TValue back();
+        bool empty();
+        ref TValue front();
+        TCont get_container();
+        void pop();
+        void push(TValue _Val);
+        int size();
+    }
+    public interface IStack<TValue, TCont> : ICloneable {
+        TValue top_item { get; set; }
+        void assign(IStack<TValue, TCont> _Right);
+        bool empty();
+        TCont get_container();
+        void pop();
+        void push(TValue _Val);
+        int size();
+        ref TValue top();
+    }
+    public interface ITree<TKey, TValue> : IBidirectionalContainer<TValue>, ICloneable, ICollection, IEnumerable {
+        void begin(ref ContainerBidirectionalIterator<TValue> );
+        void clear();
+        int count(TKey _Keyval);
+        bool empty();
+        void end(ref ContainerBidirectionalIterator<TValue> );
+        void equal_range(ref GenericPair<ContainerBidirectionalIterator<TValue>, ContainerBidirectionalIterator<TValue>> , TKey _Keyval);
+        void erase(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _Where);
+        void erase(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _First_iter, ContainerBidirectionalIterator<TValue> _Last_iter);
+        int erase(TKey _Keyval);
+        void find(ref ContainerBidirectionalIterator<TValue> , TKey _Keyval);
+        void insert(ref ContainerBidirectionalIterator<TValue> , ContainerBidirectionalIterator<TValue> _Where, TValue _Val);
+        void insert(IInputIterator<TValue> _First, IInputIterator<TValue> _Last);
+        void insert(ref GenericPair<ContainerBidirectionalIterator<TValue>, bool> , TValue _Val);
+        void insert(IEnumerable<TValue> _Right);
+        BinaryDelegate<TKey, TKey, bool> key_comp();
+        void lower_bound(ref ContainerBidirectionalIterator<TValue> , TKey _Keyval);
+        void rbegin(ref ReverseBidirectionalIterator<TValue> );
+        void rend(ref ReverseBidirectionalIterator<TValue> );
+        int size();
+        void swap(ITree<TKey, TValue> _Right);
+        void upper_bound(ref ContainerBidirectionalIterator<TValue> , TKey _Keyval);
+        BinaryDelegate<TValue, TValue, bool> value_comp();
+    }
+    public interface IVector<TValue> : ICloneable, ICollection, IEnumerable, IRandomAccessContainer<TValue> {
+        TValue back_item { get; set; }
+        TValue front_item { get; set; }
+        TValue this[int _Pos] { get; set; }
+        void assign(IInputIterator<TValue> _First, IInputIterator<TValue> _Last);
+        void assign(IEnumerable _Right);
+        void assign(int _Count, TValue _Val);
+        ref TValue at(int _Pos);
+        ref TValue back();
+        void begin(ref ContainerRandomAccessIterator<TValue> );
+        int capacity();
+        void clear();
+        bool empty();
+        void end(ref ContainerRandomAccessIterator<TValue> );
+        void erase(ref ContainerRandomAccessIterator<TValue> , ContainerRandomAccessIterator<TValue> _Where);
+        void erase(ref ContainerRandomAccessIterator<TValue> , ContainerRandomAccessIterator<TValue> _First_iter, ContainerRandomAccessIterator<TValue> _Last_iter);
+        ref TValue front();
+        uint get_generation();
+        void insert(ref ContainerRandomAccessIterator<TValue> , ContainerRandomAccessIterator<TValue> _Where, TValue _Val);
+        void insert(ContainerRandomAccessIterator<TValue> _Where, IInputIterator<TValue> _First, IInputIterator<TValue> _Last);
+        void insert(ContainerRandomAccessIterator<TValue> _Where_iter, IEnumerable _Right);
+        void insert(ContainerRandomAccessIterator<TValue> _Where, int _Count, TValue _Val);
+        void pop_back();
+        void push_back(TValue _Val);
+        void rbegin(ref ReverseRandomAccessIterator<TValue> );
+        void rend(ref ReverseRandomAccessIterator<TValue> );
+        void reserve(int _Capacity);
+        void resize(int _Newsize);
+        void resize(int _Newsize, TValue _Val);
+        int size();
+        void swap(IVector<TValue> A_0);
+    }
+    public class ListEnumerator<TValue> : ListEnumeratorBase<TValue>, IEnumerator<TValue> {
+        public ListEnumerator(INode<TValue> _First);
+        public virtual new TValue Current { get; set; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        public override bool MoveNext();
+        public override void Reset();
+    }
+    public class ListEnumeratorBase<TValue> : IEnumerator {
+        public ListEnumeratorBase(INode<TValue> _First);
+        public virtual object Current { get; set; }
+        public virtual bool MoveNext();
+        public virtual void Reset();
+    }
+    public class TreeEnumerator<TKey, TValue> : TreeEnumeratorBase<TKey, TValue>, IEnumerator<TValue> {
+        public TreeEnumerator(INode<TValue> _First);
+        public virtual new TValue Current { get; set; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        public override bool MoveNext();
+        public override void Reset();
+    }
+    public class TreeEnumeratorBase<TKey, TValue> : IEnumerator {
+        public TreeEnumeratorBase(INode<TValue> _First);
+        public virtual object Current { get; set; }
+        public virtual bool MoveNext();
+        public virtual void Reset();
+    }
+    public delegate TResult UnaryDelegate<TArg, TResult>(TArg A_0);
+    public class VectorEnumerator<TValue> : VectorEnumeratorBase<TValue>, IEnumerator<TValue> {
+        public VectorEnumerator(IVector<TValue> _Cont, int _First);
+        public virtual new TValue Current { get; set; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        public override bool MoveNext();
+        public override void Reset();
+    }
+    public class VectorEnumeratorBase<TValue> : IEnumerator {
+        public VectorEnumeratorBase(IVector<TValue> _Cont, int _First);
+        public virtual object Current { get; set; }
+        public virtual bool MoveNext();
+        public virtual void Reset();
+    }
+}
```

