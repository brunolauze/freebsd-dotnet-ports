--- src/System.Runtime.Extensions/src/System/BitConverter.cs.orig	2016-03-09 12:41:13.408739000 -0500
+++ src/System.Runtime.Extensions/src/System/BitConverter.cs	2016-03-09 12:41:23.978370000 -0500
@@ -12,7 +12,7 @@
     // converting an array of bytes to one of the base data 
     // types, as well as for converting a base data type to an
     // array of bytes.
-    public static class BitConverter
+    internal static class BitConverter
     {
         public static readonly bool IsLittleEndian = GetIsLittleEndian();
 
