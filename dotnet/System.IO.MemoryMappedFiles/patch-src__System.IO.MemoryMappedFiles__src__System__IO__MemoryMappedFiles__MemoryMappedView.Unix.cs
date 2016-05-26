--- src/System.IO.MemoryMappedFiles/src/System/IO/MemoryMappedFiles/MemoryMappedView.Unix.cs.orig	2016-03-07 09:41:43.000000000 -0500
+++ src/System.IO.MemoryMappedFiles/src/System/IO/MemoryMappedFiles/MemoryMappedView.Unix.cs	2016-03-11 15:07:02.849788000 -0500
@@ -59,16 +59,12 @@
 
             // If we have a file handle, get the file descriptor from it.  If the handle is null,
             // we'll use an anonymous backing store for the map.
-            SafeFileHandle fd;
             if (memMappedFileHandle._fileStream != null)
             {
-                // Get the file descriptor from the SafeFileHandle
-                fd = memMappedFileHandle._fileStream.SafeFileHandle;
-                Debug.Assert(!fd.IsInvalid);
+
             }
             else
             {
-                fd = new SafeFileHandle(new IntPtr(-1), false);
                 flags |= Interop.Sys.MemoryMappedFlags.MAP_ANONYMOUS;
             }
 
@@ -95,7 +91,7 @@
                     nativeSize,          // specify the rounded-size we computed so as to page align; size + extraMemNeeded
                     viewProtForCreation,
                     flags,
-                    fd,                  // mmap adds a ref count to the fd, so there's no need to dup it.
+                    new SafeFileHandle(new IntPtr(-1), false),                  // mmap adds a ref count to the fd, so there's no need to dup it.
                     nativeOffset);       // specify the rounded-offset we computed so as to page align; offset - extraMemNeeded
             }
             else
