--- src/System.Net.Http/src/System/Net/Http/HttpContent.cs.orig	2016-04-26 20:08:31.448665000 -0400
+++ src/System.Net.Http/src/System/Net/Http/HttpContent.cs	2016-04-26 20:08:50.668114000 -0400
@@ -142,6 +142,7 @@
 
         internal bool TryGetBuffer(out ArraySegment<byte> buffer)
         {
+	    buffer = default(ArraySegment<byte>);
             return _bufferedContent != null && _bufferedContent.TryGetBuffer(out buffer);
         }
 
