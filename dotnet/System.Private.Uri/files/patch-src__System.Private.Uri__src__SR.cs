--- /dev/null	2016-03-04 11:00:00.000000000 -0500
+++ src/System.Private.Uri/src/SR.cs	2016-03-04 10:59:55.337428000 -0500
@@ -0,0 +1,509 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Private.Uri
+{
+	internal class SR 
+	{ 
+	}
+}
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const string s_resourcesName = "FxResources.System.Private.Uri.SR";
+
+        internal static string Argument_InvalidUriSubcomponent
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidUriSubcomponent", null);
+            }
+        }
+
+	internal static string Argument_ExtraNotValid
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_ExtraNotValid", null);
+            }
+        }
+
+        internal static string Argument_InvalidNormalizationForm
+	{
+	    get
+	    {
+		return SR.GetResourceString("Argument_InvalidNormalizationForm", null);
+	    }
+	}
+
+        internal static string Arg_OutOfMemoryException
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_OutOfMemoryException", null);
+            }
+        }
+
+        internal static string Argument_AddingDuplicate
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AddingDuplicate", null);
+            }
+        }
+
+        internal static string Argument_IdnBadLabelSize
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_IdnBadLabelSize", null);
+            }
+        }
+
+        internal static string Argument_IdnBadPunycode
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_IdnBadPunycode", null);
+            }
+        }
+
+        internal static string Argument_IdnIllegalName
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_IdnIllegalName", null);
+            }
+        }
+
+        internal static string Argument_InvalidCharSequence
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidCharSequence", null);
+            }
+        }
+
+        internal static string Argument_InvalidCharSequenceNoIndex
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidCharSequenceNoIndex", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_FileLengthTooBig
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_Index
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Index", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_IndexCountBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_IndexCountBuffer", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_NeedNonNegNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNum", null);
+            }
+        }
+
+        internal static string AssertionFailed
+        {
+            get
+            {
+                return SR.GetResourceString("AssertionFailed", null);
+            }
+        }
+
+        internal static string Debug_Fail
+        {
+            get
+            {
+                return SR.GetResourceString("Debug_Fail", null);
+            }
+        }
+
+        internal static string DebugAssertBanner
+        {
+            get
+            {
+                return SR.GetResourceString("DebugAssertBanner", null);
+            }
+        }
+
+        internal static string DebugAssertLongMessage
+        {
+            get
+            {
+                return SR.GetResourceString("DebugAssertLongMessage", null);
+            }
+        }
+
+        internal static string DebugAssertShortMessage
+        {
+            get
+            {
+                return SR.GetResourceString("DebugAssertShortMessage", null);
+            }
+        }
+
+        internal static string IO_FileExists_Name
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileExists_Name", null);
+            }
+        }
+
+        internal static string IO_FileNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileNotFound", null);
+            }
+        }
+
+        internal static string IO_FileNotFound_FileName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_FileNotFound_FileName", null);
+            }
+        }
+
+        internal static string IO_PathNotFound_NoPathName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathNotFound_NoPathName", null);
+            }
+        }
+
+        internal static string IO_PathNotFound_Path
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathNotFound_Path", null);
+            }
+        }
+
+        internal static string IO_PathTooLong
+        {
+            get
+            {
+                return SR.GetResourceString("IO_PathTooLong", null);
+            }
+        }
+
+        internal static string IO_SharingViolation_File
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SharingViolation_File", null);
+            }
+        }
+
+        internal static string IO_SharingViolation_NoFileName
+        {
+            get
+            {
+                return SR.GetResourceString("IO_SharingViolation_NoFileName", null);
+            }
+        }
+
+        internal static string net_uri_AlreadyRegistered
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_AlreadyRegistered", null);
+            }
+        }
+
+        internal static string net_uri_BadAuthority
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadAuthority", null);
+            }
+        }
+
+        internal static string net_uri_BadAuthorityTerminator
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadAuthorityTerminator", null);
+            }
+        }
+
+        internal static string net_uri_BadFormat
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadFormat", null);
+            }
+        }
+
+        internal static string net_uri_BadHostName
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadHostName", null);
+            }
+        }
+
+        internal static string net_uri_BadPort
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadPort", null);
+            }
+        }
+
+        internal static string net_uri_BadScheme
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadScheme", null);
+            }
+        }
+
+        internal static string net_uri_BadString
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadString", null);
+            }
+        }
+
+        internal static string net_uri_BadUnicodeHostForIdn
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadUnicodeHostForIdn", null);
+            }
+        }
+
+        internal static string net_uri_BadUserPassword
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_BadUserPassword", null);
+            }
+        }
+
+        internal static string net_uri_CannotCreateRelative
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_CannotCreateRelative", null);
+            }
+        }
+
+        internal static string net_uri_EmptyUri
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_EmptyUri", null);
+            }
+        }
+
+        internal static string net_uri_InvalidUriKind
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_InvalidUriKind", null);
+            }
+        }
+
+        internal static string net_uri_MustRootedPath
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_MustRootedPath", null);
+            }
+        }
+
+        internal static string net_uri_NeedFreshParser
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_NeedFreshParser", null);
+            }
+        }
+
+        internal static string net_uri_NotAbsolute
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_NotAbsolute", null);
+            }
+        }
+
+        internal static string net_uri_NotJustSerialization
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_NotJustSerialization", null);
+            }
+        }
+
+        internal static string net_uri_PortOutOfRange
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_PortOutOfRange", null);
+            }
+        }
+
+        internal static string net_uri_SchemeLimit
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_SchemeLimit", null);
+            }
+        }
+
+        internal static string net_uri_SizeLimit
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_SizeLimit", null);
+            }
+        }
+
+        internal static string net_uri_UserDrivenParsing
+        {
+            get
+            {
+                return SR.GetResourceString("net_uri_UserDrivenParsing", null);
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
+                return typeof(FxResources.System.Private.Uri.SR);
+            }
+        }
+
+        internal static string UnauthorizedAccess_IODenied_NoPathName
+        {
+            get
+            {
+                return SR.GetResourceString("UnauthorizedAccess_IODenied_NoPathName", null);
+            }
+        }
+
+        internal static string UnauthorizedAccess_IODenied_Path
+        {
+            get
+            {
+                return SR.GetResourceString("UnauthorizedAccess_IODenied_Path", null);
+            }
+        }
+
+        internal static string UnknownError_Num
+        {
+            get
+            {
+                return SR.GetResourceString("UnknownError_Num", null);
+            }
+        }
+
+        internal static string Format(string resourceFormat, params object[] args)
+        {
+            if (args == null)
+            {
+                return resourceFormat;
+            }
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, args);
+            }
+            return string.Concat(resourceFormat, string.Join(", ", args));
+        }
+
+        internal static string Format(string resourceFormat, object p1)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1 });
+        }
+
+        internal static string Format(string resourceFormat, object p1, object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1, p2);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static string Format(string resourceFormat, object p1, object p2, object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return string.Format(resourceFormat, p1, p2, p3);
+            }
+            return string.Join(", ", new object[] { resourceFormat, p1, p2, p3 });
+        }
+
+        internal static string GetResourceString(string resourceKey, string defaultString)
+        {
+            string str = null;
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
+        private static bool UsingResourceKeys()
+        {
+            return false;
+        }
+    }
+}
