--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentHelper.cs.orig	2016-08-17 17:12:51.954111000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentHelper.cs	2016-08-17 17:13:11.454913000 -0400
@@ -96,7 +96,7 @@
             var descriptor = _selector.SelectComponent(name);
             if (descriptor == null)
             {
-                throw new InvalidOperationException(Resources.FormatViewComponent_CannotFindComponent(name));
+                throw new InvalidOperationException(ViewFeatures.Resources.FormatViewComponent_CannotFindComponent(name));
             }
 
             return InvokeCoreAsync(descriptor, arguments);
@@ -126,7 +126,7 @@
                 }
             }
 
-            throw new InvalidOperationException(Resources.FormatViewComponent_CannotFindComponent(
+            throw new InvalidOperationException(ViewFeatures.Resources.FormatViewComponent_CannotFindComponent(
                 componentType.FullName));
         }
 
@@ -148,7 +148,7 @@
                 if (invoker == null)
                 {
                     throw new InvalidOperationException(
-                        Resources.FormatViewComponent_IViewComponentFactory_ReturnedNull(descriptor.FullName));
+                        ViewFeatures.Resources.FormatViewComponent_IViewComponentFactory_ReturnedNull(descriptor.FullName));
                 }
 
                 await invoker.InvokeAsync(context);
