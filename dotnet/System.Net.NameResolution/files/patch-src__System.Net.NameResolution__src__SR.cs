--- /dev/null	2016-03-18 12:47:49.000000000 -0400
+++ src/System.Net.NameResolution/src/SR.cs	2016-03-18 12:48:31.057040000 -0400
@@ -0,0 +1,150 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.NameResolution
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
+        private const String s_resourcesName = "FxResources.System.Net.NameResolution.SR";
+
+        internal static String net_completed_result
+        {
+            get
+            {
+                return SR.GetResourceString("net_completed_result", null);
+            }
+        }
+
+        internal static String net_invalid_ip_addr
+        {
+            get
+            {
+                return SR.GetResourceString("net_invalid_ip_addr", null);
+            }
+        }
+
+        internal static String net_io_invalidasyncresult
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_invalidasyncresult", null);
+            }
+        }
+
+        internal static String net_io_invalidendcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_invalidendcall", null);
+            }
+        }
+
+        internal static String net_log_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_exception", null);
+            }
+        }
+
+        internal static String net_toolong
+        {
+            get
+            {
+                return SR.GetResourceString("net_toolong", null);
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
+                return typeof(FxResources.System.Net.NameResolution.SR);
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
