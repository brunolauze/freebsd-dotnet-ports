--- src/Native/Unix/System.Native/pal_errno.cpp.orig	2016-03-04 09:31:38.986589000 -0500
+++ src/Native/Unix/System.Native/pal_errno.cpp	2016-03-04 09:32:28.906118000 -0500
@@ -9,6 +9,11 @@
 #include <errno.h>
 #include <string.h>
 #include <assert.h>
+#include <cerrno>
+
+#ifndef ENODATA
+#define ENODATA 9919
+#endif
 
 extern "C" Error SystemNative_ConvertErrorPlatformToPal(int32_t platformErrno)
 {
