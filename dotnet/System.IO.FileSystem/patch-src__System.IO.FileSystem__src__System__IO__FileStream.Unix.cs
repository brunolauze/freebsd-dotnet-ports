--- src/System.IO.FileSystem/src/System/IO/FileStream.Unix.cs.orig	2016-04-24 20:44:11.631062000 -0400
+++ src/System.IO.FileSystem/src/System/IO/FileStream.Unix.cs	2016-04-24 20:44:52.665229000 -0400
@@ -6,7 +6,7 @@
 
 namespace System.IO
 {
-    public partial class FileStream : Stream
+    internal partial class FileStream : Stream
     {
         public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) :
             this(handle, access, bufferSize, handle.IsAsync ?? false)
