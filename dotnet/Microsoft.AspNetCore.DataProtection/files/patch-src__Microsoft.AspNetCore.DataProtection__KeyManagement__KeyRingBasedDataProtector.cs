--- src/Microsoft.AspNetCore.DataProtection/KeyManagement/KeyRingBasedDataProtector.cs.orig	2015-12-29 20:09:28.082046000 -0500
+++ src/Microsoft.AspNetCore.DataProtection/KeyManagement/KeyRingBasedDataProtector.cs	2015-12-29 20:10:43.397530000 -0500
@@ -154,7 +154,7 @@
         {
             Debug.Assert((long)ptr % 4 == 0);
 
-            Guid retVal;
+            Guid retVal = Guid.Empty;
             ((int*)&retVal)[0] = ((int*)ptr)[0];
             ((int*)&retVal)[1] = ((int*)ptr)[1];
             ((int*)&retVal)[2] = ((int*)ptr)[2];
