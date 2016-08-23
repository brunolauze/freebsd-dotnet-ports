--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/Rendering/TagBuilder.cs.orig	2016-08-16 22:40:25.134115000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/Rendering/TagBuilder.cs	2016-08-16 22:40:48.052602000 -0400
@@ -30,7 +30,7 @@
         {
             if (string.IsNullOrEmpty(tagName))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(tagName));
+                throw new ArgumentException(ViewFeatures.Resources.ArgumentCannotBeNullOrEmpty, nameof(tagName));
             }
 
             TagName = tagName;
@@ -220,7 +220,7 @@
         {
             if (string.IsNullOrEmpty(key))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(key));
+                throw new ArgumentException(ViewFeatures.Resources.ArgumentCannotBeNullOrEmpty, nameof(key));
             }
 
             if (replaceExisting || !Attributes.ContainsKey(key))
