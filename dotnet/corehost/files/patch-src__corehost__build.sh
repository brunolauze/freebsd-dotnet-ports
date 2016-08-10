--- build.sh.orig	2016-06-01 21:14:49.000000000 -0400
+++ build.sh	2016-06-01 21:24:46.477940000 -0400
@@ -120,11 +120,15 @@
 
 # __rid_plat is the base RID that corehost is shipped for, effectively, the name of the folder in "runtimes/{__rid_plat}/native/" inside the nupkgs.
 __rid_plat=
+if [ "$(uname -s)" == "FreeBSD" ]; then
+    __rid_plat=freebsd
+else
 if [ "$(uname -s)" == "Darwin" ]; then
     __rid_plat=osx.10.10
 else
     init_rid_plat
 fi
+fi
 
 if [ -z $__rid_plat ]; then
     echo "Unknown base rid (eg.: osx.10.10, ubuntu.14.04) being targeted"
