--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewEngines/ViewEngineResult.cs.orig	2016-08-16 22:38:21.229279000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewEngines/ViewEngineResult.cs	2016-08-16 22:38:34.675276000 -0400
@@ -91,7 +91,7 @@
                     locations += Environment.NewLine + string.Join(Environment.NewLine, SearchedLocations);
                 }
 
-                throw new InvalidOperationException(Resources.FormatViewEngine_ViewNotFound(ViewName, locations));
+                throw new InvalidOperationException(ViewFeatures.Resources.FormatViewEngine_ViewNotFound(ViewName, locations));
             }
 
             return this;
