--- src/Compilers/CSharp/Portable/Syntax/SyntaxExtensions.cs.orig	2016-08-06 01:05:45.000000000 -0400
+++ src/Compilers/CSharp/Portable/Syntax/SyntaxExtensions.cs	2016-08-06 20:41:05.988695000 -0400
@@ -423,7 +423,7 @@
         {
             Debug.Assert(identifier.Kind() == SyntaxKind.IdentifierToken || identifier.Kind() == SyntaxKind.None);
 
-            SyntaxNode parent;
+            SyntaxNode parent = null;
             if ((parent = identifier.Parent)?.Kind() == SyntaxKind.SingleVariableDesignation &&
                 (parent = parent.Parent)?.Kind() == SyntaxKind.TypedVariableComponent &&
                 (parent = parent.Parent)?.Kind() == SyntaxKind.DeclarationExpression)
