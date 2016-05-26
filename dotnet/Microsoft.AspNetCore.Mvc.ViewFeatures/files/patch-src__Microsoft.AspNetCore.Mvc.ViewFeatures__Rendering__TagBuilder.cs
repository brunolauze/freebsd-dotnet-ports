--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/Rendering/TagBuilder.cs.orig	2016-05-12 17:32:01.658490000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/Rendering/TagBuilder.cs	2016-05-12 17:32:30.692569000 -0400
@@ -10,6 +10,7 @@
 using System.Text.Encodings.Web;
 using Microsoft.AspNetCore.Html;
 using Microsoft.AspNetCore.Mvc.ViewFeatures;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc.Rendering
 {
@@ -30,7 +31,7 @@
         {
             if (string.IsNullOrEmpty(tagName))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(tagName));
+                throw new ArgumentException(SR.ArgumentCannotBeNullOrEmpty, nameof(tagName));
             }
 
             TagName = tagName;
@@ -220,7 +221,7 @@
         {
             if (string.IsNullOrEmpty(key))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(key));
+                throw new ArgumentException(SR.ArgumentCannotBeNullOrEmpty, nameof(key));
             }
 
             if (replaceExisting || !Attributes.ContainsKey(key))
