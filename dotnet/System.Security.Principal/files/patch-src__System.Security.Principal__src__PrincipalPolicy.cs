--- /dev/null	2016-05-11 17:55:00.000000000 -0400
+++ src/System.Security.Principal/src/PrincipalPolicy.cs	2016-05-11 17:56:35.215556000 -0400
@@ -0,0 +1,29 @@
+using System.Runtime.InteropServices;
+
+namespace System.Security.Principal
+{
+    //
+    // Summary:
+    //     Specifies how principal and identity objects should be created for an application
+    //     domain. The default is UnauthenticatedPrincipal.
+    public enum PrincipalPolicy
+    {
+        //
+        // Summary:
+        //     Principal and identity objects for the unauthenticated entity should be created.
+        //     An unauthenticated entity has System.Security.Principal.GenericIdentity.Name
+        //     set to the empty string ("") and System.Security.Principal.GenericIdentity.IsAuthenticated
+        //     set to false.
+        UnauthenticatedPrincipal = 0,
+        //
+        // Summary:
+        //     No principal or identity objects should be created.
+        NoPrincipal = 1,
+        //
+        // Summary:
+        //     Principal and identity objects that reflect the operating system token associated
+        //     with the current execution thread should be created, and the associated operating
+        //     system groups should be mapped into roles.
+        WindowsPrincipal = 2
+    }
+}
