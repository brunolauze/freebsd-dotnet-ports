--- src/System.Composition.Convention/src/System/Composition/Convention/PartConventionBuilder.cs.orig	2016-03-16 09:24:51.895283000 -0400
+++ src/System.Composition.Convention/src/System/Composition/Convention/PartConventionBuilder.cs	2016-03-16 09:26:00.398705000 -0400
@@ -541,8 +541,8 @@
             foreach (var ci in constructors)
             {
                 // We have a constructor configuration we must log a warning then not bother with ConstructorAttributes
-                IEnumerable<Attribute> attributes = ci.GetCustomAttributes(typeof(ImportingConstructorAttribute), false);
-                if (attributes.Count() != 0)
+                object[] attributes = ci.GetCustomAttributes(typeof(ImportingConstructorAttribute), false);
+                if (attributes.Length != 0)
                 {
                     CompositionTrace.Registration_ConstructorConventionOverridden(type);
                     return true;
