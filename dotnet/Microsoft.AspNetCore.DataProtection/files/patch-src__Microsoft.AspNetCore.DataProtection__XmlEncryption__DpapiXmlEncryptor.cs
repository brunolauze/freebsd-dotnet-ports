--- src/Microsoft.AspNetCore.DataProtection/XmlEncryption/DpapiXmlEncryptor.cs.orig	2016-05-09 17:32:57.730257000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/XmlEncryption/DpapiXmlEncryptor.cs	2016-05-09 17:33:35.927357000 -0400
@@ -66,7 +66,9 @@
             }
             else
             {
+#if WIN32
                 _logger?.EncryptingToWindowsDPAPIForCurrentUserAccount(WindowsIdentity.GetCurrent().Name);
+#endif
             }
 
             // Convert the XML element to a binary secret so that it can be run through DPAPI
