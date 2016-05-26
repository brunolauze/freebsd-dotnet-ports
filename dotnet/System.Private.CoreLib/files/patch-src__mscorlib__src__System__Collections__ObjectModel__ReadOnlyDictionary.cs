--- src/mscorlib/src/System/Collections/ObjectModel/ReadOnlyDictionary.cs.orig	2016-05-01 10:05:35.382862000 -0400
+++ src/mscorlib/src/System/Collections/ObjectModel/ReadOnlyDictionary.cs	2016-05-01 10:05:47.055580000 -0400
@@ -22,7 +22,7 @@
     [Serializable]
     [DebuggerTypeProxy(typeof(Mscorlib_DictionaryDebugView<,>))]
     [DebuggerDisplay("Count = {Count}")]
-    public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue>
+    internal class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue>
     {
         private readonly IDictionary<TKey, TValue> m_dictionary;
         [NonSerialized]
