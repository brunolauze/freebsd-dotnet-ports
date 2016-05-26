--- src/XMakeTasks/ManifestUtil/SecurityUtil.cs.orig	2016-01-25 15:09:31.424152000 -0500
+++ src/XMakeTasks/ManifestUtil/SecurityUtil.cs	2016-01-25 15:11:39.075965000 -0500
@@ -396,7 +396,7 @@
                     }
                 }
             }
-            retSet = new ReadOnlyPermissionSet(retSetElement);
+            retSet = null; //new ReadOnlyPermissionSet(retSetElement);
             return retSet;
         }
 
@@ -538,7 +538,7 @@
             PermissionSet ps = new PermissionSet(PermissionState.None);
             try
             {
-                ps = new ReadOnlyPermissionSet(se);
+                ps = null; //new ReadOnlyPermissionSet(se);
             }
             catch (ArgumentException ex)
             {
