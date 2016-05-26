--- build.sh.orig	2016-04-22 16:17:13.724864000 -0400
+++ build.sh	2016-04-22 16:18:22.227646000 -0400
@@ -104,11 +104,15 @@
 
 
 __rid_plat=
+if [ "$(uname -s)" == "FreeBSD" ]; then
+    __rid_plat=freebsd
+else
 if [ "$(uname -s)" == "Darwin" ]; then
     __rid_plat=osx.10.10
 else
     init_distro_name_and_rid
 fi
+fi
 
 if [ -z $__rid_plat ]; then
     echo "Unknown base rid (eg.: osx.10.10, ubuntu.14.04) being targeted"
