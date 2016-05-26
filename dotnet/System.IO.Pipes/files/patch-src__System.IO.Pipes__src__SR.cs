--- src/System.IO.Pipes/src/SR.cs.orig	2016-04-22 16:13:45.354770000 -0400
+++ src/System.IO.Pipes/src/SR.cs	2016-04-22 16:16:05.969929000 -0400
@@ -0,0 +1,535 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.IO.Pipes
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
+        private const String s_resourcesName = "FxResources.System.IO.Pipes.SR";
+
+	internal static string ArgumentOutOfRange_PathLengthInvalid
+	{
+	    get
+	    {
+		return SR.GetResourceString("ArgumentOutOfRange_PathLengthInvalid", null);
+	    }
+	}
+
+        internal static string PlatformNotSupported_RemotePipes
+        {
+            get
+            {
+                return SR.GetResourceString("PlatformNotSupported_RemotePipes", null);
+            }
+        }
+
+
+	internal static string PlatformNotSupproted_InvalidNameChars
+	{
+	    get
+	    {
+		return SR.GetResourceString("PlatformNotSupproted_InvalidNameChars", null);
+	    }
+	}
+
+	internal static string PlatformNotSupported_MessageTransmissionMode
+	{
+	    get
+	    {
+		return SR.GetResourceString("PlatformNotSupported_MessageTransmissionMode", null);
+	    }
+	}
+
+        internal static String Argument_EmptyServerName
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_EmptyServerName", null);
+            }
+        }
+
+        internal static String Argument_InvalidHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidHandle", null);
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
+        internal static String Argument_NeedNonemptyPipeName
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NeedNonemptyPipeName", null);
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
+        internal static String ArgumentNull_ServerName
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_ServerName", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_AdditionalAccessLimited
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_AdditionalAccessLimited", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_AnonymousReserved
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_AnonymousReserved", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_DirectionModeInOutOrInOut
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_DirectionModeInOutOrInOut", null);
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
+        internal static String ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_ImpersonationInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_ImpersonationInvalid", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_InvalidPipeAccessRights
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_InvalidPipeAccessRights", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_InvalidTimeout
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_InvalidTimeout", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_MaxNumServerInstances
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_MaxNumServerInstances", null);
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
+        internal static String ArgumentOutOfRange_OptionsInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_OptionsInvalid", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_TransmissionModeByteOrMsg
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_TransmissionModeByteOrMsg", null);
+            }
+        }
+
+        internal static String InvalidOperation_PipeAlreadyConnected
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_PipeAlreadyConnected", null);
+            }
+        }
+
+        internal static String InvalidOperation_PipeAlreadyDisconnected
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_PipeAlreadyDisconnected", null);
+            }
+        }
+
+        internal static String InvalidOperation_PipeDisconnected
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_PipeDisconnected", null);
+            }
+        }
+
+        internal static String InvalidOperation_PipeHandleNotSet
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_PipeHandleNotSet", null);
+            }
+        }
+
+        internal static String InvalidOperation_PipeNotAsync
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_PipeNotAsync", null);
+            }
+        }
+
+        internal static String InvalidOperation_PipeNotYetConnected
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_PipeNotYetConnected", null);
+            }
+        }
+
+        internal static String InvalidOperation_PipeReadModeNotMessage
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_PipeReadModeNotMessage", null);
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
+        internal static String IO_InvalidPipeHandle
+        {
+            get
+            {
+                return SR.GetResourceString("IO_InvalidPipeHandle", null);
+            }
+        }
+
+        internal static String IO_NoPermissionToDirectoryName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_NoPermissionToDirectoryName", null);
+            }
+        }
+
+        internal static String IO_OperationAborted
+        {
+            get
+            {
+                return SR.GetResourceString("IO_OperationAborted", null);
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
+        internal static String IO_PipeBroken
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PipeBroken", null);
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
+        internal static String NotSupported_AnonymousPipeMessagesNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_AnonymousPipeMessagesNotSupported", null);
+            }
+        }
+
+        internal static String NotSupported_AnonymousPipeUnidirectional
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_AnonymousPipeUnidirectional", null);
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
+        internal static String ObjectDisposed_PipeClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ObjectDisposed_PipeClosed", null);
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
+                return typeof(FxResources.System.IO.Pipes.SR);
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
