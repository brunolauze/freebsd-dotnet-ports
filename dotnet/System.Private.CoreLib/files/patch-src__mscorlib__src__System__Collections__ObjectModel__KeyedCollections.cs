--- src/mscorlib/src/System/Collections/ObjectModel/KeyedCollection.cs.orig	2016-04-30 09:18:07.654292000 -0400
+++ src/mscorlib/src/System/Collections/ObjectModel/KeyedCollection.cs	2016-04-30 09:18:21.512259000 -0400
@@ -15,7 +15,7 @@
     [System.Runtime.InteropServices.ComVisible(false)]
     [DebuggerTypeProxy(typeof(Mscorlib_KeyedCollectionDebugView<,>))]
     [DebuggerDisplay("Count = {Count}")]        
-    public abstract class KeyedCollection<TKey,TItem>: Collection<TItem>
+    internal abstract class KeyedCollection<TKey,TItem>: Collection<TItem>
     {
         const int defaultThreshold = 0;
 
