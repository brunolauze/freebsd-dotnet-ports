--- src/Microsoft.AspNetCore.DataProtection/DataProtectionServiceDescriptors.cs.orig	2016-08-09 17:57:36.000000000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/DataProtectionServiceDescriptors.cs	2016-08-13 12:37:32.655145000 -0400
@@ -99,6 +99,7 @@
 
 #endif
 
+#if WIN32
         /// <summary>
         /// An <see cref="IXmlEncryptor"/> backed by DPAPI.
         /// </summary>
@@ -116,6 +117,7 @@
             CryptoUtil.AssertPlatformIsWindows8OrLater();
             return ServiceDescriptor.Singleton<IXmlEncryptor>(services => new DpapiNGXmlEncryptor(protectionDescriptorRule, flags, services));
         }
+#endif
 
         /// <summary>
         /// An <see cref="IXmlRepository"/> backed by a file system.
@@ -125,6 +127,7 @@
             return ServiceDescriptor.Singleton<IXmlRepository>(services => new FileSystemXmlRepository(directory, services));
         }
 
+#if WIN32
         /// <summary>
         /// An <see cref="IXmlRepository"/> backed by the Windows registry.
         /// </summary>
@@ -132,5 +135,6 @@
         {
             return ServiceDescriptor.Singleton<IXmlRepository>(services => new RegistryXmlRepository(registryKey, services));
         }
+#endif
     }
 }
