--- /dev/null	2016-03-09 10:01:51.000000000 -0500
+++ src/System.Runtime.Numerics/src/SR.cs	2016-03-09 10:02:06.455007000 -0500
@@ -0,0 +1,214 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Runtime.Numerics
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
+        private const String s_resourcesName = "FxResources.System.Runtime.Numerics.SR";
+
+        internal static String Argument_BadFormatSpecifier
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_BadFormatSpecifier", null);
+            }
+        }
+
+        internal static String Argument_InvalidHexStyle
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidHexStyle", null);
+            }
+        }
+
+        internal static String Argument_InvalidNumberStyles
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidNumberStyles", null);
+            }
+        }
+
+        internal static String Argument_MustBeBigInt
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_MustBeBigInt", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_MustBeNonNeg
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_MustBeNonNeg", null);
+            }
+        }
+
+        internal static String Format_TooLarge
+        {
+            get
+            {
+                return SR.GetResourceString("Format_TooLarge", null);
+            }
+        }
+
+        internal static String Overflow_BigIntInfinity
+        {
+            get
+            {
+                return SR.GetResourceString("Overflow_BigIntInfinity", null);
+            }
+        }
+
+        internal static String Overflow_Decimal
+        {
+            get
+            {
+                return SR.GetResourceString("Overflow_Decimal", null);
+            }
+        }
+
+        internal static String Overflow_Int32
+        {
+            get
+            {
+                return SR.GetResourceString("Overflow_Int32", null);
+            }
+        }
+
+        internal static String Overflow_Int64
+        {
+            get
+            {
+                return SR.GetResourceString("Overflow_Int64", null);
+            }
+        }
+
+        internal static String Overflow_NotANumber
+        {
+            get
+            {
+                return SR.GetResourceString("Overflow_NotANumber", null);
+            }
+        }
+
+        internal static String Overflow_ParseBigInteger
+        {
+            get
+            {
+                return SR.GetResourceString("Overflow_ParseBigInteger", null);
+            }
+        }
+
+        internal static String Overflow_UInt32
+        {
+            get
+            {
+                return SR.GetResourceString("Overflow_UInt32", null);
+            }
+        }
+
+        internal static String Overflow_UInt64
+        {
+            get
+            {
+                return SR.GetResourceString("Overflow_UInt64", null);
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
+                return typeof(FxResources.System.Runtime.Numerics.SR);
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
