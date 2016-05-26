--- /dev/null	2016-05-21 14:24:20.000000000 -0400
+++ src/System.Runtime.InteropServices/src/SR.cs	2016-05-21 14:27:10.253790000 -0400
@@ -0,0 +1,134 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Runtime.InteropServices
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
+        private const String s_resourcesName = "FxResources.System.Runtime.InteropServices.SR";
+
+		internal static String Arg_NeedNonNegNumRequired
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_NeedNonNegNumRequired", null);
+            }
+        }
+
+        internal static String Arg_InvalidThreshold
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidThreshold", null);
+            }
+        }
+		
+		internal static String InvalidOperation_HCCountOverflow
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
+                return typeof(FxResources.System.Runtime.InteropServices.SR);
+            }
+        }
+
+        internal static String Text
+        {
+            get
+            {
+                return SR.GetResourceString("Text", null);
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
