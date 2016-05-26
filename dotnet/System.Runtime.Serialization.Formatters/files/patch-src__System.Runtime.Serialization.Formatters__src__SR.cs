--- /dev/null	2016-05-15 09:19:24.000000000 -0400
+++ src/System.Runtime.Serialization.Formatters/src/SR.cs	2016-05-15 09:19:49.998062000 -0400
@@ -0,0 +1,136 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Runtime.Serialization.Formatters
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
+        private const String s_resourcesName = "FxResources.System.Runtime.Serialization.Formatters.SR";
+
+        internal static String Serialization_OptionalFieldVersionValue
+        {
+            get
+            {
+                return SR.GetResourceString("Serialization_OptionalFieldVersionValue", null);
+            }
+        }
+		
+		internal static String Serialization_SameNameTwice
+        {
+            get
+            {
+                return SR.GetResourceString("Serialization_SameNameTwice", null);
+            }
+        }
+		
+		internal static String Serialization_NotFound
+        {
+            get
+            {
+                return SR.GetResourceString("Serialization_NotFound", null);
+            }
+        }
+		
+		internal static String InvalidOperation_EnumOpCantHappen
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumOpCantHappen", null);
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
+                return typeof(FxResources.System.Runtime.Serialization.Formatters.SR);
+            }
+        }
+
+        
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
