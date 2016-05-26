--- /dev/null	2016-03-04 10:44:00.000000000 -0500
+++ src/System.Buffers/src/System/Buffers/SR.cs	2016-03-04 10:53:47.960579000 -0500
@@ -0,0 +1,142 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Buffers
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
+        private const String s_resourcesName = "FxResources.System.Buffers.SR";
+
+        internal static String ArgumentException_BufferNotFromPool
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentException_BufferNotFromPool", null);
+            }
+        }
+
+        internal static String event_BucketExhausted
+        {
+            get
+            {
+                return SR.GetResourceString("event_BucketExhausted", null);
+            }
+        }
+
+        internal static String event_BufferAllocated
+        {
+            get
+            {
+                return SR.GetResourceString("event_BufferAllocated", null);
+            }
+        }
+
+        internal static String event_BufferRented
+        {
+            get
+            {
+                return SR.GetResourceString("event_BufferRented", null);
+            }
+        }
+
+        internal static String event_BufferReturned
+        {
+            get
+            {
+                return SR.GetResourceString("event_BufferReturned", null);
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
+                return typeof(FxResources.System.Buffers.SR);
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
