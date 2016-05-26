--- src/Compilers/Core/Portable/NativePdbWriter/ComMemoryStream.cs.orig	2016-01-20 15:22:05.631416000 -0500
+++ src/Compilers/Core/Portable/NativePdbWriter/ComMemoryStream.cs	2016-01-20 15:22:40.642814000 -0500
@@ -149,9 +149,9 @@
             _length = (int)libNewSize;
         }
 
-        void IUnsafeComStream.Stat(out STATSTG pstatstg, int grfStatFlag)
+        void IUnsafeComStream.Stat(out System.Runtime.InteropServices.STATSTG pstatstg, int grfStatFlag)
         {
-            pstatstg = new STATSTG()
+            pstatstg = new System.Runtime.InteropServices.STATSTG()
             {
                 cbSize = _length
             };
