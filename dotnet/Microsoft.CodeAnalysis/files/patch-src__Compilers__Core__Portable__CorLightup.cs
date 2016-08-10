--- src/Compilers/Core/Portable/CorLightup.cs.orig	2016-07-31 21:41:25.600477000 -0400
+++ src/Compilers/Core/Portable/CorLightup.cs	2016-07-31 21:42:28.376736000 -0400
@@ -51,7 +51,7 @@
 
             private static class _RuntimeEnvironment
             {
-                internal static readonly Type TypeOpt = ReflectionUtilities.TryGetType("System.Runtime.InteropServices.RuntimeEnvironment, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
+                internal static readonly Type TypeOpt = ReflectionUtilities.TryGetType("System.Runtime.InteropServices.RuntimeEnvironment, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
 
                 internal static readonly Func<string> GetRuntimeDirectoryOpt = TypeOpt?
                     .GetTypeInfo()
