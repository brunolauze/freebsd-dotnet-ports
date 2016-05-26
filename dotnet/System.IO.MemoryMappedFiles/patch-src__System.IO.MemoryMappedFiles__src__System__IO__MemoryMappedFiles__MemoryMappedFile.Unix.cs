--- src/System.IO.MemoryMappedFiles/src/System/IO/MemoryMappedFiles/MemoryMappedFile.Unix.cs.orig	2016-03-07 09:41:43.000000000 -0500
+++ src/System.IO.MemoryMappedFiles/src/System/IO/MemoryMappedFiles/MemoryMappedFile.Unix.cs	2016-03-11 15:10:25.612336000 -0500
@@ -74,7 +74,7 @@
                     // If the MMF handle should not be inherited, mark the backing object fd as O_CLOEXEC.
                     if (inheritability == HandleInheritability.None)
                     {
-                        Interop.CheckIo(Interop.Sys.Fcntl.SetCloseOnExec(fileStream.SafeFileHandle));
+                        Interop.CheckIo(Interop.Sys.Fcntl.SetCloseOnExec((SafeFileHandle)fileStream.NativeSafeFileHandle));
                     }
                 }
             }
@@ -200,7 +200,7 @@
                 Interop.CheckIo(Interop.Sys.FTruncate(fd, capacity));
 
                 // Wrap the file descriptor in a stream and return it.
-                return new FileStream(fd, TranslateProtectionsToFileAccess(protections));
+                return new FileStream(fd.DangerousGetHandle(), TranslateProtectionsToFileAccess(protections));
             }
             catch
             {
