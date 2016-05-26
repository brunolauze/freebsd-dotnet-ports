--- src/mscorlib/src/System/IO/DriveNotFoundException.cs.orig	2016-04-26 22:33:19.609891000 -0400
+++ src/mscorlib/src/System/IO/DriveNotFoundException.cs	2016-04-26 22:33:36.400962000 -0400
@@ -18,7 +18,7 @@
     //Thrown when trying to access a drive that is not availabe.
     [Serializable]
 [System.Runtime.InteropServices.ComVisible(true)]
-    public class DriveNotFoundException : IOException {
+    internal class DriveNotFoundException : IOException {
         public DriveNotFoundException() 
             : base(Environment.GetResourceString("Arg_DriveNotFoundException")) {
             SetErrorCode(__HResults.COR_E_DIRECTORYNOTFOUND);
