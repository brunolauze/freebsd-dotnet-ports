--- src/System.Runtime.Extensions/src/System/IO/Path.Unix.cs.orig	2016-03-08 09:06:05.231352000 -0500
+++ src/System.Runtime.Extensions/src/System/IO/Path.Unix.cs	2016-03-08 09:06:21.324062000 -0500
@@ -8,7 +8,7 @@
 
 namespace System.IO
 {
-    public static partial class Path
+    internal static partial class Path
     {
         public static readonly char DirectorySeparatorChar = '/';
         public static readonly char VolumeSeparatorChar = '/';
