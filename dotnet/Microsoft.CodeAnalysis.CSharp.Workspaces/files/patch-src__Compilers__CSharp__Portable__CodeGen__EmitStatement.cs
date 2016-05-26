--- src/Compilers/CSharp/Portable/CodeGen/EmitStatement.cs.orig	2016-05-09 17:23:49.790489000 -0400
+++ src/Compilers/CSharp/Portable/CodeGen/EmitStatement.cs	2016-05-09 17:24:10.876850000 -0400
@@ -5,6 +5,7 @@
 using System.Collections.Immutable;
 using System.Diagnostics;
 using System.Linq;
+using System.Reflection.Metadata;
 using Microsoft.CodeAnalysis.CodeGen;
 using Microsoft.CodeAnalysis.CSharp.Symbols;
 using Microsoft.CodeAnalysis.CSharp.Syntax;
