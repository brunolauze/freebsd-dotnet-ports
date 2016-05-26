--- src/System.IO.FileSystem/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs.orig	2016-03-09 09:50:35.105484000 -0500
+++ src/System.IO.FileSystem/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs	2016-03-09 09:51:58.953748000 -0500
@@ -10,7 +10,7 @@
 
 namespace Microsoft.Win32.SafeHandles
 {
-    public sealed partial class SafeFileHandle : SafeHandle
+    internal sealed partial class SafeFileHandle : SafeHandle
     {
         internal bool? IsAsync { get; set; }
     }
