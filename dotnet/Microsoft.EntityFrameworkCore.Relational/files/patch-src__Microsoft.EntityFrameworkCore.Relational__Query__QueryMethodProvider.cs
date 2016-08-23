--- src/Microsoft.EntityFrameworkCore.Relational/Query/QueryMethodProvider.cs.orig	2016-08-17 18:36:01.867386000 -0400
+++ src/Microsoft.EntityFrameworkCore.Relational/Query/QueryMethodProvider.cs	2016-08-17 18:37:02.877617000 -0400
@@ -179,7 +179,7 @@
                 {
                     var currentKey = keySelector(sourceEnumerator.Current);
                     var element = elementSelector(sourceEnumerator.Current);
-                    var grouping = new Grouping<TKey, TElement>(currentKey) { element };
+                    var grouping = new Microsoft.EntityFrameworkCore.Query.Internal.Grouping<TKey, TElement>(currentKey) { element };
 
                     while (true)
                     {
