--- src/mscorlib/src/System/Collections/Concurrent/ConcurrentQueue.cs.orig	2016-04-26 17:15:48.696046000 -0400
+++ src/mscorlib/src/System/Collections/Concurrent/ConcurrentQueue.cs	2016-04-26 17:16:01.178657000 -0400
@@ -40,7 +40,7 @@
     [DebuggerTypeProxy(typeof(SystemCollectionsConcurrent_ProducerConsumerCollectionDebugView<>))]
     [HostProtection(Synchronization = true, ExternalThreading = true)]
     [Serializable]
-    public class ConcurrentQueue<T> : IProducerConsumerCollection<T>, IReadOnlyCollection<T>
+    internal class ConcurrentQueue<T> : IProducerConsumerCollection<T>, IReadOnlyCollection<T>
     {
         //fields of ConcurrentQueue
         [NonSerialized]
