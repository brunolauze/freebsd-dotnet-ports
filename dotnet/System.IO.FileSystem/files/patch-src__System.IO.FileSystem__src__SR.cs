--- /dev/null	2016-03-07 13:22:00.000000000 -0500
+++ src/System.IO.FileSystem/src/SR.cs	2016-03-07 13:21:49.221160000 -0500
@@ -0,0 +1,558 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.IO.FileSystem
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
+        private const String s_resourcesName = "FxResources.System.IO.FileSystem.SR";
+
+        internal static String Arg_DevicesNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_DevicesNotSupported", null);
+            }
+        }
+
+        internal static String Arg_FileIsDirectory_Name
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_FileIsDirectory_Name", null);
+            }
+        }
+
+        internal static String Arg_HandleNotAsync
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_HandleNotAsync", null);
+            }
+        }
+
+        internal static String Arg_HandleNotSync
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_HandleNotSync", null);
+            }
+        }
+
+        internal static String Arg_InvalidFileAttrs
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidFileAttrs", null);
+            }
+        }
+
+        internal static String Arg_InvalidHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidHandle", null);
+            }
+        }
+
+        internal static String Arg_InvalidSearchPattern
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidSearchPattern", null);
+            }
+        }
+
+        internal static String Arg_Path2IsRooted
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_Path2IsRooted", null);
+            }
+        }
+
+        internal static String Arg_PathIsVolume
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_PathIsVolume", null);
+            }
+        }
+
+        internal static String Argument_EmptyFileName
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_EmptyFileName", null);
+            }
+        }
+
+        internal static String Argument_EmptyPath
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_EmptyPath", null);
+            }
+        }
+
+        internal static String Argument_InvalidAppendMode
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidAppendMode", null);
+            }
+        }
+
+        internal static String Argument_InvalidFileModeAndAccessCombo
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidFileModeAndAccessCombo", null);
+            }
+        }
+
+        internal static String Argument_InvalidOffLen
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidOffLen", null);
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
+        internal static String Argument_InvalidSeekOrigin
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidSeekOrigin", null);
+            }
+        }
+
+        internal static String Argument_InvalidSubPath
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidSubPath", null);
+            }
+        }
+
+        internal static String Argument_PathEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_PathEmpty", null);
+            }
+        }
+
+        internal static String Argument_PathFormatNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_PathFormatNotSupported", null);
+            }
+        }
+
+        internal static String ArgumentNull_Buffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Buffer", null);
+            }
+        }
+
+        internal static String ArgumentNull_FileName
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_FileName", null);
+            }
+        }
+
+        internal static String ArgumentNull_Path
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Path", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_Enum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Enum", null);
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
+        internal static String ArgumentOutOfRange_NeedNonNegInt32Range
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegInt32Range", null);
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
+        internal static String ArgumentOutOfRange_NeedPosNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedPosNum", null);
+            }
+        }
+
+        internal static String IndexOutOfRange_IORaceCondition
+        {
+            get
+            {
+                return SR.GetResourceString("IndexOutOfRange_IORaceCondition", null);
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
+        internal static String IO_BindHandleFailed
+        {
+            get
+            {
+                return SR.GetResourceString("IO_BindHandleFailed", null);
+            }
+        }
+
+        internal static String IO_CannotCreateDirectory
+        {
+            get
+            {
+                return SR.GetResourceString("IO_CannotCreateDirectory", null);
+            }
+        }
+
+        internal static String IO_EOF_ReadBeyondEOF
+        {
+            get
+            {
+                return SR.GetResourceString("IO_EOF_ReadBeyondEOF", null);
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
+        internal static String IO_FileStreamHandlePosition
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileStreamHandlePosition", null);
+            }
+        }
+
+        internal static String IO_FileTooLong2GB
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileTooLong2GB", null);
+            }
+        }
+
+        internal static String IO_FileTooLongOrHandleNotSync
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileTooLongOrHandleNotSync", null);
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
+        internal static String IO_SeekAppendOverwrite
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SeekAppendOverwrite", null);
+            }
+        }
+
+        internal static String IO_SetLengthAppendTruncate
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SetLengthAppendTruncate", null);
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
+        internal static String IO_SourceDestMustBeDifferent
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SourceDestMustBeDifferent", null);
+            }
+        }
+
+        internal static String IO_SourceDestMustHaveSameRoot
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SourceDestMustHaveSameRoot", null);
+            }
+        }
+
+        internal static String IO_SyncOpOnUIThread
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SyncOpOnUIThread", null);
+            }
+        }
+
+        internal static String IO_UnknownFileName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_UnknownFileName", null);
+            }
+        }
+
+        internal static String NotSupported_FileStreamOnNonFiles
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_FileStreamOnNonFiles", null);
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
+        internal static String NotSupported_UnseekableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnseekableStream", null);
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
+                return typeof(FxResources.System.IO.FileSystem.SR);
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
