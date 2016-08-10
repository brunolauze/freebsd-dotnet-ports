--- src/Compilers/Shared/CoreClrShim.cs.orig	2016-07-31 21:31:45.663316000 -0400
+++ src/Compilers/Shared/CoreClrShim.cs	2016-07-31 21:33:12.160633000 -0400
@@ -16,7 +16,7 @@
         internal static class AssemblyLoadContext
         {
             internal static readonly Type Type = ReflectionUtilities.TryGetType(
-               "System.Runtime.Loader.AssemblyLoadContext, System.Runtime.Loader, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
+               "System.Runtime.Loader.AssemblyLoadContext, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
         }
 
         internal static class CodePagesEncodingProvider
@@ -24,8 +24,8 @@
             internal static readonly Type Type = ReflectionUtilities.TryGetType(
                 "System.Text.CodePagesEncodingProvider, " +
                 "System.Text.Encoding.CodePages, " +
-                "Version=4.0.0.0, Culture=neutral, " +
-                "PublicKeyToken=b03f5f7f11d50a3a");
+                "Version=1.0.0.0, Culture=neutral, " +
+                "PublicKeyToken=0738eb9f132ed756");
 
             private static PropertyInfo s_instance = Type
                 ?.GetTypeInfo()
