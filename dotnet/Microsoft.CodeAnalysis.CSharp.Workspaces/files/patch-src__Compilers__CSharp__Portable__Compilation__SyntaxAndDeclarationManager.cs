--- src/Compilers/CSharp/Portable/Compilation/SyntaxAndDeclarationManager.cs.orig	2016-01-21 01:51:04.000000000 -0500
+++ src/Compilers/CSharp/Portable/Compilation/SyntaxAndDeclarationManager.cs	2016-01-21 12:04:55.771627000 -0500
@@ -359,6 +359,7 @@
             out int totalReferencedTreeCount,
             out ImmutableArray<LoadDirective> oldLoadDirectives)
         {
+	    oldLoadDirectives = new  ImmutableArray<LoadDirective>();
             if (includeLoadedTrees && loadDirectiveMap.TryGetValue(oldTree, out oldLoadDirectives))
             {
                 Debug.Assert(!oldLoadDirectives.IsEmpty);
