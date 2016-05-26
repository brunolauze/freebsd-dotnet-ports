--- src/Microsoft.AspNetCore.DataProtection/DataProtectionServiceDescriptors.cs.orig	2016-04-30 11:33:15.272960000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/DataProtectionServiceDescriptors.cs	2016-04-30 11:33:40.211201000 -0400
@@ -175,6 +175,7 @@
             return ServiceDescriptor.Singleton<IXmlRepository>(services => new EphemeralXmlRepository(services));
         }
 
+#if WIN32
         /// <summary>
         /// An <see cref="IXmlRepository"/> backed by the Windows registry.
         /// </summary>
@@ -182,5 +183,6 @@
         {
             return ServiceDescriptor.Singleton<IXmlRepository>(services => new RegistryXmlRepository(registryKey, services));
         }
+#endif
     }
 }
