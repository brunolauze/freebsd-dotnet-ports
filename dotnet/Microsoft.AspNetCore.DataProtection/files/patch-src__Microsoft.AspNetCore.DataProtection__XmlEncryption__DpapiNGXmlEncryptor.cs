--- src/Microsoft.AspNetCore.DataProtection/XmlEncryption/DpapiNGXmlEncryptor.cs.orig	2016-05-05 10:14:59.000000000 -0400
+++ src/Microsoft.AspNetCore.DataProtection/XmlEncryption/DpapiNGXmlEncryptor.cs	2016-05-09 17:45:06.533542000 -0400
@@ -111,15 +111,18 @@
         /// </summary>
         internal static string GetDefaultProtectionDescriptorString()
         {
-            CryptoUtil.AssertPlatformIsWindows8OrLater();
+	    string result = null;
 
             // Creates a SID=... protection descriptor string for the current user.
             // Reminder: DPAPI:NG provides only encryption, not authentication.
+#if WIN32
             using (WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent())
             {
                 // use the SID to create an SDDL string
-                return Invariant($"SID={currentIdentity.User.Value}");
+                result = $"SID={currentIdentity.User.Value}";
             }
+#endif
+	    return result;
         }
     }
 }
