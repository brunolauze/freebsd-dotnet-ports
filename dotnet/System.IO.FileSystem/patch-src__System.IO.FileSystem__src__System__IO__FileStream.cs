--- src/System.IO.FileSystem/src/System/IO/FileStream.cs.orig	2016-04-24 20:43:32.693032000 -0400
+++ src/System.IO.FileSystem/src/System/IO/FileStream.cs	2016-04-24 20:43:43.879895000 -0400
@@ -8,7 +8,7 @@
 
 namespace System.IO
 {
-    public partial class FileStream : Stream
+    internal partial class FileStream : Stream
     {
         internal const int DefaultBufferSize = 4096;
         private const FileShare DefaultShare = FileShare.Read;
