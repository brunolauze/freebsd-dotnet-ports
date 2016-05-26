--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentInvoker.cs.orig	2016-05-20 18:07:48.000000000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentInvoker.cs	2016-05-21 19:27:33.400611000 -0400
@@ -11,6 +11,7 @@
 using Microsoft.AspNetCore.Mvc.ViewFeatures;
 using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
 using Microsoft.Extensions.Logging;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc.ViewComponents
 {
@@ -77,7 +78,7 @@
 
             if (returnType == typeof(void) || returnType == typeof(Task))
             {
-                throw new InvalidOperationException(Resources.ViewComponent_MustReturnValue);
+                throw new InvalidOperationException(SR.ViewComponent_MustReturnValue);
             }
 
             IViewComponentResult result;
@@ -177,7 +178,7 @@
         {
             if (value == null)
             {
-                throw new InvalidOperationException(Resources.ViewComponent_MustReturnValue);
+                throw new InvalidOperationException(SR.ViewComponent_MustReturnValue);
             }
 
             var componentResult = value as IViewComponentResult;
@@ -198,10 +199,10 @@
                 return new HtmlContentViewComponentResult(htmlContent);
             }
 
-            throw new InvalidOperationException(Resources.FormatViewComponent_InvalidReturnValue(
+            throw new InvalidOperationException(SR.FormatViewComponent_InvalidReturnValue(
                 typeof(string).Name,
                 typeof(IHtmlContent).Name,
                 typeof(IViewComponentResult).Name));
         }
     }
-}
\ No newline at end of file
+}
