--- src/Workspaces/Core/Portable/Shared/Extensions/SymbolDisplayPartKindExtensions.cs.orig	2016-05-13 15:09:24.000000000 -0400
+++ src/Workspaces/Core/Portable/Shared/Extensions/SymbolDisplayPartKindExtensions.cs	2016-05-14 13:06:57.432651000 -0400
@@ -3,7 +3,11 @@
 using System;
 using System.Collections.Generic;
 using Microsoft.CodeAnalysis.Compilers;
+#if NETSTANDARD1_3
+using Microsoft.CodeAnalysis.Classification;
+#else
 using Microsoft.CodeAnalysis.Services.Classification;
+#endif
 using Microsoft.CodeAnalysis.Text;
 using Microsoft.CodeAnalysis.Utilities;
 
