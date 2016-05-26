--- /dev/null	2016-04-26 20:27:44.000000000 -0400
+++ src/System.Net.NetworkInformation/src/SR.cs	2016-04-26 20:28:14.800658000 -0400
@@ -0,0 +1,199 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.NetworkInformation
+{
+    internal static class SR
+    {
+
+    }
+}
+
+
+namespace System
+{
+    internal static class SR
+    {
+        private static ResourceManager s_resourceManager;
+
+        private const string s_resourcesName = "FxResources.System.Net.NetworkInformation.SR";
+
+        internal static string net_bad_mac_address
+        {
+            get
+            {
+                return SR.GetResourceString("net_bad_mac_address", null);
+            }
+        }
+
+        internal static string net_collection_readonly
+        {
+            get
+            {
+                return SR.GetResourceString("net_collection_readonly", null);
+            }
+        }
+
+        internal static string net_completed_result
+        {
+            get
+            {
+                return SR.GetResourceString("net_completed_result", null);
+            }
+        }
+
+        internal static string net_FailedToParseNetworkFile
+        {
+            get
+            {
+                return SR.GetResourceString("net_FailedToParseNetworkFile", null);
+            }
+        }
+
+        internal static string net_InformationUnavailableOnPlatform
+        {
+            get
+            {
+                return SR.GetResourceString("net_InformationUnavailableOnPlatform", null);
+            }
+        }
+
+        internal static string net_io_invalidasyncresult
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_invalidasyncresult", null);
+            }
+        }
+
+        internal static string net_io_invalidendcall
+        {
+            get
+            {
+                return SR.GetResourceString("net_io_invalidendcall", null);
+            }
+        }
+
+        internal static string net_log_exception
+        {
+            get
+            {
+                return SR.GetResourceString("net_log_exception", null);
+            }
+        }
+
+        internal static string net_MethodNotImplementedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_MethodNotImplementedException", null);
+            }
+        }
+
+        internal static string net_NoLoopback
+        {
+            get
+            {
+                return SR.GetResourceString("net_NoLoopback", null);
+            }
+        }
+
+        internal static string net_PInvokeError
+        {
+            get
+            {
+                return SR.GetResourceString("net_PInvokeError", null);
+            }
+        }
+
+        internal static string net_PropertyNotImplementedException
+        {
+            get
+            {
+                return SR.GetResourceString("net_PropertyNotImplementedException", null);
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
+                return typeof(FxResources.System.Net.NetworkInformation.SR);
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
+            if (defaultString != null && resourceKey.Equals(str, StringComparison.Ordinal))
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
