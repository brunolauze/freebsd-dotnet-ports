--- src/Common/src/System/Data/Locale/LocaleMapper.Unix.cs.orig	2016-04-27 21:10:08.089497000 -0400
+++ src/Common/src/System/Data/Locale/LocaleMapper.Unix.cs	2016-04-27 21:10:32.444491000 -0400
@@ -457,7 +457,7 @@
                 return value.LocaleName;
             }
 
-            throw new CultureNotFoundException(nameof(lcid), lcid.ToString(), message: null);
+            throw new CultureNotFoundException(nameof(lcid), lcid.ToString(), message: (string)null);
         }
 
         public static int LocaleNameToAnsiCodePage(string localeName)
