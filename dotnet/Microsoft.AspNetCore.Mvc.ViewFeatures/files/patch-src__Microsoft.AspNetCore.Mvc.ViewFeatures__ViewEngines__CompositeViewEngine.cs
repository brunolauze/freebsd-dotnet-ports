--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewEngines/CompositeViewEngine.cs.orig	2016-08-16 22:33:13.075488000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewEngines/CompositeViewEngine.cs	2016-08-16 22:33:46.950621000 -0400
@@ -34,12 +34,12 @@
 
             if (string.IsNullOrEmpty(viewName))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(viewName));
+                throw new ArgumentException(ViewFeatures.Resources.ArgumentCannotBeNullOrEmpty, nameof(viewName));
             }
 
             if (ViewEngines.Count == 0)
             {
-                throw new InvalidOperationException(Resources.FormatViewEnginesAreRequired(
+                throw new InvalidOperationException(ViewFeatures.Resources.FormatViewEnginesAreRequired(
                     typeof(MvcViewOptions).FullName,
                     nameof(MvcViewOptions.ViewEngines),
                     typeof(IViewEngine).FullName));
@@ -82,12 +82,12 @@
         {
             if (string.IsNullOrEmpty(viewPath))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(viewPath));
+                throw new ArgumentException(ViewFeatures.Resources.ArgumentCannotBeNullOrEmpty, nameof(viewPath));
             }
 
             if (ViewEngines.Count == 0)
             {
-                throw new InvalidOperationException(Resources.FormatViewEnginesAreRequired(
+                throw new InvalidOperationException(ViewFeatures.Resources.FormatViewEnginesAreRequired(
                     typeof(MvcViewOptions).FullName,
                     nameof(MvcViewOptions.ViewEngines),
                     typeof(IViewEngine).FullName));
@@ -125,4 +125,4 @@
             return ViewEngineResult.NotFound(viewPath, searchedLocations ?? Enumerable.Empty<string>());
         }
     }
-}
\ No newline at end of file
+}
