--- /dev/null	2016-01-28 15:56:29.000000000 -0500
+++ src/System.Console/src/SR.cs	2016-01-28 15:57:05.566763000 -0500
@@ -0,0 +1,389 @@
+using System.Resources;
+
+namespace FxResources.System.Console 
+{
+		internal class SR
+		{
+		}
+}
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const String s_resourcesName = "FxResources.System.Console.SR";
+
+		internal static String InvalidOperation_ConsoleKeyAvailableOnFile
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_ConsoleKeyAvailableOnFile", null);
+            }
+        }
+		
+		internal static String ArgumentOutOfRange_ConsoleTitleTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_ConsoleTitleTooLong", null);
+            }
+        }
+		
+		internal static String ArgumentOutOfRange_ConsoleBufferBoundaries
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_ConsoleBufferBoundaries", null);
+            }
+        }
+		
+		
+        internal static String Arg_InvalidConsoleColor
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidConsoleColor", null);
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
+        internal static String ArgumentNull_Buffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Buffer", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_ConsoleKey
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_ConsoleKey", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_ConsoleWindowBufferSize
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_ConsoleWindowBufferSize", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_ConsoleWindowSize_Size
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_ConsoleWindowSize_Size", null);
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
+        internal static String InvalidOperation_ConsoleReadKeyOnFile
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_ConsoleReadKeyOnFile", null);
+            }
+        }
+
+        internal static String InvalidOperation_EmptyStack
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EmptyStack", null);
+            }
+        }
+
+        internal static String InvalidOperation_PrintF
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_PrintF", null);
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
+        internal static String IO_NoConsole
+        {
+            get
+            {
+                return SR.GetResourceString("IO_NoConsole", null);
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
+        internal static String IO_TermInfoInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("IO_TermInfoInvalid", null);
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
+        internal static String PersistedFiles_NoHomeDirectory
+        {
+            get
+            {
+                return SR.GetResourceString("PersistedFiles_NoHomeDirectory", null);
+            }
+        }
+
+        internal static String PlatformNotSupported_GettingColor
+        {
+            get
+            {
+                return SR.GetResourceString("PlatformNotSupported_GettingColor", null);
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
+                return typeof(FxResources.System.Console.SR);
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
