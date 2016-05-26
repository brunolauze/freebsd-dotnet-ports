--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/RemoteAttribute.cs.orig	2016-05-12 17:16:42.789338000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/RemoteAttribute.cs	2016-05-12 17:26:53.833371000 -0400
@@ -14,6 +14,7 @@
 using Microsoft.Extensions.DependencyInjection;
 using Microsoft.Extensions.Localization;
 using Microsoft.Extensions.Options;
+using SR = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources;
 
 namespace Microsoft.AspNetCore.Mvc
 {
@@ -37,7 +38,7 @@
         /// Intended for subclasses that support URL generation with no route, action, or controller names.
         /// </remarks>
         protected RemoteAttribute()
-            : base(errorMessageAccessor: () => Resources.RemoteAttribute_RemoteValidationFailed)
+            : base(errorMessageAccessor: () => SR.RemoteAttribute_RemoteValidationFailed)
         {
             RouteData = new RouteValueDictionary();
         }
@@ -160,7 +161,7 @@
         {
             if (string.IsNullOrEmpty(property))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(property));
+                throw new ArgumentException(SR.ArgumentCannotBeNullOrEmpty, nameof(property));
             }
 
             var delimitedAdditionalFields = string.Join(",", _additionalFieldsSplit);
@@ -184,7 +185,7 @@
         {
             if (string.IsNullOrEmpty(property))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(property));
+                throw new ArgumentException(SR.ArgumentCannotBeNullOrEmpty, nameof(property));
             }
 
             return "*." + property;
@@ -214,7 +215,7 @@
 
             if (url == null)
             {
-                throw new InvalidOperationException(Resources.RemoteAttribute_NoUrlFound);
+                throw new InvalidOperationException(SR.RemoteAttribute_NoUrlFound);
             }
 
             return url;
