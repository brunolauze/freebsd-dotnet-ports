--- /dev/null	2016-03-09 11:44:34.000000000 -0500
+++ src/System.IO.FileSystem.Watcher/src/SR.cs	2016-03-09 11:44:46.710093000 -0500
@@ -0,0 +1,294 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.IO.FileSystem.Watcher
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
+        private const String s_resourcesName = "FxResources.System.IO.FileSystem.Watcher.SR";
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
+        internal static String BufferSizeTooLarge
+        {
+            get
+            {
+                return SR.GetResourceString("BufferSizeTooLarge", null);
+            }
+        }
+
+        internal static String EventStream_FailedToStart
+        {
+            get
+            {
+                return SR.GetResourceString("EventStream_FailedToStart", null);
+            }
+        }
+
+        internal static String FSW_BufferOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("FSW_BufferOverflow", null);
+            }
+        }
+
+        internal static String FSW_IOError
+        {
+            get
+            {
+                return SR.GetResourceString("FSW_IOError", null);
+            }
+        }
+
+        internal static String InvalidDirName
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidDirName", null);
+            }
+        }
+
+        internal static String InvalidEnumArgument
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidEnumArgument", null);
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
+        internal static String IOException_INotifyInstanceSystemLimitExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("IOException_INotifyInstanceSystemLimitExceeded", null);
+            }
+        }
+
+        internal static String IOException_INotifyInstanceUserLimitExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("IOException_INotifyInstanceUserLimitExceeded", null);
+            }
+        }
+
+        internal static String IOException_INotifyInstanceUserLimitExceeded_Value
+        {
+            get
+            {
+                return SR.GetResourceString("IOException_INotifyInstanceUserLimitExceeded_Value", null);
+            }
+        }
+
+        internal static String IOException_INotifyWatchesUserLimitExceeded
+        {
+            get
+            {
+                return SR.GetResourceString("IOException_INotifyWatchesUserLimitExceeded", null);
+            }
+        }
+
+        internal static String IOException_INotifyWatchesUserLimitExceeded_Value
+        {
+            get
+            {
+                return SR.GetResourceString("IOException_INotifyWatchesUserLimitExceeded_Value", null);
+            }
+        }
+
+        internal static String ObjectDisposed_FileClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_FileClosed", null);
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
+                return typeof(FxResources.System.IO.FileSystem.Watcher.SR);
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
