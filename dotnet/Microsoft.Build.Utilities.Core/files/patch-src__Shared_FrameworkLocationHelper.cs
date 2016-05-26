--- src/Shared/FrameworkLocationHelper.cs.orig	2016-01-26 11:56:14.490033000 -0500
+++ src/Shared/FrameworkLocationHelper.cs	2016-01-26 11:56:52.552007000 -0500
@@ -633,8 +633,12 @@
             {
                 if (NativeMethodsShared.IsWindows)
                 {
+#if FEATURE_WIN32_REGISTRY
                     // If the registry entry is 1 then the framework is installed. Go ahead and find the directory. If it is not 1 then the framework is not installed, return null.
                     return String.Compare("1", FindRegistryValueUnderKey(registryEntryToCheckInstall, registryValueToCheckInstall), StringComparison.OrdinalIgnoreCase) == 0;
+#else
+		    return false;
+#endif
                 }
                 // False for non-windows since there is nothing in the registry
                 else
