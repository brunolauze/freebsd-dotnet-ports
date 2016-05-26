--- /dev/null	2016-03-09 09:11:00.000000000 -0500
+++ src/System.Security.Cryptography.Csp/src/SR.cs	2016-03-09 09:11:01.959000000 -0500
@@ -0,0 +1,382 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Security.Cryptography.Csp
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
+        private const String s_resourcesName = "FxResources.System.Security.Cryptography.Csp.SR";
+
+        internal static String Arg_CryptographyException
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_CryptographyException", null);
+            }
+        }
+
+        internal static String Arg_EnumIllegalVal
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_EnumIllegalVal", null);
+            }
+        }
+
+        internal static String Argument_InvalidOffLen
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidOffLen", null);
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
+        internal static String Argument_StreamNotReadable
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_StreamNotReadable", null);
+            }
+        }
+
+        internal static String Argument_StreamNotWritable
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_StreamNotWritable", null);
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
+        internal static String CryptDecrypt_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("CryptDecrypt_Failed", null);
+            }
+        }
+
+        internal static String CryptEncrypt_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("CryptEncrypt_Failed", null);
+            }
+        }
+
+        internal static String CryptExportKey_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("CryptExportKey_Failed", null);
+            }
+        }
+
+        internal static String CryptGenKey_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("CryptGenKey_Failed", null);
+            }
+        }
+
+        internal static String CryptGetDefaultProvider_Fail
+        {
+            get
+            {
+                return SR.GetResourceString("CryptGetDefaultProvider_Fail", null);
+            }
+        }
+
+        internal static String CryptGetKeyParam_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("CryptGetKeyParam_Failed", null);
+            }
+        }
+
+        internal static String CryptGetProvParam_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("CryptGetProvParam_Failed", null);
+            }
+        }
+
+        internal static String CryptGetUserKey_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("CryptGetUserKey_Failed", null);
+            }
+        }
+
+        internal static String Cryptography_CryptoStream_FlushFinalBlockTwice
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_CryptoStream_FlushFinalBlockTwice", null);
+            }
+        }
+
+        internal static String Cryptography_CSP_NoPrivateKey
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_CSP_NoPrivateKey", null);
+            }
+        }
+
+        internal static String Cryptography_CSP_NotFound
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_CSP_NotFound", null);
+            }
+        }
+
+        internal static String Cryptography_CSP_WrongKeySpec
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_CSP_WrongKeySpec", null);
+            }
+        }
+
+        internal static String Cryptography_HashAlgorithmNameNullOrEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_HashAlgorithmNameNullOrEmpty", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidBlockSize
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidBlockSize", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidCipherMode
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidCipherMode", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidFeedbackSize
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidFeedbackSize", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidIVSize
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidIVSize", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidKeySize
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidKeySize", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidOID
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidOID", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidPaddingMode
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidPaddingMode", null);
+            }
+        }
+
+        internal static String Cryptography_OpenInvalidHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_OpenInvalidHandle", null);
+            }
+        }
+
+        internal static String Cryptography_Padding_DecDataTooBig
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_Padding_DecDataTooBig", null);
+            }
+        }
+
+        internal static String Cryptography_UnknownHashAlgorithm
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_UnknownHashAlgorithm", null);
+            }
+        }
+
+        internal static String CspParameter_invalid
+        {
+            get
+            {
+                return SR.GetResourceString("CspParameter_invalid", null);
+            }
+        }
+
+        internal static String NotSupported_UnreadableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnreadableStream", null);
+            }
+        }
+
+        internal static String NotSupported_UnseekableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnseekableStream", null);
+            }
+        }
+
+        internal static String NotSupported_UnwritableStream
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_UnwritableStream", null);
+            }
+        }
+
+        internal static String OpenCSP_Failed
+        {
+            get
+            {
+                return SR.GetResourceString("OpenCSP_Failed", null);
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
+                return typeof(FxResources.System.Security.Cryptography.Csp.SR);
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
