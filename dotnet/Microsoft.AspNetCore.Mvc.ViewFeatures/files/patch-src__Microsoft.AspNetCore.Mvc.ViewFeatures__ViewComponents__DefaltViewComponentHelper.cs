--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentHelper.cs.orig	2016-05-12 20:16:58.033061000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentHelper.cs	2016-05-12 20:17:33.241767000 -0400
@@ -10,6 +10,7 @@
 using Microsoft.AspNetCore.Mvc.ViewFeatures;
 using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
 using Microsoft.Extensions.Internal;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc.ViewComponents
 {
@@ -96,7 +97,7 @@
             var descriptor = _selector.SelectComponent(name);
             if (descriptor == null)
             {
-                throw new InvalidOperationException(Resources.FormatViewComponent_CannotFindComponent(name));
+                throw new InvalidOperationException(SR.FormatViewComponent_CannotFindComponent(name));
             }
 
             return InvokeCoreAsync(descriptor, arguments);
@@ -126,7 +127,7 @@
                 }
             }
 
-            throw new InvalidOperationException(Resources.FormatViewComponent_CannotFindComponent(
+            throw new InvalidOperationException(SR.FormatViewComponent_CannotFindComponent(
                 componentType.FullName));
         }
 
@@ -148,7 +149,7 @@
                 if (invoker == null)
                 {
                     throw new InvalidOperationException(
-                        Resources.FormatViewComponent_IViewComponentFactory_ReturnedNull(descriptor.FullName));
+                        SR.FormatViewComponent_IViewComponentFactory_ReturnedNull(descriptor.FullName));
                 }
 
                 await invoker.InvokeAsync(context);
