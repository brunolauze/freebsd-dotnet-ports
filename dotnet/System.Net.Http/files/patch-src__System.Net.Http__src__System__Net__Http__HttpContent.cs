--- src/System.Net.Http/src/System/Net/Http/HttpContent.cs.orig	2016-08-22 17:44:57.808076000 -0400
+++ src/System.Net.Http/src/System/Net/Http/HttpContent.cs	2016-08-22 17:45:38.844835000 -0400
@@ -142,9 +142,7 @@
 
         internal bool TryGetBuffer(out ArraySegment<byte> buffer)
         {
-#if NET46
             buffer = default(ArraySegment<byte>);
-#endif
             return _bufferedContent != null && _bufferedContent.TryGetBuffer(out buffer);
         }
 
