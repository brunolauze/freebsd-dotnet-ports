--- src/Common/src/System/Data/Locale/Locale.cs.orig	2016-04-27 21:00:41.820329000 -0400
+++ src/Common/src/System/Data/Locale/Locale.cs	2016-04-27 21:03:22.215416000 -0400
@@ -30,7 +30,7 @@
         {
             if (lcid < 0)
             {
-                throw ADP.ArgumentOutOfRange(nameof(lcid));
+                throw ADP.ArgumentOutOfRange($"Parameter '{nameof(lcid)}' cannot be null", nameof(lcid));
             }
             return s_cachedEncodings.GetOrAdd(lcid, id => GetDetailsInternal(id));
         }
