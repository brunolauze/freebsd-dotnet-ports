--- src/System.Runtime.Extensions/src/System/IO/Path.cs.orig	2016-03-08 09:04:59.540070000 -0500
+++ src/System.Runtime.Extensions/src/System/IO/Path.cs	2016-03-08 09:05:12.628740000 -0500
@@ -11,7 +11,7 @@
     // Provides methods for processing file system strings in a cross-platform manner.
     // Most of the methods don't do a complete parsing (such as examining a UNC hostname), 
     // but they will handle most string operations.  
-    public static partial class Path
+    internal static partial class Path
     {
         // Platform specific alternate directory separator character.  
         // There is only one directory separator char on Unix, which is the same
