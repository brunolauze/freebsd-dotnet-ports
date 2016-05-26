--- src/mscorlib/src/System/Globalization/IdnMapping.cs.orig	2016-04-26 19:36:04.164612000 -0400
+++ src/mscorlib/src/System/Globalization/IdnMapping.cs	2016-04-26 19:36:19.648448000 -0400
@@ -69,7 +69,7 @@
 
     // IdnMapping class used to map names to Punycode
 
-    public sealed class IdnMapping
+    internal sealed class IdnMapping
     {
         // Legal name lengths for domain names
         const int    M_labelLimit = 63;          // Not including dots
