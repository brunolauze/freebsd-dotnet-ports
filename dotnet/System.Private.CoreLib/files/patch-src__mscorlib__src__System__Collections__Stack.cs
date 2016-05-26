--- src/mscorlib/src/System/Collections/Stack.cs.orig	2016-04-24 19:51:27.013571000 -0400
+++ src/mscorlib/src/System/Collections/Stack.cs	2016-04-24 19:51:37.769154000 -0400
@@ -24,7 +24,7 @@
     [DebuggerDisplay("Count = {Count}")]
 [System.Runtime.InteropServices.ComVisible(true)]
     [Serializable]
-    public class Stack : ICollection, ICloneable {
+    internal class Stack : ICollection, ICloneable {
         private Object[] _array;     // Storage for stack elements
         [ContractPublicPropertyName("Count")]
         private int _size;           // Number of items in the stack.
