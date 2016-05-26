--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/Controller.cs.orig	2016-05-12 20:13:00.480624000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/Controller.cs	2016-05-12 20:13:39.730466000 -0400
@@ -9,6 +9,7 @@
 using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
 using Microsoft.Extensions.DependencyInjection;
 using Newtonsoft.Json;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc
 {
@@ -46,7 +47,7 @@
             {
                 if (value == null)
                 {
-                    throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(ViewData));
+                    throw new ArgumentException(SR.ArgumentCannotBeNullOrEmpty, nameof(ViewData));
                 }
 
                 _viewData = value;
