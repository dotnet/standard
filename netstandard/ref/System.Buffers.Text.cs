// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Buffers.Text
{
    public static partial class Base64
    {
        public static System.Buffers.OperationStatus DecodeFromUtf8(System.ReadOnlySpan<byte> utf8, System.Span<byte> bytes, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true) { throw null; }
        public static System.Buffers.OperationStatus DecodeFromUtf8InPlace(System.Span<byte> buffer, out int bytesWritten) { throw null; }
        public static System.Buffers.OperationStatus EncodeToUtf8(System.ReadOnlySpan<byte> bytes, System.Span<byte> utf8, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true) { throw null; }
        public static System.Buffers.OperationStatus EncodeToUtf8InPlace(System.Span<byte> buffer, int dataLength, out int bytesWritten) { throw null; }
        public static int GetMaxDecodedFromUtf8Length(int length) { throw null; }
        public static int GetMaxEncodedToUtf8Length(int length) { throw null; }
    }
    public static partial class Utf8Formatter
    {
        public static bool TryFormat(bool value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(byte value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(System.DateTime value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(System.DateTimeOffset value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(decimal value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(double value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(System.Guid value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(short value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(int value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(long value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryFormat(sbyte value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(float value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        public static bool TryFormat(System.TimeSpan value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryFormat(ushort value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryFormat(uint value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryFormat(ulong value, System.Span<byte> destination, out int bytesWritten, System.Buffers.StandardFormat format = default(System.Buffers.StandardFormat)) { throw null; }
    }
    public static partial class Utf8Parser
    {
        public static bool TryParse(System.ReadOnlySpan<byte> source, out bool value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out byte value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out System.DateTime value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out System.DateTimeOffset value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out decimal value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out double value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out System.Guid value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out short value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out int value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out long value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<byte> source, out sbyte value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out float value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        public static bool TryParse(System.ReadOnlySpan<byte> source, out System.TimeSpan value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<byte> source, out uint value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed, char standardFormat = '\0') { throw null; }
    }
}
