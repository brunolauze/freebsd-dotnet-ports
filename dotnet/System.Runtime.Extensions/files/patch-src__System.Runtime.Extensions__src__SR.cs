--- /dev/null	2016-01-28 11:35:46.000000000 -0500
+++ src/System.Runtime.Extensions/src/SR.cs	2016-01-28 11:36:12.788149000 -0500
@@ -0,0 +1,396 @@
+using System.Resources;
+
+namespace FxResources.System.Runtime.Extensions
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
+        private const string s_resourcesName = "FxResources.System.Runtime.Extensions.SR";
+
+	internal static string InvalidOperation_Cryptography
+	{
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_Cryptography", null);
+            }
+        }
+		
+	internal static string ArgumentOutOfRange_FileLengthTooBig
+	{
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig", null);
+            }
+        }
+
+        internal static string Arg_ArrayPlusOffTooSmall
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_ArrayPlusOffTooSmall", null);
+            }
+        }
+
+        internal static string Arg_InvalidSearchPattern
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidSearchPattern", null);
+            }
+        }
+
+        internal static string Arg_Path2IsRooted
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_Path2IsRooted", null);
+            }
+        }
+
+        internal static string Arg_PathGlobalRoot
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_PathGlobalRoot", null);
+            }
+        }
+
+        internal static string Arg_PathIllegal
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_PathIllegal", null);
+            }
+        }
+
+        internal static string Arg_PathIllegalUNC
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_PathIllegalUNC", null);
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
+        internal static string Argument_FrameworkNameInvalid
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_FrameworkNameInvalid", null);
+            }
+        }
+
+        internal static string Argument_FrameworkNameInvalidVersion
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_FrameworkNameInvalidVersion", null);
+            }
+        }
+
+        internal static string Argument_FrameworkNameMissingVersion
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_FrameworkNameMissingVersion", null);
+            }
+        }
+
+        internal static string Argument_FrameworkNameTooShort
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_FrameworkNameTooShort", null);
+            }
+        }
+
+        internal static string Argument_InvalidPathChars
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidPathChars", null);
+            }
+        }
+
+        internal static string Argument_MinMaxValue
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_MinMaxValue", null);
+            }
+        }
+
+        internal static string Argument_PathEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_PathEmpty", null);
+            }
+        }
+
+        internal static string Argument_PathFormatNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_PathFormatNotSupported", null);
+            }
+        }
+
+        internal static string Argument_PathUriFormatNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_PathUriFormatNotSupported", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_GenericPositive
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_GenericPositive", null);
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
+        internal static string ArgumentOutOfRange_LengthTooLarge
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_LengthTooLarge", null);
+            }
+        }
+
+        internal static string ArgumentOutOfRange_MustBePositive
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_MustBePositive", null);
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
+        internal static string ArgumentOutOfRange_StartIndex
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_StartIndex", null);
+            }
+        }
+
+        internal static string IO_AlreadyExists_Name
+        {
+            get
+            {
+                return SR.GetResourceString("IO_AlreadyExists_Name", null);
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
+        internal static string net_emptystringcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_emptystringcall", null);
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
+                return typeof(FxResources.System.Runtime.Extensions.SR);
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
