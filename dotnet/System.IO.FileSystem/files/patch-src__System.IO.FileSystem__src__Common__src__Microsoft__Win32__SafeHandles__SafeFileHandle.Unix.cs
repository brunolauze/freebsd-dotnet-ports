--- src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs.orig	2016-05-06 18:18:12.917716000 -0400
+++ src/Common/src/Microsoft/Win32/SafeHandles/SafeFileHandle.Unix.cs	2016-05-06 18:19:23.731673000 -0400
@@ -72,7 +72,7 @@
         /// file descriptor on error with Marshal.GetLastWin32Error() set to the error code.
         /// </param>
         /// <returns>The created SafeFileHandle.</returns>
-        internal static SafeFileHandle Open(Func<SafeFileHandle> fdFunc)
+        public static SafeFileHandle Open(Func<SafeFileHandle> fdFunc)
         {
             SafeFileHandle handle = Interop.CheckIo(fdFunc());
 
