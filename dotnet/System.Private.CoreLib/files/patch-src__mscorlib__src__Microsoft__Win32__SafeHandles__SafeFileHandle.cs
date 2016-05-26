--- src/mscorlib/src/Microsoft/Win32/SafeHandles/SafeFileHandle.cs.orig	2016-04-24 01:10:58.000000000 -0400
+++ src/mscorlib/src/Microsoft/Win32/SafeHandles/SafeFileHandle.cs	2016-04-24 13:11:07.366702000 -0400
@@ -2,42 +2,120 @@
 // The .NET Foundation licenses this file to you under the MIT license.
 // See the LICENSE file in the project root for more information.
 
-/*============================================================
-**
-**
-**
-** A wrapper for file handles
-**
-** 
-===========================================================*/
-
 using System;
-using System.Security;
-using System.Security.Permissions;
+using System.Diagnostics;
 using System.Runtime.InteropServices;
-using System.Runtime.CompilerServices;
-using System.Runtime.ConstrainedExecution;
-using System.Runtime.Versioning;
-using Microsoft.Win32;
 
-namespace Microsoft.Win32.SafeHandles {
+namespace Microsoft.Win32.SafeHandles
+{
+    [System.Security.SecurityCritical]
+    public sealed partial class SafeFileHandle : SafeHandle
+    {
+        /// <summary>A handle value of -1.</summary>
+        private static readonly IntPtr s_invalidHandle = new IntPtr(-1);
 
-    [System.Security.SecurityCritical]  // auto-generated_required
-    public sealed class SafeFileHandle: SafeHandleZeroOrMinusOneIsInvalid {
+        private SafeFileHandle() : this(ownsHandle: true)
+        {
+        }
 
-        private SafeFileHandle() : base(true) 
+        private SafeFileHandle(bool ownsHandle)
+            : base(s_invalidHandle, ownsHandle)
         {
         }
 
-        public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle) {
+        public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) : this(ownsHandle)
+        {
             SetHandle(preexistingHandle);
         }
 
+	public bool? IsAsync { get; set; }
+
+	public static SafeFileHandle Open(string path, int flags, int mode)
+	{
+		return Open(path, (Interop.Sys.OpenFlags)flags, mode);
+	}
+
+
+        /// <summary>Opens the specified file with the requested flags and mode.</summary>
+        /// <param name="path">The path to the file.</param>
+        /// <param name="flags">The flags with which to open the file.</param>
+        /// <param name="mode">The mode for opening the file.</param>
+        /// <returns>A SafeFileHandle for the opened file.</returns>
+        internal static SafeFileHandle Open(string path, Interop.Sys.OpenFlags flags, int mode)
+        {
+            // If we fail to open the file due to a path not existing, we need to know whether to blame
+            // the file itself or its directory.  If we're creating the file, then we blame the directory,
+            // otherwise we blame the file.
+            bool enoentDueToDirectory = (flags & Interop.Sys.OpenFlags.O_CREAT) != 0;
+
+            // Open the file. 
+            SafeFileHandle handle = Interop.CheckIo(
+                Interop.Sys.Open(path, flags, mode),
+                path, 
+                isDirectory: enoentDueToDirectory,
+                errorRewriter: e => (e.Error == Interop.Error.EISDIR) ? Interop.Error.EACCES.Info() : e);
+
+            // Make sure it's not a directory; we do this after opening it once we have a file descriptor 
+            // to avoid race conditions.
+            Interop.Sys.FileStatus status;
+            if (Interop.Sys.FStat(handle, out status) != 0)
+            {
+                handle.Dispose();
+                //throw Interop.GetExceptionForIoErrno(Interop.Sys.GetLastErrorInfo(), path);
+            }
+            if ((status.Mode & Interop.Sys.FileTypes.S_IFMT) == Interop.Sys.FileTypes.S_IFDIR)
+            {
+                handle.Dispose();
+                //throw Interop.GetExceptionForIoErrno(Interop.Error.EACCES.Info(), path, isDirectory: true);
+            }
+
+            return handle;
+        }
+
+        /// <summary>Opens a SafeFileHandle for a file descriptor created by a provided delegate.</summary>
+        /// <param name="fdFunc">
+        /// The function that creates the file descriptor. Returns the file descriptor on success, or an invalid
+        /// file descriptor on error with Marshal.GetLastWin32Error() set to the error code.
+        /// </param>
+        /// <returns>The created SafeFileHandle.</returns>
+        public static SafeFileHandle Open(Func<SafeFileHandle> fdFunc)
+        {
+            SafeFileHandle handle = Interop.CheckIo(fdFunc());
+            return handle;
+        }
+
         [System.Security.SecurityCritical]
-        override protected bool ReleaseHandle()
+        protected override bool ReleaseHandle()
         {
-            return Win32Native.CloseHandle(handle);
+            // When the SafeFileHandle was opened, we likely issued an flock on the created descriptor in order to add 
+            // an advisory lock.  This lock should be removed via closing the file descriptor, but close can be
+            // interrupted, and we don't retry closes.  As such, we could end up leaving the file locked,
+            // which could prevent subsequent usage of the file until this process dies.  To avoid that, we proactively
+            // try to release the lock before we close the handle. (If it's not locked, there's no behavioral
+            // problem trying to unlock it.)
+            Interop.Sys.FLock(handle, Interop.Sys.LockOperations.LOCK_UN); // ignore any errors
+
+            // Close the descriptor. Although close is documented to potentially fail with EINTR, we never want
+            // to retry, as the descriptor could actually have been closed, been subsequently reassigned, and
+            // be in use elsewhere in the process.  Instead, we simply check whether the call was successful.
+            int result = Interop.Sys.Close(handle);
+#if DEBUG
+            if (result != 0)
+            {
+
+            }
+#endif
+            return result == 0;
+        }
+
+        public override bool IsInvalid
+        {
+            [System.Security.SecurityCritical]
+            get
+            {
+                long h = (long)handle;
+                return h < 0 || h > int.MaxValue;
+            }
         }
     }
 }
-
