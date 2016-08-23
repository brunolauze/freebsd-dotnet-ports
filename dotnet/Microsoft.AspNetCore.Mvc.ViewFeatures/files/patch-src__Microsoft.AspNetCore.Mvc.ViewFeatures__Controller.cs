--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/Controller.cs.orig	2016-08-16 22:34:30.004502000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/Controller.cs	2016-08-16 22:34:42.702957000 -0400
@@ -46,7 +46,7 @@
             {
                 if (value == null)
                 {
-                    throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(ViewData));
+                    throw new ArgumentException(ViewFeatures.Resources.ArgumentCannotBeNullOrEmpty, nameof(ViewData));
                 }
 
                 _viewData = value;
