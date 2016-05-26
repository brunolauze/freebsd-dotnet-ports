--- src/mscorlib/src/System/ICloneable.cs.orig	2016-04-26 17:18:17.603720000 -0400
+++ src/mscorlib/src/System/ICloneable.cs	2016-04-26 17:18:28.202817000 -0400
@@ -17,7 +17,7 @@
     // MemberwiseClone to support default clone operations.
     // 
     [System.Runtime.InteropServices.ComVisible(true)]
-    public interface ICloneable
+    internal interface ICloneable
     {
         // Interface does not need to be marked with the serializable attribute
         // Make a new object which is a copy of the object instanced.  This object may be either
