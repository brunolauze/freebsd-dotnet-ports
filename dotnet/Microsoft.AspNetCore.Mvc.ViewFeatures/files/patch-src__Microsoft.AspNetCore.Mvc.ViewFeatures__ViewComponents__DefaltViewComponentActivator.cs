--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentActivator.cs.orig	2016-05-03 15:29:33.000000000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentActivator.cs	2016-05-12 20:53:23.753477000 -0400
@@ -5,6 +5,7 @@
 using System.Reflection;
 using Microsoft.AspNetCore.Mvc.Internal;
 using Microsoft.AspNetCore.Mvc.ViewFeatures;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc.ViewComponents
 {
@@ -48,9 +49,9 @@
             
             if (componentType == null)
             {
-                throw new ArgumentException(Resources.FormatPropertyOfTypeCannotBeNull(
-                    nameof(context.ViewComponentDescriptor.TypeInfo),
-                    nameof(context.ViewComponentDescriptor)));
+                throw new ArgumentException(SR.FormatPropertyOfTypeCannotBeNull(
+                    "TypeInfo",
+                    "ViewComponentDescriptor"));
             }
 
             var viewComponent = _typeActivatorCache.CreateInstance<object>(
@@ -80,4 +81,4 @@
             }
         }
     }
-}
\ No newline at end of file
+}
