--- src/System.Security.Cryptography.X509Certificates/src/SR.cs.orig	2016-04-22 17:41:49.480586000 -0400
+++ src/System.Security.Cryptography.X509Certificates/src/SR.cs	2016-04-22 17:46:21.956653000 -0400
@@ -0,0 +1,502 @@
+using System;
+using System.Resources;
+
+namespace FxResources.System.Security.Cryptography.X509Certificates
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
+        private const String s_resourcesName = "FxResources.System.Security.Cryptography.X509Certificates.SR";
+
+	internal static String Cryptography_InvalidFilePermissions
+	{
+	    get
+	    {
+		return SR.GetResourceString("Cryptography_InvalidFilePermissions", null);
+	    }
+	}
+
+        internal static String Arg_EmptyOrNullArray
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_EmptyOrNullArray", null);
+            }
+        }
+
+        internal static String Arg_EmptyOrNullString
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_EmptyOrNullString", null);
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
+        internal static String Arg_InvalidHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_InvalidHandle", null);
+            }
+        }
+
+        internal static String Arg_OutOfRange_NeedNonNegNum
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_OutOfRange_NeedNonNegNum", null);
+            }
+        }
+
+        internal static String Arg_RankMultiDimNotSupported
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_RankMultiDimNotSupported", null);
+            }
+        }
+
+        internal static String Arg_RemoveArgNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("Arg_RemoveArgNotFound", null);
+            }
+        }
+
+        internal static String Argument_InvalidFlag
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidFlag", null);
+            }
+        }
+
+        internal static String Argument_InvalidNameType
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidNameType", null);
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
+        internal static String Argument_InvalidOidValue
+        {
+            get
+            {
+                return SR.GetResourceString("Argument_InvalidOidValue", null);
+            }
+        }
+
+        internal static String ArgumentOutOfRange_Index
+        {
+            get
+            {
+                return SR.GetResourceString("ArgumentOutOfRange_Index", null);
+            }
+        }
+
+        internal static String Chain_NoPolicyMatch
+        {
+            get
+            {
+                return SR.GetResourceString("Chain_NoPolicyMatch", null);
+            }
+        }
+
+        internal static String Cryptography_FileStatusError
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_FileStatusError", null);
+            }
+        }
+
+        internal static String Cryptography_InsufficientFilePermissions
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InsufficientFilePermissions", null);
+            }
+        }
+
+        internal static String Cryptography_Invalid_IA5String
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_Invalid_IA5String", null);
+            }
+        }
+
+        internal static String Cryptography_Invalid_X500Name
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_Invalid_X500Name", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidContextHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidContextHandle", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidDirectoryPermissions
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidDirectoryPermissions", null);
+            }
+        }
+
+        internal static String Cryptography_InvalidHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidHandle", null);
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
+        internal static String Cryptography_InvalidStoreHandle
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_InvalidStoreHandle", null);
+            }
+        }
+
+        internal static String Cryptography_OwnerNotCurrentUser
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_OwnerNotCurrentUser", null);
+            }
+        }
+
+        internal static String Cryptography_TooBroadFilePermissions
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_TooBroadFilePermissions", null);
+            }
+        }
+
+        internal static String Cryptography_Unix_X509_MachineStoresReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_Unix_X509_MachineStoresReadOnly", null);
+            }
+        }
+
+        internal static String Cryptography_Unix_X509_MachineStoresRootOnly
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_Unix_X509_MachineStoresRootOnly", null);
+            }
+        }
+
+        internal static String Cryptography_Unix_X509_PropertyNotSettable
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_Unix_X509_PropertyNotSettable", null);
+            }
+        }
+
+        internal static String Cryptography_Unix_X509_SerializedExport
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_Unix_X509_SerializedExport", null);
+            }
+        }
+
+        internal static String Cryptography_X509_ExportFailed
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_ExportFailed", null);
+            }
+        }
+
+        internal static String Cryptography_X509_ExtensionMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_ExtensionMismatch", null);
+            }
+        }
+
+        internal static String Cryptography_X509_InvalidContentType
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_InvalidContentType", null);
+            }
+        }
+
+        internal static String Cryptography_X509_InvalidFindType
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_InvalidFindType", null);
+            }
+        }
+
+        internal static String Cryptography_X509_InvalidFindValue
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_InvalidFindValue", null);
+            }
+        }
+
+        internal static String Cryptography_X509_KeyMismatch
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_KeyMismatch", null);
+            }
+        }
+
+        internal static String Cryptography_X509_PKCS7_NoSigner
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_PKCS7_NoSigner", null);
+            }
+        }
+
+        internal static String Cryptography_X509_StoreNoFileAvailable
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_StoreNoFileAvailable", null);
+            }
+        }
+
+        internal static String Cryptography_X509_StoreNotFound
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_StoreNotFound", null);
+            }
+        }
+
+        internal static String Cryptography_X509_StoreNotOpen
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_StoreNotOpen", null);
+            }
+        }
+
+        internal static String Cryptography_X509_StoreReadOnly
+        {
+            get
+            {
+                return SR.GetResourceString("Cryptography_X509_StoreReadOnly", null);
+            }
+        }
+
+        internal static String InvalidOperation_EnumNotStarted
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidOperation_EnumNotStarted", null);
+            }
+        }
+
+        internal static String InvalidPublicKeyInX509
+        {
+            get
+            {
+                return SR.GetResourceString("InvalidPublicKeyInX509", null);
+            }
+        }
+
+        internal static String NotSupported_ECDsa_Csp
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_ECDsa_Csp", null);
+            }
+        }
+
+        internal static String NotSupported_Export_MultiplePrivateCerts
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_Export_MultiplePrivateCerts", null);
+            }
+        }
+
+        internal static String NotSupported_InvalidKeyImpl
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_InvalidKeyImpl", null);
+            }
+        }
+
+        internal static String NotSupported_KeyAlgorithm
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_KeyAlgorithm", null);
+            }
+        }
+
+        internal static String NotSupported_LegacyBasicConstraints
+        {
+            get
+            {
+                return SR.GetResourceString("NotSupported_LegacyBasicConstraints", null);
+            }
+        }
+
+        internal static String PersistedFiles_NoHomeDirectory
+        {
+            get
+            {
+                return SR.GetResourceString("PersistedFiles_NoHomeDirectory", null);
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
+                return typeof(FxResources.System.Security.Cryptography.X509Certificates.SR);
+            }
+        }
+
+        internal static String Security_InvalidValue
+        {
+            get
+            {
+                return SR.GetResourceString("Security_InvalidValue", null);
+            }
+        }
+
+        internal static String Unknown_Error
+        {
+            get
+            {
+                return SR.GetResourceString("Unknown_Error", null);
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
