# System.Net.Sockets

``` diff
 namespace System.Net.Sockets {
+    public class HttpPolicyDownloaderProtocol {
+        public HttpPolicyDownloaderProtocol(Uri appUri, IPAddress address);
+        public SocketPolicy Result { get; }
+        public void Abort();
+        public void BeginDownload(SecurityCriticalAction callback);
+        public void DownloadCallback(IAsyncResult ar);
+        public void ReadCallback(IAsyncResult ar);
+        public static void RegisterUnsafeWebRequestCreator(IUnsafeWebRequestCreate creator);
+    }
+    public delegate void SecurityCriticalAction();
     public class SocketAsyncEventArgs : EventArgs, IDisposable {
+        public SocketClientAccessPolicyProtocol SocketClientAccessPolicyProtocol { get; set; }
     }
+    public enum SocketClientAccessPolicyProtocol {
+        Http = 1,
+        Tcp = 0,
+    }
     public enum SocketFlags {
+        MaxIOVectorLength = 16,
     }
+    public class SocketPolicy {
+        public SocketPolicy();
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct SocketReceiveFromResult {
 {
-        public int ReceivedBytes;

-        public EndPoint RemoteEndPoint;

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct SocketReceiveMessageFromResult {
 {
-        public int ReceivedBytes;

-        public EndPoint RemoteEndPoint;

-        public IPPacketInformation PacketInformation;

-        public SocketFlags SocketFlags;

-    }
-    public static class SocketTaskExtensions {
 {
-        public static Task<Socket> AcceptAsync(this Socket socket);

-        public static Task<Socket> AcceptAsync(this Socket socket, Socket acceptSocket);

-        public static Task ConnectAsync(this Socket socket, EndPoint remoteEP);

-        public static Task ConnectAsync(this Socket socket, IPAddress address, int port);

-        public static Task ConnectAsync(this Socket socket, IPAddress[] addresses, int port);

-        public static Task ConnectAsync(this Socket socket, string host, int port);

-        public static Task<int> ReceiveAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags);

-        public static Task<int> ReceiveAsync(this Socket socket, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);

-        public static Task<SocketReceiveFromResult> ReceiveFromAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint);

-        public static Task<SocketReceiveMessageFromResult> ReceiveMessageFromAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint);

-        public static Task<int> SendAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags);

-        public static Task<int> SendAsync(this Socket socket, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);

-        public static Task<int> SendToAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP);

-    }
+    public class UdpAnySourceMulticastClient : IDisposable {
+        public UdpAnySourceMulticastClient(IPAddress groupAddress, int localPort);
+        public bool MulticastLoopback { get; set; }
+        public int ReceiveBufferSize { get; set; }
+        public int SendBufferSize { get; set; }
+        public IAsyncResult BeginJoinGroup(AsyncCallback callback, object state);
+        public IAsyncResult BeginReceiveFromGroup(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        public IAsyncResult BeginSendTo(byte[] buffer, int offset, int count, IPEndPoint remoteEndPoint, AsyncCallback callback, object state);
+        public IAsyncResult BeginSendToGroup(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        public void BlockSource(IPAddress sourceAddress);
+        public void Dispose();
+        public void EndJoinGroup(IAsyncResult result);
+        public int EndReceiveFromGroup(IAsyncResult result, out IPEndPoint source);
+        public void EndSendTo(IAsyncResult result);
+        public void EndSendToGroup(IAsyncResult result);
+        public void UnblockSource(IPAddress sourceAddress);
+    }
+    public class UdpSingleSourceMulticastClient : IDisposable {
+        public UdpSingleSourceMulticastClient(IPAddress sourceAddress, IPAddress groupAddress, int localPort);
+        public int ReceiveBufferSize { get; set; }
+        public int SendBufferSize { get; set; }
+        public IAsyncResult BeginJoinGroup(AsyncCallback callback, object state);
+        public IAsyncResult BeginReceiveFromSource(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        public IAsyncResult BeginSendToSource(byte[] buffer, int offset, int count, int remotePort, AsyncCallback callback, object state);
+        public void Dispose();
+        public void EndJoinGroup(IAsyncResult result);
+        public int EndReceiveFromSource(IAsyncResult result, out int sourcePort);
+        public void EndSendToSource(IAsyncResult result);
+    }
 }
```

