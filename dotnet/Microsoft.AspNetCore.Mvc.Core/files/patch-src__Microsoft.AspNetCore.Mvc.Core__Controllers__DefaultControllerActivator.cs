--- src/Microsoft.AspNetCore.Mvc.Core/Controllers/DefaultControllerActivator.cs.orig	2016-05-10 21:00:59.115789000 -0400
+++ src/Microsoft.AspNetCore.Mvc.Core/Controllers/DefaultControllerActivator.cs	2016-05-10 21:01:50.600310000 -0400
@@ -50,8 +50,8 @@
             if (controllerTypeInfo == null)
             {
                 throw new ArgumentException(Resources.FormatPropertyOfTypeCannotBeNull(
-                    nameof(controllerContext.ActionDescriptor.ControllerTypeInfo),
-                    nameof(ControllerContext.ActionDescriptor)));
+                    "ControllerTypeInfo",
+                    "ActionDescriptor"));
             }
 
             var serviceProvider = controllerContext.HttpContext.RequestServices;
