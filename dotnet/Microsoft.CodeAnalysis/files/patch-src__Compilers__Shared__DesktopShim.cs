--- src/Compilers/Shared/DesktopShim.cs.orig	2016-07-31 21:28:28.237961000 -0400
+++ src/Compilers/Shared/DesktopShim.cs	2016-07-31 21:29:28.507544000 -0400
@@ -15,7 +15,7 @@
         internal static class FileNotFoundException
         {
             internal static readonly Type Type = ReflectionUtilities.TryGetType(
-               "System.IO.FileNotFoundException, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
+               "System.IO.FileNotFoundException, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
 
             private static PropertyInfo s_fusionLog = Type?.GetTypeInfo().GetDeclaredProperty("FusionLog");
 
