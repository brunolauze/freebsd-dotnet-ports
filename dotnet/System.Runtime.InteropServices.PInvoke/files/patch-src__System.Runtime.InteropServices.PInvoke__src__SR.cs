--- /dev/null	2016-03-07 16:12:00.000000000 -0500
+++ src/System.Runtime.InteropServices.PInvoke/src/SR.cs	2016-03-07 16:13:37.470812000 -0500
@@ -0,0 +1,127 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Runtime.InteropServices.PInvoke
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
+        private const string s_resourcesName = "FxResources.System.Runtime.InteropServices.PInvoke.SR";
+
+        internal static string Arg_InvalidThreshold
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidThreshold", null);
+            }
+        }
+
+        internal static string Arg_NeedNonNegNumRequired
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_NeedNonNegNumRequired", null);
+            }
+        }
+
+        internal static string InvalidOperation_HCCountOverflow
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_HCCountOverflow", null);
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
+                return typeof(FxResources.System.Runtime.InteropServices.PInvoke.SR);
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
