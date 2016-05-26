--- /dev/null	2016-03-11 09:20:21.000000000 -0500
+++ src/System.IO.FileSystem.DriveInfo/src/SR.cs	2016-03-11 09:20:39.342694000 -0500
@@ -0,0 +1,262 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.IO.FileSystem.DriveInfo
+{
+    internal static class SR
+    {
+
+    }
+}
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const String s_resourcesName = "FxResources.System.IO.FileSystem.DriveInfo.SR";
+
+        internal static String Arg_InvalidDriveChars
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidDriveChars", null);
+            }
+        }
+
+        internal static String Arg_MustBeDriveLetterOrRootDir
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_MustBeDriveLetterOrRootDir", null);
+            }
+        }
+
+        internal static String Arg_MustBeNonEmptyDriveName
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_MustBeNonEmptyDriveName", null);
+            }
+        }
+
+        internal static String Argument_InvalidPathChars
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidPathChars", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_FileLengthTooBig
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig", null);
+            }
+        }
+
+        internal static String InvalidOperation_SetVolumeLabelFailed
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_SetVolumeLabelFailed", null);
+            }
+        }
+
+        internal static String IO_AlreadyExists_Name
+        {
+            get
+            {
+                return SR.GetResourceString("IO_AlreadyExists_Name", null);
+            }
+        }
+
+        internal static String IO_DriveNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("IO_DriveNotFound", null);
+            }
+        }
+
+        internal static String IO_DriveNotFound_Drive
+        {
+            get
+            {
+                return SR.GetResourceString("IO_DriveNotFound_Drive", null);
+            }
+        }
+
+        internal static String IO_FileExists_Name
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileExists_Name", null);
+            }
+        }
+
+        internal static String IO_FileNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileNotFound", null);
+            }
+        }
+
+        internal static String IO_FileNotFound_FileName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileNotFound_FileName", null);
+            }
+        }
+
+        internal static String IO_PathNotFound_NoPathName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathNotFound_NoPathName", null);
+            }
+        }
+
+        internal static String IO_PathNotFound_Path
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathNotFound_Path", null);
+            }
+        }
+
+        internal static String IO_PathTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathTooLong", null);
+            }
+        }
+
+        internal static String IO_SharingViolation_File
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SharingViolation_File", null);
+            }
+        }
+
+        internal static String IO_SharingViolation_NoFileName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SharingViolation_NoFileName", null);
+            }
+        }
+
+        private static ResourceManager ResourceManager
+        {
+            get
+            {
+                if (SR.s_resourceManager == null)
+                {
+                    SR.s_resourceManager = new ResourceManager(SR.ResourceType);
+                }
+                return SR.s_resourceManager;
+            }
+        }
+
+        internal static Type ResourceType
+        {
+            get
+            {
+                return typeof(FxResources.System.IO.FileSystem.DriveInfo.SR);
+            }
+        }
+
+        internal static String UnauthorizedAccess_IODenied_NoPathName
+        {
+            get
+            {
+                return SR.GetResourceString("UnauthorizedAccess_IODenied_NoPathName", null);
+            }
+        }
+
+        internal static String UnauthorizedAccess_IODenied_Path
+        {
+            get
+            {
+                return SR.GetResourceString("UnauthorizedAccess_IODenied_Path", null);
+            }
+        }
+
+        internal static String UnknownError_Num
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownError_Num", null);
+            }
+        }
+
+        internal static String Format(String resourceFormat, params Object[] args)
+        {
+            if (args == null)
+            {
+                return resourceFormat;
+            }
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, args);
+            }
+            return String.Concat(resourceFormat, String.Join(", ", args));
+        }
+
+        internal static String Format(String resourceFormat, Object p1)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1, p2);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2, Object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, p1, p2, p3);
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2, p3 });
+        }
+
+        internal static String GetResourceString(String resourceKey, String defaultString)
+        {
+            String str = null;
+            try
+            {
+                str = SR.ResourceManager.GetString(resourceKey);
+            }
+            catch (MissingManifestResourceException missingManifestResourceException)
+            {
+            }
+            if (defaultString != null && resourceKey.Equals(str))
+            {
+                return defaultString;
+            }
+            return str;
+        }
+
+        private static Boolean UsingResourceKeys()
+        {
+            return false;
+        }
+    }
+}
