--- src/Microsoft.AspNetCore.DataProtection/DataProtectionServices.cs.orig	2016-04-30 11:30:41.543856000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/DataProtectionServices.cs	2016-04-30 11:37:14.886413000 -0400
@@ -74,6 +74,7 @@
                     }
                     else
                     {
+#if WIN32
                         // Use profile isn't available - can we use the HKLM registry?
                         RegistryKey regKeyStorageKey = null;
                         if (OSVersionUtil.IsWindows())
@@ -96,6 +97,10 @@
 
                             log?.UsingEphemeralKeyRepository();
                         }
+#else
+			log?.UsingEphemeralKeyRepository();
+#endif
+
                     }
                 }
 
@@ -119,6 +124,7 @@
 
             // Read and apply policy from the registry, overriding any other defaults.
             bool encryptorConfigurationReadFromRegistry = false;
+#if WIN32
             if (OSVersionUtil.IsWindows())
             {
                 foreach (var descriptor in RegistryPolicyResolver.ResolveDefaultPolicy())
@@ -130,7 +136,7 @@
                     }
                 }
             }
-
+#endif
             // Finally, provide a fallback encryptor configuration if one wasn't already specified.
             if (!encryptorConfigurationReadFromRegistry)
             {
