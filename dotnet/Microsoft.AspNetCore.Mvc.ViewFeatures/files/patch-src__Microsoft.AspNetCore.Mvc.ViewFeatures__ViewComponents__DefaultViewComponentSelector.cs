--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentSelector.cs.orig	2016-08-17 17:11:43.930332000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentSelector.cs	2016-08-17 17:12:01.182314000 -0400
@@ -97,14 +97,14 @@
                     var matchedTypes = new List<string>();
                     foreach (var candidate in matches)
                     {
-                        matchedTypes.Add(Resources.FormatViewComponent_AmbiguousTypeMatch_Item(
+                        matchedTypes.Add(ViewFeatures.Resources.FormatViewComponent_AmbiguousTypeMatch_Item(
                             candidate.TypeInfo.FullName,
                             candidate.FullName));
                     }
 
                     var typeNames = string.Join(Environment.NewLine, matchedTypes);
                     throw new InvalidOperationException(
-                        Resources.FormatViewComponent_AmbiguousTypeMatch(name, Environment.NewLine, typeNames));
+                        ViewFeatures.Resources.FormatViewComponent_AmbiguousTypeMatch(name, Environment.NewLine, typeNames));
                 }
             }
         }
