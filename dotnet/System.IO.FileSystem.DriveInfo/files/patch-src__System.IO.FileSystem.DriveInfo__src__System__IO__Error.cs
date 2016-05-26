--- src/System.IO.FileSystem.DriveInfo/src/System/IO/Error.cs.orig	2016-03-07 09:41:43.000000000 -0500
+++ src/System.IO.FileSystem.DriveInfo/src/System/IO/Error.cs	2016-03-11 10:18:20.760719000 -0500
@@ -3,6 +3,7 @@
 // See the LICENSE file in the project root for more information.
 
 using System;
+using System.ComponentModel;
 using System.Runtime.InteropServices;
 using System.Text;
 using System.Globalization;
@@ -26,12 +27,20 @@
         {
             switch (errorCode)
             {
+#if WIN32
                 case Interop.mincore.Errors.ERROR_PATH_NOT_FOUND:
                 case Interop.mincore.Errors.ERROR_INVALID_DRIVE:
                     return new DriveNotFoundException(SR.Format(SR.IO_DriveNotFound_Drive, driveName));
 
                 default:
                     return Win32Marshal.GetExceptionForWin32Error(errorCode, driveName);
+#else
+		case System.HResults.ERROR_PATH_NOT_FOUND:
+		case System.HResults.ERROR_INVALID_DRIVE:
+			return new DriveNotFoundException(SR.Format(SR.IO_DriveNotFound_Drive, driveName));
+		default:
+			return new Win32Exception(SR.Format(SR.IO_DriveNotFound_Drive, driveName));
+#endif
             }
         }
     }
