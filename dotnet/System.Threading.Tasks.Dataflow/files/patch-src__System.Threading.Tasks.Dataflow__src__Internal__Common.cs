--- src/System.Threading.Tasks.Dataflow/src/Internal/Common.cs.orig	2016-03-16 09:36:26.478603000 -0400
+++ src/System.Threading.Tasks.Dataflow/src/Internal/Common.cs	2016-03-16 09:37:48.807710000 -0400
@@ -77,7 +77,7 @@
 
             for (int c = ITERATION_LIMIT; c > 0; c--)
             {
-                if (!Thread.Yield())
+                if (!System.Threading.Tasks.Dataflow.Internal.Threading.Thread.Yield())
                 {
                     // There was no other thread waiting. 
                     // We may spend some more cycles to evaluate the predicate. 
