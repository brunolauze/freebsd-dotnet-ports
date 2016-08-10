--- src/pal/src/debug/debug.cpp.orig	2016-05-29 12:38:07.000408000 -0400
+++ src/pal/src/debug/debug.cpp	2016-05-29 12:43:21.676105000 -0400
@@ -76,6 +76,11 @@
 #define CTL_WAIT        "wait"
 #endif   // HAVE_PROCFS_CTL
 
+#if !PROCFS_MEM_NAME
+#define PROCFS_MEM_NAME "mem"
+#endif
+
+
 /* ------------------- Constant definitions ----------------------------------*/
 
 #if !HAVE_VM_READ && !HAVE_PROCFS_CTL
