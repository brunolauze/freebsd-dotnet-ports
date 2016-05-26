--- src/NuGet.Core/NuGet.CommandLine.XPlat/Utility/RuntimeEnvironmentExtensions.cs.orig	2016-05-15 08:47:05.066817000 -0400
+++ src/NuGet.Core/NuGet.CommandLine.XPlat/Utility/RuntimeEnvironmentExtensions.cs	2016-05-15 08:53:18.101955000 -0400
@@ -26,7 +26,7 @@
             }
         }
 
-        public static string GetRuntimeOsName(this IRuntimeEnvironment env)
+        public static string GetRuntimeOsName(this RuntimeEnvironment env)
         {
             string os = env.OperatingSystem ?? string.Empty;
             string ver = env.OperatingSystemVersion ?? string.Empty;
