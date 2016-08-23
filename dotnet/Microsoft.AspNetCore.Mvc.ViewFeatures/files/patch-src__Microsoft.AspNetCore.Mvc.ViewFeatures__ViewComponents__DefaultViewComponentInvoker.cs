--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentInvoker.cs.orig	2016-08-16 22:36:32.632214000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentInvoker.cs	2016-08-16 22:36:50.540789000 -0400
@@ -77,7 +77,7 @@
 
             if (returnType == typeof(void) || returnType == typeof(Task))
             {
-                throw new InvalidOperationException(Resources.ViewComponent_MustReturnValue);
+                throw new InvalidOperationException(ViewFeatures.Resources.ViewComponent_MustReturnValue);
             }
 
             IViewComponentResult result;
@@ -177,7 +177,7 @@
         {
             if (value == null)
             {
-                throw new InvalidOperationException(Resources.ViewComponent_MustReturnValue);
+                throw new InvalidOperationException(ViewFeatures.Resources.ViewComponent_MustReturnValue);
             }
 
             var componentResult = value as IViewComponentResult;
@@ -198,10 +198,10 @@
                 return new HtmlContentViewComponentResult(htmlContent);
             }
 
-            throw new InvalidOperationException(Resources.FormatViewComponent_InvalidReturnValue(
+            throw new InvalidOperationException(ViewFeatures.Resources.FormatViewComponent_InvalidReturnValue(
                 typeof(string).Name,
                 typeof(IHtmlContent).Name,
                 typeof(IViewComponentResult).Name));
         }
     }
-}
\ No newline at end of file
+}
