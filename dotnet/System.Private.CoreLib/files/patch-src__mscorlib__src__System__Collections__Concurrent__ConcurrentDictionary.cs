--- src/mscorlib/src/System/Collections/Concurrent/ConcurrentDictionary.cs.orig	2016-04-24 19:48:36.137923000 -0400
+++ src/mscorlib/src/System/Collections/Concurrent/ConcurrentDictionary.cs	2016-04-24 19:48:50.305721000 -0400
@@ -45,7 +45,7 @@
     [DebuggerTypeProxy(typeof(Mscorlib_DictionaryDebugView<,>))]
     [DebuggerDisplay("Count = {Count}")]
     [HostProtection(Synchronization = true, ExternalThreading = true)]
-    public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue>
+    internal class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue>
     {
         /// <summary>
         /// Tables that hold the internal state of the ConcurrentDictionary
