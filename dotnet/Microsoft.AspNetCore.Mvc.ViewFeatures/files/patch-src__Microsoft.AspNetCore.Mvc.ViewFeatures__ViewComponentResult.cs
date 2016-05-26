--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponentResult.cs.orig	2016-05-12 17:30:47.414039000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponentResult.cs	2016-05-12 17:31:23.181002000 -0400
@@ -16,6 +16,7 @@
 using Microsoft.Extensions.DependencyInjection;
 using Microsoft.Extensions.Logging;
 using Microsoft.Extensions.Options;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc
 {
@@ -131,7 +132,7 @@
         {
             if (ViewComponentType == null && ViewComponentName == null)
             {
-                throw new InvalidOperationException(Resources.FormatViewComponentResult_NameOrTypeMustBeSet(
+                throw new InvalidOperationException(SR.FormatViewComponentResult_NameOrTypeMustBeSet(
                     nameof(ViewComponentName),
                     nameof(ViewComponentType)));
             }
