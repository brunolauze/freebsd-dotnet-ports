--- src/Microsoft.EntityFrameworkCore.Relational/Query/AsyncQueryMethodProvider.cs.orig	2016-08-17 19:05:06.450464000 -0400
+++ src/Microsoft.EntityFrameworkCore.Relational/Query/AsyncQueryMethodProvider.cs	2016-08-17 19:05:44.600097000 -0400
@@ -235,7 +235,7 @@
                     {
                         var currentKey = _groupByAsyncEnumerable._keySelector(_sourceEnumerator.Current);
                         var element = _groupByAsyncEnumerable._elementSelector(_sourceEnumerator.Current);
-                        var grouping = new Grouping<TKey, TElement>(currentKey) { element };
+                        var grouping = new  Microsoft.EntityFrameworkCore.Query.Internal.Grouping<TKey, TElement>(currentKey) { element };
 
                         while (true)
                         {
@@ -895,4 +895,4 @@
             }
         }
     }
-}
\ No newline at end of file
+}
