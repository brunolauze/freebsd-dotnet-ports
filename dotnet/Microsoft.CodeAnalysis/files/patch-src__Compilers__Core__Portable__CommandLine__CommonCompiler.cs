--- src/Compilers/Core/Portable/CommandLine/CommonCompiler.cs.orig	2016-07-26 18:22:28.000000000 -0400
+++ src/Compilers/Core/Portable/CommandLine/CommonCompiler.cs	2016-07-27 17:02:19.506676000 -0400
@@ -179,7 +179,7 @@
             }
             else
             {
-                diagnosticInfo = new DiagnosticInfo(messageProvider, messageProvider.ERR_NoSourceFile, filePath, e.Message);
+                diagnosticInfo = new DiagnosticInfo(messageProvider, messageProvider.ERR_NoSourceFile, filePath, $"{e.Message}\n{e.StackTrace}\n{e.InnerException?.Message}{e.InnerException?.StackTrace}");
             }
 
             return diagnosticInfo;
