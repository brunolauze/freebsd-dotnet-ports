--- src/Microsoft.AspNetCore.DataProtection/KeyManagement/XmlKeyManager.cs.orig	2015-12-29 20:11:11.391429000 -0500
+++ src/Microsoft.AspNetCore.DataProtection/KeyManagement/XmlKeyManager.cs	2015-12-29 20:11:52.941155000 -0500
@@ -397,7 +397,7 @@
             var possiblyEncryptedKeyElement = KeyEncryptor?.EncryptIfNecessary(keyElement) ?? keyElement;
 
             // Persist it to the underlying repository and trigger the cancellation token.
-            string friendlyName = Invariant($"key-{keyId:D}");
+            string friendlyName = $"key-{keyId:D}";
             KeyRepository.StoreElement(possiblyEncryptedKeyElement, friendlyName);
             TriggerAndResetCacheExpirationToken();
 
@@ -450,7 +450,7 @@
                 new XElement(ReasonElementName, reason));
 
             // Persist it to the underlying repository and trigger the cancellation token
-            string friendlyName = Invariant($"revocation-{keyId:D}");
+            string friendlyName = $"revocation-{keyId:D}";
             KeyRepository.StoreElement(revocationElement, friendlyName);
             TriggerAndResetCacheExpirationToken();
         }
