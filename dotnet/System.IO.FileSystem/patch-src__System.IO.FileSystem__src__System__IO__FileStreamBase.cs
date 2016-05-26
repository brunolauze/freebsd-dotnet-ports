--- src/System.IO.FileSystem/src/System/IO/FileStreamBase.cs.orig	2016-03-09 10:32:26.848046000 -0500
+++ src/System.IO.FileSystem/src/System/IO/FileStreamBase.cs	2016-03-09 10:32:40.440646000 -0500
@@ -23,7 +23,7 @@
 
         public abstract bool IsAsync { get; }
         public abstract string Name { get; }
-        public abstract SafeFileHandle SafeFileHandle { get; }
+        internal abstract SafeFileHandle SafeFileHandle { get; }
 
         public abstract void Flush(bool flushToDisk);
 
