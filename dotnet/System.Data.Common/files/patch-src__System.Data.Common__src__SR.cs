--- src/System.Data.Common/src/SR.cs.orig	2016-04-26 19:24:36.256697000 -0400
+++ src/System.Data.Common/src/SR.cs	2016-04-26 19:24:53.877392000 -0400
@@ -0,0 +1,190 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Data.Common
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
+        private const String s_resourcesName = "FxResources.System.Data.Common.SR";
+
+	internal static string ADP_InvalidSourceBufferIndex
+	{
+		get 
+		{
+			return GetResourceString("ADP_InvalidSourceBufferIndex", null);
+		}
+	}
+	
+	internal static string ADP_InvalidDestinationBufferIndex
+	{
+		get 
+		{
+			return GetResourceString("ADP_InvalidDestinationBufferIndex", null);
+		}
+	}
+	
+	internal static string SQL_InvalidDataLength
+	{
+		get 
+		{
+			return GetResourceString("SQL_InvalidDataLength", null);
+		}
+	}
+	
+	internal static string SQL_InvalidBufferSizeOrIndex
+	{
+		get 
+		{
+			return GetResourceString("SQL_InvalidBufferSizeOrIndex", null);
+		}
+	}
+
+        internal static String ADP_ConnectionStringSyntax
+        {
+            get
+            {
+                return SR.GetResourceString("ADP_ConnectionStringSyntax", null);
+            }
+        }
+
+        internal static String ADP_EmptyString
+        {
+            get
+            {
+                return SR.GetResourceString("ADP_EmptyString", null);
+            }
+        }
+
+        internal static String ADP_InternalProviderError
+        {
+            get
+            {
+                return SR.GetResourceString("ADP_InternalProviderError", null);
+            }
+        }
+
+        internal static String ADP_InvalidKey
+        {
+            get
+            {
+                return SR.GetResourceString("ADP_InvalidKey", null);
+            }
+        }
+
+        internal static String ADP_InvalidValue
+        {
+            get
+            {
+                return SR.GetResourceString("ADP_InvalidValue", null);
+            }
+        }
+
+        internal static String ADP_KeywordNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("ADP_KeywordNotSupported", null);
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
+                return typeof(FxResources.System.Data.Common.SR);
+            }
+        }
+
+        internal static String SqlConvert_ConvertFailed
+        {
+            get
+            {
+                return SR.GetResourceString("SqlConvert_ConvertFailed", null);
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
