--- /dev/null	2016-03-07 15:57:52.000000000 -0500
+++ src/System.Globalization.Extensions/src/SR.cs	2016-03-07 15:58:17.783206000 -0500
@@ -0,0 +1,198 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Globalization.Extensions
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
+        private const String s_resourcesName = "FxResources.System.Globalization.Extensions.SR";
+
+        internal static String Arg_OutOfMemoryException
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_OutOfMemoryException", null);
+            }
+        }
+
+        internal static String Argument_IdnBadLabelSize
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_IdnBadLabelSize", null);
+            }
+        }
+
+        internal static String Argument_IdnBadPunycode
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_IdnBadPunycode", null);
+            }
+        }
+
+        internal static String Argument_IdnIllegalName
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_IdnIllegalName", null);
+            }
+        }
+
+        internal static String Argument_InvalidCharSequence
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidCharSequence", null);
+            }
+        }
+
+        internal static String Argument_InvalidCharSequenceNoIndex
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidCharSequenceNoIndex", null);
+            }
+        }
+
+        internal static String Argument_InvalidFlag
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidFlag", null);
+            }
+        }
+
+        internal static String Argument_InvalidNormalizationForm
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidNormalizationForm", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_Index
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Index", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_IndexCountBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_IndexCountBuffer", null);
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
+                return typeof(FxResources.System.Globalization.Extensions.SR);
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
