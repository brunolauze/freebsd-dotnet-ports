--- src/System.IO.FileSystem/src/System/IO/UnixFileStream.cs.orig	2016-04-24 16:29:46.626583000 -0400
+++ src/System.IO.FileSystem/src/System/IO/UnixFileStream.cs	2016-04-24 16:30:16.353815000 -0400
@@ -123,7 +123,7 @@
                 Interop.Sys.Permissions.S_IROTH | Interop.Sys.Permissions.S_IWOTH;
 
             // Open the file and store the safe handle. Subsequent code in this method expects the safe handle to be initialized.
-            _fileHandle = SafeFileHandle.Open(path, openFlags, (int)openPermissions);
+            _fileHandle = SafeFileHandle.Open(path, (int)openFlags, (int)openPermissions);
             try
             {
                 _fileHandle.IsAsync = _useAsyncIO;
