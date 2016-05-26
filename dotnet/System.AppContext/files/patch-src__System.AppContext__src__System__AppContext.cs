--- src/System.AppContext/src/System/AppContext.cs.orig	2016-01-28 09:58:39.524592000 -0500
+++ src/System.AppContext/src/System/AppContext.cs	2016-01-28 10:00:33.570481000 -0500
@@ -3,7 +3,9 @@
 
 using System.Collections.Generic;
 using System.Threading;
+#if WIN32
 using Windows.ApplicationModel;
+#endif
 
 namespace System
 {
@@ -24,7 +26,11 @@
         {
             get
             {
+#if WIN32
                 return Package.Current.InstalledLocation.Path;
+#else
+		return ".";
+#endif
             }
         }
 
@@ -33,7 +39,7 @@
             get
             {
                 // We are currently hard coding this.
-                return ".NETCore,Version=v5.0";
+                return ".NETCore,Version=v1.0";
             }
         }
 
