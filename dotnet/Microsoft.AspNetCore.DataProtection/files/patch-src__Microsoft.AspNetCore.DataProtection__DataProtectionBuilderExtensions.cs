--- src/Microsoft.AspNetCore.DataProtection/DataProtectionBuilderExtensions.cs.orig	2016-08-09 17:57:36.000000000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/DataProtectionBuilderExtensions.cs	2016-08-13 12:33:10.240233000 -0400
@@ -185,7 +185,7 @@
             Use(builder.Services, DataProtectionServiceDescriptors.IXmlRepository_FileSystem(directory));
             return builder;
         }
-
+#if WIN32
         /// <summary>
         /// Configures the data protection system to persist keys to the Windows registry.
         /// </summary>
@@ -207,6 +207,7 @@
             Use(builder.Services, DataProtectionServiceDescriptors.IXmlRepository_Registry(registryKey));
             return builder;
         }
+#endif
 
 #if !NETSTANDARD1_3 // [[ISSUE60]] Remove this #ifdef when Core CLR gets support for EncryptedXml
 
@@ -267,6 +268,7 @@
 
 #endif
 
+#if WIN32
         /// <summary>
         /// Configures keys to be encrypted with Windows DPAPI before being persisted to
         /// storage. The encrypted key will only be decryptable by the current Windows user account.
@@ -361,6 +363,7 @@
             Use(builder.Services, DataProtectionServiceDescriptors.IXmlEncryptor_DpapiNG(protectionDescriptorRule, flags));
             return builder;
         }
+#endif
 
         /// <summary>
         /// Sets the default lifetime of keys created by the data protection system.
@@ -543,4 +546,4 @@
             services.Add(descriptor);
         }
     }
-}
\ No newline at end of file
+}
