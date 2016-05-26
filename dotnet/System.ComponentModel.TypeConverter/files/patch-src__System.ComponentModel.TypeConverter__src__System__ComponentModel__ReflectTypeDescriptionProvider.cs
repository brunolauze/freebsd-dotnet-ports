--- src/System.ComponentModel.TypeConverter/src/System/ComponentModel/ReflectTypeDescriptionProvider.cs.orig	2016-05-17 06:58:03.439291000 -0400
+++ src/System.ComponentModel.TypeConverter/src/System/ComponentModel/ReflectTypeDescriptionProvider.cs	2016-05-17 06:59:08.822055000 -0400
@@ -954,7 +954,7 @@
                 {
                     // Get the type's attributes.
                     //
-                    attrs = type.GetTypeInfo().GetCustomAttributes(typeof(Attribute), false).ToArray();
+                    attrs = type.GetTypeInfo().GetCustomAttributes(typeof(Attribute), false).Select(x => (Attribute)x).ToArray();
                     s_attributeCache[type] = attrs;
                 }
             }
@@ -992,7 +992,7 @@
                 {
                     // Get the member's attributes.
                     //
-                    attrs = member.GetCustomAttributes(typeof(Attribute), false).ToArray();
+                    attrs = member.GetCustomAttributes(typeof(Attribute), false).Select(x => (Attribute)x).ToArray();
                     s_attributeCache[member] = attrs;
                 }
             }
