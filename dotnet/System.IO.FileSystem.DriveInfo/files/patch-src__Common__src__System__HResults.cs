--- src/Common/src/System/HResults.cs.orig	2016-03-11 09:48:20.684892000 -0500
+++ src/Common/src/System/HResults.cs	2016-03-11 09:48:51.748980000 -0500
@@ -172,6 +172,7 @@
         internal const int ERROR_NOT_READY = unchecked((int)0x80070015);
         internal const int ERROR_OPEN_FAILED = unchecked((int)0x8007006E);
         internal const int ERROR_PATH_NOT_FOUND = unchecked((int)0x80070003);
+	internal const int ERROR_INVALID_DRIVE = 0xF;
         internal const int ERROR_SHARING_VIOLATION = unchecked((int)0x80070020);
         internal const int ERROR_TOO_MANY_OPEN_FILES = unchecked((int)0x80070004);
         internal const int ERROR_UNRECOGNIZED_VOLUME = unchecked((int)0x800703ED);
