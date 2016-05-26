--- src/System.Collections.Specialized/src/SR.cs.orig	2016-05-07 09:12:27.062580000 -0400
+++ src/System.Collections.Specialized/src/SR.cs	2016-05-07 09:13:14.365380000 -0400
@@ -0,0 +1,192 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Collections.Specialized
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
+        private const String s_resourcesName = "FxResources.System.Collections.Specialized.SR";
+
+	internal static string Arg_NonZeroLowerBound
+	{
+	    get
+	    {
+		return SR.GetResourceString("Arg_NonZeroLowerBound", null);
+	    }
+	}
+
+        internal static String Arg_InsufficientSpace
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InsufficientSpace", null);
+            }
+        }
+
+        internal static String Arg_MultiRank
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_MultiRank", null);
+            }
+        }
+
+        internal static String Argument_AddingDuplicate
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_AddingDuplicate", null);
+            }
+        }
+
+        internal static String Argument_InvalidValue
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidValue", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_NeedNonNegNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNum", null);
+            }
+        }
+
+        internal static String BitVectorFull
+        {
+            get
+            {
+                return SR.GetResourceString("BitVectorFull", null);
+            }
+        }
+
+        internal static String CollectionReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("CollectionReadOnly", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumFailedVersion
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumFailedVersion", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumOpCantHappen
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumOpCantHappen", null);
+            }
+        }
+
+        internal static String OrderedDictionary_ReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("OrderedDictionary_ReadOnly", null);
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
+                return typeof(FxResources.System.Collections.Specialized.SR);
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
+
+
