--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentSelector.cs.orig	2016-05-12 20:15:35.607544000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/ViewComponents/DefaultViewComponentSelector.cs	2016-05-12 20:16:12.533493000 -0400
@@ -5,6 +5,7 @@
 using System.Collections.Generic;
 using System.Linq;
 using Microsoft.AspNetCore.Mvc.ViewFeatures;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc.ViewComponents
 {
@@ -97,14 +98,14 @@
                     var matchedTypes = new List<string>();
                     foreach (var candidate in matches)
                     {
-                        matchedTypes.Add(Resources.FormatViewComponent_AmbiguousTypeMatch_Item(
+                        matchedTypes.Add(SR.FormatViewComponent_AmbiguousTypeMatch_Item(
                             candidate.TypeInfo.FullName,
                             candidate.FullName));
                     }
 
                     var typeNames = string.Join(Environment.NewLine, matchedTypes);
                     throw new InvalidOperationException(
-                        Resources.FormatViewComponent_AmbiguousTypeMatch(name, Environment.NewLine, typeNames));
+                       	SR.FormatViewComponent_AmbiguousTypeMatch(name, Environment.NewLine, typeNames));
                 }
             }
         }
