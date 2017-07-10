# System.Net.Sockets

``` diff
 namespace System.Net.Sockets {
     public class NetworkStream : Stream {
+        public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);
+        public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);
     }
 }
```

