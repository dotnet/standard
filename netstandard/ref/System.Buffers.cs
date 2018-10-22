// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Buffers
{
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
}
