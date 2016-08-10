--- src/Compilers/Core/Portable/System/Reflection/Metadata/Ecma335/MetadataBuilder.Heaps.cs.orig	2016-07-31 09:27:55.598395000 -0400
+++ src/Compilers/Core/Portable/System/Reflection/Metadata/Ecma335/MetadataBuilder.Heaps.cs	2016-07-31 09:28:23.485033000 -0400
@@ -9,7 +9,7 @@
 
 #if SRM
 using System.Reflection.Internal;
-using BitArithmeticUtilities = System.Reflection.Internal.BitArithmetic;
+using BitArithmeticUtilities = Roslyn.Utilities.BitArithmeticUtilities;
 #else
 using System;
 using System.Reflection.Metadata.Ecma335;
