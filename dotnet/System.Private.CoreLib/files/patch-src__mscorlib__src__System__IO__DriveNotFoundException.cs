--- src/mscorlib/src/System/IO/DriveNotFoundException.cs.orig	2016-07-20 17:32:41.354754000 -0400
+++ src/mscorlib/src/System/IO/DriveNotFoundException.cs	2016-07-20 17:32:52.416751000 -0400
@@ -20,7 +20,7 @@
     [Serializable]
 #endif
     [System.Runtime.InteropServices.ComVisible(true)]
-    public class DriveNotFoundException : IOException {
+    internal class DriveNotFoundException : IOException {
         public DriveNotFoundException() 
             : base(Environment.GetResourceString("Arg_DriveNotFoundException")) {
             SetErrorCode(__HResults.COR_E_DIRECTORYNOTFOUND);
