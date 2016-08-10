--- src/Compilers/Core/Portable/System/Reflection/Metadata/Ecma335/MetadataBuilder.Tables.cs.orig	2016-07-30 13:04:50.120824000 -0400
+++ src/Compilers/Core/Portable/System/Reflection/Metadata/Ecma335/MetadataBuilder.Tables.cs	2016-07-30 13:05:08.419313000 -0400
@@ -12,6 +12,7 @@
 #if SRM
 using System.Reflection.Internal;
 #else
+using MetadataSizes = Microsoft.Cci.MetadataSizes;
 using Roslyn.Utilities;
 #endif
 
