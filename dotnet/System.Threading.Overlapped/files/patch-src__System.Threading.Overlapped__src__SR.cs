--- /dev/null	2016-03-10 16:28:10.000000000 -0500
+++ src/System.Threading.Overlapped/src/SR.cs	2016-03-10 16:28:32.213695000 -0500
@@ -0,0 +1,150 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Threading.Overlapped
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
+        private const string s_resourcesName = "FxResources.System.Threading.Overlapped.SR";
+
+        internal static string Argument_AlreadyBoundOrSyncHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AlreadyBoundOrSyncHandle", null);
+            }
+        }
+
+        internal static string Argument_InvalidHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidHandle", null);
+            }
+        }
+
+        internal static string Argument_NativeOverlappedAlreadyFree
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NativeOverlappedAlreadyFree", null);
+            }
+        }
+
+        internal static string Argument_NativeOverlappedWrongBoundHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_NativeOverlappedWrongBoundHandle", null);
+            }
+        }
+
+        internal static string Argument_PreAllocatedAlreadyAllocated
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_PreAllocatedAlreadyAllocated", null);
+            }
+        }
+
+        internal static string InvalidOperation_NativeOverlappedReused
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_NativeOverlappedReused", null);
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
+                return typeof(FxResources.System.Threading.Overlapped.SR);
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
