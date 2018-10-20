// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Buffers
{
    public abstract partial class ArrayPool<T>
    {
        protected ArrayPool() { }
        public static System.Buffers.ArrayPool<T> Shared { get { throw null; } }
        public static System.Buffers.ArrayPool<T> Create() { throw null; }
        public static System.Buffers.ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket) { throw null; }
        public abstract T[] Rent(int minimumLength);
        public abstract void Return(T[] array, bool clearArray = false);
    }
    public static partial class BuffersExtensions
    {
        public static void Write<T>(this System.Buffers.IBufferWriter<T> writer, System.ReadOnlySpan<T> value) { }
    }
    public partial interface IBufferWriter<T>
    {
        void Advance(int count);
        System.Memory<T> GetMemory(int sizeHint = 0);
        System.Span<T> GetSpan(int sizeHint = 0);
    }
    public partial interface IMemoryOwner<T> : System.IDisposable
    {
        System.Memory<T> Memory { get; }
    }
    public partial interface IPinnable
    {
        System.Buffers.MemoryHandle Pin(int elementIndex);
        void Unpin();
    }
    public partial struct MemoryHandle : System.IDisposable
    {
        [System.CLSCompliantAttribute(false)]
        public unsafe MemoryHandle(void* pointer, System.Runtime.InteropServices.GCHandle handle = default(System.Runtime.InteropServices.GCHandle), System.Buffers.IPinnable pinnable = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe void* Pointer { get { throw null; } }
        public void Dispose() { }
    }
    public abstract partial class MemoryManager<T> : System.Buffers.IMemoryOwner<T>, System.Buffers.IPinnable, System.IDisposable
    {
        protected MemoryManager() { }
        public virtual System.Memory<T> Memory { get { throw null; } }
        protected System.Memory<T> CreateMemory(int length) { throw null; }
        protected System.Memory<T> CreateMemory(int start, int length) { throw null; }
        protected abstract void Dispose(bool disposing);
        public abstract System.Span<T> GetSpan();
        public abstract System.Buffers.MemoryHandle Pin(int elementIndex = 0);
        void System.IDisposable.Dispose() { }
        protected internal virtual bool TryGetArray(out System.ArraySegment<T> segment) { segment = default(System.ArraySegment<T>); throw null; }
        public abstract void Unpin();
    }
    public abstract partial class MemoryPool<T> : System.IDisposable
    {
        protected MemoryPool() { }
        public abstract int MaxBufferSize { get; }
        public static System.Buffers.MemoryPool<T> Shared { get { throw null; } }
        public void Dispose() { }
        protected abstract void Dispose(bool disposing);
        public abstract System.Buffers.IMemoryOwner<T> Rent(int minBufferSize = -1);
    }
    public enum OperationStatus
    {
        DestinationTooSmall = 1,
        Done = 0,
        InvalidData = 3,
        NeedMoreData = 2,
    }
    public delegate void ReadOnlySpanAction<T, in TArg>(System.ReadOnlySpan<T> span, TArg arg);
    public delegate void SpanAction<T, in TArg>(System.Span<T> span, TArg arg);
    public readonly partial struct StandardFormat : System.IEquatable<System.Buffers.StandardFormat>
    {
        public const byte MaxPrecision = (byte)99;
        public const byte NoPrecision = (byte)255;
        public StandardFormat(char symbol, byte precision = (byte)255) { throw null; }
        public bool HasPrecision { get { throw null; } }
        public bool IsDefault { get { throw null; } }
        public byte Precision { get { throw null; } }
        public char Symbol { get { throw null; } }
        public bool Equals(System.Buffers.StandardFormat other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Buffers.StandardFormat left, System.Buffers.StandardFormat right) { throw null; }
        public static implicit operator System.Buffers.StandardFormat(char symbol) { throw null; }
        public static bool operator !=(System.Buffers.StandardFormat left, System.Buffers.StandardFormat right) { throw null; }
        public static System.Buffers.StandardFormat Parse(System.ReadOnlySpan<char> format) { throw null; }
        public static System.Buffers.StandardFormat Parse(string format) { throw null; }
        public override string ToString() { throw null; }
    }
}
