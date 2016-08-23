--- src/pal/src/debug/debug.cpp.orig	2016-08-11 17:48:38.000000000 -0400
+++ src/pal/src/debug/debug.cpp	2016-08-11 22:40:37.211349000 -0400
@@ -74,6 +74,9 @@
 #define CTL_ATTACH      "attach"
 #define CTL_DETACH      "detach"
 #define CTL_WAIT        "wait"
+#if !PROCFS_MEM_NAME
+#define PROCFS_MEM_NAME "mem"
+#endif // !PROCFS_MEM_NAME
 #endif   // HAVE_PROCFS_CTL
 
 /* ------------------- Constant definitions ----------------------------------*/
