--- /dev/null	2016-03-09 13:51:58.000000000 -0500
+++ src/System.Net.WebSockets/src/SR.cs	2016-03-09 13:53:41.160143000 -0500
@@ -0,0 +1,182 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Net.WebSockets
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
+        private const String s_resourcesName = "FxResources.System.Net.WebSockets.SR";
+
+        internal static String net_WebSockets_ConnectionClosedPrematurely_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_ConnectionClosedPrematurely_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_HeaderError_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_HeaderError_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidMessageType_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidMessageType_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidState
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidState", null);
+            }
+        }
+
+        internal static String net_WebSockets_InvalidState_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_InvalidState_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_NotAWebSocket_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_NotAWebSocket_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_UnsupportedProtocol_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_UnsupportedProtocol_Generic", null);
+            }
+        }
+
+        internal static String net_WebSockets_UnsupportedWebSocketVersion_Generic
+        {
+            get
+            {
+                return SR.GetResourceString("net_WebSockets_UnsupportedWebSocketVersion_Generic", null);
+            }
+        }
+
+        internal static String net_Websockets_WebSocketBaseFaulted
+        {
+            get
+            {
+                return SR.GetResourceString("net_Websockets_WebSocketBaseFaulted", null);
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
+                return typeof(FxResources.System.Net.WebSockets.SR);
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
