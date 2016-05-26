--- src/Compilers/Core/Portable/PortableShim.cs.orig	2016-05-25 19:54:20.000000000 -0400
+++ src/Compilers/Core/Portable/PortableShim.cs	2016-05-25 23:05:32.558396000 -0400
@@ -75,18 +75,17 @@
 
         private static class CoreNames
         {
-            internal const string System_Diagnostics_FileVersionInfo = "System.Diagnostics.FileVersionInfo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Diagnostics_StackTrace = "System.Diagnostics.StackTrace, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Diagnostics_Process = "System.Diagnostics.Process, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_IO_FileSystem = "System.IO.FileSystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_IO_FileSystem_Primitives = "System.IO.FileSystem.Primitives, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Reflection = "System.Reflection, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Runtime = "System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Runtime_Extensions = "System.Runtime.Extensions, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Security_Cryptography_Primitives = "System.Security.Cryptography.Primitives, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Security_Cryptography_Algorithms = "System.Security.Cryptography.Algorithms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Threading_Thread = "System.Threading.Thread, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
-            internal const string System_Xml_XPath_XDocument = "System.Xml.XPath.XDocument, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
+            internal const string System_Diagnostics_FileVersionInfo = "System.Diagnostics.FileVersionInfo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Diagnostics_StackTrace = "System.Diagnostics.StackTrace, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Diagnostics_Process = "System.Diagnostics.Process, Version=4.1.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_IO_FileSystem = "System.IO.FileSystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Reflection = "System.Reflection, Version=4.0.10.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Runtime = "System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Runtime_Extensions = "System.Runtime.Extensions, Version=4.0.10.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Security_Cryptography_Primitives = "System.Security.Cryptography.Primitives, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Security_Cryptography_Algorithms = "System.Security.Cryptography.Algorithms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Threading_Thread = "System.Threading.Thread, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
+            internal const string System_Xml_XPath_XDocument = "System.Xml.XPath.XDocument, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
         }
 
         private static class DesktopNames
@@ -147,7 +146,7 @@
             private const string TypeName = "System.IO.FileAttributes";
 
             internal static readonly Type Type = ReflectionUtilities.GetTypeFromEither(
-               contractName: $"{TypeName}, {CoreNames.System_IO_FileSystem_Primitives}",
+               contractName: $"{TypeName}, {CoreNames.System_IO_FileSystem}",
                desktopName: TypeName);
 
             public static object Hidden = Enum.ToObject(Type, 2);
@@ -248,7 +247,7 @@
             internal const string TypeName = "System.IO.FileMode";
 
             internal static readonly Type Type = ReflectionUtilities.GetTypeFromEither(
-                contractName: $"{TypeName}, {CoreNames.System_IO_FileSystem_Primitives}",
+                contractName: $"{TypeName}, {CoreNames.System_IO_FileSystem}",
                 desktopName: TypeName);
 
             internal static readonly object CreateNew = Enum.ToObject(Type, 1);
@@ -269,7 +268,7 @@
             internal const string TypeName = "System.IO.FileAccess";
 
             internal static readonly Type Type = ReflectionUtilities.GetTypeFromEither(
-                contractName: $"{TypeName}, {CoreNames.System_IO_FileSystem_Primitives}",
+                contractName: $"{TypeName}, {CoreNames.System_CoreLib}",
                 desktopName: TypeName);
 
             internal static readonly object Read = Enum.ToObject(Type, 1);
@@ -284,7 +283,7 @@
             internal const string TypeName = "System.IO.FileShare";
 
             internal static readonly Type Type = ReflectionUtilities.GetTypeFromEither(
-                contractName: $"{TypeName}, {CoreNames.System_IO_FileSystem_Primitives}",
+                contractName: $"{TypeName}, {CoreNames.System_IO_FileSystem}",
                 desktopName: TypeName);
 
             internal static readonly object None = Enum.ToObject(Type, 0);
@@ -386,7 +385,7 @@
         {
             internal const string TypeName = "System.Diagnostics.FileVersionInfo";
 
-            internal static readonly string DesktopName = $"{TypeName}, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
+            internal static readonly string DesktopName = $"{TypeName}, System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
 
             internal static readonly Type Type = ReflectionUtilities.GetTypeFromEither(
                 contractName: $"{TypeName}, {CoreNames.System_Diagnostics_FileVersionInfo}",
