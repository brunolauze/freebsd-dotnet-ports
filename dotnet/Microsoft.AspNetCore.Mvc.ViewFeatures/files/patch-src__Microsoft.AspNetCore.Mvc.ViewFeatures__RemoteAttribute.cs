--- src/Microsoft.AspNetCore.Mvc.ViewFeatures/RemoteAttribute.cs.orig	2016-08-16 18:18:05.227438000 -0400
+++ src/Microsoft.AspNetCore.Mvc.ViewFeatures/RemoteAttribute.cs	2016-08-16 18:19:31.172705000 -0400
@@ -37,7 +37,7 @@
         /// Intended for subclasses that support URL generation with no route, action, or controller names.
         /// </remarks>
         protected RemoteAttribute()
-            : base(errorMessageAccessor: () => Resources.RemoteAttribute_RemoteValidationFailed)
+            : base(errorMessageAccessor: () => ViewFeatures.Resources.RemoteAttribute_RemoteValidationFailed)
         {
             RouteData = new RouteValueDictionary();
         }
@@ -160,7 +160,7 @@
         {
             if (string.IsNullOrEmpty(property))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(property));
+                throw new ArgumentException(ViewFeatures.Resources.ArgumentCannotBeNullOrEmpty, nameof(property));
             }
 
             var delimitedAdditionalFields = string.Join(",", _additionalFieldsSplit);
@@ -184,7 +184,7 @@
         {
             if (string.IsNullOrEmpty(property))
             {
-                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(property));
+                throw new ArgumentException(ViewFeatures.Resources.ArgumentCannotBeNullOrEmpty, nameof(property));
             }
 
             return "*." + property;
@@ -214,7 +214,7 @@
 
             if (url == null)
             {
-                throw new InvalidOperationException(Resources.RemoteAttribute_NoUrlFound);
+                throw new InvalidOperationException(ViewFeatures.Resources.RemoteAttribute_NoUrlFound);
             }
 
             return url;
