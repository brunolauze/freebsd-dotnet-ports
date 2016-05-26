--- src/XMakeTasks/TlbReference.cs.orig	2016-01-25 15:12:57.814214000 -0500
+++ src/XMakeTasks/TlbReference.cs	2016-01-25 15:13:35.284790000 -0500
@@ -264,7 +264,7 @@
                             flags |= TypeLibImporterFlags.ImportAsX86;
                             break;
                         case UtilitiesProcessorArchitecture.ARM:
-                            flags |= TypeLibImporterFlags.ImportAsArm;
+                            flags |= TypeLibImporterFlags.ImportAsAgnostic; //ImportAsArm is missing
                             break;
 
                         default:
