--- /dev/null	2016-05-21 17:06:50.000000000 -0400
+++ src/System.Security.Cryptography.OpenSsl/src/SR.cs	2016-05-21 17:08:24.590347000 -0400
@@ -0,0 +1,198 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Security.Cryptography.OpenSsl
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
+        private const String s_resourcesName = "FxResources.System.Security.Cryptography.OpenSsl.SR";
+
+	internal static string Cryptography_CurveNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_CurveNotSupported", null);
+            }
+        }
+
+	internal static string Cryptography_InvalidKeySize
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidKeySize", null);
+            }
+        }
+
+        internal static String Cryptography_UnsupportedEcKeyAlgorithm
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_UnsupportedEcKeyAlgorithm", null);
+            }
+        }
+		
+		internal static String Arg_CryptographyException
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_CryptographyException", null);
+            }
+        }
+		
+		internal static String Cryptography_OpenInvalidHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_OpenInvalidHandle", null);
+            }
+        }
+		
+		internal static String Cryptography_UnknownHashAlgorithm
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_UnknownHashAlgorithm", null);
+            }
+        }
+		
+		internal static String Argument_InvalidOidValue
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidOidValue", null);
+            }
+        }
+		
+		internal static String Cryptography_Invalid_IA5String
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_Invalid_IA5String", null);
+            }
+        }
+		
+		internal static String Cryptography_CSP_NoPrivateKey
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_CSP_NoPrivateKey", null);
+            }
+        }
+		
+		internal static String Argument_InvalidValue
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidValue", null);
+            }
+        }
+		
+		internal static String Cryptography_InvalidPaddingMode
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidPaddingMode", null);
+            }
+        }
+		
+		internal static String Cryptography_HashAlgorithmNameNullOrEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_HashAlgorithmNameNullOrEmpty", null);
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
+                return typeof(FxResources.System.Security.Cryptography.OpenSsl.SR);
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
