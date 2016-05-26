--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewEngines/ViewEngineResult.cs.orig	2016-05-12 20:51:42.610555000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewEngines/ViewEngineResult.cs	2016-05-12 20:52:12.499629000 -0400
@@ -5,6 +5,7 @@
 using System.Collections.Generic;
 using System.Linq;
 using Microsoft.AspNetCore.Mvc.ViewFeatures;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc.ViewEngines
 {
@@ -91,7 +92,7 @@
                     locations += Environment.NewLine + string.Join(Environment.NewLine, SearchedLocations);
                 }
 
-                throw new InvalidOperationException(Resources.FormatViewEngine_ViewNotFound(ViewName, locations));
+                throw new InvalidOperationException(SR.FormatViewEngine_ViewNotFound(ViewName, locations));
             }
 
             return this;
