--- src/System.Xml.XDocument/src/System/Xml/Linq/XHashtable.cs.orig	2016-03-16 08:26:36.470684000 -0400
+++ src/System.Xml.XDocument/src/System/Xml/Linq/XHashtable.cs	2016-03-16 08:27:02.703093000 -0400
@@ -111,15 +111,10 @@
                     XHashtableState newState = _state.Resize();
 
                     // Use memory barrier to ensure that the resized XHashtableState object is fully constructed before it is assigned
-#if !SILVERLIGHT 
-                    Thread.MemoryBarrier();
-#else // SILVERLIGHT
                     // The MemoryBarrier method usage is probably incorrect and should be removed.
-
                     // Replacing with Interlocked.CompareExchange for now (with no effect)
                     //   which will do a very similar thing to MemoryBarrier (it's just slower)
                     System.Threading.Interlocked.CompareExchange<XHashtableState>(ref _state, null, null);
-#endif // SILVERLIGHT
                     _state = newState;
                 }
             }
@@ -302,15 +297,10 @@
 
                 // Ensure that all writes to the entry can't be reordered past this barrier (or other threads might see new entry
                 // in list before entry has been initialized!).
-#if !SILVERLIGHT
-                Thread.MemoryBarrier();
-#else // SILVERLIGHT
                 // The MemoryBarrier method usage is probably incorrect and should be removed.
-
                 // Replacing with Interlocked.CompareExchange for now (with no effect)
                 //   which will do a very similar thing to MemoryBarrier (it's just slower)
                 System.Threading.Interlocked.CompareExchange<Entry[]>(ref _entries, null, null);
-#endif // SILVERLIGHT
 
                 // Loop until a matching entry is found, a new entry is added, or linked list is found to be full
                 entryIndex = 0;
