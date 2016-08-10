--- src/Compilers/CSharp/Portable/Compilation/SyntaxAndDeclarationManager.cs.orig	2016-07-29 16:38:04.000000000 -0400
+++ src/Compilers/CSharp/Portable/Compilation/SyntaxAndDeclarationManager.cs	2016-07-31 16:06:54.433799000 -0400
@@ -359,6 +359,7 @@
             out int totalReferencedTreeCount,
             out ImmutableArray<LoadDirective> oldLoadDirectives)
         {
+	    oldLoadDirectives = default(ImmutableArray<LoadDirective>);
             if (includeLoadedTrees && loadDirectiveMap.TryGetValue(oldTree, out oldLoadDirectives))
             {
                 Debug.Assert(!oldLoadDirectives.IsEmpty);
