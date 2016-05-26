--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewEngines/CompositeViewEngine.cs.orig	2016-05-12 20:11:20.120475000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewEngines/CompositeViewEngine.cs	2016-05-12 20:12:03.540643000 -0400
@@ -6,6 +6,7 @@
 using System.Linq;
 using Microsoft.AspNetCore.Mvc.ViewFeatures;
 using Microsoft.Extensions.Options;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc.ViewEngines
 {
@@ -34,7 +35,7 @@
 
             if (string.IsNullOrEmpty(viewName))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(viewName));
+                throw new ArgumentException(SR.ArgumentCannotBeNullOrEmpty, nameof(viewName));
             }
 
             // Do not allocate in the common cases: ViewEngines contains one entry or initial attempt is successful.
@@ -74,7 +75,7 @@
         {
             if (string.IsNullOrEmpty(viewPath))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(viewPath));
+                throw new ArgumentException(SR.ArgumentCannotBeNullOrEmpty, nameof(viewPath));
             }
 
             // Do not allocate in the common cases: ViewEngines contains one entry or initial attempt is successful.
@@ -109,4 +110,4 @@
             return ViewEngineResult.NotFound(viewPath, searchedLocations ?? Enumerable.Empty<string>());
         }
     }
-}
\ No newline at end of file
+}
