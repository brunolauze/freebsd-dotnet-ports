--- /dev/null	2016-05-28 11:25:55.000000000 -0400
+++ src/System.Security.Cryptography.Algorithms/src/SR.cs	2016-05-28 11:27:07.851827000 -0400
@@ -0,0 +1,431 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Security.Cryptography.Algorithms
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
+        private const String s_resourcesName = "FxResources.System.Security.Cryptography.Algorithms.SR";
+
+	internal static string Argument_InvalidOidValue
+	{
+                get
+                {
+                        return SR.GetResourceString("Argument_InvalidOidValue", null);
+                }
+	}
+
+	internal static string Arg_CryptographyException
+	{
+		get
+		{
+			return SR.GetResourceString("Arg_CryptographyException", null);
+		}
+	}
+
+	internal static string Cryptography_Invalid_IA5String
+        {
+                get
+                {
+                        return SR.GetResourceString("Cryptography_Invalid_IA5String", null);
+                }
+        }
+
+	internal static string Cryptography_CurveNotSupported
+	{
+                get
+                {
+                        return SR.GetResourceString("Cryptography_CurveNotSupported", null);
+                }
+	}
+
+
+	internal static string Cryptography_InvalidCurveKeyParameters
+	{
+		get
+		{
+			return SR.GetResourceString("Cryptography_InvalidCurveKeyParameters", null);
+		}
+	}
+
+	internal static string NotSupported_SubclassOverride
+	{
+		get
+		{
+			return SR.GetResourceString("NotSupported_SubclassOverride", null);
+		}
+	}
+
+	internal static string Cryptography_InvalidCurveOid
+	{
+		get
+		{
+			return SR.GetResourceString("Cryptography_InvalidCurveOid", null);
+		}
+	}
+
+	internal static string Cryptography_InvalidECNamedCurve
+	{
+		get
+		{
+			return SR.GetResourceString("Cryptography_InvalidECNamedCurve", null);
+		}
+	}
+
+	internal static string Cryptography_InvalidECPrimeCurve
+	{
+		get
+		{
+			return SR.GetResourceString("Cryptography_InvalidECPrimeCurve", null);
+		}
+	}
+
+	internal static string Cryptography_InvalidECCharacteristic2Curve
+	{
+		get
+		{
+			return SR.GetResourceString("Cryptography_InvalidECCharacteristic2Curve", null);
+		}
+	}
+
+	internal static string Cryptography_InvalidCurve
+	{
+		get
+		{
+			return SR.GetResourceString("Cryptography_InvalidCurve", null);
+		}
+	}
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
+        internal static String ArgumentNull_Buffer
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentNull_Buffer", null);
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
+        internal static String ArgumentOutOfRange_NeedPosNum
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_NeedPosNum", null);
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
+        internal static String Cryptography_HashAlgorithmNameNullOrEmpty
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_HashAlgorithmNameNullOrEmpty", null);
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
+        internal static String Cryptography_InvalidKey_SemiWeak
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidKey_SemiWeak", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidKey_Weak
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidKey_Weak", null);
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
+        internal static String Cryptography_InvalidPadding
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidPadding", null);
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
+        internal static String Cryptography_InvalidRsaParameters
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidRsaParameters", null);
+            }
+        }
+
+        internal static String Cryptography_MissingIV
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_MissingIV", null);
+            }
+        }
+
+        internal static String Cryptography_MustTransformWholeBlock
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_MustTransformWholeBlock", null);
+            }
+        }
+
+        internal static String Cryptography_NotValidPrivateKey
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_NotValidPrivateKey", null);
+            }
+        }
+
+        internal static String Cryptography_NotValidPublicOrPrivateKey
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_NotValidPublicOrPrivateKey", null);
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
+        internal static String Cryptography_PartialBlock
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_PartialBlock", null);
+            }
+        }
+
+        internal static String Cryptography_PasswordDerivedBytes_FewBytesSalt
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_PasswordDerivedBytes_FewBytesSalt", null);
+            }
+        }
+
+        internal static String Cryptography_PasswordDerivedBytes_InvalidAlgorithm
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_PasswordDerivedBytes_InvalidAlgorithm", null);
+            }
+        }
+
+        internal static String Cryptography_PasswordDerivedBytes_InvalidIV
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_PasswordDerivedBytes_InvalidIV", null);
+            }
+        }
+
+        internal static String Cryptography_RC2_EKS40
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_RC2_EKS40", null);
+            }
+        }
+
+        internal static String Cryptography_RC2_EKSKS
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_RC2_EKSKS", null);
+            }
+        }
+
+        internal static String Cryptography_TransformBeyondEndOfBuffer
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_TransformBeyondEndOfBuffer", null);
+            }
+        }
+
+        internal static String Cryptography_UnexpectedTransformTruncation
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_UnexpectedTransformTruncation", null);
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
+        internal static String Cryptography_UnknownPaddingMode
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_UnknownPaddingMode", null);
+            }
+        }
+
+        internal static String Cryptography_UnsupportedPaddingMode
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_UnsupportedPaddingMode", null);
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
+                return typeof(FxResources.System.Security.Cryptography.Algorithms.SR);
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
