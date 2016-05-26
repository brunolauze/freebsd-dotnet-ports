--- src/Shared/AsyncEnumerableExtensions.cs.orig	2016-05-25 22:46:56.256654000 -0400
+++ src/Shared/AsyncEnumerableExtensions.cs	2016-05-25 22:47:46.264425000 -0400
@@ -14,7 +14,9 @@
         public static IAsyncEnumerable<TResult> Select<TSource, TResult>(
             this IAsyncEnumerable<TSource> source,
             Func<TSource, CancellationToken, Task<TResult>> selector)
-            => new AsyncSelectEnumerable<TSource, TResult>(source, selector);
+        {
+		return new AsyncSelectEnumerable<TSource, TResult>(source, selector);
+	}
 
         private class AsyncSelectEnumerable<TSource, TResult> : IAsyncEnumerable<TResult>
         {
