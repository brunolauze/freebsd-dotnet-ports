--- src/vm/exceptionhandling.cpp.orig	2016-03-07 08:09:13.585006000 -0500
+++ src/vm/exceptionhandling.cpp	2016-03-07 08:10:03.585872000 -0500
@@ -351,7 +351,7 @@
     }
 
     CONSISTENCY_CHECK(state.nFrames);
-    CONSISTENCY_CHECK(state.fFound);
+    // CONSISTENCY_CHECK(state.fFound);
     CONSISTENCY_CHECK(NULL != pHighestFrameWithRegisters);
 
     //
