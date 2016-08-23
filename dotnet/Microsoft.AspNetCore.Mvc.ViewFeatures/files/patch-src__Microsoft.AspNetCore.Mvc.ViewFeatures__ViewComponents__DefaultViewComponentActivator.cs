--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentActivator.cs.orig	2016-08-16 22:39:11.315126000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentActivator.cs	2016-08-16 22:39:21.086059000 -0400
@@ -48,7 +48,7 @@
             
             if (componentType == null)
             {
-                throw new ArgumentException(Resources.FormatPropertyOfTypeCannotBeNull(
+                throw new ArgumentException(ViewFeatures.Resources.FormatPropertyOfTypeCannotBeNull(
                     nameof(context.ViewComponentDescriptor.TypeInfo),
                     nameof(context.ViewComponentDescriptor)));
             }
@@ -80,4 +80,4 @@
             }
         }
     }
-}
\ No newline at end of file
+}
