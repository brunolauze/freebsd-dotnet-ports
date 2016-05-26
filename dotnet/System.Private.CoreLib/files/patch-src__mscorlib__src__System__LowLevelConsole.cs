--- src/mscorlib/src/System/LowLevelConsole.cs.orig	2016-04-25 22:29:52.986273000 -0400
+++ src/mscorlib/src/System/LowLevelConsole.cs	2016-04-25 22:30:14.000222000 -0400
@@ -14,7 +14,7 @@
     // and low-level tests that just want to depend on mscorlib.
     //
 
-    public static class Console
+    internal static class Console
     {
         [SecurityCritical]
         static SafeFileHandle _outputHandle;
