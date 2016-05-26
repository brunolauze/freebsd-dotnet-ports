--- src/Compilers/Core/Portable/NativePdbWriter/IUnsafeComStream.cs.orig	2016-01-20 15:20:20.680549000 -0500
+++ src/Compilers/Core/Portable/NativePdbWriter/IUnsafeComStream.cs	2016-01-20 15:20:48.697482000 -0500
@@ -26,7 +26,7 @@
         void Revert();
         void LockRegion(long libOffset, long cb, int dwLockType);
         void UnlockRegion(long libOffset, long cb, int dwLockType);
-        void Stat(out STATSTG pstatstg, int grfStatFlag);
+        void Stat(out System.Runtime.InteropServices.STATSTG pstatstg, int grfStatFlag);
         void Clone(out IStream ppstm);
     }
 }
