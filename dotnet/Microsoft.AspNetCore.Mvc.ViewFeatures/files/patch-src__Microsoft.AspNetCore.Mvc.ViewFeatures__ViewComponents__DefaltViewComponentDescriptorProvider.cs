--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentDescriptorProvider.cs.orig	2016-05-12 20:19:41.662824000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentDescriptorProvider.cs	2016-05-12 20:20:24.543490000 -0400
@@ -8,6 +8,7 @@
 using System.Threading.Tasks;
 using Microsoft.AspNetCore.Mvc.ApplicationParts;
 using Microsoft.AspNetCore.Mvc.ViewFeatures;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc.ViewComponents
 {
@@ -76,12 +77,12 @@
             if (methods.Length == 0)
             {
                 throw new InvalidOperationException(
-                    Resources.FormatViewComponent_CannotFindMethod(SyncMethodName, AsyncMethodName, componentName));
+                    SR.FormatViewComponent_CannotFindMethod(SyncMethodName, AsyncMethodName, componentName));
             }
             else if (methods.Length > 1)
             {
                 throw new InvalidOperationException(
-                    Resources.FormatViewComponent_AmbiguousMethods(componentName, AsyncMethodName, SyncMethodName));
+                    SR.FormatViewComponent_AmbiguousMethods(componentName, AsyncMethodName, SyncMethodName));
             }
 
             var selectedMethod = methods[0];
@@ -90,7 +91,7 @@
                 if (!selectedMethod.ReturnType.GetTypeInfo().IsGenericType ||
                     selectedMethod.ReturnType.GetGenericTypeDefinition() != typeof(Task<>))
                 {
-                    throw new InvalidOperationException(Resources.FormatViewComponent_AsyncMethod_ShouldReturnTask(
+                    throw new InvalidOperationException(SR.FormatViewComponent_AsyncMethod_ShouldReturnTask(
                         AsyncMethodName,
                         componentName,
                         nameof(Task)));
@@ -101,13 +102,13 @@
                 // Will invoke synchronously. Method must not return void, Task or Task<T>.
                 if (selectedMethod.ReturnType == typeof(void))
                 {
-                    throw new InvalidOperationException(Resources.FormatViewComponent_SyncMethod_ShouldReturnValue(
+                    throw new InvalidOperationException(SR.FormatViewComponent_SyncMethod_ShouldReturnValue(
                         SyncMethodName,
                         componentName));
                 }
                 else if (typeof(Task).IsAssignableFrom(selectedMethod.ReturnType))
                 {
-                    throw new InvalidOperationException(Resources.FormatViewComponent_SyncMethod_CannotReturnTask(
+                    throw new InvalidOperationException(SR.FormatViewComponent_SyncMethod_CannotReturnTask(
                         SyncMethodName,
                         componentName,
                         nameof(Task)));
@@ -117,4 +118,4 @@
             return selectedMethod;
         }
     }
-}
\ No newline at end of file
+}
