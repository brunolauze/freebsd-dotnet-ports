--- src/Native/Unix/System.Native/pal_io.cpp.orig	2016-03-07 09:41:43.000000000 -0500
+++ src/Native/Unix/System.Native/pal_io.cpp	2016-03-07 12:56:35.142400000 -0500
@@ -6,7 +6,6 @@
 #include "pal_errno.h"
 #include "pal_io.h"
 #include "pal_utilities.h"
-
 #include <assert.h>
 #include <errno.h>
 #include <fcntl.h>
@@ -134,6 +133,9 @@
 static_assert(PAL_IN_ISDIR == IN_ISDIR, "");
 #endif
 
+ssize_t  getline(char ** __restrict, size_t * __restrict, FILE * __restrict);
+
+
 static void ConvertFileStatus(const struct stat_& src, FileStatus* dst)
 {
     dst->Flags = FILESTATUS_FLAGS_NONE;
