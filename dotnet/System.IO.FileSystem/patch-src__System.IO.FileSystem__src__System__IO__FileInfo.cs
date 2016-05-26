--- src/System.IO.FileSystem/src/System/IO/FileInfo.cs.orig	2016-04-24 20:54:55.603795000 -0400
+++ src/System.IO.FileSystem/src/System/IO/FileInfo.cs	2016-04-24 20:55:56.451381000 -0400
@@ -14,7 +14,7 @@
 {
     // Class for creating FileStream objects, and some basic file management
     // routines such as Delete, etc.
-    public sealed partial class FileInfo : FileSystemInfo
+    internal sealed partial class FileInfo : FileSystemInfo
     {
         private String _name;
 
