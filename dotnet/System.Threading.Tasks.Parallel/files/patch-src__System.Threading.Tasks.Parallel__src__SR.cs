--- /dev/null	2016-05-09 06:38:09.000000000 -0400
+++ src/System.Threading.Tasks.Parallel/src/SR.cs	2016-05-09 06:38:27.759255000 -0400
@@ -0,0 +1,166 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Threading.Tasks.Parallel
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
+        private const String s_resourcesName = "FxResources.System.Threading.Tasks.Parallel.SR";
+
+        internal static String Parallel_ForEach_NullEnumerator
+        {
+            get
+            {
+                return SR.GetResourceString("Parallel_ForEach_NullEnumerator", null);
+            }
+        }
+
+        internal static String Parallel_ForEach_OrderedPartitionerKeysNotNormalized
+        {
+            get
+            {
+                return SR.GetResourceString("Parallel_ForEach_OrderedPartitionerKeysNotNormalized", null);
+            }
+        }
+
+        internal static String Parallel_ForEach_PartitionerNotDynamic
+        {
+            get
+            {
+                return SR.GetResourceString("Parallel_ForEach_PartitionerNotDynamic", null);
+            }
+        }
+
+        internal static String Parallel_ForEach_PartitionerReturnedNull
+        {
+            get
+            {
+                return SR.GetResourceString("Parallel_ForEach_PartitionerReturnedNull", null);
+            }
+        }
+
+        internal static String Parallel_Invoke_ActionNull
+        {
+            get
+            {
+                return SR.GetResourceString("Parallel_Invoke_ActionNull", null);
+            }
+        }
+
+        internal static String ParallelState_Break_InvalidOperationException_BreakAfterStop
+        {
+            get
+            {
+                return SR.GetResourceString("ParallelState_Break_InvalidOperationException_BreakAfterStop", null);
+            }
+        }
+
+        internal static String ParallelState_NotSupportedException_UnsupportedMethod
+        {
+            get
+            {
+                return SR.GetResourceString("ParallelState_NotSupportedException_UnsupportedMethod", null);
+            }
+        }
+
+        internal static String ParallelState_Stop_InvalidOperationException_StopAfterBreak
+        {
+            get
+            {
+                return SR.GetResourceString("ParallelState_Stop_InvalidOperationException_StopAfterBreak", null);
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
+                return typeof(FxResources.System.Threading.Tasks.Parallel.SR);
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
