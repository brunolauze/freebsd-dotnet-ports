--- /dev/null	2016-03-10 12:01:34.000000000 -0500
+++ src/System.IO.MemoryMappedFiles/src/SR.cs	2016-03-10 12:02:44.298233000 -0500
@@ -0,0 +1,374 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.IO.MemoryMappedFiles
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
+        private const String s_resourcesName = "FxResources.System.IO.MemoryMappedFiles.SR";
+
+        internal static String Argument_EmptyFile
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_EmptyFile", null);
+            }
+        }
+
+        internal static String Argument_MapNameEmptyString
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_MapNameEmptyString", null);
+            }
+        }
+
+        internal static String Argument_NewMMFAppendModeNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NewMMFAppendModeNotAllowed", null);
+            }
+        }
+
+        internal static String Argument_NewMMFWriteAccessNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NewMMFWriteAccessNotAllowed", null);
+            }
+        }
+
+        internal static String Argument_ReadAccessWithLargeCapacity
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_ReadAccessWithLargeCapacity", null);
+            }
+        }
+
+        internal static String ArgumentNull_FileStream
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_FileStream", null);
+            }
+        }
+
+        internal static String ArgumentNull_MapName
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_MapName", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_CapacityGEFileSizeRequired
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_CapacityGEFileSizeRequired", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_CapacityLargerThanLogicalAddressSpaceNotAllowed
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_CapacityLargerThanLogicalAddressSpaceNotAllowed", null);
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
+        internal static String ArgumentOutOfRange_NeedNonNegNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNum", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_NeedPositiveNumber
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedPositiveNumber", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_PositiveOrDefaultCapacityRequired
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_PositiveOrDefaultCapacityRequired", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_PositiveOrDefaultSizeRequired
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_PositiveOrDefaultSizeRequired", null);
+            }
+        }
+
+        internal static String InvalidOperation_CantCreateFileMapping
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_CantCreateFileMapping", null);
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
+        internal static String IO_NotEnoughMemory
+        {
+            get
+            {
+                return SR.GetResourceString("IO_NotEnoughMemory", null);
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
+        internal static String NotSupported_MMViewStreamsFixedLength
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_MMViewStreamsFixedLength", null);
+            }
+        }
+
+        internal static String NotSupported_UnreadableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnreadableStream", null);
+            }
+        }
+
+        internal static String NotSupported_UnwritableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnwritableStream", null);
+            }
+        }
+
+        internal static String ObjectDisposed_StreamIsClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_StreamIsClosed", null);
+            }
+        }
+
+        internal static String ObjectDisposed_ViewAccessorClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_ViewAccessorClosed", null);
+            }
+        }
+
+        internal static String PersistedFiles_NoHomeDirectory
+        {
+            get
+            {
+                return SR.GetResourceString("PersistedFiles_NoHomeDirectory", null);
+            }
+        }
+
+        internal static String PlatformNotSupported_NamedMaps
+        {
+            get
+            {
+                return SR.GetResourceString("PlatformNotSupported_NamedMaps", null);
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
+                return typeof(FxResources.System.IO.MemoryMappedFiles.SR);
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
