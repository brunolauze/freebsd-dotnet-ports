--- /dev/null	2016-04-23 19:22:00.000000000 -0400
+++ src/mscorlib/src/Microsoft/Win32/Interop.IOErrors.cs	2016-04-23 19:27:28.915866000 -0400
@@ -0,0 +1,167 @@
+// Licensed to the .NET Foundation under one or more agreements.
+// The .NET Foundation licenses this file to you under the MIT license.
+// See the LICENSE file in the project root for more information.
+
+using System;
+using System.Diagnostics;
+using System.IO;
+using System.Runtime.InteropServices;
+using Microsoft.Win32.SafeHandles;
+
+internal static partial class Interop
+{
+    private static void ThrowExceptionForIoErrno(ErrorInfo errorInfo, string path, bool isDirectory, Func<ErrorInfo, ErrorInfo> errorRewriter)
+    {
+        if (errorRewriter != null)
+        {
+            errorInfo = errorRewriter(errorInfo);
+        }
+
+        throw Interop.GetExceptionForIoErrno(errorInfo, path, isDirectory);
+    }
+
+    internal static void CheckIo(Error error, string path = null, bool isDirectory = false, Func<ErrorInfo, ErrorInfo> errorRewriter = null)
+    {
+        if (error != Interop.Error.SUCCESS)
+        {
+            ThrowExceptionForIoErrno(error.Info(), path, isDirectory, errorRewriter);
+        }
+    }
+
+    /// <summary>
+    /// Validates the result of system call that returns greater than or equal to 0 on success
+    /// and less than 0 on failure, with errno set to the error code.
+    /// If the system call failed for any reason, an exception is thrown. Otherwise, the system call succeeded.
+    /// </summary>
+    /// <param name="result">The result of the system call.</param>
+    /// <param name="path">The path with which this error is associated.  This may be null.</param>
+    /// <param name="isDirectory">true if the <paramref name="path"/> is known to be a directory; otherwise, false.</param>
+    /// <param name="errorRewriter">Optional function to change an error code prior to processing it.</param>
+    /// <returns>
+    /// On success, returns the non-negative result long that was validated.
+    /// </returns>
+    internal static long CheckIo(long result, string path = null, bool isDirectory = false, Func<ErrorInfo, ErrorInfo> errorRewriter = null)
+    {
+        if (result < 0)
+        {
+            ThrowExceptionForIoErrno(Sys.GetLastErrorInfo(), path, isDirectory, errorRewriter);
+        }
+
+        return result;
+    }
+
+    /// <summary>
+    /// Validates the result of system call that returns greater than or equal to 0 on success
+    /// and less than 0 on failure, with errno set to the error code.
+    /// If the system call failed for any reason, an exception is thrown. Otherwise, the system call succeeded.
+    /// </summary>
+    /// <returns>
+    /// On success, returns the non-negative result int that was validated.
+    /// </returns>
+    internal static int CheckIo(int result, string path = null, bool isDirectory = false, Func<ErrorInfo, ErrorInfo> errorRewriter = null)
+    {
+        CheckIo((long)result, path, isDirectory, errorRewriter);
+
+        return result;
+    }
+
+    /// <summary>
+    /// Validates the result of system call that returns greater than or equal to 0 on success
+    /// and less than 0 on failure, with errno set to the error code.
+    /// If the system call failed for any reason, an exception is thrown. Otherwise, the system call succeeded.
+    /// </summary>
+    /// <returns>
+    /// On success, returns the non-negative result IntPtr that was validated.
+    /// </returns>
+    internal static IntPtr CheckIo(IntPtr result, string path = null, bool isDirectory = false, Func<ErrorInfo, ErrorInfo> errorRewriter = null)
+    {
+        CheckIo((long)result, path, isDirectory, errorRewriter);
+
+        return result;
+    }
+
+    /// <summary>
+    /// Validates the result of system call that returns greater than or equal to 0 on success
+    /// and less than 0 on failure, with errno set to the error code.
+    /// If the system call failed for any reason, an exception is thrown. Otherwise, the system call succeeded.
+    /// </summary>
+    /// <returns>
+    /// On success, returns the valid SafeFileHandle that was validated.
+    /// </returns>
+    internal static TSafeHandle CheckIo<TSafeHandle>(TSafeHandle handle, string path = null, bool isDirectory = false, Func<ErrorInfo, ErrorInfo> errorRewriter = null)
+        where TSafeHandle : SafeHandle
+    {
+        if (handle.IsInvalid)
+        {
+            ThrowExceptionForIoErrno(Sys.GetLastErrorInfo(), path, isDirectory, errorRewriter);
+        }
+
+        return handle;
+    }
+
+    /// <summary>
+    /// Gets an Exception to represent the supplied error info.
+    /// </summary>
+    /// <param name="error">The error info</param>
+    /// <param name="path">The path with which this error is associated.  This may be null.</param>
+    /// <param name="isDirectory">true if the <paramref name="path"/> is known to be a directory; otherwise, false.</param>
+    /// <returns></returns>
+    internal static Exception GetExceptionForIoErrno(ErrorInfo errorInfo, string path = null, bool isDirectory = false)
+    {
+        // Translate the errno into a known set of exception types.  For cases where multiple errnos map
+        // to the same exception type, include an inner exception with the details.
+        switch (errorInfo.Error)
+        {
+            case Error.ENOENT:
+                if (isDirectory)
+                {
+                    return !string.IsNullOrEmpty(path) ?
+                        new DirectoryNotFoundException(SR.Format(SR.IO_PathNotFound_Path, path)) :
+                        new DirectoryNotFoundException(SR.IO_PathNotFound_NoPathName);
+                }
+                else
+                {
+                    return !string.IsNullOrEmpty(path) ?
+                        new FileNotFoundException(SR.Format(SR.IO_FileNotFound_FileName, path), path) :
+                        new FileNotFoundException(SR.IO_FileNotFound);
+                }
+
+            case Error.EACCES:
+            case Error.EBADF:
+            case Error.EPERM:
+                Exception inner = GetIOException(errorInfo);
+                return !string.IsNullOrEmpty(path) ?
+                    new UnauthorizedAccessException(SR.Format(SR.UnauthorizedAccess_IODenied_Path, path), inner) :
+                    new UnauthorizedAccessException(SR.UnauthorizedAccess_IODenied_NoPathName, inner);
+
+            case Error.ENAMETOOLONG:
+                return new PathTooLongException(SR.IO_PathTooLong);
+
+            case Error.EWOULDBLOCK:
+                return !string.IsNullOrEmpty(path) ?
+                    new IOException(SR.Format(SR.IO_SharingViolation_File, path), errorInfo.RawErrno) :
+                    new IOException(SR.IO_SharingViolation_NoFileName, errorInfo.RawErrno);
+
+            case Error.ECANCELED:
+                return new OperationCanceledException();
+
+            case Error.EFBIG:
+                return new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_FileLengthTooBig);
+
+            case Error.EEXIST:
+                if (!string.IsNullOrEmpty(path))
+                {
+                    return new IOException(SR.Format(SR.IO_FileExists_Name, path), errorInfo.RawErrno);
+                }
+                goto default;
+
+            default:
+                return GetIOException(errorInfo);
+        }
+    }
+
+    internal static Exception GetIOException(Interop.ErrorInfo errorInfo)
+    {
+        return new IOException(errorInfo.GetErrorMessage(), errorInfo.RawErrno);
+    }
+}
