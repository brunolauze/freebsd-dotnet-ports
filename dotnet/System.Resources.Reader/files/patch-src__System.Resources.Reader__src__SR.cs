--- /dev/null	2016-05-07 21:23:25.000000000 -0400
+++ src/System.Resources.Reader/src/SR.cs	2016-05-07 21:23:45.286332000 -0400
@@ -0,0 +1,238 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Resources.Reader
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
+        private const String s_resourcesName = "FxResources.System.Resources.Reader.SR";
+
+        internal static String Arg_ResourceFileUnsupportedVersion
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_ResourceFileUnsupportedVersion", null);
+            }
+        }
+
+        internal static String Argument_StreamNotReadable
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_StreamNotReadable", null);
+            }
+        }
+
+        internal static String Argument_StreamNotSeekable
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_StreamNotSeekable", null);
+            }
+        }
+
+        internal static String BadImageFormat_InvalidType
+        {
+            get
+            {
+                return SR.GetResourceString("BadImageFormat_InvalidType", null);
+            }
+        }
+
+        internal static String BadImageFormat_NegativeStringLength
+        {
+            get
+            {
+                return SR.GetResourceString("BadImageFormat_NegativeStringLength", null);
+            }
+        }
+
+        internal static String BadImageFormat_ResourceNameCorrupted_NameIndex
+        {
+            get
+            {
+                return SR.GetResourceString("BadImageFormat_ResourceNameCorrupted_NameIndex", null);
+            }
+        }
+
+        internal static String BadImageFormat_ResourcesDataInvalidOffset
+        {
+            get
+            {
+                return SR.GetResourceString("BadImageFormat_ResourcesDataInvalidOffset", null);
+            }
+        }
+
+        internal static String BadImageFormat_ResourcesHeaderCorrupted
+        {
+            get
+            {
+                return SR.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted", null);
+            }
+        }
+
+        internal static String BadImageFormat_ResourcesNameInvalidOffset
+        {
+            get
+            {
+                return SR.GetResourceString("BadImageFormat_ResourcesNameInvalidOffset", null);
+            }
+        }
+
+        internal static String BadImageFormat_TypeMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("BadImageFormat_TypeMismatch", null);
+            }
+        }
+
+        internal static String Format_Bad7BitInt32
+        {
+            get
+            {
+                return SR.GetResourceString("Format_Bad7BitInt32", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumEnded
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumEnded", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumNotStarted
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumNotStarted", null);
+            }
+        }
+
+        internal static String InvalidOperation_ResourceWriterSaved
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_ResourceWriterSaved", null);
+            }
+        }
+
+        internal static String NotSupported_WrongResourceReader_Type
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_WrongResourceReader_Type", null);
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
+        internal static String ResourceReaderIsClosed
+        {
+            get
+            {
+                return SR.GetResourceString("ResourceReaderIsClosed", null);
+            }
+        }
+
+        internal static String Resources_StreamNotValid
+        {
+            get
+            {
+                return SR.GetResourceString("Resources_StreamNotValid", null);
+            }
+        }
+
+        internal static Type ResourceType
+        {
+            get
+            {
+                return typeof(FxResources.System.Resources.Reader.SR);
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
+                return String.Format(resourceFormat, new Object[] { p1 });
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, new Object[] { p1, p2 });
+            }
+            return String.Join(", ", new Object[] { resourceFormat, p1, p2 });
+        }
+
+        internal static String Format(String resourceFormat, Object p1, Object p2, Object p3)
+        {
+            if (!SR.UsingResourceKeys())
+            {
+                return String.Format(resourceFormat, new Object[] { p1, p2, p3 });
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
+            if (defaultString != null && resourceKey.Equals(str, StringComparison.Ordinal))
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
