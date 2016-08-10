--- src/vm/coreassemblyspec.cpp.orig	2016-08-06 10:11:11.897276000 -0400
+++ src/vm/coreassemblyspec.cpp	2016-08-06 10:15:21.563596000 -0400
@@ -666,15 +666,15 @@
 
     if (g_fAllowNativeImages)
     {
-        if (CompilationDomain::FindImage(W("mscorlib.ni.dll"), MDInternalImport_TrustedNativeImage, &pImage))
+        if (CompilationDomain::FindImage(W("System.Private.CoreLib.ni.dll"), MDInternalImport_TrustedNativeImage, &pImage))
             fNativeImage = TRUE;
     }
 
     if (!fNativeImage)
     {
-        if (!CompilationDomain::FindImage(W("mscorlib.dll"), MDInternalImport_Default, &pImage))
+        if (!CompilationDomain::FindImage(W("System.Private.CoreLib.dll"), MDInternalImport_Default, &pImage))
         {
-            EEFileLoadException::Throw(W("mscorlib.dll"), COR_E_FILENOTFOUND);
+            EEFileLoadException::Throw(W("System.Private.CoreLib.dll"), COR_E_FILENOTFOUND);
         }
     }
 
