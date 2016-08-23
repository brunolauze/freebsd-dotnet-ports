--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentDescriptorProvider.cs.orig	2016-08-11 14:57:21.000000000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentDescriptorProvider.cs	2016-08-17 18:40:58.639985000 -0400
@@ -76,12 +76,12 @@
             if (methods.Length == 0)
             {
                 throw new InvalidOperationException(
-                    Resources.FormatViewComponent_CannotFindMethod(SyncMethodName, AsyncMethodName, componentName));
+                    ViewFeatures.Resources.FormatViewComponent_CannotFindMethod(SyncMethodName, AsyncMethodName, componentName));
             }
             else if (methods.Length > 1)
             {
                 throw new InvalidOperationException(
-                    Resources.FormatViewComponent_AmbiguousMethods(componentName, AsyncMethodName, SyncMethodName));
+                    ViewFeatures.Resources.FormatViewComponent_AmbiguousMethods(componentName, AsyncMethodName, SyncMethodName));
             }
 
             var selectedMethod = methods[0];
@@ -90,7 +90,7 @@
                 if (!selectedMethod.ReturnType.GetTypeInfo().IsGenericType ||
                     selectedMethod.ReturnType.GetGenericTypeDefinition() != typeof(Task<>))
                 {
-                    throw new InvalidOperationException(Resources.FormatViewComponent_AsyncMethod_ShouldReturnTask(
+                    throw new InvalidOperationException(ViewFeatures.Resources.FormatViewComponent_AsyncMethod_ShouldReturnTask(
                         AsyncMethodName,
                         componentName,
                         nameof(Task)));
@@ -101,13 +101,13 @@
                 // Will invoke synchronously. Method must not return void, Task or Task<T>.
                 if (selectedMethod.ReturnType == typeof(void))
                 {
-                    throw new InvalidOperationException(Resources.FormatViewComponent_SyncMethod_ShouldReturnValue(
+                    throw new InvalidOperationException(ViewFeatures.Resources.FormatViewComponent_SyncMethod_ShouldReturnValue(
                         SyncMethodName,
                         componentName));
                 }
                 else if (typeof(Task).IsAssignableFrom(selectedMethod.ReturnType))
                 {
-                    throw new InvalidOperationException(Resources.FormatViewComponent_SyncMethod_CannotReturnTask(
+                    throw new InvalidOperationException(ViewFeatures.Resources.FormatViewComponent_SyncMethod_CannotReturnTask(
                         SyncMethodName,
                         componentName,
                         nameof(Task)));
@@ -117,4 +117,4 @@
             return selectedMethod;
         }
     }
-}
\ No newline at end of file
+}
