--- src/Compilers/Core/Portable/ReferenceManager/CommonReferenceManager.Resolution.cs.orig	2016-01-20 17:16:29.593791000 -0500
+++ src/Compilers/Core/Portable/ReferenceManager/CommonReferenceManager.Resolution.cs	2016-01-20 17:17:47.033128000 -0500
@@ -63,6 +63,8 @@
                 Debug.Assert(index >= 0);
                 _index = index + 1;
                 _kind = kind;
+		_aliasesOpt = new ImmutableArray<string>();
+		_recursiveAliasesOpt = new ImmutableArray<string>();
             }
 
             // initialized aliases
