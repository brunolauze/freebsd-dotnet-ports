--- /dev/null	2016-03-11 09:08:01.000000000 -0500
+++ src/System.Net.WebHeaderCollection/src/SR.cs	2016-03-11 09:09:17.487878000 -0500
@@ -0,0 +1,182 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.WebHeaderCollection
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
+        private const String s_resourcesName = "FxResources.System.Net.WebHeaderCollection.SR";
+
+        internal static String net_emptystringcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_emptystringcall", null);
+            }
+        }
+
+        internal static String net_headerrestrict
+        {
+            get
+            {
+                return SR.GetResourceString("net_headerrestrict", null);
+            }
+        }
+
+        internal static String net_headers_req
+        {
+            get
+            {
+                return SR.GetResourceString("net_headers_req", null);
+            }
+        }
+
+        internal static String net_headers_rsp
+        {
+            get
+            {
+                return SR.GetResourceString("net_headers_rsp", null);
+            }
+        }
+
+        internal static String net_headers_toolong
+        {
+            get
+            {
+                return SR.GetResourceString("net_headers_toolong", null);
+            }
+        }
+
+        internal static String net_WebHeaderInvalidControlChars
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderInvalidControlChars", null);
+            }
+        }
+
+        internal static String net_WebHeaderInvalidCRLFChars
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderInvalidCRLFChars", null);
+            }
+        }
+
+        internal static String net_WebHeaderInvalidHeaderChars
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderInvalidHeaderChars", null);
+            }
+        }
+
+        internal static String net_WebHeaderInvalidNonAsciiChars
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderInvalidNonAsciiChars", null);
+            }
+        }
+
+        internal static String net_WebHeaderMissingColon
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebHeaderMissingColon", null);
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
+                return typeof(FxResources.System.Net.WebHeaderCollection.SR);
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
