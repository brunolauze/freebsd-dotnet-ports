--- src/Microsoft.AspNetCore.DataProtection/DataProtectionBuilderExtensions.cs.orig	2016-04-30 11:27:50.130951000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/DataProtectionBuilderExtensions.cs	2016-04-30 11:28:48.702996000 -0400
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
 
@@ -543,4 +544,4 @@
             services.Add(descriptor);
         }
     }
-}
\ No newline at end of file
+}
