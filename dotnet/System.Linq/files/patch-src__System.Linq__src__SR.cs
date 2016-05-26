--- /dev/null	2016-01-28 15:33:15.000000000 -0500
+++ src/System.Linq/src/SR.cs	2016-01-28 15:33:42.284206000 -0500
@@ -0,0 +1,140 @@
+using System.Resources;
+
+namespace FxResources.System.Linq
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
+        private const String s_resourcesName = "FxResources.System.Linq.SR";
+
+        internal static String EmptyEnumerable
+        {
+            get
+            {
+                return SR.GetResourceString("EmptyEnumerable", null);
+            }
+        }
+
+        internal static String MoreThanOneElement
+        {
+            get
+            {
+                return SR.GetResourceString("MoreThanOneElement", null);
+            }
+        }
+
+        internal static String MoreThanOneMatch
+        {
+            get
+            {
+                return SR.GetResourceString("MoreThanOneMatch", null);
+            }
+        }
+
+        internal static String NoElements
+        {
+            get
+            {
+                return SR.GetResourceString("NoElements", null);
+            }
+        }
+
+        internal static String NoMatch
+        {
+            get
+            {
+                return SR.GetResourceString("NoMatch", null);
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
+                return typeof(FxResources.System.Linq.SR);
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
