--- src/System.Diagnostics.Process/src/System/Diagnostics/Process.Unix.cs.orig	2016-03-11 15:38:07.653750000 -0500
+++ src/System.Diagnostics.Process/src/System/Diagnostics/Process.Unix.cs	2016-03-11 15:38:56.144549000 -0500
@@ -414,7 +414,7 @@
         {
             Debug.Assert(fd >= 0);
             return new FileStream(
-                new SafeFileHandle((IntPtr)fd, ownsHandle: true), 
+                (IntPtr)fd, 
                 access, StreamBufferSize, isAsync: false);
         }
 
