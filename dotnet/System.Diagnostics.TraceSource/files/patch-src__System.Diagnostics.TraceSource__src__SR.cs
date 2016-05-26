--- /dev/null	2016-03-09 20:00:19.000000000 -0500
+++ src/System.Diagnostics.TraceSource/src/SR.cs	2016-03-09 20:00:39.921683000 -0500
@@ -0,0 +1,214 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Diagnostics.TraceSource
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
+        private const String s_resourcesName = "FxResources.System.Diagnostics.TraceSource.SR";
+
+        internal static String DebugAssertBanner
+        {
+            get
+            {
+                return SR.GetResourceString("DebugAssertBanner", null);
+            }
+        }
+
+        internal static String DebugAssertLongMessage
+        {
+            get
+            {
+                return SR.GetResourceString("DebugAssertLongMessage", null);
+            }
+        }
+
+        internal static String DebugAssertShortMessage
+        {
+            get
+            {
+                return SR.GetResourceString("DebugAssertShortMessage", null);
+            }
+        }
+
+        internal static String DebugAssertTitle
+        {
+            get
+            {
+                return SR.GetResourceString("DebugAssertTitle", null);
+            }
+        }
+
+        internal static String ExceptionOccurred
+        {
+            get
+            {
+                return SR.GetResourceString("ExceptionOccurred", null);
+            }
+        }
+
+        internal static String IndentSize
+        {
+            get
+            {
+                return SR.GetResourceString("IndentSize", null);
+            }
+        }
+
+        internal static String InvalidNullEmptyArgument
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidNullEmptyArgument", null);
+            }
+        }
+
+        internal static String MustAddListener
+        {
+            get
+            {
+                return SR.GetResourceString("MustAddListener", null);
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
+                return typeof(FxResources.System.Diagnostics.TraceSource.SR);
+            }
+        }
+
+        internal static String RTL
+        {
+            get
+            {
+                return SR.GetResourceString("RTL", null);
+            }
+        }
+
+        internal static String TraceListenerFail
+        {
+            get
+            {
+                return SR.GetResourceString("TraceListenerFail", null);
+            }
+        }
+
+        internal static String TraceListenerIndentSize
+        {
+            get
+            {
+                return SR.GetResourceString("TraceListenerIndentSize", null);
+            }
+        }
+
+        internal static String TraceSwitchInvalidLevel
+        {
+            get
+            {
+                return SR.GetResourceString("TraceSwitchInvalidLevel", null);
+            }
+        }
+
+        internal static String TraceSwitchLevelTooHigh
+        {
+            get
+            {
+                return SR.GetResourceString("TraceSwitchLevelTooHigh", null);
+            }
+        }
+
+        internal static String TraceSwitchLevelTooLow
+        {
+            get
+            {
+                return SR.GetResourceString("TraceSwitchLevelTooLow", null);
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
