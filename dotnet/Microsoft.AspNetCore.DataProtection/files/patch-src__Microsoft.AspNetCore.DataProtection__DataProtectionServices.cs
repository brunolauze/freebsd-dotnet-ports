--- src/Microsoft.AspNetCore.DataProtection/DataProtectionServices.cs.orig	2016-08-09 17:57:36.000000000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/DataProtectionServices.cs	2016-08-14 10:08:56.229566000 -0400
@@ -57,12 +57,14 @@
                     var localAppDataKeysFolder = FileSystemXmlRepository.DefaultKeyStorageDirectory;
                     if (localAppDataKeysFolder != null)
                     {
+#if WIN32
                         if (OSVersionUtil.IsWindows())
                         {
                             // If the user profile is available, we can protect using DPAPI.
                             // Probe to see if protecting to local user is available, and use it as the default if so.
                             keyEncryptorDescriptor = DataProtectionServiceDescriptors.IXmlEncryptor_Dpapi(protectToMachine: !DpapiSecretSerializerHelper.CanProtectToCurrentUserAccount());
                         }
+#endif
                         keyRepositoryDescriptor = DataProtectionServiceDescriptors.IXmlRepository_FileSystem(localAppDataKeysFolder);
 
                         if (keyEncryptorDescriptor != null)
@@ -76,6 +78,7 @@
                     }
                     else
                     {
+#if WIN32
                         // Use profile isn't available - can we use the HKLM registry?
                         RegistryKey regKeyStorageKey = null;
                         if (OSVersionUtil.IsWindows())
@@ -99,6 +102,10 @@
 
                             log?.UsingEphemeralKeyRepository();
                         }
+#else
+			log?.UsingEphemeralKeyRepository();
+#endif
+
                     }
                 }
 
@@ -130,7 +137,7 @@
                     options.ApplicationDiscriminator = services.GetApplicationUniqueIdentifier();
                 });
             });
-
+#if WIN32
             // Read and apply policy from the registry, overriding any other defaults.
             var encryptorConfigurationReadFromRegistry = false;
             if (OSVersionUtil.IsWindows())
@@ -144,13 +151,16 @@
                     }
                 }
             }
-
             // Finally, provide a fallback encryptor configuration if one wasn't already specified.
             if (!encryptorConfigurationReadFromRegistry)
             {
                 yield return DataProtectionServiceDescriptors.IAuthenticatedEncryptorConfiguration_FromSettings(
                     new AuthenticatedEncryptionSettings());;
             }
+#else 
+	    yield return DataProtectionServiceDescriptors.IAuthenticatedEncryptorConfiguration_FromSettings(
+                    new AuthenticatedEncryptionSettings());
+#endif
         }
     }
 }
