--- /dev/null	2016-03-11 09:06:55.000000000 -0500
+++ src/System.Net.Requests/src/SR.cs	2016-03-11 09:07:08.925398000 -0500
@@ -0,0 +1,238 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.Requests
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
+        private const String s_resourcesName = "FxResources.System.Net.Requests.SR";
+
+        internal static String net_badmethod
+        {
+            get
+            {
+                return SR.GetResourceString("net_badmethod", null);
+            }
+        }
+
+        internal static String net_emptystringcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_emptystringcall", null);
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
+        internal static String net_headers_toolong
+        {
+            get
+            {
+                return SR.GetResourceString("net_headers_toolong", null);
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
+        internal static String net_io_timeout_use_ge_zero
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_timeout_use_ge_zero", null);
+            }
+        }
+
+        internal static String net_MethodNotImplementedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_MethodNotImplementedException", null);
+            }
+        }
+
+        internal static String net_nouploadonget
+        {
+            get
+            {
+                return SR.GetResourceString("net_nouploadonget", null);
+            }
+        }
+
+        internal static String net_PropertyNotImplementedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_PropertyNotImplementedException", null);
+            }
+        }
+
+        internal static String net_repcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_repcall", null);
+            }
+        }
+
+        internal static String net_reqaborted
+        {
+            get
+            {
+                return SR.GetResourceString("net_reqaborted", null);
+            }
+        }
+
+        internal static String net_reqsubmitted
+        {
+            get
+            {
+                return SR.GetResourceString("net_reqsubmitted", null);
+            }
+        }
+
+        internal static String net_servererror
+        {
+            get
+            {
+                return SR.GetResourceString("net_servererror", null);
+            }
+        }
+
+        internal static String net_unknown_prefix
+        {
+            get
+            {
+                return SR.GetResourceString("net_unknown_prefix", null);
+            }
+        }
+
+        internal static String net_writestarted
+        {
+            get
+            {
+                return SR.GetResourceString("net_writestarted", null);
+            }
+        }
+
+        internal static String NotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported", null);
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
+                return typeof(FxResources.System.Net.Requests.SR);
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
